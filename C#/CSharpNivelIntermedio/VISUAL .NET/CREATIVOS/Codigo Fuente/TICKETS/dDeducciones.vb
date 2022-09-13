Public Class dDeducciones

    Dim conexion As New DataClasses1DataContext()
    Dim query
    Event errores(ByVal nombres As String)

    Function numero_empleado() As Integer
        query = (From n In conexion.Empleados Select n).Count + 1
        Return query
    End Function

    Public Sub insertar_deduccion(ByVal codigo As String, ByVal descripcion As String, ByVal precio As Decimal)

        Dim servicionuevo As New Deducciones
        servicionuevo.Codigo = codigo
        servicionuevo.descripcion = descripcion
        servicionuevo.Precio = precio

        conexion.Deducciones.InsertOnSubmit(servicionuevo)
        conexion.SubmitChanges()

    End Sub

    Public Sub insertar_total(ByVal codigo As String, ByVal total_deduccion As Decimal)


        Dim servicionuevo As New Total
        servicionuevo.Codigo = codigo
        servicionuevo.Total_Deduccion = total_deduccion

        conexion.Total.InsertOnSubmit(servicionuevo)
        conexion.SubmitChanges()




    End Sub

    Public Sub modificar_total(ByVal codigo As String, ByVal total_deduccion As Decimal)


        Dim modificar = (From n In conexion.Total Where n.Codigo = codigo Select n).Single
        modificar.Codigo = codigo
        modificar.Total_Deduccion = total_deduccion
        conexion.SubmitChanges()



    End Sub


    Sub Eliminar_total(ByVal codigo As String)

        Try
            query = (From n In conexion.Total Where n.Codigo = codigo Select n).Single

            conexion.Total.DeleteOnSubmit(query)

            conexion.SubmitChanges()
        Catch ex As Exception
            If ex.Message = "Sequence contains no elements" Then
                RaiseEvent errores("Seleccione el empleado que desea eliminar luego presione eliminar")
            Else
                RaiseEvent errores("Contacte al administrador del sistema error : " + vbCrLf + ex.Message)
            End If
        End Try

    End Sub

    Sub Eliminar_deduccion(ByVal codigo As String)

        Try
            query = (From n In conexion.Deducciones Where n.Codigo = codigo Select n).Single

            conexion.Deducciones.DeleteOnSubmit(query)

            conexion.SubmitChanges()
        Catch ex As Exception
            If ex.Message = "Sequence contains no elements" Then
                RaiseEvent errores("Seleccione el empleado que desea eliminar luego presione eliminar")
            Else
                RaiseEvent errores("Contacte al administrador del sistema error : " + vbCrLf + ex.Message)
            End If
        End Try

    End Sub


    Public Sub modificar_deduccion(ByVal codigo As String, ByVal nombre As String, ByVal precio As Decimal)


        Dim modificar = (From n In conexion.Deducciones Where n.Codigo = codigo Select n).Single
        modificar.Codigo = codigo
        modificar.Descripcion = nombre
        modificar.Precio = precio
        conexion.SubmitChanges()

    End Sub



End Class
