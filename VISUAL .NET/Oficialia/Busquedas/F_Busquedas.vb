Imports System.Data.SqlClient

Public Class F_Busquedas

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        F_Menu.Show()
        Me.Close()


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=OFICIALIA;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Solicitudes Where Persona_Inscrita like'" & txtNombre.Text & "%'", con)

        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            DataGridView1.DataSource = tabla


            Dim fila As Integer
            fila = DataGridView1.RowCount - 1


            lblExpediente.Text = fila

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing

            tabla = Nothing

        End Try

    End Sub

    Private Sub txtAño_TextChanged(sender As Object, e As EventArgs) Handles txtAño.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=OFICIALIA;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Solicitudes Where Fecha_Solicitud like'%" & txtAño.Text & "%'", con)

        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            DataGridView1.DataSource = tabla


            Dim fila As Integer
            fila = DataGridView1.RowCount - 1

            lblExpediente.Text = fila

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing

            tabla = Nothing

        End Try

    End Sub

    Private Sub txtSolicitud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSolicitud.SelectedIndexChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=OFICIALIA;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Solicitudes Where Tipo_Solicitud like'%" & txtSolicitud.Text & "%'", con)

        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            DataGridView1.DataSource = tabla


            Dim fila As Integer
            fila = DataGridView1.RowCount - 1


            lblExpediente.Text = fila

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing

            tabla = Nothing

        End Try

    End Sub

    Private Sub F_Busquedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class