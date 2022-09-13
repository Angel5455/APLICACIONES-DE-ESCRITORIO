Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data


Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows

Public Class F_Empleados

    Dim encontrado As Boolean
    Dim xSQL As New Conexion_Empleados
    Public accion As Boolean
    Dim resultado As MsgBoxResult


    Dim ruta As String = ""
    Dim rpt As New ReportDocument
    Public fecha1 As Date : Dim strfecha1 As String
    Public fecha2 As Date : Dim strfecha2 As String
    Dim prmdatos As ParameterField

    Dim seleccion As String



    Sub limpiar()

        '   txtcodigo.Text = My.Settings.MyCodigo + 1
        txtnombre.Text = ""
        txtcodigo.Text = ""
    End Sub



   



    Private Sub F_Empleados_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        btnGuardar.Enabled = True
        btnEliminar.Enabled = False

    End Sub

    Private Sub F_Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        btnGuardar.Enabled = False
        btnEliminar.Enabled = False
        btnModificar.Enabled = False

        txtnombre.Focus()
        bloquear()
     
    End Sub



    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

 
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        btnGuardar.Enabled = True
        btnEliminar.Enabled = False

        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim conexion As New Conexion_Empleados
        Dim datos As New dEmpleados

        datos.nombre = txtnombre.Text
        datos.codigo = txtcodigo.Text

        If accion = True Then

            If conexion.insertar_datos_Empleados(datos) Then
                If conexion.consultar_todos_Empleados Then
                    ' DataGridView1.DataSource = conexion.tabla

                End If

                MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

                '      My.Settings.MyCodigo = txtcodigo.Text
                '      My.Settings.Save()
                '     My.Settings.Reload()


                limpiar()
                bloquear()

            End If

        Else


            If accion = False Then

                If conexion.actualizar_datos_empleados(datos) Then
                    If conexion.consultar_todos_Empleados Then

                    End If


                    MessageBox.Show("REGISTRO ACTUALIZADO", "ACTUALIZAR", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    limpiar()
                    bloquear()

                Else
                    MessageBox.Show("REGISTRO NO ACTUALIZADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            End If
        End If



        btnEliminar.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = False
        btnNuevo.Enabled = True

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        accion = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True
        desbloquear()

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click

        accion = True

        ' txtcodigo.Text = My.Settings.MyCodigo + 1

        desbloquear()

        limpiar()


        txtcodigo.Focus()


        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False


    End Sub

    Sub bloquear()

        txtnombre.Enabled = False
        txtcodigo.Enabled = False


    End Sub

    Sub desbloquear()

        txtnombre.Enabled = True
        txtcodigo.Enabled = True

    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub



    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtContraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtContraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtcodigo_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtcodigo.MaskInputRejected

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click



        Dim conexion As New Conexion_Empleados
        Dim datos As New dEmpleados

        datos.nombre = txtnombre.Text

        If conexion.borrar_datos_empleados(datos) Then
            If conexion.consultar_todos_Empleados Then

            End If

            MessageBox.Show("PRODUCTO ELIMINADO", "ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Else
            MessageBox.Show("PRODUCTO NO ELIMINADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        limpiar()



    End Sub

    Private Sub txtcodigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcodigo.TextChanged
        Label1.Text = txtcodigo.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ruta = "C:\Debug\CrysEmpleados.rpt"

        llenarDsReporteKardex(ruta) : R_Empleados.CrystalReportViewer1.ReportSource = rpt : R_Empleados.Show()

    End Sub

    Private Sub llenarDsReporteKardex(ByVal strruta As String)

        Dim mids As dRptCREATIVOS = New dRptCREATIVOS
        Dim ta As New dRptCREATIVOSTableAdapters.EmpleadosTableAdapter

        Try



            ta.FillByCodigo(mids.Empleados, txtcodigo.Text)

            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        F_BuscarE.Show()
    End Sub
End Class