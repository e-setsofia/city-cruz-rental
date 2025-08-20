Public Class frmSplashScreen
    Dim progress = 99
    Dim activatedForm = False
    Private Sub timerProgress_Tick(sender As Object, e As EventArgs) Handles timerProgress.Tick
        progress += 1
        If Progress < 100 Then
            prgProgress.Value = Progress
            lblProgress.Text = Progress.ToString + "%"
        ElseIf activatedForm = False Then
            Login.Show()
            Me.Close()
            activatedForm = True
        End If
    End Sub


End Class
