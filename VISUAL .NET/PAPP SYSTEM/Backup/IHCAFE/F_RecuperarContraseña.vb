
Imports GoEmail
Public Class F_RecuperarContraseña

  
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim usuario As String = "admin"
        Dim clave As String = "545587"
        Dim angel As String = "angelrpaz54@gmail.com"
        Dim contraseña As String = "lujuria5455"


        Dim destino As String = TextBox1.Text
        Dim asunto As String = "CONTRASEÑA IHCAFE"
        Dim mensaje As String = "Usuario: " & usuario & "  " & "Contraseña: " & clave
        Dim nombre As String = "IHCAFE"
        Dim gmail As String = angel
        Dim password As String = contraseña

        Dim x As New EnviarEmail()
        Dim exito As Boolean = x.EnviarMail(destino, asunto, mensaje, nombre, gmail, password)

        If exito Then
            MessageBox.Show("Se a enviado el mensaje :)")
        Else
            MessageBox.Show("No se a enviado el mensaje :(")
        End If


        Me.Hide()
        F_ContraseñaRespaldo.Show()

        Dim resp As String

        resp = MsgBox ("Desea Abrir el Explorador Web", MsgBoxStyle.YesNo , "System IHCAFE")

        If resp = 6 Then

            F_ExploradorWeb.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Height = 45
        PictureBox1.Width = 45
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Height = 50
        PictureBox1.Width = 50
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        End
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Height = 45
        PictureBox2.Width = 45
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Height = 50
        PictureBox2.Width = 50
    End Sub
End Class