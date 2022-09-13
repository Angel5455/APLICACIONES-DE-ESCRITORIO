Public Class F_MenuListados

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        F_Menu.Show()
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        R_General.Show()
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        F_ListadosFecha.Show()
    End Sub
End Class