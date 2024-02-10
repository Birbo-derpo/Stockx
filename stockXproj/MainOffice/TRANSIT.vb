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
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    grdMotorcycle.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        grdMotorcycle.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("Invoice").ToString
                        grdMotorcycle.Rows(row).Cells(2).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        grdMotorcycle.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("Model").ToString
                        grdMotorcycle.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Color").ToString
                        grdMotorcycle.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Price").ToString
                        grdMotorcycle.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                        grdMotorcycle.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("FrameNum").ToString
                        grdMotorcycle.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("Stat").ToString
                        grdMotorcycle.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("Brnch").ToString
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
    Private Sub Btn_Reserved_Click(sender As Object, e As EventArgs) Handles Btn_Reserved.Click
        Reserve.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_transfer_Click(sender As Object, e As EventArgs) Handles Btn_transfer.Click
        State = "Reserve"
        For Each Checkcell As DataGridViewRow In grdMotorcycle.Rows
            'needs to accept only when branches combobox is selected
            If Checkcell.Cells("Column8").Value = True And cmb_tobranch.Text <> " " Then
                Try
                    With command
                        .Parameters.Clear()
                        .CommandText = "prc_ChangeStat"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_EngineNum", Checkcell.Cells(6).Value.ToString)
                        .Parameters.AddWithValue("@p_Branch", cmb_tobranch.Text)
                        .Parameters.AddWithValue("@p_Stat", State)
                        .ExecuteNonQuery()
                    End With

                Catch ex As Exception
                    MessageBox.Show("unit/s reserved", "reserved", MessageBoxButtons.OK)
                End Try
            End If

        Next
        PrcDisplayTransitUnits()
    End Sub
End Class
