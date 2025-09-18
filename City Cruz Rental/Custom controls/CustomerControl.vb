Imports MySql.Data.MySqlClient

Public Class CustomerControl



    Private Sub LoadData()
        Using conn As New MySqlConnection(My.Resources.conn)
            Try
                conn.Open()

                Dim countTotalBookings As String = "SELECT COUNT(*) FROM customers c WHERE c.status != 'Deleted' ;"
                Using cmd As New MySqlCommand(countTotalBookings, conn)
                    Dim deletedCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblTotalCustomers.Text = deletedCount.ToString()
                End Using

                Dim countTotalReserved As String = "SELECT COUNT(DISTINCT r.customer_id) AS booked_customer_count FROM rentals r WHERE r.status IN ('Reserved', 'Picked up', 'Overdue');"
                Using cmd As New MySqlCommand(countTotalReserved, conn)
                    Dim deletedCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblBookedCustomers.Text = deletedCount.ToString()
                End Using

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using

        Dim dt = Queries.GetAllCustomers
        ' Bind a DataView instead of DataTable
        Dim dv As New DataView(dt)
        dtgCustomers.DataSource = dv

        ' Set the column headers
        dtgCustomers.Columns("fullName").HeaderText = "Full name"
        dtgCustomers.Columns("email").HeaderText = "Email"
        dtgCustomers.Columns("phone_number").HeaderText = "Phone"
        dtgCustomers.Columns("address").HeaderText = "Address"
        dtgCustomers.Columns("city").HeaderText = "City"
        dtgCustomers.Columns("created_at").HeaderText = "Date joined"

        ' Hidden data
        dtgCustomers.Columns("customer_id").Visible = False
        dtgCustomers.Columns("fName").Visible = False
        dtgCustomers.Columns("lName").Visible = False
        dtgCustomers.Columns("driver_license_number").Visible = False
        dtgCustomers.Columns("license_expiry_date").Visible = False
        dtgCustomers.Columns("date_of_birth").Visible = False
        dtgCustomers.Columns("status").Visible = False
        dtgCustomers.Columns("country").Visible = False
        dtgCustomers.Columns("postal_code").Visible = False
        dtgCustomers.Columns("updated_at").Visible = False
    End Sub

    Private Sub OnSearchResultChanged(newValue As String)
        Search.FilterDataGridView(newValue, dtgCustomers, "fullName", "email", "phone_number", "city")
    End Sub

    Private Sub CustomerControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Dim selectedRow As DataGridViewRow = dtgCustomers.Rows(0)
        Preview(selectedRow)

        ' Subscribe to the event
        AddHandler Search.SearchResultChanged, AddressOf OnSearchResultChanged
    End Sub

    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        If AddCustomerDialog.ShowDialog = DialogResult.OK Then
            LoadData()
        End If
    End Sub

    Private Sub DtgCustomers_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgCustomers.CellDoubleClick

        ' Ignore header clicks
        If e.RowIndex < 0 Then Exit Sub

        ' Get the ID from the selected row
        Dim selectedRow As DataGridViewRow = dtgCustomers.Rows(e.RowIndex)
        Dim customerId As Integer = Convert.ToInt32(selectedRow.Cells("customer_id").Value)

        ' Open the dialog with the selected staff ID
        Dim dialog As New AddCustomerDialog()
        dialog.InitializeForm(customerId) ' Pass the selected ID

        If dialog.ShowDialog() = DialogResult.OK Then
            LoadData()
        End If
    End Sub


    Private Sub DtgCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgCustomers.CellClick
        ' Ignore header clicks
        If e.RowIndex < 0 Then Exit Sub

        ' Get the ID from the selected row
        Dim selectedRow As DataGridViewRow = dtgCustomers.Rows(e.RowIndex)
        Preview(selectedRow)

    End Sub

    Private Sub Preview(selectedRow As DataGridViewRow)
        Dim customerId As Integer = Convert.ToInt32(selectedRow.Cells("customer_id").Value)
        lblFullName.Text = selectedRow.Cells("fullName").Value
        lblStatus.Text = "(" & selectedRow.Cells("created_at").Value & ")"
        dpEmail.ValueText = selectedRow.Cells("email").Value
        dpPhone.ValueText = selectedRow.Cells("phone_number").Value
        dpLicence.ValueText = selectedRow.Cells("driver_license_number").Value
        dpPostalCode.ValueText = selectedRow.Cells("postal_code").Value
        dpAddress.ValueText = selectedRow.Cells("address").Value
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        LoadData()
    End Sub
End Class
