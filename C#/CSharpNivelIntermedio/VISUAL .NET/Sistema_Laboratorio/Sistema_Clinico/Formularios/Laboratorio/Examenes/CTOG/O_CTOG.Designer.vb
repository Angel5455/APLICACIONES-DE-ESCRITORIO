<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class O_CTOG
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBoxO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxA = New System.Windows.Forms.CheckBox()
        Me.CheckBoxM = New System.Windows.Forms.CheckBox()
        Me.CheckBoxC = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(62, 171)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "C"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(22, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "A"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CheckBoxO
        '
        Me.CheckBoxO.AutoSize = True
        Me.CheckBoxO.Location = New System.Drawing.Point(17, 128)
        Me.CheckBoxO.Name = "CheckBoxO"
        Me.CheckBoxO.Size = New System.Drawing.Size(63, 17)
        Me.CheckBoxO.TabIndex = 10
        Me.CheckBoxO.Text = "3 Horas"
        Me.CheckBoxO.UseVisualStyleBackColor = True
        '
        'CheckBoxA
        '
        Me.CheckBoxA.AutoSize = True
        Me.CheckBoxA.Location = New System.Drawing.Point(17, 92)
        Me.CheckBoxA.Name = "CheckBoxA"
        Me.CheckBoxA.Size = New System.Drawing.Size(63, 17)
        Me.CheckBoxA.TabIndex = 9
        Me.CheckBoxA.Text = "2 Horas"
        Me.CheckBoxA.UseVisualStyleBackColor = True
        '
        'CheckBoxM
        '
        Me.CheckBoxM.AutoSize = True
        Me.CheckBoxM.Location = New System.Drawing.Point(17, 59)
        Me.CheckBoxM.Name = "CheckBoxM"
        Me.CheckBoxM.Size = New System.Drawing.Size(58, 17)
        Me.CheckBoxM.TabIndex = 8
        Me.CheckBoxM.Text = "1 Hora"
        Me.CheckBoxM.UseVisualStyleBackColor = True
        '
        'CheckBoxC
        '
        Me.CheckBoxC.AutoSize = True
        Me.CheckBoxC.Location = New System.Drawing.Point(17, 22)
        Me.CheckBoxC.Name = "CheckBoxC"
        Me.CheckBoxC.Size = New System.Drawing.Size(61, 17)
        Me.CheckBoxC.TabIndex = 7
        Me.CheckBoxC.Text = "Ayunas"
        Me.CheckBoxC.UseVisualStyleBackColor = True
        '
        'O_CTOG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(114, 219)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBoxO)
        Me.Controls.Add(Me.CheckBoxA)
        Me.Controls.Add(Me.CheckBoxM)
        Me.Controls.Add(Me.CheckBoxC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "O_CTOG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "O_CTOG"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBoxO As CheckBox
    Friend WithEvents CheckBoxA As CheckBox
    Friend WithEvents CheckBoxM As CheckBox
    Friend WithEvents CheckBoxC As CheckBox
End Class
