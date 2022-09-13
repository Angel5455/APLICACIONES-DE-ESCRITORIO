Imports System.Data.SqlClient
Imports System.Data


Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows



Public Class F_ListadosFecha

    Dim ruta As String = ""
    Dim rpt As New ReportDocument
    Public fecha1 As Date : Dim strfecha1 As String
    Public fecha2 As Date : Dim strfecha2 As String
    Dim prmdatos As ParameterField

    Dim seleccion As String

    Dim WithEvents queryconsultas As New dSolicitud


    Private Sub llenarDsReporteKardex(ByVal strruta As String)

        Dim mids As OFICIALIADataSet = New OFICIALIADataSet
        Dim ta As New OFICIALIADataSetTableAdapters.SolicitudesTableAdapter

        Try

            ta.FillByFecha(mids.Solicitudes, (txtfecha1.Text), (txtfecha2.Text))

            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub F_ListadosFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DataGrid()

        Dim fila As Integer
        fila = DataGridView1.RowCount

        lblExpediente.Text = fila

    End Sub


    Sub datagrid()

        Dim conexion As New SqlConnection(My.Settings.OFICIALIAConnectionString)
        Dim ssql As String = "Select * from Solicitudes where Fecha_Solicitud>='" & txtfecha1.Text & "' and Fecha_Solicitud<= '" & txtfecha2.Text & "'"

        Try

            conexion.Open()
            Dim comandosql As New SqlCommand(ssql, conexion)
            Dim adapatador As New SqlDataAdapter(comandosql)
            Dim datatable As New DataTable

            adapatador.Fill(datatable)
            DataGridView1.DataSource = datatable


        Catch ex As Exception

        End Try


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ruta = "C:\Crys_General.rpt"

        llenarDsReporteKardex(ruta) : R_General.CrystalReportViewer1.ReportSource = rpt : R_General.Show()

    End Sub

    Private Sub txtfecha1_ValueChanged(sender As Object, e As EventArgs) Handles txtfecha1.ValueChanged
        txtfecha1.MinDate = New DateTime(2013, 1, 1)
        txtfecha1.MaxDate = DateTime.Today

        txtfecha1.Format = DateTimePickerFormat.Custom

    End Sub

    Private Sub txtfecha2_ValueChanged(sender As Object, e As EventArgs) Handles txtfecha2.ValueChanged
        txtfecha2.MinDate = New DateTime(2013, 1, 1)
        txtfecha2.MaxDate = DateTime.Today

        txtfecha2.Format = DateTimePickerFormat.Custom

    End Sub
End Class