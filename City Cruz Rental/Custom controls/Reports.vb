Imports Microsoft.Win32

Public Class Reports
    Private Sub SetBrowserEmulationMode()
        Dim exeName As String = System.IO.Path.GetFileName(Application.ExecutablePath)

        Using key As RegistryKey = Registry.CurrentUser.CreateSubKey(
        "Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION",
        RegistryKeyPermissionCheck.ReadWriteSubTree)

            ' 11001 = IE11 Edge mode
            key.SetValue(exeName, 11001, RegistryValueKind.DWord)
        End Using
    End Sub
    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Force IE11 engine
        SetBrowserEmulationMode()

        ' Load your report with relative path
        Dim reportPath As String = IO.Path.GetFullPath("..\..\Reports\VehiclesReport.html")
        WebBrowser1.Url = New Uri(reportPath)
    End Sub

End Class
