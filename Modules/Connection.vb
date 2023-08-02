Imports MySql.Data.MySqlClient
Module Connection
    Public conn As New MySqlConnection
    Public result As Boolean

    Public Function OpenDb()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "datasource=127.0.0.1;username=root;password= ;database=tea_manage;sslmode=none"
                conn.Open()
                result = conn.State
            End If

        Catch ex As Exception
            result = conn.State

        End Try
        Return result
    End Function

    Public Function CloseDb()
        conn.Close()
        Return result
    End Function
End Module
