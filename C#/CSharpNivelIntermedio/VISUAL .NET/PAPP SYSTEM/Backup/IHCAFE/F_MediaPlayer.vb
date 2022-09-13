Public Class F_MediaPlayer

    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName


    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim resp As Integer
        resp = MsgBox("¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "System IHCAFE")
        If resp = 6 Then
            Me.Hide()
        End If
    End Sub
End Class