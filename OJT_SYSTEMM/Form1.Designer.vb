<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpening
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpening))
        pnlSidebar = New Panel()
        btnLogout = New Button()
        pnlSidebarBottom = New Panel()
        btnFinalGrade = New Button()
        btnVisitLogs = New Button()
        btnInternshipDetails = New Button()
        btnStudentProfile = New Button()
        pnlSidebarHeader = New Panel()
        lblUserRole = New Label()
        lblUsername = New Label()
        picUserAvatar = New PictureBox()
        lblSystemTitle = New Label()
        pnlMain = New Panel()
        pnlStudentProfile = New Panel()
        pnlProfileActions = New Panel()
        btnSaveProfile = New Button()
        btnEditProfile = New Button()
        grpAcademicInfo = New GroupBox()
        txtDepartmentName = New TextBox()
        lblDepartment = New Label()
        txtCourseName = New TextBox()
        lblCourse = New Label()
        txtSectionName = New TextBox()
        lblSection = New Label()
        grpPersonalInfo = New GroupBox()
        txtCity = New TextBox()
        lblCity = New Label()
        txtAddress = New TextBox()
        lblAddress = New Label()
        txtContactNumber = New TextBox()
        lblContactNumber = New Label()
        txtEmail = New TextBox()
        lblEmail = New Label()
        txtStatus = New TextBox()
        lblStatus = New Label()
        txtBirthDate = New TextBox()
        lblBirthDate = New Label()
        txtGender = New TextBox()
        lblGender = New Label()
        txtFullName = New TextBox()
        lblFullName = New Label()
        txtStudentNumber = New TextBox()
        lblStudentNumber = New Label()
        lblProfileTitle = New Label()
        pnlInternshipDetails = New Panel()
        grpOJTProgress = New GroupBox()
        lblProgressPercentage = New Label()
        progressOJTHours = New ProgressBar()
        txtCompletedHours = New TextBox()
        lblCompletedHours = New Label()
        txtRequiredHours = New TextBox()
        lblRequiredHours = New Label()
        grpWorkSchedule = New GroupBox()
        txtEndTime = New TextBox()
        lblEndTime = New Label()
        txtStartTime = New TextBox()
        lblStartTime = New Label()
        txtWorkDays = New TextBox()
        lblWorkDays = New Label()
        grpSupervisorInfo = New GroupBox()
        txtSupervisorContact = New TextBox()
        lblSupervisorContact = New Label()
        txtSupervisorPosition = New TextBox()
        lblSupervisorPosition = New Label()
        txtSupervisorName = New TextBox()
        lblSupervisorName = New Label()
        grpCompanyInfo = New GroupBox()
        txtIndustry = New TextBox()
        lblIndustry = New Label()
        txtCompanyCity = New TextBox()
        lblCompanyCity = New Label()
        txtCompanyAddress = New TextBox()
        lblCompanyAddress = New Label()
        txtCompanyName = New TextBox()
        lblCompanyName = New Label()
        txtInternshipStatus = New TextBox()
        lblInternshipStatus = New Label()
        lblInternshipTitle = New Label()
        pnlVisitLogs = New Panel()
        dgvVisitLogs = New DataGridView()
        colVisitDate = New DataGridViewTextBoxColumn()
        colVisitType = New DataGridViewTextBoxColumn()
        colScore = New DataGridViewTextBoxColumn()
        colMaxScore = New DataGridViewTextBoxColumn()
        colRemarks = New DataGridViewTextBoxColumn()
        colDownload = New DataGridViewButtonColumn()
        txtVisitInternshipID = New TextBox()
        lblVisitInternshipID = New Label()
        lblVisitLogsTitle = New Label()
        pnlFinalGrade = New Panel()
        btnDownloadReport = New Button()
        txtGradedAt = New TextBox()
        lblGradedAt = New Label()
        txtEvaluatedBy = New TextBox()
        lblEvaluatedBy = New Label()
        lblFinalGradeValue = New Label()
        lblFinalGradeLabel = New Label()
        txtFinalInternshipStatus = New TextBox()
        lblFinalInternshipStatus = New Label()
        lblFinalGradeTitle = New Label()
        pnlSidebar.SuspendLayout()
        pnlSidebarHeader.SuspendLayout()
        CType(picUserAvatar, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        pnlStudentProfile.SuspendLayout()
        pnlProfileActions.SuspendLayout()
        grpAcademicInfo.SuspendLayout()
        grpPersonalInfo.SuspendLayout()
        pnlInternshipDetails.SuspendLayout()
        grpOJTProgress.SuspendLayout()
        grpWorkSchedule.SuspendLayout()
        grpSupervisorInfo.SuspendLayout()
        grpCompanyInfo.SuspendLayout()
        pnlVisitLogs.SuspendLayout()
        CType(dgvVisitLogs, ComponentModel.ISupportInitialize).BeginInit()
        pnlFinalGrade.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(pnlSidebarBottom)
        pnlSidebar.Controls.Add(btnFinalGrade)
        pnlSidebar.Controls.Add(btnVisitLogs)
        pnlSidebar.Controls.Add(btnInternshipDetails)
        pnlSidebar.Controls.Add(btnStudentProfile)
        pnlSidebar.Controls.Add(pnlSidebarHeader)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(280, 768)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnLogout.Cursor = Cursors.Hand
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(0, 712)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(16, 0, 0, 0)
        btnLogout.Size = New Size(280, 56)
        btnLogout.TabIndex = 6
        btnLogout.Text = "🚪  Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebarBottom
        ' 
        pnlSidebarBottom.Dock = DockStyle.Bottom
        pnlSidebarBottom.Location = New Point(0, 688)
        pnlSidebarBottom.Name = "pnlSidebarBottom"
        pnlSidebarBottom.Size = New Size(280, 24)
        pnlSidebarBottom.TabIndex = 5
        ' 
        ' btnFinalGrade
        ' 
        btnFinalGrade.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        btnFinalGrade.Cursor = Cursors.Hand
        btnFinalGrade.Dock = DockStyle.Top
        btnFinalGrade.FlatAppearance.BorderSize = 0
        btnFinalGrade.FlatStyle = FlatStyle.Flat
        btnFinalGrade.Font = New Font("Segoe UI", 10.5F)
        btnFinalGrade.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        btnFinalGrade.Location = New Point(0, 416)
        btnFinalGrade.Name = "btnFinalGrade"
        btnFinalGrade.Padding = New Padding(24, 0, 0, 0)
        btnFinalGrade.Size = New Size(280, 56)
        btnFinalGrade.TabIndex = 4
        btnFinalGrade.Text = "📊  Final Grade"
        btnFinalGrade.TextAlign = ContentAlignment.MiddleLeft
        btnFinalGrade.UseVisualStyleBackColor = False
        ' 
        ' btnVisitLogs
        ' 
        btnVisitLogs.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        btnVisitLogs.Cursor = Cursors.Hand
        btnVisitLogs.Dock = DockStyle.Top
        btnVisitLogs.FlatAppearance.BorderSize = 0
        btnVisitLogs.FlatStyle = FlatStyle.Flat
        btnVisitLogs.Font = New Font("Segoe UI", 10.5F)
        btnVisitLogs.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        btnVisitLogs.Location = New Point(0, 360)
        btnVisitLogs.Name = "btnVisitLogs"
        btnVisitLogs.Padding = New Padding(24, 0, 0, 0)
        btnVisitLogs.Size = New Size(280, 56)
        btnVisitLogs.TabIndex = 3
        btnVisitLogs.Text = "📝  Visit Logs"
        btnVisitLogs.TextAlign = ContentAlignment.MiddleLeft
        btnVisitLogs.UseVisualStyleBackColor = False
        ' 
        ' btnInternshipDetails
        ' 
        btnInternshipDetails.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        btnInternshipDetails.Cursor = Cursors.Hand
        btnInternshipDetails.Dock = DockStyle.Top
        btnInternshipDetails.FlatAppearance.BorderSize = 0
        btnInternshipDetails.FlatStyle = FlatStyle.Flat
        btnInternshipDetails.Font = New Font("Segoe UI", 10.5F)
        btnInternshipDetails.ForeColor = Color.FromArgb(CByte(220), CByte(220), CByte(220))
        btnInternshipDetails.Location = New Point(0, 304)
        btnInternshipDetails.Name = "btnInternshipDetails"
        btnInternshipDetails.Padding = New Padding(24, 0, 0, 0)
        btnInternshipDetails.Size = New Size(280, 56)
        btnInternshipDetails.TabIndex = 2
        btnInternshipDetails.Text = "🏢  Internship Details"
        btnInternshipDetails.TextAlign = ContentAlignment.MiddleLeft
        btnInternshipDetails.UseVisualStyleBackColor = False
        ' 
        ' btnStudentProfile
        ' 
        btnStudentProfile.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnStudentProfile.Cursor = Cursors.Hand
        btnStudentProfile.Dock = DockStyle.Top
        btnStudentProfile.FlatAppearance.BorderSize = 0
        btnStudentProfile.FlatStyle = FlatStyle.Flat
        btnStudentProfile.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
        btnStudentProfile.ForeColor = Color.White
        btnStudentProfile.Location = New Point(0, 248)
        btnStudentProfile.Name = "btnStudentProfile"
        btnStudentProfile.Padding = New Padding(24, 0, 0, 0)
        btnStudentProfile.Size = New Size(280, 56)
        btnStudentProfile.TabIndex = 1
        btnStudentProfile.Text = "👤  Student Profile"
        btnStudentProfile.TextAlign = ContentAlignment.MiddleLeft
        btnStudentProfile.UseVisualStyleBackColor = False
        ' 
        ' pnlSidebarHeader
        ' 
        pnlSidebarHeader.Controls.Add(lblUserRole)
        pnlSidebarHeader.Controls.Add(lblUsername)
        pnlSidebarHeader.Controls.Add(picUserAvatar)
        pnlSidebarHeader.Controls.Add(lblSystemTitle)
        pnlSidebarHeader.Dock = DockStyle.Top
        pnlSidebarHeader.Location = New Point(0, 0)
        pnlSidebarHeader.Name = "pnlSidebarHeader"
        pnlSidebarHeader.Padding = New Padding(16)
        pnlSidebarHeader.Size = New Size(280, 248)
        pnlSidebarHeader.TabIndex = 0
        ' 
        ' lblUserRole
        ' 
        lblUserRole.Font = New Font("Segoe UI", 9.0F)
        lblUserRole.ForeColor = Color.FromArgb(CByte(189), CByte(189), CByte(189))
        lblUserRole.Location = New Point(16, 216)
        lblUserRole.Name = "lblUserRole"
        lblUserRole.Size = New Size(248, 20)
        lblUserRole.TabIndex = 3
        lblUserRole.Text = "Student"
        lblUserRole.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblUsername
        ' 
        lblUsername.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        lblUsername.ForeColor = Color.White
        lblUsername.Location = New Point(16, 192)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(248, 24)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Juan Dela Cruz"
        lblUsername.TextAlign = ContentAlignment.TopCenter
        ' 
        ' picUserAvatar
        ' 
        picUserAvatar.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        picUserAvatar.Location = New Point(90, 104)
        picUserAvatar.Name = "picUserAvatar"
        picUserAvatar.Size = New Size(96, 96)
        picUserAvatar.SizeMode = PictureBoxSizeMode.StretchImage
        picUserAvatar.TabIndex = 1
        picUserAvatar.TabStop = False
        ' 
        ' lblSystemTitle
        ' 
        lblSystemTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblSystemTitle.ForeColor = Color.FromArgb(CByte(255), CByte(235), CByte(59))
        lblSystemTitle.Location = New Point(16, 16)
        lblSystemTitle.Name = "lblSystemTitle"
        lblSystemTitle.Size = New Size(248, 72)
        lblSystemTitle.TabIndex = 0
        lblSystemTitle.Text = "OJT MANAGEMENT SYSTEM"
        lblSystemTitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' pnlMain
        ' 
        pnlMain.AutoScroll = True
        pnlMain.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        pnlMain.Controls.Add(pnlStudentProfile)
        pnlMain.Controls.Add(pnlInternshipDetails)
        pnlMain.Controls.Add(pnlVisitLogs)
        pnlMain.Controls.Add(pnlFinalGrade)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(280, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(32)
        pnlMain.Size = New Size(1104, 768)
        pnlMain.TabIndex = 1
        ' 
        ' pnlStudentProfile
        ' 
        pnlStudentProfile.AutoScroll = True
        pnlStudentProfile.BackColor = Color.White
        pnlStudentProfile.Controls.Add(pnlProfileActions)
        pnlStudentProfile.Controls.Add(grpAcademicInfo)
        pnlStudentProfile.Controls.Add(grpPersonalInfo)
        pnlStudentProfile.Controls.Add(lblProfileTitle)
        pnlStudentProfile.Dock = DockStyle.Fill
        pnlStudentProfile.Location = New Point(32, 32)
        pnlStudentProfile.Name = "pnlStudentProfile"
        pnlStudentProfile.Padding = New Padding(40)
        pnlStudentProfile.Size = New Size(1040, 704)
        pnlStudentProfile.TabIndex = 0
        ' 
        ' pnlProfileActions
        ' 
        pnlProfileActions.Controls.Add(btnSaveProfile)
        pnlProfileActions.Controls.Add(btnEditProfile)
        pnlProfileActions.Dock = DockStyle.Top
        pnlProfileActions.Location = New Point(40, 836)
        pnlProfileActions.Name = "pnlProfileActions"
        pnlProfileActions.Padding = New Padding(0, 24, 0, 0)
        pnlProfileActions.Size = New Size(960, 80)
        pnlProfileActions.TabIndex = 3
        ' 
        ' btnSaveProfile
        ' 
        btnSaveProfile.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnSaveProfile.Cursor = Cursors.Hand
        btnSaveProfile.Enabled = False
        btnSaveProfile.FlatAppearance.BorderSize = 0
        btnSaveProfile.FlatStyle = FlatStyle.Flat
        btnSaveProfile.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnSaveProfile.ForeColor = Color.White
        btnSaveProfile.Location = New Point(168, 24)
        btnSaveProfile.Name = "btnSaveProfile"
        btnSaveProfile.Size = New Size(160, 48)
        btnSaveProfile.TabIndex = 1
        btnSaveProfile.Text = "💾 Save Changes"
        btnSaveProfile.UseVisualStyleBackColor = False
        ' 
        ' btnEditProfile
        ' 
        btnEditProfile.BackColor = Color.FromArgb(CByte(255), CByte(235), CByte(59))
        btnEditProfile.Cursor = Cursors.Hand
        btnEditProfile.FlatAppearance.BorderSize = 0
        btnEditProfile.FlatStyle = FlatStyle.Flat
        btnEditProfile.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnEditProfile.ForeColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        btnEditProfile.Location = New Point(0, 24)
        btnEditProfile.Name = "btnEditProfile"
        btnEditProfile.Size = New Size(160, 48)
        btnEditProfile.TabIndex = 0
        btnEditProfile.Text = "✏️ Edit Profile"
        btnEditProfile.UseVisualStyleBackColor = False
        ' 
        ' grpAcademicInfo
        ' 
        grpAcademicInfo.Controls.Add(txtDepartmentName)
        grpAcademicInfo.Controls.Add(lblDepartment)
        grpAcademicInfo.Controls.Add(txtCourseName)
        grpAcademicInfo.Controls.Add(lblCourse)
        grpAcademicInfo.Controls.Add(txtSectionName)
        grpAcademicInfo.Controls.Add(lblSection)
        grpAcademicInfo.Dock = DockStyle.Top
        grpAcademicInfo.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        grpAcademicInfo.ForeColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        grpAcademicInfo.Location = New Point(40, 652)
        grpAcademicInfo.Name = "grpAcademicInfo"
        grpAcademicInfo.Padding = New Padding(24, 16, 24, 24)
        grpAcademicInfo.Size = New Size(960, 184)
        grpAcademicInfo.TabIndex = 2
        grpAcademicInfo.TabStop = False
        grpAcademicInfo.Text = "ACADEMIC INFORMATION"
        ' 
        ' txtDepartmentName
        ' 
        txtDepartmentName.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtDepartmentName.BorderStyle = BorderStyle.FixedSingle
        txtDepartmentName.Font = New Font("Segoe UI", 10.0F)
        txtDepartmentName.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtDepartmentName.Location = New Point(504, 128)
        txtDepartmentName.Name = "txtDepartmentName"
        txtDepartmentName.ReadOnly = True
        txtDepartmentName.Size = New Size(432, 30)
        txtDepartmentName.TabIndex = 5
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Segoe UI", 9.5F)
        lblDepartment.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblDepartment.Location = New Point(504, 104)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(97, 21)
        lblDepartment.TabIndex = 4
        lblDepartment.Text = "Department"
        ' 
        ' txtCourseName
        ' 
        txtCourseName.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtCourseName.BorderStyle = BorderStyle.FixedSingle
        txtCourseName.Font = New Font("Segoe UI", 10.0F)
        txtCourseName.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtCourseName.Location = New Point(504, 64)
        txtCourseName.Name = "txtCourseName"
        txtCourseName.ReadOnly = True
        txtCourseName.Size = New Size(432, 30)
        txtCourseName.TabIndex = 3
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI", 9.5F)
        lblCourse.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblCourse.Location = New Point(504, 40)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(61, 21)
        lblCourse.TabIndex = 2
        lblCourse.Text = "Course"
        ' 
        ' txtSectionName
        ' 
        txtSectionName.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtSectionName.BorderStyle = BorderStyle.FixedSingle
        txtSectionName.Font = New Font("Segoe UI", 10.0F)
        txtSectionName.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtSectionName.Location = New Point(24, 64)
        txtSectionName.Name = "txtSectionName"
        txtSectionName.ReadOnly = True
        txtSectionName.Size = New Size(456, 30)
        txtSectionName.TabIndex = 1
        ' 
        ' lblSection
        ' 
        lblSection.AutoSize = True
        lblSection.Font = New Font("Segoe UI", 9.5F)
        lblSection.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblSection.Location = New Point(24, 40)
        lblSection.Name = "lblSection"
        lblSection.Size = New Size(64, 21)
        lblSection.TabIndex = 0
        lblSection.Text = "Section"
        ' 
        ' grpPersonalInfo
        ' 
        grpPersonalInfo.Controls.Add(txtCity)
        grpPersonalInfo.Controls.Add(lblCity)
        grpPersonalInfo.Controls.Add(txtAddress)
        grpPersonalInfo.Controls.Add(lblAddress)
        grpPersonalInfo.Controls.Add(txtContactNumber)
        grpPersonalInfo.Controls.Add(lblContactNumber)
        grpPersonalInfo.Controls.Add(txtEmail)
        grpPersonalInfo.Controls.Add(lblEmail)
        grpPersonalInfo.Controls.Add(txtStatus)
        grpPersonalInfo.Controls.Add(lblStatus)
        grpPersonalInfo.Controls.Add(txtBirthDate)
        grpPersonalInfo.Controls.Add(lblBirthDate)
        grpPersonalInfo.Controls.Add(txtGender)
        grpPersonalInfo.Controls.Add(lblGender)
        grpPersonalInfo.Controls.Add(txtFullName)
        grpPersonalInfo.Controls.Add(lblFullName)
        grpPersonalInfo.Controls.Add(txtStudentNumber)
        grpPersonalInfo.Controls.Add(lblStudentNumber)
        grpPersonalInfo.Dock = DockStyle.Top
        grpPersonalInfo.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        grpPersonalInfo.ForeColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        grpPersonalInfo.Location = New Point(40, 88)
        grpPersonalInfo.Name = "grpPersonalInfo"
        grpPersonalInfo.Padding = New Padding(24, 16, 24, 24)
        grpPersonalInfo.Size = New Size(960, 564)
        grpPersonalInfo.TabIndex = 1
        grpPersonalInfo.TabStop = False
        grpPersonalInfo.Text = "PERSONAL INFORMATION"
        ' 
        ' txtCity
        ' 
        txtCity.BackColor = Color.White
        txtCity.BorderStyle = BorderStyle.FixedSingle
        txtCity.Font = New Font("Segoe UI", 10.0F)
        txtCity.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtCity.Location = New Point(504, 512)
        txtCity.Name = "txtCity"
        txtCity.Size = New Size(432, 30)
        txtCity.TabIndex = 17
        ' 
        ' lblCity
        ' 
        lblCity.AutoSize = True
        lblCity.Font = New Font("Segoe UI", 9.5F)
        lblCity.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblCity.Location = New Point(504, 488)
        lblCity.Name = "lblCity"
        lblCity.Size = New Size(37, 21)
        lblCity.TabIndex = 16
        lblCity.Text = "City"
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.White
        txtAddress.BorderStyle = BorderStyle.FixedSingle
        txtAddress.Font = New Font("Segoe UI", 10.0F)
        txtAddress.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtAddress.Location = New Point(24, 512)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(456, 30)
        txtAddress.TabIndex = 15
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 9.5F)
        lblAddress.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblAddress.Location = New Point(24, 488)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(70, 21)
        lblAddress.TabIndex = 14
        lblAddress.Text = "Address"
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.BackColor = Color.White
        txtContactNumber.BorderStyle = BorderStyle.FixedSingle
        txtContactNumber.Font = New Font("Segoe UI", 10.0F)
        txtContactNumber.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtContactNumber.Location = New Point(504, 432)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(432, 30)
        txtContactNumber.TabIndex = 13
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.Font = New Font("Segoe UI", 9.5F)
        lblContactNumber.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblContactNumber.Location = New Point(504, 408)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New Size(133, 21)
        lblContactNumber.TabIndex = 12
        lblContactNumber.Text = "Contact Number"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.White
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 10.0F)
        txtEmail.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        txtEmail.Location = New Point(24, 432)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(456, 30)
        txtEmail.TabIndex = 11
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 9.5F)
        lblEmail.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblEmail.Location = New Point(24, 408)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(51, 21)
        lblEmail.TabIndex = 10
        lblEmail.Text = "Email"
        ' 
        ' txtStatus
        ' 
        txtStatus.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtStatus.BorderStyle = BorderStyle.FixedSingle
        txtStatus.Font = New Font("Segoe UI", 10.0F)
        txtStatus.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtStatus.Location = New Point(24, 352)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(456, 30)
        txtStatus.TabIndex = 9
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 9.5F)
        lblStatus.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblStatus.Location = New Point(24, 328)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(56, 21)
        lblStatus.TabIndex = 8
        lblStatus.Text = "Status"
        ' 
        ' txtBirthDate
        ' 
        txtBirthDate.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtBirthDate.BorderStyle = BorderStyle.FixedSingle
        txtBirthDate.Font = New Font("Segoe UI", 10.0F)
        txtBirthDate.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtBirthDate.Location = New Point(504, 272)
        txtBirthDate.Name = "txtBirthDate"
        txtBirthDate.ReadOnly = True
        txtBirthDate.Size = New Size(432, 30)
        txtBirthDate.TabIndex = 7
        ' 
        ' lblBirthDate
        ' 
        lblBirthDate.AutoSize = True
        lblBirthDate.Font = New Font("Segoe UI", 9.5F)
        lblBirthDate.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblBirthDate.Location = New Point(504, 248)
        lblBirthDate.Name = "lblBirthDate"
        lblBirthDate.Size = New Size(85, 21)
        lblBirthDate.TabIndex = 6
        lblBirthDate.Text = "Birth Date"
        ' 
        ' txtGender
        ' 
        txtGender.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtGender.BorderStyle = BorderStyle.FixedSingle
        txtGender.Font = New Font("Segoe UI", 10.0F)
        txtGender.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtGender.Location = New Point(24, 272)
        txtGender.Name = "txtGender"
        txtGender.ReadOnly = True
        txtGender.Size = New Size(456, 30)
        txtGender.TabIndex = 5
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Segoe UI", 9.5F)
        lblGender.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblGender.Location = New Point(24, 248)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(65, 21)
        lblGender.TabIndex = 4
        lblGender.Text = "Gender"
        ' 
        ' txtFullName
        ' 
        txtFullName.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtFullName.BorderStyle = BorderStyle.FixedSingle
        txtFullName.Font = New Font("Segoe UI", 10.0F)
        txtFullName.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtFullName.Location = New Point(24, 192)
        txtFullName.Name = "txtFullName"
        txtFullName.ReadOnly = True
        txtFullName.Size = New Size(912, 30)
        txtFullName.TabIndex = 3
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI", 9.5F)
        lblFullName.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblFullName.Location = New Point(24, 168)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(84, 21)
        lblFullName.TabIndex = 2
        lblFullName.Text = "Full Name"
        ' 
        ' txtStudentNumber
        ' 
        txtStudentNumber.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtStudentNumber.BorderStyle = BorderStyle.FixedSingle
        txtStudentNumber.Font = New Font("Segoe UI", 10.0F)
        txtStudentNumber.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtStudentNumber.Location = New Point(24, 64)
        txtStudentNumber.Name = "txtStudentNumber"
        txtStudentNumber.ReadOnly = True
        txtStudentNumber.Size = New Size(912, 30)
        txtStudentNumber.TabIndex = 1
        ' 
        ' lblStudentNumber
        ' 
        lblStudentNumber.AutoSize = True
        lblStudentNumber.Font = New Font("Segoe UI", 9.5F)
        lblStudentNumber.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblStudentNumber.Location = New Point(24, 40)
        lblStudentNumber.Name = "lblStudentNumber"
        lblStudentNumber.Size = New Size(135, 21)
        lblStudentNumber.TabIndex = 0
        lblStudentNumber.Text = "Student Number"
        ' 
        ' lblProfileTitle
        ' 
        lblProfileTitle.Dock = DockStyle.Top
        lblProfileTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblProfileTitle.ForeColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        lblProfileTitle.Location = New Point(40, 40)
        lblProfileTitle.Name = "lblProfileTitle"
        lblProfileTitle.Size = New Size(960, 48)
        lblProfileTitle.TabIndex = 0
        lblProfileTitle.Text = "STUDENT PROFILE"
        ' 
        ' pnlInternshipDetails
        ' 
        pnlInternshipDetails.AutoScroll = True
        pnlInternshipDetails.BackColor = Color.White
        pnlInternshipDetails.Controls.Add(grpOJTProgress)
        pnlInternshipDetails.Controls.Add(grpWorkSchedule)
        pnlInternshipDetails.Controls.Add(grpSupervisorInfo)
        pnlInternshipDetails.Controls.Add(grpCompanyInfo)
        pnlInternshipDetails.Controls.Add(txtInternshipStatus)
        pnlInternshipDetails.Controls.Add(lblInternshipStatus)
        pnlInternshipDetails.Controls.Add(lblInternshipTitle)
        pnlInternshipDetails.Dock = DockStyle.Fill
        pnlInternshipDetails.Location = New Point(32, 32)
        pnlInternshipDetails.Name = "pnlInternshipDetails"
        pnlInternshipDetails.Padding = New Padding(40)
        pnlInternshipDetails.Size = New Size(1040, 704)
        pnlInternshipDetails.TabIndex = 1
        pnlInternshipDetails.Visible = False
        ' 
        ' grpOJTProgress
        ' 
        grpOJTProgress.Controls.Add(lblProgressPercentage)
        grpOJTProgress.Controls.Add(progressOJTHours)
        grpOJTProgress.Controls.Add(txtCompletedHours)
        grpOJTProgress.Controls.Add(lblCompletedHours)
        grpOJTProgress.Controls.Add(txtRequiredHours)
        grpOJTProgress.Controls.Add(lblRequiredHours)
        grpOJTProgress.Dock = DockStyle.Top
        grpOJTProgress.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        grpOJTProgress.ForeColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        grpOJTProgress.Location = New Point(40, 896)
        grpOJTProgress.Name = "grpOJTProgress"
        grpOJTProgress.Padding = New Padding(24, 16, 24, 24)
        grpOJTProgress.Size = New Size(960, 264)
        grpOJTProgress.TabIndex = 6
        grpOJTProgress.TabStop = False
        grpOJTProgress.Text = "OJT HOURS PROGRESS"
        ' 
        ' lblProgressPercentage
        ' 
        lblProgressPercentage.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblProgressPercentage.ForeColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblProgressPercentage.Location = New Point(24, 216)
        lblProgressPercentage.Name = "lblProgressPercentage"
        lblProgressPercentage.Size = New Size(912, 24)
        lblProgressPercentage.TabIndex = 5
        lblProgressPercentage.Text = "75% Complete"
        lblProgressPercentage.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' progressOJTHours
        ' 
        progressOJTHours.ForeColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        progressOJTHours.Location = New Point(24, 176)
        progressOJTHours.Name = "progressOJTHours"
        progressOJTHours.Size = New Size(912, 32)
        progressOJTHours.Style = ProgressBarStyle.Continuous
        progressOJTHours.TabIndex = 4
        progressOJTHours.Value = 75
        ' 
        ' txtCompletedHours
        ' 
        txtCompletedHours.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtCompletedHours.BorderStyle = BorderStyle.FixedSingle
        txtCompletedHours.Font = New Font("Segoe UI", 10.0F)
        txtCompletedHours.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtCompletedHours.Location = New Point(504, 64)
        txtCompletedHours.Name = "txtCompletedHours"
        txtCompletedHours.ReadOnly = True
        txtCompletedHours.Size = New Size(432, 30)
        txtCompletedHours.TabIndex = 3
        ' 
        ' lblCompletedHours
        ' 
        lblCompletedHours.AutoSize = True
        lblCompletedHours.Font = New Font("Segoe UI", 9.5F)
        lblCompletedHours.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblCompletedHours.Location = New Point(504, 40)
        lblCompletedHours.Name = "lblCompletedHours"
        lblCompletedHours.Size = New Size(142, 21)
        lblCompletedHours.TabIndex = 2
        lblCompletedHours.Text = "Completed Hours"
        ' 
        ' txtRequiredHours
        ' 
        txtRequiredHours.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtRequiredHours.BorderStyle = BorderStyle.FixedSingle
        txtRequiredHours.Font = New Font("Segoe UI", 10.0F)
        txtRequiredHours.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtRequiredHours.Location = New Point(24, 64)
        txtRequiredHours.Name = "txtRequiredHours"
        txtRequiredHours.ReadOnly = True
        txtRequiredHours.Size = New Size(456, 30)
        txtRequiredHours.TabIndex = 1
        ' 
        ' lblRequiredHours
        ' 
        lblRequiredHours.AutoSize = True
        lblRequiredHours.Font = New Font("Segoe UI", 9.5F)
        lblRequiredHours.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblRequiredHours.Location = New Point(24, 40)
        lblRequiredHours.Name = "lblRequiredHours"
        lblRequiredHours.Size = New Size(127, 21)
        lblRequiredHours.TabIndex = 0
        lblRequiredHours.Text = "Required Hours"
        ' 
        ' grpWorkSchedule
        ' 
        grpWorkSchedule.Controls.Add(txtEndTime)
        grpWorkSchedule.Controls.Add(lblEndTime)
        grpWorkSchedule.Controls.Add(txtStartTime)
        grpWorkSchedule.Controls.Add(lblStartTime)
        grpWorkSchedule.Controls.Add(txtWorkDays)
        grpWorkSchedule.Controls.Add(lblWorkDays)
        grpWorkSchedule.Dock = DockStyle.Top
        grpWorkSchedule.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        grpWorkSchedule.ForeColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        grpWorkSchedule.Location = New Point(40, 688)
        grpWorkSchedule.Name = "grpWorkSchedule"
        grpWorkSchedule.Padding = New Padding(24, 16, 24, 24)
        grpWorkSchedule.Size = New Size(960, 208)
        grpWorkSchedule.TabIndex = 5
        grpWorkSchedule.TabStop = False
        grpWorkSchedule.Text = "WORK SCHEDULE INFORMATION"
        ' 
        ' txtEndTime
        ' 
        txtEndTime.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtEndTime.BorderStyle = BorderStyle.FixedSingle
        txtEndTime.Font = New Font("Segoe UI", 10.0F)
        txtEndTime.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtEndTime.Location = New Point(504, 144)
        txtEndTime.Name = "txtEndTime"
        txtEndTime.ReadOnly = True
        txtEndTime.Size = New Size(432, 30)
        txtEndTime.TabIndex = 5
        ' 
        ' lblEndTime
        ' 
        lblEndTime.AutoSize = True
        lblEndTime.Font = New Font("Segoe UI", 9.5F)
        lblEndTime.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblEndTime.Location = New Point(504, 120)
        lblEndTime.Name = "lblEndTime"
        lblEndTime.Size = New Size(126, 21)
        lblEndTime.TabIndex = 4
        lblEndTime.Text = "Daily End Time"
        ' 
        ' txtStartTime
        ' 
        txtStartTime.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtStartTime.BorderStyle = BorderStyle.FixedSingle
        txtStartTime.Font = New Font("Segoe UI", 10.0F)
        txtStartTime.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtStartTime.Location = New Point(24, 144)
        txtStartTime.Name = "txtStartTime"
        txtStartTime.ReadOnly = True
        txtStartTime.Size = New Size(456, 30)
        txtStartTime.TabIndex = 3
        ' 
        ' lblStartTime
        ' 
        lblStartTime.AutoSize = True
        lblStartTime.Font = New Font("Segoe UI", 9.5F)
        lblStartTime.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblStartTime.Location = New Point(24, 120)
        lblStartTime.Name = "lblStartTime"
        lblStartTime.Size = New Size(133, 21)
        lblStartTime.TabIndex = 2
        lblStartTime.Text = "Daily Start Time"
        ' 
        ' txtWorkDays
        ' 
        txtWorkDays.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtWorkDays.BorderStyle = BorderStyle.FixedSingle
        txtWorkDays.Font = New Font("Segoe UI", 10.0F)
        txtWorkDays.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtWorkDays.Location = New Point(24, 64)
        txtWorkDays.Name = "txtWorkDays"
        txtWorkDays.ReadOnly = True
        txtWorkDays.Size = New Size(912, 30)
        txtWorkDays.TabIndex = 1
        ' 
        ' lblWorkDays
        ' 
        lblWorkDays.AutoSize = True
        lblWorkDays.Font = New Font("Segoe UI", 9.5F)
        lblWorkDays.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblWorkDays.Location = New Point(24, 40)
        lblWorkDays.Name = "lblWorkDays"
        lblWorkDays.Size = New Size(90, 21)
        lblWorkDays.TabIndex = 0
        lblWorkDays.Text = "Work Days"
        ' 
        ' grpSupervisorInfo
        ' 
        grpSupervisorInfo.Controls.Add(txtSupervisorContact)
        grpSupervisorInfo.Controls.Add(lblSupervisorContact)
        grpSupervisorInfo.Controls.Add(txtSupervisorPosition)
        grpSupervisorInfo.Controls.Add(lblSupervisorPosition)
        grpSupervisorInfo.Controls.Add(txtSupervisorName)
        grpSupervisorInfo.Controls.Add(lblSupervisorName)
        grpSupervisorInfo.Dock = DockStyle.Top
        grpSupervisorInfo.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        grpSupervisorInfo.ForeColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        grpSupervisorInfo.Location = New Point(40, 480)
        grpSupervisorInfo.Name = "grpSupervisorInfo"
        grpSupervisorInfo.Padding = New Padding(24, 16, 24, 24)
        grpSupervisorInfo.Size = New Size(960, 208)
        grpSupervisorInfo.TabIndex = 4
        grpSupervisorInfo.TabStop = False
        grpSupervisorInfo.Text = "SUPERVISOR INFORMATION"
        ' 
        ' txtSupervisorContact
        ' 
        txtSupervisorContact.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtSupervisorContact.BorderStyle = BorderStyle.FixedSingle
        txtSupervisorContact.Font = New Font("Segoe UI", 10.0F)
        txtSupervisorContact.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtSupervisorContact.Location = New Point(24, 144)
        txtSupervisorContact.Name = "txtSupervisorContact"
        txtSupervisorContact.ReadOnly = True
        txtSupervisorContact.Size = New Size(912, 30)
        txtSupervisorContact.TabIndex = 5
        ' 
        ' lblSupervisorContact
        ' 
        lblSupervisorContact.AutoSize = True
        lblSupervisorContact.Font = New Font("Segoe UI", 9.5F)
        lblSupervisorContact.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblSupervisorContact.Location = New Point(24, 120)
        lblSupervisorContact.Name = "lblSupervisorContact"
        lblSupervisorContact.Size = New Size(133, 21)
        lblSupervisorContact.TabIndex = 4
        lblSupervisorContact.Text = "Contact Number"
        ' 
        ' txtSupervisorPosition
        ' 
        txtSupervisorPosition.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtSupervisorPosition.BorderStyle = BorderStyle.FixedSingle
        txtSupervisorPosition.Font = New Font("Segoe UI", 10.0F)
        txtSupervisorPosition.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtSupervisorPosition.Location = New Point(504, 64)
        txtSupervisorPosition.Name = "txtSupervisorPosition"
        txtSupervisorPosition.ReadOnly = True
        txtSupervisorPosition.Size = New Size(432, 30)
        txtSupervisorPosition.TabIndex = 3
        ' 
        ' lblSupervisorPosition
        ' 
        lblSupervisorPosition.AutoSize = True
        lblSupervisorPosition.Font = New Font("Segoe UI", 9.5F)
        lblSupervisorPosition.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblSupervisorPosition.Location = New Point(504, 40)
        lblSupervisorPosition.Name = "lblSupervisorPosition"
        lblSupervisorPosition.Size = New Size(105, 21)
        lblSupervisorPosition.TabIndex = 2
        lblSupervisorPosition.Text = "Position Title"
        ' 
        ' txtSupervisorName
        ' 
        txtSupervisorName.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtSupervisorName.BorderStyle = BorderStyle.FixedSingle
        txtSupervisorName.Font = New Font("Segoe UI", 10.0F)
        txtSupervisorName.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtSupervisorName.Location = New Point(24, 64)
        txtSupervisorName.Name = "txtSupervisorName"
        txtSupervisorName.ReadOnly = True
        txtSupervisorName.Size = New Size(456, 30)
        txtSupervisorName.TabIndex = 1
        ' 
        ' lblSupervisorName
        ' 
        lblSupervisorName.AutoSize = True
        lblSupervisorName.Font = New Font("Segoe UI", 9.5F)
        lblSupervisorName.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblSupervisorName.Location = New Point(24, 40)
        lblSupervisorName.Name = "lblSupervisorName"
        lblSupervisorName.Size = New Size(137, 21)
        lblSupervisorName.TabIndex = 0
        lblSupervisorName.Text = "Supervisor Name"
        ' 
        ' grpCompanyInfo
        ' 
        grpCompanyInfo.Controls.Add(txtIndustry)
        grpCompanyInfo.Controls.Add(lblIndustry)
        grpCompanyInfo.Controls.Add(txtCompanyCity)
        grpCompanyInfo.Controls.Add(lblCompanyCity)
        grpCompanyInfo.Controls.Add(txtCompanyAddress)
        grpCompanyInfo.Controls.Add(lblCompanyAddress)
        grpCompanyInfo.Controls.Add(txtCompanyName)
        grpCompanyInfo.Controls.Add(lblCompanyName)
        grpCompanyInfo.Dock = DockStyle.Top
        grpCompanyInfo.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
        grpCompanyInfo.ForeColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        grpCompanyInfo.Location = New Point(40, 208)
        grpCompanyInfo.Name = "grpCompanyInfo"
        grpCompanyInfo.Padding = New Padding(24, 16, 24, 24)
        grpCompanyInfo.Size = New Size(960, 272)
        grpCompanyInfo.TabIndex = 3
        grpCompanyInfo.TabStop = False
        grpCompanyInfo.Text = "COMPANY INFORMATION"
        ' 
        ' txtIndustry
        ' 
        txtIndustry.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtIndustry.BorderStyle = BorderStyle.FixedSingle
        txtIndustry.Font = New Font("Segoe UI", 10.0F)
        txtIndustry.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtIndustry.Location = New Point(24, 208)
        txtIndustry.Name = "txtIndustry"
        txtIndustry.ReadOnly = True
        txtIndustry.Size = New Size(912, 30)
        txtIndustry.TabIndex = 7
        ' 
        ' lblIndustry
        ' 
        lblIndustry.AutoSize = True
        lblIndustry.Font = New Font("Segoe UI", 9.5F)
        lblIndustry.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblIndustry.Location = New Point(24, 184)
        lblIndustry.Name = "lblIndustry"
        lblIndustry.Size = New Size(71, 21)
        lblIndustry.TabIndex = 6
        lblIndustry.Text = "Industry"
        ' 
        ' txtCompanyCity
        ' 
        txtCompanyCity.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtCompanyCity.BorderStyle = BorderStyle.FixedSingle
        txtCompanyCity.Font = New Font("Segoe UI", 10.0F)
        txtCompanyCity.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtCompanyCity.Location = New Point(504, 128)
        txtCompanyCity.Name = "txtCompanyCity"
        txtCompanyCity.ReadOnly = True
        txtCompanyCity.Size = New Size(432, 30)
        txtCompanyCity.TabIndex = 5
        ' 
        ' lblCompanyCity
        ' 
        lblCompanyCity.AutoSize = True
        lblCompanyCity.Font = New Font("Segoe UI", 9.5F)
        lblCompanyCity.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblCompanyCity.Location = New Point(504, 104)
        lblCompanyCity.Name = "lblCompanyCity"
        lblCompanyCity.Size = New Size(37, 21)
        lblCompanyCity.TabIndex = 4
        lblCompanyCity.Text = "City"
        ' 
        ' txtCompanyAddress
        ' 
        txtCompanyAddress.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtCompanyAddress.BorderStyle = BorderStyle.FixedSingle
        txtCompanyAddress.Font = New Font("Segoe UI", 10.0F)
        txtCompanyAddress.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtCompanyAddress.Location = New Point(24, 128)
        txtCompanyAddress.Name = "txtCompanyAddress"
        txtCompanyAddress.ReadOnly = True
        txtCompanyAddress.Size = New Size(456, 30)
        txtCompanyAddress.TabIndex = 3
        ' 
        ' lblCompanyAddress
        ' 
        lblCompanyAddress.AutoSize = True
        lblCompanyAddress.Font = New Font("Segoe UI", 9.5F)
        lblCompanyAddress.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblCompanyAddress.Location = New Point(24, 104)
        lblCompanyAddress.Name = "lblCompanyAddress"
        lblCompanyAddress.Size = New Size(70, 21)
        lblCompanyAddress.TabIndex = 2
        lblCompanyAddress.Text = "Address"
        ' 
        ' txtCompanyName
        ' 
        txtCompanyName.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtCompanyName.BorderStyle = BorderStyle.FixedSingle
        txtCompanyName.Font = New Font("Segoe UI", 10.0F)
        txtCompanyName.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtCompanyName.Location = New Point(24, 64)
        txtCompanyName.Name = "txtCompanyName"
        txtCompanyName.ReadOnly = True
        txtCompanyName.Size = New Size(912, 30)
        txtCompanyName.TabIndex = 1
        ' 
        ' lblCompanyName
        ' 
        lblCompanyName.AutoSize = True
        lblCompanyName.Font = New Font("Segoe UI", 9.5F)
        lblCompanyName.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblCompanyName.Location = New Point(24, 40)
        lblCompanyName.Name = "lblCompanyName"
        lblCompanyName.Size = New Size(128, 21)
        lblCompanyName.TabIndex = 0
        lblCompanyName.Text = "Company Name"
        ' 
        ' txtInternshipStatus
        ' 
        txtInternshipStatus.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtInternshipStatus.BorderStyle = BorderStyle.FixedSingle
        txtInternshipStatus.Font = New Font("Segoe UI", 10.0F)
        txtInternshipStatus.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtInternshipStatus.Location = New Point(40, 144)
        txtInternshipStatus.Name = "txtInternshipStatus"
        txtInternshipStatus.ReadOnly = True
        txtInternshipStatus.Size = New Size(960, 30)
        txtInternshipStatus.TabIndex = 2
        ' 
        ' lblInternshipStatus
        ' 
        lblInternshipStatus.AutoSize = True
        lblInternshipStatus.Font = New Font("Segoe UI", 9.5F)
        lblInternshipStatus.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblInternshipStatus.Location = New Point(40, 120)
        lblInternshipStatus.Name = "lblInternshipStatus"
        lblInternshipStatus.Size = New Size(138, 21)
        lblInternshipStatus.TabIndex = 1
        lblInternshipStatus.Text = "Internship Status"
        ' 
        ' lblInternshipTitle
        ' 
        lblInternshipTitle.Dock = DockStyle.Top
        lblInternshipTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblInternshipTitle.ForeColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        lblInternshipTitle.Location = New Point(40, 40)
        lblInternshipTitle.Name = "lblInternshipTitle"
        lblInternshipTitle.Size = New Size(960, 48)
        lblInternshipTitle.TabIndex = 0
        lblInternshipTitle.Text = "INTERNSHIP DETAILS"
        ' 
        ' pnlVisitLogs
        ' 
        pnlVisitLogs.AutoScroll = True
        pnlVisitLogs.BackColor = Color.White
        pnlVisitLogs.Controls.Add(dgvVisitLogs)
        pnlVisitLogs.Controls.Add(txtVisitInternshipID)
        pnlVisitLogs.Controls.Add(lblVisitInternshipID)
        pnlVisitLogs.Controls.Add(lblVisitLogsTitle)
        pnlVisitLogs.Dock = DockStyle.Fill
        pnlVisitLogs.Location = New Point(32, 32)
        pnlVisitLogs.Name = "pnlVisitLogs"
        pnlVisitLogs.Padding = New Padding(40)
        pnlVisitLogs.Size = New Size(1040, 704)
        pnlVisitLogs.TabIndex = 2
        pnlVisitLogs.Visible = False
        ' 
        ' dgvVisitLogs
        ' 
        dgvVisitLogs.AllowUserToAddRows = False
        dgvVisitLogs.AllowUserToDeleteRows = False
        dgvVisitLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvVisitLogs.BackgroundColor = Color.White
        dgvVisitLogs.BorderStyle = BorderStyle.None
        dgvVisitLogs.ColumnHeadersHeight = 48
        dgvVisitLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvVisitLogs.Columns.AddRange(New DataGridViewColumn() {colVisitDate, colVisitType, colScore, colMaxScore, colRemarks, colDownload})
        dgvVisitLogs.Dock = DockStyle.Top
        dgvVisitLogs.GridColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        dgvVisitLogs.Location = New Point(40, 208)
        dgvVisitLogs.Name = "dgvVisitLogs"
        dgvVisitLogs.ReadOnly = True
        dgvVisitLogs.RowHeadersVisible = False
        dgvVisitLogs.RowHeadersWidth = 51
        dgvVisitLogs.RowTemplate.Height = 40
        dgvVisitLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVisitLogs.Size = New Size(960, 400)
        dgvVisitLogs.TabIndex = 3
        ' 
        ' colVisitDate
        ' 
        colVisitDate.HeaderText = "Visit Date"
        colVisitDate.MinimumWidth = 6
        colVisitDate.Name = "colVisitDate"
        colVisitDate.ReadOnly = True
        ' 
        ' colVisitType
        ' 
        colVisitType.HeaderText = "Type"
        colVisitType.MinimumWidth = 6
        colVisitType.Name = "colVisitType"
        colVisitType.ReadOnly = True
        ' 
        ' colScore
        ' 
        colScore.HeaderText = "Score"
        colScore.MinimumWidth = 6
        colScore.Name = "colScore"
        colScore.ReadOnly = True
        ' 
        ' colMaxScore
        ' 
        colMaxScore.HeaderText = "Max Score"
        colMaxScore.MinimumWidth = 6
        colMaxScore.Name = "colMaxScore"
        colMaxScore.ReadOnly = True
        ' 
        ' colRemarks
        ' 
        colRemarks.HeaderText = "Remarks"
        colRemarks.MinimumWidth = 6
        colRemarks.Name = "colRemarks"
        colRemarks.ReadOnly = True
        ' 
        ' colDownload
        ' 
        colDownload.HeaderText = "Download"
        colDownload.MinimumWidth = 6
        colDownload.Name = "colDownload"
        colDownload.ReadOnly = True
        colDownload.Text = "📥"
        colDownload.UseColumnTextForButtonValue = True
        ' 
        ' txtVisitInternshipID
        ' 
        txtVisitInternshipID.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtVisitInternshipID.BorderStyle = BorderStyle.FixedSingle
        txtVisitInternshipID.Font = New Font("Segoe UI", 10.0F)
        txtVisitInternshipID.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtVisitInternshipID.Location = New Point(40, 144)
        txtVisitInternshipID.Name = "txtVisitInternshipID"
        txtVisitInternshipID.ReadOnly = True
        txtVisitInternshipID.Size = New Size(960, 30)
        txtVisitInternshipID.TabIndex = 2
        ' 
        ' lblVisitInternshipID
        ' 
        lblVisitInternshipID.AutoSize = True
        lblVisitInternshipID.Font = New Font("Segoe UI", 9.5F)
        lblVisitInternshipID.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblVisitInternshipID.Location = New Point(40, 120)
        lblVisitInternshipID.Name = "lblVisitInternshipID"
        lblVisitInternshipID.Size = New Size(108, 21)
        lblVisitInternshipID.TabIndex = 1
        lblVisitInternshipID.Text = "Internship ID"
        ' 
        ' lblVisitLogsTitle
        ' 
        lblVisitLogsTitle.Dock = DockStyle.Top
        lblVisitLogsTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblVisitLogsTitle.ForeColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        lblVisitLogsTitle.Location = New Point(40, 40)
        lblVisitLogsTitle.Name = "lblVisitLogsTitle"
        lblVisitLogsTitle.Size = New Size(960, 48)
        lblVisitLogsTitle.TabIndex = 0
        lblVisitLogsTitle.Text = "VISIT LOGS"
        ' 
        ' pnlFinalGrade
        ' 
        pnlFinalGrade.AutoScroll = True
        pnlFinalGrade.BackColor = Color.White
        pnlFinalGrade.Controls.Add(btnDownloadReport)
        pnlFinalGrade.Controls.Add(txtGradedAt)
        pnlFinalGrade.Controls.Add(lblGradedAt)
        pnlFinalGrade.Controls.Add(txtEvaluatedBy)
        pnlFinalGrade.Controls.Add(lblEvaluatedBy)
        pnlFinalGrade.Controls.Add(lblFinalGradeValue)
        pnlFinalGrade.Controls.Add(lblFinalGradeLabel)
        pnlFinalGrade.Controls.Add(txtFinalInternshipStatus)
        pnlFinalGrade.Controls.Add(lblFinalInternshipStatus)
        pnlFinalGrade.Controls.Add(lblFinalGradeTitle)
        pnlFinalGrade.Dock = DockStyle.Fill
        pnlFinalGrade.Location = New Point(32, 32)
        pnlFinalGrade.Name = "pnlFinalGrade"
        pnlFinalGrade.Padding = New Padding(40)
        pnlFinalGrade.Size = New Size(1040, 704)
        pnlFinalGrade.TabIndex = 3
        pnlFinalGrade.Visible = False
        ' 
        ' btnDownloadReport
        ' 
        btnDownloadReport.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnDownloadReport.Cursor = Cursors.Hand
        btnDownloadReport.FlatAppearance.BorderSize = 0
        btnDownloadReport.FlatStyle = FlatStyle.Flat
        btnDownloadReport.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnDownloadReport.ForeColor = Color.White
        btnDownloadReport.Location = New Point(40, 544)
        btnDownloadReport.Name = "btnDownloadReport"
        btnDownloadReport.Size = New Size(240, 48)
        btnDownloadReport.TabIndex = 9
        btnDownloadReport.Text = "📥 Download Report"
        btnDownloadReport.UseVisualStyleBackColor = False
        ' 
        ' txtGradedAt
        ' 
        txtGradedAt.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtGradedAt.BorderStyle = BorderStyle.FixedSingle
        txtGradedAt.Font = New Font("Segoe UI", 10.0F)
        txtGradedAt.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtGradedAt.Location = New Point(544, 456)
        txtGradedAt.Name = "txtGradedAt"
        txtGradedAt.ReadOnly = True
        txtGradedAt.Size = New Size(456, 30)
        txtGradedAt.TabIndex = 8
        ' 
        ' lblGradedAt
        ' 
        lblGradedAt.AutoSize = True
        lblGradedAt.Font = New Font("Segoe UI", 9.5F)
        lblGradedAt.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblGradedAt.Location = New Point(544, 432)
        lblGradedAt.Name = "lblGradedAt"
        lblGradedAt.Size = New Size(83, 21)
        lblGradedAt.TabIndex = 7
        lblGradedAt.Text = "Graded At"
        ' 
        ' txtEvaluatedBy
        ' 
        txtEvaluatedBy.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtEvaluatedBy.BorderStyle = BorderStyle.FixedSingle
        txtEvaluatedBy.Font = New Font("Segoe UI", 10.0F)
        txtEvaluatedBy.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtEvaluatedBy.Location = New Point(40, 456)
        txtEvaluatedBy.Name = "txtEvaluatedBy"
        txtEvaluatedBy.ReadOnly = True
        txtEvaluatedBy.Size = New Size(480, 30)
        txtEvaluatedBy.TabIndex = 6
        ' 
        ' lblEvaluatedBy
        ' 
        lblEvaluatedBy.AutoSize = True
        lblEvaluatedBy.Font = New Font("Segoe UI", 9.5F)
        lblEvaluatedBy.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblEvaluatedBy.Location = New Point(40, 432)
        lblEvaluatedBy.Name = "lblEvaluatedBy"
        lblEvaluatedBy.Size = New Size(105, 21)
        lblEvaluatedBy.TabIndex = 5
        lblEvaluatedBy.Text = "Evaluated By"
        ' 
        ' lblFinalGradeValue
        ' 
        lblFinalGradeValue.Font = New Font("Segoe UI", 72.0F, FontStyle.Bold)
        lblFinalGradeValue.ForeColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblFinalGradeValue.Location = New Point(40, 232)
        lblFinalGradeValue.Name = "lblFinalGradeValue"
        lblFinalGradeValue.Size = New Size(960, 128)
        lblFinalGradeValue.TabIndex = 4
        lblFinalGradeValue.Text = "95.00"
        lblFinalGradeValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblFinalGradeLabel
        ' 
        lblFinalGradeLabel.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold)
        lblFinalGradeLabel.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblFinalGradeLabel.Location = New Point(40, 192)
        lblFinalGradeLabel.Name = "lblFinalGradeLabel"
        lblFinalGradeLabel.Size = New Size(960, 32)
        lblFinalGradeLabel.TabIndex = 3
        lblFinalGradeLabel.Text = "FINAL GRADE"
        lblFinalGradeLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtFinalInternshipStatus
        ' 
        txtFinalInternshipStatus.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        txtFinalInternshipStatus.BorderStyle = BorderStyle.FixedSingle
        txtFinalInternshipStatus.Font = New Font("Segoe UI", 10.0F)
        txtFinalInternshipStatus.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        txtFinalInternshipStatus.Location = New Point(40, 144)
        txtFinalInternshipStatus.Name = "txtFinalInternshipStatus"
        txtFinalInternshipStatus.ReadOnly = True
        txtFinalInternshipStatus.Size = New Size(960, 30)
        txtFinalInternshipStatus.TabIndex = 2
        ' 
        ' lblFinalInternshipStatus
        ' 
        lblFinalInternshipStatus.AutoSize = True
        lblFinalInternshipStatus.Font = New Font("Segoe UI", 9.5F)
        lblFinalInternshipStatus.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblFinalInternshipStatus.Location = New Point(40, 120)
        lblFinalInternshipStatus.Name = "lblFinalInternshipStatus"
        lblFinalInternshipStatus.Size = New Size(138, 21)
        lblFinalInternshipStatus.TabIndex = 1
        lblFinalInternshipStatus.Text = "Internship Status"
        ' 
        ' lblFinalGradeTitle
        ' 
        lblFinalGradeTitle.Dock = DockStyle.Top
        lblFinalGradeTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblFinalGradeTitle.ForeColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        lblFinalGradeTitle.Location = New Point(40, 40)
        lblFinalGradeTitle.Name = "lblFinalGradeTitle"
        lblFinalGradeTitle.Size = New Size(960, 48)
        lblFinalGradeTitle.TabIndex = 0
        lblFinalGradeTitle.Text = "FINAL GRADE"
        ' 
        ' frmOpening
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        ClientSize = New Size(1384, 768)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9.0F)
        MinimumSize = New Size(1400, 815)
        Name = "frmOpening"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OJT Management System - Student Dashboard"
        WindowState = FormWindowState.Maximized
        pnlSidebar.ResumeLayout(False)
        pnlSidebarHeader.ResumeLayout(False)
        CType(picUserAvatar, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlStudentProfile.ResumeLayout(False)
        pnlProfileActions.ResumeLayout(False)
        grpAcademicInfo.ResumeLayout(False)
        grpAcademicInfo.PerformLayout()
        grpPersonalInfo.ResumeLayout(False)
        grpPersonalInfo.PerformLayout()
        pnlInternshipDetails.ResumeLayout(False)
        pnlInternshipDetails.PerformLayout()
        grpOJTProgress.ResumeLayout(False)
        grpOJTProgress.PerformLayout()
        grpWorkSchedule.ResumeLayout(False)
        grpWorkSchedule.PerformLayout()
        grpSupervisorInfo.ResumeLayout(False)
        grpSupervisorInfo.PerformLayout()
        grpCompanyInfo.ResumeLayout(False)
        grpCompanyInfo.PerformLayout()
        pnlVisitLogs.ResumeLayout(False)
        pnlVisitLogs.PerformLayout()
        CType(dgvVisitLogs, ComponentModel.ISupportInitialize).EndInit()
        pnlFinalGrade.ResumeLayout(False)
        pnlFinalGrade.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlSidebarHeader As Panel
    Friend WithEvents lblSystemTitle As Label
    Friend WithEvents picUserAvatar As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblUserRole As Label
    Friend WithEvents btnStudentProfile As Button
    Friend WithEvents btnInternshipDetails As Button
    Friend WithEvents btnVisitLogs As Button
    Friend WithEvents btnFinalGrade As Button
    Friend WithEvents pnlSidebarBottom As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlStudentProfile As Panel
    Friend WithEvents lblProfileTitle As Label
    Friend WithEvents grpPersonalInfo As GroupBox
    Friend WithEvents lblStudentNumber As Label
    Friend WithEvents txtStudentNumber As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents txtBirthDate As TextBox
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents grpAcademicInfo As GroupBox
    Friend WithEvents txtSectionName As TextBox
    Friend WithEvents lblSection As Label
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents txtDepartmentName As TextBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents pnlProfileActions As Panel
    Friend WithEvents btnEditProfile As Button
    Friend WithEvents btnSaveProfile As Button
    Friend WithEvents pnlInternshipDetails As Panel
    Friend WithEvents lblInternshipTitle As Label
    Friend WithEvents lblInternshipStatus As Label
    Friend WithEvents txtInternshipStatus As TextBox
    Friend WithEvents grpCompanyInfo As GroupBox
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents txtCompanyAddress As TextBox
    Friend WithEvents lblCompanyAddress As Label
    Friend WithEvents txtCompanyCity As TextBox
    Friend WithEvents lblCompanyCity As Label
    Friend WithEvents txtIndustry As TextBox
    Friend WithEvents lblIndustry As Label
    Friend WithEvents grpSupervisorInfo As GroupBox
    Friend WithEvents txtSupervisorName As TextBox
    Friend WithEvents lblSupervisorName As Label
    Friend WithEvents txtSupervisorPosition As TextBox
    Friend WithEvents lblSupervisorPosition As Label
    Friend WithEvents txtSupervisorContact As TextBox
    Friend WithEvents lblSupervisorContact As Label
    Friend WithEvents grpWorkSchedule As GroupBox
    Friend WithEvents txtWorkDays As TextBox
    Friend WithEvents lblWorkDays As Label
    Friend WithEvents txtStartTime As TextBox
    Friend WithEvents lblStartTime As Label
    Friend WithEvents txtEndTime As TextBox
    Friend WithEvents lblEndTime As Label
    Friend WithEvents grpOJTProgress As GroupBox
    Friend WithEvents txtRequiredHours As TextBox
    Friend WithEvents lblRequiredHours As Label
    Friend WithEvents txtCompletedHours As TextBox
    Friend WithEvents lblCompletedHours As Label
    Friend WithEvents progressOJTHours As ProgressBar
    Friend WithEvents lblProgressPercentage As Label
    Friend WithEvents pnlVisitLogs As Panel
    Friend WithEvents lblVisitLogsTitle As Label
    Friend WithEvents lblVisitInternshipID As Label
    Friend WithEvents txtVisitInternshipID As TextBox
    Friend WithEvents dgvVisitLogs As DataGridView
    Friend WithEvents colVisitDate As DataGridViewTextBoxColumn
    Friend WithEvents colVisitType As DataGridViewTextBoxColumn
    Friend WithEvents colScore As DataGridViewTextBoxColumn
    Friend WithEvents colMaxScore As DataGridViewTextBoxColumn
    Friend WithEvents colRemarks As DataGridViewTextBoxColumn
    Friend WithEvents colDownload As DataGridViewButtonColumn
    Friend WithEvents pnlFinalGrade As Panel
    Friend WithEvents lblFinalGradeTitle As Label
    Friend WithEvents lblFinalInternshipStatus As Label
    Friend WithEvents txtFinalInternshipStatus As TextBox
    Friend WithEvents lblFinalGradeLabel As Label
    Friend WithEvents lblFinalGradeValue As Label
    Friend WithEvents lblEvaluatedBy As Label
    Friend WithEvents txtEvaluatedBy As TextBox
    Friend WithEvents lblGradedAt As Label
    Friend WithEvents txtGradedAt As TextBox
    Friend WithEvents btnDownloadReport As Button

End Class