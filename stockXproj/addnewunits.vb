Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class addnewunits

    Private datUMTC As DataTable
    Dim Mode As String
    Dim selectedModel, selectedColor As String

    Public Sub DisplayModel()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter()
            datUMTC = New DataTable()

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayModel"
                .CommandType = CommandType.StoredProcedure

                sqlUMTCAdapter.SelectCommand = command
                datUMTC.Clear()
                sqlUMTCAdapter.Fill(datUMTC)
            End With


            ' Check if DataTable has rows
            If datUMTC.Rows.Count > 0 Then
                For Each row As DataRow In datUMTC.Rows
                    cmbModel.Items.Add(row("Model").ToString())
                Next
            End If

            ' Dispose resources
            sqlUMTCAdapter.Dispose()
            datUMTC.Dispose()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try



    End Sub

   Private Sub DisplayColor()
        Try
            ' Ensure there's a selected model in the ComboBox
            If Not String.IsNullOrEmpty(cmbModel.Text) Then
                ' Clear existing items in ComboBox
                cmbColor.Items.Clear()

                sqlUMTCAdapter = New MySqlDataAdapter()
                datUMTC = New DataTable()

                With command
                    .Parameters.Clear()
                    .CommandText = "prc_DisplayAllColors"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_model", cmbModel.Text)
                    sqlUMTCAdapter.SelectCommand = command
                    datUMTC.Clear()
                    sqlUMTCAdapter.Fill(datUMTC)
                End With

                ' Check if any data is returned
                If datUMTC.Rows.Count > 0 Then
                    ' Filter colors based on the selected model
                    Dim filteredRows() As DataRow = datUMTC.Select("Model = '" & cmbModel.Text & "'")
                    For Each row As DataRow In filteredRows
                        ' Assuming that the color information is in a column named "Color"
                        cmbColor.Items.Add(row("Color").ToString())
                    Next
                Else
                    MessageBox.Show("No color information found for selected model " & cmbModel.Text)
                End If

                ' Dispose resources
                sqlUMTCAdapter.Dispose()
                datUMTC.Dispose()

            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub







    Private Sub addnewunits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
        DisplayModel()
        DisplayColor()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtModel.Text = "" Then
                MessageBox.Show("Please Input a Model", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf TxtColor.Text = "" Then
                MessageBox.Show("Please Input a Color", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            With command
                .Parameters.Clear()
                .CommandText = "prc_InsertModelandColor"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_Model", txtModel.Text)
                .Parameters.AddWithValue("@p_color", TxtColor.Text)
                .ExecuteNonQuery()

            End With
            MessageBox.Show("Model Addedd Succesfully", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TxtColor.Clear()
            txtModel.Clear()
            DisplayModel()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cmbColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColor.SelectedIndexChanged

        Try
            ' Call the DisplayColor function to update the color information
            DisplayColor()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModel.SelectedIndexChanged
        If cmbModel.SelectedItem IsNot Nothing Then
            selectedModel = cmbModel.SelectedItem.ToString()
            txtModel.Text = selectedModel

            If selectedModel = "OTHERS" Then
                cmbModel.SelectedIndex = -1
                txtModel.Clear()
            End If
        End If
    End Sub
End Class