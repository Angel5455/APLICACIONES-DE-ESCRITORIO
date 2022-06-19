
Imports System.Data.OleDb



Public Class R_Impresion
    Public conexion As OleDbConnection
    Public AdaptarDatos As New OleDbDataAdapter
    Public ObtenerDatos As DataSet


    Public iPosicfilaActual As Integer


    Dim n As Integer = 0


    Dim CN2 As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Facturacion.accdb")

    Dim CN As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Ordenes.accdb")


    Private Sub R_Fase1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim total As Double

        total = Val(lblMonto_Desembolsado.Text) - Val(lblTotal.Text)

        lblCantidad_Disponible.Text = total


        lblr.Text = 1
        lblaño.Text = Year(Today)


    End Sub


    Sub nuevo()


        Dim CMD As New OleDb.OleDbCommand("INSERT INTO DATOS VALUES('" & Picturebox6.Text & "','" & lblFase.Text & "','" & lblr.Text & "','" & lbla.Text & "','" & lblpres.Text & "','" & lblaño.Text & "','" & lbld.Text & "','" & lblRegional.Text & "','" & lblAgencia.Text & "','" & lblNombre.Text & "','" & lblIdentidad.Text & "','" & lblClave.Text & "','" & lblMonto_Aprobado.Text & "','" & lblSaldo_Anterior.Text & "','" & lblMonto_Desembolsado.Text & "','" & lblCantidad_Disponible.Text & "')", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        MsgBox("REGISTRO AGREGADO", MsgBoxStyle.Information, "IHCAFE")



    End Sub


    Sub Mostrar()




        Dim DA As New OleDb.OleDbDataAdapter("Select * from PRODUCTOS", CN2)
        Dim DS As New DataSet

        DA.Fill(DS, "PRODUCTOS")

        DataGridView1.DataSource = DS.Tables("PRODUCTOS")


    End Sub


    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picturebox6.Click


    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

        nuevo()

        R_Ordenes.Show()





    End Sub

    Sub eliminar()


        Dim CMD As New OleDb.OleDbCommand("DELETE FROM DATOS WHERE ID= '" & Picturebox6.Text & "'", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()

    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

       
        eliminar()
        F_ListaProductos.eliminar()
        Mostrar()

        F_Factura.mostrar()


        Me.Hide()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub PictureBox5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Height = 45
        PictureBox5.Height = 45
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Height = 50
        PictureBox5.Height = 50
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Height = 45
        PictureBox1.Height = 45
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Height = 50
        PictureBox1.Height = 50
    End Sub
End Class