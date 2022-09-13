Public Class dFactura

    Private _N_Movimiento As Integer
    Private _factura As Integer
    Private _fecha As String
    Private _tipo_movimiento As String
    Private _concepto_movimiento As String
    Private _identidad As String
    Private _nombre As String
    Private _total As Integer

    Public Property N_Movimiento() As Integer
        Get
            Return _N_Movimiento
        End Get

        Set(ByVal value As Integer)
            _N_Movimiento = value
        End Set

    End Property




    Public Property factura() As Integer
        Get
            Return _factura
        End Get

        Set(ByVal value As Integer)
            _factura = value
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

    Public Property tipo_movimiento() As String

        Get
            Return _tipo_movimiento
        End Get
        Set(ByVal value As String)
            _tipo_movimiento = value
        End Set
    End Property

    Public Property concepto_movimiento() As String

        Get
            Return _concepto_movimiento
        End Get
        Set(ByVal value As String)
            _concepto_movimiento = value
        End Set
    End Property


    Public Property identidad() As String

        Get
            Return _identidad
        End Get
        Set(ByVal value As String)
            _identidad = value
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


End Class
