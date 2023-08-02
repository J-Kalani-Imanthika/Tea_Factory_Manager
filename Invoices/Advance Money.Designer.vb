<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Advance_Money
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Advance_Money))
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnInfo_view = New System.Windows.Forms.Button()
        Me.Txtpifid = New System.Windows.Forms.TextBox()
        Me.Gdv_advance = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Txtamount = New System.Windows.Forms.TextBox()
        Me.Close_form = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Gdv_advance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btndelete
        '
        Me.Btndelete.BackColor = System.Drawing.Color.LightCoral
        Me.Btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btndelete.FlatAppearance.BorderSize = 2
        Me.Btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btndelete.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.Location = New System.Drawing.Point(680, 120)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(88, 32)
        Me.Btndelete.TabIndex = 48
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = False
        '
        'Btnadd
        '
        Me.Btnadd.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnadd.FlatAppearance.BorderSize = 2
        Me.Btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Btnadd.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnadd.Location = New System.Drawing.Point(560, 120)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(88, 32)
        Me.Btnadd.TabIndex = 47
        Me.Btnadd.Text = "ADD"
        Me.Btnadd.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(448, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 17)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Payment Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(144, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(102, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Partner Info.ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Controls.Add(Me.BtnInfo_view)
        Me.Panel1.Controls.Add(Me.Txtpifid)
        Me.Panel1.Controls.Add(Me.Gdv_advance)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Btndelete)
        Me.Panel1.Controls.Add(Me.Btnadd)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Txtamount)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(72, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 568)
        Me.Panel1.TabIndex = 51
        '
        'BtnInfo_view
        '
        Me.BtnInfo_view.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnInfo_view.FlatAppearance.BorderSize = 2
        Me.BtnInfo_view.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.BtnInfo_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow
        Me.BtnInfo_view.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.BtnInfo_view.Location = New System.Drawing.Point(216, 184)
        Me.BtnInfo_view.Name = "BtnInfo_view"
        Me.BtnInfo_view.Size = New System.Drawing.Size(208, 32)
        Me.BtnInfo_view.TabIndex = 63
        Me.BtnInfo_view.Text = "Partner Info View"
        Me.BtnInfo_view.UseVisualStyleBackColor = False
        '
        'Txtpifid
        '
        Me.Txtpifid.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpifid.Location = New System.Drawing.Point(216, 40)
        Me.Txtpifid.Name = "Txtpifid"
        Me.Txtpifid.Size = New System.Drawing.Size(208, 25)
        Me.Txtpifid.TabIndex = 62
        '
        'Gdv_advance
        '
        Me.Gdv_advance.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Gdv_advance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gdv_advance.Location = New System.Drawing.Point(96, 232)
        Me.Gdv_advance.Name = "Gdv_advance"
        Me.Gdv_advance.Size = New System.Drawing.Size(656, 304)
        Me.Gdv_advance.TabIndex = 53
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow
        Me.Button1.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.Button1.Location = New System.Drawing.Point(40, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(560, 72)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(208, 25)
        Me.DateTimePicker2.TabIndex = 60
        Me.DateTimePicker2.Value = New Date(2021, 8, 28, 18, 49, 29, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(512, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 17)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(560, 38)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(208, 25)
        Me.DateTimePicker1.TabIndex = 58
        Me.DateTimePicker1.Value = New Date(2021, 8, 28, 18, 49, 29, 0)
        '
        'Txtamount
        '
        Me.Txtamount.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtamount.Location = New System.Drawing.Point(216, 74)
        Me.Txtamount.Name = "Txtamount"
        Me.Txtamount.Size = New System.Drawing.Size(208, 25)
        Me.Txtamount.TabIndex = 3
        '
        'Close_form
        '
        Me.Close_form.Image = CType(resources.GetObject("Close_form.Image"), System.Drawing.Image)
        Me.Close_form.Location = New System.Drawing.Point(1040, 16)
        Me.Close_form.Name = "Close_form"
        Me.Close_form.Size = New System.Drawing.Size(30, 30)
        Me.Close_form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Close_form.TabIndex = 106
        Me.Close_form.TabStop = False
        '
        'Advance_Money
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
        Me.Name = "Advance_Money"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advance Money"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Gdv_advance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btndelete As Button
    Friend WithEvents Btnadd As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Txtpifid As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Txtamount As TextBox
    Friend WithEvents Gdv_advance As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Close_form As PictureBox
    Friend WithEvents BtnInfo_view As Button
End Class
