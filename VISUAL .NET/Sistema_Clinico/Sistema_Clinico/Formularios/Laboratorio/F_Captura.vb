Public Class F_Captura
    Private Sub F_Captura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub F_Captura_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        'Form1.Show()
        Me.Opacity = 0
        'CAPTURA DE ZONA
        Dim BM As Bitmap = New Bitmap(Me.Width - 20, Me.Height - 40)
        Dim DIBUJO As Graphics = Graphics.FromImage(BM)
        DIBUJO.CopyFromScreen(Me.Location.X + 10, Me.Location.Y + 40, 0, 0, Screen.PrimaryScreen.Bounds.Size)
        DIBUJO.DrawImage(BM, 0, 0, BM.Width, BM.Height)
        BM.Save(F_AgregarDocumentos.CARPETA & "\" & F_AgregarDocumentos.PACIENTE & ".jpg", Imaging.ImageFormat.Jpeg)
        Dim Logo As String
        Logo = "C:\SystemLetona\PLaboratorio\" & F_AgregarDocumentos.PACIENTE & ".jpg"

        F_AgregarDocumentos.PicFoto.Load(Logo)
        F_AgregarDocumentos.TxtPaciente.Text = F_AgregarDocumentos.PACIENTE
        Form1.Show()
        F_AgregarDocumentos.ShowDialog()

        Me.Close()

    End Sub

    Private Sub F_Captura_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form1.Show()

    End Sub
End Class