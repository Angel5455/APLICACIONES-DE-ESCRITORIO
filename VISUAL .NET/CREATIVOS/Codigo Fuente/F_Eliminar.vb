Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class F_Eliminar

    Private Sub F_Eliminar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim constr As String

        constr = "Data Source=LAPSTUDIO;Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Descripcion where Ticket like '" & lblTicket.Text & "%'", con)


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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'F_Tickets.txtTotal.Text = ""



        Dim conexion As New Conexion_Descripcion
        Dim datos As New dDescripcion

        datos.descripcion = txtdescripcion.Text

        If conexion.borrar_datos_descripcion(datos) Then
            If conexion.consultar_todos_descripcion Then

                F_Tickets.DataGridView1.DataSource = conexion.tabla


            End If

            MessageBox.Show("PRODUCTO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            MessageBox.Show("PRODUCTO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If



        '''''

        Dim constr As String

        constr = "Data Source=LAPSTUDIO;Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable




        Dim da As New SqlDataAdapter("Select * from Descripcion Where Ticket like'" & lblTicket.Text & "%'", con)


        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            F_Tickets.DataGridView1.DataSource = tabla
            DataGridView1.DataSource = tabla

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
            For i As Integer = 0 To F_Tickets.DataGridView1.RowCount - 1
                total = total + CDbl(F_Tickets.DataGridView1.Item("Subtotal".ToLower, i).Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        F_Tickets.txtTotal.Text = total





        '      Me.Hide()




    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try

            txtdescripcion.Text = DataGridView1.SelectedCells(1).Value.ToString()

        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtdescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtdescripcion.TextChanged

    End Sub
End Class