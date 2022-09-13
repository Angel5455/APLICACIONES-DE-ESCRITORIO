Public Class F_Contraseña

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click

        Try

            Dim dts As New cDatos
            Dim funciones As New Funcion

            dts.Usuario = txtusuario.Text
            dts.Contraseña = txtcontraseña.Text

            If funciones.validar(dts) = True Then

                Dim fr As New F_Fondo


                MsgBox("ACCESO CORRECTO", MsgBoxStyle.Information, "RNP")


                fr.Show()
                Me.Hide()
                F_Progreso.Hide()


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


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CheckBox1.Checked = False
        CheckBox2.Checked = False

        txtusuario.Text = ""
        txtcontraseña.Text = ""
    End Sub

    Private Sub F_Contraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtusuario.Text = My.Settings.MyUser
        txtcontraseña.Text = My.Settings.MyPass

        CheckBox1.Checked = My.Settings.ChkdUser
        CheckBox2.Checked = My.Settings.ChkdPass
    End Sub

    Private Sub txtusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub txtcontraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontraseña.KeyPress
       If e.KeyChar = ChrW(Keys.Enter) Then
            Call OK_Click(sender, e)
        End If
    End Sub

    Private Sub txtcontraseña_TextChanged(sender As Object, e As EventArgs) Handles txtcontraseña.TextChanged

    End Sub

    Private Sub Picturebox2_Click(sender As Object, e As EventArgs) Handles Picturebox2.Click
        End

    End Sub
End Class