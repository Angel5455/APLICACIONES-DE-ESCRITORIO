Imports System.Data.SqlClient

Public Class Funcion

    Inherits Login
    Dim cmd As New SqlCommand


    Public Function validar(ByVal dts As dEmpleados) As Boolean
        Try

            Me.conectado()
            cmd = New SqlCommand("validar")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Usuario", dts.Usuario)
            cmd.Parameters.AddWithValue("@Contraseña", dts.contraseña)
            cmd.Parameters.AddWithValue("@Cargo", dts.Cargo)
            Dim dr As SqlDataReader

            dr = cmd.ExecuteReader

            If dr.HasRows = True Then

                Return True
            Else

                Return False

            End If

        Catch ex As Exception

            MsgBox(ex.Message)
            Return False

        End Try


    End Function



End Class
