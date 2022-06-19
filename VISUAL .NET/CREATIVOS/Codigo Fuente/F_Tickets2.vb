Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class F_Tickets2

    Dim encontrado As Boolean
    Dim xSQL As New Conexion_Empleados
    Public accion As Boolean
    Dim resultado As MsgBoxResult


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTicket.TextChanged
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable




        Dim da As New SqlDataAdapter("Select * from Tickets Where Ticket like'" & txtTicket.Text & "'", con)


        Try

            Dim cmd As New SqlCommand

            da.Fill(tabla)

            DataGridView2.DataSource = tabla

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            con = Nothing
            ds = Nothing
            da = Nothing

            tabla = Nothing

        End Try


    End Sub

    Private Sub F_Tickets2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Sub mostrar()

        Dim da As SqlDataAdapter = New SqlDataAdapter

        da.SelectCommand = New SqlCommand("Select * from Tickets", Conexion.conexion)
        Dim DS As New DataSet

        da.Fill(DS, "Tickets")

        DataGridView2.DataSource = DS.Tables("Tickets")

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub DataGridView2_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseDoubleClick
        Try

            lblticket.Text = DataGridView2.SelectedCells(0).Value.ToString()
            lblfecha.Text = DataGridView2.SelectedCells(1).Value.ToString()

            txtnombre.Text = DataGridView2.SelectedCells(2).Value.ToString()

            txtTotal.Text = DataGridView2.SelectedCells(3).Value.ToString()


            Dim constr As String

            constr = "Data Source=LAPSTUDIO;Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

            Dim con As New SqlConnection(constr)
            Dim ds As New DataSet
            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select * from Descripcion where Ticket like '" & lblticket.Text & "'", con)


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

            Dim total As Double = 0

            ' recorrer las filas y obtener los items de la columna indicada en "nombre_Columna"  

            Try
                For i As Integer = 0 To DataGridView1.RowCount - 1
                    total = total + CDbl(DataGridView1.Item("Subtotal".ToLower, i).Value)
                Next

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

            txtTotal.Text = total


            '     If txtcargo.Text = 2 Then

            'btnEliminar.Visible = False
            'btnNoEliminar.Visible = True
            'btnModificar.Visible = False
            'btnNoModificar.Visible = True
            'btnGuardar.Visible = True
            'btnNoGuardar.Visible = False

            'End If

            'If txtcargo.Text = 1 Then


            'End If

            TabControl1.SelectedIndex = 0


        Catch ex As Exception
        End Try
    End Sub
End Class