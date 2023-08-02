<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier_Invoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supplier_Invoice))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtSupAllow = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtSupFer = New System.Windows.Forms.TextBox()
        Me.TxtSupAdv = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtTCPK = New System.Windows.Forms.TextBox()
        Me.TxtTA = New System.Windows.Forms.TextBox()
        Me.TxtMR = New System.Windows.Forms.TextBox()
        Me.TxtTQ = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnInfo_view = New System.Windows.Forms.Button()
        Me.Btnrefresh = New System.Windows.Forms.Button()
        Me.BtnSum = New System.Windows.Forms.Button()
        Me.Gdv_sup_invo = New System.Windows.Forms.DataGridView()
        Me.DtSupPd = New System.Windows.Forms.DateTimePicker()
        Me.TxtSupPifid = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DtSupIsD = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Close_form = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Gdv_sup_invo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSupAllow)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(336, 56)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Addition"
        '
        'TxtSupAllow
        '
        Me.TxtSupAllow.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSupAllow.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TxtSupAllow.Location = New System.Drawing.Point(136, 28)
        Me.TxtSupAllow.Name = "TxtSupAllow"
        Me.TxtSupAllow.Size = New System.Drawing.Size(192, 26)
        Me.TxtSupAllow.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Allowances"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtSupFer)
        Me.GroupBox2.Controls.Add(Me.TxtSupAdv)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(8, 232)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 120)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deduction"
        '
        'TxtSupFer
        '
        Me.TxtSupFer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSupFer.Location = New System.Drawing.Point(136, 52)
        Me.TxtSupFer.Name = "TxtSupFer"
        Me.TxtSupFer.Size = New System.Drawing.Size(192, 26)
        Me.TxtSupFer.TabIndex = 8
        '
        'TxtSupAdv
        '
        Me.TxtSupAdv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSupAdv.Location = New System.Drawing.Point(136, 20)
        Me.TxtSupAdv.Name = "TxtSupAdv"
        Me.TxtSupAdv.Size = New System.Drawing.Size(192, 26)
        Me.TxtSupAdv.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(52, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 18)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Fertilizer"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(51, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Advance"
        '
        'Btndelete
        '
        Me.Btndelete.BackColor = System.Drawing.Color.LightCoral
        Me.Btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btndelete.FlatAppearance.BorderSize = 2
        Me.Btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btndelete.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.Location = New System.Drawing.Point(536, 496)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(115, 40)
        Me.Btndelete.TabIndex = 42
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
        Me.Btnadd.Location = New System.Drawing.Point(376, 496)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(115, 40)
        Me.Btnadd.TabIndex = 41
        Me.Btnadd.Text = "ADD"
        Me.Btnadd.UseVisualStyleBackColor = False
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(144, 369)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(192, 25)
        Me.TxtTotal.TabIndex = 10
        '
        'TxtTCPK
        '
        Me.TxtTCPK.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTCPK.Location = New System.Drawing.Point(144, 320)
        Me.TxtTCPK.Name = "TxtTCPK"
        Me.TxtTCPK.Size = New System.Drawing.Size(192, 25)
        Me.TxtTCPK.TabIndex = 9
        '
        'TxtTA
        '
        Me.TxtTA.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTA.Location = New System.Drawing.Point(144, 136)
        Me.TxtTA.Name = "TxtTA"
        Me.TxtTA.Size = New System.Drawing.Size(192, 25)
        Me.TxtTA.TabIndex = 5
        '
        'TxtMR
        '
        Me.TxtMR.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMR.Location = New System.Drawing.Point(144, 102)
        Me.TxtMR.Name = "TxtMR"
        Me.TxtMR.Size = New System.Drawing.Size(192, 25)
        Me.TxtMR.TabIndex = 4
        '
        'TxtTQ
        '
        Me.TxtTQ.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTQ.Location = New System.Drawing.Point(144, 68)
        Me.TxtTQ.Name = "TxtTQ"
        Me.TxtTQ.Size = New System.Drawing.Size(192, 25)
        Me.TxtTQ.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(89, 372)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 17)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 320)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 17)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Transport Cost "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Total Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Monthly Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Total Quantity"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Controls.Add(Me.TxtTCPK)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.BtnInfo_view)
        Me.Panel1.Controls.Add(Me.Btnrefresh)
        Me.Panel1.Controls.Add(Me.BtnSum)
        Me.Panel1.Controls.Add(Me.Gdv_sup_invo)
        Me.Panel1.Controls.Add(Me.DtSupPd)
        Me.Panel1.Controls.Add(Me.TxtSupPifid)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.DtSupIsD)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Btndelete)
        Me.Panel1.Controls.Add(Me.Btnadd)
        Me.Panel1.Controls.Add(Me.TxtTotal)
        Me.Panel1.Controls.Add(Me.TxtTA)
        Me.Panel1.Controls.Add(Me.TxtMR)
        Me.Panel1.Controls.Add(Me.TxtTQ)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(8, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1096, 560)
        Me.Panel1.TabIndex = 47
        '
        'BtnInfo_view
        '
        Me.BtnInfo_view.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnInfo_view.FlatAppearance.BorderSize = 2
        Me.BtnInfo_view.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.BtnInfo_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow
        Me.BtnInfo_view.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.BtnInfo_view.Location = New System.Drawing.Point(360, 16)
        Me.BtnInfo_view.Name = "BtnInfo_view"
        Me.BtnInfo_view.Size = New System.Drawing.Size(208, 32)
        Me.BtnInfo_view.TabIndex = 107
        Me.BtnInfo_view.Text = "Partner Info View"
        Me.BtnInfo_view.UseVisualStyleBackColor = False
        '
        'Btnrefresh
        '
        Me.Btnrefresh.BackColor = System.Drawing.Color.Gainsboro
        Me.Btnrefresh.FlatAppearance.BorderSize = 2
        Me.Btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.Btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow
        Me.Btnrefresh.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.Btnrefresh.Location = New System.Drawing.Point(944, 16)
        Me.Btnrefresh.Name = "Btnrefresh"
        Me.Btnrefresh.Size = New System.Drawing.Size(104, 32)
        Me.Btnrefresh.TabIndex = 64
        Me.Btnrefresh.Text = "Refresh"
        Me.Btnrefresh.UseVisualStyleBackColor = False
        '
        'BtnSum
        '
        Me.BtnSum.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnSum.FlatAppearance.BorderSize = 2
        Me.BtnSum.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.BtnSum.Location = New System.Drawing.Point(144, 472)
        Me.BtnSum.Name = "BtnSum"
        Me.BtnSum.Size = New System.Drawing.Size(192, 48)
        Me.BtnSum.TabIndex = 63
        Me.BtnSum.Text = "Get the Total"
        Me.BtnSum.UseVisualStyleBackColor = False
        '
        'Gdv_sup_invo
        '
        Me.Gdv_sup_invo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Gdv_sup_invo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gdv_sup_invo.Location = New System.Drawing.Point(360, 56)
        Me.Gdv_sup_invo.Name = "Gdv_sup_invo"
        Me.Gdv_sup_invo.Size = New System.Drawing.Size(712, 424)
        Me.Gdv_sup_invo.TabIndex = 62
        '
        'DtSupPd
        '
        Me.DtSupPd.CustomFormat = "yyyy-MM-dd"
        Me.DtSupPd.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtSupPd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtSupPd.Location = New System.Drawing.Point(144, 400)
        Me.DtSupPd.Margin = New System.Windows.Forms.Padding(2)
        Me.DtSupPd.Name = "DtSupPd"
        Me.DtSupPd.Size = New System.Drawing.Size(192, 25)
        Me.DtSupPd.TabIndex = 61
        Me.DtSupPd.Value = New Date(2021, 8, 28, 18, 49, 29, 0)
        '
        'TxtSupPifid
        '
        Me.TxtSupPifid.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSupPifid.Location = New System.Drawing.Point(144, 24)
        Me.TxtSupPifid.Name = "TxtSupPifid"
        Me.TxtSupPifid.Size = New System.Drawing.Size(192, 25)
        Me.TxtSupPifid.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(88, 440)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 17)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Date"
        '
        'DtSupIsD
        '
        Me.DtSupIsD.CustomFormat = "yyyy-MM-dd"
        Me.DtSupIsD.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtSupIsD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtSupIsD.Location = New System.Drawing.Point(144, 435)
        Me.DtSupIsD.Margin = New System.Windows.Forms.Padding(2)
        Me.DtSupIsD.Name = "DtSupIsD"
        Me.DtSupIsD.Size = New System.Drawing.Size(192, 25)
        Me.DtSupIsD.TabIndex = 58
        Me.DtSupIsD.Value = New Date(2021, 8, 28, 18, 49, 29, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(26, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 17)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Payment Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Partner Info.ID"
        '
        'Close_form
        '
        Me.Close_form.Image = CType(resources.GetObject("Close_form.Image"), System.Drawing.Image)
        Me.Close_form.Location = New System.Drawing.Point(1040, 8)
        Me.Close_form.Name = "Close_form"
        Me.Close_form.Size = New System.Drawing.Size(30, 30)
        Me.Close_form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Close_form.TabIndex = 106
        Me.Close_form.TabStop = False
        '
        'Supplier_Invoice
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
        Me.Name = "Supplier_Invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier Invoice"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Gdv_sup_invo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtSupAllow As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtSupFer As TextBox
    Friend WithEvents TxtSupAdv As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Btndelete As Button
    Friend WithEvents Btnadd As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtTCPK As TextBox
    Friend WithEvents TxtTA As TextBox
    Friend WithEvents TxtMR As TextBox
    Friend WithEvents TxtTQ As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DtSupIsD As DateTimePicker
    Friend WithEvents TxtSupPifid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DtSupPd As DateTimePicker
    Friend WithEvents Close_form As PictureBox
    Friend WithEvents Gdv_sup_invo As DataGridView
    Friend WithEvents BtnSum As Button
    Friend WithEvents Btnrefresh As Button
    Friend WithEvents BtnInfo_view As Button
End Class
