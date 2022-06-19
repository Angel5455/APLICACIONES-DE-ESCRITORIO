Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class F_FSP

    Dim Rruta As String = ""
    Dim rpt As New ReportDocument
    Dim prmdatos As ParameterField
    Dim ID As String
    Public WithEvents Query As New DFSP
    Dim ConexionLINQ As New DataClasses1DataContext()

    Private Sub F_FSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblId.Text = Query.Id() + 1
        TxtMuestra.Text = LblId.Text
    End Sub

    Private Sub TxtPaciente_TextChanged(sender As Object, e As EventArgs) Handles TxtPaciente.TextChanged

    End Sub

    Private Sub TxtPaciente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPaciente.KeyPress

        If Asc(e.KeyChar) = 13 Then

            TxtMuestra.Focus()

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

            TxtSerieRoja.Focus()

        End If
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

    Private Sub TxtSerieRoja_TextChanged(sender As Object, e As EventArgs) Handles TxtSerieRoja.TextChanged

    End Sub

    Private Sub TxtSerieRoja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSerieRoja.KeyPress

        If Asc(e.KeyChar) = 13 Then

            TxtSerieBlanca.Focus()

        End If
    End Sub

    Private Sub TxtSerieBlanca_TextChanged(sender As Object, e As EventArgs) Handles TxtSerieBlanca.TextChanged

    End Sub

    Private Sub TxtSerieBlanca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSerieBlanca.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtNeu.Focus()

        End If
    End Sub

    Private Sub TxtNeu_TextChanged(sender As Object, e As EventArgs) Handles TxtNeu.TextChanged

    End Sub

    Private Sub TxtNeu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNeu.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtEo.Focus()

        End If
    End Sub

    Private Sub TxtEo_TextChanged(sender As Object, e As EventArgs) Handles TxtEo.TextChanged

    End Sub

    Private Sub TxtEo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEo.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtBaso.Focus()

        End If
    End Sub

    Private Sub TxtBaso_TextChanged(sender As Object, e As EventArgs) Handles TxtBaso.TextChanged

    End Sub

    Private Sub TxtBaso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBaso.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtMono.Focus()

        End If
    End Sub

    Private Sub TxtMono_TextChanged(sender As Object, e As EventArgs) Handles TxtMono.TextChanged

    End Sub

    Private Sub TxtMono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMono.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtLinfo.Focus()

        End If
    End Sub

    Private Sub TxtLinfo_TextChanged(sender As Object, e As EventArgs) Handles TxtLinfo.TextChanged

    End Sub

    Private Sub TxtLinfo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLinfo.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            TxtSeriePlaquetaria.Focus()

        End If
    End Sub

    Private Sub TxtSeriePlaquetaria_TextChanged(sender As Object, e As EventArgs) Handles TxtSeriePlaquetaria.TextChanged

    End Sub

    Private Sub TxtSeriePlaquetaria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSeriePlaquetaria.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

        If Asc(e.KeyChar) = 13 Then

            BtnEnviar.Focus()

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

            If TxtSerieBlanca.Text = "" Then
                TxtSerieBlanca.Text = " "
            End If
            If TxtSerieRoja.Text = "" Then
                TxtSerieRoja.Text = " "
            End If
            If TxtSeriePlaquetaria.Text = "" Then
                TxtSeriePlaquetaria.Text = " "
            End If
            If TxtNeu.Text = "" Then
                TxtNeu.Text = " "
            End If
            If TxtEo.Text = "" Then
                TxtEo.Text = " "
            End If
            If TxtBaso.Text = "" Then
                TxtBaso.Text = " "
            End If
            If TxtMono.Text = "" Then
                TxtMono.Text = " "
            End If
            If TxtLinfo.Text = "" Then
                TxtLinfo.Text = " "
            End If

            Call Query.Guardar_Examen(TxtIdentidad.Text, TxtPaciente.Text, TxtEdad.Text, TxtSexo.Text, TxtReferencia.Text, TxtMuestra.Text, TxtFecha.Text, TxtSerieRoja.Text, TxtSerieBlanca.Text, TxtNeu.Text, TxtEo.Text, TxtBaso.Text, TxtMono.Text, TxtLinfo.Text, TxtSeriePlaquetaria.Text)
            MessageBox.Show("Los Datos fueron agregados con exito", "Datos Guardados...")

            Imprimir_Examen(LblId.Text)


            Limpiar()



        End If


    End Sub

    Sub Imprimir_Examen(ByVal Id As String)
        Dim resp As String

        resp = MsgBox("¿Desea Imprimir el Diagnostico?", MsgBoxStyle.YesNo, "L C L")


        If resp = 6 Then

            Rruta = "C:\SystemLetona\CrysFSP.rpt"

            LlenarDsReporteExamen(Rruta, Id) : R_Reportes.CrystalReportViewer1.ReportSource = rpt : R_Reportes.Show()


        End If
    End Sub

    Private Sub LlenarDsReporteExamen(ByVal strruta As String, ByVal Ids As String)

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

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Imprimir_Examen(TextBox1.Text)
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
        TxtSerieBlanca.Clear()
        TxtSerieRoja.Clear()
        TxtSeriePlaquetaria.Clear()
        TxtNeu.Clear()
        TxtEo.Clear()
        TxtBaso.Clear()
        TxtMono.Clear()
        TxtLinfo.Clear()
        LblId.Text = Query.Id() + 1
        TxtMuestra.Text = LblId.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Imprimir_Examen(TextBox1.Text)
    End Sub

    Private Sub F_FSP_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()
    End Sub
End Class