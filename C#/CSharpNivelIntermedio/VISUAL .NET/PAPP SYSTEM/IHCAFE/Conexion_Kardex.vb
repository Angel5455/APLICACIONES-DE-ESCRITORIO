Imports System.Data
Imports System.Data.SqlClient


Public Class Conexion_Kardex

    Private _cadena As String
    Private _conexion As SqlConnection
    Private _tabla As New DataTable
    Private _adaptador As SqlDataAdapter = New SqlDataAdapter

    Private Sub conexion()
        _cadena = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        _conexion = New SqlConnection(_cadena)

    End Sub


    Public Function consultar_kardex2(ByVal datos As dKardex) As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select * from Kardex where Fecha=@Fecha, Fecha=@Fecha", _conexion)

            _adaptador.SelectCommand.Parameters.Add("@Insumo", SqlDbType.VarChar, 100).Value = datos.Insumo
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function




    Public Function consultar_kardex(ByVal datos As dKardex) As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select * from Kardex where Insumo=@Insumo", _conexion)

            _adaptador.SelectCommand.Parameters.Add("@Insumo", SqlDbType.VarChar, 100).Value = datos.Insumo
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function




    Public Function consultar_todos_kardex() As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select N_Movimiento, Compra, Factura, Orden, Fecha, Movimiento, Concepto, Codigo, Insumo, Unidad, Proveedor, Cliente, Entrada, Salida, Stock from Kardex", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function

    Public Function insertar_datos_kardex(ByRef datos As dKardex) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Kardex(N_Movimiento, Compra, Factura, Orden, Fecha, Movimiento, Concepto, Codigo, Insumo, Unidad, Proveedor, Cliente, Entrada, Salida, Stock) values (@N_Movimiento, @Compra, @Factura, @Orden, @Fecha, @Movimiento, @Concepto, @Codigo, @Insumo, @Unidad, @Proveedor, @Cliente, @Entrada, @Salida, @Stock)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@N_Movimiento", SqlDbType.Int).Value = datos.N_Movimiento
            _adaptador.InsertCommand.Parameters.Add("@Compra", SqlDbType.VarChar, 50).Value = datos.compra
            _adaptador.InsertCommand.Parameters.Add("@Factura", SqlDbType.VarChar, 50).Value = datos.factura
            _adaptador.InsertCommand.Parameters.Add("@Orden", SqlDbType.VarChar, 50).Value = datos.orden
            _adaptador.InsertCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 100).Value = datos.fecha
            _adaptador.InsertCommand.Parameters.Add("@Movimiento", SqlDbType.VarChar, 100).Value = datos.movimiento
            _adaptador.InsertCommand.Parameters.Add("@Concepto", SqlDbType.VarChar, 100).Value = datos.concepto
            _adaptador.InsertCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.codigo
            _adaptador.InsertCommand.Parameters.Add("@Insumo", SqlDbType.VarChar, 100).Value = datos.Insumo
            _adaptador.InsertCommand.Parameters.Add("@Unidad", SqlDbType.VarChar, 100).Value = datos.unidad
            _adaptador.InsertCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 100).Value = datos.proveedor
            _adaptador.InsertCommand.Parameters.Add("@Cliente", SqlDbType.VarChar, 100).Value = datos.cliente
            _adaptador.InsertCommand.Parameters.Add("@Entrada", SqlDbType.Int).Value = datos.entrada
            _adaptador.InsertCommand.Parameters.Add("@Salida", SqlDbType.Int).Value = datos.salida
            _adaptador.InsertCommand.Parameters.Add("@Stock", SqlDbType.Int).Value = datos.stock


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

    Public Function actualizar_datos_kardex(ByRef datos As dKardex) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.UpdateCommand = New SqlCommand("update Kardex set Fecha=@Fecha, Movimiento=@Movimiento, Compra=@Compra, Factura=@Factura, Orden=@Orden, Concepto=@Concepto, Codigo=@Codigo, Insumo=@Insumo, Unidad=@Unidad, Proveedor=@Proveedor, Cliente=@Cliente, Entrada=@Entrada, Salida=@Salida, Stock=@Stock where N_Movimiento=@N_Movimiento", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@N_Movimiento", SqlDbType.Int).Value = datos.N_Movimiento
            _adaptador.UpdateCommand.Parameters.Add("@Compra", SqlDbType.VarChar, 50).Value = datos.compra
            _adaptador.UpdateCommand.Parameters.Add("@Factura", SqlDbType.VarChar, 50).Value = datos.factura
            _adaptador.UpdateCommand.Parameters.Add("@Orden", SqlDbType.VarChar, 50).Value = datos.factura
            _adaptador.UpdateCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 100).Value = datos.fecha
            _adaptador.UpdateCommand.Parameters.Add("@Movimiento", SqlDbType.VarChar, 100).Value = datos.movimiento
            _adaptador.UpdateCommand.Parameters.Add("@Concepto", SqlDbType.VarChar, 100).Value = datos.concepto
            _adaptador.UpdateCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.codigo
            _adaptador.UpdateCommand.Parameters.Add("@Insumo", SqlDbType.VarChar, 100).Value = datos.Insumo
            _adaptador.UpdateCommand.Parameters.Add("@Unidad", SqlDbType.VarChar, 100).Value = datos.unidad
            _adaptador.UpdateCommand.Parameters.Add("@Proveedor", SqlDbType.VarChar, 100).Value = datos.proveedor
            _adaptador.UpdateCommand.Parameters.Add("@Cliente", SqlDbType.VarChar, 100).Value = datos.cliente
            _adaptador.UpdateCommand.Parameters.Add("@Entrada", SqlDbType.Int).Value = datos.entrada
            _adaptador.UpdateCommand.Parameters.Add("@Salida", SqlDbType.Int).Value = datos.salida
            _adaptador.UpdateCommand.Parameters.Add("@Stock", SqlDbType.Int).Value = datos.stock
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


    Public Function borrar_datos_kardex(ByVal datos As dKardex) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Kardex where N_Movimiento=@N_Movimiento", _conexion)
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

    Public Function borrar_datos_kardexE(ByVal datos As dKardex) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Kardex where Codigo=@Codigo", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.codigo
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

    Public Function borrar_datos_kardexS(ByVal datos As dKardex) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Kardex where Codigo=@Codigo", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 10).Value = datos.codigo
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
