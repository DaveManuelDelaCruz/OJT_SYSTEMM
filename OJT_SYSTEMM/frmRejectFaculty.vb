Imports MySql.Data.MySqlClient

Public Class frmRejectFaculty

    Private _facultyId As Integer
    Private _fullName As String
    Private _empNum As String

    Public Sub New(facultyId As Integer, fullName As String, empNum As String)
        InitializeComponent()
        _facultyId = facultyId
        _fullName = fullName
        _empNum = empNum
    End Sub

    Private Sub frmRejectFaculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInfo.Text = $"{_fullName} ({_empNum})"
    End Sub

    Private Sub btnConfirmReject_Click(sender As Object, e As EventArgs) Handles btnConfirmReject.Click
        Dim reason As String = txtReason.Text.Trim()

        If reason = "" Then
            MessageBox.Show("Please enter a rejection reason.")
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                    UPDATE faculty
                    SET Status = 'Rejected',
                        RejectionReason = @rea
                    WHERE FacultyID = @fid;", conn)

                    cmd.Parameters.AddWithValue("@rea", reason)
                    cmd.Parameters.AddWithValue("@fid", _facultyId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Faculty rejected successfully.")
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error rejecting faculty: " & ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class
