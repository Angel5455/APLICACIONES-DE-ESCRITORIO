Imports System.Data
Imports System.Data.SqlClient


Public Class Conexion_Empleados

    Private _cadena As String
    Private _conexion As SqlConnection
    Private _cadena2 As String
    Private _conexion2 As SqlConnection
    Private _tabla As New DataTable
    Private _adaptador As SqlDataAdapter = New SqlDataAdapter

    Private Sub conexion()
        _cadena = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        _conexion = New SqlConnection(_cadena)

    End Sub



    Public Function consultar_todos_Empleados() As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select Codigo, Nombre from Empleados", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()
        End Try

        Return estado

    End Function


    Public Function insertar_datos_Empleados(ByRef datos As dEmpleados) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Empleados(Codigo, Nombre) values (@Codigo, @Nombre)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 50).Value = datos.codigo
            _adaptador.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = datos.nombre

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

    Public Function insertar_datos_Usuarios(ByRef datos As dEmpleados) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Usuarios(Usuario, Contraseña) values (@Usuario, @Contraseña)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = datos.Usuario
            _adaptador.InsertCommand.Parameters.Add("@Contraseña", SqlDbType.VarChar, 50).Value = datos.Contraseña

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


    Public Function actualizar_datos_empleados(ByRef datos As dEmpleados) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.UpdateCommand = New SqlCommand("update Empleados set Codigo=@Codigo, Nombre=@Nombre where Codigo=@Codigo", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 50).Value = datos.codigo
            _adaptador.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = datos.nombre
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


    Public Function borrar_datos_empleados(ByVal datos As dEmpleados) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Empleados where Nombre=@Nombre", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = datos.nombre
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


    Public ReadOnly Property tabla() As DataTable
        Get
            Return _tabla
        End Get
    End Property



End Class
