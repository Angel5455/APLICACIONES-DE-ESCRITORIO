Public Class DHeces
    Dim Conexion As New DataClasses1DataContext()
    Dim Query
    Public Resultados As String
    Event Errores(ByVal Examen As String)

    Function Id() As Integer
        Try
            Query = (From n In Conexion.Heces Select n).Count
        Catch ex As Exception
            RaiseEvent Errores("Error al obtener el codigo.")
        End Try
        Return Convert.ToInt32(Query)
    End Function
    Public Sub Guardar_Examen(ByVal Identidad As String, ByVal Paciente As String, ByVal Edad As Integer, ByVal Sexo As String, ByVal Referencia As String, ByVal Muestra As Integer, ByVal Fecha As String, ByVal Aspecto As String, ByVal Consistencia As String, ByVal Color As String, ByVal Moco As String, ByVal Sangre As String, ByVal Observacion As String)

        'Servicionuevo.Id = id
        Dim Servicionuevo As New Heces With {
            .Identidad = Identidad,
            .Paciente = Paciente,
            .Edad = Edad,
            .Sexo = Sexo,
            .Referencia = Referencia,
            .N_Muestra = Muestra,
            .Fecha = Fecha,
            .Aspecto = Aspecto,
            .Consistencia = Consistencia,
            .Color = Color,
            .Moco = Moco,
            .Sangre = Sangre,
            .Observacion = Observacion
        }


        Conexion.Heces.InsertOnSubmit(Servicionuevo)
        Conexion.SubmitChanges()

    End Sub

End Class
