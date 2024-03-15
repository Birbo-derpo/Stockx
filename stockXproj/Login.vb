﻿Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        Email = Email_Field.Text
        Password = Pass_Field.Text

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

                With HondaHomePage
                    Employee_Loginstat = True
                    DashBoard.Show()
                    .Hide()
                    Me.Hide()
                End With

            End If



            Email_Field.Clear()
            Pass_Field.Clear()

            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub lblForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblForgotPassword.LinkClicked

    End Sub
End Class