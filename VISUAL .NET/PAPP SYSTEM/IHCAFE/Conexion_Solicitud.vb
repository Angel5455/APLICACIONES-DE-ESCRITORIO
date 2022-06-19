Imports System.Data
Imports System.Data.SqlClient


Public Class Conexion_Solicitud

    Private _cadena As String
    Private _conexion As SqlConnection
    Private _tabla As New DataTable
    Private _adaptador As SqlDataAdapter = New SqlDataAdapter


    Private Sub conexion()
        _cadena = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        _conexion = New SqlConnection(_cadena)

    End Sub

    Public Function consultar_solicitud(ByVal datos As dSolicitud) As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select * from Solicitud where N_Solicitud=@N_Solicitud", _conexion)

            _adaptador.SelectCommand.Parameters.Add("@N_Solicitud", SqlDbType.Int).Value = datos.nSolicitud
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function



    Public Function consultar_todos_solicitud() As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select N_Solicitud, Fase, Clave, Identidad, Nombre, Edad, FechaN, EstadoCivil, Conyuge, Domicilio, Aldea, Municipio, Departamento, Monto, Plazo, LugarInversion, FormaPago, Destino, Aportacion, FechaS, FechaV, Manzanas, MontoLetras from Solicitud", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()

        End Try

        Return estado

    End Function

    Public Function insertar_datos_solicitud(ByRef datos As dSolicitud) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Solicitud(N_Solicitud, Fase, Clave, Identidad, Nombre, Edad, FechaN, EstadoCivil, Conyuge, Domicilio, Aldea, Municipio, Departamento, Monto, Plazo, LugarInversion, FormaPago, Destino, Aportacion, FechaS, FechaV, Manzanas, MontoLetras) values (@N_Solicitud, @Fase, @Clave, @Identidad, @Nombre, @Edad, @FechaN, @EstadoCivil, @Conyuge, @Domicilio, @Aldea, @Municipio, @Departamento, @Monto, @Plazo, @LugarInversion, @FormaPago, @Destino, @Aportacion, @FechaS, @FechaV, @Manzanas, @MontoLetras)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@N_Solicitud", SqlDbType.Int).Value = datos.nSolicitud
            _adaptador.InsertCommand.Parameters.Add("@Fase", SqlDbType.Int).Value = datos.Fase
            _adaptador.InsertCommand.Parameters.Add("@Clave", SqlDbType.VarChar, 15).Value = datos.clave
            _adaptador.InsertCommand.Parameters.Add("@Identidad", SqlDbType.VarChar, 15).Value = datos.identidad
            _adaptador.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = datos.nombre
            _adaptador.InsertCommand.Parameters.Add("@Edad", SqlDbType.Int).Value = datos.edad
            _adaptador.InsertCommand.Parameters.Add("@FechaN", SqlDbType.VarChar, 100).Value = datos.fechaN
            _adaptador.InsertCommand.Parameters.Add("@EstadoCivil", SqlDbType.VarChar, 100).Value = datos.estado
            _adaptador.InsertCommand.Parameters.Add("@Conyuge", SqlDbType.VarChar, 100).Value = datos.conyuge
            _adaptador.InsertCommand.Parameters.Add("@Domicilio", SqlDbType.VarChar, 100).Value = datos.domicilio
            _adaptador.InsertCommand.Parameters.Add("@Aldea", SqlDbType.VarChar, 100).Value = datos.aldea
            _adaptador.InsertCommand.Parameters.Add("@Municipio", SqlDbType.VarChar, 100).Value = datos.municipio
            _adaptador.InsertCommand.Parameters.Add("@Departamento", SqlDbType.VarChar, 100).Value = datos.departamento
            _adaptador.InsertCommand.Parameters.Add("@Monto", SqlDbType.Int).Value = datos.monto
            _adaptador.InsertCommand.Parameters.Add("@Plazo", SqlDbType.VarChar, 100).Value = datos.plazo
            _adaptador.InsertCommand.Parameters.Add("@LugarInversion", SqlDbType.VarChar, 100).Value = datos.lugar
            _adaptador.InsertCommand.Parameters.Add("@FormaPago", SqlDbType.VarChar, 100).Value = datos.pago
            _adaptador.InsertCommand.Parameters.Add("@Destino", SqlDbType.VarChar, 100).Value = datos.destino
            _adaptador.InsertCommand.Parameters.Add("@Aportacion", SqlDbType.VarChar, 100).Value = datos.aportacion
            _adaptador.InsertCommand.Parameters.Add("@FechaS", SqlDbType.VarChar, 100).Value = datos.fechaS
            _adaptador.InsertCommand.Parameters.Add("@FechaV", SqlDbType.VarChar, 100).Value = datos.fechaV
            _adaptador.InsertCommand.Parameters.Add("@Manzanas", SqlDbType.Int).Value = datos.manzanas
            _adaptador.InsertCommand.Parameters.Add("@MontoLetras", SqlDbType.VarChar, 100).Value = datos.letras
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

    Public ReadOnly Property tabla() As DataTable
        Get
            Return _tabla
        End Get
    End Property



End Class
