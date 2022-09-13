Public Class FormularioRPTciudad

    Private Sub FormularioRPTciudad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.SelectionFormula = "{contactos.ciudad} ='" & SelectCiudad.ciudad.Text & "'"
    End Sub
End Class