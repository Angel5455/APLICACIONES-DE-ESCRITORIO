Imports System.Data.SqlClient

Imports System.Data
Imports Microsoft.Office.Interop

Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows


Public Class F_Busqueda_Agencias

    Dim ruta As String = ""
    Dim rpt As New ReportDocument
    Public agencia As String : Dim stragencia As String
    Public fase As String : Dim strfase As String
    Dim prmdatos As ParameterField

    Dim seleccion As String



    Private Sub txtFase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFase.SelectedIndexChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from General where Fase like '" & txtFase.Text & "%'", con)


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


        Dim total As Double

        Dim saldo As Double

        Try
            For i As Integer = 0 To DataGridView1.RowCount - 1
                total = total + CDbl(DataGridView1.Item("Monto".ToLower, i).Value)

            Next

            lblT_Aprobado.Text = total

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Try
            For i As Integer = 0 To DataGridView1.RowCount - 1
                saldo = saldo + CDbl(DataGridView1.Item("Saldo".ToLower, i).Value)

            Next

            lblP_Desembolsado.Text = saldo

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Dim td As Double

        td = Val(lblT_Aprobado.Text) - Val(lblP_Desembolsado.Text)

        lblT_Desembolsado.Text = td

    End Sub

    Private Sub txtAgencia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAgencia.SelectedIndexChanged

        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from General where Fase like '" & txtFase.Text & "%'" & "And Agencia like'" & txtAgencia.Text & "%'", con)


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

        Dim total As Double

        Dim saldo As Double

        Try
            For i As Integer = 0 To DataGridView1.RowCount - 1
                total = total + CDbl(DataGridView1.Item("Monto".ToLower, i).Value)

            Next

            lblT_Aprobado.Text = total

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Try
            For i As Integer = 0 To DataGridView1.RowCount - 1
                saldo = saldo + CDbl(DataGridView1.Item("Saldo".ToLower, i).Value)

            Next

            lblP_Desembolsado.Text = saldo

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Dim td As Double

        td = Val(lblT_Aprobado.Text) - Val(lblP_Desembolsado.Text)

        lblT_Desembolsado.Text = td


    End Sub

    Private Sub llenarDsReporteKardex(ByVal strruta As String)

        Try

            Dim mids As dsRptGeneral = New dsRptGeneral
            Dim ta As New dsRptGeneralTableAdapters.GeneralTableAdapter


            agencia = txtAgencia.Text
            fase = txtFase.Text

            ta.FillBy2(mids.General, fase, agencia)

            rpt.Load(strruta)
            rpt.SetDataSource(mids)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub



    Private Sub F_Busqueda_Agencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FasesDataSet.Configuracion' Puede moverla o quitarla según sea necesario.
        Me.ConfiguracionTableAdapter.Fill(Me.FasesDataSet.Configuracion)
        lblUsuario.Text = F_Menu.lblUsuario.Text
        lblfecha.Text = Format(Now(), "dd/MM/yyyy")

        Dim total As Double

        Dim saldo As Double

        Try
            For i As Integer = 0 To DataGridView1.RowCount - 1
                total = total + CDbl(DataGridView1.Item("Monto".ToLower, i).Value)

            Next

            lblT_Aprobado.Text = total

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Try
            For i As Integer = 0 To DataGridView1.RowCount - 1
                saldo = saldo + CDbl(DataGridView1.Item("Saldo".ToLower, i).Value)

            Next

            lblP_Desembolsado.Text = saldo

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Dim td As Double

        td = Val(lblT_Aprobado.Text) - Val(lblP_Desembolsado.Text)

        lblT_Desembolsado.Text = td


    End Sub

    Private Sub btnNoSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoSave.Click


        ruta = "C:\Users\ANGEL\Desktop\SISTEMA DE GRADUACION\IHCAFE\Crys_Fases.rpt"

        llenarDsReporteKardex(ruta) : R_Fases.CrystalReportViewer1.ReportSource = rpt : R_Fases.Show()

    End Sub
End Class