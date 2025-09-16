Public Class MiniDialog

    Public Query = ""
    Private validator As New FieldValidator()


    Private Sub Validation()
        validator.ClearEntries()
        validator.AddEntry(txtName, lblName, FieldValidator.FieldType.NAME)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Validation()
        Dim validated = validator.ValidateAll()

        If validated Then
            MsgBox("Implement inserting.")
        End If
    End Sub

    Private Sub MiniDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Validation()
    End Sub
End Class