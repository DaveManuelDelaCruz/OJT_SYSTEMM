Imports System.Data
Imports MySql.Data.MySqlClient

Public Class frmStudentRegister

    ' ============================================================
    ' FORM LOAD
    ' ============================================================
    Private Sub frmStudentRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeUi()
        LoadGender()
        LoadCourses()
    End Sub

    Private Sub InitializeUi()
        lblError.Text = ""
        dtpBirthDate.MaxDate = Date.Today
        dtpBirthDate.Value = New Date(Date.Today.Year - 20, 1, 1)
        txtDepartment.ReadOnly = True
    End Sub

    ' ============================================================
    ' GENDER LIST
    ' ============================================================
    Private Sub LoadGender()
        cboGender.Items.Clear()
        cboGender.Items.Add("Male")
        cboGender.Items.Add("Female")
        cboGender.Items.Add("Other")
        cboGender.SelectedIndex = -1
    End Sub

    ' ============================================================
    ' COURSES
    ' ============================================================
    Private Sub LoadCourses()
        cboCourse.DataSource = Nothing
        cboSection.DataSource = Nothing
        txtDepartment.Text = ""

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand("
                    SELECT c.CourseID, c.CourseName, d.DepartmentName
                    FROM course c
                    INNER JOIN department d ON d.DepartmentID = c.DepartmentID
                    WHERE c.IsActive = 1
                    ORDER BY c.CourseName;", conn)

                    conn.Open()
                    Dim dt As New DataTable()
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using

                    cboCourse.DisplayMember = "CourseName"
                    cboCourse.ValueMember = "CourseID"
                    cboCourse.DataSource = dt
                End Using
            End Using
            cboCourse.SelectedIndex = -1
        Catch
            ShowError("Error loading courses.")
        End Try
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourse.SelectedIndexChanged
        cboSection.DataSource = Nothing
        txtDepartment.Text = ""

        Dim drv As DataRowView = TryCast(cboCourse.SelectedItem, DataRowView)
        If drv IsNot Nothing Then
            txtDepartment.Text = drv("DepartmentName").ToString()
            LoadSectionsForCourse(CInt(drv("CourseID")))
        End If
    End Sub

    Private Sub LoadSectionsForCourse(courseId As Integer)
        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand("
                    SELECT SectionID, SectionName, MaxCapacity
                    FROM section
                    WHERE CourseID = @cid AND IsActive = 1
                    ORDER BY YearLevel, SectionName;", conn)

                    cmd.Parameters.AddWithValue("@cid", courseId)
                    conn.Open()

                    Dim dt As New DataTable()
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using

                    cboSection.DisplayMember = "SectionName"
                    cboSection.ValueMember = "SectionID"
                    cboSection.DataSource = dt
                End Using
            End Using
            cboSection.SelectedIndex = -1

        Catch
            ShowError("Error loading sections.")
        End Try
    End Sub

    ' ============================================================
    ' CAPACITY CHECK
    ' ============================================================
    Private Function IsSectionFull(sectionId As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim capacity As Integer = 0

                Using cmdCap As New MySqlCommand("
                    SELECT MaxCapacity FROM section WHERE SectionID = @sid", conn)

                    cmdCap.Parameters.AddWithValue("@sid", sectionId)
                    If cmdCap.ExecuteScalar() IsNot Nothing Then
                        capacity = Convert.ToInt32(cmdCap.ExecuteScalar())
                    End If
                End Using

                Using cmdCnt As New MySqlCommand("
                    SELECT COUNT(*) FROM student WHERE SectionID = @sid", conn)

                    cmdCnt.Parameters.AddWithValue("@sid", sectionId)
                    Dim count = Convert.ToInt32(cmdCnt.ExecuteScalar())
                    Return count >= capacity
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    ' ============================================================
    ' PROPER CASE + VALIDATION HELPERS
    ' ============================================================
    Private Function ToProperName(value As String) As String
        If String.IsNullOrWhiteSpace(value) Then Return value
        Dim parts = value.ToLower().Split(" "c)
        For i = 0 To parts.Length - 1
            If parts(i).Length > 0 Then
                parts(i) = Char.ToUpper(parts(i)(0)) & parts(i).Substring(1)
            End If
        Next
        Return String.Join(" ", parts)
    End Function

    Private Function IsValidNameField(value As String) As Boolean
        For Each ch In value
            If Not (Char.IsLetter(ch) Or ch = " "c Or ch = "'"c Or ch = "-"c) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub txtLastName_Leave(sender As Object, e As EventArgs) Handles txtLastName.Leave
        txtLastName.Text = ToProperName(txtLastName.Text.Trim())
    End Sub
    Private Sub txtFirstName_Leave(sender As Object, e As EventArgs) Handles txtFirstName.Leave
        txtFirstName.Text = ToProperName(txtFirstName.Text.Trim())
    End Sub
    Private Sub txtMiddleName_Leave(sender As Object, e As EventArgs) Handles txtMiddleName.Leave
        txtMiddleName.Text = ToProperName(txtMiddleName.Text.Trim())
    End Sub

    ' ============================================================
    ' REGISTER BUTTON
    ' ============================================================
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        lblError.Text = ""

        ' -------------------------------------
        ' COLLECT INPUTS
        ' -------------------------------------
        Dim studentNumber = txtStudentNumber.Text.Trim()
        Dim lastName = txtLastName.Text.Trim()
        Dim firstName = txtFirstName.Text.Trim()
        Dim middleName = txtMiddleName.Text.Trim()
        Dim gender As String = Nothing
        Dim birthDate = dtpBirthDate.Value
        Dim email = txtEmail.Text.Trim()
        Dim password = txtPassword.Text
        Dim confirmPassword = txtConfirmPassword.Text

        If cboGender.SelectedIndex >= 0 Then
            Select Case cboGender.SelectedItem.ToString()
                Case "Male" : gender = "M"
                Case "Female" : gender = "F"
                Case Else : gender = "Other"
            End Select
        End If

        Dim sectionId As Integer = If(cboSection.SelectedIndex >= 0, CInt(cboSection.SelectedValue), -1)

        ' -------------------------------------
        ' VALIDATION (FIXED WITH Exit Sub)
        ' -------------------------------------
        If studentNumber = "" Then ShowError("Student Number required.") : Exit Sub
        If lastName = "" Or Not IsValidNameField(lastName) Then ShowError("Invalid Last Name.") : Exit Sub
        If firstName = "" Or Not IsValidNameField(firstName) Then ShowError("Invalid First Name.") : Exit Sub
        If cboGender.SelectedIndex < 0 Then ShowError("Select Gender.") : Exit Sub
        If cboCourse.SelectedIndex < 0 Then ShowError("Select Course.") : Exit Sub
        If sectionId <= 0 Then ShowError("Select Section.") : Exit Sub
        If birthDate > Date.Today Then ShowError("Birth date cannot be future.") : Exit Sub
        If Not IsValidEmail(email) Then ShowError("Invalid email.") : Exit Sub
        If password.Length < 6 Then ShowError("Password must be at least 6 characters.") : Exit Sub
        If password <> confirmPassword Then ShowError("Passwords do not match.") : Exit Sub

        If IsSectionFull(sectionId) Then
            ShowError("Section is already full.")
            Exit Sub
        End If

        ' ============================================================
        ' DATABASE CHECKS
        ' ============================================================
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' Must exist in official list
                Using cmdOff As New MySqlCommand("
                    SELECT COUNT(*) FROM official_student_list WHERE StudentNumber=@sn", conn)

                    cmdOff.Parameters.AddWithValue("@sn", studentNumber)
                    If Convert.ToInt32(cmdOff.ExecuteScalar()) = 0 Then
                        ShowError("Student Number not found in official list.")
                        Exit Sub
                    End If
                End Using

                ' Check previous registration
                Using cmdPrev As New MySqlCommand("
                    SELECT AccountStatus 
                    FROM student 
                    WHERE StudentNumber=@sn 
                    ORDER BY StudentID DESC 
                    LIMIT 1;", conn)

                    cmdPrev.Parameters.AddWithValue("@sn", studentNumber)
                    Dim statusObj = cmdPrev.ExecuteScalar()

                    If statusObj IsNot Nothing Then
                        Dim status = statusObj.ToString()

                        Select Case status
                            Case "Pending"
                                ShowError("Your registration is still pending.")
                                Exit Sub

                            Case "Active"
                                ShowError("You already have an active student account.")
                                Exit Sub

                            Case "Inactive"
                                ShowError("Your previous account is inactive. Contact Registrar.")
                                Exit Sub

                            Case "Graduated"
                                ShowError("This student number is already graduated.")
                                Exit Sub

                            Case "Rejected"
                                ' ALLOWED TO REGISTER AGAIN
                        End Select
                    End If
                End Using

                ' ============================================================
                ' INSERT NEW REGISTRATION
                ' ============================================================
                Using cmd As New MySqlCommand("
                    INSERT INTO student
                        (StudentNumber, FirstName, LastName, MiddleName,
                         Gender, BirthDate, Email, Password,
                         SectionID, AccountStatus, CreatedAt, UpdatedAt)
                    VALUES
                        (@sn, @fn, @ln, @mn,
                         @g, @bd, @em, @pw,
                         @sid, 'Pending', NOW(), NOW());", conn)

                    cmd.Parameters.AddWithValue("@sn", studentNumber)
                    cmd.Parameters.AddWithValue("@fn", firstName)
                    cmd.Parameters.AddWithValue("@ln", lastName)
                    cmd.Parameters.AddWithValue("@mn", If(middleName = "", DBNull.Value, middleName))
                    cmd.Parameters.AddWithValue("@g", gender)
                    cmd.Parameters.AddWithValue("@bd", birthDate)
                    cmd.Parameters.AddWithValue("@em", email)
                    cmd.Parameters.AddWithValue("@pw", password)
                    cmd.Parameters.AddWithValue("@sid", sectionId)

                    cmd.ExecuteNonQuery()
                End Using

            End Using

            MessageBox.Show("Registration submitted. Please wait for approval.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim login As New frmLoginStudent()
            login.Show()
            Me.Close()

        Catch ex As Exception
            ShowError("Registration failed. Please try again.")
        End Try
    End Sub

    ' ============================================================
    ' HELPERS
    ' ============================================================
    Private Sub ShowError(message As String)
        lblError.Text = message
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim a = New System.Net.Mail.MailAddress(email)
            Return a.Address = email
        Catch
            Return False
        End Try
    End Function

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        Dim v = chkShowPassword.Checked
        txtPassword.UseSystemPasswordChar = Not v
        txtConfirmPassword.UseSystemPasswordChar = Not v
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim login As New frmLoginStudent()
        login.Show()
        Me.Close()
    End Sub
End Class
