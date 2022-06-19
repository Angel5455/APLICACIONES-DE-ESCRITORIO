Public Class F_MenuReportes

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        If ComboBox1.Text = "1" Then

            R_Fase1.Show()
            Me.Hide()

        End If

        If ComboBox1.Text = "2" Then

            R_Fase2.Show()
            Me.Hide()

        End If

        If ComboBox1.Text = "3" Then

            R_Fase3.Show()
            Me.Hide()

        End If

        If ComboBox1.Text = "4" Then

            R_Fase4.Show()
            Me.Hide()

        End If

        If ComboBox1.Text = "5" Then

            R_Fase5.Show()
            Me.Hide()

        End If
        If ComboBox1.Text = "6" Then

            R_Fase6.Show()
            Me.Hide()

        End If

        If ComboBox1.Text = "7" Then

            R_Fase7.Show()
            Me.Hide()

        End If

        If ComboBox1.Text = "8" Then

            R_Fase8.Show()
            Me.Hide()

        End If

        If ComboBox1.Text = "9" Then

            R_Fase9.Show()
            Me.Hide()

        End If

        If ComboBox1.Text = "10" Then

            R_Fase10.Show()
            Me.Hide()

        End If
    End Sub
End Class