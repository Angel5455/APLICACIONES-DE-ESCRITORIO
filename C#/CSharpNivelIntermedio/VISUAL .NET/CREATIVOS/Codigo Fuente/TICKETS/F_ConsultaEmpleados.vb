Imports System.Data.SqlClient
Imports System.Data


Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows

Public Class F_ConsultaEmpleados


    Dim ruta As String = ""
    Dim rpt As New ReportDocument
    Public fecha1 As Date : Dim strfecha1 As String
    Public fecha2 As Date : Dim strfecha2 As String
    Dim prmdatos As ParameterField

    Dim seleccion As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub llenarDsReporteKardex(ByVal strruta As String)

        Dim mids As dRptCREATIVOS = New dRptCREATIVOS
        Dim ta As New dRptCREATIVOSTableAdapters.TicketsTableAdapter

        Try



            ta.FillByFecha(mids.Tickets, t1.Text, t2.Text, txtNombre.Text)

            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub F_ConsultaEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CREATIVOSDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.CREATIVOSDataSet.Usuarios)


        Dim tmes, taño, tdia As String

        If txtfecha1.Value.Date.Month < 10 Then

            tmes = "0" & txtfecha1.Value.Date.Month
            taño = txtfecha1.Value.Date.Year
            t1.Text = "" & tmes & taño
        Else

            tmes = txtfecha1.Value.Date.Month
            taño = txtfecha1.Value.Date.Year
            t1.Text = "" & tmes & taño
        End If


        If txtfecha1.Value.Date.Day < 10 Then

            tdia = "0" & txtfecha1.Value.Date.Day
            taño = txtfecha1.Value.Date.Year
            t1.Text = tdia & tmes & taño
        Else

            tdia = txtfecha1.Value.Date.Day
            taño = txtfecha1.Value.Date.Year
            t1.Text = tdia & tmes & taño

        End If

        Dim tmes1, tdia1, taño1 As String

        If txtfecha2.Value.Date.Month < 10 Then

            tmes1 = "0" & txtfecha2.Value.Date.Month
            taño1 = txtfecha2.Value.Date.Year
            t2.Text = "" & tmes1 & taño1
        Else

            tmes1 = txtfecha2.Value.Date.Month
            taño1 = txtfecha2.Value.Date.Year
            t2.Text = "" & tmes1 & taño1
        End If


        If txtfecha2.Value.Date.Day < 10 Then

            tdia1 = "0" & txtfecha2.Value.Date.Day
            taño1 = txtfecha2.Value.Date.Year
            t2.Text = tdia1 & tmes1 & taño1
        Else

            tdia1 = txtfecha2.Value.Date.Day
            taño1 = txtfecha2.Value.Date.Year
            t2.Text = tdia1 & tmes1 & taño1

        End If


    End Sub

  

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        Try
            txtNombre.Text = DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(0).Value


        Catch ex As Exception
        End Try




    End Sub

    Private Sub txtfecha1_ValueChanged(sender As Object, e As EventArgs) Handles txtfecha1.ValueChanged

        Dim tmes, taño, tdia As String

        txtfecha1.MinDate = New DateTime(2013, 1, 1)
        txtfecha1.MaxDate = DateTime.Today

        txtfecha1.Format = DateTimePickerFormat.Custom

        If txtfecha1.Value.Date.Month < 10 Then

            tmes = "0" & txtfecha1.Value.Date.Month
            taño = txtfecha1.Value.Date.Year
            t1.Text = tmes & "" & taño
        Else

            tmes = txtfecha1.Value.Date.Month
            taño = txtfecha1.Value.Date.Year
            t1.Text = tmes & "" & taño
        End If



        If txtfecha1.Value.Date.Day < 10 Then

            tdia = "0" & txtfecha1.Value.Date.Day
            taño = txtfecha1.Value.Date.Year
            t1.Text = tdia & tmes & taño
        Else

            tdia = txtfecha1.Value.Date.Day
            taño = txtfecha1.Value.Date.Year
            t1.Text = tdia & tmes & taño

        End If


    End Sub

    Private Sub txtfecha2_ValueChanged(sender As Object, e As EventArgs) Handles txtfecha2.ValueChanged
        txtfecha2.MinDate = New DateTime(2013, 1, 1)
        txtfecha2.MaxDate = DateTime.Today

        txtfecha2.Format = DateTimePickerFormat.Custom

        Dim tmes, taño, tdia As String

        If txtfecha2.Value.Date.Month < 10 Then

            tmes = "0" & txtfecha2.Value.Date.Month
            taño = txtfecha2.Value.Date.Year
            t2.Text = "" & tmes & taño
        Else

            tmes = txtfecha1.Value.Date.Month
            taño = txtfecha1.Value.Date.Year
            t2.Text = "" & tmes & taño
        End If



        If txtfecha2.Value.Date.Day < 10 Then

            tdia = "0" & txtfecha2.Value.Date.Day
            taño = txtfecha2.Value.Date.Year
            t2.Text = tdia & tmes & taño
        Else

            tdia = txtfecha2.Value.Date.Day
            taño = txtfecha2.Value.Date.Year
            t2.Text = tdia & tmes & taño

        End If

    End Sub





    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ruta = "C:\CrysConsulta.rpt"

        llenarDsReporteKardex(ruta) : R_Consulta.CrystalReportViewer1.ReportSource = rpt : R_Consulta.Show()

    End Sub
End Class