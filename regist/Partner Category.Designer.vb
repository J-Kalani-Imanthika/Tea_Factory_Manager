<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Partner_Category
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
        Me.txtcategory = New System.Windows.Forms.TextBox()
        Me.txtcategary_id = New System.Windows.Forms.TextBox()
        Me.lblcategory = New System.Windows.Forms.Label()
        Me.lblcategory_id = New System.Windows.Forms.Label()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtcategory
        '
        Me.txtcategory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcategory.Location = New System.Drawing.Point(232, 96)
        Me.txtcategory.Name = "txtcategory"
        Me.txtcategory.Size = New System.Drawing.Size(304, 26)
        Me.txtcategory.TabIndex = 41
        '
        'txtcategary_id
        '
        Me.txtcategary_id.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcategary_id.Location = New System.Drawing.Point(232, 48)
        Me.txtcategary_id.Name = "txtcategary_id"
        Me.txtcategary_id.Size = New System.Drawing.Size(304, 26)
        Me.txtcategary_id.TabIndex = 40
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.BackColor = System.Drawing.Color.LightGreen
        Me.lblcategory.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategory.Location = New System.Drawing.Point(111, 101)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(85, 18)
        Me.lblcategory.TabIndex = 39
        Me.lblcategory.Text = "First Name"
        '
        'lblcategory_id
        '
        Me.lblcategory_id.AutoSize = True
        Me.lblcategory_id.BackColor = System.Drawing.Color.LightGreen
        Me.lblcategory_id.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategory_id.Location = New System.Drawing.Point(108, 56)
        Me.lblcategory_id.Name = "lblcategory_id"
        Me.lblcategory_id.Size = New System.Drawing.Size(88, 18)
        Me.lblcategory_id.TabIndex = 38
        Me.lblcategory_id.Text = "Category Id"
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btndelete.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(416, 176)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(6)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(120, 50)
        Me.btndelete.TabIndex = 43
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnsave.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(232, 176)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(6)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(120, 50)
        Me.btnsave.TabIndex = 42
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Partner_Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(644, 284)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.txtcategory)
        Me.Controls.Add(Me.txtcategary_id)
        Me.Controls.Add(Me.lblcategory)
        Me.Controls.Add(Me.lblcategory_id)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Partner_Category"
        Me.Text = "Partner_Category"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtcategory As TextBox
    Friend WithEvents txtcategary_id As TextBox
    Friend WithEvents lblcategory As Label
    Friend WithEvents lblcategory_id As Label
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsave As Button
End Class
