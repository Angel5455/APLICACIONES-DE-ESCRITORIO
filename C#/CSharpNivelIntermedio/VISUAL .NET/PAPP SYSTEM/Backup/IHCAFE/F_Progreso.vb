Imports System.IO


Public Class F_Progreso

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If pgbCargar.Value < 400 Then
            pgbCargar.Value = pgbCargar.Value + 25
        Else

            Timer1.Enabled = False
            F_Contraseña.Show()
            Me.Hide()


        End If


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub F_Progreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxShockwaveFlash1.LoadMovie(0, Path.GetFullPath("cargador20.swf"))

    End Sub



    Private Sub PictureBox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AxShockwaveFlash1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxShockwaveFlash1.Enter

    End Sub
End Class
