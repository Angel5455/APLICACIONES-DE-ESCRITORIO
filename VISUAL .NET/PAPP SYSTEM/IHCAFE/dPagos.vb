Public Class dPagos


    Private _clave As String
    Private _nombre As String
    Private _identidad As String
    Private _fecha As String
    Private _agencia As String
    Private _municipio As String
    Private _monto As Integer
    Private _n_a As Integer
    Private _a1 As Decimal
    Private _a2 As Decimal
    Private _a3 As Decimal
    Private _saldo As Integer
    Private _Fase As Integer
    Private _foto As String
    Private _usuario As String
    Private _letras As String


    Public Property letras() As String

        Get
            Return _letras
        End Get
        Set(ByVal value As String)
            _letras = value
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


    Public Property clave() As String

        Get
            Return _clave
        End Get
        Set(ByVal value As String)
            _clave = value
        End Set
    End Property

    Public Property Identidad() As String

        Get
            Return _identidad
        End Get
        Set(ByVal value As String)
            _identidad = value
        End Set
    End Property

    Public Property Fecha() As String

        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property


    Public Property Agencia() As String

        Get
            Return _agencia
        End Get
        Set(ByVal value As String)
            _agencia = value
        End Set
    End Property

    Public Property Municipio() As String

        Get
            Return _municipio
        End Get
        Set(ByVal value As String)
            _municipio = value
        End Set
    End Property


    Public Property Monto() As Integer
        Get
            Return _monto
        End Get

        Set(ByVal value As Integer)
            _monto = value
        End Set

    End Property


    Public Property A1() As Decimal
        Get
            Return _a1
        End Get

        Set(ByVal value As Decimal)
            _a1 = value
        End Set

    End Property

    Public Property A2() As Decimal
        Get
            Return _a2
        End Get

        Set(ByVal value As Decimal)
            _a2 = value
        End Set

    End Property

    Public Property A3() As Decimal
        Get
            Return _a3
        End Get

        Set(ByVal value As Decimal)
            _a3 = value
        End Set

    End Property

    Public Property Saldo() As Integer
        Get
            Return _saldo
        End Get

        Set(ByVal value As Integer)
            _saldo = value
        End Set

    End Property

    Public Property Fase() As Integer
        Get
            Return _Fase
        End Get

        Set(ByVal value As Integer)
            _Fase = value
        End Set

    End Property

    Public Property NA() As Integer
        Get
            Return _n_a
        End Get

        Set(ByVal value As Integer)
            _n_a = value
        End Set

    End Property



    Public Property Foto() As String

        Get
            Return _foto
        End Get

        Set(ByVal value As String)
            _foto = value
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
