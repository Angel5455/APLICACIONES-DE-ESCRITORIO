Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class F_MocoFecal

    Dim Rruta As String = ""
    Dim rpt As New ReportDocument
    Dim prmdatos As ParameterField

    Public WithEvents Query As New DMoco
    Dim ConexionLINQ As New DataClasses1DataContext()
    'Dim Id As Integer
    Dim encontrado As Boolean
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
            If TxtConsistencia.Text = "" Then
                TxtConsistencia.Text = " "
            End If
            If TxtColor.Text = "" Then
                TxtColor.Text = " "
            End If
            If TxtMocos.Text = "" Then
                TxtMocos.Text = " "
            End If
            If TxtSangre.Text = "" Then
                TxtSangre.Text = " "
            End If
            If TxtPH.Text = "" Then
                TxtPH.Text = " "
            End If
            If txtFehling.Text = "" Then
                txtFehling.Text = " "
            End If
            If TxtGuayaco.Text = "" Then
                TxtGuayaco.Text = " "
            End If
            If TxtPMN.Text = "" Then
                TxtPMN.Text = " "
            End If
            If TxtMN.Text = "" Then
                TxtMN.Text = " "
            End If
            If TxtObservacion.Text = "- FLORA BACTERIANA:

- LEUCOCITOS:

- ERITROCITOS:

- LEVADURAS:

 OBSERVACION:" Then
                TxtObservacion.Text = "- FLORA BACTERIANA:

- LEUCOCITOS:

- ERITROCITOS:

- LEVADURAS:

 OBSERVACION:"
            End If

            Call Query.Guardar_Examen(TxtIdentidad.Text, TxtPaciente.Text, TxtEdad.Text, TxtSexo.Text, TxtReferencia.Text, TxtMuestra.Text, TxtFecha.Text, TxtAspecto.Text, TxtConsistencia.Text, TxtColor.Text, TxtMocos.Text, TxtSangre.Text, TxtPH.Text, TxtFehling.Text, TxtGuayaco.Text, TxtPMN.Text, TxtMN.Text, TxtObservacion.Text)
            MessageBox.Show("Los Datos fueron agregados con exito", "Datos Guardados...")

            Imprimir_Examen(TxtMuestra.Text)

            Limpiar()


        End If


    End Sub


    Private Sub TxtPaciente_TextChanged(sender As Object, e As EventArgs) Handles TxtPaciente.TextChanged

    End Sub

    Private Sub TxtPaciente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPaciente.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtEdad.Focus()

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

            TxtPaciente.Focus()

        End If
    End Sub

    Private Sub TxtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles TxtIdentidad.TextChanged

    End Sub


    Private Sub TxtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdentidad.KeyPress
        If Asc(e.KeyChar) = 13 Then


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

            TxtAspecto.Focus()

        End If
    End Sub

    Private Sub TxtPH_TextChanged(sender As Object, e As EventArgs)

    End Sub





    Private Sub TxtGuayaco_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub TxtPMN_TextChanged(sender As Object, e As EventArgs) Handles TxtPMN.TextChanged

    End Sub

    Private Sub TxtPMN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPMN.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtMN.Focus()

        End If
    End Sub

    Private Sub TxtMN_TextChanged(sender As Object, e As EventArgs) Handles TxtMN.TextChanged

    End Sub

    Private Sub TxtMN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMN.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtObservacion.Focus()

        End If
    End Sub

    Sub Limpiar()
        TxtPaciente.BackColor = Color.White
        TxtIdentidad.BackColor = Color.White
        TxtEdad.BackColor = Color.White
        TxtSexo.BackColor = Color.White


        TxtAspecto.Text = ""
        TxtConsistencia.Text = ""
        TxtColor.Text = ""
        TxtSangre.Text = ""
        TxtPH.Text = ""
        TxtMocos.Text = ""
        TxtFehling.Text = ""
        TxtGuayaco.Text = ""
        TxtPMN.Clear()
        TxtMN.Clear()
        TxtPaciente.Clear()
        TxtEdad.Clear()
        TxtSexo.Text = ""
        TxtIdentidad.Clear()




        TxtObservacion.Text = "- FLORA BACTERIANA:

- LEUCOCITOS:

- ERITROCITOS:

- LEVADURAS:

 OBSERVACION:"

        LblId.Text = Query.Id() + 1

        TxtMuestra.Text = LblId.Text

    End Sub

    Private Sub F_MocoFecal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblId.Text = Query.Id() + 1
        TxtMuestra.Text = LblId.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim resp As String

        resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


        If resp = 6 Then

            Rruta = "C:\SystemLetona\CrysCitologia.rpt"

            LlenarDsReporteExamen2(Rruta) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


        End If

    End Sub

    Private Sub LlenarDsReporteExamen2(ByVal strruta As String)
        Dim ID As String = TextBox1.Text
        Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
        Dim ta As New SystemLetonaDataSetTableAdapters.Citologia_Moco_FecalTableAdapter

        Try

            ta.FillById(mids.Citologia_Moco_Fecal, ID)

            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TxtAspecto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtAspecto.SelectedIndexChanged

    End Sub

    Private Sub TxtAspecto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAspecto.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtConsistencia.Focus()

        End If
    End Sub

    Private Sub TxtConsistencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtConsistencia.SelectedIndexChanged

    End Sub

    Private Sub TxtConsistencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtConsistencia.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtColor.Focus()

        End If
    End Sub

    Private Sub TxtColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtColor.SelectedIndexChanged

    End Sub

    Private Sub TxtColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtColor.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtMocos.Focus()

        End If
    End Sub

    Private Sub TxtMocos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtMocos.SelectedIndexChanged

    End Sub

    Private Sub TxtMocos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMocos.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtSangre.Focus()

        End If
    End Sub

    Private Sub TxtSangre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtSangre.SelectedIndexChanged

    End Sub

    Private Sub TxtSangre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSangre.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtPH.Focus()

        End If
    End Sub

    Private Sub TxtPH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtPH.SelectedIndexChanged

    End Sub

    Private Sub TxtPH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPH.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtFehling.Focus()

        End If
    End Sub

    Private Sub TxtFehling_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtFehling.SelectedIndexChanged

    End Sub

    Private Sub TxtFehling_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFehling.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtGuayaco.Focus()

        End If
    End Sub

    Private Sub TxtGuayaco_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtGuayaco.SelectedIndexChanged

    End Sub

    Private Sub TxtGuayaco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtGuayaco.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtPMN.Focus()

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Imprimir_Examen(TextBox1.Text)
    End Sub

    Sub Imprimir_Examen(ByVal Id As String)
        Dim resp As String

        resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


        If resp = 6 Then

            Rruta = "C:\SystemLetona\CrysCitologia.rpt"

            LlenarDsReporteExamen(Rruta, Id) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


        End If

    End Sub

    Private Sub LlenarDsReporteExamen(ByVal strruta As String, ByVal Ids As String)

        Dim Idd As String = Ids

        Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
        Dim ta As New SystemLetonaDataSetTableAdapters.Citologia_Moco_FecalTableAdapter
        Dim ta2 As New SystemLetonaDataSetTableAdapters.Citologia_Moco_FecalTableAdapter

        Try

            ta.FillById(mids.Citologia_Moco_Fecal, Idd)


            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class