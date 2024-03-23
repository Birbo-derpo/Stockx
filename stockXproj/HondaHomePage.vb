Public Class HondaHomePage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.ShowDialog()
        Me.Hide()
    End Sub
End Class