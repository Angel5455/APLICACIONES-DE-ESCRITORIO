Imports System.Data.SqlClient

Public Class F_BuscarCliente

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Clientes Where Nombre like'%" & txtnombre.Text & "%'", con)

        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            DataGridView1.DataSource = tabla


            Dim fila As Integer
            fila = DataGridView1.RowCount - 1


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
            If Val(lblopcion.Text) = 1 Then

                F_Clientes.txtId.Text = DataGridView1.SelectedCells(0).Value.ToString()
                F_Clientes.txtnombre.Text = DataGridView1.SelectedCells(1).Value.ToString()
                F_Clientes.txtCelular.Text = DataGridView1.SelectedCells(2).Value.ToString()

                F_Clientes.Button1.Enabled = True
                F_Clientes.btnEliminar.Enabled = True
                F_Clientes.btnModificar.Enabled = True
                F_Clientes.btnGuardar.Enabled = False

            Else

                F_ControlRecargas.lblDinero.Text = 0
                F_ControlRecargas.CheckBox1.Checked = True
                F_ControlRecargas.txtnombre.Visible = True

                F_ControlRecargas.txtnombre.Text = DataGridView1.SelectedCells(1).Value.ToString()
                F_ControlRecargas.txtCelular.Text = DataGridView1.SelectedCells(2).Value.ToString()
                F_ControlRecargas.txtCantidad.Focus()

            End If

            If Val(lblopcion.Text) = 3 Then


                F_Control_Recargas_Claro.CheckBox1.Checked = True
                F_Control_Recargas_Claro.txtnombre.Visible = True

                F_Control_Recargas_Claro.txtnombre.Text = DataGridView1.SelectedCells(1).Value.ToString()
                F_Control_Recargas_Claro.txtCelular.Text = DataGridView1.SelectedCells(2).Value.ToString()
                F_Control_Recargas_Claro.txtCantidad.Focus()
            End If


            Me.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub F_BuscarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class