Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class F_Hematologia

    Dim Rruta As String = ""
    Dim rpt As New ReportDocument
    Dim prmdatos As ParameterField

    Public WithEvents Query As New DHematologia
    Dim ConexionLINQ As New DataClasses1DataContext()
    Dim Id As Integer
    Private Sub F_Hematologia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblId.Text = Query.Id() + 1
        TxtMuestra.Text = LblId.Text


    End Sub


    Sub Limpiar()

        TxtPaciente.BackColor = Color.White
        TxtIdentidad.BackColor = Color.White
        TxtEdad.BackColor = Color.White
        TxtSexo.BackColor = Color.White
        TxtMuestra.BackColor = Color.White

        TxtPaciente.Clear()
        TxtEdad.Clear()
        TxtSexo.Text = ""
        TxtIdentidad.Clear()
        TxtMuestra.Clear()
        TxtVes.Clear()
        TxtHematocrito.Clear()
        TxtHemoglobina.Clear()
        TxtProto.Clear()
        TxtTrombo.Clear()
        TxtCoagulacion.Clear()
        TxtRetraccion.Clear()
        TxtSangradoD.Clear()
        TxtSangradoI.Clear()
        TxtRRN.Clear()
        TxtRA.Clear()
        TxtINR.Clear()
        TxtTipo.Clear()
        TxtReferencia.Text = ""
        LblId.Text = Query.Id() + 1
        TxtMuestra.Text = LblId.Text


        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.Rows.Clear()


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

    Private Sub TxtPaciente_TextChanged(sender As Object, e As EventArgs) Handles TxtPaciente.TextChanged

    End Sub

    Private Sub TxtPaciente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPaciente.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtMuestra.Focus()

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
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtFecha.Focus()

        End If
    End Sub

    Private Sub TxtFecha_ValueChanged(sender As Object, e As EventArgs) Handles TxtFecha.ValueChanged

    End Sub

    Private Sub TxtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFecha.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtVes.Focus()

        End If
    End Sub

    Private Sub TxtTipo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTipo.KeyPress
        If Asc(e.KeyChar) = 13 Then

            BtnEnviar.Focus()

        End If
    End Sub

    Private Sub TxtVes_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtVes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtVes.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtHematocrito.Focus()

        End If
    End Sub

    Private Sub TxtHematocrito_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub TxtHematocrito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHematocrito.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtHemoglobina.Focus()

        End If
    End Sub

    Private Sub TxtHemoglobina_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtHemoglobina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHemoglobina.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtProto.Focus()

        End If
    End Sub

    Private Sub TxtProto_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtProto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtProto.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtTrombo.Focus()

        End If
    End Sub

    Private Sub TxtTrombo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtTrombo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTrombo.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtCoagulacion.Focus()

        End If
    End Sub

    Private Sub TxtCoagulacion_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtCoagulacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCoagulacion.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtRetraccion.Focus()

        End If
    End Sub

    Private Sub TxtRetraccion_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtRetraccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRetraccion.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtSangradoD.Focus()

        End If
    End Sub

    Private Sub TxtSangradoD_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtSangradoD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSangradoD.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtSangradoI.Focus()

        End If
    End Sub

    Private Sub TxtSangradoI_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtSangradoI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSangradoI.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtRRN.Focus()

        End If
    End Sub

    Private Sub TxtRRN_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtRRN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRRN.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtRA.Focus()

        End If
    End Sub

    Private Sub TxtRA_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtRA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRA.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtINR.Focus()

        End If
    End Sub

    Private Sub TxtINR_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub TxtINR_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtINR.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtTipo.Focus()

        End If
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

            If TxtVes.Text = "" Then
                TxtVes.Text = " "
            End If
            If TxtHematocrito.Text = "" Then
                TxtHematocrito.Text = " "
            End If
            If TxtHemoglobina.Text = "" Then
                TxtHemoglobina.Text = " "
            End If
            If TxtProto.Text = "" Then
                TxtProto.Text = " "
            End If
            If TxtProto.Text = "" Then
                TxtProto.Text = " "
            End If
            If TxtTrombo.Text = "" Then
                TxtTrombo.Text = " "
            End If
            If TxtCoagulacion.Text = "" Then
                TxtCoagulacion.Text = " "
            End If
            If TxtRetraccion.Text = "" Then
                TxtRetraccion.Text = " "
            End If
            If TxtSangradoD.Text = "" Then
                TxtSangradoD.Text = " "
            End If
            If TxtSangradoI.Text = "" Then
                TxtSangradoI.Text = " "
            End If
            If TxtRRN.Text = "" Then
                TxtRRN.Text = " "
            End If
            If TxtINR.Text = "" Then
                TxtINR.Text = " "
            End If
            If TxtTipo.Text = "" Then
                TxtTipo.Text = " "
            End If

            If TxtVes.Text <> " " Then
                Call ButtonVes_Click(sender, e)
            End If
            If TxtHematocrito.Text <> " " Then
                Call ButtonHema_Click(sender, e)
            End If
            If TxtHemoglobina.Text <> " " Then
                Call ButtonHemo_Click(sender, e)
            End If
            If TxtProto.Text <> " " Then
                Call ButtonProtom_Click(sender, e)
            End If
            If TxtTrombo.Text <> " " Then
                Call ButtonTrombo_Click(sender, e)
            End If
            If TxtCoagulacion.Text <> " " Then
                Call ButtonTCoa_Click(sender, e)
            End If
            If TxtRetraccion.Text <> " " Then
                Call ButtonRCoa_Click(sender, e)
            End If
            If TxtSangradoD.Text <> " " Then
                Call ButtonSDuke_Click(sender, e)
            End If
            If TxtSangradoI.Text <> " " Then
                Call ButtonSIvi_Click(sender, e)
            End If




            For i As Integer = 0 To DataGridView1.Rows.Count - 2

                Me.HematologiaTableAdapter.InsertQueryHematologia(TxtMuestra.Text, TxtIdentidad.Text, TxtPaciente.Text, TxtEdad.Text, TxtSexo.Text, TxtReferencia.Text, TxtFecha.Text, ((DataGridView1.Rows(i).Cells(1).Value)), ((DataGridView1.Rows(i).Cells(2).Value)), ((DataGridView1.Rows(i).Cells(3).Value)))
                ' MsgBox(DatagridView1.Rows(i).Cells(0).Value & " detalle factura guardado")
                'txtMuestra.Text = Query.Id() + 1
            Next

            MessageBox.Show("Los Datos fueron agregados con exito", "Datos Guardados...")


            Imprimir_Examen(LblId.Text)


            Limpiar()



        End If


    End Sub

    Sub Imprimir_Examen(ByVal Id As String)
        Dim resp As String

        resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


        If resp = 6 Then

            Rruta = "C:\SystemLetona\CrysHema.rpt"

            LlenarDsReporteExamen(Rruta, Id) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


        End If
    End Sub

    Private Sub LlenarDsReporteExamen(ByVal strruta As String, ByVal Ids As String)

        Id = Ids

        Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
        Dim ta As New SystemLetonaDataSetTableAdapters.HematologiaTableAdapter
        Dim ta2 As New SystemLetonaDataSetTableAdapters.HematologiaTableAdapter

        Try

            ta.FillByMuestra(mids.Hematologia, Id)


            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Imprimir_Examen(TextBox1.Text)
    End Sub

    Private Sub Panel1Hora_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        O_Hematologia.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Imprimir_Examen(TextBox1.Text)
    End Sub

    Private Sub ButtonVes_Click(sender As Object, e As EventArgs) Handles ButtonVes.Click
        If TxtVes.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelVes.Text, TxtVes.Text & " " & LblRVes.Text, LblVVes.Text)
        End If
    End Sub

    Private Sub LabelHema_Click(sender As Object, e As EventArgs) Handles LabelHema.Click
        LblVHema.Text = InputBox("Ingrese el nuevo Valor de Referencia")
    End Sub

    Private Sub ButtonHema_Click(sender As Object, e As EventArgs) Handles ButtonHema.Click
        If TxtHematocrito.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelHema.Text, TxtHematocrito.Text & " " & LblRHema.Text, LblVHema.Text)
        End If
    End Sub

    Private Sub ButtonHemo_Click(sender As Object, e As EventArgs) Handles ButtonHemo.Click
        If TxtHemoglobina.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelHemo.Text, TxtHemoglobina.Text & " " & LblRHemo.Text, LblVHemo.Text)
        End If
    End Sub

    Private Sub ButtonProtom_Click(sender As Object, e As EventArgs) Handles ButtonProtom.Click
        If TxtProto.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelProtom.Text, TxtProto.Text & " " & LblRProtom.Text, LblVProtom.Text)
        End If
    End Sub

    Private Sub ButtonTrombo_Click(sender As Object, e As EventArgs) Handles ButtonTrombo.Click
        If TxtTrombo.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelTrombo.Text, TxtTrombo.Text & " " & LblRTrombo.Text, LblVTrombo.Text)
        End If
    End Sub

    Private Sub ButtonTCoa_Click(sender As Object, e As EventArgs) Handles ButtonTCoa.Click
        If TxtCoagulacion.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelTCoa.Text, TxtCoagulacion.Text & " " & LblRTCoa.Text, LblVTCoa.Text)
        End If
    End Sub

    Private Sub ButtonRCoa_Click(sender As Object, e As EventArgs) Handles ButtonRCoa.Click
        If TxtRetraccion.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelRCoa.Text, TxtRetraccion.Text & " " & LblRRCoa.Text, LblVRCoa.Text)
        End If
    End Sub

    Private Sub ButtonSDuke_Click(sender As Object, e As EventArgs) Handles ButtonSDuke.Click
        If TxtSangradoD.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelSDuke.Text, TxtSangradoD.Text & " " & LblRSDuke.Text, LblVSDuke.Text)
        End If
    End Sub

    Private Sub ButtonRN_Click(sender As Object, e As EventArgs) Handles ButtonRN.Click
        If TxtRRN.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelRRN.Text, TxtRRN.Text & " " & LblRRR.Text, LblVRRN.Text)
        End If
    End Sub

    Private Sub ButtonA_Click(sender As Object, e As EventArgs) Handles ButtonA.Click
        If TxtRA.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelRA.Text, TxtRA.Text & " " & LblRRA.Text, LblVRA.Text)
        End If
    End Sub

    Private Sub ButtonINR_Click(sender As Object, e As EventArgs) Handles ButtonINR.Click
        If TxtINR.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelINR.Text, TxtINR.Text, LblVINR.Text)
        End If
    End Sub

    Private Sub ButtonTipo_Click(sender As Object, e As EventArgs) Handles ButtonTipo.Click
        If TxtTipo.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelTipo.Text, TxtTipo.Text, "")
        End If
    End Sub

    Private Sub LblVVes_Click(sender As Object, e As EventArgs) Handles LblVVes.Click
        LblVVes.Text = InputBox("Ingrese el nuevo Valor de Referencia")
    End Sub

    Private Sub LblVHemo_Click(sender As Object, e As EventArgs) Handles LblVHemo.Click
        LblVHemo.Text = InputBox("Ingrese el nuevo Valor de Referencia")
    End Sub

    Private Sub LblVProtom_Click(sender As Object, e As EventArgs) Handles LblVProtom.Click
        LblVProtom.Text = InputBox("Ingrese el nuevo Valor de Referencia")
    End Sub

    Private Sub LblVTrombo_Click(sender As Object, e As EventArgs) Handles LblVTrombo.Click
        LblVTrombo.Text = InputBox("Ingrese el nuevo Valor de Referencia")
    End Sub

    Private Sub LblVTCoa_Click(sender As Object, e As EventArgs) Handles LblVTCoa.Click
        LblVTCoa.Text = InputBox("Ingrese el nuevo Valor de Referencia")
    End Sub

    Private Sub LblVRCoa_Click(sender As Object, e As EventArgs) Handles LblVRCoa.Click
        LblVRCoa.Text = InputBox("Ingrese el nuevo Valor de Referencia")
    End Sub

    Private Sub LblVSDuke_Click(sender As Object, e As EventArgs) Handles LblVSDuke.Click
        LblVSDuke.Text = InputBox("Ingrese el nuevo Valor de Referencia")
    End Sub

    Private Sub LblVSIvi_Click(sender As Object, e As EventArgs) Handles LblVSIvi.Click
        LblVSIvi.Text = InputBox("Ingrese el nuevo Valor de Referencia")
    End Sub

    Private Sub LblVRRN_Click(sender As Object, e As EventArgs) Handles LblVRRN.Click
        LblVRRN.Text = InputBox("Ingrese el nuevo Valor de Referencia")
    End Sub

    Private Sub LblVRA_Click(sender As Object, e As EventArgs) Handles LblVRA.Click
        LblVRA.Text = InputBox("Ingrese el nuevo Valor de Referencia")
    End Sub

    Private Sub LblVINR_Click(sender As Object, e As EventArgs) Handles LblVINR.Click
        LblVINR.Text = InputBox("Ingrese el nuevo Valor de Referencia")
    End Sub

    Private Sub ButtonSIvi_Click(sender As Object, e As EventArgs) Handles ButtonSIvi.Click
        If TxtSangradoD.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelSIvi.Text, TxtSangradoI.Text & " " & LblRSIvi.Text, LblVSIvi.Text)
        End If
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub F_Hematologia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()
    End Sub


End Class