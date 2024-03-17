Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class DashBoard
    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Login_stat <> True Then
            Login.Show()
            Me.Close()
        Else
            CheckDatabaseConnection()
            TotalUnits("Main")
            TotalUnits("Bajada")
            TotalUnits("Tagum")
            TotalUnits("Davao")
            TotalUnits("General Santos")
            TotalUnits("Kidapawan")
            TotalUnits("Digos")
        End If

    End Sub
    Private Sub TotalUnits(p_Branch As String)
        sqlUMTCAdapter = New MySqlDataAdapter
        DataUMTC = New DataTable

        With command
            .Parameters.Clear()
            .CommandText = "prc_TotalUnitPerBranch"
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@p_Branch", p_Branch)
            sqlUMTCAdapter.SelectCommand = command
            DataUMTC.Clear()
            sqlUMTCAdapter.Fill(DataUMTC)

            Select Case p_Branch
                Case "Main"
                    Lbl_Main.Text &= DataUMTC.Rows(0).Item("total")
                Case "Bajada"
                    Lbl_Bajada.Text &= DataUMTC.Rows(0).Item("total")
                Case "Tagum"
                    Lbl_Tagum.Text &= DataUMTC.Rows(0).Item("total")
                Case "Davao"
                    Lbl_Davao.Text &= DataUMTC.Rows(0).Item("total")
                Case "General Santos"
                    Lbl_Gensan.Text &= DataUMTC.Rows(0).Item("total")
                Case "Kidapawan"
                    Lbl_Kidapawan.Text &= DataUMTC.Rows(0).Item("total")
                Case "Digos"
                    Lbl_Digos.Text &= DataUMTC.Rows(0).Item("total")
            End Select

        End With
        sqlUMTCAdapter.Dispose()
        DataUMTC.Dispose()
    End Sub
    Private Sub Btn_MainOffice_Click(sender As Object, e As EventArgs) Handles Btn_MainOffice.Click
        MainBranchInventory.Show()
        Me.Hide()

    End Sub

    Private Sub Btn_Branches_Click(sender As Object, e As EventArgs) Handles Btn_Branches.Click
        All_Unit.Show()
        Me.Hide()

    End Sub

    Private Sub Btn_Customers_Click(sender As Object, e As EventArgs) Handles Btn_Customers.Click
        Customer.Show()
        Me.Hide()
    End Sub

    Private Sub Lbl_Tagum_Click(sender As Object, e As EventArgs) Handles Lbl_Tagum.Click

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Employee_Loginstat = False
        HondaHomePage.Show()
        Me.Hide()
    End Sub
End Class