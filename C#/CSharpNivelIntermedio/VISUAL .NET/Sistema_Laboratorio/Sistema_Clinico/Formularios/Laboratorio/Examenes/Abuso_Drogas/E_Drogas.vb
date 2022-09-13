﻿Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class E_Drogas


    Dim Rruta As String = ""
    Dim rpt As New ReportDocument
    Dim prmdatos As ParameterField
    Dim ID As String

    Public WithEvents Query As New DDrogas
    Dim ConexionLINQ As New DataClasses1DataContext()

    Private Sub CocainaToolStripMenuItem_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        O_Drogas.ShowDialog()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click

        'If TxtPaciente.Text = "" Or TxtEdad.Text = "" Or TxtSexo.Text = "" Or TxtMuestra.Text = "" Then
        '    If TxtPaciente.Text = "" Then
        '        TxtPaciente.BackColor = Color.Yellow
        '        TxtPaciente.Focus()
        '    End If
        '    If TxtEdad.Text = "" Then
        '        TxtEdad.BackColor = Color.Yellow
        '        TxtEdad.Focus()
        '    End If
        '    If TxtSexo.Text = "" Then
        '        TxtSexo.BackColor = Color.Yellow
        '        TxtSexo.Focus()
        '    End If
        '    If TxtMuestra.Text = "" Then
        '        TxtMuestra.BackColor = Color.Yellow
        '        TxtMuestra.Focus()
        '    End If
        '    MsgBox("Llene los campos obligatorios de color amarillo", MsgBoxStyle.Exclamation, "Campos Vacios")
        'Else

        '    If TxtObC.Text = "" Then
        '        TxtObC.Text = " "
        '    End If
        '    If TxtObM.Text = "" Then
        '        TxtObM.Text = " "
        '    End If
        '    If TxtObA.Text = "" Then
        '        TxtObA.Text = " "
        '    End If
        '    If TxtObO.Text = "" Then
        '        TxtObO.Text = " "
        '    End If
        '    If TxtObB.Text = "" Then
        '        TxtObB.Text = " "
        '    End If


        '    Call Query.Guardar_Examen(TxtPaciente.Text, TxtEdad.Text, TxtSexo.Text, TxtReferencia.Text, TxtMuestra.Text, TxtFecha.Text, TxtCocaina.Text, TxtMarihuana.Text, TxtAnfetamina.Text, TxtOpiaseos.Text, TxtBenzo.Text, TxtObC.Text, TxtObM.Text, TxtObA.Text, TxtObO.Text, TxtObB.Text)
        '    MessageBox.Show("Los Datos fueron agregados con exito", "Datos Guardados...")




        '    Imprimir_Examen(LblId.Text)




        '    Limpiar()



        'End If

    End Sub

    Private Sub LlenarDsReporteExamen(ByVal strruta As String, ByVal ids As String)


        ID = ids


        Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
        Dim ta As New SystemLetonaDataSetTableAdapters.Abuso_DrogasTableAdapter

        Try

            ta.FillByMuestra(mids.Abuso_Drogas, ID)

            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtMarihuana.TextChanged

    End Sub

    Private Sub PanelTitulo_Paint(sender As Object, e As PaintEventArgs) Handles PanelTitulo.Paint

    End Sub


    Sub Limpiar()
        TxtPaciente.Clear()
        TxtEdad.Clear()
        TxtSexo.Text = ""
        TxtReferencia.Clear()
        TxtMuestra.Clear()
        TxtObC.Clear()
        TxtObM.Clear()
        TxtObO.Clear()
        TxtObA.Clear()
        TxtObA.Clear()
        TxtCocaina.Clear()
        TxtMarihuana.Clear()
        TxtOpiaseos.Clear()
        TxtBenzo.Clear()
        TxtAnfetamina.Clear()



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

            TxtEdad.Focus()

        End If
    End Sub

    Private Sub TxtSexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtSexo.SelectedIndexChanged

    End Sub

    Private Sub TxtSexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSexo.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtReferencia.Focus()

        End If
    End Sub

    Private Sub TxtReferencia_TextChanged(sender As Object, e As EventArgs) Handles TxtReferencia.TextChanged

    End Sub

    Private Sub TxtReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtReferencia.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtMuestra.Focus()

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

    Private Sub TxtCocaina_TextChanged(sender As Object, e As EventArgs) Handles TxtCocaina.TextChanged

    End Sub

    Private Sub TxtCocaina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCocaina.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtObC.Focus()

        End If
    End Sub

    Private Sub TxtMarihuana_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMarihuana.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtObM.Focus()

        End If
    End Sub

    Private Sub TxtAnfetamina_TextChanged(sender As Object, e As EventArgs) Handles TxtAnfetamina.TextChanged

    End Sub

    Private Sub TxtAnfetamina_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAnfetamina.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtObA.Focus()

        End If
    End Sub

    Private Sub TxtOpiaseos_TextChanged(sender As Object, e As EventArgs) Handles TxtOpiaseos.TextChanged

    End Sub

    Private Sub TxtOpiaseos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOpiaseos.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtObO.Focus()

        End If
    End Sub

    Private Sub TxtBenzo_TextChanged(sender As Object, e As EventArgs) Handles TxtBenzo.TextChanged

    End Sub

    Private Sub TxtBenzo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBenzo.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtObB.Focus()

        End If
    End Sub

    Private Sub TxtObC_TextChanged(sender As Object, e As EventArgs) Handles TxtObC.TextChanged

    End Sub

    Private Sub TxtObC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtObC.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtMarihuana.Focus()

        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TxtObM_TextChanged(sender As Object, e As EventArgs) Handles TxtObM.TextChanged

    End Sub

    Private Sub TxtObM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtObM.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtAnfetamina.Focus()

        End If
    End Sub

    Private Sub TxtObA_TextChanged(sender As Object, e As EventArgs) Handles TxtObA.TextChanged

    End Sub

    Private Sub TxtObA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtObA.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtOpiaseos.Focus()

        End If
    End Sub

    Private Sub TxtObO_TextChanged(sender As Object, e As EventArgs) Handles TxtObO.TextChanged

    End Sub

    Private Sub TxtObO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtObO.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtBenzo.Focus()

        End If
    End Sub

    Private Sub TxtObB_TextChanged(sender As Object, e As EventArgs) Handles TxtObB.TextChanged

    End Sub

    Private Sub TxtObB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtObB.KeyPress
        If Asc(e.KeyChar) = 13 Then

            BtnEnviar.Focus()

        End If
    End Sub

    Private Sub TxtFecha_ValueChanged(sender As Object, e As EventArgs) Handles TxtFecha.ValueChanged

    End Sub

    Private Sub TxtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFecha.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtCocaina.Focus()

        End If
    End Sub

    Private Sub E_Drogas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub E_Drogas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Imprimir_Examen(TextBox1.Text)


    End Sub

    Sub Imprimir_Examen(ByVal Id As String)
        Dim resp As String

        resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


        If resp = 6 Then

            Rruta = "C:\SystemLetona\CrysDrogas.rpt"

            LlenarDsReporteExamen(Rruta, Id) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


        End If
    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim Codigo As String = LblId.Text

        'Imprimir Directo a la impresora

        If TxtCocaina.Text <> "" Then
            My.Forms.I_Drogas.DataGridView1.Rows.Add(Label5.Text, TxtCocaina.Text, TxtObC.Text)

        End If

        If TxtMarihuana.Text <> "" Then
            My.Forms.I_Drogas.DataGridView1.Rows.Add(Label6.Text, TxtMarihuana.Text, TxtObM.Text)
        End If

        If TxtAnfetamina.Text <> "" Then

            My.Forms.I_Drogas.DataGridView1.Rows.Add(Label7.Text, TxtAnfetamina.Text, TxtObA.Text)
        End If

        If TxtOpiaseos.Text <> "" Then

            My.Forms.I_Drogas.DataGridView1.Rows.Add(Label8.Text, TxtOpiaseos.Text, TxtObO.Text)
        End If

        If TxtBenzo.Text <> "" Then

            My.Forms.I_Drogas.DataGridView1.Rows.Add(Label9.Text, TxtBenzo.Text, TxtObB.Text)

        End If

        I_Drogas.Show()

    End Sub
End Class