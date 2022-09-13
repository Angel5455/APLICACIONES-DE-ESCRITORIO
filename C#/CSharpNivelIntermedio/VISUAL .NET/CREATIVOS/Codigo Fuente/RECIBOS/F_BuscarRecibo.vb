Imports System.Data.SqlClient

Public Class F_BuscarRecibo

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub F_BuscarRecibo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

    End Sub

  

    Private Sub txtNumero_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNumero.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Recibos Where Id like'%" & txtNumero.Text & "%'", con)

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

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Recibos Where Cliente like'%" & txtNombre.Text & "%'", con)

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

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        Try

            F_Imprimir.lblId.Text = DataGridView1.SelectedCells(0).Value.ToString()
            F_Imprimir.lblFecha.Text = DataGridView1.SelectedCells(1).Value.ToString()
            F_Imprimir.lblCantidad.Text = DataGridView1.SelectedCells(2).Value.ToString()
            F_Imprimir.lblCliente.Text = DataGridView1.SelectedCells(3).Value.ToString()
            F_Imprimir.lblLetras.Text = DataGridView1.SelectedCells(4).Value.ToString()
            F_Imprimir.lblConcepto.Text = DataGridView1.SelectedCells(5).Value.ToString()
            F_Imprimir.lblAnterior.Text = DataGridView1.SelectedCells(6).Value.ToString()
            F_Imprimir.lblAbono.Text = DataGridView1.SelectedCells(7).Value.ToString()
            F_Imprimir.lblActual.Text = DataGridView1.SelectedCells(8).Value.ToString()
            F_Imprimir.lblUsuario.Text = DataGridView1.SelectedCells(9).Value.ToString()

            F_Imprimir.Show()

        Catch ex As Exception

        End Try


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Recibos Where Fecha like'%" & txtFecha1.Text & "%'", con)

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

    Private Sub txtFecha1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFecha1.ValueChanged


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

    Private Sub t1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles t1.MaskInputRejected

    End Sub

    Private Sub t1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles t1.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Recibos Where Fecha like'%" & t1.Text & "%'", con)

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
End Class