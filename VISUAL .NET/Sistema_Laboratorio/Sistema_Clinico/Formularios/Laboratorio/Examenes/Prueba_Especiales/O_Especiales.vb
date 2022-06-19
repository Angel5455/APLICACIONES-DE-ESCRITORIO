Public Class O_Especiales
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBoxTSH.Checked Then
            F_PEspeciales.PanelTSH.Visible = True
            F_PEspeciales.TxtTSH.Text = ""
        Else
            F_PEspeciales.PanelTSH.Visible = False
            F_PEspeciales.TxtTSH.Text = " "

        End If

        If CheckBoxT4.Checked Then
            F_PEspeciales.PanelT4.Visible = True
            F_PEspeciales.TxtT4.Text = " "
        Else
            F_PEspeciales.PanelT4.Visible = False
            F_PEspeciales.TxtT4.Text = " "
        End If

        If CheckBoxT4_Libre.Checked Then
            F_PEspeciales.PanelT4_Libre.Visible = True
            F_PEspeciales.TxtT4_Libre.Text = " "
        Else
            F_PEspeciales.PanelT4_Libre.Visible = False
            F_PEspeciales.TxtT4_Libre.Text = " "
        End If


        If CheckBoxInsulina.Checked Then
            F_PEspeciales.PanelInsulina.Visible = True
            F_PEspeciales.TxtInsulina.Text = ""
        Else
            F_PEspeciales.PanelInsulina.Visible = False
            F_PEspeciales.TxtInsulina.Text = " "
        End If

        If CheckBoxInsulina2.Checked Then
            F_PEspeciales.PanelInsulina2.Visible = True
            F_PEspeciales.TxtInsulina2.Text = ""
        Else
            F_PEspeciales.PanelInsulina2.Visible = False
            F_PEspeciales.TxtInsulina2.Text = " "
        End If


        If CheckBoxTesto.Checked Then
            F_PEspeciales.PanelTesto.Visible = True
            F_PEspeciales.TxtTesto.Text = " "
        Else
            F_PEspeciales.PanelTesto.Visible = False
            F_PEspeciales.TxtTesto.Text = " "
        End If
        If CheckBoxAnti.Checked Then
            F_PEspeciales.PanelAnti.Visible = True
            F_PEspeciales.TxtAnti.Text = " "
        Else
            F_PEspeciales.PanelAnti.Visible = False
            F_PEspeciales.TxtAnti.Text = " "
        End If
        If CheckBoxProlactina.Checked Then
            F_PEspeciales.PanelProlactina.Visible = True
            F_PEspeciales.TxtProlactina.Text = " "
        Else
            F_PEspeciales.PanelProlactina.Visible = False
            F_PEspeciales.TxtProlactina.Text = " "
        End If

        If CheckBoxFSH.Checked Then
            F_PEspeciales.PanelFSH.Visible = True
            F_PEspeciales.TxtFSH.Text = " "
        Else
            F_PEspeciales.PanelFSH.Visible = False
            F_PEspeciales.TxtFSH.Text = " "
        End If

        If CheckBoxT3.Checked Then
            F_PEspeciales.PanelT3.Visible = True
            F_PEspeciales.TxtT3.Text = " "
        Else
            F_PEspeciales.PanelT3.Visible = False
            F_PEspeciales.TxtT3.Text = " "
        End If

        If CheckBoxT3_Libre.Checked Then
            F_PEspeciales.PanelT3_Libre.Visible = True
            F_PEspeciales.TxtT3_Libre.Text = " "
        Else
            F_PEspeciales.PanelT3_Libre.Visible = False
            F_PEspeciales.TxtT3_Libre.Text = " "
        End If



        Me.Close()


    End Sub

End Class