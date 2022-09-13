
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows


Public Class F_Tickets

    Dim WithEvents queryconsultas As New dTickets

    Dim conexion As New DataClasses1DataContext()
    Public entrada As Integer

    Public TICKET As Boolean
    Dim encontrado As Boolean


    Dim resultado As MsgBoxResult

    Public busqueda As Boolean
    Dim ruta As String = ""
    Dim rpt As New ReportDocument
    Public fecha1 As Date : Dim strfecha1 As String
    Public fecha2 As Date : Dim strfecha2 As String
    Dim prmdatos As ParameterField

    Private Sub llenarDsReporteKardex(ByVal strruta As String)

        Dim mids As dRptCREATIVOS = New dRptCREATIVOS
        Dim ta As New dRptCREATIVOSTableAdapters.TicketsTableAdapter


        Try

            ta.FillByTicket(mids.Tickets, Val(lblticket.Text))

            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If txtnombre.Text <> "" Then



            Dim conexion As New Conexion_Ticket
            Dim datos As New dTickets

            datos.Ticket = lblticket.Text
            datos.nombre = txtnombre.Text
            datos.fecha = lblfecha.Text
            datos.total = txtTotal.Text
            datos.mes = lblMes.Text
            datos.hora = lblHora.Text

            If conexion.insertar_datos_tickets(datos) Then
                If conexion.consultar_todos_tickets Then
                    ' DataGridView1.DataSource = conexion.tabla

                End If
                My.Settings.MyTicket = lblticket.Text
                My.Settings.Save()
                My.Settings.Reload()

                ' MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)



                Dim resp As String


                resp = MsgBox("¿Desea Imprimir la Factura?", MsgBoxStyle.YesNo, "CREATIVOS")


                If resp = 6 Then

                    Dim conexion2 As New Conexion_Ticket
                    Dim datos2 As New dTickets
                    Dim tabla As New DataTable
                    Dim mireporte As New Crys_Tickets

                    datos.Ticket = lblticket.Text

                    If conexion2.consultar_ticket(datos) Then

                        tabla = conexion2.tabla
                        mireporte.SetDataSource(tabla)
                        R_Tickets.CrystalReportViewer1.ReportSource = mireporte
                        R_Tickets.CrystalReportViewer1.RefreshReport()

                        limpiar()

                        dgv_Factura.DataSource = Nothing


                        txtcodigo.Enabled = True

                        R_Tickets.Show()


                    End If

                End If


            Else

                MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If


            lblticket.Text = My.Settings.MyTicket + 1


            txtnombre.Text = ""
            dgv_Factura.DataSource = Nothing
            txtTotal.Text = 0



        Else

            If txtnombre.Text = "" Then


                txtnombre.BackColor = Color.Gray

                MsgBox("Ingrese el nombre del Cliente", MsgBoxStyle.Information, "CREATIVOS")

            Else

                txtnombre.BackColor = Color.White

            End If



        End If



    End Sub



    Private Sub AñadirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirToolStripMenuItem.Click

        F_Descripcion.limpiar()
        F_Descripcion.lblTicket.Text = lblticket.Text
        F_Descripcion.txtcodigo.Focus()
        F_Descripcion.Show()


    End Sub


    Sub limpiar()

        txtnombre.Text = ""
        txtTotal.Text = ""

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click

        F_Eliminar.lblTicket.Text = lblticket.Text

        F_Eliminar.Show()

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click


        If txtnombre.Text <> "" Then



            Dim conexion As New Conexion_Ticket
            Dim datos As New dTickets

            datos.Ticket = lblticket.Text
            datos.nombre = txtnombre.Text
            datos.fecha = lblfecha.Text
            datos.total = txtTotal.Text
            datos.mes = lblMes.Text
            datos.hora = lblHora.Text

            If conexion.insertar_datos_tickets(datos) Then
                If conexion.consultar_todos_tickets Then
                    ' DataGridView1.DataSource = conexion.tabla

                End If
                My.Settings.MyTicket = lblticket.Text
                My.Settings.Save()
                My.Settings.Reload()

                ' MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)



                Dim resp As String


                resp = MsgBox("¿Desea Imprimir la Factura?", MsgBoxStyle.YesNo, "CREATIVOS")


                If resp = 6 Then

                    Dim conexion2 As New Conexion_Ticket
                    Dim datos2 As New dTickets
                    Dim tabla As New DataTable
                    Dim mireporte As New Crys_Tickets

                    datos.Ticket = lblticket.Text

                    If conexion2.consultar_ticket(datos) Then

                        tabla = conexion2.tabla
                        mireporte.SetDataSource(tabla)
                        R_Tickets.CrystalReportViewer1.ReportSource = mireporte
                        R_Tickets.CrystalReportViewer1.RefreshReport()

                        limpiar()
                        txtcodigo.Clear()


                        dgv_Factura.DataSource = Nothing


                        R_Tickets.Show()


                    End If

                End If


            Else

                MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If


            lblticket.Text = My.Settings.MyTicket + 1


        Else

            If txtnombre.Text = "" Then


                txtnombre.BackColor = Color.Gray

                MsgBox("Ingrese el nombre del Cliente", MsgBoxStyle.Information, "CREATIVOS")

            Else

                txtnombre.BackColor = Color.White

            End If

        End If

    End Sub

    Private Sub F_Tickets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CREATIVOSDataSet.Descripcion' Puede moverla o quitarla según sea necesario.
        Me.DescripcionTableAdapter.Fill(Me.CREATIVOSDataSet.Descripcion)
        'TODO: esta línea de código carga datos en la tabla 'CREATIVOSDataSet.Inventario' Puede moverla o quitarla según sea necesario.
        '    Me.InventarioTableAdapter.Fill(Me.CREATIVOSDataSet.Inventario)


        Timer1.Start()


        Dim mes As Integer

        lblfecha.Text = Format(Now(), "dd/MM/yyyy")

        Dim cadena As String = Me.lblfecha.Text

        mes = cadena.Substring(3, 2) 'Para obtener los dos primeros

        lblMes.Text = mes


        If mes = "1" Then
            lblMes.Text = "Enero"
        End If

        If mes = "2" Then
            lblMes.Text = "Febrero"
        End If

        If mes = "3" Then
            lblMes.Text = "Marzo"
        End If

        If mes = "4" Then
            lblMes.Text = "Abril"
        End If

        If mes = "5" Then
            lblMes.Text = "Mayo"
        End If

        If mes = "6" Then
            lblMes.Text = "Junio"
        End If

        If mes = "7" Then
            lblMes.Text = "Julio"
        End If

        If mes = "8" Then
            lblMes.Text = "Agosto"
        End If

        If mes = "9" Then
            lblMes.Text = "Septiembre"
        End If

        If mes = "10" Then
            lblMes.Text = "Octubre"
        End If

        If mes = "11" Then
            lblMes.Text = "Noviembre"
        End If

        If mes = "12" Then
            lblMes.Text = "Diciembre"
        End If




        lblticket.Text = queryconsultas.numero_ticket().ToString



        Dim conexion As New Conexion_Ticket
        Dim tabla As New DataTable

        ' If conexion.consultar_todos_tickets Then
        '  tabla = conexion.tabla
        '  DataGridView1.DataSource = tabla
        ' Else
        '  MessageBox.Show("No se pudo consultar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        '  End If

        'bloquear()


        Dim total As Double

        Try
            For i As Integer = 0 To dgv_Factura.RowCount - 1
                total = total + CDbl(dgv_Factura.Item("Subtotal".ToLower, i).Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        txtTotal.Text = total

        'bloquear()

    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If

    End Sub

    Private Sub txtCodigo_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)


    End Sub

    Private Sub txtCodigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
      
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lblHora.Text = TimeOfDay

    End Sub

    Private Sub btnmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub txtcodigo_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtcodigo_MaskInputRejected_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtcodigo.MaskInputRejected

    End Sub

    Private Sub txtcodigo_Validating1(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtcodigo.Validating
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("select * from Empleados where Codigo ='" & txtcodigo.Text & "'", con)

        '   Dim xConsulta As New SqlDataAdapter("select * from Inventario where Codigo = '" & txtcodigo.Text & "'", conexion.Inventario)
        '  Dim ds As New DataSet
        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then

            '   txtDescripcion.BackColor = Color.White

            encontrado = True

            txtnombre.Text = ds.Tables(0).Rows(0).Item("Nombre").ToString
         


        Else

            encontrado = False

            If txtcodigo.Text = "000" Then
                txtnombre.Text = F_Menu.lblUsuario.Text
            Else
                '   MsgBox("No se encuentra los datos del Empleado, no se puede llenar la ficha", MsgBoxStyle.Critical, "Error")
                txtcodigo.Text = ""
                txtnombre.Text = ""



            End If

           

        End If



    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub dgv_Factura_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Factura.CellClick
        If (dgv_Factura.CurrentCell.ColumnIndex = 0) Then
            TICKET = True
            F_BuscarI.Show()


        End If

       

    End Sub


    Private Sub dgv_Factura_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Factura.CellEndEdit
        Try

       
        If dgv_Factura.CurrentCell.ColumnIndex = 1 Then
            dgv_Factura.Item(2, dgv_Factura.CurrentRow.Index).Value = Me.InventarioTableAdapter.Select_Descripcion(dgv_Factura.CurrentRow.Cells(0).Value)
            dgv_Factura.Item(4, dgv_Factura.CurrentRow.Index).Value = Me.InventarioTableAdapter.Buscar_Precio(dgv_Factura.CurrentRow.Cells(0).Value)
            dgv_Factura.Item(3, dgv_Factura.CurrentRow.Index).Value = 1
            dgv_Factura.Item(5, dgv_Factura.CurrentRow.Index).Value = CInt(Me.InventarioTableAdapter.Buscar_Precio(dgv_Factura.CurrentRow.Cells(0).Value)) * CInt(dgv_Factura.Item(3, dgv_Factura.CurrentRow.Index).Value)

            Dim total As Double = 0
            For i As Integer = 0 To dgv_Factura.RowCount - 1

                total = total + CDbl(dgv_Factura.Item(5, i).Value)

            Next

            txtTotal.Text = total


        End If



        ' Pone el precio de acuerdo a la cantidad escogida
        If dgv_Factura.CurrentCell.ColumnIndex = 3 Then
            dgv_Factura.Item(5, dgv_Factura.CurrentRow.Index).Value = CInt(Me.InventarioTableAdapter.Buscar_Precio(dgv_Factura.CurrentRow.Cells(0).Value)) * CInt(dgv_Factura.Item(3, dgv_Factura.CurrentRow.Index).Value)

            Dim total As Double = 0
            For i As Integer = 0 To dgv_Factura.RowCount - 1

                total = total + CDbl(dgv_Factura.Item(5, i).Value)

            Next

            txtTotal.Text = total
        End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.dgv_Factura.Rows.RemoveAt(Me.dgv_Factura.CurrentRow.Index)

        Dim total As Double = 0
        For i As Integer = 0 To dgv_Factura.RowCount - 1

            total = total + CDbl(dgv_Factura.Item(5, i).Value)

        Next

        txtTotal.Text = total
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

          If txtnombre.Text <> "" Then
            For i As Integer = 0 To dgv_Factura.Rows.Count - 2

                Me.DescripcionTableAdapter.Insert1(lblticket.Text, lblfecha.Text, txtnombre.Text, txtTotal.Text, (dgv_Factura.Rows(i).Cells(2).Value), CInt(dgv_Factura.Rows(i).Cells(3).Value), CInt(dgv_Factura.Rows(i).Cells(4).Value), CInt(dgv_Factura.Rows(i).Cells(5).Value), lblHora.Text, lblMes.Text)
                ' MsgBox(dgv_Factura.Rows(i).Cells(0).Value & " detalle factura guardado")
                lblticket.Text = queryconsultas.numero_ticket().ToString

            Next

            Call queryconsultas.insertar_ticket(lblticket.Text, lblfecha.Text, txtnombre.Text, txtTotal.Text, lblMes.Text, lblHora.Text)


            Dim resp As String

            resp = MsgBox("¿Desea imprimir el Ticket?", MsgBoxStyle.YesNo, "IMPRESION")

            If resp = 6 Then

                Dim conexion As New Conexion_Ticket
                Dim datos As New dTickets
                Dim tabla As New DataTable
                Dim mireporte As New Crys_Descripcion



                datos.Ticket = lblticket.Text
                '  datos.nombre = txtnombre.Text

                If conexion.consultar_descripcion(datos) Then

                    tabla = conexion.tabla
                    mireporte.SetDataSource(tabla)
                    R_Tickets.CrystalReportViewer1.ReportSource = mireporte
                    R_Tickets.CrystalReportViewer1.RefreshReport()
                    R_Tickets.Show()



                End If
            End If
            lblticket.Text = queryconsultas.numero_ticket().ToString
            Me.dgv_Factura.DataSource = Nothing


            txtcodigo.Text = ""
            txtnombre.Clear()
            txtTotal.Clear()


        Else

            MsgBox("Campo Nombre en blanco", MsgBoxStyle.Information, "CREATIVOS")
        End If

        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        F_BuscarI.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim ireport As New ReportDocument()
        Dim iConnectionInfo As ConnectionInfo = New ConnectionInfo()


        ' *****************************************************************************************************************
        ' configuro el acceso a la base de datos
        ' *****************************************************************************************************************

    End Sub


    Private Sub dgv_Factura_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Factura.CellContentClick

    End Sub
End Class