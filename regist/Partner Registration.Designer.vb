<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Partner_Registration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.txtmname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtpartner_regid = New System.Windows.Forms.TextBox()
        Me.lbllname = New System.Windows.Forms.Label()
        Me.lblmname = New System.Windows.Forms.Label()
        Me.lblfname = New System.Windows.Forms.Label()
        Me.lblpartner_regid = New System.Windows.Forms.Label()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.RadioButton_male = New System.Windows.Forms.RadioButton()
        Me.RadioButton_female = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt2Line = New System.Windows.Forms.TextBox()
        Me.txt1line = New System.Windows.Forms.TextBox()
        Me.lbl3line = New System.Windows.Forms.Label()
        Me.lbl2line = New System.Windows.Forms.Label()
        Me.lbl1line = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(240, 176)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(280, 26)
        Me.txtlname.TabIndex = 39
        '
        'txtmname
        '
        Me.txtmname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.Location = New System.Drawing.Point(240, 128)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.Size = New System.Drawing.Size(280, 26)
        Me.txtmname.TabIndex = 38
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(240, 80)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(280, 26)
        Me.txtfname.TabIndex = 37
        '
        'txtpartner_regid
        '
        Me.txtpartner_regid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpartner_regid.Location = New System.Drawing.Point(240, 32)
        Me.txtpartner_regid.Name = "txtpartner_regid"
        Me.txtpartner_regid.Size = New System.Drawing.Size(280, 26)
        Me.txtpartner_regid.TabIndex = 36
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.BackColor = System.Drawing.Color.LightGreen
        Me.lbllname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllname.Location = New System.Drawing.Point(112, 175)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(84, 18)
        Me.lbllname.TabIndex = 30
        Me.lbllname.Text = "Last Name"
        '
        'lblmname
        '
        Me.lblmname.AutoSize = True
        Me.lblmname.BackColor = System.Drawing.Color.LightGreen
        Me.lblmname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmname.Location = New System.Drawing.Point(95, 130)
        Me.lblmname.Name = "lblmname"
        Me.lblmname.Size = New System.Drawing.Size(101, 18)
        Me.lblmname.TabIndex = 27
        Me.lblmname.Text = "Middle Name"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.BackColor = System.Drawing.Color.LightGreen
        Me.lblfname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.Location = New System.Drawing.Point(111, 85)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(85, 18)
        Me.lblfname.TabIndex = 26
        Me.lblfname.Text = "First Name"
        '
        'lblpartner_regid
        '
        Me.lblpartner_regid.AutoSize = True
        Me.lblpartner_regid.BackColor = System.Drawing.Color.LightGreen
        Me.lblpartner_regid.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpartner_regid.Location = New System.Drawing.Point(55, 40)
        Me.lblpartner_regid.Name = "lblpartner_regid"
        Me.lblpartner_regid.Size = New System.Drawing.Size(141, 18)
        Me.lblpartner_regid.TabIndex = 25
        Me.lblpartner_regid.Text = "Partner Register ID"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.BackColor = System.Drawing.Color.LightGreen
        Me.lblgender.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.Location = New System.Drawing.Point(136, 220)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(60, 18)
        Me.lblgender.TabIndex = 47
        Me.lblgender.Text = "Gender"
        '
        'RadioButton_male
        '
        Me.RadioButton_male.AutoSize = True
        Me.RadioButton_male.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton_male.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_male.Location = New System.Drawing.Point(248, 224)
        Me.RadioButton_male.Name = "RadioButton_male"
        Me.RadioButton_male.Size = New System.Drawing.Size(60, 22)
        Me.RadioButton_male.TabIndex = 48
        Me.RadioButton_male.TabStop = True
        Me.RadioButton_male.Text = "Male"
        Me.RadioButton_male.UseVisualStyleBackColor = False
        '
        'RadioButton_female
        '
        Me.RadioButton_female.AutoSize = True
        Me.RadioButton_female.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton_female.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_female.Location = New System.Drawing.Point(392, 224)
        Me.RadioButton_female.Name = "RadioButton_female"
        Me.RadioButton_female.Size = New System.Drawing.Size(79, 22)
        Me.RadioButton_female.TabIndex = 49
        Me.RadioButton_female.TabStop = True
        Me.RadioButton_female.Text = "Female"
        Me.RadioButton_female.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(240, 400)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 26)
        Me.TextBox1.TabIndex = 56
        '
        'txt2Line
        '
        Me.txt2Line.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2Line.Location = New System.Drawing.Point(240, 352)
        Me.txt2Line.Name = "txt2Line"
        Me.txt2Line.Size = New System.Drawing.Size(280, 26)
        Me.txt2Line.TabIndex = 55
        '
        'txt1line
        '
        Me.txt1line.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1line.Location = New System.Drawing.Point(240, 304)
        Me.txt1line.Name = "txt1line"
        Me.txt1line.Size = New System.Drawing.Size(280, 26)
        Me.txt1line.TabIndex = 54
        '
        'lbl3line
        '
        Me.lbl3line.AutoSize = True
        Me.lbl3line.BackColor = System.Drawing.Color.LightGreen
        Me.lbl3line.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3line.Location = New System.Drawing.Point(136, 400)
        Me.lbl3line.Name = "lbl3line"
        Me.lbl3line.Size = New System.Drawing.Size(60, 18)
        Me.lbl3line.TabIndex = 53
        Me.lbl3line.Text = "Line 03"
        '
        'lbl2line
        '
        Me.lbl2line.AutoSize = True
        Me.lbl2line.BackColor = System.Drawing.Color.LightGreen
        Me.lbl2line.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2line.Location = New System.Drawing.Point(136, 355)
        Me.lbl2line.Name = "lbl2line"
        Me.lbl2line.Size = New System.Drawing.Size(60, 18)
        Me.lbl2line.TabIndex = 52
        Me.lbl2line.Text = "Line 02"
        '
        'lbl1line
        '
        Me.lbl1line.AutoSize = True
        Me.lbl1line.BackColor = System.Drawing.Color.LightGreen
        Me.lbl1line.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1line.Location = New System.Drawing.Point(136, 310)
        Me.lbl1line.Name = "lbl1line"
        Me.lbl1line.Size = New System.Drawing.Size(60, 18)
        Me.lbl1line.TabIndex = 51
        Me.lbl1line.Text = "Line 01"
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.BackColor = System.Drawing.Color.LightGreen
        Me.lbladdress.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(129, 265)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(67, 18)
        Me.lbladdress.TabIndex = 50
        Me.lbladdress.Text = "Address"
        '
        'btn_next
        '
        Me.btn_next.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_next.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(240, 456)
        Me.btn_next.Margin = New System.Windows.Forms.Padding(6)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(128, 50)
        Me.btn_next.TabIndex = 57
        Me.btn_next.Text = "Next"
        Me.btn_next.UseVisualStyleBackColor = False
        '
        'Partner_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(644, 529)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txt2Line)
        Me.Controls.Add(Me.txt1line)
        Me.Controls.Add(Me.lbl3line)
        Me.Controls.Add(Me.lbl2line)
        Me.Controls.Add(Me.lbl1line)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.RadioButton_female)
        Me.Controls.Add(Me.RadioButton_male)
        Me.Controls.Add(Me.lblgender)
        Me.Controls.Add(Me.txtlname)
        Me.Controls.Add(Me.txtmname)
        Me.Controls.Add(Me.txtfname)
        Me.Controls.Add(Me.txtpartner_regid)
        Me.Controls.Add(Me.lbllname)
        Me.Controls.Add(Me.lblmname)
        Me.Controls.Add(Me.lblfname)
        Me.Controls.Add(Me.lblpartner_regid)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Partner_Registration"
        Me.Text = "Partner_Registration - I"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtmname As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtpartner_regid As TextBox
    Friend WithEvents lbllname As Label
    Friend WithEvents lblmname As Label
    Friend WithEvents lblfname As Label
    Friend WithEvents lblpartner_regid As Label
    Friend WithEvents lblgender As Label
    Friend WithEvents RadioButton_male As RadioButton
    Friend WithEvents RadioButton_female As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt2Line As TextBox
    Friend WithEvents txt1line As TextBox
    Friend WithEvents lbl3line As Label
    Friend WithEvents lbl2line As Label
    Friend WithEvents lbl1line As Label
    Friend WithEvents lbladdress As Label
    Friend WithEvents btn_next As Button
End Class
