Imports System.Data.OleDb
Public Class SelectCiudad

    Private Sub SelectCiudad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarCiudades()
    End Sub
    Public Sub cargarCiudades()
        Try
            ciudad.Items.Clear()
            Dim conexion As New OleDbConnection()
            conexion.ConnectionString = "PROVIDER=Microsoft.jet.OLEDB.4.0;Data Source=" & frmhome.Ruta
            Dim comando As New OleDbCommand()
            comando.CommandText = "SELECT  Ciudad FROM contactos"
            comando.Connection = conexion
            conexion.Open()
            Dim dr As OleDbDataReader = comando.ExecuteReader()
            If dr.HasRows Then
                While dr.Read()
                    ciudad.Items.Add(dr("Ciudad").ToString())

                End While
            End If
            dr.Close()
        Catch RED As Exception
            MessageBox.Show(RED.Message.ToString())
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FormularioRPTciudad.ShowDialog()
    End Sub
End Class