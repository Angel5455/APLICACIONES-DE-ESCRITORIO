Public Class dDescripcion

    Private _ticket As Integer
    Private _descripcion As String
    Private _cantidad As Integer
    Private _precio As Integer
    Private _subtotal As Integer


    Public Property ticket() As Integer
        Get
            Return _ticket
        End Get

        Set(ByVal value As Integer)
            _ticket = value
        End Set
    End Property



    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property cantidad() As Integer
        Get
            Return _cantidad
        End Get

        Set(ByVal value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Property precio() As Integer
        Get
            Return _precio
        End Get

        Set(ByVal value As Integer)
            _precio = value
        End Set
    End Property

    Public Property subtotal() As Integer
        Get
            Return _subtotal
        End Get

        Set(ByVal value As Integer)
            _subtotal = value
        End Set
    End Property

End Class
