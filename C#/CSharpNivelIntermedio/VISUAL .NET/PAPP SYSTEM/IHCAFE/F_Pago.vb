Imports System.Data.SqlClient


Public Class F_Pago

    Dim modificar As Boolean
    Dim accion As Boolean
    Public opcion As String
    Public abonono As Integer


    Private Sub limpiar()

        Me.txtclave.Text = ""
        Me.txtIdentidad.Text = ""
        Me.txtNombreP.Text = ""
        Me.txtAgencia.Text = ""
        Me.txtMunicipio.Text = ""
        Me.txtclave.Text = ""
        Me.txtMonto.Text = ""
        Me.txtA1.Text = "0"
        Me.txtA2.Text = "0"
        Me.txtA3.Text = "0"
        lblSaldo.Text = "0.00"
        Me.txtbuscarnombre.Text = ""
        txtMonto.Text = "0"
        txtN_Abono.Text = 1

        
    End Sub

    Sub Bloquear()
        Me.txtIdentidad.Enabled = False
        Me.txtNombreP.Enabled = False
        Me.txtclave.Enabled = False
        Me.txtAgencia.Enabled = False
        Me.txtMunicipio.Enabled = False
        Me.txtMonto.Enabled = False
        txtN_Abono.Enabled = False
        txtA1.Enabled = False
        txtA2.Enabled = False
        txtA3.Enabled = False
    End Sub


    Sub Desbloquear()
        Me.txtIdentidad.Enabled = True
        Me.txtNombreP.Enabled = True
        Me.txtclave.Enabled = True
        Me.txtAgencia.Enabled = True
        Me.txtMunicipio.Enabled = True
        Me.txtMonto.Enabled = True
        lblSaldo.Enabled = True
    End Sub


    Private Sub AñadirProductorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirProductorToolStripMenuItem.Click

        F_Lista_Productores.opciones = False

        F_Lista_Productores.txtfase.Text = lblFase.Text

        F_Lista_Productores.Show()

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GroupBox1.MouseMove
        ContextMenuStrip = ContextMenuStrip1
    End Sub



    Private Sub F_Pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblEstado.Text = ""
        'TODO: esta línea de código carga datos en la tabla 'FasesDataSet.Configuracion' Puede moverla o quitarla según sea necesario.
        Me.ConfiguracionTableAdapter.Fill(Me.FasesDataSet.Configuracion)
        LabelP.Text = "\imagenes\IHCAFE.bmp"

        lblfecha.Text = Format(Now(), "dd/MM/yyyy")
        lblUsuario.Text = F_Menu.lblUsuario.Text

        lblFase.Text = Val(F_Fases.ComboBox1.Text)

        Bloquear()


        Me.AñadirProductorToolStripMenuItem.Enabled = False
        Me.ModificarNºDesembolsoToolStripMenuItem.Enabled = False



        
        lblSaldo.Text = "0.00"




        LabelP.Text = "\imagenes\Logo.png"
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click



        Me.AñadirProductorToolStripMenuItem.Enabled = True
        
        PicBloc.Load(Application.StartupPath & LabelP.Text)

        txtMonto.Text = "0"

        btnNuevo.Visible = False
        btnNoNuevo.Visible = True
        btnGuardar.Visible = True
        btnNoSave.Visible = False
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True
        accion = True
        'Desbloquear()
        limpiar()


    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click


        If txtclave.Text <> " - -    " And txtIdentidad.Text <> "" And lblFase.Text <> "    -    -" And txtNombreP.Text <> "" And txtAgencia.Text <> "" And txtMunicipio.Text <> "" And txtMonto.Text <> "" Then


            Me.AñadirProductorToolStripMenuItem.Enabled = False


            Dim conexion As New Conexion_Pagos
            Dim datos As New dPagos


            datos.clave = txtclave.Text
            datos.Identidad = txtIdentidad.Text
            datos.nombre = txtNombreP.Text
            datos.Agencia = txtAgencia.Text
            datos.Municipio = txtMunicipio.Text
            datos.Monto = txtMonto.Text
            datos.NA = txtN_Abono.Text
            datos.A1 = txtA1.Text
            datos.A2 = txtA2.Text
            datos.A3 = txtA3.Text
            datos.Saldo = lblSaldo.Text
            datos.Fase = lblFase.Text
            datos.Foto = LabelP.Text
            datos.Fecha = lblfecha.Text
            datos.Usuario = lblUsuario.Text
            datos.letras = lblLetras.Text

            Dim n As New Validar_Datos_Pagos
            Dim c As New Validar_Datos_pagos


            Dim crol As String
            Dim ide As String


            crol = n.Comprobar_Clave1(UCase(txtclave.Text))
            ide = c.Comprobar_Identidad1(UCase(txtIdentidad.Text))


            If crol = "N" And ide = "S" Then

                If accion = True Then
                    If conexion.insertar_datos_pagos(datos) Then


                        Dim constr As String

                        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

                        Dim con As New SqlConnection(constr)
                        Dim ds As New DataSet
                        Dim tabla As New DataTable

                        Dim da As New SqlDataAdapter("Select * from Pagos  where Nombre like '" & txtNombreP.Text & "%'", con)


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


                        MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

