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
        dtgVehicles.Columns("number_plate").HeaderText = "Number Plate"
        dtgVehicles.Columns("rental_price").HeaderText = "Rental Price"
        dtgVehicles.Columns("state").HeaderText = "Status"
        dtgVehicles.Columns("rating").HeaderText = "Rating"
        dtgVehicles.Columns("category_name").HeaderText = "Category"
        dtgVehicles.Columns("number_plate").HeaderText = "number_plate"


        dtgVehicles.Columns("id").Visible = False
        dtgVehicles.Columns("brand_id").Visible = False
        dtgVehicles.Columns("category_id").Visible = False
    End Sub


    Private Sub VehicleControl_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' Ensure the PictureBox uses manual painting
        imgCar.SizeMode = PictureBoxSizeMode.Normal

        ' Remove old handler (to prevent duplicates if function is called again)
        RemoveHandler imgCar.Paint, AddressOf ImageResizer.PictureBoxCropFill_Paint
        ' Add handler
        AddHandler imgCar.Paint, AddressOf ImageResizer.PictureBoxCropFill_Paint

        ' Force redraw
        imgCar.Invalidate()

        imgCar.BorderRadius = 16
    End Sub

    Private Sub Preview(selectedRow As DataGridViewRow)
        Dim customerId As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)
        Dim name = selectedRow.Cells("model").Value & " - " & selectedRow.Cells("brand_name").Value
        lblFormName.Text = name
        dpModel.ValueText = selectedRow.Cells("model").Value
        dpStatus.ValueText = selectedRow.Cells("state").Value
        dpRentalPrice.ValueText = selectedRow.Cells("rental_price").Value

        Try
            dpNumberPlate.ValueText = selectedRow.Cells("number_plate").Value
        Catch ex As Exception
            dpNumberPlate.ValueText = "Unkown"
            Console.WriteLine("Vehicle control (Preview): " & ex.ToString)
        End Try
    End Sub

    Private Sub dtgVehicles_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dtgVehicles.RowEnter
        ' Ignore header clicks
        If e.RowIndex < 0 Then Exit Sub

        ' Get the ID from the selected row
        Dim selectedRow As DataGridViewRow = dtgVehicles.Rows(e.RowIndex)
        Preview(selectedRow)
    End Sub

    Private Sub BtnAddVehicle_Click(sender As Object, e As EventArgs) Handles btnAddVehicle.Click
        Dim dialog = New AddVehicle
        dialog.ShowDialog()

        If dialog.DialogResult = DialogResult.OK Then
            Dim lastRowIndex = dtgVehicles.Rows.Count - 1 'Get the last item in the grid
            LoadData()
            Preview(dtgVehicles.Rows(lastRowIndex))
        End If
    End Sub
End Class
