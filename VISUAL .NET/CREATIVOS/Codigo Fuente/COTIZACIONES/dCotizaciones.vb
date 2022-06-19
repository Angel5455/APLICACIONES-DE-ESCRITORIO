Public Class dCotizaciones



    Dim conexion As New DataClasses1DataContext()
    Dim query
    Event errores(ByVal nombres As String)


    Private _cotizacion As Integer
    Private _fecha As String
    Private _nombre As String
    Private _total As Integer

    Public Property Cotizacion() As Integer
        Get
            Return _cotizacion
        End Get

        Set(ByVal value As Integer)
            _cotizacion = value
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


    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
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

    Function numero_cotizacion() As Integer
        query = (From n In conexion.Cotizaciones Select n).Count + 1
        Return query
    End Function

    Public Sub insertar_cotizacion(ByVal cotizacion As Integer, ByVal fecha As String, ByVal nombre As String, ByVal total As Decimal)

        Dim servicionuevo As New Cotizaciones
        servicionuevo.Cotizacion = cotizacion
        servicionuevo.Fecha = fecha
        servicionuevo.Nombre = nombre
        servicionuevo.Total = total
        conexion.Cotizaciones.InsertOnSubmit(servicionuevo)
        conexion.SubmitChanges()

    End Sub

End Class
