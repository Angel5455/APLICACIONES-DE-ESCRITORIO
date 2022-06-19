Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class F_Drogas

    Dim Rruta As String = ""
    Dim rpt As New ReportDocument
    Dim prmdatos As ParameterField
    Dim ID As String
    Dim encontrado As Boolean

    Public WithEvents Query As New DDrogas
    Dim ConexionLINQ As New DataClasses1DataContext()
    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        If TxtCocaina.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LblC.Text, TxtCocaina.Text, TxtObC.Text)
        End If


    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        O_Drogas.ShowDialog()
    End Sub

    Private Sub ButtonM_Click(sender As Object, e As EventArgs) Handles ButtonM.Click
        If TxtMarihuana.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LblM.Text, TxtMarihuana.Text, TxtObM.Text)
        End If

    End Sub

    Private Sub ButtonA_Click(sender As Object, e As EventArgs) Handles ButtonA.Click
        If TxtAnfetamina.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LblA.Text, TxtAnfetamina.Text, TxtObA.Text)
        End If

    End Sub

    Private Sub ButtonO_Click(sender As Object, e As EventArgs) Handles ButtonO.Click
        If TxtOpiaseos.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LblC.Text, TxtOpiaseos.Text, TxtObC.Text)
        End If

    End Sub

    Private Sub ButtonB_Click(sender As Object, e As EventArgs) Handles ButtonB.Click
        If TxtBenzo.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LblB.Text, TxtBenzo.Text, TxtObB.Text)
        End If

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click

        If TxtIdentidad.Text = "" Or TxtPaciente.Text = "" Or TxtEdad.Text = "" Or TxtSexo.Text = "" Or TxtMuestra.Text = "" Then
            If TxtIdentidad.Text = "" Then
                TxtIdentidad.BackColor = Color.Yellow
                TxtIdentidad.Focus()
            End If

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

            If TxtObC.Text = "" Then
                TxtObC.Text = " "
            End If
            If TxtObM.Text = "" Then
                TxtObM.Text = " "
            End If
            If TxtObA.Text = "" Then
                TxtObA.Text = " "
            End If
            If TxtObO.Text = "" Then
                TxtObO.Text = " "
            End If
            If TxtObB.Text = "" Then
                TxtObB.Text = " "
            End If

            Call ButtonC_Click(sender, e)
            Call ButtonM_Click(sender, e)
            Call ButtonA_Click(sender, e)
            Call ButtonO_Click(sender, e)
            Call ButtonB_Click(sender, e)


            For i As Integer = 0 To DataGridView1.Rows.Count - 2

                Me.Abuso_DrogasTableAdapter.InsertQueryDrogas(TxtMuestra.Text, TxtIdentidad.Text, TxtPaciente.Text, TxtEdad.Text, TxtSexo.Text, TxtReferencia.Text, TxtFecha.Text, ((DataGridView1.Rows(i).Cells(1).Value)), ((DataGridView1.Rows(i).Cells(2).Value)), ((DataGridView1.Rows(i).Cells(3).Value)))
                ' MsgBox(DatagridView1.Rows(i).Cells(0).Value & " detalle factura guardado")
                'txtMuestra.Text = Query.Id() + 1
            Next





            Imprimir_Examen(TxtMuestra.Text)




            Limpiar()



        End If




    End Sub

    Sub Limpiar()

        TxtPaciente.BackColor = Color.White
        TxtIdentidad.BackColor = Color.White
        TxtEdad.BackColor = Color.White
        TxtSexo.BackColor = Color.White


        TxtPaciente.Clear()
        TxtEdad.Clear()
        TxtSexo.Text = ""
        TxtIdentidad.Clear()
        TxtReferencia.Text = ""


        TxtObC.Clear()
        TxtObM.Clear()
        TxtObO.Clear()
        TxtObA.Clear()
        TxtObB.Clear()
        TxtCocaina.Clear()
        TxtMarihuana.Clear()
        TxtOpiaseos.Clear()
        TxtBenzo.Clear()
        TxtAnfetamina.Clear()
        TxtMuestra.Text = Query.Id() + 1
        TxtMuestra.Text = TxtMuestra.Text
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

            TxtPaciente.Focus()

        End If
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

    Private Sub F_Drogas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SystemLetonaDataSet.Abuso_Drogas' Puede moverla o quitarla según sea necesario.
        Me.Abuso_DrogasTableAdapter.Fill(Me.SystemLetonaDataSet.Abuso_Drogas)
        'TODO: esta línea de código carga datos en la tabla 'SystemLetonaDataSet.EDrogas' Puede moverla o quitarla según sea necesario.


        TxtMuestra.Text = Query.Id() + 1




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

    Sub Imprimir_Examen(ByVal Id As String)
        Dim resp As String

        resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


        If resp = 6 Then

            Rruta = "C:\SystemLetona\CrysDrogas.rpt"

            LlenarDsReporteExamen(Rruta, Id) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Imprimir_Examen(TextBox1.Text)


    End Sub

    Private Sub TxtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles TxtIdentidad.TextChanged

    End Sub

    Private Sub F_Drogas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()

    End Sub
End Class