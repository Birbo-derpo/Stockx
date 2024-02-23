Imports MySql.Data.MySqlClient

Public Class UpdateStocks

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click

        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "prc_AddCustomerAndUnit"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@F_name", Txt_Fname.Text)
                .Parameters.AddWithValue("@L_name", Txt_Lname.Text)
                .Parameters.AddWithValue("@p_EngineNo", Txt_EngineNumber.Text)
                .Parameters.AddWithValue("@p_Amount", CDbl(Txt_Amount.Text))
                .Parameters.AddWithValue("@p_TermOE", Cmb_Term.Text)
                .Parameters.AddWithValue("@p_TypeOP", Cmb_Type.Text)
                .Parameters.AddWithValue("@p_SIV", Txt_SIN.Text)
                .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "prc_ChangeStat"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_EngineNum", Txt_EngineNumber.Text)
                .Parameters.AddWithValue("@p_Stat", Cmb_Stat.Text)
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub UpdateStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cmb_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Type.SelectedIndexChanged
        If Cmb_Type.Text = "Installment Plan" Then
            Cmb_Term.Enabled = True
            Cmb_Term.ForeColor = Color.Black
            txtterm.ForeColor = Color.Black
        Else
            Cmb_Term.Enabled = False
            Cmb_Term.Text = "" ' Clear the text inside Cmb_Term
            Cmb_Term.ForeColor = Color.Gray
            txtterm.ForeColor = Color.Gray
        End If
    End Sub

End Class