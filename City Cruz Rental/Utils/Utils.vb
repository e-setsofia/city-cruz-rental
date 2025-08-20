Public Class Utils
    Public Shared Sub AddItemToComboBox(cmb As ComboBox, id As String, name As String)
        ' If the ComboBox has no DataSource yet, create a new DataTable and bind it
        If cmb.DataSource Is Nothing Then
            Dim dt As New DataTable()
            dt.Columns.Add("id", GetType(String))
            dt.Columns.Add("name", GetType(String))

            cmb.DataSource = dt
            cmb.DisplayMember = "name"
            cmb.ValueMember = "id"
        End If

        ' Get the bound DataTable
        Dim dataSource As DataTable = CType(cmb.DataSource, DataTable)

        ' Add the new item
        dataSource.Rows.Add(id, name)
    End Sub
End Class
