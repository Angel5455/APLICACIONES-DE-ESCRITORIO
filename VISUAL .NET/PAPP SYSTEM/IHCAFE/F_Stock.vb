Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Office.Interop

Public Class F_Stock

    Dim seleccion As String

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click

      
            If Val(txtCantidad.Text) = 0 Then


                Dim constr As String

            constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

            Dim con As New SqlConnection(constr)
            Dim ds As New DataSet
            Dim tabla As New DataTable


            Dim da As New SqlDataAdapter("Select * from Insumos Where Stock like'" & "0" & "%'", con)


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




        If Val(txtCantidad.Text) = 1 Then


            Dim constr As String

            constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

            Dim con As New SqlConnection(constr)
            Dim ds As New DataSet
            Dim tabla As New DataTable


            Dim da As New SqlDataAdapter("Select * from Insumos Where Estado like'" & "Existente" & "%'", con)


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




        If Val(txtCantidad.Text) = 2 Then


            Dim constr As String

            constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

            Dim con As New SqlConnection(constr)
            Dim ds As New DataSet
            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select * from Insumos Where Codigo like'" & "%'", con)


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



    End Sub

    Private Sub PictureBox7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseEnter
        PictureBox7.Height = 65
        PictureBox7.Width = 65
    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseLeave
        PictureBox7.Height = 70
        PictureBox7.Width = 70
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        txtCantidad.Text = 1
        txtestado.Text = "Existente"

    End Sub

    Private Sub txtCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        txtCantidad.Text = 0
        txtestado.Text = "Insuficiente"
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        txtCantidad.Text = 2
        txtestado.Text = "Todos"

    End Sub

   
    Private Sub F_Stock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        lblfecha.Text = Format(Now(), "dd/MM/yyyy")


        lblUsuario.Text = F_Menu.lblUsuario.Text
        

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        If seleccion = "VP" Then

            Dim conexion As New Conexion_Productos
            Dim datos As New dProductos
            Dim tabla As New DataTable
            Dim mireporte As New Crys_Stock

            datos.estado = txtestado.Text


            If conexion.consultar_stock(datos) Then

                tabla = conexion.tabla
                mireporte.SetDataSource(tabla)
                R_Stock.CrystalReportViewer1.ReportSource = mireporte
                R_Stock.CrystalReportViewer1.RefreshReport()
                R_Stock.Show()

            End If




        End If


        

        If seleccion = "EX" Then


            Call GridAExcel(DataGridView1)


        End If

    End Sub


    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount
            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.


            With exHoja

                .Visible = Excel.XlSheetVisibility.xlSheetVisible
                .Activate()
                .Name = "Exportacion Stock"
                .Range("A1").Value = "STOCK DE INSUMOS"
                .Range("A1").Font.Size = 20
                .Range("A1").Font.Name = "Arial"
                .Range("A1").Font.Italic = True
                .Range("A1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Range("A1").RowHeight = 30
                .Range("A1:H1").MergeCells = True

                .Range("A2").Value = "Linea"
                .Range("A2").ColumnWidth = 20
                .Range("A2").ColumnWidth = 20
                .Range("A2").Font.Bold = 1
                .Range("A2").HorizontalAlignment = 3


                .Range("B2").Value = "Codigo"
                .Range("B2").ColumnWidth = 10
                .Range("B2").Font.Bold = 1
                .Range("B2").HorizontalAlignment = 3

                .Range("C2").Value = "Nombre"
                .Range("C2").ColumnWidth = 20
                .Range("C2").Font.Bold = 1
                .Range("C2").HorizontalAlignment = 3



                .Range("D2").Value = "Unidad"
                .Range("D2").ColumnWidth = 15
                .Range("D2").Font.Bold = 1
                .Range("D2").HorizontalAlignment = 3


                .Range("E2").Value = "Stock"
                .Range("E2").ColumnWidth = 10
                .Range("E2").Font.Bold = 1
                .Range("E2").HorizontalAlignment = 3

                .Range("F2").Value = "Precio"
                .Range("F2").ColumnWidth = 10
                .Range("F2").Font.Bold = 1
                .Range("F2").HorizontalAlignment = 3


                .Range("G2").Value = "Proveedor"
                .Range("G2").ColumnWidth = 20
                .Range("G2").Font.Bold = 1
                .Range("G2").HorizontalAlignment = 3



            End With


            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 3, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'Aplicación visible
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True

    End Function


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        seleccion = "VP"
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        seleccion = "EX"
    End Sub

  
    Private Sub btnSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir2.Click
        btnSalir.Visible = True
        btnSalir2.Visible = False
        Me.Close()
    End Sub

    Private Sub btnSalir2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir2.MouseLeave
        btnSalir.Visible = True
        btnSalir2.Visible = False

    End Sub

    Private Sub btnSalir_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSalir.MouseMove
        btnSalir.Visible = False
        btnSalir2.Visible = True
    End Sub
End Class