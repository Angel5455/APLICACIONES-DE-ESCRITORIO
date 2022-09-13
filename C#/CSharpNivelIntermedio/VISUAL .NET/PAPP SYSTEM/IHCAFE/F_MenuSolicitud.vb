Public Class F_MenuSolicitud

    Private Sub F_MenuSolicitud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FasesDataSet.Configuracion' Puede moverla o quitarla según sea necesario.
        Me.ConfiguracionTableAdapter.Fill(Me.FasesDataSet.Configuracion)

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        F_Solicitud.lblNSolicitud.Text = My.Settings.MySolicitud


        Dim total As Integer

        total = Val(F_Solicitud.lblNSolicitud.Text) + 1

        F_Solicitud.lblNSolicitud.Text = total

        F_Solicitud.lblfase.Text = ComboBox1.Text

        F_Solicitud.Show()
        Me.Close()


    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

    End Sub

    Private Sub btnSalir_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSalir.MouseMove
        btnSalir.Visible = False
        btnSalir2.Visible = True
    End Sub

    Private Sub btnSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir2.Click
        btnSalir.Visible = True
        btnSalir2.Visible = False
        Me.Close()
    End Sub

    Private Sub btnSalir2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir2.MouseLeave
        btnSalir.Visible = True
        btnSalir2.Visible = False
    End Sub
End Class