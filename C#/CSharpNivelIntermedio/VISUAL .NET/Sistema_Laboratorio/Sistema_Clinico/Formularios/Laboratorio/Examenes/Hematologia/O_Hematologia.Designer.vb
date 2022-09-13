<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class O_Hematologia
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
        Me.CheckBoxTP = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHemo = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHema = New System.Windows.Forms.CheckBox()
        Me.CheckBoxVes = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTSD = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRC = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTC = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTT = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTyR = New System.Windows.Forms.CheckBox()
        Me.CheckBoxINR = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRA = New System.Windows.Forms.CheckBox()
        Me.CheckBoxRRN = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTSI = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckBoxTP
        '
        Me.CheckBoxTP.AutoSize = True
        Me.CheckBoxTP.Location = New System.Drawing.Point(24, 127)
        Me.CheckBoxTP.Name = "CheckBoxTP"
        Me.CheckBoxTP.Size = New System.Drawing.Size(117, 17)
        Me.CheckBoxTP.TabIndex = 14
        Me.CheckBoxTP.Text = "Tiempo Protombina"
        Me.CheckBoxTP.UseVisualStyleBackColor = True
        '
        'CheckBoxHemo
        '
        Me.CheckBoxHemo.AutoSize = True
        Me.CheckBoxHemo.Location = New System.Drawing.Point(24, 91)
        Me.CheckBoxHemo.Name = "CheckBoxHemo"
        Me.CheckBoxHemo.Size = New System.Drawing.Size(88, 17)
        Me.CheckBoxHemo.TabIndex = 13
        Me.CheckBoxHemo.Text = "Hemoglobina"
        Me.CheckBoxHemo.UseVisualStyleBackColor = True
        '
        'CheckBoxHema
        '
        Me.CheckBoxHema.AutoSize = True
        Me.CheckBoxHema.Location = New System.Drawing.Point(24, 58)
        Me.CheckBoxHema.Name = "CheckBoxHema"
        Me.CheckBoxHema.Size = New System.Drawing.Size(83, 17)
        Me.CheckBoxHema.TabIndex = 12
        Me.CheckBoxHema.Text = "Hematocrito"
        Me.CheckBoxHema.UseVisualStyleBackColor = True
        '
        'CheckBoxVes
        '
        Me.CheckBoxVes.AutoSize = True
        Me.CheckBoxVes.Location = New System.Drawing.Point(24, 21)
        Me.CheckBoxVes.Name = "CheckBoxVes"
        Me.CheckBoxVes.Size = New System.Drawing.Size(44, 17)
        Me.CheckBoxVes.TabIndex = 11
        Me.CheckBoxVes.Text = "Ves"
        Me.CheckBoxVes.UseVisualStyleBackColor = True
        '
        'CheckBoxTSD
        '
        Me.CheckBoxTSD.AutoSize = True
        Me.CheckBoxTSD.Location = New System.Drawing.Point(158, 21)
        Me.CheckBoxTSD.Name = "CheckBoxTSD"
        Me.CheckBoxTSD.Size = New System.Drawing.Size(139, 17)
        Me.CheckBoxTSD.TabIndex = 18
        Me.CheckBoxTSD.Text = "Tiempo Sangrado Duke"
        Me.CheckBoxTSD.UseVisualStyleBackColor = True
        '
        'CheckBoxRC
        '
        Me.CheckBoxRC.AutoSize = True
        Me.CheckBoxRC.Location = New System.Drawing.Point(24, 234)
        Me.CheckBoxRC.Name = "CheckBoxRC"
        Me.CheckBoxRC.Size = New System.Drawing.Size(120, 17)
        Me.CheckBoxRC.TabIndex = 17
        Me.CheckBoxRC.Text = "Retraccion Coagulo"
        Me.CheckBoxRC.UseVisualStyleBackColor = True
        '
        'CheckBoxTC
        '
        Me.CheckBoxTC.AutoSize = True
        Me.CheckBoxTC.Location = New System.Drawing.Point(24, 201)
        Me.CheckBoxTC.Name = "CheckBoxTC"
        Me.CheckBoxTC.Size = New System.Drawing.Size(123, 17)
        Me.CheckBoxTC.TabIndex = 16
        Me.CheckBoxTC.Text = "Tiempo Coagulacion"
        Me.CheckBoxTC.UseVisualStyleBackColor = True
        '
        'CheckBoxTT
        '
        Me.CheckBoxTT.AutoSize = True
        Me.CheckBoxTT.Location = New System.Drawing.Point(24, 164)
        Me.CheckBoxTT.Name = "CheckBoxTT"
        Me.CheckBoxTT.Size = New System.Drawing.Size(136, 17)
        Me.CheckBoxTT.TabIndex = 15
        Me.CheckBoxTT.Text = "Tiempo Tromboplastina"
        Me.CheckBoxTT.UseVisualStyleBackColor = True
        '
        'CheckBoxTyR
        '
        Me.CheckBoxTyR.AutoSize = True
        Me.CheckBoxTyR.Location = New System.Drawing.Point(158, 201)
        Me.CheckBoxTyR.Name = "CheckBoxTyR"
        Me.CheckBoxTyR.Size = New System.Drawing.Size(74, 17)
        Me.CheckBoxTyR.TabIndex = 23
        Me.CheckBoxTyR.Text = "Tipo y RH"
        Me.CheckBoxTyR.UseVisualStyleBackColor = True
        '
        'CheckBoxINR
        '
        Me.CheckBoxINR.AutoSize = True
        Me.CheckBoxINR.Location = New System.Drawing.Point(158, 164)
        Me.CheckBoxINR.Name = "CheckBoxINR"
        Me.CheckBoxINR.Size = New System.Drawing.Size(45, 17)
        Me.CheckBoxINR.TabIndex = 22
        Me.CheckBoxINR.Text = "INR"
        Me.CheckBoxINR.UseVisualStyleBackColor = True
        '
        'CheckBoxRA
        '
        Me.CheckBoxRA.AutoSize = True
        Me.CheckBoxRA.Location = New System.Drawing.Point(158, 127)
        Me.CheckBoxRA.Name = "CheckBoxRA"
        Me.CheckBoxRA.Size = New System.Drawing.Size(97, 17)
        Me.CheckBoxRA.TabIndex = 21
        Me.CheckBoxRA.Text = "Reticulocitos A"
        Me.CheckBoxRA.UseVisualStyleBackColor = True
        '
        'CheckBoxRRN
        '
        Me.CheckBoxRRN.AutoSize = True
        Me.CheckBoxRRN.Location = New System.Drawing.Point(158, 91)
        Me.CheckBoxRRN.Name = "CheckBoxRRN"
        Me.CheckBoxRRN.Size = New System.Drawing.Size(106, 17)
        Me.CheckBoxRRN.TabIndex = 20
        Me.CheckBoxRRN.Text = "Reticulocitos RN"
        Me.CheckBoxRRN.UseVisualStyleBackColor = True
        '
        'CheckBoxTSI
        '
        Me.CheckBoxTSI.AutoSize = True
        Me.CheckBoxTSI.Location = New System.Drawing.Point(158, 58)
        Me.CheckBoxTSI.Name = "CheckBoxTSI"
        Me.CheckBoxTSI.Size = New System.Drawing.Size(126, 17)
        Me.CheckBoxTSI.TabIndex = 19
        Me.CheckBoxTSI.Text = "Tiempo Sangrado IVI"
        Me.CheckBoxTSI.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(241, 275)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "C"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(189, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "A"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'O_Hematologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(315, 327)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBoxTyR)
        Me.Controls.Add(Me.CheckBoxINR)
        Me.Controls.Add(Me.CheckBoxRA)
        Me.Controls.Add(Me.CheckBoxRRN)
        Me.Controls.Add(Me.CheckBoxTSI)
        Me.Controls.Add(Me.CheckBoxTSD)
        Me.Controls.Add(Me.CheckBoxRC)
        Me.Controls.Add(Me.CheckBoxTC)
        Me.Controls.Add(Me.CheckBoxTT)
        Me.Controls.Add(Me.CheckBoxTP)
        Me.Controls.Add(Me.CheckBoxHemo)
        Me.Controls.Add(Me.CheckBoxHema)
        Me.Controls.Add(Me.CheckBoxVes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "O_Hematologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "O_Hematologia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxTP As CheckBox
    Friend WithEvents CheckBoxHemo As CheckBox
    Friend WithEvents CheckBoxHema As CheckBox
    Friend WithEvents CheckBoxVes As CheckBox
    Friend WithEvents CheckBoxTSD As CheckBox
    Friend WithEvents CheckBoxRC As CheckBox
    Friend WithEvents CheckBoxTC As CheckBox
    Friend WithEvents CheckBoxTT As CheckBox
    Friend WithEvents CheckBoxTyR As CheckBox
    Friend WithEvents CheckBoxINR As CheckBox
    Friend WithEvents CheckBoxRA As CheckBox
    Friend WithEvents CheckBoxRRN As CheckBox
    Friend WithEvents CheckBoxTSI As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
