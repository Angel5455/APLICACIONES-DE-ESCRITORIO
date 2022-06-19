<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class O_Drogas
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
        Me.CheckBoxC = New System.Windows.Forms.CheckBox()
        Me.CheckBoxM = New System.Windows.Forms.CheckBox()
        Me.CheckBoxA = New System.Windows.Forms.CheckBox()
        Me.CheckBoxO = New System.Windows.Forms.CheckBox()
        Me.CheckBoxB = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckBoxC
        '
        Me.CheckBoxC.AutoSize = True
        Me.CheckBoxC.Location = New System.Drawing.Point(24, 33)
        Me.CheckBoxC.Name = "CheckBoxC"
        Me.CheckBoxC.Size = New System.Drawing.Size(65, 17)
        Me.CheckBoxC.TabIndex = 0
        Me.CheckBoxC.Text = "Cocaina"
        Me.CheckBoxC.UseVisualStyleBackColor = True
        '
        'CheckBoxM
        '
        Me.CheckBoxM.AutoSize = True
        Me.CheckBoxM.Location = New System.Drawing.Point(24, 70)
        Me.CheckBoxM.Name = "CheckBoxM"
        Me.CheckBoxM.Size = New System.Drawing.Size(76, 17)
        Me.CheckBoxM.TabIndex = 1
        Me.CheckBoxM.Text = "Marihuana"
        Me.CheckBoxM.UseVisualStyleBackColor = True
        '
        'CheckBoxA
        '
        Me.CheckBoxA.AutoSize = True
        Me.CheckBoxA.Location = New System.Drawing.Point(24, 103)
        Me.CheckBoxA.Name = "CheckBoxA"
        Me.CheckBoxA.Size = New System.Drawing.Size(84, 17)
        Me.CheckBoxA.TabIndex = 2
        Me.CheckBoxA.Text = "Anfetaminas"
        Me.CheckBoxA.UseVisualStyleBackColor = True
        '
        'CheckBoxO
        '
        Me.CheckBoxO.AutoSize = True
        Me.CheckBoxO.Location = New System.Drawing.Point(24, 139)
        Me.CheckBoxO.Name = "CheckBoxO"
        Me.CheckBoxO.Size = New System.Drawing.Size(70, 17)
        Me.CheckBoxO.TabIndex = 3
        Me.CheckBoxO.Text = "Opiaseos"
        Me.CheckBoxO.UseVisualStyleBackColor = True
        '
        'CheckBoxB
        '
        Me.CheckBoxB.AutoSize = True
        Me.CheckBoxB.Location = New System.Drawing.Point(24, 177)
        Me.CheckBoxB.Name = "CheckBoxB"
        Me.CheckBoxB.Size = New System.Drawing.Size(101, 17)
        Me.CheckBoxB.TabIndex = 4
        Me.CheckBoxB.Text = "Benzodiazepina"
        Me.CheckBoxB.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(51, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "A"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(91, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(34, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "C"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'O_Drogas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(138, 255)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBoxB)
        Me.Controls.Add(Me.CheckBoxO)
        Me.Controls.Add(Me.CheckBoxA)
        Me.Controls.Add(Me.CheckBoxM)
        Me.Controls.Add(Me.CheckBoxC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "O_Drogas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "O_Drogas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBoxC As CheckBox
    Friend WithEvents CheckBoxM As CheckBox
    Friend WithEvents CheckBoxA As CheckBox
    Friend WithEvents CheckBoxO As CheckBox
    Friend WithEvents CheckBoxB As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
