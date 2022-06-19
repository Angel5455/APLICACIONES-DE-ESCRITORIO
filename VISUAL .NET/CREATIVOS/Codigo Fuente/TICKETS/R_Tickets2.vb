Imports System.Data.SqlClient

Public Class R_Tickets2

    Dim cn As New SqlConnection("Server=LocalHost;Uid=sa;Password=root;Database=CREATIVOS ")
    Dim informe1 As CrystalReport1
    Dim MITABLA As CrystalDecisions.CrystalReports.Engine.Table
    Dim MILOGIN As CrystalDecisions.Shared.TableLogOnInfo

    Private Sub R_Tickets2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            informe1 = New CrystalReport1
            For Each Me.MITABLA In informe1.Database.Tables
                MILOGIN = MITABLA.LogOnInfo
                MILOGIN.ConnectionInfo.Password = "root"
                MILOGIN.ConnectionInfo.UserID = "sa"
                MITABLA.ApplyLogOnInfo(MILOGIN)
            Next
            Me.CrystalReportViewer1.ReportSource = informe1
            '      informe1.RecordSelectionFormula = "{CAB_DOCUMENTO.TIP_DOC}='" + tipoDocu + "' And + "" And {DETALLE_DOCUMENTO.NDOC}""+ codDocu"""



        Catch ex As Exception

        End Try
    End Sub
End Class