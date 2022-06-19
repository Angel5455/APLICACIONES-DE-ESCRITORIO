Public Class DFSP
    Dim Conexion As New DataClasses1DataContext()
    Dim Query
    Public Resultados As String
    Event Errores(ByVal Examen As String)

    Function Id() As Integer
        Try
            Query = (From n In Conexion.FSP Select n).Count
        Catch ex As Exception
            RaiseEvent Errores("Error al obtener el codigo.")
        End Try
        Return Convert.ToInt32(Query)
    End Function
    Public Sub Guardar_Examen(ByVal Identidad As String, ByVal Paciente As String, ByVal Edad As Integer, ByVal Sexo As String, ByVal Referencia As String, ByVal Muestra As Integer, ByVal Fecha As String, ByVal SerieRoja As String, ByVal SerieBlanca As String, ByVal Neu As String, ByVal Eo As String, ByVal Baso As String, ByVal Mono As String, ByVal Linfo As String, ByVal Serie_Plaquetaria As String)

        'Servicionuevo.Id = id
        Dim Servicionuevo As New FSP With {
            .Identidad = Identidad,
            .Paciente = Paciente,
            .Edad = Edad,
            .Sexo = Sexo,
            .Referencia = Referencia,
            .N_Muestra = Muestra,
            .Fecha = Fecha,
            .Serie_Roja = SerieRoja,
            .Serie_Blanca = SerieBlanca,
            .Neutrofilos = Neu,
            .Eosinofilos = Eo,
            .Basofilos = Baso,
            .Monocitos = Mono,
            .Linfocitos = Linfo,
            .Serie_Plaquetaria = Serie_Plaquetaria
                }


        Conexion.FSP.InsertOnSubmit(Servicionuevo)
        Conexion.SubmitChanges()

    End Sub

End Class
