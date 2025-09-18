Imports MySql.Data.MySqlClient

Public Class DashboardControl

    Private originalColor As New Color
    Private entered = False
    Private lblUsers As Object

    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSalesChart()
        LoadDashboardItems()
    End Sub

    Private Sub LoadDashboardItems()
        Using conn As New MySqlConnection(My.Resources.conn)
            Try
                conn.Open()
                Dim customersCount As Double = 0.0
                Dim countTotalCustomers As String = "SELECT COUNT(*) FROM customers c WHERE c.status != 'Deleted' ;"
                Using cmd As New MySqlCommand(countTotalCustomers, conn)
                    customersCount = Convert.ToDouble(cmd.ExecuteScalar())
                    lblCustomers.Text = customersCount.ToString()
                End Using

                Dim countTotalFemales As String = "SELECT COUNT(*) FROM customers c WHERE c.status != 'Deleted' AND gender = 'Female' ;"
                Using cmd As New MySqlCommand(countTotalFemales, conn)
                    Dim femaleCount As Integer = Convert.ToDouble(cmd.ExecuteScalar())
                    lblFemalePercentage.Text = ((femaleCount / customersCount) * 100).ToString + "%"
                    lblMalePercentage.Text = ((customersCount - femaleCount) / customersCount * 100).ToString + "%"
                End Using

                Dim countTotalVehicles As String = "SELECT COUNT(*) FROM vehicles v WHERE v.state != 'Deleted'"
                Using cmd As New MySqlCommand(countTotalVehicles, conn)
                    Dim deletedCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblTotalVehicles.Text = deletedCount.ToString()
                End Using


                Dim sumSales As String = "SELECT SUM(total_price) AS total_sales FROM Rentals;"
                Using cmd As New MySqlCommand(sumSales, conn)
                    Dim deletedCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    lblTotalSales.Text = deletedCount.ToString("N2")
                End Using

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End Using


    End Sub

    ' Mouse enter event handler for all panels
    Private Sub Panel_MouseEnter(sender As Object, e As EventArgs)
        Dim panel As Guna.UI2.WinForms.Guna2Panel = CType(sender, Guna.UI2.WinForms.Guna2Panel)


        ' Change the background and foreground colors on hover
        panel.FillColor = Color.FromArgb(48, 65, 102)

        For Each label As Label In panel.Controls
            label.ForeColor = Color.White
            label.BackColor = Color.Transparent
        Next

    End Sub

    ' Mouse leave event handler for all panels
    Private Sub Panel_MouseLeave(sender As Object, e As EventArgs)
        Dim panel As Guna.UI2.WinForms.Guna2Panel = CType(sender, Guna.UI2.WinForms.Guna2Panel)

        ' Change the background and foreground colors on hover
        panel.FillColor = Color.White

        For Each label As Label In panel.Controls
            label.ForeColor = Color.Black
            label.BackColor = Color.Transparent
        Next

    End Sub


    Private Sub LoadSalesChart()
        Dim connection As New MySqlConnection(My.Resources.conn)

        Try
            connection.Open()

            Dim query As String = "SELECT MONTH(booking_date) AS Month, COUNT(*) AS Total FROM Rentals GROUP BY MONTH(booking_date)"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Clear previous chart setup
            Chart1.Series.Clear()
            Chart1.ChartAreas.Clear()
            Chart1.Titles.Clear()
            Chart1.Legends.Clear()

            ' Chart Area Setup
            Dim ca As New DataVisualization.Charting.ChartArea("Default")
            With ca
                .BackColor = Color.White
                .BorderWidth = 0
                .AxisX.Title = "Month"
                .AxisY.Title = "Total Sales"

                ' X Axis (Month)
                With .AxisX
                    .CustomLabels.Clear()
                    .Minimum = 1
                    .Maximum = 12
                    .Interval = 1
                    .MajorGrid.LineColor = Color.LightGray
                    .LineColor = Color.DarkGray
                    .LabelStyle.Font = New Font("Segoe UI", 9, FontStyle.Regular)
                    .TitleFont = New Font("Segoe UI Semibold", 10)
                    .IsMarginVisible = False
                End With

                ' Y Axis
                With .AxisY
                    .MajorGrid.LineColor = Color.LightGray
                    .LineColor = Color.DarkGray
                    .LabelStyle.Font = New Font("Segoe UI", 9, FontStyle.Regular)
                    .TitleFont = New Font("Segoe UI Semibold", 10)
                End With
            End With
            Chart1.ChartAreas.Add(ca)

            ' Series Setup
            Dim salesSeries As New DataVisualization.Charting.Series("Sales")
            With salesSeries
                .ChartType = DataVisualization.Charting.SeriesChartType.Column
                .Color = Color.FromArgb(33, 150, 243) ' Modern blue (Material Design)
                .BorderWidth = 0
                .IsValueShownAsLabel = True
                .LabelForeColor = Color.DimGray
                .Font = New Font("Segoe UI", 8)
            End With

            ' Build month data
            Dim monthCounts As New Dictionary(Of Integer, Integer)()
            For Each row As DataRow In dt.Rows
                If Not IsDBNull(row("Month")) Then
                    Dim m As Integer = Convert.ToInt32(row("Month"))
                    If m >= 1 AndAlso m <= 12 Then
                        Dim t As Integer = If(IsDBNull(row("Total")), 0, Convert.ToInt32(row("Total")))
                        monthCounts(m) = t
                    End If
                End If
            Next

            ' Add data for all months
            For monthNumber As Integer = 1 To 12
                Dim totalSales As Integer = If(monthCounts.ContainsKey(monthNumber), monthCounts(monthNumber), 0)
                salesSeries.Points.AddXY(monthNumber, totalSales)

                ' Add modern label
                Dim lbl As New DataVisualization.Charting.CustomLabel()
                lbl.FromPosition = monthNumber - 0.5
                lbl.ToPosition = monthNumber + 0.5
                lbl.Text = MonthName(monthNumber).Substring(0, 3)
                lbl.LabelMark = DataVisualization.Charting.LabelMarkStyle.None
                ca.AxisX.CustomLabels.Add(lbl)
            Next

            Chart1.Series.Add(salesSeries)

            ' Optional: Chart Title
            Dim chartTitle As New DataVisualization.Charting.Title("Monthly Sales Overview")
            chartTitle.Font = New Font("Segoe UI Semibold", 12, FontStyle.Bold)
            chartTitle.ForeColor = Color.DimGray
            Chart1.Titles.Add(chartTitle)

            ' Optional: Add legend (if needed in future)
            'Dim legend As New DataVisualization.Charting.Legend("Legend")
            'legend.Font = New Font("Segoe UI", 9)
            'Chart1.Legends.Add(legend)

            ' Optional: Smooth animation or 3D can be disabled for flat look
            ca.Area3DStyle.Enable3D = False

        Catch ex As Exception
            MessageBox.Show("Error loading sales chart: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        LoadDashboardItems()
    End Sub
End Class
