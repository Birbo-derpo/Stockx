Imports MySql.Data.MySqlClient

Public Class Add_MT_Number
    Dim branch As String
    Private Sub Add_MT_Number_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
        PrcDisplayReservedUnits()
    End Sub

    Private Sub PrcDisplayReservedUnits()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", "Status")
                .Parameters.AddWithValue("@p_search", "Reserved")
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    Grd_MotorcycleReserved.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        Grd_MotorcycleReserved.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                        Grd_MotorcycleReserved.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("Invoice").ToString
                        Grd_MotorcycleReserved.Rows(row).Cells(2).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        Grd_MotorcycleReserved.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("Model").ToString
                        Grd_MotorcycleReserved.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Color").ToString
                        Grd_MotorcycleReserved.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Price").ToString
                        Grd_MotorcycleReserved.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                        Grd_MotorcycleReserved.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("FrameNum").ToString
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

    Private Sub GrdMotorcycle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grd_MotorcycleReserved.CellClick
        EngineNo = Grd_MotorcycleReserved.Rows(row).Cells(6).Value.ToString
    End Sub

    Private Sub Btn_ConfirmTransit_Click(sender As Object, e As EventArgs) Handles Btn_ConfirmTransit.Click
        'sends to delivery for transit
        State = "Transit"
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prc_AddMTN"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_EngineNum", EngineNo)
                .ExecuteNonQuery()
            End With

            With command
                .Parameters.Clear()
                .CommandText = "prc_ChangeStat"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_EngineNum", EngineNo)
                .Parameters.AddWithValue("@p_Stat", State)
                .ExecuteNonQuery()
            End With

        Catch ex As Exception
            MessageBox.Show("unit now in transit", "in transit", MessageBoxButtons.OK)
        End Try

    End Sub

End Class