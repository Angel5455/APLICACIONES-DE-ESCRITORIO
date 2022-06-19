Imports System.Data
Imports System.Data.SqlClient

Public Class Conexion_Fases

    Private _cadena As String
    Private _conexion As SqlConnection
    Private _tabla As New DataTable
    Private _adaptador As SqlDataAdapter = New SqlDataAdapter


    Public Function consultar_productor(ByVal datos2 As dFases) As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select * from Productores where Clave=@Clave", _conexion)

            _adaptador.SelectCommand.Parameters.Add("@Clave", SqlDbType.VarChar, 10).Value = datos2.clave
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function


    Public Function consultar_nombre(ByVal datos As dFases) As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select * from General where Nombre=@Nombre", _conexion)

            _adaptador.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = datos.nombre
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function


    Public Function consultar_clave2(ByVal datos As dFases) As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select * from General where Clave=@Clave", _conexion)

            _adaptador.SelectCommand.Parameters.Add("@Clave", SqlDbType.VarChar, 15).Value = datos.clave
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function



    Private Sub conexion()
        _cadena = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        _conexion = New SqlConnection(_cadena)

    End Sub


    Public Function consultar_todos_productor() As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select Clave, Nombre, Identidad, Fecha, Agencia, Municipio, Monto, Observacion, Fase, Foto, ManzanasCafe from Productores", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function




    Public Function consultar_todos_general() As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select  Id, Clave, Nombre, Identidad,  Agencia, Municipio, Monto, Desembolso1, Desembolso2, Desembolso3, Desembolso4, Desembolso5, Desembolso6, Desembolso7, Desembolso8, Desembolso9, Desembolso10, Saldo, Fase, N_D, Año, Foto from General", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function

    Public Function insertar_datos_productor(ByRef datos As dFases) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Productores(Clave, Nombre, Identidad, Fecha, Agencia, Municipio, Monto, Observacion, Fase, Foto, ManzanasCafe) values (@Clave, @Nombre, @Identidad, @Fecha, @Agencia, @Municipio, @Monto, @Observacion, @Fase, @Foto, @ManzanasCafe)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@Clave", SqlDbType.VarChar, 15).Value = datos.clave
            _adaptador.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = datos.nombre
            _adaptador.InsertCommand.Parameters.Add("@Identidad", SqlDbType.VarChar, 15).Value = datos.Identidad
            _adaptador.InsertCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 100).Value = datos.Fecha
            _adaptador.InsertCommand.Parameters.Add("@Agencia", SqlDbType.VarChar, 100).Value = datos.Agencia
            _adaptador.InsertCommand.Parameters.Add("@Municipio", SqlDbType.VarChar, 100).Value = datos.Municipio
            _adaptador.InsertCommand.Parameters.Add("@Monto", SqlDbType.Int).Value = datos.Monto
            _adaptador.InsertCommand.Parameters.Add("@Observacion", SqlDbType.VarChar, 200).Value = datos.observacion
            _adaptador.InsertCommand.Parameters.Add("@Fase", SqlDbType.Int).Value = datos.Fase
            _adaptador.InsertCommand.Parameters.Add("@Foto", SqlDbType.VarChar, 100).Value = datos.Foto
            _adaptador.InsertCommand.Parameters.Add("@ManzanasCafe", SqlDbType.Int).Value = datos.manzanas

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


    Public Function insertar_datos_general(ByRef datos As dFases) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into General(Id, Clave, Nombre, Identidad, Agencia, Municipio, Monto, Desembolso1, Desembolso2, Desembolso3, Desembolso4, Desembolso5, Desembolso6, Desembolso7, Desembolso8, Desembolso9, Desembolso10, Saldo, Fase, N_D, Año, Foto) values (@Id, @Clave, @Nombre, @Identidad, @Agencia, @Municipio, @Monto, @Desembolso1, @Desembolso2, @Desembolso3, @Desembolso4, @Desembolso5, @Desembolso6, @Desembolso7, @Desembolso8, @Desembolso9, @Desembolso10, @Saldo, @Fase, @N_D, @Año, @Foto)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@Id", SqlDbType.Int).Value = datos.id
            _adaptador.InsertCommand.Parameters.Add("@Clave", SqlDbType.VarChar, 10).Value = datos.clave
            _adaptador.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = datos.nombre
            _adaptador.InsertCommand.Parameters.Add("@Identidad", SqlDbType.VarChar, 15).Value = datos.Identidad
            _adaptador.InsertCommand.Parameters.Add("@Agencia", SqlDbType.VarChar, 100).Value = datos.Agencia
            _adaptador.InsertCommand.Parameters.Add("@Municipio", SqlDbType.VarChar, 100).Value = datos.Municipio
            _adaptador.InsertCommand.Parameters.Add("@Monto", SqlDbType.Int).Value = datos.Monto
            _adaptador.InsertCommand.Parameters.Add("@Desembolso1", SqlDbType.Int).Value = datos.D1
            _adaptador.InsertCommand.Parameters.Add("@Desembolso2", SqlDbType.Int).Value = datos.D2
            _adaptador.InsertCommand.Parameters.Add("@Desembolso3", SqlDbType.Int).Value = datos.D3
            _adaptador.InsertCommand.Parameters.Add("@Desembolso4", SqlDbType.Int).Value = datos.D4
            _adaptador.InsertCommand.Parameters.Add("@Desembolso5", SqlDbType.Int).Value = datos.D5
            _adaptador.InsertCommand.Parameters.Add("@Desembolso6", SqlDbType.Int).Value = datos.D6
            _adaptador.InsertCommand.Parameters.Add("@Desembolso7", SqlDbType.Int).Value = datos.D7
            _adaptador.InsertCommand.Parameters.Add("@Desembolso8", SqlDbType.Int).Value = datos.D8
            _adaptador.InsertCommand.Parameters.Add("@Desembolso9", SqlDbType.Int).Value = datos.D9
            _adaptador.InsertCommand.Parameters.Add("@Desembolso10", SqlDbType.Int).Value = datos.D10
            _adaptador.InsertCommand.Parameters.Add("@Saldo", SqlDbType.Int).Value = datos.Saldo
            _adaptador.InsertCommand.Parameters.Add("@Fase", SqlDbType.Int).Value = datos.Fase
            _adaptador.InsertCommand.Parameters.Add("@N_D", SqlDbType.Int).Value = datos.ND
            _adaptador.InsertCommand.Parameters.Add("@Año", SqlDbType.Int).Value = datos.Año
            _adaptador.InsertCommand.Parameters.Add("@Foto", SqlDbType.VarChar, 100).Value = datos.Foto


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

    Public Function actualizar_datos_productor(ByRef datos As dFases) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.UpdateCommand = New SqlCommand("update Productores set Clave=@Clave, Nombre=@Nombre, Identidad=@Identidad, Fecha=@Fecha, Agencia=@Agencia, Municipio=@Municipio, Monto=@Monto, Observacion=@Observacion, Fase=@Fase, Foto=@Foto where Clave=@Clave", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@Clave", SqlDbType.VarChar, 15).Value = datos.clave
            _adaptador.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = datos.nombre
            _adaptador.UpdateCommand.Parameters.Add("@Identidad", SqlDbType.VarChar, 15).Value = datos.Identidad
            _adaptador.UpdateCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 100).Value = datos.Fecha
            _adaptador.UpdateCommand.Parameters.Add("@Agencia", SqlDbType.VarChar, 100).Value = datos.Agencia
            _adaptador.UpdateCommand.Parameters.Add("@Municipio", SqlDbType.VarChar, 100).Value = datos.Municipio
            _adaptador.UpdateCommand.Parameters.Add("@Monto", SqlDbType.Int).Value = datos.Monto
            _adaptador.UpdateCommand.Parameters.Add("@Observacion", SqlDbType.VarChar, 200).Value = datos.observacion
            _adaptador.UpdateCommand.Parameters.Add("@Fase", SqlDbType.Int).Value = datos.Fase
            _adaptador.UpdateCommand.Parameters.Add("@Foto", SqlDbType.VarChar, 100).Value = datos.Foto
            _adaptador.UpdateCommand.Parameters.Add("@ManzanasCafe", SqlDbType.Int).Value = datos.manzanas


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



    Public Function actualizar_datos_general(ByRef datos As dFases) As Boolean

        Dim estado As Boolean = True

        conexion()
        _adaptador.UpdateCommand = New SqlCommand("update General set Id=@Id, Clave=@Clave, Nombre=@Nombre, Identidad=@Identidad, Agencia=@Agencia, Municipio=@Municipio, Monto=@Monto, Desembolso1=@Desembolso1, Desembolso2=@Desembolso2, Desembolso3=@Desembolso3, Desembolso4=@Desembolso4, Desembolso5=@Desembolso5, Desembolso6=@Desembolso6, Desembolso7=@Desembolso7, Desembolso8=@Desembolso8, Desembolso9=@Desembolso9, Desembolso10=@Desembolso10, Saldo=@Saldo, Fase=@Fase, N_D=@N_D, Año=@Año, Foto=@Foto where Id=@Id", _conexion)
        _adaptador.UpdateCommand.Parameters.Add("@Id", SqlDbType.Int).Value = datos.id
        _adaptador.UpdateCommand.Parameters.Add("@Clave", SqlDbType.VarChar, 10).Value = datos.clave
        _adaptador.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = datos.nombre
        _adaptador.UpdateCommand.Parameters.Add("@Identidad", SqlDbType.VarChar, 15).Value = datos.Identidad
        _adaptador.UpdateCommand.Parameters.Add("@Agencia", SqlDbType.VarChar, 100).Value = datos.Agencia
        _adaptador.UpdateCommand.Parameters.Add("@Municipio", SqlDbType.VarChar, 100).Value = datos.Municipio
        _adaptador.UpdateCommand.Parameters.Add("@Monto", SqlDbType.Int).Value = datos.Monto
        _adaptador.UpdateCommand.Parameters.Add("@Desembolso1", SqlDbType.Int).Value = datos.D1
        _adaptador.UpdateCommand.Parameters.Add("@Desembolso2", SqlDbType.Int).Value = datos.D2
        _adaptador.UpdateCommand.Parameters.Add("@Desembolso3", SqlDbType.Int).Value = datos.D3
        _adaptador.UpdateCommand.Parameters.Add("@Desembolso4", SqlDbType.Int).Value = datos.D4
        _adaptador.UpdateCommand.Parameters.Add("@Desembolso5", SqlDbType.Int).Value = datos.D5
        _adaptador.UpdateCommand.Parameters.Add("@Desembolso6", SqlDbType.Int).Value = datos.D6
        _adaptador.UpdateCommand.Parameters.Add("@Desembolso7", SqlDbType.Int).Value = datos.D7
        _adaptador.UpdateCommand.Parameters.Add("@Desembolso8", SqlDbType.Int).Value = datos.D8
        _adaptador.UpdateCommand.Parameters.Add("@Desembolso9", SqlDbType.Int).Value = datos.D9
        _adaptador.UpdateCommand.Parameters.Add("@Desembolso10", SqlDbType.Int).Value = datos.D10
        _adaptador.UpdateCommand.Parameters.Add("@Saldo", SqlDbType.Int).Value = datos.Saldo
        _adaptador.UpdateCommand.Parameters.Add("@Fase", SqlDbType.Int).Value = datos.Fase
        _adaptador.UpdateCommand.Parameters.Add("@N_D", SqlDbType.Int).Value = datos.ND
        _adaptador.UpdateCommand.Parameters.Add("@Año", SqlDbType.Int).Value = datos.Año
        _adaptador.UpdateCommand.Parameters.Add("@Foto", SqlDbType.VarChar, 100).Value = datos.Foto

        _conexion.Open()
        _adaptador.UpdateCommand.Connection = _conexion
        _adaptador.UpdateCommand.ExecuteNonQuery()


        Return estado

    End Function




    Public Function borrar_datos_productor(ByVal datos As dFases) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from Productores where Clave=@Clave", _conexion)
            _adaptador.DeleteCommand.Parameters.Add("@Clave", SqlDbType.VarChar, 15).Value = datos.clave
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



    Public Function borrar_datos_general(ByVal datos As dFases) As Boolean

        Dim estado As Boolean = True

        Try

            conexion()
            _adaptador.DeleteCommand = New SqlCommand("Delete from General where Id=@Id", _conexion)
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


    Public ReadOnly Property tabla() As DataTable
        Get
            Return _tabla
        End Get
    End Property



    Private Sub cerrar()

        _conexion.Close()

    End Sub

End Class
