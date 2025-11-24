Imports MySql.Data.MySqlClient

Public Class frmCompanyEntry

    Private _companyId As Integer = -1

    Public Sub New(Optional companyId As Integer = -1)
        InitializeComponent()
        _companyId = companyId
    End Sub

    Private Sub frmCompanyEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate status combo
        cboStatus.Items.Clear()
        cboStatus.Items.Add("Accredited")
        cboStatus.Items.Add("Inactive")

        If _companyId > 0 Then
            lblTitle.Text = "Edit Company"
            LoadCompany()
        Else
            lblTitle.Text = "Add Company"
            cboStatus.SelectedItem = "Accredited"
        End If
    End Sub

    Private Sub LoadCompany()
        Dim sql As String =
            "SELECT CompanyName, CompanyAddress, CompanyCity, Industry, Email, " &
            "ContactNumber, Website, CompanyStatus " &
            "FROM company WHERE CompanyID = @id LIMIT 1;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", _companyId)
                    conn.Open()
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            txtCompanyName.Text = dr("CompanyName").ToString()
                            txtAddress.Text = dr("CompanyAddress").ToString()
                            txtCity.Text = dr("CompanyCity").ToString()
                            txtIndustry.Text = dr("Industry").ToString()
                            txtEmail.Text = dr("Email").ToString()
                            txtContactNumber.Text = dr("ContactNumber").ToString()
                            txtWebsite.Text = dr("Website").ToString()

                            Dim status As String = dr("CompanyStatus").ToString()
                            If cboStatus.Items.Contains(status) Then
                                cboStatus.SelectedItem = status
                            End If
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading company: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txtCompanyName.Text) Then
            MessageBox.Show("Company Name is required.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtCompanyName.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtCity.Text) Then
            MessageBox.Show("City is required.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtCity.Focus()
            Return False
        End If

        If cboStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a Status.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            cboStatus.Focus()
            Return False
        End If

        ' Simple email check (optional)
        Dim email As String = txtEmail.Text.Trim()
        If email <> "" AndAlso Not email.Contains("@") Then
            MessageBox.Show("Please enter a valid email address.",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateInputs() Then Return

        Dim name As String = txtCompanyName.Text.Trim()
        Dim address As String = txtAddress.Text.Trim()
        Dim city As String = txtCity.Text.Trim()
        Dim industry As String = txtIndustry.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim contact As String = txtContactNumber.Text.Trim()
        Dim website As String = txtWebsite.Text.Trim()
        Dim status As String = cboStatus.SelectedItem.ToString()

        Dim sqlInsert As String =
            "INSERT INTO company " &
            "(CompanyName, CompanyAddress, CompanyCity, Industry, Email, ContactNumber, Website, CompanyStatus, CreatedAt) " &
            "VALUES (@CompanyName, @CompanyAddress, @CompanyCity, @Industry, @Email, @ContactNumber, @Website, @CompanyStatus, NOW());"

        Dim sqlUpdate As String =
            "UPDATE company SET " &
            "CompanyName = @CompanyName, " &
            "CompanyAddress = @CompanyAddress, " &
            "CompanyCity = @CompanyCity, " &
            "Industry = @Industry, " &
            "Email = @Email, " &
            "ContactNumber = @ContactNumber, " &
            "Website = @Website, " &
            "CompanyStatus = @CompanyStatus, " &
            "UpdatedAt = NOW() " &
            "WHERE CompanyID = @CompanyID;"

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                If _companyId > 0 Then
                    Using cmd As New MySqlCommand(sqlUpdate, conn)
                        cmd.Parameters.AddWithValue("@CompanyName", name)
                        cmd.Parameters.AddWithValue("@CompanyAddress", address)
                        cmd.Parameters.AddWithValue("@CompanyCity", city)
                        cmd.Parameters.AddWithValue("@Industry", industry)
                        cmd.Parameters.AddWithValue("@Email", If(email = "", DBNull.Value, email))
                        cmd.Parameters.AddWithValue("@ContactNumber", If(contact = "", DBNull.Value, contact))
                        cmd.Parameters.AddWithValue("@Website", If(website = "", DBNull.Value, website))
                        cmd.Parameters.AddWithValue("@CompanyStatus", status)
                        cmd.Parameters.AddWithValue("@CompanyID", _companyId)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Company updated successfully.",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                Else
                    Using cmd As New MySqlCommand(sqlInsert, conn)
                        cmd.Parameters.AddWithValue("@CompanyName", name)
                        cmd.Parameters.AddWithValue("@CompanyAddress", address)
                        cmd.Parameters.AddWithValue("@CompanyCity", city)
                        cmd.Parameters.AddWithValue("@Industry", industry)
                        cmd.Parameters.AddWithValue("@Email", If(email = "", DBNull.Value, email))
                        cmd.Parameters.AddWithValue("@ContactNumber", If(contact = "", DBNull.Value, contact))
                        cmd.Parameters.AddWithValue("@Website", If(website = "", DBNull.Value, website))
                        cmd.Parameters.AddWithValue("@CompanyStatus", status)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Company added successfully.",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                End If
            End Using

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error saving company: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
