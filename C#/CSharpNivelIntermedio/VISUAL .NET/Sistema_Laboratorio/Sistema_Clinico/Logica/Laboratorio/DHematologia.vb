Public Class DHematologia
    Dim Conexion As New DataClasses1DataContext()
    Dim Query
    Public Resultados As String
    Event Errores(ByVal Examen As String)

    Function Id() As Integer


        Dim ConexionDoc As New CConexion
        Dim Sql As New DataSet
        Dim M As Integer

        Sql = ConexionDoc.Consultar("SELECT * FROM Hematologia WHERE N_Muestra=   (SELECT MAX(N_Muestra) FROM Hematologia)")


        If (Sql.Tables(0).Rows.Count > 0) Then
            M = Sql.Tables(0).Rows(0).Item("N_Muestra")
        Else

            M = 0
        End If


        Return M
    End Function
    Public Sub Guardar_Examen(ByVal Identidad As String, ByVal Paciente As String, ByVal Edad As Integer, ByVal Sexo As String, ByVal Referencia As String, ByVal N_Muestra As Integer, ByVal Fecha As String, ByVal Examen As String, ByVal Resultado As String, ByVal Valor_Referencia As String)

        'Servicionuevo.Id = id
        Dim Servicionuevo As New Hematologia With {
            .N_Muestra = N_Muestra,
            .Identidad = Identidad,
            .Paciente = Paciente,
            .Edad = Edad,
            .Sexo = Sexo,
            .Referencia = Referencia,
            .Fecha = Fecha,
            .Examen = Examen,
            .Resultado = Resultado,
            .Valor_Referencia = Valor_Referencia
            }


        Conexion.Hematologia.InsertOnSubmit(Servicionuevo)
        Conexion.SubmitChanges()

    End Sub

End Class
