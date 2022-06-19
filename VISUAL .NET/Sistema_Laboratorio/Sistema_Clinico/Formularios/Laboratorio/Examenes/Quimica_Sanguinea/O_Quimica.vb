Public Class O_Quimica
    Private Sub O_Quimica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBoxGlucosa.Checked Then
            F_Quimica.PanelGlucosa.Visible = True
            F_Quimica.TxtGlucosa.Text = ""
        Else
            F_Quimica.PanelGlucosa.Visible = False
            F_Quimica.TxtGlucosa.Text = " "

        End If

        If CheckBoxGlucosaPP.Checked Then
            F_Quimica.PanelGlucosaPP.Visible = True
            F_Quimica.TxtGlucosaPP.Text = " "
        Else
            F_Quimica.PanelGlucosaPP.Visible = False
            F_Quimica.TxtGlucosaPP.Text = " "
        End If

        If CheckBoxTrigli.Checked Then
            F_Quimica.PanelTrigli.Visible = True
            F_Quimica.TxtTrigli.Text = " "
        Else
            F_Quimica.PanelTrigli.Visible = False
            F_Quimica.TxtTrigli.Text = " "
        End If


        If CheckBoxAcido.Checked Then
            F_Quimica.PanelAcido.Visible = True
            F_Quimica.TxtAcido.Text = ""
        Else
            F_Quimica.PanelAcido.Visible = False
            F_Quimica.TxtAcido.Text = " "
        End If

        If CheckBoxUrea.Checked Then
            F_Quimica.PanelUrea.Visible = True
            F_Quimica.TxtUrea.Text = ""
        Else
            F_Quimica.PanelUrea.Visible = False
            F_Quimica.TxtUrea.Text = " "

        End If

        If CheckBoxCreatinina.Checked Then
            F_Quimica.PanelCreatinina.Visible = True
            F_Quimica.TxtCreatinina.Text = " "
        Else
            F_Quimica.PanelCreatinina.Visible = False
            F_Quimica.TxtCreatinina.Text = " "
        End If

        If CheckBoxBun.Checked Then
            F_Quimica.PanelBun.Visible = True
            F_Quimica.TxtBun.Text = " "
        Else
            F_Quimica.PanelBun.Visible = False
            F_Quimica.TxtBun.Text = " "
        End If


        If CheckBoxTGO.Checked Then
            F_Quimica.PanelTGO.Visible = True
            F_Quimica.TxtTGO.Text = " "
        Else
            F_Quimica.PanelTGO.Visible = False
            F_Quimica.TxtTGO.Text = " "
        End If

        If CheckBoxTGP.Checked Then
            F_Quimica.PanelTGP.Visible = True
            F_Quimica.TxtTGP.Text = ""
        Else
            F_Quimica.PanelTGP.Visible = False
            F_Quimica.TxtTGP.Text = " "

        End If

        If CheckBoxFosfatasa.Checked Then
            F_Quimica.PanelFosfatasa.Visible = True
            F_Quimica.TxtFosfata.Text = " "
        Else
            F_Quimica.PanelFosfatasa.Visible = False
            F_Quimica.TxtFosfata.Text = " "
        End If

        If CheckBoxCTotal.Checked Then
            F_Quimica.PanelCTotal.Visible = True
            F_Quimica.TxtCTotal.Text = " "
        Else
            F_Quimica.PanelCTotal.Visible = False
            F_Quimica.TxtCTotal.Text = " "
        End If


        If CheckBoxHDL.Checked Then
            F_Quimica.PanelHDL.Visible = True
            F_Quimica.TxtHDL.Text = ""
        Else
            F_Quimica.PanelHDL.Visible = False
            F_Quimica.TxtHDL.Text = " "
        End If

        If CheckBoxLDL.Checked Then
            F_Quimica.PanelLDL.Visible = True
            F_Quimica.TxtLDL.Text = ""
        Else
            F_Quimica.PanelLDL.Visible = False
            F_Quimica.TxtLDL.Text = " "
        End If

        If CheckBoxVLDL.Checked Then
            F_Quimica.PanelVLDL.Visible = True
            F_Quimica.TxtVLDL.Text = ""
        Else
            F_Quimica.PanelVLDL.Visible = False
            F_Quimica.TxtVLDL.Text = " "

        End If

        If CheckBoxBTotal.Checked Then
            F_Quimica.PanelBTotal.Visible = True
            F_Quimica.TxtBTotal.Text = " "
        Else
            F_Quimica.PanelBTotal.Visible = False
            F_Quimica.TxtBTotal.Text = " "
        End If

        If CheckBoxBDirecta.Checked Then
            F_Quimica.PanelBDirecta.Visible = True
            F_Quimica.TxtBDirecta.Text = " "
        Else
            F_Quimica.PanelBDirecta.Visible = False
            F_Quimica.TxtBDirecta.Text = " "
        End If

        If CheckBoxBIndirecta.Checked Then
            F_Quimica.PanelBIndirecta.Visible = True
            F_Quimica.TxtBIndirecta.Text = " "
        Else
            F_Quimica.PanelBIndirecta.Visible = False
            F_Quimica.TxtBIndirecta.Text = " "
        End If


        If CheckBoxProteinas.Checked Then
            F_Quimica.PanelProteinas.Visible = True
            F_Quimica.TxtProteinas.Text = ""
        Else
            F_Quimica.PanelProteinas.Visible = False
            F_Quimica.TxtProteinas.Text = " "
        End If

        If CheckBoxAlbumina.Checked Then
            F_Quimica.PanelAlbumina.Visible = True
            F_Quimica.TxtAlbumina.Text = ""
        Else
            F_Quimica.PanelAlbumina.Visible = False
            F_Quimica.TxtAlbumina.Text = " "

        End If

        If CheckBoxPLCL.Checked Then
            F_Quimica.PanelPLCL.Visible = True
            F_Quimica.TxtPLCL.Text = " "
        Else
            F_Quimica.PanelPLCL.Visible = False
            F_Quimica.TxtPLCL.Text = " "
        End If

        If CheckBoxAmilasa.Checked Then
            F_Quimica.PanelAmilasa.Visible = True
            F_Quimica.TxtAmilasa.Text = " "
        Else
            F_Quimica.PanelAmilasa.Visible = False
            F_Quimica.TxtAmilasa.Text = " "
        End If


        If CheckBoxLipasa.Checked Then
            F_Quimica.PanelLipasa.Visible = True
            F_Quimica.TxtLipasa.Text = ""
        Else
            F_Quimica.PanelLipasa.Visible = False
            F_Quimica.TxtLipasa.Text = " "
        End If

        If CheckBoxLDH.Checked Then
            F_Quimica.PanelLDH.Visible = True
            F_Quimica.TxtLDH.Text = ""
        Else
            F_Quimica.PanelLDH.Visible = False
            F_Quimica.TxtLDH.Text = " "

        End If

        If CheckBoxCPK.Checked Then
            F_Quimica.PanelCPK.Visible = True
            F_Quimica.TxtCPK.Text = " "
        Else
            F_Quimica.PanelCPK.Visible = False
            F_Quimica.TxtCPK.Text = " "
        End If

        If CheckBoxCK.Checked Then
            F_Quimica.PanelCK.Visible = True
            F_Quimica.TxtCK.Text = " "
        Else
            F_Quimica.PanelCK.Visible = False
            F_Quimica.TxtCK.Text = " "
        End If


        If CheckBoxTroponina.Checked Then
            F_Quimica.PanelTroponina.Visible = True
            F_Quimica.TxtTroponina.Text = ""
        Else
            F_Quimica.PanelTroponina.Visible = False
            F_Quimica.TxtTroponina.Text = " "
        End If

        If CheckBoxCalcio.Checked Then
            F_Quimica.PanelCalcio.Visible = True
            F_Quimica.TxtCalcio.Text = ""
        Else
            F_Quimica.PanelCalcio.Visible = False
            F_Quimica.TxtCalcio.Text = " "
        End If

        If CheckBoxFosforo.Checked Then
            F_Quimica.PanelFosforo.Visible = True
            F_Quimica.TxtFosforo.Text = ""
        Else
            F_Quimica.PanelFosforo.Visible = False
            F_Quimica.TxtFosforo.Text = " "

        End If

        If CheckBoxMagnesio.Checked Then
            F_Quimica.PanelMagnesio.Visible = True
            F_Quimica.TxtMagnesio.Text = " "
        Else
            F_Quimica.PanelMagnesio.Visible = False
            F_Quimica.TxtMagnesio.Text = " "
        End If

        If CheckBoxSodio.Checked Then
            F_Quimica.PanelSodio.Visible = True
            F_Quimica.TxtSodio.Text = " "
        Else
            F_Quimica.PanelSodio.Visible = False
            F_Quimica.TxtSodio.Text = " "
        End If


        If CheckBoxCloruro.Checked Then
            F_Quimica.PanelCloruro.Visible = True
            F_Quimica.TxtCloruro.Text = ""
        Else
            F_Quimica.PanelCloruro.Visible = False
            F_Quimica.TxtCloruro.Text = " "
        End If

        If CheckBoxPotasio.Checked Then
            F_Quimica.PanelPotasio.Visible = True
            F_Quimica.TxtPotasio.Text = ""
        Else
            F_Quimica.PanelPotasio.Visible = False
            F_Quimica.TxtPotasio.Text = " "

        End If

        If CheckBoxGGT.Checked Then
            F_Quimica.PanelGGT.Visible = True
            F_Quimica.TxtGGT.Text = " "
        Else
            F_Quimica.PanelGGT.Visible = False
            F_Quimica.TxtGGT.Text = " "
        End If

        If CheckBoxHB.Checked Then
            F_Quimica.PanelHB.Visible = True
            F_Quimica.TxtHB.Text = " "
        Else
            F_Quimica.PanelHB.Visible = False
            F_Quimica.TxtHB.Text = " "
        End If


        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class