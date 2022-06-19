Public Class F_AgregarUsuario


    Public WithEvents Query As New DUsuarios
    Dim ConexionLINQ As New DataClasses1DataContext()
    Dim Identidad As String
    Dim Email As String
    Dim EBien As Boolean
    Dim IBien As Boolean
    Dim DuplicadoId As String
    Dim DuplicadoE As String

    Public Id As Integer

    'Public FotoPrincipal As String
    Public Foto As String = "/img/Usuarios/usuario.png"

    Private Sub F_AgregarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Identidad = TxtIdentidad.Text
        Email = TxtEmail.Text

    End Sub

    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefono.TextChanged

    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If



        If Asc(e.KeyChar) = 13 Then

            BtnEnviar.Focus()

        End If
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged

    End Sub

    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtIdentidad.Focus()

        End If
    End Sub

    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged


    End Sub

    Private Sub TxtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEmail.KeyPress
        If Asc(e.KeyChar) = 13 Then

            Comprobar_Email()



        End If

    End Sub


    Private Sub TxtPassword_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TxtPassword.MaskInputRejected

    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtDireccion.Focus()

        End If
    End Sub

    Private Sub TxtDireccion_TextChanged(sender As Object, e As EventArgs) Handles TxtDireccion.TextChanged

    End Sub

    Private Sub TxtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDireccion.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtTelefono.Focus()

        End If
    End Sub

    Sub Limpiar()

        TxtNombre.Clear()
        TxtEmail.Clear()
        TxtPassword.Clear()
        TxtDireccion.Clear()
        TxtCargo.Clear()
        TxtTelefono.Clear()

        Dim Logo As String
        Logo = "\img\Usuarios\Usuario.png"

        PicFoto.Load(Application.StartupPath & Logo)


    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click


        If TxtIdentidad.Text = "" Or TxtNombre.Text = "" Or TxtEmail.Text = "" Or TxtPassword.Text = "" Then

            If TxtNombre.Text = "" Then
                TxtNombre.BackColor = Color.Yellow
                TxtNombre.Focus()
            End If

            If TxtIdentidad.Text = "" Then
                TxtIdentidad.BackColor = Color.Yellow
                TxtIdentidad.Focus()
            End If

            If TxtEmail.Text = "" Then
                TxtEmail.BackColor = Color.Yellow
                TxtEmail.Focus()
            End If

            If TxtPassword.Text = "" Then
                TxtPassword.BackColor = Color.Yellow
                TxtPassword.Focus()
            End If



            MsgBox("Los Campos de color Amarillo son Obligatorios", MsgBoxStyle.Exclamation, "Llene los Campos Vacios")
        Else

            If Me.Text = "Registro de Medicos" Or Me.Text = "Registro de Laboratorista" Or Me.Text = "Registro de Enfermera" Or Me.Text = "Registro de Recepcionista" Then

                Dim telefono As String

                If TxtTelefono.Text = "" Then
                    telefono = "No tiene"
                Else
                    telefono = TxtTelefono.Text
                End If

                Comprobar_Identidad()
                Comprobar_Email()

                If DuplicadoId = "Identidad" Or DuplicadoE = "Email" Then

                    If DuplicadoId = "Identidad" Then

                        TxtIdentidad.Clear()
                        TxtIdentidad.Focus()
                    ElseIf DuplicadoE = "Email" Then

                        TxtEmail.Clear()
                        TxtEmail.Focus()
                    End If

                Else
                    Call Query.Insertar_Usuario(TxtNombre.Text, TxtIdentidad.Text, TxtEmail.Text, TxtPassword.Text, TxtDireccion.Text, telefono, TxtCargo.Text, ConvertImage.ImageToByteArray(PicFoto.Image))
                    MessageBox.Show("Los Datos fueron agregados con exito", "Datos Guardados...")
                    My.Settings.Ruta = TxtCargo.Text
                    My.Settings.Save()
                    My.Settings.Reload()
                    F_Usuarios.Close()
                    F_Usuarios.Query.Buscar_Usuarios(F_Usuarios.DataGridView1, "", TxtCargo.Text)




                    Abrir_FormulariosHijos(New F_Usuarios)
                    Limpiar()
                    Me.Close()


                End If



            ElseIf Me.Text = "Editar Medico" Or Me.Text = "Editar Enfermera" Or Me.text = "Editar Laboratorista" Or Me.Text = "Editar Recepcionista" Then

                Comprobar_Identidad()
                Comprobar_Email()

                If DuplicadoId = "Identidad" Or DuplicadoId = "ExcepcionId" Or DuplicadoE = "Email" Or DuplicadoE = "ExcepcionEmail" Then

                    If DuplicadoId = "Identidad" Then
                        IBien = False
                        TxtIdentidad.Clear()
                        TxtIdentidad.Focus()
                    End If
                    If DuplicadoE = "Email" Then
                        EBien = False
                        TxtEmail.Clear()
                        TxtEmail.Focus()
                    End If
                    If DuplicadoId = "ExcepcionId" Or DuplicadoE = "ExcepcionEmail" Then

                        If DuplicadoId = "ExcepcionId" Then
                            IBien = True
                        End If
                        If DuplicadoE = "ExcepcionEmail" Then
                            EBien = True
                        End If
                    End If
                End If

                If DuplicadoId = "" Or DuplicadoE = "" Then

                    If DuplicadoId = "" Then
                        IBien = True
                    End If

                    If DuplicadoE = "" Then
                        EBien = True
                    End If



                End If

            End If

            If IBien And EBien Then
                Call Query.Editar_Usuario(Id, TxtNombre.Text, TxtIdentidad.Text, TxtEmail.Text, TxtPassword.Text, TxtDireccion.Text, TxtTelefono.Text, TxtCargo.Text, ConvertImage.ImageToByteArray(PicFoto.Image))
                MessageBox.Show("Los Datos fueron modificados con exito", "Datos Guardados...")

                My.Settings.Ruta = TxtCargo.Text
                My.Settings.Save()
                My.Settings.Reload()

                F_Usuarios.Query.Buscar_Usuarios(F_Usuarios.DataGridView1, "", TxtCargo.Text)

                F_Usuarios.Close()

                Abrir_FormulariosHijos(New F_Usuarios)
                Limpiar()
                Me.Close()
            Else
                If IBien = False Then
                    TxtIdentidad.Clear()
                    TxtIdentidad.Focus()


                End If

                If EBien = False Then
                    TxtEmail.Clear()
                    TxtEmail.Focus()

                End If
            End If





        End If





    End Sub

    Private FormularioActual As Form = Nothing
    Private Sub Abrir_FormulariosHijos(FormularioHijo As Form)

        If FormularioActual IsNot Nothing Then FormularioActual.Close()
        FormularioActual = FormularioHijo

        FormularioHijo.TopLevel = False
        FormularioHijo.FormBorderStyle = FormBorderStyle.None
        FormularioHijo.Dock = DockStyle.Fill
        Form1.PanelFormularioHijo.Controls.Add(FormularioHijo)
        Form1.PanelFormularioHijo.Tag = FormularioHijo
        FormularioHijo.BringToFront()
        FormularioHijo.Show()



    End Sub

    Private Sub BtnFoto_Click(sender As Object, e As EventArgs) Handles BtnFoto.Click
        Dim file As New OpenFileDialog With {
            .Filter = "Archivo JPG|*.jpg"
        }
        If file.ShowDialog() = DialogResult.OK Then
            PicFoto.Image = Image.FromFile(file.FileName)
        End If

    End Sub

    Private Sub TxtIdentidad_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TxtIdentidad.MaskInputRejected

    End Sub

    Private Sub TxtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdentidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Comprobar_Identidad()


        End If

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles TxtIdentidad.TextChanged

    End Sub

    Sub Comprobar_Identidad()

        If Me.Text = "Registro de Medicos" Or Me.Text = "Registro de Laboratorista" Or Me.Text = "Registro de Enfermera" Or Me.Text = "Registro de Recepcionista" Then
            Dim Conexion As New CConexion
            Dim Sql As New DataSet

            Sql = Conexion.Consultar("SELECT * FROM Usuarios WHERE Identidad='" & TxtIdentidad.Text & "'")
            Try
                Dim Usuario As String = Sql.Tables(0).Rows(0).Item("Nombre")
                If Usuario <> "" Then
                    MsgBox("Identidad del Usuario ya Registrado", MsgBoxStyle.Exclamation, "Consultorio Letona")
                    DuplicadoId = "Identidad"
                    TxtIdentidad.Clear()
                    TxtIdentidad.Focus()


                Else
                    TxtEmail.Focus()


                End If

            Catch ex As Exception
                TxtEmail.Focus()
                DuplicadoId = ""
            End Try

        End If


        If Me.Text = "Editar Medico" Or Me.Text = "Editar Laboratorista" Or Me.Text = "Editar Enfermera" Or Me.Text = "Editar Recepcionista" Then
            Dim Conexion As New CConexion
            Dim Sql As New DataSet

            Sql = Conexion.Consultar("SELECT * FROM Usuarios WHERE Identidad='" & TxtIdentidad.Text & "'")


            Try
                Dim Usuario As String = Sql.Tables(0).Rows(0).Item("Nombre")


                If Identidad = TxtIdentidad.Text Then
                    DuplicadoId = "ExcepcionId"

                Else
                    DuplicadoId = "Identidad"

                End If

                If DuplicadoId = "ExcepcionId" Then

                Else
                    MsgBox("Identidad del Usuario ya Registrado", MsgBoxStyle.Exclamation, "Consultorio Letona")

                    TxtIdentidad.Text = Identidad
                    TxtIdentidad.Focus()
                End If



            Catch ex As Exception

                TxtEmail.Focus()
                DuplicadoId = ""
            End Try

        End If

    End Sub


    Sub Comprobar_Email()
        If Me.Text = "Registro de Medicos" Or Me.Text = "Registro de Laboratorista" Or Me.Text = "Registro de Enfermera" Or Me.Text = "Registro de Recepcionista" Then
            Dim Conexion As New CConexion
            Dim Sql As New DataSet

            Sql = Conexion.Consultar("SELECT * FROM Usuarios WHERE Email='" & TxtEmail.Text & "'")
            Try
                Dim Usuario As String = Sql.Tables(0).Rows(0).Item("Email")
                If Usuario <> "" Then
                    MsgBox("Correo Electronico del Usuario ya Registrado", MsgBoxStyle.Exclamation, "Consultorio Letona")
                    DuplicadoE = "Email"


                    TxtEmail.Clear()
                    TxtEmail.Focus()


                Else
                    TxtPassword.Focus()


                End If

            Catch ex As Exception
                TxtPassword.Focus()
                DuplicadoE = ""
            End Try

        End If


        If Me.Text = "Editar Medico" Or Me.Text = "Editar Laboratorista" Or Me.Text = "Enfermera" Or Me.Text = "Recepcionista" Then
            Dim Conexion As New CConexion
            Dim Sql As New DataSet

            Sql = Conexion.Consultar("SELECT * FROM Usuarios WHERE Email='" & TxtEmail.Text & "'")


            Try
                Dim Usuario As String = Sql.Tables(0).Rows(0).Item("Email")


                If Email = TxtEmail.Text Then
                    DuplicadoE = "ExcepcionEmail"

                Else
                    DuplicadoE = "Email"

                End If

                If DuplicadoE = "ExcepcionEmail" Then

                Else
                    MsgBox("Correo Electronico del Usuario ya Registrado", MsgBoxStyle.Exclamation, "Consultorio Letona")
                    TxtEmail.Text = Email
                    TxtEmail.Focus()
                End If




            Catch ex As Exception

                TxtPassword.Focus()
                DuplicadoE = ""
            End Try

        End If

    End Sub

    Private Sub F_AgregarUsuario_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Abrir_FormulariosHijos(New F_Usuarios)
    End Sub


End Class



