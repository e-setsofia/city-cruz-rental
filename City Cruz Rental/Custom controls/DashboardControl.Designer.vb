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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlVehicles = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblMale = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFemale = New System.Windows.Forms.Label()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1075, 745)
        Me.Panel1.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel9)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(646, 58)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(429, 687)
        Me.Panel5.TabIndex = 6
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 422)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(429, 265)
        Me.Panel9.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 114)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(429, 534)
        Me.Panel8.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(429, 114)
        Me.Panel7.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Guna2Panel1)
        Me.Panel4.Controls.Add(Me.pnlVehicles)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 58)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel4.Size = New System.Drawing.Size(640, 687)
        Me.Panel4.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Chart1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(4, 290)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(4)
        Me.Panel6.Size = New System.Drawing.Size(632, 393)
        Me.Panel6.TabIndex = 9
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(4, 4)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.Name = "Sales"
        Series1.YValuesPerPoint = 4
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(624, 385)
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
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Location = New System.Drawing.Point(319, 30)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(290, 236)
        Me.Guna2Panel1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(20, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(21, 0, 0, 5)
        Me.Label3.Size = New System.Drawing.Size(147, 28)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total Vehicles"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 40.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(30, 40)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 81)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "25"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pnlVehicles
        '
        Me.pnlVehicles.BorderColor = System.Drawing.SystemColors.Control
        Me.pnlVehicles.BorderRadius = 24
        Me.pnlVehicles.BorderThickness = 1
        Me.pnlVehicles.Controls.Add(Me.Label9)
        Me.pnlVehicles.Controls.Add(Me.lblMale)
        Me.pnlVehicles.Controls.Add(Me.Label8)
        Me.pnlVehicles.Controls.Add(Me.lblFemale)
        Me.pnlVehicles.Controls.Add(Me.Guna2VSeparator1)
        Me.pnlVehicles.Controls.Add(Me.Label1)
        Me.pnlVehicles.Controls.Add(Me.lblUser)
        Me.pnlVehicles.Location = New System.Drawing.Point(7, 30)
        Me.pnlVehicles.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlVehicles.Name = "pnlVehicles"
        Me.pnlVehicles.Size = New System.Drawing.Size(304, 236)
        Me.pnlVehicles.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(223, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "25%"
        '
        'lblMale
        '
        Me.lblMale.AutoSize = True
        Me.lblMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMale.Location = New System.Drawing.Point(210, 153)
        Me.lblMale.Name = "lblMale"
        Me.lblMale.Size = New System.Drawing.Size(59, 25)
        Me.lblMale.TabIndex = 5
        Me.lblMale.Text = "Male"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "25%"
        '
        'lblFemale
        '
        Me.lblFemale.AutoSize = True
        Me.lblFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFemale.Location = New System.Drawing.Point(44, 156)
        Me.lblFemale.Name = "lblFemale"
        Me.lblFemale.Size = New System.Drawing.Size(83, 25)
        Me.lblFemale.TabIndex = 4
        Me.lblFemale.Text = "Female"
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(153, 143)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(18, 75)
        Me.Guna2VSeparator1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(20, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(21, 0, 0, 5)
        Me.Label1.Size = New System.Drawing.Size(169, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Customers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblUser.Location = New System.Drawing.Point(59, 42)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(98, 81)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "25"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1075, 58)
        Me.Panel2.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(212, 59)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Analytics"
        '
        'DashboardControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DashboardControl"
        Me.Size = New System.Drawing.Size(1075, 745)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlVehicles As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents lblMale As Label
    Friend WithEvents lblFemale As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
