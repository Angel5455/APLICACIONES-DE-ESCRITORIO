Public Class dSolicitud


    Dim conexion As New DataClasses1DataContext()
    Dim query
    Event errores(ByVal descripcion As String)

    Function numero() As Integer
        query = (From n In conexion.Solicitudes Select n).Count + 1
        Return query
    End Function


    Public Sub insertar(ByVal id As Integer, ByVal id_Solicitante As String, ByVal Numero_Expediente As String, ByVal TGR As String, ByVal Solicitante As String, ByVal Persona_Inscrita As String, ByVal Tipo_Solicitud As String, ByVal Fecha_Solicitud As String, ByVal Fecha_Resolucion As String, ByVal Fecha_Envio As String, ByVal Fecha_Remision As String, ByVal Auto As String, ByVal Caja As String, ByVal FechaS As String, ByVal FechaRS As String, ByVal FechaE As String, ByVal FechaRm As String)

        Dim servicionuevo As New Solicitudes
        servicionuevo.Id = id
        servicionuevo.Identidad = id_Solicitante
        servicionuevo.Solicitante = Solicitante
        servicionuevo.Expediente = Numero_Expediente
        servicionuevo.TGR = TGR
        servicionuevo.Solicitante = Solicitante
        servicionuevo.Persona_Inscrita = Persona_Inscrita
        servicionuevo.Tipo_Solicitud = Tipo_Solicitud
        servicionuevo.Fecha_Solicitud = Fecha_Solicitud
        servicionuevo.Fecha_Resolucion = Fecha_Resolucion
        servicionuevo.Fecha_Envio = Fecha_Envio
        servicionuevo.Fecha_Remision = Fecha_Remision
        servicionuevo.Auto = Auto
        servicionuevo.Caja = Caja
        servicionuevo.FechaS = FechaS
        servicionuevo.FechaRs = FechaRS
        servicionuevo.FechaE = FechaE
        servicionuevo.FechaRm = FechaRm


        conexion.Solicitudes.InsertOnSubmit(servicionuevo)
        conexion.SubmitChanges()



    End Sub

    Public Sub Modificar(ByVal id As Integer, ByVal id_Solicitante As String, ByVal Numero_Expediente As String, ByVal TGR As String, ByVal Solicitante As String, ByVal Persona_Inscrita As String, ByVal Tipo_Solicitud As String, ByVal Fecha_Solicitud As String, ByVal Fecha_Resolucion As String, ByVal Fecha_Envio As String, ByVal Fecha_Remision As String, ByVal Auto As String, ByVal Caja As String, ByVal FechaS As String, ByVal FechaRS As String, ByVal FechaE As String, ByVal FechaRm As String)

        Dim modificar = (From n In conexion.Solicitudes Where n.Id = id Select n).Single
        modificar.Id = id
        modificar.Expediente = Numero_Expediente
        modificar.TGR = TGR
        modificar.Solicitante = Solicitante
        modificar.Persona_Inscrita = Persona_Inscrita
        modificar.Tipo_Solicitud = Tipo_Solicitud
        modificar.Fecha_Solicitud = Fecha_Solicitud
        modificar.Fecha_Resolucion = Fecha_Resolucion
        modificar.Fecha_Envio = Fecha_Envio
        modificar.Fecha_Remision = Fecha_Remision
        modificar.Auto = Auto
        modificar.Caja = Caja
        modificar.FechaS = FechaS
        modificar.FechaRs = FechaRS
        modificar.FechaE = FechaE
        modificar.FechaRm = FechaRm

        conexion.SubmitChanges()

    End Sub


End Class
