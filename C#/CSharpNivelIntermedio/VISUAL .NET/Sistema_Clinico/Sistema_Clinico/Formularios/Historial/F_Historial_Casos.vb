Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class F_Historial_Casos

    Public Paciente As String
    Dim Codigo As String

    Dim Rruta As String = ""
    Dim rpt As New ReportDocument
    Dim prmdatos As ParameterField
    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click


        'My.Settings.MyPaciente = "LETONA Ramon"
        'My.Settings.Save()
        'My.Settings.Reload()

        'I_Historial.Show()

        Dim resp As String

        resp = MsgBox("¿Desea Imprimir el Historial Médico?", MsgBoxStyle.YesNo, "Sistema Consultorio Letona")


        If resp = 6 Then

            Rruta = "C:\SystemLetona\CrysHistorial.rpt"

            LlenarDsReporteHistorial(Rruta) : R_Historial.CrystalReportViewer1.ReportSource = rpt : R_Historial.Show()



        End If

    End Sub

    Private Sub TxtBuscarPacientes_OnTextChange(sender As Object, e As EventArgs) Handles TxtBuscarPacientes.OnTextChange

        If (TxtBuscarPacientes.text = "Buscar Pacientes" Or TxtBuscarPacientes.text = "") Then
            Dim constr As String

            constr = Conexion.Cadena



            Dim con As New SqlConnection(constr)

            Dim tabla, tabla2 As New DataTable

            Dim da As New SqlDataAdapter("Select * from Historial Where Paciente like'%" & "" & "%'", con)



            Try


                da.Fill(tabla)


                DataGridView1.DataSource = tabla


                Dim fila As Integer
                fila = DataGridView1.RowCount - 1



            Catch ex As Exception
                MsgBox(ex.Message)

            Finally

                con = Nothing

                da = Nothing


                tabla = Nothing


            End Try

        Else
            Dim constr As String

            constr = Conexion.Cadena



            Dim con As New SqlConnection(constr)

            Dim tabla, tabla2 As New DataTable

            Dim da As New SqlDataAdapter("Select * from Historial Where Paciente like'%" & TxtBuscarPacientes.text & "%'", con)



            Try


                da.Fill(tabla)


                DataGridView1.DataSource = tabla


                Dim fila As Integer
                fila = DataGridView1.RowCount - 1



            Catch ex As Exception
                MsgBox(ex.Message)

            Finally

                con = Nothing

                da = Nothing


                tabla = Nothing


            End Try


        End If


    End Sub

    Private Sub F_Historial_Casos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SystemLetonaDataSet.Historial' Puede moverla o quitarla según sea necesario.
        Me.HistorialTableAdapter.Fill(Me.SystemLetonaDataSet.Historial)

    End Sub

    Private Sub TxtBuscarPacientes_Enter(sender As Object, e As EventArgs) Handles TxtBuscarPacientes.Enter
        If (TxtBuscarPacientes.text = "Buscar Pacientes") Then

            TxtBuscarPacientes.text = ""

        End If
    End Sub

    Private Sub TxtBuscarPacientes_Leave(sender As Object, e As EventArgs) Handles TxtBuscarPacientes.Leave
        If (TxtBuscarPacientes.text = "") Then


            TxtBuscarPacientes.text = "Buscar Pacientes"


        End If
    End Sub

    Private Sub IconCerrar_Click(sender As Object, e As EventArgs) Handles IconCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        My.Settings.Ruta = "HistorialCasos"
        My.Settings.Save()
        My.Settings.Reload()

        F_AgregarHistorial.Text = "Editar Historial de Pacientes"


        If (TxtBuscarPacientes.text = "") Then

            MsgBox("Seleccione una Fila", MsgBoxStyle.Exclamation, "Información")



        Else

            F_AgregarHistorial.LblOpcion.Text = "Editar Historial"

            F_AgregarHistorial.Codigo = DataGridView1.SelectedCells(1).Value.ToString()

            F_AgregarHistorial.ShowDialog()
            Me.Close()


        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Public Sub Consulta()
        Dim constr As String

        constr = Conexion.Cadena



        Dim con As New SqlConnection(constr)

        Dim tabla, tabla2 As New DataTable

        Dim da As New SqlDataAdapter("Select * from Historial Where Paciente like'%" & "" & "%'", con)



        Try


            da.Fill(tabla)


            DataGridView1.DataSource = tabla


            Dim fila As Integer
            fila = DataGridView1.RowCount - 1



        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing

            da = Nothing


            tabla = Nothing


        End Try
    End Sub

    Private Sub LlenarDsReporteHistorial(ByVal strruta As String)
        Dim CH As String = DataGridView1.SelectedCells(1).Value.ToString()
        Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
        Dim ta As New SystemLetonaDataSetTableAdapters.HistorialTableAdapter

        Try

            ta.FillByCH(mids.Historial, CH)

            rpt.Load(strruta)
            rpt.SetDataSource(mids)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TxtBuscarPacientes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBuscarPacientes.KeyPress
        ' Matriz de caracteres que deseamos controlar
        '
        Dim caracteres() As Char = {"%"c, "&"c, "$"c, "#"c, "/"c, "-"c, "_"c}

        ' Carácter presionado
        '
        Dim c As Char = e.KeyChar

        ' Comprobamos si la matriz contiene el carácter tecleado.
        '
        If caracteres.Contains(c) Then

            MessageBox.Show("Se ha tecleado un carácter especial.")

            ' Deshechamos el carácter
            e.Handled = True

        End If
    End Sub
End Class