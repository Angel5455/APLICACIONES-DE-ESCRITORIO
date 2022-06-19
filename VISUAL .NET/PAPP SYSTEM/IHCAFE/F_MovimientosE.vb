Imports System.Data
Imports System.Data.SqlClient

Public Class F_MovimientosE

    Public salir As String
    Dim accion As Boolean

    Sub limpiar()

        ' ComboTipo.Text = ""
        'txtConcepto.Text = ""

        ' txtCompra.Text = ""
        txtProveedor.Text = ""
        txtObservacion.Text = ""

    End Sub

    Sub bloquear()

        '  ComboTipo.Enabled = False
        txtConcepto.Enabled = False
        txtAño.Enabled = False
        txtCompra.Enabled = False
        txtProveedor.Enabled = False
        txtObservacion.Enabled = False

    End Sub


    Sub desbloquear()

        '   ComboTipo.Enabled = True
        txtConcepto.Enabled = True
        txtAño.Enabled = True
        'txtCompra.Enabled = True
        txtProveedor.Enabled = True
        txtObservacion.Enabled = True

    End Sub



    Private Sub btnNoNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoNuevo.Click
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


        salir = "S"

        txtBuscarPor.Enabled = False
        txtCampoB.Enabled = False

        Me.ContextMenuStrip.Enabled = True

        Me.AñadirRegistroToolStripMenuItem.Enabled = True

        Dim total As Integer

        total = Val(txtCompra.Text) + 1

        txtCompra.Text = total

        Dim total2 As Integer

        total2 = Val(txtN.Text) + 1

        txtN.Text = total2



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


        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable


        Dim da As New SqlDataAdapter("Select * from Productos Where Compra like'" & txtCompra.Text & "%'", con)

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

    Private Sub btnNuevo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.MouseEnter
        btnNuevo.Height = 45
        btnNuevo.Width = 45
    End Sub

    Private Sub btnNoGuardar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoGuardar.MouseEnter
        btnNoGuardar.Height = 45
        btnNoGuardar.Width = 45
    End Sub

    Private Sub btnNoGuardar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoGuardar.MouseLeave
        btnNoGuardar.Height = 50
        btnNoGuardar.Width = 50
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click


        If ComboTipo.Text <> "" And txtConcepto.Text <> "" And txtProveedor.Text <> "" And F_ListaProductos.txtDescripcion.Text <> "" Then

            salir = "S"

            Dim conexion As New Conexion_Almacen
            Dim datos As New dAlmacen

            datos.N_Movimiento = txtN.Text
            datos.Compra = txtCompra.Text
            datos.año = txtAño.Text
            datos.fecha = lblfecha.Text
            datos.tipo_movimiento = ComboTipo.Text
            datos.concepto_movimiento = txtConcepto.Text
            datos.cliente = "- - -"
            datos.proveedor = txtProveedor.Text
            datos.observacion = txtObservacion.Text
            datos.Usuario = lblUsuario.Text

            If accion = True Then
                If conexion.insertar_datos_almacen(datos) Then
                    If conexion.consultar_todos_almacen Then

                        DataGridView2.DataSource = conexion.tabla

                    End If
                    My.Settings.MyCompra = txtCompra.Text
                    My.Settings.Save()
                    My.Settings.Reload()

                    My.Settings.MyMovimiento = txtN.Text
                    My.Settings.Save()
                    My.Settings.Reload()




                    MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    F_ListaProductos.limpiar()

                Else

                    MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If

            If accion = False Then
                If conexion.actualizar_datos_almacen(datos) Then
                    If conexion.consultar_todos_almacen Then
                        DataGridView2.DataSource = conexion.tabla
                    End If
                    txtCompra.Text = My.Settings.MyCompra
                    txtN.Text = My.Settings.MyMovimiento

                    MessageBox.Show("REGISTRO ACTUALIZADO", "ACTUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            txtBuscarPor.Enabled = True
            txtCampoB.Enabled = True

            bloquear()

            limpiar()


            ComboTipo.BackColor = Color.White
            txtConcepto.BackColor = Color.White
            txtProveedor.BackColor = Color.White


        Else


            If ComboTipo.Text = "" Then

                MsgBox("No se permiten campos en blanco", MsgBoxStyle.Exclamation, "P.A.P.P System")

                ComboTipo.BackColor = Color.OrangeRed

            Else
                ComboTipo.BackColor = Color.White

            End If

            If txtConcepto.Text = "" Then

                MsgBox("No se permiten campos en blanco", MsgBoxStyle.Exclamation, "P.A.P.P System")

                txtConcepto.BackColor = Color.OrangeRed

            Else
                txtConcepto.BackColor = Color.White

            End If



            If txtProveedor.Text = "" Then

                MsgBox("No se permiten campos en blanco", MsgBoxStyle.Exclamation, "P.A.P.P System")

                txtProveedor.BackColor = Color.OrangeRed

            Else
                txtProveedor.BackColor = Color.White

            End If


            If F_ListaProductos.txtDescripcion.Text = "" Then

                MsgBox("Debe agregar productos para realizar la compra", MsgBoxStyle.Exclamation, "P.A.P.P System")

            Else


            End If


        End If





    End Sub

    Private Sub btnGuardar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.MouseEnter
        btnGuardar.Height = 45
        btnGuardar.Width = 45
    End Sub

    Private Sub btnGuardar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.Height = 50
        btnGuardar.Width = 50
    End Sub

    Private Sub btnNoModificar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoModificar.MouseEnter
        btnNoModificar.Height = 45
        btnNoModificar.Width = 45
    End Sub

    
    Private Sub btnNoModificar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoModificar.MouseLeave
        btnNoModificar.Height = 50
        btnNoModificar.Width = 50
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

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim conexion As New Conexion_Almacen
        Dim datos As New dAlmacen

        datos.N_Movimiento = txtN.Text

        If conexion.borrar_datos_almacen(datos) Then
            If conexion.consultar_todos_almacen Then

                DataGridView2.DataSource = conexion.tabla
                '        DataGridView1.DataSource = conexion.tabla

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

    End Sub

    Private Sub btnEliminar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.MouseEnter
        btnEliminar.Height = 45
        btnEliminar.Width = 45
    End Sub

    Private Sub btnEliminar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.MouseLeave
        btnEliminar.Height = 50
        btnEliminar.Width = 50
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub



    Private Sub ComboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboTipo.SelectedIndexChanged
        txtTipo.Text = ComboTipo.Text

        If txtTipo.Text = "Entrada" Then
            txtConcepto.Items.Clear()
            txtConcepto.Items.Add("Ajuste de Inventario")
            txtConcepto.Items.Add("Compra de Insumos")
            txtConcepto.Items.Add("Otras Entradas")

            Label7.Text = "Proveedor"

        End If

        If txtTipo.Text = "Salida" Then


            txtConcepto.Items.Clear()
            txtConcepto.Items.Add("Venta de Insumos")
            txtConcepto.Items.Add("Prestamos de Insumos")
            txtConcepto.Items.Add("Otras Salidas")


            Label7.Text = "Cliente"

        End If





    End Sub

    Private Sub txtConcepto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConcepto.SelectedIndexChanged





    End Sub

    Private Sub AñadirRegistroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirRegistroToolStripMenuItem.Click

        If txtProveedor.Text <> "" Then


            F_ListaProductos.txtCompra.Text = txtCompra.Text
            F_ListaProductos.txtN.Text = txtN.Text
            F_ListaProductos.limpiar()

            F_ListaProductos.Show()

        Else

            If txtProveedor.Text = "" Then


                MsgBox("Colocar la informacion basica de la compra", MsgBoxStyle.Exclamation, "P.A.P.P System")
                txtProveedor.BackColor = Color.OrangeRed

            Else

                txtProveedor.BackColor = Color.White

            End If


        End If


    End Sub


    Private Sub txtbuscarnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCampoB.TextChanged

        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable





        Dim da As New SqlDataAdapter("Select * from Almacen Where " & txtBuscarPor.Text & " like '" & txtCampoB.Text & "%'", con)


        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            DataGridView2.DataSource = tabla

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing

            tabla = Nothing

        End Try


    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDoubleClick
        Try

            txtN.Text = DataGridView2.SelectedCells(0).Value.ToString()
            txtCompra.Text = DataGridView2.SelectedCells(1).Value.ToString()

            txtAño.Text = DataGridView2.SelectedCells(2).Value.ToString()
            lblfecha.Text = DataGridView2.SelectedCells(3).Value.ToString()

            txtTipo.Text = DataGridView2.SelectedCells(4).Value.ToString()

            txtConcepto.Text = DataGridView2.SelectedCells(5).Value.ToString()
            txtProveedor.Text = DataGridView2.SelectedCells(6).Value.ToString()
            txtObservacion.Text = DataGridView2.SelectedCells(7).Value.ToString()
            lblUsuario.Text = DataGridView2.SelectedCells(8).Value.ToString()

            Dim constr As String

            constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

            Dim con As New SqlConnection(constr)
            Dim ds As New DataSet
            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select * from Productos where Compra like '" & txtCompra.Text & "%'", con)


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

            Dim total As Double = 0

            ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  

            Try
                ' For i As Integer = 0 To DataGridView1.RowCount - 1
                '   total = total + CDbl(DataGridView1.Item("Subtotal".ToLower, i).Value)
                '  Next

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

            ' txtTotal.Text = total


            '     If txtcargo.Text = 2 Then

            'btnEliminar.Visible = False
            'btnNoEliminar.Visible = True
            'btnModificar.Visible = False
            'btnNoModificar.Visible = True
            'btnGuardar.Visible = True
            'btnNoGuardar.Visible = False

            'End If

            'If txtcargo.Text = 1 Then

            btnEliminar.Visible = False
            btnNoEliminar.Visible = True
            btnModificar.Visible = False
            btnNoModificar.Visible = True
            btnGuardar.Visible = False
            btnNoGuardar.Visible = True

            btnNoNuevo.Visible = False
            btnNuevo.Visible = True


            'End If


            TabControl1.SelectedIndex = 0


        Catch ex As Exception
        End Try


    End Sub


    Private Sub EliminarRegistroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarRegistroToolStripMenuItem.Click

        F_ListaProductos.limpiar()


        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable
        
        Dim da As New SqlDataAdapter("Select * from Productos Where Compra like'" & txtCompra.Text & "%'", con)

      

        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            F_EliminarE.DataGridView1.DataSource = tabla


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing

            tabla = Nothing


        End Try



        F_EliminarE.txtCompra.Text = txtCompra.Text
        F_EliminarE.Show()

    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click

    End Sub

    Private Sub F_MovimientosE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '  txtcargo.Text = Val(F_Menu_Movimientos.txtcargo.Text)

        Me.ContextMenuStrip = ContextMenuStrip1

        Me.ContextMenuStrip.Enabled = False

        AñadirRegistroToolStripMenuItem.Enabled = False

        EliminarRegistroToolStripMenuItem.Enabled = False


        txtCompra.Text = My.Settings.MyCompra
        txtN.Text = My.Settings.MyMovimiento


        lblfecha.Text = Format(Now(), "dd/MM/yyyy")
        txtAño.Text = Year(Now)
        lblUsuario.Text = F_Menu.lblUsuario.Text

        Dim conexion As New Conexion_Almacen
        Dim tabla As New DataTable

        If conexion.consultar_todos_almacen Then
            tabla = conexion.tabla
            DataGridView2.DataSource = tabla
        Else
            MessageBox.Show("No se pudo consultar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        bloquear()


    End Sub

    Private Sub btnSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir2.Click

        
        txtCompra.Text = My.Settings.MyCompra
        txtN.Text = My.Settings.MyMovimiento



        limpiar()



        If salir = "S" Then

            Dim resp As Integer

            resp = MsgBox("¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "P.A.P.P System")
            If resp = 6 Then
                btnSalir2.Visible = False
                btnSalir.Visible = True
                EliminarRegistroToolStripMenuItem.Enabled = False

                Me.Hide()
            End If

        ElseIf salir = "A" Then

            Dim resp As Integer

            resp = MsgBox("Debe eliminar los insumos cargados en compras ¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "P.A.P.P System")
            If resp = 6 Then
                btnSalir2.Visible = False
                btnSalir.Visible = True

                EliminarRegistroToolStripMenuItem.Enabled = False

                F_ListaProductos.eliminar()
                F_ListaProductos.eliminar_kardex()


                Dim total

                total = Val(txtCompra.Text) - 1

                txtCompra.Text = total

                Dim total2

                total2 = Val(txtN.Text) - 1

                txtN.Text = total2




                Me.Close()


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



    End Sub

    Private Sub btnSalir2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir2.MouseLeave
        btnSalir2.Visible = False
        btnSalir.Visible = True

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

    End Sub

    Private Sub btnSalir_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSalir.MouseMove
        btnSalir2.Visible = True
        btnSalir.Visible = False
    End Sub
End Class