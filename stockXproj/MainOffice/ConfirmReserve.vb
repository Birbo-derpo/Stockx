Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class ConfirmReserve
    Private Sub ConfirmReserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prcdisplayBranch()
        PrcDisplayAvailableUnits()
    End Sub

    'dataloader
    Private Sub prcdisplayBranch()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_BranchList"
                .CommandType = CommandType.StoredProcedure
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)

                If DataUMTC.Rows.Count > 0 Then
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        cmb_tobranch.Items.Add("" & DataUMTC.Rows(row).Item("Brnch").ToString())
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

    Private Sub PrcDisplayAvailableUnits()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", "Satus")
                .Parameters.AddWithValue("@p_search", "available")
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
                        row = row + 1

                    End While
                Else

                    txtSearch.Clear()
                    cmbSearchType.SelectedIndex = -1
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

    'filter
    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If chkAuto.Checked = True Then
            PrcDisplayMotorcycleWithAutoCompleteInMainInventory()
        Else

        End If
    End Sub

    Private Sub PrcDisplayMotorcycleWithAutoCompleteInMainInventory()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayMotorcycleWithAutoCompleteInMainInventory"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", txtSearch.Text)
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
                        grdMotorcycle.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                        grdMotorcycle.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("Framenum").ToString

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
    'filter end

    'Buttons
    Private Sub Btn_Confirm(sender As Object, e As EventArgs) Handles Btn_ConfirmReserve.Click
        State = "Reserve"

        PrcDisplayAvailableUnits()
        'checked list must be changed state only when reserved

    End Sub
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", txtSearch.Text)
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
                        grdMotorcycle.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                        grdMotorcycle.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("Framenum").ToString

                        row = row + 1

                    End While
                    txtSearch.Clear()
                    cmbSearchType.SelectedIndex = -1

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
    Private Sub Btn_back_Click(sender As Object, e As EventArgs) Handles Btn_back.Click
        MainBranchInventory.Show()
        Me.Hide()
    End Sub
    'Buttons end
End Class