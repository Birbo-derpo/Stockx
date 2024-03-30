Imports MySql.Data.MySqlClient

Public Class Sr_Inventory_Records
    Private Sub Sr_Inventory_Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login_stat <> True Then
            Login.Show()
            Me.Close()
        Else
            CheckDatabaseConnection()
            PrcDisplayLogs()
        End If
    End Sub

    Private Sub PrcDisplayLogs()
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_Display_Inv_Logs"
                .CommandType = CommandType.StoredProcedure
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    Grd_Inv_Logs.RowCount = DataUMTC.Rows.Count
                    row = 0

                    While Not DataUMTC.Rows.Count - 1 < row
                        Grd_Inv_Logs.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("Act").ToString
                        Grd_Inv_Logs.Rows(row).Cells(1).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Dt").ToString), "MMM dd, yyyy")
                        Grd_Inv_Logs.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("Unit_EngineNo").ToString
                        Grd_Inv_Logs.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("Branch").ToString
                        Grd_Inv_Logs.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Changed_from").ToString
                        Grd_Inv_Logs.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Changed_to").ToString
                        Grd_Inv_Logs.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("Held_By").ToString
                        Grd_Inv_Logs.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("Recorded_by").ToString
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

End Class