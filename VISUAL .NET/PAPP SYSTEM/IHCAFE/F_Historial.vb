Imports System.Data.OleDb



Public Class F_Historial


    Private Sub F_Historial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim conexion As New Conexion_Usuarios
        Dim tabla As New DataTable

        If conexion.consultar_todos_historial Then
            tabla = conexion.tabla
            DataGridView1.DataSource = tabla
        Else
            MessageBox.Show("No se pudo consultar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        R_Historial.Show()

    End Sub
End Class