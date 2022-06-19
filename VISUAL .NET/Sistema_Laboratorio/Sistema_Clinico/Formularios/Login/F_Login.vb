Imports System.Runtime.InteropServices

Public Class F_Login

    Dim UNombre, CNombre As String
    Dim UIdentidad, CIdentidad As String
    Dim UCargo, CCargo As String
    Dim Login As String



    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub IconCerrar_Click(sender As Object, e As EventArgs) Handles IconCerrar.Click

        Me.Close()

    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub TxtUsuario_Leave(sender As Object, e As EventArgs) Handles txtUsuario.Leave
        If (txtUsuario.Text = "") Then

            txtUsuario.Text = "USUARIO"
            txtUsuario.ForeColor = Color.Black
        End If




    End Sub

    Private Sub TxtUsuario_Enter(sender As Object, e As EventArgs) Handles txtUsuario.Enter
        If (txtUsuario.Text = "USUARIO") Then

            txtUsuario.Text = ""
            txtUsuario.ForeColor = Color.Blue


        End If


    End Sub

    Private Sub TxtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub

    Private Sub TxtContraseña_Leave(sender As Object, e As EventArgs) Handles txtContraseña.Leave
        If (txtContraseña.Text = "") Then

            txtContraseña.Text = "CONTRASEÑA"
            txtContraseña.ForeColor = Color.Black
            txtContraseña.UseSystemPasswordChar = False

        End If

    End Sub

    Private Sub TxtContraseña_Enter(sender As Object, e As EventArgs) Handles txtContraseña.Enter
        If (txtContraseña.Text = "CONTRASEÑA") Then

            txtContraseña.Text = ""
            txtContraseña.ForeColor = Color.Blue
            txtContraseña.UseSystemPasswordChar = True

        End If



    End Sub

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub LinkContraseña_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkContraseña.LinkClicked
        F_Recuperar.ShowDialog()
    End Sub

    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub BtnAcceder_Click(sender As Object, e As EventArgs) Handles btnAcceder.Click


        Try

            Dim dts As New CDatos
            Dim funciones As New Funcion

            dts.Usuario = txtUsuario.Text
            dts.Contraseña = txtContraseña.Text

            If funciones.Validar(dts) = True Then

                Dim fr As New Form1


                MsgBox("ACCESO CORRECTO", MsgBoxStyle.Information, "Consultorio Letona")

                Form1.Mostrar_Barra()
                My.Settings.Login = txtUsuario.Text
                My.Settings.Save()
                My.Settings.Reload()

                Dim Conexion As New CConexion
                Dim Sql As New DataSet

                'My.Settings.Login = ""
                'My.Settings.Save()
                'My.Settings.Reload()


                Dim Identidad As String = My.Settings.Login
                Dim Cargo As String

                Sql = Conexion.Consultar("SELECT * FROM USUARIOS WHERE Identidad='" & Identidad & "'")

                Form1.LblUsuario.Text = Sql.Tables(0).Rows(0).Item("Nombre")
                Cargo = Sql.Tables(0).Rows(0).Item("Cargo")

                If Cargo = "Enfermera" Or Cargo = "Recepcionista" Then

                    Form1.BtnPLab.Visible = False

                    Form1.BtnAjustes.Visible = False
                End If

                If Cargo = "Laboratorista" Then

                    Form1.BtnPacientes.Visible = False

                    Form1.BtnAjustes.Visible = False
                End If

                Me.Close()


            Else

                MsgBox("Datos Incorrectos", MsgBoxStyle.Critical, "Error")


                Dim n As New ValidarUsuarios
                Dim r As New ValidarUsuarios

                Dim crol As String
                Dim pass As String

                crol = n.Comprobar_Users(UCase(txtUsuario.Text))
                pass = r.Comprobar_Pass(UCase(txtUsuario.Text))


                If crol = "N" Then

                    MsgBox("El Usuario no Existe", MsgBoxStyle.Critical, "Error")


                ElseIf pass <> txtContraseña.Text.ToUpper Then


                End If


                txtUsuario.Focus()


            End If

        Catch ex As Exception

        End Try



    End Sub

    Private Sub TxtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Asc(e.KeyChar) = 13 Then

            txtContraseña.Focus()

        End If


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

    Private Sub TxtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        If Asc(e.KeyChar) = 13 Then

            btnAcceder.Focus()

        End If
    End Sub
End Class