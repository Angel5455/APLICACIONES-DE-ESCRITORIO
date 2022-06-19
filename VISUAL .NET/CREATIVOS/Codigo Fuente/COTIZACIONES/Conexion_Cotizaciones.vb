Imports System.Data
Imports System.Data.SqlClient

Public Class Conexion_Cotizaciones

    Dim query
    Dim conexionL As New DataClasses1DataContext
    Dim consultas As New Tickets



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

  

    Public Function consultar_cotizacion(ByVal datos As dCotizaciones) As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select * from Cotizaciones where Cotizacion=@Cotizacion", _conexion)

            _adaptador.SelectCommand.Parameters.Add("@Cotizacion", SqlDbType.Int).Value = datos.Cotizacion
            _adaptador.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = datos.nombre
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function


    Public Function consultar_todos_Cotizaciones() As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select Cotizacion, Fecha, Nombre, Total from Cotizaciones", _conexion)
            _adaptador.Fill(_tabla)
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
