Imports MySql.Data.MySqlClient

Public Class frmLoginStudent

    Private Sub frmLoginStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLoginEmail.Select()
        lblLoginMessage.Text = ""

        ' --- Smooth Fade In ---
        Me.Opacity = 0
        Dim t As New Timer()
        t.Interval = 10
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
        Try
            frmStart.Show()
        Catch
        End Try
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        lblLoginMessage.Text = ""

        Dim email As String = txtLoginEmail.Text.Trim()
        Dim password As String = txtLoginPassword.Text

        '==================================
        ' BASIC VALIDATION
        '==================================
        If email = "" Then
            ShowError("Please enter your email.")
            txtLoginEmail.Focus()
            Return
        End If

        If password = "" Then
            ShowError("Please enter your password.")
            txtLoginPassword.Focus()
            Return
        End If

        Dim hashedPassword As String = password ' TEMP until hashing enabled

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand("
                    SELECT StudentID, FirstName, LastName, PasswordHash, Status, RejectionReason
                    FROM student
                    WHERE Email = @Email
                    LIMIT 1;", conn)

                    cmd.Parameters.AddWithValue("@Email", email)
                    conn.Open()

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then

                            Dim status As String = dr("Status").ToString().Trim()

                            '==================================
                            ' HANDLE STATUS BEFORE PASSWORD
                            '==================================
                            Select Case status
                                Case "Pending"
                                    ShowError("Your account is still pending approval.")
                                    Return

                                Case "Rejected"
                                    Dim reason As String = dr("RejectionReason").ToString()
                                    ShowError("Your registration was rejected: " & reason)
                                    Return

                                Case "Inactive", "Dropped", "Graduated"
                                    ShowError("Your account is inactive.")
                                    Return

                                Case "Active"
                                    ' Continue to password check
                                Case Else
                                    ShowError("Unknown account status.")
                                    Return
                            End Select

                            '==================================
                            ' PASSWORD CHECK
                            '==================================
                            Dim storedHash As String = dr("PasswordHash").ToString()

                            If storedHash <> hashedPassword Then
                                ShowError("Incorrect password.")
                                Return
                            End If

                            '==================================
                            ' SUCCESSFUL LOGIN
                            '==================================
                            CurrentUser.StudentID = CInt(dr("StudentID"))
                            LoggedStudentID = CurrentUser.StudentID
                            CurrentUser.FacultyID = Nothing
                            CurrentUser.Name = $"{dr("FirstName")} {dr("LastName")}"

                            Dim dashboard As New frmStudentDashboard()
                            dashboard.Show()
                            Me.Hide()

                        Else
                            ShowError("Email not found.")
                        End If
                    End Using
                End Using
            End Using

        Catch ex As MySqlException
            ShowError("Database connection error.")
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "DEBUG ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ShowError(msg As String)
        lblLoginMessage.Text = msg
    End Sub

    '====================================================
    ' SHOW / HIDE PASSWORD
    '====================================================
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) _
        Handles chkShowPassword.CheckedChanged

        txtLoginPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    '====================================================
    ' OPEN REGISTRATION FORM
    '====================================================
    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) _
         Handles lnkRegister.LinkClicked

        Dim reg As New frmStudentRegister()
        reg.Show()
        Me.Hide()
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        Dim reg As New frmStudentRegister()
        reg.Show()
        Me.Hide()
    End Sub
End Class
