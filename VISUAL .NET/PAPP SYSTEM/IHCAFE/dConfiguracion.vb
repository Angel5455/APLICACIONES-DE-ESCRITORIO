Public Class dConfiguracion

    Private _fase As Integer
    Private _fecha As String
    Private _usuario As String


    Public Property fase() As Integer
        Get
            Return _fase
        End Get

        Set(ByVal value As Integer)
            _fase = value
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

    Public Property Usuario() As String
        Get
            Return _usuario
        End Get

        Set(ByVal value As String)
            _usuario = value
        End Set

    End Property


End Class
