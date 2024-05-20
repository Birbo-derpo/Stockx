Public Class Employeree_Acounts
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CreateEmployee.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click

    End Sub

    Private Sub Btn_Dashboard_Click(sender As Object, e As EventArgs) Handles Btn_Dashboard.Click
        S_dashboard.Show()
        Me.Close()
    End Sub
End Class