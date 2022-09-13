Imports System.Data.SqlClient

Public Class F_Prestamos

    Dim WithEvents queryconsultas As New dPrestamos
    Dim conexion As New DataClasses1DataContext()

    Dim encontrado As Boolean

    Public accion As Boolean
    Dim resultado As MsgBoxResult



    Sub limpiar()

        '   txtcodigo.Text = My.Settings.MyCodigo + 1
        txtnombre.Text = ""
        txtcodigo.Text = ""
        txtCantidad.Text = ""
    End Sub



    Private Sub txtcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtcodigo_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtcodigo.MaskInputRejected

    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtprecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub txtcodigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtcodigo.Validating
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("select * from Empleados where Codigo ='" & txtcodigo.Text & "'", con)

        '   Dim xConsulta As New SqlDataAdapter("select * from Inventario where Codigo = '" & txtcodigo.Text & "'", conexion.Inventario)
        '  Dim ds As New DataSet
        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then

            txtnombre.BackColor = Color.White

            encontrado = True

            txtnombre.Text = ds.Tables(0).Rows(0).Item("Nombre").ToString


            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            Button1.Enabled = True

        Else

            encontrado = False

            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            txtNombre.Enabled = False
            txtnombre.Focus()


            '   MsgBox("No se encuentra los datos del Empleado, no se puede llenar la ficha", MsgBoxStyle.Critical, "Error")
            txtnombre.Text = ""
            'txtprecio.Text = ""

        End If


    End Sub

    Private Sub F_Prestamos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        mostrar()
        lblId.Text = queryconsultas.numero_prestamo().ToString
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
        btnGuardar.Enabled = True

        Dim total As Double = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1

            total = total + CDbl(DataGridView1.Item(3, i).Value)

        Next
        lbltotal.Text = total
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If txtNombre.Text <> "" And txtCantidad.Text <> "" Then


            Call queryconsultas.insertar_prestamos(lblid.text, txtcodigo.Text, txtNombre.Text, txtCantidad.Text)
            lblId.Text = queryconsultas.numero_prestamo().ToString
            mostrar()

            Dim total As Double = 0
            For i As Integer = 0 To DataGridView1.RowCount - 1

                total = total + CDbl(DataGridView1.Item(3, i).Value)

            Next
            lbltotal.Text = total

            limpiar()

        Else

            MsgBox("Campos vacios", MsgBoxStyle.Exclamation, "CREATIVOS")

        End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Call queryconsultas.modificar_prestamos(lblId.Text, txtcodigo.Text, txtNombre.Text, txtCantidad.Text)
        limpiar()
        mostrar()


    End Sub

    Sub mostrar()
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable




        Dim da As New SqlDataAdapter("Select * from Prestamos Where nombre like'%" & "" & "%'", con)


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

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Call queryconsultas.Eliminar_prestamos(txtcodigo.Text)
        lblId.Text = queryconsultas.numero_prestamo().ToString
        limpiar()
        mostrar()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Try
            txtcodigo.Text = DataGridView1.SelectedCells(1).Value.ToString()
            txtNombre.Text = DataGridView1.SelectedCells(2).Value.ToString()
            txtCantidad.Text = DataGridView1.SelectedCells(3).Value.ToString()

            btnGuardar.Enabled = False
            btnEliminar.Enabled = True
            btnModificar.Enabled = True

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable




        Dim da As New SqlDataAdapter("Select * from Prestamos Where nombre like'%" & txtNombre.Text & "%'", con)




        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            DataGridView1.DataSource = tabla


            Dim total As Double = 0
            For i As Integer = 0 To DataGridView1.RowCount - 1

                total = total + CDbl(DataGridView1.Item(3, i).Value)

            Next
            lbltotal.Text = total
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing

            tabla = Nothing

        End Try
    End Sub
End Class