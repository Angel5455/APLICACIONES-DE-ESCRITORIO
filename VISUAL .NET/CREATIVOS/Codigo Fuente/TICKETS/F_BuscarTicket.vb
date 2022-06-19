Imports System.Data.SqlClient
Imports System.Data


Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows



Public Class F_BuscarTicket

    Dim ruta As String = ""
    Dim rpt As New ReportDocument
    Public nombre As Date : Dim strfecha1 As String
    Public fecha2 As Date : Dim strfecha2 As String
    Dim prmdatos As ParameterField

    Dim seleccion As String

    Private Sub llenarDsReporteTickets(ByVal strruta As String)

        Dim mids As dRptCREATIVOS = New dRptCREATIVOS
        Dim ta As New dRptCREATIVOSTableAdapters.TicketsTableAdapter
        Dim ta2 As New dRptCREATIVOSTableAdapters.DescripcionTableAdapter
        Try



            ta.FillByTicket(mids.Tickets, txtTicket.Text)
            ta2.FillByDescripcion(mids.Descripcion, txtTicket.Text)

            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub F_BuscarTicket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DRptCREATIVOS.Tickets' Puede moverla o quitarla según sea necesario.
        Me.TicketsTableAdapter.Fill(Me.DRptCREATIVOS.Tickets)
        'TODO: esta línea de código carga datos en la tabla 'DRptCREATIVOS.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.DRptCREATIVOS.Empleados)


    End Sub

    Private Sub txtticket_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As New Conexion_Ticket
        Dim datos As New dTickets
        Dim tabla As New DataTable
        Dim mireporte As New Crys_Descripcion

        datos.Ticket = txtTicket.Text


        If conexion.consultar_descripcion(datos) Then

            tabla = conexion.tabla
            mireporte.SetDataSource(tabla)
            R_Tickets.CrystalReportViewer1.ReportSource = mireporte
            R_Tickets.CrystalReportViewer1.RefreshReport()
            R_Tickets.Show()

        End If
      
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable




        Dim da As New SqlDataAdapter("Select * from Descripcion Where Ticket like'" & txtTicket.Text & "%'", con)


        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            DataGridView1.DataSource = tabla

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing

            tabla = Nothing

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class