Public Class F_Informes

    Public WithEvents Query As New Dpacientes
    Dim ConexionLINQ As New DataClasses1DataContext()
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        F_AgregarPacientes.Text = "Registro de Pacientes - Laboratorio"
        F_AgregarPacientes.ShowDialog()
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

    Private Sub F_Informes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.DarkCyan,
            .ForeColor = Color.GhostWhite,
            .Font = New Font("Comic Sans MS", 14, FontStyle.Italic Or
        FontStyle.Bold)
        }

        ' asignar estilo al grid
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = styCabeceras

        Query.Buscar(DataGridView1, "")
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        F_AgregarDocumentos.Text = "Agregar Informe - Laboratorio"
        F_AgregarDocumentos.BtnBuscar.Enabled = False

        F_AgregarDocumentos.TxtPaciente.Text = DataGridView1.SelectedCells(1).Value.ToString()


        F_AgregarDocumentos.ShowDialog()
        Me.Close()

    End Sub

    Private Sub IconCerrar_Click(sender As Object, e As EventArgs) Handles IconCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnVerInformes_Click(sender As Object, e As EventArgs) Handles BtnVerInformes.Click

        Abrir_FormulariosHijos(New F_Documentos)
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
End Class