Public Class F_MenuReportes

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

      
    End Sub

    
    Private Sub F_MenuReportes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Local_FasesDataSet.Configuracion' Puede moverla o quitarla según sea necesario.
        Me.ConfiguracionTableAdapter1.Fill(Me.Local_FasesDataSet.Configuracion)
        'TODO: esta línea de código carga datos en la tabla 'FasesDataSet.Configuracion' Puede moverla o quitarla según sea necesario.
        Me.ConfiguracionTableAdapter.Fill(Me.FasesDataSet.Configuracion)

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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

    End Sub

    Private Sub btnSalir_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSalir.MouseMove
        btnSalir.Visible = False
        btnSalir2.Visible = True
    End Sub
End Class