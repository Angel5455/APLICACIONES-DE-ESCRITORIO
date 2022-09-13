
Imports System.Data.OleDb


Public Class F_EliminarItem

    Public conexion As OleDbConnection
    Public AdaptarDatos As New OleDbDataAdapter
    Public ObtenerDatos As DataSet


    Public iPosicfilaActual As Integer


    Dim n As Integer = 0
    Public Ruta As String = Application.StartupPath + "/Facturacion.accdb"

    Dim CN As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Facturacion.accdb")


    Sub eliminar()

        Dim CMD As New OleDb.OleDbCommand("DELETE FROM PRODUCTOS WHERE CODIGO= '" & txtCodigo.Text & "'", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        'limpiar()

        'cargar()


    End Sub

    Sub eliminar2()

        Dim CMD As New OleDb.OleDbCommand("DELETE FROM KARDEX WHERE CODIGO= '" & txtCodigo.Text & "'", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        'limpiar()

        'cargar()


    End Sub

    Sub Cargar()


        Dim DA As New OleDb.OleDbDataAdapter("Select * from PRODUCTOS", CN)
        Dim DS As New DataSet

        DA.Fill(DS, "CODIGO")
        txtCodigo.DataSource = DS.Tables("CODIGO")

        txtCodigo.DisplayMember = "CODIGO"

    End Sub



    Private Sub btnEliminar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.MouseEnter
        btnEliminar.Height = 45
        btnEliminar.Width = 45
    End Sub

    Private Sub btnEliminar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.MouseLeave
        btnEliminar.Height = 50
        btnEliminar.Width = 50
    End Sub

    Private Sub F_EliminarItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar()

    End Sub

    Private Sub txtCodigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.SelectedIndexChanged
        Dim CN2 As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Facturacion.accdb")
        CN2.Open()

        AdaptarDatos = New OleDbDataAdapter("Select * From Productos where Codigo like'%" & txtCodigo.Text & "%'", CN2)
        ObtenerDatos = New DataSet

        AdaptarDatos.Fill(ObtenerDatos, "PRODUCTOS")
        CN2.Close()

        DataGridView1.DataSource = ObtenerDatos
        DataGridView1.DataMember = "PRODUCTOS"

      

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        eliminar()
        eliminar2()
        Limpiar()

  
   


        F_Factura.mostrar()
        R_Impresion.Mostrar()

        Dim total As Double


        Try
            For i As Integer = 0 To F_Factura.DataGridView1.RowCount - 1
                total = total + CDbl(F_Factura.DataGridView1.Item("Sub_total".ToLower, i).Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        F_Factura.txtTotal.Text = total



    End Sub

    Sub Limpiar()

        txtCodigo.Text = ""
        txtDescripcion.Text = ""
    
        txtSubTotal.Text = ""

    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        Dim CN2 As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Facturacion.accdb")
        CN2.Open()

        AdaptarDatos = New OleDbDataAdapter("Select * From Productos where Detalle like'%" & txtDescripcion.Text & "%'", CN2)
        ObtenerDatos = New DataSet

        AdaptarDatos.Fill(ObtenerDatos, "PRODUCTOS")
        CN2.Close()

        DataGridView1.DataSource = ObtenerDatos
        DataGridView1.DataMember = "PRODUCTOS"

        
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

 
  

End Class