<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookVehicle
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.lblFormName = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.tmpStart = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBook = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPaymentMethod = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtDailyPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbVehicle = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbCustomer = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tmpEnd = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.SuspendLayout()
        '
        'lblFormName
        '
        Me.lblFormName.AutoSize = True
        Me.lblFormName.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormName.Location = New System.Drawing.Point(29, 31)
        Me.lblFormName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormName.Name = "lblFormName"
        Me.lblFormName.Size = New System.Drawing.Size(588, 91)
        Me.lblFormName.TabIndex = 73
        Me.lblFormName.Text = "Book A Vehicle"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(47, 124)
        Me.Guna2Separator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(1021, 12)
        Me.Guna2Separator1.TabIndex = 72
        '
        'tmpStart
        '
        Me.tmpStart.Checked = True
        Me.tmpStart.FillColor = System.Drawing.Color.White
        Me.tmpStart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tmpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.tmpStart.Location = New System.Drawing.Point(203, 251)
        Me.tmpStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tmpStart.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.tmpStart.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tmpStart.Name = "tmpStart"
        Me.tmpStart.Size = New System.Drawing.Size(292, 39)
        Me.tmpStart.TabIndex = 56
        Me.tmpStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tmpStart.Value = New Date(2025, 8, 20, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(623, 310)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 28)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Total Price:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(623, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 28)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "End Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(617, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 28)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Customer:"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotalPrice.DefaultText = ""
        Me.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTotalPrice.Enabled = False
        Me.txtTotalPrice.FillColor = System.Drawing.Color.LightGray
        Me.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTotalPrice.Location = New System.Drawing.Point(752, 310)
        Me.txtTotalPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.PlaceholderText = ""
        Me.txtTotalPrice.SelectedText = ""
        Me.txtTotalPrice.Size = New System.Drawing.Size(316, 39)
        Me.txtTotalPrice.TabIndex = 55
        '
        'btnCancel
        '
        Me.btnCancel.BorderRadius = 6
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(623, 514)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 41)
        Me.btnCancel.TabIndex = 61
        Me.btnCancel.Text = "Cancel"
        '
        'btnBook
        '
        Me.btnBook.BorderRadius = 6
        Me.btnBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBook.FillColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btnBook.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnBook.ForeColor = System.Drawing.Color.White
        Me.btnBook.Location = New System.Drawing.Point(373, 514)
        Me.btnBook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(221, 41)
        Me.btnBook.TabIndex = 60
        Me.btnBook.Text = "Book"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 367)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 28)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Payment Method:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(41, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 28)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Daily Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 28)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Start Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 28)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Vehicle:"
        '
        'cmbPaymentMethod
        '
        Me.cmbPaymentMethod.BackColor = System.Drawing.Color.Transparent
        Me.cmbPaymentMethod.DisplayMember = "sfd"
        Me.cmbPaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaymentMethod.FillColor = System.Drawing.Color.LightGray
        Me.cmbPaymentMethod.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbPaymentMethod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbPaymentMethod.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbPaymentMethod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbPaymentMethod.ItemHeight = 30
        Me.cmbPaymentMethod.Location = New System.Drawing.Point(203, 367)
        Me.cmbPaymentMethod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbPaymentMethod.Name = "cmbPaymentMethod"
        Me.cmbPaymentMethod.Size = New System.Drawing.Size(292, 36)
        Me.cmbPaymentMethod.TabIndex = 52
        Me.cmbPaymentMethod.ValueMember = "sfdm, dsjdifs"
        '
        'txtDailyPrice
        '
        Me.txtDailyPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDailyPrice.DefaultText = ""
        Me.txtDailyPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDailyPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDailyPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDailyPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDailyPrice.Enabled = False
        Me.txtDailyPrice.FillColor = System.Drawing.Color.LightGray
        Me.txtDailyPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDailyPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDailyPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDailyPrice.Location = New System.Drawing.Point(203, 310)
        Me.txtDailyPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDailyPrice.Name = "txtDailyPrice"
        Me.txtDailyPrice.PlaceholderText = ""
        Me.txtDailyPrice.SelectedText = ""
        Me.txtDailyPrice.Size = New System.Drawing.Size(292, 39)
        Me.txtDailyPrice.TabIndex = 54
        '
        'cmbVehicle
        '
        Me.cmbVehicle.BackColor = System.Drawing.Color.Transparent
        Me.cmbVehicle.DisplayMember = "sfd"
        Me.cmbVehicle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVehicle.FillColor = System.Drawing.Color.LightGray
        Me.cmbVehicle.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbVehicle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbVehicle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbVehicle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbVehicle.ItemHeight = 30
        Me.cmbVehicle.Location = New System.Drawing.Point(203, 181)
        Me.cmbVehicle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbVehicle.Name = "cmbVehicle"
        Me.cmbVehicle.Size = New System.Drawing.Size(292, 36)
        Me.cmbVehicle.TabIndex = 74
        Me.cmbVehicle.ValueMember = "sfdm, dsjdifs"
        '
        'cmbCustomer
        '
        Me.cmbCustomer.BackColor = System.Drawing.Color.Transparent
        Me.cmbCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomer.FillColor = System.Drawing.Color.LightGray
        Me.cmbCustomer.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCustomer.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCustomer.ItemHeight = 30
        Me.cmbCustomer.Location = New System.Drawing.Point(752, 181)
        Me.cmbCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(316, 36)
        Me.cmbCustomer.TabIndex = 75
        '
        'tmpEnd
        '
        Me.tmpEnd.Checked = True
        Me.tmpEnd.FillColor = System.Drawing.Color.White
        Me.tmpEnd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tmpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.tmpEnd.Location = New System.Drawing.Point(751, 251)
        Me.tmpEnd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tmpEnd.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.tmpEnd.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.tmpEnd.Name = "tmpEnd"
        Me.tmpEnd.Size = New System.Drawing.Size(319, 39)
        Me.tmpEnd.TabIndex = 76
        Me.tmpEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tmpEnd.Value = New Date(2025, 8, 20, 0, 0, 0, 0)
        '
        'BookVehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 586)
        Me.Controls.Add(Me.tmpEnd)
        Me.Controls.Add(Me.cmbCustomer)
        Me.Controls.Add(Me.cmbVehicle)
        Me.Controls.Add(Me.lblFormName)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.tmpStart)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotalPrice)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbPaymentMethod)
        Me.Controls.Add(Me.txtDailyPrice)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BookVehicle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BookVehicle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFormName As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents tmpStart As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotalPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBook As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPaymentMethod As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtDailyPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbVehicle As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbCustomer As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tmpEnd As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
