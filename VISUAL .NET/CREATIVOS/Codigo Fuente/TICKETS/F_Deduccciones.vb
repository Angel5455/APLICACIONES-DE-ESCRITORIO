Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class F_Deduccciones

    Dim WithEvents queryconsultas As New dDeducciones

    Dim conexion As New DataClasses1DataContext()

    Dim encontrado As Boolean

    Public accion As Boolean
    Dim resultado As MsgBoxResult


    Sub mostrar()
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable




        Dim da As New SqlDataAdapter("Select * from Deducciones Where codigo like'%" & "" & "%'", con)


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

    Private Sub F_Deduccciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     

        mostrar()


        Dim total As Double = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1

            total = total + CDbl(DataGridView1.Item(2, i).Value)

        Next

        lbltotal.Text = total
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
       
        Call queryconsultas.insertar_deduccion(txtcodigo.Text, txtDescripcion.Text, txtprecio.Text)
       
        mostrar()

        Dim total As Double = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1

            total = total + CDbl(DataGridView1.Item(2, i).Value)

        Next
        lbltotal.Text = total

        Call queryconsultas.Eliminar_total(MaskedTextBox1.Text)
        Call queryconsultas.insertar_total(MaskedTextBox1.Text, lbltotal.Text)
       
        limpiar()

    End Sub

    Sub limpiar()
        txtcodigo.Clear()
        txtDescripcion.Clear()
        txtprecio.Clear()

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Call queryconsultas.modificar_deduccion(txtcodigo.Text, txtDescripcion.Text, txtprecio.Text)
        limpiar()
        mostrar()

        Dim total As Double = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1

            total = total + CDbl(DataGridView1.Item(2, i).Value)

        Next
        Call queryconsultas.Eliminar_total(MaskedTextBox1.Text)
        Call queryconsultas.insertar_total(MaskedTextBox1.Text, lbltotal.Text)
        lbltotal.Text = total
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click

        Dim resp As String = MsgBox("¿Desea Eliminar el Registro?", MsgBoxStyle.YesNo, "CREATIVOS")

        If resp = 6 Then

            Call queryconsultas.Eliminar_deduccion(txtcodigo.Text)
            limpiar()
            mostrar()
            Dim total As Double = 0
            For i As Integer = 0 To DataGridView1.RowCount - 1

                total = total + CDbl(DataGridView1.Item(2, i).Value)

            Next

            lbltotal.Text = total
        End If
        Call queryconsultas.Eliminar_total(MaskedTextBox1.Text)
        Call queryconsultas.insertar_total(MaskedTextBox1.Text, lbltotal.Text)
        limpiar()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    Private Sub txtcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtcodigo_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtcodigo.MaskInputRejected

    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub txtprecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtprecio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprecio.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Try
            txtcodigo.Text = DataGridView1.SelectedCells(0).Value.ToString()
            txtDescripcion.Text = DataGridView1.SelectedCells(1).Value.ToString()
            txtprecio.Text = DataGridView1.SelectedCells(2).Value.ToString()

            btnEliminar.Enabled = True
            btnModificar.Enabled = True
            btnGuardar.Enabled = False


        Catch ex As Exception

        End Try

    End Sub
End Class