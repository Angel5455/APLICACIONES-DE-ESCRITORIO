Public Class F_ControlCreditos
    Dim WithEvents queryconsultas As New dRecargas

    Dim conexion As New DataClasses1DataContext()
    Dim query

    Dim encontrado As Boolean

    Dim resultado As MsgBoxResult

  

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim desea As DialogResult
        desea = MessageBox.Show("¿Esta Seguro que desea eliminar este registro?", "Desea Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        If desea = Windows.Forms.DialogResult.OK Then
            queryconsultas.Eliminar_creditos(txtId.Text)

        End If

        limpiar()

    End Sub

    Sub limpiar()

        txtId.Clear()
        txtnombre.Clear()
        txtCelular.Clear()
        txtcantidad.Clear()


    End Sub

    Private Sub F_ControlCreditos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class