<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentDetailsPopup
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
        btnClose = New Button()
        pnlBody = New Panel()
        lblCompanyValue = New Label()
        lblCompany = New Label()
        lblInternshipStatusValue = New Label()
        lblInternshipStatus = New Label()
        lblContactValue = New Label()
        lblContact = New Label()
        lblEmailValue = New Label()
        lblEmail = New Label()
        lblAddressValue = New Label()
        lblAddress = New Label()
        lblCourseValue = New Label()
        lblCourse = New Label()
        lblStudentNumberValue = New Label()
        lblStudentNumber = New Label()
        lblNameValue = New Label()
        lblName = New Label()
        pnlHeader.SuspendLayout()
        pnlBody.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(27), CByte(94), CByte(32))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(btnClose)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(594, 69)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = DockStyle.Fill
        lblTitle.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(535, 69)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Student Details"
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnClose
        ' 
        btnClose.Dock = DockStyle.Right
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(535, 0)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(59, 69)
        btnClose.TabIndex = 0
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Color.White
        pnlBody.Controls.Add(lblCompanyValue)
        pnlBody.Controls.Add(lblCompany)
        pnlBody.Controls.Add(lblInternshipStatusValue)
        pnlBody.Controls.Add(lblInternshipStatus)
        pnlBody.Controls.Add(lblContactValue)
        pnlBody.Controls.Add(lblContact)
        pnlBody.Controls.Add(lblEmailValue)
        pnlBody.Controls.Add(lblEmail)
        pnlBody.Controls.Add(lblAddressValue)
        pnlBody.Controls.Add(lblAddress)
        pnlBody.Controls.Add(lblCourseValue)
        pnlBody.Controls.Add(lblCourse)
        pnlBody.Controls.Add(lblStudentNumberValue)
        pnlBody.Controls.Add(lblStudentNumber)
        pnlBody.Controls.Add(lblNameValue)
        pnlBody.Controls.Add(lblName)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 69)
        pnlBody.Margin = New Padding(3, 4, 3, 4)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New Padding(27, 32, 27, 32)
        pnlBody.Size = New Size(594, 451)
        pnlBody.TabIndex = 1
        ' 
        ' lblCompanyValue
        ' 
        lblCompanyValue.AutoSize = True
        lblCompanyValue.Font = New Font("Segoe UI", 10F)
        lblCompanyValue.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCompanyValue.Location = New Point(183, 277)
        lblCompanyValue.Name = "lblCompanyValue"
        lblCompanyValue.Size = New Size(17, 23)
        lblCompanyValue.TabIndex = 15
        lblCompanyValue.Text = "-"
        ' 
        ' lblCompany
        ' 
        lblCompany.AutoSize = True
        lblCompany.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblCompany.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCompany.Location = New Point(27, 277)
        lblCompany.Name = "lblCompany"
        lblCompany.Size = New Size(88, 23)
        lblCompany.TabIndex = 14
        lblCompany.Text = "Company:"
        ' 
        ' lblInternshipStatusValue
        ' 
        lblInternshipStatusValue.AutoSize = True
        lblInternshipStatusValue.Font = New Font("Segoe UI", 10F)
        lblInternshipStatusValue.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblInternshipStatusValue.Location = New Point(183, 235)
        lblInternshipStatusValue.Name = "lblInternshipStatusValue"
        lblInternshipStatusValue.Size = New Size(17, 23)
        lblInternshipStatusValue.TabIndex = 13
        lblInternshipStatusValue.Text = "-"
        ' 
        ' lblInternshipStatus
        ' 
        lblInternshipStatus.AutoSize = True
        lblInternshipStatus.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblInternshipStatus.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblInternshipStatus.Location = New Point(27, 235)
        lblInternshipStatus.Name = "lblInternshipStatus"
        lblInternshipStatus.Size = New Size(143, 23)
        lblInternshipStatus.TabIndex = 12
        lblInternshipStatus.Text = "Internship Status:"
        ' 
        ' lblContactValue
        ' 
        lblContactValue.AutoSize = True
        lblContactValue.Font = New Font("Segoe UI", 10F)
        lblContactValue.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblContactValue.Location = New Point(183, 363)
        lblContactValue.Name = "lblContactValue"
        lblContactValue.Size = New Size(17, 23)
        lblContactValue.TabIndex = 11
        lblContactValue.Text = "-"
        ' 
        ' lblContact
        ' 
        lblContact.AutoSize = True
        lblContact.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblContact.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblContact.Location = New Point(27, 363)
        lblContact.Name = "lblContact"
        lblContact.Size = New Size(74, 23)
        lblContact.TabIndex = 10
        lblContact.Text = "Contact:"
        ' 
        ' lblEmailValue
        ' 
        lblEmailValue.AutoSize = True
        lblEmailValue.Font = New Font("Segoe UI", 10F)
        lblEmailValue.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblEmailValue.Location = New Point(183, 320)
        lblEmailValue.Name = "lblEmailValue"
        lblEmailValue.Size = New Size(17, 23)
        lblEmailValue.TabIndex = 9
        lblEmailValue.Text = "-"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblEmail.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblEmail.Location = New Point(27, 320)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(55, 23)
        lblEmail.TabIndex = 8
        lblEmail.Text = "Email:"
        ' 
        ' lblAddressValue
        ' 
        lblAddressValue.Font = New Font("Segoe UI", 10F)
        lblAddressValue.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblAddressValue.Location = New Point(183, 192)
        lblAddressValue.Name = "lblAddressValue"
        lblAddressValue.Size = New Size(366, 32)
        lblAddressValue.TabIndex = 7
        lblAddressValue.Text = "-"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblAddress.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblAddress.Location = New Point(27, 192)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(74, 23)
        lblAddress.TabIndex = 6
        lblAddress.Text = "Address:"
        ' 
        ' lblCourseValue
        ' 
        lblCourseValue.AutoSize = True
        lblCourseValue.Font = New Font("Segoe UI", 10F)
        lblCourseValue.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCourseValue.Location = New Point(183, 149)
        lblCourseValue.Name = "lblCourseValue"
        lblCourseValue.Size = New Size(17, 23)
        lblCourseValue.TabIndex = 5
        lblCourseValue.Text = "-"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblCourse.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblCourse.Location = New Point(27, 149)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(67, 23)
        lblCourse.TabIndex = 4
        lblCourse.Text = "Course:"
        ' 
        ' lblStudentNumberValue
        ' 
        lblStudentNumberValue.AutoSize = True
        lblStudentNumberValue.Font = New Font("Segoe UI", 10F)
        lblStudentNumberValue.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblStudentNumberValue.Location = New Point(183, 107)
        lblStudentNumberValue.Name = "lblStudentNumberValue"
        lblStudentNumberValue.Size = New Size(17, 23)
        lblStudentNumberValue.TabIndex = 3
        lblStudentNumberValue.Text = "-"
        ' 
        ' lblStudentNumber
        ' 
        lblStudentNumber.AutoSize = True
        lblStudentNumber.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblStudentNumber.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblStudentNumber.Location = New Point(27, 107)
        lblStudentNumber.Name = "lblStudentNumber"
        lblStudentNumber.Size = New Size(143, 23)
        lblStudentNumber.TabIndex = 2
        lblStudentNumber.Text = "Student Number:"
        ' 
        ' lblNameValue
        ' 
        lblNameValue.AutoSize = True
        lblNameValue.Font = New Font("Segoe UI", 10F)
        lblNameValue.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblNameValue.Location = New Point(183, 64)
        lblNameValue.Name = "lblNameValue"
        lblNameValue.Size = New Size(17, 23)
        lblNameValue.TabIndex = 1
        lblNameValue.Text = "-"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblName.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblName.Location = New Point(27, 64)
        lblName.Name = "lblName"
        lblName.Size = New Size(60, 23)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' frmStudentDetailsPopup
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(594, 520)
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmStudentDetailsPopup"
        StartPosition = FormStartPosition.CenterParent
        Text = "Student Details"
        pnlHeader.ResumeLayout(False)
        pnlBody.ResumeLayout(False)
        pnlBody.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlBody As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents lblNameValue As Label
    Friend WithEvents lblStudentNumber As Label
    Friend WithEvents lblStudentNumberValue As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblCourseValue As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblAddressValue As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblEmailValue As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblContactValue As Label
    Friend WithEvents lblInternshipStatus As Label
    Friend WithEvents lblInternshipStatusValue As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblCompanyValue As Label
End Class
