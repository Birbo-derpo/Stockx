Imports Google.Apis
Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView

Public Class DashBoard
    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckDatabaseConnection()
        If Login_stat <> True Then
            Login.Show()
            Me.Close()
        Else
            CheckDatabaseConnection()
            prcDisplayCurrentUser()
            TotalUnits("Main")
            TotalUnits("Bajada")
            TotalUnits("Tagum")
            TotalUnits("Davao")
            TotalUnits("General Santos")
            TotalUnits("Kidapawan")
            TotalUnits("Digos")
            Lbl_CurTime.Text = todaysdate
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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login_stat = False
        Username = ""
        HondaHomePage.Show()
        Me.Hide()
    End Sub

    Private Sub btnchange_Click(sender As Object, e As EventArgs) Handles btnchange.Click
        ChangePasswordEmployee.ShowDialog()

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        prcDisplayCurrentUser()

        ' Check if the user data is successfully retrieved
        If Not String.IsNullOrEmpty(Gmail) AndAlso Not String.IsNullOrEmpty(Firstname) AndAlso Not String.IsNullOrEmpty(Lastname) AndAlso Not String.IsNullOrEmpty(Position) Then
            ' Open the EditEmployee form and pass the user information
            Dim changeinto As New EditEmployee()
            changeinto.txtGmail.Text = Gmail
            changeinto.txtFirst.Text = Firstname
            changeinto.txtLast.Text = Lastname
            changeinto.cmbPosition.Text = Position
            changeinto.cmbGender.Text = gender ' Assuming Gender is a global variable or defined elsewhere

            changeinto.ShowDialog()

        Else
            MessageBox.Show("User data not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Lbl_Bajada_Click(sender As Object, e As EventArgs) Handles Lbl_Bajada.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click

    End Sub
End Class