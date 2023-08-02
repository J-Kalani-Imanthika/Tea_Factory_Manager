<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fertilizer_Issue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fertilizer_Issue))
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timeperiodtxt = New System.Windows.Forms.TextBox()
        Me.totaltxt = New System.Windows.Forms.TextBox()
        Me.amounttxt = New System.Windows.Forms.TextBox()
        Me.pricetxt = New System.Windows.Forms.TextBox()
        Me.partnerinfoidtxt = New System.Windows.Forms.TextBox()
        Me.fertilizeridtxt = New System.Windows.Forms.TextBox()
        Me.fertilizerissueidtxt = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btnrefresh = New System.Windows.Forms.Button()
        Me.Gdv_frtili_issue = New System.Windows.Forms.DataGridView()
        Me.datetxt = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Close_form = New System.Windows.Forms.PictureBox()
        Me.BtnSum = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Gdv_frtili_issue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Deletebtn
        '
        Me.Deletebtn.BackColor = System.Drawing.Color.LightCoral
        Me.Deletebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Deletebtn.FlatAppearance.BorderSize = 2
        Me.Deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Deletebtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deletebtn.Location = New System.Drawing.Point(800, 184)
        Me.Deletebtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(91, 32)
        Me.Deletebtn.TabIndex = 41
        Me.Deletebtn.Text = "Delete"
        Me.Deletebtn.UseVisualStyleBackColor = False
        '
        'Addbtn
        '
        Me.Addbtn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Addbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Addbtn.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addbtn.Location = New System.Drawing.Point(608, 184)
        Me.Addbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(88, 32)
        Me.Addbtn.TabIndex = 40
        Me.Addbtn.Text = "Add"
        Me.Addbtn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(513, 113)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 17)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Time period"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(559, 82)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(539, 51)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 148)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Partner Info ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 117)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Fertilizer ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Fertilizer Issue ID"
        '
        'timeperiodtxt
        '
        Me.timeperiodtxt.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeperiodtxt.ForeColor = System.Drawing.Color.Black
        Me.timeperiodtxt.Location = New System.Drawing.Point(608, 105)
        Me.timeperiodtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.timeperiodtxt.Name = "timeperiodtxt"
        Me.timeperiodtxt.Size = New System.Drawing.Size(280, 25)
        Me.timeperiodtxt.TabIndex = 31
        '
        'totaltxt
        '
        Me.totaltxt.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totaltxt.ForeColor = System.Drawing.Color.Black
        Me.totaltxt.Location = New System.Drawing.Point(608, 74)
        Me.totaltxt.Margin = New System.Windows.Forms.Padding(2)
        Me.totaltxt.Name = "totaltxt"
        Me.totaltxt.Size = New System.Drawing.Size(280, 25)
        Me.totaltxt.TabIndex = 30
        '
        'amounttxt
        '
        Me.amounttxt.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amounttxt.ForeColor = System.Drawing.Color.Black
        Me.amounttxt.Location = New System.Drawing.Point(608, 43)
        Me.amounttxt.Margin = New System.Windows.Forms.Padding(2)
        Me.amounttxt.Name = "amounttxt"
        Me.amounttxt.Size = New System.Drawing.Size(280, 25)
        Me.amounttxt.TabIndex = 28
        '
        'pricetxt
        '
        Me.pricetxt.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricetxt.ForeColor = System.Drawing.Color.Black
        Me.pricetxt.Location = New System.Drawing.Point(149, 138)
        Me.pricetxt.Margin = New System.Windows.Forms.Padding(2)
        Me.pricetxt.Name = "pricetxt"
        Me.pricetxt.Size = New System.Drawing.Size(280, 25)
        Me.pricetxt.TabIndex = 27
        '
        'partnerinfoidtxt
        '
        Me.partnerinfoidtxt.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.partnerinfoidtxt.ForeColor = System.Drawing.Color.Black
        Me.partnerinfoidtxt.Location = New System.Drawing.Point(149, 76)
        Me.partnerinfoidtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.partnerinfoidtxt.Name = "partnerinfoidtxt"
        Me.partnerinfoidtxt.Size = New System.Drawing.Size(280, 25)
        Me.partnerinfoidtxt.TabIndex = 26
        '
        'fertilizeridtxt
        '
        Me.fertilizeridtxt.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fertilizeridtxt.ForeColor = System.Drawing.Color.Black
        Me.fertilizeridtxt.Location = New System.Drawing.Point(149, 107)
        Me.fertilizeridtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.fertilizeridtxt.Name = "fertilizeridtxt"
        Me.fertilizeridtxt.Size = New System.Drawing.Size(280, 25)
        Me.fertilizeridtxt.TabIndex = 25
        '
        'fertilizerissueidtxt
        '
        Me.fertilizerissueidtxt.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fertilizerissueidtxt.ForeColor = System.Drawing.Color.Black
        Me.fertilizerissueidtxt.Location = New System.Drawing.Point(149, 45)
        Me.fertilizerissueidtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.fertilizerissueidtxt.Name = "fertilizerissueidtxt"
        Me.fertilizerissueidtxt.Size = New System.Drawing.Size(280, 25)
        Me.fertilizerissueidtxt.TabIndex = 24
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Controls.Add(Me.Btnrefresh)
        Me.Panel1.Controls.Add(Me.Gdv_frtili_issue)
        Me.Panel1.Controls.Add(Me.datetxt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Deletebtn)
        Me.Panel1.Controls.Add(Me.Addbtn)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.timeperiodtxt)
        Me.Panel1.Controls.Add(Me.totaltxt)
        Me.Panel1.Controls.Add(Me.amounttxt)
        Me.Panel1.Controls.Add(Me.pricetxt)
        Me.Panel1.Controls.Add(Me.partnerinfoidtxt)
        Me.Panel1.Controls.Add(Me.fertilizeridtxt)
        Me.Panel1.Controls.Add(Me.fertilizerissueidtxt)
        Me.Panel1.Location = New System.Drawing.Point(16, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 560)
        Me.Panel1.TabIndex = 42
        '
        'Btnrefresh
        '
        Me.Btnrefresh.BackColor = System.Drawing.Color.Gainsboro
        Me.Btnrefresh.FlatAppearance.BorderSize = 2
        Me.Btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.Btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow
        Me.Btnrefresh.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.Btnrefresh.Location = New System.Drawing.Point(96, 216)
        Me.Btnrefresh.Name = "Btnrefresh"
        Me.Btnrefresh.Size = New System.Drawing.Size(104, 32)
        Me.Btnrefresh.TabIndex = 80
        Me.Btnrefresh.Text = "Refresh"
        Me.Btnrefresh.UseVisualStyleBackColor = False
        '
        'Gdv_frtili_issue
        '
        Me.Gdv_frtili_issue.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Gdv_frtili_issue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gdv_frtili_issue.Location = New System.Drawing.Point(48, 256)
        Me.Gdv_frtili_issue.Name = "Gdv_frtili_issue"
        Me.Gdv_frtili_issue.Size = New System.Drawing.Size(816, 280)
        Me.Gdv_frtili_issue.TabIndex = 79
        '
        'datetxt
        '
        Me.datetxt.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetxt.Location = New System.Drawing.Point(608, 136)
        Me.datetxt.Margin = New System.Windows.Forms.Padding(2)
        Me.datetxt.Name = "datetxt"
        Me.datetxt.Size = New System.Drawing.Size(280, 25)
        Me.datetxt.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(558, 144)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Date"
        '
        'Close_form
        '
        Me.Close_form.Image = CType(resources.GetObject("Close_form.Image"), System.Drawing.Image)
        Me.Close_form.Location = New System.Drawing.Point(1032, 8)
        Me.Close_form.Name = "Close_form"
        Me.Close_form.Size = New System.Drawing.Size(30, 30)
        Me.Close_form.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Close_form.TabIndex = 106
        Me.Close_form.TabStop = False
        '
        'BtnSum
        '
        Me.BtnSum.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnSum.FlatAppearance.BorderSize = 2
        Me.BtnSum.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.BtnSum.Location = New System.Drawing.Point(936, 232)
        Me.BtnSum.Name = "BtnSum"
        Me.BtnSum.Size = New System.Drawing.Size(120, 88)
        Me.BtnSum.TabIndex = 107
        Me.BtnSum.Text = "Send to the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Invoice"
        Me.BtnSum.UseVisualStyleBackColor = False
        '
        'Fertilizer_Issue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(1072, 561)
        Me.Controls.Add(Me.BtnSum)
        Me.Controls.Add(Me.Close_form)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fertilizer_Issue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fertilizer Issue"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Gdv_frtili_issue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Deletebtn As Button
    Friend WithEvents Addbtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents timeperiodtxt As TextBox
    Friend WithEvents totaltxt As TextBox
    Friend WithEvents amounttxt As TextBox
    Friend WithEvents pricetxt As TextBox
    Friend WithEvents partnerinfoidtxt As TextBox
    Friend WithEvents fertilizeridtxt As TextBox
    Friend WithEvents fertilizerissueidtxt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents datetxt As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Close_form As PictureBox
    Friend WithEvents Gdv_frtili_issue As DataGridView
    Friend WithEvents Btnrefresh As Button
    Friend WithEvents BtnSum As Button
End Class
