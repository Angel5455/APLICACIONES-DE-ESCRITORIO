Public Class F_Menu_Insumos

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        F_Kardex.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox14_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox14.MouseEnter
        PictureBox14.Height = 61
        PictureBox14.Width = 61
    End Sub

    Private Sub PictureBox14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox14.MouseLeave
        PictureBox14.Height = 66
        PictureBox14.Width = 66
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        F_Stock.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Height = 61
        PictureBox1.Width = 61
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Height = 66
        PictureBox1.Width = 66
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        F_TipoMov.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Height = 61
        PictureBox2.Width = 61
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Height = 66
        PictureBox2.Width = 66
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        F_Etiquetas.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Height = 61
        PictureBox3.Width = 61
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Height = 66
        PictureBox3.Width = 66
    End Sub
End Class