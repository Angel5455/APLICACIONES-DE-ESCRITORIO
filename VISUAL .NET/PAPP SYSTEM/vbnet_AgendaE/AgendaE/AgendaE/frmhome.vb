Imports System.Data.OleDb


Public Class frmhome

    Public Ruta As String = Application.StartupPath + "/AgendaDB.mdb"
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            Dim Mov As New OleDbConnection()
            Mov.ConnectionString = ("PROVIDER=Microsoft.jet.OLEDB.4.0;Data Source=" & Ruta)
            Dim Consulta As String = "Select * From Cliente"
            Dim objAdap As New OleDbDataAdapter(Consulta, Mov)
            Dim Guardar As String = "insert into Contactos ( Nombre, Telefono, Celular, mes, Dia, Direccion, Ciudad ) values ('" & nombre.Text & "','" & telefono.Text & "','" & Celular.Text & "','" & mes.Text & "'," & dia.Value.ToString() & ",'" & direccion.Text & "','" & ciudad.Text & "')"
            Dim comando As New OleDbCommand(Guardar, Mov)
            comando.CommandType = CommandType.Text
            Mov.Open()
            comando.ExecuteNonQuery()
            MessageBox.Show("Los Datos fueron guardados con exito", "Datos Guardados...")
            Mov.Close()
            limpiar()
            cargarCiudades()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try


    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Try
            Dim Consulta As String
            If RadioButton1.Checked Then
                Consulta = " Select * from contactos where mes = '" & Mes1.Text & "'"

            Else
                Consulta = " Select * from contactos where id = " & Val(txtbuscar.Text) & " or Nombre like '%" & txtbuscar.Text & "%'"

            End If
            Dim Mov As New OleDbConnection()
            Mov.ConnectionString = ("PROVIDER=Microsoft.jet.OLEDB.4.0;Data Source=" & Ruta)
            Dim ObjDataSet As New DataSet()
            Dim M As New DataTable()
            'Consulta
            Dim objAdap As New OleDbDataAdapter(Consulta, Mov)
            Mov.Open()
            objAdap.Fill(M)
            Me.dataGridView1.DataSource = M
            Mov.Close()
            limpiar()
            cargarCiudades()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim Mov As New OleDbConnection()
            Mov.ConnectionString = ("PROVIDER=Microsoft.jet.OLEDB.4.0;Data Source=" & Ruta)
            Mov.Open()
            Dim Eliminar As String = "Delete From contactos where id =" & codigo.Text
            Dim comando As New OleDbCommand(Eliminar, Mov)
            comando.CommandType = CommandType.Text
            comando.ExecuteNonQuery()
            MessageBox.Show("Los Datos fueron Eliminados con exito", "Datos Eliminados...")
            Mov.Close()
            limpiar()
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try


    End Sub

    Private Sub dataGridView1_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dataGridView1.CellMouseDoubleClick
        codigo.Text = dataGridView1.SelectedCells(0).Value.ToString()
        nombre.Text = dataGridView1.SelectedCells(1).Value.ToString()
        telefono.Text = dataGridView1.SelectedCells(2).Value.ToString()
        Celular.Text = dataGridView1.SelectedCells(3).Value.ToString()
        mes.Text = dataGridView1.SelectedCells(4).Value.ToString()
        dia.Value = Val(dataGridView1.SelectedCells(5).Value.ToString())
        direccion.Text = dataGridView1.SelectedCells(6).Value.ToString()
        ciudad.Text = dataGridView1.SelectedCells(7).Value.ToString()
        tabControl1.SelectedIndex = 0
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Public Sub limpiar()
        nombre.Clear()
        codigo.Clear()
        telefono.Clear()
        Celular.Clear()
        mes.Text = ""
        dia.Value = 1
        direccion.Clear()
        ciudad.Text = ""
    End Sub
    Private Sub groupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles groupBox5.Enter

    End Sub

    Private Sub frmhome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarCiudades()
    End Sub
    Public Sub cargarCiudades()
        Try
            ciudad.Items.Clear()
            Dim conexion As New OleDbConnection()
            conexion.ConnectionString = "PROVIDER=Microsoft.jet.OLEDB.4.0;Data Source=" & Ruta
            Dim comando As New OleDbCommand()
            comando.CommandText = "SELECT  Ciudad FROM contactos"
            comando.Connection = conexion
            conexion.Open()
            Dim dr As OleDbDataReader = comando.ExecuteReader()
            If dr.HasRows Then
                While dr.Read()
                    ciudad.Items.Add(dr("Ciudad").ToString())

                End While
            End If
            dr.Close()
        Catch RED As Exception
            MessageBox.Show(RED.Message.ToString())
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ReportemesForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SelectCiudad.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FomularioRPTtodo.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FormularioRPTtelefonico.ShowDialog()
    End Sub
End Class


'Proyecto Realizado Por Red de la Cruz Polanco
'Email: Revolucion.77804@Gmail.com