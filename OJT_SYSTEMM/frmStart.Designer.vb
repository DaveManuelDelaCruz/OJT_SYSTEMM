<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStart
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlMain = New Panel()
        pnlRight = New Panel()
        pnlLoginCard = New Panel()
        btnRegistrar = New Button()
        btnFaculty = New Button()
        btnStudent = New Button()
        lblLoginAs = New Label()
        pnlLeft = New Panel()
        lblOJT = New Label()
        lblSchool = New Label()
        picLogo = New PictureBox()
        pnlMain.SuspendLayout()
        pnlRight.SuspendLayout()
        pnlLoginCard.SuspendLayout()
        pnlLeft.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.Controls.Add(pnlRight)
        pnlMain.Controls.Add(pnlLeft)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(1180, 760)
        pnlMain.TabIndex = 0
        ' 
        ' pnlRight
        ' 
        pnlRight.BackColor = Color.FromArgb(CByte(27), CByte(94), CByte(32))
        pnlRight.Controls.Add(pnlLoginCard)
        pnlRight.Dock = DockStyle.Fill
        pnlRight.Location = New Point(450, 0)
        pnlRight.Name = "pnlRight"
        pnlRight.Padding = New Padding(50)
        pnlRight.Size = New Size(730, 760)
        pnlRight.TabIndex = 0
        ' 
        ' pnlLoginCard
        ' 
        pnlLoginCard.Anchor = AnchorStyles.None
        pnlLoginCard.BackColor = Color.White
        pnlLoginCard.BorderStyle = BorderStyle.FixedSingle
        pnlLoginCard.Controls.Add(btnRegistrar)
        pnlLoginCard.Controls.Add(btnFaculty)
        pnlLoginCard.Controls.Add(btnStudent)
        pnlLoginCard.Controls.Add(lblLoginAs)
        pnlLoginCard.Location = New Point(163, 198)
        pnlLoginCard.Name = "pnlLoginCard"
        pnlLoginCard.Padding = New Padding(30)
        pnlLoginCard.Size = New Size(450, 380)
        pnlLoginCard.TabIndex = 0
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.BackColor = Color.FromArgb(CByte(0), CByte(77), CByte(0))
        btnRegistrar.Dock = DockStyle.Top
        btnRegistrar.FlatAppearance.BorderSize = 0
        btnRegistrar.FlatStyle = FlatStyle.Flat
        btnRegistrar.Font = New Font("Segoe UI Semibold", 16.0F)
        btnRegistrar.ForeColor = Color.White
        btnRegistrar.Location = New Point(30, 220)
        btnRegistrar.Margin = New Padding(0, 20, 0, 0)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(388, 65)
        btnRegistrar.TabIndex = 0
        btnRegistrar.Text = "REGISTRAR"
        btnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' btnFaculty
        ' 
        btnFaculty.BackColor = Color.FromArgb(CByte(46), CByte(125), CByte(50))
        btnFaculty.Dock = DockStyle.Top
        btnFaculty.FlatAppearance.BorderSize = 0
        btnFaculty.FlatStyle = FlatStyle.Flat
        btnFaculty.Font = New Font("Segoe UI Semibold", 16.0F)
        btnFaculty.ForeColor = Color.White
        btnFaculty.Location = New Point(30, 155)
        btnFaculty.Margin = New Padding(0, 20, 0, 0)
        btnFaculty.Name = "btnFaculty"
        btnFaculty.Size = New Size(388, 65)
        btnFaculty.TabIndex = 1
        btnFaculty.Text = "FACULTY"
        btnFaculty.UseVisualStyleBackColor = False
        ' 
        ' btnStudent
        ' 
        btnStudent.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        btnStudent.Dock = DockStyle.Top
        btnStudent.FlatAppearance.BorderSize = 0
        btnStudent.FlatStyle = FlatStyle.Flat
        btnStudent.Font = New Font("Segoe UI Semibold", 16.0F)
        btnStudent.ForeColor = Color.Black
        btnStudent.Location = New Point(30, 90)
        btnStudent.Margin = New Padding(0, 20, 0, 0)
        btnStudent.Name = "btnStudent"
        btnStudent.Size = New Size(388, 65)
        btnStudent.TabIndex = 2
        btnStudent.Text = "STUDENT"
        btnStudent.UseVisualStyleBackColor = False
        ' 
        ' lblLoginAs
        ' 
        lblLoginAs.Dock = DockStyle.Top
        lblLoginAs.Font = New Font("Segoe UI Semibold", 22.0F)
        lblLoginAs.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        lblLoginAs.Location = New Point(30, 30)
        lblLoginAs.Name = "lblLoginAs"
        lblLoginAs.Size = New Size(388, 60)
        lblLoginAs.TabIndex = 3
        lblLoginAs.Text = "Login As"
        lblLoginAs.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlLeft
        ' 
        pnlLeft.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        pnlLeft.Controls.Add(lblOJT)
        pnlLeft.Controls.Add(lblSchool)
        pnlLeft.Controls.Add(picLogo)
        pnlLeft.Dock = DockStyle.Left
        pnlLeft.Location = New Point(0, 0)
        pnlLeft.Name = "pnlLeft"
        pnlLeft.Padding = New Padding(50)
        pnlLeft.Size = New Size(450, 760)
        pnlLeft.TabIndex = 1
        ' 
        ' lblOJT
        ' 
        lblOJT.AutoSize = True
        lblOJT.Font = New Font("Segoe UI Black", 30.0F, FontStyle.Bold)
        lblOJT.ForeColor = Color.FromArgb(CByte(0), CByte(90), CByte(0))
        lblOJT.Location = New Point(84, 375)
        lblOJT.Name = "lblOJT"
        lblOJT.Size = New Size(338, 67)
        lblOJT.TabIndex = 1
        lblOJT.Text = "OJT SYSTEM"
        lblOJT.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblSchool
        ' 
        lblSchool.Font = New Font("Segoe UI Black", 26.0F, FontStyle.Bold)
        lblSchool.ForeColor = Color.FromArgb(CByte(20), CByte(50), CByte(20))
        lblSchool.Location = New Point(30, 213)
        lblSchool.Name = "lblSchool"
        lblSchool.Padding = New Padding(0, 20, 0, 0)
        lblSchool.Size = New Size(388, 162)
        lblSchool.TabIndex = 2
        lblSchool.Text = "GREEN ARCHERS COLLEGES" & vbCrLf
        lblSchool.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picLogo
        ' 
        picLogo.Dock = DockStyle.Top
        picLogo.Location = New Point(50, 50)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(350, 160)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 3
        picLogo.TabStop = False
        ' 
        ' frmStart
        ' 
        ClientSize = New Size(1180, 760)
        Controls.Add(pnlMain)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmStart"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OJT Management System - Welcome"
        pnlMain.ResumeLayout(False)
        pnlRight.ResumeLayout(False)
        pnlLoginCard.ResumeLayout(False)
        pnlLeft.ResumeLayout(False)
        pnlLeft.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub


    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents pnlRight As Panel
    Friend WithEvents pnlLoginCard As Panel

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblSchool As Label
    Friend WithEvents lblOJT As Label

    Friend WithEvents lblLoginAs As Label
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnFaculty As Button
    Friend WithEvents btnRegistrar As Button

End Class
