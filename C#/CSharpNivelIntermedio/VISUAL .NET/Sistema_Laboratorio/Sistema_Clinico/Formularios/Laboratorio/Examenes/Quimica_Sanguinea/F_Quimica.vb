Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class F_Quimica


    Dim Rruta As String = ""
    Dim rpt As New ReportDocument
    Dim prmdatos As ParameterField
    Dim ID As String
    Public WithEvents Query As New DQuimica
    Dim ConexionLINQ As New DataClasses1DataContext()
    Private Sub ButtonGlucosa_Click(sender As Object, e As EventArgs) Handles ButtonGlucosa.Click
        If TxtGlucosa.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelGlucosa.Text, (TxtGlucosa.Text & " " & LblRGlucosa.Text), LblVGlucosa.Text)
        End If
    End Sub

    Private Sub TxtEdad_TextChanged(sender As Object, e As EventArgs) Handles TxtEdad.TextChanged

    End Sub

    Private Sub TxtNota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNota.KeyPress

        If Asc(e.KeyChar) = 13 Then

            BtnEnviar.Focus()

        End If
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


    Private Sub TxtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdad.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtSexo.Focus()

        End If
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

            TxtGlucosa.Focus()

        End If
    End Sub



    Private Sub ButtonGlucosaPP_Click(sender As Object, e As EventArgs) Handles ButtonGlucosaPP.Click
        If TxtGlucosaPP.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelGlucosaPP.Text, (TxtGlucosaPP.Text & " " & LblRGlucosaPP.Text), " ")
        End If


    End Sub

    Private Sub ButtonTrigli_Click(sender As Object, e As EventArgs) Handles ButtonTrigli.Click
        If TxtTrigli.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelTrigli.Text, (TxtTrigli.Text & " " & LblRTrigli.Text), LblVTrigli.Text)
        End If
    End Sub

    Private Sub ButtonAcido_Click(sender As Object, e As EventArgs) Handles ButtonAcido.Click

        If TxtAcido.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelAcido.Text, (TxtAcido.Text & " " & LblRAcido.Text), LblVAcido.Text)
        End If
    End Sub

    Private Sub ButtonCreatinina_Click(sender As Object, e As EventArgs) Handles ButtonCreatinina.Click

        If TxtCreatinina.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelCreatinina.Text, (TxtCreatinina.Text & " " & LblRCreatinina.Text), LblVCreatinina.Text)
        End If
    End Sub

    Private Sub F_Quimica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SystemLetonaDataSet.Quimica_Sanguinea' Puede moverla o quitarla según sea necesario.
        ' Me.Quimica_SanguineaTableAdapter.Fill(Me.SystemLetonaDataSet.Quimica_Sanguinea)
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
        TxtGlucosa.Clear()
        TxtGlucosaPP.Clear()
        TxtTrigli.Clear()
        TxtAcido.Clear()
        TxtCreatinina.Clear()
        TxtUrea.Clear()
        TxtBun.Clear()
        TxtTGO.Clear()
        TxtTGP.Clear()
        TxtFosfata.Clear()
        TxtCTotal.Clear()
        TxtLDL.Clear()
        TxtHDL.Clear()
        TxtVLDL.Clear()
        TxtBTotal.Clear()
        TxtBDirecta.Clear()
        TxtBIndirecta.Clear()
        TxtProteinas.Clear()
        TxtAmilasa.Clear()
        TxtLipasa.Clear()
        TxtLDH.Clear()
        TxtCPK.Clear()
        TxtCK.Clear()
        TxtTroponina.Clear()
        TxtCalcio.Clear()
        TxtFosforo.Clear()
        TxtMagnesio.Clear()
        TxtPotasio.Clear()
        TxtSodio.Clear()
        TxtCloruro.Clear()
        TxtGGT.Clear()
        TxtHB.Clear()



        LblId.Text = Query.Id() + 1
        TxtMuestra.Text = LblId.Text

    End Sub

    Private Sub TxtNota_TextChanged(sender As Object, e As EventArgs) Handles TxtNota.TextChanged

    End Sub



    Private Sub ButtonUrea_Click(sender As Object, e As EventArgs) Handles ButtonUrea.Click
        If TxtUrea.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelUrea.Text, (TxtUrea.Text & " " & LblRUrea.Text), LblVUrea.Text)
        End If
    End Sub

    Private Sub ButtonBun_Click(sender As Object, e As EventArgs) Handles ButtonBun.Click
        If TxtBun.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelBun.Text, (TxtBun.Text & " " & LblRBun.Text), LblVBun.Text)
        End If


    End Sub

    Private Sub ButtonTGO_Click(sender As Object, e As EventArgs) Handles ButtonTGO.Click
        If TxtTGO.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelTGO.Text, (TxtTGO.Text & " " & LblRTGO.Text), LblVTGO.Text)
        End If
    End Sub

    Private Sub ButtonTGP_Click(sender As Object, e As EventArgs) Handles ButtonTGP.Click
        If TxtTGP.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelTGP.Text, (TxtTGP.Text & " " & LblRTGP.Text), LblVTGP.Text)
        End If
    End Sub

    Private Sub ButtonFosfa_Click(sender As Object, e As EventArgs) Handles ButtonFosfa.Click
        If TxtFosfata.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelFosfatasa.Text, (TxtFosfata.Text & " " & LblRFosfatasa.Text), LblVFosfa.Text)
        End If
    End Sub

    Private Sub ButtonCTotal_Click(sender As Object, e As EventArgs) Handles ButtonCTotal.Click
        If TxtCTotal.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelCTotal.Text, (TxtCTotal.Text & " " & LblRCTotal.Text), LblVCTotal.Text)
        End If
    End Sub

    Private Sub ButtonHDL_Click(sender As Object, e As EventArgs) Handles ButtonHDL.Click
        If TxtHDL.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelHDL.Text, (TxtHDL.Text & " " & LblRHDL.Text), LblVHDL.Text)
        End If
    End Sub

    Private Sub ButtonLDL_Click(sender As Object, e As EventArgs) Handles ButtonLDL.Click
        If TxtLDL.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelLDL.Text, (TxtLDL.Text & " " & LblRLDL.Text), LblVLDL.Text)
        End If
    End Sub

    Private Sub ButtonVLDL_Click(sender As Object, e As EventArgs) Handles ButtonVLDL.Click
        If TxtVLDL.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelVLDL.Text, (TxtVLDL.Text & " " & LblRVLDL.Text), LblVVLDL.Text)
        End If
    End Sub

    Private Sub ButtonBTotal_Click(sender As Object, e As EventArgs) Handles ButtonBTotal.Click
        If TxtBTotal.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelBTotal.Text, (TxtBTotal.Text & " " & LblRBTotal.Text), LblVBTotal.Text)
        End If
    End Sub

    Private Sub ButtonBDirecta_Click(sender As Object, e As EventArgs) Handles ButtonBDirecta.Click
        If TxtBDirecta.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelBDirecta.Text, (TxtBDirecta.Text & " " & LblRBDirecta.Text), LblVBDirecta.Text)
        End If
    End Sub

    Private Sub ButtonBIndirecta_Click(sender As Object, e As EventArgs) Handles ButtonBIndirecta.Click
        If TxtBIndirecta.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelBIndirecta.Text, (TxtBIndirecta.Text & LblRBIndirecta.Text), LblVBIndirecta.Text)
        End If
    End Sub

    Private Sub ButtonProteinas_Click(sender As Object, e As EventArgs) Handles ButtonProteinas.Click
        If TxtProteinas.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelProteinas.Text, (TxtProteinas.Text & " " & LblRProteinas.Text), LblVProteinas.Text)
        End If
    End Sub

    Private Sub ButtonAlbumina_Click(sender As Object, e As EventArgs) Handles ButtonAlbumina.Click
        If TxtAlbumina.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelAlbumina.Text, (TxtAlbumina.Text & " " & LblRAlbumina.Text), LblVAlbumina.Text)
        End If
    End Sub

    Private Sub ButtonPLCL_Click(sender As Object, e As EventArgs) Handles ButtonPLCL.Click
        If TxtPLCL.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelPLCL.Text, (TxtPLCL.Text & " " & LblRPLCL.Text), LblVPLCL.Text)
        End If


    End Sub

    Private Sub ButtonAmilasa_Click(sender As Object, e As EventArgs) Handles ButtonAmilasa.Click
        If TxtAmilasa.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelAmilasa.Text, (TxtAmilasa.Text & " " & LblRAmilasa.Text), LblVAmilasa.Text)
        End If
    End Sub

    Private Sub ButtonLipasa_Click(sender As Object, e As EventArgs) Handles ButtonLipasa.Click
        If TxtLipasa.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelLipasa.Text, (TxtLipasa.Text & " " & LblRLipasa.Text), " ")
        End If
    End Sub

    Private Sub ButtonLDH_Click(sender As Object, e As EventArgs) Handles ButtonLDH.Click
        If TxtLDH.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelLDH.Text, (TxtLDH.Text & " " & LblRLDH.Text), LblVLDH.Text)
        End If
    End Sub

    Private Sub ButtonCPK_Click(sender As Object, e As EventArgs) Handles ButtonCPK.Click
        If TxtCPK.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelCPK.Text, (TxtCPK.Text & " " & LblRCPK.Text), LblVCPK.Text)
        End If
    End Sub

    Private Sub ButtonCK_Click(sender As Object, e As EventArgs) Handles ButtonCK.Click
        If TxtCK.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelCK.Text, (TxtCK.Text & " " & LblRCK.Text), LblVCK.Text)
        End If
    End Sub

    Private Sub ButtonTroponina_Click(sender As Object, e As EventArgs) Handles ButtonTroponina.Click
        If TxtTroponina.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelTroponina.Text, (TxtTroponina.Text & " " & LblRTroponina.Text), LblVTroponina.Text)
        End If
    End Sub

    Private Sub ButtonCalcio_Click(sender As Object, e As EventArgs) Handles ButtonCalcio.Click
        If TxtCalcio.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelCalcio.Text, (TxtCalcio.Text & " " & LblRCalcio.Text), LblVCalcio.Text)
        End If
    End Sub

    Private Sub ButtonFosforo_Click(sender As Object, e As EventArgs) Handles ButtonFosforo.Click
        If TxtFosforo.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelFosforo.Text, (TxtFosforo.Text & " " & LblRFosforo.Text), LblVFosforo.Text)
        End If
    End Sub

    Private Sub ButtonMagnesio_Click(sender As Object, e As EventArgs) Handles ButtonMagnesio.Click
        If TxtMagnesio.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelMagnesio.Text, (TxtMagnesio.Text & " " & LblRMagnesio.Text), LblVMagnesio.Text)
        End If
    End Sub

    Private Sub ButtonSodio_Click(sender As Object, e As EventArgs) Handles ButtonSodio.Click
        If TxtSodio.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelSodio.Text, (TxtSodio.Text & " " & LblRSodio.Text), LblVSodio.Text)
        End If
    End Sub

    Private Sub ButtonCloruro_Click(sender As Object, e As EventArgs) Handles ButtonCloruro.Click
        If TxtCloruro.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelCloruro.Text, (TxtCloruro.Text & " " & LblRCloruro.Text), LblVCloruro.Text)
        End If
    End Sub

    Private Sub ButtonPotasio_Click(sender As Object, e As EventArgs) Handles ButtonPotasio.Click
        If TxtPotasio.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelPotasio.Text, (TxtPotasio.Text & " " & LblRPotasio.Text), LblVPotasio.Text)
        End If
    End Sub

    Private Sub ButtonGGT_Click(sender As Object, e As EventArgs) Handles ButtonGGT.Click
        If TxtGGT.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelGGT.Text, (TxtGGT.Text & " " & LblRGGT.Text), LblVGGT.Text)
        End If
    End Sub

    Private Sub ButtonHB_Click(sender As Object, e As EventArgs) Handles ButtonHB.Click
        If TxtHB.Text <> "" Then
            Me.DataGridView1.Rows.Add(TxtMuestra.Text, LabelHB.Text, (TxtHB.Text & " " & LblRHB.Text), LblVHB.Text)
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

            If TxtGlucosa.Text = "" Then
                TxtGlucosa.Text = " "
            End If
            If TxtGlucosaPP.Text = "" Then
                TxtGlucosaPP.Text = " "
            End If
            If TxtTrigli.Text = "" Then
                TxtTrigli.Text = " "
            End If
            If TxtAcido.Text = "" Then
                TxtAcido.Text = " "
            End If
            If TxtCreatinina.Text = "" Then
                TxtCreatinina.Text = " "
            End If
            If TxtUrea.Text = "" Then
                TxtUrea.Text = " "
            End If
            If TxtBun.Text = "" Then
                TxtBun.Text = " "
            End If
            If TxtTGO.Text = "" Then
                TxtTGO.Text = " "
            End If
            If TxtTGP.Text = "" Then
                TxtTGP.Text = " "
            End If
            If TxtFosfata.Text = "" Then
                TxtFosfata.Text = " "
            End If
            If TxtCTotal.Text = "" Then
                TxtCTotal.Text = " "
            End If
            If TxtHDL.Text = "" Then
                TxtHDL.Text = " "
            End If
            If TxtLDL.Text = "" Then
                TxtLDL.Text = " "
            End If
            If TxtVLDL.Text = "" Then
                TxtVLDL.Text = " "
            End If
            If TxtBTotal.Text = "" Then
                TxtBTotal.Text = " "
            End If
            If TxtBDirecta.Text = "" Then
                TxtBDirecta.Text = " "
            End If
            If TxtBIndirecta.Text = "" Then
                TxtBIndirecta.Text = " "
            End If
            If TxtProteinas.Text = "" Then
                TxtProteinas.Text = " "
            End If
            If TxtAlbumina.Text = "" Then
                TxtAlbumina.Text = " "
            End If
            If TxtPLCL.Text = "" Then
                TxtPLCL.Text = " "
            End If
            If TxtAmilasa.Text = "" Then
                TxtAmilasa.Text = " "
            End If
            If TxtLipasa.Text = "" Then
                TxtLipasa.Text = " "
            End If
            If TxtLDH.Text = "" Then
                TxtLDH.Text = " "
            End If
            If TxtCPK.Text = "" Then
                TxtCPK.Text = " "
            End If
            If TxtCK.Text = "" Then
                TxtCK.Text = " "
            End If
            If TxtTroponina.Text = "" Then
                TxtTroponina.Text = " "
            End If
            If TxtCalcio.Text = "" Then
                TxtCalcio.Text = " "
            End If
            If TxtFosforo.Text = "" Then
                TxtFosforo.Text = " "
            End If
            If TxtMagnesio.Text = "" Then
                TxtMagnesio.Text = " "
            End If
            If TxtSodio.Text = "" Then
                TxtSodio.Text = " "
            End If
            If TxtPotasio.Text = "" Then
                TxtPotasio.Text = " "
            End If
            If TxtCloruro.Text = "" Then
                TxtCloruro.Text = " "
            End If
            If TxtGGT.Text = "" Then
                TxtGGT.Text = " "
            End If
            If TxtHB.Text = "" Then
                TxtHB.Text = " "
            End If
            If TxtNota.Text = "" Then
                TxtNota.Text = " "
            End If

            'Call Query.Guardar_Examen(TxtIdentidad.Text, TxtPaciente.Text, TxtEdad.Text, TxtSexo.Text, TxtReferencia.Text, TxtMuestra.Text, TxtFecha.Text, TxtHDL.Text, TxtGlucosaPP.Text, TxtTrigli.Text, TxtAcido.Text, TxtUrea.Text, TxtCreatinina.Text, TxtBun.Text, TxtTGO.Text, TxtTGP.Text, TxtFosfa.Text, TxtCTotal.Text, TxtNota.Text)
            If TxtGlucosa.Text <> " " Then
                Call ButtonGlucosa_Click(sender, e)
            End If
            If TxtGlucosaPP.Text <> " " Then
                Call ButtonGlucosaPP_Click(sender, e)
            End If
            If TxtCreatinina.Text <> " " Then
                Call ButtonCreatinina_Click(sender, e)
            End If
            If TxtTrigli.Text <> " " Then
                Call ButtonTrigli_Click(sender, e)
            End If
            If TxtAcido.Text <> " " Then
                Call ButtonAcido_Click(sender, e)
            End If
            If TxtUrea.Text <> " " Then
                Call ButtonUrea_Click(sender, e)
            End If
            If TxtBun.Text <> " " Then
                Call ButtonBun_Click(sender, e)
            End If

            If TxtTGP.Text <> " " Then
                Call ButtonTGP_Click(sender, e)
            End If

            If TxtFosfata.Text <> " " Then
                Call ButtonFosfa_Click(sender, e)
            End If
            If TxtTGO.Text <> " " Then
                Call ButtonTGO_Click(sender, e)
            End If
            If TxtCTotal.Text <> " " Then
                Call ButtonCTotal_Click(sender, e)
            End If



            If TxtHDL.Text <> " " Then
                Call ButtonHDL_Click(sender, e)
            End If
            If TxtLDL.Text <> " " Then
                Call ButtonLDL_Click(sender, e)
            End If
            If TxtVLDL.Text <> " " Then
                Call ButtonVLDL_Click(sender, e)
            End If
            If TxtBTotal.Text <> " " Then
                Call ButtonBTotal_Click(sender, e)
            End If
            If TxtBDirecta.Text <> " " Then
                Call ButtonBDirecta_Click(sender, e)
            End If
            If TxtBIndirecta.Text <> " " Then
                Call ButtonBIndirecta_Click(sender, e)
            End If
            If TxtProteinas.Text <> " " Then
                Call ButtonProteinas_Click(sender, e)
            End If

            If TxtPLCL.Text <> " " Then
                Call ButtonPLCL_Click(sender, e)
            End If

            If TxtLDH.Text <> " " Then
                Call ButtonLDH_Click(sender, e)
            End If
            If TxtLipasa.Text <> " " Then
                Call ButtonLipasa_Click(sender, e)
            End If
            If TxtAmilasa.Text <> " " Then
                Call ButtonAmilasa_Click(sender, e)
            End If




            If TxtCPK.Text <> " " Then
                Call ButtonCPK_Click(sender, e)
            End If
            If TxtCK.Text <> " " Then
                Call ButtonCK_Click(sender, e)
            End If
            If TxtCalcio.Text <> " " Then
                Call ButtonCalcio_Click(sender, e)
            End If
            If TxtTroponina.Text <> " " Then
                Call ButtonTroponina_Click(sender, e)
            End If
            If TxtSodio.Text <> " " Then
                Call ButtonSodio_Click(sender, e)
            End If
            If TxtMagnesio.Text <> " " Then
                Call ButtonMagnesio_Click(sender, e)
            End If
            If TxtFosforo.Text <> " " Then
                Call ButtonFosforo_Click(sender, e)
            End If

            If TxtPotasio.Text <> " " Then
                Call ButtonPotasio_Click(sender, e)
            End If

            If TxtCloruro.Text <> " " Then
                Call ButtonCloruro_Click(sender, e)
            End If
            If TxtGGT.Text <> " " Then
                Call ButtonGGT_Click(sender, e)
            End If
            If TxtHB.Text <> " " Then
                Call ButtonHB_Click(sender, e)
            End If






            For i As Integer = 0 To DataGridView1.Rows.Count - 2

                Me.Quimica_SanguineaTableAdapter.InsertQueryQuimica(TxtMuestra.Text, TxtIdentidad.Text, TxtPaciente.Text, TxtEdad.Text, TxtSexo.Text, TxtReferencia.Text, TxtFecha.Text, ((DataGridView1.Rows(i).Cells(1).Value)), ((DataGridView1.Rows(i).Cells(2).Value)), ((DataGridView1.Rows(i).Cells(3).Value)), TxtNota.Text)
                ' MsgBox(DatagridView1.Rows(i).Cells(0).Value & " detalle factura guardado")
                'txtMuestra.Text = Query.Id() + 1
            Next



            MessageBox.Show("Los Datos fueron agregados con exito", "Datos Guardados...")

            Imprimir_Examen(TxtMuestra.Text)


            Limpiar()



        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Imprimir_Examen(TextBox1.Text)
    End Sub

    Private Sub LlenarDsReporteExamen(ByVal strruta As String, ByVal Ids As String)

        ID = Ids

        Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
        Dim ta As New SystemLetonaDataSetTableAdapters.Quimica_SanguineaTableAdapter
        Dim ta2 As New SystemLetonaDataSetTableAdapters.Quimica_SanguineaTableAdapter

        Try

            ta.FillByMuestra(mids.Quimica_Sanguinea, ID)


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

            Rruta = "C:\SystemLetona\CrysQuimica.rpt"

            LlenarDsReporteExamen(Rruta, Id) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


        End If
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        O_Quimica.ShowDialog()

    End Sub
End Class