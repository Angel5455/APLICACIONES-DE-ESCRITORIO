Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices

Public Class F_Pacientes
    Public WithEvents Query As New Dpacientes
    Dim ConexionLINQ As New DataClasses1DataContext()
    Dim Id As Integer
    Dim Paciente As String
    Dim Identidad As String
    Dim Telefono As String
    Dim Email As String
    Dim Direccion As String
    Dim Edad As Integer
    Dim Sexo As String
    Dim Fecha_Nacimiento As Date
    Dim Foto As Byte()

    Public Ruta As String
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub IconCerrar_Click(sender As Object, e As EventArgs) Handles IconCerrar.Click
        Me.Close()
    End Sub

    Private Sub F_Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TextBox1.Text = DataGridView1.SelectedCells(1).Value.ToString()
        ' estilo para las cabeceras
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.DarkCyan,
            .ForeColor = Color.GhostWhite,
            .Font = New Font("Comic Sans MS", 14, FontStyle.Italic Or
        FontStyle.Bold)
        }

        ' asignar estilo al grid
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = styCabeceras



        '//--------------------------------------------------------------
        'TODO: esta línea de código carga datos en la tabla 'SystemLetonaDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
        Me.PacientesTableAdapter.Fill(Me.SystemLetonaDataSet.Pacientes)


        Query.Buscar(DataGridView1, TxtBuscarPacientes.text)

        If Form1.Cargo = "Enfermera" Or Form1.Cargo = "Recepcionista" Then
            BtnHistorial.Enabled = False
        End If


    End Sub




    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        F_AgregarPacientes.Text = "Registro de Pacientes"
        F_AgregarPacientes.ShowDialog()
        Me.Close()

    End Sub



    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        F_AgregarPacientes.Text = "Editar Paciente"

        Id = DataGridView1.SelectedCells(0).Value.ToString()

        If (Id = Nothing) Then

            MsgBox("Seleccione una Fila", MsgBoxStyle.Exclamation, "Consultorio Letona")



        Else


            F_AgregarPacientes.LblId.Text = Id


            Dim Conexion As New CConexion
            Dim Sql As New DataSet

            Sql = Conexion.Consultar("SELECT * FROM Pacientes WHERE Id='" & Id & "'")



            Paciente = Sql.Tables(0).Rows(0).Item("Paciente")
            Identidad = Sql.Tables(0).Rows(0).Item("Identidad")
            Email = Sql.Tables(0).Rows(0).Item("Email")
            Direccion = Sql.Tables(0).Rows(0).Item("Direccion")
            Telefono = Sql.Tables(0).Rows(0).Item("Telefono")
            Fecha_Nacimiento = Sql.Tables(0).Rows(0).Item("Fecha_Nacimiento")
            Edad = Sql.Tables(0).Rows(0).Item("Edad")
            Sexo = Sql.Tables(0).Rows(0).Item("Sexo")
            Foto = Sql.Tables(0).Rows(0).Item("Foto")



            F_AgregarPacientes.TxtPaciente.Text = Paciente
            F_AgregarPacientes.TxtIdentidad.Text = Identidad
            F_AgregarPacientes.TxtEmail.Text = Email
            F_AgregarPacientes.TxtDireccion.Text = Direccion
            F_AgregarPacientes.TxtTelefono.Text = Telefono
            F_AgregarPacientes.TxtFecha.Text = Fecha_Nacimiento
            F_AgregarPacientes.TxtEdad.Text = Edad
            F_AgregarPacientes.TxtSexo.Text = Sexo

            Dim mybytearray As Byte() = Foto 'this should contain your data

            Dim myimage As Image
            Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream(mybytearray)
            myimage = System.Drawing.Image.FromStream(ms)
            F_AgregarPacientes.PicFoto.Image = myimage

            F_AgregarPacientes.ShowDialog()
            Me.Close()

        End If



    End Sub



    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

        My.Settings.MyPaciente = DataGridView1.SelectedCells(1).Value.ToString()
        My.Settings.Save()
        My.Settings.Reload()
    End Sub


    Private Sub PanelHeader_Paint(sender As Object, e As PaintEventArgs) Handles PanelHeader.Paint

    End Sub

    Private Sub PanelHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
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

    Private Sub BtnHistorial_Click(sender As Object, e As EventArgs) Handles BtnHistorial.Click

        Dim Id As String = DataGridView1.SelectedCells(2).Value.ToString()

        If Id = "" Then
            MsgBox("Seleccione una Fila", MsgBoxStyle.Exclamation, "Información")
        Else
            My.Settings.Ruta = "Historial"

            Dim Identidad = DataGridView1.SelectedCells(2).Value.ToString()
            My.Settings.MyIdentidad = Identidad
            My.Settings.Save()
            My.Settings.Reload()
            ' F_Historial.LblPaciente.Text = DataGridView2.SelectedCells(2).Value.ToString()

            Form1.Hide()
            F_Historial.ShowDialog()


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



    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs)

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

    Private Sub TxtBuscarPacientes_KeyPress(sender As Object, e As EventArgs) Handles TxtBuscarPacientes.KeyPress

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resp As String = MsgBox("¿Desea Eliminar el Registro?", MsgBoxStyle.YesNo, "Consultorio Letona")

        If resp = 6 Then

            Dim Id As Integer = DataGridView1.SelectedCells(0).Value.ToString()

            Call Query.Eliminar_Paciente(Id)
            Query.Buscar(DataGridView1, "")
            MsgBox("Paciente Eliminado con exito", MsgBoxStyle.Information, "Consultorio Letona")

        End If
    End Sub
End Class