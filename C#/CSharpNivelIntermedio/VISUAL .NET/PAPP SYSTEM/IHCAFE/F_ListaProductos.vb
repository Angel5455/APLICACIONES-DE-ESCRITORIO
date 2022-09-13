Imports System.Data
Imports System.Data.SqlClient
Public Class F_ListaProductos


    Public kardex As String

    Private _cadena As String
    Private _conexion As SqlConnection


    Private _tabla As New DataTable
    Private _adaptador As SqlDataAdapter = New SqlDataAdapter
    Dim accion As Boolean


    Private Sub conexion()
        _cadena = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        _conexion = New SqlConnection(_cadena)



    End Sub

    Public ReadOnly Property tabla() As DataTable
        Get
            Return _tabla
        End Get
    End Property

    Sub nuevo_kardex()

        Dim conexion As New Conexion_Kardex
        Dim datos As New dKardex

        datos.N_Movimiento = txtN.Text
        datos.compra = txtCompra.Text
        datos.factura = " - - - "
        datos.orden = " - - - "
        datos.fecha = F_MovimientosE.lblfecha.Text
        datos.movimiento = F_MovimientosE.txtTipo.Text
        datos.concepto = F_MovimientosE.txtConcepto.Text
        datos.codigo = txtCodigo.Text
        datos.Insumo = txtDescripcion.Text
        datos.unidad = txtUnidad.Text
        datos.proveedor = F_MovimientosE.txtProveedor.Text
        datos.cliente = " - - - "
        datos.entrada = txtCantidad.Text
        datos.salida = 0
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


    Sub nuevo()

        Dim conexion As New Conexion_Productos
        Dim datos As New dProductos

        datos.N_Movimiento1 = txtN.Text
        datos.Compra = txtCompra.Text
        datos.codigo1 = txtCodigo.Text
        datos.insumos1 = txtDescripcion.Text
        datos.unidad1 = txtUnidad.Text
        datos.cantidad1 = txtCantidad.Text
        datos.precio1 = txtPrecio.Text
        datos.subtotal1 = txtSubTotal.Text


        If conexion.insertar_datos_productos(datos) Then
            If conexion.consultar_todos_productos Then

                '  F_MovimientosE.DataGridView1.DataSource = conexion.tabla

            End If

            MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Sub limpiar()

        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Text = ""
        txtSubTotal.Text = ""

    End Sub



    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()

    End Sub



    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        PictureBox1.Height = 45
        PictureBox1.Width = 45
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        PictureBox1.Height = 50
        PictureBox1.Width = 50
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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

        total2 = Val(txtstock.Text) + Val(txtCantidad.Text)
        TextBox2.Text = total2


    End Sub

    Private Sub F_ListaProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim conexion As New Conexion_Productos
        Dim tabla As New DataTable

        If conexion.consultar_todos_articulos Then
            tabla = conexion.tabla
            DataGridView1.DataSource = tabla


        Else
            MessageBox.Show("No se pudo consultar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If



    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click


        If txtCantidad.Text <> "" Then

            F_MovimientosE.EliminarRegistroToolStripMenuItem.Enabled = True


            F_MovimientosE.salir = "A"


            F_MovimientosE.btnGuardar.Visible = True
            F_MovimientosE.btnNoGuardar.Visible = False



            If TextBox2.Text < 0 Then

                Dim resp As String


                resp = (MsgBox("¿Desea ir a Inventario?", MsgBoxStyle.YesNo, "No hay mas Productos...."))

                If resp = 6 Then

                End If


            Else




                nuevo()
                nuevo_kardex()

                Dim constr As String

                constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

                Dim con As New SqlConnection(constr)
                Dim ds As New DataSet
                Dim tabla As New DataTable

                Dim da As New SqlDataAdapter("Select * from Productos where Compra like '" & txtCompra.Text & "%'", con)


                Try

                    Dim cmd As New SqlCommand

                    da.Fill(tabla)
                    F_MovimientosE.DataGridView1.DataSource = tabla

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
                    For i As Integer = 0 To F_MovimientosS.DataGridView1.RowCount - 1
                        total = total + CDbl(F_MovimientosS.DataGridView1.Item("Subtotal".ToLower, i).Value)
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try

                F_MovimientosS.txtTotal.Text = total

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

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            txtCodigo.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
            txtDescripcion.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            txtstock.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(4).Value
            txtPrecio.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(5).Value
            txtUnidad.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
            txtLinea.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value

            txtproveedor.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(6).Value

            PictureBox1.Visible = True

        Catch ex As Exception
        End Try
    End Sub

    Sub eliminar()
        Dim conexion As New Conexion_Productos
        Dim datos As New dProductos

        datos.Compra = txtCompra.Text

        If conexion.borrar_datos_productos(datos) Then
            If conexion.consultar_todos_productos Then

                ' F_MovimientosE.DataGridView1.DataSource = conexion.tabla

            End If

            '   MessageBox.Show("REGISTRO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


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

            '   MessageBox.Show("REGISTRO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            MessageBox.Show("REGISTRO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        limpiar()

    End Sub


    Sub modificar()


        '' Dim conexion As New Conexion_Factura
        Dim datos As New cDatos

        datos.Codigo = txtCodigo.Text
        datos.Descripcion = txtDescripcion.Text
        datos.Unidad = txtUnidad.Text
        datos.Stock = txtstock.Text
        datos.Precio = txtPrecio.Text
        datos.Proveedor = txtproveedor.Text





        If accion = False Then
            ''    If conexion.actualizar_datos_Inventario(datos) Then
            ''If conexion.consultar_todos_Ordenes Then
            ''    F_Inventario.DataGridView1.DataSource = conexion.tabla
        End If

        MessageBox.Show("INVENTARIO ACTUALIZADO", "ACTUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ''Else
        MessageBox.Show("INVENTARIO NO ACTUALIZADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ''End If


        ''        End If




        limpiar()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nuevo()

    End Sub

 
End Class