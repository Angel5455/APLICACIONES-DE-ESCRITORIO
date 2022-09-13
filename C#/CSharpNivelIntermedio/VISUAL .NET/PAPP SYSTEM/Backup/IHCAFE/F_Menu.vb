Public Class F_Menu

    Private Sub F_Menu2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub APLICACIONESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APLICACIONESToolStripMenuItem.Click
        P_Aplicaciones.Visible = True
        P_Archivo.Visible = True
        P_Reportes.Visible = False
        P_Utilidades.Visible = False
        'P_Ventanas.Visible = False
        P_Usuarios.Visible = False
        P_Ayuda.Visible = False

    End Sub

    Private Sub F_Menu2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        P_Aplicaciones.Visible = False
        P_Archivo.Visible = False
        P_Reportes.Visible = False
        P_Utilidades.Visible = False
        'P_Ventanas.Visible = False
        P_Usuarios.Visible = False
        P_Ayuda.Visible = False
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        Dim resp As Integer
        resp = MsgBox("¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "System IHCAFE")
        If resp = 6 Then
            End
        End If

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

        F_Fases.Show()

    End Sub

    Private Sub ARCHIVOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ARCHIVOToolStripMenuItem.Click
        P_Archivo.Visible = True
        P_Aplicaciones.Visible = False
        P_Reportes.Visible = True
        P_Utilidades.Visible = False
        'P_Ventanas.Visible = False
        P_Usuarios.Visible = False
        P_Ayuda.Visible = False
    End Sub

    Private Sub APLICACIONESToolStripMenuItem_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles APLICACIONESToolStripMenuItem.MouseMove

    End Sub

    Private Sub REPORTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTESToolStripMenuItem.Click
        P_Archivo.Visible = True
        P_Aplicaciones.Visible = True
        P_Reportes.Visible = True
        P_Utilidades.Visible = False
        ' P_Ventanas.Visible = False
        P_Usuarios.Visible = False
        P_Ayuda.Visible = False
    End Sub

    Private Sub UTILIDADESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UTILIDADESToolStripMenuItem.Click
        P_Archivo.Visible = True
        P_Aplicaciones.Visible = True
        P_Reportes.Visible = True
        P_Utilidades.Visible = True
        'P_Ventanas.Visible = False
        P_Usuarios.Visible = False
        P_Ayuda.Visible = False

    End Sub

    Private Sub VENTANASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        P_Archivo.Visible = True
        P_Aplicaciones.Visible = True
        P_Reportes.Visible = True
        P_Utilidades.Visible = True
        'P_Ventanas.Visible = True
        P_Usuarios.Visible = False
        P_Ayuda.Visible = False
    End Sub

    Private Sub OPCIONESDEUSUARIOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPCIONESDEUSUARIOSToolStripMenuItem.Click
        P_Archivo.Visible = True
        P_Aplicaciones.Visible = True
        P_Reportes.Visible = True
        P_Utilidades.Visible = True
        'P_Ventanas.Visible = True
        P_Usuarios.Visible = True
        P_Ayuda.Visible = False
    End Sub

    Private Sub AYUDAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AYUDAToolStripMenuItem.Click
        P_Archivo.Visible = True
        P_Aplicaciones.Visible = True
        P_Reportes.Visible = True
        P_Utilidades.Visible = True
        'P_Ventanas.Visible = True
        P_Usuarios.Visible = True
        P_Ayuda.Visible = True
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click

        Dim resp As Integer
        resp = MsgBox("¿Deseas continuar?", MsgBoxStyle.YesNo, "NOTA: Debes tener cuenta en Gmail......")
        If resp = 6 Then
            F_Contacto_Proveedor.show()

        End If

    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Ficha_Tecnica.Show()

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        F_BlocNotas.show()

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        F_MediaPlayer.show()

    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        F_Usuarios.Show()

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        F_MenuReportes.Show()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'R_Fase1_General.Show()

    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click

        F_Factura.txtContador.Text = 0
        F_Factura.btnNuevo.Visible = True
        F_Factura.btnNoNuevo.Visible = False
        F_Factura.Show()

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        F_Inventario.Show()

    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        F_Respaldos.Show()

    End Sub

    Private Sub PictureBox9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseEnter
        'PictureBox9.Height = 61
        'PictureBox9.Width = 61

    End Sub

    Private Sub PictureBox9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseLeave
        ' PictureBox9.Height = 66
        ' PictureBox9.Width = 66
    End Sub
End Class