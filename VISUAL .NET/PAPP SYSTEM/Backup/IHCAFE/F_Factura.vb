Imports System.Data.OleDb



Public Class F_Factura


    Public conexion As OleDbConnection
    Public AdaptarDatos As New OleDbDataAdapter
    Public ObtenerDatos As DataSet


    Public iPosicfilaActual As Integer


    Dim n As Integer = 0
    ' Public Ruta As String = Application.StartupPath + "/Saldos.accdb"

    Dim CN As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Facturacion.accdb")



    Sub cargar2()

        Dim DA As New OleDb.OleDbDataAdapter("Select * from FACTURA", CN)
        Dim DS As New DataSet

        DA.Fill(DS, "FACTURA")
        ComboFactura.DataSource = DS.Tables("FACTURA")

        ComboFactura.DisplayMember = "N_Factura"



    End Sub
    Sub nuevo()


        Dim CMD As New OleDb.OleDbCommand("INSERT INTO FACTURA VALUES('" & lblid.Text & "','" & txtFecha.Text & "','" & txtIdentidad.Text & "','" & txtNombres.Text & "','" & txtFase.Text & "','" & txtN_Desembolso.Text & "','" & txtAgencia.Text & "','" & txtTotal.Text & "')", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        MsgBox("REGISTRO AGREGADO", MsgBoxStyle.Information, "IHCAFE")



    End Sub

    Sub modificar()



        Dim CMD As New OleDb.OleDbCommand("UPDATE FACTURA SET N_Factura='" & lblid.Text & "',FECHA='" & txtFecha.Text & "',CEDULA='" & txtIdentidad.Text & "',NOMBRES='" & txtNombres.Text & "',FASE='" & txtFase.Text & "',N_DESEMBOLSO='" & txtN_Desembolso.Text & "',AGENCIA='" & txtAgencia.Text & "',TOTAL_PAGAR='" & txtTotal.Text & "' WHERE N_FACTURA='" & lblid.Text & "'", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()

        MsgBox("REGISTRO ACTUALIZADO", MsgBoxStyle.Information, "IHCAFE")


    End Sub

    Sub eliminar()

        Dim CMD As New OleDb.OleDbCommand("DELETE FROM FACTURA WHERE N_FACTURA= '" & ComboFactura.Text & "'", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        limpiar()


    End Sub

    Sub eliminar2()



        Dim CMD As New OleDb.OleDbCommand("DELETE FROM KARDEX WHERE N_FACTURA= '" & ComboFactura.Text & "'", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        limpiar()




        MsgBox("EL REGISTRO A SIDO ELIMINADO", MsgBoxStyle.Information, "IHCAFE")




    End Sub
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

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        btnNuevo.Visible = True
        btnNoNuevo.Visible = False


        btnGuardar.Visible = False
        btnNoSave.Visible = True
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True



        F_ListaProductos.limpiar()
        'F_ListaProductos.eliminar()
        F_Inventario.modificar()
        F_Inventario.mostrar()





        If n = 1 Then

            nuevo()


            My.Settings.MyId11 = lblid.Text
            My.Settings.Save()
            ' My.Settings.Reload()

        ElseIf n = 2 Then

            modificar()


        End If



        bloquear()
        ' limpiar()
        mostrar()

        cargar2()

        n = 0

        Dim resp As String

        resp = MsgBox("Desea Imprimir la Factura", MsgBoxStyle.YesNo, "System IHCAFE")

        If resp = 6 Then

            R_Impresion.lblRegional.Text = "Santa Barbara"
            R_Impresion.lblAgencia.Text = txtAgencia.Text
            R_Impresion.lblNombre.Text = txtNombres.Text
            R_Impresion.lblIdentidad.Text = txtIdentidad.Text
            R_Impresion.lblClave.Text = txtClave.Text


            R_Impresion.lblMonto_Aprobado.Text = txtMonto.Text
            R_Impresion.lblSaldo_Anterior.Text = txtSaldo.Text
            R_Impresion.lblMonto_Desembolsado.Text = txtDesembolso.Text
            R_Impresion.lblTotal.Text = txtTotal.Text
            R_Impresion.lblFase.Text = txtFase.Text

            R_Impresion.lblpres.Text = txtid.Text
            R_Impresion.lbld.Text = txtN_Desembolso.Text


            R_Impresion.lblFase.Text = txtFase.Text

            If txtAgencia.Text = "1 - A, S.B." Then

                R_Impresion.lbla.Text = 1

            End If

            If txtAgencia.Text = "2 - B, S.B." Then

                R_Impresion.lbla.Text = 1

            End If

            If txtAgencia.Text = "Colinas" Then

                R_Impresion.lbla.Text = 2

            End If

            If txtAgencia.Text = "Trinidad" Then

                R_Impresion.lbla.Text = 3

            End If

            If txtAgencia.Text = "San Nicolas" Then

                R_Impresion.lbla.Text = 4

            End If

            If txtAgencia.Text = "San Luis" Then

                R_Impresion.lbla.Text = 5

            End If

            If txtAgencia.Text = "La Union Lempira" Then

                R_Impresion.lbla.Text = 6

            End If



            R_Impresion.Picturebox6.Text = lblid.Text


            R_Impresion.lblFactura.Text = lblid.Text


            R_Impresion.Show()


        End If

    End Sub

    Private Sub btnGuardar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.MouseEnter
        btnGuardar.Height = 45
        btnGuardar.Width = 45
    End Sub

    Private Sub btnGuardar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.Height = 50
        btnGuardar.Width = 50
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        txtContador.Text = 2

        Button1.Enabled = True

        ' Dim total As Integer

        'total = Val(lblFactura.Text) + 1

        'lblFactura.Text = total


        btnNuevo.Visible = False
        btnNoNuevo.Visible = True
        btnGuardar.Visible = True
        btnNoSave.Visible = False
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True




        calculo()


        desbloquear()
        limpiar()



    End Sub

    Private Sub btnNuevo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.MouseEnter
        btnNuevo.Height = 45
        btnNuevo.Width = 45
    End Sub

    Private Sub btnNuevo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.MouseLeave
        btnNuevo.Height = 50
        btnNuevo.Width = 50
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

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        eliminar()
        eliminar2()


        cargar2()



        btnNuevo.Visible = True
        btnNoNuevo.Visible = False

        btnGuardar.Visible = False
        btnNoSave.Visible = True
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True
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
        limpiar()

        If txtContador.Text = 2 Then

            Dim total

            total = Val(lblid.Text) - 1

            lblid.Text = total

        End If


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

    Sub calculo()

        Dim total

        total = Val(lblid.Text) + 1

        lblid.Text = total

    End Sub

    Private Sub F_Factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If txtContador.Text = 1 Then

            lblid.Text = My.Settings.MyId11 + 1

        Else


            lblid.Text = My.Settings.MyId11
        End If






        cargar2()




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

    Private Sub txtNombreP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
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
        lblid.Text = DataGridView2.SelectedCells(0).Value.ToString()
        txtFecha.Text = DataGridView2.SelectedCells(1).Value.ToString()
        txtIdentidad.Text = DataGridView2.SelectedCells(2).Value.ToString()

        txtNombres.Text = DataGridView2.SelectedCells(3).Value.ToString()
        txtFase.Text = DataGridView2.SelectedCells(4).Value.ToString()
        txtN_Desembolso.Text = DataGridView2.SelectedCells(5).Value.ToString()
        txtAgencia.Text = DataGridView2.SelectedCells(6).Value.ToString()
        ' txtTotal.Text = DataGridView2.SelectedCells(7).Value.ToString()
        btnModificar.Visible = True
        btnNoModificar.Visible = False
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




    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click





        F_EliminarItem.Show()


    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        n = 1
        Button2.Enabled = True

        F_ListaProductos.txtFactura.Text = lblid.Text

        F_ListaProductos.Show()

    End Sub



    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub txtAgencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAgencia.SelectedIndexChanged

    End Sub
End Class