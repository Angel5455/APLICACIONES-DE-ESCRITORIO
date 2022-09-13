Public Class F_AgregarApuntes

    Public AppID As Integer = 0
    Dim WithEvents Queryconsultas As New DCalendario
    Dim ConexionLINQ As New DataClasses1DataContext()
    Private Sub F_AgregarApuntes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDelete.Visible = AppID <> 0
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MsgBox("El nombre del Paciente es requerido.")
            Return
        End If

        If IsConfirm("Quieres guardar el registro?") Then

            If AppID = 0 Then
                Call Queryconsultas.Insertar_Cita(dtpDate.Value, txtName.Text, txtAddress.Text, txtComment.Text)
                MessageBox.Show("Los Datos fueron agregados con exito", "Datos Guardados...")
                Me.Close()

            Else
                Call Queryconsultas.Editar_Cita(AppID, dtpDate.Value, txtName.Text, txtAddress.Text, txtComment.Text)
                MessageBox.Show("Los Datos fueron modificados con exito", "Datos Guardados...")
                Limpiar()
                Me.Close()

            End If
        End If
    End Sub

    Sub Limpiar()
        txtComment.Clear()
        txtAddress.Clear()
        txtName.Clear()

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If IsConfirm("Seguro que quiere Eliminar el Registro ?") Then
            Queryconsultas.Eliminar(AppID)
            MessageBox.Show("Los Datos fueron eliminados con exito", "Datos Eliminados...")
            Limpiar()
            Me.Close()

        End If
    End Sub
End Class