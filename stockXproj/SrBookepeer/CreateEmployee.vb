Imports MySql.Data.MySqlClient

Public Class CreateEmployee
    Private datUMTC As DataTable
    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click

        Try

            If Not txtGmail.Text.Contains("@") Then
                MessageBox.Show("Invalid email address format. Please include '@' sign.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            sqlUMTCAdapter = New MySqlDataAdapter
            datUMTC = New DataTable


            With command
                .Parameters.Clear()
                .CommandText = "prc_AddEmployee"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_Gmail", txtGmail.Text)
                .Parameters.AddWithValue("@p_password", txtPassword.Text)
                .Parameters.AddWithValue("@p_First", txtFirst.Text)
                .Parameters.AddWithValue("@p_Last", txtLast.Text)
                .Parameters.AddWithValue("@p_Position", cmbPosition.Text)
                .Parameters.AddWithValue("@p_Gender", cmbGender.Text)

                .ExecuteNonQuery()
            End With


            MessageBox.Show("Record successfully saved", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Information)


            txtGmail.Clear()
            txtPassword.Clear()
            txtFirst.Clear()
            txtLast.Clear()
            cmbPosition.SelectedIndex = -1
            cmbGender.SelectedIndex = -1

            Me.Dispose()

        Catch ex As MySqlException

            If ex.Number = 1644 Then
                MessageBox.Show("Email address already exists . Please use a different email address.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("An error occurred while saving the record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

            MessageBox.Show("An error occurred while saving the record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CreateEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login_stat <> True Then
            Login.Show()
            Me.Close()
        Else
            CheckDatabaseConnection()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class