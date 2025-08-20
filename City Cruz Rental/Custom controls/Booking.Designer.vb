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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtgBooking = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btBook = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.dtgBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtgBooking)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1054, 659)
        Me.Panel2.TabIndex = 4
        '
        'dtgBooking
        '
        Me.dtgBooking.AllowUserToAddRows = False
        Me.dtgBooking.AllowUserToDeleteRows = False
        Me.dtgBooking.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dtgBooking.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgBooking.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgBooking.ColumnHeadersHeight = 24
        Me.dtgBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(179, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgBooking.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgBooking.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgBooking.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgBooking.Location = New System.Drawing.Point(0, 0)
        Me.dtgBooking.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgBooking.Name = "dtgBooking"
        Me.dtgBooking.ReadOnly = True
        Me.dtgBooking.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgBooking.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgBooking.RowHeadersVisible = False
        Me.dtgBooking.RowHeadersWidth = 51
        Me.dtgBooking.Size = New System.Drawing.Size(1054, 659)
        Me.dtgBooking.TabIndex = 3
        Me.dtgBooking.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgBooking.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgBooking.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgBooking.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.dtgBooking.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dtgBooking.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dtgBooking.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtgBooking.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtgBooking.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtgBooking.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgBooking.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtgBooking.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtgBooking.ThemeStyle.HeaderStyle.Height = 24
        Me.dtgBooking.ThemeStyle.ReadOnly = True
        Me.dtgBooking.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtgBooking.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtgBooking.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgBooking.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtgBooking.ThemeStyle.RowsStyle.Height = 22
        Me.dtgBooking.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.dtgBooking.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btBook)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 659)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1054, 67)
        Me.Panel1.TabIndex = 3
        '
        'btBook
        '
        Me.btBook.Location = New System.Drawing.Point(729, 18)
        Me.btBook.Name = "btBook"
        Me.btBook.Size = New System.Drawing.Size(125, 37)
        Me.btBook.TabIndex = 1
        Me.btBook.Text = "Book"
        Me.btBook.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(887, 18)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(125, 37)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Booking"
        Me.Size = New System.Drawing.Size(1054, 726)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtgBooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtgBooking As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btBook As Button
End Class
