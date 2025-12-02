<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProfessorDashboard
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblUserName = New Label()
        lblHeaderTitle = New Label()
        lblAppName = New Label()
        pnlSidebar = New Panel()
        btnLogout = New Button()
        btnProfile = New Button()
        btnCompanyContacts = New Button()
        btnCompanies = New Button()
        btnGrading = New Button()
        btnVisitLogs = New Button()
        btnInternship = New Button()
        btnStudents = New Button()
        btnHome = New Button()
        pnlContent = New Panel()
        pnlInternshipAssignment = New Panel()
        cboIAStatus = New ComboBox()
        lblIAStatusFilter = New Label()
        btnIADrop = New Button()
        btnIACancelEdit = New Button()
        btnIAEdit = New Button()
        btnIAClear = New Button()
        btnIAAssign = New Button()
        dtpIAEndTime = New DateTimePicker()
        dtpIAStartTime = New DateTimePicker()
        txtIAWorkDays = New TextBox()
        LabelIAEndTime = New Label()
        LabelIAStartTime = New Label()
        LabelIAWorkDays = New Label()
        lblIAFacultyEvaluator = New Label()
        LabelIAFacultyEvaluator = New Label()
        cboIASupervisor = New ComboBox()
        LabelIASupervisor = New Label()
        cboIACompany = New ComboBox()
        LabelIACompany = New Label()
        lblIAStatus = New Label()
        lblIARequiredHours = New Label()
        lblIASection = New Label()
        lblIACourse = New Label()
        lblIAStudentName = New Label()
        lblIAStudentNo = New Label()
        LabelIAStatus = New Label()
        LabelIARequiredHours = New Label()
        LabelIASection = New Label()
        LabelIACourse = New Label()
        LabelIAStudentName = New Label()
        LabelIAStudentNo = New Label()
        LabelIAStudentSelected = New Label()
        btnIASearch = New Button()
        txtIASearch = New TextBox()
        LabelIASearch = New Label()
        cboIAStudent = New ComboBox()
        LabelIAStudentFilter = New Label()
        cboIASection = New ComboBox()
        LabelIASectionFilter = New Label()
        lblIAFilters = New Label()
        lblInternshipTitle = New Label()
        pnlStudents = New Panel()
        dgvMyStudentsHistory = New DataGridView()
        pnlStudentEditStatus = New Panel()
        btnStudentEditCancel = New Button()
        btnStudentEditSave = New Button()
        lblStudentEditStatus = New Label()
        lblStudentName = New Label()
        lblStudentEditTitle = New Label()
        cboStudentEditStatus = New ComboBox()
        lblStudentNameTitle = New Label()
        btnStudentEdit = New Button()
        dgvMyStudents = New DataGridView()
        btnStudentSearch = New Button()
        txtStudentSearch = New TextBox()
        LabelStudentSearch = New Label()
        cboStudentStatus = New ComboBox()
        LabelStudentStatusFilter = New Label()
        cboStudentSection = New ComboBox()
        LabelStudentSectionFilter = New Label()
        lblStudentFilters = New Label()
        lblStudentsTitle = New Label()
        pnlHome = New Panel()
        dgvRecentActivity = New DataGridView()
        lblRecentActivity = New Label()
        pnlCardCompletedInternships = New Panel()
        lblCardCompletedInternshipsValue = New Label()
        lblCardCompletedInternshipsTitle = New Label()
        pnlCardPendingVisitLogs = New Panel()
        lblCardPendingVisitLogsValue = New Label()
        lblCardPendingVisitLogsTitle = New Label()
        pnlCardActiveInternships = New Panel()
        lblCardActiveInternshipsValue = New Label()
        lblCardActiveInternshipsTitle = New Label()
        pnlCardMyStudents = New Panel()
        lblCardMyStudentsValue = New Label()
        lblCardMyStudentsTitle = New Label()
        lblHomeTitle = New Label()
        pnlProfile = New Panel()
        btnPFCancel = New Button()
        btnPFSave = New Button()
        btnPFEdit = New Button()
        txtPFConfirmPassword = New TextBox()
        txtPFPassword = New TextBox()
        txtPFContact = New TextBox()
        txtPFEmail = New TextBox()
        lblPFSections = New Label()
        lblPFDepartment = New Label()
        lblPFName = New Label()
        lblPFFacultyNumber = New Label()
        LabelPFSectionsLabel = New Label()
        LabelPFDepartmentLabel = New Label()
        LabelPFNameLabel = New Label()
        LabelPFFacultyNumberLabel = New Label()
        LabelPFConfirmPassword = New Label()
        LabelPFPassword = New Label()
        LabelPFContact = New Label()
        LabelPFEmail = New Label()
        lblProfileTitle = New Label()
        pnlCompanyContacts = New Panel()
        btnCCAddContact = New Button()
        cboCCCompany = New ComboBox()
        LabelCCCompany = New Label()
        dgvCompanyContacts = New DataGridView()
        lblCompanyContactsTitle = New Label()
        pnlCompanies = New Panel()
        btnCompanyAdd = New Button()
        btnCompanySearch = New Button()
        txtCompanySearch = New TextBox()
        LabelCompanySearch = New Label()
        dgvCompanies = New DataGridView()
        lblCompaniesTitle = New Label()
        pnlCompanyForm = New Panel()
        lblCompanyFormTitle = New Label()
        lblCompanyNameLabel = New Label()
        lblCompanyAddressLabel = New Label()
        lblCompanyCityLabel = New Label()
        lblCompanyIndustryLabel = New Label()
        lblCompanyEmailLabel = New Label()
        lblCompanyContactLabel = New Label()
        lblCompanyWebsiteLabel = New Label()
        lblCompanyAccStatusLabel = New Label()
        lblCompanyAccDateLabel = New Label()
        txtCompanyName = New TextBox()
        txtCompanyAddress = New TextBox()
        cboCompanyCity = New ComboBox()
        txtCompanyIndustry = New TextBox()
        txtCompanyEmail = New TextBox()
        txtCompanyContact = New TextBox()
        txtCompanyWebsite = New TextBox()
        cboCompanyAccreditationStatus = New ComboBox()
        dtpCompanyAccreditationDate = New DateTimePicker()
        chkCompanyIsActive = New CheckBox()
        btnCompanySave = New Button()
        btnCompanyCancel = New Button()
        pnlGrading = New Panel()
        btnGRCancel = New Button()
        btnGREdit = New Button()
        lblGRReportTitle = New Label()
        LabelGRSelectStudent = New Label()
        cboGRStudent = New ComboBox()
        grpGROverview = New GroupBox()
        lblGROverviewTitle = New Label()
        LabelGRStudentName = New Label()
        lblGRStudentName = New Label()
        LabelGRStudentNumber = New Label()
        lblGRStudentNumber = New Label()
        LabelGRCourseSection = New Label()
        lblGRCourseSection = New Label()
        LabelGRCompany = New Label()
        lblGRCompany = New Label()
        LabelGRSupervisor = New Label()
        lblGRSupervisor = New Label()
        LabelGRRequiredHours = New Label()
        lblGRRequiredHours = New Label()
        LabelGRCompletedHours = New Label()
        lblGRCompletedHours = New Label()
        LabelGRStatus = New Label()
        lblGRInternshipStatus = New Label()
        grpGRSupervisor = New GroupBox()
        lblGRSupervisorPanelTitle = New Label()
        LabelGRSupervisorScore = New Label()
        lblGRSupervisorScore = New Label()
        grpGRFacultyEval = New GroupBox()
        lblGRFacultyEvalTitle = New Label()
        LabelGRF_Tech = New Label()
        cboGRF_Tech = New ComboBox()
        LabelGRF_Professionalism = New Label()
        cboGRF_Professionalism = New ComboBox()
        LabelGRF_Communication = New Label()
        cboGRF_Communication = New ComboBox()
        LabelGRF_Attendance = New Label()
        cboGRF_Attendance = New ComboBox()
        LabelGRF_OutputQuality = New Label()
        cboGRF_OutputQuality = New ComboBox()
        LabelGRF_FinalInterview = New Label()
        cboGRF_FinalInterview = New ComboBox()
        LabelGRFacultyTotal = New Label()
        lblGRFacultyTotal = New Label()
        grpGRFinal = New GroupBox()
        lblGRFinalCompTitle = New Label()
        LabelGRFGSupervisor = New Label()
        lblGRFGSupervisor = New Label()
        LabelGRFGFaculty = New Label()
        lblGRFGFaculty = New Label()
        LabelGRFinalGrade = New Label()
        lblGRFinalGradeAuto = New Label()
        LabelGREvalReport = New Label()
        txtGREvalFile = New TextBox()
        btnGRBrowse = New Button()
        btnGRSave = New Button()
        btnGRClear = New Button()
        btnGRGenerateReport = New Button()
        pnlVisitLogs = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        lblVisitLogsTitle = New Label()
        LabelVLSelectInternship = New Label()
        cboVLInternship = New ComboBox()
        LabelVLStudentName = New Label()
        lblVLStudentName = New Label()
        LabelVLStudentNumber = New Label()
        lblVLStudentNumber = New Label()
        LabelVLCourseSection = New Label()
        lblVLCourseSection = New Label()
        LabelVLCompany = New Label()
        lblVLCompany = New Label()
        LabelVLSupervisor = New Label()
        lblVLSupervisor = New Label()
        LabelVLVisitDate = New Label()
        dtpVLDate = New DateTimePicker()
        LabelVLVisitType = New Label()
        cboVLVisitType = New ComboBox()
        LabelVLTech = New Label()
        cboVLTech = New ComboBox()
        LabelVLComm = New Label()
        cboVLComm = New ComboBox()
        LabelVLBehavior = New Label()
        cboVLBehavior = New ComboBox()
        LabelVLAttendance = New Label()
        cboVLAttendance = New ComboBox()
        LabelVLQuality = New Label()
        cboVLQuality = New ComboBox()
        LabelVLOutputOverall = New Label()
        lblVLOverallScore = New Label()
        LabelVLHoursRendered = New Label()
        txtVLHoursRendered = New TextBox()
        LabelVLRemarks = New Label()
        txtVLRemarks = New TextBox()
        LabelVLAttachment = New Label()
        txtVLAttachment = New TextBox()
        btnVLBrowse = New Button()
        btnVLSave = New Button()
        btnVLGenerateVisitLog = New Button()
        btnVLCancel = New Button()
        dgvVisitLogs = New DataGridView()
        lblVLStatus = New Label()
        cboVLStatusFilter = New ComboBox()
        lbl1 = New Label()
        lbl2 = New Label()
        lbl3 = New Label()
        lbl4 = New Label()
        lbl5 = New Label()
        lbl6 = New Label()
        lblT = New Label()
        lblP = New Label()
        lblA = New Label()
        lblC = New Label()
        lblQ = New Label()
        lblFI = New Label()
        lblFT = New Label()
        lblFG = New Label()
        lblGRWarning = New Label()
        txtVLEditID = New TextBox()
        txtVLHoursAdded = New TextBox()
        LabelVLHoursAdded = New Label()
        txtVLMaxScore = New TextBox()
        LabelVLMaxScore = New Label()
        txtVLScore = New TextBox()
        LabelVLScore = New Label()
        lblCN = New Label()
        lblAddr = New Label()
        lblCity = New Label()
        lblInd = New Label()
        lblEm = New Label()
        lblContact = New Label()
        lblWeb = New Label()
        lblAccStat = New Label()
        lblAccDate = New Label()
        VisitID = New DataGridViewTextBoxColumn()
        VisitDate = New DataGridViewTextBoxColumn()
        VisitType = New DataGridViewTextBoxColumn()
        HoursAdded = New DataGridViewTextBoxColumn()
        Score = New DataGridViewTextBoxColumn()
        MaxScore = New DataGridViewTextBoxColumn()
        Remarks = New DataGridViewTextBoxColumn()
        AttachmentPath = New DataGridViewTextBoxColumn()
        colDownload = New DataGridViewButtonColumn()
        colEdit = New DataGridViewButtonColumn()
        colDelete = New DataGridViewButtonColumn()
        pnlHeader.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlInternshipAssignment.SuspendLayout()
        pnlStudents.SuspendLayout()
        CType(dgvMyStudentsHistory, ComponentModel.ISupportInitialize).BeginInit()
        pnlStudentEditStatus.SuspendLayout()
        CType(dgvMyStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlHome.SuspendLayout()
        CType(dgvRecentActivity, ComponentModel.ISupportInitialize).BeginInit()
        pnlCardCompletedInternships.SuspendLayout()
        pnlCardPendingVisitLogs.SuspendLayout()
        pnlCardActiveInternships.SuspendLayout()
        pnlCardMyStudents.SuspendLayout()
        pnlProfile.SuspendLayout()
        pnlCompanyContacts.SuspendLayout()
        CType(dgvCompanyContacts, ComponentModel.ISupportInitialize).BeginInit()
        pnlCompanies.SuspendLayout()
        CType(dgvCompanies, ComponentModel.ISupportInitialize).BeginInit()
        pnlCompanyForm.SuspendLayout()
        pnlGrading.SuspendLayout()
        grpGROverview.SuspendLayout()
        grpGRSupervisor.SuspendLayout()
        grpGRFacultyEval.SuspendLayout()
        grpGRFinal.SuspendLayout()
        pnlVisitLogs.SuspendLayout()
        CType(dgvVisitLogs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(27), CByte(94), CByte(32))
        pnlHeader.Controls.Add(lblUserName)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblAppName)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1551, 100)
        pnlHeader.TabIndex = 0
        ' 
        ' lblUserName
        ' 
        lblUserName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Segoe UI", 10F)
        lblUserName.ForeColor = Color.White
        lblUserName.Location = New Point(1271, 38)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(126, 23)
        lblUserName.TabIndex = 2
        lblUserName.Text = "ProfessorName"
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.Anchor = AnchorStyles.Top
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(CByte(255), CByte(241), CByte(118))
        lblHeaderTitle.Location = New Point(655, 35)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(245, 28)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "PROFESSOR DASHBOARD"
        ' 
        ' lblAppName
        ' 
        lblAppName.AutoSize = True
        lblAppName.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblAppName.ForeColor = Color.White
        lblAppName.Location = New Point(24, 30)
        lblAppName.Name = "lblAppName"
        lblAppName.Size = New Size(445, 32)
        lblAppName.TabIndex = 0
        lblAppName.Text = "OJT MONITORING AND MANAGEMENT"
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnProfile)
        pnlSidebar.Controls.Add(btnCompanyContacts)
        pnlSidebar.Controls.Add(btnCompanies)
        pnlSidebar.Controls.Add(btnGrading)
        pnlSidebar.Controls.Add(btnVisitLogs)
        pnlSidebar.Controls.Add(btnInternship)
        pnlSidebar.Controls.Add(btnStudents)
        pnlSidebar.Controls.Add(btnHome)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 100)
        pnlSidebar.Margin = New Padding(3, 4, 3, 4)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(230, 1002)
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
        btnLogout.Location = New Point(0, 927)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(20, 0, 0, 0)
        btnLogout.Size = New Size(230, 56)
        btnLogout.TabIndex = 8
        btnLogout.Text = "  Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnProfile
        ' 
        btnProfile.FlatAppearance.BorderSize = 0
        btnProfile.FlatStyle = FlatStyle.Flat
        btnProfile.Font = New Font("Segoe UI", 10F)
        btnProfile.ForeColor = Color.White
        btnProfile.Location = New Point(0, 375)
        btnProfile.Margin = New Padding(3, 4, 3, 4)
        btnProfile.Name = "btnProfile"
        btnProfile.Padding = New Padding(20, 0, 0, 0)
        btnProfile.Size = New Size(230, 50)
        btnProfile.TabIndex = 7
        btnProfile.Text = "  My Profile"
        btnProfile.TextAlign = ContentAlignment.MiddleLeft
        btnProfile.UseVisualStyleBackColor = True
        ' 
        ' btnCompanyContacts
        ' 
        btnCompanyContacts.FlatAppearance.BorderSize = 0
        btnCompanyContacts.FlatStyle = FlatStyle.Flat
        btnCompanyContacts.Font = New Font("Segoe UI", 10F)
        btnCompanyContacts.ForeColor = Color.White
        btnCompanyContacts.Location = New Point(0, 325)
        btnCompanyContacts.Margin = New Padding(3, 4, 3, 4)
        btnCompanyContacts.Name = "btnCompanyContacts"
        btnCompanyContacts.Padding = New Padding(20, 0, 0, 0)
        btnCompanyContacts.Size = New Size(230, 50)
        btnCompanyContacts.TabIndex = 6
        btnCompanyContacts.Text = "  Company Contacts"
        btnCompanyContacts.TextAlign = ContentAlignment.MiddleLeft
        btnCompanyContacts.UseVisualStyleBackColor = True
        ' 
        ' btnCompanies
        ' 
        btnCompanies.FlatAppearance.BorderSize = 0
        btnCompanies.FlatStyle = FlatStyle.Flat
        btnCompanies.Font = New Font("Segoe UI", 10F)
        btnCompanies.ForeColor = Color.White
        btnCompanies.Location = New Point(0, 275)
        btnCompanies.Margin = New Padding(3, 4, 3, 4)
        btnCompanies.Name = "btnCompanies"
        btnCompanies.Padding = New Padding(20, 0, 0, 0)
        btnCompanies.Size = New Size(230, 50)
        btnCompanies.TabIndex = 5
        btnCompanies.Text = "  Companies"
        btnCompanies.TextAlign = ContentAlignment.MiddleLeft
        btnCompanies.UseVisualStyleBackColor = True
        ' 
        ' btnGrading
        ' 
        btnGrading.FlatAppearance.BorderSize = 0
        btnGrading.FlatStyle = FlatStyle.Flat
        btnGrading.Font = New Font("Segoe UI", 10F)
        btnGrading.ForeColor = Color.White
        btnGrading.Location = New Point(0, 225)
        btnGrading.Margin = New Padding(3, 4, 3, 4)
        btnGrading.Name = "btnGrading"
        btnGrading.Padding = New Padding(20, 0, 0, 0)
        btnGrading.Size = New Size(230, 50)
        btnGrading.TabIndex = 4
        btnGrading.Text = "  Grading"
        btnGrading.TextAlign = ContentAlignment.MiddleLeft
        btnGrading.UseVisualStyleBackColor = True
        ' 
        ' btnVisitLogs
        ' 
        btnVisitLogs.FlatAppearance.BorderSize = 0
        btnVisitLogs.FlatStyle = FlatStyle.Flat
        btnVisitLogs.Font = New Font("Segoe UI", 10F)
        btnVisitLogs.ForeColor = Color.White
        btnVisitLogs.Location = New Point(0, 175)
        btnVisitLogs.Margin = New Padding(3, 4, 3, 4)
        btnVisitLogs.Name = "btnVisitLogs"
        btnVisitLogs.Padding = New Padding(20, 0, 0, 0)
        btnVisitLogs.Size = New Size(230, 50)
        btnVisitLogs.TabIndex = 3
        btnVisitLogs.Text = "  Visit Logs"
        btnVisitLogs.TextAlign = ContentAlignment.MiddleLeft
        btnVisitLogs.UseVisualStyleBackColor = True
        ' 
        ' btnInternship
        ' 
        btnInternship.FlatAppearance.BorderSize = 0
        btnInternship.FlatStyle = FlatStyle.Flat
        btnInternship.Font = New Font("Segoe UI", 10F)
        btnInternship.ForeColor = Color.White
        btnInternship.Location = New Point(0, 125)
        btnInternship.Margin = New Padding(3, 4, 3, 4)
        btnInternship.Name = "btnInternship"
        btnInternship.Padding = New Padding(20, 0, 0, 0)
        btnInternship.Size = New Size(230, 50)
        btnInternship.TabIndex = 2
        btnInternship.Text = "  Internship Assignment"
        btnInternship.TextAlign = ContentAlignment.MiddleLeft
        btnInternship.UseVisualStyleBackColor = True
        ' 
        ' btnStudents
        ' 
        btnStudents.FlatAppearance.BorderSize = 0
        btnStudents.FlatStyle = FlatStyle.Flat
        btnStudents.Font = New Font("Segoe UI", 10F)
        btnStudents.ForeColor = Color.White
        btnStudents.Location = New Point(0, 75)
        btnStudents.Margin = New Padding(3, 4, 3, 4)
        btnStudents.Name = "btnStudents"
        btnStudents.Padding = New Padding(20, 0, 0, 0)
        btnStudents.Size = New Size(230, 50)
        btnStudents.TabIndex = 1
        btnStudents.Text = "  Students (My Sections)"
        btnStudents.TextAlign = ContentAlignment.MiddleLeft
        btnStudents.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Segoe UI", 10F)
        btnHome.ForeColor = Color.White
        btnHome.Location = New Point(0, 25)
        btnHome.Margin = New Padding(3, 4, 3, 4)
        btnHome.Name = "btnHome"
        btnHome.Padding = New Padding(20, 0, 0, 0)
        btnHome.Size = New Size(230, 50)
        btnHome.TabIndex = 0
        btnHome.Text = "  Home"
        btnHome.TextAlign = ContentAlignment.MiddleLeft
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' pnlContent
        ' 
        pnlContent.Controls.Add(pnlHome)
        pnlContent.Controls.Add(pnlProfile)
        pnlContent.Controls.Add(pnlCompanyContacts)
        pnlContent.Controls.Add(pnlCompanies)
        pnlContent.Controls.Add(pnlGrading)
        pnlContent.Controls.Add(pnlVisitLogs)
        pnlContent.Controls.Add(pnlInternshipAssignment)
        pnlContent.Controls.Add(pnlStudents)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(230, 100)
        pnlContent.Margin = New Padding(3, 4, 3, 4)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1321, 1002)
        pnlContent.TabIndex = 2
        ' 
        ' pnlInternshipAssignment
        ' 
        pnlInternshipAssignment.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        pnlInternshipAssignment.Controls.Add(cboIAStatus)
        pnlInternshipAssignment.Controls.Add(lblIAStatusFilter)
        pnlInternshipAssignment.Controls.Add(btnIADrop)
        pnlInternshipAssignment.Controls.Add(btnIACancelEdit)
        pnlInternshipAssignment.Controls.Add(btnIAEdit)
        pnlInternshipAssignment.Controls.Add(btnIAClear)
        pnlInternshipAssignment.Controls.Add(btnIAAssign)
        pnlInternshipAssignment.Controls.Add(dtpIAEndTime)
        pnlInternshipAssignment.Controls.Add(dtpIAStartTime)
        pnlInternshipAssignment.Controls.Add(txtIAWorkDays)
        pnlInternshipAssignment.Controls.Add(LabelIAEndTime)
        pnlInternshipAssignment.Controls.Add(LabelIAStartTime)
        pnlInternshipAssignment.Controls.Add(LabelIAWorkDays)
        pnlInternshipAssignment.Controls.Add(lblIAFacultyEvaluator)
        pnlInternshipAssignment.Controls.Add(LabelIAFacultyEvaluator)
        pnlInternshipAssignment.Controls.Add(cboIASupervisor)
        pnlInternshipAssignment.Controls.Add(LabelIASupervisor)
        pnlInternshipAssignment.Controls.Add(cboIACompany)
        pnlInternshipAssignment.Controls.Add(LabelIACompany)
        pnlInternshipAssignment.Controls.Add(lblIAStatus)
        pnlInternshipAssignment.Controls.Add(lblIARequiredHours)
        pnlInternshipAssignment.Controls.Add(lblIASection)
        pnlInternshipAssignment.Controls.Add(lblIACourse)
        pnlInternshipAssignment.Controls.Add(lblIAStudentName)
        pnlInternshipAssignment.Controls.Add(lblIAStudentNo)
        pnlInternshipAssignment.Controls.Add(LabelIAStatus)
        pnlInternshipAssignment.Controls.Add(LabelIARequiredHours)
        pnlInternshipAssignment.Controls.Add(LabelIASection)
        pnlInternshipAssignment.Controls.Add(LabelIACourse)
        pnlInternshipAssignment.Controls.Add(LabelIAStudentName)
        pnlInternshipAssignment.Controls.Add(LabelIAStudentNo)
        pnlInternshipAssignment.Controls.Add(LabelIAStudentSelected)
        pnlInternshipAssignment.Controls.Add(btnIASearch)
        pnlInternshipAssignment.Controls.Add(txtIASearch)
        pnlInternshipAssignment.Controls.Add(LabelIASearch)
        pnlInternshipAssignment.Controls.Add(cboIAStudent)
        pnlInternshipAssignment.Controls.Add(LabelIAStudentFilter)
        pnlInternshipAssignment.Controls.Add(cboIASection)
        pnlInternshipAssignment.Controls.Add(LabelIASectionFilter)
        pnlInternshipAssignment.Controls.Add(lblIAFilters)
        pnlInternshipAssignment.Controls.Add(lblInternshipTitle)
        pnlInternshipAssignment.Dock = DockStyle.Fill
        pnlInternshipAssignment.Location = New Point(0, 0)
        pnlInternshipAssignment.Margin = New Padding(3, 4, 3, 4)
        pnlInternshipAssignment.Name = "pnlInternshipAssignment"
        pnlInternshipAssignment.Size = New Size(1321, 1002)
        pnlInternshipAssignment.TabIndex = 2
        pnlInternshipAssignment.Visible = False
        ' 
        ' cboIAStatus
        ' 
        cboIAStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboIAStatus.Font = New Font("Segoe UI", 10F)
        cboIAStatus.FormattingEnabled = True
        cboIAStatus.Location = New Point(262, 39)
        cboIAStatus.Margin = New Padding(3, 4, 3, 4)
        cboIAStatus.Name = "cboIAStatus"
        cboIAStatus.Size = New Size(80, 31)
        cboIAStatus.TabIndex = 46
        ' 
        ' lblIAStatusFilter
        ' 
        lblIAStatusFilter.AutoSize = True
        lblIAStatusFilter.Font = New Font("Segoe UI", 10F)
        lblIAStatusFilter.Location = New Point(196, 42)
        lblIAStatusFilter.Name = "lblIAStatusFilter"
        lblIAStatusFilter.Size = New Size(60, 23)
        lblIAStatusFilter.TabIndex = 45
        lblIAStatusFilter.Text = "Status:"
        ' 
        ' btnIADrop
        ' 
        btnIADrop.BackColor = Color.Red
        btnIADrop.FlatAppearance.BorderSize = 0
        btnIADrop.FlatStyle = FlatStyle.Flat
        btnIADrop.Font = New Font("Segoe UI", 10F)
        btnIADrop.ForeColor = Color.Black
        btnIADrop.Location = New Point(380, 734)
        btnIADrop.Margin = New Padding(3, 4, 3, 4)
        btnIADrop.Name = "btnIADrop"
        btnIADrop.Size = New Size(100, 40)
        btnIADrop.TabIndex = 44
        btnIADrop.Text = "Drop"
        btnIADrop.UseVisualStyleBackColor = False
        ' 
        ' btnIACancelEdit
        ' 
        btnIACancelEdit.BackColor = Color.FromArgb(CByte(189), CByte(189), CByte(189))
        btnIACancelEdit.FlatAppearance.BorderSize = 0
        btnIACancelEdit.FlatStyle = FlatStyle.Flat
        btnIACancelEdit.Font = New Font("Segoe UI", 10F)
        btnIACancelEdit.ForeColor = Color.Black
        btnIACancelEdit.Location = New Point(592, 735)
        btnIACancelEdit.Margin = New Padding(3, 4, 3, 4)
        btnIACancelEdit.Name = "btnIACancelEdit"
        btnIACancelEdit.Size = New Size(100, 40)
        btnIACancelEdit.TabIndex = 43
        btnIACancelEdit.Text = "Cancel"
        btnIACancelEdit.UseVisualStyleBackColor = False
        ' 
        ' btnIAEdit
        ' 
        btnIAEdit.BackColor = Color.Cyan
        btnIAEdit.FlatAppearance.BorderSize = 0
        btnIAEdit.FlatStyle = FlatStyle.Flat
        btnIAEdit.Font = New Font("Segoe UI", 10F)
        btnIAEdit.ForeColor = Color.Black
        btnIAEdit.Location = New Point(25, 734)
        btnIAEdit.Margin = New Padding(3, 4, 3, 4)
        btnIAEdit.Name = "btnIAEdit"
        btnIAEdit.Size = New Size(231, 40)
        btnIAEdit.TabIndex = 42
        btnIAEdit.Text = "Edit Trainee Assignment"
        btnIAEdit.UseVisualStyleBackColor = False
        ' 
        ' btnIAClear
        ' 
        btnIAClear.BackColor = Color.FromArgb(CByte(189), CByte(189), CByte(189))
        btnIAClear.FlatAppearance.BorderSize = 0
        btnIAClear.FlatStyle = FlatStyle.Flat
        btnIAClear.Font = New Font("Segoe UI", 10F)
        btnIAClear.ForeColor = Color.Black
        btnIAClear.Location = New Point(486, 735)
        btnIAClear.Margin = New Padding(3, 4, 3, 4)
        btnIAClear.Name = "btnIAClear"
        btnIAClear.Size = New Size(100, 40)
        btnIAClear.TabIndex = 41
        btnIAClear.Text = "Clear"
        btnIAClear.UseVisualStyleBackColor = False
        ' 
        ' btnIAAssign
        ' 
        btnIAAssign.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnIAAssign.FlatAppearance.BorderSize = 0
        btnIAAssign.FlatStyle = FlatStyle.Flat
        btnIAAssign.Font = New Font("Segoe UI", 10F)
        btnIAAssign.ForeColor = Color.White
        btnIAAssign.Location = New Point(262, 734)
        btnIAAssign.Margin = New Padding(3, 4, 3, 4)
        btnIAAssign.Name = "btnIAAssign"
        btnIAAssign.Size = New Size(110, 40)
        btnIAAssign.TabIndex = 40
        btnIAAssign.Text = "Assign"
        btnIAAssign.UseVisualStyleBackColor = False
        ' 
        ' dtpIAEndTime
        ' 
        dtpIAEndTime.Font = New Font("Segoe UI", 10F)
        dtpIAEndTime.Format = DateTimePickerFormat.Time
        dtpIAEndTime.Location = New Point(179, 671)
        dtpIAEndTime.Margin = New Padding(3, 4, 3, 4)
        dtpIAEndTime.Name = "dtpIAEndTime"
        dtpIAEndTime.ShowUpDown = True
        dtpIAEndTime.Size = New Size(140, 30)
        dtpIAEndTime.TabIndex = 39
        ' 
        ' dtpIAStartTime
        ' 
        dtpIAStartTime.Font = New Font("Segoe UI", 10F)
        dtpIAStartTime.Format = DateTimePickerFormat.Time
        dtpIAStartTime.Location = New Point(179, 621)
        dtpIAStartTime.Margin = New Padding(3, 4, 3, 4)
        dtpIAStartTime.Name = "dtpIAStartTime"
        dtpIAStartTime.ShowUpDown = True
        dtpIAStartTime.Size = New Size(140, 30)
        dtpIAStartTime.TabIndex = 38
        ' 
        ' txtIAWorkDays
        ' 
        txtIAWorkDays.Font = New Font("Segoe UI", 10F)
        txtIAWorkDays.Location = New Point(179, 571)
        txtIAWorkDays.Margin = New Padding(3, 4, 3, 4)
        txtIAWorkDays.Name = "txtIAWorkDays"
        txtIAWorkDays.Size = New Size(200, 30)
        txtIAWorkDays.TabIndex = 37
        ' 
        ' LabelIAEndTime
        ' 
        LabelIAEndTime.AutoSize = True
        LabelIAEndTime.Font = New Font("Segoe UI", 10F)
        LabelIAEndTime.Location = New Point(23, 674)
        LabelIAEndTime.Name = "LabelIAEndTime"
        LabelIAEndTime.Size = New Size(85, 23)
        LabelIAEndTime.TabIndex = 36
        LabelIAEndTime.Text = "End Time:"
        ' 
        ' LabelIAStartTime
        ' 
        LabelIAStartTime.AutoSize = True
        LabelIAStartTime.Font = New Font("Segoe UI", 10F)
        LabelIAStartTime.Location = New Point(23, 624)
        LabelIAStartTime.Name = "LabelIAStartTime"
        LabelIAStartTime.Size = New Size(91, 23)
        LabelIAStartTime.TabIndex = 35
        LabelIAStartTime.Text = "Start Time:"
        ' 
        ' LabelIAWorkDays
        ' 
        LabelIAWorkDays.AutoSize = True
        LabelIAWorkDays.Font = New Font("Segoe UI", 10F)
        LabelIAWorkDays.Location = New Point(23, 574)
        LabelIAWorkDays.Name = "LabelIAWorkDays"
        LabelIAWorkDays.Size = New Size(94, 23)
        LabelIAWorkDays.TabIndex = 34
        LabelIAWorkDays.Text = "Work Days:"
        ' 
        ' lblIAFacultyEvaluator
        ' 
        lblIAFacultyEvaluator.AutoSize = True
        lblIAFacultyEvaluator.Font = New Font("Segoe UI", 10F)
        lblIAFacultyEvaluator.Location = New Point(179, 534)
        lblIAFacultyEvaluator.Name = "lblIAFacultyEvaluator"
        lblIAFacultyEvaluator.Size = New Size(0, 23)
        lblIAFacultyEvaluator.TabIndex = 33
        ' 
        ' LabelIAFacultyEvaluator
        ' 
        LabelIAFacultyEvaluator.AutoSize = True
        LabelIAFacultyEvaluator.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelIAFacultyEvaluator.Location = New Point(23, 534)
        LabelIAFacultyEvaluator.Name = "LabelIAFacultyEvaluator"
        LabelIAFacultyEvaluator.Size = New Size(152, 23)
        LabelIAFacultyEvaluator.TabIndex = 32
        LabelIAFacultyEvaluator.Text = "Faculty Evaluator:"
        ' 
        ' cboIASupervisor
        ' 
        cboIASupervisor.DropDownStyle = ComboBoxStyle.DropDownList
        cboIASupervisor.Font = New Font("Segoe UI", 10F)
        cboIASupervisor.FormattingEnabled = True
        cboIASupervisor.Location = New Point(179, 484)
        cboIASupervisor.Margin = New Padding(3, 4, 3, 4)
        cboIASupervisor.Name = "cboIASupervisor"
        cboIASupervisor.Size = New Size(260, 31)
        cboIASupervisor.TabIndex = 31
        ' 
        ' LabelIASupervisor
        ' 
        LabelIASupervisor.AutoSize = True
        LabelIASupervisor.Font = New Font("Segoe UI", 10F)
        LabelIASupervisor.Location = New Point(23, 486)
        LabelIASupervisor.Name = "LabelIASupervisor"
        LabelIASupervisor.Size = New Size(93, 23)
        LabelIASupervisor.TabIndex = 30
        LabelIASupervisor.Text = "Supervisor:"
        ' 
        ' cboIACompany
        ' 
        cboIACompany.DropDownStyle = ComboBoxStyle.DropDownList
        cboIACompany.Font = New Font("Segoe UI", 10F)
        cboIACompany.FormattingEnabled = True
        cboIACompany.Location = New Point(179, 434)
        cboIACompany.Margin = New Padding(3, 4, 3, 4)
        cboIACompany.Name = "cboIACompany"
        cboIACompany.Size = New Size(260, 31)
        cboIACompany.TabIndex = 29
        ' 
        ' LabelIACompany
        ' 
        LabelIACompany.AutoSize = True
        LabelIACompany.Font = New Font("Segoe UI", 10F)
        LabelIACompany.Location = New Point(23, 436)
        LabelIACompany.Name = "LabelIACompany"
        LabelIACompany.Size = New Size(87, 23)
        LabelIACompany.TabIndex = 28
        LabelIACompany.Text = "Company:"
        ' 
        ' lblIAStatus
        ' 
        lblIAStatus.AutoSize = True
        lblIAStatus.Font = New Font("Segoe UI", 10F)
        lblIAStatus.Location = New Point(179, 384)
        lblIAStatus.Name = "lblIAStatus"
        lblIAStatus.Size = New Size(0, 23)
        lblIAStatus.TabIndex = 27
        ' 
        ' lblIARequiredHours
        ' 
        lblIARequiredHours.AutoSize = True
        lblIARequiredHours.Font = New Font("Segoe UI", 10F)
        lblIARequiredHours.Location = New Point(179, 346)
        lblIARequiredHours.Name = "lblIARequiredHours"
        lblIARequiredHours.Size = New Size(0, 23)
        lblIARequiredHours.TabIndex = 26
        ' 
        ' lblIASection
        ' 
        lblIASection.AutoSize = True
        lblIASection.Font = New Font("Segoe UI", 10F)
        lblIASection.Location = New Point(179, 308)
        lblIASection.Name = "lblIASection"
        lblIASection.Size = New Size(0, 23)
        lblIASection.TabIndex = 25
        ' 
        ' lblIACourse
        ' 
        lblIACourse.AutoSize = True
        lblIACourse.Font = New Font("Segoe UI", 10F)
        lblIACourse.Location = New Point(179, 271)
        lblIACourse.Name = "lblIACourse"
        lblIACourse.Size = New Size(0, 23)
        lblIACourse.TabIndex = 24
        ' 
        ' lblIAStudentName
        ' 
        lblIAStudentName.AutoSize = True
        lblIAStudentName.Font = New Font("Segoe UI", 10F)
        lblIAStudentName.Location = New Point(179, 234)
        lblIAStudentName.Name = "lblIAStudentName"
        lblIAStudentName.Size = New Size(0, 23)
        lblIAStudentName.TabIndex = 23
        ' 
        ' lblIAStudentNo
        ' 
        lblIAStudentNo.AutoSize = True
        lblIAStudentNo.Font = New Font("Segoe UI", 10F)
        lblIAStudentNo.Location = New Point(179, 196)
        lblIAStudentNo.Name = "lblIAStudentNo"
        lblIAStudentNo.Size = New Size(0, 23)
        lblIAStudentNo.TabIndex = 22
        ' 
        ' LabelIAStatus
        ' 
        LabelIAStatus.AutoSize = True
        LabelIAStatus.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LabelIAStatus.Location = New Point(23, 384)
        LabelIAStatus.Name = "LabelIAStatus"
        LabelIAStatus.Size = New Size(61, 23)
        LabelIAStatus.TabIndex = 21
        LabelIAStatus.Text = "Status:"
        ' 
        ' LabelIARequiredHours
        ' 
        LabelIARequiredHours.AutoSize = True
        LabelIARequiredHours.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LabelIARequiredHours.Location = New Point(23, 346)
        LabelIARequiredHours.Name = "LabelIARequiredHours"
        LabelIARequiredHours.Size = New Size(134, 23)
        LabelIARequiredHours.TabIndex = 20
        LabelIARequiredHours.Text = "Required Hours:"
        ' 
        ' LabelIASection
        ' 
        LabelIASection.AutoSize = True
        LabelIASection.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LabelIASection.Location = New Point(23, 308)
        LabelIASection.Name = "LabelIASection"
        LabelIASection.Size = New Size(70, 23)
        LabelIASection.TabIndex = 19
        LabelIASection.Text = "Section:"
        ' 
        ' LabelIACourse
        ' 
        LabelIACourse.AutoSize = True
        LabelIACourse.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LabelIACourse.Location = New Point(23, 271)
        LabelIACourse.Name = "LabelIACourse"
        LabelIACourse.Size = New Size(67, 23)
        LabelIACourse.TabIndex = 18
        LabelIACourse.Text = "Course:"
        ' 
        ' LabelIAStudentName
        ' 
        LabelIAStudentName.AutoSize = True
        LabelIAStudentName.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LabelIAStudentName.Location = New Point(23, 234)
        LabelIAStudentName.Name = "LabelIAStudentName"
        LabelIAStudentName.Size = New Size(125, 23)
        LabelIAStudentName.TabIndex = 17
        LabelIAStudentName.Text = "Student Name:"
        ' 
        ' LabelIAStudentNo
        ' 
        LabelIAStudentNo.AutoSize = True
        LabelIAStudentNo.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        LabelIAStudentNo.Location = New Point(23, 196)
        LabelIAStudentNo.Name = "LabelIAStudentNo"
        LabelIAStudentNo.Size = New Size(102, 23)
        LabelIAStudentNo.TabIndex = 16
        LabelIAStudentNo.Text = "Student No:"
        ' 
        ' LabelIAStudentSelected
        ' 
        LabelIAStudentSelected.AutoSize = True
        LabelIAStudentSelected.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelIAStudentSelected.Location = New Point(23, 158)
        LabelIAStudentSelected.Name = "LabelIAStudentSelected"
        LabelIAStudentSelected.Size = New Size(152, 23)
        LabelIAStudentSelected.TabIndex = 15
        LabelIAStudentSelected.Text = "Selected Student:"
        ' 
        ' btnIASearch
        ' 
        btnIASearch.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnIASearch.FlatAppearance.BorderSize = 0
        btnIASearch.FlatStyle = FlatStyle.Flat
        btnIASearch.Font = New Font("Segoe UI", 10F)
        btnIASearch.ForeColor = Color.White
        btnIASearch.Location = New Point(984, 39)
        btnIASearch.Margin = New Padding(3, 4, 3, 4)
        btnIASearch.Name = "btnIASearch"
        btnIASearch.Size = New Size(100, 31)
        btnIASearch.TabIndex = 14
        btnIASearch.Text = "Search"
        btnIASearch.UseVisualStyleBackColor = False
        ' 
        ' txtIASearch
        ' 
        txtIASearch.Font = New Font("Segoe UI", 10F)
        txtIASearch.Location = New Point(807, 39)
        txtIASearch.Margin = New Padding(3, 4, 3, 4)
        txtIASearch.Name = "txtIASearch"
        txtIASearch.Size = New Size(150, 30)
        txtIASearch.TabIndex = 13
        ' 
        ' LabelIASearch
        ' 
        LabelIASearch.AutoSize = True
        LabelIASearch.Font = New Font("Segoe UI", 10F)
        LabelIASearch.Location = New Point(736, 42)
        LabelIASearch.Name = "LabelIASearch"
        LabelIASearch.Size = New Size(65, 23)
        LabelIASearch.TabIndex = 12
        LabelIASearch.Text = "Search:"
        ' 
        ' cboIAStudent
        ' 
        cboIAStudent.DropDownStyle = ComboBoxStyle.DropDownList
        cboIAStudent.Font = New Font("Segoe UI", 10F)
        cboIAStudent.FormattingEnabled = True
        cboIAStudent.Location = New Point(451, 39)
        cboIAStudent.Margin = New Padding(3, 4, 3, 4)
        cboIAStudent.Name = "cboIAStudent"
        cboIAStudent.Size = New Size(260, 31)
        cboIAStudent.TabIndex = 11
        ' 
        ' LabelIAStudentFilter
        ' 
        LabelIAStudentFilter.AutoSize = True
        LabelIAStudentFilter.Font = New Font("Segoe UI", 10F)
        LabelIAStudentFilter.Location = New Point(371, 42)
        LabelIAStudentFilter.Name = "LabelIAStudentFilter"
        LabelIAStudentFilter.Size = New Size(73, 23)
        LabelIAStudentFilter.TabIndex = 10
        LabelIAStudentFilter.Text = "Student:"
        ' 
        ' cboIASection
        ' 
        cboIASection.DropDownStyle = ComboBoxStyle.DropDownList
        cboIASection.Font = New Font("Segoe UI", 10F)
        cboIASection.FormattingEnabled = True
        cboIASection.Location = New Point(90, 39)
        cboIASection.Margin = New Padding(3, 4, 3, 4)
        cboIASection.Name = "cboIASection"
        cboIASection.Size = New Size(80, 31)
        cboIASection.TabIndex = 9
        ' 
        ' LabelIASectionFilter
        ' 
        LabelIASectionFilter.AutoSize = True
        LabelIASectionFilter.Font = New Font("Segoe UI", 10F)
        LabelIASectionFilter.Location = New Point(24, 42)
        LabelIASectionFilter.Name = "LabelIASectionFilter"
        LabelIASectionFilter.Size = New Size(70, 23)
        LabelIASectionFilter.TabIndex = 8
        LabelIASectionFilter.Text = "Section:"
        ' 
        ' lblIAFilters
        ' 
        lblIAFilters.AutoSize = True
        lblIAFilters.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblIAFilters.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblIAFilters.Location = New Point(24, 7)
        lblIAFilters.Name = "lblIAFilters"
        lblIAFilters.Size = New Size(66, 28)
        lblIAFilters.TabIndex = 7
        lblIAFilters.Text = "Filters"
        ' 
        ' lblInternshipTitle
        ' 
        lblInternshipTitle.AutoSize = True
        lblInternshipTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblInternshipTitle.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblInternshipTitle.Location = New Point(24, 91)
        lblInternshipTitle.Name = "lblInternshipTitle"
        lblInternshipTitle.Size = New Size(227, 32)
        lblInternshipTitle.TabIndex = 0
        lblInternshipTitle.Text = "Trainee Assignment"
        ' 
        ' pnlStudents
        ' 
        pnlStudents.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        pnlStudents.Controls.Add(dgvMyStudentsHistory)
        pnlStudents.Controls.Add(pnlStudentEditStatus)
        pnlStudents.Controls.Add(btnStudentEdit)
        pnlStudents.Controls.Add(dgvMyStudents)
        pnlStudents.Controls.Add(btnStudentSearch)
        pnlStudents.Controls.Add(txtStudentSearch)
        pnlStudents.Controls.Add(LabelStudentSearch)
        pnlStudents.Controls.Add(cboStudentStatus)
        pnlStudents.Controls.Add(LabelStudentStatusFilter)
        pnlStudents.Controls.Add(cboStudentSection)
        pnlStudents.Controls.Add(LabelStudentSectionFilter)
        pnlStudents.Controls.Add(lblStudentFilters)
        pnlStudents.Controls.Add(lblStudentsTitle)
        pnlStudents.Dock = DockStyle.Fill
        pnlStudents.Location = New Point(0, 0)
        pnlStudents.Margin = New Padding(3, 4, 3, 4)
        pnlStudents.Name = "pnlStudents"
        pnlStudents.Size = New Size(1321, 1002)
        pnlStudents.TabIndex = 1
        pnlStudents.Visible = False
        ' 
        ' dgvMyStudentsHistory
        ' 
        dgvMyStudentsHistory.AllowUserToAddRows = False
        dgvMyStudentsHistory.AllowUserToDeleteRows = False
        dgvMyStudentsHistory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        dgvMyStudentsHistory.BackgroundColor = Color.White
        dgvMyStudentsHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMyStudentsHistory.Location = New Point(24, 651)
        dgvMyStudentsHistory.Margin = New Padding(3, 4, 3, 4)
        dgvMyStudentsHistory.MultiSelect = False
        dgvMyStudentsHistory.Name = "dgvMyStudentsHistory"
        dgvMyStudentsHistory.ReadOnly = True
        dgvMyStudentsHistory.RowHeadersVisible = False
        dgvMyStudentsHistory.RowHeadersWidth = 51
        dgvMyStudentsHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMyStudentsHistory.Size = New Size(1271, 329)
        dgvMyStudentsHistory.TabIndex = 12
        ' 
        ' pnlStudentEditStatus
        ' 
        pnlStudentEditStatus.BorderStyle = BorderStyle.FixedSingle
        pnlStudentEditStatus.Controls.Add(btnStudentEditCancel)
        pnlStudentEditStatus.Controls.Add(btnStudentEditSave)
        pnlStudentEditStatus.Controls.Add(lblStudentEditStatus)
        pnlStudentEditStatus.Controls.Add(lblStudentName)
        pnlStudentEditStatus.Controls.Add(lblStudentEditTitle)
        pnlStudentEditStatus.Controls.Add(cboStudentEditStatus)
        pnlStudentEditStatus.Controls.Add(lblStudentNameTitle)
        pnlStudentEditStatus.Location = New Point(220, 110)
        pnlStudentEditStatus.Name = "pnlStudentEditStatus"
        pnlStudentEditStatus.Size = New Size(427, 278)
        pnlStudentEditStatus.TabIndex = 11
        pnlStudentEditStatus.Visible = False
        ' 
        ' btnStudentEditCancel
        ' 
        btnStudentEditCancel.BackColor = Color.LightGray
        btnStudentEditCancel.FlatStyle = FlatStyle.Flat
        btnStudentEditCancel.Location = New Point(230, 125)
        btnStudentEditCancel.Name = "btnStudentEditCancel"
        btnStudentEditCancel.Size = New Size(100, 32)
        btnStudentEditCancel.TabIndex = 6
        btnStudentEditCancel.Text = "Cancel"
        btnStudentEditCancel.UseVisualStyleBackColor = False
        ' 
        ' btnStudentEditSave
        ' 
        btnStudentEditSave.BackColor = Color.Lime
        btnStudentEditSave.FlatStyle = FlatStyle.Flat
        btnStudentEditSave.Location = New Point(110, 125)
        btnStudentEditSave.Name = "btnStudentEditSave"
        btnStudentEditSave.Size = New Size(100, 32)
        btnStudentEditSave.TabIndex = 5
        btnStudentEditSave.Text = "Save"
        btnStudentEditSave.UseVisualStyleBackColor = False
        ' 
        ' lblStudentEditStatus
        ' 
        lblStudentEditStatus.AutoSize = True
        lblStudentEditStatus.Location = New Point(20, 85)
        lblStudentEditStatus.Name = "lblStudentEditStatus"
        lblStudentEditStatus.Size = New Size(86, 20)
        lblStudentEditStatus.TabIndex = 4
        lblStudentEditStatus.Text = "New Status:"
        ' 
        ' lblStudentName
        ' 
        lblStudentName.AutoSize = True
        lblStudentName.Location = New Point(20, 45)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(63, 20)
        lblStudentName.TabIndex = 3
        lblStudentName.Text = "Student:"
        ' 
        ' lblStudentEditTitle
        ' 
        lblStudentEditTitle.AutoSize = True
        lblStudentEditTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentEditTitle.Location = New Point(20, 10)
        lblStudentEditTitle.Name = "lblStudentEditTitle"
        lblStudentEditTitle.Size = New Size(231, 28)
        lblStudentEditTitle.TabIndex = 2
        lblStudentEditTitle.Text = "EDIT STUDENT STATUS"
        ' 
        ' cboStudentEditStatus
        ' 
        cboStudentEditStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStudentEditStatus.FormattingEnabled = True
        cboStudentEditStatus.Items.AddRange(New Object() {"Active", "OnLeave", "Dropped", "Graduated"})
        cboStudentEditStatus.Location = New Point(110, 82)
        cboStudentEditStatus.Name = "cboStudentEditStatus"
        cboStudentEditStatus.Size = New Size(180, 28)
        cboStudentEditStatus.TabIndex = 1
        ' 
        ' lblStudentNameTitle
        ' 
        lblStudentNameTitle.AutoSize = True
        lblStudentNameTitle.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStudentNameTitle.Location = New Point(110, 45)
        lblStudentNameTitle.Name = "lblStudentNameTitle"
        lblStudentNameTitle.Size = New Size(17, 23)
        lblStudentNameTitle.TabIndex = 0
        lblStudentNameTitle.Text = "-"
        ' 
        ' btnStudentEdit
        ' 
        btnStudentEdit.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnStudentEdit.FlatAppearance.BorderSize = 0
        btnStudentEdit.FlatStyle = FlatStyle.Flat
        btnStudentEdit.Font = New Font("Segoe UI", 10F)
        btnStudentEdit.ForeColor = Color.White
        btnStudentEdit.Location = New Point(580, 134)
        btnStudentEdit.Margin = New Padding(3, 4, 3, 4)
        btnStudentEdit.Name = "btnStudentEdit"
        btnStudentEdit.Size = New Size(100, 40)
        btnStudentEdit.TabIndex = 10
        btnStudentEdit.Text = "Edit"
        btnStudentEdit.UseVisualStyleBackColor = False
        ' 
        ' dgvMyStudents
        ' 
        dgvMyStudents.AllowUserToAddRows = False
        dgvMyStudents.AllowUserToDeleteRows = False
        dgvMyStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvMyStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMyStudents.BackgroundColor = Color.White
        dgvMyStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMyStudents.Location = New Point(24, 188)
        dgvMyStudents.Margin = New Padding(3, 4, 3, 4)
        dgvMyStudents.MultiSelect = False
        dgvMyStudents.Name = "dgvMyStudents"
        dgvMyStudents.ReadOnly = True
        dgvMyStudents.RowHeadersVisible = False
        dgvMyStudents.RowHeadersWidth = 51
        dgvMyStudents.RowTemplate.Height = 28
        dgvMyStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMyStudents.Size = New Size(1271, 389)
        dgvMyStudents.TabIndex = 9
        ' 
        ' btnStudentSearch
        ' 
        btnStudentSearch.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnStudentSearch.FlatAppearance.BorderSize = 0
        btnStudentSearch.FlatStyle = FlatStyle.Flat
        btnStudentSearch.Font = New Font("Segoe UI", 10F)
        btnStudentSearch.ForeColor = Color.White
        btnStudentSearch.Location = New Point(450, 134)
        btnStudentSearch.Margin = New Padding(3, 4, 3, 4)
        btnStudentSearch.Name = "btnStudentSearch"
        btnStudentSearch.Size = New Size(100, 40)
        btnStudentSearch.TabIndex = 8
        btnStudentSearch.Text = "Search"
        btnStudentSearch.UseVisualStyleBackColor = False
        ' 
        ' txtStudentSearch
        ' 
        txtStudentSearch.Font = New Font("Segoe UI", 10F)
        txtStudentSearch.Location = New Point(320, 136)
        txtStudentSearch.Margin = New Padding(3, 4, 3, 4)
        txtStudentSearch.Name = "txtStudentSearch"
        txtStudentSearch.Size = New Size(120, 30)
        txtStudentSearch.TabIndex = 7
        ' 
        ' LabelStudentSearch
        ' 
        LabelStudentSearch.AutoSize = True
        LabelStudentSearch.Font = New Font("Segoe UI", 10F)
        LabelStudentSearch.Location = New Point(250, 139)
        LabelStudentSearch.Name = "LabelStudentSearch"
        LabelStudentSearch.Size = New Size(65, 23)
        LabelStudentSearch.TabIndex = 6
        LabelStudentSearch.Text = "Search:"
        ' 
        ' cboStudentStatus
        ' 
        cboStudentStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboStudentStatus.Font = New Font("Segoe UI", 10F)
        cboStudentStatus.FormattingEnabled = True
        cboStudentStatus.Location = New Point(120, 136)
        cboStudentStatus.Margin = New Padding(3, 4, 3, 4)
        cboStudentStatus.Name = "cboStudentStatus"
        cboStudentStatus.Size = New Size(120, 31)
        cboStudentStatus.TabIndex = 5
        ' 
        ' LabelStudentStatusFilter
        ' 
        LabelStudentStatusFilter.AutoSize = True
        LabelStudentStatusFilter.Font = New Font("Segoe UI", 10F)
        LabelStudentStatusFilter.Location = New Point(24, 139)
        LabelStudentStatusFilter.Name = "LabelStudentStatusFilter"
        LabelStudentStatusFilter.Size = New Size(60, 23)
        LabelStudentStatusFilter.TabIndex = 4
        LabelStudentStatusFilter.Text = "Status:"
        ' 
        ' cboStudentSection
        ' 
        cboStudentSection.DropDownStyle = ComboBoxStyle.DropDownList
        cboStudentSection.Font = New Font("Segoe UI", 10F)
        cboStudentSection.FormattingEnabled = True
        cboStudentSection.Location = New Point(120, 89)
        cboStudentSection.Margin = New Padding(3, 4, 3, 4)
        cboStudentSection.Name = "cboStudentSection"
        cboStudentSection.Size = New Size(120, 31)
        cboStudentSection.TabIndex = 3
        ' 
        ' LabelStudentSectionFilter
        ' 
        LabelStudentSectionFilter.AutoSize = True
        LabelStudentSectionFilter.Font = New Font("Segoe UI", 10F)
        LabelStudentSectionFilter.Location = New Point(24, 92)
        LabelStudentSectionFilter.Name = "LabelStudentSectionFilter"
        LabelStudentSectionFilter.Size = New Size(70, 23)
        LabelStudentSectionFilter.TabIndex = 2
        LabelStudentSectionFilter.Text = "Section:"
        ' 
        ' lblStudentFilters
        ' 
        lblStudentFilters.AutoSize = True
        lblStudentFilters.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblStudentFilters.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblStudentFilters.Location = New Point(24, 44)
        lblStudentFilters.Name = "lblStudentFilters"
        lblStudentFilters.Size = New Size(66, 28)
        lblStudentFilters.TabIndex = 1
        lblStudentFilters.Text = "Filters"
        ' 
        ' lblStudentsTitle
        ' 
        lblStudentsTitle.AutoSize = True
        lblStudentsTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblStudentsTitle.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblStudentsTitle.Location = New Point(23, 5)
        lblStudentsTitle.Name = "lblStudentsTitle"
        lblStudentsTitle.Size = New Size(150, 32)
        lblStudentsTitle.TabIndex = 0
        lblStudentsTitle.Text = "My Students"
        ' 
        ' pnlHome
        ' 
        pnlHome.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        pnlHome.Controls.Add(dgvRecentActivity)
        pnlHome.Controls.Add(lblRecentActivity)
        pnlHome.Controls.Add(pnlCardCompletedInternships)
        pnlHome.Controls.Add(pnlCardPendingVisitLogs)
        pnlHome.Controls.Add(pnlCardActiveInternships)
        pnlHome.Controls.Add(pnlCardMyStudents)
        pnlHome.Controls.Add(lblHomeTitle)
        pnlHome.Dock = DockStyle.Fill
        pnlHome.Location = New Point(0, 0)
        pnlHome.Margin = New Padding(3, 4, 3, 4)
        pnlHome.Name = "pnlHome"
        pnlHome.Size = New Size(1321, 1002)
        pnlHome.TabIndex = 0
        ' 
        ' dgvRecentActivity
        ' 
        dgvRecentActivity.AllowUserToAddRows = False
        dgvRecentActivity.AllowUserToDeleteRows = False
        dgvRecentActivity.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRecentActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecentActivity.BackgroundColor = Color.White
        dgvRecentActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecentActivity.Location = New Point(24, 325)
        dgvRecentActivity.Margin = New Padding(3, 4, 3, 4)
        dgvRecentActivity.MultiSelect = False
        dgvRecentActivity.Name = "dgvRecentActivity"
        dgvRecentActivity.ReadOnly = True
        dgvRecentActivity.RowHeadersVisible = False
        dgvRecentActivity.RowHeadersWidth = 51
        dgvRecentActivity.RowTemplate.Height = 28
        dgvRecentActivity.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecentActivity.Size = New Size(1271, 652)
        dgvRecentActivity.TabIndex = 6
        ' 
        ' lblRecentActivity
        ' 
        lblRecentActivity.AutoSize = True
        lblRecentActivity.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblRecentActivity.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblRecentActivity.Location = New Point(24, 275)
        lblRecentActivity.Name = "lblRecentActivity"
        lblRecentActivity.Size = New Size(145, 28)
        lblRecentActivity.TabIndex = 5
        lblRecentActivity.Text = "Recent Activity"
        ' 
        ' pnlCardCompletedInternships
        ' 
        pnlCardCompletedInternships.BackColor = Color.White
        pnlCardCompletedInternships.BorderStyle = BorderStyle.FixedSingle
        pnlCardCompletedInternships.Controls.Add(lblCardCompletedInternshipsValue)
        pnlCardCompletedInternships.Controls.Add(lblCardCompletedInternshipsTitle)
        pnlCardCompletedInternships.Location = New Point(780, 100)
        pnlCardCompletedInternships.Margin = New Padding(3, 4, 3, 4)
        pnlCardCompletedInternships.Name = "pnlCardCompletedInternships"
        pnlCardCompletedInternships.Size = New Size(244, 150)
        pnlCardCompletedInternships.TabIndex = 4
        ' 
        ' lblCardCompletedInternshipsValue
        ' 
        lblCardCompletedInternshipsValue.AutoSize = True
        lblCardCompletedInternshipsValue.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblCardCompletedInternshipsValue.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblCardCompletedInternshipsValue.Location = New Point(20, 62)
        lblCardCompletedInternshipsValue.Name = "lblCardCompletedInternshipsValue"
        lblCardCompletedInternshipsValue.Size = New Size(69, 54)
        lblCardCompletedInternshipsValue.TabIndex = 1
        lblCardCompletedInternshipsValue.Text = "00"
        ' 
        ' lblCardCompletedInternshipsTitle
        ' 
        lblCardCompletedInternshipsTitle.AutoSize = True
        lblCardCompletedInternshipsTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblCardCompletedInternshipsTitle.Location = New Point(20, 19)
        lblCardCompletedInternshipsTitle.Name = "lblCardCompletedInternshipsTitle"
        lblCardCompletedInternshipsTitle.Size = New Size(213, 25)
        lblCardCompletedInternshipsTitle.TabIndex = 0
        lblCardCompletedInternshipsTitle.Text = "Completed Internships"
        ' 
        ' pnlCardPendingVisitLogs
        ' 
        pnlCardPendingVisitLogs.BackColor = Color.White
        pnlCardPendingVisitLogs.BorderStyle = BorderStyle.FixedSingle
        pnlCardPendingVisitLogs.Controls.Add(lblCardPendingVisitLogsValue)
        pnlCardPendingVisitLogs.Controls.Add(lblCardPendingVisitLogsTitle)
        pnlCardPendingVisitLogs.Location = New Point(530, 100)
        pnlCardPendingVisitLogs.Margin = New Padding(3, 4, 3, 4)
        pnlCardPendingVisitLogs.Name = "pnlCardPendingVisitLogs"
        pnlCardPendingVisitLogs.Size = New Size(244, 150)
        pnlCardPendingVisitLogs.TabIndex = 3
        ' 
        ' lblCardPendingVisitLogsValue
        ' 
        lblCardPendingVisitLogsValue.AutoSize = True
        lblCardPendingVisitLogsValue.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblCardPendingVisitLogsValue.ForeColor = Color.FromArgb(CByte(229), CByte(57), CByte(53))
        lblCardPendingVisitLogsValue.Location = New Point(20, 62)
        lblCardPendingVisitLogsValue.Name = "lblCardPendingVisitLogsValue"
        lblCardPendingVisitLogsValue.Size = New Size(69, 54)
        lblCardPendingVisitLogsValue.TabIndex = 1
        lblCardPendingVisitLogsValue.Text = "00"
        ' 
        ' lblCardPendingVisitLogsTitle
        ' 
        lblCardPendingVisitLogsTitle.AutoSize = True
        lblCardPendingVisitLogsTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblCardPendingVisitLogsTitle.Location = New Point(20, 19)
        lblCardPendingVisitLogsTitle.Name = "lblCardPendingVisitLogsTitle"
        lblCardPendingVisitLogsTitle.Size = New Size(176, 25)
        lblCardPendingVisitLogsTitle.TabIndex = 0
        lblCardPendingVisitLogsTitle.Text = "Pending Visit Logs"
        ' 
        ' pnlCardActiveInternships
        ' 
        pnlCardActiveInternships.BackColor = Color.White
        pnlCardActiveInternships.BorderStyle = BorderStyle.FixedSingle
        pnlCardActiveInternships.Controls.Add(lblCardActiveInternshipsValue)
        pnlCardActiveInternships.Controls.Add(lblCardActiveInternshipsTitle)
        pnlCardActiveInternships.Location = New Point(280, 100)
        pnlCardActiveInternships.Margin = New Padding(3, 4, 3, 4)
        pnlCardActiveInternships.Name = "pnlCardActiveInternships"
        pnlCardActiveInternships.Size = New Size(244, 150)
        pnlCardActiveInternships.TabIndex = 2
        ' 
        ' lblCardActiveInternshipsValue
        ' 
        lblCardActiveInternshipsValue.AutoSize = True
        lblCardActiveInternshipsValue.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblCardActiveInternshipsValue.ForeColor = Color.FromArgb(CByte(30), CByte(136), CByte(229))
        lblCardActiveInternshipsValue.Location = New Point(20, 62)
        lblCardActiveInternshipsValue.Name = "lblCardActiveInternshipsValue"
        lblCardActiveInternshipsValue.Size = New Size(69, 54)
        lblCardActiveInternshipsValue.TabIndex = 1
        lblCardActiveInternshipsValue.Text = "00"
        ' 
        ' lblCardActiveInternshipsTitle
        ' 
        lblCardActiveInternshipsTitle.AutoSize = True
        lblCardActiveInternshipsTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblCardActiveInternshipsTitle.Location = New Point(20, 19)
        lblCardActiveInternshipsTitle.Name = "lblCardActiveInternshipsTitle"
        lblCardActiveInternshipsTitle.Size = New Size(170, 25)
        lblCardActiveInternshipsTitle.TabIndex = 0
        lblCardActiveInternshipsTitle.Text = "Active Internships"
        ' 
        ' pnlCardMyStudents
        ' 
        pnlCardMyStudents.BackColor = Color.White
        pnlCardMyStudents.BorderStyle = BorderStyle.FixedSingle
        pnlCardMyStudents.Controls.Add(lblCardMyStudentsValue)
        pnlCardMyStudents.Controls.Add(lblCardMyStudentsTitle)
        pnlCardMyStudents.Location = New Point(24, 100)
        pnlCardMyStudents.Margin = New Padding(3, 4, 3, 4)
        pnlCardMyStudents.Name = "pnlCardMyStudents"
        pnlCardMyStudents.Size = New Size(244, 150)
        pnlCardMyStudents.TabIndex = 1
        ' 
        ' lblCardMyStudentsValue
        ' 
        lblCardMyStudentsValue.AutoSize = True
        lblCardMyStudentsValue.Font = New Font("Segoe UI", 24F, FontStyle.Bold)
        lblCardMyStudentsValue.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblCardMyStudentsValue.Location = New Point(20, 62)
        lblCardMyStudentsValue.Name = "lblCardMyStudentsValue"
        lblCardMyStudentsValue.Size = New Size(69, 54)
        lblCardMyStudentsValue.TabIndex = 1
        lblCardMyStudentsValue.Text = "00"
        ' 
        ' lblCardMyStudentsTitle
        ' 
        lblCardMyStudentsTitle.AutoSize = True
        lblCardMyStudentsTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblCardMyStudentsTitle.Location = New Point(20, 19)
        lblCardMyStudentsTitle.Name = "lblCardMyStudentsTitle"
        lblCardMyStudentsTitle.Size = New Size(124, 25)
        lblCardMyStudentsTitle.TabIndex = 0
        lblCardMyStudentsTitle.Text = "My Students"
        ' 
        ' lblHomeTitle
        ' 
        lblHomeTitle.AutoSize = True
        lblHomeTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblHomeTitle.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblHomeTitle.Location = New Point(24, 30)
        lblHomeTitle.Name = "lblHomeTitle"
        lblHomeTitle.Size = New Size(80, 32)
        lblHomeTitle.TabIndex = 0
        lblHomeTitle.Text = "Home"
        ' 
        ' pnlProfile
        ' 
        pnlProfile.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        pnlProfile.Controls.Add(btnPFCancel)
        pnlProfile.Controls.Add(btnPFSave)
        pnlProfile.Controls.Add(btnPFEdit)
        pnlProfile.Controls.Add(txtPFConfirmPassword)
        pnlProfile.Controls.Add(txtPFPassword)
        pnlProfile.Controls.Add(txtPFContact)
        pnlProfile.Controls.Add(txtPFEmail)
        pnlProfile.Controls.Add(lblPFSections)
        pnlProfile.Controls.Add(lblPFDepartment)
        pnlProfile.Controls.Add(lblPFName)
        pnlProfile.Controls.Add(lblPFFacultyNumber)
        pnlProfile.Controls.Add(LabelPFSectionsLabel)
        pnlProfile.Controls.Add(LabelPFDepartmentLabel)
        pnlProfile.Controls.Add(LabelPFNameLabel)
        pnlProfile.Controls.Add(LabelPFFacultyNumberLabel)
        pnlProfile.Controls.Add(LabelPFConfirmPassword)
        pnlProfile.Controls.Add(LabelPFPassword)
        pnlProfile.Controls.Add(LabelPFContact)
        pnlProfile.Controls.Add(LabelPFEmail)
        pnlProfile.Controls.Add(lblProfileTitle)
        pnlProfile.Dock = DockStyle.Fill
        pnlProfile.Location = New Point(0, 0)
        pnlProfile.Margin = New Padding(3, 4, 3, 4)
        pnlProfile.Name = "pnlProfile"
        pnlProfile.Size = New Size(1321, 1002)
        pnlProfile.TabIndex = 7
        pnlProfile.Visible = False
        ' 
        ' btnPFCancel
        ' 
        btnPFCancel.BackColor = SystemColors.ScrollBar
        btnPFCancel.FlatAppearance.BorderSize = 0
        btnPFCancel.FlatStyle = FlatStyle.Flat
        btnPFCancel.Font = New Font("Segoe UI", 10F)
        btnPFCancel.ForeColor = Color.White
        btnPFCancel.Location = New Point(290, 538)
        btnPFCancel.Margin = New Padding(3, 4, 3, 4)
        btnPFCancel.Name = "btnPFCancel"
        btnPFCancel.Size = New Size(100, 40)
        btnPFCancel.TabIndex = 19
        btnPFCancel.Text = "Cancel"
        btnPFCancel.UseVisualStyleBackColor = False
        ' 
        ' btnPFSave
        ' 
        btnPFSave.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnPFSave.FlatAppearance.BorderSize = 0
        btnPFSave.FlatStyle = FlatStyle.Flat
        btnPFSave.Font = New Font("Segoe UI", 10F)
        btnPFSave.ForeColor = Color.White
        btnPFSave.Location = New Point(160, 538)
        btnPFSave.Margin = New Padding(3, 4, 3, 4)
        btnPFSave.Name = "btnPFSave"
        btnPFSave.Size = New Size(100, 40)
        btnPFSave.TabIndex = 18
        btnPFSave.Text = "Save"
        btnPFSave.UseVisualStyleBackColor = False
        ' 
        ' btnPFEdit
        ' 
        btnPFEdit.BackColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        btnPFEdit.FlatAppearance.BorderSize = 0
        btnPFEdit.FlatStyle = FlatStyle.Flat
        btnPFEdit.Font = New Font("Segoe UI", 10F)
        btnPFEdit.ForeColor = Color.White
        btnPFEdit.Location = New Point(24, 538)
        btnPFEdit.Margin = New Padding(3, 4, 3, 4)
        btnPFEdit.Name = "btnPFEdit"
        btnPFEdit.Size = New Size(100, 40)
        btnPFEdit.TabIndex = 17
        btnPFEdit.Text = "Edit"
        btnPFEdit.UseVisualStyleBackColor = False
        ' 
        ' txtPFConfirmPassword
        ' 
        txtPFConfirmPassword.Font = New Font("Segoe UI", 10F)
        txtPFConfirmPassword.Location = New Point(200, 462)
        txtPFConfirmPassword.Margin = New Padding(3, 4, 3, 4)
        txtPFConfirmPassword.Name = "txtPFConfirmPassword"
        txtPFConfirmPassword.Size = New Size(250, 30)
        txtPFConfirmPassword.TabIndex = 16
        txtPFConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' txtPFPassword
        ' 
        txtPFPassword.Font = New Font("Segoe UI", 10F)
        txtPFPassword.Location = New Point(200, 412)
        txtPFPassword.Margin = New Padding(3, 4, 3, 4)
        txtPFPassword.Name = "txtPFPassword"
        txtPFPassword.Size = New Size(250, 30)
        txtPFPassword.TabIndex = 15
        txtPFPassword.UseSystemPasswordChar = True
        ' 
        ' txtPFContact
        ' 
        txtPFContact.Font = New Font("Segoe UI", 10F)
        txtPFContact.Location = New Point(200, 362)
        txtPFContact.Margin = New Padding(3, 4, 3, 4)
        txtPFContact.Name = "txtPFContact"
        txtPFContact.Size = New Size(250, 30)
        txtPFContact.TabIndex = 14
        ' 
        ' txtPFEmail
        ' 
        txtPFEmail.Font = New Font("Segoe UI", 10F)
        txtPFEmail.Location = New Point(200, 312)
        txtPFEmail.Margin = New Padding(3, 4, 3, 4)
        txtPFEmail.Name = "txtPFEmail"
        txtPFEmail.Size = New Size(250, 30)
        txtPFEmail.TabIndex = 13
        ' 
        ' lblPFSections
        ' 
        lblPFSections.AutoSize = True
        lblPFSections.Font = New Font("Segoe UI", 10F)
        lblPFSections.Location = New Point(200, 250)
        lblPFSections.Name = "lblPFSections"
        lblPFSections.Size = New Size(0, 23)
        lblPFSections.TabIndex = 12
        ' 
        ' lblPFDepartment
        ' 
        lblPFDepartment.AutoSize = True
        lblPFDepartment.Font = New Font("Segoe UI", 10F)
        lblPFDepartment.Location = New Point(200, 212)
        lblPFDepartment.Name = "lblPFDepartment"
        lblPFDepartment.Size = New Size(0, 23)
        lblPFDepartment.TabIndex = 11
        ' 
        ' lblPFName
        ' 
        lblPFName.AutoSize = True
        lblPFName.Font = New Font("Segoe UI", 10F)
        lblPFName.Location = New Point(200, 175)
        lblPFName.Name = "lblPFName"
        lblPFName.Size = New Size(0, 23)
        lblPFName.TabIndex = 10
        ' 
        ' lblPFFacultyNumber
        ' 
        lblPFFacultyNumber.AutoSize = True
        lblPFFacultyNumber.Font = New Font("Segoe UI", 10F)
        lblPFFacultyNumber.Location = New Point(200, 138)
        lblPFFacultyNumber.Name = "lblPFFacultyNumber"
        lblPFFacultyNumber.Size = New Size(0, 23)
        lblPFFacultyNumber.TabIndex = 9
        ' 
        ' LabelPFSectionsLabel
        ' 
        LabelPFSectionsLabel.AutoSize = True
        LabelPFSectionsLabel.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelPFSectionsLabel.Location = New Point(24, 250)
        LabelPFSectionsLabel.Name = "LabelPFSectionsLabel"
        LabelPFSectionsLabel.Size = New Size(158, 23)
        LabelPFSectionsLabel.TabIndex = 8
        LabelPFSectionsLabel.Text = "Sections Assigned:"
        ' 
        ' LabelPFDepartmentLabel
        ' 
        LabelPFDepartmentLabel.AutoSize = True
        LabelPFDepartmentLabel.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelPFDepartmentLabel.Location = New Point(24, 212)
        LabelPFDepartmentLabel.Name = "LabelPFDepartmentLabel"
        LabelPFDepartmentLabel.Size = New Size(113, 23)
        LabelPFDepartmentLabel.TabIndex = 7
        LabelPFDepartmentLabel.Text = "Department:"
        ' 
        ' LabelPFNameLabel
        ' 
        LabelPFNameLabel.AutoSize = True
        LabelPFNameLabel.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelPFNameLabel.Location = New Point(24, 175)
        LabelPFNameLabel.Name = "LabelPFNameLabel"
        LabelPFNameLabel.Size = New Size(62, 23)
        LabelPFNameLabel.TabIndex = 6
        LabelPFNameLabel.Text = "Name:"
        ' 
        ' LabelPFFacultyNumberLabel
        ' 
        LabelPFFacultyNumberLabel.AutoSize = True
        LabelPFFacultyNumberLabel.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelPFFacultyNumberLabel.Location = New Point(24, 138)
        LabelPFFacultyNumberLabel.Name = "LabelPFFacultyNumberLabel"
        LabelPFFacultyNumberLabel.Size = New Size(143, 23)
        LabelPFFacultyNumberLabel.TabIndex = 5
        LabelPFFacultyNumberLabel.Text = "Faculty Number:"
        ' 
        ' LabelPFConfirmPassword
        ' 
        LabelPFConfirmPassword.AutoSize = True
        LabelPFConfirmPassword.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelPFConfirmPassword.Location = New Point(24, 462)
        LabelPFConfirmPassword.Name = "LabelPFConfirmPassword"
        LabelPFConfirmPassword.Size = New Size(161, 23)
        LabelPFConfirmPassword.TabIndex = 4
        LabelPFConfirmPassword.Text = "Confirm Password:"
        ' 
        ' LabelPFPassword
        ' 
        LabelPFPassword.AutoSize = True
        LabelPFPassword.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelPFPassword.Location = New Point(24, 412)
        LabelPFPassword.Name = "LabelPFPassword"
        LabelPFPassword.Size = New Size(90, 23)
        LabelPFPassword.TabIndex = 3
        LabelPFPassword.Text = "Password:"
        ' 
        ' LabelPFContact
        ' 
        LabelPFContact.AutoSize = True
        LabelPFContact.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelPFContact.Location = New Point(24, 362)
        LabelPFContact.Name = "LabelPFContact"
        LabelPFContact.Size = New Size(149, 23)
        LabelPFContact.TabIndex = 2
        LabelPFContact.Text = "Contact Number:"
        ' 
        ' LabelPFEmail
        ' 
        LabelPFEmail.AutoSize = True
        LabelPFEmail.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelPFEmail.Location = New Point(24, 312)
        LabelPFEmail.Name = "LabelPFEmail"
        LabelPFEmail.Size = New Size(59, 23)
        LabelPFEmail.TabIndex = 1
        LabelPFEmail.Text = "Email:"
        ' 
        ' lblProfileTitle
        ' 
        lblProfileTitle.AutoSize = True
        lblProfileTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblProfileTitle.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblProfileTitle.Location = New Point(24, 30)
        lblProfileTitle.Name = "lblProfileTitle"
        lblProfileTitle.Size = New Size(125, 32)
        lblProfileTitle.TabIndex = 0
        lblProfileTitle.Text = "My Profile"
        ' 
        ' pnlCompanyContacts
        ' 
        pnlCompanyContacts.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        pnlCompanyContacts.Controls.Add(btnCCAddContact)
        pnlCompanyContacts.Controls.Add(cboCCCompany)
        pnlCompanyContacts.Controls.Add(LabelCCCompany)
        pnlCompanyContacts.Controls.Add(dgvCompanyContacts)
        pnlCompanyContacts.Controls.Add(lblCompanyContactsTitle)
        pnlCompanyContacts.Dock = DockStyle.Fill
        pnlCompanyContacts.Location = New Point(0, 0)
        pnlCompanyContacts.Margin = New Padding(3, 4, 3, 4)
        pnlCompanyContacts.Name = "pnlCompanyContacts"
        pnlCompanyContacts.Size = New Size(1321, 1002)
        pnlCompanyContacts.TabIndex = 6
        pnlCompanyContacts.Visible = False
        ' 
        ' btnCCAddContact
        ' 
        btnCCAddContact.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnCCAddContact.FlatAppearance.BorderSize = 0
        btnCCAddContact.FlatStyle = FlatStyle.Flat
        btnCCAddContact.Font = New Font("Segoe UI", 10F)
        btnCCAddContact.ForeColor = Color.White
        btnCCAddContact.Location = New Point(400, 120)
        btnCCAddContact.Margin = New Padding(3, 4, 3, 4)
        btnCCAddContact.Name = "btnCCAddContact"
        btnCCAddContact.Size = New Size(120, 40)
        btnCCAddContact.TabIndex = 4
        btnCCAddContact.Text = "Add Contact"
        btnCCAddContact.UseVisualStyleBackColor = False
        ' 
        ' cboCCCompany
        ' 
        cboCCCompany.DropDownStyle = ComboBoxStyle.DropDownList
        cboCCCompany.Font = New Font("Segoe UI", 10F)
        cboCCCompany.FormattingEnabled = True
        cboCCCompany.Location = New Point(120, 120)
        cboCCCompany.Margin = New Padding(3, 4, 3, 4)
        cboCCCompany.Name = "cboCCCompany"
        cboCCCompany.Size = New Size(260, 31)
        cboCCCompany.TabIndex = 3
        ' 
        ' LabelCCCompany
        ' 
        LabelCCCompany.AutoSize = True
        LabelCCCompany.Font = New Font("Segoe UI", 10F)
        LabelCCCompany.Location = New Point(24, 125)
        LabelCCCompany.Name = "LabelCCCompany"
        LabelCCCompany.Size = New Size(87, 23)
        LabelCCCompany.TabIndex = 2
        LabelCCCompany.Text = "Company:"
        ' 
        ' dgvCompanyContacts
        ' 
        dgvCompanyContacts.AllowUserToAddRows = False
        dgvCompanyContacts.AllowUserToDeleteRows = False
        dgvCompanyContacts.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvCompanyContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCompanyContacts.BackgroundColor = Color.White
        dgvCompanyContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCompanyContacts.Location = New Point(24, 188)
        dgvCompanyContacts.Margin = New Padding(3, 4, 3, 4)
        dgvCompanyContacts.MultiSelect = False
        dgvCompanyContacts.Name = "dgvCompanyContacts"
        dgvCompanyContacts.ReadOnly = True
        dgvCompanyContacts.RowHeadersVisible = False
        dgvCompanyContacts.RowHeadersWidth = 51
        dgvCompanyContacts.RowTemplate.Height = 28
        dgvCompanyContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCompanyContacts.Size = New Size(1271, 777)
        dgvCompanyContacts.TabIndex = 1
        ' 
        ' lblCompanyContactsTitle
        ' 
        lblCompanyContactsTitle.AutoSize = True
        lblCompanyContactsTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblCompanyContactsTitle.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblCompanyContactsTitle.Location = New Point(24, 30)
        lblCompanyContactsTitle.Name = "lblCompanyContactsTitle"
        lblCompanyContactsTitle.Size = New Size(219, 32)
        lblCompanyContactsTitle.TabIndex = 0
        lblCompanyContactsTitle.Text = "Company Contacts"
        ' 
        ' pnlCompanies
        ' 
        pnlCompanies.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        pnlCompanies.Controls.Add(btnCompanyAdd)
        pnlCompanies.Controls.Add(btnCompanySearch)
        pnlCompanies.Controls.Add(txtCompanySearch)
        pnlCompanies.Controls.Add(LabelCompanySearch)
        pnlCompanies.Controls.Add(dgvCompanies)
        pnlCompanies.Controls.Add(lblCompaniesTitle)
        pnlCompanies.Controls.Add(pnlCompanyForm)
        pnlCompanies.Dock = DockStyle.Fill
        pnlCompanies.Location = New Point(0, 0)
        pnlCompanies.Margin = New Padding(3, 4, 3, 4)
        pnlCompanies.Name = "pnlCompanies"
        pnlCompanies.Size = New Size(1321, 1002)
        pnlCompanies.TabIndex = 5
        pnlCompanies.Visible = False
        ' 
        ' btnCompanyAdd
        ' 
        btnCompanyAdd.BackColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        btnCompanyAdd.FlatAppearance.BorderSize = 0
        btnCompanyAdd.FlatStyle = FlatStyle.Flat
        btnCompanyAdd.Font = New Font("Segoe UI", 10F)
        btnCompanyAdd.ForeColor = Color.White
        btnCompanyAdd.Location = New Point(24, 135)
        btnCompanyAdd.Margin = New Padding(3, 4, 3, 4)
        btnCompanyAdd.Name = "btnCompanyAdd"
        btnCompanyAdd.Size = New Size(150, 35)
        btnCompanyAdd.TabIndex = 4
        btnCompanyAdd.Text = "Add Company"
        btnCompanyAdd.UseVisualStyleBackColor = False
        ' 
        ' btnCompanySearch
        ' 
        btnCompanySearch.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnCompanySearch.FlatAppearance.BorderSize = 0
        btnCompanySearch.FlatStyle = FlatStyle.Flat
        btnCompanySearch.Font = New Font("Segoe UI", 10F)
        btnCompanySearch.ForeColor = Color.White
        btnCompanySearch.Location = New Point(370, 84)
        btnCompanySearch.Margin = New Padding(3, 4, 3, 4)
        btnCompanySearch.Name = "btnCompanySearch"
        btnCompanySearch.Size = New Size(100, 35)
        btnCompanySearch.TabIndex = 3
        btnCompanySearch.Text = "Search"
        btnCompanySearch.UseVisualStyleBackColor = False
        ' 
        ' txtCompanySearch
        ' 
        txtCompanySearch.Font = New Font("Segoe UI", 10F)
        txtCompanySearch.Location = New Point(95, 87)
        txtCompanySearch.Margin = New Padding(3, 4, 3, 4)
        txtCompanySearch.Name = "txtCompanySearch"
        txtCompanySearch.Size = New Size(260, 30)
        txtCompanySearch.TabIndex = 2
        ' 
        ' LabelCompanySearch
        ' 
        LabelCompanySearch.AutoSize = True
        LabelCompanySearch.Font = New Font("Segoe UI", 10F)
        LabelCompanySearch.Location = New Point(24, 90)
        LabelCompanySearch.Name = "LabelCompanySearch"
        LabelCompanySearch.Size = New Size(65, 23)
        LabelCompanySearch.TabIndex = 1
        LabelCompanySearch.Text = "Search:"
        ' 
        ' dgvCompanies
        ' 
        dgvCompanies.AllowUserToAddRows = False
        dgvCompanies.AllowUserToDeleteRows = False
        dgvCompanies.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        dgvCompanies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCompanies.BackgroundColor = Color.White
        dgvCompanies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCompanies.Location = New Point(24, 188)
        dgvCompanies.Margin = New Padding(3, 4, 3, 4)
        dgvCompanies.MultiSelect = False
        dgvCompanies.Name = "dgvCompanies"
        dgvCompanies.ReadOnly = True
        dgvCompanies.RowHeadersVisible = False
        dgvCompanies.RowHeadersWidth = 51
        dgvCompanies.RowTemplate.Height = 28
        dgvCompanies.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCompanies.Size = New Size(996, 777)
        dgvCompanies.TabIndex = 0
        ' 
        ' lblCompaniesTitle
        ' 
        lblCompaniesTitle.AutoSize = True
        lblCompaniesTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblCompaniesTitle.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblCompaniesTitle.Location = New Point(24, 30)
        lblCompaniesTitle.Name = "lblCompaniesTitle"
        lblCompaniesTitle.Size = New Size(134, 32)
        lblCompaniesTitle.TabIndex = 0
        lblCompaniesTitle.Text = "Companies"
        ' 
        ' pnlCompanyForm
        ' 
        pnlCompanyForm.BackColor = Color.White
        pnlCompanyForm.BorderStyle = BorderStyle.FixedSingle
        pnlCompanyForm.Controls.Add(lblCompanyFormTitle)
        pnlCompanyForm.Controls.Add(lblCompanyNameLabel)
        pnlCompanyForm.Controls.Add(lblCompanyAddressLabel)
        pnlCompanyForm.Controls.Add(lblCompanyCityLabel)
        pnlCompanyForm.Controls.Add(lblCompanyIndustryLabel)
        pnlCompanyForm.Controls.Add(lblCompanyEmailLabel)
        pnlCompanyForm.Controls.Add(lblCompanyContactLabel)
        pnlCompanyForm.Controls.Add(lblCompanyWebsiteLabel)
        pnlCompanyForm.Controls.Add(lblCompanyAccStatusLabel)
        pnlCompanyForm.Controls.Add(lblCompanyAccDateLabel)
        pnlCompanyForm.Controls.Add(txtCompanyName)
        pnlCompanyForm.Controls.Add(txtCompanyAddress)
        pnlCompanyForm.Controls.Add(cboCompanyCity)
        pnlCompanyForm.Controls.Add(txtCompanyIndustry)
        pnlCompanyForm.Controls.Add(txtCompanyEmail)
        pnlCompanyForm.Controls.Add(txtCompanyContact)
        pnlCompanyForm.Controls.Add(txtCompanyWebsite)
        pnlCompanyForm.Controls.Add(cboCompanyAccreditationStatus)
        pnlCompanyForm.Controls.Add(dtpCompanyAccreditationDate)
        pnlCompanyForm.Controls.Add(chkCompanyIsActive)
        pnlCompanyForm.Controls.Add(btnCompanySave)
        pnlCompanyForm.Controls.Add(btnCompanyCancel)
        pnlCompanyForm.Location = New Point(260, 130)
        pnlCompanyForm.Name = "pnlCompanyForm"
        pnlCompanyForm.Size = New Size(620, 460)
        pnlCompanyForm.TabIndex = 5
        pnlCompanyForm.Visible = False
        ' 
        ' lblCompanyFormTitle
        ' 
        lblCompanyFormTitle.AutoSize = True
        lblCompanyFormTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblCompanyFormTitle.Location = New Point(20, 15)
        lblCompanyFormTitle.Name = "lblCompanyFormTitle"
        lblCompanyFormTitle.Size = New Size(245, 32)
        lblCompanyFormTitle.TabIndex = 0
        lblCompanyFormTitle.Text = "Add / Edit Company"
        ' 
        ' lblCompanyNameLabel
        ' 
        lblCompanyNameLabel.AutoSize = True
        lblCompanyNameLabel.Font = New Font("Segoe UI", 10F)
        lblCompanyNameLabel.Location = New Point(20, 70)
        lblCompanyNameLabel.Name = "lblCompanyNameLabel"
        lblCompanyNameLabel.Size = New Size(138, 23)
        lblCompanyNameLabel.TabIndex = 1
        lblCompanyNameLabel.Text = "Company Name:"
        ' 
        ' lblCompanyAddressLabel
        ' 
        lblCompanyAddressLabel.AutoSize = True
        lblCompanyAddressLabel.Font = New Font("Segoe UI", 10F)
        lblCompanyAddressLabel.Location = New Point(20, 110)
        lblCompanyAddressLabel.Name = "lblCompanyAddressLabel"
        lblCompanyAddressLabel.Size = New Size(74, 23)
        lblCompanyAddressLabel.TabIndex = 2
        lblCompanyAddressLabel.Text = "Address:"
        ' 
        ' lblCompanyCityLabel
        ' 
        lblCompanyCityLabel.AutoSize = True
        lblCompanyCityLabel.Font = New Font("Segoe UI", 10F)
        lblCompanyCityLabel.Location = New Point(20, 150)
        lblCompanyCityLabel.Name = "lblCompanyCityLabel"
        lblCompanyCityLabel.Size = New Size(43, 23)
        lblCompanyCityLabel.TabIndex = 3
        lblCompanyCityLabel.Text = "City:"
        ' 
        ' lblCompanyIndustryLabel
        ' 
        lblCompanyIndustryLabel.AutoSize = True
        lblCompanyIndustryLabel.Font = New Font("Segoe UI", 10F)
        lblCompanyIndustryLabel.Location = New Point(20, 190)
        lblCompanyIndustryLabel.Name = "lblCompanyIndustryLabel"
        lblCompanyIndustryLabel.Size = New Size(76, 23)
        lblCompanyIndustryLabel.TabIndex = 4
        lblCompanyIndustryLabel.Text = "Industry:"
        ' 
        ' lblCompanyEmailLabel
        ' 
        lblCompanyEmailLabel.AutoSize = True
        lblCompanyEmailLabel.Font = New Font("Segoe UI", 10F)
        lblCompanyEmailLabel.Location = New Point(20, 230)
        lblCompanyEmailLabel.Name = "lblCompanyEmailLabel"
        lblCompanyEmailLabel.Size = New Size(55, 23)
        lblCompanyEmailLabel.TabIndex = 5
        lblCompanyEmailLabel.Text = "Email:"
        ' 
        ' lblCompanyContactLabel
        ' 
        lblCompanyContactLabel.AutoSize = True
        lblCompanyContactLabel.Font = New Font("Segoe UI", 10F)
        lblCompanyContactLabel.Location = New Point(20, 270)
        lblCompanyContactLabel.Name = "lblCompanyContactLabel"
        lblCompanyContactLabel.Size = New Size(142, 23)
        lblCompanyContactLabel.TabIndex = 6
        lblCompanyContactLabel.Text = "Contact Number:"
        ' 
        ' lblCompanyWebsiteLabel
        ' 
        lblCompanyWebsiteLabel.AutoSize = True
        lblCompanyWebsiteLabel.Font = New Font("Segoe UI", 10F)
        lblCompanyWebsiteLabel.Location = New Point(20, 310)
        lblCompanyWebsiteLabel.Name = "lblCompanyWebsiteLabel"
        lblCompanyWebsiteLabel.Size = New Size(74, 23)
        lblCompanyWebsiteLabel.TabIndex = 7
        lblCompanyWebsiteLabel.Text = "Website:"
        ' 
        ' lblCompanyAccStatusLabel
        ' 
        lblCompanyAccStatusLabel.AutoSize = True
        lblCompanyAccStatusLabel.Font = New Font("Segoe UI", 10F)
        lblCompanyAccStatusLabel.Location = New Point(20, 350)
        lblCompanyAccStatusLabel.Name = "lblCompanyAccStatusLabel"
        lblCompanyAccStatusLabel.Size = New Size(166, 23)
        lblCompanyAccStatusLabel.TabIndex = 8
        lblCompanyAccStatusLabel.Text = "Accreditation Status:"
        ' 
        ' lblCompanyAccDateLabel
        ' 
        lblCompanyAccDateLabel.AutoSize = True
        lblCompanyAccDateLabel.Font = New Font("Segoe UI", 10F)
        lblCompanyAccDateLabel.Location = New Point(20, 390)
        lblCompanyAccDateLabel.Name = "lblCompanyAccDateLabel"
        lblCompanyAccDateLabel.Size = New Size(156, 23)
        lblCompanyAccDateLabel.TabIndex = 9
        lblCompanyAccDateLabel.Text = "Accreditation Date:"
        ' 
        ' txtCompanyName
        ' 
        txtCompanyName.Location = New Point(190, 68)
        txtCompanyName.Name = "txtCompanyName"
        txtCompanyName.Size = New Size(380, 27)
        txtCompanyName.TabIndex = 10
        ' 
        ' txtCompanyAddress
        ' 
        txtCompanyAddress.Location = New Point(190, 108)
        txtCompanyAddress.Name = "txtCompanyAddress"
        txtCompanyAddress.Size = New Size(380, 27)
        txtCompanyAddress.TabIndex = 11
        ' 
        ' cboCompanyCity
        ' 
        cboCompanyCity.DropDownStyle = ComboBoxStyle.DropDownList
        cboCompanyCity.Location = New Point(190, 148)
        cboCompanyCity.Name = "cboCompanyCity"
        cboCompanyCity.Size = New Size(250, 28)
        cboCompanyCity.TabIndex = 12
        ' 
        ' txtCompanyIndustry
        ' 
        txtCompanyIndustry.Location = New Point(190, 188)
        txtCompanyIndustry.Name = "txtCompanyIndustry"
        txtCompanyIndustry.Size = New Size(250, 27)
        txtCompanyIndustry.TabIndex = 13
        ' 
        ' txtCompanyEmail
        ' 
        txtCompanyEmail.Location = New Point(190, 228)
        txtCompanyEmail.Name = "txtCompanyEmail"
        txtCompanyEmail.Size = New Size(250, 27)
        txtCompanyEmail.TabIndex = 14
        ' 
        ' txtCompanyContact
        ' 
        txtCompanyContact.Location = New Point(190, 268)
        txtCompanyContact.Name = "txtCompanyContact"
        txtCompanyContact.Size = New Size(250, 27)
        txtCompanyContact.TabIndex = 15
        ' 
        ' txtCompanyWebsite
        ' 
        txtCompanyWebsite.Location = New Point(190, 308)
        txtCompanyWebsite.Name = "txtCompanyWebsite"
        txtCompanyWebsite.Size = New Size(250, 27)
        txtCompanyWebsite.TabIndex = 16
        ' 
        ' cboCompanyAccreditationStatus
        ' 
        cboCompanyAccreditationStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cboCompanyAccreditationStatus.Items.AddRange(New Object() {"Accredited", "Pending", "Expired", "Revoked"})
        cboCompanyAccreditationStatus.Location = New Point(190, 348)
        cboCompanyAccreditationStatus.Name = "cboCompanyAccreditationStatus"
        cboCompanyAccreditationStatus.Size = New Size(200, 28)
        cboCompanyAccreditationStatus.TabIndex = 17
        ' 
        ' dtpCompanyAccreditationDate
        ' 
        dtpCompanyAccreditationDate.Format = DateTimePickerFormat.Short
        dtpCompanyAccreditationDate.Location = New Point(190, 388)
        dtpCompanyAccreditationDate.Name = "dtpCompanyAccreditationDate"
        dtpCompanyAccreditationDate.Size = New Size(200, 27)
        dtpCompanyAccreditationDate.TabIndex = 18
        ' 
        ' chkCompanyIsActive
        ' 
        chkCompanyIsActive.AutoSize = True
        chkCompanyIsActive.Checked = True
        chkCompanyIsActive.CheckState = CheckState.Checked
        chkCompanyIsActive.Location = New Point(410, 390)
        chkCompanyIsActive.Name = "chkCompanyIsActive"
        chkCompanyIsActive.Size = New Size(72, 24)
        chkCompanyIsActive.TabIndex = 19
        chkCompanyIsActive.Text = "Active"
        ' 
        ' btnCompanySave
        ' 
        btnCompanySave.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnCompanySave.FlatStyle = FlatStyle.Flat
        btnCompanySave.ForeColor = Color.White
        btnCompanySave.Location = New Point(380, 420)
        btnCompanySave.Name = "btnCompanySave"
        btnCompanySave.Size = New Size(100, 30)
        btnCompanySave.TabIndex = 20
        btnCompanySave.Text = "Save"
        btnCompanySave.UseVisualStyleBackColor = False
        ' 
        ' btnCompanyCancel
        ' 
        btnCompanyCancel.BackColor = Color.FromArgb(CByte(189), CByte(189), CByte(189))
        btnCompanyCancel.FlatStyle = FlatStyle.Flat
        btnCompanyCancel.ForeColor = Color.Black
        btnCompanyCancel.Location = New Point(490, 420)
        btnCompanyCancel.Name = "btnCompanyCancel"
        btnCompanyCancel.Size = New Size(100, 30)
        btnCompanyCancel.TabIndex = 21
        btnCompanyCancel.Text = "Cancel"
        btnCompanyCancel.UseVisualStyleBackColor = False
        ' 
        ' pnlGrading
        ' 
        pnlGrading.BackColor = Color.White
        pnlGrading.Controls.Add(btnGRCancel)
        pnlGrading.Controls.Add(btnGREdit)
        pnlGrading.Controls.Add(lblGRReportTitle)
        pnlGrading.Controls.Add(LabelGRSelectStudent)
        pnlGrading.Controls.Add(cboGRStudent)
        pnlGrading.Controls.Add(grpGROverview)
        pnlGrading.Controls.Add(grpGRSupervisor)
        pnlGrading.Controls.Add(grpGRFacultyEval)
        pnlGrading.Controls.Add(grpGRFinal)
        pnlGrading.Controls.Add(LabelGREvalReport)
        pnlGrading.Controls.Add(txtGREvalFile)
        pnlGrading.Controls.Add(btnGRBrowse)
        pnlGrading.Controls.Add(btnGRSave)
        pnlGrading.Controls.Add(btnGRClear)
        pnlGrading.Controls.Add(btnGRGenerateReport)
        pnlGrading.Dock = DockStyle.Fill
        pnlGrading.Location = New Point(0, 0)
        pnlGrading.Name = "pnlGrading"
        pnlGrading.Size = New Size(1321, 1002)
        pnlGrading.TabIndex = 0
        pnlGrading.Visible = False
        ' 
        ' btnGRCancel
        ' 
        btnGRCancel.BackColor = Color.FromArgb(CByte(158), CByte(158), CByte(158))
        btnGRCancel.FlatStyle = FlatStyle.Flat
        btnGRCancel.Font = New Font("Segoe UI", 10F)
        btnGRCancel.ForeColor = Color.White
        btnGRCancel.Location = New Point(186, 795)
        btnGRCancel.Name = "btnGRCancel"
        btnGRCancel.Size = New Size(96, 40)
        btnGRCancel.TabIndex = 52
        btnGRCancel.Text = "Cancel"
        btnGRCancel.UseVisualStyleBackColor = False
        ' 
        ' btnGREdit
        ' 
        btnGREdit.BackColor = Color.FromArgb(CByte(26), CByte(188), CByte(156))
        btnGREdit.FlatStyle = FlatStyle.Flat
        btnGREdit.Font = New Font("Segoe UI", 10F)
        btnGREdit.ForeColor = Color.White
        btnGREdit.Location = New Point(24, 795)
        btnGREdit.Name = "btnGREdit"
        btnGREdit.Size = New Size(150, 40)
        btnGREdit.TabIndex = 51
        btnGREdit.Text = "Edit Final Grade"
        btnGREdit.UseVisualStyleBackColor = False
        ' 
        ' lblGRReportTitle
        ' 
        lblGRReportTitle.AutoSize = True
        lblGRReportTitle.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold)
        lblGRReportTitle.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblGRReportTitle.Location = New Point(25, 25)
        lblGRReportTitle.Name = "lblGRReportTitle"
        lblGRReportTitle.Size = New Size(180, 37)
        lblGRReportTitle.TabIndex = 0
        lblGRReportTitle.Text = "Final Grading"
        ' 
        ' LabelGRSelectStudent
        ' 
        LabelGRSelectStudent.AutoSize = True
        LabelGRSelectStudent.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelGRSelectStudent.Location = New Point(30, 80)
        LabelGRSelectStudent.Name = "LabelGRSelectStudent"
        LabelGRSelectStudent.Size = New Size(126, 23)
        LabelGRSelectStudent.TabIndex = 1
        LabelGRSelectStudent.Text = "Select Trainee:"
        ' 
        ' cboGRStudent
        ' 
        cboGRStudent.DropDownStyle = ComboBoxStyle.DropDownList
        cboGRStudent.Font = New Font("Segoe UI", 10F)
        cboGRStudent.Location = New Point(180, 76)
        cboGRStudent.Name = "cboGRStudent"
        cboGRStudent.Size = New Size(300, 31)
        cboGRStudent.TabIndex = 2
        ' 
        ' grpGROverview
        ' 
        grpGROverview.Controls.Add(lblGROverviewTitle)
        grpGROverview.Controls.Add(LabelGRStudentName)
        grpGROverview.Controls.Add(lblGRStudentName)
        grpGROverview.Controls.Add(LabelGRStudentNumber)
        grpGROverview.Controls.Add(lblGRStudentNumber)
        grpGROverview.Controls.Add(LabelGRCourseSection)
        grpGROverview.Controls.Add(lblGRCourseSection)
        grpGROverview.Controls.Add(LabelGRCompany)
        grpGROverview.Controls.Add(lblGRCompany)
        grpGROverview.Controls.Add(LabelGRSupervisor)
        grpGROverview.Controls.Add(lblGRSupervisor)
        grpGROverview.Controls.Add(LabelGRRequiredHours)
        grpGROverview.Controls.Add(lblGRRequiredHours)
        grpGROverview.Controls.Add(LabelGRCompletedHours)
        grpGROverview.Controls.Add(lblGRCompletedHours)
        grpGROverview.Controls.Add(LabelGRStatus)
        grpGROverview.Controls.Add(lblGRInternshipStatus)
        grpGROverview.Location = New Point(25, 120)
        grpGROverview.Name = "grpGROverview"
        grpGROverview.Size = New Size(480, 272)
        grpGROverview.TabIndex = 3
        grpGROverview.TabStop = False
        ' 
        ' lblGROverviewTitle
        ' 
        lblGROverviewTitle.AutoSize = True
        lblGROverviewTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblGROverviewTitle.Location = New Point(15, 20)
        lblGROverviewTitle.Name = "lblGROverviewTitle"
        lblGROverviewTitle.Size = New Size(191, 25)
        lblGROverviewTitle.TabIndex = 0
        lblGROverviewTitle.Text = "Internship Overview"
        ' 
        ' LabelGRStudentName
        ' 
        LabelGRStudentName.AutoSize = True
        LabelGRStudentName.Font = New Font("Segoe UI", 10F)
        LabelGRStudentName.Location = New Point(20, 60)
        LabelGRStudentName.Name = "LabelGRStudentName"
        LabelGRStudentName.Size = New Size(124, 23)
        LabelGRStudentName.TabIndex = 1
        LabelGRStudentName.Text = "Student Name:"
        ' 
        ' lblGRStudentName
        ' 
        lblGRStudentName.AutoSize = True
        lblGRStudentName.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblGRStudentName.Location = New Point(200, 60)
        lblGRStudentName.Name = "lblGRStudentName"
        lblGRStudentName.Size = New Size(17, 23)
        lblGRStudentName.TabIndex = 2
        lblGRStudentName.Text = "-"
        ' 
        ' LabelGRStudentNumber
        ' 
        LabelGRStudentNumber.AutoSize = True
        LabelGRStudentNumber.Font = New Font("Segoe UI", 10F)
        LabelGRStudentNumber.Location = New Point(20, 90)
        LabelGRStudentNumber.Name = "LabelGRStudentNumber"
        LabelGRStudentNumber.Size = New Size(141, 23)
        LabelGRStudentNumber.TabIndex = 3
        LabelGRStudentNumber.Text = "Student Number:"
        ' 
        ' lblGRStudentNumber
        ' 
        lblGRStudentNumber.AutoSize = True
        lblGRStudentNumber.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblGRStudentNumber.Location = New Point(200, 90)
        lblGRStudentNumber.Name = "lblGRStudentNumber"
        lblGRStudentNumber.Size = New Size(17, 23)
        lblGRStudentNumber.TabIndex = 4
        lblGRStudentNumber.Text = "-"
        ' 
        ' LabelGRCourseSection
        ' 
        LabelGRCourseSection.AutoSize = True
        LabelGRCourseSection.Font = New Font("Segoe UI", 10F)
        LabelGRCourseSection.Location = New Point(20, 120)
        LabelGRCourseSection.Name = "LabelGRCourseSection"
        LabelGRCourseSection.Size = New Size(140, 23)
        LabelGRCourseSection.TabIndex = 5
        LabelGRCourseSection.Text = "Course / Section:"
        ' 
        ' lblGRCourseSection
        ' 
        lblGRCourseSection.AutoSize = True
        lblGRCourseSection.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblGRCourseSection.Location = New Point(200, 120)
        lblGRCourseSection.Name = "lblGRCourseSection"
        lblGRCourseSection.Size = New Size(17, 23)
        lblGRCourseSection.TabIndex = 6
        lblGRCourseSection.Text = "-"
        ' 
        ' LabelGRCompany
        ' 
        LabelGRCompany.AutoSize = True
        LabelGRCompany.Font = New Font("Segoe UI", 10F)
        LabelGRCompany.Location = New Point(20, 150)
        LabelGRCompany.Name = "LabelGRCompany"
        LabelGRCompany.Size = New Size(87, 23)
        LabelGRCompany.TabIndex = 7
        LabelGRCompany.Text = "Company:"
        ' 
        ' lblGRCompany
        ' 
        lblGRCompany.AutoSize = True
        lblGRCompany.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblGRCompany.Location = New Point(200, 150)
        lblGRCompany.Name = "lblGRCompany"
        lblGRCompany.Size = New Size(17, 23)
        lblGRCompany.TabIndex = 8
        lblGRCompany.Text = "-"
        ' 
        ' LabelGRSupervisor
        ' 
        LabelGRSupervisor.AutoSize = True
        LabelGRSupervisor.Font = New Font("Segoe UI", 10F)
        LabelGRSupervisor.Location = New Point(20, 180)
        LabelGRSupervisor.Name = "LabelGRSupervisor"
        LabelGRSupervisor.Size = New Size(93, 23)
        LabelGRSupervisor.TabIndex = 9
        LabelGRSupervisor.Text = "Supervisor:"
        ' 
        ' lblGRSupervisor
        ' 
        lblGRSupervisor.AutoSize = True
        lblGRSupervisor.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblGRSupervisor.Location = New Point(200, 180)
        lblGRSupervisor.Name = "lblGRSupervisor"
        lblGRSupervisor.Size = New Size(17, 23)
        lblGRSupervisor.TabIndex = 10
        lblGRSupervisor.Text = "-"
        ' 
        ' LabelGRRequiredHours
        ' 
        LabelGRRequiredHours.AutoSize = True
        LabelGRRequiredHours.Font = New Font("Segoe UI", 10F)
        LabelGRRequiredHours.Location = New Point(20, 210)
        LabelGRRequiredHours.Name = "LabelGRRequiredHours"
        LabelGRRequiredHours.Size = New Size(132, 23)
        LabelGRRequiredHours.TabIndex = 11
        LabelGRRequiredHours.Text = "Required Hours:"
        ' 
        ' lblGRRequiredHours
        ' 
        lblGRRequiredHours.AutoSize = True
        lblGRRequiredHours.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblGRRequiredHours.Location = New Point(200, 210)
        lblGRRequiredHours.Name = "lblGRRequiredHours"
        lblGRRequiredHours.Size = New Size(17, 23)
        lblGRRequiredHours.TabIndex = 12
        lblGRRequiredHours.Text = "-"
        ' 
        ' LabelGRCompletedHours
        ' 
        LabelGRCompletedHours.AutoSize = True
        LabelGRCompletedHours.Font = New Font("Segoe UI", 10F)
        LabelGRCompletedHours.Location = New Point(20, 240)
        LabelGRCompletedHours.Name = "LabelGRCompletedHours"
        LabelGRCompletedHours.Size = New Size(148, 23)
        LabelGRCompletedHours.TabIndex = 13
        LabelGRCompletedHours.Text = "Completed Hours:"
        ' 
        ' lblGRCompletedHours
        ' 
        lblGRCompletedHours.AutoSize = True
        lblGRCompletedHours.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblGRCompletedHours.Location = New Point(200, 240)
        lblGRCompletedHours.Name = "lblGRCompletedHours"
        lblGRCompletedHours.Size = New Size(17, 23)
        lblGRCompletedHours.TabIndex = 14
        lblGRCompletedHours.Text = "-"
        ' 
        ' LabelGRStatus
        ' 
        LabelGRStatus.AutoSize = True
        LabelGRStatus.Font = New Font("Segoe UI", 10F)
        LabelGRStatus.Location = New Point(20, 270)
        LabelGRStatus.Name = "LabelGRStatus"
        LabelGRStatus.Size = New Size(142, 23)
        LabelGRStatus.TabIndex = 15
        LabelGRStatus.Text = "Internship Status:"
        ' 
        ' lblGRInternshipStatus
        ' 
        lblGRInternshipStatus.AutoSize = True
        lblGRInternshipStatus.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblGRInternshipStatus.Location = New Point(200, 270)
        lblGRInternshipStatus.Name = "lblGRInternshipStatus"
        lblGRInternshipStatus.Size = New Size(17, 23)
        lblGRInternshipStatus.TabIndex = 16
        lblGRInternshipStatus.Text = "-"
        ' 
        ' grpGRSupervisor
        ' 
        grpGRSupervisor.Controls.Add(lblGRSupervisorPanelTitle)
        grpGRSupervisor.Controls.Add(LabelGRSupervisorScore)
        grpGRSupervisor.Controls.Add(lblGRSupervisorScore)
        grpGRSupervisor.Location = New Point(520, 120)
        grpGRSupervisor.Name = "grpGRSupervisor"
        grpGRSupervisor.Size = New Size(250, 140)
        grpGRSupervisor.TabIndex = 4
        grpGRSupervisor.TabStop = False
        ' 
        ' lblGRSupervisorPanelTitle
        ' 
        lblGRSupervisorPanelTitle.AutoSize = True
        lblGRSupervisorPanelTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblGRSupervisorPanelTitle.Location = New Point(20, 20)
        lblGRSupervisorPanelTitle.Name = "lblGRSupervisorPanelTitle"
        lblGRSupervisorPanelTitle.Size = New Size(215, 25)
        lblGRSupervisorPanelTitle.TabIndex = 0
        lblGRSupervisorPanelTitle.Text = "Supervisor Final Grade"
        ' 
        ' LabelGRSupervisorScore
        ' 
        LabelGRSupervisorScore.AutoSize = True
        LabelGRSupervisorScore.Font = New Font("Segoe UI", 10F)
        LabelGRSupervisorScore.Location = New Point(20, 60)
        LabelGRSupervisorScore.Name = "LabelGRSupervisorScore"
        LabelGRSupervisorScore.Size = New Size(60, 23)
        LabelGRSupervisorScore.TabIndex = 1
        LabelGRSupervisorScore.Text = "Grade:"
        ' 
        ' lblGRSupervisorScore
        ' 
        lblGRSupervisorScore.AutoSize = True
        lblGRSupervisorScore.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblGRSupervisorScore.ForeColor = Color.FromArgb(CByte(30), CByte(136), CByte(229))
        lblGRSupervisorScore.Location = New Point(90, 60)
        lblGRSupervisorScore.Name = "lblGRSupervisorScore"
        lblGRSupervisorScore.Size = New Size(20, 28)
        lblGRSupervisorScore.TabIndex = 2
        lblGRSupervisorScore.Text = "-"
        ' 
        ' grpGRFacultyEval
        ' 
        grpGRFacultyEval.Controls.Add(lblGRFacultyEvalTitle)
        grpGRFacultyEval.Controls.Add(LabelGRF_Tech)
        grpGRFacultyEval.Controls.Add(cboGRF_Tech)
        grpGRFacultyEval.Controls.Add(LabelGRF_Professionalism)
        grpGRFacultyEval.Controls.Add(cboGRF_Professionalism)
        grpGRFacultyEval.Controls.Add(LabelGRF_Communication)
        grpGRFacultyEval.Controls.Add(cboGRF_Communication)
        grpGRFacultyEval.Controls.Add(LabelGRF_Attendance)
        grpGRFacultyEval.Controls.Add(cboGRF_Attendance)
        grpGRFacultyEval.Controls.Add(LabelGRF_OutputQuality)
        grpGRFacultyEval.Controls.Add(cboGRF_OutputQuality)
        grpGRFacultyEval.Controls.Add(LabelGRF_FinalInterview)
        grpGRFacultyEval.Controls.Add(cboGRF_FinalInterview)
        grpGRFacultyEval.Controls.Add(LabelGRFacultyTotal)
        grpGRFacultyEval.Controls.Add(lblGRFacultyTotal)
        grpGRFacultyEval.Location = New Point(25, 400)
        grpGRFacultyEval.Name = "grpGRFacultyEval"
        grpGRFacultyEval.Size = New Size(380, 320)
        grpGRFacultyEval.TabIndex = 5
        grpGRFacultyEval.TabStop = False
        ' 
        ' lblGRFacultyEvalTitle
        ' 
        lblGRFacultyEvalTitle.AutoSize = True
        lblGRFacultyEvalTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblGRFacultyEvalTitle.Location = New Point(15, 20)
        lblGRFacultyEvalTitle.Name = "lblGRFacultyEvalTitle"
        lblGRFacultyEvalTitle.Size = New Size(307, 25)
        lblGRFacultyEvalTitle.TabIndex = 0
        lblGRFacultyEvalTitle.Text = "Faculty Performance Rating (1–5)"
        ' 
        ' LabelGRF_Tech
        ' 
        LabelGRF_Tech.AutoSize = True
        LabelGRF_Tech.Font = New Font("Segoe UI", 10F)
        LabelGRF_Tech.Location = New Point(20, 60)
        LabelGRF_Tech.Name = "LabelGRF_Tech"
        LabelGRF_Tech.Size = New Size(124, 23)
        LabelGRF_Tech.TabIndex = 1
        LabelGRF_Tech.Text = "Technical Skills:"
        ' 
        ' cboGRF_Tech
        ' 
        cboGRF_Tech.DropDownStyle = ComboBoxStyle.DropDownList
        cboGRF_Tech.Font = New Font("Segoe UI", 10F)
        cboGRF_Tech.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cboGRF_Tech.Location = New Point(220, 56)
        cboGRF_Tech.Name = "cboGRF_Tech"
        cboGRF_Tech.Size = New Size(100, 31)
        cboGRF_Tech.TabIndex = 2
        ' 
        ' LabelGRF_Professionalism
        ' 
        LabelGRF_Professionalism.AutoSize = True
        LabelGRF_Professionalism.Font = New Font("Segoe UI", 10F)
        LabelGRF_Professionalism.Location = New Point(20, 95)
        LabelGRF_Professionalism.Name = "LabelGRF_Professionalism"
        LabelGRF_Professionalism.Size = New Size(131, 23)
        LabelGRF_Professionalism.TabIndex = 3
        LabelGRF_Professionalism.Text = "Professionalism:"
        ' 
        ' cboGRF_Professionalism
        ' 
        cboGRF_Professionalism.DropDownStyle = ComboBoxStyle.DropDownList
        cboGRF_Professionalism.Font = New Font("Segoe UI", 10F)
        cboGRF_Professionalism.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cboGRF_Professionalism.Location = New Point(220, 92)
        cboGRF_Professionalism.Name = "cboGRF_Professionalism"
        cboGRF_Professionalism.Size = New Size(100, 31)
        cboGRF_Professionalism.TabIndex = 4
        ' 
        ' LabelGRF_Communication
        ' 
        LabelGRF_Communication.AutoSize = True
        LabelGRF_Communication.Font = New Font("Segoe UI", 10F)
        LabelGRF_Communication.Location = New Point(20, 130)
        LabelGRF_Communication.Name = "LabelGRF_Communication"
        LabelGRF_Communication.Size = New Size(136, 23)
        LabelGRF_Communication.TabIndex = 5
        LabelGRF_Communication.Text = "Communication:"
        ' 
        ' cboGRF_Communication
        ' 
        cboGRF_Communication.DropDownStyle = ComboBoxStyle.DropDownList
        cboGRF_Communication.Font = New Font("Segoe UI", 10F)
        cboGRF_Communication.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cboGRF_Communication.Location = New Point(220, 126)
        cboGRF_Communication.Name = "cboGRF_Communication"
        cboGRF_Communication.Size = New Size(100, 31)
        cboGRF_Communication.TabIndex = 6
        ' 
        ' LabelGRF_Attendance
        ' 
        LabelGRF_Attendance.AutoSize = True
        LabelGRF_Attendance.Font = New Font("Segoe UI", 10F)
        LabelGRF_Attendance.Location = New Point(20, 165)
        LabelGRF_Attendance.Name = "LabelGRF_Attendance"
        LabelGRF_Attendance.Size = New Size(102, 23)
        LabelGRF_Attendance.TabIndex = 7
        LabelGRF_Attendance.Text = "Attendance:"
        ' 
        ' cboGRF_Attendance
        ' 
        cboGRF_Attendance.DropDownStyle = ComboBoxStyle.DropDownList
        cboGRF_Attendance.Font = New Font("Segoe UI", 10F)
        cboGRF_Attendance.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cboGRF_Attendance.Location = New Point(220, 162)
        cboGRF_Attendance.Name = "cboGRF_Attendance"
        cboGRF_Attendance.Size = New Size(100, 31)
        cboGRF_Attendance.TabIndex = 8
        ' 
        ' LabelGRF_OutputQuality
        ' 
        LabelGRF_OutputQuality.AutoSize = True
        LabelGRF_OutputQuality.Font = New Font("Segoe UI", 10F)
        LabelGRF_OutputQuality.Location = New Point(20, 200)
        LabelGRF_OutputQuality.Name = "LabelGRF_OutputQuality"
        LabelGRF_OutputQuality.Size = New Size(128, 23)
        LabelGRF_OutputQuality.TabIndex = 9
        LabelGRF_OutputQuality.Text = "Output Quality:"
        ' 
        ' cboGRF_OutputQuality
        ' 
        cboGRF_OutputQuality.DropDownStyle = ComboBoxStyle.DropDownList
        cboGRF_OutputQuality.Font = New Font("Segoe UI", 10F)
        cboGRF_OutputQuality.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cboGRF_OutputQuality.Location = New Point(220, 197)
        cboGRF_OutputQuality.Name = "cboGRF_OutputQuality"
        cboGRF_OutputQuality.Size = New Size(100, 31)
        cboGRF_OutputQuality.TabIndex = 10
        ' 
        ' LabelGRF_FinalInterview
        ' 
        LabelGRF_FinalInterview.AutoSize = True
        LabelGRF_FinalInterview.Font = New Font("Segoe UI", 10F)
        LabelGRF_FinalInterview.Location = New Point(20, 235)
        LabelGRF_FinalInterview.Name = "LabelGRF_FinalInterview"
        LabelGRF_FinalInterview.Size = New Size(123, 23)
        LabelGRF_FinalInterview.TabIndex = 11
        LabelGRF_FinalInterview.Text = "Final Interview:"
        ' 
        ' cboGRF_FinalInterview
        ' 
        cboGRF_FinalInterview.DropDownStyle = ComboBoxStyle.DropDownList
        cboGRF_FinalInterview.Font = New Font("Segoe UI", 10F)
        cboGRF_FinalInterview.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cboGRF_FinalInterview.Location = New Point(220, 232)
        cboGRF_FinalInterview.Name = "cboGRF_FinalInterview"
        cboGRF_FinalInterview.Size = New Size(100, 31)
        cboGRF_FinalInterview.TabIndex = 12
        ' 
        ' LabelGRFacultyTotal
        ' 
        LabelGRFacultyTotal.AutoSize = True
        LabelGRFacultyTotal.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelGRFacultyTotal.Location = New Point(20, 275)
        LabelGRFacultyTotal.Name = "LabelGRFacultyTotal"
        LabelGRFacultyTotal.Size = New Size(124, 23)
        LabelGRFacultyTotal.TabIndex = 13
        LabelGRFacultyTotal.Text = "Faculty Grade:"
        ' 
        ' lblGRFacultyTotal
        ' 
        lblGRFacultyTotal.AutoSize = True
        lblGRFacultyTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblGRFacultyTotal.ForeColor = Color.FromArgb(CByte(30), CByte(136), CByte(229))
        lblGRFacultyTotal.Location = New Point(150, 275)
        lblGRFacultyTotal.Name = "lblGRFacultyTotal"
        lblGRFacultyTotal.Size = New Size(20, 28)
        lblGRFacultyTotal.TabIndex = 14
        lblGRFacultyTotal.Text = "-"
        ' 
        ' grpGRFinal
        ' 
        grpGRFinal.Controls.Add(lblGRFinalCompTitle)
        grpGRFinal.Controls.Add(LabelGRFGSupervisor)
        grpGRFinal.Controls.Add(lblGRFGSupervisor)
        grpGRFinal.Controls.Add(LabelGRFGFaculty)
        grpGRFinal.Controls.Add(lblGRFGFaculty)
        grpGRFinal.Controls.Add(LabelGRFinalGrade)
        grpGRFinal.Controls.Add(lblGRFinalGradeAuto)
        grpGRFinal.Location = New Point(420, 400)
        grpGRFinal.Name = "grpGRFinal"
        grpGRFinal.Size = New Size(350, 250)
        grpGRFinal.TabIndex = 6
        grpGRFinal.TabStop = False
        ' 
        ' lblGRFinalCompTitle
        ' 
        lblGRFinalCompTitle.AutoSize = True
        lblGRFinalCompTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblGRFinalCompTitle.Location = New Point(15, 20)
        lblGRFinalCompTitle.Name = "lblGRFinalCompTitle"
        lblGRFinalCompTitle.Size = New Size(236, 25)
        lblGRFinalCompTitle.TabIndex = 0
        lblGRFinalCompTitle.Text = "Final Grade Computation"
        ' 
        ' LabelGRFGSupervisor
        ' 
        LabelGRFGSupervisor.AutoSize = True
        LabelGRFGSupervisor.Font = New Font("Segoe UI", 10F)
        LabelGRFGSupervisor.Location = New Point(20, 60)
        LabelGRFGSupervisor.Name = "LabelGRFGSupervisor"
        LabelGRFGSupervisor.Size = New Size(144, 23)
        LabelGRFGSupervisor.TabIndex = 1
        LabelGRFGSupervisor.Text = "Supervisor Grade:"
        ' 
        ' lblGRFGSupervisor
        ' 
        lblGRFGSupervisor.AutoSize = True
        lblGRFGSupervisor.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblGRFGSupervisor.Location = New Point(200, 60)
        lblGRFGSupervisor.Name = "lblGRFGSupervisor"
        lblGRFGSupervisor.Size = New Size(20, 25)
        lblGRFGSupervisor.TabIndex = 2
        lblGRFGSupervisor.Text = "-"
        ' 
        ' LabelGRFGFaculty
        ' 
        LabelGRFGFaculty.AutoSize = True
        LabelGRFGFaculty.Font = New Font("Segoe UI", 10F)
        LabelGRFGFaculty.Location = New Point(20, 100)
        LabelGRFGFaculty.Name = "LabelGRFGFaculty"
        LabelGRFGFaculty.Size = New Size(117, 23)
        LabelGRFGFaculty.TabIndex = 3
        LabelGRFGFaculty.Text = "Faculty Grade:"
        ' 
        ' lblGRFGFaculty
        ' 
        lblGRFGFaculty.AutoSize = True
        lblGRFGFaculty.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblGRFGFaculty.Location = New Point(200, 100)
        lblGRFGFaculty.Name = "lblGRFGFaculty"
        lblGRFGFaculty.Size = New Size(20, 25)
        lblGRFGFaculty.TabIndex = 4
        lblGRFGFaculty.Text = "-"
        ' 
        ' LabelGRFinalGrade
        ' 
        LabelGRFinalGrade.AutoSize = True
        LabelGRFinalGrade.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        LabelGRFinalGrade.Location = New Point(20, 145)
        LabelGRFinalGrade.Name = "LabelGRFinalGrade"
        LabelGRFinalGrade.Size = New Size(139, 25)
        LabelGRFinalGrade.TabIndex = 5
        LabelGRFinalGrade.Text = "FINAL GRADE:"
        ' 
        ' lblGRFinalGradeAuto
        ' 
        lblGRFinalGradeAuto.AutoSize = True
        lblGRFinalGradeAuto.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblGRFinalGradeAuto.ForeColor = Color.FromArgb(CByte(67), CByte(160), CByte(71))
        lblGRFinalGradeAuto.Location = New Point(180, 145)
        lblGRFinalGradeAuto.Name = "lblGRFinalGradeAuto"
        lblGRFinalGradeAuto.Size = New Size(24, 32)
        lblGRFinalGradeAuto.TabIndex = 6
        lblGRFinalGradeAuto.Text = "-"
        ' 
        ' LabelGREvalReport
        ' 
        LabelGREvalReport.AutoSize = True
        LabelGREvalReport.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelGREvalReport.Location = New Point(25, 740)
        LabelGREvalReport.Name = "LabelGREvalReport"
        LabelGREvalReport.Size = New Size(201, 23)
        LabelGREvalReport.TabIndex = 7
        LabelGREvalReport.Text = "Final Evaluation Report:"
        ' 
        ' txtGREvalFile
        ' 
        txtGREvalFile.Font = New Font("Segoe UI", 10F)
        txtGREvalFile.Location = New Point(230, 735)
        txtGREvalFile.Name = "txtGREvalFile"
        txtGREvalFile.Size = New Size(350, 30)
        txtGREvalFile.TabIndex = 8
        ' 
        ' btnGRBrowse
        ' 
        btnGRBrowse.BackColor = Color.FromArgb(CByte(120), CByte(144), CByte(156))
        btnGRBrowse.FlatStyle = FlatStyle.Flat
        btnGRBrowse.Font = New Font("Segoe UI", 10F)
        btnGRBrowse.ForeColor = Color.White
        btnGRBrowse.Location = New Point(590, 734)
        btnGRBrowse.Name = "btnGRBrowse"
        btnGRBrowse.Size = New Size(90, 32)
        btnGRBrowse.TabIndex = 9
        btnGRBrowse.Text = "Browse"
        btnGRBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnGRSave
        ' 
        btnGRSave.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnGRSave.FlatStyle = FlatStyle.Flat
        btnGRSave.Font = New Font("Segoe UI", 10F)
        btnGRSave.ForeColor = Color.White
        btnGRSave.Location = New Point(297, 795)
        btnGRSave.Name = "btnGRSave"
        btnGRSave.Size = New Size(150, 40)
        btnGRSave.TabIndex = 10
        btnGRSave.Text = "Save Final Grade"
        btnGRSave.UseVisualStyleBackColor = False
        ' 
        ' btnGRClear
        ' 
        btnGRClear.BackColor = Color.FromArgb(CByte(189), CByte(189), CByte(189))
        btnGRClear.FlatStyle = FlatStyle.Flat
        btnGRClear.Font = New Font("Segoe UI", 10F)
        btnGRClear.Location = New Point(711, 795)
        btnGRClear.Name = "btnGRClear"
        btnGRClear.Size = New Size(100, 40)
        btnGRClear.TabIndex = 11
        btnGRClear.Text = "Clear"
        btnGRClear.UseVisualStyleBackColor = False
        ' 
        ' btnGRGenerateReport
        ' 
        btnGRGenerateReport.BackColor = Color.FromArgb(CByte(33), CByte(150), CByte(243))
        btnGRGenerateReport.FlatAppearance.BorderSize = 0
        btnGRGenerateReport.FlatStyle = FlatStyle.Flat
        btnGRGenerateReport.Font = New Font("Segoe UI", 10F)
        btnGRGenerateReport.ForeColor = Color.White
        btnGRGenerateReport.Location = New Point(471, 795)
        btnGRGenerateReport.Name = "btnGRGenerateReport"
        btnGRGenerateReport.Size = New Size(230, 40)
        btnGRGenerateReport.TabIndex = 50
        btnGRGenerateReport.Text = "Print Final Evaluation Report"
        btnGRGenerateReport.UseVisualStyleBackColor = False
        ' 
        ' pnlVisitLogs
        ' 
        pnlVisitLogs.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        pnlVisitLogs.Controls.Add(Label2)
        pnlVisitLogs.Controls.Add(Label1)
        pnlVisitLogs.Controls.Add(lblVisitLogsTitle)
        pnlVisitLogs.Controls.Add(LabelVLSelectInternship)
        pnlVisitLogs.Controls.Add(cboVLInternship)
        pnlVisitLogs.Controls.Add(LabelVLStudentName)
        pnlVisitLogs.Controls.Add(lblVLStudentName)
        pnlVisitLogs.Controls.Add(LabelVLStudentNumber)
        pnlVisitLogs.Controls.Add(lblVLStudentNumber)
        pnlVisitLogs.Controls.Add(LabelVLCourseSection)
        pnlVisitLogs.Controls.Add(lblVLCourseSection)
        pnlVisitLogs.Controls.Add(LabelVLCompany)
        pnlVisitLogs.Controls.Add(lblVLCompany)
        pnlVisitLogs.Controls.Add(LabelVLSupervisor)
        pnlVisitLogs.Controls.Add(lblVLSupervisor)
        pnlVisitLogs.Controls.Add(LabelVLVisitDate)
        pnlVisitLogs.Controls.Add(dtpVLDate)
        pnlVisitLogs.Controls.Add(LabelVLVisitType)
        pnlVisitLogs.Controls.Add(cboVLVisitType)
        pnlVisitLogs.Controls.Add(LabelVLTech)
        pnlVisitLogs.Controls.Add(cboVLTech)
        pnlVisitLogs.Controls.Add(LabelVLComm)
        pnlVisitLogs.Controls.Add(cboVLComm)
        pnlVisitLogs.Controls.Add(LabelVLBehavior)
        pnlVisitLogs.Controls.Add(cboVLBehavior)
        pnlVisitLogs.Controls.Add(LabelVLAttendance)
        pnlVisitLogs.Controls.Add(cboVLAttendance)
        pnlVisitLogs.Controls.Add(LabelVLQuality)
        pnlVisitLogs.Controls.Add(cboVLQuality)
        pnlVisitLogs.Controls.Add(LabelVLOutputOverall)
        pnlVisitLogs.Controls.Add(lblVLOverallScore)
        pnlVisitLogs.Controls.Add(LabelVLHoursRendered)
        pnlVisitLogs.Controls.Add(txtVLHoursRendered)
        pnlVisitLogs.Controls.Add(LabelVLRemarks)
        pnlVisitLogs.Controls.Add(txtVLRemarks)
        pnlVisitLogs.Controls.Add(LabelVLAttachment)
        pnlVisitLogs.Controls.Add(txtVLAttachment)
        pnlVisitLogs.Controls.Add(btnVLBrowse)
        pnlVisitLogs.Controls.Add(btnVLSave)
        pnlVisitLogs.Controls.Add(btnVLGenerateVisitLog)
        pnlVisitLogs.Controls.Add(btnVLCancel)
        pnlVisitLogs.Controls.Add(dgvVisitLogs)
        pnlVisitLogs.Controls.Add(lblVLStatus)
        pnlVisitLogs.Controls.Add(cboVLStatusFilter)
        pnlVisitLogs.Dock = DockStyle.Fill
        pnlVisitLogs.Location = New Point(0, 0)
        pnlVisitLogs.Margin = New Padding(3, 4, 3, 4)
        pnlVisitLogs.Name = "pnlVisitLogs"
        pnlVisitLogs.Size = New Size(1321, 1002)
        pnlVisitLogs.TabIndex = 3
        pnlVisitLogs.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.Location = New Point(828, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(289, 23)
        Label2.TabIndex = 41
        Label2.Text = "PERFORMANCE EVALUATION (1–5)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label1.Location = New Point(696, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(543, 23)
        Label1.TabIndex = 40
        Label1.Text = " 1 = Very Poor  2 = Poor  3 = Satisfactory   4 = Good  5 = Excellent"
        ' 
        ' lblVisitLogsTitle
        ' 
        lblVisitLogsTitle.AutoSize = True
        lblVisitLogsTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblVisitLogsTitle.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblVisitLogsTitle.Location = New Point(24, 30)
        lblVisitLogsTitle.Name = "lblVisitLogsTitle"
        lblVisitLogsTitle.Size = New Size(117, 32)
        lblVisitLogsTitle.TabIndex = 0
        lblVisitLogsTitle.Text = "Visit Logs"
        ' 
        ' LabelVLSelectInternship
        ' 
        LabelVLSelectInternship.AutoSize = True
        LabelVLSelectInternship.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelVLSelectInternship.Location = New Point(27, 117)
        LabelVLSelectInternship.Name = "LabelVLSelectInternship"
        LabelVLSelectInternship.Size = New Size(126, 23)
        LabelVLSelectInternship.TabIndex = 1
        LabelVLSelectInternship.Text = "Select Trainee:"
        ' 
        ' cboVLInternship
        ' 
        cboVLInternship.DropDownStyle = ComboBoxStyle.DropDownList
        cboVLInternship.Font = New Font("Segoe UI", 10F)
        cboVLInternship.Location = New Point(199, 115)
        cboVLInternship.Margin = New Padding(3, 4, 3, 4)
        cboVLInternship.Name = "cboVLInternship"
        cboVLInternship.Size = New Size(238, 31)
        cboVLInternship.TabIndex = 2
        ' 
        ' LabelVLStudentName
        ' 
        LabelVLStudentName.AutoSize = True
        LabelVLStudentName.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelVLStudentName.Location = New Point(28, 185)
        LabelVLStudentName.Name = "LabelVLStudentName"
        LabelVLStudentName.Size = New Size(131, 23)
        LabelVLStudentName.TabIndex = 3
        LabelVLStudentName.Text = "Student Name:"
        ' 
        ' lblVLStudentName
        ' 
        lblVLStudentName.AutoSize = True
        lblVLStudentName.Font = New Font("Segoe UI", 10F)
        lblVLStudentName.Location = New Point(200, 185)
        lblVLStudentName.Name = "lblVLStudentName"
        lblVLStudentName.Size = New Size(0, 23)
        lblVLStudentName.TabIndex = 4
        ' 
        ' LabelVLStudentNumber
        ' 
        LabelVLStudentNumber.AutoSize = True
        LabelVLStudentNumber.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelVLStudentNumber.Location = New Point(28, 215)
        LabelVLStudentNumber.Name = "LabelVLStudentNumber"
        LabelVLStudentNumber.Size = New Size(151, 23)
        LabelVLStudentNumber.TabIndex = 5
        LabelVLStudentNumber.Text = "Student Number:"
        ' 
        ' lblVLStudentNumber
        ' 
        lblVLStudentNumber.AutoSize = True
        lblVLStudentNumber.Font = New Font("Segoe UI", 10F)
        lblVLStudentNumber.Location = New Point(200, 215)
        lblVLStudentNumber.Name = "lblVLStudentNumber"
        lblVLStudentNumber.Size = New Size(0, 23)
        lblVLStudentNumber.TabIndex = 6
        ' 
        ' LabelVLCourseSection
        ' 
        LabelVLCourseSection.AutoSize = True
        LabelVLCourseSection.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelVLCourseSection.Location = New Point(28, 245)
        LabelVLCourseSection.Name = "LabelVLCourseSection"
        LabelVLCourseSection.Size = New Size(146, 23)
        LabelVLCourseSection.TabIndex = 7
        LabelVLCourseSection.Text = "Course / Section:"
        ' 
        ' lblVLCourseSection
        ' 
        lblVLCourseSection.AutoSize = True
        lblVLCourseSection.Font = New Font("Segoe UI", 10F)
        lblVLCourseSection.Location = New Point(200, 245)
        lblVLCourseSection.Name = "lblVLCourseSection"
        lblVLCourseSection.Size = New Size(0, 23)
        lblVLCourseSection.TabIndex = 8
        ' 
        ' LabelVLCompany
        ' 
        LabelVLCompany.AutoSize = True
        LabelVLCompany.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelVLCompany.Location = New Point(28, 275)
        LabelVLCompany.Name = "LabelVLCompany"
        LabelVLCompany.Size = New Size(91, 23)
        LabelVLCompany.TabIndex = 9
        LabelVLCompany.Text = "Company:"
        ' 
        ' lblVLCompany
        ' 
        lblVLCompany.AutoSize = True
        lblVLCompany.Font = New Font("Segoe UI", 10F)
        lblVLCompany.Location = New Point(200, 275)
        lblVLCompany.Name = "lblVLCompany"
        lblVLCompany.Size = New Size(0, 23)
        lblVLCompany.TabIndex = 10
        ' 
        ' LabelVLSupervisor
        ' 
        LabelVLSupervisor.AutoSize = True
        LabelVLSupervisor.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelVLSupervisor.Location = New Point(28, 305)
        LabelVLSupervisor.Name = "LabelVLSupervisor"
        LabelVLSupervisor.Size = New Size(102, 23)
        LabelVLSupervisor.TabIndex = 11
        LabelVLSupervisor.Text = "Supervisor:"
        ' 
        ' lblVLSupervisor
        ' 
        lblVLSupervisor.AutoSize = True
        lblVLSupervisor.Font = New Font("Segoe UI", 10F)
        lblVLSupervisor.Location = New Point(200, 305)
        lblVLSupervisor.Name = "lblVLSupervisor"
        lblVLSupervisor.Size = New Size(0, 23)
        lblVLSupervisor.TabIndex = 12
        ' 
        ' LabelVLVisitDate
        ' 
        LabelVLVisitDate.AutoSize = True
        LabelVLVisitDate.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelVLVisitDate.Location = New Point(28, 340)
        LabelVLVisitDate.Name = "LabelVLVisitDate"
        LabelVLVisitDate.Size = New Size(93, 23)
        LabelVLVisitDate.TabIndex = 13
        LabelVLVisitDate.Text = "Visit Date:"
        ' 
        ' dtpVLDate
        ' 
        dtpVLDate.Font = New Font("Segoe UI", 10F)
        dtpVLDate.Location = New Point(200, 337)
        dtpVLDate.Name = "dtpVLDate"
        dtpVLDate.Size = New Size(200, 30)
        dtpVLDate.TabIndex = 14
        ' 
        ' LabelVLVisitType
        ' 
        LabelVLVisitType.AutoSize = True
        LabelVLVisitType.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelVLVisitType.Location = New Point(28, 375)
        LabelVLVisitType.Name = "LabelVLVisitType"
        LabelVLVisitType.Size = New Size(93, 23)
        LabelVLVisitType.TabIndex = 15
        LabelVLVisitType.Text = "Visit Type:"
        ' 
        ' cboVLVisitType
        ' 
        cboVLVisitType.DropDownStyle = ComboBoxStyle.DropDownList
        cboVLVisitType.Font = New Font("Segoe UI", 10F)
        cboVLVisitType.Items.AddRange(New Object() {"Initial", "Midterm", "Final"})
        cboVLVisitType.Location = New Point(200, 372)
        cboVLVisitType.Name = "cboVLVisitType"
        cboVLVisitType.Size = New Size(200, 31)
        cboVLVisitType.TabIndex = 16
        ' 
        ' LabelVLTech
        ' 
        LabelVLTech.AutoSize = True
        LabelVLTech.Font = New Font("Segoe UI", 10F)
        LabelVLTech.Location = New Point(696, 195)
        LabelVLTech.Name = "LabelVLTech"
        LabelVLTech.Size = New Size(124, 23)
        LabelVLTech.TabIndex = 17
        LabelVLTech.Text = "Technical Skills:"
        ' 
        ' cboVLTech
        ' 
        cboVLTech.DropDownStyle = ComboBoxStyle.DropDownList
        cboVLTech.Font = New Font("Segoe UI", 10F)
        cboVLTech.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cboVLTech.Location = New Point(918, 192)
        cboVLTech.Name = "cboVLTech"
        cboVLTech.Size = New Size(80, 31)
        cboVLTech.TabIndex = 18
        ' 
        ' LabelVLComm
        ' 
        LabelVLComm.AutoSize = True
        LabelVLComm.Font = New Font("Segoe UI", 10F)
        LabelVLComm.Location = New Point(696, 225)
        LabelVLComm.Name = "LabelVLComm"
        LabelVLComm.Size = New Size(177, 23)
        LabelVLComm.TabIndex = 19
        LabelVLComm.Text = "Communication Skills:"
        ' 
        ' cboVLComm
        ' 
        cboVLComm.DropDownStyle = ComboBoxStyle.DropDownList
        cboVLComm.Font = New Font("Segoe UI", 10F)
        cboVLComm.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cboVLComm.Location = New Point(918, 222)
        cboVLComm.Name = "cboVLComm"
        cboVLComm.Size = New Size(80, 31)
        cboVLComm.TabIndex = 20
        ' 
        ' LabelVLBehavior
        ' 
        LabelVLBehavior.AutoSize = True
        LabelVLBehavior.Font = New Font("Segoe UI", 10F)
        LabelVLBehavior.Location = New Point(696, 255)
        LabelVLBehavior.Name = "LabelVLBehavior"
        LabelVLBehavior.Size = New Size(176, 23)
        LabelVLBehavior.TabIndex = 21
        LabelVLBehavior.Text = "Professional Behavior:"
        ' 
        ' cboVLBehavior
        ' 
        cboVLBehavior.DropDownStyle = ComboBoxStyle.DropDownList
        cboVLBehavior.Font = New Font("Segoe UI", 10F)
        cboVLBehavior.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cboVLBehavior.Location = New Point(918, 252)
        cboVLBehavior.Name = "cboVLBehavior"
        cboVLBehavior.Size = New Size(80, 31)
        cboVLBehavior.TabIndex = 22
        ' 
        ' LabelVLAttendance
        ' 
        LabelVLAttendance.AutoSize = True
        LabelVLAttendance.Font = New Font("Segoe UI", 10F)
        LabelVLAttendance.Location = New Point(696, 285)
        LabelVLAttendance.Name = "LabelVLAttendance"
        LabelVLAttendance.Size = New Size(197, 23)
        LabelVLAttendance.TabIndex = 23
        LabelVLAttendance.Text = "Attendance / Timeliness:"
        ' 
        ' cboVLAttendance
        ' 
        cboVLAttendance.DropDownStyle = ComboBoxStyle.DropDownList
        cboVLAttendance.Font = New Font("Segoe UI", 10F)
        cboVLAttendance.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cboVLAttendance.Location = New Point(918, 282)
        cboVLAttendance.Name = "cboVLAttendance"
        cboVLAttendance.Size = New Size(80, 31)
        cboVLAttendance.TabIndex = 24
        ' 
        ' LabelVLQuality
        ' 
        LabelVLQuality.AutoSize = True
        LabelVLQuality.Font = New Font("Segoe UI", 10F)
        LabelVLQuality.Location = New Point(696, 315)
        LabelVLQuality.Name = "LabelVLQuality"
        LabelVLQuality.Size = New Size(192, 23)
        LabelVLQuality.TabIndex = 25
        LabelVLQuality.Text = "Quality of Work Output:"
        ' 
        ' cboVLQuality
        ' 
        cboVLQuality.DropDownStyle = ComboBoxStyle.DropDownList
        cboVLQuality.Font = New Font("Segoe UI", 10F)
        cboVLQuality.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cboVLQuality.Location = New Point(918, 312)
        cboVLQuality.Name = "cboVLQuality"
        cboVLQuality.Size = New Size(80, 31)
        cboVLQuality.TabIndex = 26
        ' 
        ' LabelVLOutputOverall
        ' 
        LabelVLOutputOverall.AutoSize = True
        LabelVLOutputOverall.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelVLOutputOverall.Location = New Point(696, 350)
        LabelVLOutputOverall.Name = "LabelVLOutputOverall"
        LabelVLOutputOverall.Size = New Size(178, 23)
        LabelVLOutputOverall.TabIndex = 27
        LabelVLOutputOverall.Text = "Overall Performance:"
        ' 
        ' lblVLOverallScore
        ' 
        lblVLOverallScore.AutoSize = True
        lblVLOverallScore.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblVLOverallScore.ForeColor = Color.DarkBlue
        lblVLOverallScore.Location = New Point(918, 350)
        lblVLOverallScore.Name = "lblVLOverallScore"
        lblVLOverallScore.Size = New Size(50, 25)
        lblVLOverallScore.TabIndex = 28
        lblVLOverallScore.Text = "0.00"
        ' 
        ' LabelVLHoursRendered
        ' 
        LabelVLHoursRendered.AutoSize = True
        LabelVLHoursRendered.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelVLHoursRendered.Location = New Point(696, 380)
        LabelVLHoursRendered.Name = "LabelVLHoursRendered"
        LabelVLHoursRendered.Size = New Size(221, 23)
        LabelVLHoursRendered.TabIndex = 29
        LabelVLHoursRendered.Text = "Hours Rendered This Visit:"
        ' 
        ' txtVLHoursRendered
        ' 
        txtVLHoursRendered.Font = New Font("Segoe UI", 10F)
        txtVLHoursRendered.Location = New Point(918, 377)
        txtVLHoursRendered.Name = "txtVLHoursRendered"
        txtVLHoursRendered.Size = New Size(120, 30)
        txtVLHoursRendered.TabIndex = 30
        ' 
        ' LabelVLRemarks
        ' 
        LabelVLRemarks.AutoSize = True
        LabelVLRemarks.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelVLRemarks.Location = New Point(28, 435)
        LabelVLRemarks.Name = "LabelVLRemarks"
        LabelVLRemarks.Size = New Size(84, 23)
        LabelVLRemarks.TabIndex = 31
        LabelVLRemarks.Text = "Remarks:"
        ' 
        ' txtVLRemarks
        ' 
        txtVLRemarks.Font = New Font("Segoe UI", 10F)
        txtVLRemarks.Location = New Point(200, 435)
        txtVLRemarks.Multiline = True
        txtVLRemarks.Name = "txtVLRemarks"
        txtVLRemarks.ScrollBars = ScrollBars.Vertical
        txtVLRemarks.Size = New Size(400, 60)
        txtVLRemarks.TabIndex = 32
        ' 
        ' LabelVLAttachment
        ' 
        LabelVLAttachment.AutoSize = True
        LabelVLAttachment.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        LabelVLAttachment.Location = New Point(28, 505)
        LabelVLAttachment.Name = "LabelVLAttachment"
        LabelVLAttachment.Size = New Size(110, 23)
        LabelVLAttachment.TabIndex = 33
        LabelVLAttachment.Text = "Attachment:"
        ' 
        ' txtVLAttachment
        ' 
        txtVLAttachment.Font = New Font("Segoe UI", 10F)
        txtVLAttachment.Location = New Point(200, 502)
        txtVLAttachment.Name = "txtVLAttachment"
        txtVLAttachment.Size = New Size(320, 30)
        txtVLAttachment.TabIndex = 34
        ' 
        ' btnVLBrowse
        ' 
        btnVLBrowse.BackColor = Color.FromArgb(CByte(120), CByte(144), CByte(156))
        btnVLBrowse.FlatAppearance.BorderSize = 0
        btnVLBrowse.FlatStyle = FlatStyle.Flat
        btnVLBrowse.Font = New Font("Segoe UI", 10F)
        btnVLBrowse.ForeColor = Color.White
        btnVLBrowse.Location = New Point(530, 502)
        btnVLBrowse.Name = "btnVLBrowse"
        btnVLBrowse.Size = New Size(90, 32)
        btnVLBrowse.TabIndex = 35
        btnVLBrowse.Text = "Browse"
        btnVLBrowse.UseVisualStyleBackColor = False
        ' 
        ' btnVLSave
        ' 
        btnVLSave.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnVLSave.FlatAppearance.BorderSize = 0
        btnVLSave.FlatStyle = FlatStyle.Flat
        btnVLSave.Font = New Font("Segoe UI", 10F)
        btnVLSave.ForeColor = Color.White
        btnVLSave.Location = New Point(200, 545)
        btnVLSave.Name = "btnVLSave"
        btnVLSave.Size = New Size(140, 40)
        btnVLSave.TabIndex = 36
        btnVLSave.Text = "Save Visit Log"
        btnVLSave.UseVisualStyleBackColor = False
        ' 
        ' btnVLGenerateVisitLog
        ' 
        btnVLGenerateVisitLog.BackColor = Color.FromArgb(CByte(30), CByte(136), CByte(229))
        btnVLGenerateVisitLog.FlatStyle = FlatStyle.Flat
        btnVLGenerateVisitLog.Font = New Font("Segoe UI", 10F)
        btnVLGenerateVisitLog.ForeColor = Color.White
        btnVLGenerateVisitLog.Location = New Point(350, 545)
        btnVLGenerateVisitLog.Name = "btnVLGenerateVisitLog"
        btnVLGenerateVisitLog.Size = New Size(200, 40)
        btnVLGenerateVisitLog.TabIndex = 37
        btnVLGenerateVisitLog.Text = "Print Visit Log PDF"
        btnVLGenerateVisitLog.UseVisualStyleBackColor = False
        ' 
        ' btnVLCancel
        ' 
        btnVLCancel.BackColor = Color.FromArgb(CByte(189), CByte(189), CByte(189))
        btnVLCancel.FlatAppearance.BorderSize = 0
        btnVLCancel.FlatStyle = FlatStyle.Flat
        btnVLCancel.Font = New Font("Segoe UI", 10F)
        btnVLCancel.ForeColor = Color.Black
        btnVLCancel.Location = New Point(560, 546)
        btnVLCancel.Name = "btnVLCancel"
        btnVLCancel.Size = New Size(120, 40)
        btnVLCancel.TabIndex = 38
        btnVLCancel.Text = "Clear"
        btnVLCancel.UseVisualStyleBackColor = False
        ' 
        ' dgvVisitLogs
        ' 
        dgvVisitLogs.AllowUserToAddRows = False
        dgvVisitLogs.AllowUserToDeleteRows = False
        dgvVisitLogs.AllowUserToResizeRows = False
        dgvVisitLogs.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvVisitLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvVisitLogs.BackgroundColor = Color.White
        dgvVisitLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVisitLogs.Columns.AddRange(New DataGridViewColumn() {VisitID, VisitDate, VisitType, HoursAdded, Score, MaxScore, Remarks, AttachmentPath, colDownload, colEdit, colDelete})
        dgvVisitLogs.Location = New Point(24, 609)
        dgvVisitLogs.Margin = New Padding(3, 4, 3, 4)
        dgvVisitLogs.MultiSelect = False
        dgvVisitLogs.Name = "dgvVisitLogs"
        dgvVisitLogs.ReadOnly = True
        dgvVisitLogs.RowHeadersVisible = False
        dgvVisitLogs.RowHeadersWidth = 51
        dgvVisitLogs.RowTemplate.Height = 28
        dgvVisitLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvVisitLogs.Size = New Size(1271, 366)
        dgvVisitLogs.TabIndex = 39
        ' 
        ' lblVLStatus
        ' 
        lblVLStatus.AutoSize = True
        lblVLStatus.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblVLStatus.Location = New Point(29, 81)
        lblVLStatus.Name = "lblVLStatus"
        lblVLStatus.Size = New Size(113, 23)
        lblVLStatus.TabIndex = 42
        lblVLStatus.Text = "Status Filter:"
        ' 
        ' cboVLStatusFilter
        ' 
        cboVLStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboVLStatusFilter.Font = New Font("Segoe UI", 10F)
        cboVLStatusFilter.Items.AddRange(New Object() {"Active", "Completed"})
        cboVLStatusFilter.Location = New Point(200, 80)
        cboVLStatusFilter.Name = "cboVLStatusFilter"
        cboVLStatusFilter.Size = New Size(237, 31)
        cboVLStatusFilter.TabIndex = 43
        ' 
        ' lbl1
        ' 
        lbl1.Location = New Point(0, 0)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(100, 23)
        lbl1.TabIndex = 0
        ' 
        ' lbl2
        ' 
        lbl2.Location = New Point(0, 0)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(100, 23)
        lbl2.TabIndex = 0
        ' 
        ' lbl3
        ' 
        lbl3.Location = New Point(0, 0)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(100, 23)
        lbl3.TabIndex = 0
        ' 
        ' lbl4
        ' 
        lbl4.Location = New Point(0, 0)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(100, 23)
        lbl4.TabIndex = 0
        ' 
        ' lbl5
        ' 
        lbl5.Location = New Point(0, 0)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(100, 23)
        lbl5.TabIndex = 0
        ' 
        ' lbl6
        ' 
        lbl6.Location = New Point(0, 0)
        lbl6.Name = "lbl6"
        lbl6.Size = New Size(100, 23)
        lbl6.TabIndex = 0
        ' 
        ' lblT
        ' 
        lblT.Location = New Point(0, 0)
        lblT.Name = "lblT"
        lblT.Size = New Size(100, 23)
        lblT.TabIndex = 0
        ' 
        ' lblP
        ' 
        lblP.Location = New Point(0, 0)
        lblP.Name = "lblP"
        lblP.Size = New Size(100, 23)
        lblP.TabIndex = 0
        ' 
        ' lblA
        ' 
        lblA.Location = New Point(0, 0)
        lblA.Name = "lblA"
        lblA.Size = New Size(100, 23)
        lblA.TabIndex = 0
        ' 
        ' lblC
        ' 
        lblC.Location = New Point(0, 0)
        lblC.Name = "lblC"
        lblC.Size = New Size(100, 23)
        lblC.TabIndex = 0
        ' 
        ' lblQ
        ' 
        lblQ.Location = New Point(0, 0)
        lblQ.Name = "lblQ"
        lblQ.Size = New Size(100, 23)
        lblQ.TabIndex = 0
        ' 
        ' lblFI
        ' 
        lblFI.Location = New Point(0, 0)
        lblFI.Name = "lblFI"
        lblFI.Size = New Size(100, 23)
        lblFI.TabIndex = 0
        ' 
        ' lblFT
        ' 
        lblFT.Location = New Point(0, 0)
        lblFT.Name = "lblFT"
        lblFT.Size = New Size(100, 23)
        lblFT.TabIndex = 0
        ' 
        ' lblFG
        ' 
        lblFG.Location = New Point(0, 0)
        lblFG.Name = "lblFG"
        lblFG.Size = New Size(100, 23)
        lblFG.TabIndex = 0
        ' 
        ' lblGRWarning
        ' 
        lblGRWarning.Location = New Point(0, 0)
        lblGRWarning.Name = "lblGRWarning"
        lblGRWarning.Size = New Size(100, 23)
        lblGRWarning.TabIndex = 0
        ' 
        ' txtVLEditID
        ' 
        txtVLEditID.Location = New Point(0, 0)
        txtVLEditID.Name = "txtVLEditID"
        txtVLEditID.Size = New Size(100, 27)
        txtVLEditID.TabIndex = 0
        ' 
        ' txtVLHoursAdded
        ' 
        txtVLHoursAdded.Location = New Point(0, 0)
        txtVLHoursAdded.Name = "txtVLHoursAdded"
        txtVLHoursAdded.Size = New Size(100, 27)
        txtVLHoursAdded.TabIndex = 0
        ' 
        ' LabelVLHoursAdded
        ' 
        LabelVLHoursAdded.Location = New Point(0, 0)
        LabelVLHoursAdded.Name = "LabelVLHoursAdded"
        LabelVLHoursAdded.Size = New Size(100, 23)
        LabelVLHoursAdded.TabIndex = 0
        ' 
        ' txtVLMaxScore
        ' 
        txtVLMaxScore.Location = New Point(0, 0)
        txtVLMaxScore.Name = "txtVLMaxScore"
        txtVLMaxScore.Size = New Size(100, 27)
        txtVLMaxScore.TabIndex = 0
        ' 
        ' LabelVLMaxScore
        ' 
        LabelVLMaxScore.Location = New Point(0, 0)
        LabelVLMaxScore.Name = "LabelVLMaxScore"
        LabelVLMaxScore.Size = New Size(100, 23)
        LabelVLMaxScore.TabIndex = 0
        ' 
        ' txtVLScore
        ' 
        txtVLScore.Location = New Point(0, 0)
        txtVLScore.Name = "txtVLScore"
        txtVLScore.Size = New Size(100, 27)
        txtVLScore.TabIndex = 0
        ' 
        ' LabelVLScore
        ' 
        LabelVLScore.Location = New Point(0, 0)
        LabelVLScore.Name = "LabelVLScore"
        LabelVLScore.Size = New Size(100, 23)
        LabelVLScore.TabIndex = 0
        ' 
        ' lblCN
        ' 
        lblCN.AutoSize = True
        lblCN.Font = New Font("Segoe UI", 10F)
        lblCN.Location = New Point(14, 60)
        lblCN.Name = "lblCN"
        lblCN.Size = New Size(100, 23)
        lblCN.TabIndex = 0
        lblCN.Text = "Company Name:"
        ' 
        ' lblAddr
        ' 
        lblAddr.AutoSize = True
        lblAddr.Font = New Font("Segoe UI", 10F)
        lblAddr.Location = New Point(14, 122)
        lblAddr.Name = "lblAddr"
        lblAddr.Size = New Size(100, 23)
        lblAddr.TabIndex = 0
        lblAddr.Text = "Address:"
        ' 
        ' lblCity
        ' 
        lblCity.AutoSize = True
        lblCity.Font = New Font("Segoe UI", 10F)
        lblCity.Location = New Point(14, 184)
        lblCity.Name = "lblCity"
        lblCity.Size = New Size(100, 23)
        lblCity.TabIndex = 0
        lblCity.Text = "City:"
        ' 
        ' lblInd
        ' 
        lblInd.AutoSize = True
        lblInd.Font = New Font("Segoe UI", 10F)
        lblInd.Location = New Point(14, 246)
        lblInd.Name = "lblInd"
        lblInd.Size = New Size(100, 23)
        lblInd.TabIndex = 0
        lblInd.Text = "Industry:"
        ' 
        ' lblEm
        ' 
        lblEm.AutoSize = True
        lblEm.Font = New Font("Segoe UI", 10F)
        lblEm.Location = New Point(14, 308)
        lblEm.Name = "lblEm"
        lblEm.Size = New Size(100, 23)
        lblEm.TabIndex = 0
        lblEm.Text = "Email:"
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.Font = New Font("Segoe UI", 10F)
        lblContact.Location = New Point(14, 370)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(100, 23)
        lblContact.TabIndex = 0
        lblContact.Text = "Contact Number:"
        ' 
        ' lblWeb
        ' 
        lblWeb.AutoSize = True
        lblWeb.Font = New Font("Segoe UI", 10F)
        lblWeb.Location = New Point(14, 432)
        lblWeb.Name = "lblWeb"
        lblWeb.Size = New Size(100, 23)
        lblWeb.TabIndex = 0
        lblWeb.Text = "Website:"
        ' 
        ' lblAccStat
        ' 
        lblAccStat.AutoSize = True
        lblAccStat.Font = New Font("Segoe UI", 10F)
        lblAccStat.Location = New Point(14, 494)
        lblAccStat.Name = "lblAccStat"
        lblAccStat.Size = New Size(100, 23)
        lblAccStat.TabIndex = 0
        lblAccStat.Text = "Accreditation Status:"
        ' 
        ' lblAccDate
        ' 
        lblAccDate.AutoSize = True
        lblAccDate.Font = New Font("Segoe UI", 10F)
        lblAccDate.Location = New Point(14, 556)
        lblAccDate.Name = "lblAccDate"
        lblAccDate.Size = New Size(100, 23)
        lblAccDate.TabIndex = 0
        lblAccDate.Text = "Accreditation Date:"
        ' 
        ' VisitID
        ' 
        VisitID.DataPropertyName = "VisitID"
        VisitID.HeaderText = "VisitID"
        VisitID.MinimumWidth = 6
        VisitID.Name = "VisitID"
        VisitID.ReadOnly = True
        VisitID.Visible = False
        ' 
        ' VisitDate
        ' 
        VisitDate.DataPropertyName = "VisitDate"
        VisitDate.HeaderText = "Date"
        VisitDate.MinimumWidth = 100
        VisitDate.Name = "VisitDate"
        VisitDate.ReadOnly = True
        ' 
        ' VisitType
        ' 
        VisitType.DataPropertyName = "VisitType"
        VisitType.HeaderText = "Type"
        VisitType.MinimumWidth = 120
        VisitType.Name = "VisitType"
        VisitType.ReadOnly = True
        ' 
        ' HoursAdded
        ' 
        HoursAdded.DataPropertyName = "HoursAdded"
        HoursAdded.HeaderText = "Hours"
        HoursAdded.MinimumWidth = 80
        HoursAdded.Name = "HoursAdded"
        HoursAdded.ReadOnly = True
        ' 
        ' Score
        ' 
        Score.DataPropertyName = "Score"
        Score.HeaderText = "Grade"
        Score.MinimumWidth = 70
        Score.Name = "Score"
        Score.ReadOnly = True
        ' 
        ' MaxScore
        ' 
        MaxScore.DataPropertyName = "MaxScore"
        MaxScore.HeaderText = "Max Grade"
        MaxScore.MinimumWidth = 80
        MaxScore.Name = "MaxScore"
        MaxScore.ReadOnly = True
        ' 
        ' Remarks
        ' 
        Remarks.DataPropertyName = "Remarks"
        Remarks.HeaderText = "Remarks"
        Remarks.MinimumWidth = 180
        Remarks.Name = "Remarks"
        Remarks.ReadOnly = True
        ' 
        ' AttachmentPath
        ' 
        AttachmentPath.DataPropertyName = "AttachmentPath"
        AttachmentPath.HeaderText = "File"
        AttachmentPath.MinimumWidth = 6
        AttachmentPath.Name = "AttachmentPath"
        AttachmentPath.ReadOnly = True
        AttachmentPath.Visible = False
        ' 
        ' colDownload
        ' 
        colDownload.HeaderText = "Download"
        colDownload.MinimumWidth = 40
        colDownload.Name = "colDownload"
        colDownload.ReadOnly = True
        colDownload.Text = "⬇"
        colDownload.UseColumnTextForButtonValue = True
        ' 
        ' colEdit
        ' 
        colEdit.HeaderText = "Edit"
        colEdit.MinimumWidth = 50
        colEdit.Name = "colEdit"
        colEdit.ReadOnly = True
        colEdit.Text = "✎"
        colEdit.UseColumnTextForButtonValue = True
        ' 
        ' colDelete
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.ForeColor = Color.Red
        colDelete.DefaultCellStyle = DataGridViewCellStyle1
        colDelete.HeaderText = "Delete"
        colDelete.MinimumWidth = 50
        colDelete.Name = "colDelete"
        colDelete.ReadOnly = True
        colDelete.Text = "✖"
        colDelete.UseColumnTextForButtonValue = True
        ' 
        ' frmProfessorDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1551, 1102)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        Name = "frmProfessorDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Professor Dashboard"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlSidebar.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlInternshipAssignment.ResumeLayout(False)
        pnlInternshipAssignment.PerformLayout()
        pnlStudents.ResumeLayout(False)
        pnlStudents.PerformLayout()
        CType(dgvMyStudentsHistory, ComponentModel.ISupportInitialize).EndInit()
        pnlStudentEditStatus.ResumeLayout(False)
        pnlStudentEditStatus.PerformLayout()
        CType(dgvMyStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlHome.ResumeLayout(False)
        pnlHome.PerformLayout()
        CType(dgvRecentActivity, ComponentModel.ISupportInitialize).EndInit()
        pnlCardCompletedInternships.ResumeLayout(False)
        pnlCardCompletedInternships.PerformLayout()
        pnlCardPendingVisitLogs.ResumeLayout(False)
        pnlCardPendingVisitLogs.PerformLayout()
        pnlCardActiveInternships.ResumeLayout(False)
        pnlCardActiveInternships.PerformLayout()
        pnlCardMyStudents.ResumeLayout(False)
        pnlCardMyStudents.PerformLayout()
        pnlProfile.ResumeLayout(False)
        pnlProfile.PerformLayout()
        pnlCompanyContacts.ResumeLayout(False)
        pnlCompanyContacts.PerformLayout()
        CType(dgvCompanyContacts, ComponentModel.ISupportInitialize).EndInit()
        pnlCompanies.ResumeLayout(False)
        pnlCompanies.PerformLayout()
        CType(dgvCompanies, ComponentModel.ISupportInitialize).EndInit()
        pnlCompanyForm.ResumeLayout(False)
        pnlCompanyForm.PerformLayout()
        pnlGrading.ResumeLayout(False)
        pnlGrading.PerformLayout()
        grpGROverview.ResumeLayout(False)
        grpGROverview.PerformLayout()
        grpGRSupervisor.ResumeLayout(False)
        grpGRSupervisor.PerformLayout()
        grpGRFacultyEval.ResumeLayout(False)
        grpGRFacultyEval.PerformLayout()
        grpGRFinal.ResumeLayout(False)
        grpGRFinal.PerformLayout()
        pnlVisitLogs.ResumeLayout(False)
        pnlVisitLogs.PerformLayout()
        CType(dgvVisitLogs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblAppName As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnCompanyContacts As Button
    Friend WithEvents btnCompanies As Button
    Friend WithEvents btnGrading As Button
    Friend WithEvents btnVisitLogs As Button
    Friend WithEvents btnInternship As Button
    Friend WithEvents btnStudents As Button
    Friend WithEvents btnHome As Button

    Friend WithEvents pnlContent As Panel

    ' HOME PANEL
    Friend WithEvents pnlHome As Panel
    Friend WithEvents dgvRecentActivity As DataGridView
    Friend WithEvents lblRecentActivity As Label
    Friend WithEvents pnlCardCompletedInternships As Panel
    Friend WithEvents lblCardCompletedInternshipsValue As Label
    Friend WithEvents lblCardCompletedInternshipsTitle As Label
    Friend WithEvents pnlCardPendingVisitLogs As Panel
    Friend WithEvents lblCardPendingVisitLogsValue As Label
    Friend WithEvents lblCardPendingVisitLogsTitle As Label
    Friend WithEvents pnlCardActiveInternships As Panel
    Friend WithEvents lblCardActiveInternshipsValue As Label
    Friend WithEvents lblCardActiveInternshipsTitle As Label
    Friend WithEvents pnlCardMyStudents As Panel
    Friend WithEvents lblCardMyStudentsValue As Label
    Friend WithEvents lblCardMyStudentsTitle As Label
    Friend WithEvents lblHomeTitle As Label

    ' STUDENTS PANEL
    Friend WithEvents pnlStudents As Panel
    Friend WithEvents dgvMyStudents As DataGridView
    Friend WithEvents btnStudentSearch As Button
    Friend WithEvents txtStudentSearch As TextBox
    Friend WithEvents LabelStudentSearch As Label
    Friend WithEvents cboStudentStatus As ComboBox
    Friend WithEvents LabelStudentStatusFilter As Label
    Friend WithEvents cboStudentSection As ComboBox
    Friend WithEvents LabelStudentSectionFilter As Label
    Friend WithEvents lblStudentFilters As Label
    Friend WithEvents lblStudentsTitle As Label

    ' INTERNSHIP ASSIGNMENT PANEL
    Friend WithEvents pnlInternshipAssignment As Panel
    Friend WithEvents btnIAClear As Button
    Friend WithEvents btnIAAssign As Button
    Friend WithEvents dtpIAEndTime As DateTimePicker
    Friend WithEvents dtpIAStartTime As DateTimePicker
    Friend WithEvents txtIAWorkDays As TextBox
    Friend WithEvents LabelIAEndTime As Label
    Friend WithEvents LabelIAStartTime As Label
    Friend WithEvents LabelIAWorkDays As Label
    Friend WithEvents lblIAFacultyEvaluator As Label
    Friend WithEvents LabelIAFacultyEvaluator As Label
    Friend WithEvents cboIASupervisor As ComboBox
    Friend WithEvents LabelIASupervisor As Label
    Friend WithEvents cboIACompany As ComboBox
    Friend WithEvents LabelIACompany As Label
    Friend WithEvents lblIAStatus As Label
    Friend WithEvents lblIARequiredHours As Label
    Friend WithEvents lblIASection As Label
    Friend WithEvents lblIACourse As Label
    Friend WithEvents lblIAStudentName As Label
    Friend WithEvents lblIAStudentNo As Label
    Friend WithEvents LabelIAStatus As Label
    Friend WithEvents LabelIARequiredHours As Label
    Friend WithEvents LabelIASection As Label
    Friend WithEvents LabelIACourse As Label
    Friend WithEvents LabelIAStudentName As Label
    Friend WithEvents LabelIAStudentNo As Label
    Friend WithEvents LabelIAStudentSelected As Label
    Friend WithEvents btnIASearch As Button
    Friend WithEvents txtIASearch As TextBox
    Friend WithEvents LabelIASearch As Label
    Friend WithEvents cboIAStudent As ComboBox
    Friend WithEvents LabelIAStudentFilter As Label
    Friend WithEvents cboIASection As ComboBox
    Friend WithEvents LabelIASectionFilter As Label
    Friend WithEvents lblIAFilters As Label
    Friend WithEvents lblInternshipTitle As Label

    ' VISIT LOGS PANEL
    Friend WithEvents pnlVisitLogs As Panel
    Friend WithEvents btnVLCancel As Button
    Friend WithEvents btnVLSave As Button
    Friend WithEvents btnVLBrowse As Button
    Friend WithEvents txtVLAttachment As TextBox
    Friend WithEvents LabelVLAttachment As Label
    Friend WithEvents txtVLRemarks As TextBox
    Friend WithEvents LabelVLRemarks As Label
    Friend WithEvents txtVLMaxScore As TextBox
    Friend WithEvents LabelVLMaxScore As Label
    Friend WithEvents txtVLScore As TextBox
    Friend WithEvents LabelVLScore As Label
    Friend WithEvents cboVLVisitType As ComboBox
    Friend WithEvents LabelVLVisitType As Label
    Friend WithEvents dgvVisitLogs As DataGridView
    Friend WithEvents cboVLInternship As ComboBox
    Friend WithEvents LabelVLSelectInternship As Label
    Friend WithEvents lblVisitLogsTitle As Label
    Friend WithEvents lblVLStudentName As Label
    Friend WithEvents lblVLStudentNumber As Label
    Friend WithEvents lblVLCourseSection As Label
    Friend WithEvents lblVLCompany As Label
    Friend WithEvents lblVLSupervisor As Label
    Friend WithEvents cboVLStatusFilter As ComboBox
    Friend WithEvents lblVLStatus As Label
    Friend WithEvents LabelVLStudentName As Label
    Friend WithEvents LabelVLStudentNumber As Label
    Friend WithEvents LabelVLCourseSection As Label
    Friend WithEvents LabelVLCompany As Label
    Friend WithEvents LabelVLSupervisor As Label

    Friend WithEvents LabelVLVisitDate As Label
    Friend WithEvents dtpVLDate As DateTimePicker

    Friend WithEvents cboVLTech As ComboBox
    Friend WithEvents cboVLComm As ComboBox
    Friend WithEvents cboVLBehavior As ComboBox
    Friend WithEvents cboVLAttendance As ComboBox
    Friend WithEvents cboVLQuality As ComboBox

    Friend WithEvents LabelVLTech As Label
    Friend WithEvents LabelVLComm As Label
    Friend WithEvents LabelVLBehavior As Label
    Friend WithEvents LabelVLAttendance As Label
    Friend WithEvents LabelVLQuality As Label

    Friend WithEvents LabelVLOutputOverall As Label
    Friend WithEvents lblVLOverallScore As Label

    Friend WithEvents LabelVLHoursRendered As Label
    Friend WithEvents txtVLHoursRendered As TextBox

    Friend WithEvents btnVLGenerateVisitLog As Button

    ' GRADING PANEL
    ' ============================================================
    ' ========== GRADING PANEL — CONTROL DECLARATIONS ============
    ' ============================================================

    Friend WithEvents pnlGrading As Panel
    Friend WithEvents lblGRReportTitle As Label

    ' --- Select Student ---
    Friend WithEvents LabelGRSelectStudent As Label
    Friend WithEvents cboGRStudent As ComboBox

    ' ============================================================
    ' OVERVIEW GROUPBOX
    ' ============================================================
    Friend WithEvents grpGROverview As GroupBox
    Friend WithEvents lblGROverviewTitle As Label

    Friend WithEvents LabelGRStudentName As Label
    Friend WithEvents lblGRStudentName As Label

    Friend WithEvents LabelGRStudentNumber As Label
    Friend WithEvents lblGRStudentNumber As Label

    Friend WithEvents LabelGRCourseSection As Label
    Friend WithEvents lblGRCourseSection As Label

    Friend WithEvents LabelGRCompany As Label
    Friend WithEvents lblGRCompany As Label

    Friend WithEvents LabelGRSupervisor As Label
    Friend WithEvents lblGRSupervisor As Label

    Friend WithEvents LabelGRRequiredHours As Label
    Friend WithEvents lblGRRequiredHours As Label

    Friend WithEvents LabelGRCompletedHours As Label
    Friend WithEvents lblGRCompletedHours As Label

    Friend WithEvents LabelGRStatus As Label
    Friend WithEvents lblGRInternshipStatus As Label

    ' ============================================================
    ' SUPERVISOR SCORE PANEL
    ' ============================================================
    Friend WithEvents grpGRSupervisor As GroupBox
    Friend WithEvents lblGRSupervisorPanelTitle As Label

    Friend WithEvents LabelGRSupervisorScore As Label
    Friend WithEvents lblGRSupervisorScore As Label

    ' ============================================================
    ' FACULTY FINAL EVALUATION PANEL
    ' ============================================================
    Friend WithEvents grpGRFacultyEval As GroupBox
    Friend WithEvents lblGRFacultyEvalTitle As Label

    Friend WithEvents LabelGRF_Tech As Label
    Friend WithEvents cboGRF_Tech As ComboBox

    Friend WithEvents LabelGRF_Professionalism As Label
    Friend WithEvents cboGRF_Professionalism As ComboBox

    Friend WithEvents LabelGRF_Communication As Label
    Friend WithEvents cboGRF_Communication As ComboBox

    Friend WithEvents LabelGRF_Attendance As Label
    Friend WithEvents cboGRF_Attendance As ComboBox

    Friend WithEvents LabelGRF_OutputQuality As Label
    Friend WithEvents cboGRF_OutputQuality As ComboBox

    Friend WithEvents LabelGRF_FinalInterview As Label
    Friend WithEvents cboGRF_FinalInterview As ComboBox

    Friend WithEvents LabelGRFacultyTotal As Label
    Friend WithEvents lblGRFacultyTotal As Label

    ' ============================================================
    ' FINAL GRADE COMPUTATION PANEL
    ' ============================================================
    Friend WithEvents grpGRFinal As GroupBox
    Friend WithEvents lblGRFinalCompTitle As Label

    Friend WithEvents LabelGRFGSupervisor As Label
    Friend WithEvents lblGRFGSupervisor As Label

    Friend WithEvents LabelGRFGFaculty As Label
    Friend WithEvents lblGRFGFaculty As Label

    Friend WithEvents LabelGRFinalGrade As Label
    Friend WithEvents lblGRFinalGradeAuto As Label

    ' ============================================================
    ' FINAL REPORT UPLOAD PANEL
    ' ============================================================
    Friend WithEvents LabelGREvalReport As Label
    Friend WithEvents txtGREvalFile As TextBox
    Friend WithEvents btnGRBrowse As Button
    Friend WithEvents btnGRGenerateReport As Button
    Friend WithEvents btnGRSave As Button
    Friend WithEvents btnGRClear As Button



    ' COMPANIES PANEL
    Friend WithEvents pnlCompanies As Panel
    Friend WithEvents btnCompanyAdd As Button
    Friend WithEvents btnCompanySearch As Button
    Friend WithEvents txtCompanySearch As TextBox
    Friend WithEvents LabelCompanySearch As Label
    Friend WithEvents dgvCompanies As DataGridView
    Friend WithEvents lblCompaniesTitle As Label

    ' COMPANY CONTACTS PANEL
    Friend WithEvents pnlCompanyContacts As Panel
    Friend WithEvents btnCCAddContact As Button
    Friend WithEvents cboCCCompany As ComboBox
    Friend WithEvents LabelCCCompany As Label
    Friend WithEvents dgvCompanyContacts As DataGridView
    Friend WithEvents lblCompanyContactsTitle As Label

    ' PROFILE PANEL
    Friend WithEvents pnlProfile As Panel
    Friend WithEvents btnPFSave As Button
    Friend WithEvents btnPFEdit As Button
    Friend WithEvents txtPFConfirmPassword As TextBox
    Friend WithEvents txtPFPassword As TextBox
    Friend WithEvents txtPFContact As TextBox
    Friend WithEvents txtPFEmail As TextBox
    Friend WithEvents lblPFSections As Label
    Friend WithEvents lblPFDepartment As Label
    Friend WithEvents lblPFName As Label
    Friend WithEvents lblPFFacultyNumber As Label
    Friend WithEvents LabelPFSectionsLabel As Label
    Friend WithEvents LabelPFDepartmentLabel As Label
    Friend WithEvents LabelPFNameLabel As Label
    Friend WithEvents LabelPFFacultyNumberLabel As Label
    Friend WithEvents LabelPFConfirmPassword As Label
    Friend WithEvents LabelPFPassword As Label
    Friend WithEvents LabelPFContact As Label
    Friend WithEvents LabelPFEmail As Label
    Friend WithEvents lblProfileTitle As Label
    ' COMPANIES ADD/EDIT PANEL
    Friend WithEvents pnlCompanyForm As Panel
    Friend WithEvents lblCompanyFormTitle As Label
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents txtCompanyAddress As TextBox
    Friend WithEvents cboCompanyCity As ComboBox
    Friend WithEvents txtCompanyIndustry As TextBox
    Friend WithEvents txtCompanyEmail As TextBox
    Friend WithEvents txtCompanyContact As TextBox
    Friend WithEvents txtCompanyWebsite As TextBox
    Friend WithEvents cboCompanyAccreditationStatus As ComboBox
    Friend WithEvents dtpCompanyAccreditationDate As DateTimePicker
    Friend WithEvents chkCompanyIsActive As CheckBox
    Friend WithEvents btnCompanySave As Button
    Friend WithEvents btnCompanyCancel As Button
    Friend WithEvents lblCN As Label
    Friend WithEvents lblAddr As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblInd As Label
    Friend WithEvents lblEm As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblWeb As Label
    Friend WithEvents lblAccStat As Label
    Friend WithEvents lblAccDate As Label

    Friend WithEvents lblCompanyNameLabel As Label
    Friend WithEvents lblCompanyAddressLabel As Label
    Friend WithEvents lblCompanyCityLabel As Label
    Friend WithEvents lblCompanyIndustryLabel As Label
    Friend WithEvents lblCompanyEmailLabel As Label
    Friend WithEvents lblCompanyContactLabel As Label
    Friend WithEvents lblCompanyWebsiteLabel As Label
    Friend WithEvents lblCompanyAccStatusLabel As Label
    Friend WithEvents lblCompanyAccDateLabel As Label
    Friend WithEvents txtVLHoursAdded As TextBox
    Friend WithEvents LabelVLHoursAdded As Label
    Friend WithEvents txtVLEditID As TextBox
    Friend WithEvents lblGRWarning As Label
    Friend WithEvents btnPFCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lblT As Label
    Friend WithEvents lblP As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblC As Label
    Friend WithEvents lblQ As Label
    Friend WithEvents lblFI As Label
    Friend WithEvents lblFT As Label
    Friend WithEvents lblFG As Label
    Friend WithEvents btnGREdit As Button
    Friend WithEvents btnGRCancel As Button
    Friend WithEvents btnIACancelEdit As Button
    Friend WithEvents btnIAEdit As Button
    Friend WithEvents btnIADrop As Button
    Friend WithEvents cboIAStatus As ComboBox
    Friend WithEvents lblIAStatusFilter As Label
    Friend WithEvents pnlStudentEditStatus As Panel
    Friend WithEvents btnStudentEdit As Button
    Friend WithEvents cboStudentEditStatus As ComboBox
    Friend WithEvents lblStudentNameTitle As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblStudentEditTitle As Label
    Friend WithEvents lblStudentEditStatus As Label
    Friend WithEvents btnStudentEditCancel As Button
    Friend WithEvents btnStudentEditSave As Button
    Friend WithEvents dgvMyStudentsHistory As DataGridView
    Friend WithEvents VisitID As DataGridViewTextBoxColumn
    Friend WithEvents VisitDate As DataGridViewTextBoxColumn
    Friend WithEvents VisitType As DataGridViewTextBoxColumn
    Friend WithEvents HoursAdded As DataGridViewTextBoxColumn
    Friend WithEvents Score As DataGridViewTextBoxColumn
    Friend WithEvents MaxScore As DataGridViewTextBoxColumn
    Friend WithEvents Remarks As DataGridViewTextBoxColumn
    Friend WithEvents AttachmentPath As DataGridViewTextBoxColumn
    Friend WithEvents colDownload As DataGridViewButtonColumn
    Friend WithEvents colEdit As DataGridViewButtonColumn
    Friend WithEvents colDelete As DataGridViewButtonColumn

End Class
