Imports System.Data
Imports System.Data.SqlClient

Public Class ValidarUsuarios

    Public Function Comprobar_Users(ByVal s As String) As String

        Dim strUsers As String

        Try
            Conexion.conexion.Open()
            Dim consulta As New SqlCommand("Select * from Usuarios where Usuario ='" & s & "'", Conexion.conexion)
            strUsers = CType(consulta.ExecuteScalar(), String)

            If strUsers Is Nothing Then
                strUsers = "N"
            End If

        Catch ex As Exception
            strUsers = "ERROR"

        Finally

            If Conexion.conexion.State <> ConnectionState.Closed Then
                Conexion.conexion.Close()
            End If


        End Try
        Return strUsers

    End Function

    Public Function Comprobar_Pass(ByVal s As String) As String

        Dim strPass As String


        Try
            Conexion.conexion.Open()
            Dim consulta As New SqlCommand("Select Contraseña from Usuarios where Usuario ='" & s & "'", Conexion.conexion)
            strPass = CType(consulta.ExecuteScalar(), String)

            If strPass Is Nothing Then
                strPass = "NO EXISTE PASSWORD"
            End If


        Catch ex As Exception

            strPass = "ERROR"

        Finally

            If Conexion.conexion.State <> ConnectionState.Closed Then
                Conexion.conexion.Close()
            End If


        End Try

        Return strPass

    End Function


End Class
