Public Class F_Fases

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        
        F_Fase1.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Height = 45
        PictureBox3.Width = 45
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Height = 50
        PictureBox3.Width = 50
    End Sub


    Private Sub F_Fases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FasesDataSet.Configuracion' Puede moverla o quitarla según sea necesario.
        Me.ConfiguracionTableAdapter.Fill(Me.FasesDataSet.Configuracion)
        'Dim glass As New rtaGlassEffectsLib.rtaGlassEffect


        'glass.TopBarSize = 60

        'glass.ShowEffect(Me)

        'glass.BottomBarSize = 10
        'glass.LeftBarSize = 10
        'glass.RightBarSize = 10
        'glass.ShowEffect(Me, Label2, PictureBox1)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged


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