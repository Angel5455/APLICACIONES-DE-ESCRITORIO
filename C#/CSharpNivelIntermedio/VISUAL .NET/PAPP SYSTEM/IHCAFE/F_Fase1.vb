Imports System.Data.SqlClient

Public Class F_Fase1

    Dim modificar As Boolean
    Dim accion As Boolean
    Public opcion As String

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        limpiar()
        Desbloquear()

    End Sub


    Private Sub F_Fase1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        LabelP.Text = "\imagenes\IHCAFE.bmp"

        lblcargo.Text = Val(F_Fases.lblcargo.Text)
        lblfase.Text = Val(F_Fases.ComboBox1.Text)



        Bloquear()

        lblAño.Text = Year(Now)

        Me.AñadirProductorToolStripMenuItem.Enabled = False
        Me.ModificarNºDesembolsoToolStripMenuItem.Enabled = False



        txtid.Text = My.Settings.MyId
        txtnro.Text = My.Settings.MyMovimiento

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


        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from General  where Fase like '" & lblfase.Text & "%'", con)


        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)
            DataGridView1.DataSource = tabla

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing
            tabla = Nothing


        End Try


        Bloquear()


        LabelP.Text = "\imagenes\Logo.png"


    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub



    Private Sub limpiar()

        Me.txtN_Desembolso.Text = ""
        Me.txtIdentidad.Text = ""
        Me.txtNombreP.Text = ""
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
        txtMonto.Text = "0"
        txtN_Desembolso.Text = 1

    End Sub

    Sub Bloquear()
        Me.txtN_Desembolso.Enabled = False
        Me.txtIdentidad.Enabled = False
        Me.txtNombreP.Enabled = False
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


    Sub Desbloquear()
        '  Me.txtN_Desembolso.Enabled = True
        Me.txtIdentidad.Enabled = True
        Me.txtNombreP.Enabled = True
        Me.txtclave.Enabled = True
        Me.txtAgencia.Enabled = True
        Me.txtMunicipio.Enabled = True
        ' Me.txtMonto.Enabled = True

        lblSaldo.Enabled = True
    End Sub
    Private Sub txtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonto.KeyPress
        '     Dim numero As Short = CShort(Asc(e.KeyChar))
        '    If InStr("1234567890", Chr(numero)) = 0 Then
        'e.Handled = True
        'Else
        'e.Handled = False
        'End If

        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        ' If Char.IsLetter(e.KeyChar) Then
        'e.Handled = False
        'ElseIf Char.IsControl(e.KeyChar) Then
        'e.Handled = False
        'ElseIf Char.IsSeparator(e.KeyChar) Then
        'e.Handled = False
        'Else
        'e.Handled = True
        'End If



    End Sub


    Private Sub txtMonto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonto.TextChanged

    End Sub




    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub PictureBox6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub PictureBox6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'txtbuscarrnp.Enabled = True
        'txtbuscarnombre.Enabled = False

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' txtbuscarrnp.Enabled = False
        'txtbuscarnombre.Enabled = True
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        Try

            txtid.Text = DataGridView1.SelectedCells(0).Value.ToString()

            txtclave.Text = DataGridView1.SelectedCells(1).Value.ToString()
            txtNombreP.Text = DataGridView1.SelectedCells(2).Value.ToString()

            txtIdentidad.Text = DataGridView1.SelectedCells(3).Value.ToString()

            txtAgencia.Text = DataGridView1.SelectedCells(4).Value.ToString()
            txtMunicipio.Text = DataGridView1.SelectedCells(5).Value.ToString()
            txtMonto.Text = DataGridView1.SelectedCells(6).Value.ToString()
            txtD1.Text = DataGridView1.SelectedCells(7).Value.ToString()
            txtD2.Text = DataGridView1.SelectedCells(8).Value.ToString()
            txtD3.Text = DataGridView1.SelectedCells(9).Value.ToString()
            txtD4.Text = DataGridView1.SelectedCells(10).Value.ToString()
            txtD5.Text = DataGridView1.SelectedCells(11).Value.ToString()
            txtD6.Text = DataGridView1.SelectedCells(12).Value.ToString()
            txtD7.Text = DataGridView1.SelectedCells(13).Value.ToString()
            txtD8.Text = DataGridView1.SelectedCells(14).Value.ToString()
            txtD9.Text = DataGridView1.SelectedCells(15).Value.ToString()
            txtD10.Text = DataGridView1.SelectedCells(16).Value.ToString()
            lblSaldo.Text = DataGridView1.SelectedCells(17).Value.ToString()
            txtN_Desembolso.Text = DataGridView1.SelectedCells(19).Value.ToString()
            lblfase.Text = DataGridView1.SelectedCells(18).Value.ToString()
            lblAño.Text = DataGridView1.SelectedCells(20).Value.ToString()
            PicBloc.Load(Application.StartupPath & DataGridView1.SelectedCells(21).Value.ToString)

      

            If lblcargo.Text = 2 Then

                btnEliminar.Visible = False
                btnNoEliminar.Visible = True
                btnModificar.Visible = False
                btnNoModificar.Visible = True
                btnGuardar.Visible = False
                btnNoSave.Visible = True
                ModificarNºDesembolsoToolStripMenuItem.Enabled = False


            End If

            If lblcargo.Text = 1 Then

                btnEliminar.Visible = True

                btnEliminar.Visible = True
                btnNoEliminar.Visible = False
                btnModificar.Visible = False
                btnNoModificar.Visible = True
                btnGuardar.Visible = False
                btnNoSave.Visible = True



            End If



            PictureBox1.Visible = False
            PictureBox3.Enabled = True
            txtN_Desembolso.Text = Val(txtN_Desembolso.Text) + 1


            Me.ModificarNºDesembolsoToolStripMenuItem.Enabled = True


            TabControl1.SelectedIndex = 0

            accion = False

        Catch ex As Exception
        End Try


    End Sub

    Private Sub txtbuscarnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarnombre.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from General  where Fase like '" & lblfase.Text & "%'" & "And Nombre like'" & txtbuscarnombre.Text & "%'", con)


        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)
            DataGridView1.DataSource = tabla

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing
            tabla = Nothing


        End Try


    End Sub



    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        Me.AñadirProductorToolStripMenuItem.Enabled = True

        PicBloc.Load(Application.StartupPath & LabelP.Text)



        Dim total As Integer

        total = Val(txtid.Text) + 1

        txtid.Text = total

        Dim total2 As Integer

        total2 = Val(txtnro.Text) + 1

        txtnro.Text = total2



        txtMonto.Text = "0"


        If F_Menu.lblCargo.Text = "Administrador" Then

            btnNuevo.Visible = False
            btnNoNuevo.Visible = True
            btnGuardar.Visible = False
            btnNoSave.Visible = True
            btnModificar.Visible = True
            btnNoModificar.Visible = False
            btnEliminar.Visible = False
            btnNoEliminar.Visible = True

        Else

            btnNuevo.Visible = False
            btnNoNuevo.Visible = True
            btnGuardar.Visible = False
            btnNoSave.Visible = True
            btnModificar.Visible = False
            btnNoModificar.Visible = True
            btnEliminar.Visible = False
            btnNoEliminar.Visible = True

            PictureBox1.Visible = False
            PictureBox3.Enabled = True


        End If


        accion = True
        'Desbloquear()
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

    Public Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click


        If txtclave.Text <> " - -    " And lblfase.Text <> "" And txtIdentidad.Text <> "    -    -" And txtNombreP.Text <> "" And txtAgencia.Text <> "" And txtMunicipio.Text <> "" And txtMonto.Text <> "" Then


            Me.AñadirProductorToolStripMenuItem.Enabled = False


            Dim conexion As New Conexion_Fases
            Dim datos As New dFases


            datos.nro = txtnro.Text
            datos.id = txtid.Text
            datos.clave = txtclave.Text
            datos.nombre = txtNombreP.Text
            datos.Identidad = txtIdentidad.Text
            datos.Agencia = txtAgencia.Text
            datos.Municipio = txtMunicipio.Text
            datos.Monto = txtMonto.Text
            datos.D1 = txtD1.Text
            datos.D2 = txtD2.Text
            datos.D3 = txtD3.Text
            datos.D4 = txtD4.Text
            datos.D5 = txtD5.Text
            datos.D6 = txtD6.Text
            datos.D7 = txtD7.Text
            datos.D8 = txtD8.Text
            datos.D9 = txtD9.Text
            datos.D10 = txtD10.Text
            datos.Saldo = lblSaldo.Text
            datos.Fase = lblfase.Text
            datos.ND = txtN_Desembolso.Text
            datos.Año = lblAño.Text
            datos.Foto = LabelP.Text


            Dim n As New Validar_Datos
            Dim c As New Validar_Datos


            Dim crol As String
            Dim ide As String


            crol = n.Comprobar_Clave1(UCase(txtclave.Text))
            ide = c.Comprobar_Identidad1(UCase(txtIdentidad.Text))


            If crol = "N" And ide = "S" Then

                If accion = True Then
                    If conexion.insertar_datos_general(datos) Then


                        Dim constr As String

                        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

                        Dim con As New SqlConnection(constr)
                        Dim ds As New DataSet
                        Dim tabla As New DataTable

                        Dim da As New SqlDataAdapter("Select * from General  where Fase like '" & lblfase.Text & "%'", con)


                        Try

                            Dim cmd As New SqlCommand

                            da.Fill(tabla)
                            DataGridView1.DataSource = tabla

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally

                            con = Nothing
                            ds = Nothing
                            da = Nothing
                            tabla = Nothing


                        End Try




                        My.Settings.MyId = txtid.Text
                        My.Settings.Save()
                        My.Settings.Reload()
                        MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        PictureBox3.Enabled = True
                        PictureBox1.Visible = False


                    Else

                        MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If

                End If


                btnNuevo.Visible = False
                btnNoNuevo.Visible = True
                btnGuardar.Visible = False
                btnNoSave.Visible = True
                btnModificar.Visible = False
                btnNoModificar.Visible = True
                btnEliminar.Visible = False
                btnNoEliminar.Visible = True


                Bloquear()


            Else


                If accion = False Then
                    txtid.Text = ""

                    If conexion.actualizar_datos_general(datos) Then


                        Dim constr As String

                        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

                        Dim con As New SqlConnection(constr)
                        Dim ds As New DataSet
                        Dim tabla As New DataTable

                        Dim da As New SqlDataAdapter("Select * from General  where Fase like '" & lblfase.Text & "%'", con)


                        Try

                            Dim cmd As New SqlCommand

                            da.Fill(tabla)
                            DataGridView1.DataSource = tabla

                        Catch ex As Exception
                            MsgBox(ex.Message)

                        Finally

                            con = Nothing
                            ds = Nothing
                            da = Nothing
                            tabla = Nothing


                        End Try





                        MessageBox.Show("REGISTRO ACTUALIZADO", "ACTUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtid.Text = My.Settings.MyId

                    Else
                        MessageBox.Show("REGISTRO NO ACTUALIZADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If



                    btnNuevo.Visible = False
                    btnNoNuevo.Visible = True


                    btnGuardar.Visible = False
                    btnNoSave.Visible = True
                    btnModificar.Visible = False
                    btnNoModificar.Visible = True
                    btnEliminar.Visible = False
                    btnNoEliminar.Visible = True


                    Bloquear()


                Else

                    If crol <> "N" Then
                        MsgBox("Clave Ya existe", MsgBoxStyle.Information, "P.A.P.P")

                    End If


                    If ide <> "S" Then
                        MsgBox("Identidad Ya existe", MsgBoxStyle.Information, "P.A.P.P")

                    End If

                End If
            End If


            txtclave.BackColor = Color.White
            txtIdentidad.BackColor = Color.White

            txtNombreP.BackColor = Color.White
            txtAgencia.BackColor = Color.White
            txtMunicipio.BackColor = Color.White
            txtMonto.BackColor = Color.White


        Else

            MsgBox("No se permiten campos en blanco", MsgBoxStyle.Exclamation, "P.A.P.P System")

            If txtclave.Text = " - -" Then

                txtclave.BackColor = Color.OrangeRed
            Else

                txtclave.BackColor = Color.White

            End If

            If txtIdentidad.Text = "    -    -" Then

                txtIdentidad.BackColor = Color.OrangeRed
            Else

                txtIdentidad.BackColor = Color.White

            End If


            If txtNombreP.Text = "" Then

                txtNombreP.BackColor = Color.OrangeRed
            Else

                txtNombreP.BackColor = Color.White

            End If


            If txtAgencia.Text = "" Then

                txtAgencia.BackColor = Color.OrangeRed
            Else

                txtAgencia.BackColor = Color.White

            End If

            If txtMunicipio.Text = "" Then

                txtMunicipio.BackColor = Color.OrangeRed
            Else

                txtMunicipio.BackColor = Color.White

            End If


            If txtMonto.Text = "" Then

                txtMonto.BackColor = Color.OrangeRed
            Else

                txtMonto.BackColor = Color.White

            End If



        End If




    End Sub

    Private Sub btnGuardar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.MouseEnter
        btnGuardar.Height = 45
        btnGuardar.Width = 45

    End Sub

    Private Sub btnGuardar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.Width = 50
        btnGuardar.Width = 50
    End Sub

    Private Sub btnNoModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoModificar.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Modificar")
    End Sub

    Private Sub btnNoModificar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoModificar.MouseEnter
        btnNoModificar.Width = 45
        btnNoModificar.Height = 45

    End Sub

    Private Sub btnNoModificar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoModificar.MouseLeave
        btnNoModificar.Width = 50
        btnNoModificar.Height = 50
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
        accion = False

        Me.txtIdentidad.Enabled = False
        Me.txtNombreP.Enabled = True
        Me.txtclave.Enabled = False
        Me.txtAgencia.Enabled = True
        Me.txtMunicipio.Enabled = True
        Me.txtMonto.Enabled = True

        lblSaldo.Enabled = True
    End Sub

    Private Sub btnModificar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.MouseEnter
        btnModificar.Height = 45
        btnModificar.Width = 45
    End Sub

    Private Sub btnModificar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.MouseLeave
        btnModificar.Width = 50
        btnModificar.Height = 50


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

        Dim conexion As New Conexion_Fases
        Dim datos As New dFases

        datos.id = txtid.Text

        If conexion.borrar_datos_general(datos) Then
            If conexion.consultar_todos_general Then

                DataGridView1.DataSource = conexion.tabla

            End If

            MessageBox.Show("REGISTRO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PicBloc.Load(Application.StartupPath & LabelP.Text)

        Else
            MessageBox.Show("REGISTRO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


        If conexion.borrar_datos_general(datos) Then

            '    MessageBox.Show("REGISTRO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PicBloc.Load(Application.StartupPath & LabelP.Text)

        Else
            '     MessageBox.Show("REGISTRO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


        btnNuevo.Visible = True
        btnNoNuevo.Visible = False

        btnGuardar.Visible = False
        btnNoSave.Visible = True
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True

        limpiar()
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

    End Sub



    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim total As Double


        total = Val(txtMonto.Text) - Val(txtD1.Text)

        lblL.Visible = True

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

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from General where Fase like '" & lblfase.Text & "%'" & "And Agencia like'" & ComboBox1.Text & "%'", con)


        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)
            DataGridView1.DataSource = tabla

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing
            tabla = Nothing


        End Try


    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from General where Fase like '" & lblfase.Text & "%'" & "And Clave like'" & MaskedTextBox1.Text & "%'", con)


        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)
            DataGridView1.DataSource = tabla

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing
            tabla = Nothing


        End Try

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Fase1 where Clave like '" & MaskedTextBox1.Text & "%'", con)


        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)
            DataGridView1.DataSource = tabla

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing
            tabla = Nothing


        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from General where Fase like '" & lblfase.Text & "%'" & "And Municipio like '" & ComboBox2.Text & "%'", con)


        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)
            DataGridView1.DataSource = tabla

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing
            tabla = Nothing

        End Try
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'OpenFileDialog1.ShowDialog()
        'LabelP.Text = OpenFileDialog1.FileName.ToString
        'PicBloc.Image = System.Drawing.Image.FromFile(LabelP.Text)

        Try
            Dim nombreimagen As String
            Dim nombreimagenarchivo As String
            'abrimos el cuadro de dialogo
            OpenFileDialog1.ShowDialog()
            'vemos si existe el directorio para archivar las imagenes sino lo creamos
            If System.IO.Directory.Exists(Application.StartupPath & "\imagenes") = False Then
                System.IO.Directory.CreateDirectory(Application.StartupPath & "\imagenes")
            End If
            'asignamos el path de la imagen seleccionada por el usuario
            nombreimagen = Application.StartupPath & "\imagenes\" & OpenFileDialog1.SafeFileName
            'este es el nombre que vamos a archivar en la base de datos.
            nombreimagenarchivo = "\imagenes\" & OpenFileDialog1.SafeFileName

            LabelP.Text = nombreimagenarchivo

            'Copia la imagen seleccionada en el cuadro de dialogo en el lugar que dice la variable -nombre-
            If OpenFileDialog1.FileName <> nombreimagen Then
                Call FileCopy(OpenFileDialog1.FileName, nombreimagen)
            End If
            'mostramos la imagen con la variable con el path completo
            PicBloc.Load(nombreimagen)
            'cargamos en el registro actual, fijarse en el datagrid donde esta posicionado el puntero
            'el path corto
            'esto es fundamental para cuando se traslada el programa a otra computadora, si se traslada la carpeta 
            'imagenes y sonidos en ningun momento dejará de verse las fotos y sonidos relacionados con tal o cual registro.
            'Me.PersonalBindingSource.Current("foto") = nombreimagenarchivo.ToString
            'Me.Validate()
            'Me.PersonalBindingSource.EndEdit()
            'Me.PersonalTableAdapter.Update(Me.AgendaDataSet.personal)
        Catch ex As System.Exception
            'Si se cancela el cuadro de dialogo, se podría controlar desde aquí el mensaje que envía al operador.
            'Esta es para el programador para que vea que hay que controlar este error
            'Si queres ver los errores activala
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        R_Impresion.Show()

    End Sub


    Private Sub txtN_Desembolso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN_Desembolso.SelectedIndexChanged

        If modificar = True Then



            If txtN_Desembolso.Text = 1 Then

                txtD1.Enabled = True

                txtD1.Text = Val(txtMonto.Text) / 10

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
                txtD2.Text = Val(txtMonto.Text) / 10

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
                txtD3.Text = Val(txtMonto.Text) / 10

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
                txtD4.Text = Val(txtMonto.Text) / 10

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
                txtD5.Text = Val(txtMonto.Text) / 10

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
                txtD6.Text = Val(txtMonto.Text) / 10

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
                txtD7.Text = Val(txtMonto.Text) / 10

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
                txtD8.Text = Val(txtMonto.Text) / 10

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
                txtD9.Text = Val(txtMonto.Text) / 10

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
                txtD10.Text = Val(txtMonto.Text) / 10

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


        Else



            If txtN_Desembolso.Text = 1 Then

                txtD1.Enabled = False

                txtD1.Text = Val(txtMonto.Text) / 10

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
                txtD2.Text = Val(txtMonto.Text) / 10

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

            End If

            If txtN_Desembolso.Text = 3 Then
                txtD3.Text = Val(txtMonto.Text) / 10

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

            End If

            If txtN_Desembolso.Text = 4 Then
                txtD4.Text = Val(txtMonto.Text) / 10

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

            End If

            If txtN_Desembolso.Text = 5 Then
                txtD5.Text = Val(txtMonto.Text) / 10

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

            End If

            If txtN_Desembolso.Text = 6 Then
                txtD6.Text = Val(txtMonto.Text) / 10

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

            End If

            If txtN_Desembolso.Text = 7 Then
                txtD7.Text = Val(txtMonto.Text) / 10

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


            End If

            If txtN_Desembolso.Text = 8 Then
                txtD8.Text = Val(txtMonto.Text) / 10

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


            End If

            If txtN_Desembolso.Text = 9 Then
                txtD9.Text = Val(txtMonto.Text) / 10

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


            End If

            If txtN_Desembolso.Text = 10 Then
                txtD10.Text = Val(txtMonto.Text) / 10

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

            End If


        End If



    End Sub



    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        F_MovimientosS.ComboTipo.Text = "Salida"
        F_MovimientosS.txtTipo.Text = "Salida"
        F_MovimientosS.txtConcepto.Text = "Prestamos de Insumos"



        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable









        F_MovimientosS.AF = True
        F_MovimientosS.salir = "S"

        F_MovimientosS.btnNuevo.Visible = False
        F_MovimientosS.btnNoNuevo.Visible = True
        F_MovimientosS.btnNoSave.Visible = False
        F_MovimientosS.btnGuardar.Visible = True


        If txtN_Desembolso.Text = 1 Then

            F_MovimientosS.txtMonto_Desembolsado.Text = txtD1.Text

        End If

        If txtN_Desembolso.Text = 2 Then

            F_MovimientosS.txtMonto_Desembolsado.Text = txtD2.Text

        End If

        If txtN_Desembolso.Text = 3 Then

            F_MovimientosS.txtMonto_Desembolsado.Text = txtD3.Text

        End If

        If txtN_Desembolso.Text = 4 Then

            F_MovimientosS.txtMonto_Desembolsado.Text = txtD4.Text

        End If

        If txtN_Desembolso.Text = 5 Then

            F_MovimientosS.txtMonto_Desembolsado.Text = txtD5.Text

        End If

        If txtN_Desembolso.Text = 6 Then

            F_MovimientosS.txtMonto_Desembolsado.Text = txtD6.Text

        End If

        If txtN_Desembolso.Text = 7 Then

            F_MovimientosS.txtMonto_Desembolsado.Text = txtD7.Text

        End If

        If txtN_Desembolso.Text = 8 Then

            F_MovimientosS.txtMonto_Desembolsado.Text = txtD8.Text

        End If

        If txtN_Desembolso.Text = 9 Then

            F_MovimientosS.txtMonto_Desembolsado.Text = txtD9.Text

        End If

        If txtN_Desembolso.Text = 10 Then

            F_MovimientosS.txtMonto_Desembolsado.Text = txtD10.Text

        End If

        F_MovimientosS.txtContador.Text = 1



        F_MovimientosS.txtN_Prestamo.Text = txtid.Text
        F_MovimientosS.txtN_Regional.Text = 1
        F_MovimientosS.txtN_Prestamo.Text = txtid.Text
        If txtAgencia.Text = "1 - A, S.B." Then

            F_MovimientosS.txtN_Agencia.Text = "1"

        End If

        If txtAgencia.Text = "1 - B, S.B." Then

            F_MovimientosS.txtN_Agencia.Text = "1"

        End If


        If txtAgencia.Text = "Colinas" Then

            F_MovimientosS.txtN_Agencia.Text = "2"

        End If

        If txtAgencia.Text = "Trinidad" Then

            F_MovimientosS.txtN_Agencia.Text = "3"

        End If

        If txtAgencia.Text = "San Nicolas" Then

            F_MovimientosS.txtN_Agencia.Text = "4"

        End If


        If txtAgencia.Text = "San Luis" Then

            F_MovimientosS.txtN_Agencia.Text = "5"

        End If


        If txtAgencia.Text = "La Union Lempira" Then

            F_MovimientosS.txtN_Agencia.Text = "6"

        End If


        F_MovimientosS.txtRegional.Text = "Santa Barbara"



        F_MovimientosS.txtCantidad_Disponible.Text = lblSaldo.Text

        F_MovimientosS.txtIdentidad.Text = txtIdentidad.Text
        F_MovimientosS.txtAgencia.Text = txtAgencia.Text
        F_MovimientosS.txtN_Desembolso.Text = txtN_Desembolso.Text
        F_MovimientosS.txtNombres.Text = txtNombreP.Text
        F_MovimientosS.ComboFase.Text = lblfase.Text
        F_MovimientosS.txtClave.Text = txtclave.Text
        F_MovimientosS.txtMonto_Aprobado.Text = txtMonto.Text


        F_Menu_Movimientos.menu_salida = 3

        opcion = "D"

        F_MovimientosS.AñadirRegistroToolStripMenuItem.Enabled = True
        F_MovimientosS.btnGuardar.Visible = False

        F_MovimientosS.btnNoSave.Visible = True



        F_MovimientosS.txtOrden.Text = My.Settings.MyOrden + 1
        F_MovimientosS.txtN.Text = My.Settings.MyMovimiento + 1

        Dim da As New SqlDataAdapter("Select * from Productos2 Where Factura like'" & F_MovimientosS.txtOrden.Text & "%'", con)


        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            F_MovimientosS.DataGridView1.DataSource = tabla

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing

            tabla = Nothing

        End Try



        'Dim total As Integer



        'total = Val(F_MovimientosS.txtOrden.Text) + 1

        'F_MovimientosS.txtOrden.Text = total



        F_MovimientosS.Show()
        


    End Sub

   
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
     
    End Sub

   

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter


    End Sub


    Private Sub GroupBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GroupBox1.MouseMove
        ContextMenuStrip = ContextMenuStrip1
    End Sub

    Private Sub GroupBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GroupBox2.MouseMove
        ContextMenuStrip = ContextMenuStrip2
    End Sub

    Private Sub AñadirProductorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirProductorToolStripMenuItem.Click

        F_Lista_Productores.opciones = True

        F_Lista_Productores.txtfase.Text = lblfase.Text

        F_Lista_Productores.Show()

    End Sub

    Private Sub ModificarMontoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        F_Productores.Show()
    End Sub

    Private Sub ModificarDesembolso1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    End Sub

    Private Sub ModificarDesembolso2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    End Sub

    Private Sub ModificarDesembolso3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    End Sub

    Private Sub ModificarDesembolso4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    End Sub

    Private Sub ModificarDesembolso5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    End Sub

    Private Sub ModificarDesembolso6ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    End Sub

    Private Sub ModificarDesembolso7ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    End Sub

    Private Sub ModificarDesembolso8ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    End Sub

    Private Sub ModificarDesembolso9ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    End Sub

    Private Sub ModificarDesembolso10ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    End Sub


    Private Sub ModificarNºDesembolsoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarNºDesembolsoToolStripMenuItem.Click
        txtN_Desembolso.Enabled = True
        modificar = True
    End Sub

    Private Sub ModificarDesembolso1ToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
    End Sub

    Private Sub btnSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir2.Click

        Me.AñadirProductorToolStripMenuItem.Enabled = False


        Dim resp As Integer
        resp = MsgBox("¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "P.A.P.P System")
        If resp = 6 Then
            limpiar()

            Dim total As Integer

            total = Val(txtid.Text) - 1

            txtid.Text = total

            Dim total2 As Integer

            total2 = Val(txtnro.Text) - 1

            txtnro.Text = total2

            btnNuevo.Visible = True
            btnNoNuevo.Visible = False
            btnGuardar.Visible = False
            btnNoSave.Visible = True
            btnModificar.Visible = False
            btnNoModificar.Visible = True
            btnEliminar.Visible = False
            btnNoEliminar.Visible = True


            btnSalir.Visible = True
            btnSalir2.Visible = False


            Me.Close()

        
        End If
    End Sub

    Private Sub btnSalir_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSalir.MouseMove
        btnSalir.Visible = False
        btnSalir2.Visible = True
    End Sub

    Private Sub btnSalir2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir2.MouseLeave

        btnSalir.Visible = True
        btnSalir2.Visible = False

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub
End Class