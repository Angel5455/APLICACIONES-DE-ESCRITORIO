Public Class dInventario

    Private _codigo As Integer
    Private _descripcion As String
    Private _precio As Integer

    Public Property codigo() As Integer
        Get
            Return _codigo
        End Get

        Set(ByVal value As Integer)
            _codigo = value
        End Set
    End Property



    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property


    Public Property precio() As Integer
        Get
            Return _precio
        End Get

        Set(ByVal value As Integer)
            _precio = value
        End Set
    End Property



End Class
