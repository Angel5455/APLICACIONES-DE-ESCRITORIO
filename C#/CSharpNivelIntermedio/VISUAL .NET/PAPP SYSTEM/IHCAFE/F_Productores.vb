Imports System.Data.SqlClient

Public Class F_Productores

    Public accion As Boolean


    Sub limpiar()

        txtclave.Text = ""
        txtNombreP.Text = ""
        txtIdentidad.Text = ""
        txtAgencia.Text = ""
        txtMunicipio.Text = ""
        txtMonto.Text = "20000"
        txtObservacion.Text = ""
        txtmanzanas.Text = ""

    End Sub

    Private Sub F_Productores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FasesDataSet.Configuracion' Puede moverla o quitarla según sea necesario.
        Me.ConfiguracionTableAdapter.Fill(Me.FasesDataSet.Configuracion)



        Me.ContextMenuStrip = ContextMenuStrip1

        Me.AgregarPorSolicitudToolStripMenuItem.Enabled = False
        lblfecha.Text = Format(Now(), "dd/MM/yyyy")


        lblUsuario.Text = F_Menu.lblUsuario.Text

        LabelP.Text = "\imagenes\LOGO.png"

        
        Dim conexion As New Conexion_Fases
        Dim tabla As New DataTable

        If conexion.consultar_todos_productor Then
            tabla = conexion.tabla
            DataGridView1.DataSource = tabla
        Else
            MessageBox.Show("No se pudo consultar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub


    Private Sub btnNoNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoNuevo.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Nuevo")

    End Sub

    Private Sub btnNoSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoSave.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Guardar")
    End Sub

    Private Sub btnNoModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoModificar.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Modificar")
    End Sub

    Private Sub btnNoEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoEliminar.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Eliminar")
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
        Me.AgregarPorSolicitudToolStripMenuItem.Enabled = True
        Button2.Enabled = True

        ' PicBloc.Load(Application.StartupPath & LabelP.Text)


        btnNuevo.Visible = False
        btnNoNuevo.Visible = True
        btnGuardar.Visible = True
        btnNoSave.Visible = False
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True
        accion = True

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


    Private Sub btnNoSave_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoSave.MouseEnter
        btnNoSave.Height = 45
        btnNoSave.Width = 45

    End Sub

    Private Sub btnNoSave_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoSave.MouseLeave
        btnNoSave.Height = 50
        btnNoSave.Width = 50

    End Sub

    Public Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click



        If txtclave.Text <> " - -    " And txtIdentidad.Text <> "" And txtfase.Text <> "    -    -" And txtNombreP.Text <> "" And txtAgencia.Text <> "" And txtMunicipio.Text <> "" And txtMonto.Text <> "" And txtmanzanas.Text <> "" Then

            Dim conexion As New Conexion_Fases
            Dim datos As New dFases

            datos.clave = txtclave.Text
            datos.nombre = txtNombreP.Text
            datos.Identidad = txtIdentidad.Text
            datos.Fase = txtfase.Text
            datos.Fecha = lblfecha.Text
            datos.Agencia = txtAgencia.Text
            datos.Municipio = txtMunicipio.Text
            datos.Monto = txtMonto.Text
            datos.observacion = txtObservacion.Text
            datos.manzanas = txtmanzanas.Text

            datos.Foto = LabelP.Text


            Dim n As New Validar_Datos
            Dim c As New Validar_Datos


            Dim crol As String
            Dim ide As String


            crol = n.Comprobar_ClaveP(UCase(txtclave.Text))
            ide = c.Comprobar_IdentidadP(UCase(txtIdentidad.Text))


            If crol = "N" And ide = "S" Then

                If accion = True Then
                    If conexion.insertar_datos_productor(datos) Then
                        If conexion.consultar_todos_productor Then

                            DataGridView1.DataSource = conexion.tabla

                        End If

                        MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        Dim resp As Integer


                        resp = MsgBox("¿Desea Imprimir el Contrato?", MsgBoxStyle.YesNo, "P.A.P.P System")

                        If resp = 6 Then


                            Dim conexion2 As New Conexion_Fases
                            Dim datos2 As New dFases
                            Dim tabla As New DataTable
                            Dim mireporte As New Crys_Contrato

                            datos.clave = txtclave.Text

                            If conexion2.consultar_productor(datos) Then

                                tabla = conexion2.tabla
                                mireporte.SetDataSource(tabla)
                                R_Contrato.CrystalReportViewer1.ReportSource = mireporte
                                R_Contrato.CrystalReportViewer1.RefreshReport()
                                R_Contrato.Show()


                            End If



                        End If



                    Else

                        MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If

                End If


                btnNuevo.Visible = True
                btnNoNuevo.Visible = False


                btnGuardar.Visible = False
                btnNoSave.Visible = True
                btnModificar.Visible = False
                btnNoModificar.Visible = True
                btnEliminar.Visible = False
                btnNoEliminar.Visible = True



            Else


                If accion = False Then

                    If conexion.actualizar_datos_productor(datos) Then
                        If conexion.consultar_todos_productor Then
                            DataGridView1.DataSource = conexion.tabla
                        End If

                        MessageBox.Show("REGISTRO ACTUALIZADO", "ACTUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        MessageBox.Show("REGISTRO NO ACTUALIZADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

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

                Else

                    If crol <> "N" Then
                        MsgBox("Clave Ya existe", MsgBoxStyle.Information, "P.A.P.P")

                        btnNuevo.Visible = True
                        btnNoNuevo.Visible = False
                        btnGuardar.Visible = False
                        btnNoSave.Visible = True

                    End If


                    If ide <> "S" Then
                        MsgBox("Identidad Ya existe", MsgBoxStyle.Information, "P.A.P.P")

                        btnNuevo.Visible = True
                        btnNoNuevo.Visible = False
                        btnGuardar.Visible = False
                        btnNoSave.Visible = True

                    End If


                End If
            End If


            Button2.Enabled = False
            txtclave.BackColor = Color.White
            txtIdentidad.BackColor = Color.White
            txtfase.BackColor = Color.White
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

            If txtfase.Text = "" Then

                txtfase.BackColor = Color.OrangeRed
            Else

                txtfase.BackColor = Color.White

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

            If txtmanzanas.Text = "" Then

                txtmanzanas.BackColor = Color.OrangeRed
            Else

                txtmanzanas.BackColor = Color.White

            End If


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

    Private Sub btnNoModificar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoModificar.MouseEnter
        btnNoModificar.Height = 45
        btnNoModificar.Width = 45

    End Sub

    Private Sub btnNoModificar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoModificar.MouseLeave
        btnNoModificar.Height = 50
        btnNoModificar.Width = 50

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Button2.Enabled = True

        btnNuevo.Visible = False
        btnNoNuevo.Visible = True


        btnGuardar.Visible = True
        btnNoSave.Visible = False
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True
        accion = False
        

    End Sub

    Private Sub btnModificar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.MouseEnter
        btnModificar.Height = 45
        btnModificar.Width = 45

    End Sub

    Private Sub btnModificar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.MouseLeave
        btnModificar.Height = 50
        btnModificar.Width = 50
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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

        Dim resp As Integer

        resp = MsgBox("¿Seguro Desea Eliminar al Productor " & txtNombreP.Text & " ?", MsgBoxStyle.YesNo, "P.A.P.P System")

        If resp = 6 Then


            Dim conexion As New Conexion_Fases
            Dim datos As New dFases

            datos.clave = txtclave.Text

            If conexion.borrar_datos_productor(datos) Then
                If conexion.consultar_todos_productor Then

                    DataGridView1.DataSource = conexion.tabla

                End If

                MessageBox.Show("REGISTRO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                PicBloc.Load(Application.StartupPath & LabelP.Text)

            Else
                MessageBox.Show("REGISTRO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

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
        End If
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

    Private Sub txtNombreP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombreP.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Productores where Nombre like '" & txtNombreP.Text & "%'", con)


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

    Private Sub txtAgencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAgencia.SelectedIndexChanged

        If txtAgencia.Text = "1 - A, S.B." Then

            txtMunicipio.Items.Clear()
            txtMunicipio.Items.Add("Ceguaca")
            txtMunicipio.Items.Add("Concepcion del Sur")
            txtMunicipio.Items.Add("Ilama")
            txtMunicipio.Items.Add("Montaña S.B.")
            txtMunicipio.Items.Add("Gualala")
            txtMunicipio.Items.Add("Nueva Esperanza Intibuca")
            txtMunicipio.Items.Add("San Franisco de Ojuera")
            txtMunicipio.Items.Add("Santa Barbara")
            txtMunicipio.Items.Add("Zacapa")

        End If

        If txtAgencia.Text = "2 - B, S.B." Then

            txtMunicipio.Items.Clear()
            txtMunicipio.Items.Add("Arada")
            txtMunicipio.Items.Add("El Nispero")
            txtMunicipio.Items.Add("La Iguala Lempira")
            txtMunicipio.Items.Add("San Jose Lempira")
            txtMunicipio.Items.Add("San Rafael Lempira")
            txtMunicipio.Items.Add("Santa Rita")
            
        End If

        If txtAgencia.Text = "Colinas" Then

            txtMunicipio.Items.Clear()
            txtMunicipio.Items.Add("Colinas")
            
        End If

        If txtAgencia.Text = "Trinidad" Then

            txtMunicipio.Items.Clear()
            txtMunicipio.Items.Add("Chinda")
            txtMunicipio.Items.Add("Concepcion del Norte")
            txtMunicipio.Items.Add("Petoa")
            txtMunicipio.Items.Add("Trinidad")
            txtMunicipio.Items.Add("San Marcos S.B")

        End If

        If txtAgencia.Text = "San Nicolas" Then

            txtMunicipio.Items.Clear()
            txtMunicipio.Items.Add("Atima")
            txtMunicipio.Items.Add("Nuevo Celilac")
            txtMunicipio.Items.Add("San Nicolas")

        End If

        If txtAgencia.Text = "San Luis" Then

            txtMunicipio.Items.Clear()
            txtMunicipio.Items.Add("San Luis")
      
        End If


        If txtAgencia.Text = "La Union Lempira" Then

            txtMunicipio.Items.Clear()
            txtMunicipio.Items.Add("La Union Lempira")

        End If




    End Sub

    Private Sub txtMunicipio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMunicipio.SelectedIndexChanged
        
    End Sub


    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        btnEliminar.Visible = True
        btnNoEliminar.Visible = False
        btnModificar.Visible = True
        btnNoModificar.Visible = False


        Try

            txtclave.Text = DataGridView1.SelectedCells(0).Value.ToString()
            txtNombreP.Text = DataGridView1.SelectedCells(1).Value.ToString()

            txtIdentidad.Text = DataGridView1.SelectedCells(2).Value.ToString()

            lblfecha.Text = DataGridView1.SelectedCells(3).Value.ToString()
            txtAgencia.Text = DataGridView1.SelectedCells(4).Value.ToString()
            txtMunicipio.Text = DataGridView1.SelectedCells(5).Value.ToString()
            txtMonto.Text = DataGridView1.SelectedCells(6).Value.ToString()
            txtObservacion.Text = DataGridView1.SelectedCells(7).Value.ToString()
            txtfase.Text = DataGridView1.SelectedCells(8).Value.ToString()

            PicBloc.Load(Application.StartupPath & DataGridView1.SelectedCells(9).Value.ToString)

        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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



    Private Sub btnSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir2.Click
        Dim resp As Integer
        resp = MsgBox("¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "P.A.P.P System")
        If resp = 6 Then

            accion = False
            btnSalir.Visible = True
            btnSalir2.Visible = False
            limpiar()
            '         n = 0
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

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        ContextMenuStrip = ContextMenuStrip1

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmanzanas.TextChanged

    End Sub

    Private Sub AgregarPorSolicitudToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarPorSolicitudToolStripMenuItem.Click
        F_ListaSolicitudes.Show()

    End Sub
End Class