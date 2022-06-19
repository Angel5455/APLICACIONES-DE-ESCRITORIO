Public Class DMoco

    Dim Conexion As New DataClasses1DataContext()
    Dim Query
    Public Resultados As String
    Event Errores(ByVal Drogas As String)

    Function Id() As Integer
        Try
            Query = (From n In Conexion.Citologia_Moco_Fecal Select n).Count
        Catch ex As Exception
            RaiseEvent Errores("Error al obtener el codigo.")
        End Try
        Return Convert.ToInt32(Query)
    End Function
    Public Sub Guardar_Examen(ByVal Identidad As String, ByVal Paciente As String, ByVal Edad As Integer, ByVal Sexo As String, ByVal Referencia As String, ByVal Muestra As Integer, ByVal Fecha As String, ByVal Aspecto As String, ByVal Consistencia As String, ByVal Color As String, ByVal Moco As String, ByVal Sangre As String, ByVal PH As String, ByVal Fehling As String, ByVal Guayaco As String, ByVal PMN As String, ByVal MN As String, ByVal Observacion As String)

        'Servicionuevo.Id = id
        Dim Servicionuevo As New Citologia_Moco_Fecal With {
            .Identidad = Identidad,
            .Paciente = Paciente,
            .Edad = Edad,
            .Sexo = Sexo,
            .Referido = Referencia,
            .N_Muestra = Muestra,
            .Fecha = Fecha,
            .Aspecto = Aspecto,
            .Consistencia = Consistencia,
            .Color = Color,
            .Moco = Moco,
            .Sangre = Sangre,
            .PH = PH,
            .Fehling = Fehling,
            .Guayaco = Guayaco,
            .PMN = PMN,
            .MN = MN,
            .Observacion = Observacion
        }
        Conexion.Citologia_Moco_Fecal.InsertOnSubmit(Servicionuevo)
        Conexion.SubmitChanges()

    End Sub


End Class
