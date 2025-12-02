Imports System.Drawing.Drawing2D

Public Class frmStart

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        LoadCircularLogo()
        FadeIn()
    End Sub

    '===============================
    ' Fade-in Animation
    '===============================
    Private Sub FadeIn()
        Me.Opacity = 0
        Dim t As New Timer With {.Interval = 15}

        AddHandler t.Tick,
            Sub()
                If Me.Opacity >= 1 Then
                    t.Stop()
                Else
                    Me.Opacity += 0.04
                End If
            End Sub
        t.Start()
    End Sub

    '===============================
    ' Load and Render Circular Logo
    '===============================
    Private Sub LoadCircularLogo()
        Try
            Dim logoPath As String = IO.Path.Combine(Application.StartupPath, "logo.png")

            If Not IO.File.Exists(logoPath) Then
                MessageBox.Show("Logo missing: " & logoPath)
                Exit Sub
            End If

            Dim originalImg As Image = Image.FromFile(logoPath)
            picLogo.Image = MakeCircularImage(originalImg)

        Catch ex As Exception
            MessageBox.Show("Error loading logo: " & ex.Message)
        End Try
    End Sub

    '===============================
    ' Function that draws a circle
    '===============================
    Public Function MakeCircularImage(srcImg As Image) As Bitmap
        Dim size As Integer = Math.Min(srcImg.Width, srcImg.Height)
        Dim bmp As New Bitmap(size, size)

        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = SmoothingMode.AntiAlias
            g.Clear(Color.Transparent)

            Using path As New GraphicsPath()
                path.AddEllipse(0, 0, size, size)
                g.SetClip(path)
                g.DrawImage(srcImg, 0, 0, size, size)
            End Using
        End Using

        Return bmp
    End Function

    '===============================
    ' BUTTON OPEN FORMS
    '===============================
    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Dim f As New frmLoginStudent()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click
        Dim f As New frmLoginFaculty()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim f As New frmLoginRegistrar()
        f.Show()
        Me.Hide()
    End Sub
End Class
