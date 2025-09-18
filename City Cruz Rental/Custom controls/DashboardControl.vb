Imports MySql.Data.MySqlClient

Public Class DashboardControl

    Private originalColor As New Color
    Private entered = False
    Private lblUsers As Object

    Private Sub DashboardControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSalesChart()
        ' LoadDashboardItems()
    End Sub

    Private Sub LoadDashboardItems()
        ' lblUsers.Text = Queries.CountUsers()
        '   lblTotalVehicles.Text = Queries.CountVehicles
        '  lblVehiclesRented.Text = Queries.CountVehiclesRented

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

            ' Ensure chart area exists
            If Chart1.ChartAreas.Count = 0 Then
                Chart1.ChartAreas.Add(New DataVisualization.Charting.ChartArea("Default"))
            End If

            Dim ca = Chart1.ChartAreas(0)

            ' Configure the X axis to span months 1..12
            With ca.AxisX
                .CustomLabels.Clear()
                .Minimum = 1
                .Maximum = 12
                .Interval = 1
                .IsMarginVisible = False
                .LabelAutoFitStyle = DataVisualization.Charting.LabelAutoFitStyles.None
                .MajorGrid.LineColor = Color.LightGray
            End With

            ca.AxisY.MajorGrid.LineColor = Color.LightGray

            ' Prepare series
            Dim salesSeries As DataVisualization.Charting.Series
            If Chart1.Series.IndexOf("Sales") >= 0 Then
                salesSeries = Chart1.Series("Sales")
                salesSeries.Points.Clear()
            Else
                salesSeries = New DataVisualization.Charting.Series("Sales")
                salesSeries.ChartType = DataVisualization.Charting.SeriesChartType.Column
                salesSeries.XValueType = DataVisualization.Charting.ChartValueType.Int32
                Chart1.Series.Add(salesSeries)
            End If

            ' Build lookup for totals by month
            Dim monthCounts As New Dictionary(Of Integer, Integer)()
            For Each row As DataRow In dt.Rows
                If Not IsDBNull(row("Month")) Then
                    Dim m As Integer = Convert.ToInt32(row("Month"))
                    If m >= 1 AndAlso m <= 12 Then
                        Dim t As Integer = 0
                        If Not IsDBNull(row("Total")) Then
                            t = Convert.ToInt32(row("Total"))
                        End If
                        monthCounts(m) = t
                    End If
                End If
            Next

            ' Now add data & labels for all months Jan-Dec
            For monthNumber As Integer = 1 To 12
                Dim totalSales As Integer = 0
                If monthCounts.ContainsKey(monthNumber) Then
                    totalSales = monthCounts(monthNumber)
                End If

                Dim month As String = MonthName(monthNumber).Substring(0, 3) ' ful1 month name

                salesSeries.Points.AddXY(monthNumber, totalSales)

                ' Add custom label
                Dim lbl As New DataVisualization.Charting.CustomLabel()
                lbl.FromPosition = monthNumber - 0.5
                lbl.ToPosition = monthNumber + 0.5
                lbl.Text = month
                lbl.RowIndex = 0
                lbl.LabelMark = DataVisualization.Charting.LabelMarkStyle.None
                ca.AxisX.CustomLabels.Add(lbl)
            Next

            ' Titles
            ca.AxisX.Title = "Month"
            ca.AxisY.Title = "Total Sales"

        Catch ex As Exception
            MessageBox.Show("Error loading sales chart: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub








End Class
