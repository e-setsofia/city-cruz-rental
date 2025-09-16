Public Class AddVehicle
    Private validator As New FieldValidator
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
        MsgBox("To be handled later")
    End Sub

    Private Sub Validation()
        validator.ClearEntries()
        validator.AddEntry(txtName, lblName, FieldValidator.FieldType.NAME)
        validator.AddEntry(txtPrice, lblPrice, FieldValidator.FieldType.MONEY)
        validator.AddEntry(txtNumberPlate, lblNumberPlate, FieldValidator.FieldType.NAME)
    End Sub

    Private Sub LoadComboBoxes()
        cmbStatus.Items.Clear()
        Utils.AddItemToComboBox(cmbStatus, "Available", "Available")
        Utils.AddItemToComboBox(cmbStatus, "Booked", "Booked")
        Utils.AddItemToComboBox(cmbStatus, "Rented", "Rented")
        Utils.AddItemToComboBox(cmbStatus, "Overdue", "Overdue")
        cmbStatus.SelectedIndex = 0 'This will make sure the first item is selected.

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
        dialog.ShowDialog()
    End Sub

    Private Sub BtnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        Dim dialog = New MiniDialog
        dialog.lblFormName.Text = "New Category"
        dialog.lblName.Text = "Category:"
        dialog.Query = "INSERT INTO `categories`( `name`) VALUES (@value)"
        dialog.ShowDialog()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Validation()
        Dim validate = validator.ValidateAll

        If validate Then
            MsgBox("Implement vehicle add")
        End If
    End Sub
End Class