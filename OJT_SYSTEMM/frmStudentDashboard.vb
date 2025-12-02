Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmStudentDashboard

    ' Path to final evaluation report (from internship.EvaluationReportPath)
    Private FinalReportPath As String = ""
    ' =====================================
    '  FIELDS FOR INTERNSHIP SELECTION
    ' =====================================
    Private InternshipsTable As DataTable
    Private SelectedInternshipID As Integer = 0
    Private HasShownNoInternshipMessage As Boolean = False
    Private HasShownNoVisitLogsMessage As Boolean = False


    ' ==========================
    ' FORM LOAD
    ' ==========================
    Private Sub FrmStudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' PREVENT dashboard loading without login
        If CurrentUser.StudentID Is Nothing OrElse CurrentUser.StudentID <= 0 Then
            MessageBox.Show("You must log in first.")
            Me.Close()
            frmStart.Show()
            Return
        End If

        ' Login info
        lblStudentName.Text = CurrentUser.Name
        lblStudentRole.Text = "Student"
        txtPassword.UseSystemPasswordChar = True
        txtConfirmPassword.UseSystemPasswordChar = True

        InitializeUI()
        ShowPanel(pnlStudentProfile)
        HighlightActive(btnStudentProfile)

        LoadStudentProfile()

        ' 🔥 Only this — because this will load all internship details automatically
        LoadStudentInternshipList()
    End Sub


    Private Function IsValidPhoneNumber(phone As String) As Boolean
        Dim digits As String = New String(phone.Where(AddressOf Char.IsDigit).ToArray())
        Return (digits.Length = 11 AndAlso digits.StartsWith("09"))
    End Function
    Private Sub txtContactNumber_TextChanged(sender As Object, e As EventArgs) Handles txtContactNumber.TextChanged
        Dim cursor As Integer = txtContactNumber.SelectionStart

        ' Keep digits only
        Dim digits As String = New String(txtContactNumber.Text.Where(AddressOf Char.IsDigit).ToArray())

        ' Ensure it starts with 09
        If digits.Length >= 1 AndAlso digits(0) <> "0"c Then
            digits = "0"
        End If

        If digits.Length >= 2 AndAlso digits.Substring(0, 2) <> "09" Then
            digits = "09"
        End If

        ' Limit to 11 digits
        If digits.Length > 11 Then
            digits = digits.Substring(0, 11)
        End If

        ' Update textbox safely
        If txtContactNumber.Text <> digits Then
            txtContactNumber.Text = digits
            txtContactNumber.SelectionStart = Math.Min(cursor, digits.Length)
        End If
    End Sub


    ' ==========================
    ' UI & NAVIGATION
    ' ==========================

    Private Sub InitializeUI()
        SetupVisitLogsGrid()
    End Sub

    Private Sub SetupVisitLogsGrid()
        dgvVisitLogs.Columns.Clear()

        Dim colDate As New DataGridViewTextBoxColumn With {
            .Name = "colVisitDate",
            .HeaderText = "Visit Date",
            .Width = 110
        }

        Dim colType As New DataGridViewTextBoxColumn With {
            .Name = "colVisitType",
            .HeaderText = "Visit Type",
            .Width = 120
        }

        Dim colScore As New DataGridViewTextBoxColumn With {
            .Name = "colScore",
            .HeaderText = "Score",
            .Width = 80
        }

        Dim colMax As New DataGridViewTextBoxColumn With {
            .Name = "colMaxScore",
            .HeaderText = "Max Score",
            .Width = 90
        }

        Dim colRemarks As New DataGridViewTextBoxColumn With {
            .Name = "colRemarks",
            .HeaderText = "Remarks",
            .Width = 380
        }

        Dim colAttachment As New DataGridViewTextBoxColumn With {
            .Name = "colAttachmentPath",
            .HeaderText = "AttachmentPath",
            .Visible = False
        }

        Dim colDownload As New DataGridViewButtonColumn With {
            .Name = "colDownload",
            .HeaderText = "DL",
            .Text = "🔽",
            .UseColumnTextForButtonValue = True,
            .Width = 60
        }

        dgvVisitLogs.Columns.AddRange(New DataGridViewColumn() {
            colDate, colType, colScore, colMax, colRemarks, colAttachment, colDownload
        })

        dgvVisitLogs.EnableHeadersVisualStyles = False
        dgvVisitLogs.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(76, 175, 80)
        dgvVisitLogs.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvVisitLogs.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 10, FontStyle.Bold)
        dgvVisitLogs.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvVisitLogs.ColumnHeadersDefaultCellStyle.Padding = New Padding(6)

        dgvVisitLogs.DefaultCellStyle.BackColor = Color.White
        dgvVisitLogs.DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33)
        dgvVisitLogs.DefaultCellStyle.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular)
        dgvVisitLogs.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 245, 233)
        dgvVisitLogs.DefaultCellStyle.SelectionForeColor = Color.FromArgb(27, 94, 32)
        dgvVisitLogs.DefaultCellStyle.Padding = New Padding(4)

        dgvVisitLogs.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250)

        dgvVisitLogs.ReadOnly = True
        dgvVisitLogs.AllowUserToAddRows = False
        dgvVisitLogs.AllowUserToDeleteRows = False
        dgvVisitLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVisitLogs.RowHeadersVisible = False
    End Sub

    Private Sub ShowPanel(panelToShow As Panel)
        pnlStudentProfile.Visible = False
        pnlInternshipDetails.Visible = False
        pnlVisitLogs.Visible = False
        pnlFinalGrade.Visible = False

        panelToShow.Visible = True
        panelToShow.BringToFront()
    End Sub

    Private Sub HighlightActive(activeButton As Button)
        Dim buttons() As Button = {
            btnStudentProfile,
            btnInternshipDetails,
            btnVisitLogs,
            btnFinalGrade
        }

        For Each btn In buttons
            btn.BackColor = Color.FromArgb(34, 51, 34)
            btn.ForeColor = Color.White
            btn.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
        Next

        activeButton.BackColor = Color.FromArgb(76, 175, 80)
        activeButton.ForeColor = Color.White
        activeButton.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
    End Sub


    ' Sidebar button events (PascalCase method names)
    Private Sub BtnStudentProfile_Click(sender As Object, e As EventArgs) Handles btnStudentProfile.Click
        HighlightActive(btnStudentProfile)
        ShowPanel(pnlStudentProfile)
        LoadStudentProfile()
    End Sub

    Private Sub BtnInternshipDetails_Click(sender As Object, e As EventArgs) Handles btnInternshipDetails.Click
        HighlightActive(btnInternshipDetails)
        ShowPanel(pnlInternshipDetails)
        LoadInternshipDetails(SelectedInternshipID)
    End Sub


    Private Sub BtnVisitLogs_Click(sender As Object, e As EventArgs) Handles btnVisitLogs.Click
        HighlightActive(btnVisitLogs)
        ShowPanel(pnlVisitLogs)
        LoadVisitLogs(SelectedInternshipID)
    End Sub


    Private Sub BtnFinalGrade_Click(sender As Object, e As EventArgs) Handles btnFinalGrade.Click
        HighlightActive(btnFinalGrade)
        ShowPanel(pnlFinalGrade)
        LoadFinalGrade(SelectedInternshipID)
    End Sub


    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show(
            "Are you sure you want to logout?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Try
                frmLoginStudent.Show()
            Catch
                ' ignore if login form not available
            End Try

            Me.Close()
        End If
    End Sub


    ' =====================================
    ' PART 1 – STUDENT PROFILE (VIEW/UPDATE)
    ' =====================================
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False
            txtConfirmPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
            txtConfirmPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BtnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        SetProfileEditingEnabled(True)
    End Sub

    Private Sub BtnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        If Not ValidateProfileInputs() Then Exit Sub

        SaveProfileChanges()

        MessageBox.Show("Profile updated successfully.",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        SetProfileEditingEnabled(False)
        LoadStudentProfile()
    End Sub

    Private Function ValidateProfileInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Email is required.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return False
        End If

        If Not IsValidEmail(txtEmail.Text.Trim()) Then
            MessageBox.Show("Please enter a valid email address.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtContactNumber.Text) Then
            MessageBox.Show("Contact number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContactNumber.Focus()
            Return False
        End If

        If Not IsValidPhoneNumber(txtContactNumber.Text.Trim()) Then
            MessageBox.Show("Please enter a valid contact number (digits only, 10–12 characters).",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning)
            txtContactNumber.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtAddress.Text) Then
            MessageBox.Show("Address is required.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtAddress.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCity.Text) Then
            MessageBox.Show("City is required.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtCity.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr = New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function

    Private Sub SaveProfileChanges()
        Dim updatePassword As Boolean = False

        ' Determine if user wants to update password
        If Not String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
       Not String.IsNullOrWhiteSpace(txtConfirmPassword.Text) Then

            ' Require both fields
            If txtPassword.Text.Trim() = "" OrElse txtConfirmPassword.Text.Trim() = "" Then
                MessageBox.Show("Please fill both Password and Confirm Password.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
                Return
            End If

            ' Must match
            If txtPassword.Text.Trim() <> txtConfirmPassword.Text.Trim() Then
                MessageBox.Show("Passwords do not match.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
                txtConfirmPassword.Focus()
                Return
            End If

            ' Length validation
            If txtPassword.Text.Trim().Length < 6 Then
                MessageBox.Show("Password must be at least 6 characters long.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
                txtPassword.Focus()
                Return
            End If

            updatePassword = True
        End If


        ' Build SQL
        Dim sql As String
        If updatePassword Then
            sql =
            "UPDATE student
             SET Email = @Email,
                 ContactNumber = @ContactNumber,
                 Address = @Address,
                 City = @City,
                 Password = @Password
             WHERE StudentID = @sid;"
        Else
            sql =
            "UPDATE student
             SET Email = @Email,
                 ContactNumber = @ContactNumber,
                 Address = @Address,
                 City = @City
             WHERE StudentID = @sid;"
        End If


        ' Execute update
        Try
            Using conn = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text.Trim())
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim())
                    cmd.Parameters.AddWithValue("@City", txtCity.Text.Trim())
                    cmd.Parameters.AddWithValue("@sid", CurrentUser.StudentID)

                    If updatePassword Then
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim())
                    End If

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Profile updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error saving profile: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LoadStudentProfile()
        Dim sql As String =
            "SELECT s.StudentNumber,
                    s.FirstName, s.LastName, s.MiddleName,
                    s.Gender, s.BirthDate, s.Status,
                    s.Email, s.ContactNumber, s.Address, s.City,
                    sec.SectionName,
                    c.CourseName,
                    d.DepartmentName
             FROM student s
             LEFT JOIN section sec ON s.SectionID = sec.SectionID
             LEFT JOIN course c ON sec.CourseID = c.CourseID
             LEFT JOIN department d ON c.DepartmentID = d.DepartmentID
             WHERE s.StudentID = @sid
             LIMIT 1;"

        Try
            Using conn = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@sid", CurrentUser.StudentID)

                    conn.Open()
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            txtStudentNumber.Text = SafeStr(dr("StudentNumber"))

                            Dim fullName As String =
                                String.Join(" ",
                                    New String() {
                                        SafeStr(dr("FirstName")),
                                        SafeStr(dr("MiddleName")),
                                        SafeStr(dr("LastName"))
                                    }).Replace("  ", " ").Trim()
                            txtFullName.Text = fullName

                            txtGender.Text = FormatGender(SafeStr(dr("Gender")))
                            txtBirthDate.Text = SafeDate(dr("BirthDate"))
                            txtStatus.Text = SafeStr(dr("Status"))

                            txtEmail.Text = SafeStr(dr("Email"))
                            txtContactNumber.Text = SafeStr(dr("ContactNumber"))
                            txtAddress.Text = SafeStr(dr("Address"))
                            txtCity.Text = SafeStr(dr("City"))

                            txtSectionName.Text = SafeStr(dr("SectionName"))
                            txtCourseName.Text = SafeStr(dr("CourseName"))
                            txtDepartmentName.Text = SafeStr(dr("DepartmentName"))
                        Else
                            MessageBox.Show("Student record not found.",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading student profile: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function FormatGender(g As String) As String
        Select Case g.Trim().ToUpperInvariant()
            Case "M", "MALE"
                Return "Male"
            Case "F", "FEMALE"
                Return "Female"
            Case "OTHER"
                Return "Other"
            Case Else
                Return ""
        End Select
    End Function


    ' =====================================
    ' PART 2–4 – INTERNSHIP DETAILS & HOURS
    ' =====================================

    ' =====================================
    '  MAIN INTERNSHIP LIST (ONE COMBOBOX)
    ' =====================================

    Private Sub LoadStudentInternshipList()
        InternshipsTable = New DataTable()
        Dim sql As String =
"SELECT 
    i.InternshipID,
    CONCAT(
        DATE_FORMAT(i.StartDate, '%b %Y'), ' • ',
        COALESCE(c.CompanyName, 'No Company'), ' • ',
        i.Status
    ) AS DisplayText
 FROM internship i
 LEFT JOIN companycontact cc ON i.SupervisorContactID = cc.ContactID
 LEFT JOIN company c        ON cc.CompanyID = c.CompanyID
 WHERE i.StudentID = @sid
 ORDER BY i.StartDate DESC, i.InternshipID DESC;"

        Try
            Using conn = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@sid", CurrentUser.StudentID)

                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(InternshipsTable)
                    End Using
                End Using
            End Using

            If InternshipsTable Is Nothing OrElse InternshipsTable.Rows.Count = 0 Then
                ' No internships yet
                cboSelectInternship.DataSource = Nothing
                cboSelectInternship.Items.Clear()
                cboSelectInternship.Text = "No internship yet"

                SelectedInternshipID = 0
                ClearInternshipPanels()
            Else
                cboSelectInternship.DataSource = InternshipsTable
                cboSelectInternship.DisplayMember = "DisplayText"
                cboSelectInternship.ValueMember = "InternshipID"
                cboSelectInternship.SelectedIndex = 0   ' triggers SelectedIndexChanged
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading internship list: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboSelectInternship.DataSource = Nothing
            ClearInternshipPanels()
        End Try
    End Sub

    Private Sub cboSelectInternship_SelectedIndexChanged(sender As Object, e As EventArgs) _
    Handles cboSelectInternship.SelectedIndexChanged

        If cboSelectInternship.SelectedValue Is Nothing Then
            SelectedInternshipID = 0
            ClearInternshipPanels()
            Return
        End If

        Dim iid As Integer
        If Not Integer.TryParse(cboSelectInternship.SelectedValue.ToString(), iid) Then
            SelectedInternshipID = 0
            ClearInternshipPanels()
            Return
        End If

        SelectedInternshipID = iid

        ' Update all 3 panels using the selected internship
        LoadInternshipDetails(SelectedInternshipID)
        LoadVisitLogs(SelectedInternshipID)
        LoadFinalGrade(SelectedInternshipID)
    End Sub

    Private Sub ClearInternshipPanels()
        ' Internship Details
        txtInternshipStatus.Text = "Not Assigned"
        txtCompanyName.Text = ""
        txtCompanyAddress.Text = ""
        txtCompanyCity.Text = ""
        txtIndustry.Text = ""
        txtSupervisorName.Text = ""
        txtSupervisorPosition.Text = ""
        txtSupervisorContact.Text = ""
        txtWorkDays.Text = ""
        txtStartTime.Text = ""
        txtEndTime.Text = ""
        txtRequiredHours.Text = ""
        txtCompletedHours.Text = ""
        progressHours.Value = 0

        ' Visit Logs
        dgvVisitLogs.Rows.Clear()
        dgvVisitLogs.Visible = False

        ' Final Grade
        txtFinalInternshipStatus.Text = "Not Assigned"
        lblFinalGradeValue.Text = "--"
        txtEvaluatedBy.Text = ""
        txtGradedAt.Text = ""
        FinalReportPath = ""
    End Sub

    ' =====================================
    '  INTERNSHIP DETAILS (BY INTERNSHIP ID)
    ' =====================================

    Private Sub LoadInternshipDetails(internshipID As Integer)
        If internshipID <= 0 Then
            ClearInternshipPanels()
            Return
        End If

        Dim sql As String =
        "SELECT i.InternshipID,
                i.Status,
                i.WorkDays,
                i.DailyStartTime,
                i.DailyEndTime,
                i.HoursCompleted,
                c.CompanyName,
                c.Address AS CompanyAddress,
                c.City    AS CompanyCity,
                c.Industry,
                cc.FirstName   AS SupFN,
                cc.LastName    AS SupLN,
                cc.PositionTitle,
                cc.ContactNumber AS SupContact,
                crs.RequiredOJTHours
         FROM internship i
         LEFT JOIN companycontact cc ON i.SupervisorContactID = cc.ContactID
         LEFT JOIN company c        ON cc.CompanyID = c.CompanyID
         LEFT JOIN student s        ON i.StudentID = s.StudentID
         LEFT JOIN section sec      ON s.SectionID = sec.SectionID
         LEFT JOIN course crs       ON sec.CourseID = crs.CourseID
         WHERE i.InternshipID = @iid
         LIMIT 1;"

        Try
            Using conn = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@iid", internshipID)

                    conn.Open()
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            txtInternshipStatus.Text = SafeStr(dr("Status"))

                            txtCompanyName.Text = SafeStr(dr("CompanyName"))
                            txtCompanyAddress.Text = SafeStr(dr("CompanyAddress"))
                            txtCompanyCity.Text = SafeStr(dr("CompanyCity"))
                            txtIndustry.Text = SafeStr(dr("Industry"))

                            Dim supName As String =
                            (SafeStr(dr("SupFN")) & " " & SafeStr(dr("SupLN"))).Trim()
                            txtSupervisorName.Text = supName
                            txtSupervisorPosition.Text = SafeStr(dr("PositionTitle"))
                            txtSupervisorContact.Text = SafeStr(dr("SupContact"))

                            txtWorkDays.Text = SafeStr(dr("WorkDays"))
                            txtStartTime.Text = SafeTime(dr("DailyStartTime"))
                            txtEndTime.Text = SafeTime(dr("DailyEndTime"))

                            Dim required As Integer = SafeInt(dr("RequiredOJTHours"))
                            Dim completed As Integer = SafeInt(dr("HoursCompleted"))

                            txtRequiredHours.Text = If(required > 0, required.ToString(), "")
                            txtCompletedHours.Text = If(completed > 0, completed.ToString(), "")

                            Dim percent As Integer = 0
                            If required > 0 Then
                                percent = CInt(Math.Round((completed / CDbl(required)) * 100))
                            End If
                            percent = Math.Max(0, Math.Min(100, percent))
                            progressHours.Value = percent
                        Else
                            ClearInternshipPanels()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading internship details: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearInternshipPanels()
        End Try
    End Sub

    ' =====================================
    '  VISIT LOGS (BY INTERNSHIP ID)
    ' =====================================

    Private Sub LoadVisitLogs(internshipID As Integer)
        dgvVisitLogs.Rows.Clear()

        If internshipID <= 0 Then
            dgvVisitLogs.Visible = False

            If Not HasShownNoInternshipMessage Then
                MessageBox.Show("You have no internship assigned yet.",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
                HasShownNoInternshipMessage = True
            End If

            Return
        End If

        Dim sql As String =
        "SELECT VisitDate, VisitType, Score, MaxScore, Remarks, AttachmentPath
         FROM visitlog
         WHERE InternshipID = @iid
         ORDER BY VisitDate ASC;"

        Try
            Using conn = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@iid", internshipID)

                    conn.Open()
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If Not dr.HasRows Then
                            dgvVisitLogs.Visible = False

                            If Not HasShownNoVisitLogsMessage Then
                                MessageBox.Show("No visit logs available for this internship.",
                                            "Information",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information)
                                HasShownNoVisitLogsMessage = True
                            End If

                            Return
                        End If

                        dgvVisitLogs.Visible = True

                        While dr.Read()
                            dgvVisitLogs.Rows.Add(
                            SafeDate(dr("VisitDate")),
                            SafeStr(dr("VisitType")),
                            SafeStr(dr("Score")),
                            SafeStr(dr("MaxScore")),
                            SafeStr(dr("Remarks")),
                            SafeStr(dr("AttachmentPath")),
                            "🔽"
                        )
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading visit logs: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvVisitLogs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) _
    Handles dgvVisitLogs.CellContentClick

        If e.RowIndex < 0 Then Return

        If dgvVisitLogs.Columns(e.ColumnIndex).Name = "colDownload" Then
            Dim attachmentPath As String =
            SafeStr(dgvVisitLogs.Rows(e.RowIndex).Cells("colAttachmentPath").Value)

            If String.IsNullOrWhiteSpace(attachmentPath) Then
                MessageBox.Show("No attachment available for this visit.",
                            "Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
                Return
            End If

            Try
                If File.Exists(attachmentPath) Then
                    Process.Start(New ProcessStartInfo(attachmentPath) With {
                    .UseShellExecute = True
                })
                Else
                    MessageBox.Show("Attachment file not found.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error opening file: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' =====================================
    '  FINAL GRADE (BY INTERNSHIP ID)
    ' =====================================

    Private Sub LoadFinalGrade(internshipID As Integer)
        If internshipID <= 0 Then
            txtFinalInternshipStatus.Text = "Not Assigned"
            lblFinalGradeValue.Text = "--"
            txtEvaluatedBy.Text = ""
            txtGradedAt.Text = ""
            FinalReportPath = ""
            Return
        End If

        Dim sql As String =
        "SELECT i.Status,
                i.FinalGrade,
                i.GradeDate,
                i.EvaluationReportPath,
                f.FirstName AS EvalFN,
                f.LastName  AS EvalLN
         FROM internship i
         LEFT JOIN faculty f ON i.GradedByFacultyID = f.FacultyID
         WHERE i.InternshipID = @iid
         LIMIT 1;"

        Try
            Using conn = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@iid", internshipID)

                    conn.Open()
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            txtFinalInternshipStatus.Text = SafeStr(dr("Status"))

                            Dim gradeText As String = SafeStr(dr("FinalGrade"))
                            lblFinalGradeValue.Text = If(String.IsNullOrWhiteSpace(gradeText), "--", gradeText)

                            Dim evaluator As String =
                            (SafeStr(dr("EvalFN")) & " " & SafeStr(dr("EvalLN"))).Trim()
                            txtEvaluatedBy.Text = evaluator

                            txtGradedAt.Text = SafeDate(dr("GradeDate"))
                            FinalReportPath = SafeStr(dr("EvaluationReportPath"))
                        Else
                            txtFinalInternshipStatus.Text = "In Progress"
                            lblFinalGradeValue.Text = "--"
                            txtEvaluatedBy.Text = ""
                            txtGradedAt.Text = ""
                            FinalReportPath = ""
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading final grade: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDownloadReport_Click(sender As Object, e As EventArgs) _
    Handles btnDownloadReport.Click

        If String.IsNullOrWhiteSpace(FinalReportPath) Then
            MessageBox.Show("No final evaluation report is available.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
            Return
        End If

        Try
            If File.Exists(FinalReportPath) Then
                Process.Start(New ProcessStartInfo(FinalReportPath) With {
                .UseShellExecute = True
            })
            Else
                MessageBox.Show("Report file not found.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to open report: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub



    ' =====================================
    ' NULL-SAFE HELPERS
    ' =====================================

    Private Function SafeInt(value As Object) As Integer
        If value Is Nothing OrElse value Is DBNull.Value Then
            Return 0
        End If

        Dim i As Integer
        If Integer.TryParse(value.ToString(), i) Then
            Return i
        End If
        Return 0
    End Function

    Private Function SafeTime(value As Object) As String
        If value Is Nothing OrElse value Is DBNull.Value Then
            Return ""
        End If

        Dim t As Date
        If Date.TryParse(value.ToString(), t) Then
            Return t.ToString("hh:mm tt")
        End If
        Return value.ToString()
    End Function

    Private Sub btnCancelEditProfile_Click(sender As Object, e As EventArgs) Handles btnCancelEditProfile.Click
        SetProfileEditingEnabled(False)
        LoadStudentProfile()  ' Restore original values
    End Sub

    ' ============================================
    ' UNIFIED EDIT MODE CONTROLLER
    ' ============================================
    Private Sub SetProfileEditingEnabled(enabled As Boolean)

        ' Editable fields
        txtEmail.ReadOnly = Not enabled
        txtContactNumber.ReadOnly = Not enabled
        txtAddress.ReadOnly = Not enabled
        txtCity.ReadOnly = Not enabled

        ' Optional password fields (future use)
        txtPassword.ReadOnly = Not enabled
        txtConfirmPassword.ReadOnly = Not enabled

        ' Highlight editable fields
        Dim editBack = Color.White
        Dim readBack = Color.FromArgb(245, 245, 245)

        Dim editableBoxes = {
            txtEmail, txtContactNumber, txtAddress,
            txtCity, txtPassword, txtConfirmPassword
        }

        For Each box In editableBoxes
            box.BackColor = If(enabled, editBack, readBack)
        Next

        ' Buttons visibility
        btnEditProfile.Visible = Not enabled
        btnSaveProfile.Visible = enabled
        btnCancelEditProfile.Visible = enabled

        ' NON-editable fields stay read-only
        txtStudentNumber.ReadOnly = True
        txtFullName.ReadOnly = True
        txtGender.ReadOnly = True
        txtBirthDate.ReadOnly = True
        txtStatus.ReadOnly = True
        txtSectionName.ReadOnly = True
        txtCourseName.ReadOnly = True
        txtDepartmentName.ReadOnly = True
    End Sub
End Class
