Imports System.Data
Imports System.Data.OleDb
Public Class F_Password

    Private veces As Integer = 0
    Private Const NumeroIntentos As Integer = 3

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If Me.PasswordTextBox.Text <> "" And Me.UsernameTextBox.Text <> "" Then
            Dim cn As New OleDbConnection(sConexion)
            Dim estatus As Integer
            ' Permitir varios intentos
            veces = veces + 1
            'Comenzamos una transacción
            Try
                cn.Open()
                ' evitamos la inyección de código reemplazando las comillas simples
                ' por otro carácter
                Dim sql As String = "Select estatus From usuarios Where " & _
                " password = '" & Trim(Replace(Me.PasswordTextBox.Text, "'", "k")) & _
                "' And usuario = '" & Trim(Replace(Me.UsernameTextBox.Text, "'", "k")) & "'"

                'creamos un comando
                Dim cmd As New OleDbCommand(sql, cn)
                'leemos el valor y lo convertimos a entero
                estatus = CInt(cmd.ExecuteScalar().ToString)
            Catch ex As Exception
                'mostramos el error
                If Err.Number = 91 Then
                    MessageBox.Show("No se encontro registro ")
                Else
                    MessageBox.Show("error " & Err.Number.ToString & vbCrLf & ex.Message)
                End If
            Finally
                'cerramos la conexion solo si esta abierta
                If (cn.State And ConnectionState.Open) <> 0 Then
                    cn.Close()
                End If
            End Try


            If estatus = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                If veces < NumeroIntentos Then
                    Label1.Text = "Quedan " & (NumeroIntentos - veces) & " intentos"
                    If (cn.State And ConnectionState.Open) <> 0 Then
                        cn.Close()
                    End If
                    Exit Sub
                End If
                Me.DialogResult = Windows.Forms.DialogResult.No
            End If
            Hide()
        Else
            MessageBox.Show("Ingresa tus datos completos", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ' todavía puedes hacerlo de esta forma
            'MsgBox("Ingresa tus datos completos.", MsgBoxStyle.Exclamation, "Faltan datos")
        End If
    End Sub
End Class