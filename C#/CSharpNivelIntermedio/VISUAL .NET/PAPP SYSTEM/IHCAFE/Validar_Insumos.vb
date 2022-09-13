
Imports System.Data
Imports System.Data.SqlClient

Public Class Validar_Insumos

    Public Function Comprobar_ClaveP(ByVal s As String) As String

        Dim strClave As String

        Try
            Conexion.conexion2.Open()
            Dim consulta As New SqlCommand("Select * from Productores where Clave='" & s & "'", Conexion.conexion2)
            strClave = CType(consulta.ExecuteScalar(), String)

            If strClave Is Nothing Then
                strClave = "N"
            End If

        Catch ex As Exception
            strClave = "ERROR"

        Finally

            If Conexion.conexion2.State <> ConnectionState.Closed Then
                Conexion.conexion2.Close()
            End If


        End Try
        Return strClave

    End Function

    Public Function Comprobar_IdentidadP(ByVal i As String) As String

        Dim strIdentidad As String

        Try
            Conexion.conexion2.Open()
            Dim consulta2 As New SqlCommand("Select * from Productores where Identidad='" & i & "'", Conexion.conexion2)
            strIdentidad = CType(consulta2.ExecuteScalar(), String)

            If strIdentidad Is Nothing Then
                strIdentidad = "S"
            End If

        Catch ex As Exception
            strIdentidad = "ERROR"

        Finally

            If Conexion.conexion2.State <> ConnectionState.Closed Then
                Conexion.conexion2.Close()
            End If


        End Try
        Return strIdentidad

    End Function




End Class
