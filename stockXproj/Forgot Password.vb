Imports System
Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Net.Mail
Imports System.Security.Cryptography
Imports Mysqlx.Session

Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Gmail.v1
Imports Google.Apis.Gmail.v1.Data
Imports Google.Apis.Services



Public Class Forgot_Password

    Dim gmail, from, Pass, MessageBody, randomCode As String

    Private Sub Forgot_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click

        If (txtcode.Text.Equals(randomCode)) Then
            Dim reset As Reset = New Reset()
            change.txtgmail.Text = txtGmail.Text.Trim()
            change.Show()

            Me.Hide()
        Else
            MessageBox.Show("Invalid code. Please try again.")


        End If
    End Sub

    Private Sub btnSendCode_Click(sender As Object, e As EventArgs) Handles btnSendCode.Click
        gmail = txtGmail.Text.Trim()

        ' Generate a random verification code
        Dim rand As New Random()
        randomCode = rand.Next(100000, 999999).ToString()

        ' Send email with the verification code
        Dim messageBody As String = "Your reset code is " + randomCode

        from = txtGmail.Text.Trim()
        Pass = txtPassword.Text.Trim() ' Use the real-time password entered by the user

        Dim message As New MailMessage()
        Dim smtp As New SmtpClient()

        Try
            message.From = New MailAddress(from)
            message.[To].Add(gmail)
            message.Subject = "Password Reset Code"
            message.Body = messageBody

            smtp.Port = 587
            smtp.Host = "smtp.gmail.com"
            smtp.EnableSsl = True ' Enable SSL/TLS encryption
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New Net.NetworkCredential(from, Pass)
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network
            smtp.Send(message)

            MessageBox.Show("Please check your email and enter the code in the textbox")
        Catch ex As Exception
            MessageBox.Show("Failed to send email: " & ex.Message)
        End Try
    End Sub


End Class