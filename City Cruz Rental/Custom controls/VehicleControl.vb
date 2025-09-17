Imports System.IO

Public Class VehicleControl
    Private Sub VehicleControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        ' Subscribe to the event
        AddHandler Search.SearchResultChanged, AddressOf OnSearchResultChanged

        ' Show add vehichle if is admin
        If Permissions.IsAdmin Then
            pnlAddVehicle.Visible = True
        End If
    End Sub

    Private Sub LoadData()
        ' Get data from your query
        Dim dt As DataTable = Queries.ListVehicles

        ' Bind a DataView instead of DataTable
        Dim dv As New DataView(dt)
        dtgVehicles.DataSource = dv

        ' Set the column headers
        dtgVehicles.Columns("name").HeaderText = "Vehicle"
        dtgVehicles.Columns("brand_name").HeaderText = "Brand"
        dtgVehicles.Columns("model").HeaderText = "Model"
        dtgVehicles.Columns("number_plate").HeaderText = "Number Plate"
        dtgVehicles.Columns("rental_price").HeaderText = "Rental Price"
        dtgVehicles.Columns("state").HeaderText = "Status"
        dtgVehicles.Columns("rating").HeaderText = "Rating"
        dtgVehicles.Columns("category_name").HeaderText = "Category"

        ' Hide unnecessary columns
        dtgVehicles.Columns("id").Visible = False
        dtgVehicles.Columns("brand_id").Visible = False
        dtgVehicles.Columns("category_id").Visible = False
        dtgVehicles.Columns("image").Visible = False

    End Sub

    ' Event handler that displays the new search result
    Private Sub OnSearchResultChanged(newValue As String)
        Search.FilterDataGridView(newValue, dtgVehicles, "name", "brand_name", "model", "number_plate")
    End Sub

    Private Sub VehicleControl_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' Ensure the PictureBox uses manual painting
        imgCar.SizeMode = PictureBoxSizeMode.Normal

        ' Remove old handler (to prevent duplicates if function is called again)
        RemoveHandler imgCar.Paint, AddressOf ImageUtils.PictureBoxCropFill_Paint
        ' Add handler
        AddHandler imgCar.Paint, AddressOf ImageUtils.PictureBoxCropFill_Paint

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
            dpNumberPlate.ValueText = selectedRow.Cells("number_plate").Value.ToString()

            Dim imageBytes As Byte() = CType(selectedRow.Cells("image").Value, Byte())
            If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                Using ms As New MemoryStream(imageBytes)
                    imgCar.Image = Image.FromStream(ms)
                End Using
            Else
                imgCar.Image = My.Resources.car_symbol
            End If

        Catch ex As Exception
            dpNumberPlate.ValueText = "Unknown"
            imgCar.Image = My.Resources.car_symbol
            Console.WriteLine("Vehicle control (Preview): " & ex.ToString())
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
        Dim dialog = New AddVehicleDialog
        dialog.ShowDialog()

        If dialog.DialogResult = DialogResult.OK Then
            Dim lastRowIndex = dtgVehicles.Rows.Count - 1 'Get the last item in the grid
            LoadData()
            Preview(dtgVehicles.Rows(lastRowIndex))
        End If
    End Sub

    Private Sub dtgVehicles_DoubleClick(sender As Object, e As EventArgs) Handles dtgVehicles.DoubleClick
        If dtgVehicles.CurrentRow Is Nothing Or Not Permissions.IsAdmin Then Exit Sub

        ' Get the ID from the selected row
        Dim selectedRow As DataGridViewRow = dtgVehicles.CurrentRow
        Dim vehicleId As Integer = Convert.ToInt32(selectedRow.Cells("id").Value)

        ' Open the dialog with the selected vehicle ID
        Dim dialog As New AddVehicleDialog()
        dialog.InitializeForm(vehicleId) ' Pass the selected ID

        Try
            If dialog.ShowDialog() = DialogResult.OK Then
                LoadData()
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
