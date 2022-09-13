Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class F_Inventario

    Dim WithEvents queryconsultas As New dInventario

    Dim conexion As New DataClasses1DataContext()

    Dim encontrado As Boolean

    Public accion As Boolean
    Dim resultado As MsgBoxResult

    Private Sub F_Inventario_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click

    End Sub


    
    Private Sub F_Inventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        txtcodigo.Text = My.Settings.MyInventario + 1


        txtDescripcion.Text = ""
        txtprecio.Text = ""


        


    End Sub





   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

      

    End Sub


    Sub limpiar()


        txtcodigo.Text = My.Settings.MyInventario + 1


        txtdescripcion.text = ""
        txtprecio.Text = ""


    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        btnGuardar.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True

    End Sub



    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        F_BuscarI.Show()

    End Sub

    Private Sub txtcodigo_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcodigo.Enter




    End Sub

    Private Sub txtcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtcodigo_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtcodigo.MaskInputRejected

    End Sub

    Private Sub txtcodigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtcodigo.Validating

        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("select * from Inventario where Codigo ='" & txtcodigo.Text & "'", con)

        '   Dim xConsulta As New SqlDataAdapter("select * from Inventario where Codigo = '" & txtcodigo.Text & "'", conexion.Inventario)
        '  Dim ds As New DataSet
        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then

            txtDescripcion.BackColor = Color.White

            encontrado = True

            txtdescripcion.text = ds.Tables(0).Rows(0).Item("Descripcion").ToString
            txtprecio.Text = ds.Tables(0).Rows(0).Item("Precio").ToString


            btnGuardar.Enabled = False
            btnModificar.Enabled = True
            btnEliminar.Enabled = True

        Else

            encontrado = False

            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            txtDescripcion.Enabled = True
            txtDescripcion.Focus()
            txtprecio.Enabled = True

            '   MsgBox("No se encuentra los datos del Empleado, no se puede llenar la ficha", MsgBoxStyle.Critical, "Error")
            txtDescripcion.Text = ""
            txtprecio.Text = ""

     

        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        accion = False
        txtDescripcion.Enabled = True
        txtprecio.Enabled = True
        btnGuardar.Enabled = True
        btnEliminar.Enabled = False
        btnModificar.Enabled = False


    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

     


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
    

    End Sub

    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

  
    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged

    End Sub


    Private Sub txtprecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprecio.TextChanged

    End Sub

    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Call queryconsultas.insertar_inventario(txtcodigo.Text, txtDescripcion.Text, 0, txtprecio.Text, 0)
        limpiar()

    End Sub

    Private Sub btnModificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Call queryconsultas.modificar_inventario(txtcodigo.Text, txtDescripcion.Text, 0, txtprecio.Text, 0)
        limpiar()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub btnEliminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
       

        Dim resp As String = MsgBox("¿Desea Eliminar el Registro?", MsgBoxStyle.YesNo, "CREATIVOS")

        If resp = 6 Then

          Call queryconsultas.Eliminar_inventario(txtcodigo.Text)
            limpiar()

        End If

        limpiar()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub
End Class