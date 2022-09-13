Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class F_Inventario

    Dim encontrado As Boolean
    Dim xSQL As New Conexion_Inventario
    Public accion As Boolean
    Dim resultado As MsgBoxResult

    Private Sub F_Inventario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        DataGridView1.Visible = False
    End Sub


    
    Private Sub F_Inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        '    txtcodigo.Text = My.Settings.MyInventario + 1


        txtDescripcion.Text = ""
        txtprecio.Text = ""


        


    End Sub



    Sub mostrar()

        Dim da As SqlDataAdapter = New SqlDataAdapter

        da.SelectCommand = New SqlCommand("Select * from Inventario", Conexion.conexion)
        Dim DS As New DataSet

        da.Fill(DS, "Inventario")

        F_Descripcion.DataGridView1.DataSource = DS.Tables("Inventario")


    End Sub


    Sub mostrar2()

        Dim da As SqlDataAdapter = New SqlDataAdapter

        da.SelectCommand = New SqlCommand("Select * from Inventario", Conexion.conexion)
        Dim DS As New DataSet

        da.Fill(DS, "Inventario")

        DataGridView1.DataSource = DS.Tables("Inventario")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click


        Dim conexion As New Conexion_Inventario
        Dim datos As New dInventario

        datos.codigo = txtcodigo.Text
        datos.descripcion = txtDescripcion.Text
        datos.precio = txtprecio.Text


        If accion = True Then
            If conexion.insertar_datos_Inventario(datos) Then

                mostrar()
                mostrar2()

                MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

                My.Settings.MyInventario = txtcodigo.Text
                My.Settings.Save()
                My.Settings.Reload()



                limpiar()

            Else

                MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If

        Else

            If accion = False Then

                If conexion.actualizar_datos_inventario(datos) Then
                    If conexion.consultar_todos_Inventario Then
                        DataGridView1.DataSource = conexion.tabla
                    End If
                    mostrar()
                    mostrar2()
                    MessageBox.Show("REGISTRO ACTUALIZADO", "ACTUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MessageBox.Show("REGISTRO NO ACTUALIZADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If

        End If

   
        limpiar()
        txtcodigo.Focus()

    End Sub


    Sub limpiar()


        '  txtcodigo.Text = My.Settings.MyInventario + 1

        txtcodigo.Clear()
        txtdescripcion.text = ""
        txtprecio.Text = ""


    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        btnGuardar.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True

    End Sub



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mostrar2()
        DataGridView1.Visible = True

    End Sub

    Private Sub txtcodigo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcodigo.Enter




    End Sub

    Private Sub txtcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

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

            txtdescripcion.text = ds.Tables(0).Rows(0).Item("Descripcion").ToString
            txtprecio.Text = ds.Tables(0).Rows(0).Item("Precio").ToString


            btnGuardar.Enabled = False
            btnModificar.Enabled = True
            btnEliminar.Enabled = True

        Else

            encontrado = False

            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            btnEliminar.Enabled = False

            '   MsgBox("No se encuentra los datos del Empleado, no se puede llenar la ficha", MsgBoxStyle.Critical, "Error")
            txtdescripcion.text = ""

        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        accion = False
        btnGuardar.Enabled = True
        btnEliminar.Enabled = False
        btnModificar.Enabled = False


    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim conexion As New Conexion_Inventario
        Dim datos As New dInventario

        datos.codigo = txtcodigo.Text

        If conexion.borrar_datos_inventario(datos) Then
            If conexion.consultar_todos_Inventario Then

                DataGridView1.DataSource = conexion.tabla
                mostrar()
            End If

            MessageBox.Show("PRODUCTO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            MessageBox.Show("PRODUCTO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        limpiar()


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Try
            txtcodigo.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
            txtdescripcion.text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            txtprecio.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value

            DataGridView1.Visible = False

            btnGuardar.Enabled = False
            btnModificar.Enabled = True
            btnEliminar.Enabled = True

        Catch ex As Exception
        End Try

    End Sub

    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

  
    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged

    End Sub


    Private Sub txtprecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprecio.TextChanged

    End Sub
End Class