Imports MySql.Data.MySqlClient
Public Class Partner_Catagarization
    Dim command As New MySqlCommand
    Dim quary, regid, category, area As String
    Dim reader, Datareader1, Datareader2, Datareader3 As MySqlDataReader
    Dim table, Tb1, Tb2, Tb3 As New DataTable
    Dim str, Str1, Str2, Str3 As String
    Dim MsgBoxResult As MsgBoxResult
    Dim result As Boolean

    Private Sub Close_form_Click(sender As Object, e As EventArgs) Handles Close_form.Click
        Form1.Panel_dashboard.Visible = True
        Form1.Panellist_drop.Visible = False
        Form1.Panellist_down.Visible = True
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub Btnrefresh_Click(sender As Object, e As EventArgs) Handles Btnrefresh.Click
        If OpenDb() Then

            str = "SELECT `pif_id`, `reg_partner_id`, `category`, `area` FROM `partner_catagarization`  LIMITE1"
            command.CommandText = str
            command.Connection = conn

            reader = command.ExecuteReader
            table.Load(reader)
            gdv_part_info.DataSource = table
            gdv_part_info.Update()
            gdv_part_info.Refresh()

            result = command.ExecuteNonQuery()
            command.Parameters.Clear()

        End If
    End Sub

    Private Sub Partner_Catagarization_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '===========ComboBox============

        If OpenDb() Then
            Str1 = "SELECT`Category_ID`,`Category` FROM `Category`"
            command.CommandText = Str1
            command.Connection = conn
            Datareader1 = command.ExecuteReader
            Tb1.Load(Datareader1)

            combo_cateid.DataSource = Tb1
            combo_cateid.DisplayMember = "Categoty"
            combo_cateid.ValueMember = "Category_id"

            Str2 = "SELECT`area_ID`,`area_name` FROM `Area`"
            command.CommandText = Str2
            command.Connection = conn
            Datareader2 = command.ExecuteReader
            Tb2.Load(Datareader2)

            Combo_areaid.DataSource = Tb2
            Combo_areaid.DisplayMember = "area_name"
            Combo_areaid.ValueMember = "area_id"

            '==========================DataGridView=================================
            Str3 = "SELECT `pif_id`, `reg_partner_id`, `category`, `area` FROM `partner_catagarization` "
            command.CommandText = Str3
            command.Connection = conn
            Datareader3 = command.ExecuteReader
            Tb3.Load(Datareader3)
            gdv_part_info.DataSource = Tb3

            Dim checkboxcolum As New DataGridViewCheckBoxColumn
            checkboxcolum.HeaderText = "selete"
            checkboxcolum.Width = 50
            checkboxcolum.Name = "checkcolumn"
            gdv_part_info.Columns.Insert(0, checkboxcolum)

        End If
    End Sub

    Private Sub Btn_register_Click(sender As Object, e As EventArgs) Handles Btn_register.Click
        If OpenDb() Then
            '==================Validation==============================

            If Isempty(regid) Or Isempty(category) Or Isempty(area) Then

                MsgBox("One Or More Fields Are Empty", vbExclamation + vbOKOnly, "Required Data")
            Else
                quary = "INSERT INTO `partner_catagarization`( `reg_partner_id`, `category`, `area` ) VALUES ( @regid, @cate, @aid)"

                command.CommandText = quary
                command.Connection = conn

                txtpartner_regid.Text = regid
                combo_cateid.Text = category
                Combo_areaid.Text = area

                command.Parameters.Add("@regid", MySqlDbType.Int32).Value = regid
                command.Parameters.Add("@cate", MySqlDbType.VarChar).Value = category
                command.Parameters.Add("@aid", MySqlDbType.VarChar).Value = area

                Try
                    result = command.ExecuteNonQuery()
                    If result = True Then
                        MsgBox("New record added", vbInformation + vbOKOnly, "Add User")
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


    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        If OpenDb() Then
            ' ================Option 01===============
            For Each row As DataGridViewRow In gdv_part_info.Rows
                Dim is_check As Boolean = Convert.ToBoolean(row.Cells("checkcolumn").Value)
                If is_check Then
                    'SELECT `pif_id`, `reg_partner_id`, `category`, `area` FROM `partner_catagarization`
                    str = "DELETE FROM `partner_catagarization` WHERE pif_id = @pif_id "
                    command.CommandText = str
                    command.Connection = conn
                    command.Parameters.AddWithValue("pif_id", row.Cells("pif_id").Value)
                    result = command.ExecuteNonQuery
                    command.Parameters.Clear()
                    If result Then

                        If MsgBoxResult = MsgBox("Do you want delete ?", vbYesNo + vbQuestion, "Delete Recored") Then

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
End Class