Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient


Public Class addnewunits

    Private datUMTC As DataTable
    Dim Mode As String
    Dim selectedModel, selectedColor As String


    Public Sub DisplayModel()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter()
            datUMTC = New DataTable()
            cmbModel.Items.Clear()
            cmbModel.Items.Add("OTHERS")
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
                Dim uniqueModels As New HashSet(Of String)()

                For Each row As DataRow In datUMTC.Rows
                    Dim model As String = row("Model").ToString()
                    If Not uniqueModels.Contains(model) Then
                        cmbModel.Items.Add(model)
                        uniqueModels.Add(model)

                    End If
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

            If datUMTC.Rows.Count > 0 Then
                ' Iterate through each row in the DataTable
                For Each row As DataRow In datUMTC.Rows
                    ' Check if the "Model" column value matches the selected model
                    If row("Model").ToString() = cmbModel.Text Then
                        ' Assuming that the color information is in a column named "Color"
                        ' and price information is in a column named "Price"
                        cmbColor.Items.Add(row("Color").ToString())
                        txtPrice.Text = row("Price").ToString()
                        txtPrice.ReadOnly = True
                        btnSave.Visible = False

                    End If
                Next
            End If

            ' Dispose resources
            sqlUMTCAdapter.Dispose()
            datUMTC.Dispose()

        End If

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
                .Parameters.AddWithValue("@p_price", txtPrice.Text)
                .ExecuteNonQuery()

            End With
            MessageBox.Show("Model Addedd Succesfully", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TxtColor.Clear()
            txtModel.Clear()
            txtPrice.Clear()
            DisplayModel()
            DisplayColor()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub changestat()
        If txtModel.Text <> "" AndAlso cmbModel.SelectedIndex <> -1 Then
            txtPrice.ReadOnly = True
        ElseIf btnedit.Enabled AndAlso txtModel.Text <> "" Then
            txtPrice.ReadOnly = False
        End If
    End Sub

    Private Sub cmbColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColor.SelectedIndexChanged

        Try
            ' Call the DisplayColor function to update the color information
            DisplayColor()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try


            With command
                .Parameters.Clear()
                .CommandText = "prc_EditPrice"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_price", txtPrice.Text)
                .Parameters.AddWithValue("@p_Model", txtModel.Text)

                .ExecuteNonQuery()
                txtPrice.ReadOnly = True
                btnSave.Visible = False
            End With
            MessageBox.Show("Price Change already Save", "Saving Record", MessageBoxButtons.OK, MessageBoxIcon.Information)





        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try


    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        txtPrice.ReadOnly = False
        btnSave.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModel.SelectedIndexChanged
        If cmbModel.SelectedItem IsNot Nothing Then
            selectedModel = cmbModel.SelectedItem.ToString()
            txtModel.Text = selectedModel
            DisplayColor()


            If selectedModel = "OTHERS" Then
                cmbModel.SelectedIndex = -1
                txtModel.Clear()
                txtPrice.Clear()
            End If
        End If

    End Sub
End Class