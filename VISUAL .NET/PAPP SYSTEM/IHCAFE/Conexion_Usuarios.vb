Imports System.Data
Imports System.Data.SqlClient

Public Class Conexion_Usuarios

    Private _cadena As String
    Private _conexion As SqlConnection
    Private _tabla As New DataTable
    Private _adaptador As SqlDataAdapter = New SqlDataAdapter



    Private Sub conexion()
        _cadena = "Data Source=(local);Initial Catalog=Login;User ID=sa;Password=root"

        _conexion = New SqlConnection(_cadena)

    End Sub

    Public Function consultar_todos() As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select Id, Nombre, Usuario, Contraseña, Cargo, Correo, Foto from Usuarios", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function




    Public Function consultar_todos_historial() As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select Fecha, Hora, Usuario from Historial", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function


    Public ReadOnly Property tabla() As DataTable
        Get
            Return _tabla
        End Get
    End Property



    Public Function insertar_datos(ByRef datos As cDatos) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Usuarios(Id, Nombre, Usuario, Contraseña, Cargo, Correo, Foto) values (@Id, @Nombre, @Usuario, @Contraseña, @Cargo, @Correo, @Foto)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@Id", SqlDbType.Int).Value = datos.id
            _adaptador.InsertCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = datos.nombre
            _adaptador.InsertCommand.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = datos.Usuario
            _adaptador.InsertCommand.Parameters.Add("@Contraseña", SqlDbType.VarChar, 50).Value = datos.Contraseña
            _adaptador.InsertCommand.Parameters.Add("@Cargo", SqlDbType.VarChar, 100).Value = datos.Cargo
            _adaptador.InsertCommand.Parameters.Add("@Correo", SqlDbType.VarChar, 100).Value = datos.correo
            _adaptador.InsertCommand.Parameters.Add("@Foto", SqlDbType.VarChar, 100).Value = datos.foto
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()

        Catch ex As Exception

            estado = False

        Finally

            cerrar()

        End Try

        Return estado

    End Function

    Public Function insertar_datos_historial(ByRef datos As cDatos) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into historial(Fecha, Hora, Usuario) values (@Fecha, @Hora, @Usuario)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 100).Value = datos.fecha
            _adaptador.InsertCommand.Parameters.Add("@Hora", SqlDbType.VarChar, 100).Value = datos.hora
            _adaptador.InsertCommand.Parameters.Add("@Usuario", SqlDbType.VarChar, 100).Value = datos.Usuario
     
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()

        Catch ex As Exception

            estado = False

        Finally

            cerrar()

        End Try

        Return estado

    End Function

    Public Function actualizar_datos(ByRef datos As cDatos) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.UpdateCommand = New SqlCommand("update Usuarios set Nombre=@Nombre, Usuario=@Usuario, Contraseña=@Contraseña, Cargo=@Cargo, Correo=@Correo, Foto=@Foto where Id=@Id", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int).Value = datos.id
            _adaptador.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = datos.nombre
            _adaptador.UpdateCommand.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = datos.Usuario
            _adaptador.UpdateCommand.Parameters.Add("@Contraseña", SqlDbType.VarChar, 50).Value = datos.Contraseña
            _adaptador.UpdateCommand.Parameters.Add("@Cargo", SqlDbType.VarChar, 100).Value = datos.Cargo
            _adaptador.UpdateCommand.Parameters.Add("@Correo", SqlDbType.VarChar, 100).Value = datos.correo
            _adaptador.UpdateCommand.Parameters.Add("@Foto", SqlDbType.VarChar, 100).Value = datos.foto

            _conexion.Open()
            _adaptador.UpdateCommand.Connection = _conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()

        Catch ex As Exception

            estado = False

        Finally

            cerrar()

        End Try

        Return estado

    End Function

    Public Function borrar_datos(ByVal datos As cDatos) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Usuarios where Id=@Id", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Id", SqlDbType.Int).Value = datos.id
            _conexion.Open()
            _adaptador.DeleteCommand.Connection = _conexion
            _adaptador.DeleteCommand.ExecuteNonQuery()

        Catch ex As Exception
            estado = False
        Finally
            cerrar()

        End Try
        Return estado
    End Function


    Public Function borrar_Generar(ByVal datos As cDatos) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from GeneraCodigos where Codigo=@Codigo", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Codigo", SqlDbType.NVarChar, 15).Value = datos.Codigo
            _conexion.Open()
            _adaptador.DeleteCommand.Connection = _conexion
            _adaptador.DeleteCommand.ExecuteNonQuery()

        Catch ex As Exception
            estado = False
        Finally
            cerrar()

        End Try
        Return estado
    End Function



    Public Function consultar_Usuario(ByVal datos As cDatos) As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select from Usuarios where Usuario=@Usuario", _conexion)
            _adaptador.SelectCommand.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = datos.Usuario
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function



    Private Sub cerrar()

        _conexion.Close()

    End Sub




End Class
