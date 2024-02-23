Imports System.Diagnostics.Eventing.Reader
Imports MySql.Data.MySqlClient

Public Class Add_MT_Number
    Dim branch As String

    'dataloader
    Private Sub Add_MT_Number_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
    End Sub

    Private Sub PrcDisplayReservedUnits() 'useless for now
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", "Status")
                .Parameters.AddWithValue("@p_search", "Reserved")
                .Parameters.AddWithValue("@p_GBranch", "Main")
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    Grd_MotorcycleReserved.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        Grd_MotorcycleReserved.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                        Grd_MotorcycleReserved.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("Invoice").ToString
                        Grd_MotorcycleReserved.Rows(row).Cells(3).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        Grd_MotorcycleReserved.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Model").ToString
                        Grd_MotorcycleReserved.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Color").ToString
                        Grd_MotorcycleReserved.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("Price").ToString
                        Grd_MotorcycleReserved.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                        Grd_MotorcycleReserved.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("FrameNum").ToString
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
    'dataloader end

    'buttons
    Private Sub Btn_ConfirmTransit_Click(sender As Object, e As EventArgs) Handles Btn_ConfirmTransit.Click
        'sends to delivery for transit
        State = "Transit"
        If txt_MTN.Text <> "" Then
            For Each Checkcell As DataGridViewRow In Grd_MotorcycleReserved.Rows
                'needs to accept only when branches combobox is selected

                If Checkcell.Cells("Column9").Value = True Then
                    Try
                        With command
                            .Parameters.Clear()
                            .CommandText = "prc_AddMTN"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.AddWithValue("@p_MTN", txt_MTN.Text)
                            .Parameters.AddWithValue("@p_EngineNum", Checkcell.Cells(7).Value.ToString)
                            .ExecuteNonQuery()
                        End With

                    Catch ex As Exception
                    End Try
                    Try
                        With command
                            .Parameters.Clear()
                            .CommandText = "prc_ChangeStat"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.AddWithValue("@p_EngineNum", Checkcell.Cells(7).Value.ToString)
                            .Parameters.AddWithValue("@p_Stat", State)
                            .ExecuteNonQuery()
                        End With
                    Catch ex As Exception
                    End Try
                    Checkcell.Cells("Column9").Value = False
                End If

            Next
            MessageBox.Show("unit/s are now in Transit", "In transit", MessageBoxButtons.OK)
        Else
            MessageBox.Show("MT number not inputted", "MT number", MessageBoxButtons.OK)
        End If


        PrcDisplayReservedUnits()
    End Sub

    Private Sub Btn_back_Click(sender As Object, e As EventArgs) Handles Btn_back.Click
        With Reserve
            .Show()
        End With
        Me.Hide()
    End Sub

    Private Sub txt_MTN_TextChanged(sender As Object, e As EventArgs) Handles txt_MTN.TextChanged

    End Sub

    Private Sub chkAuto_CheckedChanged(sender As Object, e As EventArgs) Handles chkAuto.CheckedChanged

    End Sub
    'buttons end
End Class