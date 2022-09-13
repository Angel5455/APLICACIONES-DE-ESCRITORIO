Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class F_Prescripcion
    Public WithEvents Query As New DPrescripcion
    Dim ConexionLINQ As New DataClasses1DataContext()
    Dim ruta As String = ""
    Dim rpt As New ReportDocument
    Dim prmdatos As ParameterField
    Private Sub F_Prescripcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SystemLetonaDataSet.Prescripcion' Puede moverla o quitarla según sea necesario.
        Me.PrescripcionTableAdapter.Fill(Me.SystemLetonaDataSet.Prescripcion)
        ' estilo para las cabeceras
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle With {
            .BackColor = Color.DarkCyan,
            .ForeColor = Color.GhostWhite,
            .Font = New Font("Comic Sans MS", 14, FontStyle.Italic Or
        FontStyle.Bold)
        }

        ' asignar estilo al grid
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = styCabeceras

        Consulta()
    End Sub

    Public Sub Consulta()

        Dim constr As String

        constr = Conexion.Cadena

        Dim con As New SqlConnection(constr)

        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("Select * from Prescripcion", con)



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

    Private Sub TxtBuscarPacientes_OnTextChange(sender As Object, e As EventArgs) Handles TxtBuscarPacientes.OnTextChange
        Query.Buscar_Receta(DataGridView1, TxtBuscarPacientes.text)
    End Sub

    Private Sub TxtBuscarPacientes_Enter(sender As Object, e As EventArgs) Handles TxtBuscarPacientes.Enter
        If (TxtBuscarPacientes.text = "Buscar Pacientes") Then

            TxtBuscarPacientes.text = ""

        End If
    End Sub

    Private Sub TxtBuscarPacientes_LocationChanged(sender As Object, e As EventArgs) Handles TxtBuscarPacientes.LocationChanged
        If (TxtBuscarPacientes.text = "") Then


            TxtBuscarPacientes.text = "Buscar Pacientes"


        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click


        F_Receta.Text = "Agregar Receta"


        F_Receta.ShowDialog()

        Me.Close()


    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click


        Dim Paciente As String = DataGridView1.SelectedCells(1).Value.ToString()

        If (Paciente = "") Then

            MsgBox("Seleccione una Fila", MsgBoxStyle.Exclamation, "Información")



        Else

            F_Receta.LblId.Text = DataGridView1.SelectedCells(0).Value.ToString()
            F_Receta.TxtPaciente.Text = DataGridView1.SelectedCells(1).Value.ToString()
            F_Receta.TxtFecha.Text = DataGridView1.SelectedCells(2).Value.ToString()
            F_Receta.TxtHistoria.Text = DataGridView1.SelectedCells(3).Value.ToString()
            F_Receta.TxtMedicacion.Text = DataGridView1.SelectedCells(4).Value.ToString()
            F_Receta.TxtNota.Text = DataGridView1.SelectedCells(5).Value.ToString()

            F_Receta.Text = "Editar Receta"
            F_Receta.ShowDialog()
            Me.Close()

        End If
    End Sub

    Private Sub IconCerrar_Click(sender As Object, e As EventArgs) Handles IconCerrar.Click
        Me.Close()

    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click


        Dim Id As String = DataGridView1.SelectedCells(0).Value.ToString()

        If (Id = "") Then

            MsgBox("Seleccione una Fila", MsgBoxStyle.Exclamation, "Información")



        Else

            Dim resp As String

            resp = MsgBox("¿Desea Imprimir la Receta?", MsgBoxStyle.YesNo, "Consultorio Letona")


            If resp = 6 Then

                ruta = "C:\CrysReceta.rpt"

                LlenarDsReporteReceta(ruta) : R_Receta.CrystalReportViewer1.ReportSource = rpt : R_Receta.Show()



            End If

        End If


    End Sub

    Private Sub LlenarDsReporteReceta(ByVal strruta As String)
        Dim Id As String = DataGridView1.SelectedCells(0).Value.ToString()
        Dim mids As SystemLetonaDataSet = New SystemLetonaDataSet
        Dim ta As New SystemLetonaDataSetTableAdapters.PrescripcionTableAdapter

        Try

            ta.FillById(mids.Prescripcion, Id)

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

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim resp As String = MsgBox("¿Desea Eliminar el Registro?", MsgBoxStyle.YesNo, "Consultorio Letona")

        If resp = 6 Then

            Dim Id As Integer = DataGridView1.SelectedCells(0).Value.ToString()

            Call Query.Eliminar_Receta(Id)
            Query.Buscar_Receta(DataGridView1, "")
            MsgBox("Receta Eliminada con exito", MsgBoxStyle.Information, "Consultorio Letona")

        End If
    End Sub
End Class