
Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class F_AgregarHistorial

    Dim WithEvents Queryconsultas As New DHistorial
    Dim ConexionLINQ As New DataClasses1DataContext()
    Dim Query
    Dim Sexo As String = ""

    Dim encontrado As Boolean
    Public Codigo As String

    Dim resultado As MsgBoxResult

    Dim Genero = My.Settings.MySexo
    Private Sub TxtMotivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMotivo.KeyPress
        If Asc(e.KeyChar) = 46 Then

            TxtAPersonales.Focus()
            TabControl1.SelectedIndex = 1

        End If
    End Sub

    Private Sub TxtPaciente_TextChanged(sender As Object, e As EventArgs) Handles TxtPaciente.TextChanged

    End Sub

    Private Sub TxtPaciente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPaciente.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtFecha.Focus()

        End If
    End Sub

    Private Sub TxtFecha_ValueChanged(sender As Object, e As EventArgs) Handles TxtFecha.ValueChanged

    End Sub

    Private Sub TxtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFecha.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtEdad.Focus()


        End If
    End Sub

    Private Sub TxtEdad_TextChanged(sender As Object, e As EventArgs) Handles TxtEdad.TextChanged

    End Sub

    Private Sub TxtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdad.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtTelefono.Focus()

        End If

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs) Handles TxtTelefono.TextChanged

    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtMotivo.Focus()

        End If
    End Sub

    Private Sub TxtHEA_TextChanged(sender As Object, e As EventArgs) Handles TxtHEA.TextChanged

    End Sub

    Private Sub TxtHEA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHEA.KeyPress
        If Asc(e.KeyChar) = 46 Then

            TxtExamenFisico.Focus()
            TabControl1.SelectedIndex = 2

        End If
    End Sub

    Private Sub TxtAPersonales_TextChanged(sender As Object, e As EventArgs) Handles TxtAPersonales.TextChanged

    End Sub

    Private Sub TxtAPersonales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAPersonales.KeyPress
        If Asc(e.KeyChar) = 46 Then

            TxtAFamiliares.Focus()


        End If
    End Sub

    Private Sub TxtAFamiliares_TextChanged(sender As Object, e As EventArgs) Handles TxtAFamiliares.TextChanged

    End Sub

    Private Sub TxtAFamiliares_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAFamiliares.KeyPress
        If Asc(e.KeyChar) = 46 Then

            TxtHEA.Focus()


        End If
    End Sub



    Sub Limpiar()
        TxtPaciente.Clear()
        TxtMotivo.Clear()
        CheckF.Checked = False
        CheckM.Checked = False
        TxtAFamiliares.Clear()
        TxtAPersonales.Clear()
        TxtHEA.Clear()
        TxtExamenFisico.Clear()
        TxtEdad.Clear()
        TxtTelefono.Clear()
        TxtExamenC.Clear()
        TxtPA.Text = 0
        TxtFC.Text = 0
        TxtFR.Text = 0
        TxtT.Text = 0
        TxtPeso.Text = 0

    End Sub

    Private Sub CheckM_OnChange(sender As Object, e As EventArgs) Handles CheckM.OnChange
        If CheckM.Checked = True Then
            CheckF.Checked = False
            Sexo = "Masculino"
        End If
    End Sub

    Private Sub CheckF_OnChange(sender As Object, e As EventArgs) Handles CheckF.OnChange
        If CheckF.Checked = True Then
            CheckM.Checked = False
            Sexo = "Femenino"
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

    Private Sub F_AgregarHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If LblOpcion.Text = "Editar Historial" Then

            TxtPaciente.Enabled = False
            TxtEdad.Enabled = False
            TxtIdentidad.Enabled = False
            TxtTelefono.Enabled = False
            CheckF.Enabled = False
            CheckM.Enabled = False

            Dim Conexion As New CConexion
            Dim Sql As New DataSet
            LblCodigo.Text = Codigo
            Sql = Conexion.Consultar("SELECT * FROM HISTORIAL WHERE Codigo_Historial='" & LblCodigo.Text & "'")



            LblId.Text = Sql.Tables(0).Rows(0).Item("Id")
            TxtIdentidad.Text = Sql.Tables(0).Rows(0).Item("Identidad")
            TxtPaciente.Text = Sql.Tables(0).Rows(0).Item("Paciente")

            Genero = Sql.Tables(0).Rows(0).Item("Sexo")

            If Genero = "Masculino" Then
                CheckM.Checked = True
                CheckF.Checked = False
            ElseIf Genero = "Femenino" Then
                CheckM.Checked = False
                CheckF.Checked = True
            End If

            TxtEdad.Text = Sql.Tables(0).Rows(0).Item("Edad")
            TxtTelefono.Text = Sql.Tables(0).Rows(0).Item("Telefono")
            TxtMotivo.Text = Sql.Tables(0).Rows(0).Item("Motivo_Consulta")
            TxtFecha.Text = Sql.Tables(0).Rows(0).Item("Fecha")
            TxtAPersonales.Text = Sql.Tables(0).Rows(0).Item("Antecedentes_Personales")
            TxtAFamiliares.Text = Sql.Tables(0).Rows(0).Item("Antecedentes_Familiares")
            TxtHEA.Text = Sql.Tables(0).Rows(0).Item("HEA")
            TxtExamenFisico.Text = Sql.Tables(0).Rows(0).Item("Examen_Fisico")
            TxtExamenC.Text = Sql.Tables(0).Rows(0).Item("Examenes_Complementarios")
            TxtPA.Text = Sql.Tables(0).Rows(0).Item("PA")
            TxtFC.Text = Sql.Tables(0).Rows(0).Item("FC")
            TxtFR.Text = Sql.Tables(0).Rows(0).Item("FR")
            TxtT.Text = Sql.Tables(0).Rows(0).Item("T")
            TxtPeso.Text = Sql.Tables(0).Rows(0).Item("Peso")
            TxtDiagnostico.Text = Sql.Tables(0).Rows(0).Item("Diagnostico")
            TxtTratamiento.Text = Sql.Tables(0).Rows(0).Item("Tratamiento")



        Else



            TxtPA.Text = 0
            TxtFC.Text = 0
            TxtFR.Text = 0
            TxtT.Text = 0
            TxtPeso.Text = 0

            TxtIdentidad.Text = My.Settings.MyIdentidad
            TxtTelefono.Text = My.Settings.MyTelefono

            TxtEdad.Text = My.Settings.MyEdad



            If Genero = "Masculino" Then
                CheckM.Checked = True
                CheckF.Checked = False
            ElseIf Genero = "Femenino" Then
                CheckM.Checked = False
                CheckF.Checked = True
            End If

            GenerarCodigo()



        End If






    End Sub

    Sub GenerarCodigo()



        Dim constr As String

        constr = Conexion.Cadena



        Dim con As New SqlConnection(constr)

        Dim tabla As New DataTable

        Dim daSql As New SqlDataAdapter("Select * from Historial Where Identidad Like'" & TxtIdentidad.Text & "'", con)





        daSql.Fill(tabla)


            DataGridView1.DataSource = tabla


            Dim fila As Integer
            fila = DataGridView1.RowCount

            Dim var As String = TxtIdentidad.Text
            Dim tam_var As Integer = var.Length
            Dim Var_Sub As String = var.Substring((tam_var - 5), 5)
            Dim Result As String
            Result = "H" + Var_Sub + "-" & fila

            LblCodigo.Text = Result




    End Sub

    Private Sub TxtIdentidad_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtExamenFisico_TextChanged(sender As Object, e As EventArgs) Handles TxtExamenFisico.TextChanged

    End Sub

    Private Sub TxtExamenFisico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtExamenFisico.KeyPress
        If Asc(e.KeyChar) = 46 Then

            TxtExamenC.Focus()


        End If
    End Sub


    Private Sub TxtExamenC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtExamenC.KeyPress
        If Asc(e.KeyChar) = 46 Then

            TxtPA.Focus()


        End If
    End Sub

    Private Sub TxtPA_TextChanged(sender As Object, e As EventArgs) Handles TxtPA.TextChanged

    End Sub

    Private Sub TxtPA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPA.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtFC.Focus()


        End If
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub TxtFC_TextChanged(sender As Object, e As EventArgs) Handles TxtFC.TextChanged

    End Sub

    Private Sub TxtFC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFC.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtFR.Focus()


        End If
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub TxtFR_TextChanged(sender As Object, e As EventArgs) Handles TxtFR.TextChanged

    End Sub

    Private Sub TxtFR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFR.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtT.Focus()


        End If
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub TxtT_TextChanged(sender As Object, e As EventArgs) Handles TxtT.TextChanged

    End Sub

    Private Sub TxtT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtT.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtPeso.Focus()


        End If
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub TxtPeso_TextChanged(sender As Object, e As EventArgs) Handles TxtPeso.TextChanged

    End Sub

    Private Sub TxtPeso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPeso.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtDiagnostico.Focus()
            TabControl1.SelectedIndex = 3

        End If
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub TxtDiagnostico_TextChanged(sender As Object, e As EventArgs) Handles TxtDiagnostico.TextChanged

    End Sub

    Private Sub TxtDiagnostico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDiagnostico.KeyPress
        If Asc(e.KeyChar) = 46 Then

            TxtTratamiento.Focus()

        End If
    End Sub

    Private Sub TxtTratamiento_TextChanged(sender As Object, e As EventArgs) Handles TxtTratamiento.TextChanged

    End Sub

    Private Sub TxtTratamiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTratamiento.KeyPress
        If Asc(e.KeyChar) = 46 Then

            BtnEnviar.Focus()

        End If
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click

        If LblOpcion.Text = "Editar Historial" Then

            If CheckF.Checked = True Then
                Genero = "Femenino"
            Else
                Genero = "Masculino"
            End If


            Call Queryconsultas.Editar_Historial(LblId.Text, LblCodigo.Text, TxtIdentidad.Text, TxtPaciente.Text, Genero, TxtEdad.Text, TxtTelefono.Text, TxtMotivo.Text, TxtFecha.Text, TxtAPersonales.Text, TxtAFamiliares.Text, TxtHEA.Text, TxtExamenFisico.Text, TxtExamenC.Text, TxtPA.Text, TxtFC.Text, TxtFR.Text, TxtT.Text, TxtPeso.Text, TxtDiagnostico.Text, TxtTratamiento.Text)
            MessageBox.Show("Los Datos fueron modificados con exito", "Datos Guardados...")

            If My.Settings.Ruta = "HistorialCasos" Then
                My.Settings.Ruta = "EditarH"
                My.Settings.Save()
                My.Settings.Reload()



                LblOpcion.Text = ""
                Genero = ""

                F_Historial_Casos.Close()

                Limpiar()


                F_Historial_Casos.Consulta()
                Abrir_FormulariosHijos(New F_Historial_Casos)
                Me.Close()

            Else

                My.Settings.Ruta = "EditarH"
                My.Settings.Save()
                My.Settings.Reload()


                Limpiar()


                LblOpcion.Text = ""
                Genero = ""


                F_Historial.Consulta()


                Me.Close()

            End If






        Else
            If TxtEdad.Text = "" Then
                TxtEdad.Text = 0
            End If

            If TxtIdentidad.Text = "" Or TxtPaciente.Text = "" Or TxtMotivo.Text = "" Or TxtTratamiento.Text = "" Or TxtDiagnostico.Text = "" Then

                If TxtExamenFisico.Text = "" Then
                    TxtExamenFisico.Text = "Ninguno"
                End If
                If TxtExamenC.Text = "" Then
                    TxtExamenC.Text = "Ninguno"
                End If
                If TxtHEA.Text = "" Then
                    TxtHEA.Text = "Ninguno"
                End If

                If TxtAFamiliares.Text = "" Then
                    TxtAFamiliares.Text = "Ninguno"
                End If

                If TxtAPersonales.Text = "" Then
                    TxtAPersonales.Text = "Ninguno"
                End If


                If TxtPaciente.Text = "" Then
                    TxtPaciente.BackColor = Color.Yellow
                    TxtPaciente.Focus()
                End If

                If TxtMotivo.Text = "" Then
                    TxtMotivo.BackColor = Color.Yellow
                    TxtMotivo.Focus()
                End If

                If TxtTratamiento.Text = "" Then
                    TxtTratamiento.BackColor = Color.Yellow
                    TxtTratamiento.Focus()
                End If

                If TxtDiagnostico.Text = "" Then
                    TxtDiagnostico.BackColor = Color.Yellow
                    TxtDiagnostico.Focus()
                End If

                MsgBox("Llene los campos obligatorios de color amarillo", MsgBoxStyle.Exclamation, "Campos Vacios")
            Else



                Call Queryconsultas.Insertar_Historial(LblCodigo.Text, TxtIdentidad.Text, TxtPaciente.Text, Genero, TxtEdad.Text, TxtTelefono.Text, TxtMotivo.Text, TxtFecha.Text, TxtAPersonales.Text, TxtAFamiliares.Text, TxtHEA.Text, TxtExamenFisico.Text, TxtExamenC.Text, TxtPA.Text, TxtFC.Text, TxtFR.Text, TxtT.Text, TxtPeso.Text, TxtDiagnostico.Text, TxtTratamiento.Text)
                MessageBox.Show("Los Datos fueron agregados con exito", "Datos Guardados...")



                My.Settings.Ruta = "AgregarH"

                My.Settings.Save()
                My.Settings.Reload()
                'F_Pacientes.Query.Buscar(F_Pacientes.DataGridView1, "")
                F_Historial.Consulta()
                Limpiar()

                Me.Close()




            End If



        End If





    End Sub

    Private Sub TxtIdentidad_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TxtIdentidad.MaskInputRejected

    End Sub

    Private Sub TxtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdentidad.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtEdad.Focus()

        End If
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub F_AgregarHistorial_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If My.Settings.Ruta = "HistorialCasos" Then
            Abrir_FormulariosHijos(New F_Historial_Casos)

        Else

            F_Historial.Show()


        End If


        'My.Settings.MySexo = ""
        'My.Settings.MyTelefono = ""
        'My.Settings.MyEdad = ""
        'My.Settings.MyPaciente = ""
        'My.Settings.Ruta = ""
        'My.Settings.Save()
        'My.Settings.Reload()
        'LblOpcion.Text = ""
        'Genero = ""


    End Sub

    Private Sub TxtMotivo_TextChanged(sender As Object, e As EventArgs) Handles TxtMotivo.TextChanged

    End Sub
End Class