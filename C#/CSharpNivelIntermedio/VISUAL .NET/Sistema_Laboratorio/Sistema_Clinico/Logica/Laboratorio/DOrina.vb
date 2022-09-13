Public Class DOrina

    Dim Conexion As New DataClasses1DataContext()
    Dim Query
    Public Resultados As String
    Event Errores(ByVal Drogas As String)

    Function Id() As Integer
        Try
            Query = (From n In Conexion.Orina Select n).Count
        Catch ex As Exception
            RaiseEvent Errores("Error al obtener el codigo.")
        End Try
        Return Convert.ToInt32(Query)
    End Function
    Public Sub Guardar_Examen(ByVal Identidad As String, ByVal Paciente As String, ByVal Edad As Integer, ByVal Sexo As String, ByVal Referencia As String, ByVal Muestra As Integer, ByVal Fecha As String, ByVal Volumen As String, ByVal Color As String, ByVal Aspecto As String, ByVal Sedimento As String, ByVal Olor As String, ByVal LeucocitosQ As String, ByVal Cetonas As String, ByVal Nitritos As String, ByVal Uro As String, ByVal Bilirrubina As String, ByVal Proteinas As String, ByVal Glucosa As String, ByVal Densidad As String, ByVal PH As String, ByVal EritrocitosQ As String, ByVal LeucocitosM As String, ByVal EritrocitosM As String, ByVal Epi As String, ByVal Bacterias As String, ByVal Mocos As String, ByVal Cristales As String, ByVal Cilindros As String, ByVal Levaduras As String, ByVal Nota As String)

        'Servicionuevo.Id = id
        Dim Servicionuevo As New Orina With {
            .Identidad = Identidad,
            .Paciente = Paciente,
            .Edad = Edad,
            .Sexo = Sexo,
            .Referencia = Referencia,
            .N_Muestra = Muestra,
            .Fecha = Fecha,
            .Volumen = Volumen,
            .Color = Color,
            .Aspecto = Aspecto,
            .Olor = Olor,
            .Sedimento = Sedimento,
            .QLeucocitos = LeucocitosQ,
            .Cetonas = Cetonas,
            .Nitritos = Nitritos,
            .Urobilinogeno = Uro,
            .Bilirrubina = Bilirrubina,
            .Proteinas = Proteinas,
            .Glucosa = Glucosa,
            .Densidad = Densidad,
            .PH = PH,
            .QEritrocitos = EritrocitosQ,
            .MLeucocitos = LeucocitosM,
            .MEritrocitos = EritrocitosM,
            .C_Epiteliales = Epi,
            .Bacterias = Bacterias,
            .Mocos = Mocos,
            .Cristales = Cristales,
            .Cilindros = Cilindros,
            .Levaduras = Levaduras,
            .Nota = Nota
        }
        Conexion.Orina.InsertOnSubmit(Servicionuevo)
        Conexion.SubmitChanges()

    End Sub

End Class
