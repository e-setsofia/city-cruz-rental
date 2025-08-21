Imports MySql.Data.MySqlClient

Public Class BookVehicle
    Private Shared db As New DatabaseHelper()
    Dim vehicles = New DataTable
    Dim customers = New DataTable
    Dim rentalPrice = 0.0
    Private Sub PopulateCombobox()
        vehicles = db.ExecuteQuery("SELECT id, name, model, rental_price FROM vehicles WHERE state = 'Available';")
        customers = db.ExecuteQuery("SELECT customer_id, fName, lName FROM customers;")

        ' Add data to combobox
        For Each row As DataRow In vehicles.Rows
            Utils.AddItemToComboBox(cmbVehicle, row("id").ToString(), row("name").ToString() & " - " & row("model").ToString(), row("rental_price").ToString())
        Next
        cmbVehicle.SelectedIndex = 0

        ' Add data to combobox
        For Each row As DataRow In customers.Rows
            Utils.AddItemToComboBox(cmbCustomer, row("customer_id").ToString(), row("fName").ToString() & " " & row("lName").ToString())
        Next
        cmbVehicle.SelectedIndex = 0

        CmbVehicle_SelectedIndexChanged(cmbVehicle, New EventArgs) 'calculate the total price

        ' Add payment method
        Utils.AddItemToComboBox(cmbPaymentMethod, "Cash", "Cash")
        Utils.AddItemToComboBox(cmbPaymentMethod, "MobileMoney", "Mobile Money")



    End Sub

    Private Sub BookVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCombobox()
    End Sub

    Private Sub CmbVehicle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVehicle.SelectedIndexChanged, tmpStart.ValueChanged, tmpEnd.ValueChanged
        If cmbVehicle.SelectedValue Is Nothing OrElse String.IsNullOrEmpty(cmbVehicle.SelectedValue.ToString()) Then
            Exit Sub
        End If

        Dim rows() As DataRow

        ' Assuming id is integer. Adjust if string.
        Dim selectedId As Integer
        If Integer.TryParse(cmbVehicle.SelectedValue.ToString(), selectedId) Then
            rows = vehicles.Select("id = " & selectedId)
        Else
            Exit Sub
        End If

        If rows.Length = 0 Then
            MessageBox.Show("No vehicle found with the selected ID.")
            Exit Sub
        End If

        Dim rentalPrice As Long = Convert.ToInt64(rows(0)("rental_price"))
        txtDailyPrice.Text = rentalPrice.ToString()

        ' Get the selected dates
        Dim date1 As DateTime = tmpStart.Value
        Dim date2 As DateTime = tmpEnd.Value

        ' Calculate the difference
        Dim difference As TimeSpan = date2 - date1

        ' Get the difference in days
        Dim daysDifference As Integer = Math.Abs(difference.Days)

        txtTotalPrice.Text = (daysDifference * rentalPrice).ToString()

        ' Calculate date limits
        Dim today As Date = Date.Today
        Dim maxDate As Date = today.AddDays(365)  ' 1 yeaar later
        Dim minDate As Date = today.AddDays(0)  ' today

        ' Apply to DateTimePicker
        tmpStart.MaxDate = maxDate
        tmpStart.MinDate = minDate

        tmpEnd.MinDate = tmpStart.Value.AddDays(1)


    End Sub

    Private Sub BtnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        If MsgBox($"Are you sure you want to book  {cmbVehicle.SelectedText} for {cmbCustomer.SelectedText} for GH¢ {txtTotalPrice.Text} ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim query As String = "INSERT INTO rentals (vehicle_id, customer_id, staff_user_id, booking_date, start_date, end_date, return_date, status, daily_price, total_price, payment_method, payment_status, fuel_level, odometer_reading, damage_notes) " &
                      "VALUES ( @vehicle_id, @customer_id, @staff_user_id, @booking_date, @start_date, @end_date, NULL, 'Reserved', @daily_price, @total_price, @payment_method, 'Pending', NULL, NULL, NULL);"

            Dim parameters As New List(Of MySqlParameter) From {
                New MySqlParameter("@vehicle_id", Convert.ToInt32(cmbVehicle.SelectedValue)),
                New MySqlParameter("@customer_id", Convert.ToInt32(cmbCustomer.SelectedValue)),
                New MySqlParameter("@staff_user_id", UserSession.Id), ' Replace with logged-in staff user ID
                New MySqlParameter("@booking_date", Date.Today),
                New MySqlParameter("@start_date", tmpStart.Value.Date),
                New MySqlParameter("@end_date", tmpEnd.Value.Date),
                New MySqlParameter("@status", "Reserved"),
                New MySqlParameter("@daily_price", Convert.ToDecimal(txtDailyPrice.Text)),
                New MySqlParameter("@total_price", Convert.ToDecimal(txtTotalPrice.Text)),
                New MySqlParameter("@payment_method", cmbPaymentMethod.SelectedValue.ToString()),
                New MySqlParameter("@payment_status", "Pending")
            }

            db.ExecuteNonQuery(query, parameters)
            MsgBox($"Successfully booked {cmbVehicle.SelectedItem} for {cmbCustomer.SelectedItem} for GH¢ {txtTotalPrice.Text}")
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
End Class