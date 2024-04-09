Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class ConfirmReserve
    Private Sub ConfirmReserve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login_stat <> True Then
            Login.Show()
            Me.Close()
        Else
            CheckDatabaseConnection()
            PrcDisplayAvailableUnits()
        End If
    End Sub

    'dataloader

    Private Sub PrcDisplayAvailableUnits()
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", "Status")
                .Parameters.AddWithValue("@p_search", "available")
                .Parameters.AddWithValue("@p_GBranch", "Main")
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
            Prc_AutofillSearch()
        Else

        End If
    End Sub

    Private Sub Prc_AutofillSearch()
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", txtSearch.Text)
                .Parameters.AddWithValue("@p_GBranch", "Main")

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

        Dim reserveCount As Integer = 0
        If cmb_tobranch.Text <> "" Then
            For Each Checkcell As DataGridViewRow In grdMotorcycle.Rows
                'needs to accept only when branches combobox is selected
                If Checkcell.Cells("Column1").Value = True And cmb_tobranch.Text <> " " Then
                    Try
                        With command
                            .Parameters.Clear()
                            .CommandText = "prc_ReserveTo"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.AddWithValue("@p_EngineNum", Checkcell.Cells(6).Value.ToString)
                            .Parameters.AddWithValue("@p_Branch", cmb_tobranch.Text)
                            .Parameters.AddWithValue("@p_dt", Format(dt.Value, "yyyy-MM-dd"))
                            .ExecuteNonQuery()
                        End With
                        With command
                            .Parameters.Clear()
                            .CommandText = "prc_SetUnitDate"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.AddWithValue("@p_EngineNum", Checkcell.Cells(6).Value.ToString)
                            .Parameters.AddWithValue("@p_state", "Reserve")
                            .Parameters.AddWithValue("@p_dt", Format(dt.Value, "yyyy-MM-dd"))
                            .ExecuteNonQuery()
                        End With
                        With command
                            .Parameters.Clear()
                            .CommandText = "prc_Record"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.AddWithValue("@p_Action", "Reserve unit")
                            .Parameters.AddWithValue("@p_d", Format(dt.Value, "yyyy-MM-dd"))
                            .Parameters.AddWithValue("@p_Unit", Checkcell.Cells(6).Value.ToString)
                            .Parameters.AddWithValue("@p_branch", cmb_tobranch.Text)
                            .Parameters.AddWithValue("@p_FromState", "Available")
                            .Parameters.AddWithValue("@p_ToState", "Reserved")
                            .Parameters.AddWithValue("@p_Customer", "none")
                            .Parameters.AddWithValue("@p_Employee", Username)
                            .ExecuteNonQuery()
                        End With
                    Catch ex As Exception
                        MessageBox.Show(" 'Catch' happened", "I think", MessageBoxButtons.OK)
                    End Try
                End If
                Checkcell.Cells("Column1").Value = False
            Next
            MessageBox.Show("unit/s reserved", "reserved", MessageBoxButtons.OK)
        Else
            MessageBox.Show("branch destination not selected", "reservation error", MessageBoxButtons.OK)
        End If
        PrcDisplayAvailableUnits()
        'checked list must be changed state only when reserved
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayStock"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", cmbSearchType.Text)
                .Parameters.AddWithValue("@p_search", txtSearch.Text)
                .Parameters.AddWithValue("@p_GBranch", "Main")
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
        Me.Close()
    End Sub

    'Buttons end
End Class