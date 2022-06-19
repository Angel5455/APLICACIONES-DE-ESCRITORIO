Imports System.Data
Imports System.Data.SqlClient

Public Class Validar_Ordenes


    Public Function Comprobar_id(ByVal s As String) As String

        Dim strId As String

        Try
            Conexion.conexion3.Open()
            Dim consulta As New SqlCommand("Select * from Ordenes where Id='" & s & "'", Conexion.conexion3)
            strId = CType(consulta.ExecuteScalar(), String)

            If strId Is Nothing Then
                strId = "N"
            End If

        Catch ex As Exception
            strId = "ERROR"

        Finally

            If Conexion.conexion3.State <> ConnectionState.Closed Then
                Conexion.conexion3.Close()
            End If


        End Try
        Return strId

    End Function

    Public Function Comprobar_ND(ByVal s As String) As String

        Dim strND As String

        Try
            Conexion.conexion3.Open()
            Dim consulta As New SqlCommand("Select * from Ordenes where N_Desembolso='" & s & "'", Conexion.conexion3)
            strND = CType(consulta.ExecuteScalar(), String)

            If strND Is Nothing Then
                strND = "N"
            End If

        Catch ex As Exception
            strND = "ERROR"

        Finally

            If Conexion.conexion3.State <> ConnectionState.Closed Then
                Conexion.conexion3.Close()
            End If


        End Try
        Return strND

    End Function


End Class
