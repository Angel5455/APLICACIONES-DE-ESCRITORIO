Imports System.Data.SqlClient


Public Class F_Usuarios


    Private dt As DataTable
    Private da As SqlDataAdapter
    Dim fila As Integer

    Dim accion As Boolean

    Sub limpiar()

        txtNombre.Text = ""
        txtcargo.Text = ""
        txtusuario.Text = ""
        txtcontraseña.Text = ""
        txtcorreo.Text = ""

    End Sub

    Sub bloquear()

        txtNombre.Enabled = False
        txtcargo.Enabled = False
        txtusuario.Enabled = False
        txtcontraseña.Enabled = False
        Button1.Enabled = False
        txtcorreo.Enabled = False

    End Sub

    Sub desbloquear()

        txtNombre.Enabled = True
        txtcargo.Enabled = True
        txtusuario.Enabled = True
        txtcontraseña.Enabled = True
        Button1.Enabled = True
        txtcorreo.Enabled = True

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



        ' PicBloc.Load(Application.StartupPath & lblFoto.Text)


        Dim total As Integer

        total = Val(lblid.Text) + 1

        lblid.Text = total



        btnNuevo.Visible = False
        btnNoNuevo.Visible = True
        btnGuardar.Visible = True
        btnNoGuardar.Visible = False
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True
        accion = True

        limpiar()
        desbloquear()
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

        If txtNombre.Text <> "" And txtusuario.Text <> "" And txtcontraseña.Text <> "" And txtcargo.Text <> "" And txtcorreo.Text <> "" Then



            Dim conexion As New Conexion_Usuarios
            Dim datos As New cDatos

            datos.id = lblid.Text
            datos.nombre = txtNombre.Text
            datos.Usuario = txtusuario.Text
            datos.Contraseña = txtcontraseña.Text
            datos.Cargo = txtcargo.Text
            datos.foto = lblFoto.Text
            datos.correo = txtcorreo.Text

            If accion = True Then
                If conexion.insertar_datos(datos) Then
                    If conexion.consultar_todos Then

                        DataGridView1.DataSource = conexion.tabla

                    End If

                    MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    My.Settings.MyUsuario = lblid.Text
                    My.Settings.Save()
                    My.Settings.Reload()


                Else

                    MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If


            If accion = False Then
                If conexion.actualizar_datos(datos) Then
                    If conexion.consultar_todos Then
                        DataGridView1.DataSource = conexion.tabla
                    End If

                    MessageBox.Show("REGISTRO ACTUALIZADO", "ACTUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("REGISTRO NO ACTUALIZADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If

            btnNuevo.Visible = True
            btnNoNuevo.Visible = False


            btnGuardar.Visible = False
            btnNoGuardar.Visible = True
            btnModificar.Visible = False
            btnNoModificar.Visible = True
            btnEliminar.Visible = False
            btnNoEliminar.Visible = True

            bloquear()

            limpiar()


        Else

            MsgBox("No se permiten campos en blanco", MsgBoxStyle.Exclamation, "P.A.P.P System")

            If txtNombre.Text = "" Then

                txtNombre.BackColor = Color.OrangeRed
            Else

                txtNombre.BackColor = Color.White

            End If

            If txtusuario.Text = "" Then

                txtusuario.BackColor = Color.OrangeRed
            Else

                txtusuario.BackColor = Color.White

            End If

            If txtcontraseña.Text = "" Then

                txtcontraseña.BackColor = Color.OrangeRed
            Else

                txtcontraseña.BackColor = Color.White

            End If

            If txtcargo.Text = "" Then

                txtcargo.BackColor = Color.OrangeRed
            Else

                txtcargo.BackColor = Color.White

            End If


            If txtcorreo.Text = "" Then

                txtcorreo.BackColor = Color.OrangeRed
            Else

                txtcorreo.BackColor = Color.White

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
        accion = False
        desbloquear()

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

        Dim resp As Integer

        resp = MsgBox("¿Seguro Desea Eliminar al Usuario " & txtusuario.Text & " ?", MsgBoxStyle.YesNo, "P.A.P.P System")

        If resp = 6 Then

            Dim conexion As New Conexion_Usuarios
            Dim datos As New cDatos

            datos.id = lblid.Text

            If conexion.borrar_datos(datos) Then
                If conexion.consultar_todos Then

                    DataGridView1.DataSource = conexion.tabla

                End If

                MessageBox.Show("REGISTRO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Else
                MessageBox.Show("REGISTRO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

            btnNuevo.Visible = True
            btnNoNuevo.Visible = False
            btnGuardar.Visible = False
            btnNoGuardar.Visible = True
            btnModificar.Visible = False
            btnNoModificar.Visible = True
            btnEliminar.Visible = False
            btnNoEliminar.Visible = True

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

  

    Private Sub F_Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LoginDataSet.Usuarios' Puede moverla o quitarla según sea necesario.


        lblfecha.Text = Format(Now(), "dd/MM/yyyy")

        lblFoto.Text = "\imagenes\Logo.png"

        lblid.Text = My.Settings.MyUsuario

        lblUsuario.Text = F_Menu.lblUsuario.Text

        Dim conexion As New Conexion_Usuarios
        Dim tabla As New DataTable

        If conexion.consultar_todos Then
            tabla = conexion.tabla
            DataGridView1.DataSource = tabla
        Else
            MessageBox.Show("No se pudo consultar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        bloquear()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Try

            lblid.Text = DataGridView1.SelectedCells(0).Value.ToString()
            txtNombre.Text = DataGridView1.SelectedCells(1).Value.ToString()

            txtusuario.Text = DataGridView1.SelectedCells(2).Value.ToString()
            txtcontraseña.Text = DataGridView1.SelectedCells(3).Value.ToString()

            txtcargo.Text = DataGridView1.SelectedCells(4).Value.ToString()
            txtcorreo.Text = DataGridView1.SelectedCells(5).Value.ToString()

            '  PicBloc.Load(Application.StartupPath & DataGridView1.SelectedCells(6).Value.ToString)

            btnEliminar.Visible = True
            btnNoEliminar.Visible = False
            btnModificar.Visible = True
            btnNoModificar.Visible = False


        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

            lblFoto.Text = nombreimagenarchivo

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

    Private Sub txtusuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub btnSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir2.Click

        Dim resp As Integer
        resp = MsgBox("¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "P.A.P.P System")
        If resp = 6 Then


            btnSalir.Visible = True
            btnSalir2.Visible = False

            bloquear()

            lblFoto.Text = "\imagenes\Logo.png"

            limpiar()

            'PicBloc.Load(Application.StartupPath & lblFoto.Text)

            btnNuevo.Visible = True
            btnNoNuevo.Visible = False
            btnGuardar.Visible = False
            btnNoGuardar.Visible = True
            btnModificar.Visible = False
            btnNoModificar.Visible = True
            btnEliminar.Visible = False
            btnNoEliminar.Visible = True
            Me.Close()
          
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

    End Sub

    Private Sub btnSalir_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSalir.MouseMove
        btnSalir.Visible = False
        btnSalir2.Visible = True
    End Sub

    Private Sub btnSalir2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir2.MouseLeave

        btnSalir.Visible = True
        btnSalir2.Visible = False
    End Sub
End Class