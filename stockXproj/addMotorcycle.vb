Imports MySql.Data.MySqlClient

Public Class addMotorcycle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Try
            If action = "Insert" And fncCheckEngineNo("EngineNum", txtEngineNumber.Text) = False And fncCheckEngineNo("FrameNum", txtFrameNumber.Text) = False Then

                With command
                    .Parameters.Clear()
                    .CommandText = "prc_AddMotorcycle"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_invoice", txtInvoiceNumber.Text)
                    .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
                    .Parameters.AddWithValue("@p_model", txtModel.Text)
                    .Parameters.AddWithValue("@p_color", txtColor.Text)
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
                    .Parameters.AddWithValue("@p_model", txtModel.Text)
                    .Parameters.AddWithValue("@p_color", txtColor.Text)
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        txtColor.Clear()

        txtEngineNumber.Clear()
        txtFrameNumber.Clear()
        txtInvoiceNumber.Clear()
        txtModel.Clear()
        txtPrice.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_close.Click
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_AddCateg.Click
        addnewunits.ShowDialog()
    End Sub

    'function methods
    Function fncCheckEngineNo(p_filter As String, p_search As String) As Boolean
        Dim result As String

        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable

        With command
            .Parameters.Clear()
            .CommandText = "prc_FindStockDuplicate"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_filter", p_filter)
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

    Private Sub addMotorcycle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'end function

End Class