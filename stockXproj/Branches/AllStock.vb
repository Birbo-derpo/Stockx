Imports MySql.Data.MySqlClient

Public Class AllStock

    Dim Model, Color, Price, Engine_Num, Frame_Num, MTN As String
    'dataloader
    Private Sub AllStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
        PrcDisplayAllStock()
    End Sub

    Private Sub PrcDisplayAllStock()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", "Status")
                .Parameters.AddWithValue("@p_search", "In branch")
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
    'dataloader end

    'left screen buttons

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        All_Unit.Show()
        Me.Close()

    End Sub



    Private Sub Btn_Released_Click(sender As Object, e As EventArgs) Handles Btn_Released.Click
        Released.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Dashboard_Click(sender As Object, e As EventArgs) Handles Btn_Dashboard.Click
        DashBoard.Show()
        Me.Close()
    End Sub

    Private Sub cmb_branch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_branch.SelectedIndexChanged
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_BranchSort"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_branch", cmb_branch.Text)
                .Parameters.AddWithValue("@p_Stat", "in branch")
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

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_SearchStockByStatus"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", txtSearch.Text)
                .Parameters.AddWithValue("@p_Stat", "In branch")
                .Parameters.AddWithValue("@p_SBranch", cmb_branch.Text)
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

    Private Sub Btn_Deposited_Click(sender As Object, e As EventArgs) Handles Btn_Deposited.Click
        Deposited.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Repossess_Click(sender As Object, e As EventArgs) Handles Btn_Repossess.Click
        Repossess.Show()

        Me.Close()
    End Sub

    'end of left screen buttons
    Private Sub Btn_AddCust_Click(sender As Object, e As EventArgs) Handles Btn_AddCust.Click
        action = "update"
        With UpdateStocks
            .Txt_SIN.Text = MTN
            .Txt_Model.Text = Model
            .Txt_Color.Text = Color
            .Txt_Price.Text = Price
            .Txt_EngineNumber.Text = Engine_Num
            .Txt_FrameNumber.Text = Frame_Num
            .ShowDialog()
        End With
    End Sub

    Private Sub Grd_Stock_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Grd_Stock.CellClick
        Model = Grd_Stock.CurrentRow.Cells(3).Value.ToString
        Color = Grd_Stock.CurrentRow.Cells(5).Value.ToString
        Price = Grd_Stock.CurrentRow.Cells(4).Value.ToString
        Engine_Num = Grd_Stock.CurrentRow.Cells(6).Value.ToString
        Frame_Num = Grd_Stock.CurrentRow.Cells(7).Value.ToString
    End Sub
End Class