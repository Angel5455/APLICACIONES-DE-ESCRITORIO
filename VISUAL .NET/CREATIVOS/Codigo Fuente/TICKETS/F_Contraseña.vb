Public Class F_Contraseña

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)





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

        If e.KeyChar = ChrW(Keys.Enter) Then
            Call OK_Click(sender, e)
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

        ComboBox1.Text = "ADMIN"
        txtusuario.Text = My.Settings.MyUser
        txtcontraseña.Text = My.Settings.MyPass

        '      CheckBox1.Checked = My.Settings.ChkdUser
        '     CheckBox2.Checked = My.Settings.ChkdPass
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Try

            Dim dts As New dEmpleados
            Dim funciones As New Funcion

            dts.Usuario = txtusuario.Text
            dts.Contraseña = txtcontraseña.Text
            dts.Cargo = ComboBox1.Text

            If funciones.validar(dts) = True Then

                Dim fr As New F_Menu


                ' Dim conexion As New Conexion_Empleados
                Dim datos As New dEmpleados

                If ComboBox1.Text = "ADMIN" Then

                    MsgBox("ACCESO CORRECTO", MsgBoxStyle.Information, "CREATIVOS")

                    My.Settings.MOculto = 0
                    My.Settings.Save()
                    My.Settings.Reload()

                    My.Settings.MyUsuarios = txtusuario.Text
                    My.Settings.Save()
                    My.Settings.Reload()



                    fr.Show()

                    Me.Hide()

                Else
                    If ComboBox1.Text = "T.S." Then


                        My.Settings.MyUsuarios = txtusuario.Text
                        My.Settings.Save()
                        My.Settings.Reload()


                        My.Settings.MOculto = 1
                        My.Settings.Save()
                        My.Settings.Reload()


                        MsgBox("ACCESO CORRECTO", MsgBoxStyle.Information, "CREATIVOS")

                      
                        fr.Show()

                        Me.Hide()


                    End If


                End If

              
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

            If CheckBox1.Checked = True Then

                My.Settings.ChkdUser = True
                My.Settings.MyUser = txtusuario.Text

            Else

                My.Settings.ChkdUser = False
                My.Settings.MyUser = ""


            End If


            If CheckBox2.Checked = True Then

                My.Settings.ChkdPass = True
                My.Settings.MyPass = txtcontraseña.Text



            Else
                My.Settings.ChkdPass = False
                My.Settings.MyPass = ""



            End If

            My.Settings.Save()
            My.Settings.Reload()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Picturebox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picturebox2.Click
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CheckBox1.Checked = False
        CheckBox2.Checked = False

        txtusuario.Text = ""
        txtcontraseña.Text = ""
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            Call OK_Click(sender, e)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class