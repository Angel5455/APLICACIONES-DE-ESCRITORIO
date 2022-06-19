Public Class F_Menu_Movimientos

    Public menu_salida As Integer
    Public menu_entrada As Integer
    Public admin As Boolean

    Private Sub ComboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboTipo.SelectedIndexChanged
        txtTipo.Text = ComboTipo.Text

        If txtTipo.Text = "Entrada" Then
            txtConcepto.Items.Clear()
            txtConcepto.Items.Add("Ajuste de Inventario")
            txtConcepto.Items.Add("Compra de Insumos")
            txtConcepto.Items.Add("Otras Entradas")


        End If

        If txtTipo.Text = "Salida" Then


            txtConcepto.Items.Clear()
            txtConcepto.Items.Add("Venta de Insumos")
            txtConcepto.Items.Add("Otras Salidas")


        End If


    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        F_MovimientosS.salir = "S"
        F_MovimientosE.salir = "S"

        '  If txtcargo.Text = 1 Then

        'admin = True

        'Else

        'admin = False


        '        End If

        If ComboTipo.Text = "Entrada" Then


            If txtConcepto.Text = "Ajuste de Inventario" Then

                menu_entrada = 1
                '      If admin = True Then

                'F_MovimientosE.txtcargo.Text = 1
                '       Else

                'F_MovimientosE.txtcargo.Text = 2
                'End If


            End If


            If txtConcepto.Text = "Compra de Insumos" Then

                menu_entrada = 1
                '     If admin = True Then

                'F_MovimientosE.txtcargo.Text = 1
                'Else

                'F_MovimientosE.txtcargo.Text = 2
                'End If

            End If

            If txtConcepto.Text = "Otras Entradas" Then

                menu_entrada = 1
                '    If admin = True Then

                'F_MovimientosE.txtcargo.Text = 1
                ' Else

                'F_MovimientosE.txtcargo.Text = 2
                '    End If


            End If



            If menu_entrada = 1 Then

            'If admin = True Then

            'F_MovimientosE.txtcargo.Text = 1
            'Else

            'F_MovimientosE.txtcargo.Text = 2
            '        End If

            F_MovimientosE.ComboTipo.Text = "Entrada"
            F_MovimientosE.txtTipo.Text = "Entrada"
            F_MovimientosE.txtConcepto.Text = txtConcepto.Text

            F_MovimientosE.Show()

            Me.Close()

        Else

            MsgBox("Elija el concepto del Movimiento")




        End If

        End If

        If ComboTipo.Text = "Salida" Then

            F_MovimientosS.txtContador.Text = 2
            F_MovimientosS.ComboTipo.Text = "Salida"
            F_MovimientosS.txtTipo.Text = "Salida"
            F_MovimientosS.txtConcepto.Text = txtConcepto.Text

            F_MovimientosS.btnNuevo.Visible = True
            F_MovimientosS.btnNoNuevo.Visible = False



            If txtConcepto.Text = "Venta de Insumos" Then

                menu_salida = 2
                F_Factura.salir = "S"

                F_Factura.txtConcepto.Text = txtConcepto.Text
                F_Factura.ComboTipo.Text = txtTipo.Text
                F_Factura.txtTipo.Text = txtTipo.Text

                F_Factura.Show()

                Me.Close()


            End If


            If txtConcepto.Text = "Otras Salidas" Then

                F_Factura.txtConcepto.Text = txtConcepto.Text
                F_Factura.ComboTipo.Text = txtTipo.Text
                F_Factura.txtTipo.Text = txtTipo.Text



                menu_salida = 2
                F_Factura.Show()

                Me.Close()

            End If


            If menu_salida = 0 Then

                MsgBox("Elija el concepto del Movimiento")

            End If


        End If



    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

    End Sub

    Private Sub txtConcepto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConcepto.SelectedIndexChanged

    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Height = 45
        PictureBox3.Width = 45
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Height = 50
        PictureBox3.Width = 50
    End Sub

  

    Private Sub F_Menu_Movimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        menu_entrada = 0
    End Sub

    Private Sub btnSalir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir2.Click
        btnSalir.Visible = True
        btnSalir2.Visible = False
        Me.Close()
    End Sub

    Private Sub btnSalir2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSalir2.MouseLeave
        btnSalir.Visible = True
        btnSalir2.Visible = False
    End Sub

    Private Sub btnSalir_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnSalir.MouseMove
        btnSalir.Visible = False
        btnSalir2.Visible = True
    End Sub
End Class