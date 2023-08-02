<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transport_Agent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transport_Agent))
        Me.DtIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtAgentTotal = New System.Windows.Forms.TextBox()
        Me.TxtAgentAdv = New System.Windows.Forms.TextBox()
        Me.TxtATcpk = New System.Windows.Forms.TextBox()
        Me.TxtTtl = New System.Windows.Forms.TextBox()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Btnadd = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnInfo_view = New System.Windows.Forms.Button()
        Me.TxtAgentAllow = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btnrefresh = New System.Windows.Forms.Button()
        Me.Gdv_agent = New System.Windows.Forms.DataGridView()
        Me.DtAgentPD = New System.Windows.Forms.DateTimePicker()
        Me.TxtAPifid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Close_form = New System.Windows.Forms.PictureBox()
        Me.BtnSum = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Gdv_agent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtIssueDate
        '
        Me.DtIssueDate.CustomFormat = "yyyy-MM-dd"
        Me.DtIssueDate.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtIssueDate.Location = New System.Drawing.Point(176, 353)
        Me.DtIssueDate.Margin = New System.Windows.Forms.Padding(2)
        Me.DtIssueDate.Name = "DtIssueDate"
        Me.DtIssueDate.Size = New System.Drawing.Size(159, 25)
        Me.DtIssueDate.TabIndex = 56
        Me.DtIssueDate.Value = New Date(2021, 8, 28, 18, 49, 29, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 317)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 17)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Payment date"
        '
        'TxtAgentTotal
        '
        Me.TxtAgentTotal.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAgentTotal.Location = New System.Drawing.Point(176, 271)
        Me.TxtAgentTotal.Name = "TxtAgentTotal"
        Me.TxtAgentTotal.Size = New System.Drawing.Size(159, 25)
        Me.TxtAgentTotal.TabIndex = 55
        '
        'TxtAgentAdv
        '
        Me.TxtAgentAdv.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAgentAdv.Location = New System.Drawing.Point(144, 17)
        Me.TxtAgentAdv.Name = "TxtAgentAdv"
        Me.TxtAgentAdv.Size = New System.Drawing.Size(159, 25)
        Me.TxtAgentAdv.TabIndex = 54
        '
        'TxtATcpk
        '
        Me.TxtATcpk.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtATcpk.Location = New System.Drawing.Point(176, 134)
        Me.TxtATcpk.Name = "TxtATcpk"
        Me.TxtATcpk.Size = New System.Drawing.Size(160, 25)
        Me.TxtATcpk.TabIndex = 52
        '
        'TxtTtl
        '
        Me.TxtTtl.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTtl.Location = New System.Drawing.Point(176, 92)
        Me.TxtTtl.Name = "TxtTtl"
        Me.TxtTtl.Size = New System.Drawing.Size(160, 25)
        Me.TxtTtl.TabIndex = 51
        '
        'Btndelete
        '
        Me.Btndelete.BackColor = System.Drawing.Color.LightCoral
        Me.Btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btndelete.FlatAppearance.BorderSize = 2
        Me.Btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Btndelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.Btndelete.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndelete.Location = New System.Drawing.Point(216, 520)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(115, 40)
        Me.Btndelete.TabIndex = 43
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
        Me.Btnadd.Location = New System.Drawing.Point(48, 520)
        Me.Btnadd.Name = "Btnadd"
        Me.Btnadd.Size = New System.Drawing.Size(115, 40)
        Me.Btnadd.TabIndex = 42
        Me.Btnadd.Text = "ADD"
        Me.Btnadd.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(122, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Advance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Transport Cost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 17)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Total Tea Leaves (kg)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Partner Info.ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.BtnSum)
        Me.Panel1.Controls.Add(Me.BtnInfo_view)
        Me.Panel1.Controls.Add(Me.Btnrefresh)
        Me.Panel1.Controls.Add(Me.Gdv_agent)
        Me.Panel1.Controls.Add(Me.DtAgentPD)
        Me.Panel1.Controls.Add(Me.TxtAPifid)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.DtIssueDate)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtAgentTotal)
        Me.Panel1.Controls.Add(Me.TxtATcpk)
        Me.Panel1.Controls.Add(Me.TxtTtl)
        Me.Panel1.Controls.Add(Me.Btndelete)
        Me.Panel1.Controls.Add(Me.Btnadd)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(80, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1016, 600)
        Me.Panel1.TabIndex = 53
        '
        'BtnInfo_view
        '
        Me.BtnInfo_view.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnInfo_view.FlatAppearance.BorderSize = 2
        Me.BtnInfo_view.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.BtnInfo_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow
        Me.BtnInfo_view.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.BtnInfo_view.Location = New System.Drawing.Point(360, 48)
        Me.BtnInfo_view.Name = "BtnInfo_view"
        Me.BtnInfo_view.Size = New System.Drawing.Size(208, 32)
        Me.BtnInfo_view.TabIndex = 107
        Me.BtnInfo_view.Text = "Partner Info View"
        Me.BtnInfo_view.UseVisualStyleBackColor = False
        '
        'TxtAgentAllow
        '
        Me.TxtAgentAllow.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAgentAllow.Location = New System.Drawing.Point(144, 24)
        Me.TxtAgentAllow.Name = "TxtAgentAllow"
        Me.TxtAgentAllow.Size = New System.Drawing.Size(160, 25)
        Me.TxtAgentAllow.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Allowances"
        '
        'Btnrefresh
        '
        Me.Btnrefresh.BackColor = System.Drawing.Color.Gainsboro
        Me.Btnrefresh.FlatAppearance.BorderSize = 2
        Me.Btnrefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.Btnrefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow
        Me.Btnrefresh.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.Btnrefresh.Location = New System.Drawing.Point(776, 48)
        Me.Btnrefresh.Name = "Btnrefresh"
        Me.Btnrefresh.Size = New System.Drawing.Size(104, 32)
        Me.Btnrefresh.TabIndex = 65
        Me.Btnrefresh.Text = "Refresh"
        Me.Btnrefresh.UseVisualStyleBackColor = False
        '
        'Gdv_agent
        '
        Me.Gdv_agent.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.Gdv_agent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gdv_agent.Location = New System.Drawing.Point(360, 88)
        Me.Gdv_agent.Name = "Gdv_agent"
        Me.Gdv_agent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Gdv_agent.Size = New System.Drawing.Size(640, 488)
        Me.Gdv_agent.TabIndex = 62
        '
        'DtAgentPD
        '
        Me.DtAgentPD.CustomFormat = "yyyy-MM-dd"
        Me.DtAgentPD.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtAgentPD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtAgentPD.Location = New System.Drawing.Point(176, 312)
        Me.DtAgentPD.Margin = New System.Windows.Forms.Padding(2)
        Me.DtAgentPD.Name = "DtAgentPD"
        Me.DtAgentPD.Size = New System.Drawing.Size(160, 25)
        Me.DtAgentPD.TabIndex = 61
        Me.DtAgentPD.Value = New Date(2021, 8, 28, 18, 49, 29, 0)
        '
        'TxtAPifid
        '
        Me.TxtAPifid.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAPifid.Location = New System.Drawing.Point(176, 50)
        Me.TxtAPifid.Name = "TxtAPifid"
        Me.TxtAPifid.Size = New System.Drawing.Size(160, 25)
        Me.TxtAPifid.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(121, 357)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 17)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Date"
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
        'BtnSum
        '
        Me.BtnSum.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnSum.FlatAppearance.BorderSize = 2
        Me.BtnSum.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.BtnSum.Location = New System.Drawing.Point(144, 392)
        Me.BtnSum.Name = "BtnSum"
        Me.BtnSum.Size = New System.Drawing.Size(192, 48)
        Me.BtnSum.TabIndex = 108
        Me.BtnSum.Text = "Get the Total"
        Me.BtnSum.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtAgentAllow)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 56)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Addition"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtAgentAdv)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(32, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 48)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deduction"
        '
        'Transport_Agent
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
        Me.Name = "Transport_Agent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transport Agent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Gdv_agent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Close_form, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DtIssueDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtAgentTotal As TextBox
    Friend WithEvents TxtAgentAdv As TextBox
    Friend WithEvents TxtATcpk As TextBox
    Friend WithEvents TxtTtl As TextBox
    Friend WithEvents Btndelete As Button
    Friend WithEvents Btnadd As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtAPifid As TextBox
    Friend WithEvents DtAgentPD As DateTimePicker
    Friend WithEvents Gdv_agent As DataGridView
    Friend WithEvents Close_form As PictureBox
    Friend WithEvents Btnrefresh As Button
    Friend WithEvents TxtAgentAllow As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnInfo_view As Button
    Friend WithEvents BtnSum As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
