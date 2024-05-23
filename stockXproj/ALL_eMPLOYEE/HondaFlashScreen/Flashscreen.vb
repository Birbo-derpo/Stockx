Public Class Flashscreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Panel2.Left += 10 ' Adjust the Left property instead of Width

        If (Panel2.Left >= 750) Then ' Check against the desired endpoint

            Timer1.Stop()

            Me.Dispose()
            Dim nextForm As New Login()
            nextForm.Show()
        End If

    End Sub

    Private Sub Flasgscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Left = 0
        Timer1.Start()
    End Sub
End Class