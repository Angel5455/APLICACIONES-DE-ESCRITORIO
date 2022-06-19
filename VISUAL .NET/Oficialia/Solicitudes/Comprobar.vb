Imports System.Data.SqlClient

Public Class Comprobar

    Public Function Comprobar_Expediente(ByVal i As String) As String

        Dim strIdentidad As String

        Try
            Conexion.conexion.Open()
            Dim consulta As New SqlCommand("Select * from Solicitudes where Expediente='" & i & "'", Conexion.conexion)
            strIdentidad = CType(consulta.ExecuteScalar(), String)

            If strIdentidad Is Nothing Then
                strIdentidad = "S"
            End If

        Catch ex As Exception
            strIdentidad = "ERROR"

        Finally

            If Conexion.conexion.State <> ConnectionState.Closed Then
                Conexion.conexion.Close()
            End If


        End Try
        Return strIdentidad

    End Function



    Public Function Comprobar_TGR(ByVal i As String) As String

        Dim strIdentidad As String

        Try
            Conexion.conexion.Open()
            Dim consulta As New SqlCommand("Select * from Solicitudes where Tgr='" & i & "'", Conexion.conexion)
            strIdentidad = CType(consulta.ExecuteScalar(), String)

            If strIdentidad Is Nothing Then
                strIdentidad = "S"
            End If

        Catch ex As Exception
            strIdentidad = "ERROR"

        Finally

            If Conexion.conexion.State <> ConnectionState.Closed Then
                Conexion.conexion.Close()
            End If


        End Try
        Return strIdentidad

    End Function




End Class
