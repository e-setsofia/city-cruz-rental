Imports MySql.Data.MySqlClient

Public Class frmMain
    Dim ActivePosition = 0

    Dim menuItems As MenuItemData() = {
        New MenuItemData("Dashboard", 0, New DashboardControl),
        New MenuItemData("Staff", 1, New StaffControl),
        New MenuItemData("Vehicles", 2, New VehicleControl),
        New MenuItemData("Customers", 3, New CustomerControl),
        New MenuItemData("Book A Car", 4, New Booking)
    } 'New MenuItemData("Reports", 5, New Reports)



    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillUserDetails()
        PopulateMenuItems()
        UpdateMainScreen()
    End Sub

    Private Sub FillUserDetails()
        lblProfileName.Text = UserSession.Fname
        lblJobTItle.Text = "- " + UserSession.JobTitle
    End Sub

    Private Sub PopulateMenuItems()
        ' Adds some controls to flpMenuItems

        For Each item In menuItems
            If (Not UserSession.Role.ToLower = "admin") And item.Name = "Staff" Then

            Else
                flpMenuItems.Controls.Add(CreateMenuItem(item))
            End If
        Next

    End Sub

    Private Sub UpdateMainScreen()
        Dim item = menuItems(ActivePosition)
        Dim page = item.Page
        page.Dock = DockStyle.Fill
        lblTitle.Text = item.Name
        pnlMain.Controls.Clear()
        pnlMain.Controls.Add(page)
    End Sub

    Private Function CreateMenuItem(item As MenuItemData)

        Dim button = New Guna.UI2.WinForms.Guna2Button   ' This creates a new Guna Button.

        Dim foreground = Color.FromArgb(0, 0, 0)
        Dim background = Color.FromArgb(240, 245, 253)

        If Not ActivePosition = item.Position Then
            foreground = Color.FromArgb(255, 255, 255)
            background = Color.FromArgb(48, 65, 102)
        Else
            foreground = Color.FromArgb(0, 0, 0)
            background = Color.FromArgb(240, 245, 253)
        End If

        ' This describes the new guna button
        button.Text = item.Name
        button.BorderRadius = 16
        button.FillColor = background
        button.ForeColor = foreground
        button.Size = New Size(199, 45)
        button.Tag = item.Position ' Store position in Tag

        ' Add Click handler
        AddHandler button.Click, AddressOf MenuItem_Click

        Return button
    End Function

    Private Sub MenuItem_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        Dim position As Int16 = Convert.ToInt16(clickedButton.Tag)

        ' Update the active position
        ActivePosition = position

        ' Refresh the menu items
        flpMenuItems.Controls.Clear()
        PopulateMenuItems()
        UpdateMainScreen()
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide() ' Hide the current user’s form

        ' Open a fresh login form
        Dim loginForm As New Login()
        loginForm.Show()

        ' Optionally dispose this form if you want it reset completely
        Me.Dispose()
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Search.SearchResult = txtSearch.Text
    End Sub
End Class