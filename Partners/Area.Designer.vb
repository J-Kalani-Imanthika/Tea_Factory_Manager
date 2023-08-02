<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Area
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Area))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Btnrefresh = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.txtarea_name = New System.Windows.Forms.TextBox()
        Me.lblarea_name = New System.Windows.Forms.Label()
        Me.txtarea_id = New System.Windows.Forms.TextBox()
        Me.lblarea_id = New System.Windows.Forms.Label()
        Me.Gdv_area = New System.Windows.Forms.DataGridView()
        Me.Close_form = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Gdv_area, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Controls.Add(Me.Btnrefresh)
        Me.Panel1.Controls.Add(Me.btnsave)
        Me.Panel1.Controls.Add(Me.txtarea_name)
        Me.Panel1.Controls.Add(Me.lblarea_name)
        Me.Panel1.Controls.Add(Me.txtarea_id)
        Me.Panel1.Controls.Add(Me.lblarea_id)
        Me.Panel1.Location = New System.Drawing.Point(136, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(808, 432)
        Me.Panel1.TabIndex = 52
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(424, 112)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(6)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(96, 32)
        Me.btndelete.TabIndex = 49
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'Btnrefresh
        '
        Me.Btnrefresh.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Btnrefresh.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.Btnrefresh.Location = New System.Drawing.Point(616, 200)
        Me.Btnrefresh.Name = "Btnrefresh"
        Me.Btnrefresh.Size = New System.Drawing.Size(104, 32)
        Me.Btnrefresh.TabIndex = 85
        Me.Btnrefresh.Text = "Refresh"
        Me.Btnrefresh.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(280, 112)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(6)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(96, 32)
        Me.btnsave.TabIndex = 48
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'txtarea_name
        '
        Me.txtarea_name.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtarea_name.Location = New System.Drawing.Point(280, 72)
        Me.txtarea_name.Name = "txtarea_name"
        Me.txtarea_name.Size = New System.Drawing.Size(240, 25)
        Me.txtarea_name.TabIndex = 47
        '
        'lblarea_name
        '
        Me.lblarea_name.AutoSize = True
        Me.lblarea_name.BackColor = System.Drawing.Color.Transparent
        Me.lblarea_name.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblarea_name.Location = New System.Drawing.Point(184, 72)
        Me.lblarea_name.Name = "lblarea_name"
        Me.lblarea_name.Size = New System.Drawing.Size(81, 17)
        Me.lblarea_name.TabIndex = 45
        Me.lblarea_name.Text = "Area Name"
        '
        'txtarea_id
        '
        Me.txtarea_id.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtarea_id.Location = New System.Drawing.Point(280, 32)
        Me.txtarea_id.Name = "txtarea_id"
        Me.txtarea_id.Size = New System.Drawing.Size(240, 25)
        Me.txtarea_id.TabIndex = 46
        '
        'lblarea_id
        '
        Me.lblarea_id.AutoSize = True
        Me.lblarea_id.BackColor = System.Drawing.Color.Transparent
        Me.lblarea_id.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblarea_id.Location = New System.Drawing.Point(209, 39)
        Me.lblarea_id.Name = "lblarea_id"
        Me.lblarea_id.Size = New System.Drawing.Size(56, 17)
        Me.lblarea_id.TabIndex = 44
        Me.lblarea_id.Text = "Area ID"
        '
        'Gdv_area
        '
        Me.Gdv_area.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gdv_area.Location = New System.Drawing.Point(328, 232)
        Me.Gdv_area.Name = "Gdv_area"
        Me.Gdv_area.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Gdv_area.Size = New System.Drawing.Size(376, 208)
        Me.Gdv_area.TabIndex = 84
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
        'Area
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(1088, 600)
        Me.Controls.Add(Me.Close_form)
        Me.Controls.Add(Me.Gdv_area)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Area"
        Me.Text = "Area"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Gdv_area, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents txtarea_name As TextBox
    Friend WithEvents txtarea_id As TextBox
    Friend WithEvents lblarea_name As Label
    Friend WithEvents lblarea_id As Label
    Friend WithEvents Gdv_area As DataGridView
    Friend WithEvents Btnrefresh As Button
    Friend WithEvents Close_form As PictureBox
End Class
