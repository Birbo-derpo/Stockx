Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class DashBoard
    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckDatabaseConnection()
        TotalUnits("Main")
        TotalUnits("Bajada")
        TotalUnits("Tagum")
        TotalUnits("Davao")
        TotalUnits("General Santos")
        TotalUnits("Kidapawan")
        TotalUnits("Digos")
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
                    Lbl_Main.Text &= DataUMTC.Rows(row).Item("total")
                Case "Bajada"
                    Lbl_Bajada.Text &= DataUMTC.Rows(row).Item("total")
                Case "Tagum"
                    Lbl_Tagum.Text &= DataUMTC.Rows(row).Item("total")
                Case "Davao"
                    Lbl_Davao.Text &= DataUMTC.Rows(row).Item("total")
                Case "General Santos"
                    Lbl_Gensan.Text &= DataUMTC.Rows(row).Item("total")
                Case "Kidapawan"
                    Lbl_Kidapawan.Text &= DataUMTC.Rows(row).Item("total")
                Case "Digos"
                    Lbl_Digos.Text &= DataUMTC.Rows(row).Item("total")
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
        AllStock.Show()
        Me.Hide()

    End Sub

    Private Sub Btn_Customers_Click(sender As Object, e As EventArgs) Handles Btn_Customers.Click
        Customer.Show()
        Me.Hide()
    End Sub

End Class