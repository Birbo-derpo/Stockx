Imports MySql.Data.MySqlClient

Public Class MainBranchInventory
    Private datUMTC As DataTable
    Dim invoice As String

    'dataloader
    Private Sub MainBranchInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
        PrcDisplayUnits()
    End Sub

    Private Sub PrcDisplayUnits()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            datUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", "Status")
                .Parameters.AddWithValue("@p_search", "available")
                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)
                lblTotal.Text = "TOTAL RECORDS: " & datUMTC.Rows.Count
                If datUMTC.Rows.Count > 0 Then
                    grdMotorcycle.RowCount = datUMTC.Rows.Count
                    row = 0
                    While Not datUMTC.Rows.Count - 1 < row
                        grdMotorcycle.Rows(row).Cells(0).Value = datUMTC.Rows(row).Item("Invoice").ToString
                        grdMotorcycle.Rows(row).Cells(1).Value = Format(Convert.ToDateTime(datUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        grdMotorcycle.Rows(row).Cells(2).Value = datUMTC.Rows(row).Item("Model").ToString
                        grdMotorcycle.Rows(row).Cells(3).Value = datUMTC.Rows(row).Item("Color").ToString
                        grdMotorcycle.Rows(row).Cells(4).Value = datUMTC.Rows(row).Item("Price").ToString
                        grdMotorcycle.Rows(row).Cells(5).Value = datUMTC.Rows(row).Item("EngineNum").ToString
                        grdMotorcycle.Rows(row).Cells(6).Value = datUMTC.Rows(row).Item("Framenum").ToString
                        grdMotorcycle.Rows(row).Cells(7).Value = datUMTC.Rows(row).Item("Stat").ToString
                        grdMotorcycle.Rows(row).Cells(8).Value = datUMTC.Rows(row).Item("Brnch").ToString

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

    'dataloader end

    'filter
    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If chkAuto.Checked = True Then
            PrcDisplayMotorcycleWithAutoCompleteInMainInventory()
        Else

        End If
    End Sub

    Private Sub PrcDisplayMotorcycleWithAutoCompleteInMainInventory()
        sqlUMTCAdapter = New MySqlDataAdapter
        datUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_InventorySearchFilter"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", txtSearch.Text)
                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)
                lblTotal.Text = "TOTAL RECORDS: " & datUMTC.Rows.Count
                If datUMTC.Rows.Count > 0 Then
                    grdMotorcycle.RowCount = datUMTC.Rows.Count
                    row = 0
                    While Not datUMTC.Rows.Count - 1 < row

                        grdMotorcycle.Rows(row).Cells(0).Value = datUMTC.Rows(row).Item("Invoice").ToString
                        grdMotorcycle.Rows(row).Cells(1).Value = Format(Convert.ToDateTime(datUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        grdMotorcycle.Rows(row).Cells(2).Value = datUMTC.Rows(row).Item("Model").ToString
                        grdMotorcycle.Rows(row).Cells(3).Value = datUMTC.Rows(row).Item("Color").ToString
                        grdMotorcycle.Rows(row).Cells(4).Value = datUMTC.Rows(row).Item("Price").ToString
                        grdMotorcycle.Rows(row).Cells(5).Value = datUMTC.Rows(row).Item("EngineNum").ToString
                        grdMotorcycle.Rows(row).Cells(6).Value = datUMTC.Rows(row).Item("Framenum").ToString
                        grdMotorcycle.Rows(row).Cells(7).Value = datUMTC.Rows(row).Item("Stat").ToString
                        grdMotorcycle.Rows(row).Cells(8).Value = datUMTC.Rows(row).Item("Brnch").ToString

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
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        With addMotorcycle

            action = "Insert"
            .ShowDialog()
        End With
        PrcDisplayUnits()
    End Sub

    Private Sub Btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        Try
            With command
                .Parameters.Clear()
                .CommandText = "prc_DeleteUnitbyInvoice"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_invoice", invoice)
                .ExecuteNonQuery()
            End With
            MessageBox.Show("unit Successfully Deleted", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PrcDisplayUnits()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        With addMotorcycle

            action = "Update"

            .txtInvoiceNumber.Text = grdMotorcycle.CurrentRow.Cells(0).Value
            .dt.Value = Format(Convert.ToDateTime(grdMotorcycle.CurrentRow.Cells(1).Value), "yyyy,MMM,dd")

            .txtModel.Text = grdMotorcycle.CurrentRow.Cells(2).Value
            .txtColor.Text = grdMotorcycle.CurrentRow.Cells(3).Value
            .txtPrice.Text = grdMotorcycle.CurrentRow.Cells(4).Value
            .txtEngineNumber.Text = grdMotorcycle.CurrentRow.Cells(5).Value
            .txtFrameNumber.Text = grdMotorcycle.CurrentRow.Cells(6).Value
            .ShowDialog()
        End With
        PrcDisplayUnits()

    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sqlUMTCAdapter = New MySqlDataAdapter
        datUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", txtSearch.Text)
                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)
                lblTotal.Text = "TOTAL RECORDS: " & datUMTC.Rows.Count
                If datUMTC.Rows.Count > 0 Then
                    grdMotorcycle.RowCount = datUMTC.Rows.Count
                    row = 0
                    While Not datUMTC.Rows.Count - 1 < row
                        grdMotorcycle.Rows(row).Cells(0).Value = datUMTC.Rows(row).Item("Invoice").ToString
                        grdMotorcycle.Rows(row).Cells(1).Value = Format(Convert.ToDateTime(datUMTC.Rows(row).Item("Datearrive").ToString), "MMM dd, yyyy")
                        grdMotorcycle.Rows(row).Cells(2).Value = datUMTC.Rows(row).Item("Model").ToString
                        grdMotorcycle.Rows(row).Cells(3).Value = datUMTC.Rows(row).Item("Color").ToString
                        grdMotorcycle.Rows(row).Cells(4).Value = datUMTC.Rows(row).Item("Price").ToString
                        grdMotorcycle.Rows(row).Cells(5).Value = datUMTC.Rows(row).Item("EngineNum").ToString
                        grdMotorcycle.Rows(row).Cells(6).Value = datUMTC.Rows(row).Item("Framenum").ToString
                        grdMotorcycle.Rows(row).Cells(7).Value = datUMTC.Rows(row).Item("Stat").ToString
                        grdMotorcycle.Rows(row).Cells(8).Value = datUMTC.Rows(row).Item("Brnch").ToString

                        row = row + 1

                    End While
                    txtSearch.Clear()
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
    Private Sub Btn_Toreservation_Click(sender As Object, e As EventArgs) Handles Btn_ReservationPage.Click
        ConfirmReserve.ShowDialog()
    End Sub
    'button end

    Private Sub grdMotorcycle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdMotorcycle.CellClick
        invoice = grdMotorcycle.Rows(row).Cells(0).Value.ToString
    End Sub

End Class