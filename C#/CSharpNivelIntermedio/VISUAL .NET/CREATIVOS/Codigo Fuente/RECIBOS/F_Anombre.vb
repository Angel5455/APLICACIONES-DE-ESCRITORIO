Public Class F_Anombre

  
    Private Sub txtNombre_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles txtNombre.DragEnter

    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call Button1_Click(sender, e)
        End If


        
    End Sub


    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        F_Recibo.lblCliente.Text = txtNombre.Text

    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


            F_Recibo.lblCliente.Text = txtNombre.Text


            Me.Close()
            F_Cantidad.Show()

    

    End Sub

    Private Sub F_Anombre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class