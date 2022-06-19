Imports System.Data.SqlClient

Public Class Login

    Protected cnn As New SqlConnection

    Protected Function conectado()

        Dim estado As Boolean = True

        Try

            cnn = New SqlConnection("Data Source=(local);Initial Catalog=OFICIALIA;User ID=sa;Password=root")
            cnn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            estado = False
        End Try
        Return estado
    End Function

    Protected Function desconectado()
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
