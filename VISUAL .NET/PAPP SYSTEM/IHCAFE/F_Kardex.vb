Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Office.Interop

Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows
Public Class F_Kardex

    Dim ruta As String = ""
    Dim rpt As New ReportDocument
    Public fecha1 As Date : Dim strfecha1 As String
    Public fecha2 As Date : Dim strfecha2 As String
    Dim prmdatos As ParameterField

    Dim seleccion As String


    Private Sub txtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescripcion.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable


        Dim da As New SqlDataAdapter("Select * from Insumos where Codigo like '" & txtDescripcion.Text & "%'", con)

        Dim da2 As New SqlDataAdapter("Select * from Kardex where Codigo like '" & txtDescripcion.Text & "%'", con)

        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)
            DataGridView1.DataSource = tabla

            da2.Fill(tabla2)
            DataGridView2.DataSource = tabla2


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing
            tabla = Nothing


        End Try



    End Sub

    Private Sub llenarDsReporteKardex(ByVal strruta As String)

        Dim mids As dsRptKardex = New dsRptKardex
        Dim ta As New dsRptKardexTableAdapters.KardexTableAdapter

        Try

            fecha1 = txtfecha1.Value
            fecha2 = txtfecha2.Value

            ta.FillByFInsumo(mids.Kardex, fecha1.Date, fecha2.Date, txtInsumo.Text)

            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        If seleccion = "VP" Then

            ruta = "C:\Users\ANGEL\Desktop\COSAS DE GRADUACION\SISTEMA DE GRADUACION\IHCAFE\Crys_Kardex.rpt"

            llenarDsReporteKardex(ruta) : R_Kardex.CrystalReportViewer1.ReportSource = rpt : R_Kardex.Show()

        End If


        If seleccion = "EX" Then

            Call GridAExcel(DataGridView2)

        End If


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Try

            txtInsumo.Text = DataGridView1.SelectedCells(1).Value.ToString()

        Catch ex As Exception
        End Try

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        seleccion = "VP"

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        seleccion = "EX"

    End Sub

    Private Sub F_Kardex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblfecha.Text = Format(Now(), "dd/MM/yyyy")


        lblUsuario.Text = F_Menu.lblUsuario.Text


        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim cn As New SqlConnection("Data Source=.;Initial Catalog=Facturacion ;Integrated Security=True")
        Dim dt As New DataTable
        With cmd
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Insumos"
            .Connection = cn
        End With
        da.SelectCommand = cmd
        da.Fill(dt)
        DataGridView1.DataSource = dt



        Dim da2 As New SqlDataAdapter
        Dim cmd2 As New SqlCommand
        Dim cn2 As New SqlConnection("Data Source=(local);Initial Catalog=Facturacion ;Integrated Security=True")
        Dim dt2 As New DataTable
        With cmd2
            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Kardex"
            .Connection = cn2
        End With
        da2.SelectCommand = cmd2
        da2.Fill(dt2)
        DataGridView2.DataSource = dt2


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
                .Name = "Exportacion Kardex"
                .Range("A1").Value = "Kardex"
                .Range("A1").Font.Size = 28
                .Range("A1").Font.Name = "Arial"
                .Range("A1").Font.Italic = True
                .Range("A1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Range("A1").RowHeight = 30
                .Range("A1:N1").MergeCells = True

                .Range("A2").Value = "Nº Mov"
                .Range("A2").ColumnWidth = 10
                .Range("A2").ColumnWidth = 10
                .Range("A2").Font.Bold = 1
                .Range("A2").HorizontalAlignment = 3


                .Range("B2").Value = "Compra"
                .Range("B2").ColumnWidth = 10
                .Range("B2").Font.Bold = 1
                .Range("B2").HorizontalAlignment = 3

                .Range("C2").Value = "Factura"
                .Range("C2").ColumnWidth = 10
                .Range("C2").Font.Bold = 1
                .Range("C2").HorizontalAlignment = 3



                .Range("D2").Value = "Fecha"
                .Range("D2").ColumnWidth = 12
                .Range("D2").Font.Bold = 1
                .Range("D2").HorizontalAlignment = 3


                .Range("E2").Value = "Movimiento"
                .Range("E2").ColumnWidth = 15
                .Range("E2").Font.Bold = 1
                .Range("E2").HorizontalAlignment = 3

                .Range("F2").Value = "Concepto"
                .Range("F2").ColumnWidth = 20
                .Range("F2").Font.Bold = 1
                .Range("F2").HorizontalAlignment = 3


                .Range("G2").Value = "Codigo"
                .Range("G2").ColumnWidth = 10
                .Range("G2").Font.Bold = 1
                .Range("G2").HorizontalAlignment = 3


                .Range("H2").Value = "Insumo"
                .Range("H2").ColumnWidth = 30
                .Range("H2").Font.Bold = 1
                .Range("H2").HorizontalAlignment = 3


                .Range("I2").Value = "Unidad"
                .Range("I2").ColumnWidth = 15
                .Range("I2").Font.Bold = 1
                .Range("I2").HorizontalAlignment = 3


                .Range("J2").Value = "Proveedor"
                .Range("J2").ColumnWidth = 20
                .Range("J2").Font.Bold = 1
                .Range("J2").HorizontalAlignment = 3


                .Range("K2").Value = "Cliente"
                .Range("K2").ColumnWidth = 20
                .Range("K2").Font.Bold = 1
                .Range("K2").HorizontalAlignment = 3


                .Range("L2").Value = "Entrada"
                .Range("L2").ColumnWidth = 10
                .Range("L2").Font.Bold = 1
                .Range("L2").HorizontalAlignment = 3

                .Range("M2").Value = "Salida"
                .Range("M2").ColumnWidth = 10
                .Range("M2").Font.Bold = 1
                .Range("M2").HorizontalAlignment = 3

                .Range("N2").Value = "Stock"
                .Range("N2").ColumnWidth = 10
                .Range("N2").Font.Bold = 1
                .Range("N2").HorizontalAlignment = 3



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

    Private Sub txtInsumo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInsumo.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable


        Dim da As New SqlDataAdapter("Select * from Insumos where Nombre like '" & txtInsumo.Text & "%'", con)

        Dim da2 As New SqlDataAdapter("Select * from Kardex where Insumo like '" & txtInsumo.Text & "%'", con)

        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)
            DataGridView1.DataSource = tabla

            da2.Fill(tabla2)
            DataGridView2.DataSource = tabla2


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