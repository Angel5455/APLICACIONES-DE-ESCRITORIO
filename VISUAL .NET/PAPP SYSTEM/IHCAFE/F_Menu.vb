Imports System.Diagnostics

Public Class F_Menu

    Public cargo As Integer

    Private Sub F_Menu2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblUsuario.Text = F_Contraseña.txtusuario.Text
        lblCargo.Text = F_Contraseña.txtcargo.Text


        If lblCargo.Text = "Administrador" Then
            cargo = 1

        Else
            cargo = 2

        End If

        If F_ContraseñaRespaldo.entrada = True Then

            ADMINISTRACIONToolStripMenuItem.Visible = False
            MAESTROSToolStripMenuItem1.Visible = False
            TRANSACCIONESToolStripMenuItem.Visible = False
            REPORTESToolStripMenuItem.Visible = False
            UTILIDADESToolStripMenuItem.Visible = False
            AYUDAToolStripMenuItem.Visible = False

        Else


            If F_Contraseña.txtcargo.Text = "Administrador" Then

                Me.ADMINISTRACIONToolStripMenuItem.Visible = True
                Me.REPORTESToolStripMenuItem.Visible = True
                Me.ARCHIVOToolStripMenuItem.Visible = True
                Me.AYUDAToolStripMenuItem.Visible = True
                Me.MAESTROSToolStripMenuItem1.Visible = True
                Me.UTILIDADESToolStripMenuItem.Visible = True
                Me.TRANSACCIONESToolStripMenuItem.Visible = True
            Else


                Me.ADMINISTRACIONToolStripMenuItem.Visible = False
                Me.REPORTESToolStripMenuItem.Visible = False
                Me.ARCHIVOToolStripMenuItem.Visible = True
                Me.AYUDAToolStripMenuItem.Visible = True
                Me.MAESTROSToolStripMenuItem1.Visible = True
                Me.UTILIDADESToolStripMenuItem.Visible = True
                Me.TRANSACCIONESToolStripMenuItem.Visible = True


            End If



        End If




    End Sub



    Private Sub F_Menu2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        P_Transacciones.Visible = False
        P_Archivo.Visible = False
        P_Reportes.Visible = False
        P_Utilidades.Visible = False
        'P_Ventanas.Visible = False
        P_Usuarios.Visible = False
        P_Ayuda.Visible = False
        P_Maestros.Visible = False

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

   

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

        F_Fases.lblcargo.Text = cargo
        F_Fases.Show()

    End Sub

    Private Sub ARCHIVOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ARCHIVOToolStripMenuItem.Click
        P_Archivo.Visible = True
        P_Transacciones.Visible = False
        P_Reportes.Visible = True
        P_Maestros.Visible = False
        P_Utilidades.Visible = False
        'P_Ventanas.Visible = False
        P_Usuarios.Visible = False
        P_Ayuda.Visible = False
    End Sub

    Private Sub REPORTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTESToolStripMenuItem.Click
        P_Archivo.Visible = True
        P_Maestros.Visible = True
        P_Transacciones.Visible = True
        P_Reportes.Visible = True
        P_Utilidades.Visible = False
        ' P_Ventanas.Visible = False
        P_Usuarios.Visible = False
        P_Ayuda.Visible = False


    End Sub

    Private Sub UTILIDADESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UTILIDADESToolStripMenuItem.Click

        P_Archivo.Visible = True
        P_Transacciones.Visible = True
        P_Maestros.Visible = True
        P_Reportes.Visible = True
        P_Utilidades.Visible = True
        'P_Ventanas.Visible = False
        P_Usuarios.Visible = False
        P_Ayuda.Visible = False


    End Sub


    Private Sub OPCIONESDEUSUARIOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADMINISTRACIONToolStripMenuItem.Click
        P_Archivo.Visible = True
        P_Maestros.Visible = True
        P_Transacciones.Visible = True
        P_Reportes.Visible = True
        P_Utilidades.Visible = True
        'P_Ventanas.Visible = True
        P_Usuarios.Visible = True
        P_Ayuda.Visible = False
    End Sub

    Private Sub AYUDAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AYUDAToolStripMenuItem.Click
        P_Archivo.Visible = True
        P_Transacciones.Visible = True
        P_Reportes.Visible = True
        P_Maestros.Visible = True
        P_Utilidades.Visible = True
        'P_Ventanas.Visible = True
        P_Usuarios.Visible = True
        P_Ayuda.Visible = True
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "Calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Ficha_Tecnica.Show()

    End Sub



    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "wmplayer.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        F_Usuarios.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        F_Busqueda_Fases.Show()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'R_Fase1_General.Show()

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

        ' F_Menu_Movimientos.txtcargo.Text = cargo
        F_Menu_Movimientos.Show()

    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        F_Backup.Show()

    End Sub

    Private Sub PictureBox9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseEnter
        'PictureBox9.Height = 61
        'PictureBox9.Width = 61

    End Sub

    Private Sub PictureBox9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox9.MouseLeave
        ' PictureBox9.Height = 66
        ' PictureBox9.Width = 66
    End Sub

    Private Sub PictureBox8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click

        F_MovimientosS.PictureBox4.Visible = True
        F_MovimientosS.txtContador.Text = 1
        F_MovimientosS.salir = "R"
        F_MovimientosS.Show()

    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        F_Busqueda_Tablas.Show()

    End Sub


    Private Sub MAESTROSToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MAESTROSToolStripMenuItem1.Click
        P_Maestros.Visible = True
        P_Archivo.Visible = True
        P_Transacciones.Visible = False
        P_Reportes.Visible = True
        P_Maestros.Visible = True
        P_Utilidades.Visible = False
        'P_Ventanas.Visible = False
        P_Usuarios.Visible = False
        P_Ayuda.Visible = False

    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        F_Productores.Show()

    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        F_Historial.Show()

    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click

        F_Articulos.btnSalir2.Visible = False
        F_Articulos.btnSalir.Visible = True

        F_Articulos.Show()

    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        F_Menu_Insumos.Show()

    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        F_Permisos.Show()

    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "iexplore.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub Panel3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        P_Transacciones.Visible = False
        P_Archivo.Visible = False
        P_Reportes.Visible = False
        P_Utilidades.Visible = False
        'P_Ventanas.Visible = False
        P_Usuarios.Visible = False
        P_Ayuda.Visible = False
        P_Maestros.Visible = False
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub LinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel.LinkClicked

        F_Contraseña.txtusuario.Text = ""
        F_Contraseña.txtcontraseña.Text = ""


        F_Contraseña.Popen.Visible = False
        F_Contraseña.Pclose.Visible = True

        Dim resp As Integer
        resp = MsgBox("¿Esta Seguro de Cerrar Sesion?", MsgBoxStyle.YesNo, "P.A.P.P")
        If resp = 6 Then
            REPORTESToolStripMenuItem.Visible = False
            ADMINISTRACIONToolStripMenuItem.Visible = False
            TRANSACCIONESToolStripMenuItem.Visible = False
            UTILIDADESToolStripMenuItem.Visible = False
            MAESTROSToolStripMenuItem1.Visible = False
            Me.Close()
            F_Progreso.Show()
            F_Contraseña.Show()


        End If

    End Sub

    Private Sub Panel3_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub PictureBox21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "Calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub PictureBox22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox22.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "iexplore.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub PictureBox23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox23.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "wmplayer.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub PictureBox24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox24.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "Notepad.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub PictureBox1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        F_CreacionFases.Show()
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        Shell("explorer.exe root=C:\Program Files\IHCAFE\PAPP System\MANUAL.pdf", vbNormalFocus)
    End Sub

    Private Sub PictureBox20_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox20.Click
        F_Busqueda_Agencias.Show()

    End Sub

    Private Sub TRANSACCIONESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRANSACCIONESToolStripMenuItem.Click
        P_Archivo.Visible = True
        P_Maestros.Visible = True

        P_Transacciones.Visible = True

        P_Reportes.Visible = False
        P_Utilidades.Visible = False
        'P_Ventanas.Visible = False
        P_Usuarios.Visible = False
        P_Ayuda.Visible = False

    End Sub

    Private Sub PictureBox25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox25.Click
        Shell("explorer.exe root=C:\Program Files\IHCAFE\PAPP System\IHCAFE.ppsx", vbNormalFocus)
    End Sub

    Private Sub PictureBox26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox26.Click

        F_Pago.txtcargo.Text = cargo
        F_Pago.lblEstado.Text = ""
        F_Pago.Show()

    End Sub

    Private Sub P_Utilidades_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles P_Utilidades.Paint

    End Sub

    Private Sub PictureBox27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox27.Click

        F_MenuSolicitud.Show()


    End Sub

    Private Sub btnSalir_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.MouseLeave

    End Sub

    Private Sub btnSalir_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSalir.MouseMove
        btnSalir.Visible = False
        btnSalir2.Visible = True
    End Sub

    Private Sub btnSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir2.Click
        Dim resp As Integer
        resp = MsgBox("¿Esta Seguro de Salir del Sistema?", MsgBoxStyle.YesNo, "P.A.P.P System")
        If resp = 6 Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSalir2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir2.MouseLeave
        btnSalir2.Visible = False
        btnSalir.Visible = True
    End Sub
End Class