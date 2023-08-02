<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Partners_Info_View
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
        Me.Gdv_all_partner_info = New System.Windows.Forms.DataGridView()
        Me.Btnselect = New System.Windows.Forms.Button()
        CType(Me.Gdv_all_partner_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gdv_all_partner_info
        '
        Me.Gdv_all_partner_info.AllowUserToOrderColumns = True
        Me.Gdv_all_partner_info.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Gdv_all_partner_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gdv_all_partner_info.Location = New System.Drawing.Point(16, 120)
        Me.Gdv_all_partner_info.Name = "Gdv_all_partner_info"
        Me.Gdv_all_partner_info.ReadOnly = True
        Me.Gdv_all_partner_info.Size = New System.Drawing.Size(1040, 400)
        Me.Gdv_all_partner_info.TabIndex = 0
        '
        'Btnselect
        '
        Me.Btnselect.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.Btnselect.Location = New System.Drawing.Point(872, 72)
        Me.Btnselect.Name = "Btnselect"
        Me.Btnselect.Size = New System.Drawing.Size(104, 32)
        Me.Btnselect.TabIndex = 53
        Me.Btnselect.Text = "Select"
        Me.Btnselect.UseVisualStyleBackColor = True
        '
        'Partners_Info_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1072, 561)
        Me.Controls.Add(Me.Btnselect)
        Me.Controls.Add(Me.Gdv_all_partner_info)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Partners_Info_View"
        Me.Text = "Partners Info Grid View"
        CType(Me.Gdv_all_partner_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Gdv_all_partner_info As DataGridView
    Friend WithEvents Btnselect As Button
End Class
