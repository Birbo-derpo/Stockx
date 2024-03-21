Imports MySql.Data.MySqlClient

Public Class EditEmployee
    Private datUMTC As DataTable


    Private Sub editEmployee()



    End Sub
    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        Try

            If Not txtGmail.Text.Contains("@") Then
                MessageBox.Show("Invalid email address format. Please include '@' sign.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Return
            End If

            If String.IsNullOrWhiteSpace(txtGmail.Text) OrElse String.IsNullOrWhiteSpace(txtFirst.Text) OrElse String.IsNullOrWhiteSpace(txtLast.Text) Then
                MessageBox.Show("Please input all the credentials.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            sqlUMTCAdapter = New MySqlDataAdapter
            datUMTC = New DataTable


            With command
                .Parameters.Clear()
                .CommandText = "prc_EditEmployee"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_Gmail", txtGmail.Text)
                .Parameters.AddWithValue("@p_First", txtFirst.Text)
                .Parameters.AddWithValue("@p_Last", txtLast.Text)
                .Parameters.AddWithValue("@p_Position", cmbPosition.Text)
                .Parameters.AddWithValue("@p_Gender", cmbGender.Text)
                .ExecuteNonQuery()




                MessageBox.Show("Change successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End With






            txtGmail.Clear()
                txtFirst.Clear()
                txtLast.Clear()
                cmbPosition.SelectedIndex = -1
                cmbGender.SelectedIndex = -1

                Me.Dispose()
                Display_Employee.Show()




        Catch ex As Exception

            MessageBox.Show("An error occurred while saving the record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class