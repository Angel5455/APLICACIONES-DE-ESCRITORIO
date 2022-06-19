Public Class dAlmacen

    '' Variables para la tabla Almacen

    Private _N_Movimiento As Integer
    Private _Compra As String
    Private _Año As Integer
    Private _fecha As String
    Private _tipo_movimiento As String
    Private _concepto_movimiento As String
    Private _cliente As String
    Private _proveedor As String
    Private _observacion As String
    Private _usuario As String


    Public Property N_Movimiento() As Integer
        Get
            Return _N_Movimiento
        End Get

        Set(ByVal value As Integer)
            _N_Movimiento = value
        End Set

    End Property

    Public Property Compra() As Integer
        Get
            Return _Compra
        End Get

        Set(ByVal value As Integer)
            _Compra = value
        End Set

    End Property

    Public Property año() As Integer
        Get
            Return _Año
        End Get

        Set(ByVal value As Integer)
            _Año = value
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

    Public Property cliente() As String
        Get
            Return _cliente
        End Get

        Set(ByVal value As String)
            _cliente = value
        End Set

    End Property

    Public Property proveedor() As String
        Get
            Return _proveedor
        End Get

        Set(ByVal value As String)
            _proveedor = value
        End Set

    End Property

    Public Property observacion() As String
        Get
            Return _observacion
        End Get

        Set(ByVal value As String)
            _observacion = value
        End Set

    End Property

    Public Property Usuario() As String
        Get
            Return _usuario
        End Get

        Set(ByVal value As String)
            _usuario = value
        End Set

    End Property

End Class
