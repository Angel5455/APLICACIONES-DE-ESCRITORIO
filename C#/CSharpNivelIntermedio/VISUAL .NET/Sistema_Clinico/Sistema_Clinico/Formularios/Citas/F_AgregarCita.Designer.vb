<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_AgregarCita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_AgregarCita))
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.LblText = New System.Windows.Forms.Label()
        Me.IconCerrar = New System.Windows.Forms.PictureBox()
        Me.TxtIdentidad = New System.Windows.Forms.MaskedTextBox()
        Me.lblIdentidad = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPaciente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtEstado = New System.Windows.Forms.ComboBox()
        Me.BunifuCheckbox1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TxtHora = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.PanelHeader.SuspendLayout()
        CType(Me.IconCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.LblText)
        Me.PanelHeader.Controls.Add(Me.IconCerrar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(695, 40)
        Me.PanelHeader.TabIndex = 9
        '
        'LblText
        '
        Me.LblText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblText.AutoSize = True
        Me.LblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblText.ForeColor = System.Drawing.Color.White
        Me.LblText.Location = New System.Drawing.Point(12, 9)
        Me.LblText.Name = "LblText"
        Me.LblText.Size = New System.Drawing.Size(110, 20)
        Me.LblText.TabIndex = 52
        Me.LblText.Text = "Agregar Cita"
        '
        'IconCerrar
        '
        Me.IconCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconCerrar.Image = CType(resources.GetObject("IconCerrar.Image"), System.Drawing.Image)
        Me.IconCerrar.Location = New System.Drawing.Point(668, 12)
        Me.IconCerrar.Name = "IconCerrar"
        Me.IconCerrar.Size = New System.Drawing.Size(15, 15)
        Me.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconCerrar.TabIndex = 0
        Me.IconCerrar.TabStop = False
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdentidad.Location = New System.Drawing.Point(26, 162)
        Me.TxtIdentidad.Mask = "0000000000000"
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(112, 22)
        Me.TxtIdentidad.TabIndex = 32
        '
        'lblIdentidad
        '
        Me.lblIdentidad.AutoSize = True
        Me.lblIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentidad.Location = New System.Drawing.Point(23, 140)
        Me.lblIdentidad.Name = "lblIdentidad"
        Me.lblIdentidad.Size = New System.Drawing.Size(64, 16)
        Me.lblIdentidad.TabIndex = 45
        Me.lblIdentidad.Text = "Identidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 16)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Observaciones"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(205, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 16)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Hora"
        '
        'TxtFecha
        '
        Me.TxtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecha.Location = New System.Drawing.Point(391, 87)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(266, 22)
        Me.TxtFecha.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(388, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Fecha"
        '
        'TxtPaciente
        '
        Me.TxtPaciente.Enabled = False
        Me.TxtPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaciente.Location = New System.Drawing.Point(26, 87)
        Me.TxtPaciente.Name = "TxtPaciente"
        Me.TxtPaciente.Size = New System.Drawing.Size(278, 22)
        Me.TxtPaciente.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 16)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Paciente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(388, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Telefono"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(391, 162)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(155, 22)
        Me.TxtTelefono.TabIndex = 34
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservaciones.Location = New System.Drawing.Point(25, 232)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtObservaciones.Size = New System.Drawing.Size(642, 98)
        Me.TxtObservaciones.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Estado"
        '
        'TxtEstado
        '
        Me.TxtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEstado.FormattingEnabled = True
        Me.TxtEstado.Items.AddRange(New Object() {"Aprobado", "Pendiente"})
        Me.TxtEstado.Location = New System.Drawing.Point(79, 355)
        Me.TxtEstado.Name = "TxtEstado"
        Me.TxtEstado.Size = New System.Drawing.Size(167, 24)
        Me.TxtEstado.TabIndex = 48
        '
        'BunifuCheckbox1
        '
        Me.BunifuCheckbox1.BackColor = System.Drawing.Color.Gray
        Me.BunifuCheckbox1.ChechedOffColor = System.Drawing.Color.Gray
        Me.BunifuCheckbox1.Checked = False
        Me.BunifuCheckbox1.CheckedOnColor = System.Drawing.Color.Teal
        Me.BunifuCheckbox1.ForeColor = System.Drawing.Color.White
        Me.BunifuCheckbox1.Location = New System.Drawing.Point(353, 358)
        Me.BunifuCheckbox1.Name = "BunifuCheckbox1"
        Me.BunifuCheckbox1.Size = New System.Drawing.Size(20, 20)
        Me.BunifuCheckbox1.TabIndex = 49
        Me.BunifuCheckbox1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(388, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Enviar SMS"
        Me.Label4.Visible = False
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackColor = System.Drawing.Color.Teal
        Me.BtnEnviar.FlatAppearance.BorderSize = 0
        Me.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviar.ForeColor = System.Drawing.Color.White
        Me.BtnEnviar.Image = CType(resources.GetObject("BtnEnviar.Image"), System.Drawing.Image)
        Me.BtnEnviar.Location = New System.Drawing.Point(529, 411)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(138, 49)
        Me.BtnEnviar.TabIndex = 56
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Teal
        Me.BtnEliminar.FlatAppearance.BorderSize = 0
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.Location = New System.Drawing.Point(25, 411)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(138, 49)
        Me.BtnEliminar.TabIndex = 58
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEliminar.UseVisualStyleBackColor = False
        Me.BtnEliminar.Visible = False
        '
        'TxtHora
        '
        Me.TxtHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHora.Location = New System.Drawing.Point(208, 162)
        Me.TxtHora.Name = "TxtHora"
        Me.TxtHora.Size = New System.Drawing.Size(110, 22)
        Me.TxtHora.TabIndex = 33
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.White
        Me.BtnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MintCream
        Me.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(300, 87)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(37, 23)
        Me.BtnBuscar.TabIndex = 74
        Me.BtnBuscar.Text = "..."
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'F_AgregarCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(695, 486)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtHora)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BunifuCheckbox1)
        Me.Controls.Add(Me.TxtEstado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.TxtIdentidad)
        Me.Controls.Add(Me.lblIdentidad)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPaciente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PanelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_AgregarCita"
        Me.Text = "F_AgregarCita"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.IconCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents PanelHeader As Panel
    Friend WithEvents LblText As Label
    Private WithEvents IconCerrar As PictureBox
    Friend WithEvents TxtIdentidad As MaskedTextBox
    Friend WithEvents lblIdentidad As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtFecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPaciente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtEstado As ComboBox
    Friend WithEvents BunifuCheckbox1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TxtHora As TextBox
    Friend WithEvents BtnBuscar As Button
End Class
