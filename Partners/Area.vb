Imports MySql.Data.MySqlClient
Public Class Area
    Dim Command As New MySqlCommand
    Dim str, quary1, insertstr1, deletestr1 As String
    Dim reader1 As MySqlDataReader
    Dim table1 As New DataTable
    Dim result As Boolean
    Dim MsgBoxResult As MsgBoxResult

    Private Sub Btnrefresh_Click(sender As Object, e As EventArgs) Handles Btnrefresh.Click
        If OpenDb() Then
            Dim counter As Integer = 0
            str = "SELECT`area_ID`,`area_name` FROM `Area` LIMITE1"
            Command.CommandText = str
            Command.Connection = conn

            reader1 = Command.ExecuteReader
            table1.Load(reader1)
            Gdv_area.DataSource = table1
            Gdv_area.Update()
            Gdv_area.Refresh()

            result = Command.ExecuteNonQuery()
            Command.Parameters.Clear()
            If result Then
                counter += 1
            End If
        End If
    End Sub

    Private Sub Close_form_Click(sender As Object, e As EventArgs) Handles Close_form.Click
        Form1.Panel_dashboard.Visible = True
        Form1.Panellist_drop.Visible = False
        Form1.Panellist_down.Visible = True
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub Area_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpenDb() Then
            '=============Gring View===============
            quary1 = "SELECT`area_ID`,`area_name` FROM `Area`"

            Command.CommandText = quary1
            Command.Connection = conn
            reader1 = Command.ExecuteReader
            table1.Load(reader1)
            Gdv_area.DataSource = table1
            Gdv_area.AllowUserToAddRows = False
            Gdv_area.AllowUserToAddRows = False

            Dim checkboxcolum As New DataGridViewCheckBoxColumn
            checkboxcolum.HeaderText = "selete"
            checkboxcolum.Width = 50
            checkboxcolum.Name = "checkcolumn"
            Gdv_area.Columns.Insert(0, checkboxcolum)

            With Gdv_area
                .Columns(0).HeaderText = "`area_ID`"
                .Columns(1).HeaderText = "`area_name``"
                .Columns(0).Visible = True
            End With
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If OpenDb() Then
            insertstr1 = "INSERT INTO `area`(`area_name`) VALUES (@area)"

            Command.CommandText = insertstr1
            Command.Connection = conn

            Dim area_nm As String = txtarea_name.Text

            Command.Parameters.Add("@area", MySqlDbType.VarChar).Value = area_nm

            Try
                result = Command.ExecuteNonQuery()
                If result Then
                    MsgBox("New record added", vbInformation + vbOKOnly, "Add Record")
                Else
                    MsgBox("Not added", vbExclamation + vbOKOnly, "Error")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbExclamation + vbOKOnly, "Error")
                Return
            End Try
        Else
            MsgBox("connection error")
            CloseDb()

        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        If OpenDb() Then
            For Each row As DataGridViewRow In Gdv_area.Rows
                Dim is_check As Boolean = Convert.ToBoolean(row.Cells("checkcolumn").Value)
                If is_check Then
                    str = "DELETE FROM `area` WHERE `area_id` = @aid "
                    Command.CommandText = str
                    Command.Connection = conn
                    Command.Parameters.AddWithValue("@aid", row.Cells("area_id").Value)
                    result = Command.ExecuteNonQuery
                    Command.Parameters.Clear()
                    If result Then

                        If MsgBoxResult = MsgBox("Do you want delete ?", vbYesNo + vbQuestion, "Delete User") Then

                            If MsgBoxResult = MsgBoxResult.Yes Then
                                'result = command.EndExecuteNonQuery()

                                MsgBox("Delete User", vbOKOnly = vbInformation, "Delete Success")
                                Command.Parameters.Clear()
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