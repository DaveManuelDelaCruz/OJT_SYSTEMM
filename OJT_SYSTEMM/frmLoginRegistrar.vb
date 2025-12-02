Imports MySql.Data.MySqlClient

Public Class frmLoginRegistrar

    Private Sub frmLoginRegistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmail.Select()
        lblLoginMessage.Text = ""

        ' Fade In Effect
        Me.Opacity = 0
        Dim t As New Timer With {.Interval = 10}
        AddHandler t.Tick,
            Sub()
                If Me.Opacity >= 1 Then
                    t.Stop()
                Else
                    Me.Opacity += 0.05
                End If
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

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand("
                SELECT RegistrarID, FullName, Email, Password, Status
                FROM registrar
                WHERE Email = @em
                LIMIT 1;", conn)

                    cmd.Parameters.AddWithValue("@em", email)
                    conn.Open()

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then

                            Dim status As String = dr("Status").ToString().Trim()

                            ' --- Status check ---
                            If status <> "Active" Then
                                lblLoginMessage.Text = "This registrar account is inactive."
                                Return
                            End If

                            ' --- Password check (plain) ---
                            Dim storedPw As String = dr("Password").ToString()
                            If storedPw <> password Then
                                lblLoginMessage.Text = "Incorrect password."
                                Return
                            End If

                            ' --- NEW: Get RegistrarID ---
                            Dim registrarID As Integer = CInt(dr("RegistrarID"))
                            CurrentUser.RegistrarID = registrarID   ' store in session

                            ' --- Save session name/email ---
                            CurrentUser.FacultyID = Nothing
                            CurrentUser.StudentID = Nothing
                            CurrentUser.Name = dr("FullName").ToString()
                            CurrentUser.Username = dr("Email").ToString()

                            ' --- Open Dashboard ---
                            Dim dash As New frmRegistrarDashboard()
                            dash.CurrentRegistrarID = registrarID     ' <<< FIXED
                            dash.Show()
                            Me.Hide()

                        Else
                            lblLoginMessage.Text = "Email not found."
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            lblLoginMessage.Text = "Database error: " & ex.Message
        End Try
    End Sub

End Class
