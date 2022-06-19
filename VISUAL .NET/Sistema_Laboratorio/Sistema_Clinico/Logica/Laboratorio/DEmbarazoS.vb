Public Class DEmbarazoS

    Dim Conexion As New DataClasses1DataContext()
    Dim Query
    Public Resultados As String
    Event Errores(ByVal Examen As String)

    Function Id() As Integer
        Try
            Query = (From n In Conexion.Embarazo_Sangre Select n).Count
        Catch ex As Exception
            RaiseEvent Errores("Error al obtener el codigo.")
        End Try
        Return Convert.ToInt32(Query)
    End Function
    Public Sub Guardar_Examen(ByVal Identidad As String, ByVal Paciente As String, ByVal Edad As Integer, ByVal Sexo As String, ByVal Referencia As String, ByVal Muestra As Integer, ByVal Fecha As String, ByVal Resultado As String, ByVal Nota As String)

        'Servicionuevo.Id = id
        Dim Servicionuevo As New Embarazo_Sangre With {
            .Identidad = Identidad,
            .Paciente = Paciente,
            .Edad = Edad,
            .Sexo = Sexo,
            .Referencia = Referencia,
            .N_Muestra = Muestra,
            .Fecha = Fecha,
            .Resultado = Resultado,
            .Nota = Nota
        }


        Conexion.Embarazo_Sangre.InsertOnSubmit(Servicionuevo)
        Conexion.SubmitChanges()

    End Sub



End Class
