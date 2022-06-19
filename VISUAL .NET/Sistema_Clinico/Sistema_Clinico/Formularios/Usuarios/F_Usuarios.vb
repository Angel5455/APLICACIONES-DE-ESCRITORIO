Imports System.Data.SqlClient
Imports System.IO

Public Class F_Usuarios

    Public WithEvents Query As New DUsuarios
    Dim ConexionLINQ As New DataClasses1DataContext()
    Public Cargo As String
    Dim Nombre As String
    Dim Identidad As String
    Dim Email As String
    Dim Password As String
    Dim Direccion As String
    Dim Telefono As String
    Dim Cargos As String
    Dim Foto As Byte()

    Public Conexion As New CConexion
    Public Sql As New DataSet

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        If My.Settings.Ruta = "Medico" Then
            F_AgregarUsuario.Text = "Registro de Medicos"
        End If

        If My.Settings.Ruta = "Laboratorista" Then
            F_AgregarUsuario.Text = "Registro de Laboratorista"
        End If

        If My.Settings.Ruta = "Enfermera" Then
            F_AgregarUsuario.Text = "Registro de Enfermera"
        End If

        If My.Settings.Ruta = "Recepcionista" Then
            F_AgregarUsuario.Text = "Registro de Recepcionista"
        End If



        F_AgregarUsuario.TxtCargo.Text = Cargo


        F_AgregarUsuario.ShowDialog()
        Me.Close()


    End Sub

    Private Sub F_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' estilo para las cabeceras
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.DarkCyan,
            .ForeColor = Color.GhostWhite,
            .Font = New Font("Comic Sans MS", 14, FontStyle.Italic Or
        FontStyle.Bold)
        }

        ' asignar estilo al grid
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = styCabeceras



        Cargo = My.Settings.Ruta


        If Cargo = "Medico" Then
            LblText.Text = "Usuarios / Medicos "
        End If

        If Cargo = "Laboratorista" Then
            LblText.Text = "Usuarios / Laboratorista "
        End If

        If Cargo = "Enfermera" Then
            LblText.Text = "Usuarios / Enfermera "
        End If

        If Cargo = "Recepcionista" Then
            LblText.Text = "Usuarios / Recepcionista "
        End If
        Consulta()


    End Sub

    Sub Consulta()

        If TxtBuscarUsuario.text = "Buscar Usuario" Or TxtBuscarUsuario.text = "" Then

            Query.Buscar_Usuarios(DataGridView1, "", Cargo)
        Else

            Query.Buscar_Usuarios(DataGridView1, TxtBuscarUsuario.text, Cargo)
        End If


    End Sub

    Private Sub TxtBuscarUsuario_OnTextChange(sender As Object, e As EventArgs) Handles TxtBuscarUsuario.OnTextChange
        Consulta()
    End Sub

    Private Sub TxtBuscarUsuario_Enter(sender As Object, e As EventArgs) Handles TxtBuscarUsuario.Enter
        If (TxtBuscarUsuario.text = "Buscar Usuario") Then

            TxtBuscarUsuario.text = ""

        End If


    End Sub

    Private Sub TxtBuscarUsuario_Leave(sender As Object, e As EventArgs) Handles TxtBuscarUsuario.Leave
        If (TxtBuscarUsuario.text = "") Then

            TxtBuscarUsuario.text = "Buscar Usuario"

        End If
    End Sub

    Private Sub IconCerrar_Click(sender As Object, e As EventArgs) Handles IconCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If My.Settings.Ruta = "Medico" Then
            F_AgregarUsuario.Text = "Editar Medico"
        End If

        If My.Settings.Ruta = "Laboratorista" Then
            F_AgregarUsuario.Text = "Editar Laboratorista"
        End If

        If My.Settings.Ruta = "Recepcionista" Then
            F_AgregarUsuario.Text = "Editar Recepcionista"
        End If

        If My.Settings.Ruta = "Enfermera" Then
            F_AgregarUsuario.Text = "Editar Enfermera"
        End If



        Dim Id As Integer = DataGridView1.SelectedCells(0).Value.ToString()

        If (Id = Nothing) Then

            MsgBox("Seleccione una Fila", MsgBoxStyle.Exclamation, "Consultorio Letona")



        Else


            F_AgregarUsuario.Id = Id




            Sql = Conexion.Consultar("SELECT * FROM Usuarios WHERE Id='" & Id & "'")



            Nombre = Sql.Tables(0).Rows(0).Item("Nombre")
            Identidad = Sql.Tables(0).Rows(0).Item("Identidad")
            Email = Sql.Tables(0).Rows(0).Item("Email")
            Direccion = Sql.Tables(0).Rows(0).Item("Direccion")
            Telefono = Sql.Tables(0).Rows(0).Item("Telefono")
            Password = Sql.Tables(0).Rows(0).Item("Password")
            Cargos = Sql.Tables(0).Rows(0).Item("Cargo")
            Foto = Sql.Tables(0).Rows(0).Item("Foto")





            F_AgregarUsuario.TxtNombre.Text = Nombre
            F_AgregarUsuario.TxtIdentidad.Text = Identidad
            F_AgregarUsuario.TxtEmail.Text = Email
            F_AgregarUsuario.TxtDireccion.Text = Direccion
            F_AgregarUsuario.TxtTelefono.Text = Telefono
            F_AgregarUsuario.TxtPassword.Text = Password
            F_AgregarUsuario.TxtCargo.Text = Cargos

            Dim mybytearray As Byte() = Foto 'this should contain your data

            Dim myimage As Image
            Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream(mybytearray)
            myimage = System.Drawing.Image.FromStream(ms)
            F_AgregarUsuario.PicFoto.Image = myimage


            F_AgregarUsuario.ShowDialog()
            Me.Close()

        End If

    End Sub

    Public Sub ObtenerImagen()
        'Dim connect As New SqlConnection("Server=localhost;database=SystemLetona;integrated security=true")
        'Dim command As New SqlCommand("select Foto from Usuarios where Id= @Id", connect)
        'command.Parameters.AddWithValue("@Id", Sql.Tables(0).Rows(0).Item("Foto"))
        ''Representa un set de comandos que es utilizado para llenar un DataSet
        'Dim dp As New SqlDataAdapter(command)
        ''Representa un caché (un espacio) en memoria de los datos.
        'Dim ds As New DataSet("Usuarios")

        ''Arreglo de byte en donde se almacenara la foto en bytes
        'Dim MyData(0 To 0 - 1) As Byte

        ''Llenamosel DataSet con la tabla. cliente es nombre de la tabla
        ''dp.Fill(ds, "Usuarios")
        ''Inicializamos una fila de datos en la cual se almacenaran todos los datos de la fila seleccionada
        ''Dim myRow As DataRow = ds.Tables("Usuarios").Rows(0)
        ''Se almacena el campo foto de la tabla en el arreglo de bytes
        'MyData = CType(Sql.Tables(0).Rows(0).Item("Foto"), Byte())
        ''Se inicializa un flujo en memoria del arreglo de bytes
        'Dim stream As New MemoryStream(MyData)
        ''En el picture box se muestra la imagen que esta almacenada en el flujo en memoria
        ''el cual contiene el arreglo de bytes
        'F_AgregarUsuario.PicFoto.Image = Image.FromStream(stream)
    End Sub

    Private Sub TxtBuscarUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBuscarUsuario.KeyPress
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

            Call Query.Eliminar_Usuario(Id)
            Query.Buscar_Usuarios(DataGridView1, "", Cargo)
            MsgBox("Usuario Eliminado con exito", MsgBoxStyle.Information, "Consultorio Letona")

        End If
    End Sub
End Class