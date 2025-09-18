<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtgBooking = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBookedVehicles = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBookVehicle = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblOverdue = New System.Windows.Forms.Label()
        Me.lblQueryName = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblReserved = New System.Windows.Forms.Label()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.dtgBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgBooking
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dtgBooking.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgBooking.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgBooking.ColumnHeadersHeight = 30
        Me.dtgBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgBooking.DefaultCellStyle = DataGridViewCellStyle6
        Me.dtgBooking.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgBooking.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgBooking.Location = New System.Drawing.Point(36, 36)
        Me.dtgBooking.Margin = New System.Windows.Forms.Padding(2)
        Me.dtgBooking.Name = "dtgBooking"
        Me.dtgBooking.RowHeadersVisible = False
        Me.dtgBooking.RowHeadersWidth = 51
        Me.dtgBooking.RowTemplate.Height = 24
        Me.dtgBooking.Size = New System.Drawing.Size(718, 300)
        Me.dtgBooking.TabIndex = 0
        Me.dtgBooking.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgBooking.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dtgBooking.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dtgBooking.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dtgBooking.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dtgBooking.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dtgBooking.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgBooking.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.dtgBooking.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgBooking.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgBooking.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtgBooking.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtgBooking.ThemeStyle.HeaderStyle.Height = 30
        Me.dtgBooking.ThemeStyle.ReadOnly = False
        Me.dtgBooking.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgBooking.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgBooking.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgBooking.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtgBooking.ThemeStyle.RowsStyle.Height = 24
        Me.dtgBooking.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgBooking.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel1.BorderRadius = 24
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.lblBookedVehicles)
        Me.Guna2Panel1.Location = New System.Drawing.Point(25, 20)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(182, 98)
        Me.Guna2Panel1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(16, 0, 0, 4)
        Me.Label2.Size = New System.Drawing.Size(168, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Booked Vehicles"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblBookedVehicles
        '
        Me.lblBookedVehicles.AutoSize = True
        Me.lblBookedVehicles.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblBookedVehicles.Location = New System.Drawing.Point(60, 10)
        Me.lblBookedVehicles.Name = "lblBookedVehicles"
        Me.lblBookedVehicles.Size = New System.Drawing.Size(79, 65)
        Me.lblBookedVehicles.TabIndex = 0
        Me.lblBookedVehicles.Text = "25"
        Me.lblBookedVehicles.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtgBooking)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 218)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(36)
        Me.Panel2.Size = New System.Drawing.Size(790, 372)
        Me.Panel2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(621, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Book Vehicle"
        '
        'btnBookVehicle
        '
        Me.btnBookVehicle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBookVehicle.BorderRadius = 16
        Me.btnBookVehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBookVehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBookVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBookVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBookVehicle.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookVehicle.ForeColor = System.Drawing.Color.White
        Me.btnBookVehicle.Location = New System.Drawing.Point(634, 20)
        Me.btnBookVehicle.Name = "btnBookVehicle"
        Me.btnBookVehicle.Size = New System.Drawing.Size(53, 75)
        Me.btnBookVehicle.TabIndex = 11
        Me.btnBookVehicle.Text = "+"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.Guna2Panel3)
        Me.Panel1.Controls.Add(Me.lblQueryName)
        Me.Panel1.Controls.Add(Me.Guna2Separator1)
        Me.Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Panel1.Controls.Add(Me.Guna2Panel1)
        Me.Panel1.Controls.Add(Me.btnBookVehicle)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 218)
        Me.Panel1.TabIndex = 9
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel3.BorderRadius = 24
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.Label6)
        Me.Guna2Panel3.Controls.Add(Me.lblOverdue)
        Me.Guna2Panel3.Location = New System.Drawing.Point(420, 20)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(182, 98)
        Me.Guna2Panel3.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 67)
        Me.Label6.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(16, 0, 0, 4)
        Me.Label6.Size = New System.Drawing.Size(139, 22)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Overdue Vehicles"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblOverdue
        '
        Me.lblOverdue.AutoSize = True
        Me.lblOverdue.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblOverdue.ForeColor = System.Drawing.Color.Tomato
        Me.lblOverdue.Location = New System.Drawing.Point(58, 10)
        Me.lblOverdue.Name = "lblOverdue"
        Me.lblOverdue.Size = New System.Drawing.Size(79, 65)
        Me.lblOverdue.TabIndex = 0
        Me.lblOverdue.Text = "25"
        Me.lblOverdue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblQueryName
        '
        Me.lblQueryName.AutoSize = True
        Me.lblQueryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQueryName.Location = New System.Drawing.Point(19, 154)
        Me.lblQueryName.Name = "lblQueryName"
        Me.lblQueryName.Size = New System.Drawing.Size(522, 55)
        Me.lblQueryName.TabIndex = 51
        Me.lblQueryName.Text = "Total Booked Vehicles"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Separator1.Location = New System.Drawing.Point(0, 208)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(790, 10)
        Me.Guna2Separator1.TabIndex = 50
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.SystemColors.Control
        Me.Guna2Panel2.BorderRadius = 24
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.lblReserved)
        Me.Guna2Panel2.Location = New System.Drawing.Point(222, 20)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(182, 98)
        Me.Guna2Panel2.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 67)
        Me.Label4.Margin = New System.Windows.Forms.Padding(15, 0, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(16, 0, 0, 4)
        Me.Label4.Size = New System.Drawing.Size(147, 22)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Reserved Vehicles"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblReserved
        '
        Me.lblReserved.AutoSize = True
        Me.lblReserved.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 40.0!, System.Drawing.FontStyle.Bold)
        Me.lblReserved.Location = New System.Drawing.Point(62, 10)
        Me.lblReserved.Name = "lblReserved"
        Me.lblReserved.Size = New System.Drawing.Size(79, 65)
        Me.lblReserved.TabIndex = 0
        Me.lblReserved.Text = "25"
        Me.lblReserved.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdate.AutoRoundedCorners = True
        Me.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(688, 177)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(66, 32)
        Me.btnUpdate.TabIndex = 52
        Me.btnUpdate.Text = "Update"
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Booking"
        Me.Size = New System.Drawing.Size(790, 590)
        CType(Me.dtgBooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgBooking As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBookedVehicles As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBookVehicle As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblReserved As Label
    Friend WithEvents lblQueryName As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblOverdue As Label
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
End Class
