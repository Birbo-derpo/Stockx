Public Class DashBoard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainBranchInventory.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AllStock.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Customer.Show()
        Me.Hide()

    End Sub
End Class