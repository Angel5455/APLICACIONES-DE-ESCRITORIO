Public Class F_Ventanas

    Private Sub F_Ventanas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim glass As New rtaGlassEffectsLib.rtaGlassEffect


        glass.TopBarSize = 60

        glass.ShowEffect(Me)

        glass.BottomBarSize = 10
        glass.LeftBarSize = 10
        glass.RightBarSize = 10
        glass.ShowEffect(Me, Label2, PictureBox1)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        F_Menu2.TextBox1.Text = 1
        Me.Hide()


    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        F_Menu2.TextBox1.Text = 2
        Me.Hide()

    End Sub
End Class