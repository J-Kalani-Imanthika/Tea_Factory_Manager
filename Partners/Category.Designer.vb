<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Category))
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.txtcategory = New System.Windows.Forms.TextBox()
        Me.lblcategory = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btnrefresh = New System.Windows.Forms.Button()
        Me.txtcategary_id = New System.Windows.Forms.TextBox()
        Me.lblcategory_id = New System.Windows.Forms.Label()
        Me.Close_form = New System.Windows.Forms.PictureBox()
        Me.Gdv_category = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gdv_category, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btndelete
        '
        Me.Btndelete.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btndelete.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.Location = New System.Drawing.Point(432, 112)
        Me.Btndelete.Margin = New System.Windows.Forms.Padding(6)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(78, 32)
        Me.Btndelete.TabIndex = 49
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = False
        '
        'Btnsave
        '
        Me.Btnsave.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnsave.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsave.Location = New System.Drawing.Point(296, 112)
        Me.Btnsave.Margin = New System.Windows.Forms.Padding(6)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(78, 32)
        Me.Btnsave.TabIndex = 48
        Me.Btnsave.Text = "Save"
        Me.Btnsave.UseVisualStyleBackColor = False
        '
        'txtcategory
        '
        Me.txtcategory.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcategory.Location = New System.Drawing.Point(296, 64)
        Me.txtcategory.Name = "txtcategory"
        Me.txtcategory.Size = New System.Drawing.Size(216, 25)
        Me.txtcategory.TabIndex = 47
        '
        'lblcategory
        '
        Me.lblcategory.AutoSize = True
        Me.lblcategory.BackColor = System.Drawing.Color.Transparent
        Me.lblcategory.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategory.Location = New System.Drawing.Point(168, 69)
        Me.lblcategory.Name = "lblcategory"
        Me.lblcategory.Size = New System.Drawing.Size(110, 17)
        Me.lblcategory.TabIndex = 45
        Me.lblcategory.Text = "Category Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Controls.Add(Me.Gdv_category)
        Me.Panel1.Controls.Add(Me.Btndelete)
        Me.Panel1.Controls.Add(Me.Btnrefresh)
        Me.Panel1.Controls.Add(Me.Btnsave)
        Me.Panel1.Controls.Add(Me.txtcategory)
        Me.Panel1.Controls.Add(Me.lblcategory)
        Me.Panel1.Controls.Add(Me.txtcategary_id)
        Me.Panel1.Controls.Add(Me.lblcategory_id)
        Me.Panel1.Location = New System.Drawing.Point(168, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 440)
        Me.Panel1.TabIndex = 50
        '
        'Btnrefresh
        '
        Me.Btnrefresh.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Btnrefresh.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.Btnrefresh.Location = New System.Drawing.Point(608, 184)
        Me.Btnrefresh.Name = "Btnrefresh"
        Me.Btnrefresh.Size = New System.Drawing.Size(104, 32)
        Me.Btnrefresh.TabIndex = 95
        Me.Btnrefresh.Text = "Refresh"
        Me.Btnrefresh.UseVisualStyleBackColor = False
        '
        'txtcategary_id
        '
        Me.txtcategary_id.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcategary_id.Location = New System.Drawing.Point(296, 24)
        Me.txtcategary_id.Name = "txtcategary_id"
        Me.txtcategary_id.Size = New System.Drawing.Size(216, 25)
        Me.txtcategary_id.TabIndex = 46
        '
        'lblcategory_id
        '
        Me.lblcategory_id.AutoSize = True
        Me.lblcategory_id.BackColor = System.Drawing.Color.Transparent
        Me.lblcategory_id.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcategory_id.Location = New System.Drawing.Point(192, 32)
        Me.lblcategory_id.Name = "lblcategory_id"
        Me.lblcategory_id.Size = New System.Drawing.Size(82, 17)
        Me.lblcategory_id.TabIndex = 44
        Me.lblcategory_id.Text = "Category Id"
        '
        'Close_form
        '
        Me.Close_form.Image = CType(resources.GetObject("Close_form.Image"), System.Drawing.Image)
        Me.Close_form.Location = New System.Drawing.Point(1040, 16)
        Me.Close_form.Name = "Close_form"
        Me.Close_form.Size = New System.Drawing.Size(30, 30)
        Me.Close_form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Close_form.TabIndex = 107
        Me.Close_form.TabStop = False
        '
        'Gdv_category
        '
        Me.Gdv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gdv_category.Location = New System.Drawing.Point(248, 176)
        Me.Gdv_category.Name = "Gdv_category"
        Me.Gdv_category.ReadOnly = True
        Me.Gdv_category.Size = New System.Drawing.Size(288, 176)
        Me.Gdv_category.TabIndex = 96
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(1088, 600)
        Me.Controls.Add(Me.Close_form)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gdv_category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btndelete As Button
    Friend WithEvents Btnsave As Button
    Friend WithEvents txtcategory As TextBox
    Friend WithEvents lblcategory As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btnrefresh As Button
    Friend WithEvents Close_form As PictureBox
    Friend WithEvents txtcategary_id As TextBox
    Friend WithEvents lblcategory_id As Label
    Friend WithEvents Gdv_category As DataGridView
End Class
