Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data


Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows

Public Class F_Empleados

    Dim WithEvents queryconsultas As New dEmpleados

    Dim conexion As New DataClasses1DataContext()
    Dim query

    Dim encontrado As Boolean

    Public accion As Boolean
    Dim resultado As MsgBoxResult

    Dim ruta As String = ""
    Dim rpt As New ReportDocument
    Public fecha1 As Date : Dim strfecha1 As String
    Public fecha2 As Date : Dim strfecha2 As String
    Dim prmdatos As ParameterField

    Dim seleccion As String



    Sub limpiar()

        '   txtcodigo.Text = My.Settings.MyCodigo + 1
        txtnombre.Text = ""
        txtcodigo.Text = ""
    End Sub



   



    Private Sub F_Empleados_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        btnGuardar.Enabled = True
        btnEliminar.Enabled = False

    End Sub

    Private Sub F_Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        btnGuardar.Enabled = True
        btnEliminar.Enabled = False
        btnModificar.Enabled = False

        txtnombre.Focus()

     
    End Sub



    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

 
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        btnGuardar.Enabled = True
        btnEliminar.Enabled = False

        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

      
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

       

    End Sub

   
    Sub bloquear()

        txtnombre.Enabled = False
        txtcodigo.Enabled = False


    End Sub

    Sub desbloquear()

        txtnombre.Enabled = True
        txtcodigo.Enabled = True

    End Sub

    Private Sub txtnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub



    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtContraseña_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtContraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

  
 

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        F_BuscarE.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnGuardar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Call queryconsultas.insertar_empleado(txtcodigo.Text, txtnombre.Text)
        limpiar()

    End Sub

  
    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click


        Dim resp As String = MsgBox("¿Desea Eliminar el Registro?", MsgBoxStyle.YesNo, "CREATIVOS")

        If resp = 6 Then

            Call queryconsultas.Eliminar_empleados(txtcodigo.Text)
            limpiar()



        End If

        limpiar()
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False


    End Sub

    Private Sub btnModificar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Call queryconsultas.modificar_empleados(txtcodigo.Text, txtnombre.Text)
        limpiar()

        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False

    End Sub

    Private Sub txtcodigo_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles txtcodigo.MaskInputRejected

    End Sub

    Private Sub txtcodigo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtcodigo.Validating
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("select * from Empleados where Codigo ='" & txtcodigo.Text & "'", con)

        '   Dim xConsulta As New SqlDataAdapter("select * from Inventario where Codigo = '" & txtcodigo.Text & "'", conexion.Inventario)
        '  Dim ds As New DataSet
        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then

            txtnombre.BackColor = Color.White

            encontrado = True

            txtnombre.Text = ds.Tables(0).Rows(0).Item("Nombre").ToString
         

            btnGuardar.Enabled = False
            btnModificar.Enabled = True
            btnEliminar.Enabled = True

        Else

            encontrado = False

            btnGuardar.Enabled = True
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
            txtnombre.Enabled = True
            txtnombre.Focus()


            '   MsgBox("No se encuentra los datos del Empleado, no se puede llenar la ficha", MsgBoxStyle.Critical, "Error")
            txtnombre.Text = ""
            'txtprecio.Text = ""



        End If
    End Sub
End Class