Public Class CDatos

    Private _Usuario As String
    Private _Contraseña As String
    Private _Cargo As String


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


    Public Property Cargo() As String

        Get
            Return _Cargo
        End Get
        Set(ByVal value As String)
            _Cargo = value
        End Set
    End Property


End Class
