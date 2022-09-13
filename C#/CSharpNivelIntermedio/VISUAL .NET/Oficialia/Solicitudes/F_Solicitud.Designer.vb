<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Solicitud
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTgr = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtExpediente = New System.Windows.Forms.TextBox()
        Me.txtPersona = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCaja = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSolicitud = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFechaS = New System.Windows.Forms.DateTimePicker()
        Me.txtFechaRes = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFechaE = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFechaRem = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAuto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSolicitante = New System.Windows.Forms.TextBox()
        Me.txtFRes = New System.Windows.Forms.TextBox()
        Me.txtFrem = New System.Windows.Forms.TextBox()
        Me.txtFsol = New System.Windows.Forms.TextBox()
        Me.txtFEnv = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AGREGAR SOLICITUD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(495, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nº TGR"
        '
        'txtTgr
        '
        Me.txtTgr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTgr.Location = New System.Drawing.Point(617, 146)
        Me.txtTgr.Name = "txtTgr"
        Me.txtTgr.Size = New System.Drawing.Size(100, 24)
        Me.txtTgr.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Id Solicitante"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentidad.Location = New System.Drawing.Point(172, 146)
        Me.txtIdentidad.Mask = "9999-9999-99999"
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(140, 24)
        Me.txtIdentidad.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nº Expediente"
        '
        'txtExpediente
        '
        Me.txtExpediente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpediente.Location = New System.Drawing.Point(172, 97)
        Me.txtExpediente.Name = "txtExpediente"
        Me.txtExpediente.Size = New System.Drawing.Size(100, 24)
        Me.txtExpediente.TabIndex = 0
        '
        'txtPersona
        '
        Me.txtPersona.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersona.Location = New System.Drawing.Point(277, 253)
        Me.txtPersona.Name = "txtPersona"
        Me.txtPersona.Size = New System.Drawing.Size(440, 24)
        Me.txtPersona.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Persona Inscrita o Afectada"
        '
        'txtCaja
        '
        Me.txtCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaja.Location = New System.Drawing.Point(617, 97)
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.Size = New System.Drawing.Size(100, 24)
        Me.txtCaja.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(495, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Nº Caja"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Tipo de Solicitud"
        '
        'txtSolicitud
        '
        Me.txtSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSolicitud.FormattingEnabled = True
        Me.txtSolicitud.Items.AddRange(New Object() {"Rectificacion de Matrimonio", "Rectificacion de Nacimiento", "Rectificacion de Defuncion", "Rectificacion de Oficio", "Reposicion de Nacimiento", "Reposicion de Defuncion", "Reposicion de Matrimonio", "Reposicion de Oficio"})
        Me.txtSolicitud.Location = New System.Drawing.Point(172, 305)
        Me.txtSolicitud.Name = "txtSolicitud"
        Me.txtSolicitud.Size = New System.Drawing.Size(209, 26)
        Me.txtSolicitud.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(437, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Fecha de Solicitud"
        '
        'txtFechaS
        '
        Me.txtFechaS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaS.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaS.Location = New System.Drawing.Point(583, 305)
        Me.txtFechaS.Name = "txtFechaS"
        Me.txtFechaS.Size = New System.Drawing.Size(134, 24)
        Me.txtFechaS.TabIndex = 7
        '
        'txtFechaRes
        '
        Me.txtFechaRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaRes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaRes.Location = New System.Drawing.Point(220, 360)
        Me.txtFechaRes.Name = "txtFechaRes"
        Me.txtFechaRes.Size = New System.Drawing.Size(134, 24)
        Me.txtFechaRes.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(47, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 18)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Fecha de Resolucion"
        '
        'txtFechaE
        '
        Me.txtFechaE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaE.Location = New System.Drawing.Point(583, 360)
        Me.txtFechaE.Name = "txtFechaE"
        Me.txtFechaE.Size = New System.Drawing.Size(134, 24)
        Me.txtFechaE.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(458, 365)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Fecha de Envio"
        '
        'txtFechaRem
        '
        Me.txtFechaRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaRem.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaRem.Location = New System.Drawing.Point(220, 410)
        Me.txtFechaRem.Name = "txtFechaRem"
        Me.txtFechaRem.Size = New System.Drawing.Size(134, 24)
        Me.txtFechaRem.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(47, 415)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 18)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Fecha de Remision"
        '
        'txtAuto
        '
        Me.txtAuto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuto.Location = New System.Drawing.Point(583, 412)
        Me.txtAuto.Name = "txtAuto"
        Me.txtAuto.Size = New System.Drawing.Size(134, 24)
        Me.txtAuto.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(399, 415)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(167, 18)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Auto para mejor proveer"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(580, 495)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 39)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(429, 495)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 39)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "GUARDAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(718, 23)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(22, 18)
        Me.lblId.TabIndex = 24
        Me.lblId.Text = "ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(47, 203)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 18)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Solicitante"
        '
        'txtSolicitante
        '
        Me.txtSolicitante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSolicitante.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSolicitante.Location = New System.Drawing.Point(172, 203)
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.Size = New System.Drawing.Size(545, 24)
        Me.txtSolicitante.TabIndex = 4
        '
        'txtFRes
        '
        Me.txtFRes.Location = New System.Drawing.Point(41, 342)
        Me.txtFRes.Name = "txtFRes"
        Me.txtFRes.Size = New System.Drawing.Size(100, 20)
        Me.txtFRes.TabIndex = 26
        Me.txtFRes.Visible = False
        '
        'txtFrem
        '
        Me.txtFrem.Location = New System.Drawing.Point(41, 392)
        Me.txtFrem.Name = "txtFrem"
        Me.txtFrem.Size = New System.Drawing.Size(100, 20)
        Me.txtFrem.TabIndex = 27
        Me.txtFrem.Visible = False
        '
        'txtFsol
        '
        Me.txtFsol.Location = New System.Drawing.Point(580, 279)
        Me.txtFsol.Name = "txtFsol"
        Me.txtFsol.Size = New System.Drawing.Size(100, 20)
        Me.txtFsol.TabIndex = 28
        Me.txtFsol.Visible = False
        '
        'txtFEnv
        '
        Me.txtFEnv.Location = New System.Drawing.Point(583, 335)
        Me.txtFEnv.Name = "txtFEnv"
        Me.txtFEnv.Size = New System.Drawing.Size(100, 20)
        Me.txtFEnv.TabIndex = 29
        Me.txtFEnv.Visible = False
        '
        'F_Solicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(779, 569)
        Me.Controls.Add(Me.txtFEnv)
        Me.Controls.Add(Me.txtFsol)
        Me.Controls.Add(Me.txtFrem)
        Me.Controls.Add(Me.txtFRes)
        Me.Controls.Add(Me.txtSolicitante)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtAuto)
        Me.Controls.Add(Me.txtFechaRem)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtFechaE)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtFechaRes)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtFechaS)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSolicitud)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCaja)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPersona)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtExpediente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIdentidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTgr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Solicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGREGAR SOLICITUD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTgr As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIdentidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtExpediente As System.Windows.Forms.TextBox
    Friend WithEvents txtPersona As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCaja As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSolicitud As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFechaS As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFechaRes As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtFechaE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFechaRem As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAuto As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSolicitante As System.Windows.Forms.TextBox
    Friend WithEvents txtFRes As System.Windows.Forms.TextBox
    Friend WithEvents txtFrem As System.Windows.Forms.TextBox
    Friend WithEvents txtFsol As System.Windows.Forms.TextBox
    Friend WithEvents txtFEnv As System.Windows.Forms.TextBox
End Class
