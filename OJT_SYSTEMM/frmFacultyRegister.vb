Imports MySql.Data.MySqlClient

Public Class frmFacultyRegister

    Private Sub frmFacultyRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeUi()
        LoadDepartments()
        LoadGender()
    End Sub

    Private Sub InitializeUi()
        lblError.Text = ""
        dtpBirthDate.MaxDate = Date.Today
        dtpBirthDate.Value = New Date(Date.Today.Year - 28, 1, 1)
        txtPosition.Text = "Professor"
        txtPosition.ReadOnly = True
    End Sub

    Private Sub LoadGender()
        cboGender.Items.Clear()
        cboGender.Items.Add("Male")
        cboGender.Items.Add("Female")
        cboGender.Items.Add("Other")
        cboGender.SelectedIndex = -1
    End Sub

    Private Sub LoadDepartments()
        cboDepartment.DataSource = Nothing
        cboDepartment.Items.Clear()

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand("
                    SELECT DepartmentID, DepartmentName
                    FROM department
                    WHERE IsActive = 1
                    ORDER BY DepartmentName;", conn)

                    conn.Open()
                    Dim dt As New DataTable()
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using

                    cboDepartment.DisplayMember = "DepartmentName"
                    cboDepartment.ValueMember = "DepartmentID"
                    cboDepartment.DataSource = dt
                End Using
            End Using
            cboDepartment.SelectedIndex = -1

        Catch
            lblError.Text = "Error loading departments."
        End Try
    End Sub

    '==============================================================
    '  VALIDATION HELPERS
    '==============================================================
    Private Function IsValidName(txt As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(txt, "^[A-Za-z\s\-]+$")
    End Function

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr = New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

    Private Function IsValidMobile(num As String) As Boolean
        Return num.Length = 11 AndAlso num.StartsWith("09") AndAlso num.All(AddressOf Char.IsDigit)
    End Function

    '==============================================================
    '  REGISTER BUTTON
    '==============================================================
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        lblError.Text = ""

        '===========================
        '  COLLECT INPUTS
        '===========================
        Dim empNum = txtEmployeeNumber.Text.Trim()
        Dim lastName = txtLastName.Text.Trim()
        Dim firstName = txtFirstName.Text.Trim()
        Dim middleName = txtMiddleName.Text.Trim()
        Dim email = txtEmail.Text.Trim()
        Dim contactNumber = txtContactNumber.Text.Trim()
        Dim password = txtPassword.Text
        Dim confirmPassword = txtConfirmPassword.Text
        Dim gender As String = If(cboGender.SelectedIndex >= 0, cboGender.SelectedItem.ToString(), Nothing)
        Dim birthDate = dtpBirthDate.Value

        Dim departmentId As Integer = -1
        If cboDepartment.SelectedIndex >= 0 Then Integer.TryParse(cboDepartment.SelectedValue.ToString(), departmentId)

        '===========================
        '  VALIDATIONS
        '===========================
        If empNum = "" Then ShowError("Employee number is required.") : Exit Sub
        If empNum.Contains(" ") Then ShowError("Employee number cannot contain spaces.") : Exit Sub

        If lastName = "" OrElse Not IsValidName(lastName) Then ShowError("Last name must contain letters only.") : Exit Sub
        If firstName = "" OrElse Not IsValidName(firstName) Then ShowError("First name must contain letters only.") : Exit Sub
        If middleName <> "" AndAlso Not IsValidName(middleName) Then ShowError("Middle name must contain letters only.") : Exit Sub

        If cboGender.SelectedIndex < 0 Then ShowError("Please select gender.") : Exit Sub
        If departmentId <= 0 Then ShowError("Please select a department.") : Exit Sub

        If Not IsValidEmail(email) Then ShowError("Invalid email.") : Exit Sub
        If Not IsValidMobile(contactNumber) Then ShowError("Invalid mobile number.") : Exit Sub

        If password.Length < 6 Then ShowError("Password must be at least 6 characters.") : Exit Sub
        If password <> confirmPassword Then ShowError("Passwords do not match.") : Exit Sub
        If birthDate > Date.Today Then ShowError("Birth date cannot be in the future.") : Exit Sub

        '==============================================================
        '  DATABASE CHECKS
        '==============================================================
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' Must exist in official_professor_list
                Using cmdOff As New MySqlCommand("
                    SELECT COUNT(*) FROM official_professor_list
                    WHERE EmployeeNumber = @num;", conn)

                    cmdOff.Parameters.AddWithValue("@num", empNum)

                    If Convert.ToInt32(cmdOff.ExecuteScalar()) = 0 Then
                        ShowError("Employee number not found in official professor list.")
                        Exit Sub
                    End If
                End Using

                ' Check previous registrations (RE-REGISTRATION LOGIC)
                Using cmdPrev As New MySqlCommand("
                    SELECT Status 
                    FROM faculty 
                    WHERE EmployeeNumber=@num
                    ORDER BY FacultyID DESC LIMIT 1;", conn)

                    cmdPrev.Parameters.AddWithValue("@num", empNum)
                    Dim statusObj = cmdPrev.ExecuteScalar()

                    If statusObj IsNot Nothing Then
                        Dim status = statusObj.ToString()

                        Select Case status
                            Case "Pending"
                                ShowError("Your registration is still pending.")
                                Exit Sub

                            Case "Active"
                                ShowError("You already have an active faculty account.")
                                Exit Sub

                            Case "Inactive"
                                ShowError("Your previous faculty account is inactive. Contact Registrar.")
                                Exit Sub

                            Case "Rejected"
                                ' ALLOWED TO REGISTER AGAIN
                        End Select
                    End If

                End Using

                ' Check email duplication
                Using cmdEmail As New MySqlCommand("
                    SELECT COUNT(*) FROM faculty WHERE Email=@em", conn)

                    cmdEmail.Parameters.AddWithValue("@em", email)

                    If Convert.ToInt32(cmdEmail.ExecuteScalar()) > 0 Then
                        ShowError("This email is already registered.")
                        Exit Sub
                    End If

                End Using

                '==============================================================
                '  INSERT NEW FACULTY RECORD
                '==============================================================
                Using cmdInsert As New MySqlCommand("
                    INSERT INTO faculty
                        (EmployeeNumber, FirstName, LastName, MiddleName,
                         Status, PositionTitle, Email, ContactNumber, Password,
                         DepartmentID, IsEvaluator, MaxActiveInternships,
                         IsActive, CreatedAt, UpdatedAt)
                    VALUES
                        (@EmployeeNumber, @FirstName, @LastName, @MiddleName,
                         'Pending', 'Professor', @Email, @ContactNumber, @Password,
                         @DepartmentID, 0, 0,
                         1, NOW(), NOW());", conn)

                    cmdInsert.Parameters.AddWithValue("@EmployeeNumber", empNum)
                    cmdInsert.Parameters.AddWithValue("@FirstName", firstName)
                    cmdInsert.Parameters.AddWithValue("@LastName", lastName)
                    cmdInsert.Parameters.AddWithValue("@MiddleName", If(middleName = "", DBNull.Value, middleName))
                    cmdInsert.Parameters.AddWithValue("@Email", email)
                    cmdInsert.Parameters.AddWithValue("@ContactNumber", contactNumber)
                    cmdInsert.Parameters.AddWithValue("@Password", password)
                    cmdInsert.Parameters.AddWithValue("@DepartmentID", departmentId)

                    cmdInsert.ExecuteNonQuery()
                End Using

            End Using

            MessageBox.Show("Your registration has been submitted for approval.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim login As New frmLoginFaculty()
            login.Show()
            Me.Close()

        Catch
            ShowError("Registration failed. Try again.")
        End Try

    End Sub

    '==============================================================
    '  CONTACT NUMBER FILTER
    '==============================================================
    Private Sub txtContactNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContactNumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.Handled = True
        If txtContactNumber.Text.Length = 0 AndAlso e.KeyChar <> "0"c Then e.Handled = True
        If txtContactNumber.Text.Length = 1 AndAlso e.KeyChar <> "9"c Then e.Handled = True
        If txtContactNumber.Text.Length >= 11 AndAlso Char.IsDigit(e.KeyChar) Then e.Handled = True
    End Sub

    Private Sub txtContactNumber_TextChanged(sender As Object, e As EventArgs) Handles txtContactNumber.TextChanged
        If txtContactNumber.Text = "" Then Exit Sub

        Dim cleaned = New String(txtContactNumber.Text.Where(Function(c) Char.IsDigit(c)).ToArray())
        If cleaned.Length = 1 AndAlso cleaned <> "0" Then cleaned = "0"
        If cleaned.Length >= 2 AndAlso cleaned.Substring(0, 2) <> "09" Then cleaned = "09" & cleaned.Substring(2)
        If cleaned.Length > 11 Then cleaned = cleaned.Substring(0, 11)

        If txtContactNumber.Text <> cleaned Then
            Dim pos = txtContactNumber.SelectionStart
            txtContactNumber.Text = cleaned
            txtContactNumber.SelectionStart = Math.Min(pos, cleaned.Length)
        End If
    End Sub

    '==============================================================
    '  OTHER BUTTONS
    '==============================================================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmployeeNumber.Clear()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtEmail.Clear()
        txtContactNumber.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        cboDepartment.SelectedIndex = -1
        cboGender.SelectedIndex = -1
        lblError.Text = ""
        txtEmployeeNumber.Focus()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        Dim v = chkShowPassword.Checked
        txtPassword.UseSystemPasswordChar = Not v
        txtConfirmPassword.UseSystemPasswordChar = Not v
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim login As New frmLoginFaculty()
        login.Show()
        Me.Close()
    End Sub

    Private Sub lnkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLogin.LinkClicked
        Dim login As New frmLoginFaculty()
        login.Show()
        Me.Close()
    End Sub

    Private Sub ShowError(msg As String)
        lblError.Text = msg
    End Sub

End Class
