Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class frmLoginFaculty

    ' SHA256 HASH FUNCTION
    Private Function HashPassword(raw As String) As String
        Dim bytes = Encoding.UTF8.GetBytes(raw)
        Dim hash = SHA256.HashData(bytes)
        Return BitConverter.ToString(hash).Replace("-", "").ToLower()
    End Function

    Private Sub frmLoginFaculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmail.Select()
        lblLoginMessage.Text = ""

        ' Smooth Fade In
        Me.Opacity = 0
        Dim t As New Timer()
        t.Interval = 10
        AddHandler t.Tick, Sub()
                               If Me.Opacity >= 1 Then t.Stop()
                               Me.Opacity += 0.05
                           End Sub
        t.Start()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmStart.Show()
        Me.Close()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        lblLoginMessage.Text = ""

        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If email = "" Then
            lblLoginMessage.Text = "Please enter your email."
            txtEmail.Focus()
            Return
        End If

        If password = "" Then
            lblLoginMessage.Text = "Please enter your password."
            txtPassword.Focus()
            Return
        End If

        Dim hashed = HashPassword(password)

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand("
                    SELECT FacultyID, FirstName, LastName, PasswordHash, Status 
                    FROM faculty
                    WHERE Email = @em
                    LIMIT 1;
                ", conn)

                    cmd.Parameters.AddWithValue("@em", email)
                    conn.Open()

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then

                            Dim status As String = dr("Status").ToString()

                            Select Case status
                                Case "Active"
                                    ' OK

                                Case "Pending"
                                    lblLoginMessage.Text = "Your account is still pending approval."
                                    Return

                                Case "Rejected"
                                    lblLoginMessage.Text = "Your registration was rejected. Contact administrator."
                                    Return

                                Case Else
                                    lblLoginMessage.Text = "Your account is inactive."
                                    Return
                            End Select

                            Dim storedHash As String = dr("PasswordHash").ToString()

                            If storedHash = hashed Then
                                ' SUCCESS
                                CurrentUser.FacultyID = CInt(dr("FacultyID"))
                                CurrentUser.StudentID = Nothing
                                CurrentUser.Name = $"{dr("FirstName")} {dr("LastName")}"

                                Dim dash As New frmFacultyDashboard()
                                dash.Show()
                                Me.Hide()
                            Else
                                lblLoginMessage.Text = "Incorrect password."
                            End If
                        Else
                            lblLoginMessage.Text = "Faculty email not found."
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            lblLoginMessage.Text = "Database error."
        End Try
    End Sub

    Private Sub lnkRegisterFaculty_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegisterFaculty.LinkClicked
        Dim reg As New frmFacultyRegister()
        reg.Show()
        Me.Hide()
    End Sub

End Class
