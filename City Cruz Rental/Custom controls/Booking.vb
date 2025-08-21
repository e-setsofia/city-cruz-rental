Public Class Booking
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub LoadData()
        dtgBooking.DataSource = Queries.ListVehicles

        ' Set the column headers
        dtgBooking.Columns("name").HeaderText = "Vehicle"
        dtgBooking.Columns("brand_name").HeaderText = "Brand"
        dtgBooking.Columns("model").HeaderText = "Model"
        dtgBooking.Columns("rental_price").HeaderText = "Rental Price"
        dtgBooking.Columns("state").HeaderText = "Status"
        dtgBooking.Columns("rating").HeaderText = "Rating"
        dtgBooking.Columns("category_name").HeaderText = "Category"


        dtgBooking.Columns("id").Visible = False
        dtgBooking.Columns("brand_id").Visible = False
        dtgBooking.Columns("category_id").Visible = False
    End Sub

    Private Sub dtgBooking_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)





























    End Sub
End Class
