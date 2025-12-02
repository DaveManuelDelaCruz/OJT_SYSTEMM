Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

' ================================================================
'  DbModule — Shared database utilities for the entire application
' ================================================================
Module DbModule

    ' -----------------------------------------
    ' 1) DATABASE CONNECTION SETTINGS
    ' -----------------------------------------
    Public Function GetConnection() As MySqlConnection
        ' UPDATE THIS based on your local XAMPP / WAMP settings
        Dim connStr As String =
            "Server=localhost;" &
            "Database=ojtdb_group8;" &
            "Uid=root;" &
            "Pwd=;"


        Return New MySqlConnection(connStr)
    End Function


    ' -----------------------------------------
    ' 2) CURRENT USER SESSION INFORMATION
    ' -----------------------------------------
    Public Class UserSession
        Public Property StudentID As Integer?
        Public Property FacultyID As Integer?
        Public Property RegistrarID As Integer?   ' <<< ADD THIS
        Public Property Name As String = ""
        Public Property Username As String = ""

        Public Sub Clear()
            StudentID = Nothing
            FacultyID = Nothing
            RegistrarID = Nothing      ' <<< reset
            Name = ""
            Username = ""
        End Sub
    End Class


    Public CurrentUser As New UserSession()



    ' -----------------------------------------
    ' 4) NULL-SAFE READ HELPERS
    ' -----------------------------------------
    Public Function SafeStr(value As Object) As String
        If value Is Nothing OrElse value Is DBNull.Value Then Return ""
        Return value.ToString().Trim()
    End Function

    Public Function SafeInt(value As Object) As Integer
        If value Is Nothing OrElse value Is DBNull.Value Then Return 0
        Dim output As Integer
        If Integer.TryParse(value.ToString(), output) Then
            Return output
        End If
        Return 0
    End Function

    Public Function SafeDecimal(value As Object) As Decimal
        If value Is Nothing OrElse value Is DBNull.Value Then Return 0D
        Dim output As Decimal
        If Decimal.TryParse(value.ToString(), output) Then
            Return output
        End If
        Return 0D
    End Function

    Public Function SafeDate(value As Object) As String
        If value Is Nothing OrElse value Is DBNull.Value Then Return ""
        Dim output As Date
        If Date.TryParse(value.ToString(), output) Then
            Return output.ToString("yyyy-MM-dd")
        End If
        Return ""
    End Function

    Public Function SafeDateTime(value As Object) As String
        If value Is Nothing OrElse value Is DBNull.Value Then Return ""
        Dim output As DateTime
        If DateTime.TryParse(value.ToString(), output) Then
            Return output.ToString("yyyy-MM-dd HH:mm:ss")
        End If
        Return ""
    End Function

    Public Function SafeTime(value As Object) As String
        If value Is Nothing OrElse value Is DBNull.Value Then Return ""
        Dim output As Date
        If Date.TryParse(value.ToString(), output) Then
            Return output.ToString("hh:mm tt")
        End If
        Return ""
    End Function


    ' -----------------------------------------
    ' 5) CREATE A PARAMETER IN A SAFE WAY
    ' -----------------------------------------
    Public Sub AddParam(cmd As MySqlCommand, name As String, value As Object)
        If value Is Nothing Then
            cmd.Parameters.AddWithValue(name, DBNull.Value)
        Else
            cmd.Parameters.AddWithValue(name, value)
        End If
    End Sub
    Public Class InternshipStatus
        Public Const Pending As String = "Pending"
        Public Const Active As String = "Active"
        Public Const Completed As String = "Completed"
        Public Const Dropped As String = "Dropped"
    End Class

    Public Class StudentStatus
        Public Const Active As String = "Active"
        Public Const Inactive As String = "Inactive"
    End Class

    Public Sub AddProfessorLog(facultyId As Integer, actionType As String, actionDesc As String)
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim sql As String =
                "INSERT INTO system_logs (UserID, ActionType, ActionDesc, LogDate)
             VALUES (@uid, @type, @desc, NOW());"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@uid", facultyId)
                cmd.Parameters.AddWithValue("@type", actionType)
                cmd.Parameters.AddWithValue("@desc", actionDesc)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


End Module
