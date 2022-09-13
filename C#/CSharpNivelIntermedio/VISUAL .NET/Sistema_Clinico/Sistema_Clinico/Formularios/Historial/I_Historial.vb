Public Class I_Historial
    Private Sub I_Historial_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim conexion As New CConexion
        Dim Dataset As New DataSet

        Dim paciente = My.Settings.MyPaciente

        Dataset = conexion.Consultar("SELECT * FROM HISTORIAL WHERE Paciente='" & paciente & "'")

        LblPaciente.Text = Dataset.Tables(0).Rows(0).Item("Paciente")
        LblMotivo.Text = Dataset.Tables(0).Rows(0).Item("Motivo_Consulta")

        Timer1.Start()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PrintForm1.Print()
        Timer1.Stop()

    End Sub
End Class