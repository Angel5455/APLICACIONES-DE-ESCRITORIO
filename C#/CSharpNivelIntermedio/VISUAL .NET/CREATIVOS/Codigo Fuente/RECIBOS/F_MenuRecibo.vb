Public Class F_MenuRecibo

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        F_BuscarPendientes.opc = False

        F_Anombre.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        F_BuscarPendientes.opc = True
        F_BuscarPendientes.Show()
        Me.Close()

    End Sub
End Class