Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class F_PEspeciales

    Dim Rruta As String = ""
    Dim rpt As New ReportDocument
    Dim prmdatos As ParameterField
    Dim ID As String
    Public WithEvents Query As New DEspeciales
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

    Private Sub TxtAyunas_TextChanged(sender As Object, e As EventArgs)

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

            TxtTSH.Focus()

        End If
    End Sub

    Private Sub F_PEspeciales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SystemLetonaDataSet.PEspeciales' Puede moverla o quitarla según sea necesario.
        Me.PEspecialesTableAdapter.Fill(Me.SystemLetonaDataSet.PEspeciales)
        'TODO: esta línea de código carga datos en la tabla 'SystemLetonaDataSet.PEspeciales' Puede moverla o quitarla según sea necesario.

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
        TxtReferencia.Text = ""
        TxtTSH.Clear()
        TxtT3.Clear()
        TxtT4.Clear()
        TxtT4_Libre.Clear()
        TxtNota.Clear()
        LblId.Text = Query.Id() + 1
        TxtMuestra.Text = LblId.Text

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

            If TxtTSH.Text = "" Then
                TxtTSH.Text = " "
            End If
            If TxtT3.Text = "" Then
                TxtT3.Text = " "
            End If
            If TxtT4.Text = "" Then
                TxtT4.Text = " "
            End If
            If TxtT4_Libre.Text = "" Then
                TxtT4_Libre.Text = " "
            End If
            If TxtT3_Libre.Text = "" Then
                TxtT3_Libre.Text = " "
            End If
            If TxtInsulina.Text = "" Then
                TxtInsulina.Text = " "
            End If
            If TxtInsulina2.Text = "" Then
                TxtInsulina2.Text = " "
            End If
            If TxtTesto.Text = "" Then
                TxtTesto.Text = " "
            End If
            If TxtAnti.Text = "" Then
                TxtAnti.Text = " "
            End If
            If TxtProlactina.Text = "" Then
                TxtProlactina.Text = " "
            End If
            If TxtFSH.Text = "" Then
                TxtFSH.Text = " "
            End If
            If TxtNota.Text = "" Then
                TxtNota.Text = " "
            End If

            'Call Query.Guardar_Examen(TxtIdentidad.Text, TxtPaciente.Text, TxtEdad.Text, TxtSexo.Text, TxtReferencia.Text, TxtMuestra.Text, TxtFecha.Text, TxtTSH.Text, TxtT3.Text, TxtT4.Text, TxtT4_Libre.Text, TxtInsulina.Text, TxtT3_Libre.Text, TxtInsulina2.Text, TxtTesto.Text, TxtAnti.Text, TxtProlactina.Text, TxtFSH.Text, TxtNota.Text)
            If TxtTSH.Text <> " " Then
                Call ButtonTSH_Click(sender, e)
            End If
            If TxtT3.Text <> " " Then
                Call ButtonT3_Click(sender, e)
            End If
            If TxtT3_Libre.Text <> " " Then
                Call ButtonT3L_Click(sender, e)
            End If
            If TxtT4.Text <> " " Then
                Call ButtonT4_Click(sender, e)
            End If
            If TxtT4_Libre.Text <> " " Then
                Call ButtonT4L_Click(sender, e)
            End If
            If TxtInsulina.Text <> " " Then
                Call ButtonInsu_Click(sender, e)
            End If
            If TxtInsulina2.Text <> " " Then
                Call ButtonInsu2_Click(sender, e)
            End If

            If TxtAnti.Text <> " " Then
                Call ButtonAnti_Click(sender, e)
            End If

            If TxtProlactina.Text <> " " Then
                Call ButtonProlac_Click(sender, e)
            End If
            If TxtTesto.Text <> " " Then
                Call ButtonTesto_Click(sender, e)
            End If
            If TxtFSH.Text <> " " Then
                Call ButtonFSH_Click(sender, e)
            End If








            For i As Integer = 0 To DataGridView1.Rows.Count - 2

                Me.PEspecialesTableAdapter.InsertQueryPEspeciales(TxtMuestra.Text, TxtIdentidad.Text, TxtPaciente.Text, TxtEdad.Text, TxtSexo.Text, TxtReferencia.Text, TxtFecha.Text, ((DataGridView1.Rows(i).Cells(1).Value)), ((DataGridView1.Rows(i).Cells(2).Value)), ((DataGridView1.Rows(i).Cells(3).Value)), TxtNota.Text)
                ' MsgBox(DatagridView1.Rows(i).Cells(0).Value & " detalle factura guardado")
                'txtMuestra.Text = Query.Id() + 1
            Next



            MessageBox.Show("Los Datos fueron agregados con exito", "Datos Guardados...")

            Imprimir_Examen(TxtMuestra.Text)


            Limpiar()



        End If


    End Sub

    Private Sub LlenarDsReporteExamen(ByVal strruta As String, ByVal Ids As String)

        ID = Ids

        Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
        Dim ta As New SystemLetonaDataSetTableAdapters.PEspecialesTableAdapter
        Dim ta2 As New SystemLetonaDataSetTableAdapters.PEspecialesTableAdapter

        Try

            ta.FillByMuestra(mids.PEspeciales, ID)


            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Imprimir_Examen(TextBox1.Text)

    End Sub

    Sub Imprimir_Examen(ByVal Id As String)
        Dim resp As String

        resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


        If resp = 6 Then

            Rruta = "C:\SystemLetona\CrysPEspeciales.rpt"

            LlenarDsReporteExamen(Rruta, Id) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        O_Especiales.ShowDialog()
    End Sub

    Private Sub F_PEspeciales_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()

    End Sub




    Private Sub ButtonT4_Click(sender As Object, e As EventArgs) Handles ButtonT4.Click
        If TxtT4.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelT4.Text, TxtT4.Text & " ", LblVT4.Text)
        End If
    End Sub

    Private Sub ButtonT4L_Click(sender As Object, e As EventArgs) Handles ButtonT4L.Click
        If TxtT4_Libre.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelT4L.Text, TxtT4_Libre.Text, LblVT4L.Text)
        End If
    End Sub

    Private Sub ButtonInsu_Click(sender As Object, e As EventArgs) Handles ButtonInsu.Click
        If TxtInsulina.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelInsu.Text, TxtInsulina.Text, LblVInsu.Text)
        End If
    End Sub

    Private Sub ButtonT3L_Click(sender As Object, e As EventArgs) Handles ButtonT3L.Click
        If TxtT3_Libre.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelT3L.Text, TxtT3_Libre.Text, "")
        End If
    End Sub

    Private Sub ButtonInsu2_Click(sender As Object, e As EventArgs) Handles ButtonInsu2.Click
        If TxtInsulina2.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelInsu2.Text, TxtInsulina2.Text, LblVInsu2.Text)
        End If
    End Sub

    Private Sub ButtonTesto_Click(sender As Object, e As EventArgs) Handles ButtonTesto.Click
        If TxtTesto.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelTesto.Text, TxtTesto.Text, LblVTesto.Text)
        End If
    End Sub

    Private Sub ButtonAnti_Click(sender As Object, e As EventArgs) Handles ButtonAnti.Click
        If TxtAnti.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelAnti.Text, TxtAnti.Text, LblVAnti.Text)
        End If
    End Sub

    Private Sub ButtonProlac_Click(sender As Object, e As EventArgs) Handles ButtonProlac.Click
        If TxtProlactina.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelProlac.Text, TxtProlactina.Text, LblVProlac.Text)
        End If
    End Sub

    Private Sub ButtonFSH_Click(sender As Object, e As EventArgs) Handles ButtonFSH.Click
        If TxtFSH.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelFSH.Text, TxtFSH.Text, LblVFSH.Text)
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Imprimir_Examen(TextBox1.Text)
    End Sub

    Private Sub ButtonTSH_Click(sender As Object, e As EventArgs) Handles ButtonTSH.Click
        If TxtTSH.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelTSH.Text, TxtTSH.Text, LblVTSH.Text)
        End If
    End Sub

    Private Sub ButtonT3_Click(sender As Object, e As EventArgs) Handles ButtonT3.Click
        If TxtT3.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelT3.Text, TxtT3.Text, LblVT3.Text)
        End If
    End Sub
End Class