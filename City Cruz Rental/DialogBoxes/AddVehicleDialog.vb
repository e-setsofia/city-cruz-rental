Imports MySql.Data.MySqlClient

Public Class AddVehicleDialog
    Private validator As New FieldValidator
    Private brands As New DataTable
    Private categories As New DataTable
    Private db As New DatabaseHelper()
    Private imageByte As Byte()

    ' New fields for Edit Mode
    Private isEditMode As Boolean = False
    Private editVehicleId As Integer = -1

    Public Sub InitializeForm(Optional vehicleId As Integer = -1)
        LoadComboBoxes()
        Validation()

        If vehicleId <> -1 Then
            isEditMode = True
            editVehicleId = vehicleId
            btnAdd.Text = "Update"
            btnDelete.Text = "Delete"
            lblFormName.Text = "Update Vehicle"
            PopulateVehicleDetails(vehicleId)
        Else
            isEditMode = False
            editVehicleId = -1
            btnAdd.Text = "Add"
            btnDelete.Text = "Cancel"
            lblFormName.Text = "New Vehicle"
        End If
    End Sub

    Private Sub TxtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim txt = txtName.Text
        If txt.Length = 0 Then
            lblFormName.Text = If(isEditMode, "Update Vehicle", "New Vehicle")
        ElseIf txt.Length > 14 Then
            lblFormName.Text = txt.Substring(0, 14) & "..."
        Else
            lblFormName.Text = txt
        End If
    End Sub

    Private Sub ImgVehicle_Click(sender As Object, e As EventArgs) Handles imgVehicle.Click
        imageByte = ImageUtils.SelectImageAndConvertToBytes(imgVehicle)

        ' Crop aspect ration
        AddHandler imgVehicle.Paint, AddressOf ImageUtils.PictureBoxCropFill_Paint
        imgVehicle.BorderRadius = 16
    End Sub

    Private Sub Validation()
        validator.ClearEntries()
        validator.AddEntry(txtName, lblName, FieldValidator.FieldType.NAME)
        validator.AddEntry(txtPrice, lblPrice, FieldValidator.FieldType.MONEY)
        validator.AddEntry(txtModel, lblModel, FieldValidator.FieldType.NAME)
        validator.AddEntry(txtNumberPlate, lblNumberPlate, FieldValidator.FieldType.NUMBER_PLATE)
    End Sub

    Private Sub PopulateCombobox()
        brands = db.ExecuteQuery("SELECT * FROM `brands`;")
        categories = db.ExecuteQuery("SELECT * FROM `categories`;")

        cmbBrand.DataSource = Nothing
        cmbBrand.Items.Clear()
        For Each row As DataRow In brands.Rows
            Utils.AddItemToComboBox(cmbBrand, row("id").ToString(), row("name").ToString())
        Next

        cmbCategory.DataSource = Nothing
        cmbCategory.Items.Clear()
        For Each row As DataRow In categories.Rows
            Utils.AddItemToComboBox(cmbCategory, row("id").ToString(), row("name").ToString())
        Next
    End Sub

    Private Sub LoadComboBoxes()
        PopulateCombobox()
        cmbCategory.SelectedIndex = 0
        cmbBrand.SelectedIndex = 0
    End Sub

    Private Sub AddVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' All setup now handled in InitializeForm()
        LoadComboBoxes()
    End Sub

    Private Sub BtnBrand_Click(sender As Object, e As EventArgs) Handles btnBrand.Click
        Dim dialog = New MiniDialog
        dialog.lblFormName.Text = "New Brand"
        dialog.lblName.Text = "Brand:"
        dialog.Query = $"INSERT INTO `brands`( `name`) VALUES (@value)"
        ShowDialogAndUpdateCombobox(dialog, cmbBrand, brands)
    End Sub

    Private Sub BtnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        Dim dialog = New MiniDialog
        dialog.lblFormName.Text = "New Category"
        dialog.lblName.Text = "Category:"
        dialog.Query = "INSERT INTO `categories`( `name`) VALUES (@value)"
        ShowDialogAndUpdateCombobox(dialog, cmbCategory, categories)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Validation()
        If Not validator.ValidateAll() Then Exit Sub

        Dim query As String
        Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@name", txtName.Text),
            New MySqlParameter("@brand_id", cmbBrand.SelectedValue),
            New MySqlParameter("@model", txtModel.Text),
            New MySqlParameter("@rental_price", Decimal.Parse(txtPrice.Text)),
            New MySqlParameter("@category_id", cmbCategory.SelectedValue),
            New MySqlParameter("@image", imageByte),
            New MySqlParameter("@number_plate", txtNumberPlate.Text)
        }

        If isEditMode Then
            query = "UPDATE vehicles SET name=@name, brand_id=@brand_id, model=@model, rental_price=@rental_price, category_id=@category_id, image=@image, number_plate=@number_plate WHERE id=@id;"
            parameters.Add(New MySqlParameter("@id", editVehicleId))
        Else
            query = "INSERT INTO vehicles(name, brand_id, model, rental_price, category_id, image, number_plate) VALUES (@name, @brand_id, @model, @rental_price, @category_id, @image, @number_plate);"
        End If

        db.ExecuteNonQuery(query, parameters)

        MessageBox.Show(If(isEditMode, "Vehicle updated successfully!", "Vehicle added successfully!"))
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub PopulateVehicleDetails(vehicleId As Integer)
        Try
            Dim query = $"SELECT * FROM vehicles WHERE id = '{vehicleId}'"


            Dim dt = db.ExecuteQuery(query)
            If dt.Rows.Count > 0 Then
                Dim row = dt.Rows(0)
                txtName.Text = row("name").ToString()
                txtModel.Text = row("model").ToString()
                txtNumberPlate.Text = row("number_plate").ToString()
                txtPrice.Text = row("rental_price").ToString()

                cmbBrand.SelectedValue = row("brand_id")
                cmbCategory.SelectedValue = row("category_id")

                If Not IsDBNull(row("image")) Then
                    imageByte = CType(row("image"), Byte())
                    imgVehicle.Image = ImageUtils.ByteArrayToImage(imageByte)

                    ' Crop aspect ration
                    AddHandler imgVehicle.Paint, AddressOf ImageUtils.PictureBoxCropFill_Paint
                End If
            Else
                MessageBox.Show("Vehicle not found.")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading vehicle: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not isEditMode Then
            If MsgBox("Are you sure you want to cancel adding this vehicle?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            If MsgBox("Are you sure you want to delete this vehicle?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    Dim query = "UPDATE vehicles SET state='deleted' WHERE id = @id"
                    Dim parameters As New List(Of MySqlParameter) From {
                        New MySqlParameter("@id", editVehicleId)
                    }

                    db.ExecuteNonQuery(query, parameters)
                    MessageBox.Show("Vehicle deleted successfully!")
                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show("Error deleting vehicle: " & ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub ShowDialogAndUpdateCombobox(dialog As Form, cmb As Guna.UI2.WinForms.Guna2ComboBox, dt As DataTable)
        dialog.ShowDialog()
        If dialog.DialogResult = DialogResult.OK Then
            PopulateCombobox()
            db.SelectLastItem(cmb, dt)
        End If
    End Sub
End Class
