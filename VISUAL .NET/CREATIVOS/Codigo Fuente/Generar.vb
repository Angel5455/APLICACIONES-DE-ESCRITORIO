Imports System.Data.SqlClient

Module Generar

    Public cn As New SqlConnection("server=localhost;database=SISTEMA; integrated security = true")
    Public dsEntorno As New DataSet
    Public tipoDocu As String
    Public codDocu As String
    Public Function Generadores(ByVal TABLA As String) As String
        Dim RESULT As String = ""
        Dim DR1 As SqlDataReader
        Dim ULT As Integer = 0
        Dim CMD As New SqlCommand("SELECT ULTIMO FROM GENERADOR WHERE PARAMETRO = '" +
        TABLA + "'", cn)
        cn.Open()
        DR1 = CMD.ExecuteReader
        While DR1.Read
            ULT = Val(DR1("ULTIMO") + 1)
        End While
        cn.Close()
        Dim CEROS As Integer
        CEROS = 5 - Len(Str(ULT))
        Select Case CEROS
            Case 3 : RESULT = Left(TABLA, 1) + "000" + Trim(Str(ULT))
            Case 2 : RESULT = Left(TABLA, 1) + "00" + Trim(Str(ULT))
            Case 1 : RESULT = Left(TABLA, 1) + "0" + Trim(Str(ULT))
            Case 0 : RESULT = Left(TABLA, 1) + "" + Trim(Str(ULT))
        End Select
        Generadores = RESULT
    End Function

End Module
