Imports MySql.Data.MySqlClient

Public Class frmViewFacultyPending

    Private _facultyId As Integer

    '✔ Constructor required by your main form
    Public Sub New(facultyId As Integer)
        InitializeComponent()
        _facultyId = facultyId
    End Sub

    Private Sub frmViewFacultyPending_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFacultyData()
    End Sub

    Private Sub LoadFacultyData()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                    SELECT EmployeeNumber,
                           CONCAT(LastName, ', ', FirstName, ' ', COALESCE(MiddleName,'')) AS FullName,
                           Gender,
                           Birthdate,
                           Email,
                           ContactNumber,
                           DepartmentID,
                           Position
                    FROM faculty
                    WHERE FacultyID = @fid;", conn)

                    cmd.Parameters.AddWithValue("@fid", _facultyId)

                    Using dr = cmd.ExecuteReader()
                        If dr.Read() Then
                            lblEmployeeNo.Text = dr("EmployeeNumber").ToString()
                            lblFullName.Text = dr("FullName").ToString()
                            lblGender.Text = dr("Gender").ToString()
                            lblBirthdate.Text = CDate(dr("Birthdate")).ToShortDateString()
                            lblEmail.Text = dr("Email").ToString()
                            lblContact.Text = dr("ContactNumber").ToString()
                            lblDepartment.Text = dr("DepartmentID").ToString()
                            lblPosition.Text = dr("Position").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading faculty info: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class
