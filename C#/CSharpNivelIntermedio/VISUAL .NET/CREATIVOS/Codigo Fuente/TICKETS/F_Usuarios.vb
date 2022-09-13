


Public Class F_Usuarios

    Dim WithEvents queryconsultas As New Conexion_Ticket

    Dim conexion As New DataClasses1DataContext()
    Public entrada As Integer

    

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub txtContraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContraseña.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtContraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContraseña.TextChanged

    End Sub

    Private Sub txtConfirmar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConfirmar.KeyPress


        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub


    Private Sub txtConfirmar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConfirmar.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If txtContraseña.Text = txtConfirmar.Text Then
            Call queryconsultas.insertar_usuarios(lblid.Text, txtUsuario.Text, txtContraseña.Text, txtcargo.Text)
            lblid.Text = queryconsultas.numero_usuarios().ToString
            limpiar()
        Else
            MsgBox("Las contraseñas no coinciden")


        End If

        
    End Sub

    Sub limpiar()
        txtUsuario.Clear()
        txtContraseña.Clear()
        txtConfirmar.Clear()
        txtcargo.Text = ""
    End Sub


    Private Sub F_Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblid.Text = queryconsultas.numero_usuarios().ToString

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcargo.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcargo.SelectedIndexChanged

    End Sub
End Class