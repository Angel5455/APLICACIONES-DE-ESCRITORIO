Imports System.Data
Imports System.Data.SqlClient

Public Class ValidarCorreo

    Public Function Comprobar_Correo(ByVal s As String) As String

        Dim strCorreo As String

        Try
            Conexion.conexion.Open()
            Dim consulta As New SqlCommand("Select * from Usuarios where Correo='" & s & "'", Conexion.conexion)
            strCorreo = CType(consulta.ExecuteScalar(), String)

            If strCorreo Is Nothing Then
                strCorreo = "N"
            End If

        Catch ex As Exception
            strCorreo = "ERROR"

        Finally

            If Conexion.conexion.State <> ConnectionState.Closed Then
                Conexion.conexion.Close()
            End If


        End Try
        Return strCorreo

    End Function


End Class
