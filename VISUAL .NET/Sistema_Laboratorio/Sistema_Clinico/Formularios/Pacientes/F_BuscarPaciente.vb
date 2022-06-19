Imports System.Data.SqlClient

Public Class F_BuscarPaciente
    Private Sub TxtBuscarPacientes_OnTextChange(sender As Object, e As EventArgs) Handles TxtBuscarPacientes.OnTextChange
        If (TxtBuscarPacientes.text = "Buscar Pacientes" Or TxtBuscarPacientes.text = "") Then

            Dim constr As String

            constr = Conexion.Cadena



            Dim con As New SqlConnection(constr)

            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select Id, Paciente, Identidad, Telefono, Email from Pacientes Where Paciente like'%" & "" & "%'", con)



            Try


                da.Fill(tabla)


                DataGridView1.DataSource = tabla


                Dim fila As Integer
                fila = DataGridView1.RowCount - 1


            Catch ex As Exception
                MsgBox(ex.Message)

            Finally

                con = Nothing

                da = Nothing


                tabla = Nothing


            End Try


        Else
            Dim constr As String

            constr = Conexion.Cadena

            Dim con As New SqlConnection(constr)

            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select Id, Paciente, Identidad, Telefono, Email from Pacientes Where Paciente like'%" & TxtBuscarPacientes.text & "%'", con)


            Try


                da.Fill(tabla)


                DataGridView1.DataSource = tabla


                Dim fila As Integer
                fila = DataGridView1.RowCount - 1



            Catch ex As Exception
                MsgBox(ex.Message)

            Finally

                con = Nothing

                da = Nothing


                tabla = Nothing


            End Try
        End If
    End Sub

    Private Sub TxtBuscarPacientes_Enter(sender As Object, e As EventArgs) Handles TxtBuscarPacientes.Enter
        If (TxtBuscarPacientes.text = "Buscar Pacientes") Then

            TxtBuscarPacientes.text = ""

        End If
    End Sub

    Private Sub TxtBuscarPacientes_Leave(sender As Object, e As EventArgs) Handles TxtBuscarPacientes.Leave
        If (TxtBuscarPacientes.text = "") Then

            TxtBuscarPacientes.text = "Buscar Pacientes"

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick



        'If Me.Text = "Buscar Paciente - Documentos" Then

        '        F_AgregarDocumentos.TxtPaciente.Text = DataGridView1.SelectedCells(1).Value.ToString()

        '    Else


        '        My.Settings.Buscar = DataGridView1.SelectedCells(1).Value.ToString()
        '    My.Settings.Save()
        '    My.Settings.Reload()

        '    F_Receta.TxtPaciente.Text = My.Settings.Buscar

        'End If

        'Me.Close()


    End Sub

    Private Sub F_BuscarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtBuscarPacientes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBuscarPacientes.KeyPress
        ' Matriz de caracteres que deseamos controlar
        '
        Dim caracteres() As Char = {"%"c, "&"c, "$"c, "#"c, "/"c, "-"c, "_"c}

        ' Carácter presionado
        '
        Dim c As Char = e.KeyChar

        ' Comprobamos si la matriz contiene el carácter tecleado.
        '
        If caracteres.Contains(c) Then

            MessageBox.Show("Se ha tecleado un carácter especial.")

            ' Deshechamos el carácter
            e.Handled = True

        End If
    End Sub
End Class