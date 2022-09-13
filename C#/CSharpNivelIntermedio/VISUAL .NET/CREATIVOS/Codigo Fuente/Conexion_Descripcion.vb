Imports System.Data
Imports System.Data.SqlClient

Public Class Conexion_Descripcion

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



    Public Function consultar_todos_descripcion() As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select Ticket, Descripcion, Cantidad, Precion, Subtotal from Descripcion", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()
        End Try

        Return estado

    End Function


    Public Function insertar_datos_descripcion(ByRef datos As dDescripcion) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Descripcion(Ticket, Descripcion, Cantidad, Precio, Subtotal) values (@Ticket, @Descripcion, @Cantidad, @Precio, @Subtotal)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@Ticket", SqlDbType.Int).Value = datos.ticket
            _adaptador.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50).Value = datos.descripcion
            _adaptador.InsertCommand.Parameters.Add("@Cantidad", SqlDbType.Int).Value = datos.cantidad
            _adaptador.InsertCommand.Parameters.Add("@Precio", SqlDbType.Int).Value = datos.precio
            _adaptador.InsertCommand.Parameters.Add("@Subtotal", SqlDbType.Int).Value = datos.subtotal
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


    Public Function borrar_datos_descripcion(ByVal datos As dDescripcion) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Descripcion where Descripcion=@Descripcion", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50).Value = datos.descripcion
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
