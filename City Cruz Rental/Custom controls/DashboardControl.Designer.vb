<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.pnlVehicles = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblVehiclesRented = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalVehicles = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.pnlVehicles.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1075, 745)
        Me.Panel1.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 554)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1075, 191)
        Me.Panel4.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Chart1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 170)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1075, 384)
        Me.Panel3.TabIndex = 4
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(37, 34)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(983, 350)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Guna2Panel1)
        Me.Panel2.Controls.Add(Me.pnlVehicles)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1075, 170)
        Me.Panel2.TabIndex = 3
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel1.BorderRadius = 24
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.lblUsers)
        Me.Guna2Panel1.Location = New System.Drawing.Point(37, 25)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(193, 121)
        Me.Guna2Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(20, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(21, 0, 0, 5)
        Me.Label2.Size = New System.Drawing.Size(126, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Users"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsers.Location = New System.Drawing.Point(48, 12)
        Me.lblUsers.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(98, 81)
        Me.lblUsers.TabIndex = 0
        Me.lblUsers.Text = "25"
        Me.lblUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlVehicles
        '
        Me.pnlVehicles.BorderColor = System.Drawing.SystemColors.Control
        Me.pnlVehicles.BorderRadius = 24
        Me.pnlVehicles.BorderThickness = 1
        Me.pnlVehicles.Controls.Add(Me.lblVehiclesRented)
        Me.pnlVehicles.Controls.Add(Me.Label1)
        Me.pnlVehicles.Controls.Add(Me.lblTotalVehicles)
        Me.pnlVehicles.Location = New System.Drawing.Point(352, 25)
        Me.pnlVehicles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlVehicles.Name = "pnlVehicles"
        Me.pnlVehicles.Size = New System.Drawing.Size(184, 121)
        Me.pnlVehicles.TabIndex = 4
        '
        'lblVehiclesRented
        '
        Me.lblVehiclesRented.AutoSize = True
        Me.lblVehiclesRented.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehiclesRented.ForeColor = System.Drawing.Color.Red
        Me.lblVehiclesRented.Location = New System.Drawing.Point(113, 41)
        Me.lblVehiclesRented.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVehiclesRented.Name = "lblVehiclesRented"
        Me.lblVehiclesRented.Size = New System.Drawing.Size(33, 29)
        Me.lblVehiclesRented.TabIndex = 2
        Me.lblVehiclesRented.Text = "25"
        Me.lblVehiclesRented.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(20, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(21, 0, 0, 5)
        Me.Label1.Size = New System.Drawing.Size(147, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Vehicles"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTotalVehicles
        '
        Me.lblTotalVehicles.AutoSize = True
        Me.lblTotalVehicles.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalVehicles.Location = New System.Drawing.Point(24, 2)
        Me.lblTotalVehicles.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalVehicles.Name = "lblTotalVehicles"
        Me.lblTotalVehicles.Size = New System.Drawing.Size(98, 81)
        Me.lblTotalVehicles.TabIndex = 0
        Me.lblTotalVehicles.Text = "25"
        Me.lblTotalVehicles.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DashboardControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DashboardControl"
        Me.Size = New System.Drawing.Size(1075, 745)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.pnlVehicles.ResumeLayout(False)
        Me.pnlVehicles.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUsers As Label
    Friend WithEvents pnlVehicles As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblVehiclesRented As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalVehicles As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
