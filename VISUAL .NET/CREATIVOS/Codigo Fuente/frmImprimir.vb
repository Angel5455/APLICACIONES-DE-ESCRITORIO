Imports System.Data.SqlClient
Public Class frmImprimir

    Dim Cn As New SqlConnection("Server=LocalHost;Uid=sa;Password=123;Database=SISTEMA")
    Dim INFORME1 As Reporte
    Dim MITABLA As CrystalDecisions.CrystalReports.Engine.Table
    Dim MILOGIN As CrystalDecisions.Shared.TableLogOnInfo



    Private Sub frmImprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            INFORME1 = New Reporte
            For Each Me.MITABLA In INFORME1.Database.Tables
                MILOGIN = MITABLA.LogOnInfo
                MILOGIN.ConnectionInfo.Password = "root"
                MILOGIN.ConnectionInfo.UserID = "sa"
                MITABLA.ApplyLogOnInfo(MILOGIN)
            Next
            Me.CrystalReportViewer1.ReportSource = INFORME1
            INFORME1.RecordSelectionFormula = "{CAB_DOCUMENTO.NDOC}='" + Factura.txtCodigoDocu.Text + "' And {DETALLE_DOCUMENTO.NDOC}='" + Factura.txtCodigoDocu.Text + "'"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class