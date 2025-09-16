Imports MySql.Data.MySqlClient

Public Class AddVehicle
    Private validator As New FieldValidator
    Private brands As New DataTable
    Private categories As New DataTable
    Private db As New DatabaseHelper()
    Private imageByte As Byte()
    Private Sub TxtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim txt = txtName.Text
        If txt.Length = 0 Then
            lblFormName.Text = "New Vehicle"
        ElseIf txt.Length > 14 Then
            lblFormName.Text = txt.Substring(14) & "..."
        Else
            lblFormName.Text = txt
        End If
    End Sub

    Private Sub ImgVehicle_Click(sender As Object, e As EventArgs) Handles imgVehicle.Click
        imageByte = ImageUtils.SelectImageAndConvertToBytes(imgVehicle)
        ' Add image resize handler
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

        ' Add data to combobox
        ' Refresh the data source instead of clearing Items
        cmbBrand.DataSource = Nothing
        For Each row As DataRow In brands.Rows
            Utils.AddItemToComboBox(cmbBrand, row("id").ToString(), row("name").ToString())
        Next

        ' Add data to combobox
        ' Refresh the data source instead of clearing Items
        cmbCategory.DataSource = Nothing
        For Each row As DataRow In categories.Rows
            Utils.AddItemToComboBox(cmbCategory, row("id").ToString(), row("name").ToString())
        Next

    End Sub

    Private Sub LoadComboBoxes()
        'cmbStatus.Items.Clear()
        'Utils.AddItemToComboBox(cmbStatus, "Available", "Available")
        'Utils.AddItemToComboBox(cmbStatus, "Booked", "Booked")
        'Utils.AddItemToComboBox(cmbStatus, "Rented", "Rented")
        'Utils.AddItemToComboBox(cmbStatus, "Overdue", "Overdue")
        'cmbStatus.SelectedIndex = 0 'This will make sure the first item is selected.

        'Populate from database 
        PopulateCombobox()
        cmbCategory.SelectedIndex = 0
        cmbBrand.SelectedIndex = 0
    End Sub

    Private Sub AddVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComboBoxes()
        Validation()
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
        Dim validate = validator.ValidateAll
        Dim insertQuery As String = " INSERT INTO `vehicles`(`name`, `brand_id`, `model`, `rental_price`, `category_id`, `image`, `number_plate`) 
            VALUES (@name, @brand_id, @model, @rental_price, @category_id, @image, @number_plate);"

        If validate Then

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@name", txtName.Text),
            New MySqlParameter("@brand_id", cmbBrand.SelectedValue), ' Assuming it's bound to a DataTable
            New MySqlParameter("@model", txtModel.Text),
            New MySqlParameter("@rental_price", Decimal.Parse(txtPrice.Text)),
            New MySqlParameter("@category_id", cmbCategory.SelectedValue), ' Also data-bound
            New MySqlParameter("@image", imageByte), ' Assuming you converted image to Byte()
            New MySqlParameter("@number_plate", txtNumberPlate.Text)
        }

            db.ExecuteNonQuery(insertQuery, parameters)
        End If
    End Sub

    Private Sub ShowDialogAndUpdateCombobox(dialog As Form, cmb As Guna.UI2.WinForms.Guna2ComboBox, dt As DataTable)
        dialog.ShowDialog()
        If dialog.DialogResult = DialogResult.OK Then
            PopulateCombobox() ' This should re-assign the DataSource
            db.SelectLastItem(cmb, dt)
        End If
    End Sub


End Class