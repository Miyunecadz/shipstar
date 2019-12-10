<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Available_Ship_View
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
        Me.CrystalTheme = New Telerik.WinControls.Themes.CrystalTheme()
        Me.available_ship_datagridview = New System.Windows.Forms.DataGridView()
        CType(Me.available_ship_datagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'available_ship_datagridview
        '
        Me.available_ship_datagridview.AllowUserToAddRows = False
        Me.available_ship_datagridview.AllowUserToDeleteRows = False
        Me.available_ship_datagridview.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.available_ship_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.available_ship_datagridview.Location = New System.Drawing.Point(3, 3)
        Me.available_ship_datagridview.Name = "available_ship_datagridview"
        Me.available_ship_datagridview.ReadOnly = True
        Me.available_ship_datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.available_ship_datagridview.Size = New System.Drawing.Size(864, 443)
        Me.available_ship_datagridview.TabIndex = 0
        '
        'Available_Ship_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Controls.Add(Me.available_ship_datagridview)
        Me.Name = "Available_Ship_View"
        Me.Size = New System.Drawing.Size(870, 449)
        CType(Me.available_ship_datagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalTheme As Telerik.WinControls.Themes.CrystalTheme
    Friend WithEvents available_ship_datagridview As DataGridView
End Class
