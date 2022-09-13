Imports System.Data
Imports System.Data.SqlClient

Public Class F_Lista_Factura

    Private _cadena As String
    Private _conexion As SqlConnection

    Private _tabla As New DataTable
    Private _adaptador As SqlDataAdapter = New SqlDataAdapter
    Dim accion As Boolean


    Sub nuevo()

        Dim conexion As New Conexion_Productos
        Dim datos As New dProductos

        datos.N_Movimiento2 = txtN.Text
        datos.factura = txtFactura.Text
        datos.codigo2 = txtCodigo.Text
        datos.insumos2 = txtDescripcion.Text
        datos.unidad2 = txtUnidad.Text
        datos.cantidad2 = txtCantidad.Text
        datos.precio2 = txtPrecio.Text
        datos.subtotal2 = txtSubTotal.Text


        If conexion.insertar_datos_productos3(datos) Then
            If conexion.consultar_todos_productos3 Then

                '     F_Factura.DataGridView1.DataSource = conexion.tabla

            End If

            MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub



    Sub nuevo_kardex()

        Dim conexion As New Conexion_Kardex
        Dim datos As New dKardex

        datos.N_Movimiento = txtN.Text
        datos.compra = " - - - "
        datos.factura = txtFactura.Text
        datos.orden = " - - - "
        datos.fecha = F_Factura.lblfecha.Text
        datos.movimiento = F_Factura.txtTipo.Text
        datos.concepto = F_Factura.txtConcepto.Text
        datos.codigo = txtCodigo.Text
        datos.Insumo = txtDescripcion.Text
        datos.unidad = txtUnidad.Text
        datos.proveedor = " - - - "
        datos.cliente = F_Factura.txtNombres.Text
        datos.entrada = 0
        datos.salida = txtCantidad.Text
        datos.stock = TextBox2.Text


        If conexion.insertar_datos_kardex(datos) Then
            If conexion.consultar_todos_kardex Then

                ''                F_MovimientosE.DataGridView1.DataSource = conexion.tabla

            End If

            ' MessageBox.Show("REGISTRO AGREGADO EN KARDEX", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MessageBox.Show("REGISTRO NO AGREGADO EN KARDEX", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Sub limpiar()

        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Text = ""
        txtSubTotal.Text = ""

    End Sub





    Private Sub F_Lista_Factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conexion As New Conexion_Productos
        Dim tabla As New DataTable

        If conexion.consultar_todos_articulos Then
            tabla = conexion.tabla
            DataGridView1.DataSource = tabla


        Else
            MessageBox.Show("No se pudo consultar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Insumos where Codigo like '" & txtCodigo.Text & "%'", con)


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

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged

        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Insumos where Nombre like '" & txtDescripcion.Text & "%'", con)


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

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged
        If Val(txtCantidad.Text) < 0 Then

            MsgBox("Cantidad Invalida")

        End If


        Dim total As Double = 0
        Dim total2 As Double = 0

        total = Val(txtCantidad.Text) * Val(txtPrecio.Text)

        txtSubTotal.Text = total

        total2 = Val(txtStock.Text) - Val(txtCantidad.Text)
        TextBox2.Text = total2
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDoubleClick
        Try
            txtCodigo.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
            txtDescripcion.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            txtStock.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
            txtPrecio.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(5).Value
            txtUnidad.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
            txtLinea.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
            txtproveedor.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value

            PictureBox1.Visible = True

        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click


        If txtCantidad.Text <> "" Then

            F_Factura.salir = "A"

            F_Factura.EliminarRegistroToolStripMenuItem.Enabled = True

            F_Factura.btnGuardar.Visible = True
            F_Factura.btnNoSave.Visible = False



            If TextBox2.Text < 0 Then

                Dim resp As String


                resp = (MsgBox("¿Desea ir a Compras?", MsgBoxStyle.YesNo, "No hay mas Productos...."))

                If resp = 6 Then

                    Dim total

                    total = Val(F_Factura.txtFactura.Text) - 1


                    F_MovimientosE.ComboTipo.Text = "Entrada"
                    F_MovimientosE.txtConcepto.Text = "Ajuste de Inventario"
                    F_Factura.txtFactura.Text = total


                    F_MovimientosE.Show()

                    Me.Hide()



                End If


            Else


                nuevo()
                nuevo_kardex()

                Dim constr As String

                constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

                Dim con As New SqlConnection(constr)
                Dim ds As New DataSet
                Dim tabla As New DataTable

                Dim da As New SqlDataAdapter("Select * from Productos3 where Factura like '" & txtFactura.Text & "%'", con)


                Try

                    Dim cmd As New SqlCommand

                    da.Fill(tabla)
                    F_Factura.DataGridView1.DataSource = tabla

                Catch ex As Exception
                    MsgBox(ex.Message)

                Finally

                    con = Nothing
                    ds = Nothing
                    da = Nothing
                    tabla = Nothing


                End Try



                Dim total As Double


                Try
                    For i As Integer = 0 To F_Factura.DataGridView1.RowCount - 1
                        total = total + CDbl(F_Factura.DataGridView1.Item("Subtotal".ToLower, i).Value)
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try

                F_Factura.txtTotal.Text = total

                F_Articulos.txtCodigo.Text = txtCodigo.Text
                F_Articulos.txtNombre.Text = txtDescripcion.Text
                F_Articulos.txtPrecio.Text = txtPrecio.Text
                F_Articulos.txtUnidad.Text = txtUnidad.Text
                F_Articulos.txtlinea.Text = txtLinea.Text
                F_Articulos.txtStock.Text = TextBox2.Text
                F_Articulos.txtProveedor.Text = txtproveedor.Text


                ' F_Articulos.Show()

                F_Articulos.btnGuardar_Click(True, Nothing)

                Me.Hide()


            End If


        Else


            If txtCantidad.Text = "" Then

                MsgBox("Debe ingresar la cantidad del producto", MsgBoxStyle.Exclamation, "P.A.P.P System")

                txtCantidad.BackColor = Color.OrangeRed
            Else
                txtCantidad.BackColor = Color.White

            End If





        End If




    End Sub

    Sub eliminar()
        Dim conexion As New Conexion_Productos
        Dim datos As New dProductos

        datos.factura = txtFactura.Text

        If conexion.borrar_datos_productos3(datos) Then
            If conexion.consultar_todos_productos3 Then

                '   F_Factura.DataGridView1.DataSource = conexion.tabla

            End If

            ' MessageBox.Show("REGISTRO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            MessageBox.Show("REGISTRO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        limpiar()

    End Sub

    Sub eliminar_kardex()

        Dim conexion As New Conexion_Kardex
        Dim datos As New dKardex

        datos.N_Movimiento = txtN.Text

        If conexion.borrar_datos_kardex(datos) Then
            If conexion.consultar_todos_kardex Then


            End If

            '  MessageBox.Show("REGISTRO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            MessageBox.Show("REGISTRO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        limpiar()

    End Sub


    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class