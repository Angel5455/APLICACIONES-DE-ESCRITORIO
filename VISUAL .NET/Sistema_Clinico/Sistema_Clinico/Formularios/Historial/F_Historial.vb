Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class F_Historial
    Public WithEvents QueryPaciente As New Dpacientes
    Public WithEvents QueryPrescripcion As New DPrescripcion
    Public WithEvents QueryDocumento As New DDocumentos
    Dim ConexionLINQ As New DataClasses1DataContext()
    Dim Id As Integer
    Dim Paciente As String
    Dim Identidad As String
    Dim Telefono As String
    Dim Email As String
    Dim Direccion As String
    Dim Edad As Integer
    Dim Sexo As String
    Dim Fecha_Nacimiento As Date
    Public Ruta As String = My.Settings.Ruta

    Dim Rruta As String = ""
    Dim rpt As New ReportDocument
    Dim prmdatos As ParameterField

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub F_Historial_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim Conexion As New CConexion
        Dim Sql As New DataSet
        Identidad = My.Settings.MyIdentidad

        Sql = Conexion.Consultar("SELECT * FROM Pacientes WHERE Identidad='" & Identidad & "'")



        Paciente = Sql.Tables(0).Rows(0).Item("Paciente")
        Identidad = Sql.Tables(0).Rows(0).Item("Identidad")
        Email = Sql.Tables(0).Rows(0).Item("Email")
        Direccion = Sql.Tables(0).Rows(0).Item("Direccion")
        Telefono = Sql.Tables(0).Rows(0).Item("Telefono")
        Fecha_Nacimiento = Sql.Tables(0).Rows(0).Item("Fecha_Nacimiento")
        Edad = Sql.Tables(0).Rows(0).Item("Edad")
        Sexo = Sql.Tables(0).Rows(0).Item("Sexo")


        LblPaciente.Text = Paciente

        'DataGridView1.SelectedCells(1).Value.ToString()
        Consulta()


    End Sub

    Private Sub IconCerrar_Click(sender As Object, e As EventArgs) Handles IconCerrar.Click


        My.Settings.MySexo = ""
        My.Settings.MyTelefono = ""
        My.Settings.MyEdad = ""
        My.Settings.MyPaciente = ""
        My.Settings.Ruta = ""
        My.Settings.Save()
        My.Settings.Reload()

        Me.Close()
        Form1.Show()

    End Sub



    Public Sub Consulta()

        Dim constr As String

        constr = Conexion.Cadena

        Dim con As New SqlConnection(constr)

        Dim tabla, tabla2, tabladoc, tablap As New DataTable

        Dim da As New SqlDataAdapter("Select Codigo_Historial, Paciente, Fecha, Motivo_Consulta from Historial Where Paciente like'" & LblPaciente.Text & "'", con)
        'Dim da2 As New SqlDataAdapter("Select * from Pacientes Where Paciente like'" & LblPaciente.Text & "'", con)
        Dim dadoc As New SqlDataAdapter("Select Id, Paciente, Descripcion, Fecha from Documentos Where Paciente like'" & LblPaciente.Text & "'", con)
        Dim dap As New SqlDataAdapter("Select Id, Paciente, Fecha from Prescripcion Where Paciente like'" & LblPaciente.Text & "'", con)



        Try


            da.Fill(tabla)
            'da2.Fill(tabla2)
            dadoc.Fill(tabladoc)
            dap.Fill(tablap)

            DataGridView1.DataSource = tabla

            DataGridView2.DataSource = tabladoc
            DataGridView3.DataSource = tablap



            Dim fila As Integer
            fila = DataGridView1.RowCount - 1



        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing

            da = Nothing

            'da2 = Nothing

            dadoc = Nothing

            dap = Nothing

            tabla = Nothing

            tabla2 = Nothing

            tabladoc = Nothing

            tablap = Nothing
        End Try



        If Ruta = "Historial" Then
            My.Settings.MyEdad = Edad
            My.Settings.MyIdentidad = Identidad
            My.Settings.MyTelefono = Telefono
            My.Settings.MySexo = Sexo

            My.Settings.Save()
            My.Settings.Reload()

        ElseIf Ruta = "AgregarH" Or Ruta = "EditarH" Or Ruta = "AgregarDoc" Then

            My.Settings.MyEdad = ""
            My.Settings.MyIdentidad = ""
            My.Settings.MyTelefono = ""
            My.Settings.MySexo = ""

            My.Settings.Save()
            My.Settings.Reload()

        End If


    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click



        My.Settings.MyIdentidad = Identidad
        My.Settings.MyTelefono = Telefono
        My.Settings.MyEdad = Edad

        F_AgregarHistorial.TxtPaciente.Text = LblPaciente.Text

        F_AgregarHistorial.ShowDialog()

    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click

        'Dim Codigo As String = DataGridView1.SelectedCells(0).Value.ToString()

        'Imprimir Directo a la impresora

        'My.Settings.MyPaciente = "LETONA Ramon"
        'My.Settings.Save()
        'My.Settings.Reload()

        'I_Historial.Show()

        Dim resp As String

        resp = MsgBox("¿Desea Imprimir el Historial Medico?", MsgBoxStyle.YesNo, "Consultorio Letona")


        If resp = 6 Then

            Rruta = "C:\SystemLetona\CrysHistorial.rpt"

            LlenarDsReporteHistorial(Rruta) : R_Historial.CrystalReportViewer1.ReportSource = rpt : R_Historial.Show()


        End If

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        F_AgregarHistorial.Text = "Editar Historial de Pacientes"


        If (LblPaciente.Text = "") Then

            MsgBox("Seleccione una Fila", MsgBoxStyle.Exclamation, "Información")



        Else

            F_AgregarHistorial.LblOpcion.Text = "Editar Historial"

            F_AgregarHistorial.Codigo = DataGridView1.SelectedCells(0).Value.ToString()

            F_AgregarHistorial.ShowDialog()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        MsgBox("Función no disponible", MsgBoxStyle.Exclamation, "Sistema Consultorio Letona")
    End Sub

    Private Sub BtnNuevoDoc_Click(sender As Object, e As EventArgs) Handles BtnNuevoDoc.Click
        F_AgregarDocumentos.TxtPaciente.Text = LblPaciente.Text
        F_AgregarDocumentos.LblOpcion.Text = "Agregar"

        F_AgregarDocumentos.ShowDialog()
    End Sub

    Private Sub BtnEditarDoc_Click(sender As Object, e As EventArgs) Handles BtnEditarDoc.Click
        Dim Paciente As String = DataGridView2.SelectedCells(1).Value.ToString()

        If (Paciente = "") Then

            MsgBox("Seleccione una Fila", MsgBoxStyle.Exclamation, "Información")



        Else

            F_AgregarDocumentos.Text = "Editar Documentos"
            F_AgregarDocumentos.LblId.Text = DataGridView2.SelectedCells(0).Value.ToString()



            F_AgregarDocumentos.LblOpcion.Text = "Editar"
            F_AgregarDocumentos.ShowDialog()

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick

    End Sub

    Private Sub LlenarDsReporteHistorial(ByVal strruta As String)
        Dim CH As String = DataGridView1.SelectedCells(0).Value.ToString()
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



    Private Sub PanelHeader_Paint(sender As Object, e As PaintEventArgs) Handles PanelHeader.Paint

    End Sub

    Private Sub PanelHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BtnEditarReceta_Click(sender As Object, e As EventArgs) Handles BtnEditarReceta.Click



        If (LblPaciente.Text = "") Then

            MsgBox("Seleccione una Fila", MsgBoxStyle.Exclamation, "Información")



        Else

            F_Receta.Text = "Editar Receta - Historial"

            F_Receta.LblId.Text = DataGridView3.SelectedCells(0).Value.ToString()

            F_Receta.ShowDialog()

        End If
    End Sub

    Private Sub BtnEliminarDocumento_Click(sender As Object, e As EventArgs) Handles BtnEliminarDocumento.Click
        Dim resp As String = MsgBox("¿Desea Eliminar el Registro?", MsgBoxStyle.YesNo, "Consultorio Letona")

        If resp = 6 Then

            Dim Id As Integer = DataGridView2.SelectedCells(0).Value.ToString()

            Call QueryDocumento.Eliminar_Documento(Id)
            QueryDocumento.Buscar_Documento(DataGridView1, "")
            MsgBox("Documento Eliminado con exito", MsgBoxStyle.Information, "Consultorio Letona")

        End If
    End Sub

    Private Sub BtnEliminarReceta_Click(sender As Object, e As EventArgs) Handles BtnEliminarReceta.Click
        Dim resp As String = MsgBox("¿Desea Eliminar el Registro?", MsgBoxStyle.YesNo, "Consultorio Letona")

        If resp = 6 Then

            Dim Id As Integer = DataGridView3.SelectedCells(0).Value.ToString()

            Call QueryPrescripcion.Eliminar_Receta(Id)
            QueryDocumento.Buscar_Documento(DataGridView1, "")
            MsgBox("Receta Eliminada con exito", MsgBoxStyle.Information, "Consultorio Letona")

        End If
    End Sub
End Class