Public Class F_Codigo

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call ok_Click(sender, e)
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtCodigo.MaskInputRejected

    End Sub

    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click

        If txtCodigo.Text = "11-1111" Then

            F_EdicionC.lblOpcion.Text = lblOpcion.Text
            F_EdicionC.Show()
            Me.Close()


        Else

            MsgBox("Codigo incorrecto", MsgBoxStyle.Exclamation, "CREATIVOS")

        End If


    End Sub
End Class