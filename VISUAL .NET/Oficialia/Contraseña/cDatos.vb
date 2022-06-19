Public Class cDatos

    Private _Usuario As String
    Private _Contraseña As String
    Private _identidad As String


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


    Public Property identidad() As String

        Get
            Return _identidad
        End Get
        Set(ByVal value As String)
            _identidad = value
        End Set
    End Property


End Class
