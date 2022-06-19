Public Class cDatos


    Private _id As Integer
    Private _Nombre As String
    Private _Usuario As String
    Private _Contraseña As String
    Private _foto As String
    Private _cargo As String
    Private _correo As String
    Private _Hora As String
    Private _Fecha As String
    Private _linea As String
    Private _Codigo As String
    Private _Descripcion As String
    Private _Precio As Integer
    Private _Unidad As String
    Private _Stock As Integer
    Private _Proveedor As String


    Private _Tmovimiento As String
    Private _Cmovimiento As String
    Private _orden As Integer
    Private _observacion As String
    Private _año As Integer


    Public Property Observacion() As String

        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
        End Set
    End Property



    Public Property TMovimiento() As String

        Get
            Return _Tmovimiento
        End Get
        Set(ByVal value As String)
            _Tmovimiento = value
        End Set
    End Property


    Public Property CMovimiento() As String

        Get
            Return _Cmovimiento
        End Get
        Set(ByVal value As String)
            _Cmovimiento = value
        End Set
    End Property



    Public Property Orden() As Integer
        Get
            Return _orden
        End Get

        Set(ByVal value As Integer)
            _orden = value
        End Set

    End Property


    Public Property Año() As Integer
        Get
            Return _año
        End Get

        Set(ByVal value As Integer)
            _orden = value
        End Set

    End Property


    Public Property id() As Integer
        Get
            Return _id
        End Get

        Set(ByVal value As Integer)
            _id = value
        End Set


    End Property

    Public Property fecha() As String

        Get
            Return _Fecha
        End Get
        Set(ByVal value As String)
            _Fecha = value
        End Set
    End Property

    Public Property hora() As String

        Get
            Return _Hora
        End Get
        Set(ByVal value As String)
            _Hora = value
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
    Public Property nombre() As String

        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property


    Public Property foto() As String

        Get
            Return _foto
        End Get
        Set(ByVal value As String)
            _foto = value
        End Set
    End Property

    Public Property Contraseña() As String

        Get
            Return _Contraseña
        End Get
        Set(ByVal value As String)
            _Contraseña = value
        End Set
    End Property

    Public Property Usuario() As String

        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property


    Public Property correo() As String

        Get
            Return _correo
        End Get
        Set(ByVal value As String)
            _correo = value
        End Set

    End Property




    Public Property Cargo() As String

        Get
            Return _cargo
        End Get
        Set(ByVal value As String)
            _cargo = value
        End Set
    End Property


    Public Property Codigo() As String

        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    Public Property Descripcion() As String

        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property Unidad() As String
        Get
            Return _Unidad
        End Get

        Set(ByVal value As String)
            _Unidad = value
        End Set


    End Property

    Public Property Stock() As Integer
        Get
            Return _Stock
        End Get

        Set(ByVal value As Integer)
            _Stock = value
        End Set


    End Property

    Public Property Precio() As Integer
        Get
            Return _Precio
        End Get

        Set(ByVal value As Integer)
            _Precio = value
        End Set


    End Property

    Public Property Proveedor() As String

        Get
            Return _Proveedor
        End Get
        Set(ByVal value As String)
            _Proveedor = value
        End Set
    End Property

End Class
