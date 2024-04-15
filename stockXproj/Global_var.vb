Imports MySql.Data.MySqlClient

Module Global_Var
    Public con_stockX As New MySqlConnection
    Public command As New MySqlCommand
    Public sqlUMTCAdapter As New MySqlDataAdapter
    Public DataUMTC As DataTable
    Public strconnection, servername, databasename, databaseuserid,
            databasepassword, action, State, port As String
    Public EngineNo, Email, Password, Username As String
    Public row, Cust_id As Integer
    Public toUser As String
    Public Gmail, Firstname, Lastname, Position, gender, full As String
    Public userGmail As String

    Public Login_stat As Boolean
    Public UserId As Integer
    Public EmployeeId As Integer
    Dim regDate As Date = Date.Now()
    Public todaysdate As String = regDate.ToString("yyyy-MM-dd")

End Module
