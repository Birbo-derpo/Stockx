Imports MySql.Data.MySqlClient

Public Class S_AllUnit
    Private Sub S_AllUnit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login_stat <> True Then
            Login.Show()
            Me.Close()
        Else
            CheckDatabaseConnection()
            PrcDisplayAllStock()
        End If
    End Sub
    Private Sub PrcDisplayAllStock()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", "")
                .Parameters.AddWithValue("@p_search", "")
                .Parameters.AddWithValue("@p_GBranch", "Branch")
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    Grd_Stock.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        If DataUMTC.Rows(row).Item("Brnch").ToString = "Main" Then
                            'skip
                            row = row + 1
                        Else
                            Grd_Stock.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                            Grd_Stock.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("MTN").ToString
                            Grd_Stock.Rows(row).Cells(2).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                            Grd_Stock.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("model").ToString
                            Grd_Stock.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Price").ToString
                            Grd_Stock.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Color").ToString
                            Grd_Stock.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                            Grd_Stock.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("Framenum").ToString
                            Grd_Stock.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("Stat").ToString
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
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", Txt_Search.Text)
                .Parameters.AddWithValue("@p_GBranch", "Branch")
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    Grd_Stock.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        If DataUMTC.Rows(row).Item("Brnch").ToString = "Main" Then
                            'skip
                            row = row + 1
                        Else
                            Grd_Stock.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                            Grd_Stock.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("MTN").ToString
                            Grd_Stock.Rows(row).Cells(2).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                            Grd_Stock.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("model").ToString
                            Grd_Stock.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Price").ToString
                            Grd_Stock.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Color").ToString
                            Grd_Stock.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                            Grd_Stock.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("Framenum").ToString
                            Grd_Stock.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("Stat").ToString

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
        Me.Close()
    End Sub

    Private Sub Btn_Repossess_Click(sender As Object, e As EventArgs) Handles Btn_Repossess.Click
        S_repossess.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", Txt_Search.Text)
                .Parameters.AddWithValue("@p_GBranch", "Branch")
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    Grd_Stock.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row

                        Grd_Stock.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                        Grd_Stock.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("MTN").ToString
                        Grd_Stock.Rows(row).Cells(2).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        Grd_Stock.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("model").ToString
                        Grd_Stock.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Price").ToString
                        Grd_Stock.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Color").ToString
                        Grd_Stock.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                        Grd_Stock.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("Framenum").ToString
                        Grd_Stock.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("Stat").ToString

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
                .Parameters.AddWithValue("@p_Stat", "")
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    Grd_Stock.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        Grd_Stock.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                        Grd_Stock.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("MTN").ToString
                        Grd_Stock.Rows(row).Cells(2).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        Grd_Stock.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("model").ToString
                        Grd_Stock.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Price").ToString
                        Grd_Stock.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Color").ToString
                        Grd_Stock.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                        Grd_Stock.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("Framenum").ToString
                        Grd_Stock.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("Stat").ToString

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


    Private Sub Btn_Dashboard_Click(sender As Object, e As EventArgs) Handles Btn_Dashboard.Click
        S_dashboard.Show()
        Me.Close()
    End Sub
End Class