Imports MySql.Data.MySqlClient

Public Class frmCompanyContactEntry

    Private _companyID As Integer
    Private _contactID As Integer = -1   ' -1 = ADD mode

    Public Sub New(companyID As Integer, Optional contactID As Integer = -1)
        InitializeComponent()
        _companyID = companyID
        _contactID = contactID
    End Sub
    Private Function PrimaryAlreadyExists() As Boolean
        Dim sql As String =
        "SELECT COUNT(*) FROM companycontact 
         WHERE CompanyID = @CompanyID AND IsPrimary = 1 AND ContactID <> @ContactID;"

        Try
            Using conn As MySqlConnection = GetConnection()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@CompanyID", _companyID)
                    cmd.Parameters.AddWithValue("@ContactID", If(_contactID = -1, 0, _contactID))

                    conn.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error validating primary contact: " & ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
            Return True ' fail-safe: block if validation fails
        End Try
    End Function


    Private Sub frmCompanyContactEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _contactID > 0 Then
            lblTitle.Text = "Edit Company Contact"
            LoadContact()
        Else
            lblTitle.Text = "Add Company Contact"
        End If

    End Sub

    Private Sub LoadContact()
        Dim sql As String =
            "SELECT FirstName, LastName, Position, Email, ContactNumber, IsPrimary " &
            "FROM companycontact WHERE ContactID = @id LIMIT 1;"

        Try
            Using conn = GetConnection()
                Using cmd = New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@id", _contactID)
                    conn.Open()

                    Using dr = cmd.ExecuteReader()
                        If dr.Read() Then
                            txtFirstName.Text = dr("FirstName").ToString()
                            txtLastName.Text = dr("LastName").ToString()
                            txtPosition.Text = dr("Position").ToString()
                            txtEmail.Text = dr("Email").ToString()
                            txtContactNumber.Text = dr("ContactNumber").ToString()
                            chkPrimary.Checked = CBool(dr("IsPrimary"))
                        End If
                    End Using

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading contact: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateInputs() As Boolean

        If txtFirstName.Text.Trim() = "" Then
            MessageBox.Show("First Name is required.")
            txtFirstName.Focus()
            Return False
        End If

        If txtLastName.Text.Trim() = "" Then
            MessageBox.Show("Last Name is required.")
            txtLastName.Focus()
            Return False
        End If

        If txtPosition.Text.Trim() = "" Then
            MessageBox.Show("Position is required.")
            txtPosition.Focus()
            Return False
        End If

        ' Simple email check
        If txtEmail.Text.Trim() <> "" AndAlso Not txtEmail.Text.Contains("@") Then
            MessageBox.Show("Invalid email address format.")
            txtEmail.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Not ValidateInputs() Then Exit Sub

        Dim sqlInsert As String =
            "INSERT INTO companycontact 
         (CompanyID, FirstName, LastName, Position, Email, ContactNumber, IsPrimary, CreatedAt) 
         VALUES (@CompanyID, @FirstName, @LastName, @Position, @Email, @ContactNumber, @IsPrimary, NOW());"

        Dim sqlUpdate As String =
            "UPDATE companycontact SET
            FirstName = @FirstName,
            LastName = @LastName,
            Position = @Position,
            Email = @Email,
            ContactNumber = @ContactNumber,
            IsPrimary = @IsPrimary,
            UpdatedAt = NOW()
         WHERE ContactID = @ContactID;"

        Try
            Using conn = GetConnection()
                conn.Open()

                ' ----------------------------------------------
                ' ENSURE ONLY ONE "PRIMARY" CONTACT PER COMPANY
                ' ----------------------------------------------
                If chkPrimary.Checked Then
                    Dim sqlClearPrimary As String =
                        "UPDATE companycontact 
                     SET IsPrimary = 0 
                     WHERE CompanyID = @CompanyID 
                       AND ContactID <> @CurrentID;"

                    Using clearCmd As New MySqlCommand(sqlClearPrimary, conn)
                        clearCmd.Parameters.AddWithValue("@CompanyID", _companyID)
                        clearCmd.Parameters.AddWithValue("@CurrentID", If(_contactID = -1, 0, _contactID))
                        clearCmd.ExecuteNonQuery()
                    End Using
                End If

                ' ----------------------------------------------
                ' INSERT OR UPDATE CONTACT
                ' ----------------------------------------------
                If _contactID = -1 Then
                    ' INSERT
                    Using cmd = New MySqlCommand(sqlInsert, conn)
                        cmd.Parameters.AddWithValue("@CompanyID", _companyID)
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim())
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim())
                        cmd.Parameters.AddWithValue("@Position", txtPosition.Text.Trim())
                        cmd.Parameters.AddWithValue("@Email", If(txtEmail.Text.Trim() = "", DBNull.Value, txtEmail.Text.Trim()))
                        cmd.Parameters.AddWithValue("@ContactNumber", If(txtContactNumber.Text.Trim() = "", DBNull.Value, txtContactNumber.Text.Trim()))
                        cmd.Parameters.AddWithValue("@IsPrimary", chkPrimary.Checked)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Contact added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    ' UPDATE
                    Using cmd = New MySqlCommand(sqlUpdate, conn)
                        cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim())
                        cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim())
                        cmd.Parameters.AddWithValue("@Position", txtPosition.Text.Trim())
                        cmd.Parameters.AddWithValue("@Email", If(txtEmail.Text.Trim() = "", DBNull.Value, txtEmail.Text.Trim()))
                        cmd.Parameters.AddWithValue("@ContactNumber", If(txtContactNumber.Text.Trim() = "", DBNull.Value, txtContactNumber.Text.Trim()))
                        cmd.Parameters.AddWithValue("@IsPrimary", chkPrimary.Checked)
                        cmd.Parameters.AddWithValue("@ContactID", _contactID)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Contact updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                Me.DialogResult = DialogResult.OK
                Me.Close()

            End Using

        Catch ex As Exception
            MessageBox.Show("Error saving contact: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub
End Class
