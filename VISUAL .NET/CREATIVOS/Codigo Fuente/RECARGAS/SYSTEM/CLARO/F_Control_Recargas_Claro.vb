Imports System.Data.SqlClient
Imports System.Data


Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows


Public Class F_Control_Recargas_Claro

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
        Dim ta As New dRptCREATIVOSTableAdapters.Control_Recargas_ClaroTableAdapter


        Try

            ta.FillByCierre(mids.Control_Recargas_Claro, (lblCierre.Text))

            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


 
    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Close()
        F_Menu.Show()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        F_BuscarCliente.lblopcion.Text = 3
        F_BuscarCliente.Show()

    End Sub

    Private Sub F_Control_Recargas_Claro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        busqueda = False

        lblUsuario.Text = F_Contraseña.txtusuario.Text
        lblFecha.Text = Format(Now(), "dd/MM/yyyy")
        txtId.Text = queryconsultas.numero_controlRC().ToString
        ' lblHora.Text = TimeOfDay
        Timer1.Start()

        lblSaldoActual.Text = My.Settings.CSaldoActual
        lblSaldoAnterior.Text = My.Settings.CSaldoAnterior
        lblCierre.Text = My.Settings.CCierre
        lblVendido.Text = My.Settings.CVendidos
        lblEfectivo.Text = My.Settings.CEfectivo
        lblErrores.Text = My.Settings.CErrores
        lblCreditos.Text = My.Settings.CCreditos



    End Sub

    Private Sub txtCelular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCelular.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
        If e.KeyChar = ChrW(Keys.Enter) Then

            Dim numero, claro As String

            numero = txtCelular.Text

            claro = numero.Substring(0, 1)

            If claro = 3 Or claro = 8 Then

                txtCantidad.Enabled = True
                txtnombre.Enabled = True
                btnGuardar.Enabled = True

            Else

                txtCantidad.Enabled = False
                txtnombre.Enabled = False
                btnGuardar.Enabled = False
                MsgBox("No es un numero de CLARO", MsgBoxStyle.Information, "ERROR")


            End If
        End If



    End Sub

    Private Sub txtCelular_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtCelular.MaskInputRejected
     
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


            Dim SA, vendido, efectivo As Integer

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
                '  lblCreditos.Text = creditos - Val(lblDinero.Text)

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
                '   lblCreditos.Text = creditos - Val(lblDinero.Text)

                CheckBox1.Enabled = False
                btnGuardar.Enabled = True

            End If


        End If
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

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call Calcular_Click(sender, e)
        End If
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If


        If e.KeyChar = ChrW(Keys.Enter) Then

            btnGuardar.Focus()

        End If
    End Sub

    Private Sub txtCantidad_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtCantidad.MaskInputRejected

    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

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

                Call queryconsultas.insertar_controlRC(2 & txtId.Text, txtnombre.Text, txtCelular.Text, txtCantidad.Text, lblFecha.Text, lblHora.Text, lblCompra.Text, lblSaldoAnterior.Text, lblSaldoActual.Text, lblVendido.Text, lblDinero.Text, lblMonto.Text, lblError.Text, lblObservacion.Text, lblUsuario.Text, lblCierre.Text)

                txtId.Text = queryconsultas.numero_controlRC().ToString


                lblSaldoAnterior.Text = lblSaldoActual.Text
                My.Settings.CSaldoAnterior = lblSaldoAnterior.Text
                My.Settings.CSaldoActual = lblSaldoActual.Text
                My.Settings.CVendidos = lblVendido.Text
                My.Settings.CCierre = lblCierre.Text
                My.Settings.CCompra = lblCompra.Text
                My.Settings.CEfectivo = lblEfectivo.Text
                My.Settings.CErrores = lblErrores.Text
                My.Settings.CCreditos = lblCreditos.Text

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

            lblError.Text = 0
            lblMonto.Text = 0
            lblDinero.Text = 0


            lblSaldoActual.Text = My.Settings.CSaldoActual
            lblSaldoAnterior.Text = My.Settings.CSaldoAnterior
            lblCierre.Text = My.Settings.CCierre
            lblVendido.Text = My.Settings.CVendidos
            lblEfectivo.Text = My.Settings.CEfectivo
            lblErrores.Text = My.Settings.CErrores
            lblCreditos.Text = My.Settings.CCreditos

            Button2.Enabled = True
            txtCelular.Enabled = True
            txtCantidad.Enabled = True
        End If


        If busqueda = True Then

            Call queryconsultas.modificar_controlRC(txtId.Text, txtnombre.Text, txtCelular.Text, txtCantidad.Text, lblFecha.Text, lblHora.Text, lblCompra.Text, lblSaldoAnterior.Text, lblSaldoActual.Text, lblVendido.Text, lblDinero.Text, lblMonto.Text, lblError.Text, lblObservacion.Text, lblUsuario.Text, lblCierre.Text)

            txtId.Text = queryconsultas.numero_controlRC().ToString


            lblSaldoAnterior.Text = lblSaldoActual.Text
            My.Settings.CSaldoAnterior = lblSaldoAnterior.Text
            My.Settings.CSaldoActual = lblSaldoActual.Text
            My.Settings.CVendidos = lblVendido.Text
            My.Settings.CCierre = lblCierre.Text
            My.Settings.CCompra = lblCompra.Text
            My.Settings.CEfectivo = lblEfectivo.Text
            My.Settings.CErrores = lblErrores.Text
            My.Settings.CCreditos = lblCreditos.Text

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

            Label5.Visible = False
            txtnombre.Visible = False
            Label4.Visible = False
            lblMonto.Visible = False
            lblObservacion.Text = "NINGUNA"


            lblError.Text = 0
            lblMonto.Text = 0
            lblDinero.Text = 0


            lblSaldoActual.Text = My.Settings.CSaldoActual
            lblSaldoAnterior.Text = My.Settings.CSaldoAnterior
            lblCierre.Text = My.Settings.CCierre
            lblVendido.Text = My.Settings.CVendidos
            lblEfectivo.Text = My.Settings.CEfectivo
            lblErrores.Text = My.Settings.CErrores
            lblCreditos.Text = My.Settings.CCreditos

            busqueda = False
            btnGuardar.Enabled = False
            Button2.Enabled = True
            txtCelular.Enabled = True
            lblObservacion.Visible = False


        End If
    End Sub

    Sub limpiar()

        txtnombre.Clear()
        txtCelular.Clear()
        txtCantidad.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False


    End Sub

    Private Sub ComprarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprarToolStripMenuItem.Click
        F_Comprar.lblOpcion.Text = 2
        F_Comprar.Show()
    End Sub

    Private Sub CierreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierreToolStripMenuItem.Click

        Dim resp As String

        resp = MsgBox("¿Desea imprimir informe de Cierre?", MsgBoxStyle.YesNo, "IMPRESION")

        If resp = 6 Then

            ruta = "C:\CrysCierreC.rpt"

            llenarDsReporteKardex(ruta) : R_CierreC.CrystalReportViewer1.ReportSource = rpt : R_CierreC.Show()



        End If

        lblCierre.Text += 1
        My.Settings.CCierre = lblCierre.Text

        lblCreditos.Text = 0
        My.Settings.CCreditos = 0


        lblEfectivo.Text = 0
        My.Settings.CEfectivo = 0


        lblErrores.Text = 0
        My.Settings.CErrores = 0


        lblVendido.Text = 0
        My.Settings.CVendidos = 0

        My.Settings.Save()
        My.Settings.Reload()

    End Sub

    Private Sub CierreToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CierreToolStripMenuItem1.Click
        lblCierre.Text = 1
        My.Settings.CCierre = 1
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub CreditosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditosToolStripMenuItem.Click
        lblCreditos.Text = 0
        My.Settings.CCreditos = 0
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub SaldoAnteriorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldoAnteriorToolStripMenuItem.Click

        lblSaldoAnterior.Text = 0
        My.Settings.CSaldoAnterior = 0
        My.Settings.Save()
        My.Settings.Reload()

        lblSaldoActual.Text = 0
        My.Settings.CSaldoActual = 0
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub SaldoActualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaldoActualToolStripMenuItem.Click
        lblEfectivo.Text = 0
        My.Settings.CEfectivo = 0
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub ErroresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ErroresToolStripMenuItem.Click
        lblErrores.Text = 0
        My.Settings.CErrores = 0
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub VendidoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendidoToolStripMenuItem.Click

        lblVendido.Text = 0
        My.Settings.CVendidos = 0
        My.Settings.Save()
        My.Settings.Reload()

    End Sub

    Private Sub ComprasMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasMToolStripMenuItem.Click
        F_Codigo.lblOpcion.Text = 2
        F_Codigo.Show()

    End Sub

    Private Sub TodoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodoToolStripMenuItem.Click


        lblCreditos.Text = 0
        My.Settings.CCreditos = 0


        lblEfectivo.Text = 0
        My.Settings.CEfectivo = 0


        lblErrores.Text = 0
        My.Settings.CErrores = 0


        lblVendido.Text = 0
        My.Settings.CVendidos = 0
        My.Settings.Save()
        My.Settings.Reload()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        F_Abono.lblOpcion.Text = 2
        F_Abono.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblHora.Text = TimeOfDay
    End Sub
End Class