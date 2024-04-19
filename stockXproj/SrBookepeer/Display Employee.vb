Imports MySql.Data.MySqlClient

Public Class Display_Employee

    Dim Position, Gender As String
    Private Sub btn_Create_Click(sender As Object, e As EventArgs) Handles btn_Create.Click
        CreateEmployee.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Display_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
        PrcDisplayEmployee()
    End Sub
    Private Sub PrcDisplayEmployee()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayEmployee"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", Cmb_Filter.Text)
                .Parameters.AddWithValue("@p_search", "")

                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    grdEmployee.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not (DataUMTC.Rows.Count - 1 < row)
                        grdEmployee.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("Gmail").ToString
                        grdEmployee.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("FirstName").ToString
                        grdEmployee.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("LastName").ToString
                        grdEmployee.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("Positions").ToString
                        grdEmployee.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Gender").ToString
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
    Private Sub AutofillSearch()
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayEmployee"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", Cmb_Filter.Text)
                .Parameters.AddWithValue("@p_search", Txt_Search.Text)

                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    grdEmployee.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not (DataUMTC.Rows.Count - 1 < row)
                        grdEmployee.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("Gmail").ToString
                        grdEmployee.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("FirstName").ToString
                        grdEmployee.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("LastName").ToString
                        grdEmployee.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("Positions").ToString
                        grdEmployee.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Gender").ToString
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

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable
        Try

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayEmployee"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_filter", Cmb_Filter.Text)
                .Parameters.AddWithValue("@p_search", Txt_Search.Text)

                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    grdEmployee.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not (DataUMTC.Rows.Count - 1 < row)
                        grdEmployee.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("Gmail").ToString
                        grdEmployee.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("FirstName").ToString
                        grdEmployee.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("LastName").ToString
                        grdEmployee.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("Positions").ToString
                        grdEmployee.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Gender").ToString
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

    Private Sub Chk_Auto_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Auto.CheckedChanged

    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        If Chk_Auto.Checked = True Then
            AutofillSearch()
        Else

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click


        With EditEmployee


            .ShowDialog()



            .txtGmail.Text = grdEmployee.CurrentRow.Cells(0).Value.ToString()
            .txtFirst.Text = grdEmployee.CurrentRow.Cells(1).Value.ToString()
            .txtLast.Text = grdEmployee.CurrentRow.Cells(2).Value.ToString()

            Dim Position As String = grdEmployee.CurrentRow.Cells(3).Value.ToString()
            If Position = "Sr.Bookeeper" Then
                .cmbPosition.Text = "Sr.Bookeeper"
            ElseIf Position = "Inventory Manager" Then
                .cmbPosition.Text = "Inventory Manager"
            End If

            Dim Gender As String = grdEmployee.CurrentRow.Cells(4).Value.ToString()
            If Gender = "Male" Then
                .cmbGender.Text = "Male"
            ElseIf Gender = "Female" Then
                .cmbGender.Text = "Female"
            End If
        End With


    End Sub
End Class