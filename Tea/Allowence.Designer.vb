<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Allowence
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Allowence))
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblallowence_name = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btnrefresh = New System.Windows.Forms.Button()
        Me.Gdv_allow = New System.Windows.Forms.DataGridView()
        Me.datetxt = New System.Windows.Forms.DateTimePicker()
        Me.txtallowence = New System.Windows.Forms.TextBox()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.amounttxt = New System.Windows.Forms.TextBox()
        Me.partnerinfoidtxt = New System.Windows.Forms.TextBox()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.Close_form = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Gdv_allow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.Color.Transparent
        Me.lbldate.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(242, 127)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(70, 17)
        Me.lbldate.TabIndex = 65
        Me.lbldate.Text = "Issu Date"
        '
        'lblallowence_name
        '
        Me.lblallowence_name.AutoSize = True
        Me.lblallowence_name.BackColor = System.Drawing.Color.Transparent
        Me.lblallowence_name.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblallowence_name.Location = New System.Drawing.Point(196, 59)
        Me.lblallowence_name.Name = "lblallowence_name"
        Me.lblallowence_name.Size = New System.Drawing.Size(116, 17)
        Me.lblallowence_name.TabIndex = 64
        Me.lblallowence_name.Text = "allowence Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Controls.Add(Me.Btnrefresh)
        Me.Panel1.Controls.Add(Me.Gdv_allow)
        Me.Panel1.Controls.Add(Me.datetxt)
        Me.Panel1.Controls.Add(Me.txtallowence)
        Me.Panel1.Controls.Add(Me.addbtn)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.amounttxt)
        Me.Panel1.Controls.Add(Me.partnerinfoidtxt)
        Me.Panel1.Controls.Add(Me.lbldate)
        Me.Panel1.Controls.Add(Me.lblallowence_name)
        Me.Panel1.Controls.Add(Me.btndelete)
        Me.Panel1.Location = New System.Drawing.Point(96, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(896, 560)
        Me.Panel1.TabIndex = 72
        '
        'Btnrefresh
        '
        Me.Btnrefresh.BackColor = System.Drawing.Color.Gainsboro
        Me.Btnrefresh.FlatAppearance.BorderSize = 2
        Me.Btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.Btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow
        Me.Btnrefresh.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.Btnrefresh.Location = New System.Drawing.Point(744, 296)
        Me.Btnrefresh.Name = "Btnrefresh"
        Me.Btnrefresh.Size = New System.Drawing.Size(88, 32)
        Me.Btnrefresh.TabIndex = 79
        Me.Btnrefresh.Text = "Refresh"
        Me.Btnrefresh.UseVisualStyleBackColor = False
        '
        'Gdv_allow
        '
        Me.Gdv_allow.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Gdv_allow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gdv_allow.Location = New System.Drawing.Point(240, 288)
        Me.Gdv_allow.Name = "Gdv_allow"
        Me.Gdv_allow.Size = New System.Drawing.Size(464, 248)
        Me.Gdv_allow.TabIndex = 78
        '
        'datetxt
        '
        Me.datetxt.CustomFormat = "yyyy-MM-dd"
        Me.datetxt.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetxt.Location = New System.Drawing.Point(336, 128)
        Me.datetxt.Margin = New System.Windows.Forms.Padding(2)
        Me.datetxt.Name = "datetxt"
        Me.datetxt.Size = New System.Drawing.Size(280, 25)
        Me.datetxt.TabIndex = 77
        '
        'txtallowence
        '
        Me.txtallowence.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtallowence.ForeColor = System.Drawing.Color.Black
        Me.txtallowence.Location = New System.Drawing.Point(336, 60)
        Me.txtallowence.Margin = New System.Windows.Forms.Padding(2)
        Me.txtallowence.Name = "txtallowence"
        Me.txtallowence.Size = New System.Drawing.Size(280, 25)
        Me.txtallowence.TabIndex = 76
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.addbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addbtn.FlatAppearance.BorderSize = 2
        Me.addbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.addbtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.Location = New System.Drawing.Point(336, 176)
        Me.addbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(80, 32)
        Me.addbtn.TabIndex = 75
        Me.addbtn.Text = "Add"
        Me.addbtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(254, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(211, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Partner Info ID"
        '
        'amounttxt
        '
        Me.amounttxt.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amounttxt.ForeColor = System.Drawing.Color.Black
        Me.amounttxt.Location = New System.Drawing.Point(336, 93)
        Me.amounttxt.Margin = New System.Windows.Forms.Padding(2)
        Me.amounttxt.Name = "amounttxt"
        Me.amounttxt.Size = New System.Drawing.Size(280, 25)
        Me.amounttxt.TabIndex = 72
        '
        'partnerinfoidtxt
        '
        Me.partnerinfoidtxt.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerinfoidtxt.ForeColor = System.Drawing.Color.Black
        Me.partnerinfoidtxt.Location = New System.Drawing.Point(336, 21)
        Me.partnerinfoidtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.partnerinfoidtxt.Name = "partnerinfoidtxt"
        Me.partnerinfoidtxt.Size = New System.Drawing.Size(280, 25)
        Me.partnerinfoidtxt.TabIndex = 71
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.LightCoral
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.FlatAppearance.BorderSize = 2
        Me.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btndelete.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(528, 176)
        Me.btndelete.Margin = New System.Windows.Forms.Padding(6)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(88, 32)
        Me.btndelete.TabIndex = 63
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'Close_form
        '
        Me.Close_form.Image = CType(resources.GetObject("Close_form.Image"), System.Drawing.Image)
        Me.Close_form.Location = New System.Drawing.Point(1040, 16)
        Me.Close_form.Name = "Close_form"
        Me.Close_form.Size = New System.Drawing.Size(30, 30)
        Me.Close_form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Close_form.TabIndex = 108
        Me.Close_form.TabStop = False
        '
        'Allowence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(1088, 600)
        Me.Controls.Add(Me.Close_form)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Allowence"
        Me.Text = "Allowence"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Gdv_allow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbldate As Label
    Friend WithEvents lblallowence_name As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btndelete As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents amounttxt As TextBox
    Friend WithEvents partnerinfoidtxt As TextBox
    Friend WithEvents addbtn As Button
    Friend WithEvents datetxt As DateTimePicker
    Friend WithEvents txtallowence As TextBox
    Friend WithEvents Gdv_allow As DataGridView
    Friend WithEvents Btnrefresh As Button
    Friend WithEvents Close_form As PictureBox
End Class
