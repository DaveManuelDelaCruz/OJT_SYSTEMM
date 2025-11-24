Imports MySql.Data.MySqlClient

Public Class frmFacultyDashboard

    Private ReadOnly Property CurrentFacultyID As Integer
        Get
            If CurrentUser Is Nothing OrElse Not CurrentUser.FacultyID.HasValue Then
                Return 0   ' or throw / handle "not logged in"
            End If
            Return CurrentUser.FacultyID.Value
        End Get
    End Property

    ' Manage Students grid state
    Private _studentsGridInitialized As Boolean = False

    ' Internship Assignment state
    Private _selectedStudentID As Integer = -1
    Private _currentInternshipID As Integer = -1
    Private _internshipStatus As String = ""   ' store current status if editing

    ' Visit Logs state
    Private _visitGridInitialized As Boolean = False
    Private _currentVisitID As Integer = -1
    Private _currentInternshipID_VisitLog As Integer = -1

    ' Grading state
    Private _currentGradingInternshipID As Integer = -1
    Private _currentGradingStudentID As Integer = -1

    ' Companies state
    Private _companiesGridInitialized As Boolean = False

    Private _contactsGridLoaded As Boolean = False

    Private Sub btnFacultyProfile_Click(sender As Object, e As EventArgs) Handles btnFacultyProfile.Click
        HighlightActive(btnFacultyProfile)
        ShowPanel(pnlFacultyProfile)
        LoadFacultyProfile()
    End Sub


    Private Sub frmFacultyDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowPanel(pnlDashboardHome)
        HighlightActive(btnDashboardHome)

        LoadDashboardSummary()
        SetupLatestActivityGrid()
    End Sub

    ' =========================
    ' NAVIGATION LOGIC
    ' =========================
    Private Sub ShowPanel(target As Panel)
        For Each pnl As Control In pnlContent.Controls
            pnl.Visible = False
        Next
        target.Visible = True
        target.BringToFront()
    End Sub

    Private Sub HighlightActive(activeButton As Button)
        For Each b As Button In pnlLeft.Controls.OfType(Of Button)()
            If b Is btnLogout Then Continue For
            b.BackColor = Color.FromArgb(34, 51, 34)
            b.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular)
        Next

        activeButton.BackColor = Color.FromArgb(76, 175, 80)
        activeButton.Font = New Font("Segoe UI Semibold", 11.0F, FontStyle.Bold)
    End Sub

    Private Sub btnDashboardHome_Click(sender As Object, e As EventArgs) Handles btnDashboardHome.Click
        HighlightActive(btnDashboardHome)
        ShowPanel(pnlDashboardHome)
        LoadDashboardSummary()
    End Sub

    Private Sub btnManageStudents_Click(sender As Object, e As EventArgs) Handles btnManageStudents.Click
        HighlightActive(btnManageStudents)
        ShowPanel(pnlManageStudents)

        If Not _studentsGridInitialized Then
            ConfigureStudentsGrid()
            _studentsGridInitialized = True
        End If

        LoadStudents(String.Empty)
    End Sub

    Private Sub btnInternshipAssignment_Click(sender As Object, e As EventArgs) Handles btnInternshipAssignment.Click
        HighlightActive(btnInternshipAssignment)
        ShowPanel(pnlInternshipAssignment)

        ' Prepare dropdowns and clear state
        LoadCompanies()
        LoadEvaluators()
        ClearInternshipForm()
    End Sub

    Private Sub btnVisitLogs_Click(sender As Object, e As EventArgs) Handles btnVisitLogs.Click
        HighlightActive(btnVisitLogs)
        ShowPanel(pnlVisitLogs)

        If Not _visitGridInitialized Then
            InitializeVisitLogsGrid()
            _visitGridInitialized = True
        End If

        PopulateVisitTypeCombo()
        LoadInternshipsForVisitLogs()
        ClearVisitLogForm()
    End Sub

    Private Sub btnGrading_Click(sender As Object, e As EventArgs) Handles btnGrading.Click
        HighlightActive(btnGrading)
        ShowPanel(pnlGrading)

        LoadGradingStudents()
        ClearGradingForm()
    End Sub

    Private Sub btnCompanies_Click(sender As Object, e As EventArgs) Handles btnCompanies.Click
        HighlightActive(btnCompanies)
        ShowPanel(pnlCompanies)

        If Not _companiesGridInitialized Then
            ConfigureCompaniesGrid()
            _companiesGridInitialized = True
        End If

        LoadCompanies(String.Empty)
    End Sub

    Private Sub btnCompanyContacts_Click(sender As Object, e As EventArgs) Handles btnCompanyContacts.Click
        HighlightActive(btnCompanyContacts)
        ShowPanel(pnlCompanyContacts)

        LoadContactCompanies()

        If Not _contactsGridLoaded Then
            ConfigureContactsGrid()
            _contactsGridLoaded = True
        End If

        If cboContactCompany.SelectedValue IsNot Nothing Then
            LoadContacts(CInt(cboContactCompany.SelectedValue))
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?",
                                     "Confirm Logout",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                frmLoginFaculty.Show()
            Catch
            End Try
            Me.Close()
        End If
    End Sub

    ' =========================
    ' DASHBOARD HOME LOGIC
    ' =========================
    Private Sub LoadDashboardSummary()
        ' Hook up with counts later if desired.
        lblTotalStudentsValue.Text = "0"
        lblActiveInternshipsValue.Text = "0"
        lblCompaniesValue.Text = "0"
        lblPendingVisitLogsValue.Text = "0"
    End Sub

    Private Sub SetupLatestActivityGrid()
        If dgvLatestActivity.Columns.Count = 0 Then
            dgvLatestActivity.Columns.Clear()
            dgvLatestActivity.Columns.Add("colDate", "Date")
            dgvLatestActivity.Columns.Add("colActivity", "Activity")
        End If

        dgvLatestActivity.Columns("colDate").FillWeight = 25
        dgvLatestActivity.Columns("colActivity").FillWeight = 75
        dgvLatestActivity.Rows.Clear()
    End Sub

    ' =========================
    ' MANAGE STUDENTS LOGIC
    ' =========================
    Private Sub ConfigureStudentsGrid()
        dgvStudents.Columns.Clear()

        Dim colId As New DataGridViewTextBoxColumn()
        colId.Name = "colStudentID"
        colId.HeaderText = "StudentID"
        colId.Visible = False

        Dim colNumber As New DataGridViewTextBoxColumn()
        colNumber.Name = "colStudentNumber"
        colNumber.HeaderText = "Student No"

        Dim colName As New DataGridViewTextBoxColumn()
        colName.Name = "colName"
        colName.HeaderText = "Name"

        Dim colCourse As New DataGridViewTextBoxColumn()
        colCourse.Name = "colCourse"
        colCourse.HeaderText = "Course"

        Dim colStatus As New DataGridViewTextBoxColumn()
        colStatus.Name = "colStatus"
        colStatus.HeaderText = "Status"

        Dim colView As New DataGridViewButtonColumn()
        colView.Name = "colView"
        colView.HeaderText = "Details"
        colView.Text = "View"
        colView.UseColumnTextForButtonValue = True
        colView.Width = 80

        dgvStudents.Columns.AddRange(New DataGridViewColumn() {
            colId, colNumber, colName, colCourse, colStatus, colView
        })

        dgvStudents.Columns("colStudentNumber").FillWeight = 20
        dgvStudents.Columns("colName").FillWeight = 30
        dgvStudents.Columns("colCourse").FillWeight = 20
        dgvStudents.Columns("colStatus").FillWeight = 15
        dgvStudents.Columns("colView").FillWeight = 15
    End Sub

    Private Sub LoadStudents(searchTerm As String)
        dgvStudents.Rows.Clear()

        Dim sql As String =
            "SELECT s.StudentID, s.StudentNumber, " &
            "CONCAT(s.FirstName, ' ', IFNULL(s.MiddleName, ''), ' ', s.LastName) AS FullName, " &
            "c.CourseCode, s.Status " &
            "FROM student s " &
            "INNER JOIN section sec ON s.SectionID = sec.SectionID " &
            "INNER JOIN course c ON sec.CourseID = c.CourseID " &
            "WHERE (@term = '' " &
            "   OR s.StudentNumber LIKE CONCAT('%', @term, '%') " &
            "   OR s.FirstName LIKE CONCAT('%', @term, '%') " &
            "   OR s.LastName LIKE CONCAT('%', @term, '%')) " &
            "ORDER BY s.StudentNumber;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@term", searchTerm)
                    conn.Open()

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            Dim id As Integer = CInt(dr("StudentID"))
                            Dim sn As String = dr("StudentNumber").ToString()
                            Dim name As String = dr("FullName").ToString().Replace("  ", " ").Trim()
                            Dim course As String = dr("CourseCode").ToString()
                            Dim status As String = dr("Status").ToString()

                            dgvStudents.Rows.Add(id, sn, name, course, status)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearchStudent_Click(sender As Object, e As EventArgs) Handles btnSearchStudent.Click
        Dim term As String = txtSearchStudent.Text.Trim()
        LoadStudents(term)
    End Sub

    Private Sub dgvStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellContentClick
        If e.RowIndex < 0 Then Return

        If dgvStudents.Columns(e.ColumnIndex).Name = "colView" Then
            Dim studentID As Integer = CInt(dgvStudents.Rows(e.RowIndex).Cells("colStudentID").Value)
            Dim details As New frmStudentDetailsPopup(studentID)
            details.ShowDialog()
        End If
    End Sub

    ' =========================
    ' INTERNSHIP ASSIGNMENT LOGIC
    ' =========================

    Private Sub LoadCompanies()
        cboCompany.DataSource = Nothing

        Dim sql As String =
            "SELECT CompanyID, CompanyName " &
            "FROM company " &
            "WHERE IsActive = 1 " &
            "ORDER BY CompanyName;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    conn.Open()
                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())
                    cboCompany.DataSource = dt
                    cboCompany.DisplayMember = "CompanyName"
                    cboCompany.ValueMember = "CompanyID"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading companies: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

        cboSupervisor.DataSource = Nothing
    End Sub

    Private Sub LoadSupervisorsForCompany(companyID As Integer)
        cboSupervisor.DataSource = Nothing

        Dim sql As String =
            "SELECT ContactID, " &
            "CONCAT(FirstName, ' ', LastName, ' - ', IFNULL(PositionTitle,'')) AS FullName " &
            "FROM companycontact " &
            "WHERE CompanyID = @cid AND IsActive = 1 " &
            "ORDER BY FirstName, LastName;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cid", companyID)
                    conn.Open()
                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())
                    cboSupervisor.DataSource = dt
                    cboSupervisor.DisplayMember = "FullName"
                    cboSupervisor.ValueMember = "ContactID"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading supervisors: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadEvaluators()
        cboEvaluator.DataSource = Nothing

        Dim sql As String =
            "SELECT FacultyID, CONCAT(FirstName, ' ', LastName) AS FullName " &
            "FROM faculty " &
            "WHERE IsEvaluator = 1 AND IsActive = 1 " &
            "ORDER BY FirstName, LastName;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    conn.Open()
                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())
                    cboEvaluator.DataSource = dt
                    cboEvaluator.DisplayMember = "FullName"
                    cboEvaluator.ValueMember = "FacultyID"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading evaluators: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboCompany_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCompany.SelectedIndexChanged
        If cboCompany.SelectedValue Is Nothing OrElse Not TypeOf cboCompany.SelectedValue Is Integer Then
            cboSupervisor.DataSource = Nothing
            Return
        End If

        Dim companyID As Integer = CInt(cboCompany.SelectedValue)
        LoadSupervisorsForCompany(companyID)
    End Sub

    Private Sub ClearInternshipForm()
        _selectedStudentID = -1
        _currentInternshipID = -1
        _internshipStatus = ""

        txtSearchStudentIA.Text = ""

        lblStudentNoValueIA.Text = "-"
        lblStudentNameValueIA.Text = "-"
        lblCourseValueIA.Text = "-"
        lblRequiredHoursValue.Text = "-"
        lblCurrentInternshipStatusValue.Text = "-"

        txtWorkDays.Text = ""
        dtpStartDate.Value = Date.Today
        dtpEndDate.Value = Date.Today
        dtpStartTime.Value = Date.Today.AddHours(8)
        dtpEndTime.Value = Date.Today.AddHours(17)

        If cboCompany.Items.Count > 0 Then
            cboCompany.SelectedIndex = 0
        End If

        cboSupervisor.DataSource = Nothing

        If cboEvaluator.Items.Count > 0 Then
            cboEvaluator.SelectedIndex = 0
        End If

        btnRemoveInternship.Enabled = False
    End Sub

    Private Sub btnClearInternship_Click(sender As Object, e As EventArgs) Handles btnClearInternship.Click
        ClearInternshipForm()
    End Sub

    Private Sub btnSearchStudentIA_Click(sender As Object, e As EventArgs) Handles btnSearchStudentIA.Click
        Dim term As String = txtSearchStudentIA.Text.Trim()

        If term = "" Then
            MessageBox.Show("Please enter a Student Number (or name) to search.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Return
        End If

        Dim sql As String =
            "SELECT s.StudentID, s.StudentNumber, " &
            "CONCAT(s.FirstName, ' ', IFNULL(s.MiddleName,''), ' ', s.LastName) AS FullName, " &
            "c.CourseCode, c.CourseName, c.RequiredOJTHours " &
            "FROM student s " &
            "INNER JOIN section sec ON s.SectionID = sec.SectionID " &
            "INNER JOIN course c ON sec.CourseID = c.CourseID " &
            "WHERE s.StudentNumber = @exact " &
            "   OR s.FirstName LIKE CONCAT('%', @like, '%') " &
            "   OR s.LastName LIKE CONCAT('%', @like, '%') " &
            "LIMIT 1;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@exact", term)
                    cmd.Parameters.AddWithValue("@like", term)
                    conn.Open()

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            _selectedStudentID = CInt(dr("StudentID"))
                            Dim sn As String = dr("StudentNumber").ToString()
                            Dim fullName As String = dr("FullName").ToString().Replace("  ", " ").Trim()
                            Dim courseText As String = dr("CourseCode").ToString()
                            Dim courseName As String = dr("CourseName").ToString()
                            If courseName <> "" Then
                                courseText &= " - " & courseName
                            End If
                            Dim requiredHours As Integer = CInt(dr("RequiredOJTHours"))

                            lblStudentNoValueIA.Text = sn
                            lblStudentNameValueIA.Text = fullName
                            lblCourseValueIA.Text = courseText
                            lblRequiredHoursValue.Text = requiredHours.ToString() & " hours"

                        Else
                            MessageBox.Show("Student not found.",
                                            "Result",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information)
                            Return
                        End If
                    End Using
                End Using
            End Using

            ' Load any existing latest internship for this student
            LoadExistingInternshipForStudent()

        Catch ex As Exception
            MessageBox.Show("Error searching student: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadExistingInternshipForStudent()
        _currentInternshipID = -1
        _internshipStatus = ""
        lblCurrentInternshipStatusValue.Text = "None"
        btnRemoveInternship.Enabled = False

        If _selectedStudentID <= 0 Then Return

        Dim sql As String =
        "SELECT i.InternshipID, i.Status, i.WorkDays, i.StartDate, i.EndDate, 
                i.DailyStartTime, i.DailyEndTime,
                cc.ContactID, CONCAT(cc.FirstName,' ',cc.LastName) AS SupervisorName,
                comp.CompanyID, comp.CompanyName,
                f.FacultyID, CONCAT(f.FirstName,' ',f.LastName) AS EvaluatorName
         FROM internship i
         LEFT JOIN companycontact cc ON i.SupervisorContactID = cc.ContactID
         LEFT JOIN company comp ON cc.CompanyID = comp.CompanyID
         LEFT JOIN faculty f ON i.EvaluatingFacultyID = f.FacultyID
         WHERE i.StudentID = @sid
         ORDER BY i.InternshipID DESC
         LIMIT 1;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@sid", _selectedStudentID)
                    conn.Open()

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then

                            ' Load internship basic data
                            _currentInternshipID = CInt(dr("InternshipID"))
                            _internshipStatus = dr("Status").ToString()
                            lblCurrentInternshipStatusValue.Text = _internshipStatus
                            btnRemoveInternship.Enabled = True

                            ' -----------------------------
                            ' CHECK IF INTERNSHIP CAN BE REMOVED
                            ' -----------------------------
                            Dim visitCount As Integer = 0
                            Dim gradeExists As Integer = 0

                            Using conn2 As MySqlConnection = GetConnection()
                                Using cmd2 As New MySqlCommand("
                                SELECT
                                    (SELECT COUNT(*) FROM visitlog WHERE InternshipID = @iid) AS VisitCount,
                                    (SELECT COUNT(*) FROM internship WHERE InternshipID = @iid AND FinalGrade IS NOT NULL) AS GradeExists;
                            ", conn2)
                                    cmd2.Parameters.AddWithValue("@iid", _currentInternshipID)
                                    conn2.Open()

                                    Using dr2 = cmd2.ExecuteReader()
                                        If dr2.Read() Then
                                            visitCount = CInt(dr2("VisitCount"))
                                            gradeExists = CInt(dr2("GradeExists"))
                                        End If
                                    End Using
                                End Using
                            End Using

                            ' AUTO-HIDE DELETE BUTTON
                            btnRemoveInternship.Visible = Not (visitCount > 0 Or gradeExists > 0)

                            ' -----------------------------
                            ' FILL SCHEDULE FIELDS
                            ' -----------------------------
                            If Not IsDBNull(dr("WorkDays")) Then txtWorkDays.Text = dr("WorkDays").ToString()
                            If Not IsDBNull(dr("StartDate")) Then dtpStartDate.Value = CDate(dr("StartDate"))
                            If Not IsDBNull(dr("EndDate")) Then dtpEndDate.Value = CDate(dr("EndDate"))
                            If Not IsDBNull(dr("DailyStartTime")) Then dtpStartTime.Value = Date.Today + CDate(dr("DailyStartTime")).TimeOfDay
                            If Not IsDBNull(dr("DailyEndTime")) Then dtpEndTime.Value = Date.Today + CDate(dr("DailyEndTime")).TimeOfDay

                            ' -----------------------------
                            ' SET COMPANY & SUPERVISOR
                            ' -----------------------------
                            If Not IsDBNull(dr("CompanyID")) Then
                                Dim companyID As Integer = CInt(dr("CompanyID"))
                                cboCompany.SelectedValue = companyID

                                ' Load supervisors
                                LoadSupervisorsForCompany(companyID)

                                If Not IsDBNull(dr("ContactID")) Then
                                    cboSupervisor.SelectedValue = CInt(dr("ContactID"))
                                End If
                            End If

                            ' -----------------------------
                            ' SET EVALUATOR
                            ' -----------------------------
                            If Not IsDBNull(dr("FacultyID")) Then
                                cboEvaluator.SelectedValue = CInt(dr("FacultyID"))
                            End If

                        Else
                            lblCurrentInternshipStatusValue.Text = "None"
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading existing internship: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateInternshipInputs() As Boolean
        If _selectedStudentID <= 0 Then
            MessageBox.Show("Please search and select a student first.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return False
        End If

        If cboCompany.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a company.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return False
        End If

        If cboSupervisor.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a supervisor.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return False
        End If

        If cboEvaluator.SelectedValue Is Nothing Then
            MessageBox.Show("Please select an evaluating faculty.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return False
        End If

        If txtWorkDays.Text.Trim() = "" Then
            MessageBox.Show("Please specify work days (e.g. Monday to Friday).",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return False
        End If

        If dtpEndDate.Value.Date < dtpStartDate.Value.Date Then
            MessageBox.Show("End Date cannot be earlier than Start Date.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return False
        End If

        If dtpEndTime.Value.TimeOfDay <= dtpStartTime.Value.TimeOfDay Then
            MessageBox.Show("End Time must be later than Start Time.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub btnAssignInternship_Click(sender As Object, e As EventArgs) Handles btnAssignInternship.Click
        If Not ValidateInternshipInputs() Then Return

        Dim supervisorContactID As Integer = CInt(cboSupervisor.SelectedValue)
        Dim evaluatorFacultyID As Integer = CInt(cboEvaluator.SelectedValue)
        Dim startDate As Date = dtpStartDate.Value.Date
        Dim endDate As Date = dtpEndDate.Value.Date
        Dim workDays As String = txtWorkDays.Text.Trim()
        Dim startTime As TimeSpan = dtpStartTime.Value.TimeOfDay
        Dim endTime As TimeSpan = dtpEndTime.Value.TimeOfDay

        ' NEW internships default to Active
        Dim statusToSet As String = If(_currentInternshipID > 0, _internshipStatus, "Active")

        Dim sqlInsert As String =
        "INSERT INTO internship " &
        "(StudentID, SupervisorContactID, EvaluatingFacultyID, StartDate, EndDate, Status, WorkDays, DailyStartTime, DailyEndTime, HoursCompleted, CreatedAt) " &
        "VALUES (@StudentID, @SupervisorContactID, @EvaluatingFacultyID, @StartDate, @EndDate, @Status, @WorkDays, @DailyStartTime, @DailyEndTime, 0, NOW());"

        Dim sqlUpdate As String =
        "UPDATE internship SET " &
        "SupervisorContactID = @SupervisorContactID, " &
        "EvaluatingFacultyID = @EvaluatingFacultyID, " &
        "StartDate = @StartDate, " &
        "EndDate = @EndDate, " &
        "Status = @Status, " &
        "WorkDays = @WorkDays, " &
        "DailyStartTime = @DailyStartTime, " &
        "DailyEndTime = @DailyEndTime, " &
        "UpdatedAt = NOW() " &
        "WHERE InternshipID = @InternshipID;"

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using tx As MySqlTransaction = conn.BeginTransaction()
                    Try
                        If _currentInternshipID > 0 Then
                            ' UPDATE EXISTING
                            Using cmd As New MySqlCommand(sqlUpdate, conn, tx)
                                cmd.Parameters.AddWithValue("@SupervisorContactID", supervisorContactID)
                                cmd.Parameters.AddWithValue("@EvaluatingFacultyID", evaluatorFacultyID)
                                cmd.Parameters.AddWithValue("@StartDate", startDate)
                                cmd.Parameters.AddWithValue("@EndDate", endDate)
                                cmd.Parameters.AddWithValue("@Status", statusToSet)
                                cmd.Parameters.AddWithValue("@WorkDays", workDays)
                                cmd.Parameters.AddWithValue("@DailyStartTime", startTime)
                                cmd.Parameters.AddWithValue("@DailyEndTime", endTime)
                                cmd.Parameters.AddWithValue("@InternshipID", _currentInternshipID)
                                cmd.ExecuteNonQuery()
                            End Using
                        Else
                            ' INSERT NEW
                            Using cmd As New MySqlCommand(sqlInsert, conn, tx)
                                cmd.Parameters.AddWithValue("@StudentID", _selectedStudentID)
                                cmd.Parameters.AddWithValue("@SupervisorContactID", supervisorContactID)
                                cmd.Parameters.AddWithValue("@EvaluatingFacultyID", evaluatorFacultyID)
                                cmd.Parameters.AddWithValue("@StartDate", startDate)
                                cmd.Parameters.AddWithValue("@EndDate", endDate)
                                cmd.Parameters.AddWithValue("@Status", statusToSet)
                                cmd.Parameters.AddWithValue("@WorkDays", workDays)
                                cmd.Parameters.AddWithValue("@DailyStartTime", startTime)
                                cmd.Parameters.AddWithValue("@DailyEndTime", endTime)
                                cmd.ExecuteNonQuery()
                            End Using
                        End If

                        tx.Commit()
                        MessageBox.Show("Internship saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Catch ex As Exception
                        tx.Rollback()
                        MessageBox.Show("Error saving internship: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using

            LoadExistingInternshipForStudent()

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRemoveInternship_Click(sender As Object, e As EventArgs) Handles btnRemoveInternship.Click
        If _currentInternshipID <= 0 Then
            MessageBox.Show("No internship to remove.")
            Return
        End If

        ' Check if there are visit logs or grades
        Dim sqlCheck As String =
        "SELECT 
            (SELECT COUNT(*) FROM visitlog WHERE InternshipID = @id) AS VisitCount,
            (SELECT COUNT(*) FROM internship WHERE InternshipID = @id AND FinalGrade IS NOT NULL) AS GradeExists;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sqlCheck, conn)
                    cmd.Parameters.AddWithValue("@id", _currentInternshipID)
                    conn.Open()

                    Using dr = cmd.ExecuteReader()
                        If dr.Read() Then
                            Dim visitCount As Integer = CInt(dr("VisitCount"))
                            Dim gradeExists As Integer = CInt(dr("GradeExists"))

                            If visitCount > 0 Or gradeExists > 0 Then
                                MessageBox.Show("This internship cannot be removed because it has visit logs or grades.")
                                Return
                            End If
                        End If
                    End Using
                End Using
            End Using

            ' Soft Delete
            Dim sqlDelete As String = "UPDATE internship SET IsDeleted = 1 WHERE InternshipID = @id;"

            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sqlDelete, conn)
                    cmd.Parameters.AddWithValue("@id", _currentInternshipID)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Internship removed successfully (soft delete).")

            _currentInternshipID = -1
            lblCurrentInternshipStatusValue.Text = "None"
            btnRemoveInternship.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Error removing internship: " & ex.Message)
        End Try
    End Sub

    ' =========================
    ' VISIT LOGS - UI & GRID SETUP
    ' =========================
    Private Sub InitializeVisitLogsGrid()
        dgvVisitLogs.Columns.Clear()

        Dim colID As New DataGridViewTextBoxColumn()
        colID.Name = "colVisitID"
        colID.HeaderText = "VisitID"
        colID.Visible = False

        Dim colDate As New DataGridViewTextBoxColumn()
        colDate.Name = "colVisitDate"
        colDate.HeaderText = "Date"

        Dim colType As New DataGridViewTextBoxColumn()
        colType.Name = "colVisitType"
        colType.HeaderText = "Type"

        Dim colScore As New DataGridViewTextBoxColumn()
        colScore.Name = "colScore"
        colScore.HeaderText = "Score"

        Dim colMaxScore As New DataGridViewTextBoxColumn()
        colMaxScore.Name = "colMaxScore"
        colMaxScore.HeaderText = "Max Score"

        Dim colRemarks As New DataGridViewTextBoxColumn()
        colRemarks.Name = "colRemarks"
        colRemarks.HeaderText = "Remarks"

        Dim colEdit As New DataGridViewButtonColumn()
        colEdit.Name = "colEdit"
        colEdit.HeaderText = "Edit"
        colEdit.Text = "Edit"
        colEdit.UseColumnTextForButtonValue = True

        Dim colDelete As New DataGridViewButtonColumn()
        colDelete.Name = "colDelete"
        colDelete.HeaderText = "Delete"
        colDelete.Text = "Delete"
        colDelete.UseColumnTextForButtonValue = True

        dgvVisitLogs.Columns.AddRange(New DataGridViewColumn() {
        colID, colDate, colType, colScore, colMaxScore, colRemarks, colEdit, colDelete
    })

        dgvVisitLogs.Columns("colVisitDate").FillWeight = 15
        dgvVisitLogs.Columns("colVisitType").FillWeight = 15
        dgvVisitLogs.Columns("colScore").FillWeight = 10
        dgvVisitLogs.Columns("colMaxScore").FillWeight = 10
        dgvVisitLogs.Columns("colRemarks").FillWeight = 35
        dgvVisitLogs.Columns("colEdit").FillWeight = 7
        dgvVisitLogs.Columns("colDelete").FillWeight = 8
    End Sub

    Private Sub PopulateVisitTypeCombo()
        If cboVLVisitType.Items.Count = 0 Then
            cboVLVisitType.Items.Add("Initial")
            cboVLVisitType.Items.Add("Monitoring")
            cboVLVisitType.Items.Add("Midterm")
            cboVLVisitType.Items.Add("Final")
            cboVLVisitType.Items.Add("Unscheduled")
        End If
    End Sub

    Private Sub LoadInternshipsForVisitLogs()
        cboVLInternship.DataSource = Nothing
        dgvVisitLogs.Rows.Clear()
        _currentInternshipID_VisitLog = -1

        Dim sql As String =
        "SELECT i.InternshipID, " &
        "CONCAT(s.StudentNumber, ' - ', s.LastName, ', ', s.FirstName, ' (', IFNULL(c.CourseCode,''), ') @ ', IFNULL(comp.CompanyName,'')) AS DisplayName " &
        "FROM internship i " &
        "INNER JOIN student s ON i.StudentID = s.StudentID " &
        "INNER JOIN section sec ON s.SectionID = sec.SectionID " &
        "INNER JOIN course c ON sec.CourseID = c.CourseID " &
        "LEFT JOIN companycontact cc ON i.SupervisorContactID = cc.ContactID " &
        "LEFT JOIN company comp ON cc.CompanyID = comp.CompanyID " &
        "ORDER BY s.StudentNumber;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    conn.Open()
                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())
                    cboVLInternship.DataSource = dt
                    cboVLInternship.DisplayMember = "DisplayName"
                    cboVLInternship.ValueMember = "InternshipID"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading internships: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboVLInternship_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVLInternship.SelectedIndexChanged
        If cboVLInternship.SelectedValue Is Nothing Then
            dgvVisitLogs.Rows.Clear()
            _currentInternshipID_VisitLog = -1
            Return
        End If

        If Not TypeOf cboVLInternship.SelectedValue Is Integer Then Return

        _currentInternshipID_VisitLog = CInt(cboVLInternship.SelectedValue)
        LoadVisitLogsForInternship(_currentInternshipID_VisitLog)
        ClearVisitLogForm()
    End Sub

    Private Sub LoadVisitLogsForInternship(internshipID As Integer)
        dgvVisitLogs.Rows.Clear()
        _currentVisitID = -1

        Dim sql As String =
        "SELECT VisitID, VisitDate, VisitType, Score, MaxScore, Remarks " &
        "FROM visitlog " &
        "WHERE InternshipID = @iid " &
        "ORDER BY VisitDate DESC, VisitID DESC;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@iid", internshipID)
                    conn.Open()
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            Dim vid As Integer = CInt(dr("VisitID"))
                            Dim vDate As Date = CDate(dr("VisitDate"))
                            Dim vType As String = dr("VisitType").ToString()
                            Dim score As Decimal = CDec(dr("Score"))
                            Dim maxScore As Decimal = CDec(dr("MaxScore"))
                            Dim remarks As String = dr("Remarks").ToString()

                            dgvVisitLogs.Rows.Add(vid,
                                              vDate.ToString("yyyy-MM-dd"),
                                              vType,
                                              score.ToString("0.00"),
                                              maxScore.ToString("0.00"),
                                              remarks)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading visit logs: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearVisitLogForm()
        _currentVisitID = -1
        lblVLFormTitle.Text = "Add / Edit Visit"

        If cboVLVisitType.Items.Count > 0 Then
            cboVLVisitType.SelectedIndex = 0
        End If

        dtpVLVisitDate.Value = Date.Today
        txtVLScore.Text = ""
        txtVLMaxScore.Text = ""
        txtVLRemarks.Text = ""
        txtVLAttachment.Text = ""

        dtpVLNextVisitDate.Value = Date.Today
        dtpVLNextVisitDate.Checked = False
    End Sub

    Private Sub btnVLCancel_Click(sender As Object, e As EventArgs) Handles btnVLCancel.Click
        ClearVisitLogForm()
    End Sub

    Private Sub btnVLBrowse_Click(sender As Object, e As EventArgs) Handles btnVLBrowse.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select attachment"
            ofd.Filter = "All Files|*.*"
            If ofd.ShowDialog() = DialogResult.OK Then
                txtVLAttachment.Text = ofd.FileName
            End If
        End Using
    End Sub

    Private Function ValidateVisitLogInputs() As Boolean
        If _currentInternshipID_VisitLog <= 0 Then
            MessageBox.Show("Please select an internship first.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Return False
        End If

        If cboVLVisitType.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a visit type.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Return False
        End If

        Dim score As Decimal
        Dim maxScore As Decimal

        If Not Decimal.TryParse(txtVLScore.Text.Trim(), score) Then
            MessageBox.Show("Please enter a valid numeric Score.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Return False
        End If

        If Not Decimal.TryParse(txtVLMaxScore.Text.Trim(), maxScore) Then
            MessageBox.Show("Please enter a valid numeric Max Score.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Return False
        End If

        If maxScore <= 0D Then
            MessageBox.Show("Max Score must be greater than zero.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Return False
        End If

        If score < 0D OrElse score > maxScore Then
            MessageBox.Show("Score must be between 0 and Max Score.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Return False
        End If

        ' FacultyID must be set globally after login
        If CurrentFacultyID <= 0 Then
            MessageBox.Show("CurrentFacultyID is not set. Make sure you set this at login.",
                        "Configuration",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub btnVLSave_Click(sender As Object, e As EventArgs) Handles btnVLSave.Click
        If Not ValidateVisitLogInputs() Then Return

        Dim visitType As String = cboVLVisitType.SelectedItem.ToString()
        Dim visitDate As Date = dtpVLVisitDate.Value.Date
        Dim score As Decimal = Decimal.Parse(txtVLScore.Text.Trim())
        Dim maxScore As Decimal = Decimal.Parse(txtVLMaxScore.Text.Trim())
        Dim remarks As String = txtVLRemarks.Text.Trim()
        Dim attachment As String = txtVLAttachment.Text.Trim()

        Dim nextVisitDate As Object = If(dtpVLNextVisitDate.Checked, dtpVLNextVisitDate.Value.Date, DBNull.Value)

        Dim sqlInsert As String =
        "INSERT INTO visitlog (InternshipID, FacultyID, VisitDate, VisitType, Score, MaxScore, Remarks, AttachmentPath, NextVisitDate, CreatedAt) " &
        "VALUES (@InternshipID, @FacultyID, @VisitDate, @VisitType, @Score, @MaxScore, @Remarks, @AttachmentPath, @NextVisitDate, NOW());"

        Dim sqlUpdate As String =
        "UPDATE visitlog SET VisitDate=@VisitDate, VisitType=@VisitType, Score=@Score, MaxScore=@MaxScore, " &
        "Remarks=@Remarks, AttachmentPath=@AttachmentPath, NextVisitDate=@NextVisitDate, UpdatedAt=NOW() " &
        "WHERE VisitID=@VisitID;"

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using tx As MySqlTransaction = conn.BeginTransaction()
                    Try
                        If _currentVisitID > 0 Then
                            ' UPDATE
                            Using cmd As New MySqlCommand(sqlUpdate, conn, tx)
                                cmd.Parameters.AddWithValue("@VisitDate", visitDate)
                                cmd.Parameters.AddWithValue("@VisitType", visitType)
                                cmd.Parameters.AddWithValue("@Score", score)
                                cmd.Parameters.AddWithValue("@MaxScore", maxScore)
                                cmd.Parameters.AddWithValue("@Remarks", If(remarks = "", DBNull.Value, remarks))
                                cmd.Parameters.AddWithValue("@AttachmentPath", If(attachment = "", DBNull.Value, attachment))
                                cmd.Parameters.AddWithValue("@NextVisitDate", nextVisitDate)
                                cmd.Parameters.AddWithValue("@VisitID", _currentVisitID)
                                cmd.ExecuteNonQuery()
                            End Using
                        Else
                            ' INSERT
                            Using cmd As New MySqlCommand(sqlInsert, conn, tx)
                                cmd.Parameters.AddWithValue("@InternshipID", _currentInternshipID_VisitLog)
                                cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)
                                cmd.Parameters.AddWithValue("@VisitDate", visitDate)
                                cmd.Parameters.AddWithValue("@VisitType", visitType)
                                cmd.Parameters.AddWithValue("@Score", score)
                                cmd.Parameters.AddWithValue("@MaxScore", maxScore)
                                cmd.Parameters.AddWithValue("@Remarks", If(remarks = "", DBNull.Value, remarks))
                                cmd.Parameters.AddWithValue("@AttachmentPath", If(attachment = "", DBNull.Value, attachment))
                                cmd.Parameters.AddWithValue("@NextVisitDate", nextVisitDate)
                                cmd.ExecuteNonQuery()
                            End Using
                        End If

                        tx.Commit()
                        MessageBox.Show("Visit log saved successfully.", "Success")

                    Catch ex As Exception
                        tx.Rollback()
                        MessageBox.Show("Error saving visit log: " & ex.Message)
                    End Try
                End Using
            End Using

            LoadVisitLogsForInternship(_currentInternshipID_VisitLog)
            ClearVisitLogForm()

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvVisitLogs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVisitLogs.CellContentClick
        If e.RowIndex < 0 Then Return

        Dim colName As String = dgvVisitLogs.Columns(e.ColumnIndex).Name
        Dim visitID As Integer = CInt(dgvVisitLogs.Rows(e.RowIndex).Cells("colVisitID").Value)

        If colName = "colEdit" Then
            LoadVisitLogIntoForm(visitID)
        ElseIf colName = "colDelete" Then
            DeleteVisitLog(visitID)
        End If
    End Sub

    Private Sub LoadVisitLogIntoForm(visitID As Integer)
        Dim sql As String =
        "SELECT VisitID, VisitDate, VisitType, Score, MaxScore, Remarks, AttachmentPath, NextVisitDate " &
        "FROM visitlog WHERE VisitID = @id;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", visitID)
                    conn.Open()
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            _currentVisitID = visitID
                            lblVLFormTitle.Text = "Edit Visit"

                            dtpVLVisitDate.Value = CDate(dr("VisitDate"))
                            Dim vType As String = dr("VisitType").ToString()
                            If cboVLVisitType.Items.Contains(vType) Then
                                cboVLVisitType.SelectedItem = vType
                            End If

                            txtVLScore.Text = CDec(dr("Score")).ToString("0.00")
                            txtVLMaxScore.Text = CDec(dr("MaxScore")).ToString("0.00")
                            txtVLRemarks.Text = dr("Remarks").ToString()
                            txtVLAttachment.Text = dr("AttachmentPath").ToString()

                            If IsDBNull(dr("NextVisitDate")) Then
                                dtpVLNextVisitDate.Checked = False
                            Else
                                dtpVLNextVisitDate.Value = CDate(dr("NextVisitDate"))
                                dtpVLNextVisitDate.Checked = True
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading visit log: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteVisitLog(visitID As Integer)
        Dim result = MessageBox.Show("Are you sure you want to delete this visit log?",
                                 "Confirm Delete",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning)
        If result <> DialogResult.Yes Then Return

        Dim sql As String = "DELETE FROM visitlog WHERE VisitID = @id;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", visitID)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Visit log deleted.",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

            If _currentInternshipID_VisitLog > 0 Then
                LoadVisitLogsForInternship(_currentInternshipID_VisitLog)
            End If
            ClearVisitLogForm()

        Catch ex As Exception
            MessageBox.Show("Error deleting visit log: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================
    ' GRADING - LOAD STUDENTS
    ' =========================
    Private Sub LoadGradingStudents()
        cboGradeStudent.DataSource = Nothing
        _currentGradingInternshipID = -1
        _currentGradingStudentID = -1

        Dim sql As String =
        "SELECT i.InternshipID, s.StudentID, s.StudentNumber, " &
        "CONCAT(s.LastName, ', ', s.FirstName, ' ', IFNULL(s.MiddleName,'')) AS FullName, " &
        "c.CourseCode, c.CourseName " &
        "FROM internship i " &
        "INNER JOIN student s ON i.StudentID = s.StudentID " &
        "INNER JOIN section sec ON s.SectionID = sec.SectionID " &
        "INNER JOIN course c ON sec.CourseID = c.CourseID " &
        "ORDER BY s.StudentNumber;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    conn.Open()
                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())

                    ' Build a display column
                    dt.Columns.Add("DisplayText", GetType(String))
                    For Each row As DataRow In dt.Rows
                        Dim sn As String = row("StudentNumber").ToString()
                        Dim name As String = row("FullName").ToString().Replace("  ", " ").Trim()
                        Dim code As String = row("CourseCode").ToString()
                        row("DisplayText") = $"{sn} - {name} ({code})"
                    Next

                    cboGradeStudent.DataSource = dt
                    cboGradeStudent.DisplayMember = "DisplayText"
                    cboGradeStudent.ValueMember = "InternshipID"
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading students for grading: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboGradeStudent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGradeStudent.SelectedIndexChanged
        If cboGradeStudent.SelectedValue Is Nothing Then
            ClearGradingForm()
            Return
        End If

        If Not TypeOf cboGradeStudent.SelectedValue Is Integer Then
            Return
        End If

        Dim internshipID As Integer = CInt(cboGradeStudent.SelectedValue)
        LoadGradingDetails(internshipID)
    End Sub

    Private Sub LoadGradingDetails(internshipID As Integer)
        Dim sql As String =
        "SELECT i.InternshipID, i.StudentID, i.HoursCompleted, i.Status, i.FinalGrade, " &
        "s.StudentNumber, CONCAT(s.FirstName, ' ', IFNULL(s.MiddleName,''), ' ', s.LastName) AS FullName, " &
        "c.CourseCode, c.CourseName, c.RequiredOJTHours " &
        "FROM internship i " &
        "INNER JOIN student s ON i.StudentID = s.StudentID " &
        "INNER JOIN section sec ON s.SectionID = sec.SectionID " &
        "INNER JOIN course c ON sec.CourseID = c.CourseID " &
        "WHERE i.InternshipID = @iid " &
        "LIMIT 1;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@iid", internshipID)
                    conn.Open()
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            _currentGradingInternshipID = CInt(dr("InternshipID"))
                            _currentGradingStudentID = CInt(dr("StudentID"))

                            Dim sn As String = dr("StudentNumber").ToString()
                            Dim fullName As String = dr("FullName").ToString().Replace("  ", " ").Trim()
                            Dim courseCode As String = dr("CourseCode").ToString()
                            Dim courseName As String = dr("CourseName").ToString()
                            Dim requiredHours As Integer = CInt(dr("RequiredOJTHours"))
                            Dim completedHours As Integer =
                            If(IsDBNull(dr("HoursCompleted")), 0, CInt(dr("HoursCompleted")))
                            Dim status As String = dr("Status").ToString()

                            lblGradeStudentNoValue.Text = sn
                            lblGradeNameValue.Text = fullName
                            lblGradeCourseValue.Text = $"{courseCode} - {courseName}"
                            lblGradeRequiredHoursValue.Text = $"{requiredHours} hours"
                            lblGradeCompletedHoursValue.Text = $"{completedHours} hours"
                            lblGradeStatusValue.Text = status

                            If IsDBNull(dr("FinalGrade")) Then
                                txtFinalGrade.Text = ""
                            Else
                                txtFinalGrade.Text = CDec(dr("FinalGrade")).ToString("0.00")
                            End If
                        Else
                            ClearGradingForm()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading grading details: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearGradingForm()
        _currentGradingInternshipID = -1
        _currentGradingStudentID = -1

        lblGradeStudentNoValue.Text = "-"
        lblGradeNameValue.Text = "-"
        lblGradeCourseValue.Text = "-"
        lblGradeRequiredHoursValue.Text = "-"
        lblGradeCompletedHoursValue.Text = "-"
        lblGradeStatusValue.Text = "-"

        txtFinalGrade.Text = ""
    End Sub

    Private Sub btnClearGrade_Click(sender As Object, e As EventArgs) Handles btnClearGrade.Click
        ClearGradingForm()
    End Sub

    Private Function ValidateGradeInputs() As Boolean
        If _currentGradingInternshipID <= 0 Then
            MessageBox.Show("Please select a student with an internship before saving a grade.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Return False
        End If

        If CurrentFacultyID <= 0 Then
            MessageBox.Show("CurrentFacultyID is not set. Make sure it is assigned at faculty login.",
                        "Configuration",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtFinalGrade.Text) Then
            MessageBox.Show("Please enter a final grade.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Return False
        End If

        Dim grade As Decimal
        If Not Decimal.TryParse(txtFinalGrade.Text.Trim(), grade) Then
            MessageBox.Show("Please enter a valid numeric grade (e.g. 95.00).",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Return False
        End If

        ' You can adjust this range if your school uses a different scale
        If grade < 0D OrElse grade > 100D Then
            MessageBox.Show("Final grade must be between 0 and 100.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub btnSaveGrade_Click(sender As Object, e As EventArgs) Handles btnSaveGrade.Click
        If Not ValidateGradeInputs() Then Return

        Dim grade As Decimal = Decimal.Parse(txtFinalGrade.Text.Trim())
        Dim remarks As String = If(grade >= 75D, "Passed", "Failed")

        Dim sql As String =
        "UPDATE internship SET " &
        "FinalGrade = @FinalGrade, " &
        "GradedByFacultyID = @FacultyID, " &
        "GradeDate = CURDATE(), " &
        "Status = 'Completed', " &
        "Remarks = @Remarks, " &
        "UpdatedAt = NOW() " &
        "WHERE InternshipID = @InternshipID;"

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using tx As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Using cmd As New MySqlCommand(sql, conn, tx)
                            cmd.Parameters.AddWithValue("@FinalGrade", grade)
                            cmd.Parameters.AddWithValue("@FacultyID", CurrentFacultyID)
                            cmd.Parameters.AddWithValue("@InternshipID", _currentGradingInternshipID)
                            cmd.Parameters.AddWithValue("@Remarks", remarks)
                            cmd.ExecuteNonQuery()
                        End Using

                        tx.Commit()
                        MessageBox.Show("Final grade saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Catch ex As Exception
                        tx.Rollback()
                        MessageBox.Show("Error saving grade: " & ex.Message)
                    End Try
                End Using
            End Using

            LoadGradingDetails(_currentGradingInternshipID)

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
        End Try
    End Sub

    ' =========================
    ' COMPANIES - GRID & LOAD
    ' =========================
    Private Sub ConfigureCompaniesGrid()
        dgvCompanies.Columns.Clear()

        Dim colID As New DataGridViewTextBoxColumn()
        colID.Name = "colCompanyID"
        colID.HeaderText = "CompanyID"
        colID.Visible = False

        Dim colName As New DataGridViewTextBoxColumn()
        colName.Name = "colCompanyName"
        colName.HeaderText = "Company Name"

        Dim colCity As New DataGridViewTextBoxColumn()
        colCity.Name = "colCity"
        colCity.HeaderText = "City"

        Dim colStatus As New DataGridViewTextBoxColumn()
        colStatus.Name = "colStatus"
        colStatus.HeaderText = "Status"

        Dim colEdit As New DataGridViewButtonColumn()
        colEdit.Name = "colEdit"
        colEdit.HeaderText = "Edit"
        colEdit.Text = "Edit"
        colEdit.UseColumnTextForButtonValue = True

        Dim colDelete As New DataGridViewButtonColumn()
        colDelete.Name = "colDelete"
        colDelete.HeaderText = "Deactivate"
        colDelete.Text = "Deactivate"
        colDelete.UseColumnTextForButtonValue = True

        dgvCompanies.Columns.AddRange(New DataGridViewColumn() {
        colID, colName, colCity, colStatus, colEdit, colDelete
    })

        dgvCompanies.Columns("colCompanyName").FillWeight = 40
        dgvCompanies.Columns("colCity").FillWeight = 20
        dgvCompanies.Columns("colStatus").FillWeight = 15
        dgvCompanies.Columns("colEdit").FillWeight = 12
        dgvCompanies.Columns("colDelete").FillWeight = 13
    End Sub

    Private Sub LoadCompanies(searchTerm As String)
        dgvCompanies.Rows.Clear()

        Dim sql As String =
        "SELECT CompanyID, CompanyName, CompanyCity, CompanyStatus " &
        "FROM company " &
        "WHERE (@term = '' " &
        "       OR CompanyName LIKE CONCAT('%', @term, '%') " &
        "       OR CompanyCity LIKE CONCAT('%', @term, '%')) " &
        "ORDER BY CompanyName;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@term", searchTerm)
                    conn.Open()
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            Dim id As Integer = CInt(dr("CompanyID"))
                            Dim name As String = dr("CompanyName").ToString()
                            Dim city As String = dr("CompanyCity").ToString()
                            Dim status As String = dr("CompanyStatus").ToString()

                            dgvCompanies.Rows.Add(id, name, city, status)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading companies: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearchCompany_Click(sender As Object, e As EventArgs) Handles btnSearchCompany.Click
        Dim term As String = txtSearchCompany.Text.Trim()
        LoadCompanies(term)
    End Sub

    Private Sub btnAddCompany_Click(sender As Object, e As EventArgs) Handles btnAddCompany.Click
        Using f As New frmCompanyEntry()   ' Add mode
            If f.ShowDialog() = DialogResult.OK Then
                LoadCompanies(txtSearchCompany.Text.Trim())
            End If
        End Using
    End Sub

    Private Sub dgvCompanies_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCompanies.CellContentClick
        If e.RowIndex < 0 Then Return

        Dim colName As String = dgvCompanies.Columns(e.ColumnIndex).Name
        Dim companyID As Integer = CInt(dgvCompanies.Rows(e.RowIndex).Cells("colCompanyID").Value)
        Dim currentStatus As String = dgvCompanies.Rows(e.RowIndex).Cells("colStatus").Value.ToString()

        If colName = "colEdit" Then
            ' Edit company
            Using f As New frmCompanyEntry(companyID)
                If f.ShowDialog() = DialogResult.OK Then
                    LoadCompanies(txtSearchCompany.Text.Trim())
                End If
            End Using

        ElseIf colName = "colDelete" Then
            ' Soft delete: set status to Inactive
            If currentStatus = "Inactive" Then
                MessageBox.Show("This company is already inactive.",
                            "Info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
                Return
            End If

            Dim result = MessageBox.Show("Mark this company as Inactive? " &
                                     "Existing internships and contacts will remain, but this company will not appear as active.",
                                     "Confirm Deactivate",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning)
            If result <> DialogResult.Yes Then Return

            SoftDeleteCompany(companyID)
            LoadCompanies(txtSearchCompany.Text.Trim())
        End If
    End Sub

    Private Sub SoftDeleteCompany(companyID As Integer)
        Dim sql As String =
        "UPDATE company SET CompanyStatus = 'Inactive', UpdatedAt = NOW() " &
        "WHERE CompanyID = @id;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", companyID)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Company marked as Inactive.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error deactivating company: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadContactCompanies()
        Dim sql As String = "SELECT CompanyID, CompanyName FROM company ORDER BY CompanyName;"

        Try
            Using conn = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    conn.Open()
                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())

                    cboContactCompany.DataSource = dt
                    cboContactCompany.DisplayMember = "CompanyName"
                    cboContactCompany.ValueMember = "CompanyID"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading companies: " & ex.Message)
        End Try
    End Sub

    Private Sub ConfigureContactsGrid()
        dgvContacts.Columns.Clear()

        dgvContacts.Columns.Add("colContactID", "ID")
        dgvContacts.Columns("colContactID").Visible = False

        dgvContacts.Columns.Add("colName", "Name")
        dgvContacts.Columns.Add("colPosition", "Position")
        dgvContacts.Columns.Add("colEmail", "Email")
        dgvContacts.Columns.Add("colContactNumber", "Contact No.")
        dgvContacts.Columns.Add("colPrimary", "Primary")

        Dim colEdit As New DataGridViewButtonColumn()
        colEdit.Name = "colEdit"
        colEdit.HeaderText = "Edit"
        colEdit.Text = "Edit"
        colEdit.UseColumnTextForButtonValue = True

        Dim colDelete As New DataGridViewButtonColumn()
        colDelete.Name = "colDelete"
        colDelete.HeaderText = "Delete"
        colDelete.Text = "Delete"
        colDelete.UseColumnTextForButtonValue = True

        dgvContacts.Columns.Add(colEdit)
        dgvContacts.Columns.Add(colDelete)
    End Sub

    Private Sub cboContactCompany_SelectedIndexChanged(sender As Object, e As EventArgs)
        If cboContactCompany.SelectedValue Is Nothing Then Return
        If TypeOf cboContactCompany.SelectedValue Is Integer Then
            LoadContacts(cboContactCompany.SelectedValue)
        End If
    End Sub

    Private Sub LoadContacts(companyID As Integer)
        dgvContacts.Rows.Clear()

        Dim sql As String =
        "SELECT ContactID, FirstName, LastName, Position, Email, ContactNumber, IsPrimary " &
        "FROM companycontact WHERE CompanyID = @cid ORDER BY LastName, FirstName;"

        Try
            Using conn = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@cid", companyID)
                    conn.Open()

                    Using dr = cmd.ExecuteReader()
                        While dr.Read()
                            dgvContacts.Rows.Add(
                            dr("ContactID"),
                            dr("LastName") & ", " & dr("FirstName"),
                            dr("Position").ToString(),
                            dr("Email").ToString(),
                            dr("ContactNumber").ToString(),
                            If(CBool(dr("IsPrimary")), "Yes", "No")
                        )
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading contacts: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAddContact_Click(sender As Object, e As EventArgs)
        If cboContactCompany.SelectedValue Is Nothing Then Return

        Dim companyID As Integer = cboContactCompany.SelectedValue

        Using f As New frmCompanyContactEntry(companyID)
            If f.ShowDialog = DialogResult.OK Then
                LoadContacts(companyID)
            End If
        End Using
    End Sub

    Private Sub dgvContacts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContacts.CellContentClick
        If e.RowIndex < 0 Then Return

        Dim contactID As Integer = CInt(dgvContacts.Rows(e.RowIndex).Cells("colContactID").Value)
        Dim companyID As Integer = CInt(cboContactCompany.SelectedValue)

        Dim colName As String = dgvContacts.Columns(e.ColumnIndex).Name

        If colName = "colEdit" Then
            Using f As New frmCompanyContactEntry(companyID, contactID)
                If f.ShowDialog() = DialogResult.OK Then
                    LoadContacts(companyID)
                End If
            End Using

        ElseIf colName = "colDelete" Then
            If MessageBox.Show("Delete this contact?",
                           "Confirm Delete",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) = DialogResult.Yes Then

                DeleteContact(contactID)
                LoadContacts(companyID)
            End If
        End If
    End Sub

    Private Sub DeleteContact(contactID As Integer)
        Dim sql As String = "DELETE FROM companycontact WHERE ContactID = @id;"

        Try
            Using conn = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", contactID)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error deleting contact: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadFacultyProfile()
        Dim sql As String =
        "SELECT FacultyID, FirstName, LastName, PositionTitle, Department, Email, ContactNumber 
         FROM faculty 
         WHERE FacultyID = @fid LIMIT 1;"

        Try
            Using conn = GetConnection()
                Using cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@fid", LoggedFacultyID)
                    conn.Open()

                    Using dr = cmd.ExecuteReader()
                        If dr.Read() Then
                            lblFacultyName.Text = dr("LastName") & ", " & dr("FirstName")
                            lblFacultyPosition.Text = dr("PositionTitle").ToString()
                            lblEmployeeNumber.Text = dr("FacultyID").ToString()
                            lblDepartment.Text = dr("Department").ToString()
                            txtFacultyEmail.Text = dr("Email").ToString()
                            txtFacultyContact.Text = dr("ContactNumber").ToString()
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading faculty profile: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEditFaculty_Click(sender As Object, e As EventArgs) Handles btnEditFaculty.Click
        txtFacultyEmail.ReadOnly = False
        txtFacultyContact.ReadOnly = False

        txtFacultyEmail.BackColor = Color.White
        txtFacultyContact.BackColor = Color.White

        btnSaveFaculty.Enabled = True
    End Sub

    Private Sub btnSaveFaculty_Click(sender As Object, e As EventArgs) Handles btnSaveFaculty.Click
        Dim sql As String =
        "UPDATE faculty SET 
            Email = @Email, 
            ContactNumber = @ContactNumber, 
            UpdatedAt = NOW()
         WHERE FacultyID = @fid;"

        Try
            Using conn = GetConnection()
                Using cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Email", txtFacultyEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@ContactNumber", txtFacultyContact.Text.Trim())
                    cmd.Parameters.AddWithValue("@fid", LoggedFacultyID)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Profile updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

            btnSaveFaculty.Enabled = False

            txtFacultyEmail.ReadOnly = True
            txtFacultyContact.ReadOnly = True
            txtFacultyEmail.BackColor = Color.FromArgb(245, 245, 245)
            txtFacultyContact.BackColor = Color.FromArgb(245, 245, 245)

        Catch ex As Exception
            MessageBox.Show("Error saving faculty profile: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvLatestActivity_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLatestActivity.CellContentClick

    End Sub
End Class
