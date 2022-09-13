Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class F_Orina
    Dim Rruta As String = ""
    Dim rpt As New ReportDocument
    Dim prmdatos As ParameterField
    Dim ID As String
    Public WithEvents Query As New DOrina
    Dim ConexionLINQ As New DataClasses1DataContext()

    Private Sub PanelTitulo_Paint(sender As Object, e As PaintEventArgs) Handles PanelTitulo.Paint

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click

        If TxtPaciente.Text = "" Or TxtEdad.Text = "" Or TxtSexo.Text = "" Or TxtMuestra.Text = "" Then
            If TxtPaciente.Text = "" Then
                TxtPaciente.BackColor = Color.Yellow
                TxtPaciente.Focus()
            End If
            If TxtEdad.Text = "" Then
                TxtEdad.BackColor = Color.Yellow
                TxtEdad.Focus()
            End If
            If TxtSexo.Text = "" Then
                TxtSexo.BackColor = Color.Yellow
                TxtSexo.Focus()
            End If
            If TxtMuestra.Text = "" Then
                TxtMuestra.BackColor = Color.Yellow
                TxtMuestra.Focus()
            End If
            MsgBox("Llene los campos obligatorios de color amarillo", MsgBoxStyle.Exclamation, "Campos Vacios")
        Else

            If TxtAspecto.Text = "" Then
                TxtAspecto.Text = ""
            End If
            If TxtVolumen.Text = "" Then
                TxtVolumen.Text = " "
            End If
            If TxtColor.Text = "" Then
                TxtColor.Text = " "
            End If
            If TxtOlor.Text = "" Then
                TxtOlor.Text = " "
            End If
            If TxtLeucocitosQ.Text = "" Then
                TxtLeucocitosQ.Text = " "
            End If
            If TxtCetonas.Text = "" Then
                TxtCetonas.Text = " "
            End If
            If TxtNitritos.Text = "" Then
                TxtNitritos.Text = " "
            End If
            If TxtUro.Text = "" Then
                TxtUro.Text = " "
            End If
            If TxtBilirrubina.Text = "" Then
                TxtBilirrubina.Text = " "
            End If
            If TxtProteinas.Text = "" Then
                TxtProteinas.Text = " "
            End If
            If TxtGlucosa.Text = "" Then
                TxtGlucosa.Text = " "
            End If
            If TxtDensidad.Text = "" Then
                TxtDensidad.Text = " "
            End If

            If TxtPH.Text = "" Then
                TxtPH.Text = " "
            End If
            If TxtEritrocitosQ.Text = "" Then
                TxtEritrocitosQ.Text = " "
            End If
            If TxtLeucocitosM.Text = "" Then
                TxtLeucocitosM.Text = " "
            End If
            If TxtEritrocitosM.Text = "" Then
                TxtEritrocitosM.Text = " "
            End If
            If TxtEpi.Text = "" Then
                TxtEpi.Text = " "
            End If
            If TxtBacterias.Text = "" Then
                TxtBacterias.Text = " "
            End If
            If TxtMocos.Text = "" Then
                TxtMocos.Text = " "
            End If
            If TxtCristales.Text = "" Then
                TxtCristales.Text = " "
            End If
            If TxtCilindros.Text = "" Then
                TxtCilindros.Text = " "
            End If

            If TxtLevaduras.Text = "" Then
                TxtLevaduras.Text = " "
            End If

            If TxtSedimento.Text = "" Then
                TxtSedimento.Text = " "
            End If

            Call Query.Guardar_Examen(TxtIdentidad.Text, TxtPaciente.Text, TxtEdad.Text, TxtSexo.Text, TxtReferencia.Text, TxtMuestra.Text, TxtFecha.Text, TxtVolumen.Text, TxtColor.Text, TxtAspecto.Text, TxtOlor.Text, TxtSedimento.Text, TxtLeucocitosQ.Text, TxtCetonas.Text, TxtNitritos.Text, TxtUro.Text, TxtBilirrubina.Text, TxtProteinas.Text, TxtGlucosa.Text, TxtDensidad.Text, TxtPH.Text, TxtEritrocitosQ.Text, TxtLeucocitosM.Text, TxtEritrocitosM.Text, TxtEpi.Text, TxtBacterias.Text, TxtMocos.Text, TxtCristales.Text, TxtCilindros.Text, TxtLevaduras.Text, TxtNota.Text)
            MessageBox.Show("Los Datos fueron agregados con exito", "Datos Guardados...")

            Imprimir_Examen(LblId.Text)

            Limpiar()

        End If

    End Sub


    Private Sub TxtPaciente_TextChanged(sender As Object, e As EventArgs) Handles TxtPaciente.TextChanged

    End Sub

    Private Sub TxtPaciente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPaciente.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtMuestra.Focus()

        End If
    End Sub

    Private Sub TxtEdad_TextChanged(sender As Object, e As EventArgs) Handles TxtEdad.TextChanged

    End Sub

    Private Sub TxtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdad.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtSexo.Focus()

        End If

        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub TxtSexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtSexo.SelectedIndexChanged

    End Sub

    Private Sub TxtSexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSexo.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtIdentidad.Focus()

        End If
    End Sub

    Private Sub TxtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles TxtIdentidad.TextChanged

    End Sub


    Private Sub TxtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdentidad.KeyPress
        If Asc(e.KeyChar) = 13 Then

            Dim encontrado As Boolean
            Dim xConsulta As New SqlDataAdapter("select * from Pacientes where Identidad = '" & TxtIdentidad.Text & "'", Conexion.Conexion)
            Dim ds As New DataSet
            xConsulta.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then

                'txtDescripcion.BackColor = Color.White

                encontrado = True

                TxtPaciente.Text = ds.Tables(0).Rows(0).Item("Paciente").ToString
                TxtSexo.Text = ds.Tables(0).Rows(0).Item("Sexo").ToString
                TxtEdad.Text = ds.Tables(0).Rows(0).Item("Edad").ToString

                TxtFecha.Focus()


            Else

                encontrado = False


                MsgBox("Paciente sin Registrar", MsgBoxStyle.Critical, "Error")
                TxtPaciente.Text = ""
                TxtSexo.Text = ""
                TxtEdad.Text = ""

                TxtEdad.Focus()
            End If



        End If
    End Sub

    Private Sub TxtMuestra_TextChanged(sender As Object, e As EventArgs) Handles TxtMuestra.TextChanged

    End Sub

    Private Sub TxtMuestra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMuestra.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtFecha.Focus()

        End If
    End Sub

    Private Sub TxtFecha_ValueChanged(sender As Object, e As EventArgs) Handles TxtFecha.ValueChanged

    End Sub

    Private Sub TxtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFecha.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtVolumen.Focus()

        End If
    End Sub



    Sub Limpiar()
        TxtPaciente.BackColor = Color.White
        TxtIdentidad.BackColor = Color.White
        TxtEdad.BackColor = Color.White
        TxtSexo.BackColor = Color.White
        TxtMuestra.BackColor = Color.White
        TxtAspecto.Text = ""
        TxtVolumen.Clear()
        TxtColor.Text = ""
        TxtOlor.Text = ""
        TxtPH.Text = ""
        TxtBacterias.Text = ""
        TxtEpi.Text = ""
        TxtMocos.Text = ""
        TxtLevaduras.Text = ""
        TxtDensidad.Text = ""
        TxtLeucocitosQ.Text = ""
        TxtCetonas.Text = ""
        TxtNitritos.Text = ""
        TxtUro.Text = ""
        TxtPaciente.Clear()
        TxtEdad.Clear()
        TxtSexo.Text = ""
        TxtIdentidad.Clear()
        TxtReferencia.Text = ""
        TxtSedimento.Text = ""


        LblId.Text = Query.Id() + 1
        TxtMuestra.Text = LblId.Text

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Imprimir_Examen(TextBox1.Text)
    End Sub


    Private Sub TxtVolumen_TextChanged(sender As Object, e As EventArgs) Handles TxtVolumen.TextChanged

    End Sub

    Private Sub TxtVolumen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtVolumen.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtColor.Focus()

        End If

    End Sub


    Private Sub TxtCristales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCristales.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtCilindros.Focus()

        End If

    End Sub

    Private Sub TxtCilindros_TextChanged(sender As Object, e As EventArgs) Handles TxtCilindros.TextChanged

    End Sub

    Private Sub TxtCilindros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCilindros.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtLevaduras.Focus()

        End If

    End Sub

    Sub Imprimir_Examen(ByVal Id As String)
        Dim resp As String

        resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


        If resp = 6 Then

            Rruta = "C:\SystemLetona\CrysOrina.rpt"

            LlenarDsReporteExamen(Rruta, Id) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


        End If
    End Sub

    Private Sub LlenarDsReporteExamen(ByVal strruta As String, ByVal Ids As String)

        ID = Ids

        Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
        Dim ta As New SystemLetonaDataSetTableAdapters.OrinaTableAdapter


        Try

            ta.FillByMuestra(mids.Orina, ID)


            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TxtNota_TextChanged(sender As Object, e As EventArgs) Handles TxtNota.TextChanged

    End Sub

    Private Sub TxtNota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNota.KeyPress
        If Asc(e.KeyChar) = 13 Then

            BtnEnviar.Focus()

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Imprimir_Examen(TextBox1.Text)
    End Sub

    Private Sub F_Orina_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()

    End Sub

    Private Sub F_Orina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblId.Text = Query.Id() + 1
        TxtMuestra.Text = LblId.Text
    End Sub

    Private Sub TxtColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtColor.SelectedIndexChanged

    End Sub

    Private Sub TxtColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtColor.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtAspecto.Focus()

        End If
    End Sub

    Private Sub TxtGlucosa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtGlucosa.SelectedIndexChanged

    End Sub

    Private Sub TxtGlucosa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtGlucosa.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtDensidad.Focus()

        End If

    End Sub

    Private Sub TxtProteinas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtProteinas.SelectedIndexChanged

    End Sub

    Private Sub TxtProteinas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtProteinas.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtGlucosa.Focus()

        End If

    End Sub

    Private Sub TxtBilirrubina_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtBilirrubina.SelectedIndexChanged

    End Sub

    Private Sub TxtBilirrubina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBilirrubina.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtProteinas.Focus()

        End If

    End Sub

    Private Sub TxtUro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtUro.SelectedIndexChanged

    End Sub

    Private Sub TxtUro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUro.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtBilirrubina.Focus()

        End If
    End Sub

    Private Sub TxtNitritos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtNitritos.SelectedIndexChanged

    End Sub

    Private Sub TxtNitritos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNitritos.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtUro.Focus()

        End If
    End Sub

    Private Sub TxtCetonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtCetonas.SelectedIndexChanged

    End Sub

    Private Sub TxtCetonas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCetonas.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtNitritos.Focus()

        End If
    End Sub

    Private Sub TxtLeucocitosQ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtLeucocitosQ.SelectedIndexChanged

    End Sub

    Private Sub TxtLeucocitosQ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLeucocitosQ.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtCetonas.Focus()

        End If
    End Sub

    Private Sub TxtSedimento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtSedimento.SelectedIndexChanged

    End Sub

    Private Sub TxtSedimento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSedimento.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtLeucocitosQ.Focus()

        End If
    End Sub

    Private Sub TxtOlor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtOlor.SelectedIndexChanged

    End Sub

    Private Sub TxtOlor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOlor.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtSedimento.Focus()

        End If
    End Sub

    Private Sub TxtAspecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtAspecto.SelectedIndexChanged

    End Sub

    Private Sub TxtAspecto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAspecto.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtOlor.Focus()

        End If
    End Sub

    Private Sub TxtLeucocitosM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtLeucocitosM.SelectedIndexChanged

    End Sub

    Private Sub TxtLeucocitosM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLeucocitosM.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtEritrocitosM.Focus()

        End If
    End Sub

    Private Sub TxtDensidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtDensidad.SelectedIndexChanged

    End Sub

    Private Sub TxtDensidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDensidad.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtPH.Focus()

        End If
    End Sub

    Private Sub TxtPH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtPH.SelectedIndexChanged

    End Sub

    Private Sub TxtPH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPH.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtEritrocitosQ.Focus()

        End If

    End Sub

    Private Sub TxtLevaduras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtLevaduras.SelectedIndexChanged

    End Sub

    Private Sub TxtLevaduras_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLevaduras.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtNota.Focus()

        End If
    End Sub

    Private Sub TxtMocos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtMocos.SelectedIndexChanged

    End Sub

    Private Sub TxtMocos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMocos.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtCristales.Focus()

        End If
    End Sub

    Private Sub TxtBacterias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtBacterias.SelectedIndexChanged

    End Sub

    Private Sub TxtBacterias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBacterias.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtMocos.Focus()

        End If
    End Sub

    Private Sub TxtEpi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtEpi.SelectedIndexChanged

    End Sub

    Private Sub TxtEpi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEpi.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtBacterias.Focus()

        End If
    End Sub

    Private Sub TxtEritrocitosQ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtEritrocitosQ.SelectedIndexChanged

    End Sub

    Private Sub TxtEritrocitosQ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEritrocitosQ.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtLeucocitosM.Focus()

        End If
    End Sub

    Private Sub TxtEritrocitosM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtEritrocitosM.SelectedIndexChanged

    End Sub

    Private Sub TxtEritrocitosM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEritrocitosM.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtEpi.Focus()

        End If
    End Sub
End Class