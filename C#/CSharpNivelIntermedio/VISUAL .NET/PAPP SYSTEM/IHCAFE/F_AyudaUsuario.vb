Imports System.Data.SqlClient

Public Class F_AyudaUsuario

    Private Sub txtcorreo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcorreo.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Login;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Usuarios where Correo like '" & txtcorreo.Text & "%'", con)


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

    Private Sub F_AyudaUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class