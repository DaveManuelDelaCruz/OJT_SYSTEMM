<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFacultyRegister
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
        pnlHeader = New Panel()
        btnBack = New Button()
        lblHeaderTitle = New Label()
        lblAppName = New Label()
        pnlRegisterCard = New Panel()
        lblRegisterTitle = New Label()
        lblPersonalHeader = New Label()
        lblLastName = New Label()
        txtLastName = New TextBox()
        lblFirstName = New Label()
        txtFirstName = New TextBox()
        lblMiddleName = New Label()
        txtMiddleName = New TextBox()
        lblBirthDate = New Label()
        dtpBirthDate = New DateTimePicker()
        lblGender = New Label()
        cboGender = New ComboBox()
        lblDepartmentHeader = New Label()
        lblDepartment = New Label()
        cboDepartment = New ComboBox()
        lblPosition = New Label()
        txtPosition = New TextBox()
        lblContactHeader = New Label()
        lblEmail = New Label()
        txtEmail = New TextBox()
        lblContactNumber = New Label()
        txtContactNumber = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        lblConfirmPassword = New Label()
        txtConfirmPassword = New TextBox()
        chkShowPassword = New CheckBox()
        lblError = New Label()
        btnRegister = New Button()
        btnClear = New Button()
        lnkLogin = New LinkLabel()
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
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1097, 96)
        pnlHeader.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(18, 24)
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
        lblHeaderTitle.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(CByte(255), CByte(241), CByte(118))
        lblHeaderTitle.Location = New Point(836, 32)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(233, 28)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "FACULTY REGISTRATION"
        ' 
        ' lblAppName
        ' 
        lblAppName.AutoSize = True
        lblAppName.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold)
        lblAppName.ForeColor = Color.White
        lblAppName.Location = New Point(146, 29)
        lblAppName.Name = "lblAppName"
        lblAppName.Size = New Size(445, 32)
        lblAppName.TabIndex = 2
        lblAppName.Text = "OJT MONITORING AND MANAGEMENT"
        ' 
        ' pnlRegisterCard
        ' 
        pnlRegisterCard.Anchor = AnchorStyles.None
        pnlRegisterCard.BackColor = Color.White
        pnlRegisterCard.BorderStyle = BorderStyle.FixedSingle
        pnlRegisterCard.Controls.Add(lblRegisterTitle)
        pnlRegisterCard.Controls.Add(lblPersonalHeader)
        pnlRegisterCard.Controls.Add(lblLastName)
        pnlRegisterCard.Controls.Add(txtLastName)
        pnlRegisterCard.Controls.Add(lblFirstName)
        pnlRegisterCard.Controls.Add(txtFirstName)
        pnlRegisterCard.Controls.Add(lblMiddleName)
        pnlRegisterCard.Controls.Add(txtMiddleName)
        pnlRegisterCard.Controls.Add(lblBirthDate)
        pnlRegisterCard.Controls.Add(dtpBirthDate)
        pnlRegisterCard.Controls.Add(lblGender)
        pnlRegisterCard.Controls.Add(cboGender)
        pnlRegisterCard.Controls.Add(lblDepartmentHeader)
        pnlRegisterCard.Controls.Add(lblDepartment)
        pnlRegisterCard.Controls.Add(cboDepartment)
        pnlRegisterCard.Controls.Add(lblPosition)
        pnlRegisterCard.Controls.Add(txtPosition)
        pnlRegisterCard.Controls.Add(lblContactHeader)
        pnlRegisterCard.Controls.Add(lblEmail)
        pnlRegisterCard.Controls.Add(txtEmail)
        pnlRegisterCard.Controls.Add(lblContactNumber)
        pnlRegisterCard.Controls.Add(txtContactNumber)
        pnlRegisterCard.Controls.Add(lblPassword)
        pnlRegisterCard.Controls.Add(txtPassword)
        pnlRegisterCard.Controls.Add(lblConfirmPassword)
        pnlRegisterCard.Controls.Add(txtConfirmPassword)
        pnlRegisterCard.Controls.Add(chkShowPassword)
        pnlRegisterCard.Controls.Add(lblError)
        pnlRegisterCard.Controls.Add(btnRegister)
        pnlRegisterCard.Controls.Add(btnClear)
        pnlRegisterCard.Controls.Add(lnkLogin)
        pnlRegisterCard.Location = New Point(188, 118)
        pnlRegisterCard.Name = "pnlRegisterCard"
        pnlRegisterCard.Padding = New Padding(27, 32, 27, 32)
        pnlRegisterCard.Size = New Size(721, 571)
        pnlRegisterCard.TabIndex = 1
        ' 
        ' lblRegisterTitle
        ' 
        lblRegisterTitle.AutoSize = True
        lblRegisterTitle.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold)
        lblRegisterTitle.ForeColor = Color.FromArgb(CByte(251), CByte(192), CByte(45))
        lblRegisterTitle.Location = New Point(27, 16)
        lblRegisterTitle.Name = "lblRegisterTitle"
        lblRegisterTitle.Size = New Size(228, 32)
        lblRegisterTitle.TabIndex = 0
        lblRegisterTitle.Text = "Faculty Registration"
        ' 
        ' lblPersonalHeader
        ' 
        lblPersonalHeader.AutoSize = True
        lblPersonalHeader.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lblPersonalHeader.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblPersonalHeader.Location = New Point(27, 56)
        lblPersonalHeader.Name = "lblPersonalHeader"
        lblPersonalHeader.Size = New Size(216, 23)
        lblPersonalHeader.TabIndex = 1
        lblPersonalHeader.Text = "PERSONAL INFORMATION"
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Segoe UI", 9.5F)
        lblLastName.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblLastName.Location = New Point(31, 84)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(84, 21)
        lblLastName.TabIndex = 2
        lblLastName.Text = "Last Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Segoe UI", 10.0F)
        txtLastName.Location = New Point(31, 108)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(170, 30)
        txtLastName.TabIndex = 3
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI", 9.5F)
        lblFirstName.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblFirstName.Location = New Point(207, 84)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(86, 21)
        lblFirstName.TabIndex = 4
        lblFirstName.Text = "First Name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Segoe UI", 10.0F)
        txtFirstName.Location = New Point(207, 108)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(200, 30)
        txtFirstName.TabIndex = 5
        ' 
        ' lblMiddleName
        ' 
        lblMiddleName.AutoSize = True
        lblMiddleName.Font = New Font("Segoe UI", 9.5F)
        lblMiddleName.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblMiddleName.Location = New Point(413, 84)
        lblMiddleName.Name = "lblMiddleName"
        lblMiddleName.Size = New Size(104, 21)
        lblMiddleName.TabIndex = 6
        lblMiddleName.Text = "Middle Name"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Font = New Font("Segoe UI", 10.0F)
        txtMiddleName.Location = New Point(413, 108)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.Size = New Size(160, 30)
        txtMiddleName.TabIndex = 7
        ' 
        ' lblBirthDate
        ' 
        lblBirthDate.AutoSize = True
        lblBirthDate.Font = New Font("Segoe UI", 9.5F)
        lblBirthDate.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblBirthDate.Location = New Point(31, 148)
        lblBirthDate.Name = "lblBirthDate"
        lblBirthDate.Size = New Size(79, 21)
        lblBirthDate.TabIndex = 8
        lblBirthDate.Text = "Birth Date"
        ' 
        ' dtpBirthDate
        ' 
        dtpBirthDate.Font = New Font("Segoe UI", 10.0F)
        dtpBirthDate.Format = DateTimePickerFormat.Short
        dtpBirthDate.Location = New Point(31, 172)
        dtpBirthDate.Name = "dtpBirthDate"
        dtpBirthDate.Size = New Size(140, 30)
        dtpBirthDate.TabIndex = 9
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Segoe UI", 9.5F)
        lblGender.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblGender.Location = New Point(187, 148)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(61, 21)
        lblGender.TabIndex = 10
        lblGender.Text = "Gender"
        ' 
        ' cboGender
        ' 
        cboGender.DropDownStyle = ComboBoxStyle.DropDownList
        cboGender.Font = New Font("Segoe UI", 10.0F)
        cboGender.Location = New Point(187, 172)
        cboGender.Name = "cboGender"
        cboGender.Size = New Size(130, 31)
        cboGender.TabIndex = 11
        ' 
        ' lblDepartmentHeader
        ' 
        lblDepartmentHeader.AutoSize = True
        lblDepartmentHeader.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lblDepartmentHeader.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblDepartmentHeader.Location = New Point(27, 212)
        lblDepartmentHeader.Name = "lblDepartmentHeader"
        lblDepartmentHeader.Size = New Size(205, 23)
        lblDepartmentHeader.TabIndex = 12
        lblDepartmentHeader.Text = "DEPARTMENT & POSITION"
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Segoe UI", 9.5F)
        lblDepartment.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblDepartment.Location = New Point(31, 239)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(93, 21)
        lblDepartment.TabIndex = 13
        lblDepartment.Text = "Department"
        ' 
        ' cboDepartment
        ' 
        cboDepartment.DropDownStyle = ComboBoxStyle.DropDownList
        cboDepartment.Font = New Font("Segoe UI", 10.0F)
        cboDepartment.Location = New Point(31, 263)
        cboDepartment.Name = "cboDepartment"
        cboDepartment.Size = New Size(350, 31)
        cboDepartment.TabIndex = 14
        ' 
        ' lblPosition
        ' 
        lblPosition.AutoSize = True
        lblPosition.Font = New Font("Segoe UI", 9.5F)
        lblPosition.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblPosition.Location = New Point(393, 239)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(65, 21)
        lblPosition.TabIndex = 15
        lblPosition.Text = "Position"
        ' 
        ' txtPosition
        ' 
        txtPosition.Font = New Font("Segoe UI", 10.0F)
        txtPosition.Location = New Point(393, 263)
        txtPosition.Name = "txtPosition"
        txtPosition.ReadOnly = True
        txtPosition.Size = New Size(180, 30)
        txtPosition.TabIndex = 16
        ' 
        ' lblContactHeader
        ' 
        lblContactHeader.AutoSize = True
        lblContactHeader.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lblContactHeader.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        lblContactHeader.Location = New Point(27, 301)
        lblContactHeader.Name = "lblContactHeader"
        lblContactHeader.Size = New Size(220, 23)
        lblContactHeader.TabIndex = 17
        lblContactHeader.Text = "CONTACT / LOGIN DETAILS"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 9.5F)
        lblEmail.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblEmail.Location = New Point(31, 329)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(48, 21)
        lblEmail.TabIndex = 18
        lblEmail.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 10.0F)
        txtEmail.Location = New Point(31, 353)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(542, 30)
        txtEmail.TabIndex = 19
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.Font = New Font("Segoe UI", 9.5F)
        lblContactNumber.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblContactNumber.Location = New Point(31, 389)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New Size(125, 21)
        lblContactNumber.TabIndex = 20
        lblContactNumber.Text = "Contact Number"
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Font = New Font("Segoe UI", 10.0F)
        txtContactNumber.Location = New Point(31, 413)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(250, 30)
        txtContactNumber.TabIndex = 21
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9.5F)
        lblPassword.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblPassword.Location = New Point(289, 389)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(76, 21)
        lblPassword.TabIndex = 22
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 10.0F)
        txtPassword.Location = New Point(289, 413)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(284, 30)
        txtPassword.TabIndex = 23
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.Font = New Font("Segoe UI", 9.5F)
        lblConfirmPassword.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblConfirmPassword.Location = New Point(289, 446)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(137, 21)
        lblConfirmPassword.TabIndex = 24
        lblConfirmPassword.Text = "Confirm Password"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Font = New Font("Segoe UI", 10.0F)
        txtConfirmPassword.Location = New Point(289, 470)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(284, 30)
        txtConfirmPassword.TabIndex = 25
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Font = New Font("Segoe UI", 8.5F)
        chkShowPassword.ForeColor = Color.FromArgb(CByte(97), CByte(97), CByte(97))
        chkShowPassword.Location = New Point(31, 452)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(134, 24)
        chkShowPassword.TabIndex = 26
        chkShowPassword.Text = "Show password"
        ' 
        ' lblError
        ' 
        lblError.AutoSize = True
        lblError.Font = New Font("Segoe UI", 9.0F)
        lblError.ForeColor = Color.FromArgb(CByte(211), CByte(47), CByte(47))
        lblError.Location = New Point(31, 504)
        lblError.Name = "lblError"
        lblError.Size = New Size(0, 20)
        lblError.TabIndex = 27
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI Semibold", 10.0F)
        btnRegister.ForeColor = Color.White
        btnRegister.Location = New Point(389, 504)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(92, 40)
        btnRegister.TabIndex = 28
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(255), CByte(241), CByte(118))
        btnClear.FlatAppearance.BorderSize = 0
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI", 9.5F)
        btnClear.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        btnClear.Location = New Point(487, 504)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(86, 40)
        btnClear.TabIndex = 29
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' lnkLogin
        ' 
        lnkLogin.ActiveLinkColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        lnkLogin.AutoSize = True
        lnkLogin.Font = New Font("Segoe UI", 9.0F)
        lnkLogin.LinkColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        lnkLogin.Location = New Point(31, 531)
        lnkLogin.Name = "lnkLogin"
        lnkLogin.Size = New Size(252, 20)
        lnkLogin.TabIndex = 30
        lnkLogin.TabStop = True
        lnkLogin.Text = "Already have an account? Login here"
        ' 
        ' frmFacultyRegister
        ' 
        AcceptButton = btnRegister
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(245))
        ClientSize = New Size(1097, 720)
        Controls.Add(pnlRegisterCard)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimumSize = New Size(1113, 756)
        Name = "frmFacultyRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Faculty Registration | OJT Management"
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
    Friend WithEvents lnkLogin As LinkLabel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblError As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblContactHeader As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents cboDepartment As ComboBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents lblPosition As Label
    Friend WithEvents lblDepartmentHeader As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents lblGender As Label
    Friend WithEvents dtpBirthDate As DateTimePicker
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblPersonalHeader As Label
    Friend WithEvents lblRegisterTitle As Label

End Class
