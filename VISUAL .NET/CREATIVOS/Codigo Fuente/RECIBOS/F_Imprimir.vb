Imports System.Data.SqlClient
Imports System.Data


Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows

Public Class F_Imprimir
    Dim WithEvents queryconsultas As New dRecibo

    Dim conexion As New DataClasses1DataContext()
    Dim query

    Dim encontrado As Boolean

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
    Private Sub F_Imprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim resp As String

        resp = MsgBox("¿Desea imprimir Recibo?", MsgBoxStyle.YesNo, "IMPRESION")

        If resp = 6 Then

            ruta = "C:\CrysRecibo.rpt"

            llenarDsReporteKardex(ruta) : R_Recibo.CrystalReportViewer1.ReportSource = rpt : R_Recibo.Show()
            Me.Close()

        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class