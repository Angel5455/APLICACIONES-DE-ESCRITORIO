Public Class dRecibo

    Dim conexion As New DataClasses1DataContext()
    Dim query
    Event errores(ByVal nombres As String)

    Function numero_recibo() As Integer
        query = (From n In conexion.Recibos Select n).Count + 1
        Return query
    End Function

    Public Sub insertar_recibo(ByVal id As Integer, ByVal Fecha As String, ByVal Cantidad As Decimal, ByVal Cliente As String, ByVal Letras As String, ByVal Concepto As String, ByVal Saldo_Anterior As Decimal, ByVal Abono As Decimal, ByVal Saldo_Actual As Decimal, ByVal Estado As String, ByVal Usuario As String)

        Dim servicionuevo As New Recibos
        servicionuevo.Id = id
        servicionuevo.Fecha = Fecha
        servicionuevo.Cantidad = Cantidad
        servicionuevo.Cliente = Cliente
        servicionuevo.Cantidad_Letras = Letras
        servicionuevo.Concepto = Concepto
        servicionuevo.Saldo_Anterior = Saldo_Anterior
        servicionuevo.Abono = Abono
        servicionuevo.Saldo_Actual = Saldo_Actual
        servicionuevo.Estado = Estado
        servicionuevo.Usuario = Usuario

        conexion.Recibos.InsertOnSubmit(servicionuevo)
        conexion.SubmitChanges()

    End Sub

    Public Sub insertar_pendiente(ByVal id As Integer, ByVal Fecha As String, ByVal Cantidad As Decimal, ByVal Cliente As String, ByVal Letras As String, ByVal Concepto As String, ByVal Saldo_Anterior As Decimal, ByVal Abono As Decimal, ByVal Saldo_Actual As Decimal, ByVal Estado As String, ByVal Usuario As String)

        Dim servicionuevo As New Recibos_Pendientes
        servicionuevo.Id = id
        servicionuevo.Fecha = Fecha
        servicionuevo.Cantidad = Cantidad
        servicionuevo.Cliente = Cliente
        servicionuevo.Cantidad_Letras = Letras
        servicionuevo.Concepto = Concepto
        servicionuevo.Saldo_Anterior = Saldo_Anterior
        servicionuevo.Abono = Abono
        servicionuevo.Saldo_Actual = Saldo_Actual
        servicionuevo.Estado = Estado
        servicionuevo.Usuario = Usuario

        conexion.Recibos_Pendientes.InsertOnSubmit(servicionuevo)
        conexion.SubmitChanges()

    End Sub
    Public Sub modificar_controlR(ByVal id As Integer, ByVal nombre As String, ByVal celular As String, ByVal cantidad As Integer, ByVal fecha As DateTime, ByVal hora As String, ByVal compra As Integer, ByVal SaldoAnterior As Double, ByVal SaldoActual As Double, ByVal Vendido As Integer, ByVal Efectivo As Integer, ByVal Creditos As Integer, ByVal Errores As Integer, ByVal Observacion As String, ByVal Usuario As String, ByVal Cierre As Integer)


        Dim modificar = (From n In conexion.Control_Recargas_Tigo Where n.Id = id Select n).Single
        modificar.Id = id
        modificar.Nombre = nombre
        modificar.Celular = celular
        modificar.Cantidad = cantidad
        modificar.Fecha = fecha
        modificar.Hora = hora
        modificar.Compra = compra
        modificar.Saldo_Anterior = SaldoAnterior
        modificar.Saldo_Actual = SaldoActual
        modificar.Vendido = Vendido
        modificar.Efectivo = Efectivo
        modificar.Creditos = Creditos
        modificar.Errores = Errores
        modificar.Observacion = Observacion
        modificar.Usuario = Usuario
        modificar.Cierre = Cierre

        conexion.SubmitChanges()

    End Sub

    Sub Eliminar_pendientes(ByVal id As String)

        Try
            query = (From n In conexion.Recibos_Pendientes Where n.Id = id Select n).Single

            conexion.Recibos_Pendientes.DeleteOnSubmit(query)

            conexion.SubmitChanges()
        Catch ex As Exception
            If ex.Message = "Sequence contains no elements" Then
                RaiseEvent errores("Seleccione el cliente que desea eliminar luego presione eliminar")
            Else
                RaiseEvent errores("Contacte al administrador del sistema error : " + vbCrLf + ex.Message)
            End If
        End Try

    End Sub




    Sub Eliminar_clientes(ByVal id As String)

        Try
            query = (From n In conexion.Clientes Where n.Id = id Select n).Single

            conexion.Clientes.DeleteOnSubmit(query)

            conexion.SubmitChanges()
        Catch ex As Exception
            If ex.Message = "Sequence contains no elements" Then
                RaiseEvent errores("Seleccione el cliente que desea eliminar luego presione eliminar")
            Else
                RaiseEvent errores("Contacte al administrador del sistema error : " + vbCrLf + ex.Message)
            End If
        End Try

    End Sub

    


End Class
