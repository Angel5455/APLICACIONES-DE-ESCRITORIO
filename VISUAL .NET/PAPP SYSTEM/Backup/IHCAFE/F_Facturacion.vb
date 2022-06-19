Imports System.Data.OleDb



Public Class F_Facturacion
    Public conexion As OleDbConnection
    Public AdaptarDatos As New OleDbDataAdapter
    Public ObtenerDatos As DataSet


    Public iPosicfilaActual As Integer


    Dim n As Integer = 0
    Public Ruta As String = Application.StartupPath + "/Facturacion.accdb"

    Dim CN As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Facturacion.accdb")


    Sub mostrar()


        Dim DA As New OleDb.OleDbDataAdapter("Select * from PRODUCTOS", CN)
        Dim DS As New DataSet

        DA.Fill(DS, "PRODUCTOS")

        DataGridView1.DataSource = DS.Tables("PRODUCTOS")


    End Sub


    Sub limpiar()

        'lblFactura.Text = ""
        txtIdentidad.Text = ""
        txtNombres.Text = ""
        txtFase.Text = ""
        txtN_Desembolso.Text = ""
        txtAgencia.Text = ""
        txtTotal.Text = ""


    End Sub

    Sub bloquear()


        txtIdentidad.Enabled = False
        txtNombres.Enabled = False
        txtFase.Enabled = False
        txtN_Desembolso.Enabled = False
        txtAgencia.Enabled = False
        txtTotal.Enabled = False
        'Button1.Enabled = False
        ' Button2.Enabled = False


    End Sub

    Sub desbloquear()


        txtIdentidad.Enabled = True
        txtNombres.Enabled = True
        txtFase.Enabled = True
        txtN_Desembolso.Enabled = True
        txtAgencia.Enabled = True
        txtTotal.Enabled = True
        'Button1.Enabled = True
        '  Button2.Enabled = True


    End Sub


    Private Sub btnNoNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoNuevo.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Nuevo")

    End Sub

    Private Sub btnNoNuevo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoNuevo.MouseEnter
        btnNoNuevo.Height = 45
        btnNoNuevo.Width = 45
    End Sub


    Private Sub btnNoSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoSave.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Guardar")

    End Sub

    Private Sub btnNoSave_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoSave.MouseEnter
        btnNoSave.Height = 45
        btnNoSave.Width = 45
    End Sub

    Private Sub btnNoSave_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoSave.MouseLeave
        btnNoSave.Height = 50
        btnNoSave.Width = 50
    End Sub

    Private Sub btnNuevo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.MouseEnter
        btnNuevo.Height = 45
        btnNuevo.Width = 45
    End Sub

    Private Sub btnNoEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoEliminar.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Eliminar")

    End Sub

    Private Sub btnNoEliminar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoEliminar.MouseEnter
        btnNoEliminar.Height = 45
        btnNoEliminar.Width = 45
    End Sub

    Private Sub btnNoEliminar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoEliminar.MouseLeave
        btnNoEliminar.Height = 50
        btnNoEliminar.Width = 50
    End Sub

    Private Sub btnEliminar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.MouseEnter
        btnEliminar.Height = 45
        btnEliminar.Width = 45
    End Sub

    Private Sub btnEliminar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.MouseLeave
        btnEliminar.Height = 50
        btnEliminar.Width = 50
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        F_ListaProductos.eliminar()
        F_ListaProductos.eliminar2()
        Me.Hide()

    End Sub

    Private Sub btnSalir_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.MouseEnter
        btnSalir.Height = 45
        btnSalir.Width = 45
    End Sub

    Private Sub btnSalir_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.MouseLeave
        btnSalir.Height = 50
        btnSalir.Width = 50
    End Sub

    Private Sub F_Facturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     

        Dim total As Double


        Try
            For i As Integer = 0 To DataGridView1.RowCount - 1
                total = total + CDbl(DataGridView1.Item("Sub_total".ToLower, i).Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        txtTotal.Text = total

        bloquear()

        txtFecha.Text = Format(Now(), "dd/MM/yyyy")

    End Sub

    Private Sub ComboFactura_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboFactura.SelectedIndexChanged
        Dim CN As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Facturacion.accdb")
        CN.Open()

        AdaptarDatos = New OleDbDataAdapter("Select * From Factura where N_Factura like'%" & ComboFactura.Text & "%'", CN)
        '  AdaptarDatos = New OleDbDataAdapter("Select * From Kardex where N_Factura like'%" & ComboFactura.Text & "%'", CN)

        ObtenerDatos = New DataSet

        AdaptarDatos.Fill(ObtenerDatos, "FACTURA")
        ' AdaptarDatos.Fill(ObtenerDatos, "KARDEX")

        CN.Close()

        DataGridView2.DataSource = ObtenerDatos
        DataGridView2.DataMember = "FACTURA"



        'DataGridView3.DataSource = ObtenerDatos
        ' DataGridView3.DataMember = "KARDEX"

    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        Dim CN As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Facturacion.accdb")
        CN.Open()

        AdaptarDatos = New OleDbDataAdapter("Select * From Factura where Nombres like'%" & txtNombre.Text & "%'", CN)
        ObtenerDatos = New DataSet

        AdaptarDatos.Fill(ObtenerDatos, "FACTURA")
        CN.Close()

        DataGridView2.DataSource = ObtenerDatos
        DataGridView2.DataMember = "FACTURA"

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDoubleClick

        txtFecha.Text = DataGridView2.SelectedCells(1).Value.ToString()
        txtIdentidad.Text = DataGridView2.SelectedCells(2).Value.ToString()

        txtNombres.Text = DataGridView2.SelectedCells(3).Value.ToString()
        txtFase.Text = DataGridView2.SelectedCells(4).Value.ToString()
        txtN_Desembolso.Text = DataGridView2.SelectedCells(5).Value.ToString()
        txtAgencia.Text = DataGridView2.SelectedCells(6).Value.ToString()
        ' txtTotal.Text = DataGridView2.SelectedCells(7).Value.ToString()

        btnEliminar.Visible = True
        btnNoEliminar.Visible = False



        Dim CN As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Facturacion.accdb")
        CN.Open()

        AdaptarDatos = New OleDbDataAdapter("Select * From Kardex where N_Factura like'%" & ComboFactura.Text & "%'", CN)

        ObtenerDatos = New DataSet

        AdaptarDatos.Fill(ObtenerDatos, "KARDEX")

        CN.Close()



        DataGridView1.DataSource = ObtenerDatos
        DataGridView1.DataMember = "KARDEX"


        Dim total As Double = 0

        ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  

        Try
            For i As Integer = 0 To DataGridView1.RowCount - 1
                total = total + CDbl(DataGridView1.Item("total".ToLower, i).Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        txtTotal.Text = total




        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        n = 1
        Button2.Enabled = True



        F_ListaProductos.Show()
    End Sub
End Class