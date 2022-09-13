Imports System.Data
Imports System.Data.SqlClient

Public Class Conexion_Configuracion

    Private _cadena As String
    Private _conexion As SqlConnection
    Private _tabla As New DataTable
    Private _adaptador As SqlDataAdapter = New SqlDataAdapter

    Private Sub conexion()

        _cadena = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        _conexion = New SqlConnection(_cadena)

    End Sub


    Public Function consultar_todos_configuracion() As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select Fase, Fecha, Usuario from Configuracion", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function


    Public Function insertar_datos_configuracion(ByRef datos As dConfiguracion) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Configuracion(Fase, Fecha, Usuario) values (@Fase, @Fecha, @Usuario)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@Fase", SqlDbType.Int).Value = datos.fase
            _adaptador.InsertCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 100).Value = datos.fecha
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

    Public ReadOnly Property tabla() As DataTable
        Get
            Return _tabla
        End Get
    End Property


End Class
