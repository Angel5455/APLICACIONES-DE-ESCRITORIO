﻿Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class F_Heces

    Dim Rruta As String = ""
    Dim rpt As New ReportDocument
    Dim prmdatos As ParameterField
    Dim ID As String
    Public WithEvents Query As New DHeces
    Dim ConexionLINQ As New DataClasses1DataContext()
    Private Sub F_Heces_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblId.Text = Query.Id() + 1
        TxtMuestra.Text = LblId.Text
    End Sub

    Sub Limpiar()

        TxtPaciente.BackColor = Color.White
        TxtIdentidad.BackColor = Color.White
        TxtEdad.BackColor = Color.White
        TxtSexo.BackColor = Color.White
        TxtMuestra.BackColor = Color.White
        TxtPaciente.Clear()
        TxtEdad.Clear()
        TxtSexo.Text = ""
        TxtIdentidad.Clear()
        TxtReferencia.Text = ""
        TxtAspecto.Clear()
        TxtConsistencia.Clear()
        TxtColor.Clear()
        TxtMoco.Clear()
        TxtSangre.Clear()
        TxtObservacion.Clear()
        LblId.Text = Query.Id() + 1
        TxtMuestra.Text = LblId.Text

    End Sub

    Private Sub TxtEdad_TextChanged(sender As Object, e As EventArgs) Handles TxtEdad.TextChanged

    End Sub

    Private Sub TxtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdad.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtSexo.Focus()

        End If
    End Sub


    Private Sub TxtPaciente_TextChanged(sender As Object, e As EventArgs) Handles TxtPaciente.TextChanged

    End Sub

    Private Sub TxtPaciente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPaciente.KeyPress

        If Asc(e.KeyChar) = 13 Then

            TxtEdad.Focus()

        End If
    End Sub

    Private Sub TxtSexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtSexo.SelectedIndexChanged

    End Sub

    Private Sub TxtSexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSexo.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtIdentidad.Focus()

        End If
    End Sub

    Private Sub TxtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles TxtIdentidad.TextChanged

    End Sub

    Private Sub TxtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdentidad.KeyPress
        If Asc(e.KeyChar) = 13 Then

            Dim encontrado As Boolean
            Dim xConsulta As New SqlDataAdapter("select * from Pacientes where Identidad = '" & TxtIdentidad.Text & "'", Conexion.Conexion)
            Dim ds As New DataSet
            xConsulta.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then

                'txtDescripcion.BackColor = Color.White

                encontrado = True

                TxtPaciente.Text = ds.Tables(0).Rows(0).Item("Paciente").ToString
                TxtSexo.Text = ds.Tables(0).Rows(0).Item("Sexo").ToString
                TxtEdad.Text = ds.Tables(0).Rows(0).Item("Edad").ToString

                TxtFecha.Focus()


            Else

                encontrado = False


                MsgBox("Paciente sin Registrar", MsgBoxStyle.Critical, "Error")
                TxtPaciente.Text = ""
                TxtSexo.Text = ""
                TxtEdad.Text = ""

                TxtEdad.Focus()
            End If



        End If
    End Sub

    Private Sub TxtMuestra_TextChanged(sender As Object, e As EventArgs) Handles TxtMuestra.TextChanged

    End Sub

    Private Sub TxtMuestra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMuestra.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtFecha.Focus()

        End If
    End Sub

    Private Sub TxtFecha_ValueChanged(sender As Object, e As EventArgs) Handles TxtFecha.ValueChanged

    End Sub

    Private Sub TxtFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFecha.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtAspecto.Focus()

        End If
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click

        If TxtPaciente.Text = "" Or TxtEdad.Text = "" Or TxtSexo.Text = "" Or TxtMuestra.Text = "" Then
            If TxtPaciente.Text = "" Then
                TxtPaciente.BackColor = Color.Yellow
                TxtPaciente.Focus()
            End If
            If TxtEdad.Text = "" Then
                TxtEdad.BackColor = Color.Yellow
                TxtEdad.Focus()
            End If
            If TxtSexo.Text = "" Then
                TxtSexo.BackColor = Color.Yellow
                TxtSexo.Focus()
            End If
            If TxtMuestra.Text = "" Then
                TxtMuestra.BackColor = Color.Yellow
                TxtMuestra.Focus()
            End If
            MsgBox("Llene los campos obligatorios de color amarillo", MsgBoxStyle.Exclamation, "Campos Vacios")
        Else

            If TxtAspecto.Text = "" Then
                TxtAspecto.Text = " "
            End If
            If TxtConsistencia.Text = "" Then
                TxtConsistencia.Text = " "
            End If
            If TxtColor.Text = "" Then
                TxtColor.Text = " "
            End If
            If TxtMoco.Text = "" Then
                TxtMoco.Text = " "
            End If
            If TxtSangre.Text = "" Then
                TxtSangre.Text = " "
            End If
            If TxtObservacion.Text = "" Then
                TxtObservacion.Text = " "
            End If

            Call Query.Guardar_Examen(TxtIdentidad.Text, TxtPaciente.Text, TxtEdad.Text, TxtSexo.Text, TxtReferencia.Text, TxtMuestra.Text, TxtFecha.Text, TxtAspecto.Text, TxtConsistencia.Text, TxtColor.Text, TxtMoco.Text, TxtSangre.Text, TxtObservacion.Text)
            MessageBox.Show("Los Datos fueron agregados con exito", "Datos Guardados...")

            Imprimir_Examen(LblId.Text)


            Limpiar()



        End If


    End Sub

    Private Sub LlenarDsReporteExamen(ByVal strruta As String, ByVal Ids As String)

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

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Imprimir_Examen(TextBox1.Text)

    End Sub

    Sub Imprimir_Examen(ByVal Id As String)
        Dim resp As String

        resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


        If resp = 6 Then

            Rruta = "C:\SystemLetona\CrysHeces.rpt"

            LlenarDsReporteExamen(Rruta, Id) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


        End If
    End Sub

    Private Sub TxtAspecto_TextChanged(sender As Object, e As EventArgs) Handles TxtAspecto.TextChanged

    End Sub

    Private Sub TxtAspecto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAspecto.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtConsistencia.Focus()

        End If
    End Sub

    Private Sub TxtConsistencia_TextChanged(sender As Object, e As EventArgs) Handles TxtConsistencia.TextChanged

    End Sub

    Private Sub TxtConsistencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtConsistencia.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtColor.Focus()

        End If
    End Sub

    Private Sub TxtColor_TextChanged(sender As Object, e As EventArgs) Handles TxtColor.TextChanged

    End Sub

    Private Sub TxtColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtColor.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtMoco.Focus()

        End If
    End Sub

    Private Sub TxtMoco_TextChanged(sender As Object, e As EventArgs) Handles TxtMoco.TextChanged

    End Sub

    Private Sub TxtMoco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMoco.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtSangre.Focus()

        End If
    End Sub

    Private Sub TxtSangre_TextChanged(sender As Object, e As EventArgs) Handles TxtSangre.TextChanged

    End Sub

    Private Sub TxtSangre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSangre.KeyPress
        If Asc(e.KeyChar) = 13 Then

            TxtObservacion.Focus()

        End If
    End Sub

    Private Sub TxtReferencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtReferencia.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Imprimir_Examen(TextBox1.Text)
    End Sub

    Private Sub F_Heces_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()
    End Sub
End Class