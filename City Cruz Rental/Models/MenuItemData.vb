Public Class MenuItemData
    Public Property Name As String
    Public Property Position As Integer
    Public Property Page As UserControl

    Public Sub New(name As String, position As Integer, userControl As UserControl)
        Me.Name = name
        Me.Position = position
        Me.Page = userControl
    End Sub

End Class
