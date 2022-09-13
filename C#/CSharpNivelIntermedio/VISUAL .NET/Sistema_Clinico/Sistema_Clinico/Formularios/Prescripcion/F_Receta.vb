Public Class F_Receta

    Dim WithEvents Queryconsultas As New DPrescripcion
    Dim ConexionLINQ As New DataClasses1DataContext()
    Dim Query

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        F_BuscarPaciente.Show()

    End Sub

    Private Sub TxtHistoria_TextChanged(sender As Object, e As EventArgs) Handles TxtHistoria.TextChanged

    End Sub

    Private Sub TxtHistoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHistoria.KeyPress
        If Asc(e.KeyChar) = 46 Then

            TxtMedicacion.Focus()

        End If
    End Sub

    Private Sub TxtMedicacion_TextChanged(sender As Object, e As EventArgs) Handles TxtMedicacion.TextChanged

    End Sub

    Private Sub TxtMedicacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMedicacion.KeyPress
        If Asc(e.KeyChar) = 46 Then

            TxtNota.Focus()

        End If
    End Sub

    Private Sub TxtNota_TextChanged(sender As Object, e As EventArgs) Handles TxtNota.TextChanged

    End Sub

    Private Sub TxtNota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNota.KeyPress
        If Asc(e.KeyChar) = 46 Then

            BtnEnviar.Focus()

        End If
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        If Me.Text = "Agregar Receta" Then

            Call Queryconsultas.Insertar_Receta(TxtPaciente.Text, TxtFecha.Text, TxtHistoria.Text, TxtMedicacion.Text, TxtNota.Text)
            MessageBox.Show("Los Datos fueron agregados con exito", "Datos Guardados...")



            'My.Settings.Ruta = "Agregar"
            'My.Settings.Save()
            'My.Settings.Reload()
            F_Prescripcion.Close()

            F_Prescripcion.Consulta()

            Abrir_FormulariosHijos(New F_Prescripcion)
              Limpiar()
            Me.Close()


        ElseIf Me.Text = "Editar Receta" Or Me.Text = "Editar Receta - Historial" Then

            Call Queryconsultas.Editar_Receta(LblId.Text, TxtPaciente.Text, TxtFecha.Text, TxtHistoria.Text, TxtMedicacion.Text, TxtNota.Text)
            MessageBox.Show("Los Datos fueron modificados con exito", "Datos Guardados...")


            If Me.Text = "Editar Receta" Then

                F_Prescripcion.Close()
                Limpiar()
                F_Prescripcion.Consulta()

                Abrir_FormulariosHijos(New F_Prescripcion)
                Me.Close()

            End If
            If Me.Text = "Editar Receta - Historial" Then


                F_Historial.Consulta()

                Limpiar()
                Me.Close()

            End If




        End If


    End Sub

    Private Sub F_Receta_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        If Me.Text = "Editar Receta - Historial" Then



            Dim ConexionRec As New CConexion
            Dim Sql As New DataSet

            Sql = ConexionRec.Consultar("SELECT * FROM Prescripcion WHERE Id='" & LblId.Text & "'")

            TxtPaciente.Text = Sql.Tables(0).Rows(0).Item("Paciente")
            TxtFecha.Text = Sql.Tables(0).Rows(0).Item("Fecha")
            TxtHistoria.Text = Sql.Tables(0).Rows(0).Item("Historia")
            TxtMedicacion.Text = Sql.Tables(0).Rows(0).Item("Medicacion")
            TxtNota.Text = Sql.Tables(0).Rows(0).Item("Nota")

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

    Sub Limpiar()
        TxtPaciente.Text = ""
        TxtHistoria.Clear()
        TxtMedicacion.Clear()
        TxtNota.Clear()
        LblOpcion.Text = ""

    End Sub

    Private Sub IconCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub F_Receta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Abrir_FormulariosHijos(New F_Prescripcion)
    End Sub
End Class