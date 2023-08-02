Imports MySql.Data.MySqlClient
Public Class Supplier_Invoice
    Dim command As New MySqlCommand
    Dim datareader As MySqlDataReader
    Dim table As New DataTable
    Dim result As Boolean
    Dim str As String
    Dim sum As Integer = 0
    Dim i As Integer = 0

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click
        If OpenDb() Then
            For Each row As DataGridViewRow In Gdv_sup_invo.Rows
                Dim was_check As Boolean = Convert.ToBoolean(row.Cells("checkcolumn").Value)
                If was_check Then
                    str = "DELETE FROM `supplier_invoice` WHERE s_id = @si"
                    command.CommandText = str
                    command.Connection = conn
                    command.Parameters.AddWithValue("@si", row.Cells("s_id").Value)
                    result = command.ExecuteNonQuery
                    command.Parameters.Clear()
                    If result Then
                        MsgBox("Done Delete")
                    End If
                End If
            Next
        End If
        command.Parameters.Clear()

    End Sub


    Private Sub Supplier_Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpenDb() Then
            Dim quary As String
            quary = "SELECT `s_id`, `pif_id`, `total_quantity`, `rate`, `total_mount`, `allowences`, `advance`, `fertilizer`, `trans_cost`, `net_amount`, `payment_date`, `date` FROM `supplier_invoice` "
            command.CommandText = quary
            command.Connection = conn
            datareader = command.ExecuteReader
            table.Load(datareader)

            Gdv_sup_invo.DataSource =
            Gdv_sup_invo.AllowUserToAddRows = False
            Gdv_sup_invo.AllowUserToAddRows = False

            Dim checkboxcolumn As New DataGridViewCheckBoxColumn
            checkboxcolumn.HeaderText = "SELECT"
            checkboxcolumn.Name = "checkboxcolumn"
            checkboxcolumn.Width = 70
            Gdv_sup_invo.Columns.Insert(0, checkboxcolumn)


            'Dim column As Decimal

            'For Each rw As DataGridViewRow In Tea_Collection.Gdv_teacollect.Rows
            '    column += rw.Cells(5).Value
            '    'Columns(5)
            'Next

            'Try

            '    TxtTQ.Text = column
            'Catch ex As Exception

            'End Try
        End If

    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        If OpenDb() Then
            Dim pif_id, t_q, rat, total_amo, s_allo, s_adv, s_fer, trans_co, net_amo As String
            Dim dates, sysdate As Date

            's_id = TxtSupInvoNum.Text
            pif_id = TxtSupPifid.Text
            t_q = TxtTQ.Text
            rat = TxtMR.Text
            total_amo = TxtTA.Text
            s_allo = TxtSupAllow.Text
            s_adv = TxtSupAdv.Text
            s_fer = TxtSupFer.Text
            trans_co = TxtTCPK.Text
            net_amo = TxtTotal.Text
            dates = DtSupPd.Value.ToShortDateString
            sysdate = DtSupIsD.Value.ToShortDateString
            If Isempty(pif_id) Or Isempty(t_q) Or Isempty(rat) Or Isempty(total_amo) Or Isempty(s_allo) Or Isempty(s_adv) Or Isempty(s_fer) Or Isempty(trans_co) Or Isempty(net_amo) Then
                MsgBox(" All Fields Are Empty", vbExclamation + vbOKOnly, "Required Data")
            Else

                str = "INSERT INTO 'supplier_invoice'('s_id', 'pif_id', 'total_quantity', 'rate', 'total_amount', 'allowances', 'advance', 'fertilizer', 'trans_cost','net_amount', 'payment_date', 'date')
