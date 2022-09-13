Public Class F_ExploradorWeb

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        WebBrowser1.GoBack()

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Height = 23
        PictureBox1.Width = 23


    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Height = 26
        PictureBox1.Width = 26
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Height = 23
        PictureBox2.Width = 23
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Height = 26
        PictureBox2.Width = 26
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub OK_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK.MouseEnter
        OK.Height = 23
        OK.Width = 23
    End Sub

    Private Sub OK_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK.MouseLeave
        OK.Height = 26
        OK.Width = 26
    End Sub

    Private Sub F_ExploradorWeb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        WebBrowser1.Navigate("www.hotmail.com")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        TextBox1.Text = WebBrowser1.Url.ToString

    End Sub
End Class