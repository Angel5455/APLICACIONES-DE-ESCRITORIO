<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Ver
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
        Me.VerPicFoto = New System.Windows.Forms.PictureBox()
        CType(Me.VerPicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VerPicFoto
        '
        Me.VerPicFoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VerPicFoto.Location = New System.Drawing.Point(0, 0)
        Me.VerPicFoto.Name = "VerPicFoto"
        Me.VerPicFoto.Size = New System.Drawing.Size(719, 408)
        Me.VerPicFoto.TabIndex = 0
        Me.VerPicFoto.TabStop = False
        '
        'F_Ver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(719, 408)
        Me.Controls.Add(Me.VerPicFoto)
        Me.Name = "F_Ver"
        Me.Text = "Ver Documento"
        CType(Me.VerPicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VerPicFoto As PictureBox
End Class
