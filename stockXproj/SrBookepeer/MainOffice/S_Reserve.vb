Imports MySql.Data.MySqlClient

Public Class S_Reserve
    'this page displays units reserved by branches
    Private Sub Reserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login_stat <> True Then
            Login.Show()
            Me.Close()
        Else
            CheckDatabaseConnection()
            PrcDisplayReservedUnits()
        End If

    End Sub

    Private Sub PrcDisplayReservedUnits()
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

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
                        Grd_MotorcycleReserved.Rows(row).Cells(9).Value = DataUMTC.Rows(row).Item("Stat").ToString
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

    Private Sub Btn_AddReserve_Click(sender As Object, e As EventArgs) Handles Btn_CancelReserve.Click
        ConfirmReserve.Show()
        Me.Close()
    End Sub

    'button start
    Private Sub Btn_Add_MT_Click(sender As Object, e As EventArgs) Handles Btn_Add_MT.Click
        'sends to delivery for transit
        State = "Transit"
        If txt_MTN.Text <> "" Then
            For Each Checkcell As DataGridViewRow In Grd_MotorcycleReserved.Rows
                'needs to accept only when branches combobox is selected

                If Checkcell.Cells("Column10").Value = True Then
                    Try
                        With command
                            .Parameters.Clear()
                            .CommandText = "prc_AddMTN"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.AddWithValue("@p_MTN", txt_MTN.Text)
                            .Parameters.AddWithValue("@p_EngineNum", Checkcell.Cells(7).Value.ToString)
                            .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
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
                            .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
                            .ExecuteNonQuery()
                        End With
                        With command
                            .Parameters.Clear()
                            .CommandText = "prc_Record"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.AddWithValue("@p_Action", "Add MTN")
                            .Parameters.AddWithValue("@p_d", todaysdate)
                            .Parameters.AddWithValue("@p_Unit", Checkcell.Cells(7).Value.ToString)
                            .Parameters.AddWithValue("@p_branch", Checkcell.Cells(1).Value.ToString)
                            .Parameters.AddWithValue("@p_FromState", "Available")
                            .Parameters.AddWithValue("@p_ToState", State)
                            .Parameters.AddWithValue("@p_Customer", "none")
                            .Parameters.AddWithValue("@p_Employee", Username)
                            .ExecuteNonQuery()
                        End With
                    Catch ex As Exception
                    End Try
                    Checkcell.Cells("Column10").Value = False
                End If

            Next
            MessageBox.Show("unit/s are now in Transit", "In transit", MessageBoxButtons.OK)
        Else
            MessageBox.Show("MT number not inputted", "MT number", MessageBoxButtons.OK)
        End If

        PrcDisplayReservedUnits()
    End Sub

    Private Sub Btn_AvStock_Click(sender As Object, e As EventArgs)
        S_MainOffice.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Transit_Click(sender As Object, e As EventArgs) Handles Btn_Transit.Click
        S_Transit.Show()
        Me.Close()
    End Sub
    'buttons end
    Private Sub Cmb_tobranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_branch.SelectedIndexChanged
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_BranchSort"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_branch", cmb_branch.Text)
                .Parameters.AddWithValue("@p_Stat", "Reserved")
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
                        Grd_MotorcycleReserved.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("Framenum").ToString
                        row = row + 1

                    End While

                Else
                    MessageBox.Show("No Available Records", "Records", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With
            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        S_dashboard.Show()
        Me.Close()
    End Sub


    Private Sub Btn_CancelReserve_Click(sender As Object, e As EventArgs) Handles Btn_CancelReserve.Click
        'sends to delivery for transit
        State = "Available"
        For Each Checkcell As DataGridViewRow In Grd_MotorcycleReserved.Rows
            'needs to accept only when branches combobox is selected

            If Checkcell.Cells("Column10").Value = True Then
                Try
                    With command
                        .Parameters.Clear()
                        .CommandText = "prc_GetUnitDate"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_EngineNum", Checkcell.Cells(7).Value.ToString)
                        .Parameters.AddWithValue("@p_state", State)
                        .ExecuteNonQuery()
                    End With
                    With command
                        .Parameters.Clear()
                        .CommandText = "prc_ChangeStat"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_EngineNum", Checkcell.Cells(7).Value.ToString)
                        .Parameters.AddWithValue("@p_Stat", State)
                        .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
                        .ExecuteNonQuery()
                    End With
                    With command
                        .Parameters.Clear()
                        .CommandText = "prc_Record"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_Action", "Cancel Reservation")
                        .Parameters.AddWithValue("@p_d", todaysdate)
                        .Parameters.AddWithValue("@p_Unit", Checkcell.Cells(7).Value.ToString)
                        .Parameters.AddWithValue("@p_branch", Checkcell.Cells(1).Value.ToString)
                        .Parameters.AddWithValue("@p_FromState", "Reserved")
                        .Parameters.AddWithValue("@p_ToState", State)
                        .Parameters.AddWithValue("@p_Customer", "none")
                        .Parameters.AddWithValue("@p_Employee", Username)
                        .ExecuteNonQuery()
                    End With
                Catch ex As Exception
                    MessageBox.Show("Catch Happened", "Catch", MessageBoxButtons.OK)
                End Try
                Checkcell.Cells("Column10").Value = False
            End If

        Next
        MessageBox.Show("Reservation is now canceled", "Cancel Reservation", MessageBoxButtons.OK)


        PrcDisplayReservedUnits()
    End Sub

    Private Sub Btn_AllUnits_Click(sender As Object, e As EventArgs) Handles Btn_AllUnits.Click
        S_MainOffice.Show()
        Me.Close()
    End Sub

End Class