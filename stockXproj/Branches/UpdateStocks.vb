Imports MySql.Data.MySqlClient

Public Class UpdateStocks
    Private Sub UpdateStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If fncCheckOwned(Txt_EngineNumber.Text) = True Then
            MessageBox.Show("Unit Already owned.", "YO how did you?", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            With command
                .Parameters.Clear()
                .CommandText = "prc_ChangeStat"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_EngineNum", Txt_EngineNumber.Text)
                .Parameters.AddWithValue("@p_Stat", Cmb_Stat.Text)
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Me.Close()
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtterm_Click(sender As Object, e As EventArgs) Handles txtterm.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class