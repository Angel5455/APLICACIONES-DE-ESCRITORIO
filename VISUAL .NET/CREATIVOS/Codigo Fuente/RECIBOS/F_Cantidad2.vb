Public Class F_Cantidad2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        F_Recibo.lblCantidad.Text = txtCantidad.Text
        F_Recibo.lblAbono.Text = txtCantidad.Text
        F_Recibo.lblActual.Text = Val(F_Recibo.lblAnterior.Text) - Val(F_Recibo.lblAbono.Text)

        If Val(F_Recibo.lblActual.Text) = 0 Then

            F_Recibo.lblEstado.Text = "CANCELADO"
        Else

            F_Recibo.lblEstado.Text = "PENDIENTE"
        End If
        '   F_Recibo.lblAnterior.Text = String.Format(txtCantidad.Text, 2)




        '   F_Recibo.lblAnterior.Text = FormatCurrency(txtCantidad.Text, 2)
        Dim lets As New Numalet
        lets.MascaraSalidaDecimal = "00/100" + " CENTAVOS"
        lets.SeparadorDecimalSalida = " LEMPIRAS CON "
        lets.ApocoparUnoParteEntera = True
        F_Recibo.lblLetras.Text = lets.ToCustomCardinal(Val(txtCantidad.Text)).ToUpper ' Donde se mostara el valor


        Me.Close()
        F_Recibo.Show()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
    
            If CheckBox1.Checked = True Then



            If Val(txtCantidad.Text) > Val(lblmonto.Text) Then

                MsgBox("La cantidad ingresada excede al monto del recibo", MsgBoxStyle.Critical, "CREATIVOS")
                txtCantidad.Clear()


            End If
            End If



        If CheckBox1.Checked = False Then
            txtCantidad.Text = lblmonto.Text
        Else
            txtCantidad.Clear()

        End If

    End Sub

    Private Sub F_Cantidad2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call Button1_Click(sender, e)
        End If

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged
        If Val(txtCantidad.Text) > Val(lblmonto.Text) Then

            MsgBox("La cantidad ingresada excede al monto del recibo", MsgBoxStyle.Critical, "CREATIVOS")
            txtCantidad.Clear()


        End If

    End Sub
End Class