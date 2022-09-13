<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Informacion
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblMac = New System.Windows.Forms.Label()
        Me.LblIP = New System.Windows.Forms.Label()
        Me.LblEquipo = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Direccion MAC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Direccion IP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre del Equipo"
        '
        'LblMac
        '
        Me.LblMac.AutoSize = True
        Me.LblMac.Location = New System.Drawing.Point(195, 68)
        Me.LblMac.Name = "LblMac"
        Me.LblMac.Size = New System.Drawing.Size(78, 13)
        Me.LblMac.TabIndex = 3
        Me.LblMac.Text = "Direccion MAC"
        '
        'LblIP
        '
        Me.LblIP.AutoSize = True
        Me.LblIP.Location = New System.Drawing.Point(195, 117)
        Me.LblIP.Name = "LblIP"
        Me.LblIP.Size = New System.Drawing.Size(65, 13)
        Me.LblIP.TabIndex = 4
        Me.LblIP.Text = "Direccion IP"
        '
        'LblEquipo
        '
        Me.LblEquipo.AutoSize = True
        Me.LblEquipo.Location = New System.Drawing.Point(195, 170)
        Me.LblEquipo.Name = "LblEquipo"
        Me.LblEquipo.Size = New System.Drawing.Size(97, 13)
        Me.LblEquipo.TabIndex = 5
        Me.LblEquipo.Text = "Nombre del Equipo"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(198, 225)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'F_Informacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 280)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LblEquipo)
        Me.Controls.Add(Me.LblIP)
        Me.Controls.Add(Me.LblMac)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "F_Informacion"
        Me.Text = "F_Informacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblMac As Label
    Friend WithEvents LblIP As Label
    Friend WithEvents LblEquipo As Label
    Friend WithEvents TextBox1 As TextBox
End Class
