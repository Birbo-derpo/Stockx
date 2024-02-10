Public Class addMotorcycle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If action = "Insert" Then

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
            Else

                With command
                    .Parameters.Clear()
                    .CommandText = ""
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_invoice", txtInvoiceNumber.Text)
                    .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
                    .Parameters.AddWithValue("@p_model", txtModel.Text)
                    .Parameters.AddWithValue("@p_color", txtColor.Text)
                    .Parameters.AddWithValue("@p_price", txtPrice.Text)
                    .Parameters.AddWithValue("@p_engine", txtEngineNumber.Text)
                    .Parameters.AddWithValue("@p_frame", txtFrameNumber.Text)
                End With
            End If

            MessageBox.Show("Record Successfully Save", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Information)



            Me.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        txtColor.Clear()

        txtEngineNumber.Clear()
        txtFrameNumber.Clear()
        txtInvoiceNumber.Clear()
        txtModel.Clear()
        txtPrice.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class