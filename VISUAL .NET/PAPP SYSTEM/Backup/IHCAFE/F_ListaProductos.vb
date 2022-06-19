Imports System.Data.OleDb



Public Class F_ListaProductos


    Public conexion As OleDbConnection
    Public AdaptarDatos As New OleDbDataAdapter
    Public ObtenerDatos As DataSet


    Public iPosicfilaActual As Integer


    Dim n As Integer = 0
    Public Ruta As String = Application.StartupPath + "/Facturacion.accdb"

    Dim CN As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Facturacion.accdb")

    Dim CN2 As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Inventario.accdb")


    Sub modificar()







    End Sub
    Sub nuevo()


        Dim CMD As New OleDb.OleDbCommand("INSERT INTO PRODUCTOS VALUES('" & txtFactura.Text & "','" & txtCodigo.Text & "','" & txtDescripcion.Text & "','" & txtUnidad.Text & "','" & txtCantidad.Text & "','" & txtPrecio.Text & "','" & txtSubTotal.Text & "')", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()


    End Sub

    Sub nuevo2()


        Dim CMD As New OleDb.OleDbCommand("INSERT INTO KARDEX VALUES('" & txtFactura.Text & "','" & txtCodigo.Text & "','" & txtDescripcion.Text & "','" & txtUnidad.Text & "','" & txtCantidad.Text & "','" & txtPrecio.Text & "','" & txtSubTotal.Text & "')", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()


    End Sub

    Sub eliminar()



        Dim CMD As New OleDb.OleDbCommand("DELETE FROM PRODUCTOS WHERE N_Factura= '" & txtFactura.Text & "'", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        limpiar()
        mostrar()






    End Sub

    Sub eliminar2()



        Dim CMD As New OleDb.OleDbCommand("DELETE FROM KARDEX WHERE N_Factura= '" & txtFactura.Text & "'", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        limpiar()
        mostrar()






    End Sub


    Sub mostrar()


        'Dim DA As New OleDb.OleDbDataAdapter("Select * from PRODUCTOS", CN)
        'Dim DS As New DataSet

        'DA.Fill(DS, "PRODUCTOS")

        'DataGridView1.DataSource = DS.Tables("PRODUCTOS")


    End Sub


    Sub limpiar()

        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtPrecio.Text = ""
        txtCantidad.Text = ""
        txtSubTotal.Text = ""



    End Sub






    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()

    End Sub














    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        PictureBox1.Height = 45
        PictureBox1.Width = 45
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        PictureBox1.Height = 50
        PictureBox1.Width = 50
    End Sub

    Private Sub txtCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.TextChanged

        Dim CN As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Inventario.accdb")
        CN.Open()

        AdaptarDatos = New OleDbDataAdapter("Select * From Insumos where Codigo like'%" & txtCodigo.Text & "%'", CN)
        ObtenerDatos = New DataSet

        AdaptarDatos.Fill(ObtenerDatos, "INSUMOS")
        CN.Close()

        DataGridView1.DataSource = ObtenerDatos
        DataGridView1.DataMember = "INSUMOS"



    End Sub


    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        Dim CN As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Inventario.accdb")
        CN.Open()

        AdaptarDatos = New OleDbDataAdapter("Select * From Insumos where Descripcion like'%" & txtDescripcion.Text & "%'", CN)
        ObtenerDatos = New DataSet

        AdaptarDatos.Fill(ObtenerDatos, "INSUMOS")
        CN.Close()

        DataGridView1.DataSource = ObtenerDatos
        DataGridView1.DataMember = "INSUMOS"

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        iPosicfilaActual = DataGridView1.CurrentCell.RowIndex
        CargarDatos()

    End Sub

    Sub CargarDatos()

        Dim NoRegistro As Integer
        NoRegistro = Me.ObtenerDatos.Tables("Insumos").Rows.Count
        If NoRegistro <> 0 Then
            Dim registro As DataRow
            registro = Me.ObtenerDatos.Tables("Insumos").Rows(Me.iPosicfilaActual)

            If Not IsDBNull(registro("Codigo")) Then
                Me.txtCodigo.Text = (registro("Codigo"))
            Else
                Me.txtCodigo.Text = ""
            End If

            If Not IsDBNull(registro("Descripcion")) Then
                Me.txtDescripcion.Text = (registro("Descripcion"))
            Else
                Me.txtDescripcion.Text = ""
            End If


            If Not IsDBNull(registro("Unidad")) Then
                Me.txtUnidad.Text = (registro("Unidad"))
            Else
                Me.txtUnidad.Text = ""
            End If


            If Not IsDBNull(registro("Precio")) Then
                Me.txtPrecio.Text = (registro("Precio"))
            Else
                Me.txtPrecio.Text = ""
            End If



            If Not IsDBNull(registro("Stock")) Then
                Me.TextBox1.Text = (registro("Stock"))
            Else
                Me.TextBox1.Text = ""
            End If

            If Not IsDBNull(registro("Proveedor")) Then
                Me.TextBox3.Text = (registro("Proveedor"))
            Else
                Me.TextBox3.Text = ""
            End If


        End If

    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged

        Dim total As Double = 0
        Dim total2 As Double = 0

        total = Val(txtCantidad.Text) * Val(txtPrecio.Text)

        txtSubTotal.Text = total

        total2 = Val(TextBox1.Text) - Val(txtCantidad.Text)
        TextBox2.Text = total2


    End Sub

    Private Sub F_ListaProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click



        If TextBox2.Text < 0 Then

            Dim resp As String


            resp = (MsgBox("¿Desea ir a Inventario?", MsgBoxStyle.YesNo, "No hay mas Productos...."))

            If resp = 6 Then

                F_Inventario.Show()
                F_Factura.Hide()


                Me.Hide()
               


            End If


        Else




            nuevo()
            nuevo2()
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


            F_Inventario.txtCodigo.Text = txtCodigo.Text
            F_Inventario.txtDescripcion.Text = txtDescripcion.Text
            F_Inventario.txtPrecio.Text = txtPrecio.Text
            F_Inventario.txtStock.Text = TextBox2.Text
            F_Inventario.txtProveedor.Text = TextBox3.Text


            limpiar()

            Me.Hide()

        End If
    End Sub
End Class