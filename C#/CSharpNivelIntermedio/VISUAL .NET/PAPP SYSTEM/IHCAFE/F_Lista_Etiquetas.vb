Imports System.Data
Imports System.Data.SqlClient


Public Class F_Lista_Etiquetas

    Private _cadena As String
    Private _conexion As SqlConnection

    Private _tabla As New DataTable
    Private _adaptador As SqlDataAdapter = New SqlDataAdapter
    Dim accion As Boolean



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

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Try
            txtCodigo.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value
            txtDescripcion.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(1).Value
            txtUnidad.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(3).Value
            PictureBox1.Visible = True


        Catch ex As Exception
        End Try

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        F_Etiquetas.BorrarRegistroToolStripMenuItem.Enabled = True
        F_Etiquetas.AñadirRegistroToolStripMenuItem.Enabled = False

        nuevo()
        F_Etiquetas.txtcodigo.Text = txtCodigo.Text

        Me.Hide()


    End Sub

    Sub nuevo()


        Dim conexion As New Conexion_Productos
        Dim datos As New dProductos



        datos.codigoE = txtCodigo.Text
        datos.insumoE = txtDescripcion.Text
        datos.unidadE = txtUnidad.Text
      


        If conexion.insertar_datos_etiquetas(datos) Then
            If conexion.consultar_todos_etiquetas Then

                F_Etiquetas.DataGridView1.DataSource = conexion.tabla

            End If

            MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub


    Private Sub F_Lista_Etiquetas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub eliminar()

        Dim conexion As New Conexion_Productos
        Dim datos As New dProductos

        datos.codigoE = txtCodigo.Text

        If conexion.borrar_datos_etiquetas(datos) Then
            If conexion.consultar_todos_etiquetas Then

                F_Etiquetas.DataGridView1.DataSource = conexion.tabla

            End If

            '   MessageBox.Show("REGISTRO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            '  MessageBox.Show("REGISTRO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        limpiar()


    End Sub


    Sub limpiar()

        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtUnidad.Text = ""

    End Sub

End Class