Imports System.Data.SqlClient


Public Class F_Lista_Productores

    Public opciones As Boolean


    Private Sub txtCampo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCampo.TextChanged

        If opciones = True Then


            Dim constr As String

            constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

            Dim con As New SqlConnection(constr)
            Dim ds As New DataSet
            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select * from Productores where Fase like '" & txtfase.Text & "%'" & "And Nombre Like'" & txtCampo.Text & "%'", con)


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

        End If


        If opciones = False Then

            Dim constr As String

            constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

            Dim con As New SqlConnection(constr)
            Dim ds As New DataSet
            Dim tabla As New DataTable

            Dim da As New SqlDataAdapter("Select * from Productores where Nombre like '" & txtCampo.Text & "%'", con)


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


        End If



    End Sub

    Private Sub F_Lista_Productores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conexion As New Conexion_Fases
        Dim tabla As New DataTable


        If conexion.consultar_todos_productor Then
            '   tabla = conexion.tabla
            '    DataGridView1.DataSource = tabla
        Else
            MessageBox.Show("No se pudo consultar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        Try

            If opciones = True Then

                F_Fase1.txtclave.Text = DataGridView1.SelectedCells(0).Value.ToString()
                F_Fase1.txtNombreP.Text = DataGridView1.SelectedCells(1).Value.ToString()

                F_Fase1.txtIdentidad.Text = DataGridView1.SelectedCells(2).Value.ToString()

                F_Fase1.txtAgencia.Text = DataGridView1.SelectedCells(4).Value.ToString()
                F_Fase1.txtMunicipio.Text = DataGridView1.SelectedCells(5).Value.ToString()
                F_Fase1.txtMonto.Text = DataGridView1.SelectedCells(6).Value.ToString()
                F_Fase1.PicBloc.Load(Application.StartupPath & DataGridView1.SelectedCells(9).Value.ToString)

                F_Fase1.txtD1.Text = Val(F_Fase1.txtMonto.Text) / 10


            End If

            If opciones = False Then

                F_Pago.txtclave.Text = DataGridView1.SelectedCells(0).Value.ToString()
                F_Pago.txtNombreP.Text = DataGridView1.SelectedCells(1).Value.ToString()

                F_Pago.txtIdentidad.Text = DataGridView1.SelectedCells(2).Value.ToString()

                F_Pago.txtAgencia.Text = DataGridView1.SelectedCells(4).Value.ToString()
                F_Pago.txtMunicipio.Text = DataGridView1.SelectedCells(5).Value.ToString()
                F_Pago.txtMonto.Text = DataGridView1.SelectedCells(6).Value.ToString()
                F_Pago.lblFase.Text = DataGridView1.SelectedCells(8).Value.ToString
                F_Pago.PicBloc.Load(Application.StartupPath & DataGridView1.SelectedCells(9).Value.ToString)

                F_Pago.txtA1.Text = Math.Round(Val(F_Pago.txtMonto.Text) / 3, 2, MidpointRounding.ToEven)


            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtBuscarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class