Public Class dTickets

    Private _ticket As Integer
    Private _fecha As String
    Private _nombre As String
    Private _total As Integer
    Private _mes As String
    Private _hora As String


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

End Class
