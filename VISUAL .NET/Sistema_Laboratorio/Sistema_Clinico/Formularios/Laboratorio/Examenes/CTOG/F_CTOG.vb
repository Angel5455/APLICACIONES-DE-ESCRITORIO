Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class F_CTOG

    Dim Rruta As String = ""
    Dim rpt As New ReportDocument
    Dim prmdatos As ParameterField
    Dim ID As String
    Public WithEvents Query As New DCTOG
    Dim ConexionLINQ As New DataClasses1DataContext()

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

    Private Sub TxtAyunas_TextChanged(sender As Object, e As EventArgs) Handles TxtAyunas.TextChanged

    End Sub

    Private Sub TxtAyunas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAyunas.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            Txt1Hora.Focus()

        End If
    End Sub

    Private Sub Txt1Hora_TextChanged(sender As Object, e As EventArgs) Handles Txt1Hora.TextChanged

    End Sub

    Private Sub Txt1Hora_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt1Hora.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            Txt2Horas.Focus()

        End If
    End Sub

    Private Sub Txt2Horas_TextChanged(sender As Object, e As EventArgs) Handles Txt2Horas.TextChanged

    End Sub

    Private Sub Txt2Horas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt2Horas.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            Txt3Horas.Focus()

        End If
    End Sub

    Private Sub Txt3Horas_TextChanged(sender As Object, e As EventArgs) Handles Txt3Horas.TextChanged

    End Sub

    Private Sub Txt3Horas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt3Horas.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtNota.Focus()

        End If
    End Sub

    Private Sub TxtNota_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub TxtNota_KeyPress(sender As Object, e As KeyPressEventArgs)

        If Asc(e.KeyChar) = 13 Then

            BtnEnviar.Focus()

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

            TxtPaciente.Focus()

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

            TxtAyunas.Focus()

        End If
    End Sub

    Private Sub F_CTOG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtMuestra.Text = Query.Id() + 1
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
        TxtAyunas.Clear()
        Txt1Hora.Clear()
        Txt2Horas.Clear()
        Txt3Horas.Clear()
        TxtNota.Clear()
        TxtReferencia.Text = ""
        TxtMuestra.Text = Query.Id() + 1
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.Rows.Clear()

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

            If TxtAyunas.Text = "" Then
                TxtAyunas.Text = " "
            End If
            If Txt1Hora.Text = "" Then
                Txt1Hora.Text = " "
            End If
            If Txt2Horas.Text = "" Then
                Txt2Horas.Text = " "
            End If
            If Txt3Horas.Text = "" Then
                Txt3Horas.Text = " "
            End If
            If TxtNota.Text = "" Then
                TxtNota.Text = " "
            End If

            If TxtAyunas.Text <> " " Then
                Call ButtonA_Click(sender, e)
            End If
            If Txt1Hora.Text <> " " Then
                Call Button1H_Click(sender, e)
            End If
            If Txt2Horas.Text <> " " Then
                Call Button2H_Click(sender, e)
            End If
            If Txt3Horas.Text <> " " Then
                Call Button3H_Click(sender, e)
            End If



            For i As Integer = 0 To DataGridView1.Rows.Count - 2

                Me.CTOGTableAdapter.InsertQueryCTOG(TxtMuestra.Text, TxtIdentidad.Text, TxtPaciente.Text, TxtEdad.Text, TxtSexo.Text, TxtReferencia.Text, TxtFecha.Text, ((DataGridView1.Rows(i).Cells(1).Value)), ((DataGridView1.Rows(i).Cells(2).Value) & " mg/dL"), ((DataGridView1.Rows(i).Cells(3).Value) & " mg/dL"), TxtNota.Text)
                ' MsgBox(DatagridView1.Rows(i).Cells(0).Value & " detalle factura guardado")
                'txtMuestra.Text = Query.Id() + 1
            Next





            Imprimir_Examen(TxtMuestra.Text)




            Limpiar()



        End If


    End Sub

    Private Sub LlenarDsReporteExamen(ByVal strruta As String, ByVal Ids As String)

        ID = Ids

        Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
        Dim ta As New SystemLetonaDataSetTableAdapters.CTOGTableAdapter
        Dim ta2 As New SystemLetonaDataSetTableAdapters.CTOGTableAdapter

        Try

            ta.FillByMuestra(mids.CTOG, ID)


            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        O_CTOG.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Imprimir_Examen(TextBox1.Text)

    End Sub

    Sub Imprimir_Examen(ByVal Id As String)
        Dim resp As String

        resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


        If resp = 6 Then

            Rruta = "C:\SystemLetona\CrysCTOG.rpt"

            LlenarDsReporteExamen(Rruta, Id) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


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

    Private Sub ButtonA_Click(sender As Object, e As EventArgs) Handles ButtonA.Click
        If TxtAyunas.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelA.Text, TxtAyunas.Text, LblVA.Text)
        End If

    End Sub

    Private Sub Button1H_Click(sender As Object, e As EventArgs) Handles Button1H.Click
        If Txt1Hora.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, Label1H.Text, Txt1Hora.Text, LblV1.Text)
        End If
    End Sub

    Private Sub Button2H_Click(sender As Object, e As EventArgs) Handles Button2H.Click
        If Txt2Horas.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, Label2H.Text, Txt2Horas.Text, LblV2.Text)
        End If
    End Sub

    Private Sub Button3H_Click(sender As Object, e As EventArgs) Handles Button3H.Click
        If Txt3Horas.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, Label3H.Text, Txt3Horas.Text, LblV3.Text)
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Imprimir_Examen(TextBox1.Text)
    End Sub

    Private Sub LblVA_Click(sender As Object, e As EventArgs) Handles LblVA.Click
        LblVA.Text = InputBox("Ingrese el nuevo Valor de Referencia")
    End Sub

    Private Sub LblV1_Click(sender As Object, e As EventArgs) Handles LblV1.Click
        LblV1.Text = InputBox("Ingrese el nuevo Valor de Referencia")
    End Sub

    Private Sub LblV2_Click(sender As Object, e As EventArgs) Handles LblV2.Click
        LblV2.Text = InputBox("Ingrese el nuevo Valor de Referencia")
    End Sub

    Private Sub LblV3_Click(sender As Object, e As EventArgs) Handles LblV3.Click
        LblV3.Text = InputBox("Ingrese el nuevo Valor de Referencia")
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub F_CTOG_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()

    End Sub
End Class