Imports System.Data.SqlClient
Imports System.Data


Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows

Public Class F_ControlRecargas

    Public busqueda As Boolean
    Dim ruta As String = ""
    Dim rpt As New ReportDocument
    Public fecha1 As Date : Dim strfecha1 As String
    Public fecha2 As Date : Dim strfecha2 As String
    Dim prmdatos As ParameterField

    Dim seleccion As String


    Dim WithEvents queryconsultas As New dRecargas
    Dim conexion As New DataClasses1DataContext()
    Dim query

    Dim encontrado As Boolean

    Dim resultado As MsgBoxResult

    Private Sub llenarDsReporteKardex(ByVal strruta As String)

        Dim mids As dRptCREATIVOS = New dRptCREATIVOS
        Dim ta As New dRptCREATIVOSTableAdapters.Control_Recargas_TigoTableAdapter


        Try

            ta.FillByCierreT(mids.Control_Recargas_Tigo, (lblCierre.Text))

            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        busqueda = False
        Button2.Enabled = True
        btnGuardar.Enabled = False

        Me.Close()
        F_Menu.Show()



    End Sub

    Private Sub MaskedTextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCelular.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If

        If e.KeyChar = ChrW(Keys.Enter) Then

            Dim numero, tigo As String

            numero = txtCelular.Text

            tigo = numero.Substring(0, 1)

            If tigo = 9 Then

                txtCantidad.Enabled = True
                txtnombre.Enabled = True
                btnGuardar.Enabled = True

            Else

                txtCantidad.Enabled = False
                txtnombre.Enabled = False
                btnGuardar.Enabled = False
                MsgBox("No es un numero de TIGO", MsgBoxStyle.Information, "ERROR")


            End If

        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtCelular.MaskInputRejected

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        Dim efectivo, creditos As Integer
        efectivo = Val(lblEfectivo.Text)

        If busqueda = False Then


            If CheckBox1.Checked = True Then

                Label5.Visible = True
                txtnombre.Visible = True
                Label4.Visible = True
                lblMonto.Visible = True

                CheckBox2.Checked = False
                CheckBox2.Enabled = False

                lblError.Text = 0
                lblDinero.Text = 0
                lblMonto.Text = Val(txtCantidad.Text) + 1


                lblEfectivo.Text = efectivo - Val(lblMonto.Text)

                creditos = Val(lblCreditos.Text)
                lblCreditos.Text = creditos + Val(lblMonto.Text)

                lblObservacion.Visible = True
                lblObservacion.Text = "DEBE"


            End If

            If CheckBox1.Checked = False Then

                Label5.Visible = False
                txtnombre.Visible = False
                Label4.Visible = False
                lblMonto.Visible = False

                CheckBox2.Enabled = True

                lblObservacion.Visible = False
                lblObservacion.Text = "NINGUNA"
                lblError.Text = 0
                lblDinero.Text = Val(txtCantidad.Text) + 1
                lblMonto.Text = 0

                lblEfectivo.Text = efectivo + Val(lblDinero.Text)

                creditos = Val(lblCreditos.Text)
                '      lblCreditos.Text = creditos - Val(lblDinero.Text)

            End If

        End If

        If busqueda = True Then

            If CheckBox1.Checked = False Then


                lblError.Text = 0
                lblDinero.Text = Val(txtCantidad.Text) + 1
                lblMonto.Text = 0
                lblObservacion.Text = "CANCELADO"

                lblEfectivo.Text = efectivo + Val(lblDinero.Text)

                creditos = Val(lblCreditos.Text)
                '      lblCreditos.Text = creditos - Val(lblDinero.Text)

                CheckBox1.Enabled = False
                btnGuardar.Enabled = True

            End If


        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If busqueda = False Then


            If (Val(txtCantidad.Text) >= Val(lblSaldoActual.Text)) Then

                Dim resp As String

                resp = MsgBox("¿Desea ir a compras de recargas?", MsgBoxStyle.YesNo, "Saldo Insuficiente")

                If resp = 6 Then


                    F_Comprar.lblOpcion.Text = 1
                    F_Comprar.Show()

                End If


            Else

                Call queryconsultas.insertar_controlR(1 & txtId.Text, txtnombre.Text, txtCelular.Text, txtCantidad.Text, lblFecha.Text, lblHora.Text, lblCompra.Text, lblSaldoAnterior.Text, lblSaldoActual.Text, lblVendido.Text, lblDinero.Text, lblMonto.Text, lblError.Text, lblObservacion.Text, lblUsuario.Text, lblCierre.Text)

                txtId.Text = queryconsultas.numero_controlR().ToString


                lblSaldoAnterior.Text = lblSaldoActual.Text
                My.Settings.TSaldoAnterior = lblSaldoAnterior.Text
                My.Settings.TSaldoActual = lblSaldoActual.Text
                My.Settings.TVendidos = lblVendido.Text
                My.Settings.TCierre = lblCierre.Text
                My.Settings.TCompra = lblCompra.Text
                My.Settings.TEfectivo = lblEfectivo.Text
                My.Settings.TErrores = lblErrores.Text
                My.Settings.TCreditos = lblCreditos.Text

                My.Settings.Save()
                My.Settings.Reload()

                txtCantidad.Enabled = True

                lblCompra.Text = 0


                limpiar()


            End If

            btnGuardar.Enabled = False
            txtCelular.Focus()
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Checked = False

            lblError.Text = 0
            lblMonto.Text = 0
            lblDinero.Text = 0


            lblSaldoActual.Text = My.Settings.TSaldoActual
            lblSaldoAnterior.Text = My.Settings.TSaldoAnterior
            lblCierre.Text = My.Settings.TCierre
            lblVendido.Text = My.Settings.TVendidos
            lblEfectivo.Text = My.Settings.TEfectivo
            lblErrores.Text = My.Settings.TErrores
            lblCreditos.Text = My.Settings.TCreditos

            Button2.Enabled = True
            txtCelular.Enabled = True
            txtCantidad.Enabled = True
        End If


        If busqueda = True Then

            Call queryconsultas.modificar_controlR(txtId.Text, txtnombre.Text, txtCelular.Text, txtCantidad.Text, lblFecha.Text, lblHora.Text, lblCompra.Text, lblSaldoAnterior.Text, lblSaldoActual.Text, lblVendido.Text, lblDinero.Text, lblMonto.Text, lblError.Text, lblObservacion.Text, lblUsuario.Text, lblCierre.Text)

            txtId.Text = queryconsultas.numero_controlR().ToString


            lblSaldoAnterior.Text = lblSaldoActual.Text
            My.Settings.TSaldoAnterior = lblSaldoAnterior.Text
            My.Settings.TSaldoActual = lblSaldoActual.Text
            My.Settings.TVendidos = lblVendido.Text
            My.Settings.TCierre = lblCierre.Text
            My.Settings.TCompra = lblCompra.Text
            My.Settings.TEfectivo = lblEfectivo.Text
            My.Settings.TErrores = lblErrores.Text
            My.Settings.TCreditos = lblCreditos.Text

            My.Settings.Save()
            My.Settings.Reload()

            txtCantidad.Enabled = True

            lblCompra.Text = 0


            limpiar()


            btnGuardar.Enabled = False
            txtCelular.Focus()
            CheckBox1.Checked = False
            CheckBox2.Checked = False
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False

            Label5.Visible = False
            txtnombre.Visible = False
            Label4.Visible = False
            lblMonto.Visible = False
            lblObservacion.Text = "NINGUNA"


            lblError.Text = 0
            lblMonto.Text = 0
            lblDinero.Text = 0


            lblSaldoActual.Text = My.Settings.TSaldoActual
            lblSaldoAnterior.Text = My.Settings.TSaldoAnterior
            lblCierre.Text = My.Settings.TCierre
            lblVendido.Text = My.Settings.TVendidos
            lblEfectivo.Text = My.Settings.TEfectivo
            lblErrores.Text = My.Settings.TErrores
            lblCreditos.Text = My.Settings.TCreditos

            busqueda = False
            btnGuardar.Enabled = False
            Button2.Enabled = True
            txtCelular.Enabled = True
            lblObservacion.Visible = False


        End If


    End Sub

    Private Sub F_ControlRecargas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        busqueda = False

        lblUsuario.Text = F_Contraseña.txtusuario.Text
        lblFecha.Text = Format(Now(), "dd/MM/yyyy")
        txtId.Text = queryconsultas.numero_controlR().ToString
        '   lblHora.Text = TimeOfDay
        Timer1.Start()

        lblSaldoActual.Text = My.Settings.TSaldoActual
        lblSaldoAnterior.Text = My.Settings.TSaldoAnterior
        lblCierre.Text = My.Settings.TCierre
        lblVendido.Text = My.Settings.TVendidos
        lblEfectivo.Text = My.Settings.TEfectivo
        lblErrores.Text = My.Settings.TErrores
        lblCreditos.Text = My.Settings.TCreditos




    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        F_BuscarCliente.lblopcion.Text = 2
        F_BuscarCliente.Show()


    End Sub

    Private Sub lblFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub limpiar()

        txtnombre.Clear()
        txtCelular.Clear()
        txtCantidad.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False


    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call Calcular_Click(sender, e)
        End If
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If


        If e.KeyChar = ChrW(Keys.Enter) Then

            btnGuardar.Focus()

            CheckBox3.Enabled = True

        End If

    End Sub

    Private Sub txtCantidad_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtCantidad.MaskInputRejected

    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub


    Private Sub ComprarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprarToolStripMenuItem.Click

        F_Comprar.lblOpcion.Text = 1
        F_Comprar.Show()

    End Sub


    Private Sub Calcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calcular.Click



        If (Val(txtCantidad.Text) >= Val(lblSaldoActual.Text)) Then

            Dim resp As String

            resp = MsgBox("¿Desea ir a compras de recargas?", MsgBoxStyle.YesNo, "Saldo Insuficiente")

            If resp = 6 Then


                F_Comprar.lblOpcion.Text = 1
                F_Comprar.Show()

            End If

        Else


            Dim SA, vendido, efectivo As Double

            efectivo = Val(txtCantidad.Text) + 1

            SA = Val(lblSaldoActual.Text)
            vendido = Val(lblVendido.Text)

            lblEfectivo.Text += efectivo
            lblSaldoActual.Text = SA - Val(txtCantidad.Text)
            lblVendido.Text = vendido + Val(txtCantidad.Text)

            lblDinero.Text = Val(txtCantidad.Text) + 1

            txtCantidad.Enabled = False


            btnGuardar.Enabled = True

        End If

        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        Button2.Enabled = False


    End Sub

    Private Sub VendidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendidoToolStripMenuItem.Click

        lblVendido.Text = 0
        My.Settings.TVendidos = 0
        My.Settings.Save()
        My.Settings.Reload()



    End Sub

    Private Sub SaldoAnteriorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldoAnteriorToolStripMenuItem.Click

        lblSaldoAnterior.Text = 0
        My.Settings.TSaldoAnterior = 0
        My.Settings.Save()
        My.Settings.Reload()

        lblSaldoActual.Text = 0
        My.Settings.TSaldoActual = 0
        My.Settings.Save()
        My.Settings.Reload()

    End Sub

    Private Sub SaldoActualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldoActualToolStripMenuItem.Click
        lblEfectivo.Text = 0
        My.Settings.TEfectivo = 0
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub CierreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierreToolStripMenuItem.Click


        Dim resp As String

        resp = MsgBox("¿Desea imprimir informe de Cierre?", MsgBoxStyle.YesNo, "IMPRESION")

        If resp = 6 Then

            ruta = "C:\CrysCierreT.rpt"

            llenarDsReporteKardex(ruta) : R_CierreT.CrystalReportViewer1.ReportSource = rpt : R_CierreT.Show()



        End If

        lblCierre.Text += 1
        My.Settings.TCierre = lblCierre.Text

        lblCreditos.Text = 0
        My.Settings.TCreditos = 0


        lblEfectivo.Text = 0
        My.Settings.TEfectivo = 0


        lblErrores.Text = 0
        My.Settings.TErrores = 0


        lblVendido.Text = 0
        My.Settings.TVendidos = 0
        My.Settings.Save()
        My.Settings.Reload()


    End Sub

    Private Sub CierreToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierreToolStripMenuItem1.Click
        lblCierre.Text = 1
        My.Settings.TCierre = 1
        My.Settings.Save()
        My.Settings.Reload()

    End Sub

    Private Sub ComprasMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasMToolStripMenuItem.Click

        F_Codigo.lblOpcion.Text = 1
        F_Codigo.Show()

    End Sub

    Private Sub lblCierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCierre.Click

    End Sub

    Private Sub lblCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCompra.Click

    End Sub

    Private Sub ToolStripStatusLabel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel6.Click

    End Sub

    Private Sub ToolStripStatusLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel2.Click

    End Sub

    Private Sub ToolStripStatusLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel4.Click

    End Sub

    Private Sub lblSaldoAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSaldoAnterior.Click

    End Sub

    Private Sub ToolStripStatusLabel12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCreditos.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

        Dim efectivo, errores As Integer

        efectivo = Val(lblEfectivo.Text)

        If CheckBox2.Checked = True Then

            CheckBox1.Checked = False
            CheckBox1.Enabled = False

            lblDinero.Text = 0
            lblMonto.Text = 0
            lblError.Text = Val(txtCantidad.Text) + 1

            lblEfectivo.Text = efectivo - Val(lblError.Text)


            errores = Val(lblErrores.Text)
            lblErrores.Text = errores + Val(lblError.Text)



        End If

        If CheckBox2.Checked = False Then

            CheckBox1.Enabled = True

            lblDinero.Text = Val(txtCantidad.Text) + 1
            lblError.Text = 0
            lblMonto.Text = 0

            lblEfectivo.Text = efectivo + Val(lblDinero.Text)

            errores = Val(lblErrores.Text)
            lblErrores.Text = errores - Val(lblDinero.Text)



        End If



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        txtCantidad.Enabled = False
        txtCelular.Enabled = False
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False

        busqueda = True
        F_BuscarCredito.lblCel.Text = lblCel.Text
        F_BuscarCredito.Show()

    End Sub

    Private Sub lblDinero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDinero.Click

    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripSplitButton1.ButtonClick

    End Sub

    Private Sub CreditosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditosToolStripMenuItem.Click
        lblCreditos.Text = 0
        My.Settings.TCreditos = 0
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub ErroresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErroresToolStripMenuItem.Click
        lblErrores.Text = 0
        My.Settings.TErrores = 0
        My.Settings.Save()
        My.Settings.Reload()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        F_Abono.lblOpcion.Text = 1
        F_Abono.Show()

    End Sub

    Private Sub TodoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodoToolStripMenuItem.Click
        lblCreditos.Text = 0
        My.Settings.TCreditos = 0


        lblEfectivo.Text = 0
        My.Settings.TEfectivo = 0


        lblErrores.Text = 0
        My.Settings.TErrores = 0


        lblVendido.Text = 0
        My.Settings.TVendidos = 0
        My.Settings.Save()
        My.Settings.Reload()


    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

        If CheckBox3.Checked = True Then

            Dim saldo, importe As Double

            saldo = Val(lblSaldoActual.Text)

            If txtCantidad.Text = "15" Then

                importe = 0.9
                lblSaldoActual.Text = saldo + importe



            End If

            If txtCantidad.Text = "35" Then

                importe = 2.1
                lblSaldoActual.Text = saldo + importe



            End If

            If txtCantidad.Text = "10" Then

                importe = 0.2
                lblSaldoActual.Text = saldo + importe


            End If

            If txtCantidad.Text = "8" Then

                importe = 0.16
                lblSaldoActual.Text = saldo + importe



            End If

            If txtCantidad.Text = "75" Then

                importe = 7.5
                lblSaldoActual.Text = saldo + importe


            End If

            If txtCantidad.Text = "50" Then

                importe = 3
                lblSaldoActual.Text = saldo + importe


            End If

            If txtCantidad.Text = "25" Then

                importe = 1.5
                lblSaldoActual.Text = saldo + importe



            End If

            If txtCantidad.Text = "85" Then

                importe = 8.5
                lblSaldoActual.Text = saldo + importe



            End If

            If txtCantidad.Text = "40" Then

                importe = 2.4
                lblSaldoActual.Text = saldo + importe


            End If

            If txtCantidad.Text = "30" Then

                importe = 1.8
                lblSaldoActual.Text = saldo + importe



            End If

            If txtCantidad.Text = "18" Then

                importe = 1.08
                lblSaldoActual.Text = saldo + importe


            End If

            If txtCantidad.Text = "13" Then

                importe = 0.26
                lblSaldoActual.Text = saldo + importe



            End If

            If txtCantidad.Text = "20" Then

                importe = 1.2
                lblSaldoActual.Text = saldo + importe



            End If

            If txtCantidad.Text = "55" Then

                importe = 3.3
                lblSaldoActual.Text = saldo + importe



            End If

            If txtCantidad.Text = "12" Then

                importe = 0.24
                lblSaldoActual.Text = saldo + importe


               

            End If


          


        End If

        If CheckBox3.Checked = False Then

            Dim saldo, importe As Double

            saldo = Val(lblSaldoActual.Text)

            If txtCantidad.Text = "15" Then

                importe = 0.9
                lblSaldoActual.Text = saldo - importe


            End If

            If txtCantidad.Text = "35" Then

                importe = 2.1
                lblSaldoActual.Text = saldo - importe


            End If

            If txtCantidad.Text = "10" Then

                importe = 0.2
                lblSaldoActual.Text = saldo - importe



            End If


            If txtCantidad.Text = "8" Then

                importe = 0.16
                lblSaldoActual.Text = saldo - importe


            End If

            If txtCantidad.Text = "75" Then

                importe = 7.5
                lblSaldoActual.Text = saldo - importe



            End If

            If txtCantidad.Text = "50" Then

                importe = 3
                lblSaldoActual.Text = saldo - importe



            End If

            If txtCantidad.Text = "25" Then

                importe = 1.5
                lblSaldoActual.Text = saldo - importe



            End If

            If txtCantidad.Text = "85" Then

                importe = 8.5
                lblSaldoActual.Text = saldo - importe


              

            End If

            If txtCantidad.Text = "40" Then

                importe = 2.4
                lblSaldoActual.Text = saldo - importe



            End If

            If txtCantidad.Text = "30" Then

                importe = 1.8
                lblSaldoActual.Text = saldo - importe



            End If


            If txtCantidad.Text = "18" Then

                importe = 1.08
                lblSaldoActual.Text = saldo - importe



            End If

            If txtCantidad.Text = "13" Then

                importe = 0.26
                lblSaldoActual.Text = saldo - importe


       

            End If

            If txtCantidad.Text = "20" Then

                importe = 1.2
                lblSaldoActual.Text = saldo - importe


            End If

            If txtCantidad.Text = "55" Then

                importe = 3.3
                lblSaldoActual.Text = saldo - importe


            End If

            If txtCantidad.Text = "12" Then

                importe = 0.24
                lblSaldoActual.Text = saldo - importe



            End If





        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblHora.Text = TimeOfDay
    End Sub
End Class