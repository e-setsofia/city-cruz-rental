Public Class VehicleControl
    Private Sub VehicleControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        dtgVehicles.DataSource = Queries.ListVehicles

        ' Set the column headers
        dtgVehicles.Columns("name").HeaderText = "Vehicle"
        dtgVehicles.Columns("brand_name").HeaderText = "Brand"
        dtgVehicles.Columns("model").HeaderText = "Model"
        dtgVehicles.Columns("rental_price").HeaderText = "Rental Price"
        dtgVehicles.Columns("state").HeaderText = "Status"
        dtgVehicles.Columns("rating").HeaderText = "Rating"
        dtgVehicles.Columns("category_name").HeaderText = "Category"


        dtgVehicles.Columns("id").Visible = False
        dtgVehicles.Columns("brand_id").Visible = False
        dtgVehicles.Columns("category_id").Visible = False
    End Sub


End Class
