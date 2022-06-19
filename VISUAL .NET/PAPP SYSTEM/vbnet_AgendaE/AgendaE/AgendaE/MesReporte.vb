Public Class MesReporte

    Private Sub MesReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.SelectionFormula = "{Contactos.mes}='" & ReportemesForm.mes.Text & "'"
    End Sub
End Class