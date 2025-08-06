<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.flpMenuItems = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblJobTItle = New System.Windows.Forms.Label()
        Me.lblProfileName = New System.Windows.Forms.Label()
        Me.picProfileImage = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.VehicleControl1 = New City_Cruz_Rental.VehicleControl()
        Me.DashboardControl1 = New City_Cruz_Rental.DashboardControl()
        Me.StaffControl1 = New City_Cruz_Rental.StaffControl()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.picProfileImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel1.Controls.Add(Me.flpMenuItems)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 866)
        Me.Panel1.TabIndex = 0
        '
        'flpMenuItems
        '
        Me.flpMenuItems.BackColor = System.Drawing.Color.Transparent
        Me.flpMenuItems.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpMenuItems.Location = New System.Drawing.Point(0, 169)
        Me.flpMenuItems.Name = "flpMenuItems"
        Me.flpMenuItems.Padding = New System.Windows.Forms.Padding(8)
        Me.flpMenuItems.Size = New System.Drawing.Size(226, 380)
        Me.flpMenuItems.TabIndex = 9
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Guna2Separator2)
        Me.Panel4.Controls.Add(Me.lblMenu)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 108)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(16)
        Me.Panel4.Size = New System.Drawing.Size(226, 61)
        Me.Panel4.TabIndex = 8
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Separator2.Location = New System.Drawing.Point(16, 44)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(194, 1)
        Me.Guna2Separator2.TabIndex = 6
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblMenu.Location = New System.Drawing.Point(16, 16)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.lblMenu.Size = New System.Drawing.Size(38, 28)
        Me.lblMenu.TabIndex = 5
        Me.lblMenu.Text = "Menu"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.btnLogout)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 804)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(226, 62)
        Me.Panel5.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(19, 20)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(93, 30)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(226, 108)
        Me.Panel3.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Guna2Separator1)
        Me.Panel2.Controls.Add(Me.Guna2Panel2)
        Me.Panel2.Controls.Add(Me.txtSearch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(226, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(816, 108)
        Me.Panel2.TabIndex = 1
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Separator1.Location = New System.Drawing.Point(0, 100)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(816, 8)
        Me.Guna2Separator1.TabIndex = 2
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.AutoRoundedCorners = True
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel2.Location = New System.Drawing.Point(564, 36)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(215, 36)
        Me.Guna2Panel2.TabIndex = 1
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.AutoRoundedCorners = True
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2Panel3.Controls.Add(Me.lblJobTItle)
        Me.Guna2Panel3.Controls.Add(Me.lblProfileName)
        Me.Guna2Panel3.Controls.Add(Me.picProfileImage)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Location = New System.Drawing.Point(8, 8)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(199, 19)
        Me.Guna2Panel3.TabIndex = 2
        '
        'lblJobTItle
        '
        Me.lblJobTItle.AutoSize = True
        Me.lblJobTItle.BackColor = System.Drawing.Color.Transparent
        Me.lblJobTItle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJobTItle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobTItle.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblJobTItle.Location = New System.Drawing.Point(97, 0)
        Me.lblJobTItle.Name = "lblJobTItle"
        Me.lblJobTItle.Size = New System.Drawing.Size(48, 16)
        Me.lblJobTItle.TabIndex = 2
        Me.lblJobTItle.Text = "Label1"
        '
        'lblProfileName
        '
        Me.lblProfileName.AutoSize = True
        Me.lblProfileName.BackColor = System.Drawing.Color.Transparent
        Me.lblProfileName.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblProfileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfileName.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblProfileName.Location = New System.Drawing.Point(43, 0)
        Me.lblProfileName.Name = "lblProfileName"
        Me.lblProfileName.Size = New System.Drawing.Size(54, 16)
        Me.lblProfileName.TabIndex = 1
        Me.lblProfileName.Text = "Label1"
        '
        'picProfileImage
        '
        Me.picProfileImage.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
        Me.picProfileImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.picProfileImage.Image = Global.City_Cruz_Rental.My.Resources.Resources.profile_icon
        Me.picProfileImage.ImageRotate = 0!
        Me.picProfileImage.Location = New System.Drawing.Point(0, 0)
        Me.picProfileImage.Margin = New System.Windows.Forms.Padding(8)
        Me.picProfileImage.Name = "picProfileImage"
        Me.picProfileImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.picProfileImage.Size = New System.Drawing.Size(43, 19)
        Me.picProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfileImage.TabIndex = 0
        Me.picProfileImage.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.AutoRoundedCorners = True
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.DefaultText = ""
        Me.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(54, 36)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PlaceholderText = "Search"
        Me.txtSearch.SelectedText = ""
        Me.txtSearch.Size = New System.Drawing.Size(421, 36)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.TextOffset = New System.Drawing.Point(20, 0)
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.pnlMain)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(226, 108)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(816, 758)
        Me.Panel6.TabIndex = 2
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.VehicleControl1)
        Me.pnlMain.Controls.Add(Me.DashboardControl1)
        Me.pnlMain.Controls.Add(Me.StaffControl1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 61)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(816, 697)
        Me.pnlMain.TabIndex = 1
        '
        'VehicleControl1
        '
        Me.VehicleControl1.Location = New System.Drawing.Point(0, 0)
        Me.VehicleControl1.Name = "VehicleControl1"
        Me.VehicleControl1.Size = New System.Drawing.Size(876, 636)
        Me.VehicleControl1.TabIndex = 2
        '
        'DashboardControl1
        '
        Me.DashboardControl1.BackColor = System.Drawing.Color.White
        Me.DashboardControl1.Location = New System.Drawing.Point(0, 0)
        Me.DashboardControl1.Name = "DashboardControl1"
        Me.DashboardControl1.Size = New System.Drawing.Size(806, 605)
        Me.DashboardControl1.TabIndex = 1
        '
        'StaffControl1
        '
        Me.StaffControl1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.StaffControl1.Location = New System.Drawing.Point(0, 0)
        Me.StaffControl1.Name = "StaffControl1"
        Me.StaffControl1.Size = New System.Drawing.Size(771, 573)
        Me.StaffControl1.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lblTitle)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(816, 61)
        Me.Panel7.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(23, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(126, 39)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Label1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 866)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.picProfileImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents picProfileImage As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblProfileName As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Panel3 As Panel
    Friend WithEvents flpMenuItems As FlowLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents lblMenu As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblJobTItle As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents VehicleControl1 As VehicleControl
    Friend WithEvents DashboardControl1 As DashboardControl
    Friend WithEvents StaffControl1 As StaffControl
End Class