Dim resp As Integer


                        resp = MsgBox("¿Desea Imprimir el Recibo?", MsgBoxStyle.YesNo, "P.A.P.P System")

                        If resp = 6 Then


                            Dim conexion2 As New Conexion_Pagos
                            Dim datos2 As New dPagos
                            Dim tabla2 As New DataTable
                            Dim mireporte As New Crys_Recibo

                            datos2.clave = txtclave.Text

                            If conexion2.consultar_recibos(datos2) Then

                                tabla2 = conexion2.tabla
                                mireporte.SetDataSource(tabla2)
                                R_Recibo.CrystalReportViewer1.ReportSource = mireporte
                                R_Recibo.CrystalReportViewer1.RefreshReport()
                                R_Recibo.Show()


                            End If

                        End If
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

                    If conexion.actualizar_datos_pagos(datos) Then


                        Dim constr As String

                        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

                        Dim con As New SqlConnection(constr)
                        Dim ds As New DataSet
                        Dim tabla As New DataTable

                        Dim da As New SqlDataAdapter("Select * from Pagos  where Nombre like '" & txtNombreP.Text & "%'", con)


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

                        lblEstado.Visible = False


                        Dim resp As Integer


                        resp = MsgBox("¿Desea Imprimir el Recibo?", MsgBoxStyle.YesNo, "P.A.P.P System")

                        If resp = 6 Then


                            Dim conexion2 As New Conexion_Pagos
                            Dim datos2 As New dPagos
                            Dim tabla2 As New DataTable
                            Dim mireporte As New Crys_Recibo

                            datos.clave = txtclave.Text

                            If conexion2.consultar_recibos(datos2) Then

                                tabla2 = conexion2.tabla
                                mireporte.SetDataSource(tabla2)
                                R_Recibo.CrystalReportViewer1.ReportSource = mireporte
                                R_Recibo.CrystalReportViewer1.RefreshReport()
                                R_Recibo.Show()

                            End If



                        End If




                        If Val(lblSaldo.Text) < 1 Then

                            F_Productores.txtObservacion.Text = "PRESTAMO CANCELADO"


                            F_Productores.txtclave.Text = txtclave.Text
                            F_Productores.txtIdentidad.Text = txtIdentidad.Text
                            F_Productores.txtNombreP.Text = txtNombreP.Text
                            F_Productores.txtAgencia.Text = txtAgencia.Text
                            F_Productores.txtMunicipio.Text = txtMunicipio.Text
                            F_Productores.txtMonto.Text = txtMonto.Text
                            F_Productores.txtfase.Text = txtFase.Text

                            F_Productores.btnGuardar_Click(True, Nothing)


                        End If

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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GroupBox2.MouseMove
        ContextMenuStrip = ContextMenuStrip2
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Pagos where Fase like '" & txtFase.Text & "%'" & "And Agencia like'" & ComboBox3.Text & "%'", con)


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

    Private Sub txtFase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFase.SelectedIndexChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Pagos where Fase like '" & txtFase.Text & "%'", con)


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

    Private Sub txtbuscarnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarnombre.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Pagos  where Fase like '" & txtFase.Text & "%'" & "And Nombre like'" & txtbuscarnombre.Text & "%'", con)


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

        Dim da As New SqlDataAdapter("Select * from Pagos where Fase like '" & txtFase.Text & "%'" & "And Clave like'" & MaskedTextBox1.Text & "%'", con)


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

    End Sub

    Private Sub btnEliminar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.MouseEnter
        btnEliminar.Height = 45
        btnEliminar.Width = 45
    End Sub

    Private Sub btnEliminar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.MouseLeave
        btnEliminar.Height = 50
        btnEliminar.Width = 50
    End Sub

    Private Sub txtN_Abono_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN_Abono.SelectedIndexChanged

        If modificar = True Then

            If txtN_Abono.Text = 1 Then

                txtA1.Enabled = True
                txtA1.Text = Math.Round((Val(txtMonto.Text) / 3), 2, MidpointRounding.ToEven)


                txtA2.Enabled = False
                txtA3.Enabled = False


            End If

            If txtN_Abono.Text = 2 Then

                txtA2.Enabled = True

                txtA2.Text = Math.Round((Val(txtMonto.Text) / 3), 2, MidpointRounding.ToEven)


                txtA1.Enabled = False
                txtA3.Enabled = False

            End If

            If txtN_Abono.Text = 3 Then

                txtA3.Enabled = True

                txtA3.Text = Math.Round((Val(txtMonto.Text) / 3), 2, MidpointRounding.ToEven)

                txtA1.Enabled = False
                txtA2.Enabled = False

            End If


        Else

            If txtN_Abono.Text = 1 Then

                txtA1.Enabled = True


                txtA1.Text = Math.Round((Val(txtMonto.Text) / 3), 2, MidpointRounding.ToEven)

                txtA2.Enabled = False
                txtA3.Enabled = False

            End If

            If txtN_Abono.Text = 2 Then

                txtA2.Enabled = False

                txtA2.Text = Math.Round((Val(txtMonto.Text) / 3), 2, MidpointRounding.ToEven)

                txtA1.Enabled = False
                txtA3.Enabled = False

            End If

            If txtN_Abono.Text = 3 Then

                txtA3.Enabled = True
                txtA2.Text = Math.Round((Val(txtMonto.Text) / 3), 2, MidpointRounding.ToEven)

                txtA1.Enabled = False
                txtA2.Enabled = False

            End If

        End If


    End Sub

    
    Private Sub ModificarNºDesembolsoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarNºDesembolsoToolStripMenuItem.Click
        txtN_Abono.Enabled = True
        modificar = True
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Try

            
            txtclave.Text = DataGridView1.SelectedCells(0).Value.ToString()
            txtIdentidad.Text = DataGridView1.SelectedCells(1).Value.ToString()
            txtNombreP.Text = DataGridView1.SelectedCells(2).Value.ToString()
            txtAgencia.Text = DataGridView1.SelectedCells(3).Value.ToString()
            txtMunicipio.Text = DataGridView1.SelectedCells(4).Value.ToString()
            txtMonto.Text = DataGridView1.SelectedCells(5).Value.ToString()
            txtN_Abono.Text = DataGridView1.SelectedCells(6).Value.ToString()
            'a = DataGridView1.SelectedCells(7).Value.ToString()
            'b = DataGridView1.SelectedCells(8).Value.ToString()
            'c = DataGridView1.SelectedCells(9).Value.ToString()
            lblSaldo.Text = DataGridView1.SelectedCells(10).Value.ToString()


            txtN_Abono.Text = Val(txtN_Abono.Text) + 1



            If Val(txtN_Abono.Text) = 2 Then


                txtA1.Text = 6666.67
                txtA2.Text = 6666.67
                txtA3.Text = 0.0


            End If

            If Val(txtN_Abono.Text) = 3 Then

                txtA1.Text = 6666.67
                txtA2.Text = 6666.67
                txtA3.Text = 6666.67

            End If

            If Val(lblSaldo.Text) < 1 Then


                lblSaldo.Text = "0.00"

            End If


            lblFase.Text = DataGridView1.SelectedCells(11).Value.ToString()
            PicBloc.Load(Application.StartupPath & DataGridView1.SelectedCells(12).Value.ToString)
            lblfecha.Text = DataGridView1.SelectedCells(13).Value.ToString()
            lblUsuario.Text = DataGridView1.SelectedCells(14).Value.ToString()


            'txtA1.Text = Math.Round(a, 2, MidpointRounding.ToEven)
            'txtA2.Text = Math.Round(b, 2, MidpointRounding.ToEven)
            'txtA3.Text = Math.Round(c, 2, MidpointRounding.ToEven)


            lblEstado.Visible = True



            If txtcargo.Text = 2 Then

                btnEliminar.Visible = False
                btnNoEliminar.Visible = True
                btnModificar.Visible = False
                btnNoModificar.Visible = True
                btnGuardar.Visible = True
                btnNoSave.Visible = False
                ModificarNºDesembolsoToolStripMenuItem.Enabled = False
            End If

            If txtcargo.Text = 1 Then

                btnEliminar.Visible = True

                btnEliminar.Visible = True
                btnNoEliminar.Visible = False
                btnModificar.Visible = False
                btnNoModificar.Visible = True
                btnGuardar.Visible = True
                btnNoSave.Visible = False
                ModificarNºDesembolsoToolStripMenuItem.Enabled = True



            End If


        
            TabControl1.SelectedIndex = 0

            accion = False

        Catch ex As Exception
        End Try

    End Sub

    Public Function Letras(ByVal numero As String) As String
        '********Declara variables de tipo cadena************
        Dim palabras, entero, dec, flag As String

        '********Declara variables de tipo entero***********
        Dim num, x, y As Integer

        flag = "N"

        '**********Número Negativo***********
        If Mid(numero, 1, 1) = "-" Then
            numero = Mid(numero, 2, numero.ToString.Length - 1).ToString
            palabras = "menos "
        End If

        '**********Si tiene ceros a la izquierda*************
        For x = 1 To numero.ToString.Length
            If Mid(numero, 1, 1) = "0" Then
                numero = Trim(Mid(numero, 2, numero.ToString.Length).ToString)
                If Trim(numero.ToString.Length) = 0 Then palabras = ""
            Else
                Exit For
            End If
        Next

        '*********Dividir parte entera y decimal************
        For y = 1 To Len(numero)
            If Mid(numero, y, 1) = "." Then
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, y, 1)
                Else
                    dec = dec + Mid(numero, y, 1)
                End If
            End If
        Next y

        If Len(dec) = 1 Then dec = dec & "0"

        '**********proceso de conversión***********
        flag = "N"

        If Val(numero) <= 999999999 Then
            For y = Len(entero) To 1 Step -1
                num = Len(entero) - (y - 1)
                Select Case y
                    Case 3, 6, 9
                        '**********Asigna las palabras para las centenas***********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" And Mid(entero, num + 2, 1) = "0" Then
                                    palabras = palabras & "Cien "
                                Else
                                    palabras = palabras & "Ciento "
                                End If
                            Case "2"
                                palabras = palabras & "Doscientos "
                            Case "3"
                                palabras = palabras & "Trescientos "
                            Case "4"
                                palabras = palabras & "Cuatrocientos "
                            Case "5"
                                palabras = palabras & "Quinientos "
                            Case "6"
                                palabras = palabras & "Seiscientos "
                            Case "7"
                                palabras = palabras & "Setecientos "
                            Case "8"
                                palabras = palabras & "Ochocientos "
                            Case "9"
                                palabras = palabras & "Novecientos "
                        End Select
                    Case 2, 5, 8
                        '*********Asigna las palabras para las decenas************
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    flag = "S"
                                    palabras = palabras & "Diez "
                                End If
                                If Mid(entero, num + 1, 1) = "1" Then
                                    flag = "S"
                                    palabras = palabras & "Once "
                                End If
                                If Mid(entero, num + 1, 1) = "2" Then
                                    flag = "S"
                                    palabras = palabras & "Doce "
                                End If
                                If Mid(entero, num + 1, 1) = "3" Then
                                    flag = "S"
                                    palabras = palabras & "Trece "
                                End If
                                If Mid(entero, num + 1, 1) = "4" Then
                                    flag = "S"
                                    palabras = palabras & "Catorce "
                                End If
                                If Mid(entero, num + 1, 1) = "5" Then
                                    flag = "S"
                                    palabras = palabras & "Quince "
                                End If
                                If Mid(entero, num + 1, 1) > "5" Then
                                    flag = "N"
                                    palabras = palabras & "Dieci"
                                End If
                            Case "2"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Veinte "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Veinti"
                                    flag = "N"
                                End If
                            Case "3"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Treinta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Treinta y "
                                    flag = "N"
                                End If
                            Case "4"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Cuarenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Cuarenta y "
                                    flag = "N"
                                End If
                            Case "5"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Cincuenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Cincuenta y "
                                    flag = "N"
                                End If
                            Case "6"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Sesenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Sesenta y "
                                    flag = "N"
                                End If
                            Case "7"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Setenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Setenta y "
                                    flag = "N"
                                End If
                            Case "8"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Ochenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Ochenta y "
                                    flag = "N"
                                End If
                            Case "9"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Noventa "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Noventa y "
                                    flag = "N"
                                End If
                        End Select
                    Case 1, 4, 7
                        '*********Asigna las palabras para las unidades*********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If flag = "N" Then
                                    If y = 1 Then
                                        palabras = palabras & "Uno "
                                    Else
                                        palabras = palabras & "Un "
                                    End If
                                End If
                            Case "2"
                                If flag = "N" Then palabras = palabras & "Dos "
                            Case "3"
                                If flag = "N" Then palabras = palabras & "Tres "
                            Case "4"
                                If flag = "N" Then palabras = palabras & "Cuatro "
                            Case "5"
                                If flag = "N" Then palabras = palabras & "Cinco "
                            Case "6"
                                If flag = "N" Then palabras = palabras & "Seis "
                            Case "7"
                                If flag = "N" Then palabras = palabras & "Siete "
                            Case "8"
                                If flag = "N" Then palabras = palabras & "Ocho "
                            Case "9"
                                If flag = "N" Then palabras = palabras & "Nueve "
                        End Select
                End Select

                '***********Asigna la palabra mil***************
                If y = 4 Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or _
                    (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And _
                    Len(entero) <= 6) Then palabras = palabras & "mil "
                End If

                '**********Asigna la palabra millón*************
                If y = 7 Then
                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                        palabras = palabras & "millón "
                    Else
                        palabras = palabras & "millones "
                    End If
                End If
            Next y

            '**********Une la parte entera y la parte decimal*************
            If dec <> "" Then
                Letras = palabras & "con " & dec
            Else
                Letras = palabras
            End If
        Else
            Letras = ""
        End If

    End Function



    Private Sub txtA1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtA1.TextChanged


        lblLetras.Text = ""
        If IsNumeric(txtA1.Text) Then
            lblLetras.Text = Letras(txtA1.Text)
        Else
            '    MessageBox.Show("Ingrese por favor el Monto a solicitar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If





        Dim total As Double

        total = Val(txtMonto.Text) - Val(txtA1.Text)

        lblSaldo.Text = total

        If Val(lblSaldo.Text) < 1 Then
            lblEstado.Visible = True
            lblEstado.Text = "          PRESTAMO CANCELADO          "

        Else
            lblEstado.Text = ""

        End If


    End Sub


    Private Sub txtA3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtA3.TextChanged



        lblLetras.Text = ""
        If IsNumeric(txtA1.Text) Then
            lblLetras.Text = Letras(txtA1.Text)
        Else
            ' MessageBox.Show("Ingrese por favor el Monto a solicitar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



        Dim total As Integer

        total = Val(txtMonto.Text) - Val(txtA1.Text) - Val(txtA2.Text) - Val(txtA3.Text)

        lblSaldo.Text = total


        If Val(lblSaldo.Text) < 1 Then
            lblEstado.Visible = True
            lblEstado.Text = "          PRESTAMO CANCELADO          "

        Else
            lblEstado.Text = ""

        End If


    End Sub

    Private Sub txtA2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtA2.TextChanged


        lblLetras.Text = ""
        If IsNumeric(txtA1.Text) Then
            lblLetras.Text = Letras(txtA1.Text)
        Else
            ' MessageBox.Show("Ingrese por favor el Monto a solicitar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



        Dim total As Double

        total = Val(txtMonto.Text) - Val(txtA1.Text) - Val(txtA2.Text)

        lblSaldo.Text = total


        If Val(lblSaldo.Text) < 1 Then
            lblEstado.Visible = True
            lblEstado.Text = "          PRESTAMO CANCELADO          "

        Else
            lblEstado.Text = ""

        End If



    End Sub

    Private Sub btnSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir2.Click

        Dim resp As String

        resp = MsgBox("¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "P.A.P.P System")
        If resp = 6 Then

            limpiar()
            btnSalir.Visible = True
            btnSalir2.Visible = False
            Me.Close()
        End If

    End Sub

    Private Sub btnSalir2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir2.MouseLeave
        btnSalir.Visible = True
        btnSalir2.Visible = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

    End Sub

    Private Sub btnSalir_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSalir.MouseMove
        btnSalir.Visible = False
        btnSalir2.Visible = True
    End Sub


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim resp As Integer


        resp = MsgBox("¿Desea Imprimir el Contrato?", MsgBoxStyle.YesNo, "P.A.P.P System")

        If resp = 6 Then


            Dim conexion2 As New Conexion_Pagos
            Dim datos2 As New dPagos
            Dim tabla2 As New DataTable
            Dim mireporte As New Crys_Recibo

            datos2.clave = txtclave.Text

            If conexion2.consultar_recibos(datos2) Then

                tabla2 = conexion2.tabla
                mireporte.SetDataSource(tabla2)
                R_Recibo.CrystalReportViewer1.ReportSource = mireporte
                R_Recibo.CrystalReportViewer1.RefreshReport()
                R_Recibo.Show()


            End If

        End If

    End Sub
End Class