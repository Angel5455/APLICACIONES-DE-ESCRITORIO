Public Class F_Contraseña

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Try

            Dim dts As New dEmpleados
            Dim funciones As New Funcion

            dts.Usuario = txtusuario.Text
            dts.Contraseña = txtcontraseña.Text
         
            If funciones.validar(dts) = True Then

                Dim fr As New F_Menu


                Dim conexion As New Conexion_Empleados
                Dim datos As New dEmpleados



                MsgBox("ACCESO CORRECTO", MsgBoxStyle.Information, "CREATIVOS")
            
                
                fr.Show()

                Me.Hide()


            Else

                MsgBox("Datos Incorrectos", MsgBoxStyle.Critical, "Error")


                Dim n As New ValidarUsuarios
                Dim r As New ValidarUsuarios

                Dim crol As String
                Dim pass As String

                crol = n.Comprobar_Users(UCase(txtusuario.Text))
                pass = r.Comprobar_Pass(UCase(txtusuario.Text))


                If crol = "N" Then

                    MsgBox("El Usuario no Existe", MsgBoxStyle.Critical, "Error")


                ElseIf pass <> txtcontraseña.Text.ToUpper Then


                End If


                txtusuario.Focus()


            End If

        Catch ex As Exception

        End Try




    End Sub

    Sub encriptar()

        '  txtEncrip.Text = ""


        Dim cad As String
        Dim p As Integer

        For p = 1 To Len(txtcontraseña.Text)

            cad = Mid(txtcontraseña.Text, p, 1)
            cad = Asc(cad) + 1

            '    txtEncrip.Text = txtEncrip.Text + ChrW(cad)


        Next


    End Sub

    Private Sub txtusuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtusuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub txtcontraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontraseña.KeyPress
        encriptar()

        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtcontraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcontraseña.TextChanged

    End Sub

    Private Sub txtcargo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtcargo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        F_Usuarios.Show()
    End Sub

    Private Sub F_Contraseña_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class