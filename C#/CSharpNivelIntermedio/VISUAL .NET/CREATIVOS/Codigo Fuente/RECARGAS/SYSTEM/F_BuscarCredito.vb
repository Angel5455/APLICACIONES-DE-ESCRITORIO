Imports System.Data.SqlClient

Public Class F_BuscarCredito

    Public busqueda As Boolean


    Private Sub F_BuscarCredito_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


    End Sub


    Private Sub F_BuscarCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtnombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnombre.TextChanged

        If lblCel.Text = "TIGO" Then


            Dim constr As String

            constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

            Dim con As New SqlConnection(constr)
            Dim ds As New DataSet
            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select * from Control_Recargas_Tigo  Where Nombre like'%" & txtnombre.Text & "%'" & "and Observacion like'" & "DEBE" & "%'", con)

            Try

                Dim cmd As New SqlCommand

                da.Fill(tabla)

                DataGridView1.DataSource = tabla


                Dim fila As Integer
                fila = DataGridView1.RowCount - 1


            Catch ex As Exception
                MsgBox(ex.Message)

            Finally

                con = Nothing
                ds = Nothing
                da = Nothing

                tabla = Nothing

            End Try

            Dim total As Integer

            Try

                For i As Integer = 0 To DataGridView1.RowCount - 1
                    total = total + CDbl(DataGridView1.Item("Creditos".ToLower, i).Value)
                Next

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

            lblMonto.Text = total


        End If

        If lblCel.Text = "CLARO" Then


            Dim constr As String

            constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

            Dim con As New SqlConnection(constr)
            Dim ds As New DataSet
            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select * from Control_Recargas_Claro Where Nombre like'%" & txtnombre.Text & "%'" & "and Observacion like'" & "DEBE" & "%'", con)

            Try

                Dim cmd As New SqlCommand

                da.Fill(tabla)

                DataGridView1.DataSource = tabla


                Dim fila As Integer
                fila = DataGridView1.RowCount - 1


            Catch ex As Exception
                MsgBox(ex.Message)

            Finally

                con = Nothing
                ds = Nothing
                da = Nothing

                tabla = Nothing

            End Try

            Dim total As Integer

            Try

                For i As Integer = 0 To DataGridView1.RowCount - 1
                    total = total + CDbl(DataGridView1.Item("Creditos".ToLower, i).Value)
                Next

            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try

            lblMonto.Text = total


        End If


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        
    End Sub

    Private Sub DataGridView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
 
    End Sub

    Private Sub btnabonar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabonar.Click


        If lblCel.Text = "TIGO" Then

            Try

                F_ControlRecargas.txtId.Text = DataGridView1.SelectedCells(0).Value.ToString()
                F_ControlRecargas.txtnombre.Text = DataGridView1.SelectedCells(1).Value.ToString()
                F_ControlRecargas.txtCelular.Text = DataGridView1.SelectedCells(2).Value.ToString()
                F_ControlRecargas.txtCantidad.Text = DataGridView1.SelectedCells(3).Value.ToString()
                F_ControlRecargas.lblFecha.Text = DataGridView1.SelectedCells(4).Value.ToString()

                F_ControlRecargas.Label5.Visible = True
                F_ControlRecargas.txtnombre.Visible = True
                F_ControlRecargas.Label4.Visible = True
                F_ControlRecargas.lblMonto.Visible = True

                F_ControlRecargas.lblMonto.Text = DataGridView1.SelectedCells(11).Value.ToString()

                F_ControlRecargas.CheckBox1.Checked = True
                F_ControlRecargas.CheckBox1.Enabled = True

                F_ControlRecargas.lblObservacion.Text = "DEBE"
                F_ControlRecargas.lblObservacion.Visible = True
                F_ControlRecargas.txtnombre.Enabled = False
                F_ControlRecargas.Button3.Visible = True

                Me.Close()

            Catch ex As Exception

                MsgBox("Seleccione al cliente correctamente")

            End Try

        End If


        If lblCel.Text = "CLARO" Then


            Try

                F_Control_Recargas_Claro.txtId.Text = DataGridView1.SelectedCells(0).Value.ToString()
                F_Control_Recargas_Claro.txtnombre.Text = DataGridView1.SelectedCells(1).Value.ToString()
                F_Control_Recargas_Claro.txtCelular.Text = DataGridView1.SelectedCells(2).Value.ToString()
                F_Control_Recargas_Claro.txtCantidad.Text = DataGridView1.SelectedCells(3).Value.ToString()
                F_Control_Recargas_Claro.lblFecha.Text = DataGridView1.SelectedCells(4).Value.ToString()

                F_Control_Recargas_Claro.Label5.Visible = True
                F_Control_Recargas_Claro.txtnombre.Visible = True
                F_Control_Recargas_Claro.Label4.Visible = True
                F_Control_Recargas_Claro.lblMonto.Visible = True

                F_Control_Recargas_Claro.lblMonto.Text = DataGridView1.SelectedCells(11).Value.ToString()

                F_Control_Recargas_Claro.CheckBox1.Checked = True
                F_Control_Recargas_Claro.CheckBox1.Enabled = True

                F_Control_Recargas_Claro.lblObservacion.Text = "DEBE"
                F_Control_Recargas_Claro.lblObservacion.Visible = True
                F_Control_Recargas_Claro.txtnombre.Enabled = False
                F_Control_Recargas_Claro.Button3.Visible = True

                Me.Close()



            Catch ex As Exception

                MsgBox("Seleccione al cliente correctamente")

            End Try



        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If lblCel.Text = "TIGO" Then


            F_ControlRecargas.txtId.Text = DataGridView1.SelectedCells(0).Value.ToString()
            F_ControlRecargas.txtnombre.Text = DataGridView1.SelectedCells(1).Value.ToString()
            F_ControlRecargas.txtCelular.Text = DataGridView1.SelectedCells(2).Value.ToString()
            F_ControlRecargas.txtCantidad.Text = DataGridView1.SelectedCells(3).Value.ToString()
            F_ControlRecargas.lblFecha.Text = DataGridView1.SelectedCells(4).Value.ToString()

            F_ControlRecargas.Label5.Visible = True
            F_ControlRecargas.txtnombre.Visible = True
            F_ControlRecargas.Label4.Visible = True
            F_ControlRecargas.lblMonto.Visible = True

            F_ControlRecargas.lblMonto.Text = DataGridView1.SelectedCells(11).Value.ToString()

            F_ControlRecargas.CheckBox1.Checked = True
            F_ControlRecargas.CheckBox1.Enabled = True

            F_ControlRecargas.lblObservacion.Text = "DEBE"
            F_ControlRecargas.lblObservacion.Visible = True
            F_ControlRecargas.txtnombre.Enabled = False
            Me.Close()



        End If

        If lblCel.Text = "CLARO" Then


            F_Control_Recargas_Claro.txtId.Text = DataGridView1.SelectedCells(0).Value.ToString()
            F_Control_Recargas_Claro.txtnombre.Text = DataGridView1.SelectedCells(1).Value.ToString()
            F_Control_Recargas_Claro.txtCelular.Text = DataGridView1.SelectedCells(2).Value.ToString()
            F_Control_Recargas_Claro.txtCantidad.Text = DataGridView1.SelectedCells(3).Value.ToString()
            F_Control_Recargas_Claro.lblFecha.Text = DataGridView1.SelectedCells(4).Value.ToString()

            F_Control_Recargas_Claro.Label5.Visible = True
            F_Control_Recargas_Claro.txtnombre.Visible = True
            F_Control_Recargas_Claro.Label4.Visible = True
            F_Control_Recargas_Claro.lblMonto.Visible = True

            F_Control_Recargas_Claro.lblMonto.Text = DataGridView1.SelectedCells(11).Value.ToString()

            F_Control_Recargas_Claro.CheckBox1.Checked = True
            F_Control_Recargas_Claro.CheckBox1.Enabled = True

            F_Control_Recargas_Claro.lblObservacion.Text = "DEBE"
            F_Control_Recargas_Claro.lblObservacion.Visible = True
            F_Control_Recargas_Claro.txtnombre.Enabled = False

            Me.Close()



        End If



    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub lblCel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCel.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class