Imports MySql.Data.MySqlClient
Public Class Transport_Agent
    Dim command As New MySqlCommand
    Dim datareader As MySqlDataReader
    Dim table As New DataTable
    Dim result As Boolean
    Dim str As String

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles Btnadd.Click
        If OpenDb() Then
            Dim pif_id, t_q, tran_co, a_allo, a_adv, net_amo As String
            Dim dates, sysdate As Date
            'Dim a, b, c, d, g As String

            pif_id = TxtAPifid.Text
            t_q = TxtTtl.Text
            tran_co = TxtATcpk.Text
            a_allo = TxtAgentAllow.Text
            a_adv = TxtAgentAdv.Text
            net_amo = TxtAgentTotal.Text
            dates = DtAgentPD.Value.ToShortDateString
            sysdate = DtIssueDate.Value.ToShortDateString

            If Isempty(pif_id) Or Isempty(t_q) Or Isempty(tran_co) Or Isempty(a_allo) Or Isempty(a_adv) Or Isempty(net_amo) Or Isempty(dates) Or Isempty(sysdate) Then
                MsgBox(" All Fields Are Empty", vbExclamation + vbOKOnly, "Required Data")
            Else
                str = "INSERT INTO `agent_invoice`(`a_id`, `pif_id`, `total_qta`, `tran_cost`, `allowances`, `advances`, `total`, `payment_date`, `date`) VALUES (@ai, @apifid, @ttlqta, @trcos, @agentallo, @agentadv, @anetamo, @apdt, @aisdt)"
                Dim command As New MySqlCommand(str, conn)

                'command.Parameters.Add("@ai", MySqlDbType.Int32).Value = a_id
                command.Parameters.Add("@apifid", MySqlDbType.Int32).Value = pif_id
                command.Parameters.Add("@ttlqta", MySqlDbType.Int32).Value = t_q
                command.Parameters.Add("@trcos", MySqlDbType.Int32).Value = tran_co
                command.Parameters.Add("@agentallo", MySqlDbType.Int32).Value = a_allo
                command.Parameters.Add("@agentadv", MySqlDbType.Int32).Value = a_adv
                command.Parameters.Add("@anetamo", MySqlDbType.Int32).Value = net_amo
                command.Parameters.Add("@apdt", MySqlDbType.Date).Value = dates
                command.Parameters.Add("@aisdt", MySqlDbType.Date).Value = sysdate

                Try
                    result = command.ExecuteNonQuery()
                    If result = True Then
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

    Private Sub Transport_Agent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpenDb() Then
            '==========================DataGridView=================================
            Dim quary As String
            quary = "SELECT `a_id`, `pif_id`, `total_qta`, `tran_cost`, `allowances`, `advances`, `total`, `payment_date`, `date` FROM `agent_invoice` "
            command.CommandText = quary
            command.Connection = conn
            datareader = command.ExecuteReader
            table.Load(datareader)

            Gdv_agent.DataSource =
            Gdv_agent.AllowUserToAddRows = False
            Gdv_agent.AllowUserToAddRows = False

            Dim checkboxcolumn As New DataGridViewCheckBoxColumn
            checkboxcolumn.HeaderText = "SELECT"
            checkboxcolumn.Name = "checkboxcolumn"
            checkboxcolumn.Width = 70
            Gdv_agent.Columns.Insert(0, checkboxcolumn)

        End If
    End Sub

    Private Sub Btnrefresh_Click(sender As Object, e As EventArgs) Handles Btnrefresh.Click
        If OpenDb() Then

            str = "SELECT `a_id`, `pif_id`, `total_qta`, `tran_cost`, `allowances`, `advances`, `total`, `payment_date`, `date` FROM `agent_invoice`  LIMITE1"
            command.CommandText = str
            command.Connection = conn

            datareader = command.ExecuteReader
            table.Load(datareader)
            Gdv_agent.DataSource = table
            Gdv_agent.Update()
            Gdv_agent.Refresh()

            result = command.ExecuteNonQuery()
            command.Parameters.Clear()

        End If
    End Sub

    Private Sub BtnInfo_view_Click(sender As Object, e As EventArgs) Handles BtnInfo_view.Click
        Partners_Info_View.Show()
    End Sub

    Private Sub BtnSum_Click(sender As Object, e As EventArgs) Handles BtnSum.Click
        Dim n1, n2, n3 As Double
        Dim Addition As String
        n1 = Convert.ToDouble(TxtATcpk.Text)
        n2 = Convert.ToDouble(TxtAgentAllow.Text)
        n3 = Convert.ToDouble(TxtAgentAdv.Text)
        Addition = n1 + n2
        TxtAgentTotal.Text = Addition - n3
    End Sub
End Class