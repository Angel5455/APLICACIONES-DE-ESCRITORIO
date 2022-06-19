Imports System.Data.OleDb

Public Class F_Fase6

    Public conexion As OleDbConnection
    Public AdaptarDatos As New OleDbDataAdapter
    Public ObtenerDatos As DataSet

    Public Ruta As String = Application.StartupPath + "/Fase6.accdb"

    Dim n As Integer = 0


    Dim CN As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Fase6.accdb")


    Sub nuevo()



        Dim cmd As New OleDb.OleDbCommand("INSERT INTO DESEMBOLSOS VALUES('" & txtid.Text & "','" & txtclave.Text & "','" & txtNombreP.Text & "','" & txtIdentidad.Text & "','" & txtFechaI.Text & "','" & txtAgencia.Text & "','" & txtMunicipio.Text & "','" & txtMonto.Text & "','" & txtD1.Text & "','" & txtD2.Text & "','" & txtD3.Text & "','" & txtD4.Text & "','" & txtD5.Text & "','" & txtD6.Text & "','" & txtD7.Text & "','" & txtD8.Text & "','" & txtD9.Text & "','" & txtD10.Text & "','" & lblSaldo.Text & "','" & txtN_Desembolso.Text & "','" & lblfase.Text & "')", CN)

        CN.Open()
        cmd.ExecuteNonQuery()
        CN.Close()
        MsgBox("REGISTRO AGREGADO", MsgBoxStyle.Information, "IHCAFE")



    End Sub

    Sub modificar()



        Dim CMD As New OleDb.OleDbCommand("UPDATE DESEMBOLSOS SET ID='" & txtid.Text & "',CLAVE='" & txtclave.Text & "',NOMBRE='" & txtNombreP.Text & "',IDENTIDAD='" & txtIdentidad.Text & "',FECHA='" & txtFechaI.Text & "',AGENCIA='" & txtAgencia.Text & "',MUNICIPIO='" & txtMunicipio.Text & "',MONTO='" & txtMonto.Text & "',DESEMBOLSO1='" & txtD1.Text & "',DESEMBOLSO2='" & txtD2.Text & "',DESEMBOLSO3='" & txtD3.Text & "',DESEMBOLSO4='" & txtD4.Text & "',DESEMBOLSO5='" & txtD5.Text & "',DESEMBOLSO6='" & txtD6.Text & "',DESEMBOLSO7='" & txtD7.Text & "',DESEMBOLSO8='" & txtD8.Text & "',DESEMBOLSO9='" & txtD9.Text & "',DESEMBOLSO10='" & txtD10.Text & "',SALDO='" & lblSaldo.Text & "',N_DESEMBOLSO='" & txtN_Desembolso.Text & "',FASE='" & lblfase.Text & "' WHERE ID='" & txtid.Text & "'", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()

        MsgBox("REGISTRO ACTUALIZADO", MsgBoxStyle.Information, "IHCAFE")



    End Sub

    Sub eliminar()


        Dim CMD As New OleDb.OleDbCommand("DELETE FROM DESEMBOLSOS WHERE CLAVE= '" & txtclave.Text & "'", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        limpiar()
        mostrar()


        MsgBox("EL REGISTRO A SIDO ELIMINADO", MsgBoxStyle.Information, "IHCAFE")



    End Sub



    Sub mostrar()

    End Sub
    Private Sub F_Fase6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Bloquear()

        txtid.Text = My.Settings.MyId6

        txtN.Text = 1
        lblfase.Text = "6"
        txtMonto.Text = 0
        txtD1.Text = 0
        txtD2.Text = 0
        txtD3.Text = 0
        txtD4.Text = 0
        txtD5.Text = 0
        txtD6.Text = 0
        txtD7.Text = 0
        txtD8.Text = 0
        txtD9.Text = 0
        txtD10.Text = 0
        lblSaldo.Text = "0.00"
    End Sub

    Private Sub limpiar()

        Me.txtN_Desembolso.Text = ""
        Me.txtIdentidad.Text = ""
        Me.txtNombreP.Text = ""
        Me.txtFechaI.Text = ""
        Me.txtAgencia.Text = ""
        Me.txtMunicipio.Text = ""
        Me.txtclave.Text = ""
        Me.txtMonto.Text = ""
        Me.txtD1.Text = "0"
        Me.txtD2.Text = "0"
        Me.txtD2.Text = "0"
        Me.txtD3.Text = "0"
        Me.txtD4.Text = "0"
        Me.txtD5.Text = "0"
        Me.txtD6.Text = "0"
        Me.txtD7.Text = "0"
        Me.txtD8.Text = "0"
        Me.txtD9.Text = "0"
        Me.txtD10.Text = "0"
        lblSaldo.Text = "0.00"
        Me.txtbuscarnombre.Text = ""




    End Sub

    Private Sub Bloquear()
        Me.txtN_Desembolso.Enabled = False
        Me.txtIdentidad.Enabled = False
        Me.txtNombreP.Enabled = False
        Me.txtFechaI.Enabled = False
        Me.txtclave.Enabled = False
        Me.txtAgencia.Enabled = False
        Me.txtMunicipio.Enabled = False
        Me.txtMonto.Enabled = False
        txtD1.Enabled = False
        txtD2.Enabled = False
        txtD3.Enabled = False
        txtD4.Enabled = False
        txtD5.Enabled = False
        txtD6.Enabled = False
        txtD7.Enabled = False
        txtD8.Enabled = False
        txtD9.Enabled = False
        txtD10.Enabled = False
        lblSaldo.Enabled = False
    End Sub


    Private Sub Desbloquear()
        Me.txtN_Desembolso.Enabled = True
        Me.txtIdentidad.Enabled = True
        Me.txtNombreP.Enabled = True
        Me.txtFechaI.Enabled = True
        Me.txtclave.Enabled = True
        Me.txtAgencia.Enabled = True
        Me.txtMunicipio.Enabled = True
        Me.txtMonto.Enabled = True

        lblSaldo.Enabled = True
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
        Desbloquear()
    End Sub



    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        F_Menu2.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try
            Dim Consulta As String

            Consulta = " Select * from Desembolsos where Nombre = '" & txtbuscarnombre.Text & "'"


            Dim Mov As New OleDbConnection()
            Mov.ConnectionString = ("PROVIDER=Microsoft.jet.OLEDB.4.0;Data Source=" & Ruta)
            Dim ObjDataSet As New DataSet()
            Dim M As New DataTable()
            'Consulta
            Dim objAdap As New OleDbDataAdapter(Consulta, Mov)
            Mov.Open()
            objAdap.Fill(M)
            Me.DataGridView1.DataSource = M
            Mov.Close()
            limpiar()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try


       

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        txtid.Text = DataGridView1.SelectedCells(0).Value.ToString()
        txtclave.Text = DataGridView1.SelectedCells(1).Value.ToString()
        txtNombreP.Text = DataGridView1.SelectedCells(2).Value.ToString()

        txtIdentidad.Text = DataGridView1.SelectedCells(3).Value.ToString()

        txtFechaI.Text = DataGridView1.SelectedCells(4).Value.ToString()
        txtAgencia.Text = DataGridView1.SelectedCells(5).Value.ToString()
        txtMunicipio.Text = DataGridView1.SelectedCells(6).Value.ToString()
        txtMonto.Text = DataGridView1.SelectedCells(7).Value.ToString()
        txtD1.Text = DataGridView1.SelectedCells(8).Value.ToString()
        txtD2.Text = DataGridView1.SelectedCells(9).Value.ToString()
        txtD3.Text = DataGridView1.SelectedCells(10).Value.ToString()
        txtD4.Text = DataGridView1.SelectedCells(11).Value.ToString()
        txtD5.Text = DataGridView1.SelectedCells(12).Value.ToString()
        txtD6.Text = DataGridView1.SelectedCells(13).Value.ToString()
        txtD7.Text = DataGridView1.SelectedCells(14).Value.ToString()
        txtD8.Text = DataGridView1.SelectedCells(15).Value.ToString()
        txtD9.Text = DataGridView1.SelectedCells(16).Value.ToString()
        txtD10.Text = DataGridView1.SelectedCells(17).Value.ToString()
        lblSaldo.Text = DataGridView1.SelectedCells(18).Value.ToString()
        txtN_Desembolso.Text = DataGridView1.SelectedCells(19).Value.ToString()
        lblfase.Text = DataGridView1.SelectedCells(20).Value.ToString()

        btnEliminar.Visible = True
        btnNoEliminar.Visible = False
        btnModificar.Visible = True
        btnNoModificar.Visible = False

        TabControl1.SelectedIndex = 0

    End Sub


    Private Sub PictureBox6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        PictureBox6.Height = 65
        PictureBox6.Width = 65
    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        PictureBox6.Height = 70
        PictureBox6.Width = 70
    End Sub


   

    Private Sub PictureBox6_MouseEnter1(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseEnter
        PictureBox6.Height = 65
        PictureBox6.Width = 65
    End Sub

    Private Sub PictureBox6_MouseLeave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.Height = 70
        PictureBox6.Width = 70
    End Sub

    

    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

    Private Sub txtMonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    
    Private Sub txtbuscarnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarnombre.TextChanged

        Dim CN As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Fase6.accdb")

        CN.Open()

        AdaptarDatos = New OleDbDataAdapter("Select * From Desembolsos where Nombre like'%" & txtbuscarnombre.Text & "%'", CN)
        ObtenerDatos = New DataSet

        AdaptarDatos.Fill(ObtenerDatos, "DESEMBOLSOS")
        CN.Close()

        DataGridView1.DataSource = ObtenerDatos
        DataGridView1.DataMember = "DESEMBOLSOS"


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
        Dim total As Integer

        total = Val(txtid.Text) + 1

        txtid.Text = total
        btnNuevo.Visible = False
        btnNoNuevo.Visible = True
        btnGuardar.Visible = True
        btnNoGuardar.Visible = False
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True

        Desbloquear()
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

    Private Sub btnNoGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoGuardar.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Guardar")

    End Sub

    Private Sub btnNoGuardar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoGuardar.MouseEnter
        btnNoGuardar.Height = 45
        btnNoGuardar.Width = 45
    End Sub

    Private Sub btnNoGuardar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoGuardar.MouseLeave
        btnNoGuardar.Height = 50
        btnNoGuardar.Width = 50
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        btnNuevo.Visible = True
        btnNoNuevo.Visible = False


        btnGuardar.Visible = False
        btnNoGuardar.Visible = True
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True



        If n = 1 Then

            nuevo()
            My.Settings.MyId6 = txtid.Text
            My.Settings.Save()
            My.Settings.Reload()

        ElseIf n = 2 Then

            modificar()


        End If



        Bloquear()
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
        btnNoGuardar.Visible = False
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True

        Desbloquear()
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


        btnNuevo.Visible = True
        btnNoNuevo.Visible = False

        btnGuardar.Visible = False
        btnNoGuardar.Visible = True
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

    Private Sub PictureBox8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        If txtN_Desembolso.Text = 1 Then


            F_Factura.txtContador.Text = 1


            F_Factura.Button1.Enabled = True
            F_Factura.btnGuardar.Visible = True
            F_Factura.btnNoSave.Visible = False
            F_Factura.btnNoNuevo.Visible = True
            F_Factura.btnNuevo.Visible = False


            F_Factura.txtid.Text = txtid.Text



            F_Factura.txtIdentidad.Text = txtIdentidad.Text
            F_Factura.txtAgencia.Text = txtAgencia.Text
            F_Factura.txtN_Desembolso.Text = txtN_Desembolso.Text
            F_Factura.txtNombres.Text = txtNombreP.Text
            F_Factura.txtFase.Text = lblfase.Text
            F_Factura.txtClave.Text = txtclave.Text
            F_Factura.txtMonto.Text = txtMonto.Text
            F_Factura.txtDesembolso.Text = txtD1.Text
            F_Factura.txtSaldo.Text = lblSaldo.Text


            F_Factura.Show()

        End If

        If txtN_Desembolso.Text = 2 Then


            F_Factura.txtContador.Text = 1


            F_Factura.Button1.Enabled = True
            F_Factura.btnGuardar.Visible = True
            F_Factura.btnNoSave.Visible = False
            F_Factura.btnNoNuevo.Visible = True
            F_Factura.btnNuevo.Visible = False


            F_Factura.txtid.Text = txtid.Text



            F_Factura.txtIdentidad.Text = txtIdentidad.Text
            F_Factura.txtAgencia.Text = txtAgencia.Text
            F_Factura.txtN_Desembolso.Text = txtN_Desembolso.Text
            F_Factura.txtNombres.Text = txtNombreP.Text
            F_Factura.txtFase.Text = lblfase.Text
            F_Factura.txtClave.Text = txtclave.Text
            F_Factura.txtMonto.Text = txtMonto.Text
            F_Factura.txtDesembolso.Text = txtD2.Text
            F_Factura.txtSaldo.Text = lblSaldo.Text


            F_Factura.Show()

        End If

        If txtN_Desembolso.Text = 3 Then


            F_Factura.txtContador.Text = 1


            F_Factura.Button1.Enabled = True
            F_Factura.btnGuardar.Visible = True
            F_Factura.btnNoSave.Visible = False
            F_Factura.btnNoNuevo.Visible = True
            F_Factura.btnNuevo.Visible = False


            F_Factura.txtid.Text = txtid.Text



            F_Factura.txtIdentidad.Text = txtIdentidad.Text
            F_Factura.txtAgencia.Text = txtAgencia.Text
            F_Factura.txtN_Desembolso.Text = txtN_Desembolso.Text
            F_Factura.txtNombres.Text = txtNombreP.Text
            F_Factura.txtFase.Text = lblfase.Text
            F_Factura.txtClave.Text = txtclave.Text
            F_Factura.txtMonto.Text = txtMonto.Text
            F_Factura.txtDesembolso.Text = txtD3.Text
            F_Factura.txtSaldo.Text = lblSaldo.Text


            F_Factura.Show()

        End If

        If txtN_Desembolso.Text = 4 Then


            F_Factura.txtContador.Text = 1


            F_Factura.Button1.Enabled = True
            F_Factura.btnGuardar.Visible = True
            F_Factura.btnNoSave.Visible = False
            F_Factura.btnNoNuevo.Visible = True
            F_Factura.btnNuevo.Visible = False


            F_Factura.txtid.Text = txtid.Text



            F_Factura.txtIdentidad.Text = txtIdentidad.Text
            F_Factura.txtAgencia.Text = txtAgencia.Text
            F_Factura.txtN_Desembolso.Text = txtN_Desembolso.Text
            F_Factura.txtNombres.Text = txtNombreP.Text
            F_Factura.txtFase.Text = lblfase.Text
            F_Factura.txtClave.Text = txtclave.Text
            F_Factura.txtMonto.Text = txtMonto.Text
            F_Factura.txtDesembolso.Text = txtD4.Text
            F_Factura.txtSaldo.Text = lblSaldo.Text


            F_Factura.Show()

        End If

        If txtN_Desembolso.Text = 5 Then


            F_Factura.txtContador.Text = 1


            F_Factura.Button1.Enabled = True
            F_Factura.btnGuardar.Visible = True
            F_Factura.btnNoSave.Visible = False
            F_Factura.btnNoNuevo.Visible = True
            F_Factura.btnNuevo.Visible = False


            F_Factura.txtid.Text = txtid.Text



            F_Factura.txtIdentidad.Text = txtIdentidad.Text
            F_Factura.txtAgencia.Text = txtAgencia.Text
            F_Factura.txtN_Desembolso.Text = txtN_Desembolso.Text
            F_Factura.txtNombres.Text = txtNombreP.Text
            F_Factura.txtFase.Text = lblfase.Text
            F_Factura.txtClave.Text = txtclave.Text
            F_Factura.txtMonto.Text = txtMonto.Text
            F_Factura.txtDesembolso.Text = txtD5.Text
            F_Factura.txtSaldo.Text = lblSaldo.Text


            F_Factura.Show()

        End If

        If txtN_Desembolso.Text = 6 Then


            F_Factura.txtContador.Text = 1


            F_Factura.Button1.Enabled = True
            F_Factura.btnGuardar.Visible = True
            F_Factura.btnNoSave.Visible = False
            F_Factura.btnNoNuevo.Visible = True
            F_Factura.btnNuevo.Visible = False


            F_Factura.txtid.Text = txtid.Text



            F_Factura.txtIdentidad.Text = txtIdentidad.Text
            F_Factura.txtAgencia.Text = txtAgencia.Text
            F_Factura.txtN_Desembolso.Text = txtN_Desembolso.Text
            F_Factura.txtNombres.Text = txtNombreP.Text
            F_Factura.txtFase.Text = lblfase.Text
            F_Factura.txtClave.Text = txtclave.Text
            F_Factura.txtMonto.Text = txtMonto.Text
            F_Factura.txtDesembolso.Text = txtD6.Text
            F_Factura.txtSaldo.Text = lblSaldo.Text


            F_Factura.Show()

        End If

        If txtN_Desembolso.Text = 7 Then


            F_Factura.txtContador.Text = 1


            F_Factura.Button1.Enabled = True
            F_Factura.btnGuardar.Visible = True
            F_Factura.btnNoSave.Visible = False
            F_Factura.btnNoNuevo.Visible = True
            F_Factura.btnNuevo.Visible = False


            F_Factura.txtid.Text = txtid.Text



            F_Factura.txtIdentidad.Text = txtIdentidad.Text
            F_Factura.txtAgencia.Text = txtAgencia.Text
            F_Factura.txtN_Desembolso.Text = txtN_Desembolso.Text
            F_Factura.txtNombres.Text = txtNombreP.Text
            F_Factura.txtFase.Text = lblfase.Text
            F_Factura.txtClave.Text = txtclave.Text
            F_Factura.txtMonto.Text = txtMonto.Text
            F_Factura.txtDesembolso.Text = txtD7.Text
            F_Factura.txtSaldo.Text = lblSaldo.Text


            F_Factura.Show()

        End If

        If txtN_Desembolso.Text = 8 Then


            F_Factura.txtContador.Text = 1


            F_Factura.Button1.Enabled = True
            F_Factura.btnGuardar.Visible = True
            F_Factura.btnNoSave.Visible = False
            F_Factura.btnNoNuevo.Visible = True
            F_Factura.btnNuevo.Visible = False


            F_Factura.txtid.Text = txtid.Text



            F_Factura.txtIdentidad.Text = txtIdentidad.Text
            F_Factura.txtAgencia.Text = txtAgencia.Text
            F_Factura.txtN_Desembolso.Text = txtN_Desembolso.Text
            F_Factura.txtNombres.Text = txtNombreP.Text
            F_Factura.txtFase.Text = lblfase.Text
            F_Factura.txtClave.Text = txtclave.Text
            F_Factura.txtMonto.Text = txtMonto.Text
            F_Factura.txtDesembolso.Text = txtD8.Text
            F_Factura.txtSaldo.Text = lblSaldo.Text


            F_Factura.Show()

        End If

        If txtN_Desembolso.Text = 9 Then


            F_Factura.txtContador.Text = 1


            F_Factura.Button1.Enabled = True
            F_Factura.btnGuardar.Visible = True
            F_Factura.btnNoSave.Visible = False
            F_Factura.btnNoNuevo.Visible = True
            F_Factura.btnNuevo.Visible = False


            F_Factura.txtid.Text = txtid.Text



            F_Factura.txtIdentidad.Text = txtIdentidad.Text
            F_Factura.txtAgencia.Text = txtAgencia.Text
            F_Factura.txtN_Desembolso.Text = txtN_Desembolso.Text
            F_Factura.txtNombres.Text = txtNombreP.Text
            F_Factura.txtFase.Text = lblfase.Text
            F_Factura.txtClave.Text = txtclave.Text
            F_Factura.txtMonto.Text = txtMonto.Text
            F_Factura.txtDesembolso.Text = txtD9.Text
            F_Factura.txtSaldo.Text = lblSaldo.Text


            F_Factura.Show()

        End If

        If txtN_Desembolso.Text = 10 Then


            F_Factura.txtContador.Text = 1


            F_Factura.Button1.Enabled = True
            F_Factura.btnGuardar.Visible = True
            F_Factura.btnNoSave.Visible = False
            F_Factura.btnNoNuevo.Visible = True
            F_Factura.btnNuevo.Visible = False


            F_Factura.txtid.Text = txtid.Text



            F_Factura.txtIdentidad.Text = txtIdentidad.Text
            F_Factura.txtAgencia.Text = txtAgencia.Text
            F_Factura.txtN_Desembolso.Text = txtN_Desembolso.Text
            F_Factura.txtNombres.Text = txtNombreP.Text
            F_Factura.txtFase.Text = lblfase.Text
            F_Factura.txtClave.Text = txtclave.Text
            F_Factura.txtMonto.Text = txtMonto.Text
            F_Factura.txtDesembolso.Text = txtD10.Text
            F_Factura.txtSaldo.Text = lblSaldo.Text


            F_Factura.Show()

        End If

    End Sub

    Private Sub PictureBox8_MouseEnter1(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseEnter
        PictureBox8.Height = 45
        PictureBox8.Width = 45
    End Sub

    Private Sub PictureBox8_MouseLeave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseLeave
        PictureBox8.Height = 50
        PictureBox8.Width = 50
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Dim resp As Integer
        resp = MsgBox("¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "System IHCAFE")
        If resp = 6 Then
            limpiar()
            Dim total As Integer

            total = Val(txtid.Text) - 1

            txtid.Text = total

            n = 0
            Me.Hide()
        End If
    End Sub

    Private Sub btnSalir_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.MouseEnter
        btnSalir.Height = 45
        btnSalir.Width = 45
    End Sub

    Private Sub btnSalir_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.MouseLeave
        btnSalir.Height = 50
        btnSalir.Width = 50
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim DA As New OleDb.OleDbDataAdapter("Select * from Desembolsos", CN)
        Dim DS As New DataSet

        DA.Fill(DS, "Desembolsos")
        DataGridView1.DataSource = DS.Tables("Desembolsos")
    End Sub

    Private Sub txtN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN.SelectedIndexChanged
        Dim CN As New OleDb.OleDbConnection("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\Fase6.accdb")

        CN.Open()

        AdaptarDatos = New OleDbDataAdapter("Select * From Desembolsos where N_Desembolso like'%" & txtN.Text & "%'", CN)
        ObtenerDatos = New DataSet

        AdaptarDatos.Fill(ObtenerDatos, "DESEMBOLSOS")
        CN.Close()

        DataGridView1.DataSource = ObtenerDatos
        DataGridView1.DataMember = "DESEMBOLSOS"

    End Sub

    Private Sub PictureBox6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        limpiar()

        Try
            Dim Consulta As String


            Consulta = " Select * from Desembolsos where Nombre = '" & txtbuscarnombre.Text & "'"

            Dim Mov As New OleDbConnection()
            Mov.ConnectionString = ("PROVIDER=Microsoft.ACE.OLEDB.12.0;Data SOURCE=" & Ruta)
            Dim ObjDataSet As New DataSet()
            Dim M As New DataTable()
            'Consulta
            Dim objAdap As New OleDbDataAdapter(Consulta, Mov)
            Mov.Open()
            objAdap.Fill(M)
            Me.DataGridView1.DataSource = M
            Mov.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try




        txtbuscarnombre.Text = " "
    End Sub

    Private Sub txtN_Desembolso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN_Desembolso.SelectedIndexChanged
        If txtN_Desembolso.Text = 1 Then

            txtD1.Enabled = True
            txtD2.Enabled = False
            txtD3.Enabled = False
            txtD4.Enabled = False
            txtD5.Enabled = False
            txtD6.Enabled = False
            txtD7.Enabled = False
            txtD8.Enabled = False
            txtD9.Enabled = False
            txtD10.Enabled = False

        End If

        If txtN_Desembolso.Text = 2 Then

            txtD1.Enabled = False
            txtD2.Enabled = True
            txtD3.Enabled = False
            txtD4.Enabled = False
            txtD5.Enabled = False
            txtD6.Enabled = False
            txtD7.Enabled = False
            txtD8.Enabled = False
            txtD9.Enabled = False
            txtD10.Enabled = False

        End If

        If txtN_Desembolso.Text = 3 Then

            txtD1.Enabled = False
            txtD2.Enabled = False
            txtD3.Enabled = True
            txtD4.Enabled = False
            txtD5.Enabled = False
            txtD6.Enabled = False
            txtD7.Enabled = False
            txtD8.Enabled = False
            txtD9.Enabled = False
            txtD10.Enabled = False

        End If

        If txtN_Desembolso.Text = 4 Then

            txtD1.Enabled = False
            txtD2.Enabled = False
            txtD3.Enabled = False
            txtD4.Enabled = True
            txtD5.Enabled = False
            txtD6.Enabled = False
            txtD7.Enabled = False
            txtD8.Enabled = False
            txtD9.Enabled = False
            txtD10.Enabled = False

        End If

        If txtN_Desembolso.Text = 5 Then

            txtD1.Enabled = False
            txtD2.Enabled = False
            txtD3.Enabled = False
            txtD4.Enabled = False
            txtD5.Enabled = True
            txtD6.Enabled = False
            txtD7.Enabled = False
            txtD8.Enabled = False
            txtD9.Enabled = False
            txtD10.Enabled = False

        End If

        If txtN_Desembolso.Text = 6 Then

            txtD1.Enabled = False
            txtD2.Enabled = False
            txtD3.Enabled = False
            txtD4.Enabled = False
            txtD5.Enabled = False
            txtD6.Enabled = True
            txtD7.Enabled = False
            txtD8.Enabled = False
            txtD9.Enabled = False
            txtD10.Enabled = False

        End If

        If txtN_Desembolso.Text = 7 Then

            txtD1.Enabled = False
            txtD2.Enabled = False
            txtD3.Enabled = False
            txtD4.Enabled = False
            txtD5.Enabled = False
            txtD6.Enabled = False
            txtD7.Enabled = True
            txtD8.Enabled = False
            txtD9.Enabled = False
            txtD10.Enabled = False


        End If

        If txtN_Desembolso.Text = 8 Then

            txtD1.Enabled = False
            txtD2.Enabled = False
            txtD3.Enabled = False
            txtD4.Enabled = False
            txtD5.Enabled = False
            txtD6.Enabled = False
            txtD7.Enabled = False
            txtD8.Enabled = True
            txtD9.Enabled = False
            txtD10.Enabled = False


        End If

        If txtN_Desembolso.Text = 9 Then

            txtD1.Enabled = False
            txtD2.Enabled = False
            txtD3.Enabled = False
            txtD4.Enabled = False
            txtD5.Enabled = False
            txtD6.Enabled = False
            txtD7.Enabled = False
            txtD8.Enabled = False
            txtD9.Enabled = True
            txtD10.Enabled = False


        End If

        If txtN_Desembolso.Text = 10 Then

            txtD1.Enabled = False
            txtD2.Enabled = False
            txtD3.Enabled = False
            txtD4.Enabled = False
            txtD5.Enabled = False
            txtD6.Enabled = False
            txtD7.Enabled = False
            txtD8.Enabled = False
            txtD9.Enabled = False
            txtD10.Enabled = True

        End If



    End Sub

    Private Sub txtD1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD1.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtD1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtD1.TextChanged
        Dim total As Double

        total = Val(txtMonto.Text) - Val(txtD1.Text)

        lblSaldo.Text = total
    End Sub

    Private Sub txtD2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD2.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtD2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtD2.TextChanged
        Dim total As Double

        total = Val(txtMonto.Text) - Val(txtD1.Text) - Val(txtD2.Text)

        lblSaldo.Text = total
    End Sub

    Private Sub txtD3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD3.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtD3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtD3.TextChanged
        Dim total As Double

        total = Val(txtMonto.Text) - Val(txtD1.Text) - Val(txtD2.Text) - Val(txtD3.Text)

        lblSaldo.Text = total
    End Sub

    Private Sub txtD4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD4.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtD4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtD4.TextChanged
        Dim total As Double

        total = Val(txtMonto.Text) - Val(txtD1.Text) - Val(txtD2.Text) - Val(txtD3.Text) - Val(txtD4.Text)

        lblSaldo.Text = total
    End Sub

    Private Sub txtD5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD5.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtD5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtD5.TextChanged
        Dim total As Double

        total = Val(txtMonto.Text) - Val(txtD1.Text) - Val(txtD2.Text) - Val(txtD3.Text) - Val(txtD4.Text) - Val(txtD5.Text)

        lblSaldo.Text = total
    End Sub

    Private Sub txtD6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD6.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtD6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtD6.TextChanged
        Dim total As Double

        total = Val(txtMonto.Text) - Val(txtD1.Text) - Val(txtD2.Text) - Val(txtD3.Text) - Val(txtD4.Text) - Val(txtD5.Text) - Val(txtD6.Text)

        lblSaldo.Text = total
    End Sub

    Private Sub txtD7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD7.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtD7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtD7.TextChanged
        Dim total As Double

        total = Val(txtMonto.Text) - Val(txtD1.Text) - Val(txtD2.Text) - Val(txtD3.Text) - Val(txtD4.Text) - Val(txtD5.Text) - Val(txtD6.Text) - Val(txtD7.Text)

        lblSaldo.Text = total
    End Sub

    Private Sub txtD8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD8.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtD8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtD8.TextChanged
        Dim total As Double

        total = Val(txtMonto.Text) - Val(txtD1.Text) - Val(txtD2.Text) - Val(txtD3.Text) - Val(txtD4.Text) - Val(txtD5.Text) - Val(txtD6.Text) - Val(txtD7.Text) - Val(txtD8.Text)

        lblSaldo.Text = total
    End Sub

    Private Sub txtD9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD9.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtD9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtD9.TextChanged
        Dim total As Double

        total = Val(txtMonto.Text) - Val(txtD1.Text) - Val(txtD2.Text) - Val(txtD3.Text) - Val(txtD4.Text) - Val(txtD5.Text) - Val(txtD6.Text) - Val(txtD7.Text) - Val(txtD8.Text) - Val(txtD9.Text)

        lblSaldo.Text = total
    End Sub

    Private Sub txtD10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtD10.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtD10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtD10.TextChanged
        Dim total As Double

        total = Val(txtMonto.Text) - Val(txtD1.Text) - Val(txtD2.Text) - Val(txtD3.Text) - Val(txtD4.Text) - Val(txtD5.Text) - Val(txtD6.Text) - Val(txtD7.Text) - Val(txtD8.Text) - Val(txtD9.Text) - Val(txtD10.Text)

        lblSaldo.Text = total
    End Sub

    Private Sub txtMonto_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtMonto_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.TextChanged

    End Sub
End Class