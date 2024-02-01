Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Tls

Module Global_procedure
    Public Function FncConnectToDatabase() As Boolean
        Try
            ServerName = "localhost"
            databasename = "stockx"
            databaseuserid = "root"
            databasepassword = ""
            port = "3306"

            If con_stockX.State = ConnectionState.Closed Then
                con_stockX = New MySqlConnection
                strconnection = "Server = " & servername & ";" _
                              & "DataBase =" & databasename & ";" _
                              & "Username =" & databaseuserid & ";" _
                              & "Password =" & databasepassword & ";" _
                              & "Port =" & port & ";" _
                              & "Default Command Timeout =" & 20 * 60

                con_stockX.ConnectionString = strconnection
                con_stockX.Open()
                command.Connection = con_stockX
                Return True

            Else
                con_stockX.Close()
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
        Return False
    End Function

    Public Sub CheckDatabaseConnection()
        If FncConnectToDatabase() = True Then
        Else
            con_stockX.Open()
        End If
    End Sub

End Module

