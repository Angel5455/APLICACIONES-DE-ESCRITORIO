Imports System.Data.SqlClient

Public Class F_Clientes

    Dim WithEvents queryconsultas As New dRecargas

    Dim conexion As New DataClasses1DataContext()
    Dim query

    Dim encontrado As Boolean

    Dim resultado As MsgBoxResult


    Sub limpiar()

        txtId.Clear()
        txtnombre.Clear()
        txtCelular.Clear()


    End Sub

    Private Sub F_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtId.Text = queryconsultas.numero_clientes().ToString

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress


        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If

      
    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub MaskedTextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCelular.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtCelular.MaskInputRejected

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If txtnombre.Text <> "" And txtnombre.Text <> "" And txtCelular.Text <> "  -  -" Then


            Call queryconsultas.insertar_clientes(txtId.Text, txtnombre.Text, txtCelular.Text)
            limpiar()


            txtId.Text = queryconsultas.numero_clientes().ToString

            limpiar()


        Else

            MsgBox("Campos Vacios", MsgBoxStyle.Information, "CREATIVOS")


        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        F_BuscarCliente.lblopcion.Text = 1

        F_BuscarCliente.Show()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click


        queryconsultas.Modificar_clientes(txtId.Text, txtnombre.Text, txtCelular.Text)
        limpiar()

        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False


    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim desea As DialogResult
        desea = MessageBox.Show("¿Esta Seguro que desea eliminar este registro?", "Desea Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        If desea = Windows.Forms.DialogResult.OK Then
            queryconsultas.Eliminar_clientes(txtId.Text)

        End If

        btnEliminar.Enabled = False
        btnGuardar.Enabled = True
        btnModificar.Enabled = False


        limpiar()
        txtId.Text = queryconsultas.numero_clientes().ToString

    End Sub
End Class