Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw
Imports MySql.Data.MySqlClient




Public Class frmProfessorDashboard

    ' Adjust if needed, but this should match DbModule / your settings
    Private ReadOnly connectionString As String =
        "server=localhost;database=ojtdb_group8;uid=root;pwd=;"

    ' Set from login form:
    '   Dim f As New frmProfessorDashboard()
    '   f.CurrentFacultyID = loggedInFacultyID
    '   f.Show()
    Public Property CurrentFacultyID As Integer
    Private SelectedStudentID As Integer = 0
    ' ===== MY STUDENTS PANEL STATE =====
    Private isMSLoading As Boolean = False

    Private currentFacultyName As String = ""
    Private currentFacultyDepartmentName As String = ""
    ' ===== GRADING MODE FLAGS =====
    Private IsEditing As Boolean = False
    Private EditingInternshipID As Integer = 0
    Private LockedSupervisorScore As Decimal = 0D
    Private IsInternalChange As Boolean = False
    ' ==== INTERNSHIP ASSIGNMENT STATE FLAGS ====
    Private IsIAEditMode As Boolean = False
    Private IA_EditingInternshipID As Integer = 0
    Private isIALoading As Boolean = False
    Private isIAClearing As Boolean = False

    ' ------------------------------------------------------
    '  FORM LOAD
    ' ------------------------------------------------------
    Private Sub frmProfessorDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetProfileEditMode(False)

        ' Set header name if you use a shared CurrentUser
        Try
            If CurrentUser IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(CurrentUser.Name) Then
                lblUserName.Text = CurrentUser.Name
            End If
        Catch
            ' ignore if not available
        End Try

        Try
            ShowPanel(pnlHome)

            ' Make sure visit type values match enum in visitlog table
            cboVLVisitType.Items.Clear()
            cboVLVisitType.Items.Add("Initial")
            cboVLVisitType.Items.Add("Midterm")
            cboVLVisitType.Items.Add("Final")
            cboVLVisitType.SelectedIndex = -1

            LoadProfessorProfile()
            LoadHomeCards()
            LoadRecentActivity()

            LoadStudentFilters()
            LoadMyStudents()

            LoadCompanies()
            LoadCompanyContactsFilters()

            LoadInternshipFilters()
            LoadGradingStudents()

            LoadVisitLogInternships()
        Catch ex As Exception
            MessageBox.Show("Error on loading Professor Dashboard: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function



    ' ------------------------------------------------------
    '  NAVIGATION
    ' ------------------------------------------------------
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        ShowPanel(pnlHome)
        LoadHomeCards()
        LoadRecentActivity()
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        ShowPanel(pnlStudents)
        LoadStudentFilters()
        LoadMyStudents()
    End Sub

    Private Sub btnInternship_Click(sender As Object, e As EventArgs) Handles btnInternship.Click
        ShowPanel(pnlInternshipAssignment)
        LoadInternshipFilters()
    End Sub

    Private Sub btnVisitLogs_Click(sender As Object, e As EventArgs) Handles btnVisitLogs.Click
        ShowPanel(pnlVisitLogs)
        LoadVisitLogInternships()
        LoadVisitLogsForSelected()
    End Sub

    Private Sub btnGrading_Click(sender As Object, e As EventArgs) Handles btnGrading.Click
        ShowPanel(pnlGrading)
        LoadGradingStudents()
    End Sub

    Private Sub btnCompanies_Click(sender As Object, e As EventArgs) Handles btnCompanies.Click
        ShowPanel(pnlCompanies)
        LoadCompanies()
    End Sub

    Private Sub btnCompanyContacts_Click(sender As Object, e As EventArgs) Handles btnCompanyContacts.Click
        ShowPanel(pnlCompanyContacts)
        LoadCompanyContactsFilters()
        LoadCompanyContacts()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ShowPanel(pnlProfile)
        LoadProfessorProfile()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?",
                                            "Confirm Logout",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Dim login As New frmLoginFaculty()
                login.Show()
            Catch
                Try
                    frmStart.Show()
                Catch
                End Try
            End Try

            Me.Close()
        End If
    End Sub

    ' ------------------------------------------------------
    '  PROFESSOR PROFILE
    ' ------------------------------------------------------
    Private Sub SetProfileEditMode(isEdit As Boolean)

        txtPFEmail.ReadOnly = Not isEdit
        txtPFContact.ReadOnly = Not isEdit
        txtPFPassword.ReadOnly = Not isEdit
        txtPFConfirmPassword.ReadOnly = Not isEdit

        btnPFSave.Visible = isEdit
        btnPFCancel.Visible = isEdit
        btnPFEdit.Visible = Not isEdit

    End Sub
    Private Function ValidateProfileInputs() As Boolean

        ' -------------------------
        ' EMAIL VALIDATION
        ' -------------------------
        If String.IsNullOrWhiteSpace(txtPFEmail.Text) Then
            MessageBox.Show("Email cannot be empty.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPFEmail.Focus()
            Return False
        End If

        ' -------------------------
        ' CONTACT NUMBER VALIDATION
        ' -------------------------
        Dim contact As String = txtPFContact.Text.Trim()

        If contact = "" Then
            MessageBox.Show("Contact number cannot be empty.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPFContact.Focus()
            Return False
        End If

        If Not contact.StartsWith("09") Then
            MessageBox.Show("Contact number must start with '09'.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPFContact.Focus()
            Return False
        End If

        If contact.Length <> 11 Then
            MessageBox.Show("Contact number must be 11 digits long.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPFContact.Focus()
            Return False
        End If

        If Not IsNumeric(contact) Then
            MessageBox.Show("Contact number must contain digits only.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPFContact.Focus()
            Return False
        End If

        ' -------------------------
        ' PASSWORD VALIDATION
        ' -------------------------
        If txtPFPassword.Text <> txtPFConfirmPassword.Text Then
            MessageBox.Show("Password and Confirm Password do not match.",
                        "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPFConfirmPassword.Focus()
            Return False
        End If

        ' If password is empty → keep old password (allowed)
        Return True
    End Function


    Private Sub LoadProfessorProfile()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim facultyNumber As String = ""
            Dim fullName As String = ""
            Dim deptName As String = ""
            Dim email As String = ""
            Dim contact As String = ""

            ' --------------------------
            '  FIRST QUERY (Reader)
            ' --------------------------
            Dim sql As String =
            "SELECT f.EmployeeNumber, f.FirstName, f.LastName, d.DepartmentName,
                    f.Email, f.ContactNumber
             FROM faculty f
             INNER JOIN department d ON f.DepartmentID = d.DepartmentID
             WHERE f.FacultyID = @FacultyID;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)

                Using rdr As MySqlDataReader = cmd.ExecuteReader()
                    If rdr.Read() Then
                        facultyNumber = rdr("EmployeeNumber").ToString()
                        fullName = rdr("FirstName").ToString() & " " & rdr("LastName").ToString()
                        deptName = rdr("DepartmentName").ToString()
                        email = If(IsDBNull(rdr("Email")), "", rdr("Email").ToString())
                        contact = If(IsDBNull(rdr("ContactNumber")), "", rdr("ContactNumber").ToString())
                    End If
                End Using
            End Using    ' 🎉 Reader is now CLOSED!

            ' --------------------------
            ' SECOND QUERY (SAFE NOW)
            ' --------------------------
            Dim sectionsText As String = GetProfessorSectionsText(conn)

            ' --------------------------
            '  POPULATE UI SAFE
            ' --------------------------
            lblPFName.Text = fullName
            lblUserName.Text = fullName
            lblPFFacultyNumber.Text = facultyNumber
            lblPFDepartment.Text = deptName
            lblPFSections.Text = sectionsText

            txtPFEmail.Text = email
            txtPFContact.Text = contact
            txtPFPassword.Text = ""
            txtPFConfirmPassword.Text = ""
        End Using
    End Sub


    Private Function GetProfessorSectionsText(conn As MySqlConnection) As String
        Dim sectionNames As New List(Of String)()

        Dim sql As String =
            "SELECT s.SectionName " &
            "FROM faculty_section fs " &
            "INNER JOIN section s ON fs.SectionID = s.SectionID " &
            "WHERE fs.FacultyID = @FacultyID AND s.IsActive = 1;"

        Using cmd As New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)

            Using rdr As MySqlDataReader = cmd.ExecuteReader()
                While rdr.Read()
                    sectionNames.Add(rdr("SectionName").ToString())
                End While
            End Using
        End Using

        If sectionNames.Count = 0 Then
            Return "(No sections assigned)"
        End If

        Return String.Join(", ", sectionNames)
    End Function

    Private Sub btnPFEdit_Click(sender As Object, e As EventArgs) Handles btnPFEdit.Click
        SetProfileEditMode(True)
    End Sub
    Private Sub btnPFCancel_Click(sender As Object, e As EventArgs) Handles btnPFCancel.Click
        LoadProfessorProfile() ' reload original data from DB
        SetProfileEditMode(False)
    End Sub

    Private Sub btnPFSave_Click(sender As Object, e As EventArgs) Handles btnPFSave.Click

        ' RUN VALIDATION FIRST
        If Not ValidateProfileInputs() Then Exit Sub
        If txtPFContact.Text.Length <> 11 OrElse Not txtPFContact.Text.StartsWith("09") Then
            MessageBox.Show("Please enter a valid PH number starting with '09' and 11 digits total.",
                    "Invalid Contact Number",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim sql As String =
            "UPDATE faculty 
             SET Email = @Email,
                 ContactNumber = @ContactNumber,
                 Password = CASE WHEN @Password = '' THEN Password ELSE @Password END,
                 UpdatedAt = NOW()
             WHERE FacultyID = @FacultyID;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Email", txtPFEmail.Text.Trim())
                cmd.Parameters.AddWithValue("@ContactNumber", txtPFContact.Text.Trim())
                cmd.Parameters.AddWithValue("@Password", txtPFPassword.Text.Trim())  ' no hashing as you said
                cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Profile updated successfully.",
                    "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

        SetProfileEditMode(False)
        LoadProfessorProfile()  ' reload updated values
    End Sub
    ' ==========================================================
    '  CONTACT NUMBER VALIDATION + FORMATTING (Starts with 09)
    ' ==========================================================
    Private Sub txtPFContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPFContact.KeyPress

        ' 1) Allow only digits and control keys (Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If

        ' 2) Enforce 11 digits maximum
        If Char.IsDigit(e.KeyChar) AndAlso txtPFContact.Text.Length >= 11 Then
            e.Handled = True
            Exit Sub
        End If

    End Sub

    Private Sub txtPFContact_TextChanged(sender As Object, e As EventArgs) Handles txtPFContact.TextChanged
        Dim txt As String = txtPFContact.Text

        ' 3) Auto–force start with "09"
        If txt.Length = 1 Then
            ' First digit must be 0
            If txt <> "0" Then
                txtPFContact.Text = "0"
                txtPFContact.SelectionStart = txtPFContact.Text.Length
            End If
        ElseIf txt.Length = 2 Then
            ' Second digit must be 9
            If txt <> "09" Then
                txtPFContact.Text = "09"
                txtPFContact.SelectionStart = txtPFContact.Text.Length
            End If
        End If

        ' 4) If user deletes below two digits — FIX IT
        If txt.Length < 2 AndAlso txt <> "" Then
            txtPFContact.Text = "0"
            txtPFContact.SelectionStart = txtPFContact.Text.Length
        End If

        ' 5) Keep cursor at end after formatting
        txtPFContact.SelectionStart = txtPFContact.Text.Length
    End Sub




    ' ------------------------------------------------------
    '  HOME CARDS + RECENT ACTIVITY
    ' ------------------------------------------------------
    Private Sub LoadHomeCards()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim totalStudents As Integer = 0
            Dim activeInternships As Integer = 0
            Dim completedInternships As Integer = 0
            Dim pendingVisitLogs As Integer = 0

            ' My students = students in sections assigned to this faculty
            Dim sqlStudents As String =
                "SELECT COUNT(DISTINCT s.StudentID) " &
                "FROM student s " &
                "INNER JOIN faculty_section fs ON s.SectionID = fs.SectionID " &
                "WHERE fs.FacultyID = @FacultyID;"

            Using cmd As New MySqlCommand(sqlStudents, conn)
                cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)
                totalStudents = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            ' Active internships under this professor
            Dim sqlActive As String =
                "SELECT COUNT(*) FROM internship " &
                "WHERE EvaluatingFacultyID = @FacultyID " &
                "  AND Status = 'Active' " &
                "  AND IsDeleted = 0;"

            Using cmd As New MySqlCommand(sqlActive, conn)
                cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)
                activeInternships = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            ' Completed internships under this professor
            Dim sqlCompleted As String =
                "SELECT COUNT(*) FROM internship " &
                "WHERE EvaluatingFacultyID = @FacultyID " &
                "  AND Status = 'Completed' " &
                "  AND IsDeleted = 0;"

            Using cmd As New MySqlCommand(sqlCompleted, conn)
                cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)
                completedInternships = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            ' For now: treat "pending visit logs" as number of active internships
            Dim sqlPendingVL As String =
                "SELECT COUNT(*) FROM internship " &
                "WHERE EvaluatingFacultyID = @FacultyID " &
                "  AND Status = 'Active' " &
                "  AND IsDeleted = 0;"

            Using cmd As New MySqlCommand(sqlPendingVL, conn)
                cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)
                pendingVisitLogs = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            lblCardMyStudentsValue.Text = totalStudents.ToString()
            lblCardActiveInternshipsValue.Text = activeInternships.ToString()
            lblCardCompletedInternshipsValue.Text = completedInternships.ToString()
            lblCardPendingVisitLogsValue.Text = pendingVisitLogs.ToString()
        End Using
    End Sub

    Private Sub LoadRecentActivity()
        ' Uses system_logs (adjust if your schema is different)
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim dt As New DataTable()

            Dim sql As String =
            "SELECT 
                sl.LogDate,
                sl.ActionDesc,
                COALESCE(CONCAT(f.LastName, ', ', f.FirstName), 'System') AS DoneBy
             FROM system_logs sl
             LEFT JOIN faculty f ON f.FacultyID = sl.UserID
             ORDER BY sl.LogDate DESC
             LIMIT 50;"

            Using da As New MySqlDataAdapter(sql, conn)
                da.Fill(dt)
            End Using

            dgvRecentActivity.DataSource = dt
        End Using
    End Sub

    ' ------------------------------------------------------
    '  STUDENTS (MY SECTIONS)
    ' ------------------------------------------------------

    '  LOAD FILTERS  (Call this in ProfessorDashboard_Load)
    Private Sub LoadStudentFilters()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            '------------------------------------------------------
            ' Sections assigned to this professor (for top filter)
            '------------------------------------------------------
            Dim dtSections As New DataTable()

            Dim sql As String =
"SELECT s.SectionID, s.SectionName
   FROM section s
   INNER JOIN faculty_section fs
           ON s.SectionID = fs.SectionID
  WHERE fs.FacultyID = @FacultyID
    AND s.IsActive = 1
  ORDER BY s.SectionName;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dtSections)
                End Using
            End Using

            cboStudentSection.DataSource = dtSections
            cboStudentSection.DisplayMember = "SectionName"
            cboStudentSection.ValueMember = "SectionID"
            cboStudentSection.SelectedIndex = -1
        End Using

        '------------------------------------------------------
        ' Status filter (Academic status only – NOT AccountStatus)
        '------------------------------------------------------
        cboStudentStatus.Items.Clear()
        cboStudentStatus.Items.Add("(All)")
        cboStudentStatus.Items.Add("Active")
        cboStudentStatus.Items.Add("OnLeave")
        cboStudentStatus.Items.Add("Graduated")
        cboStudentStatus.Items.Add("Dropped")
        cboStudentStatus.SelectedIndex = 0

        dgvMyStudents.DataSource = Nothing
        dgvMyStudentsHistory.DataSource = Nothing
    End Sub

    ' ------------------------------------------------
    '  FORMAT TOP GRID (My Students)
    ' ------------------------------------------------
    Private Sub FormatMyStudentsGrid()
        If dgvMyStudents.Columns.Count = 0 Then Exit Sub

        With dgvMyStudents
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            If .Columns.Contains("StudentID") Then
                .Columns("StudentID").Visible = False
            End If

            .Columns("StudentNumber").HeaderText = "Student No"
            .Columns("StudentName").HeaderText = "Name"
            .Columns("SectionName").HeaderText = "Section"
            .Columns("CourseCode").HeaderText = "Course"

            .Columns("StudentStatus").HeaderText = "Student Status"
            .Columns("AccountStatus").HeaderText = "Account Status"
            .Columns("LatestInternshipStatus").HeaderText = "Latest Internship Status"
        End With
    End Sub

    ' ------------------------------------------------
    '  FORMAT BOTTOM GRID (Internship History)
    ' ------------------------------------------------
    Private Sub FormatStudentHistoryGrid()

        If dgvMyStudentsHistory.Columns.Count = 0 Then Exit Sub

        With dgvMyStudentsHistory

            ' Hide ID
            If .Columns.Contains("InternshipID") Then
                .Columns("InternshipID").Visible = False
            End If

            ' Set headers
            .Columns("Status").HeaderText = "Status"
            .Columns("CompanyName").HeaderText = "Company"
            .Columns("SupervisorName").HeaderText = "Supervisor"
            .Columns("StartDate").HeaderText = "Start"
            .Columns("EndDate").HeaderText = "End"
            .Columns("WorkDays").HeaderText = "Work Days"
            .Columns("DailyStartTime").HeaderText = "Start Time"
            .Columns("DailyEndTime").HeaderText = "End Time"
            .Columns("RequiredHours").HeaderText = "Req Hrs"
            .Columns("HoursCompleted").HeaderText = "Done"
            .Columns("InitialScore").HeaderText = "Initial"
            .Columns("MidtermScore").HeaderText = "Midterm"
            .Columns("FinalScore").HeaderText = "Final"
            .Columns("FinalGrade").HeaderText = "Grade"

            ' Optional: Set fixed widths to prevent resizing
            Dim fixedWidth As Integer = 90
            For Each col As DataGridViewColumn In .Columns
                If col.Visible Then
                    col.Width = fixedWidth
                End If
            Next

            ' Prevent grid from resizing itself
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
            .AllowUserToResizeColumns = True
            .AllowUserToResizeRows = False

        End With

    End Sub

    ' ------------------------------------------------
    '  LOAD TOP GRID  (MyStudents list)
    ' ------------------------------------------------
    Private Sub LoadMyStudents()
        If cboStudentSection.SelectedIndex < 0 Then
            dgvMyStudents.DataSource = Nothing
            dgvMyStudentsHistory.DataSource = Nothing
            Return
        End If

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim dt As New DataTable()

            '=============================================================
            ' For each student in the selected section:
            '   • Show Student info
            '   • Academic Status  (Status)
            '   • Account Status   (AccountStatus)
            '   • Latest internship status  (using subquery to find last)
            '=============================================================

            Dim sql As String =
"SELECT 
      s.StudentID,
      s.StudentNumber,
      CONCAT(s.LastName, ', ', s.FirstName,
             CASE WHEN s.MiddleName IS NULL OR s.MiddleName = '' 
                  THEN '' ELSE CONCAT(' ', LEFT(s.MiddleName,1),'.') END
      ) AS StudentName,

      sec.SectionName,
      crs.CourseCode,

      s.Status        AS StudentStatus,      -- academic status
      s.AccountStatus AS AccountStatus,      -- login account status

      IFNULL(
          (
             SELECT i2.Status
               FROM internship i2
              WHERE i2.StudentID = s.StudentID
                AND i2.IsDeleted = 0
           ORDER BY i2.StartDate DESC, i2.InternshipID DESC
              LIMIT 1
          ),
          'No Internship'
      ) AS LatestInternshipStatus

 FROM student s
 INNER JOIN section sec ON s.SectionID = sec.SectionID
 INNER JOIN course  crs ON sec.CourseID = crs.CourseID

 WHERE s.SectionID = @SectionID
   AND (@StudentStatus = '(All)' OR s.Status = @StudentStatus)

 ORDER BY s.LastName, s.FirstName;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@SectionID", CInt(cboStudentSection.SelectedValue))
                cmd.Parameters.AddWithValue("@StudentStatus", cboStudentStatus.Text)

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            dgvMyStudents.DataSource = dt
            FormatMyStudentsGrid()
        End Using

        ' When the top list changes, clear history until a student is clicked
        dgvMyStudentsHistory.DataSource = Nothing
    End Sub

    ' ------------------------------------------------
    '  LOAD BOTTOM GRID  (All internships of selected student)
    ' ------------------------------------------------
    Private Sub LoadStudentInternshipHistory(studentId As Integer)
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim dt As New DataTable()

            '=========================================================
            ' All internships of this student (not deleted)
            '   • Company, Supervisor, schedule, hours
            '   • Initial / Midterm / Final visit scores
            '   • FinalGrade (0 if NULL)
            '=========================================================

            Dim sql As String =
"SELECT
     i.InternshipID,
     i.Status,

     c.CompanyName,
     CONCAT(cc.LastName, ', ', cc.FirstName,
            CASE WHEN cc.MiddleName IS NULL OR cc.MiddleName = ''
                 THEN '' ELSE CONCAT(' ', LEFT(cc.MiddleName,1),'.') END
     ) AS SupervisorName,

     i.StartDate,
     i.EndDate,
     i.WorkDays,
     i.DailyStartTime,
     i.DailyEndTime,
     i.RequiredHours,
     i.HoursCompleted,

     -- latest Initial visit score (0 if none)
     IFNULL((
        SELECT v.Score
          FROM visitlog v
         WHERE v.InternshipID = i.InternshipID
           AND v.VisitType = 'Initial'
      ORDER BY v.VisitDate DESC, v.VisitID DESC
         LIMIT 1
     ),0) AS InitialScore,

     -- latest Midterm visit score (0 if none)
     IFNULL((
        SELECT v.Score
          FROM visitlog v
         WHERE v.InternshipID = i.InternshipID
           AND v.VisitType = 'Midterm'
      ORDER BY v.VisitDate DESC, v.VisitID DESC
         LIMIT 1
     ),0) AS MidtermScore,

     -- latest Final visit score (0 if none)
     IFNULL((
        SELECT v.Score
          FROM visitlog v
         WHERE v.InternshipID = i.InternshipID
           AND v.VisitType = 'Final'
      ORDER BY v.VisitDate DESC, v.VisitID DESC
         LIMIT 1
     ),0) AS FinalScore,

     IFNULL(i.FinalGrade,0) AS FinalGrade

 FROM internship i
 LEFT JOIN company        c  ON i.CompanyID          = c.CompanyID
 LEFT JOIN companycontact cc ON i.SupervisorContactID = cc.ContactID

WHERE i.StudentID = @StudentID
  AND i.IsDeleted = 0

ORDER BY i.StartDate DESC, i.InternshipID DESC;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@StudentID", studentId)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            dgvMyStudentsHistory.DataSource = dt
            FormatStudentHistoryGrid()
        End Using
    End Sub

    ' ------------------------------------------------
    '  FILTER EVENTS
    ' ------------------------------------------------
    Private Sub cboStudentSection_SelectedIndexChanged(sender As Object, e As EventArgs) _
    Handles cboStudentSection.SelectedIndexChanged

        If Not cboStudentSection.Focused OrElse cboStudentSection.SelectedIndex < 0 Then Return
        LoadMyStudents()
    End Sub

    Private Sub cboStudentStatus_SelectedIndexChanged(sender As Object, e As EventArgs) _
    Handles cboStudentStatus.SelectedIndexChanged

        If Not cboStudentStatus.Focused OrElse cboStudentStatus.SelectedIndex < 0 Then Return
        LoadMyStudents()
    End Sub

    ' ------------------------------------------------
    '  SEARCH (TOP GRID)  – filters DataView by name/number
    ' ------------------------------------------------
    Private Sub txtStudentSearch_TextChanged(sender As Object, e As EventArgs) _
    Handles txtStudentSearch.TextChanged

        If dgvMyStudents.DataSource Is Nothing Then Return

        Dim dv As DataView = CType(dgvMyStudents.DataSource, DataTable).DefaultView
        Dim key As String = txtStudentSearch.Text.Replace("'", "''")

        dv.RowFilter =
        $"StudentName LIKE '%{key}%' OR StudentNumber LIKE '%{key}%'"
    End Sub

    ' ------------------------------------------------
    '  WHEN A STUDENT ROW IS CLICKED → load internship history
    ' ------------------------------------------------
    Private Sub dgvMyStudents_SelectionChanged(sender As Object, e As EventArgs) _
    Handles dgvMyStudents.SelectionChanged

        If dgvMyStudents.SelectedRows.Count = 0 Then
            dgvMyStudentsHistory.DataSource = Nothing
            SelectedStudentID = 0
            Exit Sub
        End If

        Dim row As DataGridViewRow = dgvMyStudents.SelectedRows(0)
        SelectedStudentID = CInt(row.Cells("StudentID").Value)

        LoadStudentInternshipHistory(SelectedStudentID)
    End Sub

    ' ------------------------------------------------
    '  OPEN EDIT PANEL (only changes academic Status, not AccountStatus)
    ' ------------------------------------------------
    Private Sub btnStudentEdit_Click(sender As Object, e As EventArgs) Handles btnStudentEdit.Click
        If dgvMyStudents.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a student first.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim row = dgvMyStudents.SelectedRows(0)
        SelectedStudentID = CInt(row.Cells("StudentID").Value)

        lblStudentName.Text = row.Cells("StudentName").Value.ToString()
        cboStudentEditStatus.Items.Clear()
        cboStudentEditStatus.Items.Add("Active")
        cboStudentEditStatus.Items.Add("OnLeave")
        cboStudentEditStatus.Items.Add("Graduated")
        cboStudentEditStatus.Items.Add("Dropped")

        cboStudentEditStatus.Text = row.Cells("StudentStatus").Value.ToString()

        pnlStudentEditStatus.Visible = True
    End Sub

    ' ------------------------------------------------
    '  SAVE STATUS CHANGE  (with Graduation Rule)
    ' ------------------------------------------------
    Private Sub btnStudentEditSave_Click(sender As Object, e As EventArgs) Handles btnStudentEditSave.Click
        If SelectedStudentID = 0 Then
            MessageBox.Show("No student selected.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim newStatus As String = cboStudentEditStatus.Text.Trim()
        If newStatus = "" Then
            MessageBox.Show("Please choose a new status.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim currentRow As DataGridViewRow = dgvMyStudents.SelectedRows(0)
        Dim currentStatus As String = currentRow.Cells("StudentStatus").Value.ToString()

        ' -------------------------------------------
        ' Basic rules on changing academic status
        ' -------------------------------------------
        If currentStatus = "Graduated" AndAlso newStatus <> "Graduated" Then
            MessageBox.Show("Graduated students cannot change status.",
                        "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' --- Graduation rule (Updated business rule #3) ---
        '  • Must have at least one internship
        '  • ALL internships Completed
        '  • ALL Completed internships have FinalGrade (NOT NULL)
        If newStatus = "Graduated" Then
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' A) Any internship at all?
                Dim sqlTotal As String =
"SELECT COUNT(*) 
   FROM internship 
  WHERE StudentID = @SID 
    AND IsDeleted = 0;"

                Dim totalIntern As Integer
                Using cmd As New MySqlCommand(sqlTotal, conn)
                    cmd.Parameters.AddWithValue("@SID", SelectedStudentID)
                    totalIntern = CInt(cmd.ExecuteScalar())
                End Using

                If totalIntern = 0 Then
                    MessageBox.Show("Cannot set status to Graduated." & vbCrLf &
                                "Student has no internship records.",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' B) Are there any non-completed internships?
                Dim sqlNotCompleted As String =
"SELECT COUNT(*)
   FROM internship
  WHERE StudentID = @SID
    AND IsDeleted = 0
    AND Status <> 'Completed';"

                Dim notCompleted As Integer
                Using cmd As New MySqlCommand(sqlNotCompleted, conn)
                    cmd.Parameters.AddWithValue("@SID", SelectedStudentID)
                    notCompleted = CInt(cmd.ExecuteScalar())
                End Using

                If notCompleted > 0 Then
                    MessageBox.Show("Cannot set status to Graduated." & vbCrLf &
                                "Some internships are not yet completed.",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' C) Completed internships must all have FinalGrade
                Dim sqlMissingGrade As String =
"SELECT COUNT(*)
   FROM internship
  WHERE StudentID = @SID
    AND IsDeleted = 0
    AND Status = 'Completed'
    AND FinalGrade IS NULL;"

                Dim missingGrade As Integer
                Using cmd As New MySqlCommand(sqlMissingGrade, conn)
                    cmd.Parameters.AddWithValue("@SID", SelectedStudentID)
                    missingGrade = CInt(cmd.ExecuteScalar())
                End Using

                If missingGrade > 0 Then
                    MessageBox.Show("Cannot set status to Graduated." & vbCrLf &
                                "One or more completed internships have no Final Grade.",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End Using
        End If

        ' -------------------------------------------
        ' Update student.Status in database
        ' -------------------------------------------
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim sql As String =
"UPDATE student
    SET Status   = @Status,
        UpdatedAt = NOW()
  WHERE StudentID = @ID;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Status", newStatus)
                cmd.Parameters.AddWithValue("@ID", SelectedStudentID)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        ' Log in Professor Recent Activity
        AddProfessorLog(CurrentFacultyID,
                    "Student Status Update",
                    "Changed status of " & lblStudentName.Text &
                    " from " & currentStatus & " to " & newStatus)

        MessageBox.Show("Student status updated!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)

        pnlStudentEditStatus.Visible = False
        SelectedStudentID = 0

        ' Reload data + keep filters
        LoadMyStudents()
    End Sub

    ' ------------------------------------------------
    '  CANCEL STATUS EDIT
    ' ------------------------------------------------
    Private Sub btnStudentEditCancel_Click(sender As Object, e As EventArgs) Handles btnStudentEditCancel.Click
        If SelectedStudentID <> 0 Then
            AddProfessorLog(CurrentFacultyID,
                        "Student Status Update",
                        "Cancelled status edit for " & lblStudentName.Text)
        End If

        pnlStudentEditStatus.Visible = False
        SelectedStudentID = 0
    End Sub

    ' ------------------------------------------------------
    '  INTERNSHIP ASSIGNMENT
    ' ------------------------------------------------------
    ' ================================================================
    '  INTERNSHIP ASSIGNMENT PANEL  (FINAL SPEC)
    '  Filters: Section + Status (Pending / Active / Dropped)
    '  Modes  : Normal vs Edit
    ' ================================================================

    ' =====================================================================
    '  INTERNSHIP ASSIGNMENT PANEL — FINAL CODE
    '  - Filters: Section + Status (Pending / Active / Dropped)
    '  - One Active internship per student enforced
    '  - Supports multiple internships over time (Completed / Dropped history)
    '  - Edit + Reactivate Dropped + Drop Active
    ' =====================================================================


    ' ---------------------------------------------------------------
    '  HELPER: Enable/Disable assignment fields (company, supervisor..)
    ' ---------------------------------------------------------------
    Private Sub SetIAFieldsEditable(enabled As Boolean)
        cboIACompany.Enabled = enabled
        cboIASupervisor.Enabled = enabled
        txtIAWorkDays.Enabled = enabled
        dtpIAStartTime.Enabled = enabled
        dtpIAEndTime.Enabled = enabled
        btnIAAssign.Enabled = enabled
    End Sub

    ' ---------------------------------------------------------------
    '  HELPER: Normal vs Edit mode switching
    ' ---------------------------------------------------------------
    Private Sub SetIA_ModeNormal()
        IsIAEditMode = False
        IA_EditingInternshipID = 0

        ' Filters allowed
        cboIASection.Enabled = True
        cboIAStatus.Enabled = True
        cboIAStudent.Enabled = True

        ' Buttons
        btnIAEdit.Visible = True
        btnIACancelEdit.Visible = False

        ' Fields always editable in normal mode (for assigning)
        SetIAFieldsEditable(True)
    End Sub

    Private Sub SetIA_ModeEdit()
        IsIAEditMode = True

        ' Lock filters while editing
        cboIASection.Enabled = False
        cboIAStatus.Enabled = False
        cboIAStudent.Enabled = False

        ' Buttons
        btnIAEdit.Visible = False
        btnIACancelEdit.Visible = True

        ' Fields editable in edit mode
        SetIAFieldsEditable(True)
    End Sub

    ' ---------------------------------------------------------------
    '  CLEAR ALL PANEL FIELDS (keeps filter selections as-is)
    ' ---------------------------------------------------------------
    Private Sub ClearIAFields()
        isIAClearing = True

        ' do NOT touch Section / Status here
        cboIAStudent.SelectedIndex = -1
        cboIACompany.SelectedIndex = -1
        cboIASupervisor.DataSource = Nothing

        txtIAWorkDays.Text = ""
        dtpIAStartTime.Value = Date.Today.AddHours(8)
        dtpIAEndTime.Value = Date.Today.AddHours(17)

        lblIAStudentNo.Text = "-"
        lblIAStudentName.Text = "-"
        lblIACourse.Text = "-"
        lblIASection.Text = "-"
        lblIARequiredHours.Text = "-"
        lblIAStatus.Text = "-"

        isIAClearing = False
    End Sub

    ' ---------------------------------------------------------------
    '  INITIAL LOAD FOR FILTERS  (Call from Form_Load)
    ' ---------------------------------------------------------------
    Private Sub LoadInternshipFilters()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            ' ---------- SECTIONS for this faculty ----------
            ' Gets only sections assigned to the logged-in professor.
            Dim dtSections As New DataTable()
            Dim sqlSections As String =
"SELECT s.SectionID, s.SectionName
 FROM section s
 INNER JOIN faculty_section fs ON s.SectionID = fs.SectionID
 WHERE fs.FacultyID = @FacultyID
   AND s.IsActive = 1
 ORDER BY s.SectionName;"

            Using cmd As New MySqlCommand(sqlSections, conn)
                cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dtSections)
                End Using
            End Using

            cboIASection.DataSource = dtSections
            cboIASection.DisplayMember = "SectionName"
            cboIASection.ValueMember = "SectionID"
            cboIASection.SelectedIndex = -1

            ' ---------- COMPANIES (active only) ----------
            ' Company masterlist, only active entries shown.
            Dim dtCompanies As New DataTable()
            Dim sqlCompanies As String =
"SELECT CompanyID, CompanyName
 FROM company
 WHERE IsActive = 1
 ORDER BY CompanyName;"

            Using da As New MySqlDataAdapter(sqlCompanies, conn)
                da.Fill(dtCompanies)
            End Using

            cboIACompany.DataSource = dtCompanies
            cboIACompany.DisplayMember = "CompanyName"
            cboIACompany.ValueMember = "CompanyID"
            cboIACompany.SelectedIndex = -1
        End Using

        ' ---------- STATUS FILTER: Pending / Active / Dropped ----------
        cboIAStatus.Items.Clear()
        cboIAStatus.Items.Add("Pending")
        cboIAStatus.Items.Add("Active")
        cboIAStatus.Items.Add("Dropped")
        cboIAStatus.SelectedIndex = 0   ' default: Pending

        cboIAStudent.DataSource = Nothing
        cboIASupervisor.DataSource = Nothing

        ClearIAFields()
        SetIA_ModeNormal()
    End Sub

    ' ---------------------------------------------------------------
    '  LOAD STUDENTS/INTERNSHIPS BASED ON Section + Status FILTER
    ' ---------------------------------------------------------------
    Private Sub LoadStudentsForCurrentSection()
        If cboIASection.SelectedIndex < 0 OrElse cboIAStatus.SelectedIndex < 0 Then
            cboIAStudent.DataSource = Nothing
            ClearIAFields()
            Return
        End If

        isIALoading = True

        Dim statusFilter As String = cboIAStatus.Text

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim dt As New DataTable()
            Dim sql As String = ""

            Select Case statusFilter
                Case "Pending"
                    ' ==========================================================
                    ' PENDING:
                    '  Show ONLY Active students who:
                    '    • belong to this section
                    '    • have NO Active internship
                    '    • may have completed or dropped internships before
                    ' ==========================================================

                    sql =
                     "SELECT s.StudentID,
                         CONCAT(s.StudentNumber, ' - ', s.LastName, ', ', s.FirstName) AS DisplayName
                         FROM student s
                         WHERE s.SectionID = @SectionID
                         AND s.Status = 'Active'  -- Only ACTIVE students allowed
                         AND NOT EXISTS (
                         SELECT 1 FROM internship i
                         WHERE i.StudentID = s.StudentID
                         AND i.Status = 'Active'
                         AND i.IsDeleted = 0
                             )
                         ORDER BY s.LastName, s.FirstName;"


                Case "Active", "Dropped"
                    ' ==========================================================
                    ' ACTIVE / DROPPED:
                    '  Shows internships (not bare students) for this faculty,
                    '  in the selected section, with the chosen Status.
                    ' ==========================================================
                    sql =
"SELECT i.InternshipID,
        CONCAT(s.StudentNumber, ' - ', s.LastName, ', ', s.FirstName) AS DisplayName
 FROM internship i
 INNER JOIN student s ON s.StudentID = i.StudentID
 WHERE i.Status = @Status
   AND i.EvaluatingFacultyID = @FacultyID
   AND i.IsDeleted = 0
   AND s.SectionID = @SectionID
 ORDER BY s.LastName, s.FirstName;"

                Case Else
                    dt.Clear()
            End Select

            If sql <> "" Then
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@SectionID", CInt(cboIASection.SelectedValue))
                    cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)
                    cmd.Parameters.AddWithValue("@Status", statusFilter)

                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End If

            cboIAStudent.DataSource = dt
            cboIAStudent.DisplayMember = "DisplayName"

            ' Important:
            If statusFilter = "Pending" Then
                cboIAStudent.ValueMember = "StudentID"     ' selecting student
            Else
                cboIAStudent.ValueMember = "InternshipID"  ' selecting internship
            End If

            cboIAStudent.SelectedIndex = -1
        End Using

        ClearIAFields()
        isIALoading = False
    End Sub

    ' ---------------------------------------------------------------
    '  SECTION OR STATUS CHANGED → Reload list
    ' ---------------------------------------------------------------
    Private Sub cboIASection_SelectedIndexChanged(sender As Object, e As EventArgs) _
Handles cboIASection.SelectedIndexChanged

        If isIALoading OrElse isIAClearing Then Return
        If Not cboIASection.Focused OrElse cboIASection.SelectedIndex < 0 Then Return

        ' In Edit mode, we do NOT allow changing section
        If IsIAEditMode Then
            Return
        End If

        LoadStudentsForCurrentSection()
    End Sub

    Private Sub cboIAStatus_SelectedIndexChanged(sender As Object, e As EventArgs) _
Handles cboIAStatus.SelectedIndexChanged

        If isIALoading OrElse isIAClearing Then Return
        If cboIAStatus.SelectedIndex < 0 Then Return
        If cboIASection.SelectedIndex < 0 Then
            cboIAStudent.DataSource = Nothing
            ClearIAFields()
            Return
        End If

        ' Cannot switch filter while editing
        If IsIAEditMode Then Return

        LoadStudentsForCurrentSection()
    End Sub

    ' ---------------------------------------------------------------
    '  LOAD DETAILS WHEN STUDENT/INTERNSHIP SELECTED
    ' ---------------------------------------------------------------
    Private Sub cboIAStudent_SelectedIndexChanged(sender As Object, e As EventArgs) _
Handles cboIAStudent.SelectedIndexChanged

        If isIALoading OrElse isIAClearing Then Return
        If cboIAStudent.SelectedIndex < 0 Then
            ClearIAFields()
            Return
        End If

        LoadIAStudentDetails()
    End Sub

    Private Sub LoadIAStudentDetails()
        If cboIAStudent.SelectedIndex < 0 Then Return
        If cboIASection.SelectedIndex < 0 OrElse cboIAStatus.SelectedIndex < 0 Then Return

        Dim statusFilter As String = cboIAStatus.Text

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            If statusFilter = "Pending" Then
                ' ==========================================================
                '  PENDING MODE:
                '  Load only STUDENT info (no internship yet).
                ' ==========================================================
                Dim studentId As Integer = CInt(cboIAStudent.SelectedValue)

                Dim sql As String =
"SELECT s.StudentNumber,
        CONCAT(s.LastName, ', ', s.FirstName,
               CASE WHEN s.MiddleName IS NULL OR s.MiddleName = ''
                    THEN '' ELSE CONCAT(' ', LEFT(s.MiddleName,1),'.') END
        ) AS StudentName,
        c.CourseCode,
        sec.SectionName,
        c.RequiredOJTHours
 FROM student s
 INNER JOIN section sec ON s.SectionID = sec.SectionID
 INNER JOIN course c ON sec.CourseID = c.CourseID
 WHERE s.StudentID = @StudentID;"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@StudentID", studentId)
                    Using rdr = cmd.ExecuteReader()
                        If rdr.Read() Then
                            lblIAStudentNo.Text = rdr("StudentNumber").ToString()
                            lblIAStudentName.Text = rdr("StudentName").ToString()
                            lblIACourse.Text = rdr("CourseCode").ToString()
                            lblIASection.Text = rdr("SectionName").ToString()
                            lblIARequiredHours.Text = rdr("RequiredOJTHours").ToString()
                            lblIAStatus.Text = "Pending"
                        End If
                    End Using
                End Using

                ' Reset assignment fields
                txtIAWorkDays.Text = ""
                dtpIAStartTime.Value = Date.Today.AddHours(8)
                dtpIAEndTime.Value = Date.Today.AddHours(17)
                cboIACompany.SelectedIndex = -1
                cboIASupervisor.DataSource = Nothing

            Else
                ' ==========================================================
                '  ACTIVE / DROPPED:
                '  Load internship row + student info.
                ' ==========================================================
                Dim internshipId As Integer = CInt(cboIAStudent.SelectedValue)

                Dim sql As String =
"SELECT i.StudentID,
        i.Status,
        i.WorkDays,
        i.DailyStartTime,
        i.DailyEndTime,
        i.CompanyID,
        i.SupervisorContactID,
        s.StudentNumber,
        CONCAT(s.LastName, ', ', s.FirstName,
               CASE WHEN s.MiddleName IS NULL OR s.MiddleName = ''
                    THEN '' ELSE CONCAT(' ', LEFT(s.MiddleName,1),'.') END
        ) AS StudentName,
        c.CourseCode,
        sec.SectionName,
        c.RequiredOJTHours
 FROM internship i
 INNER JOIN student s ON s.StudentID = i.StudentID
 INNER JOIN section sec ON s.SectionID = sec.SectionID
 INNER JOIN course c ON sec.CourseID = c.CourseID
 WHERE i.InternshipID = @InternshipID;"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@InternshipID", internshipId)

                    Using rdr = cmd.ExecuteReader()
                        If rdr.Read() Then
                            IA_EditingInternshipID = internshipId

                            lblIAStudentNo.Text = rdr("StudentNumber").ToString()
                            lblIAStudentName.Text = rdr("StudentName").ToString()
                            lblIACourse.Text = rdr("CourseCode").ToString()
                            lblIASection.Text = rdr("SectionName").ToString()
                            lblIARequiredHours.Text = rdr("RequiredOJTHours").ToString()
                            lblIAStatus.Text = rdr("Status").ToString()

                            txtIAWorkDays.Text = rdr("WorkDays").ToString()

                            If Not IsDBNull(rdr("DailyStartTime")) Then
                                dtpIAStartTime.Value = Date.Today + CType(rdr("DailyStartTime"), TimeSpan)
                            Else
                                dtpIAStartTime.Value = Date.Today.AddHours(8)
                            End If

                            If Not IsDBNull(rdr("DailyEndTime")) Then
                                dtpIAEndTime.Value = Date.Today + CType(rdr("DailyEndTime"), TimeSpan)
                            Else
                                dtpIAEndTime.Value = Date.Today.AddHours(17)
                            End If

                            ' Pre-select company if present
                            If Not IsDBNull(rdr("CompanyID")) Then
                                cboIACompany.SelectedValue = CInt(rdr("CompanyID"))
                            Else
                                cboIACompany.SelectedIndex = -1
                            End If
                        End If
                    End Using
                End Using

                ' load supervisors AFTER company is set
                If cboIACompany.SelectedIndex >= 0 Then
                    LoadIASupervisors()
                End If

                ' Re-select supervisor
                Dim sqlSup As String =
"SELECT SupervisorContactID
 FROM internship
 WHERE InternshipID = @ID;"

                Using cmdSup As New MySqlCommand(sqlSup, conn)
                    cmdSup.Parameters.AddWithValue("@ID", internshipId)
                    Dim supIdObj = cmdSup.ExecuteScalar()
                    If supIdObj IsNot Nothing AndAlso supIdObj IsNot DBNull.Value Then
                        Try
                            cboIASupervisor.SelectedValue = CInt(supIdObj)
                        Catch
                            ' ignore if supervisor no longer exists
                        End Try
                    Else
                        cboIASupervisor.SelectedIndex = -1
                    End If
                End Using
            End If
        End Using

        lblIAFacultyEvaluator.Text = CurrentUser.Name
    End Sub

    ' ---------------------------------------------------------------
    '  COMPANY → LOAD SUPERVISORS
    ' ---------------------------------------------------------------
    Private Sub cboIACompany_SelectedIndexChanged(sender As Object, e As EventArgs) _
Handles cboIACompany.SelectedIndexChanged

        If Not cboIACompany.Focused OrElse cboIACompany.SelectedIndex < 0 Then Return
        LoadIASupervisors()
    End Sub

    Private Sub LoadIASupervisors()
        If cboIACompany.SelectedIndex < 0 Then
            cboIASupervisor.DataSource = Nothing
            Return
        End If

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            ' Supervisors restricted to chosen company (and active only).
            Dim dtSup As New DataTable()
            Dim sql As String =
"SELECT ContactID,
        CONCAT(LastName, ', ', FirstName,
               CASE WHEN MiddleName IS NULL OR MiddleName = ''
                    THEN '' ELSE CONCAT(' ', LEFT(MiddleName,1),'.') END
        ) AS ContactName
 FROM companycontact
 WHERE CompanyID = @CompanyID
   AND IsActive = 1
 ORDER BY LastName, FirstName;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@CompanyID", CInt(cboIACompany.SelectedValue))
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dtSup)
                End Using
            End Using

            cboIASupervisor.DataSource = dtSup
            cboIASupervisor.DisplayMember = "ContactName"
            cboIASupervisor.ValueMember = "ContactID"
            cboIASupervisor.SelectedIndex = -1
        End Using
    End Sub

    ' ---------------------------------------------------------------
    '  CHECK IF STUDENT ALREADY HAS ACTIVE INTERNSHIP
    '  (used for NEW assignment)
    ' ---------------------------------------------------------------
    Private Function StudentHasActiveInternship(studentId As Integer) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim sql As String =
"SELECT COUNT(*)
 FROM internship
 WHERE StudentID = @StudentID
   AND Status = 'Active'
   AND (IsDeleted = 0 OR IsDeleted IS NULL);"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@StudentID", studentId)
                    Dim cnt As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return (cnt > 0)
                End Using
            End Using
        Catch
            ' Safer: disallow assignment if unsure
            Return True
        End Try
    End Function

    ' ---------------------------------------------------------------
    '  CHECK IF STUDENT HAS ANOTHER ACTIVE INTERNSHIP
    '  (used when re-activating a DROPPED internship)
    ' ---------------------------------------------------------------
    Private Function StudentHasOtherActiveInternship(studentId As Integer, excludeInternshipId As Integer) As Boolean
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim sql As String =
"SELECT COUNT(*)
 FROM internship
 WHERE StudentID = @StudentID
   AND Status = 'Active'
   AND (IsDeleted = 0 OR IsDeleted IS NULL)
   AND InternshipID <> @ExcludeID;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@StudentID", studentId)
                cmd.Parameters.AddWithValue("@ExcludeID", excludeInternshipId)
                Dim cnt As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return (cnt > 0)
            End Using
        End Using
    End Function

    ' ---------------------------------------------------------------
    '  ASSIGN / SAVE BUTTON
    ' ---------------------------------------------------------------
    Private Sub btnIAAssign_Click(sender As Object, e As EventArgs) Handles btnIAAssign.Click

        ' ===========================
        ' EDIT MODE → update existing
        ' ===========================
        If IsIAEditMode Then
            If IA_EditingInternshipID <= 0 Then
                MessageBox.Show("No internship selected for editing.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            UpdateInternshipAssignment()
            Return
        End If

        ' ===========================
        ' NORMAL MODE → NEW ASSIGNMENT
        ' Only allowed when filter = Pending
        ' ===========================
        If cboIAStatus.Text <> "Pending" Then
            MessageBox.Show("New assignments can only be created when Status filter is 'Pending'.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboIAStudent.SelectedIndex < 0 OrElse cboIACompany.SelectedIndex < 0 Then
            MessageBox.Show("Please select a student and company.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboIASupervisor.SelectedIndex < 0 Then
            MessageBox.Show("Please select a supervisor.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedStudentId As Integer = CInt(cboIAStudent.SelectedValue)

        ' Business rule: ONLY ONE ACTIVE internship at a time.
        If StudentHasActiveInternship(selectedStudentId) Then
            MessageBox.Show("This student already has an ACTIVE internship.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtIAWorkDays.Text) Then
            MessageBox.Show("Please specify Work Days.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtIAWorkDays.Focus()
            Return
        End If

        Dim startT As TimeSpan = dtpIAStartTime.Value.TimeOfDay
        Dim endT As TimeSpan = dtpIAEndTime.Value.TimeOfDay
        Dim hoursDiff As Double = (endT - startT).TotalHours

        ' Minimum of 4 hours per day
        If hoursDiff < 4 Then
            MessageBox.Show("Daily internship schedule must be at least 4 hours." & vbCrLf &
                "Current duration: " & Math.Round(hoursDiff, 2) & " hours.",
                "Invalid Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If dtpIAStartTime.Value.TimeOfDay = dtpIAEndTime.Value.TimeOfDay Then
            MessageBox.Show("Start Time and End Time cannot be the same.",
                    "Invalid Time Range", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim requiredHours As Integer
        If Not Integer.TryParse(lblIARequiredHours.Text, requiredHours) Then
            MessageBox.Show("Invalid Required OJT Hours.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn = GetConnection()
            conn.Open()

            ' Insert NEW Active internship row for the student.
            Dim sql As String =
"INSERT INTO internship
 ( StudentID, CompanyID, SupervisorContactID, EvaluatingFacultyID,
   StartDate, Status, WorkDays, DailyStartTime, DailyEndTime,
   RequiredHours, HoursCompleted, CreatedAt, UpdatedAt, IsDeleted )
 VALUES
 (@StudentID, @CompanyID, @SupervisorContactID, @FacultyID,
  @StartDate, 'Active', @WorkDays, @DailyStartTime, @DailyEndTime,
  @RequiredHours, 0, NOW(), NOW(), 0);"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@StudentID", selectedStudentId)
                cmd.Parameters.AddWithValue("@CompanyID", CInt(cboIACompany.SelectedValue))
                cmd.Parameters.AddWithValue("@SupervisorContactID", CInt(cboIASupervisor.SelectedValue))
                cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)
                cmd.Parameters.AddWithValue("@StartDate", Date.Today)
                cmd.Parameters.AddWithValue("@DailyStartTime", dtpIAStartTime.Value.TimeOfDay)
                cmd.Parameters.AddWithValue("@DailyEndTime", dtpIAEndTime.Value.TimeOfDay)
                cmd.Parameters.AddWithValue("@WorkDays", txtIAWorkDays.Text.Trim())
                cmd.Parameters.AddWithValue("@RequiredHours", requiredHours)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        AddProfessorLog(CurrentFacultyID,
                "Internship Assignment",
                "Assigned " & lblIAStudentName.Text & " to " & cboIACompany.Text)

        MessageBox.Show("Internship assigned.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information)

        LoadHomeCards()

        ' After assigning, student disappears from Pending (now Active).
        LoadStudentsForCurrentSection()
        ClearIAFields()
    End Sub

    ' ---------------------------------------------------------------
    '  UPDATE EXISTING INTERNSHIP (EDIT MODE SAVE)
    ' ---------------------------------------------------------------
    Private Sub UpdateInternshipAssignment()
        If IA_EditingInternshipID <= 0 Then Return

        ' -----------------------------
        ' BASIC VALIDATIONS
        ' -----------------------------
        If cboIACompany.SelectedIndex < 0 Then
            MessageBox.Show("Please select a company.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboIASupervisor.SelectedIndex < 0 Then
            MessageBox.Show("Please select a supervisor.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtIAWorkDays.Text) Then
            MessageBox.Show("Please specify Work Days.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' -----------------------------
        ' START/END TIME MUST BE >= 4 HOURS
        ' -----------------------------
        Dim startT As TimeSpan = dtpIAStartTime.Value.TimeOfDay
        Dim endT As TimeSpan = dtpIAEndTime.Value.TimeOfDay
        Dim hoursDiff As Double = (endT - startT).TotalHours

        If hoursDiff < 4 Then
            MessageBox.Show("Daily internship schedule must be at least 4 hours." & vbCrLf &
                    "Current duration: " & Math.Round(hoursDiff, 2) & " hours.",
                    "Invalid Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim originalStatus As String = lblIAStatus.Text.Trim()
        Dim newStatus As String = "Active"

        ' ----------------------------------------------------------
        ' If internship is currently DROPPED and will be reactivated
        ' we must check that the student has NO OTHER Active internship.
        ' ----------------------------------------------------------
        Dim studentId As Integer

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim sqlGetStudent As String =
"SELECT StudentID
 FROM internship
 WHERE InternshipID = @ID;"

            Using cmdGet As New MySqlCommand(sqlGetStudent, conn)
                cmdGet.Parameters.AddWithValue("@ID", IA_EditingInternshipID)
                Dim obj = cmdGet.ExecuteScalar()
                If obj Is Nothing OrElse obj Is DBNull.Value Then
                    MessageBox.Show("Unable to find related student for this internship.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
                studentId = CInt(obj)
            End Using
        End Using

        If originalStatus = "Dropped" Then
            ' Check other Active internships for this student (excluding this one)
            If StudentHasOtherActiveInternship(studentId, IA_EditingInternshipID) Then
                MessageBox.Show("This student already has another ACTIVE internship." & vbCrLf &
                            "You cannot reactivate this Dropped internship while another is Active.",
                            "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim result = MessageBox.Show(
            "Reactivating this Dropped internship will:" & vbCrLf &
            "• Reset completed hours" & vbCrLf &
            "• Clear final grade" & vbCrLf &
            "• Clear evaluation report" & vbCrLf &
            "• Set status back to ACTIVE" & vbCrLf & vbCrLf &
            "Do you want to continue?",
            "Confirm Reactivation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

            If result = DialogResult.No Then
                Return
            End If
        End If

        ' -----------------------------
        ' PERFORM UPDATE
        ' -----------------------------
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim sql As String =
"UPDATE internship
 SET
    CompanyID = @CompanyID,
    SupervisorContactID = @SupervisorContactID,
    WorkDays = @WorkDays,
    DailyStartTime = @StartTime,
    DailyEndTime = @EndTime,
    Status = @Status,

    -- When reactivating from Dropped, reset StartDate to today.
    StartDate = CASE 
                    WHEN @OriginalStatus = 'Dropped' 
                    THEN NOW() 
                    ELSE StartDate 
                END,

    -- If we go back to Active, EndDate is cleared.
    EndDate = CASE 
                  WHEN @Status = 'Active' 
                  THEN NULL 
                  ELSE EndDate 
              END,

    -- Reactivation resets progress and grading.
    HoursCompleted = CASE 
                        WHEN @OriginalStatus = 'Dropped' 
                        THEN 0 
                        ELSE HoursCompleted 
                     END,
    FinalGrade = CASE 
                    WHEN @OriginalStatus = 'Dropped' 
                    THEN NULL 
                    ELSE FinalGrade 
                 END,
    EvaluationReportPath = CASE 
                               WHEN @OriginalStatus = 'Dropped' 
                               THEN NULL 
                               ELSE EvaluationReportPath 
                           END,
    GradeDate = CASE 
                    WHEN @OriginalStatus = 'Dropped' 
                    THEN NULL 
                    ELSE GradeDate 
                END,
    UpdatedAt = NOW()
 WHERE InternshipID = @ID;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@CompanyID", CInt(cboIACompany.SelectedValue))
                cmd.Parameters.AddWithValue("@SupervisorContactID", CInt(cboIASupervisor.SelectedValue))
                cmd.Parameters.AddWithValue("@WorkDays", txtIAWorkDays.Text.Trim())
                cmd.Parameters.AddWithValue("@StartTime", startT)
                cmd.Parameters.AddWithValue("@EndTime", endT)
                cmd.Parameters.AddWithValue("@Status", newStatus)
                cmd.Parameters.AddWithValue("@OriginalStatus", originalStatus)
                cmd.Parameters.AddWithValue("@ID", IA_EditingInternshipID)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        ' -----------------------------
        ' LOGGING
        ' -----------------------------
        AddProfessorLog(CurrentFacultyID,
                "Internship Assignment",
                If(originalStatus = "Dropped",
                   "Reactivated internship for " & lblIAStudentName.Text,
                   "Updated internship assignment for " & lblIAStudentName.Text))

        ' -----------------------------
        ' SHOW SUCCESS
        ' -----------------------------
        If originalStatus = "Dropped" Then
            MessageBox.Show("Internship successfully REACTIVATED as ACTIVE!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Internship updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' -----------------------------
        ' EXIT EDIT MODE
        ' -----------------------------
        SetIA_ModeNormal()
        IA_EditingInternshipID = 0

        LoadStudentsForCurrentSection()
        ClearIAFields()
    End Sub

    ' ---------------------------------------------------------------
    '  EDIT BUTTON  → ENTER EDIT MODE
    ' ---------------------------------------------------------------
    Private Sub btnIAEdit_Click(sender As Object, e As EventArgs) Handles btnIAEdit.Click
        If cboIAStudent.SelectedIndex < 0 Then
            MessageBox.Show("Select a student with an Active or Dropped internship first.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboIAStatus.Text = "Pending" Then
            MessageBox.Show("Edit is only available for Active or Dropped internships.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        IA_EditingInternshipID = CInt(cboIAStudent.SelectedValue)
        If IA_EditingInternshipID <= 0 Then
            MessageBox.Show("Invalid internship selected.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        SetIA_ModeEdit()
        LoadIAStudentDetails()

        MessageBox.Show("Edit mode activated. Modify the assignment and click Save.",
                "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' ---------------------------------------------------------------
    '  CANCEL EDIT BUTTON  → back to normal
    ' ---------------------------------------------------------------
    Private Sub btnIACancelEdit_Click(sender As Object, e As EventArgs) Handles btnIACancelEdit.Click
        SetIA_ModeNormal()
        IA_EditingInternshipID = 0
        ClearIAFields()
        LoadStudentsForCurrentSection()
        MessageBox.Show("Edit mode cancelled.", "Cancelled",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' ---------------------------------------------------------------
    '  DROP BUTTON  → Active → Dropped
    ' ---------------------------------------------------------------
    Private Sub btnIADrop_Click(sender As Object, e As EventArgs) Handles btnIADrop.Click
        If cboIAStudent.SelectedIndex < 0 Then
            MessageBox.Show("Select an ACTIVE internship to drop.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboIAStatus.Text <> "Active" Then
            MessageBox.Show("Only ACTIVE internships can be dropped.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim internshipId As Integer
        Try
            internshipId = CInt(cboIAStudent.SelectedValue)
        Catch
            MessageBox.Show("Invalid internship selected.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        If MessageBox.Show("Are you sure you want to drop this internship?",
                   "Confirm Drop", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            ' Mark internship as Dropped and clear any grading/progress.
            Dim sql As String =
"UPDATE internship SET
    Status = 'Dropped',
    HoursCompleted = 0,
    FinalGrade = NULL,
    EvaluationReportPath = NULL,
    GradeDate = NULL,
    EndDate = NULL,
    UpdatedAt = NOW()
 WHERE InternshipID = @ID;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ID", internshipId)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        AddProfessorLog(CurrentFacultyID,
                "Internship Assignment",
                "Dropped internship for " & lblIAStudentName.Text)

        MessageBox.Show("Internship dropped.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' After dropping, internship moves from Active → Dropped
        SetIA_ModeNormal()
        LoadStudentsForCurrentSection()
        ClearIAFields()
    End Sub

    ' ---------------------------------------------------------------
    '  CLEAR BUTTON  → reset everything
    ' ---------------------------------------------------------------
    Private Sub btnIAClear_Click(sender As Object, e As EventArgs) Handles btnIAClear.Click
        ClearIAFields()

        cboIASection.SelectedIndex = -1
        cboIAStatus.SelectedIndex = 0  ' back to Pending
        cboIAStudent.DataSource = Nothing
        cboIACompany.SelectedIndex = -1
        cboIASupervisor.DataSource = Nothing

        lblIAFacultyEvaluator.Text = currentFacultyName

        SetIA_ModeNormal()
    End Sub





    ' ------------------------------------------------------
    '  VISIT LOGS
    ' ------------------------------------------------------

    ' VISIT LOGS — HELPERS
    Private Function ComputeVisitOverallPercent() As Decimal
        ' All criteria are 1–5. Overall % = (sum / 25) * 100
        Dim tech, comm, behavior, attendance, quality As Integer

        If cboVLTech.SelectedIndex < 0 OrElse
       cboVLComm.SelectedIndex < 0 OrElse
       cboVLBehavior.SelectedIndex < 0 OrElse
       cboVLAttendance.SelectedIndex < 0 OrElse
       cboVLQuality.SelectedIndex < 0 Then

            Throw New ApplicationException("Please select a rating (1–5) for all criteria.")
        End If

        tech = CInt(cboVLTech.SelectedItem)
        comm = CInt(cboVLComm.SelectedItem)
        behavior = CInt(cboVLBehavior.SelectedItem)
        attendance = CInt(cboVLAttendance.SelectedItem)
        quality = CInt(cboVLQuality.SelectedItem)

        Dim sum As Integer = tech + comm + behavior + attendance + quality
        Dim percent As Decimal = CDec(sum) / 25D * 100D

        Return Math.Round(percent, 2)
    End Function

    Private Sub LoadVisitLogInternships()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim dt As New DataTable()

            Dim sql As String =
            "SELECT i.InternshipID,
                    CONCAT(
                        s.StudentNumber, ' - ', s.LastName, ', ', s.FirstName,
                        CASE WHEN s.MiddleName='' OR s.MiddleName IS NULL 
                             THEN '' ELSE CONCAT(' ', LEFT(s.MiddleName,1),'.') END,
                        ' (', c.CompanyName, ')'
                    ) AS DisplayText
             FROM internship i
             INNER JOIN student s ON i.StudentID = s.StudentID
             INNER JOIN company c ON c.CompanyID = i.CompanyID
             WHERE i.EvaluatingFacultyID = @FacultyID
               AND i.IsDeleted = 0
               AND i.Status = @StatusFilter
             ORDER BY s.LastName, s.FirstName;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)
                cmd.Parameters.AddWithValue("@StatusFilter",
                If(cboVLStatusFilter.SelectedItem = "Completed", "Completed", "Active"))
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            cboVLInternship.DataSource = dt
            cboVLInternship.DisplayMember = "DisplayText"
            cboVLInternship.ValueMember = "InternshipID"
            cboVLInternship.SelectedIndex = -1
        End Using
    End Sub
    Private Sub cboVLStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) _
    Handles cboVLStatusFilter.SelectedIndexChanged

        RemoveHandler cboVLInternship.SelectedIndexChanged, AddressOf cboVLInternship_SelectedIndexChanged

        cboVLInternship.DataSource = Nothing
        ClearVisitLogFields()
        dgvVisitLogs.DataSource = Nothing

        LoadVisitLogInternships()

        AddHandler cboVLInternship.SelectedIndexChanged, AddressOf cboVLInternship_SelectedIndexChanged
    End Sub



    Private Sub cboVLInternship_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVLInternship.SelectedIndexChanged
        If Not cboVLInternship.Focused Then Return

        If cboVLInternship.SelectedIndex < 0 Then
            ClearVisitLogForm()
            dgvVisitLogs.DataSource = Nothing
            Return
        End If

        LoadVisitHeaderForSelected()
        LoadVisitLogsForSelected()
    End Sub

    Private Sub LoadVisitHeaderForSelected()
        If cboVLInternship.SelectedIndex < 0 Then Return

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim sql As String =
            "SELECT s.StudentNumber, " &
            "       CONCAT(s.LastName, ', ', s.FirstName, " &
            "              CASE WHEN s.MiddleName IS NULL OR s.MiddleName='' " &
            "                   THEN '' ELSE CONCAT(' ', s.MiddleName) END) AS FullName, " &
            "       CONCAT(crs.CourseCode, ' / ', sec.SectionName) AS CourseSection, " &
            "       c.CompanyName, " &
            "       CONCAT(cc.LastName, ', ', cc.FirstName) AS SupervisorName " &
            "FROM internship i " &
            "INNER JOIN student s ON i.StudentID = s.StudentID " &
            "INNER JOIN section sec ON s.SectionID = sec.SectionID " &
            "INNER JOIN course crs ON sec.CourseID = crs.CourseID " &
            "INNER JOIN company c ON i.CompanyID = c.CompanyID " &
            "INNER JOIN companycontact cc ON i.SupervisorContactID = cc.ContactID " &
            "WHERE i.InternshipID = @InternshipID;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@InternshipID", CInt(cboVLInternship.SelectedValue))
                Using rdr As MySqlDataReader = cmd.ExecuteReader()
                    If rdr.Read() Then
                        lblVLStudentNumber.Text = rdr("StudentNumber").ToString()
                        lblVLStudentName.Text = rdr("FullName").ToString()
                        lblVLCourseSection.Text = rdr("CourseSection").ToString()
                        lblVLCompany.Text = rdr("CompanyName").ToString()
                        lblVLSupervisor.Text = rdr("SupervisorName").ToString()
                    End If
                End Using
            End Using
        End Using
    End Sub


    Private Sub LoadVisitLogsForSelected()
        If cboVLInternship.SelectedIndex < 0 Then
            dgvVisitLogs.DataSource = Nothing
            Return
        End If

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim dt As New DataTable()
            Dim sql As String =
            "SELECT VisitID, VisitDate, VisitType, HoursAdded, Score, MaxScore, Remarks, AttachmentPath " &
            "FROM visitlog " &
            "WHERE InternshipID = @InternshipID " &
            "ORDER BY VisitDate DESC, VisitID DESC;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@InternshipID", CInt(cboVLInternship.SelectedValue))
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            dgvVisitLogs.DataSource = dt
        End Using
    End Sub


    Private Sub btnVLBrowse_Click(sender As Object, e As EventArgs) Handles btnVLBrowse.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select attachment"
            ofd.Filter = "All files|*.*"
            If ofd.ShowDialog() = DialogResult.OK Then
                txtVLAttachment.Text = ofd.FileName
            End If
        End Using
    End Sub


    ' ------------------------------------------------------
    ' SAVE VISIT LOG
    ' ------------------------------------------------------
    Private Sub btnVLSave_Click(sender As Object, e As EventArgs) Handles btnVLSave.Click

        ' --- VALIDATIONS ---
        If cboVLStatusFilter.SelectedItem = "Completed" Then
            MessageBox.Show("You cannot create NEW visit logs for a completed internship." &
                    vbCrLf & "You may only EDIT existing visit logs.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboVLInternship.SelectedIndex < 0 Then
            MessageBox.Show("Please select an internship first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cboVLVisitType.SelectedIndex < 0 Then
            MessageBox.Show("Please select a Visit Type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim hoursRendered As Decimal
        If Not Decimal.TryParse(txtVLHoursRendered.Text.Trim(), hoursRendered) OrElse hoursRendered < 0D Then
            MessageBox.Show("Hours Rendered must be a valid non-negative number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Compute performance percent (1–5 scale)
        Dim overallPercent As Decimal
        Try
            overallPercent = ComputeVisitOverallPercent()
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End Try

        lblVLOverallScore.Text = overallPercent.ToString("0.00")

        Dim internshipID As Integer = CInt(cboVLInternship.SelectedValue)
        Dim visitType As String = cboVLVisitType.Text
        Dim attachment As String = txtVLAttachment.Text.Trim()
        Dim remarks As String = txtVLRemarks.Text.Trim()
        Dim visitDate As Date = dtpVLDate.Value.Date

        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Using tx As MySqlTransaction = conn.BeginTransaction()

                Try
                    Dim isEdit As Boolean = Not String.IsNullOrWhiteSpace(txtVLEditID.Text)
                    Dim sql As String

                    ' =====================================================
                    ' INSERT MODE (NO EDIT ID)
                    ' =====================================================
                    If Not isEdit Then

                        ' Prevent duplicate VisitType per internship
                        sql = "SELECT COUNT(*) FROM visitlog 
                           WHERE InternshipID = @InternshipID 
                             AND VisitType = @VisitType;"

                        Using cmdCheck As New MySqlCommand(sql, conn, tx)
                            cmdCheck.Parameters.AddWithValue("@InternshipID", internshipID)
                            cmdCheck.Parameters.AddWithValue("@VisitType", visitType)
                            Dim existing As Integer = CInt(cmdCheck.ExecuteScalar())
                            If existing > 0 Then
                                MessageBox.Show("A " & visitType & " visit already exists for this internship." &
                                                vbCrLf & "Click the row below and press EDIT instead.",
                                                "Duplicate Visit Type",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                tx.Rollback()
                                Return
                            End If
                        End Using

                        ' INSERT NEW VISIT
                        sql =
                        "INSERT INTO visitlog 
                        (InternshipID, FacultyID, VisitDate, VisitType, 
                         HoursAdded, Score, MaxScore, Remarks, AttachmentPath,
                         CreatedAt, UpdatedAt)
                     VALUES
                        (@InternshipID, @FacultyID, @VisitDate, @VisitType,
                         @HoursAdded, @Score, @MaxScore, @Remarks, @AttachmentPath,
                         NOW(), NOW());"

                        Using cmd As New MySqlCommand(sql, conn, tx)
                            cmd.Parameters.AddWithValue("@InternshipID", internshipID)
                            cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)
                            cmd.Parameters.AddWithValue("@VisitDate", visitDate)
                            cmd.Parameters.AddWithValue("@VisitType", visitType)
                            cmd.Parameters.AddWithValue("@HoursAdded", hoursRendered)
                            cmd.Parameters.AddWithValue("@Score", overallPercent)
                            cmd.Parameters.AddWithValue("@MaxScore", 100D)
                            cmd.Parameters.AddWithValue("@Remarks", remarks)
                            cmd.Parameters.AddWithValue("@AttachmentPath", attachment)
                            cmd.ExecuteNonQuery()
                        End Using

                    Else
                        ' =====================================================
                        ' UPDATE MODE
                        ' =====================================================
                        Dim visitID As Integer = CInt(txtVLEditID.Text)

                        sql =
                        "UPDATE visitlog SET
                        VisitDate = @VisitDate,
                        VisitType = @VisitType,
                        HoursAdded = @HoursAdded,
                        Score = @Score,
                        MaxScore = @MaxScore,
                        Remarks = @Remarks,
                        AttachmentPath = @AttachmentPath,
                        UpdatedAt = NOW()
                     WHERE VisitID = @VisitID;"

                        Using cmd As New MySqlCommand(sql, conn, tx)
                            cmd.Parameters.AddWithValue("@VisitID", visitID)
                            cmd.Parameters.AddWithValue("@VisitDate", visitDate)
                            cmd.Parameters.AddWithValue("@VisitType", visitType)
                            cmd.Parameters.AddWithValue("@HoursAdded", hoursRendered)
                            cmd.Parameters.AddWithValue("@Score", overallPercent)
                            cmd.Parameters.AddWithValue("@MaxScore", 100D)
                            cmd.Parameters.AddWithValue("@Remarks", remarks)
                            cmd.Parameters.AddWithValue("@AttachmentPath", attachment)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If

                    ' =====================================================
                    ' UPDATE INTERNSHIP HOURS COMPLETED
                    ' =====================================================
                    Dim sqlHours As String =
                    "UPDATE internship SET HoursCompleted = 
                    (SELECT IFNULL(SUM(HoursAdded), 0)
                       FROM visitlog 
                      WHERE InternshipID = @InternshipID)
                 WHERE InternshipID = @InternshipID;"

                    Using cmdHours As New MySqlCommand(sqlHours, conn, tx)
                        cmdHours.Parameters.AddWithValue("@InternshipID", internshipID)
                        cmdHours.ExecuteNonQuery()
                    End Using

                    ' =====================================================
                    ' NO MORE SUPERVISOR SCORE UPDATE HERE!!!
                    ' Final visit score stays ONLY in visitlog.Score
                    ' =====================================================

                    ' =====================================================
                    ' LOGS
                    ' =====================================================
                    AddProfessorLog(CurrentFacultyID,
                                    "Visit Log",
                                    If(isEdit,
                                    "Updated visit log (" & visitType & ") for " & cboVLInternship.Text,
                                    "Created visit log (" & visitType & ") for " & cboVLInternship.Text))

                    If Not String.IsNullOrWhiteSpace(attachment) Then
                        AddProfessorLog(CurrentFacultyID,
                                        "File Upload",
                                        "Attached file for " & cboVLInternship.Text)
                    End If

                    tx.Commit()

                Catch ex As Exception
                    tx.Rollback()
                    MessageBox.Show("Error saving visit log: " & ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
            End Using
        End Using

        ' Success
        MessageBox.Show("Visit log saved successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

        txtVLEditID.Text = ""
        LoadVisitLogsForSelected()
        Try : LoadHomeCards() : Catch : End Try
        ClearVisitLogForm()

    End Sub


    Private Sub ClearVisitLogFields()

        ' Clear dropdowns
        cboVLInternship.SelectedIndex = -1
        cboVLVisitType.SelectedIndex = -1

        ' Clear student details
        lblVLStudentName.Text = ""
        lblVLStudentNumber.Text = ""
        lblVLCourseSection.Text = ""
        lblVLCompany.Text = ""
        lblVLSupervisor.Text = ""

        ' Clear criteria
        cboVLTech.SelectedIndex = -1
        cboVLComm.SelectedIndex = -1
        cboVLBehavior.SelectedIndex = -1
        cboVLAttendance.SelectedIndex = -1
        cboVLQuality.SelectedIndex = -1

        lblVLOverallScore.Text = "0.00"

        ' Clear hours and remarks
        txtVLHoursRendered.Text = ""
        txtVLRemarks.Text = ""
        txtVLAttachment.Text = ""

        ' Clear edit state
        txtVLEditID.Text = ""
    End Sub

    Private Sub ClearVisitLogForm()
        txtVLEditID.Text = ""
        dtpVLDate.Value = Date.Today
        cboVLVisitType.SelectedIndex = -1

        cboVLTech.SelectedIndex = -1
        cboVLComm.SelectedIndex = -1
        cboVLBehavior.SelectedIndex = -1
        cboVLAttendance.SelectedIndex = -1
        cboVLQuality.SelectedIndex = -1

        lblVLOverallScore.Text = "0.00"
        txtVLHoursRendered.Text = ""
        txtVLRemarks.Text = ""
        txtVLAttachment.Text = ""
    End Sub

    Private Sub btnVLCancel_Click(sender As Object, e As EventArgs) Handles btnVLCancel.Click
        ClearVisitLogForm()
    End Sub



    Private Sub UpdateVisitLog()
        Dim visitID As Integer = CInt(txtVLEditID.Text)

        Dim score As Decimal
        Dim maxScore As Decimal
        Dim hoursAdded As Integer

        If Not Decimal.TryParse(txtVLScore.Text, score) OrElse
       Not Decimal.TryParse(txtVLMaxScore.Text, maxScore) OrElse
       Not Integer.TryParse(txtVLHoursAdded.Text, hoursAdded) Then

            MessageBox.Show("Please fill in all fields correctly.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim sql As String =
            "UPDATE visitlog SET " &
            "VisitType=@VisitType, Score=@Score, MaxScore=@MaxScore, " &
            "Remarks=@Remarks, AttachmentPath=@AttachmentPath, " &
            "HoursAdded=@HoursAdded, UpdatedAt=NOW() " &
            "WHERE VisitID=@VisitID;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@VisitType", cboVLVisitType.Text)
                cmd.Parameters.AddWithValue("@Score", score)
                cmd.Parameters.AddWithValue("@MaxScore", maxScore)
                cmd.Parameters.AddWithValue("@Remarks", txtVLRemarks.Text.Trim())
                cmd.Parameters.AddWithValue("@AttachmentPath", txtVLAttachment.Text.Trim())
                cmd.Parameters.AddWithValue("@HoursAdded", hoursAdded)
                cmd.Parameters.AddWithValue("@VisitID", visitID)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        AddProfessorLog(CurrentFacultyID, "Visit Log", "Updated visit log ID " & visitID)

        MessageBox.Show("Visit log updated!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)

        txtVLEditID.Text = ""
        btnVLSave.Text = "Save"
        btnVLSave.BackColor = Color.ForestGreen

        LoadVisitLogsForSelected()
    End Sub


    Private Sub dgvVisitLogs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVisitLogs.CellContentClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return

        Dim colName As String = dgvVisitLogs.Columns(e.ColumnIndex).Name
        Dim visitID As Integer = CInt(dgvVisitLogs.Rows(e.RowIndex).Cells("VisitID").Value)
        Dim visitType As String = dgvVisitLogs.Rows(e.RowIndex).Cells("VisitType").Value.ToString()

        ' ====== DELETE ======
        If colName = "colDelete" Then
            If visitType = "Final" Then
                MessageBox.Show("Final Visit Log cannot be deleted.", "Restricted",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Return
            End If

            If MessageBox.Show("Delete this visit log?", "Confirm",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Using conn As MySqlConnection = GetConnection()
                    conn.Open()

                    Dim sql As String = "DELETE FROM visitlog WHERE VisitID = @VisitID;"
                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@VisitID", visitID)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Recompute internship hours
                    If cboVLInternship.SelectedIndex >= 0 Then
                        Dim internshipID As Integer = CInt(cboVLInternship.SelectedValue)
                        Dim sqlHours As String =
                        "UPDATE internship SET HoursCompleted = " &
                        " (SELECT IFNULL(SUM(HoursAdded),0) FROM visitlog WHERE InternshipID=@InternshipID) " &
                        "WHERE InternshipID=@InternshipID;"

                        Using cmdH As New MySqlCommand(sqlHours, conn)
                            cmdH.Parameters.AddWithValue("@InternshipID", internshipID)
                            cmdH.ExecuteNonQuery()
                        End Using
                    End If
                End Using

                AddProfessorLog(CurrentFacultyID, "Visit Log", "Deleted visit log (" & visitType & ")")

                LoadVisitLogsForSelected()
                MessageBox.Show("Visit log deleted.", "Deleted",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' ====== EDIT ======
        ElseIf colName = "colEdit" Then
            ' Load selected row back into form
            txtVLEditID.Text = visitID.ToString()
            dtpVLDate.Value = CDate(dgvVisitLogs.Rows(e.RowIndex).Cells("VisitDate").Value)
            cboVLVisitType.Text = visitType

            txtVLHoursRendered.Text = dgvVisitLogs.Rows(e.RowIndex).Cells("HoursAdded").Value.ToString()
            txtVLRemarks.Text = dgvVisitLogs.Rows(e.RowIndex).Cells("Remarks").Value.ToString()

            Dim path As String = dgvVisitLogs.Rows(e.RowIndex).Cells("AttachmentPath").Value.ToString()
            txtVLAttachment.Text = path

            ' We stored only Overall Score in Score column. 
            ' We CANNOT recover the 1–5 criteria from that, so user must re-select them if needed.
            lblVLOverallScore.Text = dgvVisitLogs.Rows(e.RowIndex).Cells("Score").Value.ToString()

            MessageBox.Show("Visit log loaded for editing. Please re-check criteria and details.",
                        "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' ====== DOWNLOAD FILE ======
        ElseIf colName = "colDownload" Then

            Dim pathObj = dgvVisitLogs.Rows(e.RowIndex).Cells("AttachmentPath").Value

            If pathObj Is Nothing Then
                MessageBox.Show("No attachment found for this visit log.", "Missing File",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim path As String = pathObj.ToString().Trim()

            If String.IsNullOrEmpty(path) OrElse Not System.IO.File.Exists(path) Then
                MessageBox.Show("Attachment file is missing or path is invalid.", "File Not Found",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Try
                Dim psi As New ProcessStartInfo()
                psi.FileName = path
                psi.UseShellExecute = True
                Process.Start(psi)

            Catch ex As Exception
                MessageBox.Show("Unable to open the file:" & vbCrLf & ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub
    Private Sub btnVLGenerateChecklist_Click(sender As Object, e As EventArgs) Handles btnVLGenerateVisitLog.Click

        If cboVLInternship.SelectedIndex < 0 Then
            MessageBox.Show("Please select an internship first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Save file dialog
        Dim save As New SaveFileDialog()
        save.Filter = "PDF File|*.pdf"
        save.Title = "Save Visit Log"
        save.FileName = lblVLStudentNumber.Text & "_" & cboVLVisitType.Text.Replace(" ", "") & "_VisitLog.pdf"

        If save.ShowDialog() <> DialogResult.OK Then Exit Sub

        Try
            Dim fs As New FileStream(save.FileName, FileMode.Create, FileAccess.Write)
            Dim doc As New Document(PageSize.A4, 40, 40, 40, 40)
            Dim writer = PdfWriter.GetInstance(doc, fs)

            doc.Open()

            Dim titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)
            Dim bold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)
            Dim normal = FontFactory.GetFont(FontFactory.HELVETICA, 11)

            ' TITLE
            doc.Add(New Paragraph(cboVLVisitType.Text.ToUpper() & " VisitLog ", titleFont))
            doc.Add(New Paragraph(" "))
            doc.Add(New LineSeparator())

            ' STUDENT INFO
            doc.Add(New Paragraph("Student Name: " & lblVLStudentName.Text, normal))
            doc.Add(New Paragraph("Student Number: " & lblVLStudentNumber.Text, normal))
            doc.Add(New Paragraph("Course & Section: " & lblVLCourseSection.Text, normal))
            doc.Add(New Paragraph("Company: " & lblVLCompany.Text, normal))
            doc.Add(New Paragraph("Supervisor: " & lblVLSupervisor.Text, normal))
            doc.Add(New Paragraph("Visit Date: " & dtpVLDate.Value.ToLongDateString(), normal))
            doc.Add(New Paragraph(" "))
            doc.Add(New LineSeparator())

            ' PERFORMANCE CRITERIA
            doc.Add(New Paragraph("PERFORMANCE EVALUATION (1–5)", bold))
            doc.Add(New Paragraph("Technical Skills: " & cboVLTech.Text, normal))
            doc.Add(New Paragraph("Communication Skills: " & cboVLComm.Text, normal))
            doc.Add(New Paragraph("Professional Behavior: " & cboVLBehavior.Text, normal))
            doc.Add(New Paragraph("Attendance / Timeliness: " & cboVLAttendance.Text, normal))
            doc.Add(New Paragraph("Quality of Work Output: " & cboVLQuality.Text, normal))

            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph("Overall Performance: " & lblVLOverallScore.Text, bold))
            doc.Add(New Paragraph(" "))
            doc.Add(New LineSeparator())

            ' HOURS & REMARKS
            doc.Add(New Paragraph("Hours Rendered: " & txtVLHoursRendered.Text, normal))
            doc.Add(New Paragraph("Remarks:", bold))
            doc.Add(New Paragraph(txtVLRemarks.Text, normal))

            doc.Add(New Paragraph(" "))
            doc.Add(New LineSeparator())

            ' SIGNATURE LINE
            doc.Add(New Paragraph("Evaluator: " & lblVLSupervisor.Text, normal))

            doc.Close()
            writer.Close()
            fs.Close()

            MessageBox.Show("Visit Log PDF Generated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error generating PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ShowPanel(p As Panel)

        ' BEFORE activating new panel, clear Visit Logs if user is LEAVING it.
        If pnlVisitLogs.Visible = True Then
            ClearVisitLogFields()
            dgvVisitLogs.DataSource = Nothing
        End If

        ' === Hide all panels ===
        pnlHome.Visible = False
        pnlStudents.Visible = False
        pnlInternshipAssignment.Visible = False
        pnlVisitLogs.Visible = False
        pnlGrading.Visible = False
        pnlCompanies.Visible = False
        pnlCompanyContacts.Visible = False
        pnlProfile.Visible = False

        ' === Show selected panel ===
        p.Visible = True

        ' OPTIONAL: also refresh when entering
        If p Is pnlVisitLogs Then
            ClearVisitLogFields()
        End If

        ' --- If leaving Grading Panel, reset it ---
        If pnlGrading.Visible = True Then
            ClearGradingFields()
            cboGRStudent.SelectedIndex = -1
        End If

        ' Hide all panels
        pnlHome.Visible = False
        pnlStudents.Visible = False
        pnlInternshipAssignment.Visible = False
        pnlVisitLogs.Visible = False
        pnlGrading.Visible = False
        pnlCompanies.Visible = False
        pnlCompanyContacts.Visible = False
        pnlProfile.Visible = False

        ' Show selected
        p.Visible = True

        ' When entering grading panel:
        If p Is pnlGrading Then
            ClearGradingFields()
            LoadGradingStudents()
        End If

        If p Is pnlGrading Then
            LoadGradingStudents()
            ClearGradingFields()
        End If

    End Sub
    ' AUTO UPDATE OVERALL SCORE WHENEVER A DROPDOWN CHANGES
    Private Sub AutoComputeVisitScore()
        Try
            ' Only compute if ALL have a value
            If cboVLTech.SelectedIndex >= 0 AndAlso
           cboVLComm.SelectedIndex >= 0 AndAlso
           cboVLBehavior.SelectedIndex >= 0 AndAlso
           cboVLAttendance.SelectedIndex >= 0 AndAlso
           cboVLQuality.SelectedIndex >= 0 Then

                Dim percent As Decimal = ComputeVisitOverallPercent()
                lblVLOverallScore.Text = percent.ToString("0.00")
            Else
                lblVLOverallScore.Text = "0.00"
            End If

        Catch
            lblVLOverallScore.Text = "0.00"
        End Try
    End Sub
    Private Sub VisitCriteriaChanged(sender As Object, e As EventArgs) _
    Handles cboVLTech.SelectedIndexChanged,
            cboVLComm.SelectedIndexChanged,
            cboVLBehavior.SelectedIndexChanged,
            cboVLAttendance.SelectedIndexChanged,
            cboVLQuality.SelectedIndexChanged

        AutoComputeVisitScore()
    End Sub



    ' ------------------------------------------------------
    '  GRADING
    ' ------------------------------------------------------

    ' Load ACTIVE internships (normal grading mode)
    Private Sub LoadActiveInternships()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim dt As New DataTable()

            Dim sql As String =
            "SELECT i.InternshipID,
                    CONCAT(s.StudentNumber, ' - ', s.LastName, ', ', s.FirstName) AS DisplayName
             FROM internship i
             INNER JOIN student s ON s.StudentID = i.StudentID
             WHERE i.EvaluatingFacultyID = @FacultyID
               AND i.Status = 'Active'
               AND i.IsDeleted = 0
             ORDER BY s.LastName, s.FirstName;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            IsInternalChange = True
            cboGRStudent.DataSource = dt
            cboGRStudent.DisplayMember = "DisplayName"
            cboGRStudent.ValueMember = "InternshipID"
            cboGRStudent.SelectedIndex = -1
            IsInternalChange = False
        End Using
    End Sub

    ' Check if internship has Initial, Midterm, and Final visit logs
    Private Function HasAllRequiredVisitLogs(internshipID As Integer) As Boolean
        Using conn = GetConnection()
            conn.Open()

            Dim sql As String =
            "SELECT COUNT(DISTINCT VisitType)
             FROM visitlog
             WHERE InternshipID = @ID
               AND VisitType IN ('Initial', 'Midterm', 'Final');"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ID", internshipID)
                Dim cnt As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                ' Must have all 3 types
                Return (cnt = 3)
            End Using
        End Using
    End Function

    ' Ensure all grading criteria have selected values (1–5)
    Private Function AreAllFacultyCriteriaSelected() As Boolean
        Dim missing As New List(Of String)()

        If cboGRF_Tech.SelectedIndex < 0 Then missing.Add("Technical Skills")
        If cboGRF_Professionalism.SelectedIndex < 0 Then missing.Add("Professionalism / Behavior")
        If cboGRF_Communication.SelectedIndex < 0 Then missing.Add("Communication Skills")
        If cboGRF_Attendance.SelectedIndex < 0 Then missing.Add("Attendance & Punctuality")
        If cboGRF_OutputQuality.SelectedIndex < 0 Then missing.Add("Quality of Work Output")
        If cboGRF_FinalInterview.SelectedIndex < 0 Then missing.Add("Final Interview / Exit")

        If missing.Count > 0 Then
            Dim msg As String =
            "Please select a grade (1–5) for the following:" & Environment.NewLine &
            String.Join(Environment.NewLine, missing)
            MessageBox.Show(msg, "Missing Grades", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    ' ================================
    '  LOAD COMPLETED INTERNSHIPS
    '  (Edit mode)
    ' ================================
    Private Sub LoadCompletedInternshipsForEdit()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()
            Dim dt As New DataTable()

            Dim sql As String =
            "SELECT i.InternshipID,
                    CONCAT(s.StudentNumber, ' - ', s.LastName, ', ', s.FirstName) AS DisplayName
             FROM internship i
             INNER JOIN student s ON s.StudentID = i.StudentID
             WHERE i.EvaluatingFacultyID = @FacultyID
               AND i.Status = 'Completed'
               AND i.IsDeleted = 0
             ORDER BY s.LastName, s.FirstName;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            IsInternalChange = True
            cboGRStudent.DataSource = dt
            cboGRStudent.DisplayMember = "DisplayName"
            cboGRStudent.ValueMember = "InternshipID"
            IsInternalChange = False
        End Using
    End Sub


    ' Enable / disable inputs (kept TRUE in both modes for now)
    Private Sub SetGradingEditMode(enabled As Boolean)
        cboGRF_Tech.Enabled = enabled
        cboGRF_Professionalism.Enabled = enabled
        cboGRF_Communication.Enabled = enabled
        cboGRF_Attendance.Enabled = enabled
        cboGRF_OutputQuality.Enabled = enabled
        cboGRF_FinalInterview.Enabled = enabled

        btnGRBrowse.Enabled = enabled
        btnGRSave.Enabled = enabled
        txtGREvalFile.Enabled = enabled
    End Sub

    Private Sub ClearGradingFields()
        lblGRStudentName.Text = ""
        lblGRStudentNumber.Text = ""
        lblGRCourseSection.Text = ""
        lblGRCompany.Text = ""
        lblGRSupervisor.Text = ""
        lblGRRequiredHours.Text = ""
        lblGRCompletedHours.Text = ""
        lblGRInternshipStatus.Text = ""

        lblGRSupervisorScore.Text = "0.00"

        cboGRF_Tech.SelectedIndex = -1
        cboGRF_Professionalism.SelectedIndex = -1
        cboGRF_Communication.SelectedIndex = -1
        cboGRF_Attendance.SelectedIndex = -1
        cboGRF_OutputQuality.SelectedIndex = -1
        cboGRF_FinalInterview.SelectedIndex = -1

        lblGRFacultyTotal.Text = "0.00"
        lblGRFGSupervisor.Text = "0.00"
        lblGRFGFaculty.Text = "0.00"
        lblGRFinalGradeAuto.Text = "0.00"

        txtGREvalFile.Text = ""
        lblGRWarning.Text = ""
    End Sub

    ' Old public loader
    Private Sub LoadGradingStudents()
        LoadActiveInternships()
    End Sub


    Private Sub cboGRStudent_SelectedIndexChanged(sender As Object, e As EventArgs) _
Handles cboGRStudent.SelectedIndexChanged

        If IsInternalChange Then Return

        If cboGRStudent.SelectedIndex >= 0 AndAlso cboGRStudent.SelectedValue IsNot Nothing Then
            LoadGradingOverview()
        Else
            ClearGradingFields()
        End If
    End Sub


    Private Sub LoadGradingOverview()
        If cboGRStudent.SelectedIndex < 0 Then Return

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim sql As String =
            "SELECT 
                 s.StudentNumber,
                 CONCAT(
                     s.LastName, ', ', s.FirstName,
                     CASE WHEN s.MiddleName IS NULL OR s.MiddleName = '' 
                          THEN '' ELSE CONCAT(' ', LEFT(s.MiddleName, 1), '.') END
                 ) AS FullName,

                 CONCAT(c.CourseCode, ' / ', sec.SectionName) AS CourseSection,
                 co.CompanyName,
                 CONCAT(ct.LastName, ', ', ct.FirstName) AS SupervisorName,

                 i.RequiredHours,
                 i.HoursCompleted,
                 i.Status,
                 i.FinalGrade,
                 i.EvaluationReportPath,

                 (
                     SELECT v.Score 
                     FROM visitlog v
                     WHERE v.InternshipID = i.InternshipID
                       AND v.VisitType = 'Final'
                     ORDER BY v.VisitDate DESC, v.VisitID DESC
                     LIMIT 1
                 ) AS SupervisorScore

             FROM internship i
             INNER JOIN student s        ON s.StudentID      = i.StudentID
             INNER JOIN section sec      ON sec.SectionID    = s.SectionID
             INNER JOIN course c         ON c.CourseID       = sec.CourseID
             INNER JOIN company co       ON co.CompanyID     = i.CompanyID
             INNER JOIN companycontact ct ON ct.ContactID    = i.SupervisorContactID
             WHERE i.InternshipID = @ID;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ID", CInt(cboGRStudent.SelectedValue))

                Using r As MySqlDataReader = cmd.ExecuteReader()
                    If r.Read() Then

                        ' --------------------------
                        ' BASIC INFO
                        ' --------------------------
                        lblGRStudentName.Text = r("FullName").ToString()
                        lblGRStudentNumber.Text = r("StudentNumber").ToString()
                        lblGRCourseSection.Text = r("CourseSection").ToString()
                        lblGRCompany.Text = r("CompanyName").ToString()
                        lblGRSupervisor.Text = r("SupervisorName").ToString()
                        lblGRRequiredHours.Text = r("RequiredHours").ToString()
                        lblGRCompletedHours.Text = r("HoursCompleted").ToString()
                        lblGRInternshipStatus.Text = r("Status").ToString()

                        ' --------------------------
                        ' SUPERVISOR SCORE
                        ' --------------------------
                        Dim supScore As Decimal = 0D
                        If Not IsDBNull(r("SupervisorScore")) Then
                            supScore = CDec(r("SupervisorScore"))
                        End If

                        lblGRSupervisorScore.Text = supScore.ToString("0.00")

                        ' ALWAYS mirror supervisor score
                        lblGRFGSupervisor.Text = lblGRSupervisorScore.Text

                        ' --------------------------
                        ' FINAL GRADE LOGIC
                        ' --------------------------
                        If IsEditing Then
                            ' Load stored grade for this internship
                            If Not IsDBNull(r("FinalGrade")) Then
                                lblGRFinalGradeAuto.Text = CDec(r("FinalGrade")).ToString("0.00")
                            Else
                                lblGRFinalGradeAuto.Text = "0.00"
                            End If
                        Else
                            ' Normal mode → recalc live
                            ComputeFacultyScore()
                            ComputeFinalGrade()
                        End If

                        ' --------------------------
                        ' REPORT PATH
                        ' --------------------------
                        If Not IsDBNull(r("EvaluationReportPath")) Then
                            txtGREvalFile.Text = r("EvaluationReportPath").ToString()
                        Else
                            txtGREvalFile.Text = ""
                        End If

                    End If
                End Using
            End Using
        End Using
    End Sub



    Private Sub FacultyEvalChanged(sender As Object, e As EventArgs) Handles _
    cboGRF_Tech.SelectedIndexChanged,
    cboGRF_Professionalism.SelectedIndexChanged,
    cboGRF_Communication.SelectedIndexChanged,
    cboGRF_Attendance.SelectedIndexChanged,
    cboGRF_OutputQuality.SelectedIndexChanged,
    cboGRF_FinalInterview.SelectedIndexChanged

        ComputeFacultyScore()
        ComputeFinalGrade()
    End Sub

    Private Sub ComputeFacultyScore()
        Dim values As New List(Of Integer)

        For Each cbo As ComboBox In {
        cboGRF_Tech, cboGRF_Professionalism, cboGRF_Communication,
        cboGRF_Attendance, cboGRF_OutputQuality, cboGRF_FinalInterview
    }
            If cbo.SelectedIndex >= 0 Then
                values.Add(CInt(cbo.SelectedItem))
            End If
        Next

        If values.Count = 0 Then
            lblGRFacultyTotal.Text = "0.00"
            lblGRFGFaculty.Text = "0.00"
            Return
        End If

        Dim avg As Double = values.Average()
        Dim percent As Decimal = CDec(avg) * 20D   ' 1–5 → 20–100

        lblGRFacultyTotal.Text = percent.ToString("0.00")
        lblGRFGFaculty.Text = lblGRFacultyTotal.Text
    End Sub

    Private Sub ComputeFinalGrade()
        Dim sup As Decimal
        Dim fac As Decimal

        If Not Decimal.TryParse(lblGRFGSupervisor.Text, sup) Then sup = 0D
        If Not Decimal.TryParse(lblGRFGFaculty.Text, fac) Then fac = 0D

        Dim finalGrade As Decimal = (sup * 0.6D) + (fac * 0.4D)
        lblGRFinalGradeAuto.Text = finalGrade.ToString("0.00")
    End Sub


    ' =======================
    '  EDIT / CANCEL MODE
    ' =======================
    Private Sub btnGREdit_Click(sender As Object, e As EventArgs) Handles btnGREdit.Click

        IsEditing = True

        btnGREdit.Visible = False
        btnGRCancel.Visible = True

        SetGradingEditMode(True)

        ' Load completed list — DO NOT reselect anything automatically
        IsInternalChange = True
        LoadCompletedInternshipsForEdit()
        IsInternalChange = False

        MessageBox.Show("Edit mode activated. Please select a completed internship.", "Edit Mode")
    End Sub


    Private Sub btnGRCancel_Click(sender As Object, e As EventArgs) Handles btnGRCancel.Click
        IsEditing = False
        EditingInternshipID = 0
        LockedSupervisorScore = 0D

        btnGREdit.Visible = True
        btnGRCancel.Visible = False

        ClearGradingFields()
        LoadActiveInternships()
        SetGradingEditMode(True)

        MessageBox.Show("Edit mode cancelled. Back to normal grading.", "Cancelled")
    End Sub




    ' =======================
    '  BROWSE REPORT FILE
    ' =======================
    Private Sub btnGRBrowseReport_Click(sender As Object, e As EventArgs) Handles btnGRBrowse.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select Final Evaluation Report"
            ofd.Filter = "PDF files|*.pdf|All files|*.*"
            If ofd.ShowDialog() = DialogResult.OK Then
                txtGREvalFile.Text = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub btnGRClear_Click(sender As Object, e As EventArgs) Handles btnGRClear.Click
        RemoveHandler cboGRStudent.SelectedIndexChanged, AddressOf cboGRStudent_SelectedIndexChanged

        cboGRStudent.SelectedIndex = -1
        ClearGradingFields()

        AddHandler cboGRStudent.SelectedIndexChanged, AddressOf cboGRStudent_SelectedIndexChanged

        MessageBox.Show("Grading fields cleared.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnGRSaveGrade_Click(sender As Object, e As EventArgs) Handles btnGRSave.Click
        lblGRWarning.Text = ""

        ' 1) Must select a student internship
        If cboGRStudent.SelectedIndex < 0 Then
            lblGRWarning.Text = "⚠ Please select a student internship."
            MessageBox.Show(lblGRWarning.Text, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2) Final grade must be valid
        Dim grade As Decimal
        If Not Decimal.TryParse(lblGRFinalGradeAuto.Text, grade) Then
            lblGRWarning.Text = "⚠ Final grade is not valid."
            MessageBox.Show(lblGRWarning.Text, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 3) All grading comboboxes must have a selected value
        If Not AreAllFacultyCriteriaSelected() Then
            ' Message already shown inside helper
            Exit Sub
        End If

        Dim internshipID As Integer = CInt(cboGRStudent.SelectedValue)

        ' 4) Must have Initial, Midterm, and Final visit logs
        If Not HasAllRequiredVisitLogs(internshipID) Then
            Dim msg As String =
            "This student does not have complete visit logs." & Environment.NewLine &
            "Required visits: Initial, Midterm, and Final." & Environment.NewLine &
            "You cannot save the final grade until all required visits are recorded."
            MessageBox.Show(msg, "Missing Visit Logs", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 5) Must have met required hours (HoursCompleted >= RequiredHours)
        Dim requiredHours As Decimal = 0D
        Dim completedHours As Decimal = 0D
        Decimal.TryParse(lblGRRequiredHours.Text, requiredHours)
        Decimal.TryParse(lblGRCompletedHours.Text, completedHours)

        If completedHours < requiredHours Then
            Dim msg As String =
            "The student has not yet completed the required OJT hours." & Environment.NewLine &
            "Required: " & requiredHours.ToString("0.##") & " hrs" & Environment.NewLine &
            "Rendered: " & completedHours.ToString("0.##") & " hrs" & Environment.NewLine &
            "You cannot finalize the grade until the required hours are met."
            MessageBox.Show(msg, "Hours Not Completed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ===========================
        ' 6) SAVE TO DATABASE
        ' ===========================
        Using conn = GetConnection()
            conn.Open()

            Dim sql As String

            If IsEditing Then
                sql =
            "UPDATE internship 
             SET FinalGrade = @FinalGrade,
                 EvaluationReportPath = @Path,
                 GradedByFacultyID = @FacultyID,
                 UpdatedAt = NOW()
             WHERE InternshipID = @ID;"
            Else
                sql =
            "UPDATE internship 
             SET FinalGrade = @FinalGrade,
                 EvaluationReportPath = @Path,
                 GradedByFacultyID = @FacultyID,
                 GradeDate = CURDATE(),
                 EndDate = CURDATE(),
                 Status = 'Completed',
                 UpdatedAt = NOW()
             WHERE InternshipID = @ID;"
            End If

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@FinalGrade", grade)
                cmd.Parameters.AddWithValue("@Path", txtGREvalFile.Text.Trim())
                cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)
                cmd.Parameters.AddWithValue("@ID", internshipID)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Final grade saved!", "Success")

        If IsEditing Then
            IsInternalChange = True
            LoadCompletedInternshipsForEdit()
            cboGRStudent.SelectedValue = internshipID
            IsInternalChange = False
            LoadGradingOverview()
        Else
            LoadActiveInternships()
            ClearGradingFields()
        End If
    End Sub

    Private Sub btnGRGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGRGenerateReport.Click

        If cboGRStudent.SelectedIndex < 0 Then
            MessageBox.Show("Please select a student first.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim save As New SaveFileDialog()
        save.Filter = "PDF File|*.pdf"
        save.Title = "Save Final Evaluation Report"
        save.FileName = lblGRStudentNumber.Text & "_FinalEvaluation.pdf"

        If save.ShowDialog() <> DialogResult.OK Then Exit Sub

        Try
            Dim fs As New FileStream(save.FileName, FileMode.Create, FileAccess.Write)
            Dim doc As New Document(PageSize.A4, 40, 40, 40, 40)
            Dim writer = PdfWriter.GetInstance(doc, fs)
            doc.Open()

            Dim titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)
            Dim bold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)
            Dim normal = FontFactory.GetFont(FontFactory.HELVETICA, 11)

            ' TITLE
            doc.Add(New Paragraph("OJT FINAL PERFORMANCE EVALUATION", titleFont))
            doc.Add(New Paragraph(" "))
            doc.Add(New LineSeparator())

            ' STUDENT INFORMATION
            doc.Add(New Paragraph("Student Name: " & lblGRStudentName.Text, normal))
            doc.Add(New Paragraph("Student Number: " & lblGRStudentNumber.Text, normal))
            doc.Add(New Paragraph("Course & Section: " & lblGRCourseSection.Text, normal))
            doc.Add(New Paragraph("Company: " & lblGRCompany.Text, normal))
            doc.Add(New Paragraph("Supervisor: " & lblGRSupervisor.Text, normal))
            doc.Add(New Paragraph(" "))
            doc.Add(New LineSeparator())

            ' SUPERVISOR SCORE
            doc.Add(New Paragraph("SUPERVISOR FINAL GRADE", bold))
            doc.Add(New Paragraph("GRADE: " & lblGRSupervisorScore.Text, normal))
            doc.Add(New Paragraph(" "))
            doc.Add(New LineSeparator())

            ' FACULTY EVALUATION (1–5)
            doc.Add(New Paragraph("FACULTY EVALUATION (1–5 SCALE)", bold))
            doc.Add(New Paragraph("Technical Skills: " & cboGRF_Tech.Text, normal))
            doc.Add(New Paragraph("Professionalism / Behavior: " & cboGRF_Professionalism.Text, normal))
            doc.Add(New Paragraph("Communication Skills: " & cboGRF_Communication.Text, normal))
            doc.Add(New Paragraph("Attendance & Punctuality: " & cboGRF_Attendance.Text, normal))
            doc.Add(New Paragraph("Quality of Work Output: " & cboGRF_OutputQuality.Text, normal))
            doc.Add(New Paragraph("Final Interview / Exit: " & cboGRF_FinalInterview.Text, normal))

            doc.Add(New Paragraph(" "))
            doc.Add(New Paragraph("Faculty Total: " & lblGRFacultyTotal.Text, bold))
            doc.Add(New Paragraph(" "))
            doc.Add(New LineSeparator())

            ' FINAL GRADE
            doc.Add(New Paragraph("FINAL GRADE COMPUTATION", bold))
            doc.Add(New Paragraph("Supervisor Grade (60%): " & lblGRFGSupervisor.Text, normal))
            doc.Add(New Paragraph("Faculty Grade (40%): " & lblGRFGFaculty.Text, normal))
            doc.Add(New Paragraph(" "))

            Dim finalFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14)
            doc.Add(New Paragraph("FINAL GRADE: " & lblGRFinalGradeAuto.Text, finalFont))
            doc.Add(New Paragraph(" "))
            doc.Add(New LineSeparator())

            ' SIGN OFF
            doc.Add(New Paragraph("Evaluator: " & CurrentUser.Name, normal))
            doc.Add(New Paragraph("Date: " & Date.Today.ToLongDateString(), normal))

            doc.Close()
            writer.Close()
            fs.Close()

            txtGREvalFile.Text = save.FileName

            MessageBox.Show("Final Evaluation Report Generated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error generating PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    ' ------------------------------------------------------
    '  COMPANIES
    ' ------------------------------------------------------
    Private Sub LoadCompanies(Optional searchText As String = "")
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim dt As New DataTable()

            Dim sql As String =
            "SELECT 
                 CompanyID,
                 CompanyNumber,
                 CompanyName,
                 Address,
                 City,
                 Industry,
                 Email,
                 ContactNumber,
                 Website,
                 AccreditationStatus,
                 AccreditationDate,
                 IsActive
             FROM company
             WHERE 1 = 1 "

            Dim cmd As New MySqlCommand()
            cmd.Connection = conn

            If Not String.IsNullOrWhiteSpace(searchText) Then
                sql &= " AND (CompanyName LIKE @Search OR City LIKE @Search) "
                cmd.Parameters.AddWithValue("@Search", "%" & searchText.Trim() & "%")
            End If

            sql &= " ORDER BY CompanyName;"
            cmd.CommandText = sql

            Using da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
            End Using

            dgvCompanies.DataSource = dt
        End Using

        FormatCompanyGrid()
        AddCompanyActionButtons()
    End Sub




    Private Sub btnCompanySearch_Click(sender As Object, e As EventArgs) Handles btnCompanySearch.Click
        LoadCompanies(txtCompanySearch.Text)
    End Sub


    Private Function GenerateNextCompanyNumber() As String
        Dim nextNumber As Integer = 1

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim sql As String =
            "SELECT CompanyNumber
             FROM company
             ORDER BY CompanyID DESC
             LIMIT 1;"

            Using cmd As New MySqlCommand(sql, conn)
                Dim last As Object = cmd.ExecuteScalar()

                If last IsNot Nothing AndAlso last IsNot DBNull.Value Then
                    Dim lastStr As String = last.ToString()  ' e.g. COMP-0003

                    If lastStr.StartsWith("COMP-") Then
                        Dim num As String = lastStr.Replace("COMP-", "")
                        If Integer.TryParse(num, nextNumber) Then
                            nextNumber += 1
                        End If
                    End If
                End If
            End Using
        End Using

        Return "COMP-" & nextNumber.ToString("0000")
    End Function


    Private Sub FormatCompanyGrid()
        If dgvCompanies.Columns.Count = 0 Then Exit Sub

        dgvCompanies.Columns("CompanyID").Visible = False

        dgvCompanies.Columns("CompanyNumber").HeaderText = "Code"
        dgvCompanies.Columns("CompanyName").HeaderText = "Company"
        dgvCompanies.Columns("Address").HeaderText = "Address"
        dgvCompanies.Columns("City").HeaderText = "City"
        dgvCompanies.Columns("Industry").HeaderText = "Industry"
        dgvCompanies.Columns("Email").HeaderText = "Email"
        dgvCompanies.Columns("ContactNumber").HeaderText = "Contact"
        dgvCompanies.Columns("Website").HeaderText = "Website"
        dgvCompanies.Columns("AccreditationStatus").HeaderText = "Status"
        dgvCompanies.Columns("AccreditationDate").HeaderText = "Accredited On"
        dgvCompanies.Columns("IsActive").HeaderText = "Active"
    End Sub

    Private Sub btnCompanyAdd_Click(sender As Object, e As EventArgs) Handles btnCompanyAdd.Click
        lblCompanyFormTitle.Text = "Add Company"

        ' Clear fields
        txtCompanyName.Clear()
        txtCompanyAddress.Clear()
        txtCompanyIndustry.Clear()
        txtCompanyEmail.Clear()
        txtCompanyContact.Clear()
        txtCompanyWebsite.Clear()
        cboCompanyAccreditationStatus.SelectedIndex = -1
        cboCompanyCity.SelectedIndex = -1
        chkCompanyIsActive.Checked = True
        dtpCompanyAccreditationDate.Value = Date.Today

        LoadCompanyCities()   ' 🔥 LOAD CITY LIST

        pnlCompanyForm.Visible = True
        pnlCompanyForm.BringToFront()
    End Sub
    Private Sub ClearCompanyForm()
        txtCompanyName.Text = ""
        txtCompanyAddress.Text = ""
        cboCompanyCity.SelectedIndex = -1
        txtCompanyIndustry.Text = ""
        txtCompanyEmail.Text = ""
        txtCompanyContact.Text = ""
        txtCompanyWebsite.Text = ""
        cboCompanyAccreditationStatus.SelectedIndex = -1
        dtpCompanyAccreditationDate.Value = Date.Today
        chkCompanyIsActive.Checked = True

        pnlCompanyForm.Tag = Nothing   ' <-- used to identify EDIT mode
    End Sub
    Private Sub btnCompanySave_Click(sender As Object, e As EventArgs) Handles btnCompanySave.Click
        If txtCompanyName.Text.Trim() = "" Then
            MessageBox.Show("Company name is required!")
            Return
        End If

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim isEditMode As Boolean = (pnlCompanyForm.Tag IsNot Nothing)

            Dim sql As String

            If isEditMode = False Then
                ' INSERT
                sql =
            "INSERT INTO company
            (CompanyNumber, CompanyName, Address, City, Industry, Email, ContactNumber, Website,
             AccreditationStatus, AccreditationDate, IsActive, CreatedAt, UpdatedAt)
             VALUES
            (@num, @name, @addr, @city, @ind, @mail, @contact, @web,
             @accStat, @accDate, @active, NOW(), NOW())"
            Else
                ' UPDATE
                sql =
            "UPDATE company SET
                CompanyName=@name,
                Address=@addr,
                City=@city,
                Industry=@ind,
                Email=@mail,
                ContactNumber=@contact,
                Website=@web,
                AccreditationStatus=@accStat,
                AccreditationDate=@accDate,
                IsActive=@active,
                UpdatedAt=NOW()
            WHERE CompanyID=@id"
            End If

            Using cmd As New MySqlCommand(sql, conn)

                If isEditMode = False Then
                    cmd.Parameters.AddWithValue("@num", GenerateNextCompanyNumber())
                End If

                cmd.Parameters.AddWithValue("@name", txtCompanyName.Text.Trim())
                cmd.Parameters.AddWithValue("@addr", txtCompanyAddress.Text.Trim())
                cmd.Parameters.AddWithValue("@city", cboCompanyCity.Text.Trim())
                cmd.Parameters.AddWithValue("@ind", txtCompanyIndustry.Text.Trim())
                cmd.Parameters.AddWithValue("@mail", txtCompanyEmail.Text.Trim())
                cmd.Parameters.AddWithValue("@contact", txtCompanyContact.Text.Trim())
                cmd.Parameters.AddWithValue("@web", txtCompanyWebsite.Text.Trim())
                cmd.Parameters.AddWithValue("@accStat", cboCompanyAccreditationStatus.Text)
                cmd.Parameters.AddWithValue("@accDate", dtpCompanyAccreditationDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@active", If(chkCompanyIsActive.Checked, 1, 0))

                If isEditMode Then
                    cmd.Parameters.AddWithValue("@id", CInt(pnlCompanyForm.Tag))
                End If

                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Company saved successfully!")

        pnlCompanyForm.Visible = False
        LoadCompanies()
    End Sub
    Private Sub btnCompanyCancel_Click(sender As Object, e As EventArgs) Handles btnCompanyCancel.Click
        pnlCompanyForm.Visible = False
    End Sub
    Private Sub dgvCompanies_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompanies.CellDoubleClick
        If e.RowIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvCompanies.Rows(e.RowIndex)
        Dim id As Integer = CInt(row.Cells("CompanyID").Value)

        LoadCompanyForEdit(id)
    End Sub
    Private Sub LoadCompanyForEdit(companyID As Integer)
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim sql As String =
            "SELECT *
             FROM company
             WHERE CompanyID = @id"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", companyID)

                Using dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        pnlCompanyForm.Tag = companyID
                        lblCompanyFormTitle.Text = "Edit Company"

                        txtCompanyName.Text = SafeStr(dr("CompanyName"))
                        txtCompanyAddress.Text = SafeStr(dr("Address"))
                        cboCompanyCity.Text = SafeStr(dr("City"))
                        txtCompanyIndustry.Text = SafeStr(dr("Industry"))
                        txtCompanyEmail.Text = SafeStr(dr("Email"))
                        txtCompanyContact.Text = SafeStr(dr("ContactNumber"))
                        txtCompanyWebsite.Text = SafeStr(dr("Website"))
                        cboCompanyAccreditationStatus.Text = SafeStr(dr("AccreditationStatus"))

                        If dr("AccreditationDate") IsNot DBNull.Value Then
                            dtpCompanyAccreditationDate.Value = CDate(dr("AccreditationDate"))
                        End If

                        chkCompanyIsActive.Checked = (SafeInt(dr("IsActive")) = 1)

                        pnlCompanyForm.Visible = True
                    End If
                End Using
            End Using
        End Using
    End Sub
    Private Sub AddCompanyActionButtons()
        ' Prevent duplicate button columns
        For Each col As DataGridViewColumn In dgvCompanies.Columns
            If col.Name = "EditAction" Or col.Name = "DeleteAction" Then
                Return
            End If
        Next

        ' EDIT BUTTON
        Dim btnEdit As New DataGridViewButtonColumn()
        btnEdit.Name = "EditAction"
        btnEdit.HeaderText = "Edit"
        btnEdit.Text = "Edit"
        btnEdit.UseColumnTextForButtonValue = True
        btnEdit.Width = 60
        dgvCompanies.Columns.Add(btnEdit)

        ' DELETE BUTTON
        Dim btnDelete As New DataGridViewButtonColumn()
        btnDelete.Name = "DeleteAction"
        btnDelete.HeaderText = "Delete"
        btnDelete.Text = "Delete"
        btnDelete.UseColumnTextForButtonValue = True
        btnDelete.Width = 70
        dgvCompanies.Columns.Add(btnDelete)
    End Sub

    Private Sub dgvCompanies_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
    Handles dgvCompanies.CellClick

        If e.RowIndex < 0 Then Exit Sub

        Dim companyID As Integer = CInt(dgvCompanies.Rows(e.RowIndex).Cells("CompanyID").Value)

        Select Case dgvCompanies.Columns(e.ColumnIndex).Name

            Case "EditAction"
                LoadCompanyForEdit(companyID)

            Case "DeleteAction"
                DeleteCompany(companyID)

        End Select
    End Sub

    Private Sub DeleteCompany(companyID As Integer)
        Dim result = MessageBox.Show("Are you sure you want to delete this company?",
                                 "Confirm Delete",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning)

        If result <> DialogResult.Yes Then Exit Sub

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim sql As String = "UPDATE company SET IsActive = 0 WHERE CompanyID = @id;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", companyID)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Company marked as inactive.", "Deleted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information)

        LoadCompanies()
    End Sub

    Private Sub TestCompanyControls()
        Dim missing As New List(Of String)

        If pnlCompanyForm Is Nothing Then missing.Add("pnlCompanyForm")
        If lblCompanyFormTitle Is Nothing Then missing.Add("lblCompanyFormTitle")
        If txtCompanyName Is Nothing Then missing.Add("txtCompanyName")
        If txtCompanyAddress Is Nothing Then missing.Add("txtCompanyAddress")
        If cboCompanyCity Is Nothing Then missing.Add("cboCompanyCity")
        If txtCompanyIndustry Is Nothing Then missing.Add("txtCompanyIndustry")
        If txtCompanyEmail Is Nothing Then missing.Add("txtCompanyEmail")
        If txtCompanyContact Is Nothing Then missing.Add("txtCompanyContact")
        If txtCompanyWebsite Is Nothing Then missing.Add("txtCompanyWebsite")
        If cboCompanyAccreditationStatus Is Nothing Then missing.Add("cboCompanyAccreditationStatus")
        If dtpCompanyAccreditationDate Is Nothing Then missing.Add("dtpCompanyAccreditationDate")
        If chkCompanyIsActive Is Nothing Then missing.Add("chkCompanyIsActive")
        If btnCompanySave Is Nothing Then missing.Add("btnCompanySave")
        If btnCompanyCancel Is Nothing Then missing.Add("btnCompanyCancel")

        If missing.Count > 0 Then
            MessageBox.Show("Missing controls: " & vbCrLf & String.Join(vbCrLf, missing))
        Else
            MessageBox.Show("All company controls exist.")
        End If
    End Sub
    Private Sub LoadCompanyCities()
        cboCompanyCity.Items.Clear()

        Dim cities As String() = {
        "Pasig",
        "Makati",
        "Taguig",
        "Mandaluyong",
        "Quezon City",
        "San Juan",
        "Manila",
        "Caloocan",
        "Valenzuela",
        "Parañaque",
        "Las Piñas",
        "Muntinlupa",
        "Marikina",
        "Navotas",
        "Malabon"
    }

        cboCompanyCity.Items.AddRange(cities)
    End Sub


    ' ------------------------------------------------------
    '  COMPANY CONTACTS
    ' ------------------------------------------------------
    Private Sub LoadCompanyContactsFilters()
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim dt As New DataTable()

            Dim sql As String =
            "SELECT 
                 CompanyID, 
                 CONCAT(CompanyNumber, ' - ', CompanyName) AS DisplayName
             FROM company
             WHERE IsActive = 1
             ORDER BY CompanyName;"

            Using da As New MySqlDataAdapter(sql, conn)
                da.Fill(dt)
            End Using

            cboCCCompany.DataSource = Nothing
            cboCCCompany.Items.Clear()

            If dt.Rows.Count > 0 Then
                cboCCCompany.DataSource = dt
                cboCCCompany.DisplayMember = "DisplayName"
                cboCCCompany.ValueMember = "CompanyID"
                cboCCCompany.SelectedIndex = -1
            End If
        End Using
    End Sub


    Private Sub LoadCompanyContacts()
        If cboCCCompany.SelectedIndex < 0 Then
            dgvCompanyContacts.DataSource = Nothing
            Return
        End If

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim dt As New DataTable()
            Dim sql As String =
                "SELECT cc.ContactID, " &
                "       CONCAT(cc.LastName, ', ', cc.FirstName, " &
                "              CASE WHEN cc.MiddleName IS NULL OR cc.MiddleName = '' " &
                "                   THEN '' ELSE CONCAT(' ', LEFT(cc.MiddleName,1),'.') END" &
                "       ) AS ContactName, " &
                "       cc.PositionTitle, cc.Email, cc.ContactNumber, cc.IsActive " &
                "FROM companycontact cc " &
                "WHERE cc.CompanyID = @CompanyID " &
                "ORDER BY cc.LastName, cc.FirstName;"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@CompanyID", CInt(cboCCCompany.SelectedValue))
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            dgvCompanyContacts.DataSource = dt
        End Using
    End Sub

    Private Sub cboCCCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCCCompany.SelectedIndexChanged
        If cboCCCompany.SelectedIndex >= 0 Then
            LoadCompanyContacts()
        End If
    End Sub


    Private Sub btnCCAddContact_Click(sender As Object, e As EventArgs) Handles btnCCAddContact.Click
        If cboCCCompany.SelectedIndex < 0 Then
            MessageBox.Show("Please select a company first.",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim lastName As String = InputBox("Enter last name:", "New Contact")
        If String.IsNullOrWhiteSpace(lastName) Then Return

        Dim firstName As String = InputBox("Enter first name:", "New Contact")
        If String.IsNullOrWhiteSpace(firstName) Then Return

        Dim middleName As String = InputBox("Enter middle name (optional):", "New Contact", "")

        Dim position As String = InputBox("Enter position title:", "New Contact", "Supervisor")
        Dim email As String = InputBox("Enter email:", "New Contact", "")
        Dim contact As String = InputBox("Enter contact number:", "New Contact", "")

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Dim sql As String =
                "INSERT INTO companycontact " &
                "(CompanyID, LastName, FirstName, MiddleName, PositionTitle, Email, ContactNumber, IsPrimaryContact, IsActive, CreatedAt) " &
                "VALUES (@CompanyID, @LastName, @FirstName, @MiddleName, @PositionTitle, @Email, @ContactNumber, 0, 1, NOW());"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@CompanyID", CInt(cboCCCompany.SelectedValue))
                cmd.Parameters.AddWithValue("@LastName", lastName.Trim())
                cmd.Parameters.AddWithValue("@FirstName", firstName.Trim())
                cmd.Parameters.AddWithValue("@MiddleName", If(String.IsNullOrWhiteSpace(middleName), DBNull.Value, middleName.Trim()))
                cmd.Parameters.AddWithValue("@PositionTitle", position.Trim())
                cmd.Parameters.AddWithValue("@Email", email.Trim())
                cmd.Parameters.AddWithValue("@ContactNumber", contact.Trim())
                cmd.ExecuteNonQuery()
            End Using
        End Using

        LoadCompanyContacts()
    End Sub
    Private Sub AddOverview(labelText As String, targetLabel As Label, ByRef y As Integer)
        Dim lbl As New Label()
        lbl.Text = labelText
        lbl.Font = New System.Drawing.Font("Segoe UI", 10)
        lbl.Location = New Point(25, y)
        pnlGrading.Controls.Add(lbl)

        targetLabel.Font = New System.Drawing.Font("Segoe UI", 10, FontStyle.Bold)
        targetLabel.Location = New Point(180, y)
        pnlGrading.Controls.Add(targetLabel)

        y += 30
    End Sub

    Private Sub AddFaculty(labelText As String, textbox As TextBox, ByRef y As Integer)
        Dim lbl As New Label()
        lbl.Text = labelText
        lbl.Font = New System.Drawing.Font("Segoe UI", 10)
        lbl.Location = New Point(25, y)
        pnlGrading.Controls.Add(lbl)

        textbox.Font = New System.Drawing.Font("Segoe UI", 10)
        textbox.Size = New Size(120, 30)
        textbox.Location = New Point(220, y - 5)
        pnlGrading.Controls.Add(textbox)

        y += 35
    End Sub
End Class
