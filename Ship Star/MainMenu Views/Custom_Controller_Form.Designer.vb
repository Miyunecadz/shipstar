<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Custom_Controller_Form
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
        Me.edit_button = New Telerik.WinControls.UI.RadButton()
        Me.delete_button = New Telerik.WinControls.UI.RadButton()
        Me.cancel_button = New Telerik.WinControls.UI.RadButton()
        Me.CrystalTheme = New Telerik.WinControls.Themes.CrystalTheme()
        CType(Me.edit_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.delete_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cancel_button, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'edit_button
        '
        Me.edit_button.Location = New System.Drawing.Point(12, 12)
        Me.edit_button.Name = "edit_button"
        Me.edit_button.Size = New System.Drawing.Size(127, 42)
        Me.edit_button.TabIndex = 0
        Me.edit_button.Text = "Edit"
        Me.edit_button.ThemeName = "Crystal"
        '
        'delete_button
        '
        Me.delete_button.Location = New System.Drawing.Point(12, 63)
        Me.delete_button.Name = "delete_button"
        Me.delete_button.Size = New System.Drawing.Size(127, 42)
        Me.delete_button.TabIndex = 1
        Me.delete_button.Text = "Delete"
        Me.delete_button.ThemeName = "Crystal"
        '
        'cancel_button
        '
        Me.cancel_button.Location = New System.Drawing.Point(12, 111)
        Me.cancel_button.Name = "cancel_button"
        Me.cancel_button.Size = New System.Drawing.Size(127, 42)
        Me.cancel_button.TabIndex = 2
        Me.cancel_button.Text = "Cancel"
        Me.cancel_button.ThemeName = "Crystal"
        '
        'Custom_Controller_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(151, 169)
        Me.ControlBox = False
        Me.Controls.Add(Me.cancel_button)
        Me.Controls.Add(Me.delete_button)
        Me.Controls.Add(Me.edit_button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Custom_Controller_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Controller"
        CType(Me.edit_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.delete_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cancel_button, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents edit_button As Telerik.WinControls.UI.RadButton
    Friend WithEvents delete_button As Telerik.WinControls.UI.RadButton
    Friend WithEvents cancel_button As Telerik.WinControls.UI.RadButton
    Friend WithEvents CrystalTheme As Telerik.WinControls.Themes.CrystalTheme
End Class
