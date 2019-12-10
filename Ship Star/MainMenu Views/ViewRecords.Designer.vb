<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewRecords
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
        Me.view_record_datagrid = New System.Windows.Forms.DataGridView()
        CType(Me.view_record_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'view_record_datagrid
        '
        Me.view_record_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.view_record_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.view_record_datagrid.Location = New System.Drawing.Point(3, 3)
        Me.view_record_datagrid.Name = "view_record_datagrid"
        Me.view_record_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.view_record_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.view_record_datagrid.Size = New System.Drawing.Size(864, 443)
        Me.view_record_datagrid.TabIndex = 0
        '
        'ViewRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Controls.Add(Me.view_record_datagrid)
        Me.Name = "ViewRecords"
        Me.Size = New System.Drawing.Size(870, 449)
        CType(Me.view_record_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents view_record_datagrid As DataGridView
End Class
