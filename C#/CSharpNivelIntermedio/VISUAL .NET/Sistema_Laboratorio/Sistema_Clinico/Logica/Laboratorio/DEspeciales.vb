Public Class DEspeciales
    Dim Conexion As New DataClasses1DataContext()
    Dim Query
    Public Resultados As String
    Event Errores(ByVal Examen As String)

    Function Id() As Integer

        Dim ConexionDoc As New CConexion
        Dim Sql As New DataSet
        Dim M As Integer

        Sql = ConexionDoc.Consultar("SELECT * FROM PEspeciales WHERE N_Muestra=   (SELECT MAX(N_Muestra) FROM PEspeciales)")


        If (Sql.Tables(0).Rows.Count > 0) Then
            M = Sql.Tables(0).Rows(0).Item("N_Muestra")
        Else

            M = 0
        End If


        Return M
    End Function
    Public Sub Guardar_Examen(ByVal Identidad As String, ByVal Paciente As String, ByVal Edad As Integer, ByVal Sexo As String, ByVal Referencia As String, ByVal Muestra As Integer, ByVal Fecha As String, ByVal Examen As String, ByVal Resultado As String, ByVal Valor_Referencia As String, ByVal Nota As String)

        'Servicionuevo.Id = id
        Dim Servicionuevo As New PEspeciales With {
            .Identidad = Identidad,
            .Paciente = Paciente,
            .Edad = Edad,
            .Sexo = Sexo,
            .Referencia = Referencia,
            .N_Muestra = Muestra,
            .Fecha = Fecha,
            .Examen = Examen,
            .Resultado = Resultado,
            .Valor_Referencia = Valor_Referencia,
            .Nota = Nota
        }


        Conexion.PEspeciales.InsertOnSubmit(Servicionuevo)
        Conexion.SubmitChanges()

    End Sub


End Class
