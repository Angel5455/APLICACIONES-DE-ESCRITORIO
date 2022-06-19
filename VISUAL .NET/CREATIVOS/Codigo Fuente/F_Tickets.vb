
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class F_Tickets


    Dim WithEvents queryconsultas As New Conexion_Ticket


    Dim encontrado As Boolean
    Dim xSQL As New Conexion_Empleados
    Dim accion As Boolean
    Dim resultado As MsgBoxResult

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click


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

                        DataGridView1.DataSource = Nothing




                        R_Tickets.Show()


                    End If

                End If


            Else

                MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If


            lblticket.Text = My.Settings.MyTicket + 1


            txtnombre.Text = ""
            txtcodigo.Text = ""
            DataGridView1.DataSource = Nothing
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


        F_Descripcion.txtcodigo.Focus()
        F_Descripcion.limpiar()
        F_Descripcion.lblTicket.Text = lblticket.Text
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

                        DataGridView1.DataSource = Nothing


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


        Timer1.Start()


        Dim mes As Integer

        lblfecha.Text = Format(Now(), "MM/dd/yyyy")

        Dim cadena As String = Me.lblfecha.Text

        mes = cadena.Substring(0, 2) 'Para obtener los dos primeros



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




        lblticket.Text = queryconsultas.numero().ToString



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
            For i As Integer = 0 To DataGridView1.RowCount - 1
                total = total + CDbl(DataGridView1.Item("Subtotal".ToLower, i).Value)
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

    Private Sub btnmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenu.Click
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
        Dim xConsulta As New SqlDataAdapter("select * from Empleados where Codigo = '" & txtcodigo.Text & "'", Conexion.conexion)
        Dim ds As New DataSet
        xConsulta.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then

            txtnombre.BackColor = Color.White

            encontrado = True

            txtnombre.Text = ds.Tables(0).Rows(0).Item("Nombre").ToString


        Else

            encontrado = False

           

            MsgBox("Ningun dato de Empleado registrado", MsgBoxStyle.Critical, "Error")
            txtnombre.Text = ""
            txtcodigo.Text = ""

        End If
    End Sub
End Class