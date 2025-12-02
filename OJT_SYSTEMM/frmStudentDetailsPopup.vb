Imports MySql.Data.MySqlClient

Public Class frmStudentDetailsPopup

    Private ReadOnly _studentID As Integer

    Public Sub New(studentID As Integer)
        InitializeComponent()
        _studentID = studentID
    End Sub

    Private Sub frmStudentDetailsPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentDetails()
    End Sub

    Private Sub LoadStudentDetails()
        Dim sql As String =
            "SELECT s.StudentNumber, s.FirstName, s.MiddleName, s.LastName, " &
            "s.Email, s.ContactNumber, s.Address, s.City, " &
            "c.CourseName, c.CourseCode, " &
            "i.Status AS InternshipStatus, " &
            "comp.CompanyName, " &
            "cc.ContactNumber AS SupervisorContact " &
            "FROM student s " &
            "LEFT JOIN section sec ON s.SectionID = sec.SectionID " &
            "LEFT JOIN course c ON sec.CourseID = c.CourseID " &
            "LEFT JOIN internship i ON i.StudentID = s.StudentID " &
            "LEFT JOIN companycontact cc ON i.SupervisorContactID = cc.ContactID " &
            "LEFT JOIN company comp ON cc.CompanyID = comp.CompanyID " &
            "WHERE s.StudentID = @id " &
            "ORDER BY i.InternshipID DESC " &
            "LIMIT 1;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", _studentID)
                    conn.Open()

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            Dim fullName As String =
                                (dr("FirstName").ToString() & " " &
                                 If(IsDBNull(dr("MiddleName")), "", dr("MiddleName").ToString() & " ") &
                                 dr("LastName").ToString()).Replace("  ", " ").Trim()

                            lblNameValue.Text = fullName
                            lblStudentNumberValue.Text = dr("StudentNumber").ToString()

                            Dim courseText As String = dr("CourseCode").ToString()
                            If Not IsDBNull(dr("CourseName")) AndAlso dr("CourseName").ToString() <> "" Then
                                courseText &= " - " & dr("CourseName").ToString()
                            End If
                            lblCourseValue.Text = courseText

                            Dim address As String = dr("Address").ToString()
                            Dim city As String = dr("City").ToString()
                            If city <> "" Then
                                If address <> "" Then
                                    address &= ", " & city
                                Else
                                    address = city
                                End If
                            End If
                            lblAddressValue.Text = If(address = "", "-", address)

                            lblEmailValue.Text = If(dr("Email").ToString() = "", "-", dr("Email").ToString())
                            lblContactValue.Text = If(dr("ContactNumber").ToString() = "", "-", dr("ContactNumber").ToString())

                            Dim internshipStatus As String = If(IsDBNull(dr("InternshipStatus")), "None", dr("InternshipStatus").ToString())
                            lblInternshipStatusValue.Text = internshipStatus

                            Dim companyName As String = If(IsDBNull(dr("CompanyName")), "-", dr("CompanyName").ToString())
                            lblCompanyValue.Text = companyName

                        Else
                            lblNameValue.Text = "(Record not found)"
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading student details: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub pnlBody_Paint(sender As Object, e As PaintEventArgs) Handles pnlBody.Paint

    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub
End Class
