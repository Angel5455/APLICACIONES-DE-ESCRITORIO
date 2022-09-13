<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_AgregarDocumentos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_AgregarDocumentos))
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPaciente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnFoto = New System.Windows.Forms.Button()
        Me.LblId = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.LblOpcion = New System.Windows.Forms.Label()
        Me.BtnCaptura = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(21, 101)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDescripcion.Size = New System.Drawing.Size(569, 98)
        Me.TxtDescripcion.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(18, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Descripcion"
        '
        'TxtFecha
        '
        Me.TxtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecha.Location = New System.Drawing.Point(324, 38)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(266, 22)
        Me.TxtFecha.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(321, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Fecha"
        '
        'TxtPaciente
        '
        Me.TxtPaciente.Enabled = False
        Me.TxtPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaciente.Location = New System.Drawing.Point(21, 38)
        Me.TxtPaciente.Name = "TxtPaciente"
        Me.TxtPaciente.Size = New System.Drawing.Size(232, 22)
        Me.TxtPaciente.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Paciente"
        '
        'BtnFoto
        '
        Me.BtnFoto.BackColor = System.Drawing.Color.White
        Me.BtnFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFoto.Location = New System.Drawing.Point(21, 402)
        Me.BtnFoto.Name = "BtnFoto"
        Me.BtnFoto.Size = New System.Drawing.Size(108, 30)
        Me.BtnFoto.TabIndex = 54
        Me.BtnFoto.Text = "Adjuntar"
        Me.BtnFoto.UseVisualStyleBackColor = False
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblId.ForeColor = System.Drawing.Color.White
        Me.LblId.Location = New System.Drawing.Point(348, 333)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(19, 18)
        Me.LblId.TabIndex = 56
        Me.LblId.Text = "Id"
        Me.LblId.Visible = False
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.White
        Me.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
        Me.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(248, 38)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(40, 22)
        Me.BtnBuscar.TabIndex = 74
        Me.BtnBuscar.Text = "..."
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'LblOpcion
        '
        Me.LblOpcion.AutoSize = True
        Me.LblOpcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOpcion.ForeColor = System.Drawing.Color.White
        Me.LblOpcion.Location = New System.Drawing.Point(348, 375)
        Me.LblOpcion.Name = "LblOpcion"
        Me.LblOpcion.Size = New System.Drawing.Size(56, 18)
        Me.LblOpcion.TabIndex = 57
        Me.LblOpcion.Text = "Opcion"
        Me.LblOpcion.Visible = False
        '
        'BtnCaptura
        '
        Me.BtnCaptura.BackColor = System.Drawing.Color.White
        Me.BtnCaptura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCaptura.Location = New System.Drawing.Point(135, 402)
        Me.BtnCaptura.Name = "BtnCaptura"
        Me.BtnCaptura.Size = New System.Drawing.Size(108, 30)
        Me.BtnCaptura.TabIndex = 75
        Me.BtnCaptura.Text = "Captura"
        Me.BtnCaptura.UseVisualStyleBackColor = False
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackColor = System.Drawing.Color.White
        Me.BtnEnviar.FlatAppearance.BorderSize = 0
        Me.BtnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.BtnEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviar.ForeColor = System.Drawing.Color.Black
        Me.BtnEnviar.Image = CType(resources.GetObject("BtnEnviar.Image"), System.Drawing.Image)
        Me.BtnEnviar.Location = New System.Drawing.Point(452, 375)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(138, 49)
        Me.BtnEnviar.TabIndex = 55
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'PicFoto
        '
        Me.PicFoto.Image = CType(resources.GetObject("PicFoto.Image"), System.Drawing.Image)
        Me.PicFoto.Location = New System.Drawing.Point(21, 211)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(222, 183)
        Me.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicFoto.TabIndex = 53
        Me.PicFoto.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PicFoto, "Ver Imagen")
        '
        'F_AgregarDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(623, 451)
        Me.Controls.Add(Me.BtnCaptura)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.LblOpcion)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.BtnFoto)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPaciente)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_AgregarDocumentos"
        Me.Text = "Agregar Documentos"
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPaciente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents BtnFoto As Button
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents LblId As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents LblOpcion As Label
    Friend WithEvents BtnCaptura As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ToolTip1 As ToolTip
End Class
