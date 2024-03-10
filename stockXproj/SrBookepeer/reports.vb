Imports MySql.Data.MySqlClient

Public Class reports
    Private Sub reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
        PrcDisplaySalesReport()
        ReleaseUnits("Bajada", "Released", cmb_Month.Text)
        ReleaseUnits("Tagum", "Released", cmb_Month.Text)
        ReleaseUnits("Davao", "Released", cmb_Month.Text)
        ReleaseUnits("General Santos", "Released", cmb_Month.Text)
        ReleaseUnits("Kidapawan", "Released", cmb_Month.Text)
        ReleaseUnits("Digos", "Released", cmb_Month.Text)

    End Sub
    Private Sub ReleaseUnits(p_Branch As String, p_Status As String, p_Month As String)
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable

        With command
            .Parameters.Clear()
            .CommandText = "prc_ReleasaeUnitPerBranch"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_Branch", p_Branch)
            .Parameters.AddWithValue("@p_Status", p_Status)
            .Parameters.AddWithValue("@p_month", p_Month)
            sqlUMTCAdapter.SelectCommand = command
            DataUMTC.Clear()
            sqlUMTCAdapter.Fill(DataUMTC)

            Select Case p_Branch
                Case "Bajada"
                    btnBajada.Text &= DataUMTC.Rows(0).Item("total").ToString
                Case "Tagum"
                    btnTagum.Text &= DataUMTC.Rows(0).Item("total").ToString
                Case "Davao"
                    btnDavao.Text &= DataUMTC.Rows(0).Item("total").ToString
                Case "General Santos"
                    btnGensan.Text &= DataUMTC.Rows(0).Item("total").ToString
                Case "Kidapawan"
                    btnKidapawan.Text &= DataUMTC.Rows(0).Item("total").ToString
                Case "Digos"
                    btnDigos.Text &= DataUMTC.Rows(0).Item("total").ToString
            End Select

        End With
        sqlUMTCAdapter.Dispose()
        DataUMTC.Dispose()
    End Sub
    Private Sub PrcDisplaySalesReport()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", "Status")
                .Parameters.AddWithValue("@p_search", "Released")
                .Parameters.AddWithValue("@p_GBranch", "Branch")
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    grd_report.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        If DataUMTC.Rows(row).Item("Brnch").ToString = "Main" Then
                            row = row + 1
                        Else
                            grd_report.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                            grd_report.Rows(row).Cells(3).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                            grd_report.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("model").ToString

                            grd_report.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("EngineNum").ToString



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
                .Parameters.AddWithValue("@p_Stat", "Released")

                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    grd_report.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        If DataUMTC.Rows(row).Item("Brnch").ToString = "Main" Then
                            'skip
                            row = row + 1
                        Else
                            grd_report.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                            grd_report.Rows(row).Cells(3).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                            grd_report.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("model").ToString

                            grd_report.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("EngineNum").ToString

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

    Private Sub SortingButton(branchName As String)
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_BranchSortByButton"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_branch", branchName)
                .Parameters.AddWithValue("@p_Stat", "Released")
                .Parameters.AddWithValue("@p_month", cmb_Month.Text)

                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    grd_report.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        grd_report.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                        grd_report.Rows(row).Cells(3).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive")), "MMM dd, yyyy")
                        grd_report.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("model").ToString
                        grd_report.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("EngineNum").ToString

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
                .CommandText = "prc_SearchByStatusOrBranch"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_branch", Txt_Search.Text)
                .Parameters.AddWithValue("@p_Stat", "Released")

                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    grd_report.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        If DataUMTC.Rows(row).Item("Brnch").ToString = "Main" Then
                            row = row + 1
                        Else
                            grd_report.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                            grd_report.Rows(row).Cells(3).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                            grd_report.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("model").ToString

                            grd_report.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("EngineNum").ToString

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

    Private Sub cmb_Month_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Month.SelectedIndexChanged
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_DateSort"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_month", cmb_Month.SelectedItem.ToString())
                .Parameters.AddWithValue("@p_Stat", "Released")

                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    grd_report.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        grd_report.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                        grd_report.Rows(row).Cells(3).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Datearrive")), "MMM dd, yyyy")
                        grd_report.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("model").ToString
                        grd_report.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
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



    Private Sub btnTagum_Click(sender As Object, e As EventArgs) Handles btnTagum.Click
        SortingButton("Tagum")
    End Sub

    Private Sub btnBajada_Click(sender As Object, e As EventArgs) Handles btnBajada.Click
        SortingButton("Bajada")
    End Sub

    Private Sub btnGensan_Click(sender As Object, e As EventArgs) Handles btnGensan.Click
        SortingButton("General Santos")
    End Sub

    Private Sub btnDavao_Click(sender As Object, e As EventArgs) Handles btnDavao.Click
        SortingButton("Davao")
    End Sub

    Private Sub btnDigos_Click(sender As Object, e As EventArgs) Handles btnDigos.Click
        SortingButton("Digos")
    End Sub

    Private Sub btnKidapawan_Click(sender As Object, e As EventArgs) Handles btnKidapawan.Click
        SortingButton("Kidapawan")
    End Sub
End Class