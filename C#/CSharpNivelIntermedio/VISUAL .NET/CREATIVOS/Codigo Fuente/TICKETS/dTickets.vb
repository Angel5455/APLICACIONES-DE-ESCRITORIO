Public Class dTickets

    Private _ticket As Integer
    Private _fecha As String
    Private _nombre As String
    Private _total As Integer
    Private _mes As String
    Private _hora As String

    Dim conexion As New DataClasses1DataContext()
    Dim query
    Event errores(ByVal nombres As String)
    Public Property Ticket() As Integer
        Get
            Return _ticket
        End Get

        Set(ByVal value As Integer)
            _ticket = value
        End Set
    End Property


    Public Property fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property


    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property


    Public Property total() As Integer
        Get
            Return _total
        End Get

        Set(ByVal value As Integer)
            _total = value
        End Set
    End Property

    Public Property mes() As String
        Get
            Return _mes
        End Get
        Set(ByVal value As String)
            _mes = value
        End Set
    End Property

    Public Property hora() As String
        Get
            Return _hora
        End Get
        Set(ByVal value As String)
            _hora = value
        End Set
    End Property

    Function numero_ticket() As Integer
        query = (From n In conexion.Tickets Select n).Count + 1
        Return query
    End Function

    Public Sub insertar_ticket(ByVal ticket As Integer, ByVal fecha As String, ByVal nombre As String, ByVal total As Integer, ByVal mes As String, ByVal hora As String)

        Dim servicionuevo As New Tickets
        servicionuevo.Ticket = ticket
        servicionuevo.Fecha = fecha
        servicionuevo.Nombre = nombre
        servicionuevo.Total = total
        servicionuevo.Hora = hora
        servicionuevo.Mes = mes

        conexion.Tickets.InsertOnSubmit(servicionuevo)
        conexion.SubmitChanges()

    End Sub


    Public Sub modificar_ticket(ByVal Ticket As String, ByVal Fecha As String, ByVal Nombre As String, ByVal Total As Integer, ByVal Mes As String, ByVal Hora As String)


        Dim modificar = (From n In conexion.Tickets Where n.Ticket = Ticket Select n).Single
        modificar.Ticket = Ticket
        modificar.Fecha = Fecha
        modificar.Nombre = Nombre
        modificar.Total = Total
        modificar.Mes = Mes
        modificar.Hora = Hora


        conexion.SubmitChanges()

    End Sub


End Class
