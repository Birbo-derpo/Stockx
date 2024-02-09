Public Class Reserve
    'this page displays units reserved by branches

    Private Sub Btn_AddReserve_Click(sender As Object, e As EventArgs) Handles Btn_AddReserve.Click
        ConfirmReserve.Show()
        Me.Hide()
    End Sub

End Class