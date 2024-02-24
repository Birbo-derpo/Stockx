Public Class Customer
    Private Sub Btn_AllStock_Click(sender As Object, e As EventArgs)
        AllStock.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Released_Click(sender As Object, e As EventArgs)
        Released.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Deposited_Click(sender As Object, e As EventArgs)
        Deposited.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Repossess_Click(sender As Object, e As EventArgs)
        Repossess.Show()
        Me.Hide()
    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        With UpdateStocks
            action = "Update"
            .Txt_SIN = grd_AllCustomer.CurrentRow.Cells(12).Value
            .Txt_Fname = grd_AllCustomer.CurrentRow.Cells(1).Value
            .Txt_Lname = grd_AllCustomer.CurrentRow.Cells(0).Value
            .dt = grd_AllCustomer.CurrentRow.Cells(11).Value
            .Txt_Amount = grd_AllCustomer.CurrentRow.Cells(10).Value
            .Cmb_Type = grd_AllCustomer.CurrentRow.Cells(8).Value
            .Cmb_Term = grd_AllCustomer.CurrentRow.Cells(9).Value
            .Cmb_Stat = grd_AllCustomer.CurrentRow.Cells(3).Value
            .ShowDialog()


        End With
    End Sub

    Private Sub grd_AllCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_AllCustomer.CellContentClick

    End Sub
End Class