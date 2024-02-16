Imports MySql.Data.MySqlClient

Public Class Reserve
    'this page displays units reserved by branches
    Private Sub Reserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
        PrcDisplayReservedUnits()
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
                    grd_Motorcycle.RowCount = DataUMTC.Rows.Count
                    row = 0

                    While Not DataUMTC.Rows.Count - 1 < row
                        grd_Motorcycle.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                        grd_Motorcycle.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("Invoice").ToString
                        grd_Motorcycle.Rows(row).Cells(3).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        grd_Motorcycle.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Model").ToString
                        grd_Motorcycle.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Color").ToString
                        grd_Motorcycle.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("Price").ToString
                        grd_Motorcycle.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                        grd_Motorcycle.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("FrameNum").ToString
                        grd_Motorcycle.Rows(row).Cells(9).Value = DataUMTC.Rows(row).Item("Stat").ToString
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

    Private Sub Btn_AddReserve_Click(sender As Object, e As EventArgs)
        ConfirmReserve.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Add_MT_Click(sender As Object, e As EventArgs) Handles Btn_Add_MT.Click
        For Each Checkcell As DataGridViewRow In grd_Motorcycle.Rows
            'needs to accept only when branches combobox is selected

            If Checkcell.Cells("Column10").Value = True Then
                Try
                    With Add_MT_Number
                        .Grd_MotorcycleReserved.Rows(row).Cells(1).Value = Checkcell.Cells(0).Value("Brnch").ToString
                        .Grd_MotorcycleReserved.Rows(row).Cells(2).Value = Checkcell.Cells(1).Value("Invoice").ToString
                        .Grd_MotorcycleReserved.Rows(row).Cells(3).Value = Format(Convert.ToDateTime(Checkcell.Cells(2).Value("Datearrive").ToString), "MMM dd, yyyy")
                        .Grd_MotorcycleReserved.Rows(row).Cells(4).Value = Checkcell.Cells(3).Value("Model").ToString
                        .Grd_MotorcycleReserved.Rows(row).Cells(5).Value = Checkcell.Cells(4).Value("Color").ToString
                        .Grd_MotorcycleReserved.Rows(row).Cells(6).Value = Checkcell.Cells(5).Value("Price").ToString
                        .Grd_MotorcycleReserved.Rows(row).Cells(7).Value = Checkcell.Cells(6).Value("EngineNum").ToString
                        .Grd_MotorcycleReserved.Rows(row).Cells(8).Value = Checkcell.Cells(7).Value("FrameNum").ToString
                        .ShowDialog()
                    End With

                Catch ex As Exception
                End Try
                Checkcell.Cells("Column9").Value = False
            End If

        Next
    End Sub

    Private Sub Btn_AvStock_Click(sender As Object, e As EventArgs) Handles Btn_AvStock.Click
        MainBranchInventory.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Reserved_Click(sender As Object, e As EventArgs) Handles Btn_Reserved.Click
        Me.Show()
    End Sub

    Private Sub Btn_Transit_Click(sender As Object, e As EventArgs) Handles Btn_Transit.Click
        TRANSIT.Show()
        Me.Hide()
    End Sub

    Private Sub Cmb_tobranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_branch.SelectedIndexChanged
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_BranchReserves"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_branch", cmb_branch.Text)
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    grd_Motorcycle.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        grd_Motorcycle.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                        grd_Motorcycle.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("Invoice").ToString
                        grd_Motorcycle.Rows(row).Cells(3).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        grd_Motorcycle.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Model").ToString
                        grd_Motorcycle.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Color").ToString
                        grd_Motorcycle.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("Price").ToString
                        grd_Motorcycle.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                        grd_Motorcycle.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("Framenum").ToString

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
End Class