Imports System.Data.SqlClient

Public Class F_EliminarS


    Sub eliminar_productos()

        Dim conexion As New Conexion_Productos
        Dim datos As New dProductos

        datos.codigo2 = txtCodigo.Text

        If conexion.borrar_datos_productosS(datos) Then
            

            MessageBox.Show("PRODUCTO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            MessageBox.Show("PRODUCTO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub

    Sub eliminar_kardex()

        Dim conexion As New Conexion_Kardex
        Dim datos As New dKardex

        datos.codigo = txtCodigo.Text

        If conexion.borrar_datos_kardexS(datos) Then
        

            '  MessageBox.Show("PRODUCTO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            '  MessageBox.Show("PRODUCTO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If



    End Sub


    Private Sub btnEliminar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.MouseEnter
        btnEliminar.Height = 45
        btnEliminar.Width = 45
    End Sub

    Private Sub btnEliminar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.MouseLeave
        btnEliminar.Height = 50
        btnEliminar.Width = 50
    End Sub

    Private Sub F_EliminarItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable




        Dim da As New SqlDataAdapter("Select * from Productos2 Where Factura like'" & txtOrden.Text & "%'", con)


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

    Private Sub txtCodigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click


        F_Articulos.txtCodigo.Text = txtCodigo.Text
        F_Articulos.txtNombre.Text = txtDescripcion.Text
        F_Articulos.txtPrecio.Text = txtPrecio.Text
        F_Articulos.txtUnidad.Text = txtUnidad.Text
        F_Articulos.txtlinea.Text = txtLinea.Text
        F_Articulos.txtStock.Text = txtQ.Text
        F_Articulos.txtProveedor.Text = txtproveedor.Text



        'F_Articulos.Show()

        F_Articulos.btnGuardar_Click(True, Nothing)

        F_MovimientosS.txtTotal.Text = ""

        eliminar_productos()
        eliminar_kardex()
        Limpiar()


        Dim total As Double


        Try
            For i As Integer = 0 To F_MovimientosS.DataGridView1.RowCount - 1
                total = total + CDbl(F_MovimientosS.DataGridView1.Item("Subtotal".ToLower, i).Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        F_MovimientosS.txtTotal.Text = total


        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable



        Dim da As New SqlDataAdapter("Select * from Productos2 Where Factura like'" & F_MovimientosS.txtOrden.Text & "%'", con)


        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            F_MovimientosS.DataGridView1.DataSource = tabla

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing

            tabla = Nothing

        End Try

        Me.Hide()





    End Sub

    Sub Limpiar()

        txtCodigo.Text = ""
        txtDescripcion.Text = ""

        txtSubTotal.Text = ""

    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged

        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable

        Dim da As New SqlDataAdapter("Select * from Productos2 where Insumos like '" & txtDescripcion.Text & "%'", con)
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged


    End Sub


    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        '  Try
        txtOrden.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
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


        'Catch ex As Exception
        'End Try

    End Sub
End Class