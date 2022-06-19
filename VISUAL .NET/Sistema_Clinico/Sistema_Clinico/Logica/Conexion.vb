Imports System.Data.SqlClient

Module Conexion
    Public Cadena As String = "Data Source=(local);Initial Catalog=SystemLetona;Persist Security Info=True;User ID=sa;Password=root"
    Public Conexion As New SqlConnection(Cadena)



    Public Sub Abrir()
        Try
            Conexion.Open()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Cerrar()

        Conexion.Close()

    End Sub

    Public Function IsConfirm(ByVal message As String) As Boolean
        Return MessageBox.Show(message, "Confirmar ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    'Public Function QueryAsDataTable(ByVal sql As String) As DataTable
    '    Dim da As New SqlDataAdapter(sql, Conexion)
    '    Dim ds As New DataSet
    '    da.Fill(ds)
    '    Return ds.Tables("Calendario")
    'End Function

    Public Function InsertUpdateDelete(ByVal sql As String) As Boolean
        Abrir()
        Dim cmd As New SqlCommand(sql, Conexion)
        Return cmd.ExecuteNonQuery() > 0
    End Function
End Module