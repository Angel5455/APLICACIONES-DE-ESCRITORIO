Public Class F_Concepto

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
   


        F_Recibo.lblConcepto.Text = txtConcepto.Text

        Me.Close()
            F_Recibo.Show()

    End Sub

    Private Sub txtConcepto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConcepto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call Button1_Click(sender, e)
        End If
    End Sub

    Private Sub txtConcepto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConcepto.TextChanged

    End Sub
End Class