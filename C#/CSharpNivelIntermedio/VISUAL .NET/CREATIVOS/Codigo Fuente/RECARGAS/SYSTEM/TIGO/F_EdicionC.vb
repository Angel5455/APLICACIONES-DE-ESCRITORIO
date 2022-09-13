Public Class F_EdicionC
    Dim WithEvents queryconsultas As New dRecargas
    Dim conexion As New DataClasses1DataContext()
    Dim query

    Dim encontrado As Boolean

    Dim resultado As MsgBoxResult
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click
        If Val(lblOpcion.Text) = 1 Then

            F_ControlRecargas.lblSaldoAnterior.Text = txtcantidad.Text
            ' F_ControlRecargas.lblCompra.Text = txtcantidad.Text
            F_ControlRecargas.lblSaldoActual.Text = F_ControlRecargas.lblSaldoAnterior.Text



            'Call queryconsultas.insertar_controlR(F_ControlRecargas.txtId.Text, "Edicion de " & F_ControlRecargas.lblUsuario.Text, " ", 0, F_ControlRecargas.lblFecha.Text, F_ControlRecargas.lblHora.Text, 0, F_ControlRecargas.lblSaldoAnterior.Text, F_ControlRecargas.lblSaldoActual.Text, 0, F_ControlRecargas.lblCierre.Text)
            Call queryconsultas.insertar_controlR(1 & F_ControlRecargas.txtId.Text, "Edicion de " & F_Contraseña.txtusuario.Text, F_ControlRecargas.txtCelular.Text, 0, F_ControlRecargas.lblFecha.Text, F_ControlRecargas.lblHora.Text, 0, txtcantidad.Text, txtcantidad.Text, 0, 0, 0, 0, "EDICION DE SALDO", F_ControlRecargas.lblUsuario.Text, F_ControlRecargas.lblCierre.Text)


            F_ControlRecargas.txtId.Text = queryconsultas.numero_controlR().ToString

            My.Settings.TSaldoActual = txtcantidad.Text
            My.Settings.TSaldoAnterior = txtcantidad.Text

            My.Settings.Save()
            My.Settings.Reload()

        Else

            F_Control_Recargas_Claro.lblSaldoAnterior.Text = txtcantidad.Text
            ' F_ControlRecargas.lblCompra.Text = txtcantidad.Text
            F_Control_Recargas_Claro.lblSaldoActual.Text = F_Control_Recargas_Claro.lblSaldoAnterior.Text



            Call queryconsultas.insertar_controlRC(2 & F_Control_Recargas_Claro.txtId.Text, "Edicion de " & F_Contraseña.txtusuario.Text, F_Control_Recargas_Claro.txtCelular.Text, 0, F_Control_Recargas_Claro.lblFecha.Text, F_Control_Recargas_Claro.lblHora.Text, 0, txtcantidad.Text, txtcantidad.Text, 0, 0, 0, 0, "EDICION DE SALDO", F_Control_Recargas_Claro.lblUsuario.Text, F_Control_Recargas_Claro.lblCierre.Text)


            F_Control_Recargas_Claro.txtId.Text = queryconsultas.numero_controlRC().ToString


            My.Settings.CSaldoActual = txtcantidad.Text
            My.Settings.CSaldoAnterior = txtcantidad.Text

            My.Settings.Save()
            My.Settings.Reload()


        End If

        Me.Close()


    End Sub

    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call ok_Click(sender, e)
        End If
    End Sub
    Private Sub txtcantidad_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtcantidad.MaskInputRejected

    End Sub
End Class