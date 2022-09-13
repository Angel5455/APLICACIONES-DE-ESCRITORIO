Public Class dKardex

    '' Variables para la tabla de Kardex

    Private _N_Movimiento As Integer
    Private _compra As String
    Private _factura As String
    Private _orden As String
    Private _fecha As String
    Private _movimiento As String
    Private _codigo As String
    Private _insumo As String
    Private _unidad As String
    Private _concepto As String
    Private _proveedor As String
    Private _cliente As String
    Private _entrada As Integer
    Private _salida As Integer
    Private _stock As Integer
    

    Public Property N_Movimiento() As Integer
        Get
            Return _N_Movimiento
        End Get

        Set(ByVal value As Integer)
            _N_Movimiento = value
        End Set

    End Property

    Public Property compra() As String
        Get
            Return _compra
        End Get

        Set(ByVal value As String)
            _compra = value
        End Set

    End Property

    Public Property factura() As String
        Get
            Return _factura
        End Get

        Set(ByVal value As String)
            _factura = value
        End Set

    End Property

    Public Property orden() As String
        Get
            Return _orden
        End Get

        Set(ByVal value As String)
            _orden = value
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


    Public Property movimiento() As String
        Get
            Return _movimiento
        End Get

        Set(ByVal value As String)
            _movimiento = value
        End Set

    End Property


    Public Property codigo() As String
        Get
            Return _codigo
        End Get

        Set(ByVal value As String)
            _codigo = value
        End Set

    End Property



    Public Property Insumo() As String
        Get
            Return _insumo
        End Get

        Set(ByVal value As String)
            _insumo = value
        End Set

    End Property


    Public Property unidad() As String
        Get
            Return _unidad
        End Get

        Set(ByVal value As String)
            _unidad = value
        End Set

    End Property



    Public Property concepto() As String
        Get
            Return _concepto
        End Get

        Set(ByVal value As String)
            _concepto = value
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



    Public Property cliente() As String
        Get
            Return _cliente
        End Get

        Set(ByVal value As String)
            _cliente = value
        End Set

    End Property


    Public Property entrada() As Integer
        Get
            Return _entrada
        End Get

        Set(ByVal value As Integer)
            _entrada = value
        End Set

    End Property


    Public Property salida() As Integer
        Get
            Return _salida
        End Get

        Set(ByVal value As Integer)
            _salida = value
        End Set

    End Property


    Public Property stock() As Integer
        Get
            Return _stock
        End Get

        Set(ByVal value As Integer)
            _stock = value
        End Set

    End Property


End Class
