Imports System.IO
Imports ExcelDataReader
Imports MySql.Data.MySqlClient

Module ExcelImportModule

    ' ============================================================
    ' 1) MAIN IMPORT FUNCTION (Students)
    ' ============================================================
    Public Sub ImportStudentOfficialList(excelPath As String)
        Dim dt As DataTable = LoadExcelToDataTable(excelPath)
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            MessageBox.Show("Excel file has no data.", "Import Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim errors As New List(Of String)
        Dim validRows As New List(Of DataRow)

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Using tx As MySqlTransaction = conn.BeginTransaction()

                ' =============================
                ' VALIDATION LOOP
                ' =============================
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim r = dt.Rows(i)
                    Dim rowNum = i + 2

                    ' Skip empty lines
                    If r("StudentNumber").ToString.Trim() = "" AndAlso
                       r("LastName").ToString.Trim() = "" Then
                        Continue For
                    End If

                    Dim studNum = r("StudentNumber").ToString.Trim()
                    Dim ln = r("LastName").ToString.Trim()
                    Dim fn = r("FirstName").ToString.Trim()
                    Dim mn = r("MiddleName").ToString.Trim()
                    Dim courseCode = r("CourseCode").ToString.Trim()
                    Dim secName = r("SectionName").ToString.Trim()
                    Dim deptCode = r("DepartmentCode").ToString.Trim()
                    Dim gender = r("Gender").ToString.Trim()

                    ' -------- Required Fields --------
                    If studNum = "" Then errors.Add($"Row {rowNum}: Missing StudentNumber.") : Continue For
                    If ln = "" Or fn = "" Then errors.Add($"Row {rowNum}: Missing name fields.") : Continue For
                    If courseCode = "" Then errors.Add($"Row {rowNum}: Missing CourseCode.") : Continue For
                    If secName = "" Then errors.Add($"Row {rowNum}: Missing SectionName.") : Continue For
                    If deptCode = "" Then errors.Add($"Row {rowNum}: Missing DepartmentCode.") : Continue For
                    If gender = "" Then errors.Add($"Row {rowNum}: Missing Gender.") : Continue For

                    ' -------- Gender Validation --------
                    Dim genderUpper = gender.ToUpper()
                    If Not {"MALE", "FEMALE", "OTHER"}.Contains(genderUpper) Then
                        errors.Add($"Row {rowNum}: Invalid Gender '{gender}'. Must be Male / Female / Other.")
                        Continue For
                    End If

                    ' -------- Lookup validation --------
                    Try
                        GetCourseIdByCode(courseCode, conn, tx)
                    Catch ex As Exception
                        errors.Add($"Row {rowNum}: " & ex.Message)
                        Continue For
                    End Try

                    Try
                        GetSectionIdByName(secName, conn, tx)
                    Catch ex As Exception
                        errors.Add($"Row {rowNum}: " & ex.Message)
                        Continue For
                    End Try

                    Try
                        GetDepartmentIdByCode(deptCode, conn, tx)
                    Catch ex As Exception
                        errors.Add($"Row {rowNum}: " & ex.Message)
                        Continue For
                    End Try

                    validRows.Add(r)
                Next

                ' =============================
                ' STOP IF THERE ARE ERRORS
                ' =============================
                If errors.Count > 0 Then
                    MessageBox.Show(String.Join(vbCrLf, errors),
                                    "Import Errors",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tx.Rollback()
                    Exit Sub
                End If

                ' =============================
                ' INSERT CLEAN ROWS
                ' =============================
                For Each r In validRows
                    Dim courseId = GetCourseIdByCode(r("CourseCode"), conn, tx)
                    Dim sectionId = GetSectionIdByName(r("SectionName"), conn, tx)
                    Dim deptId = GetDepartmentIdByCode(r("DepartmentCode"), conn, tx)

                    Using cmd As New MySqlCommand("
                        INSERT INTO official_student_list
                        (StudentNumber, LastName, FirstName, MiddleName,
                         CourseID, SectionID, Gender, DepartmentID)
                        VALUES
                        (@sn, @ln, @fn, @mn, @cid, @sid, @g, @did)
                    ", conn, tx)

                        cmd.Parameters.AddWithValue("@sn", r("StudentNumber"))
                        cmd.Parameters.AddWithValue("@ln", r("LastName"))
                        cmd.Parameters.AddWithValue("@fn", r("FirstName"))
                        cmd.Parameters.AddWithValue("@mn",
                                                     If(r("MiddleName").ToString.Trim() = "",
                                                        DBNull.Value,
                                                        r("MiddleName")))

                        cmd.Parameters.AddWithValue("@cid", courseId)
                        cmd.Parameters.AddWithValue("@sid", sectionId)
                        cmd.Parameters.AddWithValue("@g", r("Gender"))
                        cmd.Parameters.AddWithValue("@did", deptId)

                        cmd.ExecuteNonQuery()
                    End Using
                Next

                tx.Commit()
            End Using
        End Using

        MessageBox.Show("Student official list imported successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub


    ' ============================================================
    ' 2) LOOKUP HELPERS
    ' ============================================================
    ' ============================================================
    ' 2) LOOKUP HELPERS
    ' ============================================================
    Public Function GetCourseIdByCode(courseCode As String, conn As MySqlConnection, tx As MySqlTransaction) As Integer
        Using cmd As New MySqlCommand("
        SELECT CourseID 
        FROM course 
        WHERE CourseCode = @c 
        LIMIT 1
    ", conn, tx)
            cmd.Parameters.AddWithValue("@c", courseCode)
            Dim id = cmd.ExecuteScalar()
            If id Is Nothing Then Throw New Exception("Invalid CourseCode: " & courseCode)
            Return Convert.ToInt32(id)
        End Using
    End Function

    Public Function GetSectionIdByName(secName As String, conn As MySqlConnection, tx As MySqlTransaction) As Integer
        Using cmd As New MySqlCommand("
        SELECT SectionID 
        FROM section 
        WHERE SectionName = @s 
        LIMIT 1
    ", conn, tx)
            cmd.Parameters.AddWithValue("@s", secName)
            Dim id = cmd.ExecuteScalar()
            If id Is Nothing Then Throw New Exception("Invalid SectionName: " & secName)
            Return Convert.ToInt32(id)
        End Using
    End Function

    Public Function GetDepartmentIdByCode(deptCode As String, conn As MySqlConnection, tx As MySqlTransaction) As Integer
        Using cmd As New MySqlCommand("
        SELECT DepartmentID 
        FROM department 
        WHERE DepartmentCode = @dc 
        LIMIT 1
    ", conn, tx)
            cmd.Parameters.AddWithValue("@dc", deptCode)
            Dim id = cmd.ExecuteScalar()
            If id Is Nothing Then Throw New Exception("Invalid DepartmentCode: " & deptCode)
            Return Convert.ToInt32(id)
        End Using
    End Function

    ' ============================================================
    ' CHECK IF DEPARTMENT EXISTS (needed for Professor import)
    ' ============================================================
    Public Function DepartmentExists(code As String) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using cmd As New MySqlCommand("
            SELECT COUNT(*) 
            FROM department 
            WHERE DepartmentCode = @d
        ", conn)
                cmd.Parameters.AddWithValue("@d", code)
                Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function



    ' ============================================================
    ' 3) EXCEL LOADER (ExcelDataReader)
    ' ============================================================
    Public Function LoadExcelToDataTable(filePath As String) As DataTable
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)

        Using stream = File.Open(filePath, FileMode.Open, FileAccess.Read)
            Using reader = ExcelReaderFactory.CreateReader(stream)
                Dim result = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                    .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                        .UseHeaderRow = True
                    }
                })
                Return result.Tables(0)
            End Using
        End Using
    End Function
    ' ============================================================
    ' 4) MAIN IMPORT FUNCTION (Official Professors)
    ' ============================================================
    Public Sub ImportOfficialProfessorList(excelPath As String)
        Dim dt As DataTable = LoadExcelToDataTable(excelPath)
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            MessageBox.Show("Excel file has no data.", "Import Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Expected columns in Excel:
        ' EmployeeNumber, LastName, FirstName, MiddleName, DepartmentCode, PositionTitle

        Dim errors As New List(Of String)
        Dim validRows As New List(Of DataRow)

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Using tx As MySqlTransaction = conn.BeginTransaction()

                ' ---------------- VALIDATION LOOP ----------------
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim r = dt.Rows(i)
                    Dim rowNum = i + 2  ' +2 because header is row 1

                    ' Skip fully empty rows
                    If r("EmployeeNumber").ToString.Trim() = "" AndAlso
                   r("LastName").ToString.Trim() = "" AndAlso
                   r("FirstName").ToString.Trim() = "" Then
                        Continue For
                    End If

                    Dim empNum = r("EmployeeNumber").ToString.Trim()
                    Dim ln = r("LastName").ToString.Trim()
                    Dim fn = r("FirstName").ToString.Trim()
                    Dim mn = r("MiddleName").ToString.Trim()
                    Dim deptCode = r("DepartmentCode").ToString.Trim()
                    Dim posTitle = r("PositionTitle").ToString.Trim()

                    ' ---- Required fields ----
                    If empNum = "" Then
                        errors.Add($"Row {rowNum}: Missing EmployeeNumber.")
                        Continue For
                    End If
                    If ln = "" OrElse fn = "" Then
                        errors.Add($"Row {rowNum}: Missing name fields (LastName/FirstName).")
                        Continue For
                    End If
                    If deptCode = "" Then
                        errors.Add($"Row {rowNum}: Missing DepartmentCode.")
                        Continue For
                    End If
                    If posTitle = "" Then
                        errors.Add($"Row {rowNum}: Missing PositionTitle.")
                        Continue For
                    End If

                    ' ---- Department code must exist in department table ----
                    If Not DepartmentExists(deptCode) Then
                        errors.Add($"Row {rowNum}: DepartmentCode '{deptCode}' does not exist in department table.")
                        Continue For
                    End If

                    ' ---- Optional: prevent duplicate EmployeeNumber in official_professor_list ----
                    Using cmdCheck As New MySqlCommand("
                    SELECT COUNT(*) 
                    FROM official_professor_list 
                    WHERE EmployeeNumber = @num
                ", conn, tx)

                        cmdCheck.Parameters.AddWithValue("@num", empNum)
                        Dim exists As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                        If exists > 0 Then
                            errors.Add($"Row {rowNum}: EmployeeNumber '{empNum}' already exists in official_professor_list.")
                            Continue For
                        End If
                    End Using

                    validRows.Add(r)
                Next

                ' ---------------- STOP IF THERE ARE ERRORS ----------------
                If errors.Count > 0 Then
                    MessageBox.Show(String.Join(vbCrLf, errors), "Import Errors",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tx.Rollback()
                    Exit Sub
                End If

                ' ---------------- INSERT CLEAN ROWS ----------------
                For Each r In validRows
                    Dim empNum = r("EmployeeNumber").ToString.Trim()
                    Dim ln = r("LastName").ToString.Trim()
                    Dim fn = r("FirstName").ToString.Trim()
                    Dim mn = r("MiddleName").ToString.Trim()
                    Dim deptCode = r("DepartmentCode").ToString.Trim()
                    Dim posTitle = r("PositionTitle").ToString.Trim()

                    Using cmd As New MySqlCommand("
                    INSERT INTO official_professor_list
                        (EmployeeNumber, LastName, FirstName, MiddleName, DepartmentCode, PositionTitle)
                    VALUES
                        (@num, @ln, @fn, @mn, @dept, @pos);
                ", conn, tx)

                        cmd.Parameters.AddWithValue("@num", empNum)
                        cmd.Parameters.AddWithValue("@ln", ln)
                        cmd.Parameters.AddWithValue("@fn", fn)
                        cmd.Parameters.AddWithValue("@mn",
                        If(String.IsNullOrWhiteSpace(mn), CType(DBNull.Value, Object), mn))
                        cmd.Parameters.AddWithValue("@dept", deptCode)
                        cmd.Parameters.AddWithValue("@pos", posTitle)

                        cmd.ExecuteNonQuery()
                    End Using
                Next

                tx.Commit()
            End Using
        End Using

        MessageBox.Show("Official professor list imported successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Module
