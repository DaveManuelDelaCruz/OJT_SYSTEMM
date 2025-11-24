<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCompanyEntry
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.lblWebsite = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.lblContactNumber = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtIndustry = New System.Windows.Forms.TextBox()
        Me.lblIndustry = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.SuspendLayout()
        '
        ' pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(76, 175, 80)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(520, 56)
        Me.pnlHeader.TabIndex = 0
        '
        ' lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(520, 56)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Company"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        ' pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.White
        Me.pnlContent.Controls.Add(Me.cboStatus)
        Me.pnlContent.Controls.Add(Me.lblStatus)
        Me.pnlContent.Controls.Add(Me.txtWebsite)
        Me.pnlContent.Controls.Add(Me.lblWebsite)
        Me.pnlContent.Controls.Add(Me.txtContactNumber)
        Me.pnlContent.Controls.Add(Me.lblContactNumber)
        Me.pnlContent.Controls.Add(Me.txtEmail)
        Me.pnlContent.Controls.Add(Me.lblEmail)
        Me.pnlContent.Controls.Add(Me.txtIndustry)
        Me.pnlContent.Controls.Add(Me.lblIndustry)
        Me.pnlContent.Controls.Add(Me.txtCity)
        Me.pnlContent.Controls.Add(Me.lblCity)
        Me.pnlContent.Controls.Add(Me.txtAddress)
        Me.pnlContent.Controls.Add(Me.lblAddress)
        Me.pnlContent.Controls.Add(Me.txtCompanyName)
        Me.pnlContent.Controls.Add(Me.lblCompanyName)
        Me.pnlContent.Controls.Add(Me.btnCancel)
        Me.pnlContent.Controls.Add(Me.btnSave)
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(0, 56)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlContent.Size = New System.Drawing.Size(520, 344)
        Me.pnlContent.TabIndex = 1
        '
        ' cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Location = New System.Drawing.Point(140, 248)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(160, 25)
        Me.cboStatus.TabIndex = 7
        '
        ' lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66)
        Me.lblStatus.Location = New System.Drawing.Point(32, 251)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(48, 19)
        Me.lblStatus.TabIndex = 16
        Me.lblStatus.Text = "Status:"
        '
        ' txtWebsite
        '
        Me.txtWebsite.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtWebsite.Location = New System.Drawing.Point(140, 214)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(320, 25)
        Me.txtWebsite.TabIndex = 6
        '
        ' lblWebsite
        '
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblWebsite.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66)
        Me.lblWebsite.Location = New System.Drawing.Point(32, 217)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(60, 19)
        Me.lblWebsite.TabIndex = 14
        Me.lblWebsite.Text = "Website:"
        '
        ' txtContactNumber
        '
        Me.txtContactNumber.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtContactNumber.Location = New System.Drawing.Point(140, 180)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(320, 25)
        Me.txtContactNumber.TabIndex = 5
        '
        ' lblContactNumber
        '
        Me.lblContactNumber.AutoSize = True
        Me.lblContactNumber.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblContactNumber.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66)
        Me.lblContactNumber.Location = New System.Drawing.Point(32, 183)
        Me.lblContactNumber.Name = "lblContactNumber"
        Me.lblContactNumber.Size = New System.Drawing.Size(104, 19)
        Me.lblContactNumber.TabIndex = 12
        Me.lblContactNumber.Text = "Contact No. / #:"
        '
        ' txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEmail.Location = New System.Drawing.Point(140, 146)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(320, 25)
        Me.txtEmail.TabIndex = 4
        '
        ' lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66)
        Me.lblEmail.Location = New System.Drawing.Point(32, 149)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 19)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email:"
        '
        ' txtIndustry
        '
        Me.txtIndustry.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtIndustry.Location = New System.Drawing.Point(140, 112)
        Me.txtIndustry.Name = "txtIndustry"
        Me.txtIndustry.Size = New System.Drawing.Size(320, 25)
        Me.txtIndustry.TabIndex = 3
        '
        ' lblIndustry
        '
        Me.lblIndustry.AutoSize = True
        Me.lblIndustry.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblIndustry.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66)
        Me.lblIndustry.Location = New System.Drawing.Point(32, 115)
        Me.lblIndustry.Name = "lblIndustry"
        Me.lblIndustry.Size = New System.Drawing.Size(60, 19)
        Me.lblIndustry.TabIndex = 8
        Me.lblIndustry.Text = "Industry:"
        '
        ' txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCity.Location = New System.Drawing.Point(140, 78)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(320, 25)
        Me.txtCity.TabIndex = 2
        '
        ' lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCity.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66)
        Me.lblCity.Location = New System.Drawing.Point(32, 81)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(35, 19)
        Me.lblCity.TabIndex = 6
        Me.lblCity.Text = "City:"
        '
        ' txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAddress.Location = New System.Drawing.Point(140, 44)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(320, 25)
        Me.txtAddress.TabIndex = 1
        '
        ' lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblAddress.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66)
        Me.lblAddress.Location = New System.Drawing.Point(32, 47)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(60, 19)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Address:"
        '
        ' txtCompanyName
        '
        Me.txtCompanyName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCompanyName.Location = New System.Drawing.Point(140, 10)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(320, 25)
        Me.txtCompanyName.TabIndex = 0
        '
        ' lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66)
        Me.lblCompanyName.Location = New System.Drawing.Point(32, 13)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(107, 19)
        Me.lblCompanyName.TabIndex = 2
        Me.lblCompanyName.Text = "Company Name:"
        '
        ' btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(224, 224, 224)
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(66, 66, 66)
        Me.btnCancel.Location = New System.Drawing.Point(248, 296)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 30)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        ' btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(76, 175, 80)
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(140, 296)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        ' frmCompanyEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(520, 400)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompanyEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Company"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
        Me.pnlContent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtIndustry As TextBox
    Friend WithEvents lblIndustry As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents txtWebsite As TextBox
    Friend WithEvents lblWebsite As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
