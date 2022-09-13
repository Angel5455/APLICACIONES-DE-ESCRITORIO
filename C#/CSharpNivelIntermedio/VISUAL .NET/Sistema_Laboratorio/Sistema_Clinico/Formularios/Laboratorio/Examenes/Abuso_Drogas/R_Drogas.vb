Public Class R_Drogas

    Public IdPaciente As String

    Private Sub R_Drogas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim objReporte As New CrysDrogas()
        objReporte.SetParameterValue("@IdPaciente", IdPaciente)
        CrystalReportViewer1.ReportSource = objReporte




    End Sub
End Class