Public Class Reserve
    'this page displays units reserved by branches

    Private Sub Btn_AddReserve_Click(sender As Object, e As EventArgs)
        ConfirmReserve.Show()
        Me.Hide()
    End Sub

    Private Sub Reserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class