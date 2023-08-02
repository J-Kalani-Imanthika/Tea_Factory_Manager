<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Login
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
        Me.Txtusername = New System.Windows.Forms.TextBox()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.Panel_user = New System.Windows.Forms.Panel()
        Me.Lbl_userlogin = New System.Windows.Forms.Label()
        Me.Btncancal = New System.Windows.Forms.Button()
        Me.Lblmsgshow = New System.Windows.Forms.Label()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.Btn_login = New System.Windows.Forms.Button()
        Me.Paneluser = New System.Windows.Forms.Panel()
        Me.Panelpw = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureLogo = New System.Windows.Forms.PictureBox()
        Me.Panel_admin = New System.Windows.Forms.Panel()
        Me.Lbl_adminpanel = New System.Windows.Forms.Label()
        Me.Btn_admincancel = New System.Windows.Forms.Button()
        Me.ad_Lblmsgshow = New System.Windows.Forms.Label()
        Me.Txt_adminpw = New System.Windows.Forms.TextBox()
        Me.Btn_adminlogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Paneadmin = New System.Windows.Forms.Panel()
        Me.UserLoginBtn = New System.Windows.Forms.Button()
        Me.AdminLoginBtn = New System.Windows.Forms.Button()
        Me.Panel_user.SuspendLayout()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_admin.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txtusername
        '
        Me.Txtusername.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtusername.Location = New System.Drawing.Point(134, 52)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.Size = New System.Drawing.Size(280, 26)
        Me.Txtusername.TabIndex = 48
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblpassword.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpassword.Location = New System.Drawing.Point(49, 107)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(69, 20)
        Me.lblpassword.TabIndex = 47
        Me.lblpassword.Text = "Password"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblusername.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblusername.Location = New System.Drawing.Point(48, 59)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(76, 20)
        Me.lblusername.TabIndex = 46
        Me.lblusername.Text = "User Name"
        '
        'Panel_user
        '
        Me.Panel_user.BackColor = System.Drawing.Color.Transparent
        Me.Panel_user.Controls.Add(Me.Lbl_userlogin)
        Me.Panel_user.Controls.Add(Me.Btncancal)
        Me.Panel_user.Controls.Add(Me.Lblmsgshow)
        Me.Panel_user.Controls.Add(Me.Txtpassword)
        Me.Panel_user.Controls.Add(Me.Txtusername)
        Me.Panel_user.Controls.Add(Me.Btn_login)
        Me.Panel_user.Controls.Add(Me.lblpassword)
        Me.Panel_user.Controls.Add(Me.lblusername)
        Me.Panel_user.Controls.Add(Me.Paneluser)
        Me.Panel_user.Controls.Add(Me.Panelpw)
        Me.Panel_user.Location = New System.Drawing.Point(272, 216)
        Me.Panel_user.Name = "Panel_user"
        Me.Panel_user.Size = New System.Drawing.Size(440, 256)
        Me.Panel_user.TabIndex = 50
        '
        'Lbl_userlogin
        '
        Me.Lbl_userlogin.AutoSize = True
        Me.Lbl_userlogin.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_userlogin.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_userlogin.Location = New System.Drawing.Point(344, 16)
        Me.Lbl_userlogin.Name = "Lbl_userlogin"
        Me.Lbl_userlogin.Size = New System.Drawing.Size(77, 20)
        Me.Lbl_userlogin.TabIndex = 57
        Me.Lbl_userlogin.Text = "User Login"
        '
        'Btncancal
        '
        Me.Btncancal.BackColor = System.Drawing.Color.Crimson
        Me.Btncancal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btncancal.FlatAppearance.BorderColor = System.Drawing.Color.Pink
        Me.Btncancal.FlatAppearance.BorderSize = 4
        Me.Btncancal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.Btncancal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btncancal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btncancal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncancal.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Btncancal.Location = New System.Drawing.Point(288, 192)
        Me.Btncancal.Margin = New System.Windows.Forms.Padding(6)
        Me.Btncancal.Name = "Btncancal"
        Me.Btncancal.Size = New System.Drawing.Size(128, 40)
        Me.Btncancal.TabIndex = 55
        Me.Btncancal.Text = "Cancal"
        Me.Btncancal.UseVisualStyleBackColor = False
        '
        'Lblmsgshow
        '
        Me.Lblmsgshow.AutoSize = True
        Me.Lblmsgshow.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmsgshow.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Lblmsgshow.Location = New System.Drawing.Point(40, 152)
        Me.Lblmsgshow.Name = "Lblmsgshow"
        Me.Lblmsgshow.Size = New System.Drawing.Size(12, 17)
        Me.Lblmsgshow.TabIndex = 54
        Me.Lblmsgshow.Text = "|"
        '
        'Txtpassword
        '
        Me.Txtpassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpassword.Location = New System.Drawing.Point(134, 100)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtpassword.Size = New System.Drawing.Size(280, 26)
        Me.Txtpassword.TabIndex = 52
        '
        'Btn_login
        '
        Me.Btn_login.BackColor = System.Drawing.Color.Blue
        Me.Btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_login.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.Btn_login.FlatAppearance.BorderSize = 4
        Me.Btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_login.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_login.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Btn_login.Location = New System.Drawing.Point(40, 192)
        Me.Btn_login.Margin = New System.Windows.Forms.Padding(6)
        Me.Btn_login.Name = "Btn_login"
        Me.Btn_login.Size = New System.Drawing.Size(128, 40)
        Me.Btn_login.TabIndex = 50
        Me.Btn_login.Text = "Login"
        Me.Btn_login.UseVisualStyleBackColor = False
        '
        'Paneluser
        '
        Me.Paneluser.Location = New System.Drawing.Point(40, 48)
        Me.Paneluser.Name = "Paneluser"
        Me.Paneluser.Size = New System.Drawing.Size(378, 35)
        Me.Paneluser.TabIndex = 51
        '
        'Panelpw
        '
        Me.Panelpw.Location = New System.Drawing.Point(40, 96)
        Me.Panelpw.Name = "Panelpw"
        Me.Panelpw.Size = New System.Drawing.Size(378, 35)
        Me.Panelpw.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(256, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(475, 114)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "      Tea Supplier " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Management System"
        '
        'PictureLogo
        '
        Me.PictureLogo.Image = Global.Tea_Supplier_Management.My.Resources.Resources.factory_logo___3D_silver
        Me.PictureLogo.Location = New System.Drawing.Point(24, 0)
        Me.PictureLogo.Name = "PictureLogo"
        Me.PictureLogo.Size = New System.Drawing.Size(144, 128)
        Me.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureLogo.TabIndex = 51
        Me.PictureLogo.TabStop = False
        '
        'Panel_admin
        '
        Me.Panel_admin.BackColor = System.Drawing.Color.Transparent
        Me.Panel_admin.Controls.Add(Me.Lbl_adminpanel)
        Me.Panel_admin.Controls.Add(Me.Btn_admincancel)
        Me.Panel_admin.Controls.Add(Me.ad_Lblmsgshow)
        Me.Panel_admin.Controls.Add(Me.Txt_adminpw)
        Me.Panel_admin.Controls.Add(Me.Btn_adminlogin)
        Me.Panel_admin.Controls.Add(Me.Label3)
        Me.Panel_admin.Controls.Add(Me.Paneadmin)
        Me.Panel_admin.Location = New System.Drawing.Point(288, 256)
        Me.Panel_admin.Margin = New System.Windows.Forms.Padding(7)
        Me.Panel_admin.Name = "Panel_admin"
        Me.Panel_admin.Size = New System.Drawing.Size(424, 208)
        Me.Panel_admin.TabIndex = 56
        '
        'Lbl_adminpanel
        '
        Me.Lbl_adminpanel.AutoSize = True
        Me.Lbl_adminpanel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_adminpanel.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_adminpanel.Location = New System.Drawing.Point(320, 16)
        Me.Lbl_adminpanel.Name = "Lbl_adminpanel"
        Me.Lbl_adminpanel.Size = New System.Drawing.Size(90, 20)
        Me.Lbl_adminpanel.TabIndex = 56
        Me.Lbl_adminpanel.Text = "Admin Login"
        '
        'Btn_admincancel
        '
        Me.Btn_admincancel.BackColor = System.Drawing.Color.Crimson
        Me.Btn_admincancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_admincancel.FlatAppearance.BorderColor = System.Drawing.Color.Pink
        Me.Btn_admincancel.FlatAppearance.BorderSize = 4
        Me.Btn_admincancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.Btn_admincancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btn_admincancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_admincancel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_admincancel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Btn_admincancel.Location = New System.Drawing.Point(272, 152)
        Me.Btn_admincancel.Margin = New System.Windows.Forms.Padding(6)
        Me.Btn_admincancel.Name = "Btn_admincancel"
        Me.Btn_admincancel.Size = New System.Drawing.Size(128, 40)
        Me.Btn_admincancel.TabIndex = 55
        Me.Btn_admincancel.Text = "Cancal"
        Me.Btn_admincancel.UseVisualStyleBackColor = False
        '
        'ad_Lblmsgshow
        '
        Me.ad_Lblmsgshow.AutoSize = True
        Me.ad_Lblmsgshow.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ad_Lblmsgshow.ForeColor = System.Drawing.Color.LavenderBlush
        Me.ad_Lblmsgshow.Location = New System.Drawing.Point(24, 112)
        Me.ad_Lblmsgshow.Name = "ad_Lblmsgshow"
        Me.ad_Lblmsgshow.Size = New System.Drawing.Size(12, 17)
        Me.ad_Lblmsgshow.TabIndex = 54
        Me.ad_Lblmsgshow.Text = "|"
        '
        'Txt_adminpw
        '
        Me.Txt_adminpw.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_adminpw.Location = New System.Drawing.Point(118, 60)
        Me.Txt_adminpw.Name = "Txt_adminpw"
        Me.Txt_adminpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_adminpw.Size = New System.Drawing.Size(280, 26)
        Me.Txt_adminpw.TabIndex = 52
        '
        'Btn_adminlogin
        '
        Me.Btn_adminlogin.BackColor = System.Drawing.Color.Blue
        Me.Btn_adminlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_adminlogin.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.Btn_adminlogin.FlatAppearance.BorderSize = 4
        Me.Btn_adminlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Btn_adminlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_adminlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_adminlogin.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_adminlogin.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Btn_adminlogin.Location = New System.Drawing.Point(24, 152)
        Me.Btn_adminlogin.Margin = New System.Windows.Forms.Padding(6)
        Me.Btn_adminlogin.Name = "Btn_adminlogin"
        Me.Btn_adminlogin.Size = New System.Drawing.Size(128, 40)
        Me.Btn_adminlogin.TabIndex = 50
        Me.Btn_adminlogin.Text = "Login"
        Me.Btn_adminlogin.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(33, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Password"
        '
        'Paneadmin
        '
        Me.Paneadmin.Location = New System.Drawing.Point(24, 56)
        Me.Paneadmin.Name = "Paneadmin"
        Me.Paneadmin.Size = New System.Drawing.Size(378, 35)
        Me.Paneadmin.TabIndex = 53
        '
        'UserLoginBtn
        '
        Me.UserLoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.UserLoginBtn.FlatAppearance.BorderSize = 3
        Me.UserLoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UserLoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.UserLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserLoginBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserLoginBtn.Location = New System.Drawing.Point(280, 144)
        Me.UserLoginBtn.Name = "UserLoginBtn"
        Me.UserLoginBtn.Size = New System.Drawing.Size(208, 40)
        Me.UserLoginBtn.TabIndex = 57
        Me.UserLoginBtn.Text = "User Login"
        Me.UserLoginBtn.UseVisualStyleBackColor = True
        '
        'AdminLoginBtn
        '
        Me.AdminLoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.AdminLoginBtn.FlatAppearance.BorderSize = 3
        Me.AdminLoginBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AdminLoginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.AdminLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminLoginBtn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLoginBtn.Location = New System.Drawing.Point(504, 144)
        Me.AdminLoginBtn.Name = "AdminLoginBtn"
        Me.AdminLoginBtn.Size = New System.Drawing.Size(208, 40)
        Me.AdminLoginBtn.TabIndex = 58
        Me.AdminLoginBtn.Text = "Admin Login"
        Me.AdminLoginBtn.UseVisualStyleBackColor = True
        '
        'User_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(1013, 514)
        Me.Controls.Add(Me.AdminLoginBtn)
        Me.Controls.Add(Me.UserLoginBtn)
        Me.Controls.Add(Me.Panel_admin)
        Me.Controls.Add(Me.PictureLogo)
        Me.Controls.Add(Me.Panel_user)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "User_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Login"
        Me.Panel_user.ResumeLayout(False)
        Me.Panel_user.PerformLayout()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_admin.ResumeLayout(False)
        Me.Panel_admin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtusername As TextBox
    Friend WithEvents lblpassword As Label
    Friend WithEvents lblusername As Label
    Friend WithEvents Panel_user As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureLogo As PictureBox
    Friend WithEvents Btn_login As Button
    Friend WithEvents Paneluser As Panel
    Friend WithEvents Lblmsgshow As Label
    Friend WithEvents Txtpassword As TextBox
    Friend WithEvents Panelpw As Panel
    Friend WithEvents Btncancal As Button
    Friend WithEvents Lbl_userlogin As Label
    Friend WithEvents Panel_admin As Panel
    Friend WithEvents Lbl_adminpanel As Label
    Friend WithEvents Btn_admincancel As Button
    Friend WithEvents ad_Lblmsgshow As Label
    Friend WithEvents Txt_adminpw As TextBox
    Friend WithEvents Btn_adminlogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Paneadmin As Panel
    Friend WithEvents UserLoginBtn As Button
    Friend WithEvents AdminLoginBtn As Button
End Class