VALUES (@si, @pifid, @tq, @rat, @tamo, @sallo, @sadv, @sfer, @transcos, @netamo,@spdt, @sisdt)"

                Dim command As New MySqlCommand(str, conn)

                'command.Parameters.Add("@si", MySqlDbType.Int32).Value = s_id
                command.Parameters.Add("@pifid", MySqlDbType.VarChar).Value = pif_id
                command.Parameters.Add("@tq", MySqlDbType.VarChar).Value = t_q
                command.Parameters.Add("@rat", MySqlDbType.VarChar).Value = rat
                command.Parameters.Add("@tamo", MySqlDbType.VarChar).Value = total_amo
                command.Parameters.Add("@sallo", MySqlDbType.VarChar).Value = s_allo
                command.Parameters.Add("@sadv", MySqlDbType.VarChar).Value = s_adv
                command.Parameters.Add("@sfer", MySqlDbType.VarChar).Value = s_fer
                command.Parameters.Add("@transcos", MySqlDbType.VarChar).Value = trans_co
                command.Parameters.Add("@netamo", MySqlDbType.VarChar).Value = net_amo
                command.Parameters.Add("@spdt", MySqlDbType.VarChar).Value = dates
                command.Parameters.Add("@sisdt", MySqlDbType.VarChar).Value = sysdate
                Try

                    command.ExecuteNonQuery()

                    If result = True Then

                        MsgBox("Enter Data")
                    Else
                        MsgBox("Do not Enter Data")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, vbExclamation + vbOKOnly, "Error")
                    Return
                End Try
            End If
        Else
            MsgBox("Connection Error")
        End If
        command.Parameters.Clear()
    End Sub

    Private Sub Close_form_Click(sender As Object, e As EventArgs) Handles Close_form.Click
        Form1.Panel_dashboard.Visible = True
        Form1.Panellist_drop.Visible = False
        Form1.Panellist_down.Visible = True
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub Btnrefresh_Click(sender As Object, e As EventArgs) Handles Btnrefresh.Click
        If OpenDb() Then
            Dim counter As Integer = 0
            str = "SELECT `s_id`, `pif_id`, `total_quantity`, `rate`, `total_mount`, `allowences`, `advance`, `fertilizer`, `trans_cost`, `net_amount`, `payment_date`, `date` FROM `supplier_invoice` LIMITE1"
            command.CommandText = str
            command.Connection = conn

            datareader = command.ExecuteReader
            table.Load(datareader)
            Gdv_sup_invo.DataSource = table
            Gdv_sup_invo.Update()
            Gdv_sup_invo.Refresh()

            result = command.ExecuteNonQuery()
            command.Parameters.Clear()
            If result Then
                counter += 1
            End If
        End If
    End Sub

    Private Sub BtnSum_Click_1(sender As Object, e As EventArgs) Handles BtnSum.Click
        Dim Deduction, Addition As String
        ' Dim result As String
        Dim n1, n2, n3, n4, n5, n6, n7, n8 As Double

        n1 = Convert.ToDouble(TxtSupAdv.Text)
        n2 = Convert.ToDouble(TxtSupFer.Text)
        n3 = Convert.ToDouble(TxtTCPK.Text)
        n4 = Convert.ToDouble(TxtTA.Text)
        n5 = Convert.ToDouble(TxtSupAllow.Text)
        n6 = Convert.ToDouble(TxtTQ.Text)
        n7 = Convert.ToDouble(TxtMR.Text)
        'n8 = Convert.ToDouble(TxtTotal.Text)
        Deduction = n1 + n2 + n3
        Addition = n4 + n5
        n4 = n6 + n7
        TxtTotal.Text = Addition - Deduction

        'TxtTotal.Text = Val(TxtTA.Text) + Val(TxtSupAllow.Text)
        'If TxtTA.Text = ((TxtTQ.Text) * (TxtMR.Text)).ToString Then

        '    TxtTotal = ((TxtTA.Text) + (TxtSupAllow.Text)).ToString
        '    Deduction = ((TxtSupAdv.Text) + (TxtSupFer.Text) + (TxtTCPK.Text)).ToString
        '    MsgBox(Addition)
        '    MsgBox(Deduction)
        '    ' TxtTotal = ((Addition.GetType) - Deduction).ToString
        'End If
    End Sub

    Private Sub BtnInfo_view_Click(sender As Object, e As EventArgs) Handles BtnInfo_view.Click
        Partners_Info_View.Show()
    End Sub
End Class