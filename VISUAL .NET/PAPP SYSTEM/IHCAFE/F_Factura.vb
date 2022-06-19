Imports System.Data
Imports System.Data.SqlClient

Public Class F_Factura

    Public AF As Boolean
    Public salir As String

    Sub limpiar()

        txtIdentidad.Text = ""
        txtNombres.Text = ""
        txtTotal.Text = ""


    End Sub

    Sub bloquear()


        ComboTipo.Enabled = False
        txtFactura.Enabled = False
        txtConcepto.Enabled = False
        txtIdentidad.Enabled = False
        txtNombres.Enabled = False
        txtTotal.Enabled = False
        txtAño.Enabled = False


    End Sub

    Sub desbloquear()

        'ComboTipo.Enabled = True
        '  txtFactura.Enabled = True
        'txtConcepto.Enabled = True
        txtIdentidad.Enabled = True
        txtNombres.Enabled = True
        txtTotal.Enabled = True

    End Sub


    Private Sub F_Factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        AñadirRegistroToolStripMenuItem.Enabled = False
        EliminarRegistroToolStripMenuItem.Enabled = False

        lblUsuario.Text = F_Menu.lblUsuario.Text
        lblfecha.Text = Format(Now(), "dd/MM/yyyy")
        txtAño.Text = Year(Now)
        Me.ContextMenuStrip = ContextMenuStrip1
        btnNuevo.Visible = True
        btnNoNuevo.Visible = False

        txtFactura.Text = My.Settings.MyFactura
        txtN.Text = My.Settings.MyMovimiento


        Dim conexion As New Conexion_Factura
        Dim tabla As New DataTable

        If conexion.consultar_todos_factura Then
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

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If txtIdentidad.Text <> "" And txtNombres.Text <> "" And txtTotal.Text <> "" And F_Lista_Factura.txtDescripcion.Text <> "" Then

            salir = "S"


            Dim conexion As New Conexion_Factura
            Dim datos As New dFactura

            datos.N_Movimiento = txtN.Text
            datos.factura = txtFactura.Text
            datos.fecha = lblfecha.Text
            datos.tipo_movimiento = txtTipo.Text
            datos.concepto_movimiento = txtConcepto.Text

            datos.nombre = txtNombres.Text
            datos.identidad = txtIdentidad.Text

            datos.total = txtTotal.Text


            If AF = True Then
                If conexion.insertar_datos_factura(datos) Then
                    If conexion.consultar_todos_factura Then
                        DataGridView2.DataSource = conexion.tabla

                    End If
                    My.Settings.MyFactura = txtFactura.Text
                    My.Settings.Save()
                    My.Settings.Reload()


                    My.Settings.MyMovimiento = txtN.Text
                    My.Settings.Save()
                    My.Settings.Reload()


                    F_Lista_Factura.limpiar()

                    MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    txtIdentidad.BackColor = Color.White
                    txtNombres.BackColor = Color.White
                    txtTotal.BackColor = Color.White


                    Dim resp As String


                    resp = MsgBox("¿Desea Imprimir la Factura?", MsgBoxStyle.YesNo, "P.A.P.P System")


                    If resp = 6 Then

                        Dim conexion2 As New Conexion_Factura
                        Dim datos2 As New dFactura
                        Dim tabla As New DataTable
                        Dim mireporte As New Crys_Factura

                        datos.factura = txtFactura.Text

                        If conexion2.consultar_factura(datos) Then

                            tabla = conexion2.tabla
                            mireporte.SetDataSource(tabla)
                            R_Factura.CrystalReportViewer1.ReportSource = mireporte
                            R_Factura.CrystalReportViewer1.RefreshReport()
                            R_Factura.Show()
                        End If

                    End If




                Else

                    MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If



                If AF = False Then
                    If conexion.actualizar_datos_factura(datos) Then
                        If conexion.consultar_todos_factura Then
                            DataGridView2.DataSource = conexion.tabla
                        End If
                        txtFactura.Text = My.Settings.MyFactura
                        txtN.Text = My.Settings.MyMovimiento
                        MessageBox.Show("REGISTRO ACTUALIZADO", "ACTUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("REGISTRO NO ACTUALIZADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

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


            If F_Lista_Factura.txtDescripcion.Text = "" Then

                MsgBox("Debe agregar productos para realizar la venta", MsgBoxStyle.Exclamation, "P.A.P.P System")

            Else


            End If


        End If




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

    Private Sub btnGuardar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.MouseEnter
        btnGuardar.Height = 45
        btnGuardar.Width = 45
    End Sub

    Private Sub btnGuardar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.Height = 50
        btnGuardar.Width = 50
    End Sub

    Private Sub btnNoModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoModificar.Click

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
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Modificar")
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


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Me.AñadirRegistroToolStripMenuItem.Enabled = True


        salir = "S"

        Me.ContextMenuStrip1.Enabled = True


        txtBuscarPor.Enabled = False
        txtCampoB.Enabled = False
        '  DataGridView2.Visible = False


        AF = True

        txtContador.Text = 2

        Dim total As Integer

        total = Val(txtFactura.Text) + 1

        txtFactura.Text = total


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


        desbloquear()
        limpiar()


        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable





        Dim da As New SqlDataAdapter("Select * from Facturas Where Factura like'" & txtFactura.Text & "%'", con)


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

    Private Sub AñadirRegistroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirRegistroToolStripMenuItem.Click

        F_Lista_Factura.txtFactura.Text = txtFactura.Text
        F_Lista_Factura.txtN.Text = txtN.Text
        F_Lista_Factura.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim conexion As New Conexion_Factura
        Dim datos As New dFactura

        datos.factura = txtFactura.Text

        If conexion.borrar_datos_factura(datos) Then
            If conexion.consultar_todos_factura Then

                F_MovimientosE.DataGridView1.DataSource = conexion.tabla

            End If

            MessageBox.Show("REGISTRO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            MessageBox.Show("REGISTRO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        limpiar()

    End Sub

    Private Sub EliminarRegistroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarRegistroToolStripMenuItem.Click

        F_Lista_Factura.limpiar()


        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable


        Dim da As New SqlDataAdapter("Select * from Productos3 Where Factura like'" & txtFactura.Text & "%'", con)

        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            F_EliminarF.DataGridView1.DataSource = tabla

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing

            tabla = Nothing

        End Try



        F_EliminarF.txtFactura.Text = txtFactura.Text
        F_EliminarF.Show()

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDoubleClick

        Try

            txtN.Text = DataGridView2.SelectedCells(0).Value.ToString()
            txtFactura.Text = DataGridView2.SelectedCells(1).Value.ToString()

            lblfecha.Text = DataGridView2.SelectedCells(2).Value.ToString()

            txtTipo.Text = DataGridView2.SelectedCells(3).Value.ToString()

            txtConcepto.Text = DataGridView2.SelectedCells(4).Value.ToString()
            txtIdentidad.Text = DataGridView2.SelectedCells(5).Value.ToString()
            txtNombres.Text = DataGridView2.SelectedCells(6).Value.ToString()
            txtTotal.Text = DataGridView2.SelectedCells(7).Value.ToString()


            Dim constr As String

            constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

            Dim con As New SqlConnection(constr)
            Dim ds As New DataSet
            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select * from Productos3 where Factura like '" & txtFactura.Text & "%'", con)


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
            btnNoSave.Visible = True

            btnNoNuevo.Visible = True
            btnNuevo.Visible = False


            'End If

            salir = "S"
            TabControl1.SelectedIndex = 0


        Catch ex As Exception
        End Try

    End Sub

    Private Sub btnSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir2.Click

        limpiar()


        If salir = "S" Then

            Dim resp As Integer

            resp = MsgBox("¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "P.A.P.P System")
            If resp = 6 Then
                btnSalir2.Visible = False
                btnSalir.Visible = True
                Me.Close()

            End If

            

        ElseIf salir = "A" Then

            Dim resp As Integer

            resp = MsgBox("¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "P.A.P.P System")
            If resp = 6 Then

                F_Lista_Factura.eliminar()
                F_Lista_Factura.eliminar_kardex()

                Dim total

                total = Val(txtFactura.Text) - 1

                txtFactura.Text = total

                Dim total2

                total2 = Val(txtN.Text) - 1

                txtN.Text = total2

                btnSalir2.Visible = False
                btnSalir.Visible = True

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
            txtN.Text = My.Settings.MyMovimiento


            If salir = "R" Then

            Dim resp As Integer

            resp = MsgBox("¿Esta Seguro de Salir?", MsgBoxStyle.YesNo, "P.A.P.P System")
            If resp = 6 Then
                btnSalir2.Visible = False
                btnSalir.Visible = True

                Me.Close()

            End If

        End If


    End Sub

   

    Private Sub btnSalir2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir2.MouseLeave
     

        btnSalir.Visible = True
        btnSalir2.Visible = False
    End Sub

    Private Sub btnSalir_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSalir.MouseMove
        btnSalir.Visible = False
        btnSalir2.Visible = True
    End Sub
End Class