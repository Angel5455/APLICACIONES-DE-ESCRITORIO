Imports System.Data.SqlClient
Imports GoEmail

Public Class F_Recuperar

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        If TxtUsuario.Text <> "" Then

            Dim strCorreo As String
            Dim Conexion As New CConexion
            Dim Sql As New DataSet


            Dim Correo, Pass, Nombre As String

            Try
                Conexion.Conexion.Open()
                Dim consulta As New SqlCommand("Select * from Usuarios where Identidad='" & TxtUsuario.Text & "'", Conexion.Conexion)
                strCorreo = CType(consulta.ExecuteScalar(), String)

                If strCorreo Is Nothing Then
                    MsgBox("Usuario no Registrado", MsgBoxStyle.Information, "Consultorio Letona")
                    TxtUsuario.Clear()
                    TxtUsuario.Focus()
                Else
                    Sql = Conexion.Consultar("SELECT * FROM USUARIOS WHERE Identidad='" & TxtUsuario.Text & "'")

                    Nombre = Sql.Tables(0).Rows(0).Item("Nombre")
                    Correo = Sql.Tables(0).Rows(0).Item("Email")
                    Pass = Sql.Tables(0).Rows(0).Item("Password")


                    Dim Destino As String = Correo
                    Dim asunto As String = "RECUPERACION DE CONTRASEÑA SYSTEM LETONA"
                    Dim mensaje As String = "Usuario: " & Nombre & "/" & TxtUsuario.Text & "  " & "Contraseña: " & Pass
                    Dim gmail As String = "consultoriomedicoletona@gmail.com"
                    Dim password As String = "oswaldo87"

                    Dim x As New EnviarEmail()
                    Dim exito As Boolean = x.EnviarMail(Destino, asunto, mensaje, "LETONA", gmail, password)

                    If exito Then
                        MessageBox.Show("...Se ha enviado el mensaje al correo " & Correo & "...")
                        Me.Close()
                    Else
                        MessageBox.Show("...No se ha enviado el mensaje...")
                    End If


                End If


            Catch ex As Exception
                MsgBox("Error")

            Finally

                If Conexion.Conexion.State <> ConnectionState.Closed Then
                    Conexion.Conexion.Close()
                End If

            End Try

        Else

            MsgBox("Ingrese Usuario", MsgBoxStyle.Exclamation, "Consultorio Letona")
            TxtUsuario.Focus()

        End If

    End Sub

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged

    End Sub

    Private Sub TxtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsuario.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        ' Matriz de caracteres que deseamos controlar
        '
        Dim caracteres() As Char = {"%"c, "&"c, "$"c, "#"c, "/"c, "-"c, "_"c}

        ' Carácter presionado
        '
        Dim c As Char = e.KeyChar

        ' Comprobamos si la matriz contiene el carácter tecleado.
        '
        If caracteres.Contains(c) Then

            MessageBox.Show("Se ha tecleado un carácter especial.")

            ' Deshechamos el carácter
            e.Handled = True

        End If
    End Sub
End Class