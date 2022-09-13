Public Class F_Banners

    Dim medida As Integer


 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        lblMaterial.Text = My.Settings.MyLona


    End Sub


    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        Button1.BackColor = Color.Blue
        Button2.BackColor = Color.Green
        Button3.BackColor = Color.Green
        Button4.BackColor = Color.Green
        Button5.BackColor = Color.Green
        Button6.BackColor = Color.Green
        Button7.BackColor = Color.Green
        Button8.BackColor = Color.Green

        Button1.ForeColor = Color.White
        Button2.ForeColor = Color.Black
        Button3.ForeColor = Color.Black
        Button4.ForeColor = Color.Black
        Button5.ForeColor = Color.Black
        Button6.ForeColor = Color.Black
        Button7.ForeColor = Color.Black
        Button8.ForeColor = Color.Black
        lblMaterial.Text = My.Settings.MyLona

        lblTotal.Text = ((Val(txtalto.Text) * Val(txtancho.Text) * Val(lblMaterial.Text)) / 144 + lblDiseño.Text) * Val(txtcantidad.Text)

        lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")
       


    End Sub



    Private Sub F_Banners_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cbxentrada.Text = "pulgadas"

        lblan.Text = "0 pulg"
        lblal.Text = "0 pulg"


        lblancho.Text = "pulg"
        lblalto.Text = "pulg"

        lblDiseño.Text = My.Settings.MySimple
        lblMaterial.Text = My.Settings.MyLona
        txtcantidad.Text = 1
        Button1.BackColor = Color.Blue
        Button2.BackColor = Color.Green
        Button3.BackColor = Color.Green
        Button4.BackColor = Color.Green
        Button5.BackColor = Color.Green
        Button6.BackColor = Color.Green
        Button7.BackColor = Color.Green
        Button8.BackColor = Color.Green

        Button1.ForeColor = Color.White


        lblTotal.Text = ((Val(txtalto.Text) * Val(txtancho.Text) * 40) / 144) * Val(txtcantidad.Text) + lblDiseño.Text

        lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")


    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        lblMaterial.Text = My.Settings.MyLonaT
    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        Button1.BackColor = Color.Green
        Button2.BackColor = Color.Blue
        Button3.BackColor = Color.Green
        Button4.BackColor = Color.Green
        Button5.BackColor = Color.Green
        Button6.BackColor = Color.Green
        Button7.BackColor = Color.Green
        Button8.BackColor = Color.Green

        Button1.ForeColor = Color.Black
        Button2.ForeColor = Color.White
        Button3.ForeColor = Color.Black
        Button4.ForeColor = Color.Black
        Button5.ForeColor = Color.Black
        Button6.ForeColor = Color.Black
        Button7.ForeColor = Color.Black
        Button8.ForeColor = Color.Black

        lblMaterial.Text = My.Settings.MyLonaT


        lblTotal.Text = ((Val(txtalto.Text) * Val(txtancho.Text) * Val(lblMaterial.Text)) / 144 + lblDiseño.Text) * Val(txtcantidad.Text)

        lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        lblMaterial.Text = My.Settings.MyPvc
    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        Button1.BackColor = Color.Green
        Button2.BackColor = Color.Green
        Button3.BackColor = Color.Blue
        Button4.BackColor = Color.Green
        Button5.BackColor = Color.Green
        Button6.BackColor = Color.Green
        Button7.BackColor = Color.Green
        Button8.BackColor = Color.Green

        Button1.ForeColor = Color.Black
        Button2.ForeColor = Color.Black
        Button3.ForeColor = Color.White
        Button4.ForeColor = Color.Black
        Button5.ForeColor = Color.Black
        Button6.ForeColor = Color.Black
        Button7.ForeColor = Color.Black
        Button8.ForeColor = Color.Black

        lblMaterial.Text = My.Settings.MyPvc

        lblTotal.Text = ((Val(txtalto.Text) * Val(txtancho.Text) * Val(lblMaterial.Text)) / 144 + lblDiseño.Text) * Val(txtcantidad.Text)

        lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        lblMaterial.Text = My.Settings.MyCoroplast
    End Sub

    Private Sub Button4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseEnter
        Button1.BackColor = Color.Green
        Button2.BackColor = Color.Green
        Button3.BackColor = Color.Green
        Button4.BackColor = Color.Blue
        Button5.BackColor = Color.Green
        Button6.BackColor = Color.Green
        Button7.BackColor = Color.Green
        Button8.BackColor = Color.Green

        Button1.ForeColor = Color.Black
        Button2.ForeColor = Color.Black
        Button3.ForeColor = Color.Black
        Button4.ForeColor = Color.White
        Button5.ForeColor = Color.Black
        Button6.ForeColor = Color.Black
        Button7.ForeColor = Color.Black
        Button8.ForeColor = Color.Black

        lblMaterial.Text = My.Settings.MyCoroplast

        lblTotal.Text = ((Val(txtalto.Text) * Val(txtancho.Text) * Val(lblMaterial.Text)) / 144 + lblDiseño.Text) * Val(txtcantidad.Text)

        lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")

    End Sub

    Private Sub txtalto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtalto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If



    End Sub

    Private Sub txtalto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtalto.TextChanged

        lblTotal.Text = ((Val(txtalto.Text) * Val(txtancho.Text) * Val(lblMaterial.Text)) / 144 + lblDiseño.Text) * Val(txtcantidad.Text)

        lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")

        If cbxentrada.Text = "Centimetros" Then


            lblal.Text = Val(txtalto.Text)

        End If

        If cbxentrada.Text = "Pulgadas" Then


            lblal.Text = Val(txtalto.Text)

        End If

        
    End Sub

    Private Sub txtancho_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtancho.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True

            SendKeys.Send("{TAB}")

        End If

      

    End Sub

    Private Sub txtancho_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtancho.TextChanged

        lblTotal.Text = ((Val(txtalto.Text) * Val(txtancho.Text) * Val(lblMaterial.Text)) / 144 + lblDiseño.Text) * Val(txtcantidad.Text)

        lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")

        If cbxentrada.Text = "Pulgadas" Then


            lblan.Text = Val(txtancho.Text)

        End If



        If cbxentrada.Text = "Centimetros" Then


            lblan.Text = Val(txtancho.Text)

        End If


    End Sub

    Private Sub txtcantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcantidad.TextChanged


        lblTotal.Text = ((Val(txtalto.Text) * Val(txtancho.Text) * Val(lblMaterial.Text)) / 144 + lblDiseño.Text) * Val(txtcantidad.Text)

        lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        lblDiseño.Text = My.Settings.MySimple

        lblTotal.Text = ((Val(txtalto.Text) * Val(txtancho.Text) * Val(lblMaterial.Text)) / 144 + lblDiseño.Text) * Val(txtcantidad.Text)

        lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        lblDiseño.Text = My.Settings.MyNormal

        lblTotal.Text = ((Val(txtalto.Text) * Val(txtancho.Text) * Val(lblMaterial.Text)) / 144 + lblDiseño.Text) * Val(txtcantidad.Text)

        lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        lblDiseño.Text = My.Settings.MyPremiun

        lblTotal.Text = ((Val(txtalto.Text) * Val(txtancho.Text) * Val(lblMaterial.Text)) / 144 + lblDiseño.Text) * Val(txtcantidad.Text)

        lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then


            lblTotal.Text = (((Val(txtalto.Text) * Val(txtancho.Text) * Val(lblMaterial.Text)) / 144) * Val(txtcantidad.Text)) - lblDiseño.Text

            lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")

            lblDiseño.Text = 0
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton1.Checked = False

            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            RadioButton1.Enabled = False


            If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then

                lblDiseño.Text = 0

                lblTotal.Text = (((Val(txtalto.Text) * Val(txtancho.Text) * Val(lblMaterial.Text)) / 144) * Val(txtcantidad.Text)) - lblDiseño.Text

                lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")


            End If


        Else

            RadioButton2.Checked = True
            lblDiseño.Text = My.Settings.MySimple
            RadioButton2.Enabled = True
            RadioButton3.Enabled = True
            RadioButton1.Enabled = True

        End If

       

    End Sub

    

    Private Sub cbxsalida_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxsalida.SelectedIndexChanged
        If cbxentrada.Text = "Pulgadas" And cbxsalida.Text = "Centimetros" Then
            lblran.Text = Val(lblan.Text) * 2.54
            lblral.Text = Val(lblal.Text) * 2.54

            lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")


        End If

        If cbxentrada.Text = "Centimetros" And cbxsalida.Text = "Pulgadas" Then
            lblran.Text = Format(Val(lblan.Text) * 0.393700787, "0.00")
            lblral.Text = Format(Val(lblal.Text) * 0.393700787, "0.00")
        End If


    End Sub

    Private Sub cbxentrada_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxentrada.SelectedIndexChanged

        If cbxentrada.Text = "Centimetros" Then

            lblancho.Text = "Cm"
            lblalto.Text = "Cm"

        End If


    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtancho.Text = lblran.Text
        txtalto.Text = lblral.Text

        If cbxsalida.Text = "Centimetros" Then

            lblancho.Text = "Cm"
            lblalto.Text = "Cm"

            lblan.Text = Val(txtancho.Text)

            cbxentrada.Text = "Centimetros"
            cbxsalida.Text = ""

        End If

        If cbxsalida.Text = "Pulgadas" Then

            lblancho.Text = "pulg"
            lblalto.Text = "pulg"

            lblan.Text = Val(txtancho.Text)

            cbxentrada.Text = "Pulgadas"
            cbxsalida.Text = ""

        End If


    End Sub

    Private Sub lblan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblan.Click


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        lblMaterial.Text = My.Settings.MyBackLigth

    End Sub

    Private Sub Button6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseEnter
        Button1.BackColor = Color.Green
        Button2.BackColor = Color.Green
        Button3.BackColor = Color.Green
        Button4.BackColor = Color.Green
        Button5.BackColor = Color.Green
        Button6.BackColor = Color.Blue
        Button7.BackColor = Color.Green
        Button8.BackColor = Color.Green

        Button1.ForeColor = Color.Black
        Button2.ForeColor = Color.Black
        Button3.ForeColor = Color.Black
        Button4.ForeColor = Color.Black
        Button5.ForeColor = Color.Black
        Button6.ForeColor = Color.White
        Button7.ForeColor = Color.Black
        Button8.ForeColor = Color.Black
        lblMaterial.Text = My.Settings.MyBackLigth

        lblTotal.Text = ((Val(txtalto.Text) * Val(txtancho.Text) * Val(lblMaterial.Text)) / 144 + lblDiseño.Text) * Val(txtcantidad.Text)

        lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        lblMaterial.Text = My.Settings.MyMicro
    End Sub

    Private Sub Button7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseEnter
        Button1.BackColor = Color.Green
        Button2.BackColor = Color.Green
        Button3.BackColor = Color.Green
        Button4.BackColor = Color.Green
        Button5.BackColor = Color.Green
        Button6.BackColor = Color.Green
        Button7.BackColor = Color.Blue
        Button8.BackColor = Color.Green

        Button1.ForeColor = Color.Black
        Button2.ForeColor = Color.Black
        Button3.ForeColor = Color.Black
        Button4.ForeColor = Color.Black
        Button5.ForeColor = Color.Black
        Button6.ForeColor = Color.Black
        Button7.ForeColor = Color.White
        Button8.ForeColor = Color.Black

        lblMaterial.Text = My.Settings.MyMicro

        lblTotal.Text = ((Val(txtalto.Text) * Val(txtancho.Text) * Val(lblMaterial.Text)) / 144 + lblDiseño.Text) * Val(txtcantidad.Text)

        lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        lblMaterial.Text = My.Settings.MyReflectivo
    End Sub

    Private Sub Button5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseEnter
        Button1.BackColor = Color.Green
        Button2.BackColor = Color.Green
        Button3.BackColor = Color.Green
        Button4.BackColor = Color.Green
        Button5.BackColor = Color.Blue
        Button6.BackColor = Color.Green
        Button7.BackColor = Color.Green
        Button8.BackColor = Color.Green

        Button1.ForeColor = Color.Black
        Button2.ForeColor = Color.Black
        Button3.ForeColor = Color.Black
        Button4.ForeColor = Color.Black
        Button5.ForeColor = Color.White
        Button6.ForeColor = Color.Black
        Button7.ForeColor = Color.Black
        Button8.ForeColor = Color.Black

        lblMaterial.Text = My.Settings.MyReflectivo

        lblTotal.Text = ((Val(txtalto.Text) * Val(txtancho.Text) * Val(lblMaterial.Text)) / 144 + lblDiseño.Text) * Val(txtcantidad.Text)

        lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        lblMaterial.Text = My.Settings.MyVinil
    End Sub

    Private Sub Button8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseEnter
        Button1.BackColor = Color.Green
        Button2.BackColor = Color.Green
        Button3.BackColor = Color.Green
        Button4.BackColor = Color.Green
        Button5.BackColor = Color.Green
        Button6.BackColor = Color.Green
        Button7.BackColor = Color.Green
        Button8.BackColor = Color.Blue

        Button1.ForeColor = Color.Black
        Button2.ForeColor = Color.Black
        Button3.ForeColor = Color.Black
        Button4.ForeColor = Color.Black
        Button5.ForeColor = Color.Black
        Button6.ForeColor = Color.Black
        Button7.ForeColor = Color.Black
        Button8.ForeColor = Color.White

        lblMaterial.Text = My.Settings.MyVinil

        lblTotal.Text = ((Val(txtalto.Text) * Val(txtancho.Text) * Val(lblMaterial.Text)) / 144 + lblDiseño.Text) * Val(txtcantidad.Text)

        lblTotal.Text = Format(CDec(lblTotal.Text), "0.00")
    End Sub

    Private Sub EDITARPRECIOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITARPRECIOSToolStripMenuItem.Click
        F_PreciosMateriales.Show()

    End Sub

    Private Sub EDITARPRECIOSDISEÑOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITARPRECIOSDISEÑOSToolStripMenuItem.Click
        F_PreciosDiseños.Show()

    End Sub
End Class