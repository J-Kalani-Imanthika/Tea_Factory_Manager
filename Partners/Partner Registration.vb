Imports MySql.Data.MySqlClient
Public Class Partner_Registration
    Dim command As New MySqlCommand
    Dim reader1 As MySqlDataReader
    Dim table1 As New DataTable
    Dim result As Boolean
    Dim MsgBoxResult As MsgBoxResult
    Dim sysdates As Date
    Dim str, quary1, insertquary1, fname, mname, lname, gender, male, female, line1, line2, line3, phone, sysdate, email, bank_name, acc_num, branch As String

    ' UPDATE `partner_catagarization` SET `category` = 'supplier', `area` = 'neluwa' WHERE `partner_catagarization`.`pif_id` = 1; 
    Private Sub gdv_part_reg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gdv_part_reg.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = gdv_part_reg.Rows(index)

        Txtfname.Text = selectedRow.Cells(1).Value.ToString()
        Txtmname.Text = selectedRow.Cells(2).Value.ToString()
        Txtlname.Text = selectedRow.Cells(3).Value.ToString()

        Txtline1.Text = selectedRow.Cells(5).Value.ToString()
        Txtline2.Text = selectedRow.Cells(6).Value.ToString()
        Txtline3.Text = selectedRow.Cells(7).Value.ToString()
        Txtp_num.Text = selectedRow.Cells(8).Value.ToString()

        Txtemail.Text = selectedRow.Cells(10).Value.ToString()
        Txtbank_name.Text = selectedRow.Cells(11).Value.ToString()
        Txtacc_num.Text = selectedRow.Cells(12).Value.ToString()
        Txtbranch.Text = selectedRow.Cells(13).Value.ToString()

    End Sub

    Private Sub Btn_delete_Click(sender As Object, e As EventArgs) Handles Btn_delete.Click
        If OpenDb() Then
            ' ================Option 01===============
            For Each row As DataGridViewRow In gdv_part_reg.Rows
                Dim is_check As Boolean = Convert.ToBoolean(row.Cells("checkcolumn").Value)
                If is_check Then
                    str = "DELETE FROM `partner_registration` WHERE `partner_id` = @reg_id "
                    command.CommandText = str
                    command.Connection = conn
                    command.Parameters.AddWithValue("@reg_id", row.Cells("partner_id").Value)
                    result = command.ExecuteNonQuery
                    command.Parameters.Clear()
                    If result Then

                        If MsgBoxResult = MsgBox("Do you want delete ?", vbYesNo + vbQuestion, "Delete Registration Recored") Then

                            If MsgBoxResult = MsgBoxResult.Yes Then
                                'result = command.EndExecuteNonQuery()

                                MsgBox("Delete Recored", vbOKOnly = vbInformation, "Delete Success")
                                command.Parameters.Clear()
                                'Me.Refresh()
                            Else
                                Me.Refresh()
                            End If
                        End If
                    End If
                    Return
                End If
            Next
        Else
            MsgBox("connection error")
            CloseDb()
        End If
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close_form.Click
        Form1.Panel_dashboard.Visible = True
        Form1.Panellist_drop.Visible = False
        Form1.Panellist_down.Visible = True
        Form1.Show()
        Me.Dispose()

    End Sub

    Private Sub Btnrefresh_Click(sender As Object, e As EventArgs) Handles Btnrefresh.Click
        If OpenDb() Then

            str = "SELECT `partner_id`, `f_name`, `m_name`, `l_name`, `gender`, `add_line1`, `add_line2`, `add_line3`, `contact_num`, `date`, `email`, `bank_name`, `acc_num`, `branch` FROM `partner_registration` "
            command.CommandText = str
            command.Connection = conn
            reader1 = command.ExecuteReader
            table1.Load(reader1)

            gdv_part_reg.DataSource = table1
            gdv_part_reg.Update()
            gdv_part_reg.Refresh()

        End If
    End Sub

    Private Sub Btnnext_Click(sender As Object, e As EventArgs) Handles Btnnext.Click
        Me.Hide()
        Partner_Catagarization.Show()
        ' MsgBox("Are you save the data before catagarized? ")
    End Sub

    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        If OpenDb() Then

            fname = Txtfname.Text
            mname = Txtmname.Text
            lname = Txtlname.Text
            gender = If((RadioButton_male.Checked = True), male, female)
            line1 = Txtline1.Text
            line2 = Txtline2.Text
            line3 = Txtline3.Text
            phone = Txtp_num.Text
            sysdates = DateTimePicker1.Value.ToShortDateString
            email = Txtemail.Text
            bank_name = Txtbank_name.Text
            acc_num = Txtacc_num.Text
            branch = Txtbranch.Text

            '==================Validation==============================

            If Isempty(fname) Or Isempty(mname) Or Isempty(phone) Or Isempty(gender) Or Isempty(line1) Or Isempty(line2) Or Isempty(line3) Or Isempty(bank_name) Or Isempty(acc_num) Or Isempty(branch) Then
                MsgBox("One Or More Fields Are Empty", vbExclamation + vbOKOnly, "Required Data")
            ElseIf MinLen(phone, 10) Then
                MsgBox("Phone Number requies at least 10 chars", vbExclamation + vbOKOnly, "Required Data")
                'ElseIf MinLen(phone, 10) Then
                '    If phone.Length < 11 Then
                '        result = True
                '    Else
                '        result = False
                '        MsgBox("phone requies at least 10 Integer", vbExclamation + vbOKOnly, "Required Data")
                '    End If
            Else

                insertquary1 = "INSERT INTO `Partner_registration`( `f_name`, `m_name`, `l_name`, `gender`, `add_line1`, `add_line2`, `add_line3`, `contact_num`, `date`, `email`, `bank_name`, `acc_num`, `branch`) 
                                        VALUES ( @fn, @mn, @ln, @gender, @line1, @line2, @line3, @num, @date, @em, @bname, @accnum, @branch)"
                command.CommandText = insertquary1
                command.Connection = conn

                command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
                command.Parameters.Add("@mn", MySqlDbType.VarChar).Value = mname
                command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
                command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender
                command.Parameters.Add("@line1", MySqlDbType.VarChar).Value = line1
                command.Parameters.Add("@line2", MySqlDbType.VarChar).Value = line2
                command.Parameters.Add("@line3", MySqlDbType.VarChar).Value = line3
                command.Parameters.Add("@num", MySqlDbType.Int32).Value = phone
                command.Parameters.Add("@date", MySqlDbType.Date).Value = sysdate
                command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email
                command.Parameters.Add("@bname", MySqlDbType.VarChar).Value = bank_name
                command.Parameters.Add("@accnum", MySqlDbType.VarChar).Value = acc_num
                command.Parameters.Add("@branch", MySqlDbType.VarChar).Value = branch

                Try
                    result = command.ExecuteNonQuery()
                    If result Then
                        MsgBox("New record added", vbInformation + vbOKOnly, "Add Record")
                    Else
                        MsgBox("Not added", vbExclamation + vbOKOnly, "Error")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, vbExclamation + vbOKOnly, "Error")
                    Return
                End Try
            End If
        Else
            MsgBox("connection error")
            CloseDb()

        End If
    End Sub

    Private Sub Partner_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If OpenDb() Then
            str = "SELECT `partner_id`, `f_name`, `m_name`, `l_name`, `gender`, `add_line1`, `add_line2`, `add_line3`, `contact_num`, `date`, `email`, `bank_name`, `acc_num`, `branch` FROM `partner_registration` "
            command.CommandText = str
            command.Connection = conn
            reader1 = command.ExecuteReader
            table1.Load(reader1)

            '===========DataGrindView============
            gdv_part_reg.DataSource = table1

            gdv_part_reg.AllowUserToAddRows = False
            gdv_part_reg.AllowUserToDeleteRows = False

            With gdv_part_reg
                .Columns(0).HeaderText = "`partner_id`"
                .Columns(1).HeaderText = "`f_name`"
                .Columns(2).HeaderText = "`m_name`"
                .Columns(3).HeaderText = "`l_name`"
                .Columns(4).HeaderText = "`gender`"
                .Columns(5).HeaderText = "`add_line1`"
                .Columns(6).HeaderText = "`add_line2`"
                .Columns(7).HeaderText = "`add_line3`"
                .Columns(8).HeaderText = "`contact_num`"
                .Columns(9).HeaderText = "`date`"
                .Columns(10).HeaderText = "`email`"
                .Columns(11).HeaderText = "`bank_name`"
                .Columns(12).HeaderText = "`acc_num`"
                .Columns(13).HeaderText = "`branch`"

                '.Columns(1).ReadOnly = False
                '.Columns(2).ReadOnly = False
            End With

        End If

    End Sub
End Class