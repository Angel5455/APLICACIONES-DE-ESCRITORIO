Imports System.Data
Imports System.Data.SqlClient

Module Conexion

    Public cadena As String = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"
    Public conexion As New SqlConnection(cadena)

    Public Sub abrir()
        Try
            conexion.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub cerrar()

        conexion.Close()

    End Sub


End Module
