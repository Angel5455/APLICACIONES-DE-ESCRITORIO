Public Class dOrdenes

    '' Variables para la tabla de Ordenes

    Private _N_Movimiento As Integer
    Private _N_Orden As Integer
    Private _fecha As String
    Private _Tipo_Movimiento As String
    Private _Concepto_Movimiento As String
    Private _fase As Integer
    Private _N_Regional As Integer
    Private _N_Agencia As Integer
    Private _N_Prestamo As Integer
    Private _año As Integer
    Private _N_Desembolso As Integer
    Private _regional As String
    Private _agencia As String
    Private _nombres As String
    Private _identidad As String
    Private _clave As String
    Private _total As Integer
    Private _Monto_Aprobado As Integer
    Private _Saldo_Anterior As Integer
    Private _Monto_Desembolsado As Integer
    Private _Cantidad_Disponible As Integer
    Private _usuario As String



    Public Property N_Movimiento() As Integer
        Get
            Return _N_Movimiento
        End Get

        Set(ByVal value As Integer)
            _N_Movimiento = value
        End Set

    End Property


    Public Property N_Orden() As Integer
        Get
            Return _N_Orden
        End Get

        Set(ByVal value As Integer)
            _N_Orden = value
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

    Public Property Tipo_Movimiento() As String
        Get
            Return _Tipo_Movimiento
        End Get

        Set(ByVal value As String)
            _Tipo_Movimiento = value
        End Set

    End Property

    Public Property Concepto_Movimiento() As String
        Get
            Return _Concepto_Movimiento
        End Get

        Set(ByVal value As String)
            _Concepto_Movimiento = value
        End Set

    End Property


    Public Property fase() As Integer
        Get
            Return _fase
        End Get

        Set(ByVal value As Integer)
            _fase = value
        End Set

    End Property

    Public Property N_Regional() As Integer
        Get
            Return _N_Regional
        End Get

        Set(ByVal value As Integer)
            _N_Regional = value
        End Set

    End Property

    Public Property N_Agencia() As Integer
        Get
            Return _N_Agencia
        End Get

        Set(ByVal value As Integer)
            _N_Agencia = value
        End Set

    End Property

    Public Property N_Prestamo() As Integer
        Get
            Return _N_Prestamo
        End Get

        Set(ByVal value As Integer)
            _N_Prestamo = value
        End Set

    End Property

    Public Property año() As Integer
        Get
            Return _año
        End Get

        Set(ByVal value As Integer)
            _año = value
        End Set

    End Property

    Public Property N_Desembolso() As Integer
        Get
            Return _N_Desembolso
        End Get

        Set(ByVal value As Integer)
            _N_Desembolso = value
        End Set

    End Property

    Public Property regional() As String
        Get
            Return _regional
        End Get

        Set(ByVal value As String)
            _regional = value
        End Set

    End Property

    Public Property agencia() As String
        Get
            Return _agencia
        End Get

        Set(ByVal value As String)
            _agencia = value
        End Set

    End Property

    Public Property nombres() As String
        Get
            Return _nombres
        End Get

        Set(ByVal value As String)
            _nombres = value
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

    Public Property clave() As String
        Get
            Return _clave
        End Get

        Set(ByVal value As String)
            _clave = value
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

    Public Property Monto_Aprobado() As Integer
        Get
            Return _Monto_Aprobado
        End Get

        Set(ByVal value As Integer)
            _Monto_Aprobado = value
        End Set

    End Property

    Public Property Saldo_Anterior() As Integer
        Get
            Return _Saldo_Anterior
        End Get

        Set(ByVal value As Integer)
            _Saldo_Anterior = value
        End Set

    End Property

    Public Property Monto_Desembolsado() As Integer
        Get
            Return _Monto_Desembolsado
        End Get

        Set(ByVal value As Integer)
            _Monto_Desembolsado = value
        End Set

    End Property

    Public Property Cantidad_Disponible() As Integer
        Get
            Return _Cantidad_Disponible
        End Get

        Set(ByVal value As Integer)
            _Cantidad_Disponible = value
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
