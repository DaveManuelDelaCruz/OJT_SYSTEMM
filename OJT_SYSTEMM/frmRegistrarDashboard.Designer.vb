<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistrarDashboard
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlHeader = New Panel()
        lblUserName = New Label()
        lblHeaderTitle = New Label()
        lblAppName = New Label()
        pnlSidebar = New Panel()
        btnLogout = New Button()
        btnLogs = New Button()
        btnOfficialProfessorList = New Button()
        btnOfficialSchoolList = New Button()
        btnManageFaculty = New Button()
        btnManageStudents = New Button()
        btnFacultyApprovals = New Button()
        btnStudentApprovals = New Button()
        btnHome = New Button()
        pnlContent = New Panel()
        pnlOfficialProfessorList = New Panel()
        btnImportFaculty = New Button()
        cboOPPosition = New ComboBox()
        Label2 = New Label()
        cboOPDepartment = New ComboBox()
        txtOPSearch = New TextBox()
        btnOPSearch = New Button()
        dgvOfficialProfessor = New DataGridView()
        lblOfficialProfessorTitle = New Label()
        pnlOfficialSchoolList = New Panel()
        btnImportStudents = New Button()
        lblOfficialSchoolTitle = New Label()
        lblOSFilters = New Label()
        cboOSDepartment = New ComboBox()
        cboOSCourse = New ComboBox()
        cboOSSection = New ComboBox()
        txtOSSearch = New TextBox()
        btnOSSearch = New Button()
        dgvOfficialStudents = New DataGridView()
        pnlManageFaculty = New Panel()
        dgvManageFaculty = New DataGridView()
        btnMFSearch = New Button()
        txtMFSearch = New TextBox()
        cboMFSection1 = New ComboBox()
        cboMFPosition = New ComboBox()
        cboMFDepartment = New ComboBox()
        lblMFFilters = New Label()
        lblManageFacultyTitle = New Label()
        pnlManageStudents = New Panel()
        dgvManageStudents = New DataGridView()
        btnMSSearch = New Button()
        txtMSSearch = New TextBox()
        cboMSSection = New ComboBox()
        cboMSCourse = New ComboBox()
        cboMSDepartment = New ComboBox()
        lblMSFilters = New Label()
        lblManageStudentsTitle = New Label()
        pnlFacultyApprovals = New Panel()
        dgvFacultyPending = New DataGridView()
        btnSearchFacultyPending = New Button()
        txtSearchFacultyPending = New TextBox()
        lblFacultyApprovalsTitle = New Label()
        pnlStudentApprovals = New Panel()
        dgvStudentPending = New DataGridView()
        btnSearchStudentPending = New Button()
        txtSearchStudentPending = New TextBox()
        lblStudentApprovalsTitle = New Label()
        pnlHome = New Panel()
        dgvRecentActivity = New DataGridView()
        lblRecentActivity = New Label()
        pnlCardActiveFaculty = New Panel()
        lblAF = New Label()
        lblHomeActiveFaculty = New Label()
        pnlCardActiveStudents = New Panel()
        lblAS = New Label()
        lblHomeActiveStudents = New Label()
        pnlCardPendingFaculty = New Panel()
        lblPF = New Label()
        lblHomePendingFaculty = New Label()
        pnlCardPendingStudents = New Panel()
        lblPS = New Label()
        lblHomePendingStudents = New Label()
        lblHomeTitle = New Label()
        pnlLogs = New Panel()
        dgvLogs = New DataGridView()
        lblLogsTitle = New Label()
        pnlHeader.SuspendLayout()
        pnlSidebar.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlOfficialProfessorList.SuspendLayout()
        CType(dgvOfficialProfessor, ComponentModel.ISupportInitialize).BeginInit()
        pnlOfficialSchoolList.SuspendLayout()
        CType(dgvOfficialStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlManageFaculty.SuspendLayout()
        CType(dgvManageFaculty, ComponentModel.ISupportInitialize).BeginInit()
        pnlManageStudents.SuspendLayout()
        CType(dgvManageStudents, ComponentModel.ISupportInitialize).BeginInit()
        pnlFacultyApprovals.SuspendLayout()
        CType(dgvFacultyPending, ComponentModel.ISupportInitialize).BeginInit()
        pnlStudentApprovals.SuspendLayout()
        CType(dgvStudentPending, ComponentModel.ISupportInitialize).BeginInit()
        pnlHome.SuspendLayout()
        CType(dgvRecentActivity, ComponentModel.ISupportInitialize).BeginInit()
        pnlCardActiveFaculty.SuspendLayout()
        pnlCardActiveStudents.SuspendLayout()
        pnlCardPendingFaculty.SuspendLayout()
        pnlCardPendingStudents.SuspendLayout()
        pnlLogs.SuspendLayout()
        CType(dgvLogs, ComponentModel.ISupportInitialize).BeginInit()
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
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1280, 80)
        pnlHeader.TabIndex = 0
        ' 
        ' lblUserName
        ' 
        lblUserName.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Segoe UI", 10F)
        lblUserName.ForeColor = Color.White
        lblUserName.Location = New Point(1000, 30)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(123, 23)
        lblUserName.TabIndex = 2
        lblUserName.Text = "RegistrarName"
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.Anchor = AnchorStyles.Top
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(CByte(255), CByte(241), CByte(118))
        lblHeaderTitle.Location = New Point(520, 28)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(238, 28)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "REGISTRAR DASHBOARD"
        ' 
        ' lblAppName
        ' 
        lblAppName.AutoSize = True
        lblAppName.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblAppName.ForeColor = Color.White
        lblAppName.Location = New Point(24, 24)
        lblAppName.Name = "lblAppName"
        lblAppName.Size = New Size(445, 32)
        lblAppName.TabIndex = 0
        lblAppName.Text = "OJT MONITORING AND MANAGEMENT"
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(34), CByte(51), CByte(34))
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnLogs)
        pnlSidebar.Controls.Add(btnOfficialProfessorList)
        pnlSidebar.Controls.Add(btnOfficialSchoolList)
        pnlSidebar.Controls.Add(btnManageFaculty)
        pnlSidebar.Controls.Add(btnManageStudents)
        pnlSidebar.Controls.Add(btnFacultyApprovals)
        pnlSidebar.Controls.Add(btnStudentApprovals)
        pnlSidebar.Controls.Add(btnHome)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 80)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(230, 640)
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
        btnLogout.Location = New Point(0, 580)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(20, 0, 0, 0)
        btnLogout.Size = New Size(230, 45)
        btnLogout.TabIndex = 8
        btnLogout.Text = "  Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnLogs
        ' 
        btnLogs.FlatAppearance.BorderSize = 0
        btnLogs.FlatStyle = FlatStyle.Flat
        btnLogs.Font = New Font("Segoe UI", 10F)
        btnLogs.ForeColor = Color.White
        btnLogs.Location = New Point(0, 300)
        btnLogs.Name = "btnLogs"
        btnLogs.Padding = New Padding(20, 0, 0, 0)
        btnLogs.Size = New Size(230, 40)
        btnLogs.TabIndex = 7
        btnLogs.Text = "  Logs"
        btnLogs.TextAlign = ContentAlignment.MiddleLeft
        btnLogs.UseVisualStyleBackColor = True
        ' 
        ' btnOfficialProfessorList
        ' 
        btnOfficialProfessorList.FlatAppearance.BorderSize = 0
        btnOfficialProfessorList.FlatStyle = FlatStyle.Flat
        btnOfficialProfessorList.Font = New Font("Segoe UI", 10F)
        btnOfficialProfessorList.ForeColor = Color.White
        btnOfficialProfessorList.Location = New Point(0, 260)
        btnOfficialProfessorList.Name = "btnOfficialProfessorList"
        btnOfficialProfessorList.Padding = New Padding(20, 0, 0, 0)
        btnOfficialProfessorList.Size = New Size(230, 40)
        btnOfficialProfessorList.TabIndex = 6
        btnOfficialProfessorList.Text = "  Official Professor List"
        btnOfficialProfessorList.TextAlign = ContentAlignment.MiddleLeft
        btnOfficialProfessorList.UseVisualStyleBackColor = True
        ' 
        ' btnOfficialSchoolList
        ' 
        btnOfficialSchoolList.FlatAppearance.BorderSize = 0
        btnOfficialSchoolList.FlatStyle = FlatStyle.Flat
        btnOfficialSchoolList.Font = New Font("Segoe UI", 10F)
        btnOfficialSchoolList.ForeColor = Color.White
        btnOfficialSchoolList.Location = New Point(0, 220)
        btnOfficialSchoolList.Name = "btnOfficialSchoolList"
        btnOfficialSchoolList.Padding = New Padding(20, 0, 0, 0)
        btnOfficialSchoolList.Size = New Size(230, 40)
        btnOfficialSchoolList.TabIndex = 5
        btnOfficialSchoolList.Text = "  Official School List"
        btnOfficialSchoolList.TextAlign = ContentAlignment.MiddleLeft
        btnOfficialSchoolList.UseVisualStyleBackColor = True
        ' 
        ' btnManageFaculty
        ' 
        btnManageFaculty.FlatAppearance.BorderSize = 0
        btnManageFaculty.FlatStyle = FlatStyle.Flat
        btnManageFaculty.Font = New Font("Segoe UI", 10F)
        btnManageFaculty.ForeColor = Color.White
        btnManageFaculty.Location = New Point(0, 180)
        btnManageFaculty.Name = "btnManageFaculty"
        btnManageFaculty.Padding = New Padding(20, 0, 0, 0)
        btnManageFaculty.Size = New Size(230, 40)
        btnManageFaculty.TabIndex = 4
        btnManageFaculty.Text = "  Manage Faculty"
        btnManageFaculty.TextAlign = ContentAlignment.MiddleLeft
        btnManageFaculty.UseVisualStyleBackColor = True
        ' 
        ' btnManageStudents
        ' 
        btnManageStudents.FlatAppearance.BorderSize = 0
        btnManageStudents.FlatStyle = FlatStyle.Flat
        btnManageStudents.Font = New Font("Segoe UI", 10F)
        btnManageStudents.ForeColor = Color.White
        btnManageStudents.Location = New Point(0, 140)
        btnManageStudents.Name = "btnManageStudents"
        btnManageStudents.Padding = New Padding(20, 0, 0, 0)
        btnManageStudents.Size = New Size(230, 40)
        btnManageStudents.TabIndex = 3
        btnManageStudents.Text = "  Manage Students"
        btnManageStudents.TextAlign = ContentAlignment.MiddleLeft
        btnManageStudents.UseVisualStyleBackColor = True
        ' 
        ' btnFacultyApprovals
        ' 
        btnFacultyApprovals.FlatAppearance.BorderSize = 0
        btnFacultyApprovals.FlatStyle = FlatStyle.Flat
        btnFacultyApprovals.Font = New Font("Segoe UI", 10F)
        btnFacultyApprovals.ForeColor = Color.White
        btnFacultyApprovals.Location = New Point(0, 100)
        btnFacultyApprovals.Name = "btnFacultyApprovals"
        btnFacultyApprovals.Padding = New Padding(20, 0, 0, 0)
        btnFacultyApprovals.Size = New Size(230, 40)
        btnFacultyApprovals.TabIndex = 2
        btnFacultyApprovals.Text = "  Faculty Approvals"
        btnFacultyApprovals.TextAlign = ContentAlignment.MiddleLeft
        btnFacultyApprovals.UseVisualStyleBackColor = True
        ' 
        ' btnStudentApprovals
        ' 
        btnStudentApprovals.FlatAppearance.BorderSize = 0
        btnStudentApprovals.FlatStyle = FlatStyle.Flat
        btnStudentApprovals.Font = New Font("Segoe UI", 10F)
        btnStudentApprovals.ForeColor = Color.White
        btnStudentApprovals.Location = New Point(0, 60)
        btnStudentApprovals.Name = "btnStudentApprovals"
        btnStudentApprovals.Padding = New Padding(20, 0, 0, 0)
        btnStudentApprovals.Size = New Size(230, 40)
        btnStudentApprovals.TabIndex = 1
        btnStudentApprovals.Text = "  Student Approvals"
        btnStudentApprovals.TextAlign = ContentAlignment.MiddleLeft
        btnStudentApprovals.UseVisualStyleBackColor = True
        ' 
        ' btnHome
        ' 
        btnHome.FlatAppearance.BorderSize = 0
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Segoe UI", 10F)
        btnHome.ForeColor = Color.White
        btnHome.Location = New Point(0, 20)
        btnHome.Name = "btnHome"
        btnHome.Padding = New Padding(20, 0, 0, 0)
        btnHome.Size = New Size(230, 40)
        btnHome.TabIndex = 0
        btnHome.Text = "  Home"
        btnHome.TextAlign = ContentAlignment.MiddleLeft
        btnHome.UseVisualStyleBackColor = True
        ' 
        ' pnlContent
        ' 
        pnlContent.Controls.Add(pnlLogs)
        pnlContent.Controls.Add(pnlOfficialProfessorList)
        pnlContent.Controls.Add(pnlOfficialSchoolList)
        pnlContent.Controls.Add(pnlManageFaculty)
        pnlContent.Controls.Add(pnlManageStudents)
        pnlContent.Controls.Add(pnlFacultyApprovals)
        pnlContent.Controls.Add(pnlStudentApprovals)
        pnlContent.Controls.Add(pnlHome)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(230, 80)
        pnlContent.Name = "pnlContent"
        pnlContent.Size = New Size(1050, 640)
        pnlContent.TabIndex = 2
        ' 
        ' pnlOfficialProfessorList
        ' 
        pnlOfficialProfessorList.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        pnlOfficialProfessorList.Controls.Add(btnImportFaculty)
        pnlOfficialProfessorList.Controls.Add(cboOPPosition)
        pnlOfficialProfessorList.Controls.Add(Label2)
        pnlOfficialProfessorList.Controls.Add(cboOPDepartment)
        pnlOfficialProfessorList.Controls.Add(txtOPSearch)
        pnlOfficialProfessorList.Controls.Add(btnOPSearch)
        pnlOfficialProfessorList.Controls.Add(dgvOfficialProfessor)
        pnlOfficialProfessorList.Controls.Add(lblOfficialProfessorTitle)
        pnlOfficialProfessorList.Dock = DockStyle.Fill
        pnlOfficialProfessorList.Location = New Point(0, 0)
        pnlOfficialProfessorList.Name = "pnlOfficialProfessorList"
        pnlOfficialProfessorList.Size = New Size(1050, 640)
        pnlOfficialProfessorList.TabIndex = 6
        pnlOfficialProfessorList.Visible = False
        ' 
        ' btnImportFaculty
        ' 
        btnImportFaculty.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnImportFaculty.FlatAppearance.BorderSize = 0
        btnImportFaculty.FlatStyle = FlatStyle.Flat
        btnImportFaculty.Font = New Font("Segoe UI", 10F)
        btnImportFaculty.ForeColor = Color.White
        btnImportFaculty.Location = New Point(436, 148)
        btnImportFaculty.Name = "btnImportFaculty"
        btnImportFaculty.Size = New Size(180, 32)
        btnImportFaculty.TabIndex = 17
        btnImportFaculty.Text = "Import Faculty Lists"
        btnImportFaculty.UseVisualStyleBackColor = False
        ' 
        ' cboOPPosition
        ' 
        cboOPPosition.DropDownStyle = ComboBoxStyle.DropDownList
        cboOPPosition.Font = New Font("Segoe UI", 10F)
        cboOPPosition.Location = New Point(230, 100)
        cboOPPosition.Name = "cboOPPosition"
        cboOPPosition.Size = New Size(200, 31)
        cboOPPosition.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        Label2.Location = New Point(24, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 23)
        Label2.TabIndex = 9
        Label2.Text = "Filters:"
        ' 
        ' cboOPDepartment
        ' 
        cboOPDepartment.DropDownStyle = ComboBoxStyle.DropDownList
        cboOPDepartment.Font = New Font("Segoe UI", 10F)
        cboOPDepartment.Location = New Point(24, 100)
        cboOPDepartment.Name = "cboOPDepartment"
        cboOPDepartment.Size = New Size(200, 31)
        cboOPDepartment.TabIndex = 10
        ' 
        ' txtOPSearch
        ' 
        txtOPSearch.Font = New Font("Segoe UI", 10F)
        txtOPSearch.Location = New Point(24, 150)
        txtOPSearch.Name = "txtOPSearch"
        txtOPSearch.Size = New Size(300, 30)
        txtOPSearch.TabIndex = 13
        ' 
        ' btnOPSearch
        ' 
        btnOPSearch.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnOPSearch.FlatAppearance.BorderSize = 0
        btnOPSearch.FlatStyle = FlatStyle.Flat
        btnOPSearch.Font = New Font("Segoe UI", 10F)
        btnOPSearch.ForeColor = Color.White
        btnOPSearch.Location = New Point(330, 148)
        btnOPSearch.Name = "btnOPSearch"
        btnOPSearch.Size = New Size(100, 32)
        btnOPSearch.TabIndex = 14
        btnOPSearch.Text = "Search"
        btnOPSearch.UseVisualStyleBackColor = False
        ' 
        ' dgvOfficialProfessor
        ' 
        dgvOfficialProfessor.AllowUserToAddRows = False
        dgvOfficialProfessor.AllowUserToDeleteRows = False
        dgvOfficialProfessor.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvOfficialProfessor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOfficialProfessor.BackgroundColor = Color.White
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        dgvOfficialProfessor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvOfficialProfessor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgvOfficialProfessor.DefaultCellStyle = DataGridViewCellStyle5
        dgvOfficialProfessor.Location = New Point(24, 200)
        dgvOfficialProfessor.MultiSelect = False
        dgvOfficialProfessor.Name = "dgvOfficialProfessor"
        dgvOfficialProfessor.ReadOnly = True
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgvOfficialProfessor.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgvOfficialProfessor.RowHeadersVisible = False
        dgvOfficialProfessor.RowHeadersWidth = 51
        dgvOfficialProfessor.RowTemplate.Height = 28
        dgvOfficialProfessor.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOfficialProfessor.Size = New Size(1000, 368)
        dgvOfficialProfessor.TabIndex = 15
        ' 
        ' lblOfficialProfessorTitle
        ' 
        lblOfficialProfessorTitle.AutoSize = True
        lblOfficialProfessorTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblOfficialProfessorTitle.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblOfficialProfessorTitle.Location = New Point(24, 24)
        lblOfficialProfessorTitle.Name = "lblOfficialProfessorTitle"
        lblOfficialProfessorTitle.Size = New Size(242, 32)
        lblOfficialProfessorTitle.TabIndex = 0
        lblOfficialProfessorTitle.Text = "Official Professor List"
        ' 
        ' pnlOfficialSchoolList
        ' 
        pnlOfficialSchoolList.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        pnlOfficialSchoolList.Controls.Add(btnImportStudents)
        pnlOfficialSchoolList.Controls.Add(lblOfficialSchoolTitle)
        pnlOfficialSchoolList.Controls.Add(lblOSFilters)
        pnlOfficialSchoolList.Controls.Add(cboOSDepartment)
        pnlOfficialSchoolList.Controls.Add(cboOSCourse)
        pnlOfficialSchoolList.Controls.Add(cboOSSection)
        pnlOfficialSchoolList.Controls.Add(txtOSSearch)
        pnlOfficialSchoolList.Controls.Add(btnOSSearch)
        pnlOfficialSchoolList.Controls.Add(dgvOfficialStudents)
        pnlOfficialSchoolList.Dock = DockStyle.Fill
        pnlOfficialSchoolList.Location = New Point(0, 0)
        pnlOfficialSchoolList.Name = "pnlOfficialSchoolList"
        pnlOfficialSchoolList.Size = New Size(1050, 640)
        pnlOfficialSchoolList.TabIndex = 5
        pnlOfficialSchoolList.Visible = False
        ' 
        ' btnImportStudents
        ' 
        btnImportStudents.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnImportStudents.FlatAppearance.BorderSize = 0
        btnImportStudents.FlatStyle = FlatStyle.Flat
        btnImportStudents.Font = New Font("Segoe UI", 10F)
        btnImportStudents.ForeColor = Color.White
        btnImportStudents.Location = New Point(436, 148)
        btnImportStudents.Name = "btnImportStudents"
        btnImportStudents.Size = New Size(180, 32)
        btnImportStudents.TabIndex = 8
        btnImportStudents.Text = "Import Student Lists"
        btnImportStudents.UseVisualStyleBackColor = False
        ' 
        ' lblOfficialSchoolTitle
        ' 
        lblOfficialSchoolTitle.AutoSize = True
        lblOfficialSchoolTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblOfficialSchoolTitle.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblOfficialSchoolTitle.Location = New Point(24, 24)
        lblOfficialSchoolTitle.Name = "lblOfficialSchoolTitle"
        lblOfficialSchoolTitle.Size = New Size(331, 32)
        lblOfficialSchoolTitle.TabIndex = 0
        lblOfficialSchoolTitle.Text = "Official School List (Students)"
        ' 
        ' lblOSFilters
        ' 
        lblOSFilters.AutoSize = True
        lblOSFilters.Font = New Font("Segoe UI", 10F)
        lblOSFilters.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblOSFilters.Location = New Point(24, 70)
        lblOSFilters.Name = "lblOSFilters"
        lblOSFilters.Size = New Size(58, 23)
        lblOSFilters.TabIndex = 1
        lblOSFilters.Text = "Filters:"
        ' 
        ' cboOSDepartment
        ' 
        cboOSDepartment.DropDownStyle = ComboBoxStyle.DropDownList
        cboOSDepartment.Font = New Font("Segoe UI", 10F)
        cboOSDepartment.Location = New Point(24, 100)
        cboOSDepartment.Name = "cboOSDepartment"
        cboOSDepartment.Size = New Size(200, 31)
        cboOSDepartment.TabIndex = 2
        ' 
        ' cboOSCourse
        ' 
        cboOSCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cboOSCourse.Font = New Font("Segoe UI", 10F)
        cboOSCourse.Location = New Point(230, 100)
        cboOSCourse.Name = "cboOSCourse"
        cboOSCourse.Size = New Size(200, 31)
        cboOSCourse.TabIndex = 3
        ' 
        ' cboOSSection
        ' 
        cboOSSection.DropDownStyle = ComboBoxStyle.DropDownList
        cboOSSection.Font = New Font("Segoe UI", 10F)
        cboOSSection.Location = New Point(436, 100)
        cboOSSection.Name = "cboOSSection"
        cboOSSection.Size = New Size(180, 31)
        cboOSSection.TabIndex = 4
        ' 
        ' txtOSSearch
        ' 
        txtOSSearch.Font = New Font("Segoe UI", 10F)
        txtOSSearch.Location = New Point(24, 150)
        txtOSSearch.Name = "txtOSSearch"
        txtOSSearch.Size = New Size(300, 30)
        txtOSSearch.TabIndex = 5
        ' 
        ' btnOSSearch
        ' 
        btnOSSearch.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnOSSearch.FlatAppearance.BorderSize = 0
        btnOSSearch.FlatStyle = FlatStyle.Flat
        btnOSSearch.Font = New Font("Segoe UI", 10F)
        btnOSSearch.ForeColor = Color.White
        btnOSSearch.Location = New Point(330, 148)
        btnOSSearch.Name = "btnOSSearch"
        btnOSSearch.Size = New Size(100, 32)
        btnOSSearch.TabIndex = 6
        btnOSSearch.Text = "Search"
        btnOSSearch.UseVisualStyleBackColor = False
        ' 
        ' dgvOfficialStudents
        ' 
        dgvOfficialStudents.AllowUserToAddRows = False
        dgvOfficialStudents.AllowUserToDeleteRows = False
        dgvOfficialStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvOfficialStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvOfficialStudents.BackgroundColor = Color.White
        dgvOfficialStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvOfficialStudents.Location = New Point(24, 200)
        dgvOfficialStudents.MultiSelect = False
        dgvOfficialStudents.Name = "dgvOfficialStudents"
        dgvOfficialStudents.ReadOnly = True
        dgvOfficialStudents.RowHeadersVisible = False
        dgvOfficialStudents.RowHeadersWidth = 51
        dgvOfficialStudents.RowTemplate.Height = 28
        dgvOfficialStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvOfficialStudents.Size = New Size(1000, 420)
        dgvOfficialStudents.TabIndex = 7
        ' 
        ' pnlManageFaculty
        ' 
        pnlManageFaculty.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        pnlManageFaculty.Controls.Add(dgvManageFaculty)
        pnlManageFaculty.Controls.Add(btnMFSearch)
        pnlManageFaculty.Controls.Add(txtMFSearch)
        pnlManageFaculty.Controls.Add(cboMFSection1)
        pnlManageFaculty.Controls.Add(cboMFPosition)
        pnlManageFaculty.Controls.Add(cboMFDepartment)
        pnlManageFaculty.Controls.Add(lblMFFilters)
        pnlManageFaculty.Controls.Add(lblManageFacultyTitle)
        pnlManageFaculty.Dock = DockStyle.Fill
        pnlManageFaculty.Location = New Point(0, 0)
        pnlManageFaculty.Name = "pnlManageFaculty"
        pnlManageFaculty.Size = New Size(1050, 640)
        pnlManageFaculty.TabIndex = 4
        pnlManageFaculty.Visible = False
        ' 
        ' dgvManageFaculty
        ' 
        dgvManageFaculty.AllowUserToAddRows = False
        dgvManageFaculty.AllowUserToDeleteRows = False
        dgvManageFaculty.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvManageFaculty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvManageFaculty.BackgroundColor = Color.White
        dgvManageFaculty.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvManageFaculty.Location = New Point(24, 200)
        dgvManageFaculty.MultiSelect = False
        dgvManageFaculty.Name = "dgvManageFaculty"
        dgvManageFaculty.ReadOnly = True
        dgvManageFaculty.RowHeadersVisible = False
        dgvManageFaculty.RowHeadersWidth = 51
        dgvManageFaculty.RowTemplate.Height = 28
        dgvManageFaculty.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvManageFaculty.Size = New Size(1000, 420)
        dgvManageFaculty.TabIndex = 8
        ' 
        ' btnMFSearch
        ' 
        btnMFSearch.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnMFSearch.FlatAppearance.BorderSize = 0
        btnMFSearch.FlatStyle = FlatStyle.Flat
        btnMFSearch.Font = New Font("Segoe UI", 10F)
        btnMFSearch.ForeColor = Color.White
        btnMFSearch.Location = New Point(330, 148)
        btnMFSearch.Name = "btnMFSearch"
        btnMFSearch.Size = New Size(100, 32)
        btnMFSearch.TabIndex = 7
        btnMFSearch.Text = "Search"
        btnMFSearch.UseVisualStyleBackColor = False
        ' 
        ' txtMFSearch
        ' 
        txtMFSearch.Font = New Font("Segoe UI", 10F)
        txtMFSearch.Location = New Point(24, 150)
        txtMFSearch.Name = "txtMFSearch"
        txtMFSearch.Size = New Size(300, 30)
        txtMFSearch.TabIndex = 6
        ' 
        ' cboMFSection1
        ' 
        cboMFSection1.DropDownStyle = ComboBoxStyle.DropDownList
        cboMFSection1.Font = New Font("Segoe UI", 10F)
        cboMFSection1.FormattingEnabled = True
        cboMFSection1.Location = New Point(436, 100)
        cboMFSection1.Name = "cboMFSection1"
        cboMFSection1.Size = New Size(200, 31)
        cboMFSection1.TabIndex = 4
        ' 
        ' cboMFPosition
        ' 
        cboMFPosition.DropDownStyle = ComboBoxStyle.DropDownList
        cboMFPosition.Font = New Font("Segoe UI", 10F)
        cboMFPosition.FormattingEnabled = True
        cboMFPosition.Location = New Point(230, 100)
        cboMFPosition.Name = "cboMFPosition"
        cboMFPosition.Size = New Size(200, 31)
        cboMFPosition.TabIndex = 3
        ' 
        ' cboMFDepartment
        ' 
        cboMFDepartment.DropDownStyle = ComboBoxStyle.DropDownList
        cboMFDepartment.Font = New Font("Segoe UI", 10F)
        cboMFDepartment.FormattingEnabled = True
        cboMFDepartment.Location = New Point(24, 100)
        cboMFDepartment.Name = "cboMFDepartment"
        cboMFDepartment.Size = New Size(200, 31)
        cboMFDepartment.TabIndex = 2
        ' 
        ' lblMFFilters
        ' 
        lblMFFilters.AutoSize = True
        lblMFFilters.Font = New Font("Segoe UI", 10F)
        lblMFFilters.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblMFFilters.Location = New Point(24, 70)
        lblMFFilters.Name = "lblMFFilters"
        lblMFFilters.Size = New Size(58, 23)
        lblMFFilters.TabIndex = 1
        lblMFFilters.Text = "Filters:"
        ' 
        ' lblManageFacultyTitle
        ' 
        lblManageFacultyTitle.AutoSize = True
        lblManageFacultyTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblManageFacultyTitle.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblManageFacultyTitle.Location = New Point(24, 24)
        lblManageFacultyTitle.Name = "lblManageFacultyTitle"
        lblManageFacultyTitle.Size = New Size(292, 32)
        lblManageFacultyTitle.TabIndex = 0
        lblManageFacultyTitle.Text = "Manage Faculty Accounts"
        ' 
        ' pnlManageStudents
        ' 
        pnlManageStudents.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        pnlManageStudents.Controls.Add(dgvManageStudents)
        pnlManageStudents.Controls.Add(btnMSSearch)
        pnlManageStudents.Controls.Add(txtMSSearch)
        pnlManageStudents.Controls.Add(cboMSSection)
        pnlManageStudents.Controls.Add(cboMSCourse)
        pnlManageStudents.Controls.Add(cboMSDepartment)
        pnlManageStudents.Controls.Add(lblMSFilters)
        pnlManageStudents.Controls.Add(lblManageStudentsTitle)
        pnlManageStudents.Dock = DockStyle.Fill
        pnlManageStudents.Location = New Point(0, 0)
        pnlManageStudents.Name = "pnlManageStudents"
        pnlManageStudents.Size = New Size(1050, 640)
        pnlManageStudents.TabIndex = 3
        pnlManageStudents.Visible = False
        ' 
        ' dgvManageStudents
        ' 
        dgvManageStudents.AllowUserToAddRows = False
        dgvManageStudents.AllowUserToDeleteRows = False
        dgvManageStudents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvManageStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvManageStudents.BackgroundColor = Color.White
        dgvManageStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvManageStudents.Location = New Point(24, 200)
        dgvManageStudents.MultiSelect = False
        dgvManageStudents.Name = "dgvManageStudents"
        dgvManageStudents.ReadOnly = True
        dgvManageStudents.RowHeadersVisible = False
        dgvManageStudents.RowHeadersWidth = 51
        dgvManageStudents.RowTemplate.Height = 28
        dgvManageStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvManageStudents.Size = New Size(1000, 420)
        dgvManageStudents.TabIndex = 7
        ' 
        ' btnMSSearch
        ' 
        btnMSSearch.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnMSSearch.FlatAppearance.BorderSize = 0
        btnMSSearch.FlatStyle = FlatStyle.Flat
        btnMSSearch.Font = New Font("Segoe UI", 10F)
        btnMSSearch.ForeColor = Color.White
        btnMSSearch.Location = New Point(330, 148)
        btnMSSearch.Name = "btnMSSearch"
        btnMSSearch.Size = New Size(100, 32)
        btnMSSearch.TabIndex = 6
        btnMSSearch.Text = "Search"
        btnMSSearch.UseVisualStyleBackColor = False
        ' 
        ' txtMSSearch
        ' 
        txtMSSearch.Font = New Font("Segoe UI", 10F)
        txtMSSearch.Location = New Point(24, 150)
        txtMSSearch.Name = "txtMSSearch"
        txtMSSearch.Size = New Size(300, 30)
        txtMSSearch.TabIndex = 5
        ' 
        ' cboMSSection
        ' 
        cboMSSection.DropDownStyle = ComboBoxStyle.DropDownList
        cboMSSection.Font = New Font("Segoe UI", 10F)
        cboMSSection.FormattingEnabled = True
        cboMSSection.Location = New Point(436, 100)
        cboMSSection.Name = "cboMSSection"
        cboMSSection.Size = New Size(180, 31)
        cboMSSection.TabIndex = 4
        ' 
        ' cboMSCourse
        ' 
        cboMSCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cboMSCourse.Font = New Font("Segoe UI", 10F)
        cboMSCourse.FormattingEnabled = True
        cboMSCourse.Location = New Point(230, 100)
        cboMSCourse.Name = "cboMSCourse"
        cboMSCourse.Size = New Size(200, 31)
        cboMSCourse.TabIndex = 3
        ' 
        ' cboMSDepartment
        ' 
        cboMSDepartment.DropDownStyle = ComboBoxStyle.DropDownList
        cboMSDepartment.Font = New Font("Segoe UI", 10F)
        cboMSDepartment.FormattingEnabled = True
        cboMSDepartment.Location = New Point(24, 100)
        cboMSDepartment.Name = "cboMSDepartment"
        cboMSDepartment.Size = New Size(200, 31)
        cboMSDepartment.TabIndex = 2
        ' 
        ' lblMSFilters
        ' 
        lblMSFilters.AutoSize = True
        lblMSFilters.Font = New Font("Segoe UI", 10F)
        lblMSFilters.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblMSFilters.Location = New Point(24, 70)
        lblMSFilters.Name = "lblMSFilters"
        lblMSFilters.Size = New Size(58, 23)
        lblMSFilters.TabIndex = 1
        lblMSFilters.Text = "Filters:"
        ' 
        ' lblManageStudentsTitle
        ' 
        lblManageStudentsTitle.AutoSize = True
        lblManageStudentsTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblManageStudentsTitle.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblManageStudentsTitle.Location = New Point(24, 24)
        lblManageStudentsTitle.Name = "lblManageStudentsTitle"
        lblManageStudentsTitle.Size = New Size(301, 32)
        lblManageStudentsTitle.TabIndex = 0
        lblManageStudentsTitle.Text = "Manage Student Accounts"
        ' 
        ' pnlFacultyApprovals
        ' 
        pnlFacultyApprovals.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        pnlFacultyApprovals.Controls.Add(dgvFacultyPending)
        pnlFacultyApprovals.Controls.Add(btnSearchFacultyPending)
        pnlFacultyApprovals.Controls.Add(txtSearchFacultyPending)
        pnlFacultyApprovals.Controls.Add(lblFacultyApprovalsTitle)
        pnlFacultyApprovals.Dock = DockStyle.Fill
        pnlFacultyApprovals.Location = New Point(0, 0)
        pnlFacultyApprovals.Name = "pnlFacultyApprovals"
        pnlFacultyApprovals.Size = New Size(1050, 640)
        pnlFacultyApprovals.TabIndex = 2
        pnlFacultyApprovals.Visible = False
        ' 
        ' dgvFacultyPending
        ' 
        dgvFacultyPending.AllowUserToAddRows = False
        dgvFacultyPending.AllowUserToDeleteRows = False
        dgvFacultyPending.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvFacultyPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvFacultyPending.BackgroundColor = Color.White
        dgvFacultyPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFacultyPending.Location = New Point(24, 130)
        dgvFacultyPending.MultiSelect = False
        dgvFacultyPending.Name = "dgvFacultyPending"
        dgvFacultyPending.ReadOnly = True
        dgvFacultyPending.RowHeadersVisible = False
        dgvFacultyPending.RowHeadersWidth = 51
        dgvFacultyPending.RowTemplate.Height = 28
        dgvFacultyPending.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvFacultyPending.Size = New Size(1000, 480)
        dgvFacultyPending.TabIndex = 3
        ' 
        ' btnSearchFacultyPending
        ' 
        btnSearchFacultyPending.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnSearchFacultyPending.FlatAppearance.BorderSize = 0
        btnSearchFacultyPending.FlatStyle = FlatStyle.Flat
        btnSearchFacultyPending.Font = New Font("Segoe UI", 10F)
        btnSearchFacultyPending.ForeColor = Color.White
        btnSearchFacultyPending.Location = New Point(295, 76)
        btnSearchFacultyPending.Name = "btnSearchFacultyPending"
        btnSearchFacultyPending.Size = New Size(100, 32)
        btnSearchFacultyPending.TabIndex = 2
        btnSearchFacultyPending.Text = "Search"
        btnSearchFacultyPending.UseVisualStyleBackColor = False
        ' 
        ' txtSearchFacultyPending
        ' 
        txtSearchFacultyPending.Font = New Font("Segoe UI", 10F)
        txtSearchFacultyPending.Location = New Point(24, 78)
        txtSearchFacultyPending.Name = "txtSearchFacultyPending"
        txtSearchFacultyPending.Size = New Size(260, 30)
        txtSearchFacultyPending.TabIndex = 1
        ' 
        ' lblFacultyApprovalsTitle
        ' 
        lblFacultyApprovalsTitle.AutoSize = True
        lblFacultyApprovalsTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblFacultyApprovalsTitle.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblFacultyApprovalsTitle.Location = New Point(24, 24)
        lblFacultyApprovalsTitle.Name = "lblFacultyApprovalsTitle"
        lblFacultyApprovalsTitle.Size = New Size(301, 32)
        lblFacultyApprovalsTitle.TabIndex = 0
        lblFacultyApprovalsTitle.Text = "Faculty Account Approvals"
        ' 
        ' pnlStudentApprovals
        ' 
        pnlStudentApprovals.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        pnlStudentApprovals.Controls.Add(dgvStudentPending)
        pnlStudentApprovals.Controls.Add(btnSearchStudentPending)
        pnlStudentApprovals.Controls.Add(txtSearchStudentPending)
        pnlStudentApprovals.Controls.Add(lblStudentApprovalsTitle)
        pnlStudentApprovals.Dock = DockStyle.Fill
        pnlStudentApprovals.Location = New Point(0, 0)
        pnlStudentApprovals.Name = "pnlStudentApprovals"
        pnlStudentApprovals.Size = New Size(1050, 640)
        pnlStudentApprovals.TabIndex = 1
        pnlStudentApprovals.Visible = False
        ' 
        ' dgvStudentPending
        ' 
        dgvStudentPending.AllowUserToAddRows = False
        dgvStudentPending.AllowUserToDeleteRows = False
        dgvStudentPending.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvStudentPending.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStudentPending.BackgroundColor = Color.White
        dgvStudentPending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStudentPending.Location = New Point(24, 130)
        dgvStudentPending.MultiSelect = False
        dgvStudentPending.Name = "dgvStudentPending"
        dgvStudentPending.ReadOnly = True
        dgvStudentPending.RowHeadersVisible = False
        dgvStudentPending.RowHeadersWidth = 51
        dgvStudentPending.RowTemplate.Height = 28
        dgvStudentPending.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudentPending.Size = New Size(1000, 480)
        dgvStudentPending.TabIndex = 3
        ' 
        ' btnSearchStudentPending
        ' 
        btnSearchStudentPending.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnSearchStudentPending.FlatAppearance.BorderSize = 0
        btnSearchStudentPending.FlatStyle = FlatStyle.Flat
        btnSearchStudentPending.Font = New Font("Segoe UI", 10F)
        btnSearchStudentPending.ForeColor = Color.White
        btnSearchStudentPending.Location = New Point(360, 76)
        btnSearchStudentPending.Name = "btnSearchStudentPending"
        btnSearchStudentPending.Size = New Size(100, 32)
        btnSearchStudentPending.TabIndex = 2
        btnSearchStudentPending.Text = "Search"
        btnSearchStudentPending.UseVisualStyleBackColor = False
        ' 
        ' txtSearchStudentPending
        ' 
        txtSearchStudentPending.Font = New Font("Segoe UI", 10F)
        txtSearchStudentPending.Location = New Point(24, 78)
        txtSearchStudentPending.Name = "txtSearchStudentPending"
        txtSearchStudentPending.PlaceholderText = "Search by student number, name, or email..."
        txtSearchStudentPending.Size = New Size(320, 30)
        txtSearchStudentPending.TabIndex = 1
        ' 
        ' lblStudentApprovalsTitle
        ' 
        lblStudentApprovalsTitle.AutoSize = True
        lblStudentApprovalsTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblStudentApprovalsTitle.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblStudentApprovalsTitle.Location = New Point(24, 24)
        lblStudentApprovalsTitle.Name = "lblStudentApprovalsTitle"
        lblStudentApprovalsTitle.Size = New Size(310, 32)
        lblStudentApprovalsTitle.TabIndex = 0
        lblStudentApprovalsTitle.Text = "Student Account Approvals"
        ' 
        ' pnlHome
        ' 
        pnlHome.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        pnlHome.Controls.Add(dgvRecentActivity)
        pnlHome.Controls.Add(lblRecentActivity)
        pnlHome.Controls.Add(pnlCardActiveFaculty)
        pnlHome.Controls.Add(pnlCardActiveStudents)
        pnlHome.Controls.Add(pnlCardPendingFaculty)
        pnlHome.Controls.Add(pnlCardPendingStudents)
        pnlHome.Controls.Add(lblHomeTitle)
        pnlHome.Dock = DockStyle.Fill
        pnlHome.Location = New Point(0, 0)
        pnlHome.Name = "pnlHome"
        pnlHome.Size = New Size(1050, 640)
        pnlHome.TabIndex = 0
        ' 
        ' dgvRecentActivity
        ' 
        dgvRecentActivity.AllowUserToAddRows = False
        dgvRecentActivity.AllowUserToDeleteRows = False
        dgvRecentActivity.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRecentActivity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecentActivity.BackgroundColor = Color.White
        dgvRecentActivity.ColumnHeadersHeight = 29
        dgvRecentActivity.Location = New Point(24, 250)
        dgvRecentActivity.Name = "dgvRecentActivity"
        dgvRecentActivity.ReadOnly = True
        dgvRecentActivity.RowHeadersVisible = False
        dgvRecentActivity.RowHeadersWidth = 51
        dgvRecentActivity.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecentActivity.Size = New Size(1000, 360)
        dgvRecentActivity.TabIndex = 0
        ' 
        ' lblRecentActivity
        ' 
        lblRecentActivity.AutoSize = True
        lblRecentActivity.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblRecentActivity.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblRecentActivity.Location = New Point(24, 210)
        lblRecentActivity.Name = "lblRecentActivity"
        lblRecentActivity.Size = New Size(145, 28)
        lblRecentActivity.TabIndex = 1
        lblRecentActivity.Text = "Recent Activity"
        ' 
        ' pnlCardActiveFaculty
        ' 
        pnlCardActiveFaculty.BackColor = Color.White
        pnlCardActiveFaculty.BorderStyle = BorderStyle.FixedSingle
        pnlCardActiveFaculty.Controls.Add(lblAF)
        pnlCardActiveFaculty.Controls.Add(lblHomeActiveFaculty)
        pnlCardActiveFaculty.Location = New Point(792, 80)
        pnlCardActiveFaculty.Name = "pnlCardActiveFaculty"
        pnlCardActiveFaculty.Size = New Size(240, 100)
        pnlCardActiveFaculty.TabIndex = 2
        ' 
        ' lblAF
        ' 
        lblAF.AutoSize = True
        lblAF.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblAF.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblAF.Location = New Point(10, 10)
        lblAF.Name = "lblAF"
        lblAF.Size = New Size(165, 23)
        lblAF.TabIndex = 0
        lblAF.Text = "Total Active Faculty"
        ' 
        ' lblHomeActiveFaculty
        ' 
        lblHomeActiveFaculty.AutoSize = True
        lblHomeActiveFaculty.Font = New Font("Segoe UI Semibold", 28F, FontStyle.Bold)
        lblHomeActiveFaculty.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblHomeActiveFaculty.Location = New Point(10, 40)
        lblHomeActiveFaculty.Name = "lblHomeActiveFaculty"
        lblHomeActiveFaculty.Size = New Size(53, 62)
        lblHomeActiveFaculty.TabIndex = 1
        lblHomeActiveFaculty.Text = "0"
        ' 
        ' pnlCardActiveStudents
        ' 
        pnlCardActiveStudents.BackColor = Color.White
        pnlCardActiveStudents.BorderStyle = BorderStyle.FixedSingle
        pnlCardActiveStudents.Controls.Add(lblAS)
        pnlCardActiveStudents.Controls.Add(lblHomeActiveStudents)
        pnlCardActiveStudents.Location = New Point(536, 80)
        pnlCardActiveStudents.Name = "pnlCardActiveStudents"
        pnlCardActiveStudents.Size = New Size(240, 100)
        pnlCardActiveStudents.TabIndex = 3
        ' 
        ' lblAS
        ' 
        lblAS.AutoSize = True
        lblAS.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblAS.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblAS.Location = New Point(10, 10)
        lblAS.Name = "lblAS"
        lblAS.Size = New Size(180, 23)
        lblAS.TabIndex = 0
        lblAS.Text = "Total Active Students"
        ' 
        ' lblHomeActiveStudents
        ' 
        lblHomeActiveStudents.AutoSize = True
        lblHomeActiveStudents.Font = New Font("Segoe UI Semibold", 28F, FontStyle.Bold)
        lblHomeActiveStudents.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblHomeActiveStudents.Location = New Point(10, 40)
        lblHomeActiveStudents.Name = "lblHomeActiveStudents"
        lblHomeActiveStudents.Size = New Size(53, 62)
        lblHomeActiveStudents.TabIndex = 1
        lblHomeActiveStudents.Text = "0"
        ' 
        ' pnlCardPendingFaculty
        ' 
        pnlCardPendingFaculty.BackColor = Color.White
        pnlCardPendingFaculty.BorderStyle = BorderStyle.FixedSingle
        pnlCardPendingFaculty.Controls.Add(lblPF)
        pnlCardPendingFaculty.Controls.Add(lblHomePendingFaculty)
        pnlCardPendingFaculty.Location = New Point(280, 80)
        pnlCardPendingFaculty.Name = "pnlCardPendingFaculty"
        pnlCardPendingFaculty.Size = New Size(240, 100)
        pnlCardPendingFaculty.TabIndex = 4
        ' 
        ' lblPF
        ' 
        lblPF.AutoSize = True
        lblPF.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblPF.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblPF.Location = New Point(10, 10)
        lblPF.Name = "lblPF"
        lblPF.Size = New Size(246, 23)
        lblPF.TabIndex = 0
        lblPF.Text = "Pending Faculty Registrations"
        ' 
        ' lblHomePendingFaculty
        ' 
        lblHomePendingFaculty.AutoSize = True
        lblHomePendingFaculty.Font = New Font("Segoe UI Semibold", 28F, FontStyle.Bold)
        lblHomePendingFaculty.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblHomePendingFaculty.Location = New Point(10, 40)
        lblHomePendingFaculty.Name = "lblHomePendingFaculty"
        lblHomePendingFaculty.Size = New Size(53, 62)
        lblHomePendingFaculty.TabIndex = 1
        lblHomePendingFaculty.Text = "0"
        ' 
        ' pnlCardPendingStudents
        ' 
        pnlCardPendingStudents.BackColor = Color.White
        pnlCardPendingStudents.BorderStyle = BorderStyle.FixedSingle
        pnlCardPendingStudents.Controls.Add(lblPS)
        pnlCardPendingStudents.Controls.Add(lblHomePendingStudents)
        pnlCardPendingStudents.Location = New Point(24, 80)
        pnlCardPendingStudents.Name = "pnlCardPendingStudents"
        pnlCardPendingStudents.Size = New Size(240, 100)
        pnlCardPendingStudents.TabIndex = 5
        ' 
        ' lblPS
        ' 
        lblPS.AutoSize = True
        lblPS.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblPS.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblPS.Location = New Point(-1, 10)
        lblPS.Name = "lblPS"
        lblPS.Size = New Size(254, 23)
        lblPS.TabIndex = 0
        lblPS.Text = "Pending Student Registrations"
        ' 
        ' lblHomePendingStudents
        ' 
        lblHomePendingStudents.AutoSize = True
        lblHomePendingStudents.Font = New Font("Segoe UI Semibold", 28F, FontStyle.Bold)
        lblHomePendingStudents.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblHomePendingStudents.Location = New Point(10, 40)
        lblHomePendingStudents.Name = "lblHomePendingStudents"
        lblHomePendingStudents.Size = New Size(53, 62)
        lblHomePendingStudents.TabIndex = 1
        lblHomePendingStudents.Text = "0"
        ' 
        ' lblHomeTitle
        ' 
        lblHomeTitle.AutoSize = True
        lblHomeTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblHomeTitle.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblHomeTitle.Location = New Point(24, 24)
        lblHomeTitle.Name = "lblHomeTitle"
        lblHomeTitle.Size = New Size(80, 32)
        lblHomeTitle.TabIndex = 0
        lblHomeTitle.Text = "Home"
        ' 
        ' pnlLogs
        ' 
        pnlLogs.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
        pnlLogs.Controls.Add(dgvLogs)
        pnlLogs.Controls.Add(lblLogsTitle)
        pnlLogs.Dock = DockStyle.Fill
        pnlLogs.Location = New Point(0, 0)
        pnlLogs.Name = "pnlLogs"
        pnlLogs.Size = New Size(1050, 640)
        pnlLogs.TabIndex = 7
        pnlLogs.Visible = False
        ' 
        ' dgvLogs
        ' 
        dgvLogs.AllowUserToAddRows = False
        dgvLogs.AllowUserToDeleteRows = False
        dgvLogs.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLogs.BackgroundColor = Color.White
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvLogs.DefaultCellStyle = DataGridViewCellStyle2
        dgvLogs.Location = New Point(24, 114)
        dgvLogs.MultiSelect = False
        dgvLogs.Name = "dgvLogs"
        dgvLogs.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dgvLogs.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dgvLogs.RowHeadersVisible = False
        dgvLogs.RowHeadersWidth = 51
        dgvLogs.RowTemplate.Height = 28
        dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLogs.Size = New Size(1000, 368)
        dgvLogs.TabIndex = 16
        ' 
        ' lblLogsTitle
        ' 
        lblLogsTitle.AutoSize = True
        lblLogsTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblLogsTitle.ForeColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lblLogsTitle.Location = New Point(24, 24)
        lblLogsTitle.Name = "lblLogsTitle"
        lblLogsTitle.Size = New Size(64, 32)
        lblLogsTitle.TabIndex = 0
        lblLogsTitle.Text = "Logs"
        ' 
        ' frmRegistrarDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(245))
        ClientSize = New Size(1280, 720)
        Controls.Add(pnlContent)
        Controls.Add(pnlSidebar)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimumSize = New Size(1296, 756)
        Name = "frmRegistrarDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registrar Dashboard | OJT Management"
        WindowState = FormWindowState.Maximized
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlSidebar.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlOfficialProfessorList.ResumeLayout(False)
        pnlOfficialProfessorList.PerformLayout()
        CType(dgvOfficialProfessor, ComponentModel.ISupportInitialize).EndInit()
        pnlOfficialSchoolList.ResumeLayout(False)
        pnlOfficialSchoolList.PerformLayout()
        CType(dgvOfficialStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlManageFaculty.ResumeLayout(False)
        pnlManageFaculty.PerformLayout()
        CType(dgvManageFaculty, ComponentModel.ISupportInitialize).EndInit()
        pnlManageStudents.ResumeLayout(False)
        pnlManageStudents.PerformLayout()
        CType(dgvManageStudents, ComponentModel.ISupportInitialize).EndInit()
        pnlFacultyApprovals.ResumeLayout(False)
        pnlFacultyApprovals.PerformLayout()
        CType(dgvFacultyPending, ComponentModel.ISupportInitialize).EndInit()
        pnlStudentApprovals.ResumeLayout(False)
        pnlStudentApprovals.PerformLayout()
        CType(dgvStudentPending, ComponentModel.ISupportInitialize).EndInit()
        pnlHome.ResumeLayout(False)
        pnlHome.PerformLayout()
        CType(dgvRecentActivity, ComponentModel.ISupportInitialize).EndInit()
        pnlCardActiveFaculty.ResumeLayout(False)
        pnlCardActiveFaculty.PerformLayout()
        pnlCardActiveStudents.ResumeLayout(False)
        pnlCardActiveStudents.PerformLayout()
        pnlCardPendingFaculty.ResumeLayout(False)
        pnlCardPendingFaculty.PerformLayout()
        pnlCardPendingStudents.ResumeLayout(False)
        pnlCardPendingStudents.PerformLayout()
        pnlLogs.ResumeLayout(False)
        pnlLogs.PerformLayout()
        CType(dgvLogs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblAppName As Label
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnLogs As Button
    Friend WithEvents btnOfficialProfessorList As Button
    Friend WithEvents btnOfficialSchoolList As Button
    Friend WithEvents btnManageFaculty As Button
    Friend WithEvents btnManageStudents As Button
    Friend WithEvents btnFacultyApprovals As Button
    Friend WithEvents btnStudentApprovals As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlLogs As Panel
    Friend WithEvents lblLogsTitle As Label
    Friend WithEvents pnlOfficialProfessorList As Panel
    Friend WithEvents lblOfficialProfessorTitle As Label
    Friend WithEvents pnlOfficialSchoolList As Panel
    Friend WithEvents lblOfficialSchoolTitle As Label
    Friend WithEvents pnlManageFaculty As Panel
    Friend WithEvents lblManageFacultyTitle As Label
    Friend WithEvents pnlManageStudents As Panel
    Friend WithEvents lblManageStudentsTitle As Label
    Friend WithEvents lblMSFilters As Label
    Friend WithEvents cboMSDepartment As ComboBox
    Friend WithEvents cboMSCourse As ComboBox
    Friend WithEvents cboMSSection As ComboBox
    Friend WithEvents txtMSSearch As TextBox
    Friend WithEvents btnMSSearch As Button
    Friend WithEvents dgvManageStudents As DataGridView
    Friend WithEvents pnlFacultyApprovals As Panel
    Friend WithEvents lblFacultyApprovalsTitle As Label
    Friend WithEvents txtSearchFacultyPending As TextBox
    Friend WithEvents btnSearchFacultyPending As Button
    Friend WithEvents dgvFacultyPending As DataGridView
    Friend WithEvents pnlStudentApprovals As Panel
    Friend WithEvents lblStudentApprovalsTitle As Label
    Friend WithEvents txtSearchStudentPending As TextBox
    Friend WithEvents btnSearchStudentPending As Button
    Friend WithEvents dgvStudentPending As DataGridView
    Friend WithEvents pnlHome As Panel
    Friend WithEvents lblHomeTitle As Label

    ' Manage Faculty panel controls (Option 2)
    Friend WithEvents lblMFFilters As Label
    Friend WithEvents cboMFDepartment As ComboBox
    Friend WithEvents cboMFPosition As ComboBox
    Friend WithEvents cboMFSection1 As ComboBox
    Friend WithEvents txtMFSearch As TextBox
    Friend WithEvents btnMFSearch As Button
    Friend WithEvents dgvManageFaculty As DataGridView
    ' Official School List
    Friend WithEvents lblOSFilters As Label
    Friend WithEvents cboOSDepartment As ComboBox
    Friend WithEvents cboOSCourse As ComboBox
    Friend WithEvents cboOSSection As ComboBox
    Friend WithEvents txtOSSearch As TextBox
    Friend WithEvents btnOSSearch As Button
    Friend WithEvents dgvOfficialStudents As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cboOPDepartment As ComboBox
    Friend WithEvents txtOPSearch As TextBox
    Friend WithEvents btnOPSearch As Button
    Friend WithEvents dgvOfficialProfessor As DataGridView
    Friend WithEvents cboOPPosition As ComboBox
    Friend WithEvents dgvLogs As DataGridView
    Friend WithEvents pnlCardPendingStudents As Panel
    Friend WithEvents pnlCardPendingFaculty As Panel
    Friend WithEvents pnlCardActiveStudents As Panel
    Friend WithEvents pnlCardActiveFaculty As Panel

    Friend WithEvents lblHomePendingStudents As Label
    Friend WithEvents lblHomePendingFaculty As Label
    Friend WithEvents lblHomeActiveStudents As Label
    Friend WithEvents lblHomeActiveFaculty As Label

    Friend WithEvents lblRecentActivity As Label
    Friend WithEvents dgvRecentActivity As DataGridView
    Friend WithEvents lblAF As Label
    Friend WithEvents lblAS As Label
    Friend WithEvents lblPF As Label
    Friend WithEvents lblPS As Label
    Friend WithEvents btnImportStudents As Button
    Friend WithEvents btnImportFaculty As Button

End Class
