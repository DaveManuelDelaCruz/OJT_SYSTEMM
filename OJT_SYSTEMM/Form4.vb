Public Class Form4
    ' Form Load - Set up initial UI
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Center the form on screen
        Me.CenterToScreen()
        Me.Text = "OJT Management System - Welcome"

        ' Optional: Set form size
        Me.Size = New Size(500, 400)
    End Sub

    ' Student Button Click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Ask if they have an account
        Dim result As DialogResult = MessageBox.Show(
            "Do you already have a student account?",
            "Student Login",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            ' User has account - Go to Student Login Form
            MessageBox.Show("Redirecting to Student Login...", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' TODO: Open your Student Login form
            ' Dim loginForm As New StudentLoginForm()
            ' loginForm.Show()
            ' Me.Hide()
        Else
            ' User doesn't have account - Go to Student Registration Form
            MessageBox.Show("Redirecting to Student Registration...", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' TODO: Open your Student Registration form
            ' Dim signupForm As New StudentSignupForm()
            ' signupForm.Show()
            ' Me.Hide()
        End If
    End Sub

    ' Faculty Button Click
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Ask if they have an account
        Dim result As DialogResult = MessageBox.Show(
            "Do you already have a faculty account?",
            "Faculty Login",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            ' User has account - Go to Faculty Login Form
            MessageBox.Show("Redirecting to Faculty Login...", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' TODO: Open your Faculty Login form
            ' Dim loginForm As New FacultyLoginForm()
            ' loginForm.Show()
            ' Me.Hide()
        Else
            ' User doesn't have account - Go to Faculty Registration Form
            MessageBox.Show("Redirecting to Faculty Registration...", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' TODO: Open your Faculty Registration form
            ' Dim signupForm As New FacultySignupForm()
            ' signupForm.Show()
            ' Me.Hide()
        End If
    End Sub

    ' Exit/Close Button Click
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ' Confirm before closing
        Dim result = MessageBox.Show(
            "Are you sure you want to exit?",
            "Exit Application",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class