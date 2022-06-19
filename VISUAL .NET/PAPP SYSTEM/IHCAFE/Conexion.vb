Imports System.Data
Imports System.Data.SqlClient

Module Conexion

    Public cadena As String = "Data Source=(local);Initial Catalog=Login;User ID=sa;Password=root"
    Public conexion As New SqlConnection(cadena)


    Public cadena2 As String = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"
    Public conexion2 As New SqlConnection(cadena2)


    Public cadena3 As String = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"
    Public conexion3 As New SqlConnection(cadena3)



    Public Sub abrir()
        Try
            conexion.Open()
            conexion2.Open()
            conexion3.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub cerrar()

        conexion.Close()
        conexion2.Close()
        conexion3.Close()


    End Sub



End Module
