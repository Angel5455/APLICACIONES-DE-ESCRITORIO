Imports System.Runtime.InteropServices

Public Class Form1

    Public Cargo As String
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim ip As System.Net.IPHostEntry
        Dim Ips As String
        ip = System.Net.Dns.GetHostEntry(My.Computer.Name)
        Ips = ip.AddressList(0).ToString


        If My.Settings.Login = "" Then
                Ocultar_Barra()
                Abrir_FormulariosHijos(New F_Login)

            Else
                Mostrar_Barra()
                Dim Conexion As New CConexion
                Dim Sql As New DataSet

                'My.Settings.Login = ""
                'My.Settings.Save()
                'My.Settings.Reload()


                Dim Identidad As String = My.Settings.Login


                Sql = Conexion.Consultar("SELECT * FROM USUARIOS WHERE Identidad='" & Identidad & "'")

                LblUsuario.Text = Sql.Tables(0).Rows(0).Item("Nombre")
                Cargo = Sql.Tables(0).Rows(0).Item("Cargo")

                If Cargo = "Enfermera" Or Cargo = "Recepcionista" Then
                    BtnHCasos.Visible = False
                    BtnDocumentos.Visible = False
                    BtnCitas.Visible = False
                    BtnPrescripcion.Visible = False
                    BtnPLab.Visible = False
                    BtnRH.Visible = False
                    BtnAjustes.Visible = False
                End If

                If Cargo = "Laboratorista" Then
                    BtnHCasos.Visible = False
                    BtnDocumentos.Visible = False
                    BtnCitas.Visible = False
                    BtnPrescripcion.Visible = False
                    BtnPacientes.Visible = False
                    BtnRH.Visible = False
                    BtnAjustes.Visible = False
                End If

            End If

            Ocultar_SubMenu()



    End Sub

    Private Sub Ocultar_SubMenu()

        PanelSubPacientes.Visible = False
        PanelSubCitas.Visible = False
        PanelRH.Visible = False
        PanelPLab.Visible = False
        PanelAjustes.Visible = False

    End Sub

    Private Sub Mostrar_SubMenu(subMenu As Panel)

        If (subMenu.Visible = False) Then
            Ocultar_SubMenu()
            subMenu.Visible = True

        Else
            subMenu.Visible = False

        End If

    End Sub

    Private FormularioActual As Form = Nothing
    Private Sub Abrir_FormulariosHijos(FormularioHijo As Form)

        If FormularioActual IsNot Nothing Then FormularioActual.Close()
        FormularioActual = FormularioHijo

        FormularioHijo.TopLevel = False
        FormularioHijo.FormBorderStyle = FormBorderStyle.None
        FormularioHijo.Dock = DockStyle.Fill
        PanelFormularioHijo.Controls.Add(FormularioHijo)
        PanelFormularioHijo.Tag = FormularioHijo
        FormularioHijo.BringToFront()
        FormularioHijo.Show()


    End Sub

    Private Sub BtnPacientes_Click(sender As Object, e As EventArgs) Handles BtnPacientes.Click
        Mostrar_SubMenu(PanelSubPacientes)
    End Sub

    Private Sub BtnCitas_Click(sender As Object, e As EventArgs) Handles BtnCitas.Click
        Mostrar_SubMenu(PanelSubCitas)
    End Sub



    Private Sub IconCerrar_Click(sender As Object, e As EventArgs) Handles IconCerrar.Click
        My.Settings.MyIdentidad = ""
        My.Settings.MySexo = ""
        My.Settings.MyTelefono = ""
        My.Settings.MyEdad = ""
        My.Settings.MyPaciente = ""
        My.Settings.Ruta = ""
        My.Settings.Save()
        My.Settings.Reload()
        End
    End Sub

    Private Sub PanelHeader_Paint(sender As Object, e As PaintEventArgs) Handles PanelHeader.Paint

    End Sub

    Private Sub PanelHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelFormularioHijo_Paint(sender As Object, e As PaintEventArgs) Handles PanelFormularioHijo.Paint


    End Sub

    Private Sub BtnPLab_Click(sender As Object, e As EventArgs) Handles BtnPLab.Click
        Mostrar_SubMenu(PanelPLab)
    End Sub

    Private Sub BtnRH_Click(sender As Object, e As EventArgs) Handles BtnRH.Click
        Mostrar_SubMenu(PanelRH)
    End Sub

    Private Sub PanelSubCitas_Paint(sender As Object, e As PaintEventArgs) Handles PanelSubCitas.Paint

    End Sub

    Private Sub BtnAjustes_Click(sender As Object, e As EventArgs) Handles BtnAjustes.Click
        Mostrar_SubMenu(PanelAjustes)
    End Sub


    Private Sub BtnDocumentos_Click(sender As Object, e As EventArgs) Handles BtnDocumentos.Click
        My.Settings.Ruta = "Documentos"
        My.Settings.Save()
        My.Settings.Reload()

        Abrir_FormulariosHijos(New F_Documentos)
        Ocultar_SubMenu()
    End Sub

    Private Sub BtnPrescripcion_Click(sender As Object, e As EventArgs) Handles BtnPrescripcion.Click
        Abrir_FormulariosHijos(New F_Prescripcion)
        Ocultar_SubMenu()
    End Sub

    Private Sub BtnCalendario_Click(sender As Object, e As EventArgs) Handles BtnCalendario.Click
        Me.Hide()
        F_Calendario.ShowDialog()

    End Sub

    Private Sub BtnTodas_Click(sender As Object, e As EventArgs) Handles BtnTodas.Click
        Abrir_FormulariosHijos(New F_VerTodas)
        Ocultar_SubMenu()
    End Sub

    Private Sub BtnInforme_Click(sender As Object, e As EventArgs) Handles BtnInforme.Click

        Abrir_FormulariosHijos(New F_Informes)
        Ocultar_SubMenu()
    End Sub

    Private Sub BtnVerInformes_Click(sender As Object, e As EventArgs) Handles BtnVerInformes.Click

        Abrir_FormulariosHijos(New F_Laboratorio)
        Ocultar_SubMenu()
    End Sub

    Private Sub OcultarMenu_Tick(sender As Object, e As EventArgs) Handles OcultarMenu.Tick
        'If PanelMenuLateral.Width <= 0 Then


        '    AnimacionPanelMenuLateral.Show(PanelMenuLateral)
        '    Me.OcultarMenu.Enabled = False
        'Else
        '    Me.PanelMenuLateral.Width = PanelMenuLateral.Width - 50

        'End If
    End Sub

    Private Sub Btnmenu_Click(sender As Object, e As EventArgs) Handles Btnmenu.Click
        'If PanelMenuLateral.Width = 250 Then
        '    
        'ElseIf PanelMenuLateral.Width = 0 Then
        '    Me.MostrarMenu.Enabled = True


        'End If

        If My.Settings.Login <> "" Then
            If (PanelMenuLateral.Width = 250) Then
                AnimacionPanelMenuLateral.Show(PanelMenuLateral)
                PanelMenuLateral.Visible = False
                PanelMenuLateral.Width = 0



            Else

                PanelMenuLateral.Visible = False
                PanelMenuLateral.Width = 250

                AnimacionPanelMenuLateralBack.Show(PanelMenuLateral)

            End If
        Else
            MsgBox("Inicie Sesión", MsgBoxStyle.Exclamation, "Consultorio Letona")
        End If





    End Sub

    Sub Ocultar_Barra()

        AnimacionPanelMenuLateral.Show(PanelMenuLateral)
        PanelMenuLateral.Visible = False
        PanelMenuLateral.Width = 0




    End Sub

    Public Sub Mostrar_Barra()
        PanelMenuLateral.Visible = False
        PanelMenuLateral.Width = 250

        AnimacionPanelMenuLateralBack.Show(PanelMenuLateral)

        LinkSesion.Visible = True
        LinkSesion.Text = "Cerrar Sesion"
    End Sub

    Private Sub MostrarMenu_Tick(sender As Object, e As EventArgs) Handles MostrarMenu.Tick
        'If PanelMenuLateral.Width >= 250 Then
        '    Me.MostrarMenu.Enabled = False
        'Else
        '    Me.PanelMenuLateral.Width = PanelMenuLateral.Width + 50

        'End If
    End Sub

    Private Sub IconMinimizar_Click(sender As Object, e As EventArgs) Handles IconMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnMedicos_Click(sender As Object, e As EventArgs) Handles BtnMedicos.Click

        My.Settings.Ruta = "Medico"
        My.Settings.Save()
        My.Settings.Reload()


        Abrir_FormulariosHijos(New F_Usuarios)
        Ocultar_SubMenu()
    End Sub

    Private Sub BtnLaboratorista_Click(sender As Object, e As EventArgs) Handles BtnLaboratorista.Click
        My.Settings.Ruta = "Laboratorista"
        My.Settings.Save()
        My.Settings.Reload()


        Abrir_FormulariosHijos(New F_Usuarios)
        Ocultar_SubMenu()
    End Sub

    Private Sub BtnEnfermera_Click(sender As Object, e As EventArgs) Handles BtnEnfermera.Click
        My.Settings.Ruta = "Enfermera"
        My.Settings.Save()
        My.Settings.Reload()


        Abrir_FormulariosHijos(New F_Usuarios)
        Ocultar_SubMenu()
    End Sub

    Private Sub BtnRecepcionista_Click(sender As Object, e As EventArgs) Handles BtnRecepcionista.Click
        My.Settings.Ruta = "Recepcionista"
        My.Settings.Save()
        My.Settings.Reload()


        Abrir_FormulariosHijos(New F_Usuarios)
        Ocultar_SubMenu()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        F_Informacion.Show()

    End Sub



    Private Sub LinkSesion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSesion.LinkClicked
        LinkSesion.Visible = False
        Ocultar_Barra()
        Abrir_FormulariosHijos(New F_Login)

        If LinkSesion.Text = "Cerrar Sesion" Then
            My.Settings.Login = ""
            My.Settings.Save()
            My.Settings.Reload()
        Else

        End If


    End Sub

    Private Sub BtnBackup_Click(sender As Object, e As EventArgs) Handles BtnBackup.Click
        F_Backup.Show()
    End Sub

    Private Sub BtnLPacientes_Click(sender As Object, e As EventArgs) Handles BtnLPacientes.Click
        Abrir_FormulariosHijos(New F_Pacientes)
        Ocultar_SubMenu()

    End Sub

    Private Sub BtnHCasos_Click(sender As Object, e As EventArgs) Handles BtnHCasos.Click
        Abrir_FormulariosHijos(New F_Historial_Casos)
        Ocultar_SubMenu()
    End Sub
End Class
