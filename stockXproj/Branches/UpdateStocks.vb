Imports MySql.Data.MySqlClient

Public Class UpdateStocks

    Private Sub UpdateStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login_stat <> True Then
            Login.Show()
            Me.Close()
        Else

        End If

    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        Try
            If action = "Update" Then
                With command
                    .Parameters.Clear()
                    .CommandText = "prc_Transact"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_FName", Txt_Fname.Text)
                    .Parameters.AddWithValue("@p_LName", Txt_Lname.Text)
                    .Parameters.AddWithValue("@p_Amount", CDbl(Txt_Amount.Text))
                    .Parameters.AddWithValue("@p_TermOP", Cmb_Term.Text)
                    .Parameters.AddWithValue("@p_TypeOP", Cmb_Type.Text)
                    .Parameters.AddWithValue("@p_SIV", Txt_SIN.Text)
                    .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
                    .Parameters.AddWithValue("@p_EngineNo", Txt_EngineNumber.Text)
                    .Parameters.AddWithValue("@p_PaymentStatus", txt_PaymentStatus.Text)
                    .ExecuteNonQuery()
                End With
                With command
                    .Parameters.Clear()
                    .CommandText = "prc_Record"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_Action", "Transfer unit")
                    .Parameters.AddWithValue("@p_d", Format(dt.Value, "yyyy-MM-dd"))
                    .Parameters.AddWithValue("@p_Unit", Txt_EngineNumber.Text)
                    .Parameters.AddWithValue("@p_branch", lbl_branch.Text)
                    .Parameters.AddWithValue("@p_FromState", "In branch")
                    .Parameters.AddWithValue("@p_ToState", Cmb_Stat.Text)
                    .Parameters.AddWithValue("@p_Customer", Txt_Fname.Text + " " + Txt_Lname.Text)
                    .Parameters.AddWithValue("@p_Employee", Username)
                    .ExecuteNonQuery()
                End With
                MessageBox.Show("Transaction success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ElseIf action = "edit" Then
                With command
                    .Parameters.Clear()
                    .CommandText = "prc_editTransac"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_id", Cust_id)
                    .Parameters.AddWithValue("@p_FName", Txt_Fname.Text)
                    .Parameters.AddWithValue("@p_LName", Txt_Lname.Text)
                    .Parameters.AddWithValue("@p_Amount", CDbl(Txt_Amount.Text))
                    .Parameters.AddWithValue("@p_TermOP", Cmb_Term.Text)
                    .Parameters.AddWithValue("@p_TypeOP", Cmb_Type.Text)
                    .Parameters.AddWithValue("@p_SIV", Txt_SIN.Text)
                    .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
                End With
                With command
                    .Parameters.Clear()
                    .CommandText = "prc_Record"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_Action", "Edit Transferred unit")
                    .Parameters.AddWithValue("@p_d", Format(dt.Value, "yyyy-MM-dd"))
                    .Parameters.AddWithValue("@p_Unit", Txt_EngineNumber.Text)
                    .Parameters.AddWithValue("@p_branch", lbl_branch.Text)
                    .Parameters.AddWithValue("@p_FromState", Lbl_Stat.Text)
                    .Parameters.AddWithValue("@p_ToState", Cmb_Stat.Text)
                    .Parameters.AddWithValue("@p_Customer", Txt_Fname.Text + " " + Txt_Lname.Text)
                    .Parameters.AddWithValue("@p_Employee", Username)
                    .ExecuteNonQuery()
                End With
            End If

            With command
                .Parameters.Clear()
                .CommandText = "prc_ChangeStat"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_EngineNum", Txt_EngineNumber.Text)
                .Parameters.AddWithValue("@p_Stat", Cmb_Stat.Text)
                .Parameters.AddWithValue("@p_dd", Format(dt.Value, "yyyy-MM-dd"))
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("hmmmmm.", "Success?", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        Me.Close()
    End Sub

    Private Sub Cmb_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Type.SelectedIndexChanged
        If Cmb_Type.Text = "Installment Plan" Then
            Cmb_Term.Enabled = True
            Cmb_Term.ForeColor = Color.Black
            txtterm.ForeColor = Color.Black
            txt_PaymentStatus.Text = "OnGoing"
        Else
            Cmb_Term.Enabled = False
            Cmb_Term.Text = "" ' Clear the text inside Cmb_Term
            Cmb_Term.ForeColor = Color.Gray
            txtterm.ForeColor = Color.Gray
            txt_PaymentStatus.Text = "Fully Paid"
        End If
    End Sub


End Class