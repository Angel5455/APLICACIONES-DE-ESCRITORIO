Public Class F_PreciosDiseños

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        lblPrecio.Text = My.Settings.MySimple
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        lblPrecio.Text = My.Settings.MyNormal
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        lblPrecio.Text = My.Settings.MyPremiun
    End Sub

    Private Sub F_PreciosDiseños_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblPrecio.Text = My.Settings.MySimple
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If RadioButton2.Checked = True Then
            My.Settings.MySimple = lblPrecio.Text
            My.Settings.Save()
            My.Settings.Reload()
            MsgBox("DISEÑO SIMPLE ACTUALIZADO", MsgBoxStyle.Exclamation, "CREATIVOS")
        End If

        If RadioButton1.Checked = True Then
            My.Settings.MyNormal = lblPrecio.Text
            My.Settings.Save()
            My.Settings.Reload()
            MsgBox("PRECIO DISEÑO NORMAL ACTUALIZADO", MsgBoxStyle.Exclamation, "CREATIVOS")
        End If

        If RadioButton3.Checked = True Then
            My.Settings.MyNormal = lblPrecio.Text
            My.Settings.Save()
            My.Settings.Reload()
            MsgBox("PRECIO DISEÑO PREMIUM ACTUALIZADO", MsgBoxStyle.Exclamation, "CREATIVOS")
        End If
    End Sub

    Private Sub lblPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPrecio.Click
        Dim PRECIO As String

        PRECIO = InputBox("INGRESE EL VALOR DEL DISEÑO")

        If PRECIO = "" Then
            lblPrecio.Text = "0"
        Else
            lblPrecio.Text = PRECIO
        End If
    End Sub
End Class