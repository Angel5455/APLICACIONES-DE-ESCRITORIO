Imports System.Data.SqlClient

Public Class Login
    Protected Cnn As New SqlConnection

    Protected Function Conectado()

        Dim Estado As Boolean = True

        Try

            Cnn = New SqlConnection("Data Source=(local);Initial Catalog=SystemLetona;User ID=sa;Password=root")
            Cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Estado = False
        End Try
        Return Estado
    End Function

    Protected Function Desconectado()
        Dim estado As Boolean = True

        Try

            If cnn.State = ConnectionState.Open Then

                cnn.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            estado = False
        End Try

        Return estado

    End Function


End Class
