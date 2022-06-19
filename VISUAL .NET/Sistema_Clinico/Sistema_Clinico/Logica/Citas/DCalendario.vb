Public Class DCalendario

    Dim ConexionD As New DataClasses1DataContext()
    Dim Query
    Event Errores(ByVal Pacientes As String)

    Private _Id As Integer
    Private _Fecha As Date
    Private _Nombre As String
    Private _Direccion As String
    Private _Comentario As String

    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property



    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return _Direccion
        End Get
        Set(ByVal value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Comentario() As String
        Get
            Return _Comentario
        End Get
        Set(ByVal value As String)
            _Comentario = value
        End Set
    End Property

    Public Sub Insertar_Cita(ByVal Fecha As Date, ByVal Nombre As String, ByVal Direccion As String, ByVal Comentario As String)

        'Servicionuevo.Id = id
        Dim Servicionuevo As New Calendario With {
            .Fecha = Fecha,
            .Nombre = Nombre,
            .Direccion = Direccion,
            .Comentario = Comentario
        }
        ConexionD.Calendario.InsertOnSubmit(Servicionuevo)
        ConexionD.SubmitChanges()

    End Sub

    Public Sub Editar_Cita(ByVal Id As Integer, ByVal Fecha As Date, ByVal Nombre As String, ByVal Direccion As String, ByVal Comentario As String)


        Dim modificar = (From n In ConexionD.Calendario Where n.Id = Id Select n).Single
        modificar.Id = Id
        modificar.Fecha = Fecha
        modificar.Direccion = Direccion
        modificar.Comentario = Comentario

        ConexionD.SubmitChanges()

    End Sub

    Sub Eliminar(ByVal id As Integer)
        Try
            Query = (From n In ConexionD.Calendario Where n.Id = id Select n).Single

            ConexionD.Calendario.DeleteOnSubmit(Query)

            ConexionD.SubmitChanges()
        Catch ex As Exception
            If ex.Message = "Secuencia no contiene Elementos" Then
                RaiseEvent Errores("Seleccione el contacto que desea eliminar luego presione eliminar")
            Else
                RaiseEvent Errores("Contacte al administrador del sistema error : " + vbCrLf + ex.Message)
            End If
        End Try
    End Sub
End Class
