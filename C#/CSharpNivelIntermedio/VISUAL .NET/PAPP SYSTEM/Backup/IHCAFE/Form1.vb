Imports System.Data.OleDb

Public Class Form1

    Public Ruta As String = Application.StartupPath + "/Numero.accdb"


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim Mov As New OleDbConnection()
            Mov.ConnectionString = ("PROVIDER=Microsoft.ace.OLEDB.12.0;Data Source=" & Ruta)
            Dim Consulta As String = "Select * From Datos"
            Dim objAdap As New OleDbDataAdapter(Consulta, Mov)
            Dim Guardar As String = "insert into Datos( Numero) values ('" & TextBox1.Text & "')"
            Dim comando As New OleDbCommand(Guardar, Mov)
            comando.CommandType = CommandType.Text
            Mov.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Los Datos fueron guardados con exito", "Datos Guardados...")
            Mov.Close()
         
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

    End Sub
End Class