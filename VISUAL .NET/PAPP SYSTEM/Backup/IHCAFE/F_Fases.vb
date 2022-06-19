Public Class F_Fases

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If ComboBox1.Text = "1" Then
            F_Fase1.Show()
        End If
        If ComboBox1.Text = "2" Then
            F_Fase2.Show()
        End If
        If ComboBox1.Text = "3" Then
            F_Fase3.Show()
        End If
        If ComboBox1.Text = "4" Then
            F_Fase4.Show()
        End If
        If ComboBox1.Text = "5" Then
            F_Fase5.Show()
        End If
        If ComboBox1.Text = "6" Then
            F_Fase6.Show()
        End If
        If ComboBox1.Text = "7" Then
            F_Fase7.Show()
        End If
        If ComboBox1.Text = "8" Then
            F_Fase8.Show()
        End If
        If ComboBox1.Text = "9" Then
            F_Fase9.Show()
        End If
        If ComboBox1.Text = "10" Then
            F_Fase10.Show()
        End If
        Me.Hide()

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Height = 45
        PictureBox3.Width = 45
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Height = 50
        PictureBox3.Width = 50
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        '  F_Menu2.Show()


    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Height = 45
        PictureBox2.Width = 45
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Height = 50
        PictureBox2.Width = 50
    End Sub

    Private Sub F_Fases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim glass As New rtaGlassEffectsLib.rtaGlassEffect


        'glass.TopBarSize = 60

        'glass.ShowEffect(Me)

        'glass.BottomBarSize = 10
        'glass.LeftBarSize = 10
        'glass.RightBarSize = 10
        'glass.ShowEffect(Me, Label2, PictureBox1)

    End Sub
End Class