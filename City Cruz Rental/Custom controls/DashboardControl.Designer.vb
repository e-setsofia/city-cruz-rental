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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalVehicles = New System.Windows.Forms.Label()
        Me.pnlVehicles = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblMalePercentage = New System.Windows.Forms.Label()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.lblFemalePercentage = New System.Windows.Forms.Label()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCustomers = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.pnlVehicles.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 605)
        Me.Panel1.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(484, 47)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(322, 558)
        Me.Panel5.TabIndex = 6
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 343)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(322, 215)
        Me.Panel9.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 93)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(322, 434)
        Me.Panel8.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(322, 93)
        Me.Panel7.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Guna2Panel1)
        Me.Panel4.Controls.Add(Me.pnlVehicles)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 47)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.Panel4.Size = New System.Drawing.Size(480, 558)
        Me.Panel4.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Chart1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(3, 236)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.Panel6.Size = New System.Drawing.Size(474, 319)
        Me.Panel6.TabIndex = 9
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 3)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.Name = "Sales"
        Series1.YValuesPerPoint = 4
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(468, 313)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Me.Chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel1.BorderRadius = 24
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.lblTotalVehicles)
        Me.Guna2Panel1.Location = New System.Drawing.Point(239, 24)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(218, 192)
        Me.Guna2Panel1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(16, 0, 0, 4)
        Me.Label3.Size = New System.Drawing.Size(114, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total Vehicles"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTotalVehicles
        '
        Me.lblTotalVehicles.AutoSize = True
        Me.lblTotalVehicles.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalVehicles.Location = New System.Drawing.Point(22, 32)
        Me.lblTotalVehicles.Name = "lblTotalVehicles"
        Me.lblTotalVehicles.Size = New System.Drawing.Size(79, 65)
        Me.lblTotalVehicles.TabIndex = 0
        Me.lblTotalVehicles.Text = "25"
        Me.lblTotalVehicles.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlVehicles
        '
        Me.pnlVehicles.BorderColor = System.Drawing.SystemColors.Control
        Me.pnlVehicles.BorderRadius = 24
        Me.pnlVehicles.BorderThickness = 1
        Me.pnlVehicles.Controls.Add(Me.lblMalePercentage)
        Me.pnlVehicles.Controls.Add(Me.lblMale)
        Me.pnlVehicles.Controls.Add(Me.lblFemalePercentage)
        Me.pnlVehicles.Controls.Add(Me.lblFemale)
        Me.pnlVehicles.Controls.Add(Me.Guna2VSeparator1)
        Me.pnlVehicles.Controls.Add(Me.Label1)
        Me.pnlVehicles.Controls.Add(Me.lblCustomers)
        Me.pnlVehicles.Location = New System.Drawing.Point(5, 24)
        Me.pnlVehicles.Name = "pnlVehicles"
        Me.pnlVehicles.Size = New System.Drawing.Size(228, 192)
        Me.pnlVehicles.TabIndex = 7
        '
        'lblMalePercentage
        '
        Me.lblMalePercentage.AutoSize = True
        Me.lblMalePercentage.Location = New System.Drawing.Point(167, 163)
        Me.lblMalePercentage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMalePercentage.Name = "lblMalePercentage"
        Me.lblMalePercentage.Size = New System.Drawing.Size(27, 13)
        Me.lblMalePercentage.TabIndex = 5
        Me.lblMalePercentage.Text = "25%"
        '
        'lblMale
        '
        Me.lblMale.AutoSize = True
        Me.lblMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMale.Location = New System.Drawing.Point(158, 124)
        Me.lblMale.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMale.Name = "lblMale"
        Me.lblMale.Size = New System.Drawing.Size(47, 20)
        Me.lblMale.TabIndex = 5
        Me.lblMale.Text = "Male"
        '
        'lblFemalePercentage
        '
        Me.lblFemalePercentage.AutoSize = True
        Me.lblFemalePercentage.Location = New System.Drawing.Point(40, 163)
        Me.lblFemalePercentage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFemalePercentage.Name = "lblFemalePercentage"
        Me.lblFemalePercentage.Size = New System.Drawing.Size(27, 13)
        Me.lblFemalePercentage.TabIndex = 4
        Me.lblFemalePercentage.Text = "25%"
        '
        'lblFemale
        '
        Me.lblFemale.AutoSize = True
        Me.lblFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemale.Location = New System.Drawing.Point(33, 127)
        Me.lblFemale.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.Size = New System.Drawing.Size(68, 20)
        Me.lblFemale.TabIndex = 4
        Me.lblFemale.Text = "Female"
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(115, 116)
        Me.Guna2VSeparator1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(14, 61)
        Me.Guna2VSeparator1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(16, 0, 0, 4)
        Me.Label1.Size = New System.Drawing.Size(132, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Customers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCustomers
        '
        Me.lblCustomers.AutoSize = True
        Me.lblCustomers.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblCustomers.Location = New System.Drawing.Point(44, 34)
        Me.lblCustomers.Name = "lblCustomers"
        Me.lblCustomers.Size = New System.Drawing.Size(79, 65)
        Me.lblCustomers.TabIndex = 0
        Me.lblCustomers.Text = "25"
        Me.lblCustomers.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(806, 47)
        Me.Panel2.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 47)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Analytics"
        '
        'DashboardControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Name = "DashboardControl"
        Me.Size = New System.Drawing.Size(806, 605)
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.pnlVehicles.ResumeLayout(False)
        Me.pnlVehicles.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalVehicles As Label
    Friend WithEvents pnlVehicles As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCustomers As Label
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents lblMale As Label
    Friend WithEvents lblFemale As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents lblMalePercentage As Label
    Friend WithEvents lblFemalePercentage As Label
End Class
