Imports MySql.Data.MySqlClient

Public Class Released
    Private Sub Released_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
        PrcDisplayDepositedStock()
    End Sub

    Private Sub PrcDisplayDepositedStock()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "procDisplayAllStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", "Status")
                .Parameters.AddWithValue("@p_search", "Released")
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    Grd_StockReleased.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        If DataUMTC.Rows(row).Item("Brnch").ToString = "Main" Then
                            row = row + 1
                        Else
                            Grd_StockReleased.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                            Grd_StockReleased.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("Invoice").ToString
                            Grd_StockReleased.Rows(row).Cells(2).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                            Grd_StockReleased.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("model").ToString
                            Grd_StockReleased.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Color").ToString
                            Grd_StockReleased.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Price").ToString
                            Grd_StockReleased.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("EngineNum").ToString

                            row = row + 1
                        End If
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        All_Unit.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_AllStock_Click(sender As Object, e As EventArgs) Handles Btn_AllStock.Click
        AllStock.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Released_Click(sender As Object, e As EventArgs) Handles Btn_Released.Click
        Me.Show()

    End Sub

    Private Sub Btn_Deposited_Click(sender As Object, e As EventArgs) Handles Btn_Deposited.Click
        Deposited.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Repossess_Click(sender As Object, e As EventArgs) Handles Btn_Repossess.Click
        Repossess.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Dashboard_Click(sender As Object, e As EventArgs) Handles Btn_Dashboard.Click
        DashBoard.Show()
        Me.Hide()
    End Sub
End Class