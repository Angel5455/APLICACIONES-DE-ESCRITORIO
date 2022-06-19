Public Class F_Permisos

    Private Sub F_Permisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conexion As New Conexion_Usuarios
        Dim tabla As New DataTable

        If conexion.consultar_todos Then
            tabla = conexion.tabla
            DataGridView1.DataSource = tabla
        Else
            MessageBox.Show("No se pudo consultar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub
End Class