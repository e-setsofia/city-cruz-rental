Public Class Search
    ' Backing field
    Private Shared _searchResult As String

    ' Event that fires whenever SearchResult changes
    Public Shared Event SearchResultChanged(newValue As String)

    ' Shared property with logic
    Public Shared Property SearchResult As String
        Get
            Return _searchResult
        End Get
        Set(value As String)
            If _searchResult <> value Then
                _searchResult = value
                ' Raise event when the value changes
                RaiseEvent SearchResultChanged(value)
            End If
        End Set
    End Property

    ' Dynamic filteration.
    Public Shared Sub FilterVehicles(searchText As String,
                                     dataGridView As Guna.UI2.WinForms.Guna2DataGridView,
                                     ParamArray columnsToSearch() As String)

        Dim dv As DataView = CType(dataGridView.DataSource, DataView)

        ' Escape single quotes to prevent filter errors
        Dim safeSearch As String = searchText.Replace("'", "''")

        ' Build filter dynamically from the given columns
        Dim filterParts As New List(Of String)
        For Each col As String In columnsToSearch
            filterParts.Add(String.Format("{0} LIKE '%{1}%'", col, safeSearch))
        Next

        ' Join with OR
        dv.RowFilter = String.Join(" OR ", filterParts)
    End Sub


End Class
