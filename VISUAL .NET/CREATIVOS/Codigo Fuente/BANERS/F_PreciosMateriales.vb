Public Class F_PreciosMateriales

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.Text = "BACK LIGTH" Then
            lblPrecio.Text = My.Settings.MyBackLigth
        End If

        If ComboBox1.Text = "COROPLAST" Then
            lblPrecio.Text = My.Settings.MyCoroplast
        End If

        If ComboBox1.Text = "LONA" Then
            lblPrecio.Text = My.Settings.MyLona
        End If

        If ComboBox1.Text = "LONA TRASLUCIDA" Then
            lblPrecio.Text = My.Settings.MyLonaT
        End If

        If ComboBox1.Text = "MICRO" Then
            lblPrecio.Text = My.Settings.MyMicro
        End If

        If ComboBox1.Text = "PVC" Then
            lblPrecio.Text = My.Settings.MyPvc
        End If

        If ComboBox1.Text = "REFLECTIVO" Then
            lblPrecio.Text = My.Settings.MyReflectivo
        End If

        If ComboBox1.Text = "VINIL" Then
            lblPrecio.Text = My.Settings.MyVinil
        End If
    End Sub

    Private Sub lblPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPrecio.Click

        Dim PRECIO As String

        PRECIO = InputBox("INGRESE EL VALOR DEL " & ComboBox1.Text)
        
        If PRECIO = "" Then
            lblPrecio.Text = "0"
        Else
            lblPrecio.Text = PRECIO
        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If ComboBox1.Text = "BACK LIGTH" Then

            My.Settings.MyBackLigth = lblPrecio.Text
            My.Settings.Save()
            My.Settings.Reload()

            MsgBox("PRECIO DEL " & ComboBox1.Text & " ACTUALIZADO", MsgBoxStyle.Exclamation, "CREATIVOS")

        End If

        If ComboBox1.Text = "COROPLAST" Then
            My.Settings.MyCoroplast = lblPrecio.Text
            My.Settings.Save()
            My.Settings.Reload()

            MsgBox("PRECIO DEL " & ComboBox1.Text & " ACTUALIZADO", MsgBoxStyle.Exclamation, "CREATIVOS")

        End If

        If ComboBox1.Text = "LONA" Then
            My.Settings.MyLona = lblPrecio.Text
            My.Settings.Save()
            My.Settings.Reload()

            MsgBox("PRECIO DEL " & ComboBox1.Text & " ACTUALIZADO", MsgBoxStyle.Exclamation, "CREATIVOS")

        End If

        If ComboBox1.Text = "LONA TRASLUCIDA" Then
            My.Settings.MyLonaT = lblPrecio.Text
            My.Settings.Save()
            My.Settings.Reload()

            MsgBox("PRECIO DEL " & ComboBox1.Text & " ACTUALIZADO", MsgBoxStyle.Exclamation, "CREATIVOS")

        End If

        If ComboBox1.Text = "MICRO" Then
            My.Settings.MyMicro = lblPrecio.Text
            My.Settings.Save()
            My.Settings.Reload()

            MsgBox("PRECIO DEL " & ComboBox1.Text & " ACTUALIZADO", MsgBoxStyle.Exclamation, "CREATIVOS")

        End If

        If ComboBox1.Text = "PVC" Then
            My.Settings.MyPvc = lblPrecio.Text
            My.Settings.Save()
            My.Settings.Reload()

            MsgBox("PRECIO DEL " & ComboBox1.Text & " ACTUALIZADO", MsgBoxStyle.Exclamation, "CREATIVOS")

        End If

        If ComboBox1.Text = "REFLECTIVO" Then
            My.Settings.MyReflectivo = lblPrecio.Text
            My.Settings.Save()
            My.Settings.Reload()

            MsgBox("PRECIO DEL " & ComboBox1.Text & " ACTUALIZADO", MsgBoxStyle.Exclamation, "CREATIVOS")

        End If

        If ComboBox1.Text = "VINIL" Then
            My.Settings.MyVinil = lblPrecio.Text
            My.Settings.Save()
            My.Settings.Reload()

            MsgBox("PRECIO DEL " & ComboBox1.Text & " ACTUALIZADO", MsgBoxStyle.Exclamation, "CREATIVOS")

        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class