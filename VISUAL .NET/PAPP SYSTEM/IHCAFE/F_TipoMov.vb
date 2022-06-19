Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Office.Interop

Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows


Public Class F_TipoMov
    Dim seleccion As String
    Dim ruta As String = ""
    Dim rpt As New ReportDocument
    Public fecha1 As Date : Dim strfecha1 As String
    Public fecha2 As Date : Dim strfecha2 As String
    Dim prmdatos As ParameterField

    Private Sub F_TipoMov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblUsuario.Text = F_Menu.lblUsuario.Text
        lblfecha.Text = Format(Now(), "dd/MM/yyyy")

        fecha1 = txtfecha1.Text
        fecha2 = txtfecha2.Text

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click

        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Facturacion;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Kardex Where Movimiento like'" & ComboTipo.Text & "%'", con)


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

    Private Sub llenarDsReporteKardex(ByVal strruta As String)

        Dim mids As dsRptKardex = New dsRptKardex
        Dim ta As New dsRptKardexTableAdapters.KardexTableAdapter

        Try

            fecha1 = txtfecha1.Value
            fecha2 = txtfecha2.Value

            ta.FillByFecha(mids.Kardex, fecha1.Date, fecha2.Date, ComboTipo.Text)

            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        If seleccion = "VP" Then

            ruta = "C:\Users\ANGEL\Desktop\SISTEMA DE GRADUACION\IHCAFE\Crys_Movimientos.rpt"

            llenarDsReporteKardex(ruta) : R_Movimiento.CrystalReportViewer1.ReportSource = rpt : R_Movimiento.Show()


        End If

        If seleccion = "EX" Then


            Call GridAExcel(DataGridView1)


        End If


    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Height = 45
        PictureBox3.Width = 45
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Height = 50
        PictureBox3.Width = 50
    End Sub

   

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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
                .Name = "Movimientos"
                .Range("A1").Value = "Movimientos Inventario"
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


                .Range("D2").Value = "Orden"
                .Range("D2").ColumnWidth = 10
                .Range("D2").Font.Bold = 1
                .Range("D2").HorizontalAlignment = 3


                .Range("E2").Value = "Fecha"
                .Range("E2").ColumnWidth = 12
                .Range("E2").Font.Bold = 1
                .Range("E2").HorizontalAlignment = 3


                .Range("F2").Value = "Movimiento"
                .Range("F2").ColumnWidth = 15
                .Range("F2").Font.Bold = 1
                .Range("F2").HorizontalAlignment = 3

                .Range("G2").Value = "Concepto"
                .Range("G2").ColumnWidth = 20
                .Range("G2").Font.Bold = 1
                .Range("G2").HorizontalAlignment = 3


                .Range("H2").Value = "Codigo"
                .Range("H2").ColumnWidth = 10
                .Range("H2").Font.Bold = 1
                .Range("H2").HorizontalAlignment = 3


                .Range("I2").Value = "Insumo"
                .Range("I2").ColumnWidth = 30
                .Range("I2").Font.Bold = 1
                .Range("I2").HorizontalAlignment = 3


                .Range("J2").Value = "Unidad"
                .Range("J2").ColumnWidth = 15
                .Range("J2").Font.Bold = 1
                .Range("J2").HorizontalAlignment = 3


                .Range("K2").Value = "Proveedor"
                .Range("K2").ColumnWidth = 20
                .Range("K2").Font.Bold = 1
                .Range("K2").HorizontalAlignment = 3


                .Range("L2").Value = "Cliente"
                .Range("L2").ColumnWidth = 20
                .Range("L2").Font.Bold = 1
                .Range("L2").HorizontalAlignment = 3


                .Range("M2").Value = "Entrada"
                .Range("M2").ColumnWidth = 10
                .Range("M2").Font.Bold = 1
                .Range("M2").HorizontalAlignment = 3

                .Range("N2").Value = "Salida"
                .Range("N2").ColumnWidth = 10
                .Range("N2").Font.Bold = 1
                .Range("N2").HorizontalAlignment = 3

                .Range("O2").Value = "Stock"
                .Range("O2").ColumnWidth = 10
                .Range("O2").Font.Bold = 1
                .Range("O2").HorizontalAlignment = 3



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

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        seleccion = "VP"
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        seleccion = "EX"
    End Sub

    Private Sub ComboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboTipo.SelectedIndexChanged

    End Sub

    Private Sub btnSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir2.Click

        Dim resp As Integer
        resp = MsgBox("¿Esta Seguro De Salir?", MsgBoxStyle.YesNo, "P.A.P.P System")
        If resp = 6 Then

            btnSalir.Visible = True
            btnSalir2.Visible = False

         
            Me.Close()
        End If

    End Sub

    Private Sub btnSalir2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir2.MouseLeave
        btnSalir.Visible = True
        btnSalir2.Visible = False
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

    End Sub

    Private Sub btnSalir_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSalir.MouseMove
        btnSalir.Visible = False
        btnSalir2.Visible = True
    End Sub
End Class