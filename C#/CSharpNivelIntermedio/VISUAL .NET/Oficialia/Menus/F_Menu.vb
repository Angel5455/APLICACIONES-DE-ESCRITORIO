Public Class F_Menu


    Dim resultado As MsgBoxResult

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click


        F_Solicitud.Show()

        Me.Close()



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        resultado = CType(MessageBox.Show("¿Desea Salir de la Aplicacion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation), MsgBoxResult)


        If resultado = MsgBoxResult.No Then



        Else

            End

        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        F_Modificar.Show()
        Me.Close()
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        F_Busquedas.Show()
        Me.Close()

    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        F_MenuListados.Show()
        Me.Close()
    End Sub

    Private Sub btnBase_Click(sender As Object, e As EventArgs) Handles btnBase.Click
        F_BD.Show()
        Me.Close()
    End Sub

    Private Sub F_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class