<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Partner_Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Partner_Registration))
        Me.Btn_save = New System.Windows.Forms.Button()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel_part_reg = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Close_form = New System.Windows.Forms.PictureBox()
        Me.lblmname = New System.Windows.Forms.Label()
        Me.Txtline3 = New System.Windows.Forms.TextBox()
        Me.Txtline2 = New System.Windows.Forms.TextBox()
        Me.Txtline1 = New System.Windows.Forms.TextBox()
        Me.lbl3line = New System.Windows.Forms.Label()
        Me.lbl2line = New System.Windows.Forms.Label()
        Me.lbl1line = New System.Windows.Forms.Label()
        Me.RadioButton_female = New System.Windows.Forms.RadioButton()
        Me.RadioButton_male = New System.Windows.Forms.RadioButton()
        Me.Txtlname = New System.Windows.Forms.TextBox()
        Me.Txtmname = New System.Windows.Forms.TextBox()
        Me.Txtfname = New System.Windows.Forms.TextBox()
        Me.lbllname = New System.Windows.Forms.Label()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.Btn_delete = New System.Windows.Forms.Button()
        Me.Btnrefresh = New System.Windows.Forms.Button()
        Me.Btnnext = New System.Windows.Forms.Button()
        Me.gdv_part_reg = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txtbranch = New System.Windows.Forms.TextBox()
        Me.Txtacc_num = New System.Windows.Forms.TextBox()
        Me.Txtbank_name = New System.Windows.Forms.TextBox()
        Me.lblbranch = New System.Windows.Forms.Label()
        Me.lblacc_num = New System.Windows.Forms.Label()
        Me.lblbank_name = New System.Windows.Forms.Label()
        Me.Txtp_num = New System.Windows.Forms.TextBox()
        Me.Txtemail = New System.Windows.Forms.TextBox()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblp_num = New System.Windows.Forms.Label()
        Me.Panel_part_reg.SuspendLayout()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdv_part_reg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_save
        '
        Me.Btn_save.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_save.FlatAppearance.BorderSize = 2
        Me.Btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.Btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Btn_save.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_save.Location = New System.Drawing.Point(776, 304)
        Me.Btn_save.Margin = New System.Windows.Forms.Padding(6)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Size = New System.Drawing.Size(80, 32)
        Me.Btn_save.TabIndex = 76
        Me.Btn_save.Text = "Save"
        Me.Btn_save.UseVisualStyleBackColor = False
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.BackColor = System.Drawing.Color.PaleGreen
        Me.lblgender.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.Location = New System.Drawing.Point(120, 152)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(56, 17)
        Me.lblgender.TabIndex = 66
        Me.lblgender.Text = "Gender"
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 104)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Address :"
        '
        'Panel_part_reg
        '
        Me.Panel_part_reg.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel_part_reg.Controls.Add(Me.DateTimePicker1)
        Me.Panel_part_reg.Controls.Add(Me.Close_form)
        Me.Panel_part_reg.Controls.Add(Me.lblmname)
        Me.Panel_part_reg.Controls.Add(Me.Txtline3)
        Me.Panel_part_reg.Controls.Add(Me.Txtline2)
        Me.Panel_part_reg.Controls.Add(Me.Txtline1)
        Me.Panel_part_reg.Controls.Add(Me.lbl3line)
        Me.Panel_part_reg.Controls.Add(Me.lbl2line)
        Me.Panel_part_reg.Controls.Add(Me.lbl1line)
        Me.Panel_part_reg.Controls.Add(Me.RadioButton_female)
        Me.Panel_part_reg.Controls.Add(Me.RadioButton_male)
        Me.Panel_part_reg.Controls.Add(Me.Txtlname)
        Me.Panel_part_reg.Controls.Add(Me.Txtmname)
        Me.Panel_part_reg.Controls.Add(Me.Txtfname)
        Me.Panel_part_reg.Controls.Add(Me.lbllname)
        Me.Panel_part_reg.Controls.Add(Me.lblfname)
        Me.Panel_part_reg.Controls.Add(Me.Btn_delete)
        Me.Panel_part_reg.Controls.Add(Me.Btnrefresh)
        Me.Panel_part_reg.Controls.Add(Me.Btnnext)
        Me.Panel_part_reg.Controls.Add(Me.gdv_part_reg)
        Me.Panel_part_reg.Controls.Add(Me.GroupBox2)
        Me.Panel_part_reg.Controls.Add(Me.Txtp_num)
        Me.Panel_part_reg.Controls.Add(Me.Txtemail)
        Me.Panel_part_reg.Controls.Add(Me.lbldate)
        Me.Panel_part_reg.Controls.Add(Me.lblemail)
        Me.Panel_part_reg.Controls.Add(Me.lblp_num)
        Me.Panel_part_reg.Controls.Add(Me.Btn_save)
        Me.Panel_part_reg.Controls.Add(Me.GroupBox1)
        Me.Panel_part_reg.Controls.Add(Me.lblgender)
        Me.Panel_part_reg.Location = New System.Drawing.Point(56, 0)
        Me.Panel_part_reg.Name = "Panel_part_reg"
        Me.Panel_part_reg.Size = New System.Drawing.Size(992, 584)
        Me.Panel_part_reg.TabIndex = 77
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(632, 112)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(296, 25)
        Me.DateTimePicker1.TabIndex = 106
        '
        'Close_form
        '
        Me.Close_form.Image = CType(resources.GetObject("Close_form.Image"), System.Drawing.Image)
        Me.Close_form.Location = New System.Drawing.Point(952, 8)
        Me.Close_form.Name = "Close_form"
        Me.Close_form.Size = New System.Drawing.Size(30, 30)
        Me.Close_form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Close_form.TabIndex = 105
        Me.Close_form.TabStop = False
        '
        'lblmname
        '
        Me.lblmname.AutoSize = True
        Me.lblmname.BackColor = System.Drawing.Color.PaleGreen
        Me.lblmname.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmname.Location = New System.Drawing.Point(88, 80)
        Me.lblmname.Name = "lblmname"
        Me.lblmname.Size = New System.Drawing.Size(92, 17)
        Me.lblmname.TabIndex = 92
        Me.lblmname.Text = "Middle Name"
        '
        'Txtline3
        '
        Me.Txtline3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtline3.Location = New System.Drawing.Point(189, 243)
        Me.Txtline3.Name = "Txtline3"
        Me.Txtline3.Size = New System.Drawing.Size(280, 25)
        Me.Txtline3.TabIndex = 104
        '
        'Txtline2
        '
        Me.Txtline2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtline2.Location = New System.Drawing.Point(189, 210)
        Me.Txtline2.Name = "Txtline2"
        Me.Txtline2.Size = New System.Drawing.Size(280, 25)
        Me.Txtline2.TabIndex = 103
        '
        'Txtline1
        '
        Me.Txtline1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtline1.Location = New System.Drawing.Point(189, 177)
        Me.Txtline1.Name = "Txtline1"
        Me.Txtline1.Size = New System.Drawing.Size(280, 25)
        Me.Txtline1.TabIndex = 102
        '
        'lbl3line
        '
        Me.lbl3line.AutoSize = True
        Me.lbl3line.BackColor = System.Drawing.Color.PaleGreen
        Me.lbl3line.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3line.Location = New System.Drawing.Point(125, 249)
        Me.lbl3line.Name = "lbl3line"
        Me.lbl3line.Size = New System.Drawing.Size(55, 17)
        Me.lbl3line.TabIndex = 101
        Me.lbl3line.Text = "Line 03"
        '
        'lbl2line
        '
        Me.lbl2line.AutoSize = True
        Me.lbl2line.BackColor = System.Drawing.Color.PaleGreen
        Me.lbl2line.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2line.Location = New System.Drawing.Point(125, 216)
        Me.lbl2line.Name = "lbl2line"
        Me.lbl2line.Size = New System.Drawing.Size(55, 17)
        Me.lbl2line.TabIndex = 100
        Me.lbl2line.Text = "Line 02"
        '
        'lbl1line
        '
        Me.lbl1line.AutoSize = True
        Me.lbl1line.BackColor = System.Drawing.Color.PaleGreen
        Me.lbl1line.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1line.Location = New System.Drawing.Point(125, 183)
        Me.lbl1line.Name = "lbl1line"
        Me.lbl1line.Size = New System.Drawing.Size(55, 17)
        Me.lbl1line.TabIndex = 99
        Me.lbl1line.Text = "Line 01"
        '
        'RadioButton_female
        '
        Me.RadioButton_female.AutoSize = True
        Me.RadioButton_female.BackColor = System.Drawing.Color.PaleGreen
        Me.RadioButton_female.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_female.Location = New System.Drawing.Point(341, 151)
        Me.RadioButton_female.Name = "RadioButton_female"
        Me.RadioButton_female.Size = New System.Drawing.Size(75, 21)
        Me.RadioButton_female.TabIndex = 98
        Me.RadioButton_female.TabStop = True
        Me.RadioButton_female.Text = "Female"
        Me.RadioButton_female.UseVisualStyleBackColor = False
        '
        'RadioButton_male
        '
        Me.RadioButton_male.AutoSize = True
        Me.RadioButton_male.BackColor = System.Drawing.Color.PaleGreen
        Me.RadioButton_male.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_male.Location = New System.Drawing.Point(197, 151)
        Me.RadioButton_male.Name = "RadioButton_male"
        Me.RadioButton_male.Size = New System.Drawing.Size(56, 21)
        Me.RadioButton_male.TabIndex = 97
        Me.RadioButton_male.TabStop = True
        Me.RadioButton_male.Text = "Male"
        Me.RadioButton_male.UseVisualStyleBackColor = False
        '
        'Txtlname
        '
        Me.Txtlname.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtlname.Location = New System.Drawing.Point(189, 113)
        Me.Txtlname.Name = "Txtlname"
        Me.Txtlname.Size = New System.Drawing.Size(280, 25)
        Me.Txtlname.TabIndex = 96
        '
        'Txtmname
        '
        Me.Txtmname.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtmname.Location = New System.Drawing.Point(189, 80)
        Me.Txtmname.Name = "Txtmname"
        Me.Txtmname.Size = New System.Drawing.Size(280, 25)
        Me.Txtmname.TabIndex = 95
        '
        'Txtfname
        '
        Me.Txtfname.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfname.Location = New System.Drawing.Point(189, 47)
        Me.Txtfname.Name = "Txtfname"
        Me.Txtfname.Size = New System.Drawing.Size(280, 25)
        Me.Txtfname.TabIndex = 94
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.BackColor = System.Drawing.Color.PaleGreen
        Me.lbllname.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllname.Location = New System.Drawing.Point(101, 113)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(79, 17)
        Me.lbllname.TabIndex = 93
        Me.lbllname.Text = "Last Name"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.BackColor = System.Drawing.Color.PaleGreen
        Me.lblfname.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.Location = New System.Drawing.Point(100, 47)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(80, 17)
        Me.lblfname.TabIndex = 91
        Me.lblfname.Text = "First Name"
        '
        'Btn_delete
        '
        Me.Btn_delete.BackColor = System.Drawing.Color.LightCoral
        Me.Btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btn_delete.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_delete.Location = New System.Drawing.Point(648, 304)
        Me.Btn_delete.Margin = New System.Windows.Forms.Padding(6)
        Me.Btn_delete.Name = "Btn_delete"
        Me.Btn_delete.Size = New System.Drawing.Size(80, 32)
        Me.Btn_delete.TabIndex = 90
        Me.Btn_delete.Text = "Delete"
        Me.Btn_delete.UseVisualStyleBackColor = False
        '
        'Btnrefresh
        '
        Me.Btnrefresh.BackColor = System.Drawing.Color.Gainsboro
        Me.Btnrefresh.FlatAppearance.BorderSize = 2
        Me.Btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.Btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow
        Me.Btnrefresh.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.Btnrefresh.Location = New System.Drawing.Point(40, 312)
        Me.Btnrefresh.Name = "Btnrefresh"
        Me.Btnrefresh.Size = New System.Drawing.Size(88, 32)
        Me.Btnrefresh.TabIndex = 88
        Me.Btnrefresh.Text = " Refresh"
        Me.Btnrefresh.UseVisualStyleBackColor = False
        '
        'Btnnext
        '
        Me.Btnnext.BackColor = System.Drawing.Color.RosyBrown
        Me.Btnnext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnnext.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnnext.Location = New System.Drawing.Point(904, 280)
        Me.Btnnext.Margin = New System.Windows.Forms.Padding(6)
        Me.Btnnext.Name = "Btnnext"
        Me.Btnnext.Size = New System.Drawing.Size(80, 56)
        Me.Btnnext.TabIndex = 87
        Me.Btnnext.Text = "Next"
        Me.Btnnext.UseVisualStyleBackColor = False
        '
        'gdv_part_reg
        '
        Me.gdv_part_reg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.gdv_part_reg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdv_part_reg.Location = New System.Drawing.Point(40, 352)
        Me.gdv_part_reg.Name = "gdv_part_reg"
        Me.gdv_part_reg.Size = New System.Drawing.Size(928, 224)
        Me.gdv_part_reg.TabIndex = 86
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Txtbranch)
        Me.GroupBox2.Controls.Add(Me.Txtacc_num)
        Me.GroupBox2.Controls.Add(Me.Txtbank_name)
        Me.GroupBox2.Controls.Add(Me.lblbranch)
        Me.GroupBox2.Controls.Add(Me.lblacc_num)
        Me.GroupBox2.Controls.Add(Me.lblbank_name)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(496, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 128)
        Me.GroupBox2.TabIndex = 85
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bank Details"
        '
        'Txtbranch
        '
        Me.Txtbranch.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbranch.Location = New System.Drawing.Point(144, 88)
        Me.Txtbranch.Name = "Txtbranch"
        Me.Txtbranch.Size = New System.Drawing.Size(288, 25)
        Me.Txtbranch.TabIndex = 74
        '
        'Txtacc_num
        '
        Me.Txtacc_num.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtacc_num.Location = New System.Drawing.Point(144, 55)
        Me.Txtacc_num.Name = "Txtacc_num"
        Me.Txtacc_num.Size = New System.Drawing.Size(288, 25)
        Me.Txtacc_num.TabIndex = 73
        '
        'Txtbank_name
        '
        Me.Txtbank_name.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbank_name.Location = New System.Drawing.Point(144, 22)
        Me.Txtbank_name.Name = "Txtbank_name"
        Me.Txtbank_name.Size = New System.Drawing.Size(288, 25)
        Me.Txtbank_name.TabIndex = 72
        '
        'lblbranch
        '
        Me.lblbranch.AutoSize = True
        Me.lblbranch.BackColor = System.Drawing.Color.Transparent
        Me.lblbranch.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbranch.Location = New System.Drawing.Point(77, 91)
        Me.lblbranch.Name = "lblbranch"
        Me.lblbranch.Size = New System.Drawing.Size(55, 17)
        Me.lblbranch.TabIndex = 68
        Me.lblbranch.Text = "Branch"
        '
        'lblacc_num
        '
        Me.lblacc_num.AutoSize = True
        Me.lblacc_num.BackColor = System.Drawing.Color.Transparent
        Me.lblacc_num.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacc_num.Location = New System.Drawing.Point(15, 59)
        Me.lblacc_num.Name = "lblacc_num"
        Me.lblacc_num.Size = New System.Drawing.Size(117, 17)
        Me.lblacc_num.TabIndex = 67
        Me.lblacc_num.Text = "Account Number"
        '
        'lblbank_name
        '
        Me.lblbank_name.AutoSize = True
        Me.lblbank_name.BackColor = System.Drawing.Color.Transparent
        Me.lblbank_name.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbank_name.Location = New System.Drawing.Point(48, 27)
        Me.lblbank_name.Name = "lblbank_name"
        Me.lblbank_name.Size = New System.Drawing.Size(84, 17)
        Me.lblbank_name.TabIndex = 65
        Me.lblbank_name.Text = "Bank Name"
        '
        'Txtp_num
        '
        Me.Txtp_num.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtp_num.Location = New System.Drawing.Point(632, 80)
        Me.Txtp_num.Name = "Txtp_num"
        Me.Txtp_num.Size = New System.Drawing.Size(296, 25)
        Me.Txtp_num.TabIndex = 83
        '
        'Txtemail
        '
        Me.Txtemail.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtemail.Location = New System.Drawing.Point(632, 43)
        Me.Txtemail.Name = "Txtemail"
        Me.Txtemail.Size = New System.Drawing.Size(296, 25)
        Me.Txtemail.TabIndex = 82
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.BackColor = System.Drawing.Color.Transparent
        Me.lbldate.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(584, 114)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(39, 17)
        Me.lbldate.TabIndex = 81
        Me.lbldate.Text = "Date"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.BackColor = System.Drawing.Color.Transparent
        Me.lblemail.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblemail.Location = New System.Drawing.Point(573, 48)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(50, 17)
        Me.lblemail.TabIndex = 80
        Me.lblemail.Text = "E-mail"
        '
        'lblp_num
        '
        Me.lblp_num.AutoSize = True
        Me.lblp_num.BackColor = System.Drawing.Color.Transparent
        Me.lblp_num.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblp_num.Location = New System.Drawing.Point(517, 81)
        Me.lblp_num.Name = "lblp_num"
        Me.lblp_num.Size = New System.Drawing.Size(106, 17)
        Me.lblp_num.TabIndex = 79
        Me.lblp_num.Text = "Phone Number"
        '
        'Partner_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(1088, 600)
        Me.Controls.Add(Me.Panel_part_reg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Partner_Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Partner_Registration"
        Me.Panel_part_reg.ResumeLayout(False)
        Me.Panel_part_reg.PerformLayout()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdv_part_reg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_save As Button
    Friend WithEvents lblgender As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel_part_reg As Panel
    Friend WithEvents gdv_part_reg As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Txtbranch As TextBox
    Friend WithEvents Txtacc_num As TextBox
    Friend WithEvents Txtbank_name As TextBox
    Friend WithEvents lblbranch As Label
    Friend WithEvents lblacc_num As Label
    Friend WithEvents lblbank_name As Label
    Friend WithEvents Txtp_num As TextBox
    Friend WithEvents Txtemail As TextBox
    Friend WithEvents lbldate As Label
    Friend WithEvents lblemail As Label
    Friend WithEvents lblp_num As Label
    Friend WithEvents Btnnext As Button
    Friend WithEvents Btnrefresh As Button
    Friend WithEvents Btn_delete As Button
    Friend WithEvents lblmname As Label
    Friend WithEvents Txtline3 As TextBox
    Friend WithEvents Txtline2 As TextBox
    Friend WithEvents Txtline1 As TextBox
    Friend WithEvents lbl3line As Label
    Friend WithEvents lbl2line As Label
    Friend WithEvents lbl1line As Label
    Friend WithEvents RadioButton_female As RadioButton
    Friend WithEvents RadioButton_male As RadioButton
    Friend WithEvents Txtlname As TextBox
    Friend WithEvents Txtmname As TextBox
    Friend WithEvents Txtfname As TextBox
    Friend WithEvents lbllname As Label
    Friend WithEvents lblfname As Label
    Friend WithEvents Close_form As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
