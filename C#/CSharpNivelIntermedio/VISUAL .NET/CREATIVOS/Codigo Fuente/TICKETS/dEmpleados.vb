Public Class dEmpleados

    Private _codigo As String
    Private _nombre As String
    Private _usuario As String
    Private _contraseña As String
    Private _Cargo As String

    Dim conexion As New DataClasses1DataContext()
    Dim query
    Event errores(ByVal nombres As String)

    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property


    Public Property codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
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


    Public Property Contraseña() As String
        Get
            Return _contraseña
        End Get
        Set(ByVal value As String)
            _contraseña = value
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




    Function numero_empleado() As Integer
        query = (From n In conexion.Empleados Select n).Count + 1
        Return query
    End Function

    Public Sub insertar_empleado(ByVal codigo As String, ByVal nombre As String)

        Dim servicionuevo As New Empleados
        servicionuevo.Codigo = codigo
        servicionuevo.Nombre = nombre

        conexion.Empleados.InsertOnSubmit(servicionuevo)
        conexion.SubmitChanges()

    End Sub

    Sub Eliminar_empleados(ByVal codigo As String)

        Try
            query = (From n In conexion.Empleados Where n.Codigo = codigo Select n).Single

            conexion.Empleados.DeleteOnSubmit(query)

            conexion.SubmitChanges()
        Catch ex As Exception
            If ex.Message = "Sequence contains no elements" Then
                RaiseEvent errores("Seleccione el empleado que desea eliminar luego presione eliminar")
            Else
                RaiseEvent errores("Contacte al administrador del sistema error : " + vbCrLf + ex.Message)
            End If
        End Try

    End Sub


    Public Sub modificar_empleados(ByVal codigo As String, ByVal nombre As String)


        Dim modificar = (From n In conexion.Empleados Where n.Codigo = codigo Select n).Single
        modificar.Codigo = codigo
        modificar.Nombre = nombre
        conexion.SubmitChanges()

    End Sub


End Class
