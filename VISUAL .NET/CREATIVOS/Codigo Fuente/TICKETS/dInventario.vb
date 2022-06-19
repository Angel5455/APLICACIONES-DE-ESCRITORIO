Public Class dInventario

    Private _codigo As Integer
    Private _descripcion As String
    Private _precio As Integer

    Dim conexion As New DataClasses1DataContext()
    Dim query
    Event errores(ByVal nombres As String)

    Public Sub insertar_inventario(ByVal codigo As String, ByVal descripcion As String, ByVal cantidad As Integer, ByVal precio As Integer, ByVal subtotal As Integer)

        Dim servicionuevo As New Inventario
        servicionuevo.Codigo = codigo
        servicionuevo.Descripcion = descripcion
        servicionuevo.Cantidad = cantidad
        servicionuevo.Precio = precio
        servicionuevo.Subtotal = subtotal

        conexion.Inventario.InsertOnSubmit(servicionuevo)
        conexion.SubmitChanges()

    End Sub
    Sub Eliminar_inventario(ByVal codigo As String)

        Try
            query = (From n In conexion.Inventario Where n.Codigo = codigo Select n).Single

            conexion.Inventario.DeleteOnSubmit(query)

            conexion.SubmitChanges()
        Catch ex As Exception
            If ex.Message = "Sequence contains no elements" Then
                RaiseEvent errores("Seleccione el empleado que desea eliminar luego presione eliminar")
            Else
                RaiseEvent errores("Contacte al administrador del sistema error : " + vbCrLf + ex.Message)
            End If
        End Try

    End Sub


    Public Sub modificar_inventario(ByVal codigo As String, ByVal descripcion As String, ByVal cantidad As Integer, ByVal precio As Integer, ByVal subtotal As Integer)


        Dim modificar = (From n In conexion.Inventario Where n.Codigo = codigo Select n).Single
        modificar.Codigo = codigo
        modificar.Descripcion = descripcion
        modificar.Cantidad = cantidad
        modificar.Precio = precio
        modificar.Subtotal = subtotal
        conexion.SubmitChanges()

    End Sub


End Class
