Imports MySql.Data.MySqlClient

Public Class getCustomerts


    Private Sub PrcDisplayAllCustomers()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_GetCustomer"
                .CommandType = CommandType.StoredProcedure
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    grd_GetCustomer.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row

                        grd_GetCustomer.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("L_name").ToString
                        grd_GetCustomer.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("F_name").ToString
                        grd_GetCustomer.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("Amount_paid").ToString
                        grd_GetCustomer.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("Payment_Status").ToString


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
    Private Sub btn_AddCustomer_Click(sender As Object, e As EventArgs) Handles btn_AddCustomer.Click
        With UpdateStocks

            .Txt_Fname.Text = grd_GetCustomer.CurrentRow.Cells(0).Value.ToString()
            .Txt_Lname.Text = grd_GetCustomer.CurrentRow.Cells(1).Value.ToString()
        End With
        Me.Close()



    End Sub

    Private Sub getCustomerts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckDatabaseConnection()
        PrcDisplayAllCustomers()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class