Imports System.Data
Imports System.Data.SqlClient


Public Class F_Descripcion

    Private _cadena As String
    Private _conexion As SqlConnection

    Private _tabla As New DataTable
    Private _adaptador As SqlDataAdapter = New SqlDataAdapter
    Dim accion As Boolean


    Dim encontrado As Boolean
    ' Dim xSQL As New Conexion_Inventario

    Dim resultado As MsgBoxResult


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        txtCantidad.Enabled = False


        If txtdescripcion.Text <> "" And txtCantidad.Text <> "" And txtprecio.Text <> "" Then


            Dim conexion As New Conexion_Descripcion
            Dim datos As New dDescripcion
            datos.ticket = lblTicket.Text
            datos.descripcion = txtdescripcion.Text
            datos.cantidad = txtCantidad.Text
            datos.precio = txtprecio.Text
            datos.subtotal = txtsubtotal.Text


            If conexion.insertar_datos_descripcion(datos) Then
                If conexion.consultar_todos_descripcion Then
                    F_Tickets.dgv_Factura.DataSource = conexion.tabla

                End If


                '  MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


                txtcodigo.Focus()



                Dim constr As String

                constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

                Dim con As New SqlConnection(constr)
                Dim ds As New DataSet
                Dim tabla As New DataTable

                Dim da As New SqlDataAdapter("Select * from Descripcion where Ticket like '" & lblTicket.Text & "%'", con)


                Try

                    Dim cmd As New SqlCommand

                    da.Fill(tabla)
                    F_Tickets.dgv_Factura.DataSource = tabla

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
                    For i As Integer = 0 To F_Tickets.dgv_Factura.RowCount - 1
                        total = total + CDbl(F_Tickets.dgv_Factura.Item("Subtotal".ToLower, i).Value)
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try

                F_Tickets.txtTotal.Text = total


                F_Tickets.Show()
                Me.Hide()



            Else

                MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Else

            If txtdescripcion.Text = "" Then

                txtdescripcion.BackColor = Color.Gray

            Else

                txtdescripcion.BackColor = Color.White


            End If

            If txtCantidad.Text = "" Then

                txtCantidad.BackColor = Color.Gray

            Else


                txtCantidad.BackColor = Color.White

            End If


            If txtprecio.Text = "" Then

                txtprecio.BackColor = Color.Gray

            Else

                txtprecio.BackColor = Color.White


            End If

        End If


        txtcodigo.Focus()


    End Sub

    Sub limpiar()


        txtcodigo.Text = ""
        txtDescripcion.Text = ""
        txtCantidad.Text = ""
        txtprecio.Text = ""
        txtsubtotal.Text = ""



    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If


    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged
        Dim subtotal As Double

        subtotal = Val(txtprecio.Text) * Val(txtCantidad.Text)

        txtsubtotal.Text = subtotal
    End Sub

    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtprecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprecio.TextChanged
        Dim subtotal As Double

        subtotal = Val(txtprecio.Text) * Val(txtCantidad.Text)

        txtsubtotal.Text = subtotal
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If txtdescripcion.Text <> "" And txtCantidad.Text <> "" And txtprecio.Text <> "" Then


            Dim conexion As New Conexion_Descripcion
            Dim datos As New dDescripcion
            datos.ticket = lblTicket.Text
            datos.descripcion = txtdescripcion.Text
            datos.cantidad = txtCantidad.Text
            datos.precio = txtprecio.Text
            datos.subtotal = txtsubtotal.Text


            If conexion.insertar_datos_descripcion(datos) Then
                If conexion.consultar_todos_descripcion Then
                    F_Tickets.dgv_Factura.DataSource = conexion.tabla

                End If


                '  MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


                Dim constr As String

                constr = "Data Source=LAPSTUDIO;Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

                Dim con As New SqlConnection(constr)
                Dim ds As New DataSet
                Dim tabla As New DataTable

                Dim da As New SqlDataAdapter("Select * from Descripcion where Ticket like '" & lblTicket.Text & "%'", con)


                Try

                    Dim cmd As New SqlCommand

                    da.Fill(tabla)
                    F_Tickets.dgv_Factura.DataSource = tabla

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
                    For i As Integer = 0 To F_Tickets.dgv_Factura.RowCount - 1
                        total = total + CDbl(F_Tickets.dgv_Factura.Item("Subtotal".ToLower, i).Value)
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try

                F_Tickets.txtTotal.Text = total


                F_Tickets.Show()
                Me.Hide()



            Else

                MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Else

            If txtdescripcion.Text = "" Then

                txtdescripcion.BackColor = Color.Gray

            Else

                txtdescripcion.BackColor = Color.White


            End If

            If txtCantidad.Text = "" Then

                txtCantidad.BackColor = Color.Gray

            Else


                txtCantidad.BackColor = Color.White

            End If


            If txtprecio.Text = "" Then

                txtprecio.BackColor = Color.Gray

            Else

                txtprecio.BackColor = Color.White


            End If

        End If
    End Sub

    Private Sub txtcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

            txtCantidad.Enabled = True

        End If
    End Sub

    Private Sub txtcodigo_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtcodigo.MaskInputRejected

    End Sub

    Private Sub txtcodigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtcodigo.Validating
        Dim xConsulta As New SqlDataAdapter("select * from Inventario where Codigo = '" & txtcodigo.Text & "'", Conexion.conexion)
        Dim ds As New DataSet
        xConsulta.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then

            txtDescripcion.BackColor = Color.White

            encontrado = True

            txtDescripcion.Text = ds.Tables(0).Rows(0).Item("Descripcion").ToString
            txtprecio.Text = ds.Tables(0).Rows(0).Item("Precio").ToString


        Else

            encontrado = False


            '   MsgBox("No se encuentra los datos del Empleado, no se puede llenar la ficha", MsgBoxStyle.Critical, "Error")
            txtDescripcion.Text = ""

        End If
    End Sub

    Private Sub F_Descripcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DRptCREATIVOS.Inventario' Puede moverla o quitarla según sea necesario.
        Me.InventarioTableAdapter.Fill(Me.DRptCREATIVOS.Inventario)
        'TODO: esta línea de código carga datos en la tabla 'DRptCREATIVOS.Inventario' Puede moverla o quitarla según sea necesario.

        txtcodigo.Focus()


    End Sub

    Private Sub dgv_Factura_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged

    End Sub
End Class