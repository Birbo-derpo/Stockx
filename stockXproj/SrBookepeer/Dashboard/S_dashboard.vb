Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.X509

Public Class S_dashboard

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        reports.ShowDialog()

    End Sub

    Private Sub S_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Login_stat <> True Then
            Login.Show()
            Me.Close()
        Else
            CheckDatabaseConnection()
            prcDisplayCurrentUser()
            AllAvialableUnit("Main", "Available")
            AllAvialableUnit("Bajada", "In branch")
            AllAvialableUnit("Tagum", "In branch")
            AllAvialableUnit("Davao", "In branch")
            AllAvialableUnit("General Santos", "In branch")
            AllAvialableUnit("Kidapawan", "In branch")
            AllAvialableUnit("Digos", "In branch")
        End If

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

    Private Sub Btnchange_Click(sender As Object, e As EventArgs) Handles btnchange.Click
        ChangePasswordEmployee.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login_stat = False
        Username = ""
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateEmployee.ShowDialog()
    End Sub


    Private Sub prcDisplayCurrentUser()
        Try
            sqlUMTCAdapter = New MySqlDataAdapter
            DataUMTC = New DataTable

            With command
                .Parameters.Clear()
                .CommandText = "prc_DisplayCurrentUser"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_User", EmployeeId)
                sqlUMTCAdapter.SelectCommand = command
                DataUMTC.Clear()
                sqlUMTCAdapter.Fill(DataUMTC)

                If DataUMTC.Rows.Count > 0 Then
                    Gmail = DataUMTC.Rows(0).Item("Gmail").ToString
                    Firstname = DataUMTC.Rows(0).Item("FirstName").ToString
                    Lastname = DataUMTC.Rows(0).Item("LastName").ToString
                    Position = DataUMTC.Rows(0).Item("Positions").ToString
                    full = Firstname & " " & Lastname

                    lblgmail.Text = "Gmail: " + Gmail
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

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Display_Employee.ShowDialog()

    End Sub

    Private Sub Btn_inv_logs_Click(sender As Object, e As EventArgs) Handles Btn_inv_logs.Click
        Sr_Inventory_Records.ShowDialog()

    End Sub

    Private Sub Btn_MainOffice_Click(sender As Object, e As EventArgs) Handles Btn_MainOffice.Click
        S_MainOffice.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Branches_Click(sender As Object, e As EventArgs) Handles Btn_Branches.Click
        S_AllUnit.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Btn_Customers_Click(sender As Object, e As EventArgs) Handles Btn_Customers.Click
        S_customer.Show()
        Me.Close()

    End Sub
End Class