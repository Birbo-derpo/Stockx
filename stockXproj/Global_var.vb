Imports System.Data.SqlClient
Module Global_Var
    Public conUMTC As New MySqlConnection
    Public command As New MySqlCommand
    Public sqlUMTCAdapter As New MySqlDataAdapter
    Public DataUMTC As DataTable
    Public strconnection, servername, databasename, databaseuserid,
            databasepassword, action, port As String
End Module
