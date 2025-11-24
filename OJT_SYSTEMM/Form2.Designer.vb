<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFacultyDashboard
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        lblHeaderTitle = New Label()
        pnlLeft = New Panel()
        btnDashboardHome = New Button()
        btnManageStudents = New Button()
        btnInternshipAssignment = New Button()
        btnVisitLogs = New Button()
        btnGrading = New Button()
        btnCompanies = New Button()
        btnCompanyContacts = New Button()
        btnFacultyProfile = New Button()
        btnLogout = New Button()
        pnlContent = New Panel()
        pnlDashboardHome = New Panel()
        dgvLatestActivity = New DataGridView()
        lblLatestActivityTitle = New Label()
        flpCards = New FlowLayoutPanel()
        pnlCardTotalStudents = New Panel()
        lblTotalStudentsValue = New Label()
        lblTotalStudentsTitle = New Label()
        pnlCardActiveInternships = New Panel()
        lblActiveInternshipsValue = New Label()
        lblActiveInternshipsTitle = New Label()
        pnlCardCompanies = New Panel()
        lblCompaniesValue = New Label()
        lblCompaniesTitle = New Label()
        pnlCardPendingVisitLogs = New Panel()
        lblPendingVisitLogsValue = New Label()
        lblPendingVisitLogsTitle = New Label()
        lblDashboardTitle = New Label()
        pnlManageStudents = New Panel()
        dgvStudents = New DataGridView()
        btnSearchStudent = New Button()
        txtSearchStudent = New TextBox()
        lblSearchStudent = New Label()
        lblManageStudentsTitle = New Label()
        pnlInternshipAssignment = New Panel()
        btnRemoveInternship = New Button()
        btnClearInternship = New Button()
        btnAssignInternship = New Button()
        grpWorkScheduleBorder = New Panel()
        dtpEndTime = New DateTimePicker()
        lblEndTime = New Label()
        dtpStartTime = New DateTimePicker()
        lblStartTime = New Label()
        dtpEndDate = New DateTimePicker()
        lblEndDate = New Label()
        dtpStartDate = New DateTimePicker()
        lblStartDate = New Label()
        txtWorkDays = New TextBox()
        lblWorkDays = New Label()
        lblWorkScheduleTitle = New Label()
        grpCompanyBorder = New Panel()
        cboEvaluator = New ComboBox()
        lblEvaluator = New Label()
        cboSupervisor = New ComboBox()
        lblSupervisor = New Label()
        cboCompany = New ComboBox()
        lblCompany = New Label()
        lblCompanySectionTitle = New Label()
        grpStudentBorder = New Panel()
        lblCurrentInternshipStatusValue = New Label()
        lblCurrentInternshipStatus = New Label()
        lblRequiredHoursValue = New Label()
        lblRequiredHours = New Label()
        lblCourseValueIA = New Label()
        lblCourseIA = New Label()
        lblStudentNameValueIA = New Label()
        lblStudentNameIA = New Label()
        lblStudentNoValueIA = New Label()
        lblStudentNoIA = New Label()
        lblStudentInfoTitle = New Label()
        btnSearchStudentIA = New Button()
        txtSearchStudentIA = New TextBox()
        lblSearchStudentIA = New Label()
        lblInternshipTitle = New Label()
        pnlVisitLogs = New Panel()
        grpVLForm = New Panel()
        lblVLFormTitle = New Label()
        lblVLVisitType = New Label()
        cboVLVisitType = New ComboBox()
        lblVLVisitDate = New Label()
        dtpVLVisitDate = New DateTimePicker()
        lblVLScore = New Label()
        txtVLScore = New TextBox()
        lblVLMaxScore = New Label()
        txtVLMaxScore = New TextBox()
        lblVLNextVisitDate = New Label()
        dtpVLNextVisitDate = New DateTimePicker()
        lblVLRemarks = New Label()
        txtVLRemarks = New TextBox()
        lblVLAttachment = New Label()
        txtVLAttachment = New TextBox()
        btnVLBrowse = New Button()
        btnVLSave = New Button()
        btnVLCancel = New Button()
        dgvVisitLogs = New DataGridView()
        cboVLInternship = New ComboBox()
        lblVLSelectInternship = New Label()
        lblVisitLogsTitle = New Label()
        pnlGrading = New Panel()
        grpGradeForm = New Panel()
        lblGradeFormTitle = New Label()
        lblFinalGradeLabel = New Label()
        txtFinalGrade = New TextBox()
        lblGradeHint = New Label()
        btnSaveGrade = New Button()
        btnClearGrade = New Button()
        grpGradeStudentInfo = New Panel()
        lblGradeStudentInfoTitle = New Label()
        lblGradeStudentNoLabel = New Label()
        lblGradeStudentNoValue = New Label()
        lblGradeNameLabel = New Label()
        lblGradeNameValue = New Label()
        lblGradeCourseLabel = New Label()
        lblGradeCourseValue = New Label()
        lblGradeRequiredHoursLabel = New Label()
        lblGradeRequiredHoursValue = New Label()
        lblGradeCompletedHoursLabel = New Label()
        lblGradeCompletedHoursValue = New Label()
        lblGradeStatusLabel = New Label()
        lblGradeStatusValue = New Label()
        cboGradeStudent = New ComboBox()
        lblGradeSelectStudent = New Label()
        lblGradingTitle = New Label()
        pnlCompanies = New Panel()
        dgvCompanies = New DataGridView()
        btnAddCompany = New Button()
        btnSearchCompany = New Button()
        txtSearchCompany = New TextBox()
        lblSearchCompany = New Label()
        pnlCompanyContacts = New Panel()
        dgvContacts = New DataGridView()
        lblContactCompany = New Label()
        lblCompanyContactsTitle = New Label()
        pnlFacultyProfile = New Panel()
        lblProfileTitle = New Label()
        lblNameCaption = New Label()
        lblFacultyName = New Label()
        lblPositionCaption = New Label()
        lblFacultyPosition = New Label()
        lblEmployeeNoCaption = New Label()
        lblEmployeeNumber = New Label()
        lblDepartmentCaption = New Label()
        lblDepartment = New Label()
        lblEditableHeader = New Label()
        lblEmailCaption = New Label()
        txtFacultyEmail = New TextBox()
        lblContactCaption = New Label()
        txtFacultyContact = New TextBox()
        btnEditFaculty = New Button()
        btnSaveFaculty = New Button()
        pnlHeader.SuspendLayout()
        pnlLeft.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlDashboardHome.SuspendLayout()
        CType(dgvLatestActivity, ComponentModel.ISupportInitialize).BeginInit()
        flpCards.SuspendLayout()
        pnlCardTotalStudents.SuspendLayout()
        pnlCardActiveInternships.SuspendLayout()
        pnlCardCompanies.SuspendLayout()
        pnlCardPendingVisitLogs.SuspendLayout()
        pnlManageStudents.SuspendLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlInternshipAssignment.SuspendLayout()
        grpWorkScheduleBorder.SuspendLayout()
        grpCompanyBorder.SuspendLayout()
        grpStudentBorder.SuspendLayout()
        pnlVisitLogs.SuspendLayout()
        grpVLForm.SuspendLayout()
        CType(dgvVisitLogs, ComponentModel.ISupportInitialize).BeginInit()
        pnlGrading.SuspendLayout()
        grpGradeForm.SuspendLayout()
        grpGradeStudentInfo.SuspendLayout()
        pnlCompanies.SuspendLayout()
        CType(dgvCompanies, ComponentModel.ISupportInitialize).BeginInit()
        pnlCompanyContacts.SuspendLayout()
        CType(dgvContacts, ComponentModel.ISupportInitialize).BeginInit()
        pnlFacultyProfile.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(27), CByte(94), CByte(32))
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1371, 80)
        pnlHeader.TabIndex = 0
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.Dock = DockStyle.Fill
        lblHeaderTitle.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.White
        lblHeaderTitle.Location = New Point(0, 0)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(1371, 80)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "FACULTY DASHBOARD"
        lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        pnlLeft.Controls.Add(btnDashboardHome)
        pnlLeft.Controls.Add(btnManageStudents)
        pnlLeft.Controls.Add(btnInternshipAssignment)
        pnlLeft.Controls.Add(btnVisitLogs)
        pnlLeft.Controls.Add(btnGrading)
        pnlLeft.Controls.Add(btnCompanies)
        pnlLeft.Controls.Add(btnCompanyContacts)
        pnlLeft.Controls.Add(btnFacultyProfile)
        pnlLeft.Controls.Add(btnLogout)
        pnlLeft.Dock = DockStyle.Left
        pnlLeft.Location = New Point(0, 80)
        pnlLeft.Margin = New Padding(3, 4, 3, 4)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Size = New Size(263, 853)
        pnlLeft.TabIndex = 1
        ' 
        ' btnDashboardHome
        ' 
        btnDashboardHome.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        btnDashboardHome.FlatAppearance.BorderSize = 0
        btnDashboardHome.FlatStyle = FlatStyle.Flat
        btnDashboardHome.Font = New Font("Segoe UI", 11F)
        btnDashboardHome.ForeColor = Color.White
        btnDashboardHome.Location = New Point(17, 27)
        btnDashboardHome.Margin = New Padding(3, 4, 3, 4)
        btnDashboardHome.Name = "btnDashboardHome"
        btnDashboardHome.Size = New Size(229, 53)
        btnDashboardHome.TabIndex = 0
        btnDashboardHome.Text = "Dashboard Home"
        btnDashboardHome.UseVisualStyleBackColor = False
        ' 
        ' btnManageStudents
        ' 
        btnManageStudents.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        btnManageStudents.FlatAppearance.BorderSize = 0
        btnManageStudents.FlatStyle = FlatStyle.Flat
        btnManageStudents.Font = New Font("Segoe UI", 11F)
        btnManageStudents.ForeColor = Color.White
        btnManageStudents.Location = New Point(17, 80)
        btnManageStudents.Margin = New Padding(3, 4, 3, 4)
        btnManageStudents.Name = "btnManageStudents"
        btnManageStudents.Size = New Size(229, 53)
        btnManageStudents.TabIndex = 1
        btnManageStudents.Text = "Manage Students"
        btnManageStudents.UseVisualStyleBackColor = False
        ' 
        ' btnInternshipAssignment
        ' 
        btnInternshipAssignment.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        btnInternshipAssignment.FlatAppearance.BorderSize = 0
        btnInternshipAssignment.FlatStyle = FlatStyle.Flat
        btnInternshipAssignment.Font = New Font("Segoe UI", 11F)
        btnInternshipAssignment.ForeColor = Color.White
        btnInternshipAssignment.Location = New Point(17, 133)
        btnInternshipAssignment.Margin = New Padding(3, 4, 3, 4)
        btnInternshipAssignment.Name = "btnInternshipAssignment"
        btnInternshipAssignment.Size = New Size(229, 53)
        btnInternshipAssignment.TabIndex = 2
        btnInternshipAssignment.Text = "Internship Assignment"
        btnInternshipAssignment.UseVisualStyleBackColor = False
        ' 
        ' btnVisitLogs
        ' 
        btnVisitLogs.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        btnVisitLogs.FlatAppearance.BorderSize = 0
        btnVisitLogs.FlatStyle = FlatStyle.Flat
        btnVisitLogs.Font = New Font("Segoe UI", 11F)
        btnVisitLogs.ForeColor = Color.White
        btnVisitLogs.Location = New Point(17, 187)
        btnVisitLogs.Margin = New Padding(3, 4, 3, 4)
        btnVisitLogs.Name = "btnVisitLogs"
        btnVisitLogs.Size = New Size(229, 53)
        btnVisitLogs.TabIndex = 3
        btnVisitLogs.Text = "Visit Logs"
        btnVisitLogs.UseVisualStyleBackColor = False
        ' 
        ' btnGrading
        ' 
        btnGrading.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        btnGrading.FlatAppearance.BorderSize = 0
        btnGrading.FlatStyle = FlatStyle.Flat
        btnGrading.Font = New Font("Segoe UI", 11F)
        btnGrading.ForeColor = Color.White
        btnGrading.Location = New Point(17, 240)
        btnGrading.Margin = New Padding(3, 4, 3, 4)
        btnGrading.Name = "btnGrading"
        btnGrading.Size = New Size(229, 53)
        btnGrading.TabIndex = 4
        btnGrading.Text = "Grading"
        btnGrading.UseVisualStyleBackColor = False
        ' 
        ' btnCompanies
        ' 
        btnCompanies.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        btnCompanies.FlatAppearance.BorderSize = 0
        btnCompanies.FlatStyle = FlatStyle.Flat
        btnCompanies.Font = New Font("Segoe UI", 11F)
        btnCompanies.ForeColor = Color.White
        btnCompanies.Location = New Point(17, 293)
        btnCompanies.Margin = New Padding(3, 4, 3, 4)
        btnCompanies.Name = "btnCompanies"
        btnCompanies.Size = New Size(229, 53)
        btnCompanies.TabIndex = 5
        btnCompanies.Text = "Companies"
        btnCompanies.UseVisualStyleBackColor = False
        ' 
        ' btnCompanyContacts
        ' 
        btnCompanyContacts.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        btnCompanyContacts.FlatAppearance.BorderSize = 0
        btnCompanyContacts.FlatStyle = FlatStyle.Flat
        btnCompanyContacts.Font = New Font("Segoe UI", 11F)
        btnCompanyContacts.ForeColor = Color.White
        btnCompanyContacts.Location = New Point(17, 347)
        btnCompanyContacts.Margin = New Padding(3, 4, 3, 4)
        btnCompanyContacts.Name = "btnCompanyContacts"
        btnCompanyContacts.Size = New Size(229, 53)
        btnCompanyContacts.TabIndex = 6
        btnCompanyContacts.Text = "Company Contacts"
        btnCompanyContacts.UseVisualStyleBackColor = False
        ' 
        ' btnFacultyProfile
        ' 
        btnFacultyProfile.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        btnFacultyProfile.FlatAppearance.BorderSize = 0
        btnFacultyProfile.FlatStyle = FlatStyle.Flat
        btnFacultyProfile.Font = New Font("Segoe UI", 11F)
        btnFacultyProfile.ForeColor = Color.White
        btnFacultyProfile.Location = New Point(17, 400)
        btnFacultyProfile.Margin = New Padding(3, 4, 3, 4)
        btnFacultyProfile.Name = "btnFacultyProfile"
        btnFacultyProfile.Size = New Size(229, 53)
        btnFacultyProfile.TabIndex = 7
        btnFacultyProfile.Text = "Faculty Profile"
        btnFacultyProfile.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(220), CByte(53), CByte(69))
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(17, 747)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(229, 53)
        btnLogout.TabIndex = 8
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        pnlContent.Controls.Add(pnlDashboardHome)
        pnlContent.Controls.Add(pnlManageStudents)
        pnlContent.Controls.Add(pnlInternshipAssignment)
        pnlContent.Controls.Add(pnlVisitLogs)
        pnlContent.Controls.Add(pnlGrading)
        pnlContent.Controls.Add(pnlCompanies)
        pnlContent.Controls.Add(pnlCompanyContacts)
        pnlContent.Controls.Add(pnlFacultyProfile)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(263, 80)
        pnlContent.Margin = New Padding(3, 4, 3, 4)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1108, 853)
        pnlContent.TabIndex = 2
        ' 
        ' pnlDashboardHome
        ' 
        pnlDashboardHome.BackColor = Color.White
        pnlDashboardHome.Controls.Add(dgvLatestActivity)
        pnlDashboardHome.Controls.Add(lblLatestActivityTitle)
        pnlDashboardHome.Controls.Add(flpCards)
        pnlDashboardHome.Controls.Add(lblDashboardTitle)
        pnlDashboardHome.Dock = DockStyle.Fill
        pnlDashboardHome.Location = New Point(0, 0)
        pnlDashboardHome.Margin = New Padding(3, 4, 3, 4)
        pnlDashboardHome.Name = "pnlDashboardHome"
        pnlDashboardHome.Size = New Size(1108, 853)
        pnlDashboardHome.TabIndex = 0
        ' 
        ' dgvLatestActivity
        ' 
        dgvLatestActivity.AllowUserToAddRows = False
        dgvLatestActivity.AllowUserToDeleteRows = False
        dgvLatestActivity.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvLatestActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLatestActivity.BackgroundColor = Color.White
        dgvLatestActivity.BorderStyle = BorderStyle.None
        dgvLatestActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLatestActivity.Location = New Point(37, 331)
        dgvLatestActivity.Margin = New Padding(3, 4, 3, 4)
        dgvLatestActivity.MultiSelect = False
        dgvLatestActivity.Name = "dgvLatestActivity"
        dgvLatestActivity.ReadOnly = True
        dgvLatestActivity.RowHeadersVisible = False
        dgvLatestActivity.RowHeadersWidth = 51
        dgvLatestActivity.RowTemplate.Height = 28
        dgvLatestActivity.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLatestActivity.Size = New Size(1034, 485)
        dgvLatestActivity.TabIndex = 3
        ' 
        ' lblLatestActivityTitle
        ' 
        lblLatestActivityTitle.AutoSize = True
        lblLatestActivityTitle.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        lblLatestActivityTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblLatestActivityTitle.Location = New Point(32, 293)
        lblLatestActivityTitle.Name = "lblLatestActivityTitle"
        lblLatestActivityTitle.Size = New Size(134, 25)
        lblLatestActivityTitle.TabIndex = 2
        lblLatestActivityTitle.Text = "Latest Activity"
        ' 
        ' flpCards
        ' 
        flpCards.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        flpCards.BackColor = Color.Transparent
        flpCards.Controls.Add(pnlCardTotalStudents)
        flpCards.Controls.Add(pnlCardActiveInternships)
        flpCards.Controls.Add(pnlCardCompanies)
        flpCards.Controls.Add(pnlCardPendingVisitLogs)
        flpCards.Location = New Point(32, 85)
        flpCards.Margin = New Padding(3, 4, 3, 4)
        flpCards.Name = "flpCards"
        flpCards.Size = New Size(1039, 187)
        flpCards.TabIndex = 1
        ' 
        ' pnlCardTotalStudents
        ' 
        pnlCardTotalStudents.BackColor = Color.FromArgb(CByte(252), CByte(243), CByte(207))
        pnlCardTotalStudents.BorderStyle = BorderStyle.FixedSingle
        pnlCardTotalStudents.Controls.Add(lblTotalStudentsValue)
        pnlCardTotalStudents.Controls.Add(lblTotalStudentsTitle)
        pnlCardTotalStudents.Location = New Point(5, 5)
        pnlCardTotalStudents.Margin = New Padding(5, 5, 5, 5)
        pnlCardTotalStudents.Name = "pnlCardTotalStudents"
        pnlCardTotalStudents.Size = New Size(240, 159)
        pnlCardTotalStudents.TabIndex = 0
        ' 
        ' lblTotalStudentsValue
        ' 
        lblTotalStudentsValue.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        lblTotalStudentsValue.ForeColor = Color.FromArgb(CByte(46), CByte(125), CByte(50))
        lblTotalStudentsValue.Location = New Point(9, 69)
        lblTotalStudentsValue.Name = "lblTotalStudentsValue"
        lblTotalStudentsValue.Size = New Size(217, 43)
        lblTotalStudentsValue.TabIndex = 1
        lblTotalStudentsValue.Text = "0"
        lblTotalStudentsValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTotalStudentsTitle
        ' 
        lblTotalStudentsTitle.AutoSize = True
        lblTotalStudentsTitle.Font = New Font("Segoe UI", 10F)
        lblTotalStudentsTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblTotalStudentsTitle.Location = New Point(9, 21)
        lblTotalStudentsTitle.Name = "lblTotalStudentsTitle"
        lblTotalStudentsTitle.Size = New Size(117, 23)
        lblTotalStudentsTitle.TabIndex = 0
        lblTotalStudentsTitle.Text = "Total Students"
        ' 
        ' pnlCardActiveInternships
        ' 
        pnlCardActiveInternships.BackColor = Color.FromArgb(CByte(240), CByte(244), CByte(195))
        pnlCardActiveInternships.BorderStyle = BorderStyle.FixedSingle
        pnlCardActiveInternships.Controls.Add(lblActiveInternshipsValue)
        pnlCardActiveInternships.Controls.Add(lblActiveInternshipsTitle)
        pnlCardActiveInternships.Location = New Point(255, 5)
        pnlCardActiveInternships.Margin = New Padding(5, 5, 5, 5)
        pnlCardActiveInternships.Name = "pnlCardActiveInternships"
        pnlCardActiveInternships.Size = New Size(240, 159)
        pnlCardActiveInternships.TabIndex = 1
        ' 
        ' lblActiveInternshipsValue
        ' 
        lblActiveInternshipsValue.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        lblActiveInternshipsValue.ForeColor = Color.FromArgb(CByte(51), CByte(105), CByte(30))
        lblActiveInternshipsValue.Location = New Point(9, 69)
        lblActiveInternshipsValue.Name = "lblActiveInternshipsValue"
        lblActiveInternshipsValue.Size = New Size(217, 43)
        lblActiveInternshipsValue.TabIndex = 1
        lblActiveInternshipsValue.Text = "0"
        lblActiveInternshipsValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblActiveInternshipsTitle
        ' 
        lblActiveInternshipsTitle.AutoSize = True
        lblActiveInternshipsTitle.Font = New Font("Segoe UI", 10F)
        lblActiveInternshipsTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblActiveInternshipsTitle.Location = New Point(9, 21)
        lblActiveInternshipsTitle.Name = "lblActiveInternshipsTitle"
        lblActiveInternshipsTitle.Size = New Size(145, 23)
        lblActiveInternshipsTitle.TabIndex = 0
        lblActiveInternshipsTitle.Text = "Active Internships"
        ' 
        ' pnlCardCompanies
        ' 
        pnlCardCompanies.BackColor = Color.FromArgb(CByte(227), CByte(242), CByte(253))
        pnlCardCompanies.BorderStyle = BorderStyle.FixedSingle
        pnlCardCompanies.Controls.Add(lblCompaniesValue)
        pnlCardCompanies.Location = New Point(505, 5)
        pnlCardCompanies.Margin = New Padding(5, 5, 5, 5)
        pnlCardCompanies.Name = "pnlCardCompanies"
        pnlCardCompanies.Size = New Size(240, 159)
        pnlCardCompanies.TabIndex = 2
        ' 
        ' lblCompaniesValue
        ' 
        lblCompaniesValue.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        lblCompaniesValue.ForeColor = Color.FromArgb(CByte(30), CByte(136), CByte(229))
        lblCompaniesValue.Location = New Point(9, 69)
        lblCompaniesValue.Name = "lblCompaniesValue"
        lblCompaniesValue.Size = New Size(217, 43)
        lblCompaniesValue.TabIndex = 1
        lblCompaniesValue.Text = "0"
        lblCompaniesValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCompaniesTitle
        ' 
        lblCompaniesTitle.AutoSize = True
        lblCompaniesTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblCompaniesTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCompaniesTitle.Location = New Point(32, 27)
        lblCompaniesTitle.Name = "lblCompaniesTitle"
        lblCompaniesTitle.Size = New Size(134, 32)
        lblCompaniesTitle.TabIndex = 0
        lblCompaniesTitle.Text = "Companies"
        ' 
        ' pnlCardPendingVisitLogs
        ' 
        pnlCardPendingVisitLogs.BackColor = Color.FromArgb(CByte(255), CByte(249), CByte(196))
        pnlCardPendingVisitLogs.BorderStyle = BorderStyle.FixedSingle
        pnlCardPendingVisitLogs.Controls.Add(lblPendingVisitLogsValue)
        pnlCardPendingVisitLogs.Controls.Add(lblPendingVisitLogsTitle)
        pnlCardPendingVisitLogs.Location = New Point(755, 5)
        pnlCardPendingVisitLogs.Margin = New Padding(5, 5, 5, 5)
        pnlCardPendingVisitLogs.Name = "pnlCardPendingVisitLogs"
        pnlCardPendingVisitLogs.Size = New Size(240, 159)
        pnlCardPendingVisitLogs.TabIndex = 3
        ' 
        ' lblPendingVisitLogsValue
        ' 
        lblPendingVisitLogsValue.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold)
        lblPendingVisitLogsValue.ForeColor = Color.FromArgb(CByte(249), CByte(168), CByte(37))
        lblPendingVisitLogsValue.Location = New Point(9, 69)
        lblPendingVisitLogsValue.Name = "lblPendingVisitLogsValue"
        lblPendingVisitLogsValue.Size = New Size(217, 43)
        lblPendingVisitLogsValue.TabIndex = 1
        lblPendingVisitLogsValue.Text = "0"
        lblPendingVisitLogsValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblPendingVisitLogsTitle
        ' 
        lblPendingVisitLogsTitle.AutoSize = True
        lblPendingVisitLogsTitle.Font = New Font("Segoe UI", 10F)
        lblPendingVisitLogsTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblPendingVisitLogsTitle.Location = New Point(9, 21)
        lblPendingVisitLogsTitle.Name = "lblPendingVisitLogsTitle"
        lblPendingVisitLogsTitle.Size = New Size(149, 23)
        lblPendingVisitLogsTitle.TabIndex = 0
        lblPendingVisitLogsTitle.Text = "Pending Visit Logs"
        ' 
        ' lblDashboardTitle
        ' 
        lblDashboardTitle.AutoSize = True
        lblDashboardTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblDashboardTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblDashboardTitle.Location = New Point(27, 27)
        lblDashboardTitle.Name = "lblDashboardTitle"
        lblDashboardTitle.Size = New Size(205, 32)
        lblDashboardTitle.TabIndex = 0
        lblDashboardTitle.Text = "Dashboard Home"
        ' 
        ' pnlManageStudents
        ' 
        pnlManageStudents.BackColor = Color.White
        pnlManageStudents.Controls.Add(dgvStudents)
        pnlManageStudents.Controls.Add(btnSearchStudent)
        pnlManageStudents.Controls.Add(txtSearchStudent)
        pnlManageStudents.Controls.Add(lblSearchStudent)
        pnlManageStudents.Controls.Add(lblManageStudentsTitle)
        pnlManageStudents.Dock = DockStyle.Fill
        pnlManageStudents.Location = New Point(0, 0)
        pnlManageStudents.Margin = New Padding(3, 4, 3, 4)
        pnlManageStudents.Name = "pnlManageStudents"
        pnlManageStudents.Size = New Size(1108, 853)
        pnlManageStudents.TabIndex = 1
        pnlManageStudents.Visible = False
        ' 
        ' dgvStudents
        ' 
        dgvStudents.AllowUserToAddRows = False
        dgvStudents.AllowUserToDeleteRows = False
        dgvStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStudents.BackgroundColor = Color.White
        dgvStudents.BorderStyle = BorderStyle.None
        dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudents.Location = New Point(37, 192)
        dgvStudents.Margin = New Padding(3, 4, 3, 4)
        dgvStudents.MultiSelect = False
        dgvStudents.Name = "dgvStudents"
        dgvStudents.ReadOnly = True
        dgvStudents.RowHeadersVisible = False
        dgvStudents.RowHeadersWidth = 51
        dgvStudents.RowTemplate.Height = 28
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.Size = New Size(1034, 608)
        dgvStudents.TabIndex = 4
        ' 
        ' btnSearchStudent
        ' 
        btnSearchStudent.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnSearchStudent.FlatAppearance.BorderSize = 0
        btnSearchStudent.FlatStyle = FlatStyle.Flat
        btnSearchStudent.Font = New Font("Segoe UI Semibold", 10F)
        btnSearchStudent.ForeColor = Color.White
        btnSearchStudent.Location = New Point(448, 128)
        btnSearchStudent.Margin = New Padding(3, 4, 3, 4)
        btnSearchStudent.Name = "btnSearchStudent"
        btnSearchStudent.Size = New Size(114, 43)
        btnSearchStudent.TabIndex = 3
        btnSearchStudent.Text = "Search"
        btnSearchStudent.UseVisualStyleBackColor = False
        ' 
        ' txtSearchStudent
        ' 
        txtSearchStudent.Font = New Font("Segoe UI", 10F)
        txtSearchStudent.Location = New Point(128, 132)
        txtSearchStudent.Margin = New Padding(3, 4, 3, 4)
        txtSearchStudent.Name = "txtSearchStudent"
        txtSearchStudent.Size = New Size(310, 30)
        txtSearchStudent.TabIndex = 2
        ' 
        ' lblSearchStudent
        ' 
        lblSearchStudent.AutoSize = True
        lblSearchStudent.Font = New Font("Segoe UI", 10F)
        lblSearchStudent.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblSearchStudent.Location = New Point(37, 136)
        lblSearchStudent.Name = "lblSearchStudent"
        lblSearchStudent.Size = New Size(65, 23)
        lblSearchStudent.TabIndex = 1
        lblSearchStudent.Text = "Search:"
        ' 
        ' lblManageStudentsTitle
        ' 
        lblManageStudentsTitle.AutoSize = True
        lblManageStudentsTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblManageStudentsTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblManageStudentsTitle.Location = New Point(32, 32)
        lblManageStudentsTitle.Name = "lblManageStudentsTitle"
        lblManageStudentsTitle.Size = New Size(205, 32)
        lblManageStudentsTitle.TabIndex = 0
        lblManageStudentsTitle.Text = "Manage Students"
        ' 
        ' pnlInternshipAssignment
        ' 
        pnlInternshipAssignment.BackColor = Color.White
        pnlInternshipAssignment.Controls.Add(btnRemoveInternship)
        pnlInternshipAssignment.Controls.Add(btnClearInternship)
        pnlInternshipAssignment.Controls.Add(btnAssignInternship)
        pnlInternshipAssignment.Controls.Add(grpWorkScheduleBorder)
        pnlInternshipAssignment.Controls.Add(grpCompanyBorder)
        pnlInternshipAssignment.Controls.Add(grpStudentBorder)
        pnlInternshipAssignment.Controls.Add(btnSearchStudentIA)
        pnlInternshipAssignment.Controls.Add(txtSearchStudentIA)
        pnlInternshipAssignment.Controls.Add(lblSearchStudentIA)
        pnlInternshipAssignment.Controls.Add(lblInternshipTitle)
        pnlInternshipAssignment.Dock = DockStyle.Fill
        pnlInternshipAssignment.Location = New Point(0, 0)
        pnlInternshipAssignment.Margin = New Padding(3, 4, 3, 4)
        pnlInternshipAssignment.Name = "pnlInternshipAssignment"
        pnlInternshipAssignment.Size = New Size(1108, 853)
        pnlInternshipAssignment.TabIndex = 2
        pnlInternshipAssignment.Visible = False
        ' 
        ' btnRemoveInternship
        ' 
        btnRemoveInternship.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnRemoveInternship.BackColor = Color.FromArgb(CByte(211), CByte(47), CByte(47))
        btnRemoveInternship.FlatAppearance.BorderSize = 0
        btnRemoveInternship.FlatStyle = FlatStyle.Flat
        btnRemoveInternship.Font = New Font("Segoe UI Semibold", 10F)
        btnRemoveInternship.ForeColor = Color.White
        btnRemoveInternship.Location = New Point(366, 768)
        btnRemoveInternship.Margin = New Padding(3, 4, 3, 4)
        btnRemoveInternship.Name = "btnRemoveInternship"
        btnRemoveInternship.Size = New Size(174, 48)
        btnRemoveInternship.TabIndex = 9
        btnRemoveInternship.Text = "Remove Internship"
        btnRemoveInternship.UseVisualStyleBackColor = False
        ' 
        ' btnClearInternship
        ' 
        btnClearInternship.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnClearInternship.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnClearInternship.FlatAppearance.BorderSize = 0
        btnClearInternship.FlatStyle = FlatStyle.Flat
        btnClearInternship.Font = New Font("Segoe UI", 10F)
        btnClearInternship.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        btnClearInternship.Location = New Point(210, 768)
        btnClearInternship.Margin = New Padding(3, 4, 3, 4)
        btnClearInternship.Name = "btnClearInternship"
        btnClearInternship.Size = New Size(137, 48)
        btnClearInternship.TabIndex = 8
        btnClearInternship.Text = "Clear"
        btnClearInternship.UseVisualStyleBackColor = False
        ' 
        ' btnAssignInternship
        ' 
        btnAssignInternship.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnAssignInternship.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnAssignInternship.FlatAppearance.BorderSize = 0
        btnAssignInternship.FlatStyle = FlatStyle.Flat
        btnAssignInternship.Font = New Font("Segoe UI Semibold", 10F)
        btnAssignInternship.ForeColor = Color.White
        btnAssignInternship.Location = New Point(37, 768)
        btnAssignInternship.Margin = New Padding(3, 4, 3, 4)
        btnAssignInternship.Name = "btnAssignInternship"
        btnAssignInternship.Size = New Size(155, 48)
        btnAssignInternship.TabIndex = 7
        btnAssignInternship.Text = "Assign Internship"
        btnAssignInternship.UseVisualStyleBackColor = False
        ' 
        ' grpWorkScheduleBorder
        ' 
        grpWorkScheduleBorder.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpWorkScheduleBorder.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        grpWorkScheduleBorder.BorderStyle = BorderStyle.FixedSingle
        grpWorkScheduleBorder.Controls.Add(dtpEndTime)
        grpWorkScheduleBorder.Controls.Add(lblEndTime)
        grpWorkScheduleBorder.Controls.Add(dtpStartTime)
        grpWorkScheduleBorder.Controls.Add(lblStartTime)
        grpWorkScheduleBorder.Controls.Add(dtpEndDate)
        grpWorkScheduleBorder.Controls.Add(lblEndDate)
        grpWorkScheduleBorder.Controls.Add(dtpStartDate)
        grpWorkScheduleBorder.Controls.Add(lblStartDate)
        grpWorkScheduleBorder.Controls.Add(txtWorkDays)
        grpWorkScheduleBorder.Controls.Add(lblWorkDays)
        grpWorkScheduleBorder.Controls.Add(lblWorkScheduleTitle)
        grpWorkScheduleBorder.Location = New Point(37, 459)
        grpWorkScheduleBorder.Margin = New Padding(3, 4, 3, 4)
        grpWorkScheduleBorder.Name = "grpWorkScheduleBorder"
        grpWorkScheduleBorder.Padding = New Padding(18, 21, 18, 21)
        grpWorkScheduleBorder.Size = New Size(1034, 277)
        grpWorkScheduleBorder.TabIndex = 6
        ' 
        ' dtpEndTime
        ' 
        dtpEndTime.CustomFormat = "hh:mm tt"
        dtpEndTime.Format = DateTimePickerFormat.Custom
        dtpEndTime.Location = New Point(613, 192)
        dtpEndTime.Margin = New Padding(3, 4, 3, 4)
        dtpEndTime.Name = "dtpEndTime"
        dtpEndTime.ShowUpDown = True
        dtpEndTime.Size = New Size(173, 27)
        dtpEndTime.TabIndex = 5
        ' 
        ' lblEndTime
        ' 
        lblEndTime.AutoSize = True
        lblEndTime.Font = New Font("Segoe UI", 9.5F)
        lblEndTime.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblEndTime.Location = New Point(521, 195)
        lblEndTime.Name = "lblEndTime"
        lblEndTime.Size = New Size(77, 21)
        lblEndTime.TabIndex = 10
        lblEndTime.Text = "End Time:"
        ' 
        ' dtpStartTime
        ' 
        dtpStartTime.CustomFormat = "hh:mm tt"
        dtpStartTime.Format = DateTimePickerFormat.Custom
        dtpStartTime.Location = New Point(229, 192)
        dtpStartTime.Margin = New Padding(3, 4, 3, 4)
        dtpStartTime.Name = "dtpStartTime"
        dtpStartTime.ShowUpDown = True
        dtpStartTime.Size = New Size(173, 27)
        dtpStartTime.TabIndex = 4
        ' 
        ' lblStartTime
        ' 
        lblStartTime.AutoSize = True
        lblStartTime.Font = New Font("Segoe UI", 9.5F)
        lblStartTime.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblStartTime.Location = New Point(137, 195)
        lblStartTime.Name = "lblStartTime"
        lblStartTime.Size = New Size(83, 21)
        lblStartTime.TabIndex = 8
        lblStartTime.Text = "Start Time:"
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Format = DateTimePickerFormat.Short
        dtpEndDate.Location = New Point(613, 139)
        dtpEndDate.Margin = New Padding(3, 4, 3, 4)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(173, 27)
        dtpEndDate.TabIndex = 3
        ' 
        ' lblEndDate
        ' 
        lblEndDate.AutoSize = True
        lblEndDate.Font = New Font("Segoe UI", 9.5F)
        lblEndDate.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblEndDate.Location = New Point(521, 141)
        lblEndDate.Name = "lblEndDate"
        lblEndDate.Size = New Size(75, 21)
        lblEndDate.TabIndex = 6
        lblEndDate.Text = "End Date:"
        ' 
        ' dtpStartDate
        ' 
        dtpStartDate.Format = DateTimePickerFormat.Short
        dtpStartDate.Location = New Point(229, 139)
        dtpStartDate.Margin = New Padding(3, 4, 3, 4)
        dtpStartDate.Name = "dtpStartDate"
        dtpStartDate.Size = New Size(173, 27)
        dtpStartDate.TabIndex = 2
        ' 
        ' lblStartDate
        ' 
        lblStartDate.AutoSize = True
        lblStartDate.Font = New Font("Segoe UI", 9.5F)
        lblStartDate.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblStartDate.Location = New Point(137, 141)
        lblStartDate.Name = "lblStartDate"
        lblStartDate.Size = New Size(81, 21)
        lblStartDate.TabIndex = 4
        lblStartDate.Text = "Start Date:"
        ' 
        ' txtWorkDays
        ' 
        txtWorkDays.Location = New Point(229, 85)
        txtWorkDays.Margin = New Padding(3, 4, 3, 4)
        txtWorkDays.Name = "txtWorkDays"
        txtWorkDays.Size = New Size(557, 27)
        txtWorkDays.TabIndex = 1
        ' 
        ' lblWorkDays
        ' 
        lblWorkDays.AutoSize = True
        lblWorkDays.Font = New Font("Segoe UI", 9.5F)
        lblWorkDays.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblWorkDays.Location = New Point(137, 88)
        lblWorkDays.Name = "lblWorkDays"
        lblWorkDays.Size = New Size(88, 21)
        lblWorkDays.TabIndex = 2
        lblWorkDays.Text = "Work Days:"
        ' 
        ' lblWorkScheduleTitle
        ' 
        lblWorkScheduleTitle.AutoSize = True
        lblWorkScheduleTitle.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        lblWorkScheduleTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblWorkScheduleTitle.Location = New Point(18, 21)
        lblWorkScheduleTitle.Name = "lblWorkScheduleTitle"
        lblWorkScheduleTitle.Size = New Size(140, 25)
        lblWorkScheduleTitle.TabIndex = 0
        lblWorkScheduleTitle.Text = "Work Schedule"
        ' 
        ' grpCompanyBorder
        ' 
        grpCompanyBorder.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpCompanyBorder.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        grpCompanyBorder.BorderStyle = BorderStyle.FixedSingle
        grpCompanyBorder.Controls.Add(cboEvaluator)
        grpCompanyBorder.Controls.Add(lblEvaluator)
        grpCompanyBorder.Controls.Add(cboSupervisor)
        grpCompanyBorder.Controls.Add(lblSupervisor)
        grpCompanyBorder.Controls.Add(cboCompany)
        grpCompanyBorder.Controls.Add(lblCompany)
        grpCompanyBorder.Controls.Add(lblCompanySectionTitle)
        grpCompanyBorder.Location = New Point(37, 277)
        grpCompanyBorder.Margin = New Padding(3, 4, 3, 4)
        grpCompanyBorder.Name = "grpCompanyBorder"
        grpCompanyBorder.Padding = New Padding(18, 21, 18, 21)
        grpCompanyBorder.Size = New Size(1034, 159)
        grpCompanyBorder.TabIndex = 5
        ' 
        ' cboEvaluator
        ' 
        cboEvaluator.DropDownStyle = ComboBoxStyle.DropDownList
        cboEvaluator.FormattingEnabled = True
        cboEvaluator.Location = New Point(640, 96)
        cboEvaluator.Margin = New Padding(3, 4, 3, 4)
        cboEvaluator.Name = "cboEvaluator"
        cboEvaluator.Size = New Size(329, 28)
        cboEvaluator.TabIndex = 3
        ' 
        ' lblEvaluator
        ' 
        lblEvaluator.AutoSize = True
        lblEvaluator.Font = New Font("Segoe UI", 9.5F)
        lblEvaluator.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblEvaluator.Location = New Point(539, 99)
        lblEvaluator.Name = "lblEvaluator"
        lblEvaluator.Size = New Size(78, 21)
        lblEvaluator.TabIndex = 5
        lblEvaluator.Text = "Evaluator:"
        ' 
        ' cboSupervisor
        ' 
        cboSupervisor.DropDownStyle = ComboBoxStyle.DropDownList
        cboSupervisor.FormattingEnabled = True
        cboSupervisor.Location = New Point(155, 96)
        cboSupervisor.Margin = New Padding(3, 4, 3, 4)
        cboSupervisor.Name = "cboSupervisor"
        cboSupervisor.Size = New Size(338, 28)
        cboSupervisor.TabIndex = 2
        ' 
        ' lblSupervisor
        ' 
        lblSupervisor.AutoSize = True
        lblSupervisor.Font = New Font("Segoe UI", 9.5F)
        lblSupervisor.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblSupervisor.Location = New Point(64, 99)
        lblSupervisor.Name = "lblSupervisor"
        lblSupervisor.Size = New Size(88, 21)
        lblSupervisor.TabIndex = 3
        lblSupervisor.Text = "Supervisor:"
        ' 
        ' cboCompany
        ' 
        cboCompany.DropDownStyle = ComboBoxStyle.DropDownList
        cboCompany.FormattingEnabled = True
        cboCompany.Location = New Point(155, 53)
        cboCompany.Margin = New Padding(3, 4, 3, 4)
        cboCompany.Name = "cboCompany"
        cboCompany.Size = New Size(383, 28)
        cboCompany.TabIndex = 1
        ' 
        ' lblCompany
        ' 
        lblCompany.AutoSize = True
        lblCompany.Font = New Font("Segoe UI", 9.5F)
        lblCompany.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCompany.Location = New Point(64, 56)
        lblCompany.Name = "lblCompany"
        lblCompany.Size = New Size(80, 21)
        lblCompany.TabIndex = 1
        lblCompany.Text = "Company:"
        ' 
        ' lblCompanySectionTitle
        ' 
        lblCompanySectionTitle.AutoSize = True
        lblCompanySectionTitle.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        lblCompanySectionTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCompanySectionTitle.Location = New Point(18, 21)
        lblCompanySectionTitle.Name = "lblCompanySectionTitle"
        lblCompanySectionTitle.Size = New Size(179, 25)
        lblCompanySectionTitle.TabIndex = 0
        lblCompanySectionTitle.Text = "Company & Contacts"
        ' 
        ' grpStudentBorder
        ' 
        grpStudentBorder.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpStudentBorder.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        grpStudentBorder.BorderStyle = BorderStyle.FixedSingle
        grpStudentBorder.Controls.Add(lblCurrentInternshipStatusValue)
        grpStudentBorder.Controls.Add(lblCurrentInternshipStatus)
        grpStudentBorder.Controls.Add(lblRequiredHoursValue)
        grpStudentBorder.Controls.Add(lblRequiredHours)
        grpStudentBorder.Controls.Add(lblCourseValueIA)
        grpStudentBorder.Controls.Add(lblCourseIA)
        grpStudentBorder.Controls.Add(lblStudentNameValueIA)
        grpStudentBorder.Controls.Add(lblStudentNameIA)
        grpStudentBorder.Controls.Add(lblStudentNoValueIA)
        grpStudentBorder.Controls.Add(lblStudentNoIA)
        grpStudentBorder.Controls.Add(lblStudentInfoTitle)
        grpStudentBorder.Location = New Point(37, 128)
        grpStudentBorder.Margin = New Padding(3, 4, 3, 4)
        grpStudentBorder.Name = "grpStudentBorder"
        grpStudentBorder.Padding = New Padding(18, 21, 18, 21)
        grpStudentBorder.Size = New Size(1034, 138)
        grpStudentBorder.TabIndex = 4
        ' 
        ' lblCurrentInternshipStatusValue
        ' 
        lblCurrentInternshipStatusValue.AutoSize = True
        lblCurrentInternshipStatusValue.Font = New Font("Segoe UI", 9.5F)
        lblCurrentInternshipStatusValue.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCurrentInternshipStatusValue.Location = New Point(731, 93)
        lblCurrentInternshipStatusValue.Name = "lblCurrentInternshipStatusValue"
        lblCurrentInternshipStatusValue.Size = New Size(16, 21)
        lblCurrentInternshipStatusValue.TabIndex = 10
        lblCurrentInternshipStatusValue.Text = "-"
        ' 
        ' lblCurrentInternshipStatus
        ' 
        lblCurrentInternshipStatus.AutoSize = True
        lblCurrentInternshipStatus.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblCurrentInternshipStatus.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCurrentInternshipStatus.Location = New Point(530, 93)
        lblCurrentInternshipStatus.Name = "lblCurrentInternshipStatus"
        lblCurrentInternshipStatus.Size = New Size(204, 21)
        lblCurrentInternshipStatus.TabIndex = 9
        lblCurrentInternshipStatus.Text = "Current Internship Status:"
        ' 
        ' lblRequiredHoursValue
        ' 
        lblRequiredHoursValue.AutoSize = True
        lblRequiredHoursValue.Font = New Font("Segoe UI", 9.5F)
        lblRequiredHoursValue.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblRequiredHoursValue.Location = New Point(731, 61)
        lblRequiredHoursValue.Name = "lblRequiredHoursValue"
        lblRequiredHoursValue.Size = New Size(16, 21)
        lblRequiredHoursValue.TabIndex = 8
        lblRequiredHoursValue.Text = "-"
        ' 
        ' lblRequiredHours
        ' 
        lblRequiredHours.AutoSize = True
        lblRequiredHours.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblRequiredHours.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblRequiredHours.Location = New Point(530, 61)
        lblRequiredHours.Name = "lblRequiredHours"
        lblRequiredHours.Size = New Size(132, 21)
        lblRequiredHours.TabIndex = 7
        lblRequiredHours.Text = "Required Hours:"
        ' 
        ' lblCourseValueIA
        ' 
        lblCourseValueIA.AutoSize = True
        lblCourseValueIA.Font = New Font("Segoe UI", 9.5F)
        lblCourseValueIA.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCourseValueIA.Location = New Point(165, 93)
        lblCourseValueIA.Name = "lblCourseValueIA"
        lblCourseValueIA.Size = New Size(16, 21)
        lblCourseValueIA.TabIndex = 6
        lblCourseValueIA.Text = "-"
        ' 
        ' lblCourseIA
        ' 
        lblCourseIA.AutoSize = True
        lblCourseIA.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblCourseIA.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCourseIA.Location = New Point(37, 93)
        lblCourseIA.Name = "lblCourseIA"
        lblCourseIA.Size = New Size(66, 21)
        lblCourseIA.TabIndex = 5
        lblCourseIA.Text = "Course:"
        ' 
        ' lblStudentNameValueIA
        ' 
        lblStudentNameValueIA.AutoSize = True
        lblStudentNameValueIA.Font = New Font("Segoe UI", 9.5F)
        lblStudentNameValueIA.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblStudentNameValueIA.Location = New Point(165, 61)
        lblStudentNameValueIA.Name = "lblStudentNameValueIA"
        lblStudentNameValueIA.Size = New Size(16, 21)
        lblStudentNameValueIA.TabIndex = 4
        lblStudentNameValueIA.Text = "-"
        ' 
        ' lblStudentNameIA
        ' 
        lblStudentNameIA.AutoSize = True
        lblStudentNameIA.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblStudentNameIA.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblStudentNameIA.Location = New Point(37, 61)
        lblStudentNameIA.Name = "lblStudentNameIA"
        lblStudentNameIA.Size = New Size(60, 21)
        lblStudentNameIA.TabIndex = 3
        lblStudentNameIA.Text = "Name:"
        ' 
        ' lblStudentNoValueIA
        ' 
        lblStudentNoValueIA.AutoSize = True
        lblStudentNoValueIA.Font = New Font("Segoe UI", 9.5F)
        lblStudentNoValueIA.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblStudentNoValueIA.Location = New Point(165, 29)
        lblStudentNoValueIA.Name = "lblStudentNoValueIA"
        lblStudentNoValueIA.Size = New Size(16, 21)
        lblStudentNoValueIA.TabIndex = 2
        lblStudentNoValueIA.Text = "-"
        ' 
        ' lblStudentNoIA
        ' 
        lblStudentNoIA.AutoSize = True
        lblStudentNoIA.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblStudentNoIA.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblStudentNoIA.Location = New Point(37, 29)
        lblStudentNoIA.Name = "lblStudentNoIA"
        lblStudentNoIA.Size = New Size(105, 21)
        lblStudentNoIA.TabIndex = 1
        lblStudentNoIA.Text = "Student No.:"
        ' 
        ' lblStudentInfoTitle
        ' 
        lblStudentInfoTitle.AutoSize = True
        lblStudentInfoTitle.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        lblStudentInfoTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblStudentInfoTitle.Location = New Point(18, 21)
        lblStudentInfoTitle.Name = "lblStudentInfoTitle"
        lblStudentInfoTitle.Size = New Size(142, 25)
        lblStudentInfoTitle.TabIndex = 0
        lblStudentInfoTitle.Text = "Student Details"
        ' 
        ' btnSearchStudentIA
        ' 
        btnSearchStudentIA.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnSearchStudentIA.FlatAppearance.BorderSize = 0
        btnSearchStudentIA.FlatStyle = FlatStyle.Flat
        btnSearchStudentIA.Font = New Font("Segoe UI Semibold", 10F)
        btnSearchStudentIA.ForeColor = Color.White
        btnSearchStudentIA.Location = New Point(448, 75)
        btnSearchStudentIA.Margin = New Padding(3, 4, 3, 4)
        btnSearchStudentIA.Name = "btnSearchStudentIA"
        btnSearchStudentIA.Size = New Size(114, 37)
        btnSearchStudentIA.TabIndex = 3
        btnSearchStudentIA.Text = "Search"
        btnSearchStudentIA.UseVisualStyleBackColor = False
        ' 
        ' txtSearchStudentIA
        ' 
        txtSearchStudentIA.Font = New Font("Segoe UI", 10F)
        txtSearchStudentIA.Location = New Point(183, 76)
        txtSearchStudentIA.Margin = New Padding(3, 4, 3, 4)
        txtSearchStudentIA.Name = "txtSearchStudentIA"
        txtSearchStudentIA.Size = New Size(255, 30)
        txtSearchStudentIA.TabIndex = 2
        ' 
        ' lblSearchStudentIA
        ' 
        lblSearchStudentIA.AutoSize = True
        lblSearchStudentIA.Font = New Font("Segoe UI", 10F)
        lblSearchStudentIA.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblSearchStudentIA.Location = New Point(37, 80)
        lblSearchStudentIA.Name = "lblSearchStudentIA"
        lblSearchStudentIA.Size = New Size(157, 23)
        lblSearchStudentIA.TabIndex = 1
        lblSearchStudentIA.Text = "Search Student No:"
        ' 
        ' lblInternshipTitle
        ' 
        lblInternshipTitle.AutoSize = True
        lblInternshipTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblInternshipTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblInternshipTitle.Location = New Point(32, 27)
        lblInternshipTitle.Name = "lblInternshipTitle"
        lblInternshipTitle.Size = New Size(323, 32)
        lblInternshipTitle.TabIndex = 0
        lblInternshipTitle.Text = "Assign Internship to Student"
        ' 
        ' pnlVisitLogs
        ' 
        pnlVisitLogs.BackColor = Color.White
        pnlVisitLogs.Controls.Add(grpVLForm)
        pnlVisitLogs.Controls.Add(dgvVisitLogs)
        pnlVisitLogs.Controls.Add(cboVLInternship)
        pnlVisitLogs.Controls.Add(lblVLSelectInternship)
        pnlVisitLogs.Controls.Add(lblVisitLogsTitle)
        pnlVisitLogs.Dock = DockStyle.Fill
        pnlVisitLogs.Location = New Point(0, 0)
        pnlVisitLogs.Margin = New Padding(3, 4, 3, 4)
        pnlVisitLogs.Name = "pnlVisitLogs"
        pnlVisitLogs.Size = New Size(1108, 853)
        pnlVisitLogs.TabIndex = 3
        pnlVisitLogs.Visible = False
        ' 
        ' grpVLForm
        ' 
        grpVLForm.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        grpVLForm.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        grpVLForm.BorderStyle = BorderStyle.FixedSingle
        grpVLForm.Controls.Add(lblVLFormTitle)
        grpVLForm.Controls.Add(lblVLVisitType)
        grpVLForm.Controls.Add(cboVLVisitType)
        grpVLForm.Controls.Add(lblVLVisitDate)
        grpVLForm.Controls.Add(dtpVLVisitDate)
        grpVLForm.Controls.Add(lblVLScore)
        grpVLForm.Controls.Add(txtVLScore)
        grpVLForm.Controls.Add(lblVLMaxScore)
        grpVLForm.Controls.Add(txtVLMaxScore)
        grpVLForm.Controls.Add(lblVLNextVisitDate)
        grpVLForm.Controls.Add(dtpVLNextVisitDate)
        grpVLForm.Controls.Add(lblVLRemarks)
        grpVLForm.Controls.Add(txtVLRemarks)
        grpVLForm.Controls.Add(lblVLAttachment)
        grpVLForm.Controls.Add(txtVLAttachment)
        grpVLForm.Controls.Add(btnVLBrowse)
        grpVLForm.Controls.Add(btnVLSave)
        grpVLForm.Controls.Add(btnVLCancel)
        grpVLForm.Location = New Point(37, 1227)
        grpVLForm.Margin = New Padding(3, 4, 3, 4)
        grpVLForm.Name = "grpVLForm"
        grpVLForm.Padding = New Padding(18, 21, 18, 21)
        grpVLForm.Size = New Size(1914, 309)
        grpVLForm.TabIndex = 4
        ' 
        ' lblVLFormTitle
        ' 
        lblVLFormTitle.AutoSize = True
        lblVLFormTitle.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        lblVLFormTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblVLFormTitle.Location = New Point(18, 21)
        lblVLFormTitle.Name = "lblVLFormTitle"
        lblVLFormTitle.Size = New Size(140, 25)
        lblVLFormTitle.TabIndex = 0
        lblVLFormTitle.Text = "Add / Edit Visit"
        ' 
        ' lblVLVisitType
        ' 
        lblVLVisitType.AutoSize = True
        lblVLVisitType.Font = New Font("Segoe UI", 9.5F)
        lblVLVisitType.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblVLVisitType.Location = New Point(37, 69)
        lblVLVisitType.Name = "lblVLVisitType"
        lblVLVisitType.Size = New Size(79, 21)
        lblVLVisitType.TabIndex = 1
        lblVLVisitType.Text = "Visit Type:"
        ' 
        ' cboVLVisitType
        ' 
        cboVLVisitType.DropDownStyle = ComboBoxStyle.DropDownList
        cboVLVisitType.Location = New Point(137, 67)
        cboVLVisitType.Margin = New Padding(3, 4, 3, 4)
        cboVLVisitType.Name = "cboVLVisitType"
        cboVLVisitType.Size = New Size(205, 28)
        cboVLVisitType.TabIndex = 1
        ' 
        ' lblVLVisitDate
        ' 
        lblVLVisitDate.AutoSize = True
        lblVLVisitDate.Font = New Font("Segoe UI", 9.5F)
        lblVLVisitDate.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblVLVisitDate.Location = New Point(379, 69)
        lblVLVisitDate.Name = "lblVLVisitDate"
        lblVLVisitDate.Size = New Size(79, 21)
        lblVLVisitDate.TabIndex = 3
        lblVLVisitDate.Text = "Visit Date:"
        ' 
        ' dtpVLVisitDate
        ' 
        dtpVLVisitDate.Format = DateTimePickerFormat.Short
        dtpVLVisitDate.Location = New Point(475, 67)
        dtpVLVisitDate.Margin = New Padding(3, 4, 3, 4)
        dtpVLVisitDate.Name = "dtpVLVisitDate"
        dtpVLVisitDate.Size = New Size(159, 27)
        dtpVLVisitDate.TabIndex = 2
        ' 
        ' lblVLScore
        ' 
        lblVLScore.AutoSize = True
        lblVLScore.Font = New Font("Segoe UI", 9.5F)
        lblVLScore.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblVLScore.Location = New Point(37, 112)
        lblVLScore.Name = "lblVLScore"
        lblVLScore.Size = New Size(52, 21)
        lblVLScore.TabIndex = 5
        lblVLScore.Text = "Score:"
        ' 
        ' txtVLScore
        ' 
        txtVLScore.Location = New Point(137, 109)
        txtVLScore.Margin = New Padding(3, 4, 3, 4)
        txtVLScore.Name = "txtVLScore"
        txtVLScore.Size = New Size(91, 27)
        txtVLScore.TabIndex = 3
        ' 
        ' lblVLMaxScore
        ' 
        lblVLMaxScore.AutoSize = True
        lblVLMaxScore.Font = New Font("Segoe UI", 9.5F)
        lblVLMaxScore.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblVLMaxScore.Location = New Point(251, 112)
        lblVLMaxScore.Name = "lblVLMaxScore"
        lblVLMaxScore.Size = New Size(81, 21)
        lblVLMaxScore.TabIndex = 7
        lblVLMaxScore.Text = "MaxScore:"
        ' 
        ' txtVLMaxScore
        ' 
        txtVLMaxScore.Location = New Point(343, 109)
        txtVLMaxScore.Margin = New Padding(3, 4, 3, 4)
        txtVLMaxScore.Name = "txtVLMaxScore"
        txtVLMaxScore.Size = New Size(91, 27)
        txtVLMaxScore.TabIndex = 4
        ' 
        ' lblVLNextVisitDate
        ' 
        lblVLNextVisitDate.AutoSize = True
        lblVLNextVisitDate.Font = New Font("Segoe UI", 9.5F)
        lblVLNextVisitDate.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblVLNextVisitDate.Location = New Point(466, 112)
        lblVLNextVisitDate.Name = "lblVLNextVisitDate"
        lblVLNextVisitDate.Size = New Size(115, 21)
        lblVLNextVisitDate.TabIndex = 9
        lblVLNextVisitDate.Text = "Next Visit Date:"
        ' 
        ' dtpVLNextVisitDate
        ' 
        dtpVLNextVisitDate.Format = DateTimePickerFormat.Short
        dtpVLNextVisitDate.Location = New Point(585, 109)
        dtpVLNextVisitDate.Margin = New Padding(3, 4, 3, 4)
        dtpVLNextVisitDate.Name = "dtpVLNextVisitDate"
        dtpVLNextVisitDate.ShowCheckBox = True
        dtpVLNextVisitDate.Size = New Size(159, 27)
        dtpVLNextVisitDate.TabIndex = 5
        dtpVLNextVisitDate.Checked = False
        ' 
        ' lblVLRemarks
        ' 
        lblVLRemarks.AutoSize = True
        lblVLRemarks.Font = New Font("Segoe UI", 9.5F)
        lblVLRemarks.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblVLRemarks.Location = New Point(37, 160)
        lblVLRemarks.Name = "lblVLRemarks"
        lblVLRemarks.Size = New Size(74, 21)
        lblVLRemarks.TabIndex = 11
        lblVLRemarks.Text = "Remarks:"
        ' 
        ' txtVLRemarks
        ' 
        txtVLRemarks.Location = New Point(137, 157)
        txtVLRemarks.Margin = New Padding(3, 4, 3, 4)
        txtVLRemarks.Multiline = True
        txtVLRemarks.Name = "txtVLRemarks"
        txtVLRemarks.ScrollBars = ScrollBars.Vertical
        txtVLRemarks.Size = New Size(402, 84)
        txtVLRemarks.TabIndex = 6
        ' 
        ' lblVLAttachment
        ' 
        lblVLAttachment.AutoSize = True
        lblVLAttachment.Font = New Font("Segoe UI", 9.5F)
        lblVLAttachment.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblVLAttachment.Location = New Point(558, 160)
        lblVLAttachment.Name = "lblVLAttachment"
        lblVLAttachment.Size = New Size(93, 21)
        lblVLAttachment.TabIndex = 13
        lblVLAttachment.Text = "Attachment:"
        ' 
        ' txtVLAttachment
        ' 
        txtVLAttachment.Location = New Point(658, 157)
        txtVLAttachment.Margin = New Padding(3, 4, 3, 4)
        txtVLAttachment.Name = "txtVLAttachment"
        txtVLAttachment.Size = New Size(228, 27)
        txtVLAttachment.TabIndex = 7
        ' 
        ' btnVLBrowse
        ' 
        btnVLBrowse.BackColor = Color.FromArgb(CByte(255), CByte(235), CByte(59))
        btnVLBrowse.FlatAppearance.BorderSize = 0
        btnVLBrowse.FlatStyle = FlatStyle.Flat
        btnVLBrowse.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnVLBrowse.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        btnVLBrowse.Location = New Point(894, 155)
        btnVLBrowse.Margin = New Padding(3, 4, 3, 4)
        btnVLBrowse.Name = "btnVLBrowse"
        btnVLBrowse.Size = New Size(91, 35)
        btnVLBrowse.TabIndex = 8
        btnVLBrowse.Text = "Browse..."
        btnVLBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnVLSave
        ' 
        btnVLSave.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnVLSave.FlatAppearance.BorderSize = 0
        btnVLSave.FlatStyle = FlatStyle.Flat
        btnVLSave.Font = New Font("Segoe UI Semibold", 10F)
        btnVLSave.ForeColor = Color.White
        btnVLSave.Location = New Point(137, 256)
        btnVLSave.Margin = New Padding(3, 4, 3, 4)
        btnVLSave.Name = "btnVLSave"
        btnVLSave.Size = New Size(110, 37)
        btnVLSave.TabIndex = 9
        btnVLSave.Text = "Save"
        btnVLSave.UseVisualStyleBackColor = False
        ' 
        ' btnVLCancel
        ' 
        btnVLCancel.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnVLCancel.FlatAppearance.BorderSize = 0
        btnVLCancel.FlatStyle = FlatStyle.Flat
        btnVLCancel.Font = New Font("Segoe UI", 10F)
        btnVLCancel.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        btnVLCancel.Location = New Point(261, 256)
        btnVLCancel.Margin = New Padding(3, 4, 3, 4)
        btnVLCancel.Name = "btnVLCancel"
        btnVLCancel.Size = New Size(110, 37)
        btnVLCancel.TabIndex = 10
        btnVLCancel.Text = "Cancel"
        btnVLCancel.UseVisualStyleBackColor = False
        ' 
        ' dgvVisitLogs
        ' 
        dgvVisitLogs.AllowUserToAddRows = False
        dgvVisitLogs.AllowUserToDeleteRows = False
        dgvVisitLogs.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvVisitLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvVisitLogs.BackgroundColor = Color.White
        dgvVisitLogs.BorderStyle = BorderStyle.None
        dgvVisitLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVisitLogs.Location = New Point(37, 139)
        dgvVisitLogs.Margin = New Padding(3, 4, 3, 4)
        dgvVisitLogs.MultiSelect = False
        dgvVisitLogs.Name = "dgvVisitLogs"
        dgvVisitLogs.ReadOnly = True
        dgvVisitLogs.RowHeadersVisible = False
        dgvVisitLogs.RowHeadersWidth = 51
        dgvVisitLogs.RowTemplate.Height = 26
        dgvVisitLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVisitLogs.Size = New Size(1914, 1067)
        dgvVisitLogs.TabIndex = 3
        ' 
        ' cboVLInternship
        ' 
        cboVLInternship.DropDownStyle = ComboBoxStyle.DropDownList
        cboVLInternship.Font = New Font("Segoe UI", 10F)
        cboVLInternship.Location = New Point(183, 81)
        cboVLInternship.Margin = New Padding(3, 4, 3, 4)
        cboVLInternship.Name = "cboVLInternship"
        cboVLInternship.Size = New Size(479, 31)
        cboVLInternship.TabIndex = 2
        ' 
        ' lblVLSelectInternship
        ' 
        lblVLSelectInternship.AutoSize = True
        lblVLSelectInternship.Font = New Font("Segoe UI", 10F)
        lblVLSelectInternship.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblVLSelectInternship.Location = New Point(37, 85)
        lblVLSelectInternship.Name = "lblVLSelectInternship"
        lblVLSelectInternship.Size = New Size(141, 23)
        lblVLSelectInternship.TabIndex = 1
        lblVLSelectInternship.Text = "Select Internship:"
        ' 
        ' lblVisitLogsTitle
        ' 
        lblVisitLogsTitle.AutoSize = True
        lblVisitLogsTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblVisitLogsTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblVisitLogsTitle.Location = New Point(32, 27)
        lblVisitLogsTitle.Name = "lblVisitLogsTitle"
        lblVisitLogsTitle.Size = New Size(117, 32)
        lblVisitLogsTitle.TabIndex = 0
        lblVisitLogsTitle.Text = "Visit Logs"
        ' 
        ' pnlGrading
        ' 
        pnlGrading.BackColor = Color.White
        pnlGrading.Controls.Add(grpGradeForm)
        pnlGrading.Controls.Add(grpGradeStudentInfo)
        pnlGrading.Controls.Add(cboGradeStudent)
        pnlGrading.Controls.Add(lblGradeSelectStudent)
        pnlGrading.Controls.Add(lblGradingTitle)
        pnlGrading.Dock = DockStyle.Fill
        pnlGrading.Location = New Point(0, 0)
        pnlGrading.Margin = New Padding(3, 4, 3, 4)
        pnlGrading.Name = "pnlGrading"
        pnlGrading.Size = New Size(1108, 853)
        pnlGrading.TabIndex = 4
        pnlGrading.Visible = False
        ' 
        ' grpGradeForm
        ' 
        grpGradeForm.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpGradeForm.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        grpGradeForm.BorderStyle = BorderStyle.FixedSingle
        grpGradeForm.Controls.Add(lblGradeFormTitle)
        grpGradeForm.Controls.Add(lblFinalGradeLabel)
        grpGradeForm.Controls.Add(txtFinalGrade)
        grpGradeForm.Controls.Add(lblGradeHint)
        grpGradeForm.Controls.Add(btnSaveGrade)
        grpGradeForm.Controls.Add(btnClearGrade)
        grpGradeForm.Location = New Point(37, 389)
        grpGradeForm.Margin = New Padding(3, 4, 3, 4)
        grpGradeForm.Name = "grpGradeForm"
        grpGradeForm.Padding = New Padding(18, 21, 18, 21)
        grpGradeForm.Size = New Size(1914, 213)
        grpGradeForm.TabIndex = 4
        ' 
        ' lblGradeFormTitle
        ' 
        lblGradeFormTitle.AutoSize = True
        lblGradeFormTitle.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        lblGradeFormTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradeFormTitle.Location = New Point(18, 21)
        lblGradeFormTitle.Name = "lblGradeFormTitle"
        lblGradeFormTitle.Size = New Size(109, 25)
        lblGradeFormTitle.TabIndex = 0
        lblGradeFormTitle.Text = "Final Grade"
        ' 
        ' lblFinalGradeLabel
        ' 
        lblFinalGradeLabel.AutoSize = True
        lblFinalGradeLabel.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblFinalGradeLabel.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblFinalGradeLabel.Location = New Point(37, 75)
        lblFinalGradeLabel.Name = "lblFinalGradeLabel"
        lblFinalGradeLabel.Size = New Size(100, 21)
        lblFinalGradeLabel.TabIndex = 1
        lblFinalGradeLabel.Text = "Final Grade:"
        ' 
        ' txtFinalGrade
        ' 
        txtFinalGrade.Font = New Font("Segoe UI", 10F)
        txtFinalGrade.Location = New Point(146, 71)
        txtFinalGrade.Margin = New Padding(3, 4, 3, 4)
        txtFinalGrade.Name = "txtFinalGrade"
        txtFinalGrade.Size = New Size(91, 30)
        txtFinalGrade.TabIndex = 1
        ' 
        ' lblGradeHint
        ' 
        lblGradeHint.AutoSize = True
        lblGradeHint.Font = New Font("Segoe UI", 9F, FontStyle.Italic)
        lblGradeHint.ForeColor = Color.FromArgb(CByte(120), CByte(120), CByte(120))
        lblGradeHint.Location = New Point(256, 76)
        lblGradeHint.Name = "lblGradeHint"
        lblGradeHint.Size = New Size(259, 20)
        lblGradeHint.TabIndex = 3
        lblGradeHint.Text = "Example: 95.00 (0 - 100 scale, decimal)"
        ' 
        ' btnSaveGrade
        ' 
        btnSaveGrade.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnSaveGrade.FlatAppearance.BorderSize = 0
        btnSaveGrade.FlatStyle = FlatStyle.Flat
        btnSaveGrade.Font = New Font("Segoe UI Semibold", 10F)
        btnSaveGrade.ForeColor = Color.White
        btnSaveGrade.Location = New Point(146, 128)
        btnSaveGrade.Margin = New Padding(3, 4, 3, 4)
        btnSaveGrade.Name = "btnSaveGrade"
        btnSaveGrade.Size = New Size(126, 40)
        btnSaveGrade.TabIndex = 2
        btnSaveGrade.Text = "Save Grade"
        btnSaveGrade.UseVisualStyleBackColor = False
        ' 
        ' btnClearGrade
        ' 
        btnClearGrade.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnClearGrade.FlatAppearance.BorderSize = 0
        btnClearGrade.FlatStyle = FlatStyle.Flat
        btnClearGrade.Font = New Font("Segoe UI", 10F)
        btnClearGrade.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        btnClearGrade.Location = New Point(283, 128)
        btnClearGrade.Margin = New Padding(3, 4, 3, 4)
        btnClearGrade.Name = "btnClearGrade"
        btnClearGrade.Size = New Size(114, 40)
        btnClearGrade.TabIndex = 3
        btnClearGrade.Text = "Clear"
        btnClearGrade.UseVisualStyleBackColor = False
        ' 
        ' grpGradeStudentInfo
        ' 
        grpGradeStudentInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        grpGradeStudentInfo.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        grpGradeStudentInfo.BorderStyle = BorderStyle.FixedSingle
        grpGradeStudentInfo.Controls.Add(lblGradeStudentInfoTitle)
        grpGradeStudentInfo.Controls.Add(lblGradeStudentNoLabel)
        grpGradeStudentInfo.Controls.Add(lblGradeStudentNoValue)
        grpGradeStudentInfo.Controls.Add(lblGradeNameLabel)
        grpGradeStudentInfo.Controls.Add(lblGradeNameValue)
        grpGradeStudentInfo.Controls.Add(lblGradeCourseLabel)
        grpGradeStudentInfo.Controls.Add(lblGradeCourseValue)
        grpGradeStudentInfo.Controls.Add(lblGradeRequiredHoursLabel)
        grpGradeStudentInfo.Controls.Add(lblGradeRequiredHoursValue)
        grpGradeStudentInfo.Controls.Add(lblGradeCompletedHoursLabel)
        grpGradeStudentInfo.Controls.Add(lblGradeCompletedHoursValue)
        grpGradeStudentInfo.Controls.Add(lblGradeStatusLabel)
        grpGradeStudentInfo.Controls.Add(lblGradeStatusValue)
        grpGradeStudentInfo.Location = New Point(37, 139)
        grpGradeStudentInfo.Margin = New Padding(3, 4, 3, 4)
        grpGradeStudentInfo.Name = "grpGradeStudentInfo"
        grpGradeStudentInfo.Padding = New Padding(18, 21, 18, 21)
        grpGradeStudentInfo.Size = New Size(1914, 223)
        grpGradeStudentInfo.TabIndex = 3
        ' 
        ' lblGradeStudentInfoTitle
        ' 
        lblGradeStudentInfoTitle.AutoSize = True
        lblGradeStudentInfoTitle.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        lblGradeStudentInfoTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradeStudentInfoTitle.Location = New Point(18, 21)
        lblGradeStudentInfoTitle.Name = "lblGradeStudentInfoTitle"
        lblGradeStudentInfoTitle.Size = New Size(142, 25)
        lblGradeStudentInfoTitle.TabIndex = 0
        lblGradeStudentInfoTitle.Text = "Student Details"
        ' 
        ' lblGradeStudentNoLabel
        ' 
        lblGradeStudentNoLabel.AutoSize = True
        lblGradeStudentNoLabel.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblGradeStudentNoLabel.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradeStudentNoLabel.Location = New Point(37, 69)
        lblGradeStudentNoLabel.Name = "lblGradeStudentNoLabel"
        lblGradeStudentNoLabel.Size = New Size(105, 21)
        lblGradeStudentNoLabel.TabIndex = 1
        lblGradeStudentNoLabel.Text = "Student No.:"
        ' 
        ' lblGradeStudentNoValue
        ' 
        lblGradeStudentNoValue.AutoSize = True
        lblGradeStudentNoValue.Font = New Font("Segoe UI", 9.5F)
        lblGradeStudentNoValue.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradeStudentNoValue.Location = New Point(165, 69)
        lblGradeStudentNoValue.Name = "lblGradeStudentNoValue"
        lblGradeStudentNoValue.Size = New Size(16, 21)
        lblGradeStudentNoValue.TabIndex = 2
        lblGradeStudentNoValue.Text = "-"
        ' 
        ' lblGradeNameLabel
        ' 
        lblGradeNameLabel.AutoSize = True
        lblGradeNameLabel.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblGradeNameLabel.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradeNameLabel.Location = New Point(37, 101)
        lblGradeNameLabel.Name = "lblGradeNameLabel"
        lblGradeNameLabel.Size = New Size(60, 21)
        lblGradeNameLabel.TabIndex = 3
        lblGradeNameLabel.Text = "Name:"
        ' 
        ' lblGradeNameValue
        ' 
        lblGradeNameValue.AutoSize = True
        lblGradeNameValue.Font = New Font("Segoe UI", 9.5F)
        lblGradeNameValue.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradeNameValue.Location = New Point(165, 101)
        lblGradeNameValue.Name = "lblGradeNameValue"
        lblGradeNameValue.Size = New Size(16, 21)
        lblGradeNameValue.TabIndex = 4
        lblGradeNameValue.Text = "-"
        ' 
        ' lblGradeCourseLabel
        ' 
        lblGradeCourseLabel.AutoSize = True
        lblGradeCourseLabel.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblGradeCourseLabel.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradeCourseLabel.Location = New Point(37, 133)
        lblGradeCourseLabel.Name = "lblGradeCourseLabel"
        lblGradeCourseLabel.Size = New Size(66, 21)
        lblGradeCourseLabel.TabIndex = 5
        lblGradeCourseLabel.Text = "Course:"
        ' 
        ' lblGradeCourseValue
        ' 
        lblGradeCourseValue.AutoSize = True
        lblGradeCourseValue.Font = New Font("Segoe UI", 9.5F)
        lblGradeCourseValue.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradeCourseValue.Location = New Point(165, 133)
        lblGradeCourseValue.Name = "lblGradeCourseValue"
        lblGradeCourseValue.Size = New Size(16, 21)
        lblGradeCourseValue.TabIndex = 6
        lblGradeCourseValue.Text = "-"
        ' 
        ' lblGradeRequiredHoursLabel
        ' 
        lblGradeRequiredHoursLabel.AutoSize = True
        lblGradeRequiredHoursLabel.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblGradeRequiredHoursLabel.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradeRequiredHoursLabel.Location = New Point(530, 69)
        lblGradeRequiredHoursLabel.Name = "lblGradeRequiredHoursLabel"
        lblGradeRequiredHoursLabel.Size = New Size(132, 21)
        lblGradeRequiredHoursLabel.TabIndex = 7
        lblGradeRequiredHoursLabel.Text = "Required Hours:"
        ' 
        ' lblGradeRequiredHoursValue
        ' 
        lblGradeRequiredHoursValue.AutoSize = True
        lblGradeRequiredHoursValue.Font = New Font("Segoe UI", 9.5F)
        lblGradeRequiredHoursValue.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradeRequiredHoursValue.Location = New Point(677, 69)
        lblGradeRequiredHoursValue.Name = "lblGradeRequiredHoursValue"
        lblGradeRequiredHoursValue.Size = New Size(16, 21)
        lblGradeRequiredHoursValue.TabIndex = 8
        lblGradeRequiredHoursValue.Text = "-"
        ' 
        ' lblGradeCompletedHoursLabel
        ' 
        lblGradeCompletedHoursLabel.AutoSize = True
        lblGradeCompletedHoursLabel.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblGradeCompletedHoursLabel.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradeCompletedHoursLabel.Location = New Point(530, 101)
        lblGradeCompletedHoursLabel.Name = "lblGradeCompletedHoursLabel"
        lblGradeCompletedHoursLabel.Size = New Size(147, 21)
        lblGradeCompletedHoursLabel.TabIndex = 9
        lblGradeCompletedHoursLabel.Text = "Completed Hours:"
        ' 
        ' lblGradeCompletedHoursValue
        ' 
        lblGradeCompletedHoursValue.AutoSize = True
        lblGradeCompletedHoursValue.Font = New Font("Segoe UI", 9.5F)
        lblGradeCompletedHoursValue.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradeCompletedHoursValue.Location = New Point(677, 101)
        lblGradeCompletedHoursValue.Name = "lblGradeCompletedHoursValue"
        lblGradeCompletedHoursValue.Size = New Size(16, 21)
        lblGradeCompletedHoursValue.TabIndex = 10
        lblGradeCompletedHoursValue.Text = "-"
        ' 
        ' lblGradeStatusLabel
        ' 
        lblGradeStatusLabel.AutoSize = True
        lblGradeStatusLabel.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblGradeStatusLabel.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradeStatusLabel.Location = New Point(530, 133)
        lblGradeStatusLabel.Name = "lblGradeStatusLabel"
        lblGradeStatusLabel.Size = New Size(61, 21)
        lblGradeStatusLabel.TabIndex = 11
        lblGradeStatusLabel.Text = "Status:"
        ' 
        ' lblGradeStatusValue
        ' 
        lblGradeStatusValue.AutoSize = True
        lblGradeStatusValue.Font = New Font("Segoe UI", 9.5F)
        lblGradeStatusValue.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradeStatusValue.Location = New Point(677, 133)
        lblGradeStatusValue.Name = "lblGradeStatusValue"
        lblGradeStatusValue.Size = New Size(16, 21)
        lblGradeStatusValue.TabIndex = 12
        lblGradeStatusValue.Text = "-"
        ' 
        ' cboGradeStudent
        ' 
        cboGradeStudent.DropDownStyle = ComboBoxStyle.DropDownList
        cboGradeStudent.Font = New Font("Segoe UI", 10F)
        cboGradeStudent.Location = New Point(174, 81)
        cboGradeStudent.Margin = New Padding(3, 4, 3, 4)
        cboGradeStudent.Name = "cboGradeStudent"
        cboGradeStudent.Size = New Size(479, 31)
        cboGradeStudent.TabIndex = 2
        ' 
        ' lblGradeSelectStudent
        ' 
        lblGradeSelectStudent.AutoSize = True
        lblGradeSelectStudent.Font = New Font("Segoe UI", 10F)
        lblGradeSelectStudent.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradeSelectStudent.Location = New Point(37, 85)
        lblGradeSelectStudent.Name = "lblGradeSelectStudent"
        lblGradeSelectStudent.Size = New Size(123, 23)
        lblGradeSelectStudent.TabIndex = 1
        lblGradeSelectStudent.Text = "Select Student:"
        ' 
        ' lblGradingTitle
        ' 
        lblGradingTitle.AutoSize = True
        lblGradingTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblGradingTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGradingTitle.Location = New Point(32, 27)
        lblGradingTitle.Name = "lblGradingTitle"
        lblGradingTitle.Size = New Size(101, 32)
        lblGradingTitle.TabIndex = 0
        lblGradingTitle.Text = "Grading"
        ' 
        ' pnlCompanies
        ' 
        pnlCompanies.BackColor = Color.White
        pnlCompanies.Controls.Add(dgvCompanies)
        pnlCompanies.Controls.Add(btnAddCompany)
        pnlCompanies.Controls.Add(btnSearchCompany)
        pnlCompanies.Controls.Add(txtSearchCompany)
        pnlCompanies.Controls.Add(lblSearchCompany)
        pnlCompanies.Controls.Add(lblCompaniesTitle)
        pnlCompanies.Dock = DockStyle.Fill
        pnlCompanies.Location = New Point(0, 0)
        pnlCompanies.Margin = New Padding(3, 4, 3, 4)
        pnlCompanies.Name = "pnlCompanies"
        pnlCompanies.Size = New Size(1108, 853)
        pnlCompanies.TabIndex = 5
        pnlCompanies.Visible = False
        ' 
        ' dgvCompanies
        ' 
        dgvCompanies.AllowUserToAddRows = False
        dgvCompanies.AllowUserToDeleteRows = False
        dgvCompanies.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCompanies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCompanies.BackgroundColor = Color.White
        dgvCompanies.BorderStyle = BorderStyle.None
        dgvCompanies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCompanies.Location = New Point(37, 139)
        dgvCompanies.Margin = New Padding(3, 4, 3, 4)
        dgvCompanies.MultiSelect = False
        dgvCompanies.Name = "dgvCompanies"
        dgvCompanies.ReadOnly = True
        dgvCompanies.RowHeadersVisible = False
        dgvCompanies.RowHeadersWidth = 51
        dgvCompanies.RowTemplate.Height = 26
        dgvCompanies.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCompanies.Size = New Size(1914, 1403)
        dgvCompanies.TabIndex = 5
        ' 
        ' btnAddCompany
        ' 
        btnAddCompany.BackColor = Color.FromArgb(CByte(255), CByte(235), CByte(59))
        btnAddCompany.FlatAppearance.BorderSize = 0
        btnAddCompany.FlatStyle = FlatStyle.Flat
        btnAddCompany.Font = New Font("Segoe UI Semibold", 10F)
        btnAddCompany.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        btnAddCompany.Location = New Point(558, 79)
        btnAddCompany.Margin = New Padding(3, 4, 3, 4)
        btnAddCompany.Name = "btnAddCompany"
        btnAddCompany.Size = New Size(137, 37)
        btnAddCompany.TabIndex = 4
        btnAddCompany.Text = "Add Company"
        btnAddCompany.UseVisualStyleBackColor = False
        ' 
        ' btnSearchCompany
        ' 
        btnSearchCompany.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnSearchCompany.FlatAppearance.BorderSize = 0
        btnSearchCompany.FlatStyle = FlatStyle.Flat
        btnSearchCompany.Font = New Font("Segoe UI Semibold", 10F)
        btnSearchCompany.ForeColor = Color.White
        btnSearchCompany.Location = New Point(434, 79)
        btnSearchCompany.Margin = New Padding(3, 4, 3, 4)
        btnSearchCompany.Name = "btnSearchCompany"
        btnSearchCompany.Size = New Size(103, 37)
        btnSearchCompany.TabIndex = 3
        btnSearchCompany.Text = "Search"
        btnSearchCompany.UseVisualStyleBackColor = False
        ' 
        ' txtSearchCompany
        ' 
        txtSearchCompany.Font = New Font("Segoe UI", 10F)
        txtSearchCompany.Location = New Point(105, 81)
        txtSearchCompany.Margin = New Padding(3, 4, 3, 4)
        txtSearchCompany.Name = "txtSearchCompany"
        txtSearchCompany.Size = New Size(319, 30)
        txtSearchCompany.TabIndex = 2
        ' 
        ' lblSearchCompany
        ' 
        lblSearchCompany.AutoSize = True
        lblSearchCompany.Font = New Font("Segoe UI", 10F)
        lblSearchCompany.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblSearchCompany.Location = New Point(37, 85)
        lblSearchCompany.Name = "lblSearchCompany"
        lblSearchCompany.Size = New Size(65, 23)
        lblSearchCompany.TabIndex = 1
        lblSearchCompany.Text = "Search:"
        ' 
        ' pnlCompanyContacts
        ' 
        pnlCompanyContacts.BackColor = Color.White
        pnlCompanyContacts.Controls.Add(dgvContacts)
        pnlCompanyContacts.Controls.Add(lblContactCompany)
        pnlCompanyContacts.Controls.Add(lblCompanyContactsTitle)
        pnlCompanyContacts.Dock = DockStyle.Fill
        pnlCompanyContacts.Location = New Point(0, 0)
        pnlCompanyContacts.Margin = New Padding(3, 4, 3, 4)
        pnlCompanyContacts.Name = "pnlCompanyContacts"
        pnlCompanyContacts.Size = New Size(1108, 853)
        pnlCompanyContacts.TabIndex = 6
        pnlCompanyContacts.Visible = False
        ' 
        ' dgvContacts
        ' 
        dgvContacts.AllowUserToAddRows = False
        dgvContacts.AllowUserToDeleteRows = False
        dgvContacts.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvContacts.BackgroundColor = Color.White
        dgvContacts.BorderStyle = BorderStyle.None
        dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvContacts.Location = New Point(37, 139)
        dgvContacts.Margin = New Padding(3, 4, 3, 4)
        dgvContacts.MultiSelect = False
        dgvContacts.Name = "dgvContacts"
        dgvContacts.ReadOnly = True
        dgvContacts.RowHeadersVisible = False
        dgvContacts.RowHeadersWidth = 51
        dgvContacts.RowTemplate.Height = 26
        dgvContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvContacts.Size = New Size(1914, 1403)
        dgvContacts.TabIndex = 4
        ' 
        ' lblContactCompany
        ' 
        lblContactCompany.AutoSize = True
        lblContactCompany.Font = New Font("Segoe UI", 10F)
        lblContactCompany.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblContactCompany.Location = New Point(37, 85)
        lblContactCompany.Name = "lblContactCompany"
        lblContactCompany.Size = New Size(87, 23)
        lblContactCompany.TabIndex = 1
        lblContactCompany.Text = "Company:"
        ' 
        ' lblCompanyContactsTitle
        ' 
        lblCompanyContactsTitle.AutoSize = True
        lblCompanyContactsTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblCompanyContactsTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCompanyContactsTitle.Location = New Point(32, 27)
        lblCompanyContactsTitle.Name = "lblCompanyContactsTitle"
        lblCompanyContactsTitle.Size = New Size(219, 32)
        lblCompanyContactsTitle.TabIndex = 0
        lblCompanyContactsTitle.Text = "Company Contacts"
        ' 
        ' pnlFacultyProfile
        ' 
        pnlFacultyProfile.BackColor = Color.White
        pnlFacultyProfile.Controls.Add(lblProfileTitle)
        pnlFacultyProfile.Controls.Add(lblNameCaption)
        pnlFacultyProfile.Controls.Add(lblFacultyName)
        pnlFacultyProfile.Controls.Add(lblPositionCaption)
        pnlFacultyProfile.Controls.Add(lblFacultyPosition)
        pnlFacultyProfile.Controls.Add(lblEmployeeNoCaption)
        pnlFacultyProfile.Controls.Add(lblEmployeeNumber)
        pnlFacultyProfile.Controls.Add(lblDepartmentCaption)
        pnlFacultyProfile.Controls.Add(lblDepartment)
        pnlFacultyProfile.Controls.Add(lblEditableHeader)
        pnlFacultyProfile.Controls.Add(lblEmailCaption)
        pnlFacultyProfile.Controls.Add(txtFacultyEmail)
        pnlFacultyProfile.Controls.Add(lblContactCaption)
        pnlFacultyProfile.Controls.Add(txtFacultyContact)
        pnlFacultyProfile.Controls.Add(btnEditFaculty)
        pnlFacultyProfile.Controls.Add(btnSaveFaculty)
        pnlFacultyProfile.Dock = DockStyle.Fill
        pnlFacultyProfile.Location = New Point(0, 0)
        pnlFacultyProfile.Margin = New Padding(3, 4, 3, 4)
        pnlFacultyProfile.Name = "pnlFacultyProfile"
        pnlFacultyProfile.Size = New Size(1108, 853)
        pnlFacultyProfile.TabIndex = 7
        pnlFacultyProfile.Visible = False
        ' 
        ' lblProfileTitle
        ' 
        lblProfileTitle.AutoSize = True
        lblProfileTitle.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        lblProfileTitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblProfileTitle.Location = New Point(37, 32)
        lblProfileTitle.Name = "lblProfileTitle"
        lblProfileTitle.Size = New Size(190, 37)
        lblProfileTitle.TabIndex = 0
        lblProfileTitle.Text = "Faculty Profile"
        ' 
        ' lblNameCaption
        ' 
        lblNameCaption.Font = New Font("Segoe UI", 10F)
        lblNameCaption.Location = New Point(46, 107)
        lblNameCaption.Name = "lblNameCaption"
        lblNameCaption.Size = New Size(114, 31)
        lblNameCaption.TabIndex = 1
        lblNameCaption.Text = "Name:"
        ' 
        ' lblFacultyName
        ' 
        lblFacultyName.Font = New Font("Segoe UI Semibold", 10F)
        lblFacultyName.Location = New Point(183, 107)
        lblFacultyName.Name = "lblFacultyName"
        lblFacultyName.Size = New Size(343, 29)
        lblFacultyName.TabIndex = 2
        ' 
        ' lblPositionCaption
        ' 
        lblPositionCaption.Font = New Font("Segoe UI", 10F)
        lblPositionCaption.Location = New Point(46, 160)
        lblPositionCaption.Name = "lblPositionCaption"
        lblPositionCaption.Size = New Size(114, 31)
        lblPositionCaption.TabIndex = 3
        lblPositionCaption.Text = "Position Title:"
        ' 
        ' lblFacultyPosition
        ' 
        lblFacultyPosition.Font = New Font("Segoe UI Semibold", 10F)
        lblFacultyPosition.Location = New Point(183, 160)
        lblFacultyPosition.Name = "lblFacultyPosition"
        lblFacultyPosition.Size = New Size(343, 29)
        lblFacultyPosition.TabIndex = 4
        ' 
        ' lblEmployeeNoCaption
        ' 
        lblEmployeeNoCaption.Font = New Font("Segoe UI", 10F)
        lblEmployeeNoCaption.Location = New Point(46, 213)
        lblEmployeeNoCaption.Name = "lblEmployeeNoCaption"
        lblEmployeeNoCaption.Size = New Size(114, 31)
        lblEmployeeNoCaption.TabIndex = 5
        lblEmployeeNoCaption.Text = "Employee No:"
        ' 
        ' lblEmployeeNumber
        ' 
        lblEmployeeNumber.Font = New Font("Segoe UI Semibold", 10F)
        lblEmployeeNumber.Location = New Point(183, 213)
        lblEmployeeNumber.Name = "lblEmployeeNumber"
        lblEmployeeNumber.Size = New Size(343, 29)
        lblEmployeeNumber.TabIndex = 6
        ' 
        ' lblDepartmentCaption
        ' 
        lblDepartmentCaption.Font = New Font("Segoe UI", 10F)
        lblDepartmentCaption.Location = New Point(46, 267)
        lblDepartmentCaption.Name = "lblDepartmentCaption"
        lblDepartmentCaption.Size = New Size(114, 31)
        lblDepartmentCaption.TabIndex = 7
        lblDepartmentCaption.Text = "Department:"
        ' 
        ' lblDepartment
        ' 
        lblDepartment.Font = New Font("Segoe UI Semibold", 10F)
        lblDepartment.Location = New Point(183, 267)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(343, 29)
        lblDepartment.TabIndex = 8
        ' 
        ' lblEditableHeader
        ' 
        lblEditableHeader.Font = New Font("Segoe UI Semibold", 12F)
        lblEditableHeader.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblEditableHeader.Location = New Point(46, 347)
        lblEditableHeader.Name = "lblEditableHeader"
        lblEditableHeader.Size = New Size(114, 31)
        lblEditableHeader.TabIndex = 9
        lblEditableHeader.Text = "Editable Contact Information"
        ' 
        ' lblEmailCaption
        ' 
        lblEmailCaption.Font = New Font("Segoe UI", 10F)
        lblEmailCaption.Location = New Point(46, 413)
        lblEmailCaption.Name = "lblEmailCaption"
        lblEmailCaption.Size = New Size(114, 31)
        lblEmailCaption.TabIndex = 10
        lblEmailCaption.Text = "Email:"
        ' 
        ' txtFacultyEmail
        ' 
        txtFacultyEmail.Font = New Font("Segoe UI", 10F)
        txtFacultyEmail.Location = New Point(183, 408)
        txtFacultyEmail.Margin = New Padding(3, 4, 3, 4)
        txtFacultyEmail.Name = "txtFacultyEmail"
        txtFacultyEmail.ReadOnly = True
        txtFacultyEmail.Size = New Size(399, 30)
        txtFacultyEmail.TabIndex = 11
        ' 
        ' lblContactCaption
        ' 
        lblContactCaption.Font = New Font("Segoe UI", 10F)
        lblContactCaption.Location = New Point(46, 467)
        lblContactCaption.Name = "lblContactCaption"
        lblContactCaption.Size = New Size(114, 31)
        lblContactCaption.TabIndex = 12
        lblContactCaption.Text = "Contact No:"
        ' 
        ' txtFacultyContact
        ' 
        txtFacultyContact.Font = New Font("Segoe UI", 10F)
        txtFacultyContact.Location = New Point(183, 461)
        txtFacultyContact.Margin = New Padding(3, 4, 3, 4)
        txtFacultyContact.Name = "txtFacultyContact"
        txtFacultyContact.ReadOnly = True
        txtFacultyContact.Size = New Size(399, 30)
        txtFacultyContact.TabIndex = 13
        ' 
        ' btnEditFaculty
        ' 
        btnEditFaculty.BackColor = Color.FromArgb(CByte(255), CByte(235), CByte(59))
        btnEditFaculty.FlatAppearance.BorderSize = 0
        btnEditFaculty.FlatStyle = FlatStyle.Flat
        btnEditFaculty.Location = New Point(183, 533)
        btnEditFaculty.Margin = New Padding(3, 4, 3, 4)
        btnEditFaculty.Name = "btnEditFaculty"
        btnEditFaculty.Size = New Size(114, 43)
        btnEditFaculty.TabIndex = 14
        btnEditFaculty.Text = "Edit"
        btnEditFaculty.UseVisualStyleBackColor = False
        ' 
        ' btnSaveFaculty
        ' 
        btnSaveFaculty.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnSaveFaculty.Enabled = False
        btnSaveFaculty.FlatAppearance.BorderSize = 0
        btnSaveFaculty.FlatStyle = FlatStyle.Flat
        btnSaveFaculty.ForeColor = Color.White
        btnSaveFaculty.Location = New Point(320, 533)
        btnSaveFaculty.Margin = New Padding(3, 4, 3, 4)
        btnSaveFaculty.Name = "btnSaveFaculty"
        btnSaveFaculty.Size = New Size(114, 43)
        btnSaveFaculty.TabIndex = 15
        btnSaveFaculty.Text = "Save"
        btnSaveFaculty.UseVisualStyleBackColor = False
        ' 
        ' frmFacultyDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1371, 933)
        Controls.Add(pnlContent)
        Controls.Add(pnlLeft)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmFacultyDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Faculty Dashboard | OJT Management"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlLeft.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlDashboardHome.ResumeLayout(False)
        pnlDashboardHome.PerformLayout()
        CType(dgvLatestActivity, ComponentModel.ISupportInitialize).EndInit()
        flpCards.ResumeLayout(False)
        pnlCardTotalStudents.ResumeLayout(False)
        pnlCardTotalStudents.PerformLayout()
        pnlCardActiveInternships.ResumeLayout(False)
        pnlCardActiveInternships.PerformLayout()
        pnlCardCompanies.ResumeLayout(False)
        pnlCardPendingVisitLogs.ResumeLayout(False)
        pnlCardPendingVisitLogs.PerformLayout()
        pnlManageStudents.ResumeLayout(False)
        pnlManageStudents.PerformLayout()
        CType(dgvStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlInternshipAssignment.ResumeLayout(False)
        pnlInternshipAssignment.PerformLayout()
        grpWorkScheduleBorder.ResumeLayout(False)
        grpWorkScheduleBorder.PerformLayout()
        grpCompanyBorder.ResumeLayout(False)
        grpCompanyBorder.PerformLayout()
        grpStudentBorder.ResumeLayout(False)
        grpStudentBorder.PerformLayout()
        pnlVisitLogs.ResumeLayout(False)
        pnlVisitLogs.PerformLayout()
        grpVLForm.ResumeLayout(False)
        grpVLForm.PerformLayout()
        CType(dgvVisitLogs, ComponentModel.ISupportInitialize).EndInit()
        pnlGrading.ResumeLayout(False)
        pnlGrading.PerformLayout()
        grpGradeForm.ResumeLayout(False)
        grpGradeForm.PerformLayout()
        grpGradeStudentInfo.ResumeLayout(False)
        grpGradeStudentInfo.PerformLayout()
        pnlCompanies.ResumeLayout(False)
        pnlCompanies.PerformLayout()
        CType(dgvCompanies, ComponentModel.ISupportInitialize).EndInit()
        pnlCompanyContacts.ResumeLayout(False)
        pnlCompanyContacts.PerformLayout()
        CType(dgvContacts, ComponentModel.ISupportInitialize).EndInit()
        pnlFacultyProfile.ResumeLayout(False)
        pnlFacultyProfile.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents btnDashboardHome As Button
    Friend WithEvents btnManageStudents As Button
    Friend WithEvents btnInternshipAssignment As Button
    Friend WithEvents btnVisitLogs As Button
    Friend WithEvents btnGrading As Button
    Friend WithEvents btnCompanies As Button
    Friend WithEvents btnCompanyContacts As Button
    Friend WithEvents btnFacultyProfile As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlDashboardHome As Panel
    Friend WithEvents pnlManageStudents As Panel
    Friend WithEvents pnlInternshipAssignment As Panel
    Friend WithEvents pnlVisitLogs As Panel
    Friend WithEvents pnlGrading As Panel
    Friend WithEvents pnlCompanies As Panel
    Friend WithEvents pnlCompanyContacts As Panel
    Friend WithEvents pnlFacultyProfile As Panel
    Friend WithEvents lblDashboardTitle As Label
    Friend WithEvents flpCards As FlowLayoutPanel
    Friend WithEvents pnlCardTotalStudents As Panel
    Friend WithEvents lblTotalStudentsValue As Label
    Friend WithEvents lblTotalStudentsTitle As Label
    Friend WithEvents pnlCardActiveInternships As Panel
    Friend WithEvents lblActiveInternshipsValue As Label
    Friend WithEvents lblActiveInternshipsTitle As Label
    Friend WithEvents pnlCardCompanies As Panel
    Friend WithEvents lblCompaniesValue As Label
    Friend WithEvents lblCompaniesTitle As Label
    Friend WithEvents pnlCardPendingVisitLogs As Panel
    Friend WithEvents lblPendingVisitLogsValue As Label
    Friend WithEvents lblPendingVisitLogsTitle As Label
    Friend WithEvents lblLatestActivityTitle As Label
    Friend WithEvents dgvLatestActivity As DataGridView
    Friend WithEvents lblManageStudentsTitle As Label
    Friend WithEvents lblSearchStudent As Label
    Friend WithEvents txtSearchStudent As TextBox
    Friend WithEvents btnSearchStudent As Button
    Friend WithEvents dgvStudents As DataGridView

    ' Internship Assignment controls
    Friend WithEvents lblInternshipTitle As Label
    Friend WithEvents lblSearchStudentIA As Label
    Friend WithEvents txtSearchStudentIA As TextBox
    Friend WithEvents btnSearchStudentIA As Button
    Friend WithEvents grpStudentBorder As Panel
    Friend WithEvents lblStudentInfoTitle As Label
    Friend WithEvents lblStudentNoIA As Label
    Friend WithEvents lblStudentNoValueIA As Label
    Friend WithEvents lblStudentNameIA As Label
    Friend WithEvents lblStudentNameValueIA As Label
    Friend WithEvents lblCourseIA As Label
    Friend WithEvents lblCourseValueIA As Label
    Friend WithEvents lblRequiredHours As Label
    Friend WithEvents lblRequiredHoursValue As Label
    Friend WithEvents lblCurrentInternshipStatus As Label
    Friend WithEvents lblCurrentInternshipStatusValue As Label
    Friend WithEvents grpCompanyBorder As Panel
    Friend WithEvents lblCompanySectionTitle As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents cboCompany As ComboBox
    Friend WithEvents lblSupervisor As Label
    Friend WithEvents cboSupervisor As ComboBox
    Friend WithEvents lblEvaluator As Label
    Friend WithEvents cboEvaluator As ComboBox
    Friend WithEvents grpWorkScheduleBorder As Panel
    Friend WithEvents lblWorkScheduleTitle As Label
    Friend WithEvents lblWorkDays As Label
    Friend WithEvents txtWorkDays As TextBox
    Friend WithEvents lblStartDate As Label
    Friend WithEvents dtpStartDate As DateTimePicker
    Friend WithEvents lblEndDate As Label
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents lblStartTime As Label
    Friend WithEvents dtpStartTime As DateTimePicker
    Friend WithEvents lblEndTime As Label
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents btnAssignInternship As Button
    Friend WithEvents btnClearInternship As Button
    Friend WithEvents btnRemoveInternship As Button
    ' Visit Logs controls
    Friend WithEvents lblVisitLogsTitle As Label
    Friend WithEvents lblVLSelectInternship As Label
    Friend WithEvents cboVLInternship As ComboBox
    Friend WithEvents dgvVisitLogs As DataGridView
    Friend WithEvents grpVLForm As Panel
    Friend WithEvents lblVLFormTitle As Label
    Friend WithEvents lblVLVisitType As Label
    Friend WithEvents cboVLVisitType As ComboBox
    Friend WithEvents lblVLVisitDate As Label
    Friend WithEvents dtpVLVisitDate As DateTimePicker
    Friend WithEvents lblVLScore As Label
    Friend WithEvents txtVLScore As TextBox
    Friend WithEvents lblVLMaxScore As Label
    Friend WithEvents txtVLMaxScore As TextBox
    Friend WithEvents lblVLNextVisitDate As Label
    Friend WithEvents dtpVLNextVisitDate As DateTimePicker
    Friend WithEvents lblVLRemarks As Label
    Friend WithEvents txtVLRemarks As TextBox
    Friend WithEvents lblVLAttachment As Label
    Friend WithEvents txtVLAttachment As TextBox
    Friend WithEvents btnVLBrowse As Button
    Friend WithEvents btnVLSave As Button
    Friend WithEvents btnVLCancel As Button
    ' Grading panel controls
    Friend WithEvents lblGradingTitle As Label
    Friend WithEvents lblGradeSelectStudent As Label
    Friend WithEvents cboGradeStudent As ComboBox
    Friend WithEvents grpGradeStudentInfo As Panel
    Friend WithEvents lblGradeStudentInfoTitle As Label
    Friend WithEvents lblGradeStudentNoLabel As Label
    Friend WithEvents lblGradeStudentNoValue As Label
    Friend WithEvents lblGradeNameLabel As Label
    Friend WithEvents lblGradeNameValue As Label
    Friend WithEvents lblGradeCourseLabel As Label
    Friend WithEvents lblGradeCourseValue As Label
    Friend WithEvents lblGradeRequiredHoursLabel As Label
    Friend WithEvents lblGradeRequiredHoursValue As Label
    Friend WithEvents lblGradeCompletedHoursLabel As Label
    Friend WithEvents lblGradeCompletedHoursValue As Label
    Friend WithEvents lblGradeStatusLabel As Label
    Friend WithEvents lblGradeStatusValue As Label
    Friend WithEvents grpGradeForm As Panel
    Friend WithEvents lblGradeFormTitle As Label
    Friend WithEvents lblFinalGradeLabel As Label
    Friend WithEvents txtFinalGrade As TextBox
    Friend WithEvents lblGradeHint As Label
    Friend WithEvents btnSaveGrade As Button
    Friend WithEvents btnClearGrade As Button
    ' Companies panel controls

    Friend WithEvents lblSearchCompany As Label
    Friend WithEvents txtSearchCompany As TextBox
    Friend WithEvents btnSearchCompany As Button
    Friend WithEvents btnAddCompany As Button
    Friend WithEvents dgvCompanies As DataGridView
    Friend WithEvents lblCompanyContactsTitle As Label
    Friend WithEvents lblContactCompany As Label
    Friend WithEvents cboContactCompany As ComboBox
    Friend WithEvents btnAddContact As Button
    Friend WithEvents dgvContacts As DataGridView
    Friend WithEvents lblProfileTitle As Label
    Friend WithEvents lblFacultyName As Label
    Friend WithEvents lblFacultyPosition As Label
    Friend WithEvents lblEmployeeNumber As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents txtFacultyEmail As TextBox
    Friend WithEvents txtFacultyContact As TextBox
    Friend WithEvents btnEditFaculty As Button
    Friend WithEvents btnSaveFaculty As Button
    Friend WithEvents lblNameCaption As Label
    Friend WithEvents lblPositionCaption As Label
    Friend WithEvents lblEmployeeNoCaption As Label
    Friend WithEvents lblDepartmentCaption As Label
    Friend WithEvents lblEditableHeader As Label
    Friend WithEvents lblEmailCaption As Label
    Friend WithEvents lblContactCaption As Label

End Class
