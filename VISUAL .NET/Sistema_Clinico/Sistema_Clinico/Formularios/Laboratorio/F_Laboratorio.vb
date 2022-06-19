Public Class F_Laboratorio


    Public WithEvents Query As New DDocumentos
    Dim ConexionLINQ As New DataClasses1DataContext()
    Private Sub F_Laboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.DarkCyan,
            .ForeColor = Color.GhostWhite,
            .Font = New Font("Comic Sans MS", 14, FontStyle.Italic Or
        FontStyle.Bold)
        }

        ' asignar estilo al grid
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = styCabeceras

        Consulta()
    End Sub

    Sub Consulta()
        Query.Buscar_Documento(DataGridView1, TxtBuscarPacientes.text)
    End Sub

    Private Sub TxtBuscarPacientes_OnTextChange(sender As Object, e As EventArgs) Handles TxtBuscarPacientes.OnTextChange
        Consulta()
    End Sub

    Private Sub TxtBuscarPacientes_Leave(sender As Object, e As EventArgs) Handles TxtBuscarPacientes.Leave
        If (TxtBuscarPacientes.text = "") Then


            TxtBuscarPacientes.text = "Buscar Pacientes"


        End If
    End Sub

    Private Sub TxtBuscarPacientes_Enter(sender As Object, e As EventArgs) Handles TxtBuscarPacientes.Enter
        If (TxtBuscarPacientes.text = "Buscar Pacientes") Then

            TxtBuscarPacientes.text = ""

        End If
    End Sub

    Private Sub IconCerrar_Click(sender As Object, e As EventArgs) Handles IconCerrar.Click
        Me.Close()

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim Paciente As String = DataGridView1.SelectedCells(1).Value.ToString()

        If (Paciente = "") Then

            MsgBox("Seleccione una Fila", MsgBoxStyle.Exclamation, "Información")



        Else
            F_AgregarDocumentos.BtnBuscar.Enabled = False

            F_AgregarDocumentos.Text = "Editar Informe"
            F_AgregarDocumentos.LblId.Text = DataGridView1.SelectedCells(0).Value.ToString()



            F_AgregarDocumentos.ShowDialog()
            Me.Close()

        End If
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

    Private Sub TxtBuscarPacientes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBuscarPacientes.KeyPress
        ' Matriz de caracteres que deseamos controlar
        '
        Dim caracteres() As Char = {"%"c, "&"c, "$"c, "#"c, "/"c, "-"c, "_"c}

        ' Carácter presionado
        '
        Dim c As Char = e.KeyChar

        ' Comprobamos si la matriz contiene el carácter tecleado.
        '
        If caracteres.Contains(c) Then

            MessageBox.Show("Se ha tecleado un carácter especial.")

            ' Deshechamos el carácter
            e.Handled = True

        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim resp As String = MsgBox("¿Desea Eliminar el Registro?", MsgBoxStyle.YesNo, "Consultorio Letona")

        If resp = 6 Then

            Dim Id As Integer = DataGridView1.SelectedCells(0).Value.ToString()

            Call Query.Eliminar_Documento(Id)
            Query.Buscar_Documento(DataGridView1, "")
            MsgBox("Documento Eliminado con exito", MsgBoxStyle.Information, "Consultorio Letona")

        End If
    End Sub
End Class