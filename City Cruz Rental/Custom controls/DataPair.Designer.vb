<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPair
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
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.MySqlDataAdapter1 = New MySql.Data.MySqlClient.MySqlDataAdapter()
        Me.SuspendLayout()
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblLabel.Location = New System.Drawing.Point(3, 0)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(106, 15)
        Me.lblLabel.TabIndex = 4
        Me.lblLabel.Text = "Stephen Bimpong"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValue.Location = New System.Drawing.Point(3, 15)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(121, 15)
        Me.lblValue.TabIndex = 3
        Me.lblValue.Text = "Stephen Bimpong"
        '
        'MySqlDataAdapter1
        '
        Me.MySqlDataAdapter1.DeleteCommand = Nothing
        Me.MySqlDataAdapter1.InsertCommand = Nothing
        Me.MySqlDataAdapter1.SelectCommand = Nothing
        Me.MySqlDataAdapter1.UpdateCommand = Nothing
        '
        'DataPair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.lblValue)
        Me.Name = "DataPair"
        Me.Size = New System.Drawing.Size(298, 48)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLabel As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents MySqlDataAdapter1 As MySql.Data.MySqlClient.MySqlDataAdapter
End Class
