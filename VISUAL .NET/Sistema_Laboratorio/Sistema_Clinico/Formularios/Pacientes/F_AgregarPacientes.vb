Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class F_AgregarPacientes


    Public WithEvents Query As New Dpacientes
    Dim ConexionLINQ As New DataClasses1DataContext()
    Dim Id As Integer

    Dim Identidad As String
    Dim Email As String
    Dim EBien As Boolean
    Dim IBien As Boolean
    Dim DuplicadoId As String
    Dim DuplicadoE As String



    Dim resultado As MsgBoxResult
    Private Sub F_AgregarPacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Identidad = TxtIdentidad.Text
        Email = TxtEmail.Text

    End Sub

    Sub Limpiar()
        TxtPaciente.Clear()
        TxtIdentidad.Clear()
        TxtEmail.Clear()
        TxtSexo.Text = ""
        TxtEdad.Clear()

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


    Private Sub TxtPaciente_TextChanged(sender As Object, e As EventArgs) Handles TxtPaciente.TextChanged
        If TxtPaciente.Text = "" Then
            TxtPaciente.BackColor = Color.LightYellow
        Else
            TxtPaciente.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtIdentidad_TextChanged(sender As Object, e As EventArgs)
        If TxtIdentidad.Text = "" Then
            TxtIdentidad.BackColor = Color.LightYellow
        Else
            TxtIdentidad.BackColor = Color.White
        End If
    End Sub

    Private Sub F_AgregarPacientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.Text = "Registro de Pacientes - Laboratorio" Or Me.Text = "Editar Paciente - Laboratorio" Then
            Abrir_FormulariosHijos(New F_Informes)
        Else
            Abrir_FormulariosHijos(New F_Pacientes)

        End If
        Limpiar()


    End Sub



    Private Sub TxtEdad_TextChanged(sender As Object, e As EventArgs) Handles TxtEdad.TextChanged

    End Sub

    Private Sub TxtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdad.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtSexo.Focus()

        End If
    End Sub

    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs)

        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If



        If Asc(e.KeyChar) = 13 Then

            TxtEdad.Focus()

        End If
    End Sub

    Private Sub TxtIdentidad_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TxtIdentidad.MaskInputRejected



    End Sub

    Private Sub TxtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdentidad.KeyPress
        If Asc(e.KeyChar) = 13 Then


            Comprobar_Identidad()


        End If




    End Sub

    Private Sub TxtPaciente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPaciente.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtIdentidad.Focus()

        End If
    End Sub

    Private Sub TxtEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtEmail.TextChanged

    End Sub

    Private Sub TxtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEmail.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If TxtEmail.Text = "" Or TxtEmail.Text = "No Tiene" Or TxtEmail.Text = "NO TIENE" Or TxtEmail.Text = "No tiene" Then
                TxtFecha.Focus()
            Else
                Comprobar_Email()
            End If


        End If
    End Sub



    Private Sub TxtSexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtSexo.SelectedIndexChanged

    End Sub

    Private Sub TxtSexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSexo.KeyPress
        If Asc(e.KeyChar) = 13 Then

            BtnEnviar.Focus()

        End If
    End Sub

    Private Sub TxtFecha_ValueChanged(sender As Object, e As EventArgs) Handles TxtFecha.ValueChanged
        Dim FechaActual As DateTime = DateTime.Today
        Dim Edad As Integer = FechaActual.Year - TxtFecha.Value.Year

        If (FechaActual > TxtFecha.Value.AddYears(Edad)) Then
            Edad -= 1

            TxtEdad.Text = Edad



        End If

        TxtEdad.Text = Edad


    End Sub

    Sub Comprobar_Identidad()

        If Me.Text = "Registro de Pacientes" Or Me.Text = "Registro de Pacientes - Laboratorio" Then
            Dim Conexion As New CConexion
            Dim Sql As New DataSet

            Sql = Conexion.Consultar("SELECT * FROM Pacientes WHERE Identidad='" & TxtIdentidad.Text & "'")
            Try
                Dim Paciente As String = Sql.Tables(0).Rows(0).Item("Paciente")
                If Paciente <> "" Then
                    MsgBox("Identidad del Paciente ya Registrado", MsgBoxStyle.Exclamation, "Consultorio Letona")
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


        If Me.Text = "Editar Paciente" Or Me.Text = "Editar Paciente - Laboratorio" Then
            Dim Conexion As New CConexion
            Dim Sql As New DataSet

            Sql = Conexion.Consultar("SELECT * FROM Pacientes WHERE Identidad='" & TxtIdentidad.Text & "'")


            Try
                Dim Paciente As String = Sql.Tables(0).Rows(0).Item("Paciente")


                If Identidad = TxtIdentidad.Text Then
                    DuplicadoId = "ExcepcionId"

                Else
                    DuplicadoId = "Identidad"

                End If

                If DuplicadoId = "ExcepcionId" Then

                Else
                    MsgBox("Identidad del Paciente ya Registrado", MsgBoxStyle.Exclamation, "Consultorio Letona")

                End If

                TxtIdentidad.Text = Identidad
                TxtEmail.Focus()


            Catch ex As Exception

                TxtEmail.Focus()
                DuplicadoId = ""
            End Try

        End If

    End Sub


    Sub Comprobar_Email()
        If Me.Text = "Registro de Pacientes" Or Me.Text = "Registro de Pacientes - Laboratorio" Then
            Dim Conexion As New CConexion
            Dim Sql As New DataSet

            Sql = Conexion.Consultar("SELECT * FROM Pacientes WHERE Email='" & TxtEmail.Text & "'")
            Try
                Dim Paciente As String = Sql.Tables(0).Rows(0).Item("Email")
                If Paciente <> "" Or Paciente <> "No Tiene" Or Paciente <> "NO TIENE" Or Paciente <> "no tiene" Then
                    MsgBox("Correo Electronico del Paciente ya Registrado", MsgBoxStyle.Exclamation, "Consultorio Letona")
                    DuplicadoE = "Email"
                    TxtEmail.Clear()
                    TxtEmail.Focus()


                Else
                    TxtFecha.Focus()


                End If

            Catch ex As Exception
                TxtFecha.Focus()
                DuplicadoE = ""
            End Try

        End If


        If Me.Text = "Editar Paciente" Or Me.Text = "Editar Paciente - Laboratorio" Then
            Dim Conexion As New CConexion
            Dim Sql As New DataSet

            Sql = Conexion.Consultar("SELECT * FROM Pacientes WHERE Email='" & TxtEmail.Text & "'")


            Try
                Dim Paciente As String = Sql.Tables(0).Rows(0).Item("Paciente")


                If Email = TxtEmail.Text Then
                    DuplicadoE = "ExcepcionEmail"

                Else
                    DuplicadoE = "Email"

                End If

                If DuplicadoE = "ExcepcionEmail" Then


                Else
                    MsgBox("Correo Electronico del Paciente ya Registrado", MsgBoxStyle.Exclamation, "Consultorio Letona")
                End If

                TxtEmail.Text = Email
                TxtEmail.Focus()


            Catch ex As Exception

                TxtFecha.Focus()
                DuplicadoE = ""
            End Try

        End If

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click

        If TxtEdad.Text = "" Then
            TxtEdad.Text = Val(0)
        End If

        If TxtIdentidad.Text = "_____________" Or TxtPaciente.Text = "" Or TxtSexo.Text = "" Then

            If TxtPaciente.Text = "" Then
                TxtPaciente.BackColor = Color.Yellow
                TxtPaciente.Focus()
            End If

            If TxtIdentidad.Text = "_____________" Then
                TxtIdentidad.BackColor = Color.Yellow
                TxtIdentidad.Focus()
            End If

            If TxtSexo.Text = "" Then
                TxtSexo.BackColor = Color.Yellow
                TxtSexo.Focus()
            End If
            MsgBox("Llene los campos obligatorios de color amarillo", MsgBoxStyle.Exclamation, "Campos Vacios")
        Else

            If Me.Text = "Registro de Pacientes" Then


                Comprobar_Identidad()

                If TxtEmail.Text = "" Or TxtEmail.Text = "No Tiene" Or TxtEmail.Text = "NO TIENE" Or TxtEmail.Text = "No tiene" Then

                Else
                    Comprobar_Email()
                End If

                If DuplicadoId = "Identidad" Or DuplicadoId = "ExcepcionId" Or DuplicadoE = "Email" Or DuplicadoE = "ExcepcionEmail" Then

                    If DuplicadoId = "Identidad" Then
                        TxtIdentidad.Clear()
                        TxtIdentidad.Focus()
                    ElseIf DuplicadoE = "Email" Then
                        TxtEmail.Clear()
                        TxtEmail.Focus()
                    End If

                Else


                    Call Query.Insertar_Pacientes(TxtIdentidad.Text, TxtPaciente.Text, TxtSexo.Text, TxtFecha.Text, TxtEdad.Text, TxtEmail.Text)
                    MessageBox.Show("Los Datos fueron agregados con exito", "Datos Guardados...")



                    'If Me.Text = "Registro de Pacientes - Laboratorio" Then
                    '    F_Informes.Close()
                    '    F_Informes.Query.Buscar(F_Informes.DataGridView1, "")

                    '    Abrir_FormulariosHijos(New F_Informes)
                    '    Limpiar()
                    '    Me.Close()

                    'Else
                    '    F_Pacientes.Close()
                    '    F_Pacientes.Query.Buscar(F_Pacientes.DataGridView1, "")


                    '    Abrir_FormulariosHijos(New F_Pacientes)
                    '    Limpiar()
                    '    Me.Close()

                    'End If

                    F_Pacientes.Close()
                    F_Pacientes.Query.Buscar(F_Pacientes.DataGridView1, "")


                    Abrir_FormulariosHijos(New F_Pacientes)
                    Limpiar()
                    Me.Close()
                End If



            ElseIf Me.Text = "Editar Paciente" Then


                Comprobar_Identidad()
                Comprobar_Email()


                If DuplicadoId = "Identidad" Or DuplicadoId = "ExcepcionId" Then

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
                Call Query.Editar_Pacientes(LblId.Text, TxtIdentidad.Text, TxtPaciente.Text, TxtSexo.Text, TxtFecha.Text, TxtEdad.Text, TxtEmail.Text)
                MessageBox.Show("Los Datos fueron modificados con exito", "Datos Guardados...")


                If Me.Text = "Editar Paciente - Laboratorio" Then
                    F_Informes.Close()
                    F_Informes.Query.Buscar(F_Informes.DataGridView1, "")

                    Abrir_FormulariosHijos(New F_Informes)
                    Limpiar()
                    Me.Close()

                Else
                    F_Pacientes.Close()
                    F_Pacientes.Query.Buscar(F_Pacientes.DataGridView1, "")


                    Abrir_FormulariosHijos(New F_Pacientes)
                    Limpiar()
                    Me.Close()

                End If


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
End Class