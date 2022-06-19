Imports System.Data
Imports System.Data.SqlClient

Public Class F_MovimientosS

    Public AF As Boolean
    Public accion As String
    Public salir As String


    Sub limpiar()

        'lblFactura.Text = ""
        txtIdentidad.Text = ""
        txtNombres.Text = ""
        'ComboFase.Text = ""
        '  txtN_Desembolso.Text = ""
        'txtAgencia.Text = ""
        txtTotal.Text = ""
        'txtClave.Text = ""
        txtSaldo_Anterior.Text = ""
        txtMonto_Desembolsado.Text = ""
        txtCantidad_Disponible.Text = ""
        txtMonto_Aprobado.Text = ""

    End Sub

    Sub bloquear()


        txtIdentidad.Enabled = False
        txtNombres.Enabled = False
        ComboFase.Enabled = False
        txtN_Desembolso.Enabled = False
        txtAgencia.Enabled = False
        txtTotal.Enabled = False
        txtClave.Enabled = False
        txtAño.Enabled = False
        txtRegional.Enabled = False
        ComboFase.Enabled = False

        'Button1.Enabled = False
        ' Button2.Enabled = False

    End Sub

    Sub desbloquear()


        txtIdentidad.Enabled = True
        txtNombres.Enabled = True
        'ComboFase.Enabled = True
        'txtN_Desembolso.Enabled = True
        txtAgencia.Enabled = True
        txtTotal.Enabled = True
        txtClave.Enabled = True
        txtAño.Enabled = True
        'txtRegional.Enabled = True
        'ComboFase.Enabled = True


        'Button1.Enabled = True
        '  Button2.Enabled = True


    End Sub




    Private Sub btnNoSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoSave.Click

        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Guardar")

    End Sub

    Private Sub btnNoSave_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoSave.MouseEnter
        btnNoSave.Height = 45
        btnNoSave.Width = 45
    End Sub

    Private Sub btnNoSave_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoSave.MouseLeave
        btnNoSave.Height = 50
        btnNoSave.Width = 50
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click




        If txtIdentidad.Text <> "" And txtNombres.Text <> "" And txtTotal.Text <> "" And F_Lista_Insumos.txtDescripcion.Text <> "" Then

            salir = "S"


            Dim conexion As New Conexion_Ordenes
            Dim datos As New dOrdenes

            datos.N_Movimiento = txtN.Text
            datos.N_Orden = txtOrden.Text
            datos.fecha = lblfecha.Text
            datos.Tipo_Movimiento = ComboTipo.Text
            datos.Concepto_Movimiento = txtConcepto.Text
            datos.fase = ComboFase.Text
            datos.N_Regional = txtN_Regional.Text
            datos.N_Agencia = txtN_Agencia.Text
            datos.N_Prestamo = txtN_Prestamo.Text
            datos.año = txtAño.Text
            datos.N_Desembolso = txtN_Desembolso.Text
            datos.regional = txtRegional.Text
            datos.agencia = txtAgencia.Text
            datos.nombres = txtNombres.Text
            datos.identidad = txtIdentidad.Text
            datos.clave = txtClave.Text
            datos.total = txtTotal.Text
            datos.Monto_Aprobado = txtMonto_Aprobado.Text
            datos.Saldo_Anterior = txtSaldo_Anterior.Text
            datos.Monto_Desembolsado = txtMonto_Desembolsado.Text
            datos.Cantidad_Disponible = txtCantidad_Disponible.Text
            datos.Usuario = lblUsuario.Text

            If F_Menu_Movimientos.menu_salida = 1 Or F_Menu_Movimientos.menu_salida = 2 Then


                If AF = True Then

                    If conexion.insertar_datos_ordenes(datos) Then
                        If conexion.consultar_todos_ordenes Then
                            DataGridView2.DataSource = conexion.tabla

                        End If
                        My.Settings.MyOrden = txtOrden.Text
                        My.Settings.Save()
                        My.Settings.Reload()


                        My.Settings.MyMovimiento = txtN.Text
                        My.Settings.Save()
                        My.Settings.Reload()


        
                        MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        F_Lista_Insumos.limpiar()

                    Else

                        MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If


                    If AF = False Then
                        If conexion.actualizar_datos_ordenes(datos) Then
                            If conexion.consultar_todos_ordenes Then
                                DataGridView2.DataSource = conexion.tabla
                            End If
                            txtOrden.Text = My.Settings.MyOrden
                            txtN.Text = My.Settings.MyMovimiento
                            MessageBox.Show("REGISTRO ACTUALIZADO", "ACTUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("REGISTRO NO ACTUALIZADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If

                    End If

                End If

            End If

            If F_Menu_Movimientos.menu_salida = 3 Then

                If AF = True Then

                    If Val(txtTotal.Text) > Val(txtMonto_Desembolsado.Text) Then

                        MsgBox("Ha pasado el Limite de Desembolso", MsgBoxStyle.Critical, "P.A.P.P System")


                    ElseIf Val(txtTotal.Text) < Val(txtMonto_Desembolsado.Text) Then

                        MsgBox("No se ha completado el Desembolso Acordado", MsgBoxStyle.Critical, "P.A.P.P System")
                        salir = "A"


                    Else

                        If conexion.insertar_datos_ordenes(datos) Then
                            If conexion.consultar_todos_ordenes Then
                                DataGridView2.DataSource = conexion.tabla

                            End If
                            My.Settings.MyOrden = txtOrden.Text
                            My.Settings.Save()
                            My.Settings.Reload()


                            My.Settings.MyMovimiento = txtN.Text
                            My.Settings.Save()
                            My.Settings.Reload()



                            MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            F_Lista_Insumos.limpiar()


                            Dim resp As String



                            If Val(txtContador.Text) = 1 Then

                                resp = MsgBox("¿Desea Imprimir la Orden?", MsgBoxStyle.YesNo, "System IHCAFE")


                                If resp = 6 Then

                                    Dim conexion2 As New Conexion_Ordenes
                                    Dim datos2 As New dOrdenes
                                    Dim tabla As New DataTable
                                    Dim mireporte As New Crys_Ordenes

                                    datos.N_Orden = txtOrden.Text

                                    If conexion2.consultar_orden(datos) Then

                                        tabla = conexion2.tabla
                                        mireporte.SetDataSource(tabla)
                                        R_Ordenes.CrystalReportViewer1.ReportSource = mireporte
                                        R_Ordenes.CrystalReportViewer1.RefreshReport()
                                        R_Ordenes.Show()
                                    End If

                                End If

                            End If



                            If Val(txtContador.Text) = 2 Then

                                resp = MsgBox("Desea Imprimir la Factura", MsgBoxStyle.YesNo, "System IHCAFE")


                                If resp = 6 Then

                                    Dim conexion2 As New Conexion_Ordenes
                                    Dim datos2 As New dOrdenes
                                    Dim tabla As New DataTable
                                    Dim mireporte As New Crys_Factura

                                    datos.N_Orden = txtOrden.Text

                                    If conexion2.consultar_orden(datos) Then

                                        tabla = conexion2.tabla
                                        mireporte.SetDataSource(tabla)
                                        R_Factura.CrystalReportViewer1.ReportSource = mireporte
                                        R_Factura.CrystalReportViewer1.RefreshReport()
                                        R_Factura.Show()
                                    End If

                                End If

                            End If




                            txtBuscarPor.Enabled = True
                            txtCampoB.Enabled = True
                            DataGridView2.Visible = True
                            btnNuevo.Visible = False
                            btnNoNuevo.Visible = True

                            btnGuardar.Visible = False
                            btnNoSave.Visible = True
                            btnModificar.Visible = False
                            btnNoModificar.Visible = True
                            btnEliminar.Visible = False
                            btnNoEliminar.Visible = True



                            bloquear()


                        Else

                            MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        End If



                        If AF = False Then
                            If conexion.actualizar_datos_ordenes(datos) Then
                                If conexion.consultar_todos_ordenes Then
                                    DataGridView2.DataSource = conexion.tabla
                                End If
                                txtOrden.Text = My.Settings.MyOrden
                                txtN.Text = My.Settings.MyMovimiento
                                MessageBox.Show("REGISTRO ACTUALIZADO", "ACTUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Else
                                MessageBox.Show("REGISTRO NO ACTUALIZADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            End If

                        End If

                    End If

                End If

            End If



        Else

            
            If txtIdentidad.Text = "    -    -" Then

                txtIdentidad.BackColor = Color.OrangeRed

            Else
                txtIdentidad.BackColor = Color.White


            End If

            If txtNombres.Text = "" Then

                txtNombres.BackColor = Color.OrangeRed

            Else
                txtNombres.BackColor = Color.White

            End If


            If txtTotal.Text = "" Then

                txtTotal.BackColor = Color.OrangeRed

            Else
                txtTotal.BackColor = Color.White

            End If


            If F_Lista_Insumos.txtDescripcion.Text = "" Then

                MsgBox("Debe agregar productos para realizar la venta", MsgBoxStyle.Exclamation, "P.A.P.P System")

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

    Private Sub btnNoModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoModificar.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Modificar")

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
        btnNoSave.Visible = False
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True

        AF = False
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

    Private Sub btnNoEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoEliminar.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Eliminar")

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
        Dim conexion As New Conexion_Ordenes
        Dim datos As New dOrdenes

        datos.N_Movimiento = txtN.Text

        If conexion.borrar_datos_ordenes(datos) Then
            If conexion.consultar_todos_ordenes Then

                DataGridView2.DataSource = conexion.tabla
                'DataGridView1.DataSource = conexion.tabla

            End If

            MessageBox.Show("REGISTRO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MessageBox.Show("REGISTRO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


        Dim conexion2 As New Conexion_Kardex
        Dim datos2 As New dKardex

        datos.N_Movimiento = txtN.Text

        If conexion2.borrar_datos_kardex(datos2) Then
            If conexion2.consultar_todos_kardex Then


            End If

            MessageBox.Show("REGISTRO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            MessageBox.Show("REGISTRO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        limpiar()




        btnNuevo.Visible = True
        btnNoNuevo.Visible = False
        btnGuardar.Visible = False
        btnNoSave.Visible = True
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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

    End Sub

    

    Private Sub F_Factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        
        lblUsuario.Text = F_Menu.lblUsuario.Text
        lblfecha.Text = Format(Now(), "dd/MM/yyyy")
        lblaño.Text = Year(Now)
        txtAño.Text = Year(Now)
        Me.ContextMenuStrip = ContextMenuStrip1


        If F_Fase1.opcion = "D" Then


            Me.AñadirRegistroToolStripMenuItem.Enabled = True
            Me.EliminarRegistroToolStripMenuItem.Enabled = False

        Else

            Me.AñadirRegistroToolStripMenuItem.Enabled = False
            Me.EliminarRegistroToolStripMenuItem.Enabled = False


        End If


        If Val(txtN_Desembolso.Text) > 1 Then

            Dim t As Integer

            t = Val(txtMonto_Desembolsado.Text) + Val(txtCantidad_Disponible.Text)

            txtSaldo_Anterior.Text = t



        Else

            txtSaldo_Anterior.Text = "0"



        End If


        lblaño.Text = Year(Now)


        Dim conexion As New Conexion_Ordenes
        Dim tabla As New DataTable

        If conexion.consultar_todos_ordenes Then
            tabla = conexion.tabla
            DataGridView2.DataSource = tabla
        Else
            MessageBox.Show("No se pudo consultar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        bloquear()




      


        Dim total As Double


        Try
            For i As Integer = 0 To DataGridView1.RowCount - 1
                total = total + CDbl(DataGridView1.Item("Subtotal".ToLower, i).Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        txtTotal.Text = total

        bloquear()



    End Sub


    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDoubleClick

        Try

            txtN.Text = DataGridView2.SelectedCells(0).Value.ToString()
            txtOrden.Text = DataGridView2.SelectedCells(1).Value.ToString()
            lblfecha.Text = DataGridView2.SelectedCells(2).Value.ToString()

            txtTipo.Text = DataGridView2.SelectedCells(3).Value.ToString()
            txtConcepto.Text = DataGridView2.SelectedCells(4).Value.ToString()
            txtFase.Text = DataGridView2.SelectedCells(5).Value.ToString()
            ComboFase.Text = DataGridView2.SelectedCells(5).Value.ToString()
            txtN_Regional.Text = DataGridView2.SelectedCells(6).Value.ToString()
            txtN_Agencia.Text = DataGridView2.SelectedCells(7).Value.ToString()
            txtN_Prestamo.Text = DataGridView2.SelectedCells(8).Value.ToString()

            txtAño.Text = DataGridView2.SelectedCells(9).Value.ToString()
            txtN_Desembolso.Text = DataGridView2.SelectedCells(10).Value.ToString()
            txtRegional.Text = DataGridView2.SelectedCells(11).Value.ToString()
            txtAgencia.Text = DataGridView2.SelectedCells(12).Value.ToString()
            txtNombres.Text = DataGridView2.SelectedCells(13).Value.ToString()

            txtIdentidad.Text = DataGridView2.SelectedCells(14).Value.ToString()
            txtClave.Text = DataGridView2.SelectedCells(15).Value.ToString()
            txtTotal.Text = DataGridView2.SelectedCells(16).Value.ToString()
            txtMonto_Aprobado.Text = DataGridView2.SelectedCells(17).Value.ToString()
            txtSaldo_Anterior.Text = DataGridView2.SelectedCells(18).Value.ToString()

            txtMonto_Desembolsado.Text = DataGridView2.SelectedCells(19).Value.ToString()
            txtCantidad_Disponible.Text = DataGridView2.SelectedCells(20).Value.ToString()
            lblUsuario.Text = DataGridView2.SelectedCells(21).Value.ToString()



            btnModificar.Visible = False
            btnNoModificar.Visible = True
            btnEliminar.Visible = False
            btnNoEliminar.Visible = True
            btnNoNuevo.Visible = True
            btnNuevo.Visible = False

            Dim constr As String

            constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

            Dim con As New SqlConnection(constr)
            Dim ds As New DataSet
            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select * from Productos2 where N_Movimiento like '" & txtN.Text & "%'", con)


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
                For i As Integer = 0 To DataGridView1.RowCount - 1
                    total = total + CDbl(DataGridView1.Item("Subtotal".ToLower, i).Value)
                Next

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

            txtTotal.Text = total




            btnModificar.Visible = False
            btnNoModificar.Visible = True
            btnEliminar.Visible = False
            btnNoEliminar.Visible = True
            btnNoNuevo.Visible = True
            btnNuevo.Visible = False




            TabControl1.SelectedIndex = 0


        Catch ex As Exception
        End Try


    End Sub




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)





        F_EliminarS.Show()


    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



        F_ListaProductos.txtCompra.Text = txtOrden.Text

        F_ListaProductos.Show()

    End Sub



    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub txtAgencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAgencia.SelectedIndexChanged

    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub btnNoNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoNuevo.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Nuevo")
    End Sub

    Private Sub btnNoNuevo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoNuevo.MouseEnter
        btnNoNuevo.Height = 45
        btnNoNuevo.Width = 45
    End Sub


    Private Sub btnNoNuevo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoNuevo.MouseLeave
        btnNoNuevo.Height = 50
        btnNoNuevo.Width = 50
    End Sub




    Private Sub btnNuevo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.MouseEnter
        btnNuevo.Height = 45
        btnNuevo.Width = 45
    End Sub

    Private Sub btnNuevo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.MouseLeave
        btnNuevo.Height = 50
        btnNuevo.Width = 50
    End Sub



    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        F_Fases.Show()
    End Sub

    Private Sub txtBuscarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarPor.SelectedIndexChanged

    End Sub

    Private Sub AñadirRegistroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirRegistroToolStripMenuItem.Click

        F_Lista_Insumos.txtFactura.Text = txtOrden.Text
        F_Lista_Insumos.txtN.Text = txtN.Text
        F_Lista_Insumos.Show()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conexion As New Conexion_Kardex
        Dim datos As New dKardex

        datos.N_Movimiento = txtN.Text

        If conexion.borrar_datos_kardex(datos) Then
            If conexion.consultar_todos_kardex Then


            End If

            MessageBox.Show("REGISTRO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            MessageBox.Show("REGISTRO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        limpiar()

    End Sub

    Private Sub txtCampoB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCampoB.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable





        Dim da As New SqlDataAdapter("Select * from Ordenes Where " & txtBuscarPor.Text & " like '" & txtCampoB.Text & "%'", con)


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


    Private Sub txtConcepto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConcepto.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim conexion As New Conexion_Productos
        Dim datos As New dProductos

        datos.factura = txtOrden.Text

        If conexion.borrar_datos_productos2(datos) Then
            If conexion.consultar_todos_productos2 Then

                DataGridView2.DataSource = conexion.tabla
                'DataGridView1.DataSource = conexion.tabla

            End If

            MessageBox.Show("REGISTRO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MessageBox.Show("REGISTRO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub EliminarRegistroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarRegistroToolStripMenuItem.Click

        F_Lista_Insumos.limpiar()


        F_EliminarS.txtOrden.Text = txtN.Text
        

        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable



        Dim da As New SqlDataAdapter("Select * from Productos2 Where Factura like'" & txtOrden.Text & "%'", con)
    

        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            F_EliminarS.DataGridView1.DataSource = tabla


    

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing

            tabla = Nothing

        End Try



        F_EliminarS.txtOrden.Text = txtOrden.Text
        F_EliminarS.Show()

    End Sub

    Private Sub ComboFase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboFase.SelectedIndexChanged

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

        Dim conexion As New Conexion_Ordenes
        Dim datos As New dOrdenes



        Dim resp As Integer

        resp = MsgBox("¿Desea Imprimir la Orden?", MsgBoxStyle.YesNo, "P.A.P.P System")


        If resp = 6 Then

            Dim conexion2 As New Conexion_Ordenes
            Dim datos2 As New dOrdenes
            Dim tabla As New DataTable
            Dim mireporte As New Crys_Ordenes

            datos.N_Orden = txtOrden.Text

            If conexion2.consultar_orden(datos) Then

                tabla = conexion2.tabla
                mireporte.SetDataSource(tabla)
                R_Ordenes.CrystalReportViewer1.ReportSource = mireporte
                R_Ordenes.CrystalReportViewer1.RefreshReport()
                R_Ordenes.Show()
            End If

        End If

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

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



        Me.AñadirRegistroToolStripMenuItem.Enabled = True


        If F_Menu_Movimientos.menu_salida = 3 Then

            ' btnBuscar.Visible = True

        End If


        salir = "S"

        Me.ContextMenuStrip1.Enabled = True


        txtBuscarPor.Enabled = False
        txtCampoB.Enabled = False
        '  DataGridView2.Visible = False



        txtContador.Text = 2

        Dim total As Integer

        total = Val(txtOrden.Text) + 1

        txtOrden.Text = total


        Dim total2 As Integer

        total2 = Val(txtN.Text) + 1

        txtN.Text = total2



        btnNuevo.Visible = False
        btnNoNuevo.Visible = True
        btnGuardar.Visible = True
        btnNoSave.Visible = False
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True

        AF = True


        desbloquear()

    End Sub

    Private Sub btnSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir2.Click

        limpiar()


        If salir = "S" Then
            Dim resp As Integer
            resp = MsgBox("¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "P.A.P.P System")
            If resp = 6 Then
                btnSalir2.Visible = False
                btnSalir.Visible = True
                Me.Hide()
            End If
        ElseIf salir = "A" Then
            Dim resp As Integer
            resp = MsgBox("Debe eliminar los insumos cargados en compras ¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "P.A.P.P System")
            If resp = 6 Then
                btnSalir2.Visible = False
                btnSalir.Visible = True

                F_Lista_Insumos.eliminar()
                F_Lista_Insumos.eliminar_kardex()

                Dim total

                total = Val(txtOrden.Text) - 1

                txtOrden.Text = total

                Dim total2

                total2 = Val(txtN.Text) - 1

                txtN.Text = total2


                Me.Hide()

            End If
            End If

            btnNuevo.Visible = True
            btnNoNuevo.Visible = False
            btnGuardar.Visible = False
            btnNoSave.Visible = True
            btnModificar.Visible = False
            btnNoModificar.Visible = True
            btnEliminar.Visible = False
            btnNoEliminar.Visible = True


            txtContador.Text = 0
            txtOrden.Text = My.Settings.MyOrden
            txtN.Text = My.Settings.MyMovimiento


            If salir = "R" Then
            Dim resp As Integer
            resp = MsgBox("¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "P.A.P.P System")
            If resp = 6 Then
                btnSalir2.Visible = False
                btnSalir.Visible = True

                Me.Close()

            End If

        End If
        F_Fase1.btnGuardar.Visible = True
        F_Fase1.btnNoSave.Visible = False
        F_Fase1.btnNoEliminar.Visible = True
        F_Fase1.btnEliminar.Visible = False


        F_Fase1.btnSalir.Enabled = False
        F_Fase1.btnNoNuevo.Visible = True


        F_Fase1.PictureBox1.Visible = True
        F_Fase1.PictureBox3.Visible = True

        F_Fase1.btnSalir.Enabled = True


    End Sub

    Private Sub btnSalir2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir2.MouseLeave
        btnSalir2.Visible = False
        btnSalir.Visible = True

    End Sub

    Private Sub btnSalir_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSalir.MouseMove
        btnSalir2.Visible = True
        btnSalir.Visible = False

    End Sub
End Class