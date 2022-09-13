<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectCiudad
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
        Me.ciudad = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ciudad
        '
        Me.ciudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ciudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ciudad.FormattingEnabled = True
        Me.ciudad.Location = New System.Drawing.Point(128, 9)
        Me.ciudad.Name = "ciudad"
        Me.ciudad.Size = New System.Drawing.Size(214, 21)
        Me.ciudad.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Seleccione la Ciudad : "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(348, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 27)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Ver Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SelectCiudad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 40)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ciudad)
        Me.Controls.Add(Me.Label3)
        Me.Name = "SelectCiudad"
        Me.Text = "Ciudad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ciudad As System.Windows.Forms.ComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
