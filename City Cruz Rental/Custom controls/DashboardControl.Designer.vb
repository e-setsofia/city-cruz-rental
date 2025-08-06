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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.pnlVehicles = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblVehiclesRented = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalVehicles = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.pnlVehicles.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel1.BorderRadius = 24
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.lblUsers)
        Me.Guna2Panel1.Location = New System.Drawing.Point(40, 24)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(114, 78)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(16, 0, 0, 4)
        Me.Label2.Size = New System.Drawing.Size(99, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Users"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsers.Location = New System.Drawing.Point(20, 0)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(79, 65)
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
        Me.pnlVehicles.Location = New System.Drawing.Point(269, 24)
        Me.pnlVehicles.Name = "pnlVehicles"
        Me.pnlVehicles.Size = New System.Drawing.Size(126, 78)
        Me.pnlVehicles.TabIndex = 2
        '
        'lblVehiclesRented
        '
        Me.lblVehiclesRented.AutoSize = True
        Me.lblVehiclesRented.Font = New System.Drawing.Font("Bahnschrift Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehiclesRented.ForeColor = System.Drawing.Color.Red
        Me.lblVehiclesRented.Location = New System.Drawing.Point(85, 33)
        Me.lblVehiclesRented.Name = "lblVehiclesRented"
        Me.lblVehiclesRented.Size = New System.Drawing.Size(26, 23)
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
        Me.Label1.Location = New System.Drawing.Point(0, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(16, 0, 0, 4)
        Me.Label1.Size = New System.Drawing.Size(114, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Vehicles"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTotalVehicles
        '
        Me.lblTotalVehicles.AutoSize = True
        Me.lblTotalVehicles.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalVehicles.Location = New System.Drawing.Point(20, 0)
        Me.lblTotalVehicles.Name = "lblTotalVehicles"
        Me.lblTotalVehicles.Size = New System.Drawing.Size(79, 65)
        Me.lblTotalVehicles.TabIndex = 0
        Me.lblTotalVehicles.Text = "25"
        Me.lblTotalVehicles.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DashboardControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pnlVehicles)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "DashboardControl"
        Me.Size = New System.Drawing.Size(806, 605)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.pnlVehicles.ResumeLayout(False)
        Me.pnlVehicles.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblUsers As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlVehicles As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblVehiclesRented As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalVehicles As Label
End Class
