<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        lblStudentRole = New Label()
        lblStudentName = New Label()
        lblAppTitle = New Label()
        pnlVisitLogs = New Panel()
        lblVisitLogsListHeader = New Label()
        lblVisitLogsTitle = New Label()
        dgvVisitLogs = New DataGridView()
        pnlSidebar = New Panel()
        btnLogout = New Button()
        btnFinalGrade = New Button()
        btnVisitLogs = New Button()
        btnInternshipDetails = New Button()
        btnStudentProfile = New Button()
        lblSidebarTitle = New Label()
        pnlContent = New Panel()
        pnlInternshipDetails = New Panel()
        cboSelectInternship = New ComboBox()
        lblSelectInternship = New Label()
        lblHoursProgress = New Label()
        lblCompletedHoursCaption = New Label()
        lblRequiredHoursCaption = New Label()
        lblOjtHoursHeader = New Label()
        lblEndTimeCaption = New Label()
        lblStartTimeCaption = New Label()
        lblWorkDaysCaption = New Label()
        lblWorkScheduleHeader = New Label()
        lblSupervisorContactCaption = New Label()
        lblSupervisorPositionCaption = New Label()
        lblSupervisorNameCaption = New Label()
        lblSupervisorInfoHeader = New Label()
        lblIndustryCaption = New Label()
        lblCompanyCityCaption = New Label()
        lblCompanyAddressCaption = New Label()
        lblCompanyNameCaption = New Label()
        lblCompanyInfoHeader = New Label()
        lblInternshipStatusCaption = New Label()
        progressHours = New ProgressBar()
        txtCompletedHours = New TextBox()
        txtRequiredHours = New TextBox()
        txtEndTime = New TextBox()
        txtStartTime = New TextBox()
        txtWorkDays = New TextBox()
        txtSupervisorContact = New TextBox()
        txtSupervisorPosition = New TextBox()
        txtSupervisorName = New TextBox()
        txtIndustry = New TextBox()
        txtCompanyCity = New TextBox()
        txtCompanyAddress = New TextBox()
        txtCompanyName = New TextBox()
        txtInternshipStatus = New TextBox()
        lblInternshipTitle = New Label()
        pnlFinalGrade = New Panel()
        lblFinalGradeTitle = New Label()
        txtFinalInternshipStatus = New TextBox()
        lblFinalInternshipStatusCaption = New Label()
        lblFinalGradeCaption = New Label()
        lblFinalGradeValue = New Label()
        lblEvaluatedByCaption = New Label()
        lblGradedAtCaption = New Label()
        txtEvaluatedBy = New TextBox()
        txtGradedAt = New TextBox()
        btnDownloadReport = New Button()
        lblFinalReportCaption = New Label()
        pnlStudentProfile = New Panel()
        chkShowPassword = New CheckBox()
        Label1 = New Label()
        txtConfirmPassword = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        lblAcademicInfoHeader = New Label()
        lblContactInfoHeader = New Label()
        lblDepartmentCaption = New Label()
        lblCourseCaption = New Label()
        lblSectionCaption = New Label()
        lblCityCaption = New Label()
        lblAddressCaption = New Label()
        lblContactCaption = New Label()
        lblEmailCaption = New Label()
        lblStatusCaption = New Label()
        lblBirthDateCaption = New Label()
        lblGenderCaption = New Label()
        lblFullNameCaption = New Label()
        lblStudentNumberCaption = New Label()
        btnCancelEditProfile = New Button()
        btnSaveProfile = New Button()
        btnEditProfile = New Button()
        txtDepartmentName = New TextBox()
        txtCourseName = New TextBox()
        txtSectionName = New TextBox()
        txtCity = New TextBox()
        txtAddress = New TextBox()
        txtContactNumber = New TextBox()
        txtEmail = New TextBox()
        txtStatus = New TextBox()
        txtBirthDate = New TextBox()
        txtGender = New TextBox()
        txtFullName = New TextBox()
        txtStudentNumber = New TextBox()
        lblProfileTitle = New Label()
        pnlHeader.SuspendLayout()
        pnlVisitLogs.SuspendLayout()
        CType(dgvVisitLogs, ComponentModel.ISupportInitialize).BeginInit()
        pnlSidebar.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlInternshipDetails.SuspendLayout()
        pnlFinalGrade.SuspendLayout()
        pnlStudentProfile.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        pnlHeader.Controls.Add(lblStudentRole)
        pnlHeader.Controls.Add(lblStudentName)
        pnlHeader.Controls.Add(lblAppTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1371, 93)
        pnlHeader.TabIndex = 0
        ' 
        ' lblStudentRole
        ' 
        lblStudentRole.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblStudentRole.AutoSize = True
        lblStudentRole.Font = New Font("Segoe UI", 9F)
        lblStudentRole.ForeColor = Color.White
        lblStudentRole.Location = New Point(1189, 53)
        lblStudentRole.Name = "lblStudentRole"
        lblStudentRole.Size = New Size(60, 20)
        lblStudentRole.TabIndex = 2
        lblStudentRole.Text = "Student"
        ' 
        ' lblStudentName
        ' 
        lblStudentName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblStudentName.AutoSize = True
        lblStudentName.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblStudentName.ForeColor = Color.White
        lblStudentName.Location = New Point(1189, 24)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(125, 23)
        lblStudentName.TabIndex = 1
        lblStudentName.Text = "Juan Dela Cruz"
        ' 
        ' lblAppTitle
        ' 
        lblAppTitle.AutoSize = True
        lblAppTitle.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        lblAppTitle.ForeColor = Color.White
        lblAppTitle.Location = New Point(27, 24)
        lblAppTitle.Name = "lblAppTitle"
        lblAppTitle.Size = New Size(370, 37)
        lblAppTitle.TabIndex = 0
        lblAppTitle.Text = "OJT Management — Student"
        ' 
        ' pnlVisitLogs
        ' 
        pnlVisitLogs.BackColor = Color.White
        pnlVisitLogs.Controls.Add(lblVisitLogsListHeader)
        pnlVisitLogs.Controls.Add(lblVisitLogsTitle)
        pnlVisitLogs.Controls.Add(dgvVisitLogs)
        pnlVisitLogs.Dock = DockStyle.Fill
        pnlVisitLogs.Location = New Point(0, 0)
        pnlVisitLogs.Margin = New Padding(3, 4, 3, 4)
        pnlVisitLogs.Name = "pnlVisitLogs"
        pnlVisitLogs.Size = New Size(1120, 867)
        pnlVisitLogs.TabIndex = 2
        pnlVisitLogs.Visible = False
        ' 
        ' lblVisitLogsListHeader
        ' 
        lblVisitLogsListHeader.AutoSize = True
        lblVisitLogsListHeader.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblVisitLogsListHeader.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblVisitLogsListHeader.Location = New Point(46, 148)
        lblVisitLogsListHeader.Name = "lblVisitLogsListHeader"
        lblVisitLogsListHeader.Size = New Size(112, 23)
        lblVisitLogsListHeader.TabIndex = 4
        lblVisitLogsListHeader.Text = "Visit Logs List"
        ' 
        ' lblVisitLogsTitle
        ' 
        lblVisitLogsTitle.AutoSize = True
        lblVisitLogsTitle.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        lblVisitLogsTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblVisitLogsTitle.Location = New Point(37, 32)
        lblVisitLogsTitle.Name = "lblVisitLogsTitle"
        lblVisitLogsTitle.Size = New Size(153, 37)
        lblVisitLogsTitle.TabIndex = 0
        lblVisitLogsTitle.Text = "VISIT LOGS"
        ' 
        ' dgvVisitLogs
        ' 
        dgvVisitLogs.AllowUserToAddRows = False
        dgvVisitLogs.AllowUserToDeleteRows = False
        dgvVisitLogs.BackgroundColor = Color.White
        dgvVisitLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVisitLogs.Location = New Point(46, 176)
        dgvVisitLogs.Margin = New Padding(3, 4, 3, 4)
        dgvVisitLogs.Name = "dgvVisitLogs"
        dgvVisitLogs.RowHeadersVisible = False
        dgvVisitLogs.RowHeadersWidth = 51
        dgvVisitLogs.RowTemplate.Height = 25
        dgvVisitLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVisitLogs.Size = New Size(1006, 600)
        dgvVisitLogs.TabIndex = 2
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnFinalGrade)
        pnlSidebar.Controls.Add(btnVisitLogs)
        pnlSidebar.Controls.Add(btnInternshipDetails)
        pnlSidebar.Controls.Add(btnStudentProfile)
        pnlSidebar.Controls.Add(lblSidebarTitle)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 93)
        pnlSidebar.Margin = New Padding(3, 4, 3, 4)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(251, 867)
        pnlSidebar.TabIndex = 1
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnLogout.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(18, 773)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(215, 53)
        btnLogout.TabIndex = 5
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnFinalGrade
        ' 
        btnFinalGrade.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        btnFinalGrade.FlatAppearance.BorderSize = 0
        btnFinalGrade.FlatStyle = FlatStyle.Flat
        btnFinalGrade.Font = New Font("Segoe UI", 10F)
        btnFinalGrade.ForeColor = Color.White
        btnFinalGrade.Location = New Point(18, 307)
        btnFinalGrade.Margin = New Padding(3, 4, 3, 4)
        btnFinalGrade.Name = "btnFinalGrade"
        btnFinalGrade.Size = New Size(215, 53)
        btnFinalGrade.TabIndex = 4
        btnFinalGrade.Text = "Final Grade"
        btnFinalGrade.UseVisualStyleBackColor = False
        ' 
        ' btnVisitLogs
        ' 
        btnVisitLogs.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        btnVisitLogs.FlatAppearance.BorderSize = 0
        btnVisitLogs.FlatStyle = FlatStyle.Flat
        btnVisitLogs.Font = New Font("Segoe UI", 10F)
        btnVisitLogs.ForeColor = Color.White
        btnVisitLogs.Location = New Point(18, 245)
        btnVisitLogs.Margin = New Padding(3, 4, 3, 4)
        btnVisitLogs.Name = "btnVisitLogs"
        btnVisitLogs.Size = New Size(215, 53)
        btnVisitLogs.TabIndex = 3
        btnVisitLogs.Text = "Visit Logs"
        btnVisitLogs.UseVisualStyleBackColor = False
        ' 
        ' btnInternshipDetails
        ' 
        btnInternshipDetails.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        btnInternshipDetails.FlatAppearance.BorderSize = 0
        btnInternshipDetails.FlatStyle = FlatStyle.Flat
        btnInternshipDetails.Font = New Font("Segoe UI", 10F)
        btnInternshipDetails.ForeColor = Color.White
        btnInternshipDetails.Location = New Point(18, 184)
        btnInternshipDetails.Margin = New Padding(3, 4, 3, 4)
        btnInternshipDetails.Name = "btnInternshipDetails"
        btnInternshipDetails.Size = New Size(215, 53)
        btnInternshipDetails.TabIndex = 2
        btnInternshipDetails.Text = "Internship Details"
        btnInternshipDetails.UseVisualStyleBackColor = False
        ' 
        ' btnStudentProfile
        ' 
        btnStudentProfile.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        btnStudentProfile.FlatAppearance.BorderSize = 0
        btnStudentProfile.FlatStyle = FlatStyle.Flat
        btnStudentProfile.Font = New Font("Segoe UI", 10F)
        btnStudentProfile.ForeColor = Color.White
        btnStudentProfile.Location = New Point(18, 123)
        btnStudentProfile.Margin = New Padding(3, 4, 3, 4)
        btnStudentProfile.Name = "btnStudentProfile"
        btnStudentProfile.Size = New Size(215, 53)
        btnStudentProfile.TabIndex = 1
        btnStudentProfile.Text = "Student Profile"
        btnStudentProfile.UseVisualStyleBackColor = False
        ' 
        ' lblSidebarTitle
        ' 
        lblSidebarTitle.AutoSize = True
        lblSidebarTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblSidebarTitle.ForeColor = Color.FromArgb(CByte(255), CByte(235), CByte(59))
        lblSidebarTitle.Location = New Point(27, 26)
        lblSidebarTitle.Name = "lblSidebarTitle"
        lblSidebarTitle.Size = New Size(187, 28)
        lblSidebarTitle.TabIndex = 0
        lblSidebarTitle.Text = "Student Dashboard"
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        pnlContent.Controls.Add(pnlFinalGrade)
        pnlContent.Controls.Add(pnlStudentProfile)
        pnlContent.Controls.Add(pnlInternshipDetails)
        pnlContent.Controls.Add(pnlVisitLogs)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(251, 93)
        pnlContent.Margin = New Padding(3, 4, 3, 4)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1120, 867)
        pnlContent.TabIndex = 2
        ' 
        ' pnlInternshipDetails
        ' 
        pnlInternshipDetails.BackColor = Color.White
        pnlInternshipDetails.Controls.Add(cboSelectInternship)
        pnlInternshipDetails.Controls.Add(lblSelectInternship)
        pnlInternshipDetails.Controls.Add(lblHoursProgress)
        pnlInternshipDetails.Controls.Add(lblCompletedHoursCaption)
        pnlInternshipDetails.Controls.Add(lblRequiredHoursCaption)
        pnlInternshipDetails.Controls.Add(lblOjtHoursHeader)
        pnlInternshipDetails.Controls.Add(lblEndTimeCaption)
        pnlInternshipDetails.Controls.Add(lblStartTimeCaption)
        pnlInternshipDetails.Controls.Add(lblWorkDaysCaption)
        pnlInternshipDetails.Controls.Add(lblWorkScheduleHeader)
        pnlInternshipDetails.Controls.Add(lblSupervisorContactCaption)
        pnlInternshipDetails.Controls.Add(lblSupervisorPositionCaption)
        pnlInternshipDetails.Controls.Add(lblSupervisorNameCaption)
        pnlInternshipDetails.Controls.Add(lblSupervisorInfoHeader)
        pnlInternshipDetails.Controls.Add(lblIndustryCaption)
        pnlInternshipDetails.Controls.Add(lblCompanyCityCaption)
        pnlInternshipDetails.Controls.Add(lblCompanyAddressCaption)
        pnlInternshipDetails.Controls.Add(lblCompanyNameCaption)
        pnlInternshipDetails.Controls.Add(lblCompanyInfoHeader)
        pnlInternshipDetails.Controls.Add(lblInternshipStatusCaption)
        pnlInternshipDetails.Controls.Add(progressHours)
        pnlInternshipDetails.Controls.Add(txtCompletedHours)
        pnlInternshipDetails.Controls.Add(txtRequiredHours)
        pnlInternshipDetails.Controls.Add(txtEndTime)
        pnlInternshipDetails.Controls.Add(txtStartTime)
        pnlInternshipDetails.Controls.Add(txtWorkDays)
        pnlInternshipDetails.Controls.Add(txtSupervisorContact)
        pnlInternshipDetails.Controls.Add(txtSupervisorPosition)
        pnlInternshipDetails.Controls.Add(txtSupervisorName)
        pnlInternshipDetails.Controls.Add(txtIndustry)
        pnlInternshipDetails.Controls.Add(txtCompanyCity)
        pnlInternshipDetails.Controls.Add(txtCompanyAddress)
        pnlInternshipDetails.Controls.Add(txtCompanyName)
        pnlInternshipDetails.Controls.Add(txtInternshipStatus)
        pnlInternshipDetails.Controls.Add(lblInternshipTitle)
        pnlInternshipDetails.Dock = DockStyle.Fill
        pnlInternshipDetails.Location = New Point(0, 0)
        pnlInternshipDetails.Margin = New Padding(3, 4, 3, 4)
        pnlInternshipDetails.Name = "pnlInternshipDetails"
        pnlInternshipDetails.Size = New Size(1120, 867)
        pnlInternshipDetails.TabIndex = 1
        pnlInternshipDetails.Visible = False
        ' 
        ' cboSelectInternship
        ' 
        cboSelectInternship.DropDownStyle = ComboBoxStyle.DropDownList
        cboSelectInternship.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboSelectInternship.FormattingEnabled = True
        cboSelectInternship.Location = New Point(208, 79)
        cboSelectInternship.Name = "cboSelectInternship"
        cboSelectInternship.Size = New Size(350, 31)
        cboSelectInternship.TabIndex = 35
        ' 
        ' lblSelectInternship
        ' 
        lblSelectInternship.AutoSize = True
        lblSelectInternship.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSelectInternship.Location = New Point(38, 80)
        lblSelectInternship.Name = "lblSelectInternship"
        lblSelectInternship.Size = New Size(146, 25)
        lblSelectInternship.TabIndex = 34
        lblSelectInternship.Text = "Select Internship:"
        ' 
        ' lblHoursProgress
        ' 
        lblHoursProgress.AutoSize = True
        lblHoursProgress.Font = New Font("Segoe UI", 9F)
        lblHoursProgress.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblHoursProgress.Location = New Point(737, 266)
        lblHoursProgress.Name = "lblHoursProgress"
        lblHoursProgress.Size = New Size(68, 20)
        lblHoursProgress.TabIndex = 33
        lblHoursProgress.Text = "Progress:"
        ' 
        ' lblCompletedHoursCaption
        ' 
        lblCompletedHoursCaption.AutoSize = True
        lblCompletedHoursCaption.Font = New Font("Segoe UI", 9F)
        lblCompletedHoursCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCompletedHoursCaption.Location = New Point(737, 238)
        lblCompletedHoursCaption.Name = "lblCompletedHoursCaption"
        lblCompletedHoursCaption.Size = New Size(129, 20)
        lblCompletedHoursCaption.TabIndex = 32
        lblCompletedHoursCaption.Text = "Completed Hours:"
        ' 
        ' lblRequiredHoursCaption
        ' 
        lblRequiredHoursCaption.AutoSize = True
        lblRequiredHoursCaption.Font = New Font("Segoe UI", 9F)
        lblRequiredHoursCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblRequiredHoursCaption.Location = New Point(737, 184)
        lblRequiredHoursCaption.Name = "lblRequiredHoursCaption"
        lblRequiredHoursCaption.Size = New Size(115, 20)
        lblRequiredHoursCaption.TabIndex = 31
        lblRequiredHoursCaption.Text = "Required Hours:"
        ' 
        ' lblOjtHoursHeader
        ' 
        lblOjtHoursHeader.AutoSize = True
        lblOjtHoursHeader.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblOjtHoursHeader.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblOjtHoursHeader.Location = New Point(737, 146)
        lblOjtHoursHeader.Name = "lblOjtHoursHeader"
        lblOjtHoursHeader.Size = New Size(126, 23)
        lblOjtHoursHeader.TabIndex = 30
        lblOjtHoursHeader.Text = "OJT Hours Info"
        ' 
        ' lblEndTimeCaption
        ' 
        lblEndTimeCaption.AutoSize = True
        lblEndTimeCaption.Font = New Font("Segoe UI", 9F)
        lblEndTimeCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblEndTimeCaption.Location = New Point(412, 798)
        lblEndTimeCaption.Name = "lblEndTimeCaption"
        lblEndTimeCaption.Size = New Size(74, 20)
        lblEndTimeCaption.TabIndex = 29
        lblEndTimeCaption.Text = "End Time:"
        ' 
        ' lblStartTimeCaption
        ' 
        lblStartTimeCaption.AutoSize = True
        lblStartTimeCaption.Font = New Font("Segoe UI", 9F)
        lblStartTimeCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblStartTimeCaption.Location = New Point(46, 798)
        lblStartTimeCaption.Name = "lblStartTimeCaption"
        lblStartTimeCaption.Size = New Size(80, 20)
        lblStartTimeCaption.TabIndex = 28
        lblStartTimeCaption.Text = "Start Time:"
        ' 
        ' lblWorkDaysCaption
        ' 
        lblWorkDaysCaption.AutoSize = True
        lblWorkDaysCaption.Font = New Font("Segoe UI", 9F)
        lblWorkDaysCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblWorkDaysCaption.Location = New Point(46, 744)
        lblWorkDaysCaption.Name = "lblWorkDaysCaption"
        lblWorkDaysCaption.Size = New Size(82, 20)
        lblWorkDaysCaption.TabIndex = 27
        lblWorkDaysCaption.Text = "Work Days:"
        ' 
        ' lblWorkScheduleHeader
        ' 
        lblWorkScheduleHeader.AutoSize = True
        lblWorkScheduleHeader.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblWorkScheduleHeader.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblWorkScheduleHeader.Location = New Point(37, 706)
        lblWorkScheduleHeader.Name = "lblWorkScheduleHeader"
        lblWorkScheduleHeader.Size = New Size(125, 23)
        lblWorkScheduleHeader.TabIndex = 26
        lblWorkScheduleHeader.Text = "Work Schedule"
        ' 
        ' lblSupervisorContactCaption
        ' 
        lblSupervisorContactCaption.AutoSize = True
        lblSupervisorContactCaption.Font = New Font("Segoe UI", 9F)
        lblSupervisorContactCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblSupervisorContactCaption.Location = New Point(46, 624)
        lblSupervisorContactCaption.Name = "lblSupervisorContactCaption"
        lblSupervisorContactCaption.Size = New Size(121, 20)
        lblSupervisorContactCaption.TabIndex = 25
        lblSupervisorContactCaption.Text = "Contact Number:"
        ' 
        ' lblSupervisorPositionCaption
        ' 
        lblSupervisorPositionCaption.AutoSize = True
        lblSupervisorPositionCaption.Font = New Font("Segoe UI", 9F)
        lblSupervisorPositionCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblSupervisorPositionCaption.Location = New Point(46, 571)
        lblSupervisorPositionCaption.Name = "lblSupervisorPositionCaption"
        lblSupervisorPositionCaption.Size = New Size(97, 20)
        lblSupervisorPositionCaption.TabIndex = 24
        lblSupervisorPositionCaption.Text = "Position Title:"
        ' 
        ' lblSupervisorNameCaption
        ' 
        lblSupervisorNameCaption.AutoSize = True
        lblSupervisorNameCaption.Font = New Font("Segoe UI", 9F)
        lblSupervisorNameCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblSupervisorNameCaption.Location = New Point(46, 518)
        lblSupervisorNameCaption.Name = "lblSupervisorNameCaption"
        lblSupervisorNameCaption.Size = New Size(125, 20)
        lblSupervisorNameCaption.TabIndex = 23
        lblSupervisorNameCaption.Text = "Supervisor Name:"
        ' 
        ' lblSupervisorInfoHeader
        ' 
        lblSupervisorInfoHeader.AutoSize = True
        lblSupervisorInfoHeader.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblSupervisorInfoHeader.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblSupervisorInfoHeader.Location = New Point(37, 467)
        lblSupervisorInfoHeader.Name = "lblSupervisorInfoHeader"
        lblSupervisorInfoHeader.Size = New Size(187, 23)
        lblSupervisorInfoHeader.TabIndex = 22
        lblSupervisorInfoHeader.Text = "Supervisor Information"
        ' 
        ' lblIndustryCaption
        ' 
        lblIndustryCaption.AutoSize = True
        lblIndustryCaption.Font = New Font("Segoe UI", 9F)
        lblIndustryCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblIndustryCaption.Location = New Point(46, 398)
        lblIndustryCaption.Name = "lblIndustryCaption"
        lblIndustryCaption.Size = New Size(64, 20)
        lblIndustryCaption.TabIndex = 21
        lblIndustryCaption.Text = "Industry:"
        ' 
        ' lblCompanyCityCaption
        ' 
        lblCompanyCityCaption.AutoSize = True
        lblCompanyCityCaption.Font = New Font("Segoe UI", 9F)
        lblCompanyCityCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCompanyCityCaption.Location = New Point(46, 344)
        lblCompanyCityCaption.Name = "lblCompanyCityCaption"
        lblCompanyCityCaption.Size = New Size(37, 20)
        lblCompanyCityCaption.TabIndex = 20
        lblCompanyCityCaption.Text = "City:"
        ' 
        ' lblCompanyAddressCaption
        ' 
        lblCompanyAddressCaption.AutoSize = True
        lblCompanyAddressCaption.Font = New Font("Segoe UI", 9F)
        lblCompanyAddressCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCompanyAddressCaption.Location = New Point(46, 291)
        lblCompanyAddressCaption.Name = "lblCompanyAddressCaption"
        lblCompanyAddressCaption.Size = New Size(65, 20)
        lblCompanyAddressCaption.TabIndex = 19
        lblCompanyAddressCaption.Text = "Address:"
        ' 
        ' lblCompanyNameCaption
        ' 
        lblCompanyNameCaption.AutoSize = True
        lblCompanyNameCaption.Font = New Font("Segoe UI", 9F)
        lblCompanyNameCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCompanyNameCaption.Location = New Point(46, 238)
        lblCompanyNameCaption.Name = "lblCompanyNameCaption"
        lblCompanyNameCaption.Size = New Size(119, 20)
        lblCompanyNameCaption.TabIndex = 18
        lblCompanyNameCaption.Text = "Company Name:"
        ' 
        ' lblCompanyInfoHeader
        ' 
        lblCompanyInfoHeader.AutoSize = True
        lblCompanyInfoHeader.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblCompanyInfoHeader.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCompanyInfoHeader.Location = New Point(37, 200)
        lblCompanyInfoHeader.Name = "lblCompanyInfoHeader"
        lblCompanyInfoHeader.Size = New Size(180, 23)
        lblCompanyInfoHeader.TabIndex = 17
        lblCompanyInfoHeader.Text = "Company Information"
        ' 
        ' lblInternshipStatusCaption
        ' 
        lblInternshipStatusCaption.AutoSize = True
        lblInternshipStatusCaption.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblInternshipStatusCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblInternshipStatusCaption.Location = New Point(37, 137)
        lblInternshipStatusCaption.Name = "lblInternshipStatusCaption"
        lblInternshipStatusCaption.Size = New Size(143, 23)
        lblInternshipStatusCaption.TabIndex = 16
        lblInternshipStatusCaption.Text = "Internship Status:"
        ' 
        ' progressHours
        ' 
        progressHours.Location = New Point(737, 290)
        progressHours.Margin = New Padding(3, 4, 3, 4)
        progressHours.Name = "progressHours"
        progressHours.Size = New Size(331, 31)
        progressHours.TabIndex = 14
        ' 
        ' txtCompletedHours
        ' 
        txtCompletedHours.Location = New Point(888, 234)
        txtCompletedHours.Margin = New Padding(3, 4, 3, 4)
        txtCompletedHours.Name = "txtCompletedHours"
        txtCompletedHours.ReadOnly = True
        txtCompletedHours.Size = New Size(180, 27)
        txtCompletedHours.TabIndex = 13
        ' 
        ' txtRequiredHours
        ' 
        txtRequiredHours.Location = New Point(888, 180)
        txtRequiredHours.Margin = New Padding(3, 4, 3, 4)
        txtRequiredHours.Name = "txtRequiredHours"
        txtRequiredHours.ReadOnly = True
        txtRequiredHours.Size = New Size(180, 27)
        txtRequiredHours.TabIndex = 12
        ' 
        ' txtEndTime
        ' 
        txtEndTime.Location = New Point(494, 794)
        txtEndTime.Margin = New Padding(3, 4, 3, 4)
        txtEndTime.Name = "txtEndTime"
        txtEndTime.ReadOnly = True
        txtEndTime.Size = New Size(166, 27)
        txtEndTime.TabIndex = 11
        ' 
        ' txtStartTime
        ' 
        txtStartTime.Location = New Point(208, 794)
        txtStartTime.Margin = New Padding(3, 4, 3, 4)
        txtStartTime.Name = "txtStartTime"
        txtStartTime.ReadOnly = True
        txtStartTime.Size = New Size(182, 27)
        txtStartTime.TabIndex = 10
        ' 
        ' txtWorkDays
        ' 
        txtWorkDays.Location = New Point(208, 740)
        txtWorkDays.Margin = New Padding(3, 4, 3, 4)
        txtWorkDays.Name = "txtWorkDays"
        txtWorkDays.ReadOnly = True
        txtWorkDays.Size = New Size(297, 27)
        txtWorkDays.TabIndex = 9
        ' 
        ' txtSupervisorContact
        ' 
        txtSupervisorContact.Location = New Point(208, 620)
        txtSupervisorContact.Margin = New Padding(3, 4, 3, 4)
        txtSupervisorContact.Name = "txtSupervisorContact"
        txtSupervisorContact.ReadOnly = True
        txtSupervisorContact.Size = New Size(297, 27)
        txtSupervisorContact.TabIndex = 8
        ' 
        ' txtSupervisorPosition
        ' 
        txtSupervisorPosition.Location = New Point(208, 567)
        txtSupervisorPosition.Margin = New Padding(3, 4, 3, 4)
        txtSupervisorPosition.Name = "txtSupervisorPosition"
        txtSupervisorPosition.ReadOnly = True
        txtSupervisorPosition.Size = New Size(342, 27)
        txtSupervisorPosition.TabIndex = 7
        ' 
        ' txtSupervisorName
        ' 
        txtSupervisorName.Location = New Point(208, 514)
        txtSupervisorName.Margin = New Padding(3, 4, 3, 4)
        txtSupervisorName.Name = "txtSupervisorName"
        txtSupervisorName.ReadOnly = True
        txtSupervisorName.Size = New Size(342, 27)
        txtSupervisorName.TabIndex = 6
        ' 
        ' txtIndustry
        ' 
        txtIndustry.Location = New Point(208, 394)
        txtIndustry.Margin = New Padding(3, 4, 3, 4)
        txtIndustry.Name = "txtIndustry"
        txtIndustry.ReadOnly = True
        txtIndustry.Size = New Size(454, 27)
        txtIndustry.TabIndex = 5
        ' 
        ' txtCompanyCity
        ' 
        txtCompanyCity.Location = New Point(208, 340)
        txtCompanyCity.Margin = New Padding(3, 4, 3, 4)
        txtCompanyCity.Name = "txtCompanyCity"
        txtCompanyCity.ReadOnly = True
        txtCompanyCity.Size = New Size(297, 27)
        txtCompanyCity.TabIndex = 4
        ' 
        ' txtCompanyAddress
        ' 
        txtCompanyAddress.Location = New Point(208, 287)
        txtCompanyAddress.Margin = New Padding(3, 4, 3, 4)
        txtCompanyAddress.Name = "txtCompanyAddress"
        txtCompanyAddress.ReadOnly = True
        txtCompanyAddress.Size = New Size(454, 27)
        txtCompanyAddress.TabIndex = 3
        ' 
        ' txtCompanyName
        ' 
        txtCompanyName.Location = New Point(208, 234)
        txtCompanyName.Margin = New Padding(3, 4, 3, 4)
        txtCompanyName.Name = "txtCompanyName"
        txtCompanyName.ReadOnly = True
        txtCompanyName.Size = New Size(454, 27)
        txtCompanyName.TabIndex = 2
        ' 
        ' txtInternshipStatus
        ' 
        txtInternshipStatus.Location = New Point(208, 134)
        txtInternshipStatus.Margin = New Padding(3, 4, 3, 4)
        txtInternshipStatus.Name = "txtInternshipStatus"
        txtInternshipStatus.ReadOnly = True
        txtInternshipStatus.Size = New Size(297, 27)
        txtInternshipStatus.TabIndex = 1
        ' 
        ' lblInternshipTitle
        ' 
        lblInternshipTitle.AutoSize = True
        lblInternshipTitle.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        lblInternshipTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblInternshipTitle.Location = New Point(37, 32)
        lblInternshipTitle.Name = "lblInternshipTitle"
        lblInternshipTitle.Size = New Size(279, 37)
        lblInternshipTitle.TabIndex = 0
        lblInternshipTitle.Text = "INTERNSHIP DETAILS"
        ' 
        ' pnlFinalGrade
        ' 
        pnlFinalGrade.BackColor = Color.White
        pnlFinalGrade.Controls.Add(lblFinalGradeTitle)
        pnlFinalGrade.Controls.Add(txtFinalInternshipStatus)
        pnlFinalGrade.Controls.Add(lblFinalInternshipStatusCaption)
        pnlFinalGrade.Controls.Add(lblFinalGradeCaption)
        pnlFinalGrade.Controls.Add(lblFinalGradeValue)
        pnlFinalGrade.Controls.Add(lblEvaluatedByCaption)
        pnlFinalGrade.Controls.Add(lblGradedAtCaption)
        pnlFinalGrade.Controls.Add(txtEvaluatedBy)
        pnlFinalGrade.Controls.Add(txtGradedAt)
        pnlFinalGrade.Controls.Add(btnDownloadReport)
        pnlFinalGrade.Controls.Add(lblFinalReportCaption)
        pnlFinalGrade.Dock = DockStyle.Fill
        pnlFinalGrade.Location = New Point(0, 0)
        pnlFinalGrade.Margin = New Padding(3, 4, 3, 4)
        pnlFinalGrade.Name = "pnlFinalGrade"
        pnlFinalGrade.Size = New Size(1120, 867)
        pnlFinalGrade.TabIndex = 3
        pnlFinalGrade.Visible = False
        ' 
        ' lblFinalGradeTitle
        ' 
        lblFinalGradeTitle.AutoSize = True
        lblFinalGradeTitle.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        lblFinalGradeTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblFinalGradeTitle.Location = New Point(37, 32)
        lblFinalGradeTitle.Name = "lblFinalGradeTitle"
        lblFinalGradeTitle.Size = New Size(185, 37)
        lblFinalGradeTitle.TabIndex = 0
        lblFinalGradeTitle.Text = "FINAL GRADE"
        ' 
        ' txtFinalInternshipStatus
        ' 
        txtFinalInternshipStatus.Location = New Point(208, 117)
        txtFinalInternshipStatus.Margin = New Padding(3, 4, 3, 4)
        txtFinalInternshipStatus.Name = "txtFinalInternshipStatus"
        txtFinalInternshipStatus.ReadOnly = True
        txtFinalInternshipStatus.Size = New Size(251, 27)
        txtFinalInternshipStatus.TabIndex = 1
        ' 
        ' lblFinalInternshipStatusCaption
        ' 
        lblFinalInternshipStatusCaption.AutoSize = True
        lblFinalInternshipStatusCaption.Font = New Font("Segoe UI", 9F)
        lblFinalInternshipStatusCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblFinalInternshipStatusCaption.Location = New Point(46, 121)
        lblFinalInternshipStatusCaption.Name = "lblFinalInternshipStatusCaption"
        lblFinalInternshipStatusCaption.Size = New Size(121, 20)
        lblFinalInternshipStatusCaption.TabIndex = 6
        lblFinalInternshipStatusCaption.Text = "Internship Status:"
        ' 
        ' lblFinalGradeCaption
        ' 
        lblFinalGradeCaption.AutoSize = True
        lblFinalGradeCaption.Font = New Font("Segoe UI", 9F)
        lblFinalGradeCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblFinalGradeCaption.Location = New Point(46, 168)
        lblFinalGradeCaption.Name = "lblFinalGradeCaption"
        lblFinalGradeCaption.Size = New Size(87, 20)
        lblFinalGradeCaption.TabIndex = 7
        lblFinalGradeCaption.Text = "Final Grade:"
        ' 
        ' lblFinalGradeValue
        ' 
        lblFinalGradeValue.AutoSize = True
        lblFinalGradeValue.Font = New Font("Segoe UI Semibold", 28F, FontStyle.Bold)
        lblFinalGradeValue.ForeColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lblFinalGradeValue.Location = New Point(46, 200)
        lblFinalGradeValue.Name = "lblFinalGradeValue"
        lblFinalGradeValue.Size = New Size(65, 62)
        lblFinalGradeValue.TabIndex = 2
        lblFinalGradeValue.Text = "--"
        ' 
        ' lblEvaluatedByCaption
        ' 
        lblEvaluatedByCaption.AutoSize = True
        lblEvaluatedByCaption.Font = New Font("Segoe UI", 9F)
        lblEvaluatedByCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblEvaluatedByCaption.Location = New Point(46, 335)
        lblEvaluatedByCaption.Name = "lblEvaluatedByCaption"
        lblEvaluatedByCaption.Size = New Size(97, 20)
        lblEvaluatedByCaption.TabIndex = 8
        lblEvaluatedByCaption.Text = "Evaluated By:"
        ' 
        ' lblGradedAtCaption
        ' 
        lblGradedAtCaption.AutoSize = True
        lblGradedAtCaption.Font = New Font("Segoe UI", 9F)
        lblGradedAtCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradedAtCaption.Location = New Point(46, 388)
        lblGradedAtCaption.Name = "lblGradedAtCaption"
        lblGradedAtCaption.Size = New Size(80, 20)
        lblGradedAtCaption.TabIndex = 9
        lblGradedAtCaption.Text = "Graded At:"
        ' 
        ' txtEvaluatedBy
        ' 
        txtEvaluatedBy.Location = New Point(208, 331)
        txtEvaluatedBy.Margin = New Padding(3, 4, 3, 4)
        txtEvaluatedBy.Name = "txtEvaluatedBy"
        txtEvaluatedBy.ReadOnly = True
        txtEvaluatedBy.Size = New Size(365, 27)
        txtEvaluatedBy.TabIndex = 4
        ' 
        ' txtGradedAt
        ' 
        txtGradedAt.Location = New Point(208, 384)
        txtGradedAt.Margin = New Padding(3, 4, 3, 4)
        txtGradedAt.Name = "txtGradedAt"
        txtGradedAt.ReadOnly = True
        txtGradedAt.Size = New Size(251, 27)
        txtGradedAt.TabIndex = 5
        ' 
        ' btnDownloadReport
        ' 
        btnDownloadReport.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnDownloadReport.FlatAppearance.BorderSize = 0
        btnDownloadReport.FlatStyle = FlatStyle.Flat
        btnDownloadReport.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        btnDownloadReport.ForeColor = Color.White
        btnDownloadReport.Location = New Point(46, 467)
        btnDownloadReport.Margin = New Padding(3, 4, 3, 4)
        btnDownloadReport.Name = "btnDownloadReport"
        btnDownloadReport.Size = New Size(206, 53)
        btnDownloadReport.TabIndex = 3
        btnDownloadReport.Text = "Download Report"
        btnDownloadReport.UseVisualStyleBackColor = False
        ' 
        ' lblFinalReportCaption
        ' 
        lblFinalReportCaption.AutoSize = True
        lblFinalReportCaption.Font = New Font("Segoe UI", 9F)
        lblFinalReportCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblFinalReportCaption.Location = New Point(46, 441)
        lblFinalReportCaption.Name = "lblFinalReportCaption"
        lblFinalReportCaption.Size = New Size(165, 20)
        lblFinalReportCaption.TabIndex = 10
        lblFinalReportCaption.Text = "Final Evaluation Report:"
        ' 
        ' pnlStudentProfile
        ' 
        pnlStudentProfile.BackColor = Color.White
        pnlStudentProfile.Controls.Add(chkShowPassword)
        pnlStudentProfile.Controls.Add(Label1)
        pnlStudentProfile.Controls.Add(txtConfirmPassword)
        pnlStudentProfile.Controls.Add(lblPassword)
        pnlStudentProfile.Controls.Add(txtPassword)
        pnlStudentProfile.Controls.Add(lblAcademicInfoHeader)
        pnlStudentProfile.Controls.Add(lblContactInfoHeader)
        pnlStudentProfile.Controls.Add(lblDepartmentCaption)
        pnlStudentProfile.Controls.Add(lblCourseCaption)
        pnlStudentProfile.Controls.Add(lblSectionCaption)
        pnlStudentProfile.Controls.Add(lblCityCaption)
        pnlStudentProfile.Controls.Add(lblAddressCaption)
        pnlStudentProfile.Controls.Add(lblContactCaption)
        pnlStudentProfile.Controls.Add(lblEmailCaption)
        pnlStudentProfile.Controls.Add(lblStatusCaption)
        pnlStudentProfile.Controls.Add(lblBirthDateCaption)
        pnlStudentProfile.Controls.Add(lblGenderCaption)
        pnlStudentProfile.Controls.Add(lblFullNameCaption)
        pnlStudentProfile.Controls.Add(lblStudentNumberCaption)
        pnlStudentProfile.Controls.Add(btnCancelEditProfile)
        pnlStudentProfile.Controls.Add(btnSaveProfile)
        pnlStudentProfile.Controls.Add(btnEditProfile)
        pnlStudentProfile.Controls.Add(txtDepartmentName)
        pnlStudentProfile.Controls.Add(txtCourseName)
        pnlStudentProfile.Controls.Add(txtSectionName)
        pnlStudentProfile.Controls.Add(txtCity)
        pnlStudentProfile.Controls.Add(txtAddress)
        pnlStudentProfile.Controls.Add(txtContactNumber)
        pnlStudentProfile.Controls.Add(txtEmail)
        pnlStudentProfile.Controls.Add(txtStatus)
        pnlStudentProfile.Controls.Add(txtBirthDate)
        pnlStudentProfile.Controls.Add(txtGender)
        pnlStudentProfile.Controls.Add(txtFullName)
        pnlStudentProfile.Controls.Add(txtStudentNumber)
        pnlStudentProfile.Controls.Add(lblProfileTitle)
        pnlStudentProfile.Dock = DockStyle.Fill
        pnlStudentProfile.Location = New Point(0, 0)
        pnlStudentProfile.Margin = New Padding(3, 4, 3, 4)
        pnlStudentProfile.Name = "pnlStudentProfile"
        pnlStudentProfile.Size = New Size(1120, 867)
        pnlStudentProfile.TabIndex = 0
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(866, 218)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(132, 24)
        chkShowPassword.TabIndex = 34
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F)
        Label1.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        Label1.Location = New Point(669, 188)
        Label1.Name = "Label1"
        Label1.Size = New Size(130, 20)
        Label1.TabIndex = 33
        Label1.Text = "Confirm Password:"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(816, 184)
        txtConfirmPassword.Margin = New Padding(3, 4, 3, 4)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.ReadOnly = True
        txtConfirmPassword.Size = New Size(182, 27)
        txtConfirmPassword.TabIndex = 32
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9F)
        lblPassword.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblPassword.Location = New Point(669, 134)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(73, 20)
        lblPassword.TabIndex = 31
        lblPassword.Text = "Password:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(816, 130)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.ReadOnly = True
        txtPassword.Size = New Size(182, 27)
        txtPassword.TabIndex = 30
        ' 
        ' lblAcademicInfoHeader
        ' 
        lblAcademicInfoHeader.AutoSize = True
        lblAcademicInfoHeader.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblAcademicInfoHeader.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblAcademicInfoHeader.Location = New Point(37, 527)
        lblAcademicInfoHeader.Name = "lblAcademicInfoHeader"
        lblAcademicInfoHeader.Size = New Size(180, 23)
        lblAcademicInfoHeader.TabIndex = 29
        lblAcademicInfoHeader.Text = "Academic Information"
        ' 
        ' lblContactInfoHeader
        ' 
        lblContactInfoHeader.AutoSize = True
        lblContactInfoHeader.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblContactInfoHeader.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblContactInfoHeader.Location = New Point(37, 294)
        lblContactInfoHeader.Name = "lblContactInfoHeader"
        lblContactInfoHeader.Size = New Size(166, 23)
        lblContactInfoHeader.TabIndex = 28
        lblContactInfoHeader.Text = "Contact Information"
        ' 
        ' lblDepartmentCaption
        ' 
        lblDepartmentCaption.AutoSize = True
        lblDepartmentCaption.Font = New Font("Segoe UI", 9F)
        lblDepartmentCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblDepartmentCaption.Location = New Point(37, 667)
        lblDepartmentCaption.Name = "lblDepartmentCaption"
        lblDepartmentCaption.Size = New Size(92, 20)
        lblDepartmentCaption.TabIndex = 27
        lblDepartmentCaption.Text = "Department:"
        ' 
        ' lblCourseCaption
        ' 
        lblCourseCaption.AutoSize = True
        lblCourseCaption.Font = New Font("Segoe UI", 9F)
        lblCourseCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCourseCaption.Location = New Point(37, 614)
        lblCourseCaption.Name = "lblCourseCaption"
        lblCourseCaption.Size = New Size(57, 20)
        lblCourseCaption.TabIndex = 26
        lblCourseCaption.Text = "Course:"
        ' 
        ' lblSectionCaption
        ' 
        lblSectionCaption.AutoSize = True
        lblSectionCaption.Font = New Font("Segoe UI", 9F)
        lblSectionCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblSectionCaption.Location = New Point(37, 561)
        lblSectionCaption.Name = "lblSectionCaption"
        lblSectionCaption.Size = New Size(61, 20)
        lblSectionCaption.TabIndex = 25
        lblSectionCaption.Text = "Section:"
        ' 
        ' lblCityCaption
        ' 
        lblCityCaption.AutoSize = True
        lblCityCaption.Font = New Font("Segoe UI", 9F)
        lblCityCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCityCaption.Location = New Point(37, 486)
        lblCityCaption.Name = "lblCityCaption"
        lblCityCaption.Size = New Size(37, 20)
        lblCityCaption.TabIndex = 24
        lblCityCaption.Text = "City:"
        ' 
        ' lblAddressCaption
        ' 
        lblAddressCaption.AutoSize = True
        lblAddressCaption.Font = New Font("Segoe UI", 9F)
        lblAddressCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblAddressCaption.Location = New Point(37, 433)
        lblAddressCaption.Name = "lblAddressCaption"
        lblAddressCaption.Size = New Size(65, 20)
        lblAddressCaption.TabIndex = 23
        lblAddressCaption.Text = "Address:"
        ' 
        ' lblContactCaption
        ' 
        lblContactCaption.AutoSize = True
        lblContactCaption.Font = New Font("Segoe UI", 9F)
        lblContactCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblContactCaption.Location = New Point(37, 380)
        lblContactCaption.Name = "lblContactCaption"
        lblContactCaption.Size = New Size(90, 20)
        lblContactCaption.TabIndex = 22
        lblContactCaption.Text = "Contact No.:"
        ' 
        ' lblEmailCaption
        ' 
        lblEmailCaption.AutoSize = True
        lblEmailCaption.Font = New Font("Segoe UI", 9F)
        lblEmailCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblEmailCaption.Location = New Point(37, 326)
        lblEmailCaption.Name = "lblEmailCaption"
        lblEmailCaption.Size = New Size(49, 20)
        lblEmailCaption.TabIndex = 21
        lblEmailCaption.Text = "Email:"
        ' 
        ' lblStatusCaption
        ' 
        lblStatusCaption.AutoSize = True
        lblStatusCaption.Font = New Font("Segoe UI", 9F)
        lblStatusCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblStatusCaption.Location = New Point(37, 244)
        lblStatusCaption.Name = "lblStatusCaption"
        lblStatusCaption.Size = New Size(52, 20)
        lblStatusCaption.TabIndex = 20
        lblStatusCaption.Text = "Status:"
        ' 
        ' lblBirthDateCaption
        ' 
        lblBirthDateCaption.AutoSize = True
        lblBirthDateCaption.Font = New Font("Segoe UI", 9F)
        lblBirthDateCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblBirthDateCaption.Location = New Point(669, 84)
        lblBirthDateCaption.Name = "lblBirthDateCaption"
        lblBirthDateCaption.Size = New Size(79, 20)
        lblBirthDateCaption.TabIndex = 19
        lblBirthDateCaption.Text = "Birth Date:"
        ' 
        ' lblGenderCaption
        ' 
        lblGenderCaption.AutoSize = True
        lblGenderCaption.Font = New Font("Segoe UI", 9F)
        lblGenderCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGenderCaption.Location = New Point(37, 191)
        lblGenderCaption.Name = "lblGenderCaption"
        lblGenderCaption.Size = New Size(60, 20)
        lblGenderCaption.TabIndex = 18
        lblGenderCaption.Text = "Gender:"
        ' 
        ' lblFullNameCaption
        ' 
        lblFullNameCaption.AutoSize = True
        lblFullNameCaption.Font = New Font("Segoe UI", 9F)
        lblFullNameCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblFullNameCaption.Location = New Point(37, 137)
        lblFullNameCaption.Name = "lblFullNameCaption"
        lblFullNameCaption.Size = New Size(79, 20)
        lblFullNameCaption.TabIndex = 17
        lblFullNameCaption.Text = "Full Name:"
        ' 
        ' lblStudentNumberCaption
        ' 
        lblStudentNumberCaption.AutoSize = True
        lblStudentNumberCaption.Font = New Font("Segoe UI", 9F)
        lblStudentNumberCaption.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblStudentNumberCaption.Location = New Point(37, 84)
        lblStudentNumberCaption.Name = "lblStudentNumberCaption"
        lblStudentNumberCaption.Size = New Size(121, 20)
        lblStudentNumberCaption.TabIndex = 16
        lblStudentNumberCaption.Text = "Student Number:"
        ' 
        ' btnCancelEditProfile
        ' 
        btnCancelEditProfile.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnCancelEditProfile.FlatAppearance.BorderSize = 0
        btnCancelEditProfile.FlatStyle = FlatStyle.Flat
        btnCancelEditProfile.Font = New Font("Segoe UI", 10F)
        btnCancelEditProfile.ForeColor = Color.Black
        btnCancelEditProfile.Location = New Point(336, 743)
        btnCancelEditProfile.Margin = New Padding(3, 4, 3, 4)
        btnCancelEditProfile.Name = "btnCancelEditProfile"
        btnCancelEditProfile.Size = New Size(137, 51)
        btnCancelEditProfile.TabIndex = 15
        btnCancelEditProfile.Text = "Cancel"
        btnCancelEditProfile.UseVisualStyleBackColor = False
        ' 
        ' btnSaveProfile
        ' 
        btnSaveProfile.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnSaveProfile.FlatAppearance.BorderSize = 0
        btnSaveProfile.FlatStyle = FlatStyle.Flat
        btnSaveProfile.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        btnSaveProfile.ForeColor = Color.White
        btnSaveProfile.Location = New Point(183, 743)
        btnSaveProfile.Margin = New Padding(3, 4, 3, 4)
        btnSaveProfile.Name = "btnSaveProfile"
        btnSaveProfile.Size = New Size(137, 51)
        btnSaveProfile.TabIndex = 14
        btnSaveProfile.Text = "Save"
        btnSaveProfile.UseVisualStyleBackColor = False
        ' 
        ' btnEditProfile
        ' 
        btnEditProfile.BackColor = Color.FromArgb(CByte(255), CByte(235), CByte(59))
        btnEditProfile.FlatAppearance.BorderSize = 0
        btnEditProfile.FlatStyle = FlatStyle.Flat
        btnEditProfile.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        btnEditProfile.ForeColor = Color.Black
        btnEditProfile.Location = New Point(37, 743)
        btnEditProfile.Margin = New Padding(3, 4, 3, 4)
        btnEditProfile.Name = "btnEditProfile"
        btnEditProfile.Size = New Size(137, 51)
        btnEditProfile.TabIndex = 13
        btnEditProfile.Text = "Edit Profile"
        btnEditProfile.UseVisualStyleBackColor = False
        ' 
        ' txtDepartmentName
        ' 
        txtDepartmentName.Location = New Point(183, 663)
        txtDepartmentName.Margin = New Padding(3, 4, 3, 4)
        txtDepartmentName.Name = "txtDepartmentName"
        txtDepartmentName.ReadOnly = True
        txtDepartmentName.Size = New Size(411, 27)
        txtDepartmentName.TabIndex = 12
        ' 
        ' txtCourseName
        ' 
        txtCourseName.Location = New Point(183, 610)
        txtCourseName.Margin = New Padding(3, 4, 3, 4)
        txtCourseName.Name = "txtCourseName"
        txtCourseName.ReadOnly = True
        txtCourseName.Size = New Size(411, 27)
        txtCourseName.TabIndex = 11
        ' 
        ' txtSectionName
        ' 
        txtSectionName.Location = New Point(183, 557)
        txtSectionName.Margin = New Padding(3, 4, 3, 4)
        txtSectionName.Name = "txtSectionName"
        txtSectionName.ReadOnly = True
        txtSectionName.Size = New Size(411, 27)
        txtSectionName.TabIndex = 10
        ' 
        ' txtCity
        ' 
        txtCity.Location = New Point(183, 482)
        txtCity.Margin = New Padding(3, 4, 3, 4)
        txtCity.Name = "txtCity"
        txtCity.ReadOnly = True
        txtCity.Size = New Size(297, 27)
        txtCity.TabIndex = 9
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(183, 429)
        txtAddress.Margin = New Padding(3, 4, 3, 4)
        txtAddress.Name = "txtAddress"
        txtAddress.ReadOnly = True
        txtAddress.Size = New Size(479, 27)
        txtAddress.TabIndex = 8
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Location = New Point(183, 376)
        txtContactNumber.Margin = New Padding(3, 4, 3, 4)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.ReadOnly = True
        txtContactNumber.Size = New Size(297, 27)
        txtContactNumber.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(183, 322)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(411, 27)
        txtEmail.TabIndex = 6
        ' 
        ' txtStatus
        ' 
        txtStatus.Location = New Point(183, 240)
        txtStatus.Margin = New Padding(3, 4, 3, 4)
        txtStatus.Name = "txtStatus"
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(228, 27)
        txtStatus.TabIndex = 5
        ' 
        ' txtBirthDate
        ' 
        txtBirthDate.Location = New Point(816, 80)
        txtBirthDate.Margin = New Padding(3, 4, 3, 4)
        txtBirthDate.Name = "txtBirthDate"
        txtBirthDate.ReadOnly = True
        txtBirthDate.Size = New Size(182, 27)
        txtBirthDate.TabIndex = 4
        ' 
        ' txtGender
        ' 
        txtGender.Location = New Point(183, 187)
        txtGender.Margin = New Padding(3, 4, 3, 4)
        txtGender.Name = "txtGender"
        txtGender.ReadOnly = True
        txtGender.Size = New Size(137, 27)
        txtGender.TabIndex = 3
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(183, 133)
        txtFullName.Margin = New Padding(3, 4, 3, 4)
        txtFullName.Name = "txtFullName"
        txtFullName.ReadOnly = True
        txtFullName.Size = New Size(411, 27)
        txtFullName.TabIndex = 2
        ' 
        ' txtStudentNumber
        ' 
        txtStudentNumber.Location = New Point(183, 80)
        txtStudentNumber.Margin = New Padding(3, 4, 3, 4)
        txtStudentNumber.Name = "txtStudentNumber"
        txtStudentNumber.ReadOnly = True
        txtStudentNumber.Size = New Size(228, 27)
        txtStudentNumber.TabIndex = 1
        ' 
        ' lblProfileTitle
        ' 
        lblProfileTitle.AutoSize = True
        lblProfileTitle.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        lblProfileTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblProfileTitle.Location = New Point(37, 26)
        lblProfileTitle.Name = "lblProfileTitle"
        lblProfileTitle.Size = New Size(244, 37)
        lblProfileTitle.TabIndex = 0
        lblProfileTitle.Text = "STUDENT PROFILE"
        ' 
        ' frmStudentDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1371, 960)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmStudentDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Dashboard"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlVisitLogs.ResumeLayout(False)
        pnlVisitLogs.PerformLayout()
        CType(dgvVisitLogs, ComponentModel.ISupportInitialize).EndInit()
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlContent.ResumeLayout(False)
        pnlInternshipDetails.ResumeLayout(False)
        pnlInternshipDetails.PerformLayout()
        pnlFinalGrade.ResumeLayout(False)
        pnlFinalGrade.PerformLayout()
        pnlStudentProfile.ResumeLayout(False)
        pnlStudentProfile.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblStudentRole As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblAppTitle As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnFinalGrade As Button
    Friend WithEvents btnVisitLogs As Button
    Friend WithEvents btnInternshipDetails As Button
    Friend WithEvents btnStudentProfile As Button
    Friend WithEvents lblSidebarTitle As Label
    Friend WithEvents pnlContent As Panel

    Friend WithEvents pnlStudentProfile As Panel
    Friend WithEvents lblProfileTitle As Label
    Friend WithEvents txtStudentNumber As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtBirthDate As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtSectionName As TextBox
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents txtDepartmentName As TextBox
    Friend WithEvents btnEditProfile As Button
    Friend WithEvents btnSaveProfile As Button
    Friend WithEvents btnCancelEditProfile As Button
    Friend WithEvents lblStudentNumberCaption As Label
    Friend WithEvents lblFullNameCaption As Label
    Friend WithEvents lblGenderCaption As Label
    Friend WithEvents lblBirthDateCaption As Label
    Friend WithEvents lblStatusCaption As Label
    Friend WithEvents lblEmailCaption As Label
    Friend WithEvents lblContactCaption As Label
    Friend WithEvents lblAddressCaption As Label
    Friend WithEvents lblCityCaption As Label
    Friend WithEvents lblSectionCaption As Label
    Friend WithEvents lblCourseCaption As Label
    Friend WithEvents lblDepartmentCaption As Label
    Friend WithEvents lblContactInfoHeader As Label
    Friend WithEvents lblAcademicInfoHeader As Label

    Friend WithEvents pnlInternshipDetails As Panel
    Friend WithEvents lblInternshipTitle As Label
    Friend WithEvents txtInternshipStatus As TextBox
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents txtCompanyAddress As TextBox
    Friend WithEvents txtCompanyCity As TextBox
    Friend WithEvents txtIndustry As TextBox
    Friend WithEvents txtSupervisorName As TextBox
    Friend WithEvents txtSupervisorPosition As TextBox
    Friend WithEvents txtSupervisorContact As TextBox
    Friend WithEvents txtWorkDays As TextBox
    Friend WithEvents txtStartTime As TextBox
    Friend WithEvents txtEndTime As TextBox
    Friend WithEvents txtRequiredHours As TextBox
    Friend WithEvents txtCompletedHours As TextBox
    Friend WithEvents progressHours As ProgressBar
    Friend WithEvents lblInternshipStatusCaption As Label
    Friend WithEvents lblCompanyInfoHeader As Label
    Friend WithEvents lblCompanyNameCaption As Label
    Friend WithEvents lblCompanyAddressCaption As Label
    Friend WithEvents lblCompanyCityCaption As Label
    Friend WithEvents lblIndustryCaption As Label
    Friend WithEvents lblSupervisorInfoHeader As Label
    Friend WithEvents lblSupervisorNameCaption As Label
    Friend WithEvents lblSupervisorPositionCaption As Label
    Friend WithEvents lblSupervisorContactCaption As Label
    Friend WithEvents lblWorkScheduleHeader As Label
    Friend WithEvents lblWorkDaysCaption As Label
    Friend WithEvents lblStartTimeCaption As Label
    Friend WithEvents lblEndTimeCaption As Label
    Friend WithEvents lblOjtHoursHeader As Label
    Friend WithEvents lblRequiredHoursCaption As Label
    Friend WithEvents lblCompletedHoursCaption As Label
    Friend WithEvents lblHoursProgress As Label

    Friend WithEvents pnlVisitLogs As Panel
    Friend WithEvents lblVisitLogsTitle As Label
    Friend WithEvents dgvVisitLogs As DataGridView
    Friend WithEvents lblVisitLogsListHeader As Label

    Friend WithEvents pnlFinalGrade As Panel
    Friend WithEvents lblFinalGradeTitle As Label
    Friend WithEvents txtFinalInternshipStatus As TextBox
    Friend WithEvents lblFinalGradeValue As Label
    Friend WithEvents btnDownloadReport As Button
    Friend WithEvents txtEvaluatedBy As TextBox
    Friend WithEvents txtGradedAt As TextBox
    Friend WithEvents lblFinalInternshipStatusCaption As Label
    Friend WithEvents lblFinalGradeCaption As Label
    Friend WithEvents lblEvaluatedByCaption As Label
    Friend WithEvents lblGradedAtCaption As Label
    Friend WithEvents lblFinalReportCaption As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents cboSelectInternship As ComboBox
    Friend WithEvents lblSelectInternship As Label

End Class
