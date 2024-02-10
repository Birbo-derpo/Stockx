Imports MySql.Data.MySqlClient

Public Class AllStock

    Private Sub AllStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrcDisplayAllStock()
    End Sub

    Private Sub PrcDisplayAllStock()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "procDisplayAllStock"
                .CommandType = CommandType.StoredProcedure
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    Grd_Stock.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row

                        Grd_Stock.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                        Grd_Stock.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("Invoice").ToString
                        Grd_Stock.Rows(row).Cells(2).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        Grd_Stock.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("model").ToString
                        Grd_Stock.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Color").ToString
                        Grd_Stock.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Price").ToString
                        Grd_Stock.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("EngineNum").ToString

                        row = row + 1

                    End While
                Else

                    MessageBox.Show("No Available Records", "Records", MessageBoxButtons.OK, MessageBoxIcon.Question)
                End If
            End With

            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    'left screen buttons
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

    Private Sub Btn_Customer_Click(sender As Object, e As EventArgs)
        Customer.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs)
        UpdateStocks.Show()
        Me.Hide()
    End Sub
    'end of left screen buttons

End Class