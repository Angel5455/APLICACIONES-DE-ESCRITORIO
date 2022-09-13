Public Class F_BD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        F_Menu.Show()
        Me.Close()
    End Sub

    Private Sub F_BD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'OFICIALIADataSet.Solicitudes' Puede moverla o quitarla según sea necesario.
        Me.SolicitudesTableAdapter.Fill(Me.OFICIALIADataSet.Solicitudes)

    End Sub
End Class