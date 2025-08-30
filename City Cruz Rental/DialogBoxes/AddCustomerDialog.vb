Imports MySql.Data.MySqlClient

Public Class AddCustomerDialog

    Private isEditMode As Boolean = False
    Private editCustomerId As Integer = -1

    Public Sub InitializeForm(Optional customerId As Integer = -1)
        If customerId <> -1 Then
            isEditMode = True
            editCustomerId = customerId
            btnAdd.Text = "Update"
            btnCancel.Text = "Delete"
            PopulateCustomerDetails(customerId)
            lblFormName.Text = $"Update {txtFirstName.Text}'s Details"
        Else
            isEditMode = False
            editCustomerId = -1
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Try
            Dim query As String

            If isEditMode Then
                query = "UPDATE customers SET fName=@fName, lName=@lName, email=@Email, phone_number=@Phone, " &
                        "driver_license_number=@License, license_expiry_date=@LicenseExpiry, date_of_birth=@DOB, " &
                        "address=@Address, city=@City, status=@Status, postal_code=@Postal, country=@Country " &
                        "WHERE customer_id=@CustomerId"
            Else
                query = "INSERT INTO customers (fName, lName, email, phone_number, driver_license_number, license_expiry_date, date_of_birth, " &
                        "address, city, status, postal_code, country) " &
                        "VALUES (@fName, @lName, @Email, @Phone, @License, @LicenseExpiry, @DOB, @Address, @City, @Status, @Postal, @Country)"
            End If

            Using conn As New MySqlConnection(My.Resources.conn)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fName", txtFirstName.Text)
                    cmd.Parameters.AddWithValue("@lName", txtLastName.Text)
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text)
                    cmd.Parameters.AddWithValue("@License", txtLicenseNumber.Text)
                    cmd.Parameters.AddWithValue("@LicenseExpiry", dtpLicenseExpiry.Value.Date)
                    cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value.Date)
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                    cmd.Parameters.AddWithValue("@City", cmbCity.SelectedValue)
                    cmd.Parameters.AddWithValue("@Status", "Active")
                    cmd.Parameters.AddWithValue("@Postal", txtPostalCode.Text)
                    cmd.Parameters.AddWithValue("@Country", "Ghana")

                    If isEditMode Then
                        cmd.Parameters.AddWithValue("@CustomerId", editCustomerId)
                    End If

                    cmd.ExecuteNonQuery()

                    MessageBox.Show(If(isEditMode, "Customer updated successfully!", "Customer added successfully!"))
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub PopulateCityComboBox()
        cmbCity.Items.Clear()

        Dim regions As New List(Of String) From {
        "Greater Accra",
        "Ashanti",
        "Eastern",
        "Western",
        "Central",
        "Volta",
        "Northern",
        "Upper East",
        "Upper West",
        "Bono",
        "Bono East",
        "Ahafo",
        "Western North",
        "North East",
        "Savannah",
        "Oti"
    }

        For Each region As String In regions
            cmbCity.Items.Add(region)
        Next

        If cmbCity.Items.Count > 0 Then
            cmbCity.SelectedIndex = 0 ' Optional: select the first region
        End If
    End Sub

    Private Sub PopulateCustomerDetails(customerId As Integer)
        Try
            Dim query As String = "SELECT * FROM customers WHERE customer_id = @id"

            Using conn As New MySqlConnection(My.Resources.conn)
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", customerId)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtFirstName.Text = reader("fName").ToString()
                            txtLastName.Text = reader("lName").ToString()
                            txtEmail.Text = reader("email").ToString()
                            txtPhone.Text = reader("phone_number").ToString()
                            txtLicenseNumber.Text = reader("driver_license_number").ToString()

                            If Not IsDBNull(reader("license_expiry_date")) Then
                                dtpLicenseExpiry.Value = Convert.ToDateTime(reader("license_expiry_date"))
                            End If

                            If Not IsDBNull(reader("date_of_birth")) Then
                                dtpDOB.Value = Convert.ToDateTime(reader("date_of_birth"))
                            End If

                            txtAddress.Text = reader("address").ToString()



                            txtPostalCode.Text = reader("postal_code").ToString()
                        Else
                            MessageBox.Show("Customer not found.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading customer: " & ex.Message)
        End Try
    End Sub

    Private Sub AddCustomerDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDatePickers()
        PopulateCityComboBox()
        btnAdd.Text = "Add"
        btnCancel.Text = "Cancel"
    End Sub

    Private Sub SetDatePickers()
        Dim today As Date = Date.Today
        dtpDOB.MaxDate = today.AddYears(-18)
        dtpDOB.MinDate = today.AddYears(-100)

        dtpLicenseExpiry.MinDate = today
        dtpLicenseExpiry.MaxDate = today.AddYears(20)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If Not isEditMode Then
            If MsgBox("Are you sure you want to cancel adding this customer?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            If MsgBox($"Are you sure you want to delete {txtFirstName.Text} from the system?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim query = $"UPDATE customers SET status='deleted' WHERE customer_id={editCustomerId}"
                Try
                    Using conn As New MySqlConnection(My.Resources.conn)
                        conn.Open()
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.ExecuteNonQuery()
                            MessageBox.Show($"{txtFirstName.Text} deleted successfully!")
                            Me.DialogResult = DialogResult.OK
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error deleting customer: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

        Dim originalText As String = txtFirstName.Text
        Dim filteredText As String = ""

        For Each ch As Char In originalText
            If Char.IsLetter(ch) Then
                filteredText &= ch
            End If
        Next

        If txtFirstName.Text <> filteredText Then
            Dim cursorPos As Integer = txtFirstName.SelectionStart
            txtFirstName.Text = filteredText
            txtFirstName.SelectionStart = Math.Min(cursorPos, filteredText.Length)
        End If
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        Dim originalText As String = txtLastName.Text
        Dim filteredText As String = ""

        For Each ch As Char In originalText
            If Char.IsLetter(ch) Then
                filteredText &= ch
            End If
        Next

        If txtLastName.Text <> filteredText Then
            Dim cursorPos As Integer = txtLastName.SelectionStart
            txtLastName.Text = filteredText
            txtLastName.SelectionStart = Math.Min(cursorPos, filteredText.Length)
        End If
    End Sub

End Class
