<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        lblTitle = New Label()
        lblSubtitle = New Label()
        pnlMain = New Panel()
        btnStudent = New Button()
        btnFaculty = New Button()
        lblFooter = New Label()
        pnlHeader.SuspendLayout()
        pnlMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(4, 4, 4, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Padding = New Padding(40, 50, 40, 30)
        pnlHeader.Size = New Size(1000, 200)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        lblTitle.Location = New Point(40, 50)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(199, 62)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Sign Up"
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 12.0F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblSubtitle.Location = New Point(48, 125)
        lblSubtitle.Margin = New Padding(4, 0, 4, 0)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(436, 28)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Select your role to begin your OJT journey today"
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.White
        pnlMain.Controls.Add(btnStudent)
        pnlMain.Controls.Add(btnFaculty)
        pnlMain.Controls.Add(lblFooter)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 200)
        pnlMain.Margin = New Padding(4, 4, 4, 4)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(100, 100, 100, 50)
        pnlMain.Size = New Size(1000, 550)
        pnlMain.TabIndex = 1
        ' 
        ' btnStudent
        ' 
        btnStudent.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnStudent.Cursor = Cursors.Hand
        btnStudent.FlatAppearance.BorderSize = 0
        btnStudent.FlatStyle = FlatStyle.Flat
        btnStudent.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnStudent.ForeColor = Color.White
        btnStudent.Location = New Point(100, 100)
        btnStudent.Margin = New Padding(4, 4, 4, 4)
        btnStudent.Name = "btnStudent"
        btnStudent.Size = New Size(800, 90)
        btnStudent.TabIndex = 0
        btnStudent.Text = "🎓 I'm a Student"
        btnStudent.UseVisualStyleBackColor = False
        ' 
        ' btnFaculty
        ' 
        btnFaculty.BackColor = Color.FromArgb(CByte(139), CByte(195), CByte(74))
        btnFaculty.Cursor = Cursors.Hand
        btnFaculty.FlatAppearance.BorderSize = 0
        btnFaculty.FlatStyle = FlatStyle.Flat
        btnFaculty.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btnFaculty.ForeColor = Color.White
        btnFaculty.Location = New Point(100, 220)
        btnFaculty.Margin = New Padding(4, 4, 4, 4)
        btnFaculty.Name = "btnFaculty"
        btnFaculty.Size = New Size(800, 90)
        btnFaculty.TabIndex = 1
        btnFaculty.Text = "👨‍🏫 I'm a Faculty Member"
        btnFaculty.UseVisualStyleBackColor = False
        ' 
        ' lblFooter
        ' 
        lblFooter.Dock = DockStyle.Bottom
        lblFooter.Font = New Font("Segoe UI", 9.0F)
        lblFooter.ForeColor = Color.Gray
        lblFooter.Location = New Point(100, 455)
        lblFooter.Margin = New Padding(4, 0, 4, 0)
        lblFooter.Name = "lblFooter"
        lblFooter.Size = New Size(800, 45)
        lblFooter.TabIndex = 2
        lblFooter.Text = "© 2024 OJT Management System. All rights reserved."
        lblFooter.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(120.0F, 120.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1000, 750)
        Controls.Add(pnlMain)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 4, 4, 4)
        MaximizeBox = False
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OJT Management System - Welcome"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnFaculty As Button
    Friend WithEvents lblFooter As Label
End Class