<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VehicleControl
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.dpRentalPrice = New City_Cruz_Rental.DataPair()
        Me.dpNumberPlate = New City_Cruz_Rental.DataPair()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.pnlAddVehicle = New System.Windows.Forms.Panel()
        Me.btnAddVehicle = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblFormName = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.imgCar = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dpStatus = New City_Cruz_Rental.DataPair()
        Me.dpModel = New City_Cruz_Rental.DataPair()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtgVehicles = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.pnlAddVehicle.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.imgCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(32)
        Me.Panel1.Size = New System.Drawing.Size(876, 269)
        Me.Panel1.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel9, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlAddVehicle, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnUpdate, 3, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(32, 32)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(812, 205)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.dpRentalPrice)
        Me.Panel9.Controls.Add(Me.dpNumberPlate)
        Me.Panel9.Controls.Add(Me.Panel8)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(559, 91)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(150, 82)
        Me.Panel9.TabIndex = 15
        '
        'dpRentalPrice
        '
        Me.dpRentalPrice.BackColor = System.Drawing.Color.Transparent
        Me.dpRentalPrice.Dock = System.Windows.Forms.DockStyle.Top
        Me.dpRentalPrice.LabelText = "Rent Price"
        Me.dpRentalPrice.Location = New System.Drawing.Point(24, 48)
        Me.dpRentalPrice.Name = "dpRentalPrice"
        Me.dpRentalPrice.Size = New System.Drawing.Size(126, 43)
        Me.dpRentalPrice.TabIndex = 11
        Me.dpRentalPrice.ValueText = "Stephen Bimpong"
        '
        'dpNumberPlate
        '
        Me.dpNumberPlate.BackColor = System.Drawing.Color.Transparent
        Me.dpNumberPlate.Dock = System.Windows.Forms.DockStyle.Top
        Me.dpNumberPlate.LabelText = "Number Plate"
        Me.dpNumberPlate.Location = New System.Drawing.Point(24, 0)
        Me.dpNumberPlate.Name = "dpNumberPlate"
        Me.dpNumberPlate.Size = New System.Drawing.Size(126, 48)
        Me.dpNumberPlate.TabIndex = 12
        Me.dpNumberPlate.ValueText = "Stephen Bimpong"
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(24, 82)
        Me.Panel8.TabIndex = 13
        '
        'pnlAddVehicle
        '
        Me.pnlAddVehicle.Controls.Add(Me.btnAddVehicle)
        Me.pnlAddVehicle.Controls.Add(Me.Label8)
        Me.pnlAddVehicle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAddVehicle.Location = New System.Drawing.Point(715, 3)
        Me.pnlAddVehicle.Name = "pnlAddVehicle"
        Me.TableLayoutPanel1.SetRowSpan(Me.pnlAddVehicle, 2)
        Me.pnlAddVehicle.Size = New System.Drawing.Size(94, 170)
        Me.pnlAddVehicle.TabIndex = 6
        Me.pnlAddVehicle.Visible = False
        '
        'btnAddVehicle
        '
        Me.btnAddVehicle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddVehicle.BorderRadius = 16
        Me.btnAddVehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddVehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddVehicle.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddVehicle.ForeColor = System.Drawing.Color.White
        Me.btnAddVehicle.Location = New System.Drawing.Point(21, 21)
        Me.btnAddVehicle.Name = "btnAddVehicle"
        Me.btnAddVehicle.Size = New System.Drawing.Size(53, 115)
        Me.btnAddVehicle.TabIndex = 15
        Me.btnAddVehicle.Text = "+"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Add Vehicle"
        '
        'Guna2Panel1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Guna2Panel1, 2)
        Me.Guna2Panel1.Controls.Add(Me.Panel5)
        Me.Guna2Panel1.Controls.Add(Me.lblFormName)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel1.Controls.Add(Me.Panel3)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(403, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(306, 82)
        Me.Guna2Panel1.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(282, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(24, 72)
        Me.Panel5.TabIndex = 53
        '
        'lblFormName
        '
        Me.lblFormName.AutoSize = True
        Me.lblFormName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFormName.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormName.Location = New System.Drawing.Point(24, 0)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(319, 73)
        Me.lblFormName.TabIndex = 52
        Me.lblFormName.Text = "New Staff"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Separator1.Location = New System.Drawing.Point(24, 72)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(282, 10)
        Me.Guna2Separator1.TabIndex = 51
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(24, 82)
        Me.Panel3.TabIndex = 0
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderRadius = 16
        Me.Guna2Panel2.Controls.Add(Me.imgCar)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.TableLayoutPanel1.SetRowSpan(Me.Guna2Panel2, 2)
        Me.Guna2Panel2.Size = New System.Drawing.Size(394, 170)
        Me.Guna2Panel2.TabIndex = 4
        '
        'imgCar
        '
        Me.imgCar.BorderRadius = 16
        Me.imgCar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgCar.Image = Global.City_Cruz_Rental.My.Resources.Resources.benz1
        Me.imgCar.ImageRotate = 0!
        Me.imgCar.Location = New System.Drawing.Point(0, 0)
        Me.imgCar.Name = "imgCar"
        Me.imgCar.Size = New System.Drawing.Size(394, 170)
        Me.imgCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imgCar.TabIndex = 3
        Me.imgCar.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dpStatus)
        Me.Panel6.Controls.Add(Me.dpModel)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(403, 91)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(150, 82)
        Me.Panel6.TabIndex = 7
        '
        'dpStatus
        '
        Me.dpStatus.BackColor = System.Drawing.Color.Transparent
        Me.dpStatus.Dock = System.Windows.Forms.DockStyle.Top
        Me.dpStatus.LabelText = "Status"
        Me.dpStatus.Location = New System.Drawing.Point(24, 48)
        Me.dpStatus.Name = "dpStatus"
        Me.dpStatus.Size = New System.Drawing.Size(126, 48)
        Me.dpStatus.TabIndex = 10
        Me.dpStatus.ValueText = "Stephen Bimpong"
        '
        'dpModel
        '
        Me.dpModel.BackColor = System.Drawing.Color.Transparent
        Me.dpModel.Dock = System.Windows.Forms.DockStyle.Top
        Me.dpModel.LabelText = "Model"
        Me.dpModel.Location = New System.Drawing.Point(24, 0)
        Me.dpModel.Name = "dpModel"
        Me.dpModel.Size = New System.Drawing.Size(126, 48)
        Me.dpModel.TabIndex = 9
        Me.dpModel.ValueText = "Stephen Bimpong"
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(24, 82)
        Me.Panel7.TabIndex = 11
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
        Me.btnUpdate.Location = New System.Drawing.Point(715, 179)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(94, 23)
        Me.btnUpdate.TabIndex = 53
        Me.btnUpdate.Text = "Update"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtgVehicles)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 269)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(32)
        Me.Panel2.Size = New System.Drawing.Size(876, 367)
        Me.Panel2.TabIndex = 2
        '
        'dtgVehicles
        '
        Me.dtgVehicles.AllowUserToAddRows = False
        Me.dtgVehicles.AllowUserToDeleteRows = False
        Me.dtgVehicles.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dtgVehicles.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgVehicles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgVehicles.ColumnHeadersHeight = 24
        Me.dtgVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgVehicles.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgVehicles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgVehicles.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgVehicles.Location = New System.Drawing.Point(32, 32)
        Me.dtgVehicles.Name = "dtgVehicles"
        Me.dtgVehicles.ReadOnly = True
        Me.dtgVehicles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgVehicles.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgVehicles.RowHeadersVisible = False
        Me.dtgVehicles.RowHeadersWidth = 51
        Me.dtgVehicles.Size = New System.Drawing.Size(812, 303)
        Me.dtgVehicles.TabIndex = 1
        Me.dtgVehicles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgVehicles.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgVehicles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgVehicles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.dtgVehicles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dtgVehicles.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dtgVehicles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgVehicles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtgVehicles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgVehicles.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgVehicles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtgVehicles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtgVehicles.ThemeStyle.HeaderStyle.Height = 24
        Me.dtgVehicles.ThemeStyle.ReadOnly = True
        Me.dtgVehicles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgVehicles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgVehicles.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgVehicles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtgVehicles.ThemeStyle.RowsStyle.Height = 22
        Me.dtgVehicles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.dtgVehicles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'VehicleControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "VehicleControl"
        Me.Size = New System.Drawing.Size(876, 636)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.pnlAddVehicle.ResumeLayout(False)
        Me.pnlAddVehicle.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.imgCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtgVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtgVehicles As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pnlAddVehicle As Panel
    Friend WithEvents btnAddVehicle As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblFormName As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents imgCar As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dpStatus As DataPair
    Friend WithEvents dpModel As DataPair
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents dpRentalPrice As DataPair
    Friend WithEvents dpNumberPlate As DataPair
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
End Class
