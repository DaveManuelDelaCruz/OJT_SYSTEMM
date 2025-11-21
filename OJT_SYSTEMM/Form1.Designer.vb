<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpening
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        SuspendLayout()
        ' 
        ' frmOpening
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Green
        ClientSize = New Size(1262, 673)
        Name = "frmOpening"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Welcome"
        ResumeLayout(False)
    End Sub

End Class
