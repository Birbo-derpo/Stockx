Imports MySql.Data.MySqlClient
Imports Mysqlx.Prepare

Public Class change


    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_ForgotpasswordChange"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_gmail", txtgmail.Text)
                .Parameters.AddWithValue("@p_new_password", txtnewpass.Text)
                .Parameters.AddWithValue("@p_confirm_password", txtconfirmpass.Text)
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)

                ' Display the message returned by the stored procedure
                If DataUMTC.Rows.Count > 0 Then
                    MessageBox.Show(DataUMTC.Rows(0)("Message").ToString())
                End If
            End With


        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub change_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()

    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtnewpass_TextChanged(sender As Object, e As EventArgs) Handles txtnewpass.TextChanged
        ' Check if the new password contains at least one number and one letter
        Dim newPassword As String = txtnewpass.Text
        If System.Text.RegularExpressions.Regex.IsMatch(newPassword, "^(?=.*\d)(?=.*[a-zA-Z]).+$") Then
            ' Show Label5 if the new password meets the requirements
            Label5.Visible = False
        Else
            ' Hide Label5 if the new password does not meet the requirements
            Label5.Visible = True

        End If
    End Sub

    Private Sub txtconfirmpass_TextChanged(sender As Object, e As EventArgs) Handles txtconfirmpass.TextChanged

        ' Check if confirm password matches new password
        If txtnewpass.Text <> txtconfirmpass.Text Then
            Label4.Visible = True ' Hide Label4
        Else


            Label4.Visible = False ' Hide Label4

        End If
    End Sub
End Class