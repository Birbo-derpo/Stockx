Imports MySql.Data.MySqlClient

Public Class UpdateStocks
    Private Sub UpdateStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If fncCheckOwned(Txt_EngineNumber.Text) = True Then
            MessageBox.Show("Unit Already owned.", "how did you?", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
        End If
    End Sub

    Function fncCheckOwned(p_EngineNum As String) As Boolean
        Dim result As String

        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable

        With command
            .Parameters.Clear()
            .CommandText = "prc_FindUnitOwned"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_EngineNum", p_EngineNum)
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
    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        Try
            If action = "Update" Then
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
            Else
                With command
                    'for edit
                End With
            End If
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
            MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception

        End Try
        Me.Dispose()
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