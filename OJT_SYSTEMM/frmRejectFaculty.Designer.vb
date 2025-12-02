<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRejectFaculty
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblReason = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.btnConfirmReject = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        ' FORM
        '
        Me.ClientSize = New System.Drawing.Size(420, 320)
        Me.StartPosition = FormStartPosition.CenterParent
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.BackColor = Color.FromArgb(245, 245, 245)
        Me.Text = "Reject Faculty Registration"
        '
        ' lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New Font("Segoe UI Semibold", 14.0!, FontStyle.Bold)
        Me.lblTitle.Location = New Point(20, 20)
        Me.lblTitle.Text = "Reject Faculty Registration"
        '
        ' lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New Font("Segoe UI", 10.0!)
        Me.lblInfo.Location = New Point(20, 65)
        Me.lblInfo.Text = "Faculty Name (Employee No.)"
        '
        ' lblReason
        '
        Me.lblReason.AutoSize = True
        Me.lblReason.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.lblReason.Location = New Point(20, 105)
        Me.lblReason.Text = "Rejection Reason:"
        '
        ' txtReason
        '
        Me.txtReason.Font = New Font("Segoe UI", 10.0!)
        Me.txtReason.Multiline = True
        Me.txtReason.Location = New Point(24, 130)
        Me.txtReason.Size = New Size(360, 80)
        Me.txtReason.Name = "txtReason"
        '
        ' btnConfirmReject
        '
        Me.btnConfirmReject.Text = "Confirm Reject"
        Me.btnConfirmReject.BackColor = Color.FromArgb(200, 50, 50)
        Me.btnConfirmReject.ForeColor = Color.White
        Me.btnConfirmReject.FlatStyle = FlatStyle.Flat
        Me.btnConfirmReject.Location = New Point(60, 230)
        Me.btnConfirmReject.Size = New Size(135, 40)
        '
        ' btnCancel
        '
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.BackColor = Color.Gray
        Me.btnCancel.ForeColor = Color.White
        Me.btnCancel.FlatStyle = FlatStyle.Flat
        Me.btnCancel.Location = New Point(220, 230)
        Me.btnCancel.Size = New Size(135, 40)
        '
        ' Add Controls
        '
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblReason)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.btnConfirmReject)
        Me.Controls.Add(Me.btnCancel)

        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblReason As Label
    Friend WithEvents txtReason As TextBox
    Friend WithEvents btnConfirmReject As Button
    Friend WithEvents btnCancel As Button

End Class
