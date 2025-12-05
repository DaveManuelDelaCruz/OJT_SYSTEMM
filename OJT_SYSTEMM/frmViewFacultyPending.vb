Imports MySql.Data.MySqlClient

Public Class frmViewFacultyPending

    Private _facultyId As Integer

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
                           PositionTitle
                    FROM faculty
                    WHERE FacultyID = @fid;", conn)

                    cmd.Parameters.AddWithValue("@fid", _facultyId)

                    Using dr = cmd.ExecuteReader()
                        If dr.Read() Then

                            lblEmployeeNoValue.Text = dr("EmployeeNumber").ToString()
                            lblFullNameValue.Text = dr("FullName").ToString()

                            ' Gender (safe)
                            lblGenderValue.Text =
                                If(IsDBNull(dr("Gender")),
                                   "N/A",
                                   dr("Gender").ToString())

                            ' Birthdate (safe)
                            If IsDBNull(dr("Birthdate")) Then
                                lblBirthdateValue.Text = "N/A"
                            Else
                                lblBirthdateValue.Text = CDate(dr("Birthdate")).ToShortDateString()
                            End If

                            ' Email
                            lblEmailValue.Text =
                                If(IsDBNull(dr("Email")),
                                   "N/A",
                                   dr("Email").ToString())

                            ' Contact
                            lblContactValue.Text =
                                If(IsDBNull(dr("ContactNumber")),
                                   "N/A",
                                   dr("ContactNumber").ToString())

                            ' Department
                            lblDepartmentValue.Text =
                                If(IsDBNull(dr("DepartmentID")),
                                   "N/A",
                                   dr("DepartmentID").ToString())

                            ' Position
                            lblPositionValue.Text =
                                If(IsDBNull(dr("PositionTitle")),
                                   "N/A",
                                   dr("PositionTitle").ToString())

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
