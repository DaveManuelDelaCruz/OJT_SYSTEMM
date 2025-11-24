<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoginFaculty
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
        Me.pnlHeader = New Panel()
        Me.btnBack = New Button()
        Me.lblHeaderTitle = New Label()
        Me.lblAppName = New Label()
        Me.pnlLoginCard = New Panel()
        Me.lnkRegisterFaculty = New LinkLabel()
        Me.chkShowPassword = New CheckBox()
        Me.lblLoginMessage = New Label()
        Me.btnLogin = New Button()
        Me.txtPassword = New TextBox()
        Me.lblPassword = New Label()
        Me.txtEmail = New TextBox()
        Me.lblEmail = New Label()
        Me.lblLoginTitle = New Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlLoginCard.SuspendLayout()
        Me.SuspendLayout()
        '
        ' pnlHeader
        '
        Me.pnlHeader.BackColor = Color.FromArgb(27, 94, 32)
        Me.pnlHeader.Controls.Add(Me.btnBack)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Controls.Add(Me.lblAppName)
        Me.pnlHeader.Dock = DockStyle.Top
        Me.pnlHeader.Location = New Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New Size(1100, 90)
        Me.pnlHeader.TabIndex = 0
        '
        ' btnBack
        '
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = FlatStyle.Flat
        Me.btnBack.Font = New Font("Segoe UI Semibold", 10.0!, FontStyle.Bold)
        Me.btnBack.ForeColor = Color.White
        Me.btnBack.Location = New Point(18, 20)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New Size(110, 45)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "← Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        ' lblHeaderTitle
        '
        Me.lblHeaderTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New Font("Segoe UI Semibold", 12.0!, FontStyle.Bold)
        Me.lblHeaderTitle.ForeColor = Color.FromArgb(255, 241, 118)
        Me.lblHeaderTitle.Location = New Point(860, 30)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New Size(158, 28)
        Me.lblHeaderTitle.Text = "FACULTY LOGIN"
        '
        ' lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.Font = New Font("Segoe UI Semibold", 14.0!, FontStyle.Bold)
        Me.lblAppName.ForeColor = Color.White
        Me.lblAppName.Location = New Point(150, 28)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New Size(445, 32)
        Me.lblAppName.Text = "OJT MONITORING AND MANAGEMENT"
        '
        ' pnlLoginCard
        '
        Me.pnlLoginCard.Anchor = AnchorStyles.None
        Me.pnlLoginCard.BackColor = Color.White
        Me.pnlLoginCard.BorderStyle = BorderStyle.FixedSingle
        Me.pnlLoginCard.Controls.Add(Me.lnkRegisterFaculty)
        Me.pnlLoginCard.Controls.Add(Me.chkShowPassword)
        Me.pnlLoginCard.Controls.Add(Me.lblLoginMessage)
        Me.pnlLoginCard.Controls.Add(Me.btnLogin)
        Me.pnlLoginCard.Controls.Add(Me.txtPassword)
        Me.pnlLoginCard.Controls.Add(Me.lblPassword)
        Me.pnlLoginCard.Controls.Add(Me.txtEmail)
        Me.pnlLoginCard.Controls.Add(Me.lblEmail)
        Me.pnlLoginCard.Controls.Add(Me.lblLoginTitle)
        Me.pnlLoginCard.Location = New Point(330, 150)
        Me.pnlLoginCard.Name = "pnlLoginCard"
        Me.pnlLoginCard.Padding = New Padding(25)
        Me.pnlLoginCard.Size = New Size(450, 420)
        Me.pnlLoginCard.TabIndex = 1
        '
        ' lnkRegisterFaculty
        '
        Me.lnkRegisterFaculty.AutoSize = True
        Me.lnkRegisterFaculty.LinkColor = Color.FromArgb(76, 175, 80)
        Me.lnkRegisterFaculty.ActiveLinkColor = Color.FromArgb(56, 142, 60)
        Me.lnkRegisterFaculty.Font = New Font("Segoe UI", 9.0!, FontStyle.Underline)
        Me.lnkRegisterFaculty.Location = New Point(28, 355)
        Me.lnkRegisterFaculty.Name = "lnkRegisterFaculty"
        Me.lnkRegisterFaculty.Size = New Size(220, 20)
        Me.lnkRegisterFaculty.Text = "Don't have an account? Register"
        '
        ' chkShowPassword
        '
        Me.chkShowPassword.AutoSize = True
        Me.chkShowPassword.Location = New Point(32, 240)
        Me.chkShowPassword.Name = "chkShowPassword"
        Me.chkShowPassword.Size = New Size(136, 24)
        Me.chkShowPassword.Text = "Show Password"
        '
        ' lblLoginMessage
        '
        Me.lblLoginMessage.AutoSize = True
        Me.lblLoginMessage.ForeColor = Color.FromArgb(211, 47, 47)
        Me.lblLoginMessage.Font = New Font("Segoe UI", 9.0!)
        Me.lblLoginMessage.Location = New Point(28, 280)
        Me.lblLoginMessage.Name = "lblLoginMessage"
        Me.lblLoginMessage.Size = New Size(0, 20)
        '
        ' btnLogin
        '
        Me.btnLogin.BackColor = Color.FromArgb(76, 175, 80)
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = FlatStyle.Flat
        Me.btnLogin.Font = New Font("Segoe UI Semibold", 10.0!)
        Me.btnLogin.ForeColor = Color.White
        Me.btnLogin.Location = New Point(32, 310)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New Size(385, 45)
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        ' txtPassword
        '
        Me.txtPassword.Font = New Font("Segoe UI", 10.0!)
        Me.txtPassword.Location = New Point(32, 200)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New Size(385, 30)
        Me.txtPassword.UseSystemPasswordChar = True
        '
        ' lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New Font("Segoe UI", 9.5!)
        Me.lblPassword.ForeColor = Color.FromArgb(66, 66, 66)
        Me.lblPassword.Location = New Point(32, 175)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Text = "Password"
        '
        ' txtEmail
        '
        Me.txtEmail.Font = New Font("Segoe UI", 10.0!)
        Me.txtEmail.Location = New Point(32, 120)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New Size(385, 30)
        '
        ' lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New Font("Segoe UI", 9.5!)
        Me.lblEmail.ForeColor = Color.FromArgb(66, 66, 66)
        Me.lblEmail.Location = New Point(32, 95)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Text = "Email"
        '
        ' lblLoginTitle
        '
        Me.lblLoginTitle.AutoSize = True
        Me.lblLoginTitle.Font = New Font("Segoe UI Semibold", 14.0!, FontStyle.Bold)
        Me.lblLoginTitle.ForeColor = Color.FromArgb(251, 192, 45)
        Me.lblLoginTitle.Location = New Point(25, 35)
        Me.lblLoginTitle.Name = "lblLoginTitle"
        Me.lblLoginTitle.Size = New Size(265, 32)
        Me.lblLoginTitle.Text = "Login to Faculty Account"
        '
        ' frmLoginFaculty
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.FromArgb(250, 250, 245)
        Me.ClientSize = New Size(1100, 720)
        Me.Controls.Add(Me.pnlLoginCard)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Faculty Login | OJT Management"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlLoginCard.ResumeLayout(False)
        Me.pnlLoginCard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblAppName As Label
    Friend WithEvents pnlLoginCard As Panel
    Friend WithEvents lnkRegisterFaculty As LinkLabel
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents lblLoginMessage As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblLoginTitle As Label

End Class
