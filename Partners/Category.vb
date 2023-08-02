Imports MySql.Data.MySqlClient
Public Class Category
    Dim Command As New MySqlCommand
    Dim str, quary1, insertstr1, deletestr1 As String
    Dim reader1 As MySqlDataReader
    Dim table1 As New DataTable
    Dim result As Boolean
    Dim MsgBoxResult As MsgBoxResult

    Private Sub cleardata()
        txtcategory.Text = ""

    End Sub

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OpenDb() Then
            '=============Gring View===============
            quary1 = "SELECT `category_id`, `category` FROM `category`"

            Command.CommandText = quary1
            Command.Connection = conn
            reader1 = Command.ExecuteReader
            table1.Load(reader1)
            Gdv_category.DataSource = table1
            Gdv_category.AllowUserToAddRows = False
            Gdv_category.AllowUserToAddRows = False

            Dim checkboxcolum As New DataGridViewCheckBoxColumn
            checkboxcolum.HeaderText = "selete"
            checkboxcolum.Width = 50
            checkboxcolum.Name = "checkcolumn"
            Gdv_category.Columns.Insert(0, checkboxcolum)

            With Gdv_category
                    .Columns(0).HeaderText = "`Category_ID`"
                    .Columns(1).HeaderText = "`Category`"
                .Columns(0).Visible = True
            End With



        End If
    End Sub

    Private Sub Btnrefresh_Click(sender As Object, e As EventArgs) Handles Btnrefresh.Click
        If OpenDb() Then
            ' Dim counter As Integer = 0
            ' quary1 = "SELECT `category_id`, `category` FROM `category`"
            quary1 = "SELECT * FROM `category`"

            Command.CommandText = quary1
            Command.Connection = conn

            reader1 = Command.ExecuteReader
            table1.Load(reader1)
            Gdv_category.DataSource = table1
            Gdv_category.Update()
            Gdv_category.Refresh()

            result = Command.ExecuteNonQuery()
            Command.Parameters.Clear()
            'If result Then
            '    counter += 1
            'End If
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Close_form_Click(sender As Object, e As EventArgs) Handles Close_form.Click
        Form1.Panel_dashboard.Visible = True
        Form1.Panellist_drop.Visible = False
        Form1.Panellist_down.Visible = True
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub Gdv_category_CellClick(sender As Object, e As DataGridViewCellEventArgs) 
        'Dim index As Integer
        'index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = Gdv_category.Rows(index)
        'txtcategary_id.Text = selectedRow.Cells(0).Value.ToString()
        'txtcategory.Text = selectedRow.Cells(1).Value.ToString()
    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles Btndelete.Click

        If OpenDb() Then
            For Each row As DataGridViewRow In Gdv_category.Rows
                Dim is_check As Boolean = Convert.ToBoolean(row.Cells("checkcolumn").Value)
                If is_check Then
                    str = "DELETE FROM `category` WHERE `category_id` = @cid "
                    Command.CommandText = str
                    Command.Connection = conn
                    Command.Parameters.AddWithValue("@cid", row.Cells("category_id").Value)
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

    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles Btnsave.Click
        If OpenDb() Then
            insertstr1 = "INSERT INTO `category`( `category`) VALUES (@cat)"

            Command.CommandText = insertstr1
            Command.Connection = conn

            'Dim cid As String = txtcategary_id.Text
            Dim cate As String = txtcategory.Text
            'Command.Parameters.Add("@cid", MySqlDbType.Int32).Value = cid
            Command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = cate

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
End Class