Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class F_BuscarI

    Dim encontrado As Boolean

    Public accion As Boolean
    Dim resultado As MsgBoxResult

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable




        Dim da As New SqlDataAdapter("Select * from Inventario Where codigo like'%" & txtCodigo.Text & "%'", con)


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

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Try
            F_Inventario.txtcodigo.Text = DataGridView1.SelectedCells(0).Value.ToString()
            F_Inventario.txtDescripcion.Text = DataGridView1.SelectedCells(1).Value.ToString()
            F_Inventario.txtprecio.Text = DataGridView1.SelectedCells(3).Value.ToString()

            F_Inventario.btnEliminar.Enabled = True
            F_Inventario.btnModificar.Enabled = True
            F_Inventario.btnGuardar.Enabled = False

            F_Inventario.txtcodigo.Enabled = True
            F_Inventario.txtDescripcion.Enabled = True
            F_Inventario.txtprecio.Enabled = True

            If F_Tickets.TICKET = True Then
                F_Tickets.dgv_Factura.Item(0, F_Tickets.dgv_Factura.CurrentRow.Index).Value = "..."
                F_Tickets.dgv_Factura.Item(1, F_Tickets.dgv_Factura.CurrentRow.Index).Value = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                F_Tickets.dgv_Factura.Item(2, F_Tickets.dgv_Factura.CurrentRow.Index).Value = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                F_Tickets.dgv_Factura.Item(4, F_Tickets.dgv_Factura.CurrentRow.Index).Value = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value


            End If


            Me.Close()



        Catch ex As Exception

        End Try


    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable




        Dim da As New SqlDataAdapter("Select * from Inventario Where Descripcion like'%" & txtnombre.Text & "%'", con)


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

    Private Sub F_BuscarI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable




        Dim da As New SqlDataAdapter("Select * from Inventario Where Descripcion like'%" & "" & "%'", con)


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
End Class