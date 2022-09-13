Imports System.Data.SqlClient

Public Class F_EliminarF



    Sub eliminar()

        Dim conexion As New Conexion_Productos
        Dim datos As New dProductos

        datos.codigo2 = txtCodigo.Text

        If conexion.borrar_datos_productosF(datos) Then
            If conexion.consultar_todos_productos3 Then

                ' DataGridView1.DataSource = conexion.tabla
                ' F_Factura.DataGridView1.DataSource = conexion.tabla

            End If

            MessageBox.Show("PRODUCTO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            MessageBox.Show("PRODUCTO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub

    Sub eliminar2()

        Dim conexion As New Conexion_Kardex
        Dim datos As New dKardex

        datos.codigo = txtCodigo.Text

        If conexion.borrar_datos_kardex(datos) Then
            If conexion.consultar_todos_kardex Then



            End If

            '  MessageBox.Show("PRODUCTO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            '  MessageBox.Show("PRODUCTO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If



    End Sub

    Private Sub F_EliminarF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim conexion As New Conexion_Productos
        Dim tabla As New DataTable

        If conexion.consultar_todos_productos3 Then
            tabla = conexion.tabla
            '    DataGridView1.DataSource = tabla


        Else
            MessageBox.Show("No se pudo consultar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            txtFactura.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            txtCodigo.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value
            txtDescripcion.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value

            txtSubTotal.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(7).Value

            txtLinea.Text = DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells(2).Value
            txtUnidad.Text = DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells(3).Value
            txtstock.Text = DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells(4).Value
            txtPrecio.Text = DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells(5).Value
            txtproveedor.Text = DataGridView2.Rows(DataGridView2.CurrentRow.Index).Cells(6).Value

            txtCantidad.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(5).Value


            txtQ.Text = Val(txtstock.Text) + Val(txtCantidad.Text)


        Catch ex As Exception
        End Try

    End Sub

    Sub Limpiar()

        txtCodigo.Text = ""
        txtDescripcion.Text = ""

        txtSubTotal.Text = ""

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        F_Factura.txtTotal.Text = ""


        F_Articulos.txtCodigo.Text = txtCodigo.Text
        F_Articulos.txtNombre.Text = txtDescripcion.Text
        F_Articulos.txtPrecio.Text = txtPrecio.Text
        F_Articulos.txtUnidad.Text = txtUnidad.Text
        F_Articulos.txtlinea.Text = txtLinea.Text
        F_Articulos.txtStock.Text = txtQ.Text
        F_Articulos.txtProveedor.Text = txtproveedor.Text




        ' F_Articulos.Show()

        F_Articulos.btnGuardar_Click(True, Nothing)




        eliminar()
        eliminar2()
        Limpiar()


        Dim total As Double


        Try
            For i As Integer = 0 To F_Factura.DataGridView1.RowCount - 1
                total = total + CDbl(F_Factura.DataGridView1.Item("Subtotal".ToLower, i).Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        F_Factura.txtTotal.Text = total

        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable


        Dim da As New SqlDataAdapter("Select * from Productos3 Where Factura like'" & F_Factura.txtFactura.Text & "%'", con)


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




        Me.Close()


    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged

        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable

        Dim da As New SqlDataAdapter("Select * from Productos3 where Insumos like '" & txtDescripcion.Text & "%'", con)
        Dim da2 As New SqlDataAdapter("Select * from Insumos where Nombre like '" & txtDescripcion.Text & "%'", con)


        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)
            DataGridView1.DataSource = tabla


            da2.Fill(tabla2)
            DataGridView2.DataSource = tabla2

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing
            tabla = Nothing


        End Try


    End Sub
End Class