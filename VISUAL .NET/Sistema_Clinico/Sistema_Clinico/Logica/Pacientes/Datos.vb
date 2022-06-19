Imports System.Data.SqlClient
Imports System
Imports System.Configuration


Module Datos
    Public Function Cargar() As DataTable

        Dim Cadena As String = "Data Source=(local);Initial Catalog=SystemLetona;Persist Security Info=True;User ID=sa;Password=root"
        Dim Conexion As New SqlConnection(Cadena)

            Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM Pacientes"
        Dim cmd As New SqlCommand(query, Conexion)
        Dim adap As New SqlDataAdapter(cmd)
            adap.Fill(dt)
            Return dt

    End Function



End Module
