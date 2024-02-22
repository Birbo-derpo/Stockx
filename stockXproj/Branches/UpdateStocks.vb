Public Class UpdateStocks
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Term.SelectedIndexChanged

    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click

        Try
            With command
                .Parameters.Clear()
                .CommandText = "prc_AddMotorcycle"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_Name", Txt_Name.Text)
                .Parameters.AddWithValue("@p_EngineNo", Txt_EngineNumber.Text)
                .Parameters.AddWithValue("@p_Amount", CDbl(Txt_Amount.Text))
                .Parameters.AddWithValue("@p_TermOE", Cmb_Term.Text)
                .Parameters.AddWithValue("@p_TypeOP", Cmb_Type.Text)
                .Parameters.AddWithValue("@p_SIV", Txt_SIN.Text)
                .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
        End Try
        Try
            With command
                .Parameters.Clear()
                .CommandText = "prc_ChangeStat"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_EngineNum", Txt_EngineNumber.Text)
                .Parameters.AddWithValue("@p_Stat", Cmb_Stat.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
        End Try
    End Sub
End Class