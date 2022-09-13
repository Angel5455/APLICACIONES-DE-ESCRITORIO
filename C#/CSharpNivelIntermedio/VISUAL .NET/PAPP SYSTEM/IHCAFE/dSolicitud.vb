Public Class dSolicitud

    Private _nSolicitud As Integer
    Private _fase As Integer
    Private _clave As String
    Private _identidad As String
    Private _nombre As String
    Private _edad As Integer
    Private _fechaN As String
    Private _estado As String
    Private _conyuge As String
    Private _domicilio As String
    Private _aldea As String
    Private _municipio As String
    Private _departamento As String
    Private _monto As Integer
    Private _plazo As String
    Private _lugar As String
    Private _pago As String
    Private _destino As String
    Private _aportacion As String
    Private _fechaS As String
    Private _fechaV As String
    Private _manzanas As Integer
    Private _letras As String



    Public Property nSolicitud() As Integer

        Get
            Return _nSolicitud
        End Get
        Set(ByVal value As Integer)
            _nSolicitud = value
        End Set
    End Property

    Public Property manzanas() As Integer

        Get
            Return _manzanas
        End Get
        Set(ByVal value As Integer)
            _manzanas = value
        End Set
    End Property


    Public Property Fase() As Integer

        Get
            Return _fase
        End Get
        Set(ByVal value As Integer)
            _fase = value
        End Set
    End Property


    Public Property letras() As String

        Get
            Return _letras
        End Get
        Set(ByVal value As String)
            _letras = value
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

    Public Property edad() As Integer

        Get
            Return _edad
        End Get
        Set(ByVal value As Integer)
            _edad = value
        End Set
    End Property


    Public Property fechaN() As String

        Get
            Return _fechaN
        End Get
        Set(ByVal value As String)
            _fechaN = value
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


    Public Property conyuge() As String

        Get
            Return _conyuge
        End Get
        Set(ByVal value As String)
            _conyuge = value
        End Set
    End Property


    Public Property domicilio() As String

        Get
            Return _domicilio
        End Get
        Set(ByVal value As String)
            _domicilio = value
        End Set
    End Property


    Public Property aldea() As String

        Get
            Return _aldea
        End Get
        Set(ByVal value As String)
            _aldea = value
        End Set
    End Property



    Public Property municipio() As String

        Get
            Return _municipio
        End Get
        Set(ByVal value As String)
            _municipio = value
        End Set
    End Property


    Public Property departamento() As String

        Get
            Return _departamento
        End Get
        Set(ByVal value As String)
            _departamento = value
        End Set
    End Property


    Public Property monto() As Integer

        Get
            Return _monto
        End Get
        Set(ByVal value As Integer)
            _monto = value
        End Set
    End Property


    Public Property plazo() As String

        Get
            Return _plazo
        End Get
        Set(ByVal value As String)
            _plazo = value
        End Set
    End Property


    Public Property lugar() As String

        Get
            Return _lugar
        End Get
        Set(ByVal value As String)
            _lugar = value
        End Set
    End Property


    Public Property pago() As String

        Get
            Return _pago
        End Get
        Set(ByVal value As String)
            _pago = value
        End Set
    End Property


    Public Property destino() As String

        Get
            Return _destino
        End Get
        Set(ByVal value As String)
            _destino = value
        End Set
    End Property


    Public Property aportacion() As String

        Get
            Return _aportacion
        End Get
        Set(ByVal value As String)
            _aportacion = value
        End Set
    End Property


    Public Property fechaS() As String

        Get
            Return _fechaS
        End Get
        Set(ByVal value As String)
            _fechaS = value
        End Set
    End Property


    Public Property fechaV() As String

        Get
            Return _fechaV
        End Get
        Set(ByVal value As String)
            _fechaV = value
        End Set
    End Property


End Class
