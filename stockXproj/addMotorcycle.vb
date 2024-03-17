Imports MySql.Data.MySqlClient

Public Class addMotorcycle
    Private Sub addMotorcycle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login_stat <> True Then
            Login.Show()
            Me.Close()
        Else
            Predef_model_list()
            Predef_color_list()
        End If

    End Sub
    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Try
            If action = "Insert" And fncCheckEngineNo(txtEngineNumber.Text) = False Then

                With command
                    .Parameters.Clear()
                    .CommandText = "prc_AddMotorcycle"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_invoice", txtInvoiceNumber.Text)
                    .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
                    .Parameters.AddWithValue("@p_model", Cmb_Model.Text)
                    .Parameters.AddWithValue("@p_color", Cmb_Color.Text)
                    .Parameters.AddWithValue("@p_price", txtPrice.Text)
                    .Parameters.AddWithValue("@p_engine", txtEngineNumber.Text)
                    .Parameters.AddWithValue("@p_frame", txtFrameNumber.Text)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Record Successfully Save", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf action = "Edit" Then

                With command
                    .Parameters.Clear()
                    .CommandText = "prc_UpdateMotorcycleByEngineNumber"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_invoice", txtInvoiceNumber.Text)
                    .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
                    .Parameters.AddWithValue("@p_model", Cmb_Model.Text)
                    .Parameters.AddWithValue("@p_color", Cmb_Color.Text)
                    .Parameters.AddWithValue("@p_price", txtPrice.Text)
                    .Parameters.AddWithValue("@p_engine", txtEngineNumber.Text)
                    .Parameters.AddWithValue("@p_frame", txtFrameNumber.Text)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Record Successfully Save", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Engine/Frame number already existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click

        txtEngineNumber.Clear()
        txtFrameNumber.Clear()
        txtInvoiceNumber.Clear()
        txtPrice.Clear()
    End Sub

    Private Sub Btn_close_Click(sender As Object, e As EventArgs) Handles Btn_close.Click
        Me.Dispose()
    End Sub

    Private Sub Btn_AddCateg_Click(sender As Object, e As EventArgs) Handles Btn_AddCateg.Click
        addnewunits.ShowDialog()
    End Sub

    'function methods
    Function fncCheckEngineNo(p_search As String) As Boolean
        Dim result As String

        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable

        With command
            .Parameters.Clear()
            .CommandText = "prc_FindStockDuplicate"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_search", p_search)
            sqlUMTCAdapter.SelectCommand = command
            DataUMTC.Clear()
            sqlUMTCAdapter.Fill(DataUMTC)

            If DataUMTC.Rows.Count > 0 Then
                result = True
            Else
                result = False
            End If
        End With
        sqlUMTCAdapter.Dispose()
        DataUMTC.Dispose()
        Try

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
        Return result
    End Function

    'end function
    Private Sub Predef_model_list()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_predef_inv_details"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_type", "models")
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        Cmb_Model.Items.Add(DataUMTC.Rows(row).Item("Model").ToString)
                        row = row + 1
                    End While
                Else

                End If
            End With

            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
    Private Sub Predef_color_list()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_predef_inv_details"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_type", "colors")
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        Cmb_Color.Items.Add(DataUMTC.Rows(row).Item("Color").ToString)
                        row = row + 1
                    End While
                Else

                End If
            End With

            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Class