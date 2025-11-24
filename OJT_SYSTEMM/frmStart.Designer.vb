<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStart
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
        pnlMain = New Panel()
        pnlContent = New Panel()
        pnlButtons = New Panel()
        btnFaculty = New Button()
        btnStudent = New Button()
        lblSelectType = New Label()
        pnlHeader = New Panel()
        lblSubtitle = New Label()
        lblTitle = New Label()
        pnlMain.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlButtons.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(245))
        pnlMain.Controls.Add(pnlContent)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(48)
        pnlMain.Size = New Size(1000, 750)
        pnlMain.TabIndex = 0
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.White
        pnlContent.Controls.Add(pnlButtons)
        pnlContent.Controls.Add(lblSelectType)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(48, 208)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(64, 56, 64, 64)
        pnlContent.Size = New Size(904, 494)
        pnlContent.TabIndex = 1
        ' 
        ' pnlButtons
        ' 
        pnlButtons.Controls.Add(btnFaculty)
        pnlButtons.Controls.Add(btnStudent)
        pnlButtons.Dock = DockStyle.Fill
        pnlButtons.Location = New Point(64, 112)
        pnlButtons.Name = "pnlButtons"
        pnlButtons.Padding = New Padding(80, 0, 80, 0)
        pnlButtons.Size = New Size(776, 318)
        pnlButtons.TabIndex = 1
        ' 
        ' btnFaculty
        ' 
        btnFaculty.BackColor = Color.FromArgb(CByte(76), CByte(175), CByte(80))
        btnFaculty.Cursor = Cursors.Hand
        btnFaculty.Dock = DockStyle.Top
        btnFaculty.FlatAppearance.BorderSize = 0
        btnFaculty.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(56), CByte(142), CByte(60))
        btnFaculty.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(66), CByte(160), CByte(70))
        btnFaculty.FlatStyle = FlatStyle.Flat
        btnFaculty.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        btnFaculty.ForeColor = Color.White
        btnFaculty.Location = New Point(80, 80)
        btnFaculty.Margin = New Padding(0)
        btnFaculty.Name = "btnFaculty"
        btnFaculty.Size = New Size(616, 80)
        btnFaculty.TabIndex = 1
        btnFaculty.Text = "LOGIN AS FACULTY"
        btnFaculty.UseVisualStyleBackColor = False
        ' 
        ' btnStudent
        ' 
        btnStudent.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        btnStudent.Cursor = Cursors.Hand
        btnStudent.Dock = DockStyle.Top
        btnStudent.FlatAppearance.BorderSize = 0
        btnStudent.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(255), CByte(160), CByte(0))
        btnStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(179), CByte(0))
        btnStudent.FlatStyle = FlatStyle.Flat
        btnStudent.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold)
        btnStudent.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        btnStudent.Location = New Point(80, 0)
        btnStudent.Margin = New Padding(0, 0, 0, 16)
        btnStudent.Name = "btnStudent"
        btnStudent.Size = New Size(616, 80)
        btnStudent.TabIndex = 0
        btnStudent.Text = "LOGIN AS STUDENT"
        btnStudent.UseVisualStyleBackColor = False
        ' 
        ' lblSelectType
        ' 
        lblSelectType.Dock = DockStyle.Top
        lblSelectType.Font = New Font("Segoe UI", 12F)
        lblSelectType.ForeColor = Color.FromArgb(CByte(117), CByte(117), CByte(117))
        lblSelectType.Location = New Point(64, 56)
        lblSelectType.Name = "lblSelectType"
        lblSelectType.Size = New Size(776, 56)
        lblSelectType.TabIndex = 0
        lblSelectType.Text = "Select Your Login Type"
        lblSelectType.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(255), CByte(193), CByte(7))
        pnlHeader.Controls.Add(lblSubtitle)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(48, 48)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Padding = New Padding(48, 40, 48, 40)
        pnlHeader.Size = New Size(904, 160)
        pnlHeader.TabIndex = 0
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.Dock = DockStyle.Top
        lblSubtitle.Font = New Font("Segoe UI", 11F)
        lblSubtitle.ForeColor = Color.FromArgb(CByte(66), CByte(66), CByte(66))
        lblSubtitle.Location = New Point(48, 88)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(808, 32)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Monitoring and Tracking System"
        lblSubtitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = DockStyle.Top
        lblTitle.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold)
        lblTitle.ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        lblTitle.Location = New Point(48, 40)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(808, 48)
        lblTitle.TabIndex = 0
        lblTitle.Text = "OJT MANAGEMENT SYSTEM"
        lblTitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' frmStart
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1000, 750)
        Controls.Add(pnlMain)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimumSize = New Size(1000, 750)
        Name = "frmStart"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OJT Management System - Welcome"
        pnlMain.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlButtons.ResumeLayout(False)
        pnlHeader.ResumeLayout(False)
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents lblSelectType As Label
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnFaculty As Button
End Class