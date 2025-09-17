Imports MySql.Data.MySqlClient
Public Class Booking
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()

        ' Subscribe to the event
        AddHandler Search.SearchResultChanged, AddressOf OnSearchResultChanged

        ' Subscribe to double-click event on DataGridView rows
        AddHandler dtgBooking.CellDoubleClick, AddressOf DtgBooking_CellDoubleClick
    End Sub

    Private Sub LoadData()
        Using conn As New MySqlConnection(My.Resources.conn)
            Try
                conn.Open()

                Dim countTotalBookings As String = "SELECT COUNT(*) FROM rentals r WHERE r.status != 'Returned' ;"
                Using cmd As New MySqlCommand(countTotalBookings, conn)
                    Dim deletedCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblBookedVehicles.Text = deletedCount.ToString()
                End Using

                Dim countTotalReserved As String = "SELECT COUNT(*) FROM rentals r WHERE r.status = 'Reserved';"
                Using cmd As New MySqlCommand(countTotalReserved, conn)
                    Dim deletedCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblReserved.Text = deletedCount.ToString()
                End Using

                ' Update outdated vehicles
                Dim updateOverdueBookings As String = "Update `rentals` Set `status`='Overdue' WHERE end_date < CURDATE() AND `status`='Picked up';"
                Using cmd As New MySqlCommand(updateOverdueBookings, conn)
                    Dim deletedCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                Dim countOverdueBookings As String = "SELECT COUNT(*) FROM rentals r WHERE r.status = 'Overdue';"
                Using cmd As New MySqlCommand(countOverdueBookings, conn)
                    Dim deletedCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblOverdue.Text = deletedCount.ToString()
                End Using

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using

        Dim dt = Queries.ListBookedVehicles()
        Dim dv As New DataView(dt)
        dtgBooking.DataSource = dv

        ' Set column headers
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

        ' Hide internal ID
        dtgBooking.Columns("rental_id").Visible = False
    End Sub

    Private Sub OnSearchResultChanged(newValue As String)
        Search.FilterDataGridView(newValue, dtgBooking,
                                  "vehicle_name", "vehicle_model",
                                  "customer_first_name", "customer_email",
                                  "staff_first_name", "status")
    End Sub

    ' === ADD BOOKING ===
    Private Sub BtnBookVehicle_Click(sender As Object, e As EventArgs) Handles btnBookVehicle.Click
        Dim frm As New BookVehicleDialog()
        frm.InitializeForm() ' Add mode
        If frm.ShowDialog() = DialogResult.OK Then
            LoadData()
        End If
    End Sub

    ' === EDIT BOOKING ON DOUBLE-CLICK ===
    Private Sub DtgBooking_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim rentalId As Integer = Convert.ToInt32(dtgBooking.Rows(e.RowIndex).Cells("rental_id").Value)

            Dim frm As New BookVehicleDialog()
            frm.InitializeForm(rentalId) ' Edit mode
            If frm.ShowDialog() = DialogResult.OK Then
                LoadData()
            End If
        End If
    End Sub
End Class
