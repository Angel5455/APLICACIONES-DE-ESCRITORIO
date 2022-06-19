Imports System.Data
Imports System.Data.SqlClient

Public Class F_Opciones

    Dim WithEvents queryconsultas As New Conexion_Ticket

    Dim conexion As New DataClasses1DataContext()
    Dim query
    Private Sub F_Opciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable




        Dim da As New SqlDataAdapter("Select * from Usuarios Where Usuario like'" & lblUsuario.Text & "'", con)


        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            DataGridView1.DataSource = tabla

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing

            tabla = Nothing

        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Try
            txtId.Text = DataGridView1.SelectedCells(0).Value.ToString()
            txtUsuario.Text = DataGridView1.SelectedCells(1).Value.ToString()
            txtContraseña.Text = DataGridView1.SelectedCells(2).Value.ToString()
            txtcargo.Text = DataGridView1.SelectedCells(3).Value.ToString()
            btnModificar.Enabled = True
            txtUsuario.Enabled = True
            txtContraseña.Enabled = True
            txtConfirmar.Enabled = True

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtUsuario_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsuario.DoubleClick

        txtUsuario.Text = InputBox("Ingrese El Nuevo Usuario")


        F_Menu.lblUsuario.Text = txtUsuario.Text
        lblUsuario.Text = txtUsuario.Text

        My.Settings.MyUsuarios = txtUsuario.Text
        My.Settings.Save()
        My.Settings.Reload()
    End Sub


    Private Sub txtContraseña_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContraseña.DoubleClick
        txtContraseña.Text = InputBox("Ingrese la Nueva Contraseña")
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        If txtContraseña.Text = txtConfirmar.Text Then

            Dim resp As String = MsgBox("¿Seguro que desea modificar el registro del usuario?", MsgBoxStyle.YesNo, "CREATIVOS")

            If resp = 6 Then

                Call queryconsultas.modificar_usuario(txtId.Text, txtUsuario.Text, txtContraseña.Text, txtcargo.Text)
                limpiar()

                btnModificar.Enabled = False


                Dim constr As String

                constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

                Dim con As New SqlConnection(constr)
                Dim ds As New DataSet
                Dim tabla As New DataTable




                Dim da As New SqlDataAdapter("Select * from Usuarios Where Usuario like'" & lblUsuario.Text & "'", con)


                Try

                    Dim cmd As New SqlCommand

                    da.Fill(tabla)

                    DataGridView1.DataSource = tabla

                Catch ex As Exception
                    MsgBox(ex.Message)

                Finally

                    con = Nothing
                    ds = Nothing
                    da = Nothing

                    tabla = Nothing

                End Try





            End If







        Else
            MsgBox("Las contraseñas no coinciden")
        End If

    End Sub

    Sub limpiar()
        txtUsuario.Clear()
        txtContraseña.Clear()
        txtConfirmar.Clear()
        txtId.Clear()
    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub
End Class