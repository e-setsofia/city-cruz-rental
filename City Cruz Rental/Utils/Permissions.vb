Public Class Permissions
    Public Shared Function IsAdmin() As Boolean
        If (UserSession.Role.ToLower = "admin") Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
