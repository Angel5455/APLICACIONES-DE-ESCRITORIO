Imports System.Data.SqlClient

Public Class F_CreacionFases

    Sub bloquear()

        txtfase.Enabled = True
        txtfecha.Enabled = False
        txtusuario.Enabled = False

    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        Me.ContextMenuStrip = Me.ContextMenuStrip1
    End Sub

    Private Sub F_CreacionFases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        txtfase.Text = My.Settings.MyFase


        Dim conexion As New Conexion_Configuracion
        Dim tabla As New DataTable

        If conexion.consultar_todos_configuracion Then

            tabla = conexion.tabla
            DataGridView1.DataSource = tabla
        Else
            MessageBox.Show("No se pudo consultar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        Bloquear()


    End Sub

    Private Sub CrearFaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrearFaseToolStripMenuItem.Click


        Dim total As Integer

        total = Val(txtfase.Text) + 1

        txtfase.Text = total


        Dim conexion As New Conexion_Configuracion
        Dim datos As New dConfiguracion


        txtusuario.Text = F_Menu.lblUsuario.Text


        datos.fase = txtfase.Text

        datos.fecha = txtfecha.Text
        datos.Usuario = txtusuario.Text


            If conexion.insertar_datos_configuracion(datos) Then
                If conexion.consultar_todos_configuracion Then

                    DataGridView1.DataSource = conexion.tabla

                End If


            My.Settings.MyFase = txtfase.Text
            My.Settings.Save()
            My.Settings.Reload()


                MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

    End Sub

    
End Class