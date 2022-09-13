Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class F_BuscarE

    Dim encontrado As Boolean
    Dim xSQL As New Conexion_Empleados
    Public accion As Boolean
    Dim resultado As MsgBoxResult

    Private Sub F_BuscarE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable




        Dim da As New SqlDataAdapter("Select * from Empleados Where codigo like'%" & txtCodigo.Text & "%'", con)


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

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable




        Dim da As New SqlDataAdapter("Select * from Empleados Where nombre like'%" & txtnombre.Text & "%'", con)


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
        F_Empleados.txtcodigo.Text = DataGridView1.SelectedCells(0).Value.ToString()
        F_Empleados.txtnombre.Text = DataGridView1.SelectedCells(1).Value.ToString()

        F_Empleados.Button1.Enabled = True
        F_Empleados.btnEliminar.Enabled = True
        F_Empleados.btnModificar.Enabled = True
        F_Empleados.btnGuardar.Enabled = False

        Me.Close()

    End Sub
End Class