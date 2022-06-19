Public Class F_ContraseñaRespaldo

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If txtusuario.Text = "admin" And txtcontraseña.Text = "545587" Then

            F_Menu.Show()
            Me.Hide()

        Else

            txtusuario.Text = ""
            txtcontraseña.Text = ""
            txtusuario.Focus()
            MsgBox("DATOS INCORRECTOS", MsgBoxStyle.Critical, "IHCAFE")

        End If

    End Sub

    Private Sub OK_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK.MouseEnter
        OK.Height = 70
        OK.Width = 70
    End Sub

    Private Sub OK_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK.MouseLeave
        OK.Height = 75
        OK.Width = 75
    End Sub

    Private Sub Picturebox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picturebox2.Click
        End
    End Sub

    Private Sub Picturebox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Picturebox2.MouseEnter
        Picturebox2.Height = 70
        Picturebox2.Width = 70
    End Sub

    Private Sub Picturebox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Picturebox2.MouseLeave
        Picturebox2.Height = 75
        Picturebox2.Width = 75
    End Sub

    Private Sub F_ContraseñaRespaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class