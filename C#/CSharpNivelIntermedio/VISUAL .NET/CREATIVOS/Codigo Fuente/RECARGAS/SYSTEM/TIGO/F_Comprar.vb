Public Class F_Comprar

    Dim WithEvents queryconsultas As New dRecargas
    Dim conexion As New DataClasses1DataContext()
    Dim query

    Dim encontrado As Boolean

    Dim resultado As MsgBoxResult

    Private Sub txtcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcantidad.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            Call OK_Click(sender, e)
        End If

    End Sub

    Private Sub txtcantidad_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtcantidad.MaskInputRejected

    End Sub

    Private Sub ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok.Click

        If Val(lblOpcion.Text) = 1 Then

            
            F_ControlRecargas.lblSaldoAnterior.Text = txtcantidad.Text + Val(My.Settings.TSaldoActual)
            ' F_ControlRecargas.lblCompra.Text = txtcantidad.Text
            F_ControlRecargas.lblSaldoActual.Text = F_ControlRecargas.lblSaldoAnterior.Text



            Call queryconsultas.insertar_controlR(1 & F_ControlRecargas.txtId.Text, F_ControlRecargas.txtnombre.Text, F_ControlRecargas.txtCelular.Text, 0, F_ControlRecargas.lblFecha.Text, F_ControlRecargas.lblHora.Text, txtcantidad.Text, F_ControlRecargas.lblSaldoAnterior.Text, F_ControlRecargas.lblSaldoActual.Text, F_ControlRecargas.lblVendido.Text, F_ControlRecargas.lblDinero.Text, F_ControlRecargas.lblMonto.Text, F_ControlRecargas.lblError.Text, F_ControlRecargas.lblObservacion.Text, F_ControlRecargas.lblUsuario.Text, F_ControlRecargas.lblCierre.Text)
            F_ControlRecargas.txtId.Text = queryconsultas.numero_controlR().ToString

            My.Settings.TSaldoActual = txtcantidad.Text + Val(My.Settings.TSaldoActual)
            My.Settings.TSaldoAnterior = txtcantidad.Text + Val(My.Settings.TSaldoAnterior)


            My.Settings.Save()
            My.Settings.Reload()

        Else



            F_Control_Recargas_Claro.lblSaldoAnterior.Text = txtcantidad.Text + Val(My.Settings.CSaldoActual)
            ' F_ControlRecargas.lblCompra.Text = txtcantidad.Text
            F_Control_Recargas_Claro.lblSaldoActual.Text = F_Control_Recargas_Claro.lblSaldoAnterior.Text



            Call queryconsultas.insertar_controlRC(2 & F_Control_Recargas_Claro.txtId.Text, F_Control_Recargas_Claro.txtnombre.Text, F_Control_Recargas_Claro.txtCelular.Text, 0, F_Control_Recargas_Claro.lblFecha.Text, F_Control_Recargas_Claro.lblHora.Text, txtcantidad.Text, F_Control_Recargas_Claro.lblSaldoAnterior.Text, F_Control_Recargas_Claro.lblSaldoActual.Text, F_Control_Recargas_Claro.lblVendido.Text, F_Control_Recargas_Claro.lblDinero.Text, F_Control_Recargas_Claro.lblMonto.Text, F_Control_Recargas_Claro.lblError.Text, F_Control_Recargas_Claro.lblObservacion.Text, F_Control_Recargas_Claro.lblUsuario.Text, F_Control_Recargas_Claro.lblCierre.Text)
            F_Control_Recargas_Claro.txtId.Text = queryconsultas.numero_controlRC().ToString


            My.Settings.CSaldoActual = txtcantidad.Text + Val(My.Settings.CSaldoActual)
            My.Settings.CSaldoAnterior = txtcantidad.Text + Val(My.Settings.CSaldoAnterior)

            My.Settings.Save()
            My.Settings.Reload()


        End If

        Me.Close()

    End Sub

    Private Sub F_Comprar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


End Class