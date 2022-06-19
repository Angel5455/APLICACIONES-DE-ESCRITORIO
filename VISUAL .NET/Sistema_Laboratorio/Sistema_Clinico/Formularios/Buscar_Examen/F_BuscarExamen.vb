Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class F_BuscarExamen

    Dim TablaBD As String
    Dim Columna, Columna1, Columna2 As String
    Dim Opcion As String

    Dim Rruta As String = ""
    Dim rpt As New ReportDocument
    Dim prmdatos As ParameterField
    Dim ID As String


    Private Sub F_BuscarExamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RadioUnica.Checked = True


        If RadioUnica.Checked Then

            Label3.Visible = False
            Label4.Visible = False
            TxtCampo2.Visible = False
            TxtBuscar2.Visible = False
            Opcion = "Unica"


        End If

        If RadioMultiple.Checked Then

            Label3.Visible = True
            Label4.Visible = True
            TxtCampo2.Visible = True
            TxtBuscar2.Visible = True
            Opcion = "Multiple"

        End If


    End Sub

    Private Sub TxtXPaciente_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Sub BD(Examen As String)




    End Sub

    Private Sub TxtExamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtExamen.SelectedIndexChanged
        If TxtExamen.Text = "Abuso de Drogas" Then
            TablaBD = "Abuso_Drogas"
        End If

        If TxtExamen.Text = "Citologia de Moco Fecal" Then
            TablaBD = "Citologia_Moco_Fecal"
        End If

        If TxtExamen.Text = "CTOG" Then
            TablaBD = "CTOG"
        End If

        If TxtExamen.Text = "Embarazo / Orina" Then
            TablaBD = "Embarazo_Orina"
        End If

        If TxtExamen.Text = "Embarazo / Sangre" Then
            TablaBD = "Embarazo_Sangre"
        End If

        If TxtExamen.Text = "FSP" Then
            TablaBD = "FSP"
        End If

        If TxtExamen.Text = "Heces" Then
            TablaBD = "Heces"
        End If

        If TxtExamen.Text = "Hematologia" Then
            TablaBD = "Hematologia"
        End If

        If TxtExamen.Text = "Helicobacter Pilory / Heces" Then
            TablaBD = "HPilory_Heces"
        End If

        If TxtExamen.Text = "Helicobacter Pilory / Sangre" Then
            TablaBD = "HPilory_Sangre"
        End If

        If TxtExamen.Text = "Hematologia" Then
            TablaBD = "Hematologia"
        End If

        If TxtExamen.Text = "Orina" Then
            TablaBD = "Orina"
        End If

        If TxtExamen.Text = "Pruebas Especiales" Then
            TablaBD = "PEspeciales"
        End If

        If TxtExamen.Text = "Quimica Sanguinea" Then
            TablaBD = "Quimica_Sanguinea"
        End If











    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click


        If Opcion = "Unica" Then

            Dim constr As String
            Dim Sql As String



            constr = Conexion.Cadena

            Columna = TxtCampo1.Text

            If TablaBD <> "" Then

                Sql = "Select * from " & TablaBD & " where " & Columna & " like '%" & TxtBuscar1.Text & "%'"

                Dim con As New SqlConnection(constr)

                Dim tabla As New DataTable

                Dim da As New SqlDataAdapter(Sql, con)




                Try


                    da.Fill(tabla)


                    DataGridView1.DataSource = tabla





                Catch ex As Exception
                    MsgBox(ex.Message)

                Finally

                    con = Nothing

                    da = Nothing


                    tabla = Nothing


                End Try


            Else
                MsgBox("Elija el Examen a Buscar")

            End If






        End If





        If Opcion = "Multiple" Then

            Dim constr As String
            Dim Sql As String



            constr = Conexion.Cadena

            Columna1 = TxtCampo1.Text
            Columna2 = TxtCampo2.Text

            If TablaBD <> "" Then

                Sql = "Select * from " & TablaBD & " where " & Columna1 & " like '%" & TxtBuscar1.Text & "%'" & " And " & Columna2 & " like '" & TxtBuscar2.Text & "%'"

                Dim con As New SqlConnection(constr)

                Dim tabla As New DataTable

                Dim da As New SqlDataAdapter(Sql, con)




                Try


                    da.Fill(tabla)


                    DataGridView1.DataSource = tabla





                Catch ex As Exception
                    MsgBox(ex.Message)

                Finally

                    con = Nothing

                    da = Nothing


                    tabla = Nothing


                End Try


            Else
                MsgBox("Elija el Examen a Buscar")

            End If






        End If



    End Sub

    Private Sub TxtCampo1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtCampo1.SelectedIndexChanged
        'Dim da As SqlDataAdapter
        'Dim dt As DataTable
        'Dim oConexion As SqlConnection
        'oConexion = New SqlConnection
        'oConexion.ConnectionString = "Data Source=(local);Initial Catalog=SystemLaboratorio;Persist Security Info=True;User ID=sa;Password=root"

        'Dim sSel As String = "Describe " & TxtExamen.Text.ToString

        'Try
        '    da = New SqlDataAdapter(sSel, oConexion)
        '    dt = New DataTable
        '    da.Fill(dt)




        'Catch ex As Exception
        '    MsgBox("Error")
        'End Try

        'TxtCampo1.DataSource = dt
        'TxtCampo1.DisplayMember = "COLUMN_NAME"
        'TxtCampo1.ValueMember = "COLUMN_NAME"



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim IdE As Integer = DataGridView1.SelectedCells(0).Value.ToString()

            If IdE <> 0 Then
                Imprimir_Examen(IdE, TablaBD)
            Else
                MsgBox("Seleccione una fila")

            End If
        Catch ex As Exception
            MsgBox(ex)

        End Try





    End Sub

    Private Sub RadioUnica_CheckedChanged(sender As Object, e As EventArgs) Handles RadioUnica.CheckedChanged
        If RadioUnica.Checked Then

            Label3.Visible = False
            Label4.Visible = False
            TxtCampo2.Visible = False
            TxtBuscar2.Visible = False
            Opcion = "Unica"


        End If

        If RadioMultiple.Checked Then

            Label3.Visible = True
            Label4.Visible = True
            TxtCampo2.Visible = True
            TxtBuscar2.Visible = True
            Opcion = "Multiple"

        End If
    End Sub

    Private Sub RadioMultiple_CheckedChanged(sender As Object, e As EventArgs) Handles RadioMultiple.CheckedChanged

        If RadioUnica.Checked Then

            Label3.Visible = False
            Label4.Visible = False
            TxtCampo2.Visible = False
            TxtBuscar2.Visible = False
            Opcion = "Unica"


        End If

        If RadioMultiple.Checked Then

            Label3.Visible = True
            Label4.Visible = True
            TxtCampo2.Visible = True
            TxtBuscar2.Visible = True
            Opcion = "Multiple"

        End If
    End Sub

    Sub Imprimir_Examen(ByVal Id As String, ByVal Tabla As String)

        If Tabla = "Abuso_Drogas" Then
            Dim resp As String

            resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


            If resp = 6 Then

                Rruta = "C:\SystemLetona\CrysDrogas.rpt"

                LlenarDsReporteExamen(Rruta, Id, Tabla) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


            End If
        End If

        If Tabla = "Citologia_Moco_Fecal" Then
            Dim resp As String

            resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


            If resp = 6 Then

                Rruta = "C:\SystemLetona\CrysCitologia.rpt"

                LlenarDsReporteExamen(Rruta, Id, Tabla) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


            End If
        End If


        If Tabla = "CTOG" Then
            Dim resp As String

            resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


            If resp = 6 Then

                Rruta = "C:\SystemLetona\CrysCTOG.rpt"

                LlenarDsReporteExamen(Rruta, Id, Tabla) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


            End If
        End If

        If Tabla = "Embarazo_Orina" Then
            Dim resp As String

            resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


            If resp = 6 Then

                Rruta = "C:\SystemLetona\CrysEmbarazoO.rpt"

                LlenarDsReporteExamen(Rruta, Id, Tabla) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


            End If
        End If


        If Tabla = "Embarazo_Sangre" Then
            Dim resp As String

            resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


            If resp = 6 Then

                Rruta = "C:\SystemLetona\CrysEmbarazoS.rpt"

                LlenarDsReporteExamen(Rruta, Id, Tabla) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


            End If
        End If

        If Tabla = "FSP" Then
            Dim resp As String

            resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


            If resp = 6 Then

                Rruta = "C:\SystemLetona\CrysFSP.rpt"

                LlenarDsReporteExamen(Rruta, Id, Tabla) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


            End If
        End If

        If Tabla = "Heces" Then
            Dim resp As String

            resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


            If resp = 6 Then

                Rruta = "C:\SystemLetona\CrysHeces.rpt"

                LlenarDsReporteExamen(Rruta, Id, Tabla) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


            End If
        End If


        If Tabla = "Hematologia" Then
            Dim resp As String

            resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


            If resp = 6 Then

                Rruta = "C:\SystemLetona\CrysHema.rpt"

                LlenarDsReporteExamen(Rruta, Id, Tabla) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


            End If
        End If


        If Tabla = "HPilory_Heces" Then
            Dim resp As String

            resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


            If resp = 6 Then

                Rruta = "C:\SystemLetona\CrysPiloryH.rpt"

                LlenarDsReporteExamen(Rruta, Id, Tabla) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


            End If
        End If

        If Tabla = "HPilory_Sangre" Then
            Dim resp As String

            resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


            If resp = 6 Then

                Rruta = "C:\SystemLetona\CrysPiloryS.rpt"

                LlenarDsReporteExamen(Rruta, Id, Tabla) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


            End If
        End If

        If Tabla = "Orina" Then
            Dim resp As String

            resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


            If resp = 6 Then

                Rruta = "C:\SystemLetona\CrysOrina.rpt"

                LlenarDsReporteExamen(Rruta, Id, Tabla) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


            End If
        End If

        If Tabla = "PEspeciales" Then
            Dim resp As String

            resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


            If resp = 6 Then

                Rruta = "C:\SystemLetona\CrysPEspeciales.rpt"

                LlenarDsReporteExamen(Rruta, Id, Tabla) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


            End If
        End If

        If Tabla = "Quimica_Sanguinea" Then
            Dim resp As String

            resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


            If resp = 6 Then

                Rruta = "C:\SystemLetona\CrysQuimica.rpt"

                LlenarDsReporteExamen(Rruta, Id, Tabla) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


            End If
        End If










    End Sub

    Private Sub LlenarDsReporteExamen(ByVal strruta As String, ByVal Ids As String, ByVal Tabla As String)


        If Tabla = "Abuso_Drogas" Then
            ID = Ids

            Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
            Dim ta As New SystemLetonaDataSetTableAdapters.Abuso_DrogasTableAdapter
            Dim ta2 As New SystemLetonaDataSetTableAdapters.Abuso_DrogasTableAdapter

            Try

                ta.FillByMuestra(mids.Abuso_Drogas, ID)


                rpt.Load(strruta)
                rpt.SetDataSource(mids)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


        If Tabla = "Citologia_Moco_Fecal" Then
            ID = Ids

            Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
            Dim ta As New SystemLetonaDataSetTableAdapters.Citologia_Moco_FecalTableAdapter
            Dim ta2 As New SystemLetonaDataSetTableAdapters.Citologia_Moco_FecalTableAdapter

            Try

                ta.FillById(mids.Citologia_Moco_Fecal, ID)


                rpt.Load(strruta)
                rpt.SetDataSource(mids)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


        If Tabla = "CTOG" Then
            ID = Ids

            Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
            Dim ta As New SystemLetonaDataSetTableAdapters.CTOGTableAdapter
            Dim ta2 As New SystemLetonaDataSetTableAdapters.CTOGTableAdapter

            Try

                ta.FillByMuestra(mids.CTOG, ID)


                rpt.Load(strruta)
                rpt.SetDataSource(mids)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


        If Tabla = "Embarazo_Orina" Then
            ID = Ids

            Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
            Dim ta As New SystemLetonaDataSetTableAdapters.Embarazo_OrinaTableAdapter
            Dim ta2 As New SystemLetonaDataSetTableAdapters.Embarazo_OrinaTableAdapter


            Try

                ta.FillByMuestra(mids.Embarazo_Orina, ID)


                rpt.Load(strruta)
                rpt.SetDataSource(mids)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


        If Tabla = "Embarazo_Sangre" Then
            ID = Ids

            Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
            Dim ta As New SystemLetonaDataSetTableAdapters.Embarazo_SangreTableAdapter
            Dim ta2 As New SystemLetonaDataSetTableAdapters.Embarazo_SangreTableAdapter


            Try

                ta.FillByMuestra(mids.Embarazo_Sangre, ID)


                rpt.Load(strruta)
                rpt.SetDataSource(mids)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


        If Tabla = "FSP" Then
            ID = Ids

            Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
            Dim ta As New SystemLetonaDataSetTableAdapters.FSPTableAdapter
            Dim ta2 As New SystemLetonaDataSetTableAdapters.FSPTableAdapter


            Try

                ta.FillByMuestra(mids.FSP, ID)


                rpt.Load(strruta)
                rpt.SetDataSource(mids)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


        If Tabla = "Heces" Then
            ID = Ids

            Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
            Dim ta As New SystemLetonaDataSetTableAdapters.HecesTableAdapter
            Dim ta2 As New SystemLetonaDataSetTableAdapters.HecesTableAdapter


            Try

                ta.FillByMuestra(mids.Heces, ID)


                rpt.Load(strruta)
                rpt.SetDataSource(mids)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


        If Tabla = "Hematologia" Then
            ID = Ids

            Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
            Dim ta As New SystemLetonaDataSetTableAdapters.HematologiaTableAdapter
            Dim ta2 As New SystemLetonaDataSetTableAdapters.HematologiaTableAdapter


            Try

                ta.FillByMuestra(mids.Hematologia, ID)


                rpt.Load(strruta)
                rpt.SetDataSource(mids)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


        If Tabla = "HPilory_Heces" Then
            ID = Ids

            Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
            Dim ta As New SystemLetonaDataSetTableAdapters.HPilory_HecesTableAdapter
            Dim ta2 As New SystemLetonaDataSetTableAdapters.HPilory_HecesTableAdapter


            Try

                ta.FillByMuestra(mids.HPilory_Heces, ID)


                rpt.Load(strruta)
                rpt.SetDataSource(mids)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


        If Tabla = "HPilory_Sangre" Then
            ID = Ids

            Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
            Dim ta As New SystemLetonaDataSetTableAdapters.HPilory_SangreTableAdapter
            Dim ta2 As New SystemLetonaDataSetTableAdapters.HPilory_SangreTableAdapter


            Try

                ta.FillByMuestra(mids.HPilory_Sangre, ID)


                rpt.Load(strruta)
                rpt.SetDataSource(mids)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If Tabla = "Orina" Then
            ID = Ids

            Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
            Dim ta As New SystemLetonaDataSetTableAdapters.OrinaTableAdapter
            Dim ta2 As New SystemLetonaDataSetTableAdapters.OrinaTableAdapter


            Try

                ta.FillByMuestra(mids.Orina, ID)


                rpt.Load(strruta)
                rpt.SetDataSource(mids)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

        If Tabla = "PEspeciales" Then
            ID = Ids

            Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
            Dim ta As New SystemLetonaDataSetTableAdapters.PEspecialesTableAdapter
            Dim ta2 As New SystemLetonaDataSetTableAdapters.PEspecialesTableAdapter


            Try

                ta.FillByMuestra(mids.PEspeciales, ID)


                rpt.Load(strruta)
                rpt.SetDataSource(mids)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


        If Tabla = "Quimica_Sanguinea" Then
            ID = Ids

            Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
            Dim ta As New SystemLetonaDataSetTableAdapters.Quimica_SanguineaTableAdapter
            Dim ta2 As New SystemLetonaDataSetTableAdapters.Quimica_SanguineaTableAdapter


            Try

                ta.FillByMuestra(mids.Quimica_Sanguinea, ID)


                rpt.Load(strruta)
                rpt.SetDataSource(mids)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub
End Class