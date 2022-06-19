Imports System.Data.SqlClient

Public Class F_Modificar

    Dim WithEvents queryconsultas As New dSolicitud

    Dim encontrado As Boolean

    Dim resultado As MsgBoxResult

    Sub limpiar()

        txtIdentidad.Clear()
        txtTgr.Clear()
        txtExpediente.Clear()
        txtSolicitante.Clear()
        txtPersona.Clear()
        txtSolicitud.Text = ""
        txtAuto.Clear()
        txtCaja.Clear()

    End Sub


    Private Sub txtExpediente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExpediente.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If

        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub


    Private Sub txtExpediente_TextChanged(sender As Object, e As EventArgs) Handles txtExpediente.TextChanged

        

    End Sub

    Private Sub txtCaja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCaja.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If

        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub


    Private Sub txtCaja_TextChanged(sender As Object, e As EventArgs) Handles txtCaja.TextChanged

    End Sub

    Private Sub txtTgr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTgr.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If

        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtTgr_TextChanged(sender As Object, e As EventArgs) Handles txtTgr.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        F_Menu.Show()
        Me.Close()

    End Sub

    Private Sub F_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtExpediente_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtExpediente.Validating

        Dim xConsulta As New SqlDataAdapter("select * from Solicitudes where Expediente = '" & txtExpediente.Text & "'", Conexion.conexion)
        Dim ds As New DataSet
        xConsulta.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then

            encontrado = True


            lblId.Visible = True

            lblId.Text = ds.Tables(0).Rows(0).Item("Id").ToString
            txtIdentidad.Text = ds.Tables(0).Rows(0).Item("Identidad").ToString
            txtPersona.Text = ds.Tables(0).Rows(0).Item("Persona_Inscrita").ToString
            txtTgr.Text = ds.Tables(0).Rows(0).Item("TGR").ToString
            txtSolicitante.Text = ds.Tables(0).Rows(0).Item("Solicitante").ToString
            txtPersona.Text = ds.Tables(0).Rows(0).Item("Persona_Inscrita").ToString
            txtSolicitud.Text = ds.Tables(0).Rows(0).Item("Tipo_Solicitud").ToString
       
            txtAuto.Text = ds.Tables(0).Rows(0).Item("Auto").ToString
            txtCaja.Text = ds.Tables(0).Rows(0).Item("Caja").ToString


            txtFechaS.Text = ds.Tables(0).Rows(0).Item("Fecha_Solicitud").ToString
            txtFechaRes.Text = ds.Tables(0).Rows(0).Item("Fecha_Resolucion").ToString
            txtFechaE.Text = ds.Tables(0).Rows(0).Item("Fecha_Envio").ToString
            txtFechaRem.Text = ds.Tables(0).Rows(0).Item("Fecha_Remision").ToString


            txtFsol.Text = ds.Tables(0).Rows(0).Item("FechaS").ToString
            txtFRes.Text = ds.Tables(0).Rows(0).Item("FechaRs").ToString
            txtFEnv.Text = ds.Tables(0).Rows(0).Item("FechaE").ToString
            txtFrem.Text = ds.Tables(0).Rows(0).Item("FechaRm").ToString




        Else
            'MsgBox("No se encuentra los datos del Empleado, no se puede llenar la ficha", MsgBoxStyle.Critical, "Error")
           
            txtIdentidad.Clear()
            txtTgr.Clear()
            txtSolicitante.Clear()
            txtPersona.Clear()
            txtSolicitud.Text = ""
            txtAuto.Clear()
            txtCaja.Clear()


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        queryconsultas.Modificar(lblId.Text, txtIdentidad.Text, txtExpediente.Text, txtTgr.Text, txtSolicitante.Text, txtPersona.Text, txtSolicitud.Text, txtFechaS.Text, txtFechaRes.Text, txtFechaE.Text, txtFechaRem.Text, txtAuto.Text, txtCaja.Text, txtFsol.Text, txtFRes.Text, txtFEnv.Text, txtFrem.Text)

        limpiar()



        lblId.Visible = False




        lblId.Visible = False


    End Sub

    Private Sub txtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtIdentidad_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtIdentidad.MaskInputRejected

    End Sub

    Private Sub txtSolicitante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSolicitante.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtSolicitante_TextChanged(sender As Object, e As EventArgs) Handles txtSolicitante.TextChanged

    End Sub

    Private Sub txtPersona_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPersona.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPersona_TextChanged(sender As Object, e As EventArgs) Handles txtPersona.TextChanged

    End Sub

    Private Sub txtSolicitud_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSolicitud.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtSolicitud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtSolicitud.SelectedIndexChanged

    End Sub

    Private Sub txtFechaS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFechaS.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtFechaS_ValueChanged(sender As Object, e As EventArgs) Handles txtFechaS.ValueChanged

    End Sub

    Private Sub txtFechaRes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFechaRes.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtFechaRes_ValueChanged(sender As Object, e As EventArgs) Handles txtFechaRes.ValueChanged

    End Sub

    Private Sub txtFechaE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFechaE.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtFechaE_ValueChanged(sender As Object, e As EventArgs) Handles txtFechaE.ValueChanged

    End Sub

    Private Sub txtFechaRem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFechaRem.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtFechaRem_ValueChanged(sender As Object, e As EventArgs) Handles txtFechaRem.ValueChanged

    End Sub

    Private Sub txtAuto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAuto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtAuto_TextChanged(sender As Object, e As EventArgs) Handles txtAuto.TextChanged

    End Sub
End Class