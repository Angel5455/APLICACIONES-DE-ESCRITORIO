Public Class O_CTOG
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBoxC.Checked Then
            F_CTOG.PanelAyunas.Visible = True
            F_CTOG.TxtAyunas.Text = ""
        Else
            F_CTOG.PanelAyunas.Visible = False
            F_CTOG.TxtAyunas.Text = ""

        End If

        If CheckBoxM.Checked Then
            F_CTOG.Panel1Hora.Visible = True
            F_CTOG.Txt1Hora.Text = ""
        Else
            F_CTOG.Panel1Hora.Visible = False
            F_CTOG.Txt1Hora.Text = ""
        End If

        If CheckBoxA.Checked Then
            F_CTOG.Panel2Horas.Visible = True
            F_CTOG.Txt2Horas.Text = ""
        Else
            F_CTOG.Panel2Horas.Visible = False
            F_CTOG.Txt2Horas.Text = ""
        End If


        If CheckBoxO.Checked Then
            F_CTOG.Panel3Horas.Visible = True
            F_CTOG.Txt3Horas.Text = ""
        Else
            F_CTOG.Panel3Horas.Visible = False
            F_CTOG.Txt3Horas.Text = ""
        End If


        Me.Close()
    End Sub
End Class