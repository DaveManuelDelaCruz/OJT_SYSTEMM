<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCompanyContactEntry
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
        lblTitle = New Label()
        pnlContent = New Panel()
        chkPrimary = New CheckBox()
        lblPrimary = New Label()
        txtContactNumber = New TextBox()
        lblContactNumber = New Label()
        txtEmail = New TextBox()
        lblEmail = New Label()
        txtPosition = New TextBox()
        lblPosition = New Label()
        txtLastName = New TextBox()
        lblLastName = New Label()
        txtFirstName = New TextBox()
        lblFirstName = New Label()
        btnCancel = New Button()
        btnSave = New Button()
        pnlHeader.SuspendLayout()
        pnlContent.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(526, 75)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(526, 75)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Company Contact"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.White
        pnlContent.Controls.Add(chkPrimary)
        pnlContent.Controls.Add(lblPrimary)
        pnlContent.Controls.Add(txtContactNumber)
        pnlContent.Controls.Add(lblContactNumber)
        pnlContent.Controls.Add(txtEmail)
        pnlContent.Controls.Add(lblEmail)
        pnlContent.Controls.Add(txtPosition)
        pnlContent.Controls.Add(lblPosition)
        pnlContent.Controls.Add(txtLastName)
        pnlContent.Controls.Add(lblLastName)
        pnlContent.Controls.Add(txtFirstName)
        pnlContent.Controls.Add(lblFirstName)
        pnlContent.Controls.Add(btnCancel)
        pnlContent.Controls.Add(btnSave)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 75)
        pnlContent.Margin = New Padding(3, 4, 3, 4)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(18, 21, 18, 21)
        pnlContent.Size = New Size(526, 405)
        pnlContent.TabIndex = 1
        ' 
        ' chkPrimary
        ' 
        chkPrimary.AutoSize = True
        chkPrimary.Location = New Point(160, 275)
        chkPrimary.Margin = New Padding(3, 4, 3, 4)
        chkPrimary.Name = "chkPrimary"
        chkPrimary.Size = New Size(18, 17)
        chkPrimary.TabIndex = 5
        chkPrimary.UseVisualStyleBackColor = True
        ' 
        ' lblPrimary
        ' 
        lblPrimary.AutoSize = True
        lblPrimary.Font = New Font("Segoe UI", 10F)
        lblPrimary.Location = New Point(37, 269)
        lblPrimary.Name = "lblPrimary"
        lblPrimary.Size = New Size(72, 23)
        lblPrimary.TabIndex = 20
        lblPrimary.Text = "Primary:"
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Font = New Font("Segoe UI", 10F)
        txtContactNumber.Location = New Point(160, 227)
        txtContactNumber.Margin = New Padding(3, 4, 3, 4)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.Size = New Size(319, 30)
        txtContactNumber.TabIndex = 4
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.Font = New Font("Segoe UI", 10F)
        lblContactNumber.Location = New Point(37, 231)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New Size(142, 23)
        lblContactNumber.TabIndex = 18
        lblContactNumber.Text = "Contact Number:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 10F)
        txtEmail.Location = New Point(160, 181)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(319, 30)
        txtEmail.TabIndex = 3
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 10F)
        lblEmail.Location = New Point(37, 185)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(55, 23)
        lblEmail.TabIndex = 16
        lblEmail.Text = "Email:"
        ' 
        ' txtPosition
        ' 
        txtPosition.Font = New Font("Segoe UI", 10F)
        txtPosition.Location = New Point(160, 136)
        txtPosition.Margin = New Padding(3, 4, 3, 4)
        txtPosition.Name = "txtPosition"
        txtPosition.Size = New Size(319, 30)
        txtPosition.TabIndex = 2
        ' 
        ' lblPosition
        ' 
        lblPosition.AutoSize = True
        lblPosition.Font = New Font("Segoe UI", 10F)
        lblPosition.Location = New Point(37, 140)
        lblPosition.Name = "lblPosition"
        lblPosition.Size = New Size(74, 23)
        lblPosition.TabIndex = 14
        lblPosition.Text = "Position:"
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Segoe UI", 10F)
        txtLastName.Location = New Point(160, 91)
        txtLastName.Margin = New Padding(3, 4, 3, 4)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(319, 30)
        txtLastName.TabIndex = 1
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Segoe UI", 10F)
        lblLastName.Location = New Point(37, 95)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(95, 23)
        lblLastName.TabIndex = 12
        lblLastName.Text = "Last Name:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Segoe UI", 10F)
        txtFirstName.Location = New Point(160, 45)
        txtFirstName.Margin = New Padding(3, 4, 3, 4)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(319, 30)
        txtFirstName.TabIndex = 0
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI", 10F)
        lblFirstName.Location = New Point(37, 49)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(96, 23)
        lblFirstName.TabIndex = 10
        lblFirstName.Text = "First Name:"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10F)
        btnCancel.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        btnCancel.Location = New Point(288, 333)
        btnCancel.Margin = New Padding(3, 4, 3, 4)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(114, 40)
        btnCancel.TabIndex = 7
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Semibold", 10F)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(160, 333)
        btnSave.Margin = New Padding(3, 4, 3, 4)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(114, 40)
        btnSave.TabIndex = 6
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' frmCompanyContactEntry
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(526, 480)
        Controls.Add(pnlContent)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmCompanyContactEntry"
        StartPosition = FormStartPosition.CenterParent
        Text = "Company Contact"
        pnlHeader.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlContent.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents lblPosition As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents chkPrimary As CheckBox
    Friend WithEvents lblPrimary As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
