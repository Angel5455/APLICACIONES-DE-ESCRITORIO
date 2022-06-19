Imports System.Data.SqlClient
Imports System.Data

Public Class F_BuscarPendientes

    Public opc As Boolean
    Private Sub txtRecibo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRecibo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRecibo_TextChanged(sender As Object, e As EventArgs) Handles txtRecibo.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable




        Dim da As New SqlDataAdapter("Select * from Recibos_Pendientes Where Id like'" & txtRecibo.Text & "'", con)


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

    Private Sub F_BuscarPendientes_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Recibos_Pendientes Where Estado like'%" & "PENDIENTE" & "%'", con)

        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            DataGridView1.DataSource = tabla


            Dim fila As Integer
            fila = DataGridView1.RowCount - 1


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing

            tabla = Nothing

        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtFecha1.ValueChanged
        txtFecha1.MinDate = New DateTime(2013, 1, 1)
        txtFecha1.MaxDate = DateTime.Today

        txtFecha1.Format = DateTimePickerFormat.Custom

        txtFecha1.MinDate = New DateTime(2013, 1, 1)
        txtFecha1.MaxDate = DateTime.Today

        txtFecha1.Format = DateTimePickerFormat.Custom


        Dim tmes, taño, tdia As String

        If txtFecha1.Value.Date.Month < 10 Then

            tmes = "0" & txtFecha1.Value.Date.Month
            taño = txtFecha1.Value.Date.Year
            t1.Text = taño & tmes & ""
        Else

            tmes = txtFecha1.Value.Date.Month
            taño = txtFecha1.Value.Date.Year
            t1.Text = taño & tmes & ""
        End If



        If txtFecha1.Value.Date.Day < 10 Then

            tdia = "0" & txtFecha1.Value.Date.Day
            taño = txtFecha1.Value.Date.Year
            t1.Text = taño & tmes & tdia
        Else

            tdia = txtFecha1.Value.Date.Day
            taño = txtFecha1.Value.Date.Year
            t1.Text = taño & tmes & tdia

        End If

    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtNombre.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Recibos_Pendientes Where Cliente like'%" & txtNombre.Text & "%'", con)

        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            DataGridView1.DataSource = tabla


            Dim fila As Integer
            fila = DataGridView1.RowCount - 1


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing

            tabla = Nothing

        End Try
    End Sub

    Private Sub t1_MaskInputRejected(ByVal sender As Object, ByVal e As MaskInputRejectedEventArgs) Handles t1.MaskInputRejected

    End Sub

    Private Sub t1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles t1.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Recibos_Pendientes Where Fecha like'%" & t1.Text & "%'", con)

        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            DataGridView1.DataSource = tabla


            Dim fila As Integer
            fila = DataGridView1.RowCount - 1


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing

            tabla = Nothing

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Try
            Dim cantidad As Integer

            F_Recibo.lblReciboAnt.Text = DataGridView1.SelectedCells(0).Value.ToString()
            F_Recibo.lblFecha.Text = DataGridView1.SelectedCells(1).Value.ToString()


            F_Recibo.lblCliente.Text = DataGridView1.SelectedCells(3).Value.ToString()
            F_Recibo.lblLetras.Text = DataGridView1.SelectedCells(4).Value.ToString()
            F_Recibo.lblConcepto.Text = DataGridView1.SelectedCells(5).Value.ToString()
            cantidad = Val(DataGridView1.SelectedCells(8).Value.ToString())

            F_Recibo.lblAnterior.Text = cantidad

            F_Recibo.lblAbono.Text = DataGridView1.SelectedCells(7).Value.ToString()
            'F_Recibo.lblActual.Text = DataGridView1.SelectedCells(8).Value.ToString()
            F_Recibo.lblEstado.Text = DataGridView1.SelectedCells(9).Value.ToString()
            F_Recibo.lblUsuario.Text = DataGridView1.SelectedCells(10).Value.ToString()

            F_Cantidad2.lblmonto.Text = cantidad

            F_Cantidad2.CheckBox1.Checked = True
            F_Cantidad2.Show()
            Me.Close()


        Catch ex As Exception

        End Try
    End Sub
End Class