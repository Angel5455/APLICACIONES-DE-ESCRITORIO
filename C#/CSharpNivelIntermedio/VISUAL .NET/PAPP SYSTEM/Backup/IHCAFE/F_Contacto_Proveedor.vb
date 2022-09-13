Imports GoEmail

Public Class F_Contacto_Proveedor

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Dim destino As String = txtpara.Text
        Dim asunto As String = txtasunto.Text
        Dim mensaje As String = txtmensaje.Text
        Dim nombre As String = txtemisor.Text

        Dim gmail As String = txtgmail.Text
        Dim password As String = txtcontraseña.Text

        Dim x As New EnviarEmail()
        Dim exito As Boolean = x.EnviarMail(destino, asunto, mensaje, nombre, gmail, password)

        If exito Then
            MessageBox.Show("Se a enviado el mensaje :)")
        Else
            MessageBox.Show("No se a enviado el mensaje :(")
        End If

    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        Me.txtpara.Text = ""
        Me.txtasunto.Text = ""
        Me.txtmensaje.Text = ""
        txtemisor.Text = ""
        txtgmail.Text = ""
        txtcontraseña.Text = ""

        
    End Sub

    Private Sub F_Contacto_Proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtpara.Text = "angelrpaz@hotmail.com"
    End Sub

    Private Sub PictureBox8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseEnter
        PictureBox8.Height = 55
        PictureBox8.Width = 55

    End Sub

    Private Sub PictureBox8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseLeave
        PictureBox8.Height = 60
        PictureBox8.Width = 60

    End Sub

    Private Sub PictureBox9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseEnter
        PictureBox9.Height = 55
        PictureBox9.Width = 55

    End Sub

    Private Sub PictureBox9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseLeave
        PictureBox9.Height = 60
        PictureBox9.Width = 60

    End Sub
End Class