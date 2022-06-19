<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_PEspeciales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_PEspeciales))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Muestra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Examen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Resultado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.LblId = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtSexo = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxtMuestra = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPaciente = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SystemLetonaDataSet = New Sistema_Clinico.SystemLetonaDataSet()
        Me.PEspecialesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PEspecialesTableAdapter = New Sistema_Clinico.SystemLetonaDataSetTableAdapters.PEspecialesTableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.TxtReferencia = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TxtNota = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.PanelFSH = New System.Windows.Forms.Panel()
        Me.ButtonFSH = New System.Windows.Forms.Button()
        Me.LblVFSH = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TxtFSH = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LabelFSH = New System.Windows.Forms.Label()
        Me.PanelProlactina = New System.Windows.Forms.Panel()
        Me.ButtonProlac = New System.Windows.Forms.Button()
        Me.LblVProlac = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtProlactina = New System.Windows.Forms.TextBox()
        Me.LabelProlac = New System.Windows.Forms.Label()
        Me.PanelAnti = New System.Windows.Forms.Panel()
        Me.ButtonAnti = New System.Windows.Forms.Button()
        Me.LblVAnti = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxtAnti = New System.Windows.Forms.TextBox()
        Me.LabelAnti = New System.Windows.Forms.Label()
        Me.PanelTesto = New System.Windows.Forms.Panel()
        Me.ButtonTesto = New System.Windows.Forms.Button()
        Me.LblVTesto = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TxtTesto = New System.Windows.Forms.TextBox()
        Me.LabelTesto = New System.Windows.Forms.Label()
        Me.PanelInsulina2 = New System.Windows.Forms.Panel()
        Me.ButtonInsu2 = New System.Windows.Forms.Button()
        Me.LblVInsu2 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TxtInsulina2 = New System.Windows.Forms.TextBox()
        Me.LabelInsu2 = New System.Windows.Forms.Label()
        Me.PanelT3_Libre = New System.Windows.Forms.Panel()
        Me.ButtonT3L = New System.Windows.Forms.Button()
        Me.LabelT3L = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TxtT3_Libre = New System.Windows.Forms.TextBox()
        Me.PanelInsulina = New System.Windows.Forms.Panel()
        Me.ButtonInsu = New System.Windows.Forms.Button()
        Me.LblVInsu = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TxtInsulina = New System.Windows.Forms.TextBox()
        Me.LabelInsu = New System.Windows.Forms.Label()
        Me.PanelT4_Libre = New System.Windows.Forms.Panel()
        Me.ButtonT4L = New System.Windows.Forms.Button()
        Me.LblVT4L = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtT4_Libre = New System.Windows.Forms.TextBox()
        Me.LabelT4L = New System.Windows.Forms.Label()
        Me.PanelT4 = New System.Windows.Forms.Panel()
        Me.ButtonT4 = New System.Windows.Forms.Button()
        Me.LblVT4 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtT4 = New System.Windows.Forms.TextBox()
        Me.LabelT4 = New System.Windows.Forms.Label()
        Me.PanelT3 = New System.Windows.Forms.Panel()
        Me.ButtonT3 = New System.Windows.Forms.Button()
        Me.LblVT3 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtT3 = New System.Windows.Forms.TextBox()
        Me.LabelT3 = New System.Windows.Forms.Label()
        Me.PanelTSH = New System.Windows.Forms.Panel()
        Me.ButtonTSH = New System.Windows.Forms.Button()
        Me.LblVTSH = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtTSH = New System.Windows.Forms.TextBox()
        Me.LabelTSH = New System.Windows.Forms.Label()
        Me.PaneltTabla = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PanelTitulo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SystemLetonaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEspecialesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.PanelFSH.SuspendLayout()
        Me.PanelProlactina.SuspendLayout()
        Me.PanelAnti.SuspendLayout()
        Me.PanelTesto.SuspendLayout()
        Me.PanelInsulina2.SuspendLayout()
        Me.PanelT3_Libre.SuspendLayout()
        Me.PanelInsulina.SuspendLayout()
        Me.PanelT4_Libre.SuspendLayout()
        Me.PanelT4.SuspendLayout()
        Me.PanelT3.SuspendLayout()
        Me.PanelTSH.SuspendLayout()
        Me.PaneltTabla.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.BtnEnviar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 504)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(732, 74)
        Me.Panel1.TabIndex = 19
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Muestra, Me.Examen, Me.Resultado, Me.Observacion})
        Me.DataGridView1.Location = New System.Drawing.Point(64, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 96)
        Me.DataGridView1.TabIndex = 33
        Me.DataGridView1.Visible = False
        '
        'Muestra
        '
        Me.Muestra.HeaderText = "Muestra"
        Me.Muestra.Name = "Muestra"
        '
        'Examen
        '
        Me.Examen.HeaderText = "Examen"
        Me.Examen.Name = "Examen"
        '
        'Resultado
        '
        Me.Resultado.HeaderText = "Resultado"
        Me.Resultado.Name = "Resultado"
        '
        'Observacion
        '
        Me.Observacion.HeaderText = "Observacion"
        Me.Observacion.Name = "Observacion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 58)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ReImprimir Muestra"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(121, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 46)
        Me.Button1.TabIndex = 58
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 59
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
        Me.BtnEnviar.Location = New System.Drawing.Point(542, 13)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(138, 49)
        Me.BtnEnviar.TabIndex = 53
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.LblId)
        Me.PanelTitulo.Controls.Add(Me.Panel2)
        Me.PanelTitulo.Controls.Add(Me.Label1)
        Me.PanelTitulo.Controls.Add(Me.BunifuSeparator2)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(732, 129)
        Me.PanelTitulo.TabIndex = 18
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblId.Location = New System.Drawing.Point(679, 17)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(18, 13)
        Me.LblId.TabIndex = 19
        Me.LblId.Text = "ID"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TxtSexo)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.TxtFecha)
        Me.Panel2.Controls.Add(Me.TxtMuestra)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.TxtIdentidad)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.TxtEdad)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TxtPaciente)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(732, 83)
        Me.Panel2.TabIndex = 1
        '
        'TxtSexo
        '
        Me.TxtSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSexo.FormattingEnabled = True
        Me.TxtSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.TxtSexo.Location = New System.Drawing.Point(590, 9)
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.Size = New System.Drawing.Size(121, 24)
        Me.TxtSexo.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(546, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "FECHA"
        '
        'TxtFecha
        '
        Me.TxtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtFecha.Location = New System.Drawing.Point(591, 42)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(116, 22)
        Me.TxtFecha.TabIndex = 6
        '
        'TxtMuestra
        '
        Me.TxtMuestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMuestra.Location = New System.Drawing.Point(418, 42)
        Me.TxtMuestra.Name = "TxtMuestra"
        Me.TxtMuestra.Size = New System.Drawing.Size(80, 22)
        Me.TxtMuestra.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(342, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "# MUESTRA"
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdentidad.Location = New System.Drawing.Point(84, 9)
        Me.TxtIdentidad.MaxLength = 13
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(232, 22)
        Me.TxtIdentidad.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "IDENTIDAD"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(548, 14)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "SEXO"
        '
        'TxtEdad
        '
        Me.TxtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEdad.Location = New System.Drawing.Point(418, 9)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(80, 22)
        Me.TxtEdad.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(375, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "EDAD"
        '
        'TxtPaciente
        '
        Me.TxtPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaciente.Location = New System.Drawing.Point(84, 42)
        Me.TxtPaciente.Name = "TxtPaciente"
        Me.TxtPaciente.Size = New System.Drawing.Size(232, 22)
        Me.TxtPaciente.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "PACIENTE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRUEBAS ESPECIALES"
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(3, 26)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(722, 35)
        Me.BunifuSeparator2.TabIndex = 4
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'SystemLetonaDataSet
        '
        Me.SystemLetonaDataSet.DataSetName = "SystemLetonaDataSet"
        Me.SystemLetonaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PEspecialesBindingSource
        '
        Me.PEspecialesBindingSource.DataMember = "PEspeciales"
        Me.PEspecialesBindingSource.DataSource = Me.SystemLetonaDataSet
        '
        'PEspecialesTableAdapter
        '
        Me.PEspecialesTableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.PanelFSH)
        Me.Panel3.Controls.Add(Me.PanelProlactina)
        Me.Panel3.Controls.Add(Me.PanelAnti)
        Me.Panel3.Controls.Add(Me.PanelTesto)
        Me.Panel3.Controls.Add(Me.PanelInsulina2)
        Me.Panel3.Controls.Add(Me.PanelT3_Libre)
        Me.Panel3.Controls.Add(Me.PanelInsulina)
        Me.Panel3.Controls.Add(Me.PanelT4_Libre)
        Me.Panel3.Controls.Add(Me.PanelT4)
        Me.Panel3.Controls.Add(Me.PanelT3)
        Me.Panel3.Controls.Add(Me.PanelTSH)
        Me.Panel3.Controls.Add(Me.PaneltTabla)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 129)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(732, 375)
        Me.Panel3.TabIndex = 20
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 512)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(715, 40)
        Me.Panel4.TabIndex = 46
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel9.Controls.Add(Me.TxtReferencia)
        Me.Panel9.Controls.Add(Me.Label41)
        Me.Panel9.Controls.Add(Me.TxtNota)
        Me.Panel9.Controls.Add(Me.Label40)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 472)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(715, 40)
        Me.Panel9.TabIndex = 45
        '
        'TxtReferencia
        '
        Me.TxtReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferencia.FormattingEnabled = True
        Me.TxtReferencia.Items.AddRange(New Object() {"DR. OSWALDO LETONA"})
        Me.TxtReferencia.Location = New System.Drawing.Point(469, 11)
        Me.TxtReferencia.Name = "TxtReferencia"
        Me.TxtReferencia.Size = New System.Drawing.Size(251, 24)
        Me.TxtReferencia.TabIndex = 81
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(372, 16)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(91, 13)
        Me.Label41.TabIndex = 80
        Me.Label41.Text = "REFERIDO POR:"
        '
        'TxtNota
        '
        Me.TxtNota.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TxtNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota.Location = New System.Drawing.Point(64, 12)
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.Size = New System.Drawing.Size(300, 22)
        Me.TxtNota.TabIndex = 18
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(18, 17)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(40, 13)
        Me.Label40.TabIndex = 3
        Me.Label40.Text = "NOTA:"
        '
        'PanelFSH
        '
        Me.PanelFSH.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelFSH.Controls.Add(Me.ButtonFSH)
        Me.PanelFSH.Controls.Add(Me.LblVFSH)
        Me.PanelFSH.Controls.Add(Me.Label44)
        Me.PanelFSH.Controls.Add(Me.TxtFSH)
        Me.PanelFSH.Controls.Add(Me.TextBox2)
        Me.PanelFSH.Controls.Add(Me.LabelFSH)
        Me.PanelFSH.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFSH.Location = New System.Drawing.Point(0, 432)
        Me.PanelFSH.Name = "PanelFSH"
        Me.PanelFSH.Size = New System.Drawing.Size(715, 40)
        Me.PanelFSH.TabIndex = 44
        '
        'ButtonFSH
        '
        Me.ButtonFSH.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonFSH.FlatAppearance.BorderSize = 0
        Me.ButtonFSH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonFSH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonFSH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFSH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFSH.ForeColor = System.Drawing.Color.Black
        Me.ButtonFSH.Image = CType(resources.GetObject("ButtonFSH.Image"), System.Drawing.Image)
        Me.ButtonFSH.Location = New System.Drawing.Point(566, -1)
        Me.ButtonFSH.Name = "ButtonFSH"
        Me.ButtonFSH.Size = New System.Drawing.Size(49, 41)
        Me.ButtonFSH.TabIndex = 72
        Me.ButtonFSH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonFSH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonFSH.UseVisualStyleBackColor = False
        Me.ButtonFSH.Visible = False
        '
        'LblVFSH
        '
        Me.LblVFSH.AutoSize = True
        Me.LblVFSH.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVFSH.Location = New System.Drawing.Point(487, 7)
        Me.LblVFSH.Name = "LblVFSH"
        Me.LblVFSH.Size = New System.Drawing.Size(233, 48)
        Me.LblVFSH.TabIndex = 18
        Me.LblVFSH.Text = "FASE FOLICULAR: 3-11" & Global.Microsoft.VisualBasic.ChrW(9) & "               FASE LUTEA: 1-9" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MEDIO CICLO: 6-21" & Global.Microsoft.VisualBasic.ChrW(9) & "        " &
    "       POST-MENOPAUSIA 1-11" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(386, 14)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(46, 16)
        Me.Label44.TabIndex = 17
        Me.Label44.Text = "mg/dL"
        '
        'TxtFSH
        '
        Me.TxtFSH.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFSH.Location = New System.Drawing.Point(284, 9)
        Me.TxtFSH.Name = "TxtFSH"
        Me.TxtFSH.Size = New System.Drawing.Size(80, 24)
        Me.TxtFSH.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(161, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(482, 15)
        Me.TextBox2.TabIndex = 6
        '
        'LabelFSH
        '
        Me.LabelFSH.AutoSize = True
        Me.LabelFSH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFSH.Location = New System.Drawing.Point(109, 16)
        Me.LabelFSH.Name = "LabelFSH"
        Me.LabelFSH.Size = New System.Drawing.Size(28, 13)
        Me.LabelFSH.TabIndex = 3
        Me.LabelFSH.Text = "FSH"
        '
        'PanelProlactina
        '
        Me.PanelProlactina.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelProlactina.Controls.Add(Me.ButtonProlac)
        Me.PanelProlactina.Controls.Add(Me.LblVProlac)
        Me.PanelProlactina.Controls.Add(Me.Label26)
        Me.PanelProlactina.Controls.Add(Me.TxtProlactina)
        Me.PanelProlactina.Controls.Add(Me.LabelProlac)
        Me.PanelProlactina.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelProlactina.Location = New System.Drawing.Point(0, 392)
        Me.PanelProlactina.Name = "PanelProlactina"
        Me.PanelProlactina.Size = New System.Drawing.Size(715, 40)
        Me.PanelProlactina.TabIndex = 43
        '
        'ButtonProlac
        '
        Me.ButtonProlac.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonProlac.FlatAppearance.BorderSize = 0
        Me.ButtonProlac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonProlac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonProlac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProlac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProlac.ForeColor = System.Drawing.Color.Black
        Me.ButtonProlac.Image = CType(resources.GetObject("ButtonProlac.Image"), System.Drawing.Image)
        Me.ButtonProlac.Location = New System.Drawing.Point(631, 0)
        Me.ButtonProlac.Name = "ButtonProlac"
        Me.ButtonProlac.Size = New System.Drawing.Size(49, 41)
        Me.ButtonProlac.TabIndex = 71
        Me.ButtonProlac.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonProlac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonProlac.UseVisualStyleBackColor = False
        Me.ButtonProlac.Visible = False
        '
        'LblVProlac
        '
        Me.LblVProlac.AutoSize = True
        Me.LblVProlac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVProlac.Location = New System.Drawing.Point(490, 13)
        Me.LblVProlac.Name = "LblVProlac"
        Me.LblVProlac.Size = New System.Drawing.Size(101, 16)
        Me.LblVProlac.TabIndex = 10
        Me.LblVProlac.Text = "Hasta 20 ng/mL"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(375, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(46, 16)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "mg/dL"
        '
        'TxtProlactina
        '
        Me.TxtProlactina.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProlactina.Location = New System.Drawing.Point(284, 8)
        Me.TxtProlactina.Name = "TxtProlactina"
        Me.TxtProlactina.Size = New System.Drawing.Size(80, 24)
        Me.TxtProlactina.TabIndex = 16
        '
        'LabelProlac
        '
        Me.LabelProlac.AutoSize = True
        Me.LabelProlac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProlac.Location = New System.Drawing.Point(109, 16)
        Me.LabelProlac.Name = "LabelProlac"
        Me.LabelProlac.Size = New System.Drawing.Size(75, 13)
        Me.LabelProlac.TabIndex = 3
        Me.LabelProlac.Text = "PROLACTINA"
        '
        'PanelAnti
        '
        Me.PanelAnti.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelAnti.Controls.Add(Me.ButtonAnti)
        Me.PanelAnti.Controls.Add(Me.LblVAnti)
        Me.PanelAnti.Controls.Add(Me.Label29)
        Me.PanelAnti.Controls.Add(Me.TxtAnti)
        Me.PanelAnti.Controls.Add(Me.LabelAnti)
        Me.PanelAnti.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAnti.Location = New System.Drawing.Point(0, 352)
        Me.PanelAnti.Name = "PanelAnti"
        Me.PanelAnti.Size = New System.Drawing.Size(715, 40)
        Me.PanelAnti.TabIndex = 42
        '
        'ButtonAnti
        '
        Me.ButtonAnti.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonAnti.FlatAppearance.BorderSize = 0
        Me.ButtonAnti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonAnti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonAnti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAnti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnti.ForeColor = System.Drawing.Color.Black
        Me.ButtonAnti.Image = CType(resources.GetObject("ButtonAnti.Image"), System.Drawing.Image)
        Me.ButtonAnti.Location = New System.Drawing.Point(631, 1)
        Me.ButtonAnti.Name = "ButtonAnti"
        Me.ButtonAnti.Size = New System.Drawing.Size(49, 41)
        Me.ButtonAnti.TabIndex = 70
        Me.ButtonAnti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonAnti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAnti.UseVisualStyleBackColor = False
        Me.ButtonAnti.Visible = False
        '
        'LblVAnti
        '
        Me.LblVAnti.AutoSize = True
        Me.LblVAnti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVAnti.Location = New System.Drawing.Point(490, 16)
        Me.LblVAnti.Name = "LblVAnti"
        Me.LblVAnti.Size = New System.Drawing.Size(125, 16)
        Me.LblVAnti.TabIndex = 9
        Me.LblVAnti.Text = "Menor de 4.0 ng/mL"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(375, 15)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(46, 16)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "mg/dL"
        '
        'TxtAnti
        '
        Me.TxtAnti.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAnti.Location = New System.Drawing.Point(284, 8)
        Me.TxtAnti.Name = "TxtAnti"
        Me.TxtAnti.Size = New System.Drawing.Size(80, 24)
        Me.TxtAnti.TabIndex = 15
        '
        'LabelAnti
        '
        Me.LabelAnti.AutoSize = True
        Me.LabelAnti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAnti.Location = New System.Drawing.Point(109, 16)
        Me.LabelAnti.Name = "LabelAnti"
        Me.LabelAnti.Size = New System.Drawing.Size(135, 13)
        Me.LabelAnti.TabIndex = 3
        Me.LabelAnti.Text = "ANTIGENO PROSTATICO"
        '
        'PanelTesto
        '
        Me.PanelTesto.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelTesto.Controls.Add(Me.ButtonTesto)
        Me.PanelTesto.Controls.Add(Me.LblVTesto)
        Me.PanelTesto.Controls.Add(Me.Label32)
        Me.PanelTesto.Controls.Add(Me.TxtTesto)
        Me.PanelTesto.Controls.Add(Me.LabelTesto)
        Me.PanelTesto.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTesto.Location = New System.Drawing.Point(0, 312)
        Me.PanelTesto.Name = "PanelTesto"
        Me.PanelTesto.Size = New System.Drawing.Size(715, 40)
        Me.PanelTesto.TabIndex = 41
        '
        'ButtonTesto
        '
        Me.ButtonTesto.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonTesto.FlatAppearance.BorderSize = 0
        Me.ButtonTesto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonTesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonTesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTesto.ForeColor = System.Drawing.Color.Black
        Me.ButtonTesto.Image = CType(resources.GetObject("ButtonTesto.Image"), System.Drawing.Image)
        Me.ButtonTesto.Location = New System.Drawing.Point(607, -1)
        Me.ButtonTesto.Name = "ButtonTesto"
        Me.ButtonTesto.Size = New System.Drawing.Size(49, 41)
        Me.ButtonTesto.TabIndex = 69
        Me.ButtonTesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonTesto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonTesto.UseVisualStyleBackColor = False
        Me.ButtonTesto.Visible = False
        '
        'LblVTesto
        '
        Me.LblVTesto.AutoSize = True
        Me.LblVTesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVTesto.Location = New System.Drawing.Point(490, 14)
        Me.LblVTesto.Name = "LblVTesto"
        Me.LblVTesto.Size = New System.Drawing.Size(93, 16)
        Me.LblVTesto.TabIndex = 8
        Me.LblVTesto.Text = "3.0-10.0  ng/dL"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(375, 14)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(46, 16)
        Me.Label32.TabIndex = 7
        Me.Label32.Text = "mg/dL"
        '
        'TxtTesto
        '
        Me.TxtTesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTesto.Location = New System.Drawing.Point(284, 8)
        Me.TxtTesto.Name = "TxtTesto"
        Me.TxtTesto.Size = New System.Drawing.Size(80, 24)
        Me.TxtTesto.TabIndex = 14
        '
        'LabelTesto
        '
        Me.LabelTesto.AutoSize = True
        Me.LabelTesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTesto.Location = New System.Drawing.Point(109, 16)
        Me.LabelTesto.Name = "LabelTesto"
        Me.LabelTesto.Size = New System.Drawing.Size(95, 13)
        Me.LabelTesto.TabIndex = 3
        Me.LabelTesto.Text = "TESTOSTERONA"
        '
        'PanelInsulina2
        '
        Me.PanelInsulina2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelInsulina2.Controls.Add(Me.ButtonInsu2)
        Me.PanelInsulina2.Controls.Add(Me.LblVInsu2)
        Me.PanelInsulina2.Controls.Add(Me.Label35)
        Me.PanelInsulina2.Controls.Add(Me.TxtInsulina2)
        Me.PanelInsulina2.Controls.Add(Me.LabelInsu2)
        Me.PanelInsulina2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelInsulina2.Location = New System.Drawing.Point(0, 272)
        Me.PanelInsulina2.Name = "PanelInsulina2"
        Me.PanelInsulina2.Size = New System.Drawing.Size(715, 40)
        Me.PanelInsulina2.TabIndex = 40
        '
        'ButtonInsu2
        '
        Me.ButtonInsu2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonInsu2.FlatAppearance.BorderSize = 0
        Me.ButtonInsu2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonInsu2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonInsu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInsu2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInsu2.ForeColor = System.Drawing.Color.Black
        Me.ButtonInsu2.Image = CType(resources.GetObject("ButtonInsu2.Image"), System.Drawing.Image)
        Me.ButtonInsu2.Location = New System.Drawing.Point(607, 0)
        Me.ButtonInsu2.Name = "ButtonInsu2"
        Me.ButtonInsu2.Size = New System.Drawing.Size(49, 41)
        Me.ButtonInsu2.TabIndex = 68
        Me.ButtonInsu2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonInsu2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonInsu2.UseVisualStyleBackColor = False
        Me.ButtonInsu2.Visible = False
        '
        'LblVInsu2
        '
        Me.LblVInsu2.AutoSize = True
        Me.LblVInsu2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVInsu2.Location = New System.Drawing.Point(490, 14)
        Me.LblVInsu2.Name = "LblVInsu2"
        Me.LblVInsu2.Size = New System.Drawing.Size(85, 16)
        Me.LblVInsu2.TabIndex = 7
        Me.LblVInsu2.Text = "21-69 uIU/mL"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(375, 14)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(46, 16)
        Me.Label35.TabIndex = 6
        Me.Label35.Text = "mg/dL"
        '
        'TxtInsulina2
        '
        Me.TxtInsulina2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInsulina2.Location = New System.Drawing.Point(284, 8)
        Me.TxtInsulina2.Name = "TxtInsulina2"
        Me.TxtInsulina2.Size = New System.Drawing.Size(80, 24)
        Me.TxtInsulina2.TabIndex = 13
        '
        'LabelInsu2
        '
        Me.LabelInsu2.AutoSize = True
        Me.LabelInsu2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInsu2.Location = New System.Drawing.Point(109, 16)
        Me.LabelInsu2.Name = "LabelInsu2"
        Me.LabelInsu2.Size = New System.Drawing.Size(91, 13)
        Me.LabelInsu2.TabIndex = 3
        Me.LabelInsu2.Text = "INSULINA_2HPP"
        '
        'PanelT3_Libre
        '
        Me.PanelT3_Libre.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelT3_Libre.Controls.Add(Me.ButtonT3L)
        Me.PanelT3_Libre.Controls.Add(Me.LabelT3L)
        Me.PanelT3_Libre.Controls.Add(Me.Label42)
        Me.PanelT3_Libre.Controls.Add(Me.TxtT3_Libre)
        Me.PanelT3_Libre.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelT3_Libre.Location = New System.Drawing.Point(0, 235)
        Me.PanelT3_Libre.Name = "PanelT3_Libre"
        Me.PanelT3_Libre.Size = New System.Drawing.Size(715, 37)
        Me.PanelT3_Libre.TabIndex = 39
        '
        'ButtonT3L
        '
        Me.ButtonT3L.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonT3L.FlatAppearance.BorderSize = 0
        Me.ButtonT3L.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonT3L.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonT3L.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonT3L.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonT3L.ForeColor = System.Drawing.Color.Black
        Me.ButtonT3L.Image = CType(resources.GetObject("ButtonT3L.Image"), System.Drawing.Image)
        Me.ButtonT3L.Location = New System.Drawing.Point(607, -1)
        Me.ButtonT3L.Name = "ButtonT3L"
        Me.ButtonT3L.Size = New System.Drawing.Size(49, 41)
        Me.ButtonT3L.TabIndex = 67
        Me.ButtonT3L.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonT3L.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonT3L.UseVisualStyleBackColor = False
        Me.ButtonT3L.Visible = False
        '
        'LabelT3L
        '
        Me.LabelT3L.AutoSize = True
        Me.LabelT3L.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelT3L.Location = New System.Drawing.Point(109, 12)
        Me.LabelT3L.Name = "LabelT3L"
        Me.LabelT3L.Size = New System.Drawing.Size(57, 13)
        Me.LabelT3L.TabIndex = 7
        Me.LabelT3L.Text = "T3_LIBRE"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(376, 14)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(46, 16)
        Me.Label42.TabIndex = 15
        Me.Label42.Text = "mg/dL"
        '
        'TxtT3_Libre
        '
        Me.TxtT3_Libre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT3_Libre.Location = New System.Drawing.Point(285, 6)
        Me.TxtT3_Libre.Name = "TxtT3_Libre"
        Me.TxtT3_Libre.Size = New System.Drawing.Size(80, 24)
        Me.TxtT3_Libre.TabIndex = 12
        '
        'PanelInsulina
        '
        Me.PanelInsulina.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelInsulina.Controls.Add(Me.ButtonInsu)
        Me.PanelInsulina.Controls.Add(Me.LblVInsu)
        Me.PanelInsulina.Controls.Add(Me.Label39)
        Me.PanelInsulina.Controls.Add(Me.TxtInsulina)
        Me.PanelInsulina.Controls.Add(Me.LabelInsu)
        Me.PanelInsulina.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelInsulina.Location = New System.Drawing.Point(0, 195)
        Me.PanelInsulina.Name = "PanelInsulina"
        Me.PanelInsulina.Size = New System.Drawing.Size(715, 40)
        Me.PanelInsulina.TabIndex = 38
        '
        'ButtonInsu
        '
        Me.ButtonInsu.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonInsu.FlatAppearance.BorderSize = 0
        Me.ButtonInsu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonInsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonInsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonInsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInsu.ForeColor = System.Drawing.Color.Black
        Me.ButtonInsu.Image = CType(resources.GetObject("ButtonInsu.Image"), System.Drawing.Image)
        Me.ButtonInsu.Location = New System.Drawing.Point(607, -1)
        Me.ButtonInsu.Name = "ButtonInsu"
        Me.ButtonInsu.Size = New System.Drawing.Size(49, 41)
        Me.ButtonInsu.TabIndex = 66
        Me.ButtonInsu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonInsu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonInsu.UseVisualStyleBackColor = False
        Me.ButtonInsu.Visible = False
        '
        'LblVInsu
        '
        Me.LblVInsu.AutoSize = True
        Me.LblVInsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVInsu.Location = New System.Drawing.Point(490, 13)
        Me.LblVInsu.Name = "LblVInsu"
        Me.LblVInsu.Size = New System.Drawing.Size(106, 16)
        Me.LblVInsu.TabIndex = 13
        Me.LblVInsu.Text = "Hasta 20 uIU/mL"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(375, 16)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(46, 16)
        Me.Label39.TabIndex = 12
        Me.Label39.Text = "mg/dL"
        '
        'TxtInsulina
        '
        Me.TxtInsulina.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInsulina.Location = New System.Drawing.Point(284, 8)
        Me.TxtInsulina.Name = "TxtInsulina"
        Me.TxtInsulina.Size = New System.Drawing.Size(80, 24)
        Me.TxtInsulina.TabIndex = 11
        '
        'LabelInsu
        '
        Me.LabelInsu.AutoSize = True
        Me.LabelInsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInsu.Location = New System.Drawing.Point(109, 16)
        Me.LabelInsu.Name = "LabelInsu"
        Me.LabelInsu.Size = New System.Drawing.Size(57, 13)
        Me.LabelInsu.TabIndex = 3
        Me.LabelInsu.Text = "INSULINA"
        '
        'PanelT4_Libre
        '
        Me.PanelT4_Libre.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelT4_Libre.Controls.Add(Me.ButtonT4L)
        Me.PanelT4_Libre.Controls.Add(Me.LblVT4L)
        Me.PanelT4_Libre.Controls.Add(Me.Label19)
        Me.PanelT4_Libre.Controls.Add(Me.TxtT4_Libre)
        Me.PanelT4_Libre.Controls.Add(Me.LabelT4L)
        Me.PanelT4_Libre.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelT4_Libre.Location = New System.Drawing.Point(0, 155)
        Me.PanelT4_Libre.Name = "PanelT4_Libre"
        Me.PanelT4_Libre.Size = New System.Drawing.Size(715, 40)
        Me.PanelT4_Libre.TabIndex = 37
        '
        'ButtonT4L
        '
        Me.ButtonT4L.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonT4L.FlatAppearance.BorderSize = 0
        Me.ButtonT4L.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonT4L.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonT4L.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonT4L.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonT4L.ForeColor = System.Drawing.Color.Black
        Me.ButtonT4L.Image = CType(resources.GetObject("ButtonT4L.Image"), System.Drawing.Image)
        Me.ButtonT4L.Location = New System.Drawing.Point(607, 1)
        Me.ButtonT4L.Name = "ButtonT4L"
        Me.ButtonT4L.Size = New System.Drawing.Size(49, 41)
        Me.ButtonT4L.TabIndex = 65
        Me.ButtonT4L.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonT4L.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonT4L.UseVisualStyleBackColor = False
        Me.ButtonT4L.Visible = False
        '
        'LblVT4L
        '
        Me.LblVT4L.AutoSize = True
        Me.LblVT4L.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVT4L.Location = New System.Drawing.Point(490, 13)
        Me.LblVT4L.Name = "LblVT4L"
        Me.LblVT4L.Size = New System.Drawing.Size(97, 16)
        Me.LblVT4L.TabIndex = 10
        Me.LblVT4L.Text = "0.82-1.63 ng/dL"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(375, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 16)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "mg/dL"
        '
        'TxtT4_Libre
        '
        Me.TxtT4_Libre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT4_Libre.Location = New System.Drawing.Point(284, 8)
        Me.TxtT4_Libre.Name = "TxtT4_Libre"
        Me.TxtT4_Libre.Size = New System.Drawing.Size(80, 24)
        Me.TxtT4_Libre.TabIndex = 10
        '
        'LabelT4L
        '
        Me.LabelT4L.AutoSize = True
        Me.LabelT4L.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelT4L.Location = New System.Drawing.Point(109, 16)
        Me.LabelT4L.Name = "LabelT4L"
        Me.LabelT4L.Size = New System.Drawing.Size(57, 13)
        Me.LabelT4L.TabIndex = 3
        Me.LabelT4L.Text = "T4_LIBRE"
        '
        'PanelT4
        '
        Me.PanelT4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelT4.Controls.Add(Me.ButtonT4)
        Me.PanelT4.Controls.Add(Me.LblVT4)
        Me.PanelT4.Controls.Add(Me.Label18)
        Me.PanelT4.Controls.Add(Me.TxtT4)
        Me.PanelT4.Controls.Add(Me.LabelT4)
        Me.PanelT4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelT4.Location = New System.Drawing.Point(0, 115)
        Me.PanelT4.Name = "PanelT4"
        Me.PanelT4.Size = New System.Drawing.Size(715, 40)
        Me.PanelT4.TabIndex = 36
        '
        'ButtonT4
        '
        Me.ButtonT4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonT4.FlatAppearance.BorderSize = 0
        Me.ButtonT4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonT4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonT4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonT4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonT4.ForeColor = System.Drawing.Color.Black
        Me.ButtonT4.Image = CType(resources.GetObject("ButtonT4.Image"), System.Drawing.Image)
        Me.ButtonT4.Location = New System.Drawing.Point(607, -1)
        Me.ButtonT4.Name = "ButtonT4"
        Me.ButtonT4.Size = New System.Drawing.Size(49, 41)
        Me.ButtonT4.TabIndex = 64
        Me.ButtonT4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonT4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonT4.UseVisualStyleBackColor = False
        Me.ButtonT4.Visible = False
        '
        'LblVT4
        '
        Me.LblVT4.AutoSize = True
        Me.LblVT4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVT4.Location = New System.Drawing.Point(490, 16)
        Me.LblVT4.Name = "LblVT4"
        Me.LblVT4.Size = New System.Drawing.Size(104, 16)
        Me.LblVT4.TabIndex = 9
        Me.LblVT4.Text = "5.10-14.10 ug/dL"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(375, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 16)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "mg/dL"
        '
        'TxtT4
        '
        Me.TxtT4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT4.Location = New System.Drawing.Point(284, 8)
        Me.TxtT4.Name = "TxtT4"
        Me.TxtT4.Size = New System.Drawing.Size(80, 24)
        Me.TxtT4.TabIndex = 9
        '
        'LabelT4
        '
        Me.LabelT4.AutoSize = True
        Me.LabelT4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelT4.Location = New System.Drawing.Point(109, 16)
        Me.LabelT4.Name = "LabelT4"
        Me.LabelT4.Size = New System.Drawing.Size(20, 13)
        Me.LabelT4.TabIndex = 3
        Me.LabelT4.Text = "T4"
        '
        'PanelT3
        '
        Me.PanelT3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelT3.Controls.Add(Me.ButtonT3)
        Me.PanelT3.Controls.Add(Me.LblVT3)
        Me.PanelT3.Controls.Add(Me.Label17)
        Me.PanelT3.Controls.Add(Me.TxtT3)
        Me.PanelT3.Controls.Add(Me.LabelT3)
        Me.PanelT3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelT3.Location = New System.Drawing.Point(0, 75)
        Me.PanelT3.Name = "PanelT3"
        Me.PanelT3.Size = New System.Drawing.Size(715, 40)
        Me.PanelT3.TabIndex = 35
        '
        'ButtonT3
        '
        Me.ButtonT3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonT3.FlatAppearance.BorderSize = 0
        Me.ButtonT3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonT3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonT3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonT3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonT3.ForeColor = System.Drawing.Color.Black
        Me.ButtonT3.Image = CType(resources.GetObject("ButtonT3.Image"), System.Drawing.Image)
        Me.ButtonT3.Location = New System.Drawing.Point(607, -1)
        Me.ButtonT3.Name = "ButtonT3"
        Me.ButtonT3.Size = New System.Drawing.Size(49, 41)
        Me.ButtonT3.TabIndex = 63
        Me.ButtonT3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonT3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonT3.UseVisualStyleBackColor = False
        Me.ButtonT3.Visible = False
        '
        'LblVT3
        '
        Me.LblVT3.AutoSize = True
        Me.LblVT3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVT3.Location = New System.Drawing.Point(490, 14)
        Me.LblVT3.Name = "LblVT3"
        Me.LblVT3.Size = New System.Drawing.Size(103, 16)
        Me.LblVT3.TabIndex = 8
        Me.LblVT3.Text = "1.30-3.10 nmol/L"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(375, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 16)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "mg/dL"
        '
        'TxtT3
        '
        Me.TxtT3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT3.Location = New System.Drawing.Point(284, 8)
        Me.TxtT3.Name = "TxtT3"
        Me.TxtT3.Size = New System.Drawing.Size(80, 24)
        Me.TxtT3.TabIndex = 8
        '
        'LabelT3
        '
        Me.LabelT3.AutoSize = True
        Me.LabelT3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelT3.Location = New System.Drawing.Point(109, 16)
        Me.LabelT3.Name = "LabelT3"
        Me.LabelT3.Size = New System.Drawing.Size(20, 13)
        Me.LabelT3.TabIndex = 3
        Me.LabelT3.Text = "T3"
        '
        'PanelTSH
        '
        Me.PanelTSH.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelTSH.Controls.Add(Me.ButtonTSH)
        Me.PanelTSH.Controls.Add(Me.LblVTSH)
        Me.PanelTSH.Controls.Add(Me.Label16)
        Me.PanelTSH.Controls.Add(Me.TxtTSH)
        Me.PanelTSH.Controls.Add(Me.LabelTSH)
        Me.PanelTSH.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTSH.Location = New System.Drawing.Point(0, 35)
        Me.PanelTSH.Name = "PanelTSH"
        Me.PanelTSH.Size = New System.Drawing.Size(715, 40)
        Me.PanelTSH.TabIndex = 34
        '
        'ButtonTSH
        '
        Me.ButtonTSH.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonTSH.FlatAppearance.BorderSize = 0
        Me.ButtonTSH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonTSH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonTSH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTSH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTSH.ForeColor = System.Drawing.Color.Black
        Me.ButtonTSH.Image = CType(resources.GetObject("ButtonTSH.Image"), System.Drawing.Image)
        Me.ButtonTSH.Location = New System.Drawing.Point(607, -1)
        Me.ButtonTSH.Name = "ButtonTSH"
        Me.ButtonTSH.Size = New System.Drawing.Size(49, 41)
        Me.ButtonTSH.TabIndex = 62
        Me.ButtonTSH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonTSH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonTSH.UseVisualStyleBackColor = False
        Me.ButtonTSH.Visible = False
        '
        'LblVTSH
        '
        Me.LblVTSH.AutoSize = True
        Me.LblVTSH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVTSH.Location = New System.Drawing.Point(490, 14)
        Me.LblVTSH.Name = "LblVTSH"
        Me.LblVTSH.Size = New System.Drawing.Size(98, 16)
        Me.LblVTSH.TabIndex = 7
        Me.LblVTSH.Text = "0.30-4.20 mlU/L"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(375, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 16)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "mg/dL"
        '
        'TxtTSH
        '
        Me.TxtTSH.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTSH.Location = New System.Drawing.Point(284, 8)
        Me.TxtTSH.Name = "TxtTSH"
        Me.TxtTSH.Size = New System.Drawing.Size(80, 24)
        Me.TxtTSH.TabIndex = 7
        '
        'LabelTSH
        '
        Me.LabelTSH.AutoSize = True
        Me.LabelTSH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTSH.Location = New System.Drawing.Point(109, 16)
        Me.LabelTSH.Name = "LabelTSH"
        Me.LabelTSH.Size = New System.Drawing.Size(29, 13)
        Me.LabelTSH.TabIndex = 3
        Me.LabelTSH.Text = "TSH"
        '
        'PaneltTabla
        '
        Me.PaneltTabla.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PaneltTabla.Controls.Add(Me.Label4)
        Me.PaneltTabla.Controls.Add(Me.Label3)
        Me.PaneltTabla.Controls.Add(Me.Label2)
        Me.PaneltTabla.Controls.Add(Me.BunifuSeparator1)
        Me.PaneltTabla.Dock = System.Windows.Forms.DockStyle.Top
        Me.PaneltTabla.Location = New System.Drawing.Point(0, 0)
        Me.PaneltTabla.Name = "PaneltTabla"
        Me.PaneltTabla.Size = New System.Drawing.Size(715, 35)
        Me.PaneltTabla.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(471, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "VALOR DE REFERENCIA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(282, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "RESULTADOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "EXAMENES"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(31, 13)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(663, 35)
        Me.BunifuSeparator1.TabIndex = 3
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'F_PEspeciales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(732, 578)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTitulo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_PEspeciales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRUEBAS ESPECIALES"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.SystemLetonaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEspecialesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.PanelFSH.ResumeLayout(False)
        Me.PanelFSH.PerformLayout()
        Me.PanelProlactina.ResumeLayout(False)
        Me.PanelProlactina.PerformLayout()
        Me.PanelAnti.ResumeLayout(False)
        Me.PanelAnti.PerformLayout()
        Me.PanelTesto.ResumeLayout(False)
        Me.PanelTesto.PerformLayout()
        Me.PanelInsulina2.ResumeLayout(False)
        Me.PanelInsulina2.PerformLayout()
        Me.PanelT3_Libre.ResumeLayout(False)
        Me.PanelT3_Libre.PerformLayout()
        Me.PanelInsulina.ResumeLayout(False)
        Me.PanelInsulina.PerformLayout()
        Me.PanelT4_Libre.ResumeLayout(False)
        Me.PanelT4_Libre.PerformLayout()
        Me.PanelT4.ResumeLayout(False)
        Me.PanelT4.PerformLayout()
        Me.PanelT3.ResumeLayout(False)
        Me.PanelT3.PerformLayout()
        Me.PanelTSH.ResumeLayout(False)
        Me.PanelTSH.PerformLayout()
        Me.PaneltTabla.ResumeLayout(False)
        Me.PaneltTabla.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents LblId As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtSexo As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtFecha As DateTimePicker
    Friend WithEvents TxtMuestra As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtIdentidad As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtPaciente As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Muestra As DataGridViewTextBoxColumn
    Friend WithEvents Examen As DataGridViewTextBoxColumn
    Friend WithEvents Resultado As DataGridViewTextBoxColumn
    Friend WithEvents Observacion As DataGridViewTextBoxColumn
    Friend WithEvents SystemLetonaDataSet As SystemLetonaDataSet
    Friend WithEvents PEspecialesBindingSource As BindingSource
    Friend WithEvents PEspecialesTableAdapter As SystemLetonaDataSetTableAdapters.PEspecialesTableAdapter
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TxtReferencia As ComboBox
    Friend WithEvents Label41 As Label
    Friend WithEvents TxtNota As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents PanelFSH As Panel
    Friend WithEvents ButtonFSH As Button
    Friend WithEvents LblVFSH As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents TxtFSH As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LabelFSH As Label
    Friend WithEvents PanelProlactina As Panel
    Friend WithEvents ButtonProlac As Button
    Friend WithEvents LblVProlac As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TxtProlactina As TextBox
    Friend WithEvents LabelProlac As Label
    Friend WithEvents PanelAnti As Panel
    Friend WithEvents ButtonAnti As Button
    Friend WithEvents LblVAnti As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents TxtAnti As TextBox
    Friend WithEvents LabelAnti As Label
    Friend WithEvents PanelTesto As Panel
    Friend WithEvents ButtonTesto As Button
    Friend WithEvents LblVTesto As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents TxtTesto As TextBox
    Friend WithEvents LabelTesto As Label
    Friend WithEvents PanelInsulina2 As Panel
    Friend WithEvents ButtonInsu2 As Button
    Friend WithEvents LblVInsu2 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents TxtInsulina2 As TextBox
    Friend WithEvents LabelInsu2 As Label
    Friend WithEvents PanelT3_Libre As Panel
    Friend WithEvents ButtonT3L As Button
    Friend WithEvents LabelT3L As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents TxtT3_Libre As TextBox
    Friend WithEvents PanelInsulina As Panel
    Friend WithEvents ButtonInsu As Button
    Friend WithEvents LblVInsu As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents TxtInsulina As TextBox
    Friend WithEvents LabelInsu As Label
    Friend WithEvents PanelT4_Libre As Panel
    Friend WithEvents ButtonT4L As Button
    Friend WithEvents LblVT4L As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtT4_Libre As TextBox
    Friend WithEvents LabelT4L As Label
    Friend WithEvents PanelT4 As Panel
    Friend WithEvents ButtonT4 As Button
    Friend WithEvents LblVT4 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtT4 As TextBox
    Friend WithEvents LabelT4 As Label
    Friend WithEvents PanelT3 As Panel
    Friend WithEvents ButtonT3 As Button
    Friend WithEvents LblVT3 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtT3 As TextBox
    Friend WithEvents LabelT3 As Label
    Friend WithEvents PanelTSH As Panel
    Friend WithEvents ButtonTSH As Button
    Friend WithEvents LblVTSH As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtTSH As TextBox
    Friend WithEvents LabelTSH As Label
    Friend WithEvents PaneltTabla As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Panel4 As Panel
End Class
