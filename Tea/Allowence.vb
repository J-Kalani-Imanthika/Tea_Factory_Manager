Imports MySql.Data.MySqlClient
Public Class Allowence
    Dim MsgBoxResult As MsgBoxResult
    Dim command As New MySqlCommand
    Dim table As New DataTable
    Dim reader As MySqlDataReader
    Dim ast, pifid, allo_name, amount, query As String
    Dim dates As Date
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
            Dim counter As Integer = 0
            ast = "SELECT `alowence_id`, `pif_id`, `allowence_name`, `amount`, `issue_date` FROM `allowence`LIMITE1"
            command.CommandText = ast
            command.Connection = conn

            reader = command.ExecuteReader
            table.Load(reader)
            Gdv_allow.DataSource = table
            Gdv_allow.Update()
            Gdv_allow.Refresh()

            result = command.ExecuteNonQuery()
            command.Parameters.Clear()
            If result Then
                counter += 1
            End If
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If OpenDb() Then
            ' ================Option 01===============
            For Each row As DataGridViewRow In Gdv_allow.Rows
                Dim is_check As Boolean = Convert.ToBoolean(row.Cells("checkcolumn").Value)
                If is_check Then
                    ast = "DELETE FROM `allowence` WHERE alowence_id = @ai "
                    command.CommandText = ast
                    command.Connection = conn
                    command.Parameters.AddWithValue("@ai", row.Cells("alowence_id").Value)
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

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        If OpenDb() Then

            pifid = partnerinfoidtxt.Text
            allo_name = txtallowence.Text
            amount = amounttxt.Text
            dates = datetxt.Value.ToShortDateString
            If Isempty(pifid) Or Isempty(amount) Or Isempty(allo_name) Or Isempty(dates) Then
                MsgBox(" All Fields Are Empty", vbExclamation + vbOKOnly, "Required Data")
            Else
                query = "INSERT INTO `allowence`(`pif_id`, `allowence_name`, `amount`, `issue_date`) VALUES ( @id, @allo, @am, @dt)"
                Dim command As New MySqlCommand(query, conn)

                command.Parameters.Add("@id", MySqlDbType.VarChar).Value = pifid
                command.Parameters.Add("@allo", MySqlDbType.VarChar).Value = allo_name
                command.Parameters.Add("@am", MySqlDbType.VarChar).Value = amount
                command.Parameters.Add("@D", MySqlDbType.Date).Value = dates
                Try
                    result = command.ExecuteNonQuery()
                    If result = True Then
                        MsgBox("enter the data")
                    Else
                        MsgBox("not enter the data")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Return
                End Try
                command.Parameters.Clear()
            End If
        Else
            MsgBox("connection error")
        End If

    End Sub

    Private Sub Allowence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpenDb() Then
            '==========================DataGridView=================================
            query = "SELECT `alowence_id`, `pif_id`, `allowence_name`, `amount`, `issue_date` FROM `allowence` `"
            command.CommandText = query
            command.Connection = conn
            reader = command.ExecuteReader
            table.Load(reader)

            Gdv_allow.DataSource = table
            Gdv_allow.AllowUserToAddRows = False
            Gdv_allow.AllowUserToAddRows = False

            Dim checkboxcolum As New DataGridViewCheckBoxColumn
            checkboxcolum.HeaderText = "selete"
            checkboxcolum.Width = 50
            checkboxcolum.Name = "checkcolumn"
            Gdv_allow.Columns.Insert(0, checkboxcolum)

            With Gdv_allow
                .Columns(1).HeaderText = "`alowence_id`"
                .Columns(2).HeaderText = "`pif_id`"
                .Columns(3).HeaderText = "`allowence_name`"
                .Columns(4).HeaderText = "`amount`"
                .Columns(5).HeaderText = "`issue_date`"
                .Columns(1).Visible = False

                .Columns(1).ReadOnly = True
                .Columns(2).ReadOnly = True
                .Columns(3).ReadOnly = True
                .Columns(4).ReadOnly = True
                .Columns(5).ReadOnly = True
            End With
            reader.Close()
        End If
    End Sub
End Class