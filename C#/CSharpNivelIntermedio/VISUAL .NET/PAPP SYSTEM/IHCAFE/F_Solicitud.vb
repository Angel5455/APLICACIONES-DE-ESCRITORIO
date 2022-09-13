Imports System.Data.SqlClient

Public Class F_Solicitud

    Dim accion As Boolean
    Dim numero As Double

    Sub limpiar()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If txtclave.Text <> " - -    " And txtIdentidad.Text <> "    -    -" And txtnombre.Text <> "" And txtedad.Text <> "" And txtestado.Text <> "" And txtconyuge.Text <> "" And txtdomicilio.Text <> "" And txtaldea.Text <> "" And txtmunicipio.Text <> "" And txtdepartamento.Text <> "" And txtMontoS.Text <> "" And txtplazo.Text <> "" And txtLugarI.Text <> "" And txtFpagos.Text <> "" And txtDestino.Text <> "" And txtAportacionP.Text <> "" And txtManzanas.Text <> "" Then

            Button3.Enabled = True

            Dim conexion As New Conexion_Solicitud
            Dim datos As New dSolicitud

            datos.nSolicitud = lblNSolicitud.Text
            datos.Fase = lblfase.Text
            datos.clave = txtclave.Text
            datos.identidad = txtIdentidad.Text
            datos.nombre = txtnombre.Text
            datos.edad = txtedad.Text
            datos.fechaN = txtfechaN.Text
            datos.estado = txtestado.Text
            datos.conyuge = txtconyuge.Text
            datos.domicilio = txtdomicilio.Text
            datos.aldea = txtaldea.Text
            datos.municipio = txtmunicipio.Text
            datos.departamento = txtdepartamento.Text
            datos.monto = txtMontoS.Text
            datos.plazo = txtplazo.Text
            datos.lugar = txtLugarI.Text
            datos.pago = txtFpagos.Text
            datos.destino = txtDestino.Text
            datos.aportacion = txtAportacionP.Text
            datos.fechaS = txtfechaS.Text
            datos.fechaV = txtfechaV.Text
            datos.letras = lblMonto.Text
            datos.manzanas = txtManzanas.Text

            If conexion.insertar_datos_solicitud(datos) Then

                MessageBox.Show("REGISTRO AGREGADO", "AGREGAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                My.Settings.MySolicitud = lblNSolicitud.Text
                My.Settings.Save()
                My.Settings.Reload()

                Dim resp As Integer


                resp = MsgBox("¿Desea Imprimir la Solicitud?", MsgBoxStyle.YesNo, "P.A.P.P System")

                If resp = 6 Then


                    Dim conexion2 As New Conexion_Solicitud
                    Dim datos2 As New dSolicitud
                    Dim tabla As New DataTable
                    Dim mireporte As New Crys_Solicitud

                    datos.clave = txtclave.Text

                    If conexion2.consultar_solicitud(datos) Then

                        tabla = conexion2.tabla
                        mireporte.SetDataSource(tabla)
                        R_Solicitud.CrystalReportViewer1.ReportSource = mireporte
                        R_Solicitud.CrystalReportViewer1.RefreshReport()
                        R_Solicitud.Show()


                    End If



                End If



            Else

                MessageBox.Show("REGISTRO NO AGREGADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If



            limpiar()




        Else


            MsgBox("No se permiten campos en blanco", MsgBoxStyle.Exclamation, "P.A.P.P System")

            If txtclave.Text = " - -" Then

                txtclave.BackColor = Color.OrangeRed
            Else

                txtclave.BackColor = Color.White

            End If

            If txtIdentidad.Text = "    -    -" Then

                txtIdentidad.BackColor = Color.OrangeRed
            Else

                txtIdentidad.BackColor = Color.White

            End If


            If txtnombre.Text = "" Then

                txtnombre.BackColor = Color.OrangeRed
            Else

                txtnombre.BackColor = Color.White

            End If

            If txtedad.Text = "" Then

                txtedad.BackColor = Color.OrangeRed
            Else

                txtedad.BackColor = Color.White

            End If


            If txtestado.Text = "" Then

                txtestado.BackColor = Color.OrangeRed
            Else

                txtestado.BackColor = Color.White

            End If


            If txtnombre.Text = "" Then

                txtconyuge.BackColor = Color.OrangeRed
            Else

                txtconyuge.BackColor = Color.White

            End If


            If txtdomicilio.Text = "" Then

                txtdomicilio.BackColor = Color.OrangeRed
            Else

                txtdomicilio.BackColor = Color.White

            End If

            If txtaldea.Text = "" Then

                txtaldea.BackColor = Color.OrangeRed
            Else

                txtaldea.BackColor = Color.White

            End If

            If txtmunicipio.Text = "" Then

                txtmunicipio.BackColor = Color.OrangeRed
            Else

                txtmunicipio.BackColor = Color.White

            End If


            If txtdepartamento.Text = "" Then

                txtdepartamento.BackColor = Color.OrangeRed
            Else

                txtdepartamento.BackColor = Color.White

            End If


            If txtplazo.Text = "" Then

                txtplazo.BackColor = Color.OrangeRed
            Else

                txtplazo.BackColor = Color.White

            End If


            If txtMontoS.Text = "" Then

                txtMontoS.BackColor = Color.OrangeRed
            Else

                txtMontoS.BackColor = Color.White

            End If


            If txtLugarI.Text = "" Then

                txtLugarI.BackColor = Color.OrangeRed
            Else

                txtLugarI.BackColor = Color.White

            End If

            If txtFpagos.Text = "" Then

                txtFpagos.BackColor = Color.OrangeRed
            Else

                txtFpagos.BackColor = Color.White

            End If


            If txtManzanas.Text = "" Then

                txtManzanas.BackColor = Color.OrangeRed
            Else

                txtManzanas.BackColor = Color.White

            End If


            If txtDestino.Text = "" Then

                txtDestino.BackColor = Color.OrangeRed
            Else

                txtDestino.BackColor = Color.White

            End If


            If txtAportacionP.Text = "" Then

                txtAportacionP.BackColor = Color.OrangeRed
            Else

                txtAportacionP.BackColor = Color.White

            End If


        End If




    End Sub


    Public Function Num2Text(ByVal value As Double) As String


        Select Case value
            Case 0 : Num2Text = "CERO"
            Case 1 : Num2Text = "UN"
            Case 2 : Num2Text = "DOS"
            Case 3 : Num2Text = "TRES"
            Case 4 : Num2Text = "CUATRO"
            Case 5 : Num2Text = "CINCO"
            Case 6 : Num2Text = "SEIS"
            Case 7 : Num2Text = "SIETE"
            Case 8 : Num2Text = "OCHO"
            Case 9 : Num2Text = "NUEVE"
            Case 10 : Num2Text = "DIEZ"
            Case 11 : Num2Text = "ONCE"
            Case 12 : Num2Text = "DOCE"
            Case 13 : Num2Text = "TRECE"
            Case 14 : Num2Text = "CATORCE"
            Case 15 : Num2Text = "QUINCE"
            Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
            Case 20 : Num2Text = "VEINTE"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
            Case 30 : Num2Text = "TREINTA"
            Case 40 : Num2Text = "CUARENTA"
            Case 50 : Num2Text = "CINCUENTA"
            Case 60 : Num2Text = "SESENTA"
            Case 70 : Num2Text = "SETENTA"
            Case 80 : Num2Text = "OCHENTA"
            Case 90 : Num2Text = "NOVENTA"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
            Case 100 : Num2Text = "CIEN"
            Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num2Text = "QUINIENTOS"
            Case 700 : Num2Text = "SETECIENTOS"
            Case 900 : Num2Text = "NOVECIENTOS"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "MIL"
            Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "UN MILLON"
            Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
            Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES "
                If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : Num2Text = "UN BILLON"
            Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select

    End Function

    Private Sub F_Solicitud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        txtfechaV.Value = DateAdd(DateInterval.Year, 6, txtfechaN.Value)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ' lblaño.Text = Year(Now())


        ' Dim fecha As Integer

        ' fecha = Val(lblaño.Text) + 6



        ' Dim date1 As New System.DateTime(fecha, 1, 1)



        'Dim date2 As System.DateTime = Now()
        'Dim tsResult As System.TimeSpan

        '       tsResult = date1.Subtract(date2)

        'MsgBox("Faltan " & tsResult.Days.ToString & _
        ' " días, " & tsResult.Hours.ToString & _
        ' " horas y " & tsResult.Minutes.ToString & _
        ' " minutos para el " & fecha)


    End Sub

    Private Sub txtedad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtedad.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub


    Private Sub txtedad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtedad.TextChanged

    End Sub

    Private Sub txtMontoS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoS.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Private Sub txtMontoS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoS.TextChanged

        lblMonto.Text = ""
        If IsNumeric(txtMontoS.Text) Then
            lblMonto.Text = Letras(txtMontoS.Text)
        Else
            MessageBox.Show("Ingrese por favor el Monto a solicitar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        

    End Sub

    Private Sub txtManzanas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtManzanas.KeyPress
        If Char.IsLetter(e.KeyChar) Then

            e.Handled = True

        End If
    End Sub

    Public Function Letras(ByVal numero As String) As String
        '********Declara variables de tipo cadena************
        Dim palabras, entero, dec, flag As String

        '********Declara variables de tipo entero***********
        Dim num, x, y As Integer

        flag = "N"

        '**********Número Negativo***********
        If Mid(numero, 1, 1) = "-" Then
            numero = Mid(numero, 2, numero.ToString.Length - 1).ToString
            palabras = "menos "
        End If

        '**********Si tiene ceros a la izquierda*************
        For x = 1 To numero.ToString.Length
            If Mid(numero, 1, 1) = "0" Then
                numero = Trim(Mid(numero, 2, numero.ToString.Length).ToString)
                If Trim(numero.ToString.Length) = 0 Then palabras = ""
            Else
                Exit For
            End If
        Next

        '*********Dividir parte entera y decimal************
        For y = 1 To Len(numero)
            If Mid(numero, y, 1) = "." Then
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, y, 1)
                Else
                    dec = dec + Mid(numero, y, 1)
                End If
            End If
        Next y

        If Len(dec) = 1 Then dec = dec & "0"

        '**********proceso de conversión***********
        flag = "N"

        If Val(numero) <= 999999999 Then
            For y = Len(entero) To 1 Step -1
                num = Len(entero) - (y - 1)
                Select Case y
                    Case 3, 6, 9
                        '**********Asigna las palabras para las centenas***********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" And Mid(entero, num + 2, 1) = "0" Then
                                    palabras = palabras & "Cien "
                                Else
                                    palabras = palabras & "Ciento "
                                End If
                            Case "2"
                                palabras = palabras & "Doscientos "
                            Case "3"
                                palabras = palabras & "Trescientos "
                            Case "4"
                                palabras = palabras & "Cuatrocientos "
                            Case "5"
                                palabras = palabras & "Quinientos "
                            Case "6"
                                palabras = palabras & "Seiscientos "
                            Case "7"
                                palabras = palabras & "Setecientos "
                            Case "8"
                                palabras = palabras & "Ochocientos "
                            Case "9"
                                palabras = palabras & "Novecientos "
                        End Select
                    Case 2, 5, 8
                        '*********Asigna las palabras para las decenas************
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    flag = "S"
                                    palabras = palabras & "Diez "
                                End If
                                If Mid(entero, num + 1, 1) = "1" Then
                                    flag = "S"
                                    palabras = palabras & "Once "
                                End If
                                If Mid(entero, num + 1, 1) = "2" Then
                                    flag = "S"
                                    palabras = palabras & "Doce "
                                End If
                                If Mid(entero, num + 1, 1) = "3" Then
                                    flag = "S"
                                    palabras = palabras & "Trece "
                                End If
                                If Mid(entero, num + 1, 1) = "4" Then
                                    flag = "S"
                                    palabras = palabras & "Catorce "
                                End If
                                If Mid(entero, num + 1, 1) = "5" Then
                                    flag = "S"
                                    palabras = palabras & "Quince "
                                End If
                                If Mid(entero, num + 1, 1) > "5" Then
                                    flag = "N"
                                    palabras = palabras & "Dieci"
                                End If
                            Case "2"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Veinte "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Veinti"
                                    flag = "N"
                                End If
                            Case "3"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Treinta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Treinta y "
                                    flag = "N"
                                End If
                            Case "4"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Cuarenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Cuarenta y "
                                    flag = "N"
                                End If
                            Case "5"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Cincuenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Cincuenta y "
                                    flag = "N"
                                End If
                            Case "6"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Sesenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Sesenta y "
                                    flag = "N"
                                End If
                            Case "7"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Setenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Setenta y "
                                    flag = "N"
                                End If
                            Case "8"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Ochenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Ochenta y "
                                    flag = "N"
                                End If
                            Case "9"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "Noventa "
                                    flag = "S"
                                Else
                                    palabras = palabras & "Noventa y "
                                    flag = "N"
                                End If
                        End Select
                    Case 1, 4, 7
                        '*********Asigna las palabras para las unidades*********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If flag = "N" Then
                                    If y = 1 Then
                                        palabras = palabras & "Uno "
                                    Else
                                        palabras = palabras & "Un "
                                    End If
                                End If
                            Case "2"
                                If flag = "N" Then palabras = palabras & "Dos "
                            Case "3"
                                If flag = "N" Then palabras = palabras & "Tres "
                            Case "4"
                                If flag = "N" Then palabras = palabras & "Cuatro "
                            Case "5"
                                If flag = "N" Then palabras = palabras & "Cinco "
                            Case "6"
                                If flag = "N" Then palabras = palabras & "Seis "
                            Case "7"
                                If flag = "N" Then palabras = palabras & "Siete "
                            Case "8"
                                If flag = "N" Then palabras = palabras & "Ocho "
                            Case "9"
                                If flag = "N" Then palabras = palabras & "Nueve "
                        End Select
                End Select

                '***********Asigna la palabra mil***************
                If y = 4 Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or _
                    (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And _
                    Len(entero) <= 6) Then palabras = palabras & "mil "
                End If

                '**********Asigna la palabra millón*************
                If y = 7 Then
                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                        palabras = palabras & "millón "
                    Else
                        palabras = palabras & "millones "
                    End If
                End If
            Next y

            '**********Une la parte entera y la parte decimal*************
            If dec <> "" Then
                Letras = palabras & "con " & dec
            Else
                Letras = palabras
            End If
        Else
            Letras = ""
        End If

    End Function


    Private Sub txtManzanas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtManzanas.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Enabled = False

        Dim resp As Integer

        resp = MsgBox("¿Desea Imprimir la Resolucion de Creditos?", MsgBoxStyle.YesNo, "P.A.P.P System")

        If resp = 6 Then


            Dim conexion As New Conexion_Solicitud
            Dim datos As New dSolicitud
            Dim tabla As New DataTable
            Dim mireporte As New Crys_Resolucion

            datos.nSolicitud = lblNSolicitud.Text

            If conexion.consultar_solicitud(datos) Then

                tabla = conexion.tabla
                mireporte.SetDataSource(tabla)
                R_Resolucion.CrystalReportViewer1.ReportSource = mireporte
                R_Resolucion.CrystalReportViewer1.RefreshReport()
                R_Resolucion.Show()


            End If

        End If
    End Sub

    Private Sub txtfechaN_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfechaN.ValueChanged

        Try
            txtedad.Text = (DateTime.Today.AddTicks(-Me.txtfechaN.Value.Ticks).Year - 1).ToString
        Catch ex As Exception

        End Try

    End Sub
End Class