Imports System.Runtime.InteropServices

Public Class F_AgregarCita

    Public AppID As Integer = 0
    Dim WithEvents Queryconsultas As New DCitas
    Dim ConexionLINQ As New DataClasses1DataContext()

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelHeader_Paint(sender As Object, e As PaintEventArgs) Handles PanelHeader.Paint

    End Sub

    Private Sub PanelHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        If String.IsNullOrWhiteSpace(TxtPaciente.Text) Then
            MsgBox("El nombre del Paciente es requerido.")
            Return
        End If

        If IsConfirm("Quieres guardar el registro?") Then

            If AppID = 0 Then
                Call Queryconsultas.Insertar_Cita(TxtPaciente.Text, TxtIdentidad.Text, TxtFecha.Value, TxtHora.Text, TxtObservaciones.Text, TxtEstado.Text)
                MessageBox.Show("Los Datos fueron agregados con exito", "Datos Guardados...")

                If My.Settings.Ruta = "Todas" Then
                    F_VerTodas.Query.Buscar(F_VerTodas.DataGridView1, F_VerTodas.TxtBuscarPacientes.text)

                    Limpiar()
                    Abrir_FormulariosHijos(New F_VerTodas)

                End If

                Limpiar()

                Me.Close()

            Else
                Call Queryconsultas.Editar_Cita(AppID, TxtPaciente.Text, TxtIdentidad.Text, TxtFecha.Value, TxtHora.Text, TxtObservaciones.Text, TxtEstado.Text)
                MessageBox.Show("Los Datos fueron modificados con exito", "Datos Guardados...")


                If My.Settings.Ruta = "Todas" Then
                    F_VerTodas.Query.Buscar(F_VerTodas.DataGridView1, F_VerTodas.TxtBuscarPacientes.text)

                    Limpiar()
                    Abrir_FormulariosHijos(New F_VerTodas)

                End If
                Limpiar()
                Me.Close()

            End If
        End If
    End Sub

    Sub Limpiar()
        TxtPaciente.Clear()
        TxtTelefono.Clear()
        TxtIdentidad.Clear()
        TxtObservaciones.Clear()
        TxtEstado.Text = ""
        TxtHora.Clear()
        My.Settings.Ruta = ""
        My.Settings.Save()
        My.Settings.Reload()

    End Sub

    Private Sub F_AgregarCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If LblText.Text = "Agregar Cita" Then
            TxtHora.Text = DateTime.Now.ToShortTimeString()
        End If

        If LblText.Text = "Editar Cita" Then

            Dim Conexion As New CConexion
            Dim Sql As New DataSet

            Sql = Conexion.Consultar("SELECT * FROM PACIENTES WHERE Identidad='" & TxtIdentidad.Text & "'")

            TxtTelefono.Text = Sql.Tables(0).Rows(0).Item("Telefono")


        End If

        BtnEliminar.Visible = AppID <> 0
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtPaciente_TextChanged(sender As Object, e As EventArgs) Handles TxtPaciente.TextChanged

    End Sub

    Private Sub TxtPaciente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPaciente.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtIdentidad.Focus()

        End If
    End Sub



    Private Sub TxtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdentidad.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtHora.Focus()

        End If

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtHora_TextChanged(sender As Object, e As EventArgs) Handles TxtHora.TextChanged

    End Sub

    Private Sub TxtHora_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHora.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtTelefono.Focus()

        End If
    End Sub

    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefono.TextChanged

    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtObservaciones.Focus()

        End If

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtObservaciones_TextChanged(sender As Object, e As EventArgs) Handles TxtObservaciones.TextChanged

    End Sub

    Private Sub TxtObservaciones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtObservaciones.KeyPress
        If Asc(e.KeyChar) = 46 Then

            TxtEstado.Focus()

        End If
    End Sub

    Private Sub TxtEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtEstado.SelectedIndexChanged

    End Sub

    Private Sub TxtEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEstado.KeyPress
        If Asc(e.KeyChar) = 13 Then

            BtnEnviar.Focus()

        End If
    End Sub

    Private Sub IconCerrar_Click(sender As Object, e As EventArgs) Handles IconCerrar.Click
        Limpiar()
        Me.Close()
    End Sub

    Private FormularioActual As Form = Nothing
    Private Sub Abrir_FormulariosHijos(FormularioHijo As Form)

        If FormularioActual IsNot Nothing Then FormularioActual.Close()
        FormularioActual = FormularioHijo

        FormularioHijo.TopLevel = False
        FormularioHijo.FormBorderStyle = FormBorderStyle.None
        FormularioHijo.Dock = DockStyle.Fill
        Form1.PanelFormularioHijo.Controls.Add(FormularioHijo)
        Form1.PanelFormularioHijo.Tag = FormularioHijo
        FormularioHijo.BringToFront()
        FormularioHijo.Show()


    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        F_BuscarPaciente.Text = "Buscar Paciente - Citas"
        F_BuscarPaciente.Show()
    End Sub

    Private Sub TxtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles TxtIdentidad.TextChanged

    End Sub
End Class