Imports System.Data
Imports System.Data.SqlClient

Public Class Conexion_Ticket
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

    Function numero() As Integer
        query = (From n In conexionL.Tickets Select n).Count + 1
        Return query
    End Function

    Function numero_usuarios() As Integer
        query = (From n In conexionL.Usuarios Select n).Count + 1
        Return query
    End Function




    Public Function consultar_ticket(ByVal datos As dTickets) As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select * from Tickets where Ticket=@Ticket and Nombre=@Nombre", _conexion)

            _adaptador.SelectCommand.Parameters.Add("@Ticket", SqlDbType.Int).Value = datos.Ticket
            _adaptador.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 100).Value = datos.nombre
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function

    Public Function consultar_descripcion(ByVal datos As dTickets) As Boolean

        Dim estado As Boolean = True

        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select * from Descripcion where Ticket=@Ticket", _conexion)

            _adaptador.SelectCommand.Parameters.Add("@Ticket", SqlDbType.Int).Value = datos.Ticket

            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()


        End Try

        Return estado


    End Function

    Public Function consultar_todos_tickets() As Boolean
        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.SelectCommand = New SqlCommand("Select Ticket, Fecha, Nombre, Total, Mes, Hora from Tickets", _conexion)
            _adaptador.Fill(_tabla)
        Catch ex As Exception

            estado = False
        Finally

            cerrar()
        End Try

        Return estado

    End Function


    Public Sub insertar_usuarios(ByVal id As Integer, ByVal usuario As String, ByVal contraseña As String, ByVal cargo As String)

        Dim servicionuevo As New Usuarios
        servicionuevo.Id = id
        servicionuevo.Usuario = usuario
        servicionuevo.Contraseña = contraseña
        servicionuevo.Cargo = cargo



        conexionL.Usuarios.InsertOnSubmit(servicionuevo)
        conexionL.SubmitChanges()

    End Sub

    Public Sub modificar_usuario(ByVal id As Integer, ByVal usuario As String, ByVal contraseña As String, ByVal cargo As String)


        Dim modificar = (From n In conexionL.Usuarios Where n.Id = id Select n).Single
        modificar.Id = id
        modificar.Usuario = usuario
        modificar.Contraseña = contraseña
        modificar.Cargo = cargo
        conexionL.SubmitChanges()

    End Sub


    Public Function insertar_datos_tickets(ByRef datos As dTickets) As Boolean

        Dim estado As Boolean = True
        Try
            conexion()
            _adaptador.InsertCommand = New SqlCommand("insert into Tickets(Ticket, Fecha, Nombre, Total, Mes, Hora) values (@Ticket, @Fecha, @Nombre, @Total, @Mes, @Hora)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@Ticket", SqlDbType.Int).Value = datos.Ticket
            _adaptador.InsertCommand.Parameters.Add("@Fecha", SqlDbType.VarChar, 50).Value = datos.fecha
            _adaptador.InsertCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = datos.nombre
            _adaptador.InsertCommand.Parameters.Add("@Total", SqlDbType.Int).Value = datos.total
            _adaptador.InsertCommand.Parameters.Add("@Mes", SqlDbType.VarChar, 50).Value = datos.mes
            _adaptador.InsertCommand.Parameters.Add("@Hora", SqlDbType.VarChar, 50).Value = datos.hora

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
