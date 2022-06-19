Imports System.Data.SqlClient


Public Class F_ListaSolicitudes

    Private Sub txtCampo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCampo.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Solicitud where Nombre like '" & txtCampo.Text & "%'", con)


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

            F_Productores.txtfase.Text = DataGridView1.SelectedCells(1).Value.ToString()
            F_Productores.txtclave.Text = DataGridView1.SelectedCells(2).Value.ToString()
            F_Productores.txtIdentidad.Text = DataGridView1.SelectedCells(3).Value.ToString()
            F_Productores.txtNombreP.Text = DataGridView1.SelectedCells(4).Value.ToString()
            F_Productores.txtMonto.Text = DataGridView1.SelectedCells(13).Value.ToString()
            F_Productores.txtmanzanas.Text = DataGridView1.SelectedCells(21).Value.ToString()

            Me.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class