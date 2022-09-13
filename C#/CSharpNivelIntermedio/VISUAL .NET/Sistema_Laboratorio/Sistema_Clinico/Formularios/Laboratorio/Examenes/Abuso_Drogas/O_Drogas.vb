Public Class O_Drogas
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If CheckBoxC.Checked Then
            F_Drogas.PanelCocaina.Visible = True
        Else
            F_Drogas.PanelCocaina.Visible = False
            F_Drogas.TxtCocaina.Text = ""

        End If

        If CheckBoxM.Checked Then
            F_Drogas.PanelMarihuana.Visible = True
        Else
            F_Drogas.PanelMarihuana.Visible = False
            F_Drogas.TxtMarihuana.Text = ""
        End If

        If CheckBoxA.Checked Then
            F_Drogas.PanelAnfetaminas.Visible = True
        Else
            F_Drogas.PanelAnfetaminas.Visible = False
            F_Drogas.TxtAnfetamina.Text = ""
        End If


        If CheckBoxO.Checked Then
            F_Drogas.PanelOpiaseos.Visible = True
        Else
            F_Drogas.PanelOpiaseos.Visible = False
            F_Drogas.TxtOpiaseos.Text = ""
        End If

        If CheckBoxB.Checked Then
            F_Drogas.PanelBenzo.Visible = True
        Else
            F_Drogas.PanelBenzo.Visible = False
            F_Drogas.TxtBenzo.Text = ""
        End If
        Me.Close()

    End Sub
End Class