Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class frmFacultyRegister

    Private Sub frmFacultyRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeUi()
        LoadDepartments()
        LoadGender()
    End Sub

    Private Sub InitializeUi()
        lblError.Text = ""
        dtpBirthDate.MaxDate = Date.Today
        dtpBirthDate.Value = New DateTime(Date.Today.Year - 28, 1, 1)
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
                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        cboDepartment.DisplayMember = "DepartmentName"
                        cboDepartment.ValueMember = "DepartmentID"
                        cboDepartment.DataSource = dt
                    End Using
                End Using
            End Using
            cboDepartment.SelectedIndex = -1
        Catch ex As Exception
            lblError.Text = "Error loading departments."
        End Try
    End Sub

    ' SHA256 password hashing
    Private Function HashPassword(raw As String) As String
        Dim bytes = Encoding.UTF8.GetBytes(raw)
        Dim hash = SHA256.HashData(bytes)
        Return BitConverter.ToString(hash).Replace("-", "").ToLower()
    End Function

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        lblError.Text = ""

        Dim lastName As String = txtLastName.Text.Trim()
        Dim firstName As String = txtFirstName.Text.Trim()
        Dim middleName As String = txtMiddleName.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim contactNumber As String = txtContactNumber.Text.Trim()
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text

        Dim gender As String = If(cboGender.SelectedIndex >= 0, cboGender.SelectedItem.ToString(), Nothing)
        Dim birthDate As Date = dtpBirthDate.Value

        Dim departmentId As Integer = -1
        If cboDepartment.SelectedIndex >= 0 AndAlso cboDepartment.SelectedValue IsNot Nothing Then
            Integer.TryParse(cboDepartment.SelectedValue.ToString(), departmentId)
        End If

        ' ==========================
        ' VALIDATION
        ' ==========================
        If String.IsNullOrWhiteSpace(lastName) Then
            ShowError("Last name is required.")
            txtLastName.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(firstName) Then
            ShowError("First name is required.")
            txtFirstName.Focus()
            Return
        End If

        If departmentId <= 0 Then
            ShowError("Please select a department.")
            cboDepartment.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(email) Then
            ShowError("Email is required.")
            txtEmail.Focus()
            Return
        End If

        If Not IsValidEmail(email) Then
            ShowError("Invalid email address.")
            txtEmail.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(password) Then
            ShowError("Password is required.")
            txtPassword.Focus()
            Return
        End If

        If password.Length < 6 Then
            ShowError("Password must be at least 6 characters.")
            txtPassword.Focus()
            Return
        End If

        If password <> confirmPassword Then
            ShowError("Passwords do not match.")
            txtConfirmPassword.Focus()
            Return
        End If

        ' Birthdate sanity (not mandatory in DB but we can limit)
        If birthDate > Date.Today Then
            ShowError("Birth date cannot be in the future.")
            dtpBirthDate.Focus()
            Return
        End If

        ' ==========================
        ' DB OPERATIONS
        ' ==========================
        Dim passwordHash As String = HashPassword(password)

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' Ensure email is unique
                Using cmdCheck As New MySqlCommand("
                    SELECT 
                        SUM(CASE WHEN Email = @Email THEN 1 ELSE 0 END) AS EmailExists
                    FROM faculty;", conn)

                    cmdCheck.Parameters.AddWithValue("@Email", email)

                    Using dr As MySqlDataReader = cmdCheck.ExecuteReader()
                        If dr.Read() Then
                            Dim emailExists As Integer = Convert.ToInt32(If(dr("EmailExists"), 0))
                            If emailExists > 0 Then
                                ShowError("This email is already registered.")
                                txtEmail.Focus()
                                Return
                            End If
                        End If
                    End Using
                End Using

                ' Generate EmployeeNumber & Username
                Dim newEmployeeNumber As String = GenerateEmployeeNumber(conn)
                Dim newUsername As String = GenerateUsername(conn, firstName, lastName)

                ' Insert row
                Using cmdInsert As New MySqlCommand("
                    INSERT INTO faculty
                        (EmployeeNumber,
                         FirstName,
                         LastName,
                         MiddleName,
                         Role,
                         Status,
                         ApprovedByFacultyID,
                         ApprovalDate,
                         PositionTitle,
                         Email,
                         ContactNumber,
                         Username,
                         PasswordHash,
                         DepartmentID,
                         IsEvaluator,
                         MaxActiveInternships,
                         IsActive,
                         CreatedAt,
                         UpdatedAt)
                    VALUES
                        (@EmployeeNumber,
                         @FirstName,
                         @LastName,
                         @MiddleName,
                         'Professor',
                         'Pending',
                         NULL,
                         NULL,
                         @PositionTitle,
                         @Email,
                         @ContactNumber,
                         @Username,
                         @PasswordHash,
                         @DepartmentID,
                         0,
                         0,
                         1,
                         NOW(),
                         NOW());", conn)

                    cmdInsert.Parameters.AddWithValue("@EmployeeNumber", newEmployeeNumber)
                    cmdInsert.Parameters.AddWithValue("@FirstName", firstName)
                    cmdInsert.Parameters.AddWithValue("@LastName", lastName)
                    cmdInsert.Parameters.AddWithValue("@MiddleName", If(String.IsNullOrWhiteSpace(middleName), DBNull.Value, middleName))
                    cmdInsert.Parameters.AddWithValue("@PositionTitle", "Professor")
                    cmdInsert.Parameters.AddWithValue("@Email", email)
                    cmdInsert.Parameters.AddWithValue("@ContactNumber", If(String.IsNullOrWhiteSpace(contactNumber), DBNull.Value, contactNumber))
                    cmdInsert.Parameters.AddWithValue("@Username", newUsername)
                    cmdInsert.Parameters.AddWithValue("@PasswordHash", passwordHash)
                    cmdInsert.Parameters.AddWithValue("@DepartmentID", departmentId)

                    Dim rows = cmdInsert.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show(Me,
                                        "Your faculty registration has been submitted for approval." &
                                        Environment.NewLine &
                                        "You will be able to login once an administrator activates your account.",
                                        "Registration Submitted",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information)

                        Dim login As New frmLoginFaculty()
                        login.Show()
                        Me.Close()
                    Else
                        ShowError("Registration failed. Please try again.")
                    End If
                End Using
            End Using

        Catch ex As MySqlException
            ShowError("Database error during registration.")
        Catch ex As Exception
            ShowError("Unexpected error during registration.")
        End Try
    End Sub

    Private Function GenerateEmployeeNumber(conn As MySqlConnection) As String
        ' Simple pattern: EMP-0001, EMP-0002, based on MAX(FacultyID)+1
        Using cmd As New MySqlCommand("SELECT IFNULL(MAX(FacultyID), 0) + 1 FROM faculty;", conn)
            Dim nextId As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return "EMP-" & nextId.ToString("D4")
        End Using
    End Function

    Private Function GenerateUsername(conn As MySqlConnection, firstName As String, lastName As String) As String
        Dim baseUser As String = ""
        If Not String.IsNullOrWhiteSpace(firstName) Then
            baseUser &= firstName.Substring(0, 1)
        End If
        baseUser &= lastName
        baseUser = baseUser.Replace(" ", "").ToLower()

        If baseUser = "" Then baseUser = "faculty"

        Dim candidate As String = baseUser
        Dim counter As Integer = 1

        While UsernameExists(conn, candidate)
            candidate = baseUser & counter.ToString()
            counter += 1
        End While

        Return candidate
    End Function

    Private Function UsernameExists(conn As MySqlConnection, username As String) As Boolean
        Using cmd As New MySqlCommand("SELECT COUNT(*) FROM faculty WHERE Username = @u;", conn)
            cmd.Parameters.AddWithValue("@u", username)
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0
        End Using
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        dtpBirthDate.Value = New DateTime(Date.Today.Year - 28, 1, 1)
        cboGender.SelectedIndex = -1

        cboDepartment.SelectedIndex = -1

        txtEmail.Clear()
        txtContactNumber.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        chkShowPassword.Checked = False

        lblError.Text = ""
        txtLastName.Focus()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        Dim visible As Boolean = chkShowPassword.Checked
        txtPassword.UseSystemPasswordChar = Not visible
        txtConfirmPassword.UseSystemPasswordChar = Not visible
    End Sub

    Private Sub lnkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLogin.LinkClicked
        Dim login As New frmLoginFaculty()
        login.Show()
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim login As New frmLoginFaculty()
        login.Show()
        Me.Close()
    End Sub

    Private Sub ShowError(msg As String)
        lblError.Text = msg
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then Return False
        Try
            Dim addr = New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

End Class
