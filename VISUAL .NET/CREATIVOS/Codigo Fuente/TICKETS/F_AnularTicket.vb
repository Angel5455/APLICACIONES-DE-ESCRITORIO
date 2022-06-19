Imports System.Data.Sql
Imports System.Data.SqlClient



Public Class F_AnularTicket

    Dim WithEvents queryconsultas As New dTickets

    Dim conexion As New DataClasses1DataContext()

    Dim encontrado As Boolean

    Public accion As Boolean
    Dim resultado As MsgBoxResult

    Private Sub F_AnularTicket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnGuardar.Enabled = False
        btnSalir.Enabled = False


    End Sub

    Private Sub txtTicket_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTicket.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If

        btnSalir.Enabled = True
    End Sub



    

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Call queryconsultas.modificar_ticket(txtTicket.Text, lblfecha.Text, lblNombre.Text, lblTotal.Text, lblMes.Text, lblHora.Text)
        limpiar()
        lblAnulado.Visible = False
        btnSalir.Enabled = True




            End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        lblTotal.Text = 0
        lblAnulado.Visible = True
        btnGuardar.Enabled = True
        btnSalir.Enabled = False



    End Sub

    Sub limpiar()
        txtTicket.Text = ""
        lblfecha.Text = ""
        lblNombre.Text = ""
        lblMes.Text = ""
        lblHora.Text = ""
        lblTotal.Text = ""
    End Sub

    Private Sub txtTicket_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTicket.TextChanged

    End Sub

    Private Sub txtTicket_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTicket.Validating
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("select * from  Tickets where Ticket ='" & txtTicket.Text & "'", con)

        '   Dim xConsulta As New SqlDataAdapter("select * from Inventario where Codigo = '" & txtcodigo.Text & "'", conexion.Inventario)
        '  Dim ds As New DataSet
        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then

            'txtDescripcion.BackColor = Color.White

            encontrado = True

            lblNombre.Text = ds.Tables(0).Rows(0).Item("Nombre").ToString
            lblfecha.Text = ds.Tables(0).Rows(0).Item("Fecha").ToString
            lblMes.Text = ds.Tables(0).Rows(0).Item("Mes").ToString
            lblTotal.Text = ds.Tables(0).Rows(0).Item("Total").ToString
            lblHora.Text = ds.Tables(0).Rows(0).Item("Hora").ToString

        Else

            encontrado = False

            '   MsgBox("No se encuentra los datos del Empleado, no se puede llenar la ficha", MsgBoxStyle.Critical, "Error")
            '  txtDescripcion.Text = ""
            '  txtprecio.Text = ""



        End If
    End Sub
End Class