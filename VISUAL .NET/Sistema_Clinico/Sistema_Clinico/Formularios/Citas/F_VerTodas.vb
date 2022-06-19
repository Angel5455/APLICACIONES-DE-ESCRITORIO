Public Class F_VerTodas

    Public WithEvents Query As New DCitas
    Dim seleccionada As Integer
    Private Sub F_VerTodas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SystemLetonaDataSet.Citas' Puede moverla o quitarla según sea necesario.
        Me.CitasTableAdapter.Fill(Me.SystemLetonaDataSet.Citas)
        ' estilo para las cabeceras
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.DarkCyan,
            .ForeColor = Color.GhostWhite,
            .Font = New Font("Comic Sans MS", 14, FontStyle.Italic Or
        FontStyle.Bold)
        }

        ' asignar estilo al grid
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = styCabeceras
        Query.Buscar(DataGridView1, TxtBuscarPacientes.text)

    End Sub

    Private Sub IconCerrar_Click(sender As Object, e As EventArgs) Handles IconCerrar.Click
        Me.Close()

    End Sub

    Private Sub TxtBuscarPacientes_OnTextChange(sender As Object, e As EventArgs) Handles TxtBuscarPacientes.OnTextChange
        Query.Buscar(DataGridView1, TxtBuscarPacientes.text)
    End Sub

    Private Sub TxtBuscarPacientes_Enter(sender As Object, e As EventArgs) Handles TxtBuscarPacientes.Enter
        If (TxtBuscarPacientes.text = "Buscar Pacientes") Then

            TxtBuscarPacientes.text = ""

        End If
    End Sub

    Private Sub TxtBuscarPacientes_Leave(sender As Object, e As EventArgs) Handles TxtBuscarPacientes.Leave
        If (TxtBuscarPacientes.text = "") Then


            TxtBuscarPacientes.text = "Buscar Pacientes"


        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        My.Settings.Ruta = "Todas"
        My.Settings.Save()
        My.Settings.Reload()

        F_AgregarCita.Show()

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        My.Settings.Ruta = "Todas"
        My.Settings.Save()
        My.Settings.Reload()
        F_AgregarCita.LblText.Text = "Editar Cita"


        Dim Paciente As String = DataGridView1.SelectedCells(1).Value.ToString()

        If (Paciente = "" Or Paciente = "Buscar Pacientes") Then

            MsgBox("Seleccione una Fila", MsgBoxStyle.Exclamation, "Información")



        Else

            F_AgregarCita.AppID = DataGridView1.SelectedCells(0).Value.ToString()
            'F_AgregarCita.TxtTelefono.Visible = False
            'F_AgregarCita.Label7.Visible = False
            F_AgregarCita.TxtPaciente.Text = Paciente
            F_AgregarCita.TxtIdentidad.Text = DataGridView1.SelectedCells(2).Value.ToString()
            F_AgregarCita.TxtFecha.Text = DataGridView1.SelectedCells(3).Value.ToString()
            F_AgregarCita.TxtHora.Text = DataGridView1.SelectedCells(4).Value.ToString()
            F_AgregarCita.TxtObservaciones.Text = DataGridView1.SelectedCells(5).Value.ToString()
            F_AgregarCita.TxtEstado.Text = DataGridView1.SelectedCells(6).Value.ToString()


            F_AgregarCita.Show()

        End If






        F_AgregarCita.Show()
    End Sub
End Class