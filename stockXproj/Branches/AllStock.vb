﻿Public Class AllStock
    Private Sub Btn_Released_Click(sender As Object, e As EventArgs) Handles Btn_Released.Click
        Released.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Deposited_Click(sender As Object, e As EventArgs) Handles Btn_Deposited.Click
        Deposited.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Repossess_Click(sender As Object, e As EventArgs) Handles Btn_Repossess.Click
        Repossess.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Customer_Click(sender As Object, e As EventArgs) Handles Btn_Customer.Click
        Customer.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        UpdateStocks.Show()
        Me.Hide()
    End Sub
End Class