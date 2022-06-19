Public Class O_Hematologia
    Private Sub CheckBoxM_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxHema.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBoxVes.Checked Then
            F_Hematologia.PanelVes.Visible = True
            F_Hematologia.TxtVes.Text = ""
        Else
            F_Hematologia.PanelVes.Visible = False
            F_Hematologia.TxtVes.Text = " "

        End If

        If CheckBoxHema.Checked Then
            F_Hematologia.PanelHematocrito.Visible = True
            F_Hematologia.TxtHematocrito.Text = " "
        Else
            F_Hematologia.PanelHematocrito.Visible = False
            F_Hematologia.TxtHematocrito.Text = " "
        End If

        If CheckBoxHemo.Checked Then
            F_Hematologia.PanelHemoglobina.Visible = True
            F_Hematologia.TxtHemoglobina.Text = " "
        Else
            F_Hematologia.PanelHemoglobina.Visible = False
            F_Hematologia.TxtHemoglobina.Text = " "
        End If


        If CheckBoxTP.Checked Then
            F_Hematologia.PanelProto.Visible = True
            F_Hematologia.TxtProto.Text = ""
        Else
            F_Hematologia.PanelProto.Visible = False
            F_Hematologia.TxtProto.Text = " "
        End If

        If CheckBoxTT.Checked Then
            F_Hematologia.PanelTrombo.Visible = True
            F_Hematologia.TxtTrombo.Text = ""
        Else
            F_Hematologia.PanelTrombo.Visible = False
            F_Hematologia.TxtTrombo.Text = " "

        End If

        If CheckBoxTC.Checked Then
            F_Hematologia.PanelCoagulacion.Visible = True
            F_Hematologia.TxtCoagulacion.Text = " "
        Else
            F_Hematologia.PanelCoagulacion.Visible = False
            F_Hematologia.TxtCoagulacion.Text = " "
        End If

        If CheckBoxRC.Checked Then
            F_Hematologia.PanelRetraccion.Visible = True
            F_Hematologia.TxtRetraccion.Text = " "
        Else
            F_Hematologia.PanelRetraccion.Visible = False
            F_Hematologia.TxtRetraccion.Text = " "
        End If


        If CheckBoxTSD.Checked Then
            F_Hematologia.PanelSangradoD.Visible = True
            F_Hematologia.TxtSangradoD.Text = ""
        Else
            F_Hematologia.PanelSangradoD.Visible = False
            F_Hematologia.TxtSangradoD.Text = " "
        End If

        If CheckBoxTSI.Checked Then
            F_Hematologia.PanelSangradoI.Visible = True
            F_Hematologia.TxtSangradoI.Text = ""
        Else
            F_Hematologia.PanelSangradoI.Visible = False
            F_Hematologia.TxtSangradoI.Text = " "

        End If

        If CheckBoxRRN.Checked Then
            F_Hematologia.PanelRRN.Visible = True
            F_Hematologia.TxtRRN.Text = " "
        Else
            F_Hematologia.PanelRRN.Visible = False
            F_Hematologia.TxtRRN.Text = " "
        End If

        If CheckBoxRA.Checked Then
            F_Hematologia.PanelRA.Visible = True
            F_Hematologia.TxtRA.Text = " "
        Else
            F_Hematologia.PanelRA.Visible = False
            F_Hematologia.TxtRA.Text = " "
        End If


        If CheckBoxINR.Checked Then
            F_Hematologia.PanelINR.Visible = True
            F_Hematologia.TxtINR.Text = ""
        Else
            F_Hematologia.PanelINR.Visible = False
            F_Hematologia.TxtINR.Text = " "
        End If

        If CheckBoxTyR.Checked Then
            F_Hematologia.PanelTipo.Visible = True
            F_Hematologia.TxtTipo.Text = ""
        Else
            F_Hematologia.PanelTipo.Visible = False
            F_Hematologia.TxtTipo.Text = " "
        End If


        Me.Close()


        Me.Close()


        Me.Close()
    End Sub

    Private Sub CheckBoxVes_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxVes.CheckedChanged

    End Sub
End Class