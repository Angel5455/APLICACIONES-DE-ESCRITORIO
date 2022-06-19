Imports System.Data.SqlClient

Public Class Funcion
    Inherits login
    Dim cmd As New SqlCommand


    Public Function Validar(ByVal dts As CDatos) As Boolean
        Try

            Me.Conectado()
            cmd = New SqlCommand("validar") With {
                .CommandType = CommandType.StoredProcedure,
                .Connection = Cnn
            }
            cmd.Parameters.AddWithValue("@Identidad", dts.Usuario)
            cmd.Parameters.AddWithValue("@Password", dts.Contraseña)

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
