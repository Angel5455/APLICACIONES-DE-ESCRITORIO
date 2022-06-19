Public Class F_Cantidad
    Public total As Double

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

            If CheckBox1.Checked = True Then

                F_Recibo.lblCantidad.Text = txtCantidad.Text
                'F_Recibo.lblAnterior.Text = txtCantidad.Text
                F_Recibo.lblAbono.Text = txtCantidad.Text
                F_Recibo.lblActual.Text = Val(F_Recibo.lblAnterior.Text) - Val(F_Recibo.lblAbono.Text)
                F_Recibo.lblEstado.Text = "PENDIENTE"

            Else

            F_Recibo.lblCantidad.Text = txtCantidad.Text
                F_Recibo.lblAnterior.Text = txtCantidad.Text
                F_Recibo.lblAbono.Text = 0
                F_Recibo.lblActual.Text = 0
                F_Recibo.lblEstado.Text = "CANCELADO"

        End If

        'F_Recibo.lbl_num.Text = FormatCurrency(txtCantidad.Text, 2))
            Dim lets As New Numalet
            lets.MascaraSalidaDecimal = "00/100" + " CENTAVOS"
            lets.SeparadorDecimalSalida = " LEMPIRAS CON "
            lets.ApocoparUnoParteEntera = True
            F_Recibo.lblLetras.Text = lets.ToCustomCardinal(Val(txtCantidad.Text)).ToUpper ' Donde se mostara el valor

        Me.Close()
            F_Concepto.Show()

    End Sub

    Private Sub txtCantidad_KeyPress(ByVal Sender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress

        If eventArgs.KeyChar = ChrW(Keys.Enter) Then
            Call Button1_Click(Sender, eventArgs)
        End If

        'If Char.IsDigit(e.KeyChar) Then
        'e.Handled = False
        '   Else
        '    e.Handled = True

        '    End If
        eventArgs.Handled = Fg_SoloNumeros(eventArgs.KeyChar, txtCantidad.Text & CChar(eventArgs.KeyChar))

    End Sub

    Function Fg_SoloNumeros(ByVal Digito As String, ByVal Texto As String) As Boolean
        Dim Dt_Entero As Integer = CInt(Asc(Digito))
        If Dt_Entero = 8 Then
            Fg_SoloNumeros = False
        Else
            If InStr("1234567890.", Digito) = 0 Then
                Fg_SoloNumeros = True
            ElseIf IsNumeric(Texto) = True Then
                Fg_SoloNumeros = False
            ElseIf IsNumeric(Texto) = False Then
                Fg_SoloNumeros = True
            End If
        End If
        Return Fg_SoloNumeros
    End Function


    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged

        If CheckBox1.Checked = True Then

            If Val(txtCantidad.Text) > total Then

                MsgBox("La cantidad ingresada excede al monto del recibo", MsgBoxStyle.Critical, "CREATIVOS")
                txtCantidad.Clear()
            End If
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Try
            If CheckBox1.Checked = True Then

                total = InputBox("Ingrese el monto total del recibo")
                F_Recibo.lblAnterior.Text = total

                If Val(txtCantidad.Text) > total Then

                    MsgBox("La cantidad ingresada excede al monto del recibo", MsgBoxStyle.Critical, "CREATIVOS")
                    txtCantidad.Clear()

                End If
            End If


        Catch ex As Exception

        End Try


    End Sub

    Private Sub F_Cantidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class