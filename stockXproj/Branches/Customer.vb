Imports MySql.Data.MySqlClient

Public Class Customer
    'dataloader
    Private Sub PrcDisplayAllCustomers()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayCustomers"
                .CommandType = CommandType.StoredProcedure
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
                If DataUMTC.Rows.Count > 0 Then
                    grd_AllCustomer.RowCount = DataUMTC.Rows.Count
                    row = 0
                    While Not DataUMTC.Rows.Count - 1 < row
                        If DataUMTC.Rows(row).Item("Brnch").ToString = "Main" Then
                            'skip
                            row = row + 1
                        Else
                            grd_AllCustomer.Rows(row).Cells(0).Value = DataUMTC.Rows(row).Item("L_name").ToString
                            grd_AllCustomer.Rows(row).Cells(1).Value = DataUMTC.Rows(row).Item("F_name").ToString
                            grd_AllCustomer.Rows(row).Cells(2).Value = DataUMTC.Rows(row).Item("Stat").ToString
                            grd_AllCustomer.Rows(row).Cells(3).Value = DataUMTC.Rows(row).Item("Model").ToString
                            grd_AllCustomer.Rows(row).Cells(4).Value = DataUMTC.Rows(row).Item("Color").ToString
                            grd_AllCustomer.Rows(row).Cells(5).Value = DataUMTC.Rows(row).Item("Brnch").ToString
                            grd_AllCustomer.Rows(row).Cells(6).Value = DataUMTC.Rows(row).Item("EngineNum").ToString
                            grd_AllCustomer.Rows(row).Cells(7).Value = DataUMTC.Rows(row).Item("FrameNum").ToString
                            grd_AllCustomer.Rows(row).Cells(8).Value = DataUMTC.Rows(row).Item("TypeOP").ToString
                            grd_AllCustomer.Rows(row).Cells(9).Value = DataUMTC.Rows(row).Item("TermOP").ToString
                            grd_AllCustomer.Rows(row).Cells(10).Value = DataUMTC.Rows(row).Item("Amount_paid").ToString
                            grd_AllCustomer.Rows(row).Cells(11).Value = Format(Convert.ToDateTime(DataUMTC.Rows(row).Item("Date_owned").ToString), "MMM dd, yyyy")
                            grd_AllCustomer.Rows(row).Cells(12).Value = DataUMTC.Rows(row).Item("SIV").ToString

                            row = row + 1
                        End If
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
    'dataloader end
    Private Sub Btn_AllStock_Click(sender As Object, e As EventArgs)
        AllStock.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Released_Click(sender As Object, e As EventArgs)
        Released.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Deposited_Click(sender As Object, e As EventArgs)
        Deposited.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Repossess_Click(sender As Object, e As EventArgs)
        Repossess.Show()
        Me.Hide()
    End Sub

    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrcDisplayAllCustomers()
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click

        With UpdateStocks
            action = "edit"
            .Txt_SIN = grd_AllCustomer.CurrentRow.Cells(12).Value
            .Txt_Fname = grd_AllCustomer.CurrentRow.Cells(1).Value
            .Txt_Lname = grd_AllCustomer.CurrentRow.Cells(0).Value
            .dt = grd_AllCustomer.CurrentRow.Cells(11).Value
            .Txt_Amount = grd_AllCustomer.CurrentRow.Cells(10).Value
            .Cmb_Type = grd_AllCustomer.CurrentRow.Cells(8).Value
            .Cmb_Term = grd_AllCustomer.CurrentRow.Cells(9).Value
            .Cmb_Stat = grd_AllCustomer.CurrentRow.Cells(3).Value
            .ShowDialog()
        End With
    End Sub

    Private Sub grd_AllCustomer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_AllCustomer.CellContentClick

    End Sub
End Class