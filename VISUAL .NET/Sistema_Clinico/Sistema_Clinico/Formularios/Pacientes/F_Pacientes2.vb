Imports System.Data.SqlClient
Imports System.IO

Public Class F_Pacientes2

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


    Private Sub F_Pacientes2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SystemLetonaDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
        Me.PacientesTableAdapter.Fill(Me.SystemLetonaDataSet.Pacientes)

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
        F_AgregarPacientes.Text = "Registro de Pacientes"
        'F_AgregarPacientes.LblOpcion.Text = "Agregar"
        F_AgregarPacientes.Show()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click


    End Sub

    Public Sub ObtenerImagen()
        Dim connect As New SqlConnection("Server=localhost;database=SystemLetona;integrated security=true")
        Dim command As New SqlCommand("select Foto from Pacientes where Id= @IdPaciente", connect)
        command.Parameters.AddWithValue("@IdPaciente", DataGridView1.SelectedCells(0).Value.ToString())
        'Representa un set de comandos que es utilizado para llenar un DataSet
        Dim dp As New SqlDataAdapter(command)
        'Representa un caché (un espacio) en memoria de los datos.
        Dim ds As New DataSet("Pacientes")

        'Arreglo de byte en donde se almacenara la foto en bytes
        Dim MyData(0 To 0 - 1) As Byte

        'Llenamosel DataSet con la tabla. cliente es nombre de la tabla
        dp.Fill(ds, "Pacientes")
        'Inicializamos una fila de datos en la cual se almacenaran todos los datos de la fila seleccionada
        Dim myRow As DataRow = ds.Tables("Pacientes").Rows(0)
        'Se almacena el campo foto de la tabla en el arreglo de bytes
        MyData = CType(myRow("Foto"), Byte())
        'Se inicializa un flujo en memoria del arreglo de bytes
        Dim stream As New MemoryStream(MyData)
        'En el picture box se muestra la imagen que esta almacenada en el flujo en memoria
        'el cual contiene el arreglo de bytes
        F_AgregarPacientes.PicFoto.Image = Image.FromStream(stream)
    End Sub
End Class