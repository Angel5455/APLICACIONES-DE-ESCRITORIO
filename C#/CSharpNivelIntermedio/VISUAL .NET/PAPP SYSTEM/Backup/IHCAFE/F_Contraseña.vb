Imports System.Data
Imports System.Data.OleDb


Public Class F_Contraseña
    Public sAppPath As String = Application.StartupPath.ToString
    Public sBaseDatos As String = sAppPath & "\datos.accdb"
    Public sConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & sBaseDatos

    Private veces As Integer = 0
    Private Const NumeroIntentos As Integer = 3


    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        OK.Height = 70
        OK.Width = 70

    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        PictureBox2.Height = 70
        PictureBox2.Width = 70

    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        PictureBox2.Height = 75
        PictureBox2.Width = 75

    End Sub

    Private Sub F_Contraseña_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        resp = MsgBox("Esta Seguro De Salir", MsgBoxStyle.YesNo, "IHCAFE")
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
        If Me.txtcontraseña.Text <> "" And Me.txtusuario.Text <> "" Then
            Dim cn As New OleDbConnection(sConexion)
            Dim estatus As Integer
            ' Permitir varios intentos
            veces = veces + 1
            'Comenzamos una transacción
            Try
                cn.Open()
                ' evitamos la inyección de código reemplazando las comillas simples
                ' por otro carácter
                Dim sql As String = "Select estatus From usuarios Where " & _
                " contraseña = '" & Trim(Replace(Me.txtcontraseña.Text, "'", "k")) & _
                "' And usuario = '" & Trim(Replace(Me.txtusuario.Text, "'", "k")) & "'"



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








                'creamos un comando
                Dim cmd As New OleDbCommand(sql, cn)
                'leemos el valor y lo convertimos a entero
                estatus = CInt(cmd.ExecuteScalar().ToString)
            Catch ex As Exception
                'mostramos el error
                If Err.Number = 91 Then
                    MessageBox.Show("No se encontro registro ")
                Else
                    MessageBox.Show("error " & Err.Number.ToString & vbCrLf & ex.Message)
                End If
            Finally
                'cerramos la conexion solo si esta abierta
                If (cn.State And ConnectionState.Open) <> 0 Then
                    cn.Close()
                End If
            End Try


            If estatus = 1 Then

          

          
                F_Menu.Show()
                Me.Hide()





            ElseIf estatus = 2 Then


                F_Menu.OPCIONESDEUSUARIOSToolStripMenuItem.Visible = False
                'F_Menu.VENTANASToolStripMenuItem.Visible = False

                F_Menu.Show()

                Me.Hide()



            Else
                If veces < NumeroIntentos Then
                    Label1.Text = "Quedan " & (NumeroIntentos - veces) & " intentos"
                    If (cn.State And ConnectionState.Open) <> 0 Then
                        cn.Close()
                    End If
                    Exit Sub
                End If
                Me.DialogResult = Windows.Forms.DialogResult.No
            End If
            Hide()
        Else
            MessageBox.Show("Ingresa tus datos completos", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' todavía puedes hacerlo de esta forma
            'MsgBox("Ingresa tus datos completos.", MsgBoxStyle.Exclamation, "Faltan datos")
        End If
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
End Class