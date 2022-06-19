Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows

Public Class Factura

    Dim fila As Integer = -1
    Dim TIPO As String = ""
    Dim D As Integer = 0
    Dim pre As Double
    Dim encontrado As Boolean


    Dim resultado As MsgBoxResult
    Private Sub Factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFecha.Text = Now
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Me.DatosGrid.Rows.Add("")

    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        If fila <> -1 Then
            Me.DatosGrid.Rows.RemoveAt(fila)
            fila = -1
        Else
            MsgBox("Debe eliminar una fila")
        End If

    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try

            'CONDICIONES EN BOLETA
            If radBoleta.Checked = True Then
                TIPO = "BOLETA"
            End If
            If radFactura.Checked = True Then
                TIPO = "FACTURA"
            End If

            'CABECERA
            cn.Open()
            Dim cmd As New SqlCommand("SP_MANTEDOCUMENTO", cn)
            Dim prm As New SqlParameter
            With cmd
                .CommandType = CommandType.StoredProcedure
                prm = .Parameters.Add("@NDO", SqlDbType.VarChar, 5)
                prm.Value = Me.txtNum.Text
                prm = .Parameters.Add("@TIP", SqlDbType.VarChar, 30)
                prm.Value = TIPO
                prm = .Parameters.Add("@IDC", SqlDbType.VarChar, 5)
                prm.Value = Me.txtCodCli.Text
                prm = .Parameters.Add("@IDE", SqlDbType.VarChar, 5)
                prm.Value = Me.txtCodEmpl.Text
                prm = .Parameters.Add("@FEC", SqlDbType.DateTime)
                prm.Value = Me.txtFecha.Text
                prm = .Parameters.Add("@SUBTOT", SqlDbType.Real)
                prm.Value = Me.txtSubTotal.Text
                prm = .Parameters.Add("@IGV", SqlDbType.Real)
                prm.Value = Me.txtIgv.Text
                prm = .Parameters.Add("@TOT", SqlDbType.Real)
                prm.Value = Me.txtTotal.Text

                .ExecuteNonQuery()
            End With
            cn.Close()
            cmd.Dispose()


            'DETALLE
            Dim I As Integer
            Dim prod, precio, cant, imp, sql2 As String
            For I = 0 To DatosGrid.Rows.Count - 1
                prod = DatosGrid.Rows(I).Cells(0).Value
                precio = DatosGrid.Rows(I).Cells(1).Value
                cant = DatosGrid.Rows(I).Cells(2).Value
                imp = DatosGrid.Rows(I).Cells(3).Value
                sql2 = "INSERT INTO DETALLE_DOCUMENTO VALUES('" + Me.txtNum.Text + "','" + TIPO + "','" +
                (I + 1).ToString + "', '" + prod + "' , '" + precio + "' , '" + cant + "')"
                Dim cmd2 As New SqlCommand(sql2, cn)
                cn.Open()
                cmd2.ExecuteNonQuery()
                cn.Close()
                cmd2.Dispose()
            Next
            MsgBox("Documento Almacenado")

            'ACTUALIZAR
            Dim cmd3 As New SqlCommand("UPDATE GENERADOR SET ULTIMO = ULTIMO + 1 WHERE PARAMETRO = 'DOCUMENTO'", cn)
            cn.Open()
            cmd3.ExecuteNonQuery()
            cn.Close()
            cmd3.Dispose()
            pre = 0
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try

    End Sub

    Private Sub btnBusCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusCliente.Click
        Try
            Dim NR As Integer = -1
            Dim Codigo As String = ""
            Codigo = InputBox("Ingrese Cliente:")
            Dim Da1 As New SqlDataAdapter("select * from CLIENTES where IdCLI = '" + Codigo + "'", cn)
            Da1.Fill(dsEntorno, "Busq1")
            NR = dsEntorno.Tables("Busq1").Rows.Count
            If NR > 0 Then
                Me.txtCodCli.Text = dsEntorno.Tables("Busq1").Rows(0)(0)
                Me.txtNomCli.Text = dsEntorno.Tables("Busq1").Rows(0)(1)
            Else
                MsgBox("Cliente no Existe")
            End If
            dsEntorno.Tables("Busq1").Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBusEmpleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBusEmpleado.Click
        Try
            Dim NR As Integer = -1
            Dim Codigo As String = ""
            Codigo = InputBox("Ingrese Empleado:")
            Dim Da1 As New SqlDataAdapter("select * from EMPLEADOS where IDEMP = '" + Codigo + "'", cn)
            Da1.Fill(dsEntorno, "Busq2")
            NR = dsEntorno.Tables("Busq2").Rows.Count
            If NR > 0 Then
                Me.txtCodEmpl.Text = dsEntorno.Tables("Busq2").Rows(0)(0)
                Me.txtNomEmp.Text = dsEntorno.Tables("Busq2").Rows(0)(1)
            Else
                MsgBox("Empleado no Existe")
            End If
            dsEntorno.Tables("Busq2").Rows.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Call limpiar()
        Me.txtNum.Text = Generadores("DOCUMENTO")
    End Sub


    Sub limpiar()
        Me.txtNum.Text = ""
        Me.txtCodCli.Text = ""
        Me.txtNomCli.Text = ""
        Me.txtCodEmpl.Text = ""
        Me.txtNomEmp.Text = ""
        Me.txtSubTotal.Text = ""
        Me.txtIgv.Text = ""
        Me.txtTotal.Text = ""

        Me.DatosGrid.Rows.Clear()
        Me.DatosGrid.DataSource = Nothing
        D = 0
    End Sub

    Private Sub DatosGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatosGrid.CellClick
        fila = e.RowIndex
    End Sub

    Private Sub DatosGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatosGrid.CellContentClick

    End Sub

    Private Sub DatosGrid_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DatosGrid.CellEnter
        Try
            If (DatosGrid.Rows(D).Cells(2).Value > 0) Then
                Me.DatosGrid.Rows(D).Cells(3).Value = Me.DatosGrid.Rows(D).Cells(2).Value *
               Me.DatosGrid.Rows(D).Cells(1).Value
            End If
            If (radBoleta.Checked = True) Then
                If (DatosGrid.Rows(D).Cells(3).Value > 0) Then
                    pre = pre + DatosGrid.Rows(D).Cells(3).Value
                    Me.txtSubtotal.Text = pre
                    Me.txtIgv.Text = 0
                    Me.txtTotal.Text = Me.txtSubtotal.Text
                    D = D + 1
                End If
            ElseIf (radFactura.Checked = True) Then
                If (DatosGrid.Rows(D).Cells(3).Value > 0) Then
                    pre = pre + DatosGrid.Rows(D).Cells(3).Value
                    Me.txtSubtotal.Text = pre
                    Me.txtIgv.Text = (Val(Me.txtSubtotal.Text) * 0.19)
                    Me.txtTotal.Text = (Val(Me.txtSubtotal.Text) + Val(Me.txtIgv.Text))
                    D = D + 1
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        tipoDocu = cbTipoDocu.SelectedItem
        codDocu = txtCodigoDocu.Text
        frmImprimir.Show()

    End Sub

    Private Sub txtCodCli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodCli.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub txtCodCli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodCli.TextChanged

    End Sub

    Private Sub txtCodCli_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodCli.Validating
        Dim constr As String

        constr = "Data Source=(local);Initial Catalog=CREATIVOS;Persist Security Info=True;User ID=sa;Password=root"

        Dim con As New SqlConnection(constr)
        Dim ds As New DataSet
        Dim tabla As New DataTable

        Dim da As New SqlDataAdapter("select * from Empleados where Codigo ='" & txtCodCli.Text & "'", con)

        '   Dim xConsulta As New SqlDataAdapter("select * from Inventario where Codigo = '" & txtcodigo.Text & "'", conexion.Inventario)
        '  Dim ds As New DataSet
        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then

            '   txtDescripcion.BackColor = Color.White

            encontrado = True

            txtNomCli.Text = ds.Tables(0).Rows(0).Item("Nombre").ToString



        Else

            encontrado = False

            If txtCodCli.Text = "000" Then
                txtNomCli.Enabled = True
            Else
                '   MsgBox("No se encuentra los datos del Empleado, no se puede llenar la ficha", MsgBoxStyle.Critical, "Error")
                txtCodCli.Text = ""
                txtNomCli.Text = ""



            End If



        End If

    End Sub
End Class