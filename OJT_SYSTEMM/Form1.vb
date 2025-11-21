Imports System.Drawing.Drawing2D

Public Class frmOpening

#Region "Form Load & Initialization"

    Private Sub frmOpening_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize form
        InitializeUI()
        LoadStudentData()
        ShowPanel(pnlStudentProfile)
    End Sub

    Private Sub InitializeUI()
        ' Set up circular avatar
        MakeCircularPictureBox(picUserAvatar)

        ' Set DataGridView styling
        StyleDataGridView()

        ' Disable Save button initially
        btnSaveProfile.Enabled = False

        ' Make all editable fields readonly initially
        SetEditMode(False)
    End Sub

    Private Sub MakeCircularPictureBox(pic As PictureBox)
        ' Create circular avatar shape
        Dim gp As New GraphicsPath()
        gp.AddEllipse(0, 0, pic.Width - 1, pic.Height - 1)
        pic.Region = New Region(gp)
    End Sub

    Private Sub StyleDataGridView()
        With dgvVisitLogs
            ' Header styling
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(76, 175, 80)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI Semibold", 10, FontStyle.Bold)
            .ColumnHeadersDefaultCellStyle.Padding = New Padding(8)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            ' Row styling
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.FromArgb(33, 33, 33)
            .DefaultCellStyle.Font = New Font("Segoe UI", 9.5F)
            .DefaultCellStyle.Padding = New Padding(8)
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 245, 233)
            .DefaultCellStyle.SelectionForeColor = Color.FromArgb(27, 94, 32)

            ' Alternating row colors
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250)

            ' Remove borders
            .CellBorderStyle = DataGridViewCellBorderStyle.None
            .EnableHeadersVisualStyles = False
        End With
    End Sub

#End Region

#Region "Navigation - Sidebar Button Events"

    Private Sub btnStudentProfile_Click(sender As Object, e As EventArgs) Handles btnStudentProfile.Click
        ShowPanel(pnlStudentProfile)
        UpdateActiveButton(btnStudentProfile)
    End Sub

    Private Sub btnInternshipDetails_Click(sender As Object, e As EventArgs) Handles btnInternshipDetails.Click
        ShowPanel(pnlInternshipDetails)
        UpdateActiveButton(btnInternshipDetails)
    End Sub

    Private Sub btnVisitLogs_Click(sender As Object, e As EventArgs) Handles btnVisitLogs.Click
        ShowPanel(pnlVisitLogs)
        UpdateActiveButton(btnVisitLogs)
    End Sub

    Private Sub btnFinalGrade_Click(sender As Object, e As EventArgs) Handles btnFinalGrade.Click
        ShowPanel(pnlFinalGrade)
        UpdateActiveButton(btnFinalGrade)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to logout?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            ' TODO: Clear session and redirect to login form
            ' frmLogin.Show()
            Me.Close()
        End If
    End Sub

#End Region

#Region "Panel Management"

    Private Sub ShowPanel(panelToShow As Panel)
        ' Hide all panels
        pnlStudentProfile.Visible = False
        pnlInternshipDetails.Visible = False
        pnlVisitLogs.Visible = False
        pnlFinalGrade.Visible = False

        ' Show requested panel
        panelToShow.Visible = True
        panelToShow.BringToFront()
    End Sub

    Private Sub UpdateActiveButton(activeButton As Button)
        ' Reset all sidebar buttons to inactive state
        ResetSidebarButton(btnStudentProfile)
        ResetSidebarButton(btnInternshipDetails)
        ResetSidebarButton(btnVisitLogs)
        ResetSidebarButton(btnFinalGrade)

        ' Set active button styling
        With activeButton
            .BackColor = Color.FromArgb(76, 175, 80)
            .ForeColor = Color.White
            .Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
        End With
    End Sub

    Private Sub ResetSidebarButton(btn As Button)
        With btn
            .BackColor = Color.FromArgb(34, 51, 34)
            .ForeColor = Color.FromArgb(220, 220, 220)
            .Font = New Font("Segoe UI", 10.5F, FontStyle.Regular)
        End With
    End Sub

#End Region

