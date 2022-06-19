Imports System.Data
Imports System.Data.OleDb

Public Class F_Contraseña
    

    Public usuario As String
    Dim accion As Boolean


    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        OK.Height = 70
        OK.Width = 70

    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        Picturebox2.Height = 70
        Picturebox2.Width = 70

    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        PictureBox2.Height = 75
        PictureBox2.Width = 75

    End Sub

    Private Sub F_Contraseña_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LoginDataSet.Usuarios' Puede moverla o quitarla según sea necesario.

        Popen.Visible = False
        Pclose.Visible = True


        lblFecha.Text = Today


        txtusuario.Text = My.Settings.MyUser
        txtcontraseña.Text = My.Settings.MyPass

        CheckBox1.Checked = My.Settings.ChkdUser
        CheckBox2.Checked = My.Settings.ChkdPass




        'OK.Enabled = False


    End Sub



    Private Sub Picturebox1_MouseEnter1(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK.MouseEnter
        OK.Height = 45
        OK.Width = 45

    End Sub

    Private Sub Picturebox1_MouseLeave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK.MouseLeave
        OK.Height = 50
        OK.Width = 50

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Picturebox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picturebox2.Click

        Dim resp As Integer
        resp = MsgBox("¿Esta seguro de salir?", MsgBoxStyle.YesNo, "P.A.P.P System")
        If resp = 6 Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End

        End If


    End Sub

    Private Sub Picturebox2_MouseEnter1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Picturebox2.MouseEnter
        Picturebox2.Height = 45
        Picturebox2.Width = 45

    End Sub

    Private Sub Picturebox2_MouseLeave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Picturebox2.MouseLeave
        Picturebox2.Height = 50
        Picturebox2.Width = 50

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click


        Try

            Dim dts As New cDatos
            Dim funciones As New Funcion

            dts.Usuario = txtusuario.Text
            dts.Contraseña = txtcontraseña.Text
            dts.Cargo = txtcargo.Text


            If funciones.validar(dts) = True Then

                Dim fr As New F_Menu


                Dim conexion As New Conexion_Usuarios
                Dim datos As New cDatos

                datos.fecha = lblFecha.Text
                datos.hora = lbltime.Text
                datos.Usuario = txtusuario.Text

                F_Menu.lblUsuario.Text = txtusuario.Text


                If conexion.insertar_datos_historial(datos) Then
                    If conexion.consultar_todos Then



                    End If

                    'MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    'MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If


                Popen.Visible = True
                Pclose.Visible = False

                MsgBox("ACCESO CORRECTO", MsgBoxStyle.Information, "P.A.P.P SYSTEM")

                F_Menu.btnSalir.Visible = True
                F_Menu.btnSalir2.Visible = False

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


    Private Sub txtusuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusuario.TextChanged, txtcontraseña.TextChanged
        If Len(txtcontraseña.Text) = 0 And Len(txtusuario.Text) = 0 Then

            OK.Enabled = False

        Else

            OK.Enabled = True

        End If
    End Sub


    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        If MessageBox.Show("¿Desea Quitar Usuario?", "Aviso", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.OK Then

            My.Settings.ChkdPass = False
            My.Settings.ChkdUser = False
            My.Settings.MyUser = ""
            My.Settings.MyPass = ""


            F_Contraseña_Load(sender, e)
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

        F_RecuperarContraseña.Show()
        Me.Hide()

    End Sub

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CheckBox1.Checked = False
        CheckBox2.Checked = False

        txtusuario.Text = ""
        txtcontraseña.Text = ""

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbltime.Text = Date.Now.ToLongTimeString
    End Sub
End Class