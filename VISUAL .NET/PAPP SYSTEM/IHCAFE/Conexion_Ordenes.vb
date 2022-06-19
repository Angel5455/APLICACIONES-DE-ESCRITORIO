Imports System.Data
Imports System.Data.SqlClient

Public Class Conexion_Ordenes

    Private _cadena As String
    Private _conexion As SqlConnection
    Private _tabla As New DataTable
    Private _adaptador As SqlDataAdapter = New SqlDataAdapter

    Private Sub conexion()
        _cadena = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        _conexion = New SqlConnection(_cadena)

    End Sub


    Public Function consultar_orden(ByVal datos As dOrdenes) As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select * from Ordenes where N_Orden=@N_Orden", _conexion)

            _adaptador.SelectCommand.Parameters.Add("@N_Orden", SqlDbType.Int).Value = datos.N_Orden
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function


    Public Function consultar_todos_ordenes() As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select N_Movimiento, N_Orden, Fecha, Tipo_Movimiento, Concepto_Movimiento, Fase, N_Regional, N_Agencia, N_Prestamo, Año, N_Desembolso, Regional, Agencia, Nombres, Identidad, Clave, Total, Monto_Aprobado, Saldo_Anterior, Monto_Desembolsado, Cantidad_Disponible, Usuario from Ordenes", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function

    Public Function insertar_datos_ordenes(ByRef datos As dOrdenes) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Ordenes(N_Movimiento, N_Orden, Fecha, Tipo_Movimiento, Concepto_Movimiento, Fase, N_Regional, N_Agencia, N_Prestamo, Año, N_Desembolso, Regional, Agencia, Nombres, Identidad, Clave, Total, Monto_Aprobado, Saldo_Anterior, Monto_Desembolsado, Cantidad_Disponible, Usuario) values (@N_Movimiento, @N_Orden, @Fecha, @Tipo_Movimiento, @Concepto_Movimiento, @Fase, @N_Regional, @N_Agencia, @N_Prestamo, @Año, @N_Desembolso, @Regional, @Agencia, @Nombres, @Identidad, @Clave, @Total, @Monto_Aprobado, @Saldo_Anterior, @Monto_Desembolsado, @Cantidad_Disponible, @Usuario)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@N_Movimiento", SqlDbType.Int).Value = datos.N_Movimiento
            _adaptador.InsertCommand.Parameters.Add("@N_Orden", SqlDbType.Int).Value = datos.N_Orden
            _adaptador.InsertCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 100).Value = datos.fecha
            _adaptador.InsertCommand.Parameters.Add("@Tipo_Movimiento", SqlDbType.VarChar, 100).Value = datos.Tipo_Movimiento
            _adaptador.InsertCommand.Parameters.Add("@Concepto_Movimiento", SqlDbType.VarChar, 100).Value = datos.Concepto_Movimiento
            _adaptador.InsertCommand.Parameters.Add("@Fase", SqlDbType.VarChar).Value = datos.fase
            _adaptador.InsertCommand.Parameters.Add("@N_Regional", SqlDbType.Int).Value = datos.N_Regional
            _adaptador.InsertCommand.Parameters.Add("@N_Agencia", SqlDbType.Int).Value = datos.N_Agencia
            _adaptador.InsertCommand.Parameters.Add("@N_Prestamo", SqlDbType.Int).Value = datos.N_Prestamo
            _adaptador.InsertCommand.Parameters.Add("@Año", SqlDbType.Int).Value = datos.año
            _adaptador.InsertCommand.Parameters.Add("@N_Desembolso", SqlDbType.Int).Value = datos.N_Desembolso
            _adaptador.InsertCommand.Parameters.Add("@Regional", SqlDbType.VarChar, 100).Value = datos.regional
            _adaptador.InsertCommand.Parameters.Add("@Agencia", SqlDbType.VarChar, 100).Value = datos.agencia
            _adaptador.InsertCommand.Parameters.Add("@Nombres", SqlDbType.VarChar, 100).Value = datos.nombres
            _adaptador.InsertCommand.Parameters.Add("@Identidad", SqlDbType.VarChar, 15).Value = datos.identidad
            _adaptador.InsertCommand.Parameters.Add("@Clave", SqlDbType.VarChar, 10).Value = datos.clave
            _adaptador.InsertCommand.Parameters.Add("@Total", SqlDbType.Int).Value = datos.total
            _adaptador.InsertCommand.Parameters.Add("@Monto_Aprobado", SqlDbType.Int).Value = datos.Monto_Aprobado
            _adaptador.InsertCommand.Parameters.Add("@Saldo_Anterior", SqlDbType.Int).Value = datos.Saldo_Anterior
            _adaptador.InsertCommand.Parameters.Add("@Monto_Desembolsado", SqlDbType.Int).Value = datos.Monto_Desembolsado
            _adaptador.InsertCommand.Parameters.Add("@Cantidad_Disponible", SqlDbType.Int).Value = datos.Cantidad_Disponible
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

    Public Function actualizar_datos_ordenes(ByRef datos As dOrdenes) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.UpdateCommand = New SqlCommand("update Ordenes set N_Orden=@N_Orden, Fecha=@Fecha, Tipo_Movimiento=@Tipo_Movimiento, Concepto_Movimiento=@Concepto_Movimiento, Fase=@Fase, N_Regional=@N_Regional, N_Agencia=@N_Agencia, N_Prestamo=@N_Prestamo, Año=@Año, N_Desembolso=@N_Desembolso, Regional=@Regional, Agencia=@Agencia, Nombres=@Nombres, Identidad=@Identidad, Clave=@Clave, Total=@Total, Monto_Aprobado=@Monto_Aprobado, Saldo_Anterior=@Saldo_Anterior, Monto_Desembolsado=@Monto_Desembolsado, Cantidad_Disponible=@Cantidad_Disponible, Usuario=@Usuario where N_Movimiento=@N_Movimiento", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@N_Movimiento", SqlDbType.Int).Value = datos.N_Movimiento
            _adaptador.UpdateCommand.Parameters.Add("@N_Orden", SqlDbType.Int).Value = datos.N_Orden
            _adaptador.UpdateCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 100).Value = datos.fecha
            _adaptador.UpdateCommand.Parameters.Add("@Tipo_Movimiento", SqlDbType.VarChar, 100).Value = datos.Tipo_Movimiento
            _adaptador.UpdateCommand.Parameters.Add("@Concepto_Movimiento", SqlDbType.VarChar, 100).Value = datos.Concepto_Movimiento
            _adaptador.UpdateCommand.Parameters.Add("@Fase", SqlDbType.Int).Value = datos.fase
            _adaptador.UpdateCommand.Parameters.Add("@N_Regional", SqlDbType.Int).Value = datos.N_Regional
            _adaptador.UpdateCommand.Parameters.Add("@N_Agencia", SqlDbType.Int).Value = datos.N_Agencia
            _adaptador.UpdateCommand.Parameters.Add("@N_Prestamo", SqlDbType.Int).Value = datos.N_Prestamo
            _adaptador.UpdateCommand.Parameters.Add("@Año", SqlDbType.Int).Value = datos.año
            _adaptador.UpdateCommand.Parameters.Add("@N_Desembolso", SqlDbType.Int).Value = datos.N_Desembolso
            _adaptador.UpdateCommand.Parameters.Add("@Regional", SqlDbType.VarChar, 100).Value = datos.regional
            _adaptador.UpdateCommand.Parameters.Add("@Agencia", SqlDbType.VarChar, 100).Value = datos.agencia
            _adaptador.UpdateCommand.Parameters.Add("@Nombres", SqlDbType.VarChar, 100).Value = datos.nombres
            _adaptador.UpdateCommand.Parameters.Add("@Identidad", SqlDbType.VarChar, 15).Value = datos.identidad
            _adaptador.UpdateCommand.Parameters.Add("@Clave", SqlDbType.VarChar, 10).Value = datos.clave
            _adaptador.UpdateCommand.Parameters.Add("@Total", SqlDbType.Int).Value = datos.año
            _adaptador.UpdateCommand.Parameters.Add("@Monto_Aprobado", SqlDbType.Int).Value = datos.Monto_Aprobado
            _adaptador.UpdateCommand.Parameters.Add("@Saldo_Anterior", SqlDbType.Int).Value = datos.Saldo_Anterior
            _adaptador.UpdateCommand.Parameters.Add("@Monto_Desembolsado", SqlDbType.Int).Value = datos.Monto_Desembolsado
            _adaptador.UpdateCommand.Parameters.Add("@Cantidad_Disponible", SqlDbType.Int).Value = datos.Saldo_Anterior
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

    Public Function borrar_datos_ordenes(ByVal datos As dOrdenes) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Ordenes where N_Movimiento=@N_Movimiento", _conexion)
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

    Public ReadOnly Property tabla() As DataTable
        Get
            Return _tabla
        End Get
    End Property
End Class
