Imports System.Data.SqlClient

Public Class ValidarUsuarios
    Public Function Comprobar_Users(ByVal s As String) As String

        Dim strUsers As String

        Try
            Conexion.Conexion.Open()
            Dim consulta As New SqlCommand("Select * from Usuarios where Identidad ='" & s & "'", Conexion.Conexion)
            strUsers = CType(consulta.ExecuteScalar(), String)

            If strUsers Is Nothing Then
                strUsers = "N"
            End If

        Catch ex As Exception
            strUsers = "ERROR"

        Finally

            If Conexion.Conexion.State <> ConnectionState.Closed Then
                Conexion.Conexion.Close()
            End If


        End Try
        Return strUsers

    End Function

    Public Function Comprobar_Pass(ByVal s As String) As String

        Dim strPass As String


        Try
            Conexion.Conexion.Open()
            Dim consulta As New SqlCommand("Select Password from Usuarios where Identidad ='" & s & "'", Conexion.Conexion)
            strPass = CType(consulta.ExecuteScalar(), String)

            If strPass Is Nothing Then
                strPass = "NO EXISTE PASSWORD"
            End If


        Catch ex As Exception

            strPass = "ERROR"

        Finally

            If Conexion.Conexion.State <> ConnectionState.Closed Then
                Conexion.Conexion.Close()
            End If


        End Try

        Return strPass

    End Function
End Class
