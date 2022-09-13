Imports System.Data
Imports System.Data.SqlClient

Public Class Conexion_Factura

    Private _cadena As String
    Private _conexion As SqlConnection
    Private _cadena2 As String
    Private _conexion2 As SqlConnection
    Private _tabla As New DataTable
    Private _adaptador As SqlDataAdapter = New SqlDataAdapter

    Private Sub conexion()
        _cadena = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        _conexion = New SqlConnection(_cadena)

    End Sub

    

    Public Function consultar_factura(ByVal datos As dFactura) As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select * from Facturas where Factura=@Factura", _conexion)

            _adaptador.SelectCommand.Parameters.Add("@Factura", SqlDbType.Int).Value = datos.factura
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function


    Public Function consultar_todos_factura() As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select N_Movimiento, Factura, Fecha, Tipo_Movimiento, Concepto_Movimiento, Identidad, Nombre, Total from Facturas", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()

        End Try

        Return estado


    End Function


    Public Function insertar_datos_factura(ByRef datos As dFactura) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Facturas(N_Movimiento, Factura, Fecha, Tipo_Movimiento, Concepto_Movimiento, Identidad, Nombre, Total) values (@N_Movimiento, @Factura, @Fecha, @Tipo_Movimiento, @Concepto_Movimiento, @Identidad, @Nombre, @Total)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@N_Movimiento", SqlDbType.Int).Value = datos.N_Movimiento
            _adaptador.InsertCommand.Parameters.Add("@Factura", SqlDbType.Int).Value = datos.factura
            _adaptador.InsertCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 100).Value = datos.fecha
            _adaptador.InsertCommand.Parameters.Add("@Tipo_Movimiento", SqlDbType.VarChar, 100).Value = datos.tipo_movimiento
            _adaptador.InsertCommand.Parameters.Add("@Concepto_Movimiento", SqlDbType.VarChar, 100).Value = datos.concepto_movimiento
            _adaptador.InsertCommand.Parameters.Add("@Identidad", SqlDbType.VarChar, 15).Value = datos.identidad
            _adaptador.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = datos.nombre
            _adaptador.InsertCommand.Parameters.Add("@Total", SqlDbType.Int).Value = datos.total
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


    Public Function actualizar_datos_factura(ByRef datos As dFactura) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.UpdateCommand = New SqlCommand("update Facturas set Factura=@Factura, Fecha=@Fecha, Tipo_Movimiento=@Tipo_Movimiento, Concepto_Movimiento=@Concepto_Movimiento, Identidad=@Identidad, Identidad=@Identidad, Nombre=@Nombre, Total=@Total where N_Movimiento=@N_Movimiento", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@N_Movimiento", SqlDbType.Int).Value = datos.N_Movimiento
            _adaptador.UpdateCommand.Parameters.Add("@Factura", SqlDbType.Int).Value = datos.factura
            _adaptador.UpdateCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 100).Value = datos.fecha
            _adaptador.UpdateCommand.Parameters.Add("@Tipo_Movimiento", SqlDbType.VarChar, 100).Value = datos.tipo_movimiento
            _adaptador.UpdateCommand.Parameters.Add("@Concepto_Movimiento", SqlDbType.VarChar, 100).Value = datos.concepto_movimiento
            _adaptador.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = datos.nombre
            _adaptador.UpdateCommand.Parameters.Add("@Total", SqlDbType.Int).Value = datos.total

            _conexion.Open()
            _adaptador.UpdateCommand.Connection = _conexion
            _adaptador.UpdateCommand.ExecuteNonQuery()
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


    Public Function borrar_datos_factura(ByVal datos As dFactura) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Facturas where Factura=@Factura", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Factura", SqlDbType.Int).Value = datos.factura
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
