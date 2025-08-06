Public Class DashboardControl

    Private originalColor As New Color
    Private entered = False

    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardItems()
    End Sub

    Private Sub LoadDashboardItems()
        lblUsers.Text = Queries.CountUsers()
        lblTotalVehicles.Text = Queries.CountVehicles
        lblVehiclesRented.Text = Queries.CountVehiclesRented

    End Sub

    ' Mouse enter event handler for all panels
    Private Sub Panel_MouseEnter(sender As Object, e As EventArgs) Handles pnlVehicles.MouseEnter
        Dim panel As Guna.UI2.WinForms.Guna2Panel = CType(sender, Guna.UI2.WinForms.Guna2Panel)


        ' Change the background and foreground colors on hover
        panel.FillColor = Color.FromArgb(48, 65, 102)

        For Each label As Label In panel.Controls
            label.ForeColor = Color.White
            label.BackColor = Color.Transparent
        Next

    End Sub

    ' Mouse leave event handler for all panels
    Private Sub Panel_MouseLeave(sender As Object, e As EventArgs) Handles pnlVehicles.MouseEnter, pnlVehicles.MouseLeave
        Dim panel As Guna.UI2.WinForms.Guna2Panel = CType(sender, Guna.UI2.WinForms.Guna2Panel)

        ' Change the background and foreground colors on hover
        panel.FillColor = Color.White

        For Each label As Label In panel.Controls
            label.ForeColor = Color.Black
            label.BackColor = Color.Transparent
        Next

    End Sub

End Class
