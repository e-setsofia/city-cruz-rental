Imports MySql.Data.MySqlClient
Public Class Booking
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

        ' Subscribe to the event
        AddHandler Search.SearchResultChanged, AddressOf OnSearchResultChanged
    End Sub
    Private Sub LoadData()
        Using conn As New MySqlConnection(My.Resources.conn)
            Try
                conn.Open()

                Dim countTotalBookings As String = "SELECT COUNT(*) FROM  rentals r WHERE  r.return_date IS NULL OR r.status != 'Returned';"
                Using cmd As New MySqlCommand(countTotalBookings, conn)
                    Dim deletedCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblBookedVehicles.Text = deletedCount.ToString()
                End Using

                Dim countTotalReserved As String = "SELECT COUNT(*) FROM rentals r WHERE r.status = 'Reserved';"
                Using cmd As New MySqlCommand(countTotalReserved, conn)
                    Dim deletedCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblReserved.Text = deletedCount.ToString()
                End Using

                Dim countOverdueBookings As String = "SELECT COUNT(*) FROM rentals r WHERE r.return_date IS NULL AND r.end_date < CURDATE();"
                Using cmd As New MySqlCommand(countOverdueBookings, conn)
                    Dim deletedCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblOverdue.Text = deletedCount.ToString()
                End Using
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End Using


        Dim dt = Queries.ListBookedVehicles
        ' Bind a DataView instead of DataTable
        Dim dv As New DataView(dt)

        dtgBooking.DataSource = dv

        ' Set column headers for rentals
        dtgBooking.Columns("rental_id").HeaderText = "Rental ID"
        dtgBooking.Columns("vehicle_name").HeaderText = "Vehicle"
        dtgBooking.Columns("vehicle_model").HeaderText = "Model"
        dtgBooking.Columns("rental_price").HeaderText = "Price/Day"
        dtgBooking.Columns("customer_first_name").HeaderText = "Customer Name"
        dtgBooking.Columns("customer_email").HeaderText = "Email"
        dtgBooking.Columns("staff_first_name").HeaderText = "Staff Name"
        dtgBooking.Columns("start_date").HeaderText = "Start Date"
        dtgBooking.Columns("end_date").HeaderText = "End Date"
        dtgBooking.Columns("status").HeaderText = "Rental Status"
        dtgBooking.Columns("return_date").HeaderText = "Return Date"

        ' Hide internal or unnecessary columns (if any)
        dtgBooking.Columns("rental_id").Visible = False ' optional
    End Sub

    Private Sub dtgBooking_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub OnSearchResultChanged(newValue As String)
        Search.FilterDataGridView(newValue, dtgBooking, "vehicle_name", "vehicle_model", "customer_first_name", "customer_email", "staff_first_name", "status")
    End Sub

    Private Sub BtnBookVehicle_Click(sender As Object, e As EventArgs) Handles btnBookVehicle.Click
        If BookVehicle.ShowDialog() = DialogResult.OK Then
            LoadData()
        End If
    End Sub
End Class
