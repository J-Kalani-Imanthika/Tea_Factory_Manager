<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Partner_Catagarization
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
        Me.Btn_register = New System.Windows.Forms.Button()
        Me.combo_cateid = New System.Windows.Forms.ComboBox()
        Me.txtpartner_regid = New System.Windows.Forms.TextBox()
        Me.lblpartner_infoid = New System.Windows.Forms.Label()
        Me.lblarea = New System.Windows.Forms.Label()
        Me.lblcategory = New System.Windows.Forms.Label()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Combo_areaid = New System.Windows.Forms.ComboBox()
        Me.Close_form = New System.Windows.Forms.PictureBox()
        Me.Btnrefresh = New System.Windows.Forms.Button()
        Me.gdv_part_info = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdv_part_info, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_register
        '
        Me.Btn_register.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_register.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_register.FlatAppearance.BorderSize = 2
        Me.Btn_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Btn_register.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_register.Location = New System.Drawing.Point(144, 144)
        Me.Btn_register.Margin = New System.Windows.Forms.Padding(6)
        Me.Btn_register.Name = "Btn_register"
        Me.Btn_register.Size = New System.Drawing.Size(88, 32)
        Me.Btn_register.TabIndex = 70
        Me.Btn_register.Text = "Register"
        Me.Btn_register.UseVisualStyleBackColor = False
        '
        'combo_cateid
        '
        Me.combo_cateid.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_cateid.FormattingEnabled = True
        Me.combo_cateid.Location = New System.Drawing.Point(136, 64)
        Me.combo_cateid.Name = "combo_cateid"
        Me.combo_cateid.Size = New System.Drawing.Size(304, 25)
        Me.combo_cateid.TabIndex = 69
        '
        'txtpartner_regid
        '
        Me.txtpartner_regid.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpartner_regid.Location = New System.Drawing.Point(136, 32)
        Me.txtpartner_regid.Name = "txtpartner_regid"
        Me.txtpartner_regid.Size = New System.Drawing.Size(304, 25)
        Me.txtpartner_regid.TabIndex = 68
        '
        'lblpartner_infoid
        '
        Me.lblpartner_infoid.AutoSize = True
        Me.lblpartner_infoid.BackColor = System.Drawing.Color.Transparent
        Me.lblpartner_infoid.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpartner_infoid.Location = New System.Drawing.Point(24, 35)
        Me.lblpartner_infoid.Name = "lblpartner_infoid"
        Me.lblpartner_infoid.Size = New System.Drawing.Size(101, 17)
        Me.lblpartner_infoid.TabIndex = 67
        Me.lblpartner_infoid.Text = "Partner Info ID"
        '
        'lblarea
        '
        Me.lblarea.AutoSize = True
        Me.lblarea.BackColor = System.Drawing.Color.Transparent
        Me.lblarea.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblarea.Location = New System.Drawing.Point(87, 103)
        Me.lblarea.Name = "lblarea"
        Me.lblarea.Size = New System.Drawing.Size(38, 17)
        Me.lblarea.TabIndex = 65
        Me.lblarea.Text = "Area"
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.BackColor = System.Drawing.Color.Transparent
        Me.lblcategory.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategory.Location = New System.Drawing.Point(58, 69)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(67, 17)
        Me.lblcategory.TabIndex = 64
        Me.lblcategory.Text = "Category"
        '
        'Btndelete
        '
        Me.Btndelete.BackColor = System.Drawing.Color.LightCoral
        Me.Btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btndelete.FlatAppearance.BorderSize = 2
        Me.Btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btndelete.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.Location = New System.Drawing.Point(352, 144)
        Me.Btndelete.Margin = New System.Windows.Forms.Padding(6)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(88, 32)
        Me.Btndelete.TabIndex = 63
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Controls.Add(Me.Combo_areaid)
        Me.Panel1.Controls.Add(Me.Btn_register)
        Me.Panel1.Controls.Add(Me.combo_cateid)
        Me.Panel1.Controls.Add(Me.txtpartner_regid)
        Me.Panel1.Controls.Add(Me.lblpartner_infoid)
        Me.Panel1.Controls.Add(Me.lblarea)
        Me.Panel1.Controls.Add(Me.lblcategory)
        Me.Panel1.Controls.Add(Me.Btndelete)
        Me.Panel1.Location = New System.Drawing.Point(256, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 216)
        Me.Panel1.TabIndex = 71
        '
        'Combo_areaid
        '
        Me.Combo_areaid.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_areaid.FormattingEnabled = True
        Me.Combo_areaid.Location = New System.Drawing.Point(136, 96)
        Me.Combo_areaid.Name = "Combo_areaid"
        Me.Combo_areaid.Size = New System.Drawing.Size(304, 25)
        Me.Combo_areaid.TabIndex = 70
        '
        'Close_form
        '
        Me.Close_form.Image = Global.Tea_Supplier_Management.My.Resources.Resources.Close
        Me.Close_form.Location = New System.Drawing.Point(1040, 16)
        Me.Close_form.Name = "Close_form"
        Me.Close_form.Size = New System.Drawing.Size(30, 30)
        Me.Close_form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Close_form.TabIndex = 109
        Me.Close_form.TabStop = False
        '
        'Btnrefresh
        '
        Me.Btnrefresh.BackColor = System.Drawing.Color.Gainsboro
        Me.Btnrefresh.FlatAppearance.BorderSize = 2
        Me.Btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.Btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow
        Me.Btnrefresh.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.Btnrefresh.Location = New System.Drawing.Point(760, 296)
        Me.Btnrefresh.Name = "Btnrefresh"
        Me.Btnrefresh.Size = New System.Drawing.Size(80, 32)
        Me.Btnrefresh.TabIndex = 108
        Me.Btnrefresh.Text = "Refresh"
        Me.Btnrefresh.UseVisualStyleBackColor = False
        '
        'gdv_part_info
        '
        Me.gdv_part_info.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.gdv_part_info.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gdv_part_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdv_part_info.Location = New System.Drawing.Point(256, 296)
        Me.gdv_part_info.Name = "gdv_part_info"
        Me.gdv_part_info.Size = New System.Drawing.Size(472, 227)
        Me.gdv_part_info.TabIndex = 110
        '
        'Partner_Catagarization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(1088, 600)
        Me.Controls.Add(Me.gdv_part_info)
        Me.Controls.Add(Me.Close_form)
        Me.Controls.Add(Me.Btnrefresh)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Partner_Catagarization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Partner Catagarization"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdv_part_info, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_register As Button
    Friend WithEvents combo_cateid As ComboBox
    Friend WithEvents txtpartner_regid As TextBox
    Friend WithEvents lblpartner_infoid As Label
    Friend WithEvents lblarea As Label
    Friend WithEvents lblcategory As Label
    Friend WithEvents Btndelete As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Combo_areaid As ComboBox
    Friend WithEvents Close_form As PictureBox
    Friend WithEvents Btnrefresh As Button
    Friend WithEvents gdv_part_info As DataGridView
End Class
