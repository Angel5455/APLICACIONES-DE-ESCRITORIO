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



        Mostrar_Barra()

        'My.Settings.Login = ""
        'My.Settings.Save()
        'My.Settings.Reload()






        Ocultar_SubMenu()



    End Sub

    Private Sub Ocultar_SubMenu()

        PanelSubPacientes.Visible = False


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


    Private Sub PanelSubCitas_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BtnAjustes_Click(sender As Object, e As EventArgs) Handles BtnAjustes.Click
        Mostrar_SubMenu(PanelAjustes)
    End Sub


    Private Sub BtnVerInformes_Click(sender As Object, e As EventArgs) Handles BtnADrogas.Click

        F_Drogas.ShowDialog()


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

        If (PanelMenuLateral.Width = 250) Then
                AnimacionPanelMenuLateral.Show(PanelMenuLateral)
                PanelMenuLateral.Visible = False
                PanelMenuLateral.Width = 0



            Else

                PanelMenuLateral.Visible = False
                PanelMenuLateral.Width = 250

                AnimacionPanelMenuLateralBack.Show(PanelMenuLateral)

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

         
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        F_Informacion.Show()

    End Sub



    Private Sub BtnBackup_Click(sender As Object, e As EventArgs) Handles BtnBackup.Click
        F_Backup.Show()
    End Sub

    Private Sub BtnLPacientes_Click(sender As Object, e As EventArgs) Handles BtnLPacientes.Click
        Abrir_FormulariosHijos(New F_Pacientes)
        Ocultar_SubMenu()

    End Sub

    Private Sub BtnCitologia_Click(sender As Object, e As EventArgs) Handles BtnCitologia.Click
        F_MocoFecal.ShowDialog()


    End Sub

    Private Sub BtnCTOG_Click(sender As Object, e As EventArgs) Handles BtnCTOG.Click
        F_CTOG.ShowDialog()
    End Sub

    Private Sub BtnEmbarazoO_Click(sender As Object, e As EventArgs) Handles BtnEmbarazoO.Click
        F_PEmbarazoO.ShowDialog()
    End Sub

    Private Sub BtnEmbarazoS_Click(sender As Object, e As EventArgs) Handles BtnEmbarazoS.Click
        F_EmbarazoS.ShowDialog()
    End Sub

    Private Sub BtnFSP_Click(sender As Object, e As EventArgs) Handles BtnFSP.Click
        F_FSP.ShowDialog()
    End Sub

    Private Sub BtnHeces_Click(sender As Object, e As EventArgs) Handles BtnHeces.Click
        F_Heces.ShowDialog()
    End Sub

    Private Sub BtnHematologia_Click(sender As Object, e As EventArgs) Handles BtnHematologia.Click
        F_Hematologia.ShowDialog()
    End Sub

    Private Sub BtnPiloryH_Click(sender As Object, e As EventArgs) Handles BtnPiloryH.Click
        F_PiloryH.ShowDialog()
    End Sub

    Private Sub BtnPiloryS_Click(sender As Object, e As EventArgs) Handles BtnPiloryS.Click
        F_PiloryS.Show()
    End Sub

    Private Sub BtnOrina_Click(sender As Object, e As EventArgs) Handles BtnOrina.Click
        F_Orina.ShowDialog()
    End Sub

    Private Sub BtnPEspeciales_Click(sender As Object, e As EventArgs) Handles BtnPEspeciales.Click
        F_PEspeciales.ShowDialog()
    End Sub

    Private Sub BtnQuimicaS_Click(sender As Object, e As EventArgs) Handles BtnQuimicaS.Click
        F_Quimica.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        F_BuscarExamen.ShowDialog()

    End Sub
End Class
