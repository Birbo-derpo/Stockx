Imports K4os.Compression.LZ4
Imports MySql.Data.MySqlClient

Public Class AvailableStocks
    Private datUMTC As DataTable
    Private Engyno As String

    Private Sub Btn_AvStock_Click(sender As Object, e As EventArgs) Handles Btn_AvStock.Click
        MainBranchInventory.Show()
        Me.Close()
    End Sub

    Private Sub AvailableStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login_stat <> True Then
            Login.Show()
            Me.Close()
        Else
            CheckDatabaseConnection()
            PrcAvailableUnits()
        End If
    End Sub

    Private Sub PrcAvailableUnits()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            datUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", "Status")
                .Parameters.AddWithValue("@p_search", "Available")
                .Parameters.AddWithValue("@p_GBranch", "Main")
                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)
                lblTotal.Text = "TOTAL RECORDS: " & datUMTC.Rows.Count
                If datUMTC.Rows.Count > 0 Then
                    Grd_Motorcycle.RowCount = datUMTC.Rows.Count
                    row = 0
                    While Not datUMTC.Rows.Count - 1 < row
                        Grd_Motorcycle.Rows(row).Cells(0).Value = datUMTC.Rows(row).Item("Invoice").ToString
                        Grd_Motorcycle.Rows(row).Cells(1).Value = Format(Convert.ToDateTime(datUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        Grd_Motorcycle.Rows(row).Cells(2).Value = datUMTC.Rows(row).Item("Model").ToString
                        Grd_Motorcycle.Rows(row).Cells(3).Value = datUMTC.Rows(row).Item("Color").ToString
                        Grd_Motorcycle.Rows(row).Cells(4).Value = datUMTC.Rows(row).Item("Price").ToString
                        Grd_Motorcycle.Rows(row).Cells(5).Value = datUMTC.Rows(row).Item("EngineNum").ToString
                        Grd_Motorcycle.Rows(row).Cells(6).Value = datUMTC.Rows(row).Item("Framenum").ToString
                        Grd_Motorcycle.Rows(row).Cells(7).Value = datUMTC.Rows(row).Item("Stat").ToString
                        Grd_Motorcycle.Rows(row).Cells(8).Value = datUMTC.Rows(row).Item("Brnch").ToString

                        row = row + 1

                    End While
                    sqlUMTCAdapter.Dispose()
                    datUMTC.Dispose()
                Else
                    MessageBox.Show("No Available Records", "Records", MessageBoxButtons.OK, MessageBoxIcon.Question)
                End If
            End With

            sqlUMTCAdapter.Dispose()
            datUMTC.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub prc_search()
        sqlUMTCAdapter = New MySqlDataAdapter
        datUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", Txt_Search.Text)
                .Parameters.AddWithValue("@p_GBranch", "Main")
                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)
                lblTotal.Text = "TOTAL RECORDS: " & datUMTC.Rows.Count
                If datUMTC.Rows.Count > 0 Then
                    Grd_Motorcycle.RowCount = datUMTC.Rows.Count
                    row = 0
                    While Not datUMTC.Rows.Count - 1 < row

                        Grd_Motorcycle.Rows(row).Cells(0).Value = datUMTC.Rows(row).Item("Invoice").ToString
                        Grd_Motorcycle.Rows(row).Cells(1).Value = Format(Convert.ToDateTime(datUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        Grd_Motorcycle.Rows(row).Cells(2).Value = datUMTC.Rows(row).Item("Model").ToString
                        Grd_Motorcycle.Rows(row).Cells(3).Value = datUMTC.Rows(row).Item("Color").ToString
                        Grd_Motorcycle.Rows(row).Cells(4).Value = datUMTC.Rows(row).Item("Price").ToString
                        Grd_Motorcycle.Rows(row).Cells(5).Value = datUMTC.Rows(row).Item("EngineNum").ToString
                        Grd_Motorcycle.Rows(row).Cells(6).Value = datUMTC.Rows(row).Item("FrameNum").ToString
                        Grd_Motorcycle.Rows(row).Cells(7).Value = datUMTC.Rows(row).Item("Stat").ToString
                        Grd_Motorcycle.Rows(row).Cells(8).Value = datUMTC.Rows(row).Item("Brnch").ToString

                        row = row + 1
                    End While

                End If
            End With
            sqlUMTCAdapter.Dispose()
            datUMTC.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub
    'filter end

    'button

    Private Sub Btn_Reserved_Click(sender As Object, e As EventArgs) Handles Btn_Reserved.Click
        Reserve.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Transit_Click(sender As Object, e As EventArgs) Handles Btn_Transit.Click
        TRANSIT.Show()
        Me.Close()
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        If Chk_Auto.Checked = True Then
            prc_search()
        Else

        End If
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        sqlUMTCAdapter = New MySqlDataAdapter
        datUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", Txt_Search.Text)
                .Parameters.AddWithValue("@p_GBranch", "Main")
                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)
                lblTotal.Text = "TOTAL RECORDS: " & datUMTC.Rows.Count
                If datUMTC.Rows.Count > 0 Then
                    Grd_Motorcycle.RowCount = datUMTC.Rows.Count
                    row = 0
                    While Not datUMTC.Rows.Count - 1 < row
                        Grd_Motorcycle.Rows(row).Cells(0).Value = datUMTC.Rows(row).Item("Invoice").ToString
                        Grd_Motorcycle.Rows(row).Cells(1).Value = Format(Convert.ToDateTime(datUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        Grd_Motorcycle.Rows(row).Cells(2).Value = datUMTC.Rows(row).Item("Model").ToString
                        Grd_Motorcycle.Rows(row).Cells(3).Value = datUMTC.Rows(row).Item("Color").ToString
                        Grd_Motorcycle.Rows(row).Cells(4).Value = datUMTC.Rows(row).Item("Price").ToString
                        Grd_Motorcycle.Rows(row).Cells(5).Value = datUMTC.Rows(row).Item("EngineNum").ToString
                        Grd_Motorcycle.Rows(row).Cells(6).Value = datUMTC.Rows(row).Item("FrameNum").ToString
                        Grd_Motorcycle.Rows(row).Cells(7).Value = datUMTC.Rows(row).Item("Stat").ToString
                        Grd_Motorcycle.Rows(row).Cells(8).Value = datUMTC.Rows(row).Item("Brnch").ToString

                        row = row + 1

                    End While
                    Txt_Search.Clear()
                    cmbSearchType.SelectedIndex = -1

                Else
                    MessageBox.Show("No Available Records", "Records", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With
            sqlUMTCAdapter.Dispose()
            datUMTC.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try

    End Sub

    Private Sub Btn_Dashboard_Click(sender As Object, e As EventArgs) Handles Btn_Dashboard.Click
        DashBoard.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Btn_ReservationPage_Click(sender As Object, e As EventArgs) Handles Btn_ReservationPage.Click
        ConfirmReserve.ShowDialog()
        PrcAvailableUnits()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        action = "Insert"
        addMotorcycle.ShowDialog()
        If Txt_Search.Text = "" Then
            PrcAvailableUnits()
        Else
            prc_search()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        With addMotorcycle
            action = "Edit"

            .txtPrice.Text = Grd_Motorcycle.CurrentRow.Cells(4).Value.ToString()
            .txtInvoiceNumber.Text = Grd_Motorcycle.CurrentRow.Cells(0).Value.ToString
            .txtFrameNumber.Text = Grd_Motorcycle.CurrentRow.Cells(6).Value.ToString()
            .txtEngineNumber.Text = Grd_Motorcycle.CurrentRow.Cells(5).Value.ToString
            .Cmb_Color.Text = Grd_Motorcycle.CurrentRow.Cells(3).Value.ToString
            .Cmb_Model.Text = Grd_Motorcycle.CurrentRow.Cells(2).Value.ToString
            .dt.Value = Format(Convert.ToDateTime(Grd_Motorcycle.CurrentRow.Cells(1).Value), "yyyy,MMM,dd")
            .ShowDialog()

        End With
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prc_DeleteUnitbyEngineNumber"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_EngineNo", Engyno)
                .ExecuteNonQuery()
            End With
            MessageBox.Show("unit Successfully Deleted", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PrcAvailableUnits()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
        If Txt_Search.Text = "" Then
            PrcAvailableUnits()
        Else
            prc_search()
        End If
    End Sub

    'dataloader end

    'filter
End Class