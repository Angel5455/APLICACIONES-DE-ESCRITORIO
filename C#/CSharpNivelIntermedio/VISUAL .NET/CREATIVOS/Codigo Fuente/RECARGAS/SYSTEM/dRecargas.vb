Public Class dRecargas

    Dim conexion As New DataClasses1DataContext()
    Dim query
    Event errores(ByVal nombres As String)

    Function numero_clientes() As Integer
        query = (From n In conexion.Clientes Select n).Count + 1
        Return query
    End Function

    Function numero_controlR() As Integer
        query = (From n In conexion.Control_Recargas_TIGO Select n).Count + 1
        Return query
    End Function

    Function numero_controlRC() As Integer
        query = (From n In conexion.Control_Recargas_Claro Select n).Count + 1
        Return query
    End Function

    Public Sub insertar_clientes(ByVal id As Integer, ByVal nombre As String, ByVal celular As String)

        Dim servicionuevo As New Clientes
        servicionuevo.Id = id
        servicionuevo.Nombre = nombre
        servicionuevo.Celular = celular

        conexion.Clientes.InsertOnSubmit(servicionuevo)
        conexion.SubmitChanges()

    End Sub

    Public Sub insertar_controlR(ByVal id As Integer, ByVal nombre As String, ByVal celular As String, ByVal cantidad As Integer, ByVal fecha As DateTime, ByVal hora As String, ByVal compra As Integer, ByVal SaldoAnterior As Double, ByVal SaldoActual As Double, ByVal Vendido As Integer, ByVal Efectivo As Integer, ByVal Creditos As Integer, ByVal Errores As Integer, ByVal Observacion As String, ByVal Usuario As String, ByVal Cierre As Integer)

        Dim servicionuevo As New Control_Recargas_Tigo
        servicionuevo.Id = id
        servicionuevo.Nombre = nombre
        servicionuevo.Celular = celular
        servicionuevo.Cantidad = cantidad
        servicionuevo.Fecha = fecha
        servicionuevo.Hora = hora
        servicionuevo.Compra = compra
        servicionuevo.Saldo_Anterior = SaldoAnterior
        servicionuevo.Saldo_Actual = SaldoActual
        servicionuevo.Vendido = Vendido
        servicionuevo.Efectivo = Efectivo
        servicionuevo.Creditos = Creditos
        servicionuevo.Errores = Errores
        servicionuevo.Observacion = Observacion
        servicionuevo.Usuario = Usuario
        servicionuevo.Cierre = Cierre


        conexion.Control_Recargas_Tigo.InsertOnSubmit(servicionuevo)
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

    Public Sub modificar_controlRC(ByVal id As Integer, ByVal nombre As String, ByVal celular As String, ByVal cantidad As Integer, ByVal fecha As DateTime, ByVal hora As String, ByVal compra As Integer, ByVal SaldoAnterior As Double, ByVal SaldoActual As Double, ByVal Vendido As Integer, ByVal Efectivo As Integer, ByVal Creditos As Integer, ByVal Errores As Integer, ByVal Observacion As String, ByVal Usuario As String, ByVal Cierre As Integer)


        Dim modificar = (From n In conexion.Control_Recargas_Claro Where n.Id = id Select n).Single
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

    Public Sub insertar_controlRC(ByVal id As Integer, ByVal nombre As String, ByVal celular As String, ByVal cantidad As Integer, ByVal fecha As DateTime, ByVal hora As String, ByVal compra As Integer, ByVal SaldoAnterior As Double, ByVal SaldoActual As Double, ByVal Vendido As Integer, ByVal Efectivo As Integer, ByVal Creditos As Integer, ByVal Errores As Integer, ByVal Observacion As String, ByVal Usuario As String, ByVal Cierre As Integer)

        Dim servicionuevo As New Control_Recargas_Claro
        servicionuevo.Id = id
        servicionuevo.Nombre = nombre
        servicionuevo.Celular = celular
        servicionuevo.Cantidad = cantidad
        servicionuevo.Fecha = fecha
        servicionuevo.Hora = hora
        servicionuevo.Compra = compra
        servicionuevo.Saldo_Anterior = SaldoAnterior
        servicionuevo.Saldo_Actual = SaldoActual
        servicionuevo.Vendido = Vendido
        servicionuevo.Efectivo = Efectivo
        servicionuevo.Creditos = Creditos
        servicionuevo.Errores = Errores
        servicionuevo.Observacion = Observacion
        servicionuevo.Usuario = Usuario
        servicionuevo.Cierre = Cierre


        conexion.Control_Recargas_Claro.InsertOnSubmit(servicionuevo)
        conexion.SubmitChanges()

    End Sub



    Public Sub insertar_creditosR(ByVal id As Integer, ByVal nombre As String, ByVal celular As String, ByVal cantidad As Integer, ByVal fecha As DateTime)

        Dim servicionuevo As New Creditos_Recargas
        servicionuevo.Id = id
        servicionuevo.Nombre = nombre
        servicionuevo.Celular = celular
        servicionuevo.Cantidad = cantidad
        servicionuevo.Fecha = fecha


        conexion.Creditos_Recargas.InsertOnSubmit(servicionuevo)
        conexion.SubmitChanges()

    End Sub

    Public Sub Modificar_CreditosR(ByVal id As Integer, ByVal nombre As String, ByVal celular As String, ByVal cantidad As Integer, ByVal fecha As DateTime)
        Dim modificar = (From n In conexion.Creditos_Recargas Where n.Id = id Select n).Single
        modificar.Id = id
        modificar.Nombre = nombre
        modificar.Celular = celular
        modificar.Cantidad = cantidad
        modificar.Fecha = fecha

        conexion.SubmitChanges()

    End Sub
    Public Sub Modificar_clientes(ByVal id As Integer, ByVal nombre As String, ByVal celular As String)
        Dim modificar = (From n In conexion.Clientes Where n.Id = id Select n).Single
        modificar.Id = id
        modificar.Celular = celular
        modificar.Nombre = nombre

        conexion.SubmitChanges()

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

    Sub Eliminar_creditos(ByVal id As String)

        Try
            query = (From n In conexion.Creditos_Recargas Where n.Id = id Select n).Single

            conexion.Creditos_Recargas.DeleteOnSubmit(query)

            conexion.SubmitChanges()
        Catch ex As Exception
            If ex.Message = "Sequence contains no elements" Then
                RaiseEvent errores("Seleccione el contacto que desea eliminar luego presione eliminar")
            Else
                RaiseEvent errores("Contacte al administrador del sistema error : " + vbCrLf + ex.Message)
            End If
        End Try

    End Sub

End Class
