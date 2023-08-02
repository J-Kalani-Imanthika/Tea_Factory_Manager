Imports MySql.Data.MySqlClient
Public Class Advance_Money
    Dim MsgBoxResult As MsgBoxResult
    Dim command As New MySqlCommand
    Dim datareader As MySqlDataReader
    Dim table As New DataTable
    Dim result As Boolean
    Dim pif_id, amount, str As String
    Dim pay_date, sysdates As Date

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenDb() Then
            Dim counter As Integer = 0
            str = "SELECT `adv_id`, `pif_id`, `amount`, `payment_date`, `date` FROM `advance_money` LIMITE1"
            command.CommandText = str
            command.Connection = conn

            datareader = command.ExecuteReader
            table.Load(datareader)
            Gdv_advance.DataSource = table
            Gdv_advance.Update()
            Gdv_advance.Refresh()

            result = command.ExecuteNonQuery()
            command.Parameters.Clear()
            If result Then
                counter += 1
            End If
        End If
    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        If OpenDb() Then
            ' ================Option 01===============
            For Each row As DataGridViewRow In Gdv_advance.Rows
                Dim is_check As Boolean = Convert.ToBoolean(row.Cells("checkcolumn").Value)
                If is_check Then
                    str = "DELETE FROM `advance_money` WHERE adv_id = @a_id "
                    command.CommandText = str
                    command.Connection = conn
                    command.Parameters.AddWithValue("@a_id", row.Cells("adv_id").Value)
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

    Private Sub BtnInfo_view_Click(sender As Object, e As EventArgs) Handles BtnInfo_view.Click
        Partners_Info_View.Show()
    End Sub

    Private Sub Close_form_Click(sender As Object, e As EventArgs) Handles Close_form.Click
        Form1.Panel_dashboard.Visible = True
        Form1.Panellist_drop.Visible = False
        Form1.Panellist_down.Visible = True
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub Advance_Money_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpenDb() Then
            '==========================DataGridView=================================
            str = "SELECT `adv_id`, `pif_id`, `amount`, `payment_date`, `date` FROM `advance_money`"
            command.CommandText = str
            command.Connection = conn
            datareader = command.ExecuteReader
            table.Load(datareader)

            Gdv_advance.DataSource = table
            Gdv_advance.AllowUserToAddRows = False
            Gdv_advance.AllowUserToAddRows = False

            Dim checkboxcolum As New DataGridViewCheckBoxColumn
            checkboxcolum.HeaderText = "selete"
            checkboxcolum.Width = 50
            checkboxcolum.Name = "checkcolumn"
            Gdv_advance.Columns.Insert(0, checkboxcolum)
        End If
    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        If OpenDb() Then
            pif_id = TxtPifid.Text
            amount = Txtamount.Text
            pay_date = DateTimePicker2.Value.ToShortDateString
            sysdates = DateTimePicker2.Value.ToShortDateString
            If Isempty(pif_id) Or Isempty(amount) Or Isempty(pay_date) Or Isempty(sysdates) Then
                MsgBox(" All Fields Are Empty", vbExclamation + vbOKOnly, "Required Data")
            Else
                str = "INSERT INTO `advance_money`(`pif_id`, `amount`, `payment_date`, `date`) VALUES ( @pif, @amo, @pdt, @isdt)"

            Dim command As New MySqlCommand(str, conn)
            command.Parameters.Add("@pif", MySqlDbType.Int32).Value = pif_id
            command.Parameters.Add("amo", MySqlDbType.VarChar).Value = amount
            command.Parameters.Add("@pdt", MySqlDbType.Date).Value = pay_date
            command.Parameters.Add("@isdt", MySqlDbType.Date).Value = sysdates
                Try
                    result = command.ExecuteNonQuery()
                    If result Then
                        MsgBox("Enter Data")
                    Else
                        MsgBox("Do not Enter Data")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Return
                End Try
            End If
        Else
            MsgBox("Connection Error")
            command.Parameters.Clear()
        End If
    End Sub
End Class