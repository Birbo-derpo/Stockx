Imports MySql.Data.MySqlClient

Public Class TRANSIT
    Private Sub TRANSIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
        PrcDisplayTransitUnits()
    End Sub
    Private Sub PrcDisplayTransitUnits()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", "Status")
                .Parameters.AddWithValue("@p_search", "in Transit")
                .Parameters.AddWithValue("@p_GBranch", "Main")
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    Grd_Motorcycle.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        Grd_Motorcycle.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                        Grd_Motorcycle.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("Mtn").ToString
                        Grd_Motorcycle.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("Invoice").ToString
                        Grd_Motorcycle.Rows(row).Cells(4).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        Grd_Motorcycle.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Model").ToString
                        Grd_Motorcycle.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("Color").ToString
                        Grd_Motorcycle.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("Price").ToString
                        Grd_Motorcycle.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                        Grd_Motorcycle.Rows(row).Cells(9).Value = DataUMTC.Rows(row).Item("FrameNum").ToString
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

    Private Sub Btn_Transfer_Click(sender As Object, e As EventArgs) Handles Btn_Transfer.Click
        State = "in branch"
        For Each Checkcell As DataGridViewRow In Grd_Motorcycle.Rows
            'needs to accept only when branches combobox is selected
            If Checkcell.Cells("Column8").Value = True Then
                Try
                    With command
                        .Parameters.Clear()
                        .CommandText = "prc_ChangeStat"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_EngineNum", Checkcell.Cells(8).Value.ToString)
                        .Parameters.AddWithValue("@p_Stat", State)
                        .ExecuteNonQuery()
                    End With

                Catch ex As Exception
                End Try
            End If

        Next
        MessageBox.Show("unit/s now in branch", "in branch", MessageBoxButtons.OK)
        PrcDisplayTransitUnits()
    End Sub

    Private Sub Btn_Reserved_Click(sender As Object, e As EventArgs) Handles Btn_Reserved.Click
        Reserve.Show()
        Me.Close()
    End Sub

    Private Sub Btn_AvStock_Click(sender As Object, e As EventArgs) Handles Btn_AvStock.Click
        MainBranchInventory.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DashBoard.Show()
        Me.Close()
    End Sub


End Class
