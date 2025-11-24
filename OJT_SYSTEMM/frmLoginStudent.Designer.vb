<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoginStudent
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
        pnlLoginCard = New Panel()
        lblLoginMessage = New Label()
        lnkRegister = New LinkLabel()
        chkShowPassword = New CheckBox()
        btnLogin = New Button()
        txtLoginPassword = New TextBox()
        lblPassword = New Label()
        txtLoginEmail = New TextBox()
        lblEmail = New Label()
        lblLoginTitle = New Label()
        pnlHeader.SuspendLayout()
        pnlLoginCard.SuspendLayout()
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
        pnlHeader.TabIndex = 1
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
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblHeaderTitle.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(CByte(255), CByte(241), CByte(118))
        lblHeaderTitle.Location = New Point(880, 32)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(100, 23)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "STUDENT LOGIN"
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
        ' pnlLoginCard
        ' 
        pnlLoginCard.Anchor = AnchorStyles.None
        pnlLoginCard.BackColor = Color.White
        pnlLoginCard.BorderStyle = BorderStyle.FixedSingle
        pnlLoginCard.Controls.Add(lblLoginMessage)
        pnlLoginCard.Controls.Add(lnkRegister)
        pnlLoginCard.Controls.Add(chkShowPassword)
        pnlLoginCard.Controls.Add(btnLogin)
        pnlLoginCard.Controls.Add(txtLoginPassword)
        pnlLoginCard.Controls.Add(lblPassword)
        pnlLoginCard.Controls.Add(txtLoginEmail)
        pnlLoginCard.Controls.Add(lblEmail)
        pnlLoginCard.Controls.Add(lblLoginTitle)
        pnlLoginCard.Location = New Point(320, 160)
        pnlLoginCard.Name = "pnlLoginCard"
        pnlLoginCard.Size = New Size(457, 420)
        pnlLoginCard.TabIndex = 0
        ' 
        ' lblLoginMessage
        ' 
        lblLoginMessage.AutoSize = True
        lblLoginMessage.Font = New Font("Segoe UI", 9.0F)
        lblLoginMessage.ForeColor = Color.FromArgb(CByte(211), CByte(47), CByte(47))
        lblLoginMessage.Location = New Point(31, 380)
        lblLoginMessage.Name = "lblLoginMessage"
        lblLoginMessage.Size = New Size(0, 20)
        lblLoginMessage.TabIndex = 0
        ' 
        ' lnkRegister
        ' 
        lnkRegister.AutoSize = True
        lnkRegister.Font = New Font("Segoe UI", 9.0F)
        lnkRegister.Location = New Point(31, 345)
        lnkRegister.Name = "lnkRegister"
        lnkRegister.Size = New Size(221, 20)
        lnkRegister.TabIndex = 1
        lnkRegister.TabStop = True
        lnkRegister.Text = "Don't have an account? Register"
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Font = New Font("Segoe UI", 9.0F)
        chkShowPassword.ForeColor = Color.Gray
        chkShowPassword.Location = New Point(31, 230)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(132, 24)
        chkShowPassword.TabIndex = 2
        chkShowPassword.Text = "Show Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 10.0F)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(31, 275)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(393, 53)
        btnLogin.TabIndex = 3
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtLoginPassword
        ' 
        txtLoginPassword.Font = New Font("Segoe UI", 10.0F)
        txtLoginPassword.Location = New Point(31, 194)
        txtLoginPassword.Name = "txtLoginPassword"
        txtLoginPassword.Size = New Size(393, 30)
        txtLoginPassword.TabIndex = 4
        txtLoginPassword.UseSystemPasswordChar = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9.5F)
        lblPassword.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblPassword.Location = New Point(31, 168)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(76, 21)
        lblPassword.TabIndex = 5
        lblPassword.Text = "Password"
        ' 
        ' txtLoginEmail
        ' 
        txtLoginEmail.Font = New Font("Segoe UI", 10.0F)
        txtLoginEmail.Location = New Point(31, 123)
        txtLoginEmail.Name = "txtLoginEmail"
        txtLoginEmail.Size = New Size(393, 30)
        txtLoginEmail.TabIndex = 6
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 9.5F)
        lblEmail.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblEmail.Location = New Point(31, 97)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(48, 21)
        lblEmail.TabIndex = 7
        lblEmail.Text = "Email"
        ' 
        ' lblLoginTitle
        ' 
        lblLoginTitle.AutoSize = True
        lblLoginTitle.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold)
        lblLoginTitle.ForeColor = Color.FromArgb(CByte(251), CByte(192), CByte(45))
        lblLoginTitle.Location = New Point(27, 30)
        lblLoginTitle.Name = "lblLoginTitle"
        lblLoginTitle.Size = New Size(292, 32)
        lblLoginTitle.TabIndex = 8
        lblLoginTitle.Text = "Login to Student Account"
        ' 
        ' frmLoginStudent
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(245))
        ClientSize = New Size(1097, 720)
        Controls.Add(pnlLoginCard)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmLoginStudent"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Student Login"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlLoginCard.ResumeLayout(False)
        pnlLoginCard.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblAppName As Label
    Friend WithEvents pnlLoginCard As Panel
    Friend WithEvents lblLoginTitle As Label
    Friend WithEvents txtLoginEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtLoginPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lnkRegister As LinkLabel
    Friend WithEvents lblLoginMessage As Label

End Class
