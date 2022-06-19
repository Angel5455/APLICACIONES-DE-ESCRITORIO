Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Office.Interop

Public Class F_Etiquetas

    Private Sub F_Etiquetas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblUsuario.Text = F_Menu.lblUsuario.Text
        lblfecha.Text = Format(Now(), "dd/MM/yyyy")
        Me.ContextMenuStrip = ContextMenuStrip1
        BorrarRegistroToolStripMenuItem.Enabled = False
    End Sub

    Private Sub AñadirRegistroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirRegistroToolStripMenuItem.Click
        F_Lista_Etiquetas.Show()
    End Sub

    Private Sub BorrarRegistroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarRegistroToolStripMenuItem.Click

        Dim resp As String


        resp = MsgBox("Desea eliminar el Registro del Insumo", MsgBoxStyle.YesNo, "P.A.P.P System")


        If resp = 6 Then

            F_Lista_Etiquetas.eliminar()

            MsgBox("REGISTRO ELIMINADO", MsgBoxStyle.Exclamation, "P.A.P.P SYSTEM")

        End If

        AñadirRegistroToolStripMenuItem.Enabled = True

    End Sub



    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim conexion2 As New Conexion_Productos
        Dim datos2 As New dProductos
        Dim tabla As New DataTable
        Dim mireporte As New Crys_Etiquetas

        datos2.codigoE = F_Lista_Etiquetas.txtCodigo.Text

        If conexion2.consultar_etiqueta(datos2) Then

            tabla = conexion2.tabla
            mireporte.SetDataSource(tabla)
            R_Etiqueta.CrystalReportViewer1.ReportSource = mireporte
            R_Etiqueta.CrystalReportViewer1.RefreshReport()
            R_Etiqueta.Show()
        End If




    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir2.Click

        btnSalir.Visible = True
        btnSalir2.Visible = False

        BorrarRegistroToolStripMenuItem.Enabled = False

        F_Lista_Etiquetas.eliminar()

        AñadirRegistroToolStripMenuItem.Enabled = True

        Me.Hide()
    End Sub

    Private Sub btnSalir2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir2.MouseLeave

        btnSalir.Visible = True
        btnSalir2.Visible = False

    End Sub

    Private Sub btnSalir_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSalir.MouseMove

        btnSalir.Visible = False
        btnSalir2.Visible = True

    End Sub
End Class