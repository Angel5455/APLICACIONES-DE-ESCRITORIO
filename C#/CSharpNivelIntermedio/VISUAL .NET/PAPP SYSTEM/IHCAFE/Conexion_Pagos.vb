Imports System.Data
Imports System.Data.SqlClient

Public Class Conexion_Pagos

    Private _cadena As String
    Private _conexion As SqlConnection
    Private _tabla As New DataTable
    Private _adaptador As SqlDataAdapter = New SqlDataAdapter


    Private Sub conexion()
        _cadena = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        _conexion = New SqlConnection(_cadena)

    End Sub

    Public Function consultar_recibos(ByVal datos As dPagos) As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select * from Pagos where Clave=@Clave", _conexion)

            _adaptador.SelectCommand.Parameters.Add("@Clave", SqlDbType.VarChar, 15).Value = datos.clave
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function


    Public Function consultar_todos_pagos() As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select Clave, Identidad, Nombre, Agencia, Municipio, Fase, Monto, N_Abono, Abono1, Abono2, Abono3, Saldo, Foto, Fecha, Usuario from Pagos", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()

        End Try

        Return estado

    End Function

    Public Function insertar_datos_pagos(ByRef datos As dPagos) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Pagos(Clave, Identidad, Nombre, Agencia, Municipio, Fase, Monto, N_Abono, Abono1, Abono2, Abono3, Saldo, Foto, Fecha, Usuario, Letras) values (@Clave, @Identidad, @Nombre, @Agencia, @Municipio, @Fase, @Monto, @N_Abono, @Abono1, @Abono2, @Abono3, @Saldo, @Foto, @Fecha, @Usuario, @Letras)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@Clave", SqlDbType.VarChar, 15).Value = datos.clave
            _adaptador.InsertCommand.Parameters.Add("@Identidad", SqlDbType.VarChar, 15).Value = datos.Identidad
            _adaptador.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = datos.nombre
            _adaptador.InsertCommand.Parameters.Add("@Agencia", SqlDbType.VarChar, 100).Value = datos.Agencia
            _adaptador.InsertCommand.Parameters.Add("@Municipio", SqlDbType.VarChar, 100).Value = datos.Municipio
            _adaptador.InsertCommand.Parameters.Add("@Fase", SqlDbType.Int).Value = datos.Fase
            _adaptador.InsertCommand.Parameters.Add("@Monto", SqlDbType.Int).Value = datos.Monto
            _adaptador.InsertCommand.Parameters.Add("@N_Abono", SqlDbType.Int).Value = datos.NA
            _adaptador.InsertCommand.Parameters.Add("@Abono1", SqlDbType.Decimal, 18, 2).Value = datos.A1
            _adaptador.InsertCommand.Parameters.Add("@Abono2", SqlDbType.Decimal, 18, 2).Value = datos.A2
            _adaptador.InsertCommand.Parameters.Add("@Abono3", SqlDbType.Decimal, 18, 2).Value = datos.A3
            _adaptador.InsertCommand.Parameters.Add("@Saldo", SqlDbType.Decimal, 18, 2).Value = datos.Saldo
            _adaptador.InsertCommand.Parameters.Add("@Foto", SqlDbType.VarChar, 100).Value = datos.Foto
            _adaptador.InsertCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 100).Value = datos.Fecha
            _adaptador.InsertCommand.Parameters.Add("@Usuario", SqlDbType.VarChar, 100).Value = datos.Usuario
            _adaptador.InsertCommand.Parameters.Add("@Letras", SqlDbType.VarChar, 100).Value = datos.letras


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


    Public Function actualizar_datos_pagos(ByRef datos As dPagos) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.UpdateCommand = New SqlCommand("update Pagos set Clave=@Clave, Identidad=@Identidad, Nombre=@Nombre, Agencia=@Agencia, Municipio=@Municipio, Fase=@Fase, Monto=@Monto, N_Abono=@N_Abono, Abono1=@Abono1, Abono2=@Abono2, Abono3=@Abono3, Saldo=@Saldo, Foto=@Foto, Fecha=@Fecha, Usuario=@Usuario where Clave=@Clave", _conexion)
            _adaptador.UpdateCommand.Parameters.Add("@Clave", SqlDbType.VarChar, 15).Value = datos.clave
            _adaptador.UpdateCommand.Parameters.Add("@Identidad", SqlDbType.VarChar, 15).Value = datos.Identidad
            _adaptador.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = datos.nombre
            _adaptador.UpdateCommand.Parameters.Add("@Agencia", SqlDbType.VarChar, 100).Value = datos.Agencia
            _adaptador.UpdateCommand.Parameters.Add("@Municipio", SqlDbType.VarChar, 100).Value = datos.Municipio
            _adaptador.UpdateCommand.Parameters.Add("@Fase", SqlDbType.Int).Value = datos.Fase
            _adaptador.UpdateCommand.Parameters.Add("@Monto", SqlDbType.Int).Value = datos.Monto
            _adaptador.UpdateCommand.Parameters.Add("@N_Abono", SqlDbType.Decimal, 18, 2).Value = datos.NA
            _adaptador.UpdateCommand.Parameters.Add("@Abono1", SqlDbType.Decimal, 18, 2).Value = datos.A1
            _adaptador.UpdateCommand.Parameters.Add("@Abono2", SqlDbType.Decimal, 18, 2).Value = datos.A2
            _adaptador.UpdateCommand.Parameters.Add("@Abono3", SqlDbType.Decimal, 18, 2).Value = datos.A3
            _adaptador.UpdateCommand.Parameters.Add("@Saldo", SqlDbType.Int).Value = datos.Saldo
            _adaptador.UpdateCommand.Parameters.Add("@Foto", SqlDbType.VarChar, 100).Value = datos.Foto
            _adaptador.UpdateCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 100).Value = datos.Fecha
            _adaptador.UpdateCommand.Parameters.Add("@Usuario", SqlDbType.VarChar, 100).Value = datos.Usuario
            _adaptador.UpdateCommand.Parameters.Add("@Letras", SqlDbType.VarChar, 100).Value = datos.letras


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
