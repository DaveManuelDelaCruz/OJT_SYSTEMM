Public Class frmStart

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        frmLoginStudent.Show()
        Me.Hide()
    End Sub

    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click
        frmLoginFaculty.Show()
        Me.Hide()
    End Sub

    Private Sub lblSelectType_Click(sender As Object, e As EventArgs) Handles lblSelectType.Click

    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub
End Class
