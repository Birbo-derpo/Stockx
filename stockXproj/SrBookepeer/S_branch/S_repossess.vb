Imports MySql.Data.MySqlClient

Public Class S_repossess
    Private Cust_Name As String
    Private Sub S_repossess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login_stat <> True Then
            Login.Show()
            Me.Close()
        Else
            CheckDatabaseConnection()
            PrcDisplayRepossessedStock()
        End If
    End Sub
    Private Sub PrcDisplayRepossessedStock()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", "Status")
                .Parameters.AddWithValue("@p_search", "Repossessed")
                .Parameters.AddWithValue("@p_GBranch", "Branch")
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    Grd_StockRepossessed.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        If DataUMTC.Rows(row).Item("Brnch").ToString = "Main" Then
                            row = row + 1
                        Else
                            Grd_StockRepossessed.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                            Grd_StockRepossessed.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("Invoice").ToString
                            Grd_StockRepossessed.Rows(row).Cells(3).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                            Grd_StockRepossessed.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("model").ToString
                            Grd_StockRepossessed.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Color").ToString
                            Grd_StockRepossessed.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("Price").ToString
                            Grd_StockRepossessed.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                            Grd_StockRepossessed.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("FrameNum").ToString
                            Grd_StockRepossessed.Rows(row).Cells(9).Value = DataUMTC.Rows(row).Item("Stat").ToString

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

    Private Sub AutofillSearch()
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_SearchByStatusOrBranch"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", Txt_Search.Text)
                .Parameters.AddWithValue("@p_Stat", "Repossessed")
                .Parameters.AddWithValue("@p_SBranch", Cmb_Branch.Text)
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    Grd_StockRepossessed.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        If DataUMTC.Rows(row).Item("Brnch").ToString = "Main" Then
                            'skip
                            row = row + 1
                        Else
                            Grd_StockRepossessed.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                            Grd_StockRepossessed.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("Invoice").ToString
                            Grd_StockRepossessed.Rows(row).Cells(3).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                            Grd_StockRepossessed.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("model").ToString
                            Grd_StockRepossessed.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Color").ToString
                            Grd_StockRepossessed.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("Price").ToString
                            Grd_StockRepossessed.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                            Grd_StockRepossessed.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("FrameNum").ToString
                            Grd_StockRepossessed.Rows(row).Cells(9).Value = DataUMTC.Rows(row).Item("Stat").ToString

                            row = row + 1
                        End If
                    End While

                End If
            End With
            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub Btn_AllUnits_Click(sender As Object, e As EventArgs) Handles Btn_AllUnits.Click
        S_AllUnit.Show()
        Me.Close()
    End Sub

    Private Sub Btn_AllStock_Click(sender As Object, e As EventArgs) Handles Btn_AllStock.Click
        S_AllStock.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Released_Click(sender As Object, e As EventArgs) Handles Btn_Released.Click
        S_Released.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Deposited_Click(sender As Object, e As EventArgs) Handles Btn_Deposited.Click
        S_Deposited.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Dashboard_Click(sender As Object, e As EventArgs) Handles Btn_Dashboard.Click
        S_dashboard.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_SearchByStatusOrBranch"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", Txt_Search.Text)
                .Parameters.AddWithValue("@p_Stat", "Repossessed")
                .Parameters.AddWithValue("@p_SBranch", Cmb_Branch.Text)
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    Grd_StockRepossessed.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row

                        Grd_StockRepossessed.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                        Grd_StockRepossessed.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("Invoice").ToString
                        Grd_StockRepossessed.Rows(row).Cells(3).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        Grd_StockRepossessed.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("model").ToString
                        Grd_StockRepossessed.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Color").ToString
                        Grd_StockRepossessed.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("Price").ToString
                        Grd_StockRepossessed.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                        Grd_StockRepossessed.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("FrameNum").ToString
                        Grd_StockRepossessed.Rows(row).Cells(9).Value = DataUMTC.Rows(row).Item("Stat").ToString

                        row = row + 1
                    End While

                End If
            End With
            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub Cmb_Branch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Branch.SelectedIndexChanged
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_BranchSort"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_branch", Cmb_Branch.Text)
                .Parameters.AddWithValue("@p_Stat", "Repossessed")
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    Grd_StockRepossessed.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row

                        Grd_StockRepossessed.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                        Grd_StockRepossessed.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("Invoice").ToString
                        Grd_StockRepossessed.Rows(row).Cells(3).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        Grd_StockRepossessed.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("model").ToString
                        Grd_StockRepossessed.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Color").ToString
                        Grd_StockRepossessed.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("Price").ToString
                        Grd_StockRepossessed.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                        Grd_StockRepossessed.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("FrameNum").ToString
                        Grd_StockRepossessed.Rows(row).Cells(9).Value = DataUMTC.Rows(row).Item("Stat").ToString

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

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        If Chk_Auto.Checked = True Then
            AutofillSearch()
        Else

        End If
    End Sub

    Private Sub Prc_GetCustName(p_unit As String)
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_GetCustomerName"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_Unit", p_unit)
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                Cust_Name = DataUMTC.Rows(0).Item("Customer").ToString
            End With
            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub Btn_ReRelease_Click(sender As Object, e As EventArgs) Handles Btn_ReRelease.Click
        State = "Release"
        For Each Checkcell As DataGridViewRow In Grd_StockRepossessed.Rows
            'needs to accept only when branches combobox is selected
            If Checkcell.Cells("Column10").Value = True Then
                Try
                    With command
                        .Parameters.Clear()
                        .CommandText = "prc_SetUnitDate"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_EngineNum", Checkcell.Cells(7).Value.ToString)
                        .Parameters.AddWithValue("@p_state", State)
                        .Parameters.AddWithValue("@p_dt", Format(dt.Value, "yyyy-MM-dd"))
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
                        .Parameters.AddWithValue("@p_Action", "Release unit")
                        .Parameters.AddWithValue("@p_d", todaysdate)
                        .Parameters.AddWithValue("@p_Unit", Checkcell.Cells(7).Value.ToString)
                        .Parameters.AddWithValue("@p_branch", Checkcell.Cells(1).Value.ToString)
                        .Parameters.AddWithValue("@p_FromState", Checkcell.Cells(9).Value.ToString)
                        .Parameters.AddWithValue("@p_ToState", State)
                        Prc_GetCustName(Checkcell.Cells(7).Value.ToString)
                        .Parameters.AddWithValue("@p_Customer", Cust_Name)
                        .Parameters.AddWithValue("@p_Employee", Username)
                        .ExecuteNonQuery()
                    End With

                Catch ex As Exception
                End Try
                Checkcell.Cells("Column10").Value = False
                Cust_Name = ""
            End If

        Next
        MessageBox.Show("unit/s now Re Released", "Re release", MessageBoxButtons.OK)
        PrcDisplayRepossessedStock()

    End Sub

    Private Sub Btn_CancelRepo_Click(sender As Object, e As EventArgs) Handles Btn_CancelRepo.Click
        State = "Release"
        For Each Checkcell As DataGridViewRow In Grd_StockRepossessed.Rows
            'needs to accept only when branches combobox is selected
            If Checkcell.Cells("Column10").Value = True Then
                Try
                    With command
                        .Parameters.Clear()
                        .CommandText = "prc_Record"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_Action", "Return Unit to Branch")
                        .Parameters.AddWithValue("@p_d", todaysdate)
                        .Parameters.AddWithValue("@p_Unit", Checkcell.Cells(7).Value.ToString)
                        .Parameters.AddWithValue("@p_branch", Checkcell.Cells(1).Value.ToString)
                        .Parameters.AddWithValue("@p_FromState", Checkcell.Cells(9).Value.ToString)
                        .Parameters.AddWithValue("@p_ToState", State)
                        Prc_GetCustName(Checkcell.Cells(7).Value.ToString)
                        .Parameters.AddWithValue("@p_Customer", Cust_Name)
                        .Parameters.AddWithValue("@p_Employee", Username)
                        .ExecuteNonQuery()
                    End With
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
                        .CommandText = "prc_ChangeStatUndo"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@p_EngineNum", Checkcell.Cells(7).Value.ToString)
                        .Parameters.AddWithValue("@p_Stat", State)
                        .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
                        .ExecuteNonQuery()
                    End With

                Catch ex As Exception
                    MessageBox.Show("" & ex.Message)
                End Try
                Checkcell.Cells("Column10").Value = False
                Cust_Name = ""
            End If

        Next
        MessageBox.Show("unit/s returned to deposit", "in branch", MessageBoxButtons.OK)
        PrcDisplayRepossessedStock()
    End Sub
End Class