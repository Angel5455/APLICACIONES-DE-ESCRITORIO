Public Class dProductos

    '' Variables para la tabla de Productos y PG

    Private _N_Movimiento1 As Integer
    Private _compra As Integer
    Private _codigo1 As String
    Private _insumos1 As String
    Private _unidad1 As String
    Private _cantidad1 As Integer
    Private _precio1 As Integer
    Private _subtotal1 As Integer


    '' Variables para la tabla de Productos y PG

    Private _N_Movimiento2 As Integer
    Private _factura As Integer
    Private _codigo2 As String
    Private _insumos2 As String
    Private _unidad2 As String
    Private _cantidad2 As Integer
    Private _precio2 As Integer
    Private _subtotal2 As Integer



    '' Variables para la tabla de Articulos//Isumos

    Private _codigoA As String
    Private _nombre As String
    Private _linea As String
    Private _unidadA As String
    Private _stock As Integer
    Private _precioA As Integer
    Private _proveedor As String
    Private _estado As String


    'Variables para la tabla de Etiquetas 

    Private _codigoE As String
    Private _insumoE As String
    Private _unidadE As String

    Public Property compra() As Integer
        Get
            Return _compra
        End Get

        Set(ByVal value As Integer)
            _compra = value
        End Set

    End Property


    Public Property N_Movimiento1() As Integer
        Get
            Return _N_Movimiento1
        End Get

        Set(ByVal value As Integer)
            _N_Movimiento1 = value
        End Set

    End Property



    Public Property codigo1() As String
        Get
            Return _codigo1
        End Get

        Set(ByVal value As String)
            _codigo1 = value
        End Set

    End Property

    Public Property insumos1() As String
        Get
            Return _insumos1
        End Get

        Set(ByVal value As String)
            _insumos1 = value
        End Set

    End Property

    Public Property unidad1() As String
        Get
            Return _unidad1
        End Get

        Set(ByVal value As String)
            _unidad1 = value
        End Set

    End Property

    Public Property cantidad1() As Integer
        Get
            Return _cantidad1
        End Get

        Set(ByVal value As Integer)
            _cantidad1 = value
        End Set

    End Property

    Public Property precio1() As Integer
        Get
            Return _precio1
        End Get

        Set(ByVal value As Integer)
            _precio1 = value
        End Set

    End Property

    Public Property subtotal1() As Integer
        Get
            Return _subtotal1
        End Get

        Set(ByVal value As Integer)
            _subtotal1 = value
        End Set

    End Property

    '*******************************

    Public Property factura() As Integer
        Get
            Return _factura
        End Get

        Set(ByVal value As Integer)
            _factura = value
        End Set

    End Property


    Public Property N_Movimiento2() As Integer
        Get
            Return _N_Movimiento2
        End Get

        Set(ByVal value As Integer)
            _N_Movimiento2 = value
        End Set

    End Property



    Public Property codigo2() As String
        Get
            Return _codigo2
        End Get

        Set(ByVal value As String)
            _codigo2 = value
        End Set

    End Property

    Public Property insumos2() As String
        Get
            Return _insumos2
        End Get

        Set(ByVal value As String)
            _insumos2 = value
        End Set

    End Property

    Public Property unidad2() As String
        Get
            Return _unidad2
        End Get

        Set(ByVal value As String)
            _unidad2 = value
        End Set

    End Property

    Public Property cantidad2() As Integer
        Get
            Return _cantidad2
        End Get

        Set(ByVal value As Integer)
            _cantidad2 = value
        End Set

    End Property

    Public Property precio2() As Integer
        Get
            Return _precio2
        End Get

        Set(ByVal value As Integer)
            _precio2 = value
        End Set

    End Property

    Public Property subtotal2() As Integer
        Get
            Return _subtotal2
        End Get

        Set(ByVal value As Integer)
            _subtotal2 = value
        End Set

    End Property







    '******************************

    Public Property CodigoA() As String
        Get
            Return _codigoA
        End Get

        Set(ByVal value As String)
            _codigoA = value
        End Set

    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get

        Set(ByVal value As String)
            _nombre = value
        End Set

    End Property

    Public Property linea() As String
        Get
            Return _linea
        End Get

        Set(ByVal value As String)
            _linea = value
        End Set

    End Property

    Public Property UnidadA() As String
        Get
            Return _unidadA
        End Get

        Set(ByVal value As String)
            _unidadA = value
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


    Public Property precioA() As Integer
        Get
            Return _precioA
        End Get

        Set(ByVal value As Integer)
            _precioA = value
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


    Public Property estado() As String
        Get
            Return _estado
        End Get

        Set(ByVal value As String)
            _estado = value
        End Set

    End Property


    Public Property codigoE() As String
        Get
            Return _codigoE
        End Get

        Set(ByVal value As String)
            _codigoE = value
        End Set

    End Property


    Public Property insumoE() As String
        Get
            Return _insumoE
        End Get

        Set(ByVal value As String)
            _insumoE = value
        End Set

    End Property


    Public Property unidadE() As String
        Get
            Return _unidadE
        End Get

        Set(ByVal value As String)
            _unidadE = value
        End Set

    End Property

End Class



