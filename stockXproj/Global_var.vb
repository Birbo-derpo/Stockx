﻿Imports MySql.Data.MySqlClient

Module Global_Var
    Public con_stockX As New MySqlConnection
    Public command As New MySqlCommand
    Public sqlUMTCAdapter As New MySqlDataAdapter
    Public DataUMTC As DataTable
    Public strconnection, servername, databasename, databaseuserid,
            databasepassword, action, State, port As String
    Public EngineNo, Email, Password As String
    Public row As Integer

End Module
