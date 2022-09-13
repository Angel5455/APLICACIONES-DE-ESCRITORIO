Imports System.Data
Imports System.Data.SqlClient

Public Class Conexion_Inventario

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



    Public Function consultar_todos_Inventario() As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select Codigo, Descripcion, Precio from Inventario", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()
        End Try

        Return estado

    End Function


    Public Function insertar_datos_Inventario(ByRef datos As dInventario) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Inventario(Codigo, Descripcion, Precio) values (@Codigo, @Descripcion, @Precio)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@Codigo", SqlDbType.Int).Value = datos.codigo
            _adaptador.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50).Value = datos.descripcion
            _adaptador.InsertCommand.Parameters.Add("@Precio", SqlDbType.Int).Value = datos.precio

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

    Public Function actualizar_datos_inventario(ByRef datos As dInventario) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.UpdateCommand = New SqlCommand("update Inventario set Codigo=@Codigo, Descripcion=@Descripcion, Precio=@Precio where Codigo=@Codigo", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@Codigo", SqlDbType.Int).Value = datos.codigo
            _adaptador.UpdateCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50).Value = datos.descripcion
            _adaptador.UpdateCommand.Parameters.Add("@Precio", SqlDbType.VarChar, 50).Value = datos.precio
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


    Public Function borrar_datos_inventario(ByVal datos As dInventario) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Inventario where Codigo=@Codigo", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 50).Value = datos.codigo
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
