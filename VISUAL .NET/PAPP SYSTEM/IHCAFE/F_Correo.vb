Imports System.Net
Imports System.Net.Mail

Public Class F_Correo


    Private Sub F_Correo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim mail As New MailMessage

        mail.Subject = txtasunto.Text
        mail.To.Add(txtemisor.Text)
        mail.From = New MailAddress(txtemisor.Text)
        mail.Body = txtmensaje.Text

        Dim SMTP As New SmtpClient("smtp.live.com")
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential(txtemisor.Text, txtcontraseña.Text)
        SMTP.Port = "587"
        SMTP.Send(mail)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class