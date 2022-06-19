Imports System.Data.SqlClient
Imports System.Data


Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows



Public Class F_Cotizaciones

    Dim WithEvents queryconsultas As New dCotizaciones

    Dim conexion As New DataClasses1DataContext()
    Dim query


    
    Dim encontrado As Boolean
    Public entrada As Integer

    Dim resultado As MsgBoxResult

    Public busqueda As Boolean
    Dim ruta As String = ""
    Dim rpt As New ReportDocument
    Public fecha1 As Date : Dim strfecha1 As String
    Public fecha2 As Date : Dim strfecha2 As String
    Dim prmdatos As ParameterField

    Dim seleccion As String


    Private Sub llenarDsReporteKardex(ByVal strruta As String)

        Dim mids As dRptCREATIVOS = New dRptCREATIVOS
        Dim ta As New dRptCREATIVOSTableAdapters.CotizacionesTableAdapter


        Try

            ta.FillByCotizacion(mids.Cotizaciones, (lblcotizacion.Text))

            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If


    End Sub



    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
        '  e.Handled = txtNumerico(txtCantidad, e.KeyChar, True)
    End Sub

    Public Function txtNumerico(ByVal txtControl As TextBox, ByVal caracter As Char, ByVal decimales As Boolean) As Boolean
        If (Char.IsNumber(caracter, 0) = True) Or caracter = Convert.ToChar(8) Or caracter = "." Then
            If caracter = "." Then
                If decimales = True Then
                    If txtControl.Text.IndexOf(".") <> -1 Then Return True
                Else : Return True
                End If
            End If
            Return False
        Else
            Return True
        End If
    End Function

   

    Private Sub txtTotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If


        '   e.Handled = txtNumerico(txtTotal, e.KeyChar, True)

    End Sub

    Private Sub txtTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        For i As Integer = 0 To dgv_Factura.Rows.Count - 2
            Me.DetalleTableAdapter.InsertDetalle(lblcotizacion.Text, (dgv_Factura.Rows(i).Cells(0).Value), CDec(dgv_Factura.Rows(i).Cells(1).Value), CInt(dgv_Factura.Rows(i).Cells(2).Value), CDec(dgv_Factura.Rows(i).Cells(3).Value))
        Next

        Call queryconsultas.insertar_cotizacion(lblcotizacion.Text, lblfecha.Text, txtNombre.Text, txtTotal.Text)



        Dim resp As String

        resp = MsgBox("¿Desea imprimir Cotizacion?", MsgBoxStyle.YesNo, "IMPRESION")

        If resp = 6 Then

            Dim conexion As New Conexion_Cotizaciones
            Dim datos As New dCotizaciones
            Dim tabla As New DataTable
            Dim mireporte As New Crys_Cotizaciones

            datos.Cotizacion = lblcotizacion.Text
            datos.nombre = txtNombre.Text

            If conexion.consultar_cotizacion(datos) Then

                tabla = conexion.tabla
                mireporte.SetDataSource(tabla)
                R_Cotizaciones.CrystalReportViewer1.ReportSource = mireporte
                R_Cotizaciones.CrystalReportViewer1.RefreshReport()
                R_Cotizaciones.Show()

            End If
        End If

        dgv_Factura.DataSource = Nothing
        lblcotizacion.Text = queryconsultas.numero_cotizacion().ToString
        limpiar()


    End Sub

    Private Sub F_Cotizaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        lblcotizacion.Text = queryconsultas.numero_cotizacion().ToString
    End Sub

    Sub limpiar()
        
        txtTotal.Clear()
        txtNombre.Clear()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub dgv_Factura_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub dgv_Factura_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

       
    End Sub

    Private Sub txtTotal_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTotal.KeyPress
        e.Handled = txtNumerico(txtTotal, e.KeyChar, True)
    End Sub

    Private Sub txtTotal_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub dgv_Factura_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Factura.CellContentClick

    End Sub

    Private Sub dgv_Factura_CellEndEdit1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Factura.CellEndEdit

        Try

            Dim total As Decimal

            For i As Integer = 0 To dgv_Factura.RowCount - 1
                ' dgv_Factura.Item(0, dgv_Factura.CurrentRow.Index).Value = lblcotizacion.Text
                dgv_Factura.Item(3, i).Value = dgv_Factura.Item(1, i).Value * dgv_Factura.Item(2, i).Value
                total = total + dgv_Factura.Item(3, i).Value
            Next i

            txtTotal.Text = total



        Catch ex As Exception

        End Try

      
    End Sub
End Class