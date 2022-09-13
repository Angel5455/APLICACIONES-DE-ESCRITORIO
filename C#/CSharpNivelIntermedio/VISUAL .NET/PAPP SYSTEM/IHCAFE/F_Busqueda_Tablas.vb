Imports System.Data.SqlClient

Public Class F_Busqueda_Tablas

    Private Sub txtN_Desembolso_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub


    
    Private Sub txtCampo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCampo.TextChanged

        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=Fases;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable



            Dim da As New SqlDataAdapter("Select * from Productores  where " & txtBuscarPor.Text & " like '" & txtCampo.Text & "%'", con)


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




    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
   

        Try

        
                txtclave.Text = DataGridView1.SelectedCells(0).Value.ToString()
                txtNombreP.Text = DataGridView1.SelectedCells(1).Value.ToString()

                txtIdentidad.Text = DataGridView1.SelectedCells(2).Value.ToString()


                txtAgencia.Text = DataGridView1.SelectedCells(4).Value.ToString()
            txtMunicipio.Text = DataGridView1.SelectedCells(5).Value.ToString()
                PicBloc.Load(Application.StartupPath & DataGridView1.SelectedCells(8).Value.ToString)


            Catch ex As Exception
            End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim conexion As New Conexion_Fases
        Dim datos As New dFases
        Dim tabla As New DataTable
        Dim mireporte As New CrystalReport_General

        datos.nombre = txtNombreP.Text

        If conexion.consultar_nombre(datos) Then

            tabla = conexion.tabla
            mireporte.SetDataSource(tabla)
            R_Productores.CrystalReportViewer1.ReportSource = mireporte
            R_Productores.CrystalReportViewer1.RefreshReport()
            R_Productores.Show()

        End If
        


    End Sub

    Private Sub F_Busqueda_Tablas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FasesDataSet.Configuracion' Puede moverla o quitarla según sea necesario.
        Me.ConfiguracionTableAdapter.Fill(Me.FasesDataSet.Configuracion)

        Dim conexion As New Conexion_Fases
        Dim tabla As New DataTable

        If conexion.consultar_todos_productor Then

            tabla = conexion.tabla
            DataGridView1.DataSource = tabla
        Else
            MessageBox.Show("No se pudo consultar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        R_General.Show()



    End Sub

    Private Sub txtBuscarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarPor.SelectedIndexChanged

    End Sub
End Class