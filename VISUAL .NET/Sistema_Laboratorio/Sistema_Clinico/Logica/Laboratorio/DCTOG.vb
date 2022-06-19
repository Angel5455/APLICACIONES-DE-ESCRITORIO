Public Class DCTOG

    Dim Conexion As New DataClasses1DataContext()
    Dim Query
    Public Resultados As String
    Event Errores(ByVal Examen As String)

    Function Id() As Integer


        Dim ConexionDoc As New CConexion
        Dim Sql As New DataSet
        Dim M As Integer

        Sql = ConexionDoc.Consultar("SELECT * FROM CTOG WHERE N_Muestra=   (SELECT MAX(N_Muestra) FROM CTOG)")


        If (Sql.Tables(0).Rows.Count > 0) Then
            M = Sql.Tables(0).Rows(0).Item("N_Muestra")
        Else

            M = 0
        End If


        Return M
    End Function
    Public Sub Guardar_Examen(ByVal Muestra As Integer, ByVal Identidad As String, ByVal Paciente As String, ByVal Edad As Integer, ByVal Sexo As String, ByVal Referencia As String, ByVal Fecha As String, ByVal Examen As String, ByVal Resultado As String, ByVal VReferencia As String, ByVal Nota As String)

        'Servicionuevo.Id = id
        Dim Servicionuevo As New CTOG With {
            .N_Muestra = Muestra,
            .Identidad = Identidad,
            .Paciente = Paciente,
            .Edad = Edad,
            .Sexo = Sexo,
            .Referencia = Referencia,
            .Fecha = Fecha,
            .Examen = Examen,
            .Resultados = Resultado,
            .Valor_Referencia = VReferencia,
            .Nota = Nota
        }


        Conexion.CTOG.InsertOnSubmit(Servicionuevo)
        Conexion.SubmitChanges()

    End Sub


End Class
