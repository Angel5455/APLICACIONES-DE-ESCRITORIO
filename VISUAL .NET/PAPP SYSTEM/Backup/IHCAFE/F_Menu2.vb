Imports System.IO

Public Class F_Menu2

    Private Sub F_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim glass As New rtaGlassEffectsLib.rtaGlassEffect


        glass.TopBarSize = 100

        glass.ShowEffect(Me)

        glass.BottomBarSize = 30
        glass.LeftBarSize = 30
        glass.RightBarSize = 30
        glass.ShowEffect(Me, Label1, PictureBox1)



        'group.Visible = False
        'GroupBox1.Visible = False


    End Sub




    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        F_Fases.Show()

    End Sub


    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        F_Ventanas.Show()

    End Sub
End Class