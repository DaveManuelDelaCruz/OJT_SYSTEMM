<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoginRegistrar
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
        chkShowPassword = New CheckBox()
        lblLoginMessage = New Label()
        btnLogin = New Button()
        txtPassword = New TextBox()
        lblPassword = New Label()
        txtEmail = New TextBox()
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
        pnlHeader.Size = New Size(1100, 90)
        pnlHeader.TabIndex = 0
        ' 
        ' btnBack
        ' 
        btnBack.FlatAppearance.BorderSize = 0
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(18, 20)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(110, 45)
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
        lblHeaderTitle.Location = New Point(860, 30)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(178, 28)
        lblHeaderTitle.TabIndex = 2
        lblHeaderTitle.Text = "REGISTRAR LOGIN"
        ' 
        ' lblAppName
        ' 
        lblAppName.AutoSize = True
        lblAppName.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold)
        lblAppName.ForeColor = Color.White
        lblAppName.Location = New Point(150, 28)
        lblAppName.Name = "lblAppName"
        lblAppName.Size = New Size(445, 32)
        lblAppName.TabIndex = 1
        lblAppName.Text = "OJT MONITORING AND MANAGEMENT"
        ' 
        ' pnlLoginCard
        ' 
        pnlLoginCard.Anchor = AnchorStyles.None
        pnlLoginCard.BackColor = Color.White
        pnlLoginCard.BorderStyle = BorderStyle.FixedSingle
        pnlLoginCard.Controls.Add(chkShowPassword)
        pnlLoginCard.Controls.Add(lblLoginMessage)
        pnlLoginCard.Controls.Add(btnLogin)
        pnlLoginCard.Controls.Add(txtPassword)
        pnlLoginCard.Controls.Add(lblPassword)
        pnlLoginCard.Controls.Add(txtEmail)
        pnlLoginCard.Controls.Add(lblEmail)
        pnlLoginCard.Controls.Add(lblLoginTitle)
        pnlLoginCard.Location = New Point(330, 150)
        pnlLoginCard.Name = "pnlLoginCard"
        pnlLoginCard.Padding = New Padding(25)
        pnlLoginCard.Size = New Size(450, 380)
        pnlLoginCard.TabIndex = 1
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(32, 230)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(132, 24)
        chkShowPassword.TabIndex = 4
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' lblLoginMessage
        ' 
        lblLoginMessage.AutoSize = True
        lblLoginMessage.Font = New Font("Segoe UI", 9.0F)
        lblLoginMessage.ForeColor = Color.FromArgb(CByte(211), CByte(47), CByte(47))
        lblLoginMessage.Location = New Point(28, 260)
        lblLoginMessage.Name = "lblLoginMessage"
        lblLoginMessage.Size = New Size(0, 20)
        lblLoginMessage.TabIndex = 7
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 10.0F)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(32, 290)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(385, 45)
        btnLogin.TabIndex = 5
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 10.0F)
        txtPassword.Location = New Point(32, 190)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(385, 30)
        txtPassword.TabIndex = 3
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 9.5F)
        lblPassword.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblPassword.Location = New Point(32, 165)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(76, 21)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 10.0F)
        txtEmail.Location = New Point(32, 115)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(385, 30)
        txtEmail.TabIndex = 2
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 9.5F)
        lblEmail.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblEmail.Location = New Point(32, 90)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(48, 21)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' lblLoginTitle
        ' 
        lblLoginTitle.AutoSize = True
        lblLoginTitle.Font = New Font("Segoe UI Semibold", 14.0F, FontStyle.Bold)
        lblLoginTitle.ForeColor = Color.FromArgb(CByte(251), CByte(192), CByte(45))
        lblLoginTitle.Location = New Point(25, 35)
        lblLoginTitle.Name = "lblLoginTitle"
        lblLoginTitle.Size = New Size(304, 32)
        lblLoginTitle.TabIndex = 1
        lblLoginTitle.Text = "Login to Registrar Account"
        ' 
        ' frmLoginRegistrar
        ' 
        AcceptButton = btnLogin
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(245))
        ClientSize = New Size(1100, 720)
        Controls.Add(pnlLoginCard)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmLoginRegistrar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Registrar Login | OJT Management"
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
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents lblLoginMessage As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblLoginTitle As Label

End Class
