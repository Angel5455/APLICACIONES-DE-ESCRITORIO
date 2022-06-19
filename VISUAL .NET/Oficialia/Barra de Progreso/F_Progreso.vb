Public Class F_Progreso

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then


            ProgressBar1.Value = ProgressBar1.Value + 2

            PictureBox1.Left = PictureBox1.Left - 5

        Else

            Timer1.Enabled = False

            F_Contraseña.Show()
            Me.Hide()

        End If
    End Sub
End Class
