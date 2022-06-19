Imports System.Data.OleDb


Public Class F_Usuarios

    Dim n As Integer = 0
    Public Ruta As String = Application.StartupPath + "/datos.accdb"

    Dim CN As New OleDb.OleDbConnection("PROVIDER=MICROSOFT.ACE.OLEDB.12.0;DATA SOURCE=C:\ARCHIVOS DE PROGRAMA\ARP\IHCAFE SYSTEM\datos.accdb")

    Sub cargar()

        Dim DA As New OleDb.OleDbDataAdapter("Select * from USUARIOS", CN)
        Dim DS As New DataSet

        DA.Fill(DS, "USUARIOS")
        txtnombre.DataSource = DS.Tables("USUARIOS")

        txtnombre.DisplayMember = "NOMBRE"

    End Sub



    Sub buscar()
        Dim CMD As New OleDb.OleDbCommand("Select * from USUARIOS where NOMBRE= '" & txtnombre.Text & "'", CN)
        Dim DR As OleDb.OleDbDataReader

        CN.Open()

        DR = CMD.ExecuteReader

        If DR.Read Then

            txtnombre.Text = DR(0)

            txtusuario.Text = DR(1)
            txtcontraseña.Text = DR(2)
            txtstatus.Text = DR(3)

            If txtstatus.Text = "1" Then

                txtrango.Text = "Administrador"

            End If


            If txtstatus.Text = "2" Then

                txtrango.Text = "Moderador"

            End If


        Else
            MsgBox("ERROR")

        End If

        CN.Close()


    End Sub

    Sub mostrar()

        Dim DA As New OleDb.OleDbDataAdapter("Select * from USUARIOS", CN)
        Dim DS As New DataSet

        DA.Fill(DS, "USUARIOS")
        DataGridView1.DataSource = DS.Tables("USUARIOS")

    End Sub

    Sub nuevo()

        Dim cmd As New OleDb.OleDbCommand("INSERT INTO USUARIOS VALUES('" & txtnombre.Text & "','" & txtusuario.Text & "','" & txtcontraseña.Text & "','" & txtstatus.Text & "')", CN)

        CN.Open()
        cmd.ExecuteNonQuery()
        CN.Close()
        MsgBox("REGISTRO AGREGADO", MsgBoxStyle.Information, "IHCAFE")

    End Sub


    Sub modificar()


        Dim CMD As New OleDb.OleDbCommand("UPDATE USUARIOS SET NOMBRE='" & txtnombre.Text & "',USUARIO='" & txtusuario.Text & "',CONTRASEÑA='" & txtcontraseña.Text & "',ESTATUS='" & txtstatus.Text & "' WHERE NOMBRE='" & txtnombre.Text & "'", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        mostrar()
        MsgBox("REGISTRO ACTUALIZADO")


    End Sub

    Sub eliminar()

        Dim CMD As New OleDb.OleDbCommand("DELETE FROM USUARIOS WHERE NOMBRE= '" & txtnombre.Text & "'", CN)

        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        limpiar()
        mostrar()

        cargar()
        MsgBox("EL REGISTRO A SIDO ELIMINADO")


    End Sub

    Sub limpiar()

        txtnombre.Text = ""
        txtrango.Text = ""
        txtstatus.Text = ""
        txtusuario.Text = ""
        txtcontraseña.Text = ""


    End Sub

    Sub bloquear()

        txtrango.Enabled = False
        txtstatus.Enabled = False
        txtusuario.Enabled = False
        txtcontraseña.Enabled = False

    End Sub

    Sub desbloquear()

        txtrango.Enabled = True
        txtstatus.Enabled = True
        txtusuario.Enabled = True
        txtcontraseña.Enabled = True
    End Sub


    Private Sub txtrango_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtrango.SelectedIndexChanged
        If txtrango.Text = "Administrador" Then

            txtstatus.Text = 1
        End If

        If txtrango.Text = "Moderador" Then

            txtstatus.Text = 2

        End If
    End Sub

    Private Sub F_Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar()
        mostrar()
        bloquear()


    End Sub

    Private Sub txtstatus_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtstatus.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        buscar()

        btnModificar.Visible = True
        btnNoModificar.Visible = False
        btnEliminar.Visible = True
        btnNoEliminar.Visible = False


    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Height = 45
        PictureBox3.Width = 45

    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Height = 50
        PictureBox3.Width = 50
    End Sub

    Private Sub btnNoNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoNuevo.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Nuevo")

    End Sub

    Private Sub btnNoNuevo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoNuevo.MouseEnter
        btnNoNuevo.Height = 45
        btnNoNuevo.Width = 45
    End Sub

    Private Sub btnNoNuevo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoNuevo.MouseLeave
        btnNoNuevo.Height = 50
        btnNoNuevo.Width = 50
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        btnNuevo.Visible = False
        btnNoNuevo.Visible = True
        btnGuardar.Visible = True
        btnNoSave.Visible = False
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True


        limpiar()
        Desbloquear()
        n = 1

    End Sub

    Private Sub btnNuevo_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.MouseEnter
        btnNuevo.Height = 45
        btnNuevo.Width = 45
    End Sub

    Private Sub btnNuevo_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNuevo.MouseLeave
        btnNuevo.Height = 50
        btnNuevo.Width = 50
    End Sub

    Private Sub btnNoSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoSave.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Guardar")

    End Sub

    Private Sub btnNoSave_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoSave.MouseEnter
        btnNoSave.Height = 45
        btnNoSave.Width = 45
    End Sub

    Private Sub btnNoSave_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoSave.MouseLeave
        btnNoSave.Height = 50
        btnNoSave.Width = 50
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        btnNuevo.Visible = True
        btnNoNuevo.Visible = False


        btnGuardar.Visible = False
        btnNoSave.Visible = True
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True


        If n = 1 Then

            nuevo()

        ElseIf n = 2 Then

            modificar()


        End If


        Bloquear()
        cargar()

        limpiar()
        mostrar()

        n = 0

    End Sub

    Private Sub btnGuardar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.MouseEnter
        btnGuardar.Height = 45
        btnGuardar.Width = 45
    End Sub

    Private Sub btnGuardar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.Height = 50
        btnGuardar.Width = 50
    End Sub

    Private Sub btnNoModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoModificar.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Modificar")

    End Sub

    Private Sub btnNoModificar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoModificar.MouseEnter
        btnNoModificar.Width = 45
        btnNoModificar.Height = 45
    End Sub

    Private Sub btnNoModificar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoModificar.MouseLeave
        btnNoModificar.Width = 50
        btnNoModificar.Height = 50
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        btnNuevo.Visible = False
        btnNoNuevo.Visible = True


        btnGuardar.Visible = True
        btnNoSave.Visible = False
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True

        Desbloquear()
        n = 2
    End Sub

    Private Sub btnModificar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.MouseEnter
        btnModificar.Height = 45
        btnModificar.Width = 45
    End Sub

    Private Sub btnModificar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.MouseLeave
        btnModificar.Height = 50
        btnModificar.Width = 50
    End Sub

    Private Sub btnNoEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoEliminar.Click
        MsgBox("No Disponible", MsgBoxStyle.Information, "Boton Eliminar")

    End Sub

    Private Sub btnNoEliminar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoEliminar.MouseEnter
        btnNoEliminar.Height = 45
        btnNoEliminar.Width = 45
    End Sub

    Private Sub btnNoEliminar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNoEliminar.MouseLeave
        btnNoEliminar.Height = 50
        btnNoEliminar.Width = 50
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        eliminar()


        btnNuevo.Visible = True
        btnNoNuevo.Visible = False

        btnGuardar.Visible = False
        btnNoSave.Visible = True
        btnModificar.Visible = False
        btnNoModificar.Visible = True
        btnEliminar.Visible = False
        btnNoEliminar.Visible = True
    End Sub

    Private Sub btnEliminar_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.MouseEnter
        btnEliminar.Height = 45
        btnEliminar.Width = 45
    End Sub

    Private Sub btnEliminar_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEliminar.MouseLeave
        btnEliminar.Height = 50
        btnEliminar.Width = 50
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Me.Hide()

    End Sub

    Private Sub btnSalir_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.MouseEnter
        btnSalir.Height = 45
        btnSalir.Width = 45
    End Sub

    Private Sub btnSalir_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir.MouseLeave
        btnSalir.Height = 50
        btnSalir.Width = 50
    End Sub

    Private Sub txtnombre_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.SelectedIndexChanged

    End Sub
End Class