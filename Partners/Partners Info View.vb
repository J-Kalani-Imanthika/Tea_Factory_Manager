Imports MySql.Data.MySqlClient
Public Class Partners_Info_View
    Dim command As New MySqlCommand
    Dim str, quary, fname, mname, lname, email, phone, nic, job, user, pass, sysdate As String
    Dim MsgBoxResult As MsgBoxResult
    Dim result As Boolean

    Private Sub Partners_Info_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpenDb() Then
            Dim quary1 As String
            Dim reader As MySqlDataReader
            Dim table As New DataTable
            '==========================DataGridView=================================

            quary1 = "SELECT partner_catagarization.pif_id, partner_catagarization.reg_partner_id, partner_catagarization.category, partner_catagarization.area,partner_registration.partner_id,partner_registration.f_name,partner_registration.m_name,partner_registration.l_name,partner_registration.contact_num,partner_registration.email FROM partner_catagarization INNER JOIN partner_registration ON partner_registration.partner_id = partner_catagarization.pif_id"
            command.CommandText = quary1
            command.Connection = conn
            reader = command.ExecuteReader
            table.Load(reader)

            Gdv_all_partner_info.DataSource = table
            Gdv_all_partner_info.AllowUserToAddRows = False
            Gdv_all_partner_info.AllowUserToDeleteRows = False

            Dim checkboxcolumn As New DataGridViewCheckBoxColumn
            checkboxcolumn.HeaderText = "SELECT"
            checkboxcolumn.Name = "checkboxcolumn"
            checkboxcolumn.Width = 70
            Gdv_all_partner_info.Columns.Insert(0, checkboxcolumn)

            'With Gdv_all_partner_info
            '    .Columns(1).HeaderText = "`user_id`"
            '    .Columns(2).HeaderText = "`f_name`"
            '    .Columns(3).HeaderText = "`m_name`"
            '    .Columns(4).HeaderText = "`l_name`"
            '    .Columns(5).HeaderText = "`email`"
            '    .Columns(6).HeaderText = "`phone_num`"
            '    .Columns(7).HeaderText = "`nic_num`"
            '    .Columns(8).HeaderText = "`job_role`"
            '    .Columns(9).HeaderText = "`user_name`"
            '    .Columns(10).HeaderText = "`password`"
            '    .Columns(11).HeaderText = "`date`"
            '    .Columns(1).Visible = False

            '    .Columns(1).ReadOnly = True
            '    .Columns(2).ReadOnly = True
            '    .Columns(3).ReadOnly = True
            '    .Columns(4).ReadOnly = True
            '    .Columns(5).ReadOnly = True
            '    .Columns(6).ReadOnly = True
            '    .Columns(7).ReadOnly = True
            '    .Columns(8).ReadOnly = True
            '    .Columns(9).ReadOnly = True
            '    .Columns(10).ReadOnly = True
            '    .Columns(11).ReadOnly = True
            'End With
            reader.Close()
        End If
    End Sub

    'Private Sub Btnselect_Click(sender As Object, e As EventArgs) Handles Btnselect.Click
    '    If OpenDb() Then

    '        Dim counter As Integer = 0
    '        For Each row As DataGridViewRow In Gdv_all_partner_info.Rows

    '            Dim is_check As Boolean = Convert.ToBoolean(row.Cells("checkboxcolumn").Value)
    '            If is_check Then
    '                str = "INSERT INTO `user`( `f_name`, `m_name`, `l_name`, `email`, `phone_num`, `nic_num`, `job_role`, `user_name`, `password`, `date`) 
    '        VALUES ( @fn, @mn, @ln, @em, @num, @nic, @job, @us, @pw, @dt)"
    '                '"DELETE FROM `user` WHERE `user`.`user_id` = 11"?

    '                command.CommandText = str
    '                command.Connection = conn
    '                'command.Parameters.AddWithValue("`user_id`", row.Cells("`user_id`").Value)
    '                command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
    '                command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname
    '                command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
    '                command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email
    '                command.Parameters.Add("@num", MySqlDbType.Int32).Value = phone
    '                command.Parameters.Add("@nic", MySqlDbType.VarChar).Value = nic
    '                command.Parameters.Add("@job", MySqlDbType.VarChar).Value = job
    '                command.Parameters.Add("@us", MySqlDbType.VarChar).Value = user
    '                command.Parameters.Add("@pw", MySqlDbType.VarChar).Value = pass
    '                command.Parameters.Add("@dt", MySqlDbType.VarChar).Value = sysdate

    '                result = command.ExecuteNonQuery()
    '                command.Parameters.Clear()
    '                If result Then
    '                    counter += 1
    '                End If
    '            End If
    '        Next

    '    End If
    'End Sub

    'Private Sub Btnselect_Click(sender As Object, e As EventArgs) Handles Btnselect.Click
    '    str = " SELECT "
    'End Sub

End Class