Public Class F_ContraseñaRespaldo

    Public entrada As Double

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        '  If txtusuario.Text = "admin" And txtContraseña.Text = F_RecuperarContraseña.TextBox2.Text Then

        If txtusuario.Text = "admin" And txtContraseña.Text = "123" Then

            entrada = True


            F_Menu.Show()

            F_AyudaUsuario.txtcorreo.Text = F_RecuperarContraseña.TextBox1.Text

            F_AyudaUsuario.Show()

            Me.Hide()

        Else

            txtusuario.Text = ""
            txtContraseña.Text = ""
            txtusuario.Focus()
            MsgBox("DATOS INCORRECTOS", MsgBoxStyle.Critical, "IHCAFE")

        End If

    End Sub

    Private Sub OK_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK.MouseEnter
        OK.Height = 50
        OK.Width = 50
    End Sub

    Private Sub OK_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK.MouseLeave
        OK.Height = 45
        OK.Width = 45
    End Sub

    Private Sub Picturebox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picturebox2.Click
        End
    End Sub

    Private Sub Picturebox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Picturebox2.MouseEnter
        Picturebox2.Height = 50
        Picturebox2.Width = 50
    End Sub

    Private Sub Picturebox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Picturebox2.MouseLeave
        Picturebox2.Height = 45
        Picturebox2.Width = 45
    End Sub

    Private Sub F_ContraseñaRespaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class