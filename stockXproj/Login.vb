Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        Email = Email_Field.Text
        Password = Pass_Field.Text


        'gets UserId
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "prc_GetEmployeeId"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_gmail", Email)
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)

                'stores user id in variable as integer
                EmployeeId = CInt(DataUMTC.Rows(0).Item("id"))
            End With

            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()
        Catch ex As Exception

        End Try
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "prc_Login"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_gmail", Email)
                .Parameters.AddWithValue("@p_password", Password)
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
            End With
            If DataUMTC.Rows.Count = 0 Then
                    MessageBox.Show("Invalid Username or Password", "Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim position As String = DataUMTC.Rows(0).Item("Positions").ToString()


                    If position = "Inventory Manager" Then ' Check if the position is srbookkeeper
                        Dim userEmail As String = DataUMTC.Rows(0).Item("Gmail").ToString()
                    Dim dashboardForm As New DashBoard()
                    dashboardForm.lblgmail.Text = userEmail



                        With HondaHomePage
                            Login_stat = True
                        dashboardForm.Show()
                        Prc_GetEmpName()
                        .Dispose()

                            Me.Dispose()
                        End With
                    Else
                        MessageBox.Show("Only Inventory Manager.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If


                Email_Field.Clear()
            Pass_Field.Clear()

            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub Prc_GetEmpName()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_getEmployeeName"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_gmail", Email_Field.Text)
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                Username = DataUMTC.Rows(row).Item("User_name").ToString
            End With
            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
    Private Sub lblForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblForgotPassword.LinkClicked
        Forgot_Password.Show()
        Me.Hide()
    End Sub

End Class