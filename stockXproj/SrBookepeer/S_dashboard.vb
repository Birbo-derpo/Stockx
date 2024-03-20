Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class S_dashboard


    Dim Gmail, Firstname, Lastname, Position, full As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        reports.Show()
        Me.Close()

    End Sub

    Private Sub S_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
        prcDisplayCurrentUser()
        AllAvialableUnit("Main", "Available")
        AllAvialableUnit("Bajada", "In branch")
        AllAvialableUnit("Tagum", "In branch")
        AllAvialableUnit("Davao", "In branch")
        AllAvialableUnit("General Santos", "In branch")
        AllAvialableUnit("Kidapawan", "In branch")
        AllAvialableUnit("Digos", "In branch")

    End Sub
    Private Sub AllAvialableUnit(p_Branch As String, p_Status As String)
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable

        With command
            .Parameters.Clear()
            .CommandText = "prc_AllAvailableUnitPerBranch"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_Branch", p_Branch)
            .Parameters.AddWithValue("@p_Status", p_Status)

            sqlUMTCAdapter.SelectCommand = command
            DataUMTC.Clear()
            sqlUMTCAdapter.Fill(DataUMTC)
            If DataUMTC.Rows.Count > 0 Then
                Select Case p_Branch
                    Case "Bajada", "Tagum", "Davao", "General Santos", "Kidapawan", "Digos", "Main"
                        Dim totalUnits As String = DataUMTC.Rows(0).Item("total").ToString()
                        Select Case p_Branch
                            Case "Bajada"
                                Lbl_Bajada.Text &= totalUnits
                            Case "Tagum"
                                Lbl_Tagum.Text &= totalUnits
                            Case "Davao"
                                Lbl_Davao.Text &= totalUnits
                            Case "General Santos"
                                Lbl_Gensan.Text &= totalUnits
                            Case "Kidapawan"
                                Lbl_Kidapawan.Text &= totalUnits
                            Case "Digos"
                                Lbl_Digos.Text &= totalUnits
                            Case "Main"
                                Lbl_Main.Text &= totalUnits
                        End Select
                End Select
            End If
        End With
        sqlUMTCAdapter.Dispose()
        DataUMTC.Dispose()

    End Sub

    Private Sub Lbl_Main_Click(sender As Object, e As EventArgs) Handles Lbl_Main.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Employee_Loginstat = False
        HondaHomePage.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateEmployee.ShowDialog()
        Me.Hide()
    End Sub


    Private Sub prcDisplayCurrentUser()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayCurrentUser"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_User", lblgmail.Text)
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)

                If DataUMTC.Rows.Count > 0 Then
                    Gmail = DataUMTC.Rows(0).Item("Gmail").ToString
                    Firstname = DataUMTC.Rows(0).Item("FirstName").ToString
                    Lastname = DataUMTC.Rows(0).Item("LastName").ToString
                    Position = DataUMTC.Rows(0).Item("Positions").ToString
                    full = Firstname & " " & Lastname

                    lblgmail.Text = "Gmail:" + Gmail
                    lblUser.Text = "User: " + full
                    lblPositionn.Text = "Position: " + Position

                Else
                    MessageBox.Show("User data not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With




            sqlUMTCAdapter.Dispose()
            DataUMTC.Dispose()

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub
End Class