Imports System.Data.SqlClient


Public Class F_Articulos

    Public accion As Boolean

    Sub limpiar()
        txtCodigo.Text = ""
        txtNombre.Text = ""
        txtlinea.Text = ""
        txtUnidad.Text = ""
        txtStock.Text = "0"
        txtPrecio.Text = ""
        txtProveedor.Text = ""
    End Sub

    Sub bloquear()
        txtCodigo.Enabled = False
        txtNombre.Enabled = False
        txtlinea.Enabled = False
        txtUnidad.Enabled = False
        txtStock.Enabled = False
        txtPrecio.Enabled = False
        txtProveedor.Enabled = False
    End Sub

    Sub desbloquear()
        txtCodigo.Enabled = True
        txtNombre.Enabled = True
        txtPrecio.Enabled = True
        txtlinea.Enabled = True
        txtUnidad.Enabled = True
        'txtStock.Enabled = True
        txtProveedor.Enabled = True
    End Sub

    Private Sub btnNoNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoNuevo.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Nuevo")
    End Sub

    Private Sub btnNoSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoGuardar.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Guardar")
    End Sub

    Private Sub btnNoModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoModificar.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Modificar")
    End Sub

    Private Sub btnNoEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoEliminar.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Eliminar")
    End Sub

    Private Sub btnNoNuevo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoNuevo.MouseEnter
        btnNoNuevo.Height = 45
        btnNoNuevo.Width = 45
    End Sub

    Private Sub btnNoNuevo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoNuevo.MouseLeave
        btnNoNuevo.Height = 50
        btnNoNuevo.Width = 50
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        btnNuevo.Visible = False
        btnNoNuevo.Visible = True
        btnGuardar.Visible = True
        btnNoGuardar.Visible = False
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True
        accion = True
        desbloquear()
        limpiar()

    End Sub

    Private Sub btnNuevo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.MouseEnter
        btnNuevo.Height = 45
        btnNuevo.Width = 45
    End Sub

    Private Sub btnNuevo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.MouseLeave
        btnNuevo.Height = 50
        btnNuevo.Width = 50
    End Sub

    Private Sub F_Articulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblUsuario.Text = F_Menu.lblUsuario.Text

        lblfecha.Text = Format(Now(), "dd/MM/yyyy")

        Dim conexion As New Conexion_Productos
        Dim tabla As New DataTable

        If conexion.consultar_todos_articulos Then
            tabla = conexion.tabla
            DataGridView1.DataSource = tabla
        Else
            MessageBox.Show("No se pudo consultar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        bloquear()

    End Sub

    Private Sub btnNoGuardar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoGuardar.MouseEnter
        btnNoGuardar.Height = 45
        btnNoGuardar.Width = 45

    End Sub

    Private Sub btnNoGuardar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoGuardar.MouseLeave
        btnNoGuardar.Height = 50
        btnNoGuardar.Width = 50
    End Sub

    Public Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click


        If txtStock.Text <> "" And txtUnidad.Text <> "" And txtCodigo.Text <> "" And txtNombre.Text <> "" And txtlinea.Text <> "" And txtUnidad.Text <> "" And txtPrecio.Text <> "" And txtProveedor.Text <> "" Then


            Dim conexion As New Conexion_Productos
            Dim datos As New dProductos

            datos.CodigoA = txtCodigo.Text
            datos.Nombre = txtNombre.Text
            datos.linea = txtlinea.Text
            datos.UnidadA = txtUnidad.Text
            datos.stock = txtStock.Text
            datos.precioA = txtPrecio.Text
            datos.proveedor = txtProveedor.Text
            datos.estado = txtEstado.Text


            If accion = True Then
                If conexion.insertar_datos_articulos(datos) Then
                    If conexion.consultar_todos_articulos Then

                        DataGridView1.DataSource = conexion.tabla

                    End If

                    MessageBox.Show("REGISTRO AGREGADO", "INVENTARIO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else

                    MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If


            If accion = False Then
                If conexion.actualizar_datos_articulos(datos) Then
                    If conexion.consultar_todos_articulos Then
                        DataGridView1.DataSource = conexion.tabla
                    End If

                    MessageBox.Show("REGISTRO ACTUALIZADO", "INVENTARIO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("REGISTRO NO ACTUALIZADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If


            End If



            btnNuevo.Visible = True
            btnNoNuevo.Visible = False


            btnGuardar.Visible = False
            btnNoGuardar.Visible = True
            btnModificar.Visible = False
            btnNoModificar.Visible = True
            btnEliminar.Visible = False
            btnNoEliminar.Visible = True




            bloquear()

            limpiar()


            txtNombre.BackColor = Color.White
            txtCodigo.BackColor = Color.White
            txtlinea.BackColor = Color.White
            txtUnidad.BackColor = Color.White
            txtStock.BackColor = Color.White
            txtPrecio.BackColor = Color.White
            txtProveedor.BackColor = Color.White

        Else

            If txtCodigo.Text = "" Then

                txtCodigo.BackColor = Color.OrangeRed

            Else
                txtCodigo.BackColor = Color.White


            End If

            If txtNombre.Text = "" Then

                txtNombre.BackColor = Color.OrangeRed

            Else
                txtNombre.BackColor = Color.White

            End If


            If txtlinea.Text = "" Then

                txtlinea.BackColor = Color.OrangeRed

            Else
                txtlinea.BackColor = Color.White

            End If



            If txtUnidad.Text = "" Then

                txtUnidad.BackColor = Color.OrangeRed

            Else
                txtUnidad.BackColor = Color.White

            End If



            If txtStock.Text = "" Then

                txtStock.BackColor = Color.OrangeRed

            Else
                txtStock.BackColor = Color.White

            End If


            If txtPrecio.Text = "" Then

                txtPrecio.BackColor = Color.OrangeRed

            Else
                txtPrecio.BackColor = Color.White

            End If


            If txtProveedor.Text = "" Then

                txtProveedor.BackColor = Color.OrangeRed

            Else
                txtProveedor.BackColor = Color.White

            End If


            MsgBox("No se permiten campos en blanco", MsgBoxStyle.Exclamation, "P.A.P.P System")
        End If


    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        btnNuevo.Visible = False
        btnNoNuevo.Visible = True


        btnGuardar.Visible = True
        btnNoGuardar.Visible = False
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True
        accion = False
        desbloquear()

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim resp As Integer

        resp = MsgBox("¿Seguro Desea Eliminar el Insumo " & txtNombre.Text & " ?", MsgBoxStyle.YesNo, "P.A.P.P System")

        If resp = 6 Then

            Dim conexion As New Conexion_Productos
            Dim datos As New dProductos

            datos.CodigoA = txtCodigo.Text

            If conexion.borrar_datos_articulos(datos) Then
                If conexion.consultar_todos_articulos Then

                    DataGridView1.DataSource = conexion.tabla

                End If

                MessageBox.Show("REGISTRO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("REGISTRO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            btnNuevo.Visible = True
            btnNoNuevo.Visible = False

            btnGuardar.Visible = False
            btnNoGuardar.Visible = True
            btnModificar.Visible = False
            btnNoModificar.Visible = True
            btnEliminar.Visible = False
            btnNoEliminar.Visible = True

            limpiar()

        End If


    End Sub

    Private Sub txtCampoB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCampoB.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable



        Dim da As New SqlDataAdapter("Select * from Insumos where " & txtBuscarPor.Text & " like '" & txtCampoB.Text & "%'", con)


        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)
            DataGridView1.DataSource = tabla

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing
            tabla = Nothing

        End Try



    End Sub

    Private Sub txtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtPrecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub txtStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtStock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStock.TextChanged
        If Val(txtStock.Text) = 0 Then

            txtEstado.Text = "Insuficiente"

        Else

            txtEstado.Text = "Existente"

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        Try

            txtCodigo.Text = DataGridView1.SelectedCells(0).Value.ToString()
            txtNombre.Text = DataGridView1.SelectedCells(1).Value.ToString()

            txtlinea.Text = DataGridView1.SelectedCells(2).Value.ToString()
            txtUnidad.Text = DataGridView1.SelectedCells(3).Value.ToString()
            txtStock.Text = DataGridView1.SelectedCells(4).Value.ToString()
            txtPrecio.Text = DataGridView1.SelectedCells(5).Value.ToString()
            txtProveedor.Text = DataGridView1.SelectedCells(6).Value.ToString()

        Catch ex As Exception
        End Try

        btnEliminar.Visible = True
        btnNoEliminar.Visible = False
        btnModificar.Visible = True
        btnNoModificar.Visible = False


    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click



    End Sub

    Private Sub btnNoModificar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoModificar.MouseEnter
        btnNoModificar.Height = 45
        btnNoModificar.Width = 45
    End Sub

    Private Sub btnNoModificar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoModificar.MouseLeave
        btnNoModificar.Height = 50
        btnNoModificar.Width = 50
    End Sub

    Private Sub btnModificar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.MouseEnter
        btnModificar.Height = 45
        btnModificar.Width = 45
    End Sub

    Private Sub btnModificar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.MouseLeave
        btnModificar.Height = 50
        btnModificar.Width = 50
    End Sub

    Private Sub btnNoEliminar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoEliminar.MouseEnter
        btnNoEliminar.Height = 45
        btnNoEliminar.Width = 45
    End Sub

    Private Sub btnNoEliminar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoEliminar.MouseLeave
        btnNoEliminar.Height = 50
        btnNoEliminar.Width = 50
    End Sub

    Private Sub btnEliminar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.MouseEnter
        btnEliminar.Height = 45
        btnEliminar.Width = 45
    End Sub

    Private Sub btnEliminar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.MouseLeave
        btnEliminar.Height = 50
        btnEliminar.Width = 50
    End Sub

  

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub btnSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir2.Click
        Dim resp As Integer
        resp = MsgBox("¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "P.A.P.P System")
        If resp = 6 Then

            limpiar()
            Me.Hide()

        End If


        btnNuevo.Visible = True
        btnNoNuevo.Visible = False
        btnGuardar.Visible = False
        btnNoGuardar.Visible = True
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True

    End Sub


    
    Private Sub btnSalir_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSalir.MouseMove
        btnSalir2.Visible = True
        btnSalir.Visible = False

    End Sub

    Private Sub btnSalir2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir2.MouseEnter
       
    End Sub

    Private Sub btnSalir2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir2.MouseLeave
        btnSalir2.Visible = False
        btnSalir.Visible = True
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub
End Class