
Imports MySql.Data.MySqlClient

Module Global_Var
    Public con_stockX As New MySqlConnection
    Public command As New MySqlCommand
    Public sqlUMTCAdapter As New MySqlDataAdapter
    Public DataUMTC As DataTable
    Public strconnection, servername, databasename, databaseuserid,
            databasepassword, action, port As String
    Public carphotopath, Email, Password As String

End Module
