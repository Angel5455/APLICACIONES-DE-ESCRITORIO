Public Class dPrestamos


    Dim conexion As New DataClasses1DataContext()
    Dim query
    Event errores(ByVal nombres As String)

    Public Sub insertar_prestamos(ByVal id As Integer, ByVal codigo As String, ByVal nombre As String, ByVal cantidad As Integer)

        Dim servicionuevo As New Prestamos
        servicionuevo.Id = id
        servicionuevo.Codigo = codigo
        servicionuevo.Nombre = nombre
        servicionuevo.Prestamo = cantidad

        conexion.Prestamos.InsertOnSubmit(servicionuevo)
        conexion.SubmitChanges()

    End Sub
    Sub Eliminar_prestamos(ByVal codigo As String)

        Try
            query = (From n In conexion.Prestamos Where n.Codigo = codigo Select n).Single

            conexion.Prestamos.DeleteOnSubmit(query)

            conexion.SubmitChanges()
        Catch ex As Exception
            If ex.Message = "Sequence contains no elements" Then
                RaiseEvent errores("Seleccione el empleado que desea eliminar luego presione eliminar")
            Else
                RaiseEvent errores("Contacte al administrador del sistema error : " + vbCrLf + ex.Message)
            End If
        End Try

    End Sub


    Public Sub modificar_prestamos(ByVal id As Integer, ByVal codigo As String, ByVal nombre As String, ByVal cantidad As Integer)


        Dim modificar = (From n In conexion.Prestamos Where n.Codigo = codigo Select n).Single
        modificar.Id = id
        modificar.Codigo = codigo
        modificar.nombre = nombre
        modificar.Prestamo = cantidad
        conexion.SubmitChanges()

    End Sub

    Function numero_prestamo() As Integer
        query = (From n In conexion.Prestamos Select n).Count + 1
        Return query
    End Function

End Class
