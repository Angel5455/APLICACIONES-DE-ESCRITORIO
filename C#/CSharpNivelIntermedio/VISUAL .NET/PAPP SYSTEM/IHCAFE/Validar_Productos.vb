Imports System.Data
Imports System.Data.SqlClient

Public Class Validar_Productos

    Public Function Comprobar_Productos(ByVal s As String) As String

        Dim strClave As String

        Try
            Conexion.conexion3.Open()
            Dim consulta As New SqlCommand("Select * from Productos where Codigo='" & s & "'", Conexion.conexion3)
            strClave = CType(consulta.ExecuteScalar(), String)

            If strClave Is Nothing Then
                strClave = "N"
            End If

        Catch ex As Exception
            strClave = "ERROR"

        Finally

            If Conexion.conexion3.State <> ConnectionState.Closed Then
                Conexion.conexion3.Close()
            End If


        End Try
        Return strClave

    End Function


    Public Function Comprobar_Compras(ByVal s As String) As String

        Dim strClave As String

        Try
            Conexion.conexion3.Open()
            Dim consulta As New SqlCommand("Select * from Productos where Compra='" & s & "'", Conexion.conexion3)
            strClave = CType(consulta.ExecuteScalar(), String)

            If strClave Is Nothing Then
                strClave = "S"
            End If

        Catch ex As Exception
            strClave = "ERROR"

        Finally

            If Conexion.conexion3.State <> ConnectionState.Closed Then
                Conexion.conexion3.Close()
            End If


        End Try
        Return strClave

    End Function

    Public Function Comprobar_Productos2(ByVal s As String) As String

        Dim strClave As String

        Try
            Conexion.conexion3.Open()
            Dim consulta As New SqlCommand("Select * from Productos2 where Codigo='" & s & "'", Conexion.conexion3)
            strClave = CType(consulta.ExecuteScalar(), String)

            If strClave Is Nothing Then
                strClave = "N"
            End If

        Catch ex As Exception
            strClave = "ERROR"

        Finally

            If Conexion.conexion3.State <> ConnectionState.Closed Then
                Conexion.conexion3.Close()
            End If


        End Try
        Return strClave

    End Function


    Public Function Comprobar_Factura(ByVal s As String) As String

        Dim strClave As String

        Try
            Conexion.conexion3.Open()
            Dim consulta As New SqlCommand("Select * from Productos2 where Factura='" & s & "'", Conexion.conexion3)
            strClave = CType(consulta.ExecuteScalar(), String)

            If strClave Is Nothing Then
                strClave = "S"
            End If

        Catch ex As Exception
            strClave = "ERROR"

        Finally

            If Conexion.conexion3.State <> ConnectionState.Closed Then
                Conexion.conexion3.Close()
            End If


        End Try
        Return strClave

    End Function



End Class
