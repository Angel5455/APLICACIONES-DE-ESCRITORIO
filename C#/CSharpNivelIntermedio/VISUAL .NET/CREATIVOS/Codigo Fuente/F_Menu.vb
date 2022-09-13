Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class F_Menu

    Dim resultado As MsgBoxResult
    Public entrada As Integer

    Private Sub TicketsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TicketsToolStripMenuItem.Click

    End Sub

    Private Sub GeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



        F_Empleados.Show()

    End Sub

    Private Sub InventarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        F_Inventario.accion = True
        F_Inventario.Show()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click

        Dim resp As String = MsgBox("¿Desea Salir de la Aplicacion?", MsgBoxStyle.YesNo, "CREATIVOS")

        If resp = 6 Then

            End

        End If


    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        resultado = CType(MessageBox.Show("¿Desea Salir de la Aplicacion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation), MsgBoxResult)


        If resultado = MsgBoxResult.No Then

            e.Cancel = True

        Else

            End

        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       

        If My.Settings.MOculto = 1 Then

            BanersToolStripMenuItem.Visible = False
            RecibosToolStripMenuItem.Visible = False
            CotizacionesToolStripMenuItem.Visible = False
            UsuariosToolStripMenuItem.Visible = False
            PrestamosToolStripMenuItem.Visible = False
            RECARGASToolStripMenuItem.Visible = False
            REPORTESYCONSULTASToolStripMenuItem.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            EmpleadosToolStripMenuItem.Visible = False
            UsuariosToolStripMenuItem.Visible = False
            DeduccionesToolStripMenuItem.Visible = False
            PictureBox4.Visible = False

        Else
            BanersToolStripMenuItem.Visible = True
            RecibosToolStripMenuItem.Visible = True
            CotizacionesToolStripMenuItem.Visible = True
            UsuariosToolStripMenuItem.Visible = True
            PrestamosToolStripMenuItem.Visible = True
            RECARGASToolStripMenuItem.Visible = True
            REPORTESYCONSULTASToolStripMenuItem.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            EmpleadosToolStripMenuItem.Visible = True
            UsuariosToolStripMenuItem.Visible = True
            DeduccionesToolStripMenuItem.Visible = True
            PictureBox4.Visible = True

        End If



        lblUsuario.Text = My.Settings.MyUsuarios


        If My.Settings.MyUsuarios <> "" Then

            lblUsuario.Text = My.Settings.MyUsuarios
        Else

            F_Contraseña.Show()
            Me.Hide()




        End If




        If F_Tickets.entrada = 1 Then
            F_Tickets.Show()

        End If

        lblFecha.Text = Format(Now(), "dd/MM/yyyy")
        Timer1.Start()



        If F_Contraseña.ComboBox1.Text = "T.S." Then

            BanersToolStripMenuItem.Visible = False
            RecibosToolStripMenuItem.Visible = False
            CotizacionesToolStripMenuItem.Visible = False
            UsuariosToolStripMenuItem.Visible = False
            PrestamosToolStripMenuItem.Visible = False
            RECARGASToolStripMenuItem.Visible = False
            REPORTESYCONSULTASToolStripMenuItem.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            EmpleadosToolStripMenuItem.Visible = False
            UsuariosToolStripMenuItem.Visible = False
            DeduccionesToolStripMenuItem.Visible = False
            PictureBox4.Visible = False

        End If


    End Sub


    Private Sub lblcargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub LinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel.LinkClicked
        Me.Hide()
        lblUsuario.Text = ""

        F_Contraseña.txtusuario.Text = ""
        F_Contraseña.txtcontraseña.Text = ""
        'F_Contraseña.txtEncrip.Text = ""

        My.Settings.MyUsuarios = ""
        My.Settings.Save()
        My.Settings.Reload()


        F_Contraseña.Show()


    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblHora.Text = TimeOfDay
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        F_Usuarios.Show()
    End Sub

    Private Sub CLIENTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLIENTESToolStripMenuItem.Click
        F_Clientes.Show()

    End Sub

    Private Sub CONTROLDERECARGASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CONTROLDERECARGASToolStripMenuItem.Click

    End Sub

    Private Sub CONTROLDECREDITOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        F_BuscarCredito.Show()

    End Sub

    Private Sub PorEmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorEmpleadoToolStripMenuItem.Click
        F_ConsultaEmpleados.Show()
    End Sub

    Private Sub GeneralToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralToolStripMenuItem2.Click
        R_General.Show()
    End Sub

    Private Sub BuscarTicketToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarTicketToolStripMenuItem1.Click
        F_BuscarTicket.Show()
    End Sub



    Private Sub CreditosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        R_CreditosR.Show()

    End Sub



    Private Sub TIGOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIGOToolStripMenuItem.Click

        F_ControlRecargas.Show()
        Me.Hide()


    End Sub

    Private Sub CLAROToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLAROToolStripMenuItem.Click
        F_Control_Recargas_Claro.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        F_Control_Recargas_Claro.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Height = 160
        PictureBox2.Width = 160
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Height = 150
        PictureBox2.Width = 150
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        F_ControlRecargas.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Height = 160
        PictureBox3.Width = 160
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Height = 150
        PictureBox3.Width = 150
    End Sub

    Private Sub TIGOToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIGOToolStripMenuItem1.Click
        R_GeneralR.Show()
    End Sub

    Private Sub GeneralToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralToolStripMenuItem.Click

    End Sub

    Private Sub PorCierreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorCierreToolStripMenuItem.Click

    End Sub

    Private Sub CLAROToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLAROToolStripMenuItem1.Click
        R_GeneralC.Show()
    End Sub

    Private Sub RECARGASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECARGASToolStripMenuItem.Click

    End Sub

    Private Sub RecibosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibosToolStripMenuItem.Click

        F_Anombre.Show()



    End Sub

    Private Sub RecibosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecibosToolStripMenuItem1.Click

        F_BuscarRecibo.Show()

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

        F_MenuRecibo.Show()


    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Height = 160
        PictureBox4.Width = 160
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Height = 150
        PictureBox4.Width = 150
    End Sub

    Private Sub BanersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BanersToolStripMenuItem.Click
        F_Banners.Show()

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        F_Tickets.txtcodigo.Text = "000"
        F_Tickets.txtnombre.Text = lblUsuario.Text
        F_Tickets.Show()


    End Sub

    Private Sub PictureBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Height = 160
        PictureBox5.Width = 160
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Height = 150
        PictureBox5.Width = 150
    End Sub


    Private Sub TicketToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TicketToolStripMenuItem.Click
        F_Tickets.txtnombre.Text = lblUsuario.Text
        F_Tickets.Show()




    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem.Click
        F_Empleados.Show()
    End Sub

    Private Sub DeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeToolStripMenuItem.Click
        F_Inventario.Show()

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CotizacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CotizacionesToolStripMenuItem.Click
        F_Cotizaciones.Show()
    End Sub

    Private Sub GeneralToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralToolStripMenuItem1.Click
        R_CotGeneral.Show()

    End Sub

    Private Sub BuscarCotizacionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarCotizacionToolStripMenuItem.Click
        F_BuscarCotizacion.Show()

    End Sub

    Private Sub DeduccionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeduccionesToolStripMenuItem.Click
        F_Deduccciones.Show()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Factura.Show()

    End Sub

    Private Sub PrestamosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrestamosToolStripMenuItem.Click
        F_Prestamos.Show()

    End Sub

    Private Sub AnularTicketToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularTicketToolStripMenuItem.Click
        F_AnularTicket.Show()
    End Sub

    Private Sub ModificarUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarUsuarioToolStripMenuItem.Click

        F_Opciones.lblUsuario.Text = lblUsuario.Text

        F_Opciones.Show()
    End Sub
End Class
