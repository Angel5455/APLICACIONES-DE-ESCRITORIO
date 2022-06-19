Imports System.Data.SqlClient

Public Class F_Solicitud

    Dim WithEvents queryconsultas As New dSolicitud
    Dim fila As Integer
    Dim editada As Boolean

    Dim conexion As New DataClasses1DataContext()
    Dim query

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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        F_Menu.Show()

        Me.Close()

    End Sub

    Private Sub txtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtIdentidad_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtIdentidad.MaskInputRejected

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCaja.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtCaja.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExpediente.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If

        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
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

        Dim fmess, faños, fdias As String


        If txtFechaS.Value.Date.Month < 10 Then

            fmess = "0" & txtFechaS.Value.Date.Month
            faños = txtFechaS.Value.Date.Year
            fdias = txtFechaS.Value.Date.Day
            txtFsol.Text = fmess & "/" & fdias & "/" & faños
        Else

            fmess = txtFechaS.Value.Date.Month
            faños = txtFechaS.Value.Date.Year
            fdias = txtFechaS.Value.Date.Day
            txtFsol.Text = fmess & "/" & fdias & "/" & faños

        End If


        If txtFechaS.Value.Date.Day < 10 Then

            fdias = "0" & txtFechaS.Value.Date.Day
            faños = txtFechaS.Value.Date.Year
            txtFsol.Text = fmess & "/" & fdias & "/" & faños

        Else
            fdias = txtFechaS.Value.Date.Day
            faños = txtFechaS.Value.Date.Year
            txtFrem.Text = fmess & "/" & fdias & "/" & faños

        End If


    End Sub

    Private Sub txtFechaRes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFechaRes.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtFechaRes_ValueChanged(sender As Object, e As EventArgs) Handles txtFechaRes.ValueChanged
        Dim fmes, faño, fdia As String

        If txtFechaRes.Value.Date.Month < 10 Then

            fmes = "0" & txtFechaRes.Value.Date.Month
            faño = txtFechaS.Value.Date.Year
            fdia = txtFechaS.Value.Date.Day
            txtFRes.Text = fmes & "/" & fdia & "/" & faño
        Else

            fmes = txtFechaRes.Value.Date.Month
            faño = txtFechaRes.Value.Date.Year
            fdia = txtFechaRes.Value.Date.Day
            txtFRes.Text = fmes & "/" & fdia & "/" & faño
        End If


        If txtFechaRes.Value.Date.Day < 10 Then

            fdia = "0" & txtFechaRes.Value.Date.Day
            faño = txtFechaRes.Value.Date.Year
            txtFRes.Text = fmes & "/" & fdia & "/" & faño

        Else

            fdia = txtFechaRes.Value.Date.Day
            faño = txtFechaRes.Value.Date.Year
            txtFRes.Text = fmes & "/" & fdia & "/" & faño

        End If


    End Sub

    Private Sub txtFechaE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFechaE.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtFechaE_ValueChanged(sender As Object, e As EventArgs) Handles txtFechaE.ValueChanged

        Dim fmese, fañoe, fdiae As String

        If txtFechaE.Value.Date.Month < 10 Then

            fmese = "0" & txtFechaE.Value.Date.Month
            fañoe = txtFechaE.Value.Date.Year
            fdiae = txtFechaE.Value.Date.Day
            txtFEnv.Text = fmese & "/" & fdiae & "/" & fañoe
        Else

            fmese = txtFechaE.Value.Date.Month
            fañoe = txtFechaE.Value.Date.Year
            fdiae = txtFechaE.Value.Date.Day
            txtFEnv.Text = fmese & "/" & fdiae & "/" & fañoe

        End If


        If txtFechaE.Value.Date.Day < 10 Then

            fdiae = "0" & txtFechaE.Value.Date.Day
            fañoe = txtFechaS.Value.Date.Year
            txtFEnv.Text = fmese & "/" & fdiae & "/" & fañoe

        Else
            fdiae = txtFechaS.Value.Date.Day
            fañoe = txtFechaS.Value.Date.Year
            txtFEnv.Text = fmese & "/" & fdiae & "/" & fañoe

        End If


    End Sub

    Private Sub txtFechaRem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFechaRem.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtFechaRem_ValueChanged(sender As Object, e As EventArgs) Handles txtFechaRem.ValueChanged

        Dim fmesr, fañor, fdiar As String


        If txtFechaRem.Value.Date.Month < 10 Then

            fmesr = "0" & txtFechaRem.Value.Date.Month
            fañor = txtFechaRem.Value.Date.Year
            fdiar = txtFechaRem.Value.Date.Day
            txtFrem.Text = fmesr & "/" & fdiar & "/" & fañor
        Else

            fmesr = txtFechaRem.Value.Date.Month
            fañor = txtFechaRem.Value.Date.Year
            fdiar = txtFechaRem.Value.Date.Day
            txtFrem.Text = fmesr & "/" & fdiar & "/" & fañor

        End If


        If txtFechaRem.Value.Date.Day < 10 Then

            fdiar = "0" & txtFechaRem.Value.Date.Day
            fañor = txtFechaRem.Value.Date.Year
            txtFrem.Text = fmesr & "/" & fdiar & "/" & fañor

        Else

            fdiar = txtFechaRem.Value.Date.Day
            fañor = txtFechaRem.Value.Date.Year
            txtFrem.Text = fmesr & "/" & fdiar & "/" & fañor

        End If


    End Sub

    Private Sub txtAuto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAuto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtAuto_TextChanged(sender As Object, e As EventArgs) Handles txtAuto.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Try


            If txtIdentidad.Text <> " - -    " And txtPersona.Text <> "" And txtAuto.Text <> "" And txtExpediente.Text <> "" And txtSolicitante.Text <> "" And txtSolicitud.Text <> "" And txtCaja.Text <> "" Then




                Dim n As New Comprobar

                Dim crol As String

                crol = n.Comprobar_Expediente(UCase(txtExpediente.Text))



                If crol = "S" Then



                    Call queryconsultas.insertar(lblId.Text, txtIdentidad.Text, txtExpediente.Text, txtTgr.Text, txtSolicitante.Text, txtPersona.Text, txtSolicitud.Text, txtFechaS.Text, txtFechaRes.Text, txtFechaE.Text, txtFechaRem.Text, txtAuto.Text, txtCaja.Text, txtFsol.Text, txtFRes.Text, txtFEnv.Text, txtFrem.Text)
                    limpiar()


                    lblId.Text = queryconsultas.numero().ToString

                    limpiar()

                Else

                    MessageBox.Show("Numero de Identidad ya Registrada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


                End If

            Else

                MessageBox.Show("Campos Vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            End If




        Catch ex As Exception

        End Try





    End Sub

    Private Sub F_Solicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim fmes, faño, fdia As String
        Dim fmesr, fañor, fdiar As String
        Dim fmess, faños, fdias As String
        Dim fmese, fañoe, fdiae As String

        If txtFechaRes.Value.Date.Month < 10 Then

            fmes = "0" & txtFechaRes.Value.Date.Month
            faño = txtFechaRes.Value.Date.Year
            fdia = txtFechaRes.Value.Date.Day
            txtFRes.Text = fmes & "/" & fdia & "/" & faño
        Else

            fmes = txtFechaRes.Value.Date.Month
            faño = txtFechaRes.Value.Date.Year
            fdia = txtFechaRes.Value.Date.Day
            txtFRes.Text = fmes & "/" & fdia & "/" & faño
        End If


        If txtFechaRes.Value.Date.Day < 10 Then

            fdia = "0" & txtFechaRes.Value.Date.Day
            faño = txtFechaRes.Value.Date.Year
            txtFRes.Text = fmes & "/" & fdia & "/" & faño

        Else

            fdia = txtFechaRes.Value.Date.Day
            faño = txtFechaRes.Value.Date.Year
            txtFRes.Text = fmes & "/" & fdia & "/" & faño

        End If


        ' rem


        If txtFechaRem.Value.Date.Month < 10 Then

            fmesr = "0" & txtFechaRem.Value.Date.Month
            fañor = txtFechaRem.Value.Date.Year
            fdiar = txtFechaRem.Value.Date.Day
            txtFrem.Text = fmes & "/" & fdia & "/" & faño
        Else

            fmesr = txtFechaRem.Value.Date.Month
            fañor = txtFechaRem.Value.Date.Year
            fdiar = txtFechaRem.Value.Date.Day
            txtFrem.Text = fmesr & "/" & fdiar & "/" & fañor

        End If


        If txtFechaRem.Value.Date.Day < 10 Then

            fdiar = "0" & txtFechaRem.Value.Date.Day
            fañor = txtFechaRem.Value.Date.Year
            txtFrem.Text = fmesr & "/" & fdiar & "/" & fañor

        Else

            fdiar = txtFechaRem.Value.Date.Day
            fañor = txtFechaRem.Value.Date.Year
            txtFrem.Text = fmesr & "/" & fdiar & "/" & fañor

        End If


        ' sol 

        If txtFechaS.Value.Date.Month < 10 Then

            fmess = "0" & txtFechaS.Value.Date.Month
            faños = txtFechaS.Value.Date.Year
            fdias = txtFechaS.Value.Date.Day
            txtFsol.Text = fmess & "/" & fdias & "/" & faños
        Else

            fmess = txtFechaS.Value.Date.Month
            faños = txtFechaS.Value.Date.Year
            fdias = txtFechaS.Value.Date.Day
            txtFsol.Text = fmess & "/" & fdias & "/" & faños

        End If


        If txtFechaS.Value.Date.Day < 10 Then

            fdias = "0" & txtFechaS.Value.Date.Day
            faños = txtFechaS.Value.Date.Year
            txtFsol.Text = fmess & "/" & fdias & "/" & faños

        Else
            fdias = txtFechaS.Value.Date.Day
            faños = txtFechaS.Value.Date.Year
            txtFrem.Text = fmess & "/" & fdias & "/" & faños

        End If

        ' env

        If txtFechaE.Value.Date.Month < 10 Then

            fmese = "0" & txtFechaE.Value.Date.Month
            fañoe = txtFechaE.Value.Date.Year
            fdiae = txtFechaE.Value.Date.Day
            txtFEnv.Text = fmese & "/" & fdiae & "/" & fañoe
        Else

            fmese = txtFechaE.Value.Date.Month
            fañoe = txtFechaE.Value.Date.Year
            fdiae = txtFechaE.Value.Date.Day
            txtFEnv.Text = fmese & "/" & fdiae & "/" & fañoe

        End If


        If txtFechaE.Value.Date.Day < 10 Then

            fdiae = "0" & txtFechaE.Value.Date.Day
            fañoe = txtFechaS.Value.Date.Year
            txtFEnv.Text = fmese & "/" & fdiae & "/" & fañoe

        Else
            fdiae = txtFechaS.Value.Date.Day
            fañoe = txtFechaS.Value.Date.Year
            txtFEnv.Text = fmese & "/" & fdiae & "/" & fañoe

        End If





        lblId.Text = queryconsultas.numero().ToString

    End Sub

    Private Sub txtSolicitante_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSolicitante.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")
        End If
    End Sub

 
End Class