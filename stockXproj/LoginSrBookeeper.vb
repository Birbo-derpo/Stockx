Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class LoginSrBookeeper
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
                UserId = CInt(DataUMTC.Rows(0).Item("id"))
            End With

            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
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


                If position = "Sr.Bookeeper" Then ' Check if the position is srbookkeeper
                    Dim userEmail As String = DataUMTC.Rows(0).Item("Gmail").ToString()
                    Dim dashboardForm As New S_dashboard()
                    dashboardForm.lblgmail.Text = userEmail



                    With HondaHomePage
                        Login_stat = True
                        dashboardForm.Show()
                        .Dispose()

                        Me.Dispose()
                    End With
                Else
                    MessageBox.Show("You do not have permission to access the dashboard.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub LoginSrBookeeper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
    End Sub
End Class