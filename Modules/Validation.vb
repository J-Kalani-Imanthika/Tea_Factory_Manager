Imports MySql.Data.MySqlClient

Module Validation
    Public result As Boolean

    Public Function Is_email_exist(ByVal email As String) As Boolean
        Dim rows As Integer
        Dim command As New MySqlCommand
        result = False
        email = email.ToLower
        command.CommandText = "SELECT COUNT ( `email`) FROM `user` WHERE  `email` = @em LIMIT 1"
        command.Connection = conn
        command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email
        rows = Command.executescalar()
        Command.parameters.clear()

        If rows > 0 Then
            result = True
        End If
        Return result
    End Function

    Public Function Isempty(ByVal inputname As String) As Boolean
        inputname = Trim(inputname)
        If String.IsNullOrEmpty(inputname) Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    ''' <summary>
    ''' minimum length of a string
    ''' </summary>
    ''' 

    Public Function MinLen(ByVal input As String, ByVal len As Integer) As Boolean
        If input.Length < len Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function




End Module
