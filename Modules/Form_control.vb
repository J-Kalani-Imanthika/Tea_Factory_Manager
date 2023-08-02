Imports MySql.Data.MySqlClient
Public Class Form_control
    Dim conn As New MySqlConnection
    '' <summary>
    '' Select if the username textbox and password is null, then return color
    '' </summary>

    '======= Function to Return table data ========
    Function getdata(ByVal quary As String) As DataTable
        Dim command As New MySqlCommand(quary, conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        Return table
    End Function

    '======= Function to Return table data with parameters ========
    Function getDatawithPara(ByVal command As MySqlCommand) As DataTable
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        Return table
    End Function
    '======= Function to Count rows in specific table ========
    Function getCount(ByVal tablename As String) As Integer

        Dim quary As String = ""
        Dim command As New MySqlCommand(quary, conn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        Return table.Rows.Count

    End Function





End Class
