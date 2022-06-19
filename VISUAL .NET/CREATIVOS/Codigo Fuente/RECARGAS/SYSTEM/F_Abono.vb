Public Class F_Abono

    Public abono As Integer

    Private Sub txtcantidad_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcantidad.Enter
      
    End Sub


    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress

        If Val(lblOpcion.Text) = 1 Then


            abono = Val(F_ControlRecargas.txtCantidad.Text)

            If Val(txtcantidad.Text) > abono Then

                MsgBox("Abono sobrepasa a la cantidad", MsgBoxStyle.Exclamation, "Error")
                txtcantidad.Clear()

            End If

            If e.KeyChar = ChrW(Keys.Enter) Then
                Call ok_Click(sender, e)
            End If


        End If

        If Val(lblOpcion.Text) = 2 Then


            abono = Val(F_Control_Recargas_Claro.txtCantidad.Text)

            If Val(txtcantidad.Text) > abono Then

                MsgBox("Abono sobrepasa a la cantidad", MsgBoxStyle.Exclamation, "Error")
                txtcantidad.Clear()

            End If

            If e.KeyChar = ChrW(Keys.Enter) Then
                Call ok_Click(sender, e)
            End If


        End If

    End Sub

    Private Sub txtcantidad_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtcantidad.MaskInputRejected

    End Sub

    Private Sub F_Abono_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub txtcantidad_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcantidad.MouseEnter
  
    End Sub

    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click

        If Val(lblOpcion.Text) = 1 Then


            abono = Val(F_ControlRecargas.lblMonto.Text)

            Dim total As Integer

            total = abono - Val(txtcantidad.Text)


            F_ControlRecargas.lblMonto.Text = total

            Dim efectivo As Integer

            efectivo = Val(F_ControlRecargas.lblEfectivo.Text)

            F_ControlRecargas.lblEfectivo.Text = efectivo + Val(txtcantidad.Text)


            F_ControlRecargas.Button3.Visible = False
            F_ControlRecargas.btnGuardar.Enabled = True

            Me.Close()

        End If

        If Val(lblOpcion.Text) = 2 Then


            abono = Val(F_Control_Recargas_Claro.lblMonto.Text)

            Dim total As Integer

            total = abono - Val(txtcantidad.Text)


            F_Control_Recargas_Claro.lblMonto.Text = total

            Dim efectivo As Integer

            efectivo = Val(F_Control_Recargas_Claro.lblEfectivo.Text)

            F_Control_Recargas_Claro.lblEfectivo.Text = efectivo + Val(txtcantidad.Text)


            F_Control_Recargas_Claro.Button3.Visible = False
            F_Control_Recargas_Claro.btnGuardar.Enabled = True

            Me.Close()

        End If


    End Sub
End Class