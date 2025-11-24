Imports System.Data
Imports MySql.Data.MySqlClient

Public Class frmStudentRegister

    Private Sub frmStudentRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeUi()
        LoadGender()
        LoadCourses()
    End Sub

    Private Sub InitializeUi()
        lblError.Text = String.Empty

        ' Reasonable defaults for birthdate (prevent future dates)
        dtpBirthDate.MaxDate = DateTime.Today
        dtpBirthDate.Value = New DateTime(DateTime.Today.Year - 20, 1, 1) ' around 20 yrs old default

        txtDepartment.ReadOnly = True
    End Sub

    Private Sub LoadGender()
        cboGender.Items.Clear()
        cboGender.Items.Add("Male")
        cboGender.Items.Add("Female")
        cboGender.Items.Add("Other")
        cboGender.SelectedIndex = -1
    End Sub

    Private Sub LoadCourses()
        cboCourse.DataSource = Nothing
        cboCourse.Items.Clear()
        cboSection.DataSource = Nothing
        cboSection.Items.Clear()
        txtDepartment.Text = ""

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand("
                    SELECT c.CourseID,
                           c.CourseName,
                           d.DepartmentName
                    FROM course c
                    INNER JOIN department d ON d.DepartmentID = c.DepartmentID
                    WHERE c.IsActive = 1
                    ORDER BY c.CourseName;", conn)

                    conn.Open()
                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)

                        cboCourse.DisplayMember = "CourseName"
                        cboCourse.ValueMember = "CourseID"
                        cboCourse.DataSource = dt
                    End Using
                End Using
            End Using

            cboCourse.SelectedIndex = -1
        Catch ex As MySqlException
            ShowError("Database error loading courses.")
        Catch ex As Exception
            ShowError("Unexpected error loading courses.")
        End Try
    End Sub

    Private Sub cboCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCourse.SelectedIndexChanged
        txtDepartment.Text = ""
        cboSection.DataSource = Nothing
        cboSection.Items.Clear()

        Dim drv As DataRowView = TryCast(cboCourse.SelectedItem, DataRowView)
        If drv IsNot Nothing Then
            txtDepartment.Text = drv("DepartmentName").ToString()
            Dim courseId As Integer = CInt(drv("CourseID"))
            LoadSectionsForCourse(courseId)
        End If
    End Sub

    Private Sub LoadSectionsForCourse(courseId As Integer)
        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand("
                    SELECT SectionID,
                           SectionName,
                           MaxCapacity
                    FROM section
                    WHERE CourseID = @CourseID
                      AND IsActive = 1
                    ORDER BY YearLevel, SectionName;", conn)

                    cmd.Parameters.AddWithValue("@CourseID", courseId)
                    conn.Open()

                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)

                        cboSection.DisplayMember = "SectionName"
                        cboSection.ValueMember = "SectionID"
                        cboSection.DataSource = dt
                    End Using
                End Using
            End Using

            cboSection.SelectedIndex = -1
        Catch ex As MySqlException
            ShowError("Database error loading sections.")
        Catch ex As Exception
            ShowError("Unexpected error loading sections.")
        End Try
    End Sub

    Private Sub cboSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSection.SelectedIndexChanged
        If cboSection.SelectedIndex < 0 OrElse cboSection.SelectedValue Is Nothing Then
            Return
        End If

        Dim sectionId As Integer
        If Not Integer.TryParse(cboSection.SelectedValue.ToString(), sectionId) Then
            Return
        End If

        If IsSectionFull(sectionId) Then
            MessageBox.Show(Me,
                            "This section is already at maximum capacity. Please choose another section.",
                            "Section Full",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            cboSection.SelectedIndex = -1
        End If
    End Sub

    Private Function IsSectionFull(sectionId As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim capacity As Integer = 0

                ' Get section capacity
                Using cmdCap As New MySqlCommand("
                    SELECT MaxCapacity
                    FROM section
                    WHERE SectionID = @SectionID;", conn)

                    cmdCap.Parameters.AddWithValue("@SectionID", sectionId)
                    Dim obj = cmdCap.ExecuteScalar()
                    If obj Is Nothing OrElse obj Is DBNull.Value Then
                        Return False ' no capacity info, don't block
                    End If
                    capacity = Convert.ToInt32(obj)
                End Using

                ' Count students in that section (exclude Rejected)
                Using cmdCount As New MySqlCommand("
                    SELECT COUNT(*)
                    FROM student
                    WHERE SectionID = @SectionID
                      AND Status IN ('Pending','Active','OnLeave','Graduated','Dropped');", conn)

                    cmdCount.Parameters.AddWithValue("@SectionID", sectionId)
                    Dim count = Convert.ToInt32(cmdCount.ExecuteScalar())
                    Return count >= capacity
                End Using
            End Using
        Catch
            ' On any error, don't block registration by accident
            Return False
        End Try
    End Function

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        Dim visible As Boolean = chkShowPassword.Checked
        txtPassword.UseSystemPasswordChar = Not visible
        txtConfirmPassword.UseSystemPasswordChar = Not visible
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        lblError.Text = String.Empty

        ' ---- Gather inputs ----
        Dim studentNumber As String = txtStudentNumber.Text.Trim()
        Dim lastName As String = txtLastName.Text.Trim()
        Dim firstName As String = txtFirstName.Text.Trim()
        Dim middleName As String = txtMiddleName.Text.Trim()
        Dim birthDate As Date = dtpBirthDate.Value

        Dim genderValue As String = Nothing
        If cboGender.SelectedIndex >= 0 Then
            Select Case cboGender.SelectedItem.ToString()
                Case "Male"
                    genderValue = "M"
                Case "Female"
                    genderValue = "F"
                Case Else
                    genderValue = "Other"
            End Select
        End If

        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text
        Dim confirmPassword As String = txtConfirmPassword.Text

        Dim sectionId As Integer = -1
        If cboSection.SelectedIndex >= 0 AndAlso cboSection.SelectedValue IsNot Nothing Then
            Integer.TryParse(cboSection.SelectedValue.ToString(), sectionId)
        End If

        ' ---- Validation ----
        ' Required fields
        If String.IsNullOrWhiteSpace(studentNumber) Then
            ShowError("Student Number is required.")
            txtStudentNumber.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(lastName) Then
            ShowError("Last Name is required.")
            txtLastName.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(firstName) Then
            ShowError("First Name is required.")
            txtFirstName.Focus()
            Return
        End If

        If cboGender.SelectedIndex < 0 Then
            ShowError("Please select a gender.")
            cboGender.Focus()
            Return
        End If

        If cboCourse.SelectedIndex < 0 Then
            ShowError("Please select a course.")
            cboCourse.Focus()
            Return
        End If

        If sectionId <= 0 Then
            ShowError("Please select a section.")
            cboSection.Focus()
            Return
        End If

        If birthDate > Date.Today Then
            ShowError("Birth date cannot be in the future.")
            dtpBirthDate.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(email) Then
            ShowError("Email is required.")
            txtEmail.Focus()
            Return
        End If

        If Not IsValidEmail(email) Then
            ShowError("Please enter a valid email address.")
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
            ShowError("Password and Confirm Password do not match.")
            txtConfirmPassword.Focus()
            Return
        End If

        ' Check capacity again at registration time (race safety)
        If IsSectionFull(sectionId) Then
            ShowError("Selected section is already full. Please choose another section.")
            cboSection.Focus()
            Return
        End If

        ' ---- Hash password ----
        Dim passwordHash As String = HashPassword(password)

        ' ---- Insert into DB ----
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' First ensure StudentNumber + Email are unique
                Using cmdCheck As New MySqlCommand("
                    SELECT 
                        SUM(CASE WHEN StudentNumber = @StudentNumber THEN 1 ELSE 0 END) AS NumberExists,
                        SUM(CASE WHEN Email = @Email THEN 1 ELSE 0 END) AS EmailExists
                    FROM student;", conn)

                    cmdCheck.Parameters.AddWithValue("@StudentNumber", studentNumber)
                    cmdCheck.Parameters.AddWithValue("@Email", email)

                    Using dr As MySqlDataReader = cmdCheck.ExecuteReader()
                        If dr.Read() Then
                            Dim numExists As Integer = Convert.ToInt32(If(dr("NumberExists"), 0))
                            Dim emailExists As Integer = Convert.ToInt32(If(dr("EmailExists"), 0))

                            If numExists > 0 Then
                                ShowError("That Student Number is already registered.")
                                txtStudentNumber.Focus()
                                Return
                            End If

                            If emailExists > 0 Then
                                ShowError("That email address is already registered.")
                                txtEmail.Focus()
                                Return
                            End If
                        End If
                    End Using
                End Using

                ' Insert student as Pending
                Using cmdInsert As New MySqlCommand("
                    INSERT INTO student
                        (StudentNumber,
                         FirstName,
                         LastName,
                         MiddleName,
                         Gender,
                         BirthDate,
                         PasswordHash,
                         Email,
                         ContactNumber,
                         Address,
                         City,
                         SectionID,
                         Status,
                         ApprovedByFacultyID,
                         ApprovalDate,
                         CreatedAt,
                         UpdatedAt)
                    VALUES
                        (@StudentNumber,
                         @FirstName,
                         @LastName,
                         @MiddleName,
                         @Gender,
                         @BirthDate,
                         @PasswordHash,
                         @Email,
                         @ContactNumber,
                         @Address,
                         @City,
                         @SectionID,
                         'Pending',
                         NULL,
                         NULL,
                         NOW(),
                         NOW());", conn)

                    cmdInsert.Parameters.AddWithValue("@StudentNumber", studentNumber)
                    cmdInsert.Parameters.AddWithValue("@FirstName", firstName)
                    cmdInsert.Parameters.AddWithValue("@LastName", lastName)
                    cmdInsert.Parameters.AddWithValue("@MiddleName", If(String.IsNullOrWhiteSpace(middleName), DBNull.Value, middleName))
                    cmdInsert.Parameters.AddWithValue("@Gender", If(String.IsNullOrWhiteSpace(genderValue), DBNull.Value, genderValue))
                    cmdInsert.Parameters.AddWithValue("@BirthDate", birthDate.Date)
                    cmdInsert.Parameters.AddWithValue("@PasswordHash", passwordHash)
                    cmdInsert.Parameters.AddWithValue("@Email", email)
                    cmdInsert.Parameters.AddWithValue("@ContactNumber", DBNull.Value)
                    cmdInsert.Parameters.AddWithValue("@Address", DBNull.Value)
                    cmdInsert.Parameters.AddWithValue("@City", DBNull.Value)
                    cmdInsert.Parameters.AddWithValue("@SectionID", sectionId)

                    Dim rows As Integer = cmdInsert.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show(Me,
                                        "Your account has been submitted for approval." & Environment.NewLine &
                                        "You will be able to login once it has been activated.",
                                        "Registration Submitted",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information)

                        ' After successful registration, go back to Student Login
                        Try
                            Dim login As New frmLoginStudent()
                            login.Show()
                        Catch
                            ' ignore if form not available for some reason
                        End Try

                        Me.Close()
                    Else
                        ShowError("Registration failed. Please try again.")
                    End If
                End Using
            End Using

        Catch ex As MySqlException
            ShowError("Database error while saving your registration.")
        Catch ex As Exception
            ShowError("Unexpected error during registration.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStudentNumber.Clear()
        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        dtpBirthDate.Value = New DateTime(DateTime.Today.Year - 20, 1, 1)
        cboGender.SelectedIndex = -1

        cboCourse.SelectedIndex = -1
        txtDepartment.Text = ""
        cboSection.DataSource = Nothing
        cboSection.Items.Clear()

        txtEmail.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        chkShowPassword.Checked = False

        lblError.Text = ""
        txtStudentNumber.Focus()
    End Sub

    Private Sub lnkLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLogin.LinkClicked
        Try
            Dim login As New frmLoginStudent()
            login.Show()
        Catch
            ' ignore
        End Try

        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Back to Student Login
        Try
            Dim login As New frmLoginStudent()
            login.Show()
        Catch
            ' ignore
        End Try

        Me.Close()
    End Sub

    Private Sub ShowError(message As String)
        lblError.Text = message
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
