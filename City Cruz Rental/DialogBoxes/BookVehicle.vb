Imports MySql.Data.MySqlClient

Public Class BookVehicle
    Private Shared db As New DatabaseHelper()
    Private vehicles As DataTable
    Private customers As DataTable
    Private rentalPrice As Double = 0.0

    ' Edit mode fields
    Private isEditMode As Boolean = False
    Private editBookingId As Integer = -1

    Public Sub InitializeForm(Optional bookingId As Integer = -1)
        PopulateCombobox()

        If bookingId <> -1 Then
            isEditMode = True
            editBookingId = bookingId
            btnBook.Text = "Update"
            btnCancel.Text = "Delete"
            lblFormName.Text = "Update Booking"
            PopulateBookingDetails(bookingId)
        Else
            isEditMode = False
            editBookingId = -1
            btnBook.Text = "Book"
            btnCancel.Text = "Cancel"
            lblFormName.Text = "New Booking"
        End If
    End Sub

    Private Sub PopulateCombobox()
        vehicles = db.ExecuteQuery("SELECT id, name, model, rental_price FROM vehicles WHERE state = 'Available';")
        customers = db.ExecuteQuery("SELECT customer_id, fName, lName FROM customers;")

        cmbVehicle.DataSource = Nothing
        For Each row As DataRow In vehicles.Rows
            Utils.AddItemToComboBox(cmbVehicle, row("id").ToString(), row("name").ToString() & " - " & row("model").ToString(), row("rental_price").ToString())
        Next
        If cmbVehicle.Items.Count > 0 Then cmbVehicle.SelectedIndex = 0

        cmbCustomer.DataSource = Nothing
        For Each row As DataRow In customers.Rows
            Utils.AddItemToComboBox(cmbCustomer, row("customer_id").ToString(), row("fName").ToString() & " " & row("lName").ToString())
        Next
        If cmbCustomer.Items.Count > 0 Then cmbCustomer.SelectedIndex = 0

        cmbPaymentMethod.DataSource = Nothing
        Utils.AddItemToComboBox(cmbPaymentMethod, "Cash", "Cash")
        Utils.AddItemToComboBox(cmbPaymentMethod, "MobileMoney", "Mobile Money")

        CmbVehicle_SelectedIndexChanged(cmbVehicle, New EventArgs()) ' trigger calculation
    End Sub

    Private Sub BookVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCombobox()
    End Sub

    Private Sub CmbVehicle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVehicle.SelectedIndexChanged, tmpStart.ValueChanged, tmpEnd.ValueChanged
        If cmbVehicle.SelectedValue Is Nothing OrElse String.IsNullOrEmpty(cmbVehicle.SelectedValue.ToString()) Then Exit Sub

        Dim selectedId As Integer
        If Integer.TryParse(cmbVehicle.SelectedValue.ToString(), selectedId) Then
            Dim rows() As DataRow = vehicles.Select("id = " & selectedId)
            If rows.Length > 0 Then
                rentalPrice = Convert.ToDecimal(rows(0)("rental_price"))
                txtDailyPrice.Text = rentalPrice.ToString()

                ' Calculate total
                Dim days As Integer = Math.Abs((tmpEnd.Value.Date - tmpStart.Value.Date).Days)
                txtTotalPrice.Text = (days * rentalPrice).ToString()
            End If
        End If

        ' Apply date limits
        If Not isEditMode Then
            Dim today As Date = Date.Today
            tmpStart.MinDate = today
            tmpStart.MaxDate = today.AddDays(365)
        End If
        tmpEnd.MinDate = tmpStart.Value.AddDays(1)
    End Sub

    Private Sub BtnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Dim confirmationMessage As String = If(isEditMode,
            $"Are you sure you want to update this booking for {cmbCustomer.Text}?",
            $"Are you sure you want to book {cmbVehicle.Text} for {cmbCustomer.Text} for GH¢ {txtTotalPrice.Text}?")

        If MsgBox(confirmationMessage, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim query As String
            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@vehicle_id", Convert.ToInt32(cmbVehicle.SelectedValue)),
                New MySqlParameter("@customer_id", Convert.ToInt32(cmbCustomer.SelectedValue)),
                New MySqlParameter("@staff_user_id", UserSession.Id),
                New MySqlParameter("@booking_date", Date.Today),
                New MySqlParameter("@start_date", tmpStart.Value.Date),
                New MySqlParameter("@end_date", tmpEnd.Value.Date),
                New MySqlParameter("@daily_price", Convert.ToDecimal(txtDailyPrice.Text)),
                New MySqlParameter("@total_price", Convert.ToDecimal(txtTotalPrice.Text)),
                New MySqlParameter("@payment_method", cmbPaymentMethod.SelectedValue.ToString()),
                New MySqlParameter("@payment_status", "Pending")
            }

            If isEditMode Then
                query = "UPDATE rentals SET vehicle_id=@vehicle_id, customer_id=@customer_id, staff_user_id=@staff_user_id, start_date=@start_date, end_date=@end_date, daily_price=@daily_price, total_price=@total_price, payment_method=@payment_method WHERE id=@id;"
                parameters.Add(New MySqlParameter("@id", editBookingId))
            Else
                query = "INSERT INTO rentals (vehicle_id, customer_id, staff_user_id, booking_date, start_date, end_date, return_date, status, daily_price, total_price, payment_method, payment_status, fuel_level, odometer_reading, damage_notes) " &
                        "VALUES (@vehicle_id, @customer_id, @staff_user_id, @booking_date, @start_date, @end_date, NULL, 'Reserved', @daily_price, @total_price, @payment_method, @payment_status, NULL, NULL, NULL);"
            End If

            db.ExecuteNonQuery(query, parameters)
            MessageBox.Show(If(isEditMode, "Booking updated successfully!", "Vehicle booked successfully!"))
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub PopulateBookingDetails(bookingId As Integer)
        'Remove boundry on dates

        Dim today As Date = Date.Today
        tmpStart.MinDate = today.AddDays(-365)
        tmpStart.MaxDate = today.AddDays(365)

        Try
            Dim query As String = $"SELECT * FROM rentals WHERE id={bookingId}"

            Dim dt As DataTable = db.ExecuteQuery(query)
            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                cmbVehicle.SelectedValue = row("vehicle_id")
                cmbCustomer.SelectedValue = row("customer_id")
                tmpStart.Value = Convert.ToDateTime(row("start_date"))
                tmpEnd.Value = Convert.ToDateTime(row("end_date"))
                txtDailyPrice.Text = row("daily_price").ToString()
                txtTotalPrice.Text = row("total_price").ToString()
                cmbPaymentMethod.SelectedValue = row("payment_method").ToString()
            Else
                MessageBox.Show("Booking not found.")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading booking: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If Not isEditMode Then
            If MsgBox("Are you sure you want to cancel?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            If MsgBox("Are you sure you want to delete this booking?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    Dim query As String = "UPDATE rentals SET status='Cancelled' WHERE id=@id"
                    Dim parameters As New List(Of MySqlParameter) From {
                        New MySqlParameter("@id", editBookingId)
                    }
                    db.ExecuteNonQuery(query, parameters)
                    MessageBox.Show("Booking cancelled successfully!")
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Error cancelling booking: " & ex.Message)
                End Try
            End If
        End If
    End Sub
End Class
