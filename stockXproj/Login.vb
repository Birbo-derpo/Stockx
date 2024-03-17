Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        Email = Email_Field.Text
        Password = Pass_Field.Text

        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable
            With command
                .Parameters.Clear()
                .CommandText = "prc_Login"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_email", Email)
                .Parameters.AddWithValue("@p_password", Password)
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)
            End With

            If DataUMTC.Rows.Count = 0 Then
                MessageBox.Show("Invalid Username or Password", "Login Details", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Login Success", "Login Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Login_stat = True
            End If

            Email_Field.Clear()
            Pass_Field.Clear()

            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()
        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Pass_Field_TextChanged(sender As Object, e As EventArgs) Handles Pass_Field.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class