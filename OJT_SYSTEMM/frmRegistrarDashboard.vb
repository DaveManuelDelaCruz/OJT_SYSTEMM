Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class frmRegistrarDashboard
    Public Property CurrentRegistrarID As Integer

    '========================
    ' FORM LOAD
    '========================
    Private Sub frmRegistrarDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set header name if you use a shared CurrentUser
        Try
            If CurrentUser IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(CurrentUser.Name) Then
                lblUserName.Text = CurrentUser.Name
            End If
        Catch
            ' ignore if not available
        End Try

        InitializeUi()
        ShowPanel(pnlHome)
        HighlightActive(btnHome)

        ' Smooth fade-in
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

        ' Initial data
        LoadStudentApprovals()
        LoadPendingFaculty()
        ShowPanel(pnlHome)
        RefreshHomeDashboard()
    End Sub

    '========================
    ' UI HELPERS
    '========================
    Private Sub InitializeUi()
        For Each ctrl As Control In pnlSidebar.Controls
            Dim btn = TryCast(ctrl, Button)
            If btn IsNot Nothing AndAlso btn IsNot btnLogout Then
                ResetSidebarButton(btn)
            End If
        Next

        pnlHome.Visible = True
        pnlStudentApprovals.Visible = False
        pnlFacultyApprovals.Visible = False
        pnlManageStudents.Visible = False
        pnlManageFaculty.Visible = False
        pnlOfficialSchoolList.Visible = False
        pnlOfficialProfessorList.Visible = False
        pnlLogs.Visible = False
    End Sub

    Private Sub ShowPanel(panelToShow As Panel)
        pnlHome.Visible = False
        pnlStudentApprovals.Visible = False
        pnlFacultyApprovals.Visible = False
        pnlManageStudents.Visible = False
        pnlManageFaculty.Visible = False
        pnlOfficialSchoolList.Visible = False
        pnlOfficialProfessorList.Visible = False
        pnlLogs.Visible = False

        panelToShow.Visible = True
        panelToShow.BringToFront()
    End Sub

    Private Sub HighlightActive(activeButton As Button)
        For Each ctrl As Control In pnlSidebar.Controls
            Dim btn As Button = TryCast(ctrl, Button)
            If btn IsNot Nothing AndAlso btn IsNot btnLogout Then
                ResetSidebarButton(btn)
            End If
        Next

        activeButton.BackColor = Color.FromArgb(76, 175, 80)
        activeButton.ForeColor = Color.White
        activeButton.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
    End Sub

    Private Sub ResetSidebarButton(btn As Button)
        btn.BackColor = Color.FromArgb(34, 51, 34)
        btn.ForeColor = Color.White
        btn.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular)
    End Sub

    ' Registrar ID helper (comes from login form)
    Private Function GetCurrentRegistrarId() As Integer
        Return CurrentRegistrarID
    End Function

    '========================
    ' NAVIGATION BUTTONS
    '========================
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        HighlightActive(btnHome)
        ShowPanel(pnlHome)
        RefreshHomeDashboard()
    End Sub

    Private Sub btnStudentApprovals_Click(sender As Object, e As EventArgs) Handles btnStudentApprovals.Click
        HighlightActive(btnStudentApprovals)
        ShowPanel(pnlStudentApprovals)
        LoadStudentApprovals()
    End Sub

    Private Sub btnFacultyApprovals_Click(sender As Object, e As EventArgs) Handles btnFacultyApprovals.Click
        HighlightActive(btnFacultyApprovals)
        ShowPanel(pnlFacultyApprovals)
        LoadPendingFaculty()
    End Sub

    Private Sub btnManageStudents_Click(sender As Object, e As EventArgs) Handles btnManageStudents.Click
        HighlightActive(btnManageStudents)
        ShowPanel(pnlManageStudents)

        If cboMSDepartment.Items.Count = 0 Then
            LoadMSDepartments()
        End If

        LoadManageStudents()
    End Sub

    Private Sub btnManageFaculty_Click(sender As Object, e As EventArgs) Handles btnManageFaculty.Click
        HighlightActive(btnManageFaculty)
        ShowPanel(pnlManageFaculty)

        If cboMFDepartment.Items.Count = 0 Then
            LoadMFDepartments()
            LoadMFPositions()
            LoadMFSections(0) ' All departments for filter
        End If

        LoadManageFaculty()
    End Sub

    Private Sub btnOfficialSchoolList_Click(sender As Object, e As EventArgs) Handles btnOfficialSchoolList.Click
        HighlightActive(btnOfficialSchoolList)
        ShowPanel(pnlOfficialSchoolList)

        ' Load filters only once
        If cboOSDepartment.DataSource Is Nothing Then
            LoadOSLDepartments()
        End If

        LoadOfficialStudentList()
    End Sub

    Private Sub btnOfficialProfessorList_Click(sender As Object, e As EventArgs) Handles btnOfficialProfessorList.Click
        HighlightActive(btnOfficialProfessorList)
        ShowPanel(pnlOfficialProfessorList)

        If cboOPDepartment.Items.Count = 0 Then
            LoadOPDepartments()
        End If

        LoadOfficialProfessorList()
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        HighlightActive(btnLogs)
        ShowPanel(pnlLogs)

        LoadLogs()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to logout?",
                                     "Confirm Logout",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                ' Registrar now has its own login form
                Dim login As New frmLoginRegistrar()
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

    '==========================================
    ' STUDENT APPROVALS (PANEL 2)
    '==========================================
    Private Sub ConfigureStudentPendingGrid()
        If dgvStudentPending.Columns.Count > 0 Then
            Return
        End If

        dgvStudentPending.AutoGenerateColumns = False
        dgvStudentPending.Columns.Clear()

        ' Hidden StudentID
        Dim colId As New DataGridViewTextBoxColumn() With {
            .Name = "colStudentID",
            .DataPropertyName = "StudentID",
            .Visible = False
        }
        dgvStudentPending.Columns.Add(colId)

        ' Student Number
        dgvStudentPending.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colStudentNumber",
            .HeaderText = "Student No",
            .DataPropertyName = "StudentNumber"
        })

        ' Full Name
        dgvStudentPending.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colFullName",
            .HeaderText = "Name",
            .DataPropertyName = "FullName"
        })

        ' Course
        dgvStudentPending.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colCourse",
            .HeaderText = "Course",
            .DataPropertyName = "CourseCode"
        })

        ' Section
        dgvStudentPending.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colSection",
            .HeaderText = "Section",
            .DataPropertyName = "SectionName"
        })

        ' Email
        dgvStudentPending.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colEmail",
            .HeaderText = "Email",
            .DataPropertyName = "Email"
        })

        ' View
        dgvStudentPending.Columns.Add(New DataGridViewButtonColumn() With {
            .Name = "colView",
            .HeaderText = "View",
            .Text = "View",
            .UseColumnTextForButtonValue = True
        })

        ' Approve
        dgvStudentPending.Columns.Add(New DataGridViewButtonColumn() With {
            .Name = "colApprove",
            .HeaderText = "Approve",
            .Text = "✔",
            .UseColumnTextForButtonValue = True
        })

        ' Reject
        dgvStudentPending.Columns.Add(New DataGridViewButtonColumn() With {
            .Name = "colReject",
            .HeaderText = "Reject",
            .Text = "✖",
            .UseColumnTextForButtonValue = True
        })
    End Sub

    Private Sub LoadStudentApprovals()
        Dim search As String = txtSearchStudentPending.Text.Trim()
        LoadStudentApprovals(search)
    End Sub

    Private Sub LoadStudentApprovals(searchText As String)
        Try
            ConfigureStudentPendingGrid()

            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand("
                    SELECT 
                        s.StudentID,
                        s.StudentNumber,
                        CONCAT(s.LastName, ', ', s.FirstName, ' ', COALESCE(s.MiddleName, '')) AS FullName,
                        c.CourseCode,
                        sec.SectionName,
                        s.Email
                    FROM student s
                    LEFT JOIN section sec ON s.SectionID = sec.SectionID
                    LEFT JOIN course c ON sec.CourseID = c.CourseID
                    WHERE s.AccountStatus = 'Pending'
                      AND (
                        @search = '' OR
                        s.StudentNumber LIKE CONCAT('%', @search, '%') OR
                        s.LastName LIKE CONCAT('%', @search, '%') OR
                        s.FirstName LIKE CONCAT('%', @search, '%') OR
                        s.Email LIKE CONCAT('%', @search, '%')
                      )
                    ORDER BY s.CreatedAt DESC;", conn)

                    cmd.Parameters.AddWithValue("@search", searchText)

                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dgvStudentPending.DataSource = dt
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading pending students: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearchStudentPending_Click(sender As Object, e As EventArgs) Handles btnSearchStudentPending.Click
        LoadStudentApprovals()
    End Sub

    Private Sub dgvStudentPending_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudentPending.CellContentClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return

        Dim colName As String = dgvStudentPending.Columns(e.ColumnIndex).Name
        Dim row As DataGridViewRow = dgvStudentPending.Rows(e.RowIndex)

        Dim studentId As Integer = CInt(row.Cells("colStudentID").Value)
        Dim studentNumber As String = row.Cells("colStudentNumber").Value.ToString()
        Dim fullName As String = row.Cells("colFullName").Value.ToString()
        Dim course As String = row.Cells("colCourse").Value.ToString()
        Dim sectionName As String = row.Cells("colSection").Value.ToString()
        Dim email As String = row.Cells("colEmail").Value.ToString()

        If colName = "colView" Then
            Dim info As String =
                $"Student Number: {studentNumber}" & Environment.NewLine &
                $"Name: {fullName}" & Environment.NewLine &
                $"Course / Section: {course} - {sectionName}" & Environment.NewLine &
                $"Email: {email}"

            MessageBox.Show(info, "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf colName = "colApprove" Then
            Dim result = MessageBox.Show(
                $"Approve this student?" & Environment.NewLine &
                $"{fullName} ({studentNumber})",
                "Confirm Approval",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ApproveStudent(studentId, fullName, studentNumber)
                LoadStudentApprovals()
            End If

        ElseIf colName = "colReject" Then
            Dim reason As String = InputBox("Reason for rejection:", "Reject Student")
            If String.IsNullOrWhiteSpace(reason) Then Return

            Dim result = MessageBox.Show(
                $"Reject this student?" & Environment.NewLine &
                $"{fullName} ({studentNumber})" & Environment.NewLine &
                $"Reason: {reason}",
                "Confirm Rejection",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                RejectStudent(studentId, fullName, studentNumber, reason)
                LoadStudentApprovals()
            End If
        End If
    End Sub
    Private Sub ApproveStudent(studentId As Integer, fullName As String, studentNumber As String)
        Dim approverId As Integer = GetCurrentRegistrarId()

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using tx As MySqlTransaction = conn.BeginTransaction()

                    Using cmd As New MySqlCommand("
                    UPDATE student
                    SET AccountStatus = 'Active',
                        RejectionReason = NULL,
                        ApprovedByRegistrarID = @rid,
                        ApprovalDate = NOW()
                    WHERE StudentID = @sid;", conn, tx)

                        cmd.Parameters.AddWithValue("@rid", approverId)
                        cmd.Parameters.AddWithValue("@sid", studentId)
                        cmd.ExecuteNonQuery()
                    End Using

                    Using cmdLog As New MySqlCommand("
                    INSERT INTO account_logs (UserType, UserID, Action, LogDate)
                    VALUES ('Registrar', @rid, @action, NOW());", conn, tx)

                        Dim actionText As String =
                        $"Approved student registration: {fullName} ({studentNumber})"

                        cmdLog.Parameters.AddWithValue("@rid", approverId)
                        cmdLog.Parameters.AddWithValue("@action", actionText)
                        cmdLog.ExecuteNonQuery()
                    End Using

                    tx.Commit()
                End Using
            End Using

            MessageBox.Show("Student approved successfully.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error approving student: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RejectStudent(studentId As Integer, fullName As String, studentNumber As String, reason As String)
        Dim approverId As Integer = GetCurrentRegistrarId()

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using tx As MySqlTransaction = conn.BeginTransaction()

                    Using cmd As New MySqlCommand("
                    UPDATE student
                    SET AccountStatus = 'Rejected',
                        RejectionReason = @reason,
                        ApprovedByRegistrarID = @rid,
                        ApprovalDate = NOW()
                    WHERE StudentID = @sid;", conn, tx)

                        cmd.Parameters.AddWithValue("@reason", reason)
                        cmd.Parameters.AddWithValue("@rid", approverId)
                        cmd.Parameters.AddWithValue("@sid", studentId)
                        cmd.ExecuteNonQuery()
                    End Using

                    Using cmdLog As New MySqlCommand("
                    INSERT INTO account_logs (UserType, UserID, Action, LogDate)
                    VALUES ('Registrar', @rid, @action, NOW());", conn, tx)

                        Dim actionText As String =
                        $"Rejected student registration: {fullName} ({studentNumber}). Reason: {reason}."

                        cmdLog.Parameters.AddWithValue("@rid", approverId)
                        cmdLog.Parameters.AddWithValue("@action", actionText)
                        cmdLog.ExecuteNonQuery()
                    End Using

                    tx.Commit()
                End Using
            End Using

            MessageBox.Show("Student rejected successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error rejecting student: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '==========================================
    ' FACULTY APPROVALS (PANEL 3)
    '==========================================
    Private Sub LoadPendingFaculty(Optional searchText As String = "")
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim query As String =
                "SELECT 
                    f.FacultyID,
                    f.EmployeeNumber,
                    CONCAT(f.LastName, ', ', f.FirstName, ' ', COALESCE(f.MiddleName,'')) AS FullName,
                    d.DepartmentCode,
                    f.PositionTitle AS Position
                 FROM faculty f
                 INNER JOIN department d ON f.DepartmentID = d.DepartmentID
                 WHERE f.Status = 'Pending'
                   AND (
                        @search = '' OR
                        f.EmployeeNumber LIKE CONCAT('%', @search, '%') OR
                        f.LastName LIKE CONCAT('%', @search, '%') OR
                        f.FirstName LIKE CONCAT('%', @search, '%')
                   )
                 ORDER BY f.LastName;"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@search", searchText)

                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)

                        ' ============================
                        ' RESET GRID BEFORE REBUILDING
                        ' ============================
                        dgvFacultyPending.Columns.Clear()
                        dgvFacultyPending.DataSource = dt

                        ' ----------------------------
                        ' HIDE FacultyID (internal use)
                        ' ----------------------------
                        If dgvFacultyPending.Columns.Contains("FacultyID") Then
                            dgvFacultyPending.Columns("FacultyID").Visible = False
                        End If

                        ' ----------------------------
                        ' FORMAT COLUMNS
                        ' ----------------------------
                        If dgvFacultyPending.Columns.Contains("EmployeeNumber") Then
                            dgvFacultyPending.Columns("EmployeeNumber").HeaderText = "Faculty No"
                        End If

                        If dgvFacultyPending.Columns.Contains("DepartmentCode") Then
                            dgvFacultyPending.Columns("DepartmentCode").HeaderText = "Department"
                        End If

                        If dgvFacultyPending.Columns.Contains("Position") Then
                            dgvFacultyPending.Columns("Position").HeaderText = "Position"
                        End If

                        ' ============================
                        ' ADD ACTION BUTTONS
                        ' ============================
                        Dim colView As New DataGridViewButtonColumn() With {
                        .HeaderText = "View",
                        .Text = "👁",
                        .UseColumnTextForButtonValue = True,
                        .Width = 60,
                        .Name = "colView"
                    }
                        dgvFacultyPending.Columns.Add(colView)

                        Dim colApprove As New DataGridViewButtonColumn() With {
                        .HeaderText = "Approve",
                        .Text = "✔",
                        .UseColumnTextForButtonValue = True,
                        .Width = 80,
                        .Name = "colApprove"
                    }
                        dgvFacultyPending.Columns.Add(colApprove)

                        Dim colReject As New DataGridViewButtonColumn() With {
                        .HeaderText = "Reject",
                        .Text = "✖",
                        .UseColumnTextForButtonValue = True,
                        .Width = 80,
                        .Name = "colReject"
                    }
                        dgvFacultyPending.Columns.Add(colReject)

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading pending faculty: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSearchFacultyPending_Click(sender As Object, e As EventArgs) Handles btnSearchFacultyPending.Click
        LoadPendingFaculty(txtSearchFacultyPending.Text.Trim())
    End Sub

    Private Sub dgvFacultyPending_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFacultyPending.CellContentClick
        If e.RowIndex < 0 Then Exit Sub

        Dim facultyId As Integer = CInt(dgvFacultyPending.Rows(e.RowIndex).Cells("FacultyID").Value)
        Dim fullName As String = dgvFacultyPending.Rows(e.RowIndex).Cells("FullName").Value.ToString()
        Dim empNum As String = dgvFacultyPending.Rows(e.RowIndex).Cells("EmployeeNumber").Value.ToString()

        Dim col = dgvFacultyPending.Columns(e.ColumnIndex)

        If col.Name = "colView" OrElse col.HeaderText = "View" Then
            ShowFacultyViewPopup(facultyId)

        ElseIf col.Name = "colApprove" OrElse col.HeaderText = "Approve" Then
            ApproveFaculty(facultyId, fullName, empNum)

        ElseIf col.Name = "colReject" OrElse col.HeaderText = "Reject" Then
            ShowFacultyRejectPopup(facultyId, fullName, empNum)
        End If
    End Sub

    Private Sub ApproveFaculty(facultyId As Integer, fullName As String, empNum As String)
        Dim registrarId As Integer = GetCurrentRegistrarId()

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using tx = conn.BeginTransaction()

                    Using cmd As New MySqlCommand("
                    UPDATE faculty
                    SET Status = 'Active',
                        RejectionReason = NULL,
                        ApprovedByRegistrarID = @rid,
                        ApprovalDate = NOW()
                    WHERE FacultyID = @fid;", conn, tx)

                        cmd.Parameters.AddWithValue("@fid", facultyId)
                        cmd.Parameters.AddWithValue("@rid", registrarId)
                        cmd.ExecuteNonQuery()
                    End Using

                    Using cmdLog As New MySqlCommand("
                    INSERT INTO account_logs (UserType, UserID, Action, LogDate)
                    VALUES ('Registrar', @rid, @action, NOW());", conn, tx)

                        Dim actionText =
                        $"Approved faculty registration: {fullName} ({empNum})"

                        cmdLog.Parameters.AddWithValue("@rid", registrarId)
                        cmdLog.Parameters.AddWithValue("@action", actionText)
                        cmdLog.ExecuteNonQuery()
                    End Using

                    tx.Commit()
                End Using
            End Using

            MessageBox.Show("Faculty approved successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadPendingFaculty()

        Catch ex As Exception
            MessageBox.Show("Error approving faculty: " & ex.Message)
        End Try
    End Sub


    Private Sub ShowFacultyViewPopup(facultyId As Integer)
        Dim popup As New frmViewFacultyPending(facultyId)
        popup.ShowDialog()
    End Sub

    Private Sub ShowFacultyRejectPopup(facultyId As Integer, fullName As String, empNum As String)
        Dim reject As New frmRejectFaculty(facultyId, fullName, empNum)
        If reject.ShowDialog() = DialogResult.OK Then
            LoadPendingFaculty()
        End If
    End Sub

    '==========================================
    ' MANAGE STUDENT ACCOUNTS (PANEL 4)
    '==========================================
    ' ---- Filters ----
    Private Sub LoadMSDepartments()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                    SELECT DepartmentID, DepartmentName
                    FROM department
                    WHERE IsActive = 1
                    ORDER BY DepartmentName;", conn)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(dr)

                        Dim rowAll As DataRow = dt.NewRow()
                        rowAll("DepartmentID") = 0
                        rowAll("DepartmentName") = "All Departments"
                        dt.Rows.InsertAt(rowAll, 0)

                        cboMSDepartment.DataSource = dt
                        cboMSDepartment.DisplayMember = "DepartmentName"
                        cboMSDepartment.ValueMember = "DepartmentID"
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading departments: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

        cboMSCourse.DataSource = Nothing
        cboMSSection.DataSource = Nothing
    End Sub

    Private Sub cboMSDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMSDepartment.SelectedIndexChanged
        Dim deptId As Integer = 0
        If cboMSDepartment.SelectedValue IsNot Nothing AndAlso Integer.TryParse(cboMSDepartment.SelectedValue.ToString(), deptId) Then
            LoadMSCourses(deptId)
        Else
            cboMSCourse.DataSource = Nothing
            cboMSSection.DataSource = Nothing
        End If
        LoadManageStudents()
    End Sub

    Private Sub LoadMSCourses(departmentId As Integer)
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                    SELECT CourseID, CourseCode
                    FROM course
                    WHERE IsActive = 1
                      AND (@deptId = 0 OR DepartmentID = @deptId)
                    ORDER BY CourseCode;", conn)

                    cmd.Parameters.AddWithValue("@deptId", departmentId)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(dr)

                        Dim rowAll As DataRow = dt.NewRow()
                        rowAll("CourseID") = 0
                        rowAll("CourseCode") = "All Courses"
                        dt.Rows.InsertAt(rowAll, 0)

                        cboMSCourse.DataSource = dt
                        cboMSCourse.DisplayMember = "CourseCode"
                        cboMSCourse.ValueMember = "CourseID"
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading courses: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

        cboMSSection.DataSource = Nothing
    End Sub

    Private Sub cboMSCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMSCourse.SelectedIndexChanged
        Dim courseId As Integer = 0
        If cboMSCourse.SelectedValue IsNot Nothing AndAlso Integer.TryParse(cboMSCourse.SelectedValue.ToString(), courseId) Then
            LoadMSSections(courseId)
        Else
            cboMSSection.DataSource = Nothing
        End If
        LoadManageStudents()
    End Sub

    Private Sub LoadMSSections(courseId As Integer)
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                    SELECT SectionID, SectionName
                    FROM section
                    WHERE IsActive = 1
                      AND (@courseId = 0 OR CourseID = @courseId)
                    ORDER BY SectionName;", conn)

                    cmd.Parameters.AddWithValue("@courseId", courseId)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(dr)

                        Dim rowAll As DataRow = dt.NewRow()
                        rowAll("SectionID") = 0
                        rowAll("SectionName") = "All Sections"
                        dt.Rows.InsertAt(rowAll, 0)

                        cboMSSection.DataSource = dt
                        cboMSSection.DisplayMember = "SectionName"
                        cboMSSection.ValueMember = "SectionID"
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading sections: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    ' ---- Grid ----
    Private Sub ConfigureManageStudentsGrid()
        If dgvManageStudents.Columns.Count > 0 Then
            Return
        End If

        dgvManageStudents.AutoGenerateColumns = False
        dgvManageStudents.Columns.Clear()

        dgvManageStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colStudentID",
            .DataPropertyName = "StudentID",
            .Visible = False
        })

        dgvManageStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colStudentNumber",
            .HeaderText = "Student No",
            .DataPropertyName = "StudentNumber"
        })

        dgvManageStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colFullName",
            .HeaderText = "Name",
            .DataPropertyName = "FullName"
        })

        dgvManageStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colEmail",
            .HeaderText = "Email",
            .DataPropertyName = "Email"
        })

        dgvManageStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colAccountStatus",
            .HeaderText = "AccountStatus",
            .DataPropertyName = "AccountStatus"
        })

        dgvManageStudents.Columns.Add(New DataGridViewButtonColumn() With {
            .Name = "colEdit",
            .HeaderText = "Edit",
            .Text = "Edit",
            .UseColumnTextForButtonValue = True
        })

        dgvManageStudents.Columns.Add(New DataGridViewButtonColumn() With {
            .Name = "colReset",
            .HeaderText = "Reset PW",
            .Text = "Reset",
            .UseColumnTextForButtonValue = True
        })

        dgvManageStudents.Columns.Add(New DataGridViewButtonColumn() With {
            .Name = "colActivate",
            .HeaderText = "Activate",
            .Text = "✔",
            .UseColumnTextForButtonValue = True
        })

        dgvManageStudents.Columns.Add(New DataGridViewButtonColumn() With {
            .Name = "colDeactivate",
            .HeaderText = "Deactivate",
            .Text = "🛑",
            .UseColumnTextForButtonValue = True
        })
    End Sub

    Private Sub LoadManageStudents()
        Dim search As String = txtMSSearch.Text.Trim()

        Dim deptId As Integer = 0
        Dim courseId As Integer = 0
        Dim sectionId As Integer = 0

        If cboMSDepartment.SelectedValue IsNot Nothing Then
            Integer.TryParse(cboMSDepartment.SelectedValue.ToString(), deptId)
        End If
        If cboMSCourse.SelectedValue IsNot Nothing Then
            Integer.TryParse(cboMSCourse.SelectedValue.ToString(), courseId)
        End If
        If cboMSSection.SelectedValue IsNot Nothing Then
            Integer.TryParse(cboMSSection.SelectedValue.ToString(), sectionId)
        End If

        Try
            ConfigureManageStudentsGrid()

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                    SELECT 
                        s.StudentID,
                        s.StudentNumber,
                        CONCAT(s.LastName, ', ', s.FirstName, ' ', COALESCE(s.MiddleName, '')) AS FullName,
                        s.Email,
                        s.AccountStatus
                    FROM student s
                    LEFT JOIN section sec ON s.SectionID = sec.SectionID
                    LEFT JOIN course c ON sec.CourseID = c.CourseID
                    WHERE s.AccountStatus <> 'Pending'
                      AND (@deptId = 0 OR c.DepartmentID = @deptId)
                      AND (@courseId = 0 OR c.CourseID = @courseId)
                      AND (@sectionId = 0 OR sec.SectionID = @sectionId)
                      AND (
                            @search = '' OR
                            s.StudentNumber LIKE CONCAT('%', @search, '%') OR
                            s.FirstName LIKE CONCAT('%', @search, '%') OR
                            s.LastName LIKE CONCAT('%', @search, '%') OR
                            s.Email LIKE CONCAT('%', @search, '%')
                      )
                    ORDER BY s.LastName, s.FirstName;", conn)

                    cmd.Parameters.AddWithValue("@deptId", deptId)
                    cmd.Parameters.AddWithValue("@courseId", courseId)
                    cmd.Parameters.AddWithValue("@sectionId", sectionId)
                    cmd.Parameters.AddWithValue("@search", search)

                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dgvManageStudents.DataSource = dt
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading student accounts: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMSSearch_Click(sender As Object, e As EventArgs) Handles btnMSSearch.Click
        LoadManageStudents()
    End Sub

    Private Sub dgvManageStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvManageStudents.CellContentClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvManageStudents.Rows(e.RowIndex)
        Dim colName As String = dgvManageStudents.Columns(e.ColumnIndex).Name

        Dim studentId As Integer = CInt(row.Cells("colStudentID").Value)
        Dim studentNumber As String = row.Cells("colStudentNumber").Value.ToString()
        Dim fullName As String = row.Cells("colFullName").Value.ToString()
        Dim currentAccountStatus As String = row.Cells("colAccountStatus").Value.ToString()

        If colName = "colEdit" Then
            EditStudentContactInfo(studentId, fullName, studentNumber)

        ElseIf colName = "colReset" Then
            ResetStudentPassword(studentId, fullName, studentNumber)

        ElseIf colName = "colActivate" Then
            ActivateStudent(studentId, fullName, studentNumber, currentAccountStatus)

        ElseIf colName = "colDeactivate" Then
            DeactivateStudent(studentId, fullName, studentNumber, currentAccountStatus)
        End If
    End Sub

    Private Sub EditStudentContactInfo(studentId As Integer, fullName As String, studentNumber As String)
        Dim email As String = ""
        Dim contact As String = ""
        Dim address As String = ""
        Dim city As String = ""

        '===========================
        ' LOAD CURRENT STUDENT DATA
        '===========================
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                SELECT Email, ContactNumber, Address, City
                FROM student
                WHERE StudentID = @sid
                LIMIT 1;", conn)

                    cmd.Parameters.AddWithValue("@sid", studentId)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            email = dr("Email").ToString()
                            contact = dr("ContactNumber").ToString()
                            address = dr("Address").ToString()
                            city = dr("City").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading student info: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        '===========================
        ' EMAIL — LOOP VALIDATION
        '===========================
        Dim newEmail As String =
        PromptBox("Update Email:", $"{fullName} ({studentNumber})", email,
                  AddressOf ValidateEmail)

        If newEmail = "__CANCEL__" Then Return

        '===========================
        ' CONTACT NUMBER — LOOP VALIDATION
        '===========================
        Dim newContact As String =
        PromptBox("Update Contact Number (must start with 09 and be 11 digits):",
                  $"{fullName} ({studentNumber})",
                  contact,
                  AddressOf ValidateContact)

        If newContact = "__CANCEL__" Then Return

        '===========================
        ' ADDRESS (NO VALIDATION)
        '===========================
        Dim newAddress As String =
        PromptBox("Update Address:", $"{fullName} ({studentNumber})",
                  address,
                  Function(x) "")

        If newAddress = "__CANCEL__" Then Return

        '===========================
        ' CITY (NO VALIDATION)
        '===========================
        Dim newCity As String =
        PromptBox("Update City:", $"{fullName} ({studentNumber})",
                  city,
                  Function(x) "")

        If newCity = "__CANCEL__" Then Return

        '===========================
        ' APPLY UPDATE
        '===========================
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                UPDATE student
                SET Email = @e,
                    ContactNumber = @c,
                    Address = @a,
                    City = @city,
                    UpdatedAt = NOW()
                WHERE StudentID = @sid;", conn)

                    cmd.Parameters.AddWithValue("@e", newEmail)
                    cmd.Parameters.AddWithValue("@c", newContact)
                    cmd.Parameters.AddWithValue("@a", If(newAddress = "", CType(DBNull.Value, Object), newAddress))
                    cmd.Parameters.AddWithValue("@city", If(newCity = "", CType(DBNull.Value, Object), newCity))
                    cmd.Parameters.AddWithValue("@sid", studentId)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Student information updated.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadManageStudents()

        Catch ex As Exception
            MessageBox.Show("Error updating student info: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ResetStudentPassword(studentId As Integer, fullName As String, studentNumber As String)
        If MessageBox.Show(
        $"Reset password for {fullName} ({studentNumber}) to default 'student123'?",
        "Confirm Password Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) <> DialogResult.Yes Then Return

        Dim approverId As Integer = GetCurrentRegistrarId()

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using tx As MySqlTransaction = conn.BeginTransaction()

                    Using cmd As New MySqlCommand("
                    UPDATE student
                    SET Password = 'student123',
                        UpdatedAt = NOW()
                    WHERE StudentID = @sid;", conn, tx)

                        cmd.Parameters.AddWithValue("@sid", studentId)
                        cmd.ExecuteNonQuery()
                    End Using

                    Using cmdLog As New MySqlCommand("
                    INSERT INTO account_logs (UserType, UserID, Action, LogDate)
                    VALUES ('Registrar', @rid, @action, NOW());", conn, tx)

                        Dim actionText =
                        $"Reset password for student {fullName} ({studentNumber})."

                        cmdLog.Parameters.AddWithValue("@rid", approverId)
                        cmdLog.Parameters.AddWithValue("@action", actionText)
                        cmdLog.ExecuteNonQuery()
                    End Using

                    tx.Commit()
                End Using
            End Using

            MessageBox.Show("Password reset successfully.")

        Catch ex As Exception
            MessageBox.Show("Error resetting password: " & ex.Message)
        End Try
    End Sub


    Private Sub ActivateStudent(studentId As Integer, fullName As String, studentNumber As String, currentAccountStatus As String)
        If currentAccountStatus = "Active" Then
            MessageBox.Show("This student is already active.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim approverId As Integer = GetCurrentRegistrarId()

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using tx As MySqlTransaction = conn.BeginTransaction()

                    Using cmd As New MySqlCommand("
                    UPDATE student
                    SET AccountStatus = 'Active',
                        RejectionReason = NULL,
                        ApprovedByRegistrarID = @rid,
                        ApprovalDate = NOW(),
                        UpdatedAt = NOW()
                    WHERE StudentID = @sid;", conn, tx)

                        cmd.Parameters.AddWithValue("@rid", approverId)
                        cmd.Parameters.AddWithValue("@sid", studentId)
                        cmd.ExecuteNonQuery()
                    End Using

                    Using cmdLog As New MySqlCommand("
                    INSERT INTO account_logs (UserType, UserID, Action, LogDate)
                    VALUES ('Registrar', @rid, @action, NOW());", conn, tx)

                        Dim actionText As String =
                        $"Activated student account: {fullName} ({studentNumber})"

                        cmdLog.Parameters.AddWithValue("@rid", approverId)
                        cmdLog.Parameters.AddWithValue("@action", actionText)
                        cmdLog.ExecuteNonQuery()
                    End Using

                    tx.Commit()
                End Using
            End Using

            MessageBox.Show("Student account activated.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadManageStudents()

        Catch ex As Exception
            MessageBox.Show("Error activating student: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub DeactivateStudent(studentId As Integer, fullName As String, studentNumber As String, currentAccountStatus As String)
        If currentAccountStatus = "Inactive" Then
            MessageBox.Show("This student is already inactive.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim approverId As Integer = GetCurrentRegistrarId()

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using tx As MySqlTransaction = conn.BeginTransaction()

                    Using cmd As New MySqlCommand("
                    UPDATE student
                    SET AccountStatus = 'Inactive',
                        RejectionReason = 'Deactivated by registrar',
                        UpdatedAt = NOW()
                    WHERE StudentID = @sid;", conn, tx)

                        cmd.Parameters.AddWithValue("@sid", studentId)
                        cmd.ExecuteNonQuery()
                    End Using

                    Using cmdLog As New MySqlCommand("
                    INSERT INTO account_logs (UserType, UserID, Action, LogDate)
                    VALUES ('Registrar', @rid, @action, NOW());", conn, tx)

                        Dim actionText As String =
                        $"Deactivated student account: {fullName} ({studentNumber})"

                        cmdLog.Parameters.AddWithValue("@rid", approverId)
                        cmdLog.Parameters.AddWithValue("@action", actionText)
                        cmdLog.ExecuteNonQuery()
                    End Using

                    tx.Commit()
                End Using
            End Using

            MessageBox.Show("Student account deactivated.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadManageStudents()

        Catch ex As Exception
            MessageBox.Show("Error deactivating student: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    '==========================================
    ' MANAGE FACULTY ACCOUNTS (PANEL 5)
    '==========================================

    ' ---------- FILTER LOADERS ----------
    Private Sub LoadMFDepartments()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                SELECT DepartmentID, DepartmentName
                FROM department
                WHERE IsActive = 1
                ORDER BY DepartmentName;", conn)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(dr)

                        Dim rowAll As DataRow = dt.NewRow()
                        rowAll("DepartmentID") = 0
                        rowAll("DepartmentName") = "All Departments"
                        dt.Rows.InsertAt(rowAll, 0)

                        cboMFDepartment.DataSource = dt
                        cboMFDepartment.DisplayMember = "DepartmentName"
                        cboMFDepartment.ValueMember = "DepartmentID"
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading faculty departments: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadMFPositions()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                SELECT DISTINCT PositionTitle AS Position
                FROM faculty
                WHERE PositionTitle IS NOT NULL AND PositionTitle <> ''
                ORDER BY PositionTitle;", conn)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(dr)

                        Dim rowAll As DataRow = dt.NewRow()
                        rowAll("Position") = "All Positions"
                        dt.Rows.InsertAt(rowAll, 0)

                        cboMFPosition.DataSource = dt
                        cboMFPosition.DisplayMember = "Position"
                        cboMFPosition.ValueMember = "Position"
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading positions: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadMFSections(departmentId As Integer)
        ' filter sections by department THROUGH course table (section has only CourseID)
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                SELECT s.SectionID, s.SectionName
                FROM section s
                INNER JOIN course c ON s.CourseID = c.CourseID
                WHERE s.IsActive = 1
                  AND (@deptId = 0 OR c.DepartmentID = @deptId)
                ORDER BY s.SectionName;", conn)

                    cmd.Parameters.AddWithValue("@deptId", departmentId)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(dr)

                        Dim rowAll As DataRow = dt.NewRow()
                        rowAll("SectionID") = 0
                        rowAll("SectionName") = "All Sections"
                        dt.Rows.InsertAt(rowAll, 0)

                        cboMFSection1.DataSource = dt.Copy()
                        cboMFSection1.DisplayMember = "SectionName"
                        cboMFSection1.ValueMember = "SectionID"
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading faculty sections: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboMFDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMFDepartment.SelectedIndexChanged
        Dim deptId As Integer = 0
        If cboMFDepartment.SelectedValue IsNot Nothing Then
            Integer.TryParse(cboMFDepartment.SelectedValue.ToString(), deptId)
        End If

        LoadMFSections(deptId)
        LoadManageFaculty()
    End Sub

    Private Sub cboMFPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMFPosition.SelectedIndexChanged
        LoadManageFaculty()
    End Sub

    Private Sub cboMFSection1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMFSection1.SelectedIndexChanged
        LoadManageFaculty()
    End Sub

    ' ---------- GRID CONFIG ----------
    Private Sub ConfigureManageFacultyGrid()
        If dgvManageFaculty.Columns.Count > 0 Then
            Return
        End If

        dgvManageFaculty.AutoGenerateColumns = False
        dgvManageFaculty.Columns.Clear()

        dgvManageFaculty.Columns.Add(New DataGridViewTextBoxColumn() With {
        .Name = "colFacultyID",
        .DataPropertyName = "FacultyID",
        .Visible = False
    })

        dgvManageFaculty.Columns.Add(New DataGridViewTextBoxColumn() With {
        .Name = "colEmployeeNumber",
        .HeaderText = "Faculty No",
        .DataPropertyName = "EmployeeNumber"
    })

        dgvManageFaculty.Columns.Add(New DataGridViewTextBoxColumn() With {
        .Name = "colFullName",
        .HeaderText = "Name",
        .DataPropertyName = "FullName"
    })

        dgvManageFaculty.Columns.Add(New DataGridViewTextBoxColumn() With {
        .Name = "colDepartment",
        .HeaderText = "Department",
        .DataPropertyName = "DepartmentName"
    })

        dgvManageFaculty.Columns.Add(New DataGridViewTextBoxColumn() With {
        .Name = "colSection1",
        .HeaderText = "Section 1",
        .DataPropertyName = "Section1Name"
    })

        dgvManageFaculty.Columns.Add(New DataGridViewTextBoxColumn() With {
        .Name = "colSection2",
        .HeaderText = "Section 2",
        .DataPropertyName = "Section2Name"
    })

        dgvManageFaculty.Columns.Add(New DataGridViewTextBoxColumn() With {
        .Name = "colStatus",
        .HeaderText = "Status",
        .DataPropertyName = "Status"
    })

        dgvManageFaculty.Columns.Add(New DataGridViewButtonColumn() With {
        .Name = "colEdit",
        .HeaderText = "Edit",
        .Text = "Edit",
        .UseColumnTextForButtonValue = True
    })

        dgvManageFaculty.Columns.Add(New DataGridViewButtonColumn() With {
        .Name = "colReset",
        .HeaderText = "Reset PW",
        .Text = "Reset",
        .UseColumnTextForButtonValue = True
    })

        dgvManageFaculty.Columns.Add(New DataGridViewButtonColumn() With {
        .Name = "colActivate",
        .HeaderText = "Activate",
        .Text = "✔",
        .UseColumnTextForButtonValue = True
    })

        dgvManageFaculty.Columns.Add(New DataGridViewButtonColumn() With {
        .Name = "colDeactivate",
        .HeaderText = "Deactivate",
        .Text = "🛑",
        .UseColumnTextForButtonValue = True
    })
    End Sub

    ' ---------- MAIN LOAD ----------
    Private Sub LoadManageFaculty()
        Dim search As String = txtMFSearch.Text.Trim()

        Dim deptId As Integer = 0
        Dim sectionId As Integer = 0
        Dim position As String = ""

        If cboMFDepartment.SelectedValue IsNot Nothing Then
            Integer.TryParse(cboMFDepartment.SelectedValue.ToString(), deptId)
        End If

        If cboMFSection1.SelectedValue IsNot Nothing Then
            Integer.TryParse(cboMFSection1.SelectedValue.ToString(), sectionId)
        End If

        If cboMFPosition.SelectedValue IsNot Nothing Then
            position = cboMFPosition.SelectedValue.ToString()
            If position = "All Positions" Then position = ""
        End If

        Dim sectionFilterId As Integer = sectionId   'single only

        Try
            ConfigureManageFacultyGrid()

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                SELECT 
                    f.FacultyID,
                    f.EmployeeNumber,
                    CONCAT(f.LastName, ', ', f.FirstName, ' ', COALESCE(f.MiddleName, '')) AS FullName,
                    d.DepartmentName,
                    s1.SectionName AS Section1Name,
                    s2.SectionName AS Section2Name,
                    f.Status
                FROM faculty f
                LEFT JOIN department d ON f.DepartmentID = d.DepartmentID
                LEFT JOIN (
                    SELECT fs.FacultyID,
                           MIN(fs.SectionID) AS SectionID1,
                           NULLIF(MAX(fs.SectionID), MIN(fs.SectionID)) AS SectionID2
                    FROM faculty_section fs
                    GROUP BY fs.FacultyID
                ) fsagg ON fsagg.FacultyID = f.FacultyID
                LEFT JOIN section s1 ON s1.SectionID = fsagg.SectionID1
                LEFT JOIN section s2 ON s2.SectionID = fsagg.SectionID2
                WHERE f.Status <> 'Pending'
                  AND (@deptId = 0 OR f.DepartmentID = @deptId)
                  AND (@position = '' OR f.PositionTitle = @position)
                  AND (
                        @sectionId = 0 OR
                        EXISTS (
                            SELECT 1 FROM faculty_section fsf
                            WHERE fsf.FacultyID = f.FacultyID
                              AND fsf.SectionID = @sectionId
                        )
                      )
                  AND (
                        @search = '' OR
                        f.EmployeeNumber LIKE CONCAT('%', @search, '%') OR
                        f.FirstName LIKE CONCAT('%', @search, '%') OR
                        f.LastName LIKE CONCAT('%', @search, '%')
                      )
                ORDER BY f.LastName, f.FirstName;", conn)

                    cmd.Parameters.AddWithValue("@deptId", deptId)
                    cmd.Parameters.AddWithValue("@position", position)
                    cmd.Parameters.AddWithValue("@sectionId", sectionFilterId)
                    cmd.Parameters.AddWithValue("@search", search)

                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dgvManageFaculty.DataSource = dt
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading faculty accounts: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMFSearch_Click(sender As Object, e As EventArgs) Handles btnMFSearch.Click
        LoadManageFaculty()
    End Sub

    ' ---------- GRID CLICK HANDLER ----------
    Private Sub dgvManageFaculty_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvManageFaculty.CellContentClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Return

        Dim row As DataGridViewRow = dgvManageFaculty.Rows(e.RowIndex)
        Dim colName As String = dgvManageFaculty.Columns(e.ColumnIndex).Name

        Dim facultyId As Integer = CInt(row.Cells("colFacultyID").Value)
        Dim empNum As String = row.Cells("colEmployeeNumber").Value.ToString()
        Dim fullName As String = row.Cells("colFullName").Value.ToString()
        Dim currentStatus As String = row.Cells("colStatus").Value.ToString()

        If colName = "colEdit" Then
            EditFacultyInfo(facultyId, fullName, empNum)

        ElseIf colName = "colReset" Then
            ResetFacultyPassword(facultyId, fullName, empNum)

        ElseIf colName = "colActivate" Then
            ActivateFaculty(facultyId, fullName, empNum, currentStatus)

        ElseIf colName = "colDeactivate" Then
            DeactivateFaculty(facultyId, fullName, empNum, currentStatus)
        End If
    End Sub

    ' ---------- EDIT FACULTY (CONTACT + SECTIONS) ----------
    Private Sub EditFacultyInfo(facultyId As Integer, fullName As String, empNum As String)
        Dim email As String = ""
        Dim contact As String = ""
        Dim deptId As Integer = 0

        ' Current sections
        Dim oldSec1 As Integer = 0
        Dim oldSec2 As Integer = 0

        ' Load current faculty data
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                ' Basic info
                Using cmd As New MySqlCommand("
                SELECT Email, ContactNumber, DepartmentID
                FROM faculty
                WHERE FacultyID = @fid
                LIMIT 1;", conn)

                    cmd.Parameters.AddWithValue("@fid", facultyId)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            email = dr("Email").ToString()
                            contact = dr("ContactNumber").ToString()
                            Integer.TryParse(dr("DepartmentID").ToString(), deptId)
                        End If
                    End Using
                End Using

                ' Load current assigned sections (max 2)
                Using cmdSec As New MySqlCommand("
                SELECT SectionID
                FROM faculty_section
                WHERE FacultyID = @fid
                ORDER BY SectionID
                LIMIT 2;", conn)

                    cmdSec.Parameters.AddWithValue("@fid", facultyId)

                    Using dr As MySqlDataReader = cmdSec.ExecuteReader()
                        If dr.Read() Then Integer.TryParse(dr("SectionID").ToString(), oldSec1)
                        If dr.Read() Then Integer.TryParse(dr("SectionID").ToString(), oldSec2)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading faculty info: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' Load valid sections for this department
        Dim availableSections As New List(Of String)()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                SELECT s.SectionName
                FROM section s
                INNER JOIN course c ON c.CourseID = s.CourseID
                WHERE c.DepartmentID = @dept
                  AND s.IsActive = 1
                  AND (
                        NOT EXISTS (
                            SELECT 1 
                            FROM faculty_section fs
                            WHERE fs.SectionID = s.SectionID
                              AND fs.FacultyID <> @fid   -- assigned to another faculty → block
                        )
                      )
                ORDER BY s.SectionName;
                ", conn)

                    cmd.Parameters.AddWithValue("@dept", deptId)
                    cmd.Parameters.AddWithValue("@fid", facultyId)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        While dr.Read()
                            availableSections.Add(dr("SectionName").ToString())
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading sections: " & ex.Message)
            Return
        End Try

        ' Prepare default section text (you can improve this later if you want exact mapping)
        Dim defaultSectionText As String = ""
        If oldSec1 <> 0 OrElse oldSec2 <> 0 Then
            ' just leave empty or you can manually map names later
            defaultSectionText = ""
        End If

        ' 1) Email
        Dim newEmail As String =
        PromptBox("Update Email:", $"{fullName} ({empNum})", email,
                  AddressOf ValidateEmail)
        If newEmail = "__CANCEL__" Then Return

        ' 2) Contact number
        Dim newContact As String =
        PromptBox("Update Contact Number (must start with 09 and be 11 digits):",
                  $"{fullName} ({empNum})",
                  contact,
                  AddressOf ValidateContact)
        If newContact = "__CANCEL__" Then Return

        ' 3) Sections input
        Dim newSectionString As String =
        PromptBox("Assign up to 2 SECTION NAMES (comma-separated):" &
                  vbCrLf & "Available Sections:" &
                  vbCrLf & "• " & String.Join(vbCrLf & "• ", availableSections),
                  $"{fullName} ({empNum})",
                  defaultSectionText,
                  Function(x) ValidateSectionNames(x, availableSections))

        If newSectionString = "__CANCEL__" Then Return

        ' Parse sections
        Dim selectedNames = newSectionString.Split(","c).
        Select(Function(x) x.Trim()).
        Where(Function(x) x <> "").ToList()

        Dim newSecName1 As String = If(selectedNames.Count >= 1, selectedNames(0), Nothing)
        Dim newSecName2 As String = If(selectedNames.Count >= 2, selectedNames(1), Nothing)

        ' Convert to SectionID
        Dim newSec1 As Integer = 0
        Dim newSec2 As Integer = 0

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                If newSecName1 IsNot Nothing Then
                    Using cmd As New MySqlCommand("
                    SELECT SectionID
                    FROM section
                    WHERE SectionName = @n
                    LIMIT 1;", conn)
                        cmd.Parameters.AddWithValue("@n", newSecName1)
                        newSec1 = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using
                End If

                If newSecName2 IsNot Nothing Then
                    Using cmd As New MySqlCommand("
                    SELECT SectionID
                    FROM section
                    WHERE SectionName = @n
                    LIMIT 1;", conn)
                        cmd.Parameters.AddWithValue("@n", newSecName2)
                        newSec2 = Convert.ToInt32(cmd.ExecuteScalar())
                    End Using
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error verifying section assignment: " & ex.Message)
            Return
        End Try

        ' Apply changes
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using tx As MySqlTransaction = conn.BeginTransaction()

                    ' Update email + contact
                    Using cmd As New MySqlCommand("
                    UPDATE faculty
                    SET Email = @e,
                        ContactNumber = @c,
                        UpdatedAt = NOW()
                    WHERE FacultyID = @fid;", conn, tx)

                        cmd.Parameters.AddWithValue("@e", newEmail)
                        cmd.Parameters.AddWithValue("@c", newContact)
                        cmd.Parameters.AddWithValue("@fid", facultyId)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Remove previous section assignments
                    Using cmdDel As New MySqlCommand("
                    DELETE FROM faculty_section
                    WHERE FacultyID = @fid;", conn, tx)
                        cmdDel.Parameters.AddWithValue("@fid", facultyId)
                        cmdDel.ExecuteNonQuery()
                    End Using

                    ' Add new sections
                    If newSec1 <> 0 Then
                        Using cmdIns As New MySqlCommand("
                        INSERT INTO faculty_section (FacultyID, SectionID)
                        VALUES (@fid, @s1);", conn, tx)
                            cmdIns.Parameters.AddWithValue("@fid", facultyId)
                            cmdIns.Parameters.AddWithValue("@s1", newSec1)
                            cmdIns.ExecuteNonQuery()
                        End Using
                    End If

                    If newSec2 <> 0 AndAlso newSec2 <> newSec1 Then
                        Using cmdIns As New MySqlCommand("
                        INSERT INTO faculty_section (FacultyID, SectionID)
                        VALUES (@fid, @s2);", conn, tx)
                            cmdIns.Parameters.AddWithValue("@fid", facultyId)
                            cmdIns.Parameters.AddWithValue("@s2", newSec2)
                            cmdIns.ExecuteNonQuery()
                        End Using
                    End If

                    ' Log action AS REGISTRAR
                    Dim registrarId As Integer = GetCurrentRegistrarId()

                    Using cmdLog As New MySqlCommand("
                    INSERT INTO account_logs (UserType, UserID, Action, LogDate)
                    VALUES ('Registrar', @rid, @action, NOW());", conn, tx)

                        Dim actionText As String =
                        $"Updated faculty info & sections for {fullName} ({empNum})."

                        cmdLog.Parameters.AddWithValue("@rid", registrarId)
                        cmdLog.Parameters.AddWithValue("@action", actionText)
                        cmdLog.ExecuteNonQuery()
                    End Using

                    tx.Commit()
                End Using
            End Using

            MessageBox.Show("Faculty information updated successfully.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadManageFaculty()

        Catch ex As Exception
            MessageBox.Show("Error updating faculty info: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ---------- HELPER INPUT FUNCTIONS ----------
    Private Function PromptBox(prompt As String, title As String, defaultValue As String,
                           validator As Func(Of String, String)) As String

        Dim value As String = defaultValue

        Do
            Dim result As String = InputBox(prompt, title, value)

            ' CANCEL or X
            If result = "" Then Return "__CANCEL__"

            ' Validate input
            Dim msg As String = validator(result)

            If msg = "" Then
                Return result  ' valid
            End If

            MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            value = result   ' keep their last typed value

        Loop
    End Function

    Private Function ValidateContact(input As String) As String
        input = New String(input.Where(Function(c) Char.IsDigit(c)).ToArray())

        If Not input.StartsWith("09") Then
            Return "Contact number must start with '09'."
        End If

        If input.Length <> 11 Then
            Return "Contact number must be exactly 11 digits."
        End If

        Return ""  ' valid
    End Function

    Private Function ValidateEmail(input As String) As String
        If Not input.Contains("@") OrElse Not input.Contains(".") Then
            Return "Invalid email format."
        End If
        Return ""
    End Function

    Private Function ValidateSectionNames(input As String, available As List(Of String)) As String
        Dim parts = input.Split(","c).
        Select(Function(x) x.Trim()).
        Where(Function(x) x <> "").ToList()

        If parts.Count > 2 Then Return "You can only assign up to 2 sections."
        If parts.Count = 2 AndAlso parts(0).ToLower() = parts(1).ToLower() Then
            Return "Duplicate section names are not allowed."
        End If

        For Each sec In parts
            If Not available.Any(Function(a) a.Equals(sec, StringComparison.OrdinalIgnoreCase)) Then
                Return $"Section '{sec}' does not exist or is not in this department."
            End If
        Next

        Return ""
    End Function

    ' ---------- RESET FACULTY PASSWORD ----------
    Private Sub ResetFacultyPassword(facultyId As Integer, fullName As String, empNum As String)
        Dim result = MessageBox.Show(
        $"Reset password for {fullName} ({empNum}) to default 'faculty123'?",
        "Confirm Password Reset",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning)

        If result <> DialogResult.Yes Then Return

        Dim newPassword As String = "faculty123"
        Dim registrarId As Integer = GetCurrentRegistrarId()

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using tx As MySqlTransaction = conn.BeginTransaction()

                    Using cmd As New MySqlCommand("
                    UPDATE faculty
                    SET Password = @pw,
                        UpdatedAt = NOW()
                    WHERE FacultyID = @fid;", conn, tx)

                        cmd.Parameters.AddWithValue("@pw", newPassword)
                        cmd.Parameters.AddWithValue("@fid", facultyId)
                        cmd.ExecuteNonQuery()
                    End Using

                    Using cmdLog As New MySqlCommand("
                    INSERT INTO account_logs (UserType, UserID, Action, LogDate)
                    VALUES ('Registrar', @rid, @action, NOW());", conn, tx)

                        Dim actionText As String =
                        $"Reset password for faculty {fullName} ({empNum}) to default password."

                        cmdLog.Parameters.AddWithValue("@rid", registrarId)
                        cmdLog.Parameters.AddWithValue("@action", actionText)
                        cmdLog.ExecuteNonQuery()
                    End Using

                    tx.Commit()
                End Using
            End Using

            MessageBox.Show("Faculty password reset successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error resetting faculty password: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ---------- ACTIVATE FACULTY ----------
    Private Sub ActivateFaculty(facultyId As Integer, fullName As String, empNum As String, currentStatus As String)
        If String.Equals(currentStatus, "Active", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("This faculty account is already active.",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
            Return
        End If

        Dim result = MessageBox.Show(
        $"Activate this faculty account?" & Environment.NewLine &
        $"{fullName} ({empNum})",
        "Confirm Activation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If result <> DialogResult.Yes Then Return

        Dim approverId As Integer = GetCurrentRegistrarId()

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using tx As MySqlTransaction = conn.BeginTransaction()

                    Using cmd As New MySqlCommand("
                    UPDATE faculty
                    SET Status = 'Active',
                        RejectionReason = NULL,
                        ApprovedByRegistrarID = @rid,
                        ApprovalDate = NOW(),
                        UpdatedAt = NOW()
                    WHERE FacultyID = @fid;", conn, tx)

                        cmd.Parameters.AddWithValue("@rid", approverId)
                        cmd.Parameters.AddWithValue("@fid", facultyId)
                        cmd.ExecuteNonQuery()
                    End Using

                    Using cmdLog As New MySqlCommand("
                    INSERT INTO account_logs (UserType, UserID, Action, LogDate)
                    VALUES ('Registrar', @rid, @action, NOW());", conn, tx)

                        Dim actionText As String =
                        $"Activated faculty account: {fullName} ({empNum})"

                        cmdLog.Parameters.AddWithValue("@rid", approverId)
                        cmdLog.Parameters.AddWithValue("@action", actionText)
                        cmdLog.ExecuteNonQuery()
                    End Using

                    tx.Commit()
                End Using
            End Using

            MessageBox.Show("Faculty account activated.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
            LoadManageFaculty()

        Catch ex As Exception
            MessageBox.Show("Error activating faculty: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ---------- DEACTIVATE FACULTY ----------
    Private Sub DeactivateFaculty(facultyId As Integer, fullName As String, empNum As String, currentStatus As String)
        If String.Equals(currentStatus, "Inactive", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("This faculty account is already inactive.",
                        "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
            Return
        End If

        Dim result = MessageBox.Show(
        $"Deactivate this faculty account?" & Environment.NewLine &
        $"{fullName} ({empNum})",
        "Confirm Deactivation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning)

        If result <> DialogResult.Yes Then Return

        Dim registrarId As Integer = GetCurrentRegistrarId()

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using tx As MySqlTransaction = conn.BeginTransaction()

                    Using cmd As New MySqlCommand("
                    UPDATE faculty
                    SET Status = 'Inactive',
                        RejectionReason = 'Deactivated by registrar',
                        UpdatedAt = NOW()
                    WHERE FacultyID = @fid;", conn, tx)

                        cmd.Parameters.AddWithValue("@fid", facultyId)
                        cmd.ExecuteNonQuery()
                    End Using

                    Using cmdLog As New MySqlCommand("
                    INSERT INTO account_logs (UserType, UserID, Action, LogDate)
                    VALUES ('Registrar', @rid, @action, NOW());", conn, tx)

                        Dim actionText As String =
                        $"Deactivated faculty account: {fullName} ({empNum})"

                        cmdLog.Parameters.AddWithValue("@rid", registrarId)
                        cmdLog.Parameters.AddWithValue("@action", actionText)
                        cmdLog.ExecuteNonQuery()
                    End Using

                    tx.Commit()
                End Using
            End Using

            MessageBox.Show("Faculty account deactivated.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
            LoadManageFaculty()

        Catch ex As Exception
            MessageBox.Show("Error deactivating faculty: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    '==========================================
    ' OFFICIAL SCHOOL LIST (PANEL 6)
    '   Uses official_student_list + department/course/section
    '==========================================

    '---------- FILTER LOADERS ----------

    Private Sub LoadOSLDepartments()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                SELECT DepartmentID, DepartmentName
                FROM department
                WHERE IsActive = 1
                ORDER BY DepartmentName;", conn)

                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())

                    Dim rowAll As DataRow = dt.NewRow()
                    rowAll("DepartmentID") = 0
                    rowAll("DepartmentName") = "All Departments"
                    dt.Rows.InsertAt(rowAll, 0)

                    cboOSDepartment.DataSource = dt
                    cboOSDepartment.DisplayMember = "DepartmentName"
                    cboOSDepartment.ValueMember = "DepartmentID"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading OSL departments: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' Reset children
        cboOSCourse.DataSource = Nothing
        cboOSSection.DataSource = Nothing
    End Sub

    Private Sub LoadOSLCourses(departmentId As Integer)
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                SELECT CourseID, CourseCode
                FROM course
                WHERE IsActive = 1
                  AND (@deptId = 0 OR DepartmentID = @deptId)
                ORDER BY CourseCode;", conn)

                    cmd.Parameters.AddWithValue("@deptId", departmentId)

                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())

                    Dim rowAll As DataRow = dt.NewRow()
                    rowAll("CourseID") = 0
                    rowAll("CourseCode") = "All Courses"
                    dt.Rows.InsertAt(rowAll, 0)

                    cboOSCourse.DataSource = dt
                    cboOSCourse.DisplayMember = "CourseCode"
                    cboOSCourse.ValueMember = "CourseID"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading OSL courses: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        cboOSSection.DataSource = Nothing
    End Sub

    Private Sub LoadOSLSections(courseId As Integer)
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                SELECT SectionID, SectionName
                FROM section
                WHERE IsActive = 1
                  AND (@courseId = 0 OR CourseID = @courseId)
                ORDER BY SectionName;", conn)

                    cmd.Parameters.AddWithValue("@courseId", courseId)

                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())

                    Dim rowAll As DataRow = dt.NewRow()
                    rowAll("SectionID") = 0
                    rowAll("SectionName") = "All Sections"
                    dt.Rows.InsertAt(rowAll, 0)

                    cboOSSection.DataSource = dt
                    cboOSSection.DisplayMember = "SectionName"
                    cboOSSection.ValueMember = "SectionID"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading OSL sections: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '---------- FILTER EVENTS ----------

    Private Sub cboOSDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOSDepartment.SelectedIndexChanged
        Dim deptId = 0
        If cboOSDepartment.SelectedValue IsNot Nothing Then
            Integer.TryParse(cboOSDepartment.SelectedValue.ToString, deptId)
        End If

        LoadOSLCourses(deptId)
        LoadOfficialStudentList()
    End Sub

    Private Sub cboOSCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOSCourse.SelectedIndexChanged
        Dim courseId = 0
        If cboOSCourse.SelectedValue IsNot Nothing Then
            Integer.TryParse(cboOSCourse.SelectedValue.ToString, courseId)
        End If

        LoadOSLSections(courseId)
        LoadOfficialStudentList()
    End Sub

    Private Sub cboOSSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOSSection.SelectedIndexChanged
        LoadOfficialStudentList()
    End Sub

    '---------- GRID CONFIG ----------

    Private Sub ConfigureOfficialStudentGrid()
        If dgvOfficialStudents.Columns.Count > 0 Then Return

        dgvOfficialStudents.AutoGenerateColumns = False
        dgvOfficialStudents.Columns.Clear()

        dgvOfficialStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colOfficialID",
            .DataPropertyName = "OfficialID",
            .Visible = False
        })

        dgvOfficialStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colStudentNumber",
            .HeaderText = "Student No",
            .DataPropertyName = "StudentNumber"
        })

        dgvOfficialStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colFullName",
            .HeaderText = "Name",
            .DataPropertyName = "FullName"
        })

        dgvOfficialStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colCourse",
            .HeaderText = "Course",
            .DataPropertyName = "CourseCode"
        })

        dgvOfficialStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colSection",
            .HeaderText = "Section",
            .DataPropertyName = "SectionName"
        })

        dgvOfficialStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colRegistered",
            .HeaderText = "Registered?",
            .DataPropertyName = "IsRegistered"
        })
    End Sub

    '---------- MAIN LOAD ----------

    Private Sub LoadOfficialStudentList()
        Dim search As String = txtOSSearch.Text.Trim()

        Dim deptId As Integer = 0
        Dim courseId As Integer = 0
        Dim sectionId As Integer = 0

        If cboOSDepartment.SelectedValue IsNot Nothing Then
            Integer.TryParse(cboOSDepartment.SelectedValue.ToString(), deptId)
        End If

        If cboOSCourse.SelectedValue IsNot Nothing Then
            Integer.TryParse(cboOSCourse.SelectedValue.ToString(), courseId)
        End If

        If cboOSSection.SelectedValue IsNot Nothing Then
            Integer.TryParse(cboOSSection.SelectedValue.ToString(), sectionId)
        End If

        Try
            ConfigureOfficialStudentGrid()

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                SELECT 
                    osl.OfficialID,
                    osl.StudentNumber,
                    CONCAT(osl.LastName, ', ', osl.FirstName, ' ', COALESCE(osl.MiddleName, '')) AS FullName,
                    c.CourseCode,
                    sec.SectionName,
                    CASE WHEN s.StudentID IS NULL THEN 'No' ELSE 'Yes' END AS IsRegistered
                FROM official_student_list osl
                INNER JOIN course c  ON osl.CourseID = c.CourseID
                INNER JOIN section sec ON osl.SectionID = sec.SectionID
                LEFT JOIN student s ON s.StudentNumber = osl.StudentNumber
                WHERE (@deptId    = 0 OR osl.DepartmentID = @deptId)
                  AND (@courseId  = 0 OR osl.CourseID     = @courseId)
                  AND (@sectionId = 0 OR osl.SectionID    = @sectionId)
                  AND (
                        @search = '' OR
                        osl.StudentNumber LIKE CONCAT('%', @search, '%') OR
                        osl.LastName      LIKE CONCAT('%', @search, '%') OR
                        osl.FirstName     LIKE CONCAT('%', @search, '%')
                      )
                ORDER BY osl.LastName, osl.FirstName;", conn)

                    cmd.Parameters.AddWithValue("@deptId", deptId)
                    cmd.Parameters.AddWithValue("@courseId", courseId)
                    cmd.Parameters.AddWithValue("@sectionId", sectionId)
                    cmd.Parameters.AddWithValue("@search", search)

                    Dim dt As New DataTable()
                    Using da As New MySqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using

                    dgvOfficialStudents.DataSource = dt
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading official student list: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnOSSearch_Click(sender As Object, e As EventArgs) Handles btnOSSearch.Click
        LoadOfficialStudentList()
    End Sub

    Private Sub btnImportStudents_Click(sender As Object, e As EventArgs) Handles btnImportStudents.Click

        Dim ofd As New OpenFileDialog With {
        .Filter = "Excel Files|*.xlsx",
        .Title = "Import Official Student List"
    }

        If ofd.ShowDialog <> DialogResult.OK Then Exit Sub

        Dim dt = LoadExcelToDataTable(ofd.FileName)

        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            MessageBox.Show("Excel is empty or unreadable.", "Import Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim registrarId As Integer = CurrentUser.RegistrarID
        Dim importedCount As Integer = 0

        Try
            Using conn = GetConnection()
                conn.Open()

                Using tx = conn.BeginTransaction()

                    For Each row As DataRow In dt.Rows

                        Dim studNo = row("StudentNumber").ToString.Trim()
                        Dim last = row("LastName").ToString.Trim()
                        Dim first = row("FirstName").ToString.Trim()
                        Dim mid = row("MiddleName").ToString.Trim()
                        Dim courseCode = row("CourseCode").ToString.Trim()
                        Dim sectionName = row("SectionName").ToString.Trim()
                        Dim deptCode = row("DepartmentCode").ToString.Trim()
                        Dim gender = row("Gender").ToString.Trim()

                        ' BASIC VALIDATION
                        If studNo = "" Or last = "" Or first = "" Or courseCode = "" Or sectionName = "" Or deptCode = "" Then
                            Throw New Exception("Missing required fields in Excel.")
                        End If

                        ' LOOKUPS
                        Dim courseId = GetCourseIdByCode(courseCode, conn, tx)
                        Dim sectionId = GetSectionIdByName(sectionName, conn, tx)
                        Dim deptId = GetDepartmentIdByCode(deptCode, conn, tx)

                        ' INSERT
                        Using cmd As New MySqlCommand("
                        INSERT INTO official_student_list
                        (StudentNumber, LastName, FirstName, MiddleName,
                         CourseID, SectionID, DepartmentID, Gender)
                        VALUES
                        (@sn, @ln, @fn, @mn, @cid, @sid, @did, @g)
                    ", conn, tx)

                            cmd.Parameters.AddWithValue("@sn", studNo)
                            cmd.Parameters.AddWithValue("@ln", last)
                            cmd.Parameters.AddWithValue("@fn", first)
                            cmd.Parameters.AddWithValue("@mn", If(mid = "", DBNull.Value, mid))
                            cmd.Parameters.AddWithValue("@cid", courseId)
                            cmd.Parameters.AddWithValue("@sid", sectionId)
                            cmd.Parameters.AddWithValue("@did", deptId)
                            cmd.Parameters.AddWithValue("@g", gender)

                            cmd.ExecuteNonQuery()
                            importedCount += 1
                        End Using

                    Next

                    tx.Commit()
                End Using
            End Using

            ' LOG THE IMPORT
            Using conn = GetConnection()
                conn.Open()

                Dim logCmd As New MySqlCommand("
                INSERT INTO account_logs (UserType, UserID, Action, LogDate)
                VALUES('Registrar', @rid, @action, NOW());
            ", conn)

                logCmd.Parameters.AddWithValue("@rid", registrarId)
                logCmd.Parameters.AddWithValue("@action", $"Imported {importedCount} students into official_student_list")

                logCmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Student list imported successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadOfficialStudentList()

        Catch ex As Exception
            MessageBox.Show("Import failed: " & ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    '===========================================================
    ' OFFICIAL PROFESSOR LIST — CONFIGURE GRID
    '===========================================================
    Private Sub ConfigureOfficialProfessorGrid()
        If dgvOfficialProfessor.Columns.Count > 0 Then Exit Sub

        dgvOfficialProfessor.AutoGenerateColumns = False
        dgvOfficialProfessor.Columns.Clear()

        dgvOfficialProfessor.Columns.Add(New DataGridViewTextBoxColumn() With {
        .Name = "colEmployeeNumber",
        .HeaderText = "Faculty No",
        .DataPropertyName = "EmployeeNumber",
        .Width = 110
    })

        dgvOfficialProfessor.Columns.Add(New DataGridViewTextBoxColumn() With {
        .Name = "colFullName",
        .HeaderText = "Full Name",
        .DataPropertyName = "FullName",
        .Width = 200
    })

        dgvOfficialProfessor.Columns.Add(New DataGridViewTextBoxColumn() With {
        .Name = "colDepartment",
        .HeaderText = "Department",
        .DataPropertyName = "DepartmentCode",
        .Width = 120
    })

        dgvOfficialProfessor.Columns.Add(New DataGridViewTextBoxColumn() With {
        .Name = "colPosition",
        .HeaderText = "Position",
        .DataPropertyName = "PositionTitle",
        .Width = 150
    })

        dgvOfficialProfessor.Columns.Add(New DataGridViewTextBoxColumn() With {
        .Name = "colInSystem",
        .HeaderText = "In System?",
        .DataPropertyName = "InSystem",
        .Width = 90
    })
    End Sub

    '==========================================
    ' OFFICIAL PROFESSOR LIST (PANEL 7)
    '==========================================
    Private Sub LoadOPDepartments()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                SELECT DISTINCT DepartmentCode
                FROM official_professor_list
                ORDER BY DepartmentCode;", conn)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(dr)

                        Dim rowAll As DataRow = dt.NewRow()
                        rowAll("DepartmentCode") = "All Departments"
                        dt.Rows.InsertAt(rowAll, 0)

                        cboOPDepartment.DataSource = dt
                        cboOPDepartment.DisplayMember = "DepartmentCode"
                        cboOPDepartment.ValueMember = "DepartmentCode"
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading professor departments: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadOPPositions()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand("
                SELECT DISTINCT PositionTitle
                FROM official_professor_list
                ORDER BY PositionTitle;", conn)

                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(dr)

                        Dim rowAll As DataRow = dt.NewRow()
                        rowAll("PositionTitle") = "All Positions"
                        dt.Rows.InsertAt(rowAll, 0)

                        cboOPPosition.DataSource = dt
                        cboOPPosition.DisplayMember = "PositionTitle"
                        cboOPPosition.ValueMember = "PositionTitle"
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading professor positions: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadOfficialProfessorList()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim dept As String = ""
                If cboOPDepartment.SelectedValue IsNot Nothing Then
                    dept = cboOPDepartment.SelectedValue.ToString()
                    If dept = "All Departments" Then dept = ""
                End If

                Dim position As String = ""
                If cboOPPosition.SelectedValue IsNot Nothing Then
                    position = cboOPPosition.SelectedValue.ToString()
                    If position = "All Positions" Then position = ""
                End If

                Dim search As String = txtOPSearch.Text.Trim()

                Dim query As String =
            "SELECT 
                 opl.EmployeeNumber,
                 CONCAT(opl.LastName, ', ', opl.FirstName, ' ', COALESCE(opl.MiddleName, '')) AS FullName,
                 opl.DepartmentCode,
                 opl.PositionTitle,
                 CASE
                     WHEN f.FacultyID IS NOT NULL THEN 'Yes'
                     ELSE 'No'
                 END AS InSystem
             FROM official_professor_list opl
             LEFT JOIN faculty f 
                 ON f.EmployeeNumber = opl.EmployeeNumber
             WHERE (@dept = '' OR opl.DepartmentCode = @dept)
               AND (@pos = '' OR opl.PositionTitle = @pos)
               AND (
                     @search = '' OR
                     opl.EmployeeNumber LIKE CONCAT('%', @search, '%') OR
                     opl.LastName      LIKE CONCAT('%', @search, '%') OR
                     opl.FirstName     LIKE CONCAT('%', @search, '%')
               )
             ORDER BY opl.LastName, opl.FirstName;"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@dept", dept)
                    cmd.Parameters.AddWithValue("@pos", position)
                    cmd.Parameters.AddWithValue("@search", search)

                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dgvOfficialProfessor.DataSource = dt
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading official professor list: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnOPSearch_Click(sender As Object, e As EventArgs) Handles btnOPSearch.Click
        LoadOfficialProfessorList()
    End Sub

    Private Sub cboOPDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOPDepartment.SelectedIndexChanged
        LoadOfficialProfessorList()
    End Sub

    Private Sub cboOPPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOPPosition.SelectedIndexChanged
        LoadOfficialProfessorList()
    End Sub
    Private Sub btnImportFaculty_Click(sender As Object, e As EventArgs) Handles btnImportFaculty.Click

        Dim ofd As New OpenFileDialog With {
        .Filter = "Excel Files|*.xlsx",
        .Title = "Import Official Professor List"
    }

        If ofd.ShowDialog() <> DialogResult.OK Then Exit Sub

        Dim registrarId As Integer = CurrentUser.RegistrarID

        Try
            ImportOfficialProfessorList(ofd.FileName)

            ' LOG THE IMPORT
            Using conn = GetConnection()
                conn.Open()

                Dim cmd As New MySqlCommand("
                INSERT INTO account_logs (UserType, UserID, Action, LogDate)
                VALUES('Registrar', @rid, @action, NOW());
            ", conn)

                cmd.Parameters.AddWithValue("@rid", registrarId)
                cmd.Parameters.AddWithValue("@action", $"Imported official professor list from Excel")

                cmd.ExecuteNonQuery()
            End Using

            LoadOfficialProfessorList()

        Catch ex As Exception
            MessageBox.Show("Import failed: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    '
    'Logs panel
    '
    Private Sub ConfigureLogsGrid()
        If dgvLogs.Columns.Count > 0 Then Exit Sub

        dgvLogs.AutoGenerateColumns = False
        dgvLogs.Columns.Clear()

        dgvLogs.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colDate",
            .HeaderText = "Date",
            .DataPropertyName = "LogDate",
            .Width = 150
        })

        dgvLogs.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colAction",
            .HeaderText = "Action",
            .DataPropertyName = "Action",
            .Width = 550
        })

        dgvLogs.Columns.Add(New DataGridViewTextBoxColumn() With {
            .Name = "colBy",
            .HeaderText = "By",
            .DataPropertyName = "DoneBy",
            .Width = 150
        })
    End Sub

    Private Sub LoadLogs(Optional search As String = "")
        Try
            ConfigureLogsGrid()

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Dim query As String =
                "
                SELECT 
                    al.LogDate,

                    -- Clean action text
                    CASE 
                        WHEN al.Action LIKE '% by %'
                            THEN SUBSTRING_INDEX(al.Action, ' by ', 1)
                        ELSE al.Action
                    END AS Action,

                    -- Resolve who performed the action
                    CASE 
                        WHEN al.UserType = 'Registrar' AND r.RegistrarID IS NOT NULL
                            THEN r.FullName
                        ELSE 'System'
                    END AS DoneBy

                FROM account_logs al

                LEFT JOIN registrar r
                    ON al.UserType = 'Registrar'
                    AND al.UserID = r.RegistrarID

                -- Search filter
                WHERE (@search = '' OR al.Action LIKE CONCAT('%', @search, '%'))

                ORDER BY al.LogDate DESC;
                "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@search", search)

                    Using da As New MySqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dgvLogs.DataSource = dt
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading logs: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RefreshHomeDashboard()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                '==========================
                ' 1. Pending Student Registrations
                '==========================
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM student WHERE AccountStatus = 'Pending';", conn)
                    lblHomePendingStudents.Text = cmd.ExecuteScalar().ToString()
                End Using

                '==========================
                ' 2. Pending Faculty Registrations
                '==========================
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM faculty WHERE Status = 'Pending';", conn)
                    lblHomePendingFaculty.Text = cmd.ExecuteScalar().ToString()
                End Using

                '==========================
                ' 3. Total Active Students
                '==========================
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM student WHERE AccountStatus = 'Active';", conn)
                    lblHomeActiveStudents.Text = cmd.ExecuteScalar().ToString()
                End Using

                '==========================
                ' 4. Total Active Faculty
                '==========================
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM faculty WHERE Status = 'Active';", conn)
                    lblHomeActiveFaculty.Text = cmd.ExecuteScalar().ToString()
                End Using

                '==========================
                ' 5. Load Recent Activity (from your logs)
                '==========================
                Dim query As String =
                "SELECT LogDate, Action 
                 FROM account_logs 
                 ORDER BY LogDate DESC 
                 LIMIT 10;"

                Using da As New MySqlDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvRecentActivity.DataSource = dt
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading home dashboard: " & ex.Message)
        End Try
    End Sub
End Class
