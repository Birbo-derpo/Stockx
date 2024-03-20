Public Class Employee_Or_SrBookeeper
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LoginSrBookeeper.ShowDialog()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class