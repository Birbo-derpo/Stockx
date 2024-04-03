Imports MySql.Data.MySqlClient

Public Class EditEmployee
    Private datUMTC As DataTable

    Private Sub EditEmployeeby()
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
                .CommandText = "prc_EditEmployeeById"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_ID", EmployeeId)
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
            DashBoard.Show()


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
    Private Sub EditEmployee()
        Try
            'Dim isEmployee As Boolean = IsUserEmployee(EmployeeId)


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


            If action = "change" Then
                With command
                    .Parameters.Clear()
                    .CommandText = "prc_EditEmployeeById"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_ID", EmployeeId)
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


            Else

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


            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while saving the record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to change the password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If result = DialogResult.Yes Then

            action = "change"
            EditEmployee()
        Else

            EditEmployee()
        End If
    End Sub

    Private Sub EditEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class