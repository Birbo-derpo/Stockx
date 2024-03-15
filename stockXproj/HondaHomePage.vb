Public Class HondaHomePage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Employee_Or_SrBookeeper.ShowDialog()
        Me.Hide()
    End Sub
End Class