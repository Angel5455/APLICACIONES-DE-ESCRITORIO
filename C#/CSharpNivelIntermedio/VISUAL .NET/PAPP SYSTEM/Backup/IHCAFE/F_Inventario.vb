Imports System.Data.OleDb


Public Class F_Inventario

    Public conexion As OleDbConnection
    Public AdaptarDatos As New OleDbDataAdapter
    Public ObtenerDatos As DataSet





    Dim n As Integer = 0
    Public Ruta As String = Application.StartupPath + "/Inventario.accdb"

    Dim CN As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Inventario.accdb")

    Sub cargar()

        Dim DA As New OleDb.OleDbDataAdapter("Select * from INSUMOS", CN)
        Dim DS As New DataSet

        DA.Fill(DS, "INSUMOS")
        txtCodigo.DataSource = DS.Tables("INSUMOS")

        txtCodigo.DisplayMember = "Codigo"



    End Sub


    Sub nuevo()


        Dim cmd As New OleDb.OleDbCommand("INSERT INTO INSUMOS VALUES('" & txtCodigo.Text & "','" & txtDescripcion.Text & "','" & txtUnidad.Text & "','" & txtStock.Text & "','" & txtPrecio.Text & "','" & txtProveedor.Text & "')", CN)

        CN.Open()
        cmd.ExecuteNonQuery()
        CN.Close()
        MsgBox("REGISTRO AGREGADO", MsgBoxStyle.Information, "IHCAFE")


    End Sub

    Sub modificar()



        Dim CMD As New OleDb.OleDbCommand("UPDATE INSUMOS SET CODIGO='" & txtCodigo.Text & "',DESCRIPCION='" & txtDescripcion.Text & "',UNIDAD='" & txtUnidad.Text & "',STOCK='" & txtStock.Text & "',PRECIO='" & txtPrecio.Text & "',PROVEEDOR='" & txtProveedor.Text & "' WHERE CODIGO='" & txtCodigo.Text & "'", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()

        MsgBox("REGISTRO ACTUALIZADO", MsgBoxStyle.Information, "IHCAFE")


    End Sub

    Sub eliminar()



        Dim CMD As New OleDb.OleDbCommand("DELETE FROM INSUMOS WHERE CODIGO= '" & txtCodigo.Text & "'", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        limpiar()
        mostrar()
        cargar()



        MsgBox("EL REGISTRO A SIDO ELIMINADO", MsgBoxStyle.Information, "IHCAFE")




    End Sub


    Sub mostrar()


        Dim DA As New OleDb.OleDbDataAdapter("Select * from INSUMOS", CN)
        Dim DS As New DataSet

        DA.Fill(DS, "INSUMOS")

        DataGridView1.DataSource = DS.Tables("INSUMOS")


    End Sub


    Sub limpiar()

        txtCodigo.Text = ""
        txtDescripcion.Text = ""
        txtUnidad.Text = ""
        txtPrecio.Text = ""
        txtProveedor.Text = ""
        txtStock.Text = ""


    End Sub

    Sub bloquear()


        txtDescripcion.Enabled = False
        txtUnidad.Enabled = False
        txtPrecio.Enabled = False
        txtProveedor.Enabled = False
        txtStock.Enabled = False

    End Sub

    Sub desbloquear()


        txtDescripcion.Enabled = True
        txtUnidad.Enabled = True
        txtPrecio.Enabled = True
        txtProveedor.Enabled = True
        txtStock.Enabled = True


    End Sub
    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click

        Dim CMD As New OleDb.OleDbCommand("Select * from INSUMOS where Codigo= '" & txtCodigo.Text & "'", CN)
        Dim DR As OleDb.OleDbDataReader


        CN.Open()
        DR = CMD.ExecuteReader

        If DR.Read Then

            txtDescripcion.Text = DR(1)
            txtUnidad.Text = DR(2)
            txtStock.Text = DR(3)
            txtPrecio.Text = DR(4)
            txtProveedor.Text = DR(5)

        Else
            MsgBox("ERROR")

        End If

        CN.Close()

        btnModificar.Visible = True
        btnNoModificar.Visible = False
        btnEliminar.Visible = True
        btnNoEliminar.Visible = False


    End Sub

    Private Sub PictureBox7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseEnter
        PictureBox7.Height = 45
        PictureBox7.Width = 45
    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseLeave
        PictureBox7.Height = 50
        PictureBox7.Width = 50
    End Sub

    Private Sub btnNoNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoNuevo.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Nuevo")
    End Sub

    Private Sub btnNoNuevo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoNuevo.MouseEnter
        btnNoNuevo.Height = 45
        btnNoNuevo.Width = 45
    End Sub

    Private Sub btnNoNuevo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoNuevo.MouseLeave
        btnNoNuevo.Height = 50
        btnNoNuevo.Width = 50
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        btnNuevo.Visible = False
        btnNoNuevo.Visible = True
        btnGuardar.Visible = True
        btnNoSave.Visible = False
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True

        desbloquear()
        limpiar()

        n = 1
    End Sub

    Private Sub btnNuevo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.MouseEnter
        btnNuevo.Height = 45
        btnNuevo.Width = 45
    End Sub

    Private Sub btnNuevo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.MouseLeave
        btnNuevo.Height = 50
        btnNuevo.Width = 50
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

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        btnNuevo.Visible = True
        btnNoNuevo.Visible = False


        btnGuardar.Visible = False
        btnNoSave.Visible = True
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True


        If n = 1 Then

            nuevo()

        ElseIf n = 2 Then

            modificar()


        End If



        bloquear()
        limpiar()
        mostrar()

        n = 0


    End Sub

    Private Sub btnGuardar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.MouseEnter
        btnGuardar.Height = 45
        btnGuardar.Width = 45
    End Sub

    Private Sub btnGuardar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.Height = 50
        btnGuardar.Width = 50
    End Sub

    Private Sub btnNoModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoModificar.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Modificar")
    End Sub

    Private Sub btnNoModificar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoModificar.MouseEnter
        btnNoModificar.Height = 45
        btnNoModificar.Width = 45
    End Sub

    Private Sub btnNoModificar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoModificar.MouseLeave
        btnNoModificar.Height = 50
        btnNoModificar.Width = 50
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        btnNuevo.Visible = False
        btnNoNuevo.Visible = True


        btnGuardar.Visible = True
        btnNoSave.Visible = False
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True

        desbloquear()
        n = 2

    End Sub

    Private Sub btnModificar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.MouseEnter
        btnModificar.Height = 45
        btnModificar.Width = 45
    End Sub

    Private Sub btnModificar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.MouseLeave
        btnModificar.Height = 50
        btnModificar.Width = 50
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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
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

    Private Sub btnNoBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoBuscar.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Buscar")
    End Sub

    Private Sub btnNoBuscar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoBuscar.MouseEnter
        btnNoBuscar.Height = 45
        btnNoBuscar.Width = 45
    End Sub

    Private Sub btnNoBuscar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoBuscar.MouseLeave
        btnNoBuscar.Height = 50
        btnNoBuscar.Width = 50
    End Sub

    Private Sub F_Inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bloquear()
        mostrar()
        cargar()

    End Sub

    Private Sub txtCodigo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigo.SelectedIndexChanged

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        eliminar()


        btnNuevo.Visible = True
        btnNoNuevo.Visible = False

        btnGuardar.Visible = False
        btnNoSave.Visible = True
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True
    End Sub

    Private Sub txtNombreP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CN2 As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Inventario.accdb")

        CN2.Open()

        AdaptarDatos = New OleDbDataAdapter("Select * From Insumos where Descripcion like'%" & txtDescripcion.Text & "%'", CN2)
        ObtenerDatos = New DataSet

        AdaptarDatos.Fill(ObtenerDatos, "INSUMOS")
        CN2.Close()

        DataGridView2.DataSource = ObtenerDatos
        DataGridView2.DataMember = "INSUMOS"


    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDoubleClick
        txtCodigo.Text = DataGridView2.SelectedCells(0).Value.ToString()
        txtDescripcion.Text = DataGridView2.SelectedCells(1).Value.ToString()
        txtUnidad.Text = DataGridView2.SelectedCells(2).Value.ToString()

        txtPrecio.Text = DataGridView2.SelectedCells(4).Value.ToString()

        txtStock.Text = DataGridView2.SelectedCells(3).Value.ToString()
        txtProveedor.Text = DataGridView2.SelectedCells(5).Value.ToString()

        btnModificar.Visible = True
        btnNoModificar.Visible = False
        btnEliminar.Visible = True
        btnNoEliminar.Visible = False


        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim CN2 As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Inventario.accdb")

        CN2.Open()

        AdaptarDatos = New OleDbDataAdapter("Select * From Insumos where Descripcion like'%" & TextBox1.Text & "%'", CN2)
        ObtenerDatos = New DataSet

        AdaptarDatos.Fill(ObtenerDatos, "INSUMOS")
        CN2.Close()

        DataGridView2.DataSource = ObtenerDatos
        DataGridView2.DataMember = "INSUMOS"

    End Sub
End Class