#Region "Student Profile - Edit Mode"

    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        SetEditMode(True)
        btnSaveProfile.Enabled = True
    End Sub

    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        ' Validate inputs
        If Not ValidateProfileInputs() Then
            Return
        End If

        ' TODO: Save to database
        SaveProfileChanges()

        ' Disable edit mode
        SetEditMode(False)
        btnSaveProfile.Enabled = False

        MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SetEditMode(isEditMode As Boolean)
        ' Only these fields are editable
        txtEmail.ReadOnly = Not isEditMode
        txtContactNumber.ReadOnly = Not isEditMode
        txtAddress.ReadOnly = Not isEditMode
        txtCity.ReadOnly = Not isEditMode

        ' Change background color to indicate editable fields
        If isEditMode Then
            txtEmail.BackColor = Color.White
            txtContactNumber.BackColor = Color.White
            txtAddress.BackColor = Color.White
            txtCity.BackColor = Color.White
        Else
            txtEmail.BackColor = Color.FromArgb(250, 250, 250)
            txtContactNumber.BackColor = Color.FromArgb(250, 250, 250)
            txtAddress.BackColor = Color.FromArgb(250, 250, 250)
            txtCity.BackColor = Color.FromArgb(250, 250, 250)
        End If
    End Sub

    Private Function ValidateProfileInputs() As Boolean
        ' Email validation
        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return False
        End If

        If Not IsValidEmail(txtEmail.Text) Then
            MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return False
        End If

        ' Contact number validation
        If String.IsNullOrWhiteSpace(txtContactNumber.Text) Then
            MessageBox.Show("Contact number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContactNumber.Focus()
            Return False
        End If

        ' Address validation
        If String.IsNullOrWhiteSpace(txtAddress.Text) Then
            MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAddress.Focus()
            Return False
        End If

        ' City validation
        If String.IsNullOrWhiteSpace(txtCity.Text) Then
            MessageBox.Show("City is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

#End Region

#Region "Data Loading Methods"

    Private Sub LoadStudentData()
        ' TODO: Load from database
        ' This is sample data

        ' User info in sidebar
        lblUsername.Text = "Juan Dela Cruz"
        lblUserRole.Text = "Student"

        ' Student Profile Panel
        txtStudentNumber.Text = "2021-00123"
        txtFullName.Text = "Juan Miguel Dela Cruz"
        txtGender.Text = "Male"
        txtBirthDate.Text = "January 15, 2001"
        txtStatus.Text = "Active"
        txtEmail.Text = "juan.delacruz@university.edu.ph"
        txtContactNumber.Text = "+63 912 345 6789"
        txtAddress.Text = "123 Main Street, Barangay San Jose"
        txtCity.Text = "Antipolo City"
        txtSectionName.Text = "BSIT 4-A"
        txtCourseName.Text = "Bachelor of Science in Information Technology"
        txtDepartmentName.Text = "College of Computer Studies"

        ' Internship Details Panel
        txtInternshipStatus.Text = "Active - In Progress"
        txtCompanyName.Text = "Tech Solutions Inc."
        txtCompanyAddress.Text = "456 Business Park Avenue, BGC"
        txtCompanyCity.Text = "Taguig City"
        txtIndustry.Text = "Information Technology & Services"
        txtSupervisorName.Text = "Maria Santos"
        txtSupervisorPosition.Text = "IT Department Manager"
        txtSupervisorContact.Text = "+63 917 123 4567"
        txtWorkDays.Text = "Monday to Friday"
        txtStartTime.Text = "8:00 AM"
        txtEndTime.Text = "5:00 PM"
        txtRequiredHours.Text = "500 hours"
        txtCompletedHours.Text = "375 hours"

        ' Update progress bar
        UpdateProgressBar(375, 500)

        ' Visit Logs Panel
        txtVisitInternshipID.Text = "INT-2024-00123"
        LoadVisitLogsData()

        ' Final Grade Panel
        txtFinalInternshipStatus.Text = "Completed"
        lblFinalGradeValue.Text = "95.00"
        txtEvaluatedBy.Text = "Prof. Maria Lopez"
        txtGradedAt.Text = "May 30, 2025"
    End Sub

    Private Sub UpdateProgressBar(completed As Integer, required As Integer)
        Dim percentage As Integer = CInt((completed / required) * 100)
        progressOJTHours.Value = Math.Min(percentage, 100)
        lblProgressPercentage.Text = $"{percentage}% Complete ({completed}/{required} hours)"
    End Sub

    Private Sub LoadVisitLogsData()
        ' TODO: Load from database
        ' Sample data
        dgvVisitLogs.Rows.Clear()
        dgvVisitLogs.Rows.Add("February 10, 2025", "Initial Visit", "85", "100", "Good start, proper documentation")
        dgvVisitLogs.Rows.Add("March 15, 2025", "Midterm Visit", "90", "100", "Excellent progress, on track")
        dgvVisitLogs.Rows.Add("April 20, 2025", "Final Visit", "92", "100", "Outstanding performance")
    End Sub

    Private Sub SaveProfileChanges()
        ' TODO: Implement database save logic
        ' Example:
        ' Using conn As New SqlConnection(connectionString)
        '     Using cmd As New SqlCommand("UPDATE Students SET Email = @Email, ContactNumber = @ContactNumber, Address = @Address, City = @City WHERE StudentNumber = @StudentNumber", conn)
        '         cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
        '         cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text)
        '         cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
        '         cmd.Parameters.AddWithValue("@City", txtCity.Text)
        '         cmd.Parameters.AddWithValue("@StudentNumber", txtStudentNumber.Text)
        '         conn.Open()
        '         cmd.ExecuteNonQuery()
        '     End Using
        ' End Using
    End Sub

#End Region

#Region "DataGridView Events"

    Private Sub dgvVisitLogs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVisitLogs.CellContentClick
        ' Handle download button click
        If e.ColumnIndex = dgvVisitLogs.Columns("colDownload").Index AndAlso e.RowIndex >= 0 Then
            Dim visitDate As String = dgvVisitLogs.Rows(e.RowIndex).Cells("colVisitDate").Value.ToString()
            MessageBox.Show($"Downloading attachment for visit on {visitDate}...", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' TODO: Implement actual download logic
        End If
    End Sub

#End Region

#Region "Final Grade Panel Events"

    Private Sub btnDownloadReport_Click(sender As Object, e As EventArgs) Handles btnDownloadReport.Click
        MessageBox.Show("Downloading Final Evaluation Report...", "Download", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' TODO: Implement actual download logic
    End Sub

#End Region

#Region "Hover Effects for Buttons"

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles btnStudentProfile.MouseEnter, btnInternshipDetails.MouseEnter, btnVisitLogs.MouseEnter, btnFinalGrade.MouseEnter
        Dim btn As Button = DirectCast(sender, Button)
        If btn.BackColor <> Color.FromArgb(76, 175, 80) Then ' If not active
            btn.BackColor = Color.FromArgb(45, 66, 45)
        End If
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles btnStudentProfile.MouseLeave, btnInternshipDetails.MouseLeave, btnVisitLogs.MouseLeave, btnFinalGrade.MouseLeave
        Dim btn As Button = DirectCast(sender, Button)
        If btn.BackColor <> Color.FromArgb(76, 175, 80) Then ' If not active
            btn.BackColor = Color.FromArgb(34, 51, 34)
        End If
    End Sub

    Private Sub btnEditProfile_MouseEnter(sender As Object, e As EventArgs) Handles btnEditProfile.MouseEnter
        btnEditProfile.BackColor = Color.FromArgb(255, 245, 157)
    End Sub

    Private Sub btnEditProfile_MouseLeave(sender As Object, e As EventArgs) Handles btnEditProfile.MouseLeave
        btnEditProfile.BackColor = Color.FromArgb(255, 235, 59)
    End Sub

    Private Sub btnSaveProfile_MouseEnter(sender As Object, e As EventArgs) Handles btnSaveProfile.MouseEnter
        If btnSaveProfile.Enabled Then
            btnSaveProfile.BackColor = Color.FromArgb(56, 142, 60)
        End If
    End Sub

    Private Sub btnSaveProfile_MouseLeave(sender As Object, e As EventArgs) Handles btnSaveProfile.MouseLeave
        If btnSaveProfile.Enabled Then
            btnSaveProfile.BackColor = Color.FromArgb(76, 175, 80)
        End If
    End Sub

    Private Sub btnLogout_MouseEnter(sender As Object, e As EventArgs) Handles btnLogout.MouseEnter
        btnLogout.BackColor = Color.FromArgb(200, 35, 51)
    End Sub

    Private Sub btnLogout_MouseLeave(sender As Object, e As EventArgs) Handles btnLogout.MouseLeave
        btnLogout.BackColor = Color.FromArgb(220, 53, 69)
    End Sub

    Private Sub btnDownloadReport_MouseEnter(sender As Object, e As EventArgs) Handles btnDownloadReport.MouseEnter
        btnDownloadReport.BackColor = Color.FromArgb(56, 142, 60)
    End Sub

    Private Sub btnDownloadReport_MouseLeave(sender As Object, e As EventArgs) Handles btnDownloadReport.MouseLeave
        btnDownloadReport.BackColor = Color.FromArgb(76, 175, 80)
    End Sub

#End Region

End Class