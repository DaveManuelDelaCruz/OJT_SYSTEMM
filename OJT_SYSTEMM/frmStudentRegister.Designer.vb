<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentRegister
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
        btnBack = New Button()
        lblHeaderTitle = New Label()
        lblAppName = New Label()
        pnlRegisterCard = New Panel()
        lnkLogin = New LinkLabel()
        btnClear = New Button()
        lblRegisterTitle = New Label()
        lblPersonalHeader = New Label()
        btnRegister = New Button()
        lblError = New Label()
        chkShowPassword = New CheckBox()
        txtConfirmPassword = New TextBox()
        lblConfirmPassword = New Label()
        txtPassword = New TextBox()
        lblPassword = New Label()
        txtEmail = New TextBox()
        lblEmail = New Label()
        lblContactLoginHeader = New Label()
        cboSection = New ComboBox()
        lblSection = New Label()
        txtDepartment = New TextBox()
        lblDepartment = New Label()
        cboCourse = New ComboBox()
        lblCourse = New Label()
        lblAcademicHeader = New Label()
        cboGender = New ComboBox()
        lblGender = New Label()
        dtpBirthDate = New DateTimePicker()
        lblBirthDate = New Label()
        txtMiddleName = New TextBox()
        lblMiddleName = New Label()
        txtFirstName = New TextBox()
        lblFirstName = New Label()
        txtLastName = New TextBox()
        lblLastName = New Label()
        txtStudentNumber = New TextBox()
        lblStudentNumber = New Label()
        pnlHeader.SuspendLayout()
        pnlRegisterCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(27), CByte(94), CByte(32))
        pnlHeader.Controls.Add(btnBack)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblAppName)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1097, 96)
        pnlHeader.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(18, 24)
        btnBack.Margin = New Padding(3, 4, 3, 4)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(110, 48)
        btnBack.TabIndex = 0
        btnBack.Text = "← Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(CByte(255), CByte(241), CByte(118))
        lblHeaderTitle.Location = New Point(836, 32)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(239, 28)
        lblHeaderTitle.TabIndex = 2
        lblHeaderTitle.Text = "STUDENT REGISTRATION"
        ' 
        ' lblAppName
        ' 
        lblAppName.AutoSize = True
        lblAppName.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblAppName.ForeColor = Color.White
        lblAppName.Location = New Point(146, 29)
        lblAppName.Name = "lblAppName"
        lblAppName.Size = New Size(445, 32)
        lblAppName.TabIndex = 1
        lblAppName.Text = "OJT MONITORING AND MANAGEMENT"
        ' 
        ' pnlRegisterCard
        ' 
        pnlRegisterCard.Anchor = AnchorStyles.None
        pnlRegisterCard.BackColor = Color.White
        pnlRegisterCard.BorderStyle = BorderStyle.FixedSingle
        pnlRegisterCard.Controls.Add(lnkLogin)
        pnlRegisterCard.Controls.Add(btnClear)
        pnlRegisterCard.Controls.Add(lblRegisterTitle)
        pnlRegisterCard.Controls.Add(lblPersonalHeader)
        pnlRegisterCard.Controls.Add(btnRegister)
        pnlRegisterCard.Controls.Add(lblError)
        pnlRegisterCard.Controls.Add(chkShowPassword)
        pnlRegisterCard.Controls.Add(txtConfirmPassword)
        pnlRegisterCard.Controls.Add(lblConfirmPassword)
        pnlRegisterCard.Controls.Add(txtPassword)
        pnlRegisterCard.Controls.Add(lblPassword)
        pnlRegisterCard.Controls.Add(txtEmail)
        pnlRegisterCard.Controls.Add(lblEmail)
        pnlRegisterCard.Controls.Add(lblContactLoginHeader)
        pnlRegisterCard.Controls.Add(cboSection)
        pnlRegisterCard.Controls.Add(lblSection)
        pnlRegisterCard.Controls.Add(txtDepartment)
        pnlRegisterCard.Controls.Add(lblDepartment)
        pnlRegisterCard.Controls.Add(cboCourse)
        pnlRegisterCard.Controls.Add(lblCourse)
        pnlRegisterCard.Controls.Add(lblAcademicHeader)
        pnlRegisterCard.Controls.Add(cboGender)
        pnlRegisterCard.Controls.Add(lblGender)
        pnlRegisterCard.Controls.Add(dtpBirthDate)
        pnlRegisterCard.Controls.Add(lblBirthDate)
        pnlRegisterCard.Controls.Add(txtMiddleName)
        pnlRegisterCard.Controls.Add(lblMiddleName)
        pnlRegisterCard.Controls.Add(txtFirstName)
        pnlRegisterCard.Controls.Add(lblFirstName)
        pnlRegisterCard.Controls.Add(txtLastName)
        pnlRegisterCard.Controls.Add(lblLastName)
        pnlRegisterCard.Controls.Add(txtStudentNumber)
        pnlRegisterCard.Controls.Add(lblStudentNumber)
        pnlRegisterCard.Location = New Point(188, 104)
        pnlRegisterCard.Margin = New Padding(3, 4, 3, 4)
        pnlRegisterCard.Name = "pnlRegisterCard"
        pnlRegisterCard.Padding = New Padding(27, 32, 27, 32)
        pnlRegisterCard.Size = New Size(721, 639)
        pnlRegisterCard.TabIndex = 1
        ' 
        ' lnkLogin
        ' 
        lnkLogin.AutoSize = True
        lnkLogin.Font = New Font("Segoe UI", 9F, FontStyle.Underline)
        lnkLogin.Location = New Point(12, 608)
        lnkLogin.Name = "lnkLogin"
        lnkLogin.Size = New Size(219, 20)
        lnkLogin.TabIndex = 15
        lnkLogin.TabStop = True
        lnkLogin.Text = "Already have an account? Login"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(255), CByte(241), CByte(118))
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 9.5F)
        btnClear.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        btnClear.Location = New Point(360, 556)
        btnClear.Margin = New Padding(3, 4, 3, 4)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(172, 45)
        btnClear.TabIndex = 14
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' lblRegisterTitle
        ' 
        lblRegisterTitle.AutoSize = True
        lblRegisterTitle.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold)
        lblRegisterTitle.ForeColor = Color.FromArgb(CByte(251), CByte(192), CByte(45))
        lblRegisterTitle.Location = New Point(26, 17)
        lblRegisterTitle.Name = "lblRegisterTitle"
        lblRegisterTitle.Size = New Size(237, 32)
        lblRegisterTitle.TabIndex = 0
        lblRegisterTitle.Text = "Student Registration"
        ' 
        ' lblPersonalHeader
        ' 
        lblPersonalHeader.AutoSize = True
        lblPersonalHeader.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblPersonalHeader.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblPersonalHeader.Location = New Point(30, 64)
        lblPersonalHeader.Name = "lblPersonalHeader"
        lblPersonalHeader.Size = New Size(216, 23)
        lblPersonalHeader.TabIndex = 1
        lblPersonalHeader.Text = "PERSONAL INFORMATION"
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(184, 556)
        btnRegister.Margin = New Padding(3, 4, 3, 4)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(172, 45)
        btnRegister.TabIndex = 13
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' lblError
        ' 
        lblError.AutoSize = True
        lblError.Font = New Font("Segoe UI", 9F)
        lblError.ForeColor = Color.FromArgb(CByte(211), CByte(47), CByte(47))
        lblError.Location = New Point(30, 519)
        lblError.Name = "lblError"
        lblError.Size = New Size(0, 20)
        lblError.TabIndex = 30
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Font = New Font("Segoe UI", 8.5F)
        chkShowPassword.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        chkShowPassword.Location = New Point(362, 513)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(134, 24)
        chkShowPassword.TabIndex = 12
        chkShowPassword.Text = "Show password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Font = New Font("Segoe UI", 10F)
        txtConfirmPassword.Location = New Point(362, 479)
        txtConfirmPassword.Margin = New Padding(3, 4, 3, 4)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(237, 30)
        txtConfirmPassword.TabIndex = 11
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.Font = New Font("Segoe UI", 9.5F)
        lblConfirmPassword.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblConfirmPassword.Location = New Point(362, 452)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(137, 21)
        lblConfirmPassword.TabIndex = 27
        lblConfirmPassword.Text = "Confirm Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 10F)
        txtPassword.Location = New Point(30, 479)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(313, 30)
        txtPassword.TabIndex = 10
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9.5F)
        lblPassword.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblPassword.Location = New Point(30, 452)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(76, 21)
        lblPassword.TabIndex = 25
        lblPassword.Text = "Password"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 10F)
        txtEmail.Location = New Point(30, 417)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(569, 30)
        txtEmail.TabIndex = 9
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 9.5F)
        lblEmail.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblEmail.Location = New Point(30, 390)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(48, 21)
        lblEmail.TabIndex = 23
        lblEmail.Text = "Email"
        ' 
        ' lblContactLoginHeader
        ' 
        lblContactLoginHeader.AutoSize = True
        lblContactLoginHeader.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblContactLoginHeader.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblContactLoginHeader.Location = New Point(26, 358)
        lblContactLoginHeader.Name = "lblContactLoginHeader"
        lblContactLoginHeader.Size = New Size(220, 23)
        lblContactLoginHeader.TabIndex = 22
        lblContactLoginHeader.Text = "CONTACT / LOGIN DETAILS"
        ' 
        ' cboSection
        ' 
        cboSection.DropDownStyle = ComboBoxStyle.DropDownList
        cboSection.Font = New Font("Segoe UI", 10F)
        cboSection.FormattingEnabled = True
        cboSection.Location = New Point(362, 314)
        cboSection.Name = "cboSection"
        cboSection.Size = New Size(237, 31)
        cboSection.TabIndex = 8
        ' 
        ' lblSection
        ' 
        lblSection.AutoSize = True
        lblSection.Font = New Font("Segoe UI", 9.5F)
        lblSection.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblSection.Location = New Point(362, 287)
        lblSection.Name = "lblSection"
        lblSection.Size = New Size(61, 21)
        lblSection.TabIndex = 20
        lblSection.Text = "Section"
        ' 
        ' txtDepartment
        ' 
        txtDepartment.Font = New Font("Segoe UI", 10F)
        txtDepartment.Location = New Point(362, 252)
        txtDepartment.Margin = New Padding(3, 4, 3, 4)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.ReadOnly = True
        txtDepartment.Size = New Size(237, 30)
        txtDepartment.TabIndex = 7
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Segoe UI", 9.5F)
        lblDepartment.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblDepartment.Location = New Point(362, 225)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(93, 21)
        lblDepartment.TabIndex = 18
        lblDepartment.Text = "Department"
        ' 
        ' cboCourse
        ' 
        cboCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cboCourse.Font = New Font("Segoe UI", 10F)
        cboCourse.FormattingEnabled = True
        cboCourse.Location = New Point(30, 314)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(313, 31)
        cboCourse.TabIndex = 6
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI", 9.5F)
        lblCourse.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCourse.Location = New Point(30, 287)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(59, 21)
        lblCourse.TabIndex = 16
        lblCourse.Text = "Course"
        ' 
        ' lblAcademicHeader
        ' 
        lblAcademicHeader.AutoSize = True
        lblAcademicHeader.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblAcademicHeader.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblAcademicHeader.Location = New Point(26, 225)
        lblAcademicHeader.Name = "lblAcademicHeader"
        lblAcademicHeader.Size = New Size(218, 23)
        lblAcademicHeader.TabIndex = 15
        lblAcademicHeader.Text = "ACADEMIC INFORMATION"
        ' 
        ' cboGender
        ' 
        cboGender.DropDownStyle = ComboBoxStyle.DropDownList
        cboGender.Font = New Font("Segoe UI", 10F)
        cboGender.FormattingEnabled = True
        cboGender.Location = New Point(458, 187)
        cboGender.Name = "cboGender"
        cboGender.Size = New Size(141, 31)
        cboGender.TabIndex = 5
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Segoe UI", 9.5F)
        lblGender.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGender.Location = New Point(458, 160)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(61, 21)
        lblGender.TabIndex = 12
        lblGender.Text = "Gender"
        ' 
        ' dtpBirthDate
        ' 
        dtpBirthDate.Font = New Font("Segoe UI", 10F)
        dtpBirthDate.Format = DateTimePickerFormat.Short
        dtpBirthDate.Location = New Point(310, 187)
        dtpBirthDate.Name = "dtpBirthDate"
        dtpBirthDate.Size = New Size(132, 30)
        dtpBirthDate.TabIndex = 4
        ' 
        ' lblBirthDate
        ' 
        lblBirthDate.AutoSize = True
        lblBirthDate.Font = New Font("Segoe UI", 9.5F)
        lblBirthDate.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblBirthDate.Location = New Point(310, 160)
        lblBirthDate.Name = "lblBirthDate"
        lblBirthDate.Size = New Size(79, 21)
        lblBirthDate.TabIndex = 10
        lblBirthDate.Text = "Birth Date"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Font = New Font("Segoe UI", 10F)
        txtMiddleName.Location = New Point(186, 187)
        txtMiddleName.Margin = New Padding(3, 4, 3, 4)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(118, 30)
        txtMiddleName.TabIndex = 3
        ' 
        ' lblMiddleName
        ' 
        lblMiddleName.AutoSize = True
        lblMiddleName.Font = New Font("Segoe UI", 9.5F)
        lblMiddleName.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblMiddleName.Location = New Point(186, 160)
        lblMiddleName.Name = "lblMiddleName"
        lblMiddleName.Size = New Size(104, 21)
        lblMiddleName.TabIndex = 8
        lblMiddleName.Text = "Middle Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Segoe UI", 10F)
        txtFirstName.Location = New Point(362, 126)
        txtFirstName.Margin = New Padding(3, 4, 3, 4)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(237, 30)
        txtFirstName.TabIndex = 2
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI", 9.5F)
        lblFirstName.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblFirstName.Location = New Point(362, 99)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(86, 21)
        lblFirstName.TabIndex = 6
        lblFirstName.Text = "First Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Segoe UI", 10F)
        txtLastName.Location = New Point(186, 126)
        txtLastName.Margin = New Padding(3, 4, 3, 4)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(170, 30)
        txtLastName.TabIndex = 1
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Segoe UI", 9.5F)
        lblLastName.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblLastName.Location = New Point(186, 99)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(84, 21)
        lblLastName.TabIndex = 4
        lblLastName.Text = "Last Name"
        ' 
        ' txtStudentNumber
        ' 
        txtStudentNumber.Font = New Font("Segoe UI", 10F)
        txtStudentNumber.Location = New Point(30, 126)
        txtStudentNumber.Margin = New Padding(3, 4, 3, 4)
        txtStudentNumber.Name = "txtStudentNumber"
        txtStudentNumber.Size = New Size(150, 30)
        txtStudentNumber.TabIndex = 0
        ' 
        ' lblStudentNumber
        ' 
        lblStudentNumber.AutoSize = True
        lblStudentNumber.Font = New Font("Segoe UI", 9.5F)
        lblStudentNumber.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblStudentNumber.Location = New Point(30, 99)
        lblStudentNumber.Name = "lblStudentNumber"
        lblStudentNumber.Size = New Size(125, 21)
        lblStudentNumber.TabIndex = 2
        lblStudentNumber.Text = "Student Number"
        ' 
        ' frmStudentRegister
        ' 
        AcceptButton = btnRegister
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(245))
        ClientSize = New Size(1097, 756)
        Controls.Add(pnlRegisterCard)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimumSize = New Size(1113, 756)
        Name = "frmStudentRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Registration | OJT Management"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlRegisterCard.ResumeLayout(False)
        pnlRegisterCard.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblAppName As Label
    Friend WithEvents pnlRegisterCard As Panel
    Friend WithEvents lblRegisterTitle As Label
    Friend WithEvents lblPersonalHeader As Label
    Friend WithEvents txtStudentNumber As TextBox
    Friend WithEvents lblStudentNumber As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAcademicHeader As Label
    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents cboSection As ComboBox
    Friend WithEvents lblSection As Label
    Friend WithEvents lblContactLoginHeader As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents lblError As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lnkLogin As LinkLabel
End Class
