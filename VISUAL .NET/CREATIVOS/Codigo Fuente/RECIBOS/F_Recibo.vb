Imports System.Data.SqlClient
Imports System.Data


Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows


Public Class F_Recibo

    Dim WithEvents queryconsultas As New dRecibo

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
        Dim ta As New dRptCREATIVOSTableAdapters.RecibosTableAdapter


        Try

            ta.FillByRecibo(mids.Recibos, (lblId.Text))

            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub limpiar()

        lblId.Text = ""
        lblCliente.Text = "___________________________________________"
        lblCantidad.Text = "________"
        lblLetras.Text = "______________________________________________"
        lblAbono.Text = "__________"
        lblAnterior.Text = "__________"
        lblActual.Text = "__________"
        lblConcepto.Text = "_______________________________________________"


    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lblCantidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCantidad.Click
        lblCantidad.Text = InputBox("Ingrese la Cantidad")

        lblCantidad.Text = lblCantidad.Text
        lblAnterior.Text = lblCantidad.Text
        lblAbono.Text = 0
        lblActual.Text = lblCantidad.Text



        'F_Recibo.lbl_num.Text = FormatCurrency(txtCantidad.Text, 2))
        Dim lets As New Numalet
        lets.MascaraSalidaDecimal = "00/100" + " CENTAVOS"
        lets.SeparadorDecimalSalida = " LEMPIRAS CON "
        lets.ApocoparUnoParteEntera = True
        lblLetras.Text = lets.ToCustomCardinal(lblCantidad.Text).ToUpper ' Donde se mostara el valor


    End Sub



    Private Sub lblCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCliente.Click

        lblCliente.Text = InputBox("Ingrese el nombre del Cliente").ToUpper


    End Sub

    Private Sub lblConcepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblConcepto.Click
        lblConcepto.Text = InputBox("Ingrese el Concepto").ToUpper


    End Sub

    Private Sub F_Recibo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblId.Text = queryconsultas.numero_recibo().ToString
        lblUsuario.Text = F_Contraseña.txtusuario.Text



    End Sub

   

    Private Sub lblAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAnterior.Click
        lblAnterior.Text = InputBox("Ingrese Saldo Anterior")

    End Sub

    Private Sub lblAbono_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAbono.Click
        lblAbono.Text = InputBox("Ingrese el Abono")

        lblActual.Text = Val(lblAnterior.Text) - Val(lblAbono.Text)
    End Sub

    Private Sub lblActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblActual.Click
        lblActual.Text = InputBox("Ingrese Saldo Actual")
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If lblEstado.Text = "PENDIENTE" Then

            Call queryconsultas.insertar_pendiente(lblId.Text, lblFecha.Text, lblCantidad.Text, lblCliente.Text, lblLetras.Text, lblConcepto.Text, lblAnterior.Text, lblAbono.Text, lblActual.Text, lblEstado.Text, lblUsuario.Text)
            Call queryconsultas.insertar_recibo(lblId.Text, lblFecha.Text, lblCantidad.Text, lblCliente.Text, lblLetras.Text, lblConcepto.Text, lblAnterior.Text, lblAbono.Text, lblActual.Text, lblEstado.Text, lblUsuario.Text)
            Call queryconsultas.Eliminar_pendientes(lblReciboAnt.Text)

        Else

            Call queryconsultas.insertar_recibo(lblId.Text, lblFecha.Text, lblCantidad.Text, lblCliente.Text, lblLetras.Text, lblConcepto.Text, lblAnterior.Text, lblAbono.Text, lblActual.Text, lblEstado.Text, lblUsuario.Text)


        End If


        If lblEstado.Text = "CANCELADO" Then
            Call queryconsultas.Eliminar_pendientes(lblReciboAnt.Text)

        End If

        Dim resp As String

        resp = MsgBox("¿Desea imprimir Recibo?", MsgBoxStyle.YesNo, "IMPRESION")

        If resp = 6 Then

            ruta = "C:\CrysRecibo.rpt"

            llenarDsReporteKardex(ruta) : R_Recibo.CrystalReportViewer1.ReportSource = rpt : R_Recibo.Show()
        End If

        limpiar()


        lblId.Text = queryconsultas.numero_recibo().ToString


    End Sub

    Private Sub EditarCantidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarCantidadToolStripMenuItem.Click
        lblCantidad.Text = InputBox("Ingrese la Cantidad")

        lblCantidad.Text = lblCantidad.Text
        lblAnterior.Text = lblCantidad.Text
        lblAbono.Text = 0
        lblActual.Text = lblCantidad.Text



        'F_Recibo.lbl_num.Text = FormatCurrency(txtCantidad.Text, 2))
        Dim lets As New Numalet
        lets.MascaraSalidaDecimal = "00/100" + " CENTAVOS"
        lets.SeparadorDecimalSalida = " LEMPIRAS CON "
        lets.ApocoparUnoParteEntera = True
        lblLetras.Text = lets.ToCustomCardinal(lblCantidad.Text).ToUpper ' Donde se mostara el valor


    End Sub

    Private Sub EditarClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarClienteToolStripMenuItem.Click

        lblCliente.Text = InputBox("Ingrese el nombre del Cliente").ToUpper

    End Sub

    Private Sub EditarConceptoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarConceptoToolStripMenuItem.Click
        lblConcepto.Text = InputBox("Ingrese el Concepto").ToUpper
    End Sub

    Private Sub EditarSaldoAnteriorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarSaldoAnteriorToolStripMenuItem.Click
        lblAnterior.Text = InputBox("Ingrese Saldo Anterior")
    End Sub

    Private Sub EditarAbonoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarAbonoToolStripMenuItem.Click
        lblAbono.Text = InputBox("Ingrese el Abono")

        lblActual.Text = Val(lblAnterior.Text) - Val(lblAbono.Text)
    End Sub

    Private Sub EditarSaldoActualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarSaldoActualToolStripMenuItem.Click
        lblActual.Text = InputBox("Ingrese Saldo Actual")
    End Sub

    Private Sub lblLetras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLetras.Click

    End Sub
End Class