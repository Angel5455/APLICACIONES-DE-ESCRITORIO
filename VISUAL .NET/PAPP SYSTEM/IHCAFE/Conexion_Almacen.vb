Imports System.Data
Imports System.Data.SqlClient

Public Class Conexion_Almacen

    Private _cadena As String
    Private _conexion As SqlConnection
    Private _tabla As New DataTable
    Private _adaptador As SqlDataAdapter = New SqlDataAdapter

    Private Sub conexion()

        _cadena = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        _conexion = New SqlConnection(_cadena)

    End Sub


    Public Function consultar_todos_almacen() As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select N_Movimiento, Compra, Año, Fecha, Tipo_Movimiento, Concepto_Movimiento, Proveedor, Observacion, Usuario from Almacen", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function


    Public Function insertar_datos_almacen(ByRef datos As dAlmacen) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Almacen(N_Movimiento, Compra, Año, Fecha, Tipo_Movimiento, Concepto_Movimiento, Proveedor, Observacion, Usuario) values (@N_Movimiento, @Compra, @Año, @Fecha, @Tipo_Movimiento, @Concepto_Movimiento, @Proveedor, @Observacion, @Usuario)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@N_Movimiento", SqlDbType.Int).Value = datos.N_Movimiento
            _adaptador.InsertCommand.Parameters.Add("@Compra", SqlDbType.Int).Value = datos.Compra
            _adaptador.InsertCommand.Parameters.Add("@Año", SqlDbType.Int).Value = datos.año
            _adaptador.InsertCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 100).Value = datos.fecha
            _adaptador.InsertCommand.Parameters.Add("@Tipo_Movimiento", SqlDbType.VarChar, 100).Value = datos.tipo_movimiento
            _adaptador.InsertCommand.Parameters.Add("@Concepto_Movimiento", SqlDbType.VarChar, 100).Value = datos.concepto_movimiento
            _adaptador.InsertCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 100).Value = datos.proveedor
            _adaptador.InsertCommand.Parameters.Add("@Observacion", SqlDbType.VarChar, 100).Value = datos.observacion
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

    Public Function borrar_datos_almacen(ByVal datos As dAlmacen) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Almacen where N_Movimiento=@N_Movimiento", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@N_Movimiento", SqlDbType.Int).Value = datos.N_Movimiento
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

    Public Function actualizar_datos_almacen(ByRef datos As dAlmacen) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.UpdateCommand = New SqlCommand("update Almacen set Compra=@Compra, Año=@Año, Fecha=@Fecha, Tipo_Movimiento=@Tipo_Movimiento, Concepto_Movimiento=@Concepto_Movimiento, Proveedor=@Proveedor, Observacion=@Observacion, Usuario=@Usuario  where N_Movimiento=@N_Movimiento", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@N_Movimiento", SqlDbType.Int).Value = datos.N_Movimiento
            _adaptador.UpdateCommand.Parameters.Add("@Compra", SqlDbType.Int).Value = datos.Compra
            _adaptador.UpdateCommand.Parameters.Add("@Año", SqlDbType.Int).Value = datos.año
            _adaptador.UpdateCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 100).Value = datos.fecha
            _adaptador.UpdateCommand.Parameters.Add("@Tipo_Movimiento", SqlDbType.VarChar, 100).Value = datos.tipo_movimiento
            _adaptador.UpdateCommand.Parameters.Add("@Concepto_Movimiento", SqlDbType.VarChar, 100).Value = datos.concepto_movimiento
            _adaptador.UpdateCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 100).Value = datos.proveedor
            _adaptador.UpdateCommand.Parameters.Add("@Observacion", SqlDbType.VarChar, 100).Value = datos.observacion
            _adaptador.UpdateCommand.Parameters.Add("@Usuario", SqlDbType.VarChar, 100).Value = datos.Usuario

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

    Public ReadOnly Property tabla() As DataTable
        Get
            Return _tabla
        End Get
    End Property


End Class
