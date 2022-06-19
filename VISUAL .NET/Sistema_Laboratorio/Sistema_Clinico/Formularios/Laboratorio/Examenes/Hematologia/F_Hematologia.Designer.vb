<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Hematologia
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Hematologia))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TxtReferencia = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
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
        Me.HematologiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HematologiaTableAdapter = New Sistema_Clinico.SystemLetonaDataSetTableAdapters.HematologiaTableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelTipo = New System.Windows.Forms.Panel()
        Me.ButtonTipo = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Muestra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Examen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Resultado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.LabelTipo = New System.Windows.Forms.Label()
        Me.PanelINR = New System.Windows.Forms.Panel()
        Me.ButtonINR = New System.Windows.Forms.Button()
        Me.LblVINR = New System.Windows.Forms.Label()
        Me.TxtINR = New System.Windows.Forms.TextBox()
        Me.LabelINR = New System.Windows.Forms.Label()
        Me.PanelRA = New System.Windows.Forms.Panel()
        Me.ButtonA = New System.Windows.Forms.Button()
        Me.LblVRA = New System.Windows.Forms.Label()
        Me.LblRRA = New System.Windows.Forms.Label()
        Me.TxtRA = New System.Windows.Forms.TextBox()
        Me.LabelRA = New System.Windows.Forms.Label()
        Me.PanelRRN = New System.Windows.Forms.Panel()
        Me.ButtonRN = New System.Windows.Forms.Button()
        Me.LblVRRN = New System.Windows.Forms.Label()
        Me.LblRRR = New System.Windows.Forms.Label()
        Me.TxtRRN = New System.Windows.Forms.TextBox()
        Me.LabelRRN = New System.Windows.Forms.Label()
        Me.PanelSangradoI = New System.Windows.Forms.Panel()
        Me.ButtonSIvi = New System.Windows.Forms.Button()
        Me.LblVSIvi = New System.Windows.Forms.Label()
        Me.LblRSIvi = New System.Windows.Forms.Label()
        Me.TxtSangradoI = New System.Windows.Forms.TextBox()
        Me.LabelSIvi = New System.Windows.Forms.Label()
        Me.PanelSangradoD = New System.Windows.Forms.Panel()
        Me.ButtonSDuke = New System.Windows.Forms.Button()
        Me.LblVSDuke = New System.Windows.Forms.Label()
        Me.LblRSDuke = New System.Windows.Forms.Label()
        Me.TxtSangradoD = New System.Windows.Forms.TextBox()
        Me.LabelSDuke = New System.Windows.Forms.Label()
        Me.PanelRetraccion = New System.Windows.Forms.Panel()
        Me.ButtonRCoa = New System.Windows.Forms.Button()
        Me.LblVRCoa = New System.Windows.Forms.Label()
        Me.LblRRCoa = New System.Windows.Forms.Label()
        Me.TxtRetraccion = New System.Windows.Forms.TextBox()
        Me.LabelRCoa = New System.Windows.Forms.Label()
        Me.PanelCoagulacion = New System.Windows.Forms.Panel()
        Me.ButtonTCoa = New System.Windows.Forms.Button()
        Me.LblVTCoa = New System.Windows.Forms.Label()
        Me.LblRTCoa = New System.Windows.Forms.Label()
        Me.TxtCoagulacion = New System.Windows.Forms.TextBox()
        Me.LabelTCoa = New System.Windows.Forms.Label()
        Me.PanelTrombo = New System.Windows.Forms.Panel()
        Me.ButtonTrombo = New System.Windows.Forms.Button()
        Me.LblVTrombo = New System.Windows.Forms.Label()
        Me.LblRTrombo = New System.Windows.Forms.Label()
        Me.TxtTrombo = New System.Windows.Forms.TextBox()
        Me.LabelTrombo = New System.Windows.Forms.Label()
        Me.PanelProto = New System.Windows.Forms.Panel()
        Me.ButtonProtom = New System.Windows.Forms.Button()
        Me.LblVProtom = New System.Windows.Forms.Label()
        Me.LblRProtom = New System.Windows.Forms.Label()
        Me.TxtProto = New System.Windows.Forms.TextBox()
        Me.LabelProtom = New System.Windows.Forms.Label()
        Me.PanelHemoglobina = New System.Windows.Forms.Panel()
        Me.ButtonHemo = New System.Windows.Forms.Button()
        Me.LblVHemo = New System.Windows.Forms.Label()
        Me.LblRHemo = New System.Windows.Forms.Label()
        Me.TxtHemoglobina = New System.Windows.Forms.TextBox()
        Me.LabelHemo = New System.Windows.Forms.Label()
        Me.PanelHematocrito = New System.Windows.Forms.Panel()
        Me.ButtonHema = New System.Windows.Forms.Button()
        Me.LblVHema = New System.Windows.Forms.Label()
        Me.LblRHema = New System.Windows.Forms.Label()
        Me.TxtHematocrito = New System.Windows.Forms.TextBox()
        Me.LabelHema = New System.Windows.Forms.Label()
        Me.PanelVes = New System.Windows.Forms.Panel()
        Me.ButtonVes = New System.Windows.Forms.Button()
        Me.LblVVes = New System.Windows.Forms.Label()
        Me.LblRVes = New System.Windows.Forms.Label()
        Me.TxtVes = New System.Windows.Forms.TextBox()
        Me.LabelVes = New System.Windows.Forms.Label()
        Me.PaneltTabla = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelTitulo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SystemLetonaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HematologiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.PanelTipo.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelINR.SuspendLayout()
        Me.PanelRA.SuspendLayout()
        Me.PanelRRN.SuspendLayout()
        Me.PanelSangradoI.SuspendLayout()
        Me.PanelSangradoD.SuspendLayout()
        Me.PanelRetraccion.SuspendLayout()
        Me.PanelCoagulacion.SuspendLayout()
        Me.PanelTrombo.SuspendLayout()
        Me.PanelProto.SuspendLayout()
        Me.PanelHemoglobina.SuspendLayout()
        Me.PanelHematocrito.SuspendLayout()
        Me.PanelVes.SuspendLayout()
        Me.PaneltTabla.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.TxtReferencia)
        Me.Panel1.Controls.Add(Me.Label45)
        Me.Panel1.Controls.Add(Me.BtnEnviar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 426)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(732, 57)
        Me.Panel1.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 54)
        Me.GroupBox1.TabIndex = 80
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
        'TxtReferencia
        '
        Me.TxtReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferencia.FormattingEnabled = True
        Me.TxtReferencia.Items.AddRange(New Object() {"DR. OSWALDO LETONA"})
        Me.TxtReferencia.Location = New System.Drawing.Point(331, 18)
        Me.TxtReferencia.Name = "TxtReferencia"
        Me.TxtReferencia.Size = New System.Drawing.Size(167, 24)
        Me.TxtReferencia.TabIndex = 79
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(222, 25)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(91, 13)
        Me.Label45.TabIndex = 78
        Me.Label45.Text = "REFERIDO POR:"
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
        Me.BtnEnviar.Location = New System.Drawing.Point(549, 5)
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
        Me.PanelTitulo.Size = New System.Drawing.Size(732, 111)
        Me.PanelTitulo.TabIndex = 17
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblId.Location = New System.Drawing.Point(679, 12)
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
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
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
        Me.TxtSexo.TabIndex = 18
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
        Me.TxtFecha.TabIndex = 16
        '
        'TxtMuestra
        '
        Me.TxtMuestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMuestra.Location = New System.Drawing.Point(418, 42)
        Me.TxtMuestra.Name = "TxtMuestra"
        Me.TxtMuestra.Size = New System.Drawing.Size(80, 22)
        Me.TxtMuestra.TabIndex = 14
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
        Me.TxtIdentidad.Location = New System.Drawing.Point(93, 11)
        Me.TxtIdentidad.MaxLength = 13
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(232, 22)
        Me.TxtIdentidad.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 14)
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
        Me.TxtEdad.TabIndex = 7
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
        Me.TxtPaciente.Location = New System.Drawing.Point(93, 42)
        Me.TxtPaciente.Name = "TxtPaciente"
        Me.TxtPaciente.Size = New System.Drawing.Size(232, 22)
        Me.TxtPaciente.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "PACIENTE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HEMATOLOGIA"
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
        'HematologiaBindingSource
        '
        Me.HematologiaBindingSource.DataMember = "Hematologia"
        Me.HematologiaBindingSource.DataSource = Me.SystemLetonaDataSet
        '
        'HematologiaTableAdapter
        '
        Me.HematologiaTableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.PanelTipo)
        Me.Panel3.Controls.Add(Me.PanelINR)
        Me.Panel3.Controls.Add(Me.PanelRA)
        Me.Panel3.Controls.Add(Me.PanelRRN)
        Me.Panel3.Controls.Add(Me.PanelSangradoI)
        Me.Panel3.Controls.Add(Me.PanelSangradoD)
        Me.Panel3.Controls.Add(Me.PanelRetraccion)
        Me.Panel3.Controls.Add(Me.PanelCoagulacion)
        Me.Panel3.Controls.Add(Me.PanelTrombo)
        Me.Panel3.Controls.Add(Me.PanelProto)
        Me.Panel3.Controls.Add(Me.PanelHemoglobina)
        Me.Panel3.Controls.Add(Me.PanelHematocrito)
        Me.Panel3.Controls.Add(Me.PanelVes)
        Me.Panel3.Controls.Add(Me.PaneltTabla)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 111)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(732, 315)
        Me.Panel3.TabIndex = 19
        '
        'PanelTipo
        '
        Me.PanelTipo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelTipo.Controls.Add(Me.ButtonTipo)
        Me.PanelTipo.Controls.Add(Me.DataGridView1)
        Me.PanelTipo.Controls.Add(Me.TxtTipo)
        Me.PanelTipo.Controls.Add(Me.LabelTipo)
        Me.PanelTipo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTipo.Location = New System.Drawing.Point(0, 515)
        Me.PanelTipo.Name = "PanelTipo"
        Me.PanelTipo.Size = New System.Drawing.Size(715, 40)
        Me.PanelTipo.TabIndex = 46
        '
        'ButtonTipo
        '
        Me.ButtonTipo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonTipo.FlatAppearance.BorderSize = 0
        Me.ButtonTipo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonTipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTipo.ForeColor = System.Drawing.Color.Black
        Me.ButtonTipo.Image = CType(resources.GetObject("ButtonTipo.Image"), System.Drawing.Image)
        Me.ButtonTipo.Location = New System.Drawing.Point(583, -2)
        Me.ButtonTipo.Name = "ButtonTipo"
        Me.ButtonTipo.Size = New System.Drawing.Size(49, 41)
        Me.ButtonTipo.TabIndex = 94
        Me.ButtonTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonTipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonTipo.UseVisualStyleBackColor = False
        Me.ButtonTipo.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Muestra, Me.Examen, Me.Resultado, Me.Observacion})
        Me.DataGridView1.Location = New System.Drawing.Point(669, 10)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(241, 96)
        Me.DataGridView1.TabIndex = 81
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
        'TxtTipo
        '
        Me.TxtTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTipo.Location = New System.Drawing.Point(284, 8)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(264, 24)
        Me.TxtTipo.TabIndex = 5
        '
        'LabelTipo
        '
        Me.LabelTipo.AutoSize = True
        Me.LabelTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTipo.Location = New System.Drawing.Point(90, 15)
        Me.LabelTipo.Name = "LabelTipo"
        Me.LabelTipo.Size = New System.Drawing.Size(61, 13)
        Me.LabelTipo.TabIndex = 3
        Me.LabelTipo.Text = "TIPO Y RH"
        '
        'PanelINR
        '
        Me.PanelINR.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelINR.Controls.Add(Me.ButtonINR)
        Me.PanelINR.Controls.Add(Me.LblVINR)
        Me.PanelINR.Controls.Add(Me.TxtINR)
        Me.PanelINR.Controls.Add(Me.LabelINR)
        Me.PanelINR.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelINR.Location = New System.Drawing.Point(0, 475)
        Me.PanelINR.Name = "PanelINR"
        Me.PanelINR.Size = New System.Drawing.Size(715, 40)
        Me.PanelINR.TabIndex = 45
        '
        'ButtonINR
        '
        Me.ButtonINR.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonINR.FlatAppearance.BorderSize = 0
        Me.ButtonINR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonINR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonINR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonINR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonINR.ForeColor = System.Drawing.Color.Black
        Me.ButtonINR.Image = CType(resources.GetObject("ButtonINR.Image"), System.Drawing.Image)
        Me.ButtonINR.Location = New System.Drawing.Point(583, 0)
        Me.ButtonINR.Name = "ButtonINR"
        Me.ButtonINR.Size = New System.Drawing.Size(49, 41)
        Me.ButtonINR.TabIndex = 93
        Me.ButtonINR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonINR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonINR.UseVisualStyleBackColor = False
        Me.ButtonINR.Visible = False
        '
        'LblVINR
        '
        Me.LblVINR.AutoSize = True
        Me.LblVINR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVINR.Location = New System.Drawing.Point(490, 14)
        Me.LblVINR.Name = "LblVINR"
        Me.LblVINR.Size = New System.Drawing.Size(58, 16)
        Me.LblVINR.TabIndex = 8
        Me.LblVINR.Text = "0.9-1.2%"
        '
        'TxtINR
        '
        Me.TxtINR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtINR.Location = New System.Drawing.Point(284, 8)
        Me.TxtINR.Name = "TxtINR"
        Me.TxtINR.Size = New System.Drawing.Size(80, 24)
        Me.TxtINR.TabIndex = 5
        '
        'LabelINR
        '
        Me.LabelINR.AutoSize = True
        Me.LabelINR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelINR.Location = New System.Drawing.Point(123, 16)
        Me.LabelINR.Name = "LabelINR"
        Me.LabelINR.Size = New System.Drawing.Size(26, 13)
        Me.LabelINR.TabIndex = 3
        Me.LabelINR.Text = "INR"
        '
        'PanelRA
        '
        Me.PanelRA.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelRA.Controls.Add(Me.ButtonA)
        Me.PanelRA.Controls.Add(Me.LblVRA)
        Me.PanelRA.Controls.Add(Me.LblRRA)
        Me.PanelRA.Controls.Add(Me.TxtRA)
        Me.PanelRA.Controls.Add(Me.LabelRA)
        Me.PanelRA.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRA.Location = New System.Drawing.Point(0, 435)
        Me.PanelRA.Name = "PanelRA"
        Me.PanelRA.Size = New System.Drawing.Size(715, 40)
        Me.PanelRA.TabIndex = 44
        '
        'ButtonA
        '
        Me.ButtonA.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonA.FlatAppearance.BorderSize = 0
        Me.ButtonA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonA.ForeColor = System.Drawing.Color.Black
        Me.ButtonA.Image = CType(resources.GetObject("ButtonA.Image"), System.Drawing.Image)
        Me.ButtonA.Location = New System.Drawing.Point(638, 1)
        Me.ButtonA.Name = "ButtonA"
        Me.ButtonA.Size = New System.Drawing.Size(49, 41)
        Me.ButtonA.TabIndex = 92
        Me.ButtonA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonA.UseVisualStyleBackColor = False
        Me.ButtonA.Visible = False
        '
        'LblVRA
        '
        Me.LblVRA.AutoSize = True
        Me.LblVRA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVRA.Location = New System.Drawing.Point(490, 14)
        Me.LblVRA.Name = "LblVRA"
        Me.LblVRA.Size = New System.Drawing.Size(48, 16)
        Me.LblVRA.TabIndex = 8
        Me.LblVRA.Text = "0.2-2%"
        '
        'LblRRA
        '
        Me.LblRRA.AutoSize = True
        Me.LblRRA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRRA.Location = New System.Drawing.Point(375, 14)
        Me.LblRRA.Name = "LblRRA"
        Me.LblRRA.Size = New System.Drawing.Size(20, 16)
        Me.LblRRA.TabIndex = 7
        Me.LblRRA.Text = "%"
        '
        'TxtRA
        '
        Me.TxtRA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRA.Location = New System.Drawing.Point(284, 8)
        Me.TxtRA.Name = "TxtRA"
        Me.TxtRA.Size = New System.Drawing.Size(80, 24)
        Me.TxtRA.TabIndex = 5
        '
        'LabelRA
        '
        Me.LabelRA.AutoSize = True
        Me.LabelRA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRA.Location = New System.Drawing.Point(92, 17)
        Me.LabelRA.Name = "LabelRA"
        Me.LabelRA.Size = New System.Drawing.Size(103, 13)
        Me.LabelRA.TabIndex = 3
        Me.LabelRA.Text = "RETICULOCITOS A"
        '
        'PanelRRN
        '
        Me.PanelRRN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelRRN.Controls.Add(Me.ButtonRN)
        Me.PanelRRN.Controls.Add(Me.LblVRRN)
        Me.PanelRRN.Controls.Add(Me.LblRRR)
        Me.PanelRRN.Controls.Add(Me.TxtRRN)
        Me.PanelRRN.Controls.Add(Me.LabelRRN)
        Me.PanelRRN.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRRN.Location = New System.Drawing.Point(0, 395)
        Me.PanelRRN.Name = "PanelRRN"
        Me.PanelRRN.Size = New System.Drawing.Size(715, 40)
        Me.PanelRRN.TabIndex = 43
        '
        'ButtonRN
        '
        Me.ButtonRN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonRN.FlatAppearance.BorderSize = 0
        Me.ButtonRN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonRN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonRN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRN.ForeColor = System.Drawing.Color.Black
        Me.ButtonRN.Image = CType(resources.GetObject("ButtonRN.Image"), System.Drawing.Image)
        Me.ButtonRN.Location = New System.Drawing.Point(638, -1)
        Me.ButtonRN.Name = "ButtonRN"
        Me.ButtonRN.Size = New System.Drawing.Size(49, 41)
        Me.ButtonRN.TabIndex = 91
        Me.ButtonRN.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonRN.UseVisualStyleBackColor = False
        Me.ButtonRN.Visible = False
        '
        'LblVRRN
        '
        Me.LblVRRN.AutoSize = True
        Me.LblVRRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVRRN.Location = New System.Drawing.Point(490, 14)
        Me.LblVRRN.Name = "LblVRRN"
        Me.LblVRRN.Size = New System.Drawing.Size(38, 16)
        Me.LblVRRN.TabIndex = 8
        Me.LblVRRN.Text = "2-6%"
        '
        'LblRRR
        '
        Me.LblRRR.AutoSize = True
        Me.LblRRR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRRR.Location = New System.Drawing.Point(375, 14)
        Me.LblRRR.Name = "LblRRR"
        Me.LblRRR.Size = New System.Drawing.Size(20, 16)
        Me.LblRRR.TabIndex = 7
        Me.LblRRR.Text = "%"
        '
        'TxtRRN
        '
        Me.TxtRRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRRN.Location = New System.Drawing.Point(284, 8)
        Me.TxtRRN.Name = "TxtRRN"
        Me.TxtRRN.Size = New System.Drawing.Size(80, 24)
        Me.TxtRRN.TabIndex = 5
        '
        'LabelRRN
        '
        Me.LabelRRN.AutoSize = True
        Me.LabelRRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRRN.Location = New System.Drawing.Point(90, 16)
        Me.LabelRRN.Name = "LabelRRN"
        Me.LabelRRN.Size = New System.Drawing.Size(112, 13)
        Me.LabelRRN.TabIndex = 3
        Me.LabelRRN.Text = "RETICULOCITOS RN"
        '
        'PanelSangradoI
        '
        Me.PanelSangradoI.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelSangradoI.Controls.Add(Me.ButtonSIvi)
        Me.PanelSangradoI.Controls.Add(Me.LblVSIvi)
        Me.PanelSangradoI.Controls.Add(Me.LblRSIvi)
        Me.PanelSangradoI.Controls.Add(Me.TxtSangradoI)
        Me.PanelSangradoI.Controls.Add(Me.LabelSIvi)
        Me.PanelSangradoI.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSangradoI.Location = New System.Drawing.Point(0, 355)
        Me.PanelSangradoI.Name = "PanelSangradoI"
        Me.PanelSangradoI.Size = New System.Drawing.Size(715, 40)
        Me.PanelSangradoI.TabIndex = 42
        '
        'ButtonSIvi
        '
        Me.ButtonSIvi.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonSIvi.FlatAppearance.BorderSize = 0
        Me.ButtonSIvi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonSIvi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonSIvi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSIvi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSIvi.ForeColor = System.Drawing.Color.Black
        Me.ButtonSIvi.Image = CType(resources.GetObject("ButtonSIvi.Image"), System.Drawing.Image)
        Me.ButtonSIvi.Location = New System.Drawing.Point(638, 2)
        Me.ButtonSIvi.Name = "ButtonSIvi"
        Me.ButtonSIvi.Size = New System.Drawing.Size(49, 41)
        Me.ButtonSIvi.TabIndex = 90
        Me.ButtonSIvi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSIvi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonSIvi.UseVisualStyleBackColor = False
        Me.ButtonSIvi.Visible = False
        '
        'LblVSIvi
        '
        Me.LblVSIvi.AutoSize = True
        Me.LblVSIvi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVSIvi.Location = New System.Drawing.Point(490, 14)
        Me.LblVSIvi.Name = "LblVSIvi"
        Me.LblVSIvi.Size = New System.Drawing.Size(50, 16)
        Me.LblVSIvi.TabIndex = 8
        Me.LblVSIvi.Text = "1-7 min"
        '
        'LblRSIvi
        '
        Me.LblRSIvi.AutoSize = True
        Me.LblRSIvi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRSIvi.Location = New System.Drawing.Point(375, 14)
        Me.LblRSIvi.Name = "LblRSIvi"
        Me.LblRSIvi.Size = New System.Drawing.Size(31, 16)
        Me.LblRSIvi.TabIndex = 7
        Me.LblRSIvi.Text = "seg"
        '
        'TxtSangradoI
        '
        Me.TxtSangradoI.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSangradoI.Location = New System.Drawing.Point(284, 8)
        Me.TxtSangradoI.Name = "TxtSangradoI"
        Me.TxtSangradoI.Size = New System.Drawing.Size(80, 24)
        Me.TxtSangradoI.TabIndex = 5
        '
        'LabelSIvi
        '
        Me.LabelSIvi.AutoSize = True
        Me.LabelSIvi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSIvi.Location = New System.Drawing.Point(74, 14)
        Me.LabelSIvi.Name = "LabelSIvi"
        Me.LabelSIvi.Size = New System.Drawing.Size(146, 13)
        Me.LabelSIvi.TabIndex = 3
        Me.LabelSIvi.Text = "TIEMPO DE SANGRADO IVI"
        '
        'PanelSangradoD
        '
        Me.PanelSangradoD.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelSangradoD.Controls.Add(Me.ButtonSDuke)
        Me.PanelSangradoD.Controls.Add(Me.LblVSDuke)
        Me.PanelSangradoD.Controls.Add(Me.LblRSDuke)
        Me.PanelSangradoD.Controls.Add(Me.TxtSangradoD)
        Me.PanelSangradoD.Controls.Add(Me.LabelSDuke)
        Me.PanelSangradoD.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSangradoD.Location = New System.Drawing.Point(0, 315)
        Me.PanelSangradoD.Name = "PanelSangradoD"
        Me.PanelSangradoD.Size = New System.Drawing.Size(715, 40)
        Me.PanelSangradoD.TabIndex = 41
        '
        'ButtonSDuke
        '
        Me.ButtonSDuke.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonSDuke.FlatAppearance.BorderSize = 0
        Me.ButtonSDuke.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonSDuke.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonSDuke.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSDuke.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSDuke.ForeColor = System.Drawing.Color.Black
        Me.ButtonSDuke.Image = CType(resources.GetObject("ButtonSDuke.Image"), System.Drawing.Image)
        Me.ButtonSDuke.Location = New System.Drawing.Point(638, 0)
        Me.ButtonSDuke.Name = "ButtonSDuke"
        Me.ButtonSDuke.Size = New System.Drawing.Size(49, 41)
        Me.ButtonSDuke.TabIndex = 89
        Me.ButtonSDuke.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSDuke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonSDuke.UseVisualStyleBackColor = False
        Me.ButtonSDuke.Visible = False
        '
        'LblVSDuke
        '
        Me.LblVSDuke.AutoSize = True
        Me.LblVSDuke.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVSDuke.Location = New System.Drawing.Point(490, 16)
        Me.LblVSDuke.Name = "LblVSDuke"
        Me.LblVSDuke.Size = New System.Drawing.Size(50, 16)
        Me.LblVSDuke.TabIndex = 9
        Me.LblVSDuke.Text = "1-3 min"
        '
        'LblRSDuke
        '
        Me.LblRSDuke.AutoSize = True
        Me.LblRSDuke.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRSDuke.Location = New System.Drawing.Point(375, 15)
        Me.LblRSDuke.Name = "LblRSDuke"
        Me.LblRSDuke.Size = New System.Drawing.Size(31, 16)
        Me.LblRSDuke.TabIndex = 8
        Me.LblRSDuke.Text = "seg"
        '
        'TxtSangradoD
        '
        Me.TxtSangradoD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSangradoD.Location = New System.Drawing.Point(284, 8)
        Me.TxtSangradoD.Name = "TxtSangradoD"
        Me.TxtSangradoD.Size = New System.Drawing.Size(80, 24)
        Me.TxtSangradoD.TabIndex = 6
        '
        'LabelSDuke
        '
        Me.LabelSDuke.AutoSize = True
        Me.LabelSDuke.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSDuke.Location = New System.Drawing.Point(67, 15)
        Me.LabelSDuke.Name = "LabelSDuke"
        Me.LabelSDuke.Size = New System.Drawing.Size(163, 13)
        Me.LabelSDuke.TabIndex = 3
        Me.LabelSDuke.Text = "TIEMPO DE SANGRADO DUKE"
        '
        'PanelRetraccion
        '
        Me.PanelRetraccion.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelRetraccion.Controls.Add(Me.ButtonRCoa)
        Me.PanelRetraccion.Controls.Add(Me.LblVRCoa)
        Me.PanelRetraccion.Controls.Add(Me.LblRRCoa)
        Me.PanelRetraccion.Controls.Add(Me.TxtRetraccion)
        Me.PanelRetraccion.Controls.Add(Me.LabelRCoa)
        Me.PanelRetraccion.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRetraccion.Location = New System.Drawing.Point(0, 275)
        Me.PanelRetraccion.Name = "PanelRetraccion"
        Me.PanelRetraccion.Size = New System.Drawing.Size(715, 40)
        Me.PanelRetraccion.TabIndex = 40
        '
        'ButtonRCoa
        '
        Me.ButtonRCoa.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonRCoa.FlatAppearance.BorderSize = 0
        Me.ButtonRCoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonRCoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonRCoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRCoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRCoa.ForeColor = System.Drawing.Color.Black
        Me.ButtonRCoa.Image = CType(resources.GetObject("ButtonRCoa.Image"), System.Drawing.Image)
        Me.ButtonRCoa.Location = New System.Drawing.Point(638, -1)
        Me.ButtonRCoa.Name = "ButtonRCoa"
        Me.ButtonRCoa.Size = New System.Drawing.Size(49, 41)
        Me.ButtonRCoa.TabIndex = 88
        Me.ButtonRCoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRCoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonRCoa.UseVisualStyleBackColor = False
        Me.ButtonRCoa.Visible = False
        '
        'LblVRCoa
        '
        Me.LblVRCoa.AutoSize = True
        Me.LblVRCoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVRCoa.Location = New System.Drawing.Point(490, 16)
        Me.LblVRCoa.Name = "LblVRCoa"
        Me.LblVRCoa.Size = New System.Drawing.Size(45, 16)
        Me.LblVRCoa.TabIndex = 9
        Me.LblVRCoa.Text = "1-20%"
        '
        'LblRRCoa
        '
        Me.LblRRCoa.AutoSize = True
        Me.LblRRCoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRRCoa.Location = New System.Drawing.Point(375, 15)
        Me.LblRRCoa.Name = "LblRRCoa"
        Me.LblRRCoa.Size = New System.Drawing.Size(20, 16)
        Me.LblRRCoa.TabIndex = 8
        Me.LblRRCoa.Text = "%"
        '
        'TxtRetraccion
        '
        Me.TxtRetraccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRetraccion.Location = New System.Drawing.Point(284, 8)
        Me.TxtRetraccion.Name = "TxtRetraccion"
        Me.TxtRetraccion.Size = New System.Drawing.Size(80, 24)
        Me.TxtRetraccion.TabIndex = 6
        '
        'LabelRCoa
        '
        Me.LabelRCoa.AutoSize = True
        Me.LabelRCoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRCoa.Location = New System.Drawing.Point(74, 15)
        Me.LabelRCoa.Name = "LabelRCoa"
        Me.LabelRCoa.Size = New System.Drawing.Size(156, 13)
        Me.LabelRCoa.TabIndex = 3
        Me.LabelRCoa.Text = "RETRACCION DEL COAGULO"
        '
        'PanelCoagulacion
        '
        Me.PanelCoagulacion.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelCoagulacion.Controls.Add(Me.ButtonTCoa)
        Me.PanelCoagulacion.Controls.Add(Me.LblVTCoa)
        Me.PanelCoagulacion.Controls.Add(Me.LblRTCoa)
        Me.PanelCoagulacion.Controls.Add(Me.TxtCoagulacion)
        Me.PanelCoagulacion.Controls.Add(Me.LabelTCoa)
        Me.PanelCoagulacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCoagulacion.Location = New System.Drawing.Point(0, 235)
        Me.PanelCoagulacion.Name = "PanelCoagulacion"
        Me.PanelCoagulacion.Size = New System.Drawing.Size(715, 40)
        Me.PanelCoagulacion.TabIndex = 39
        '
        'ButtonTCoa
        '
        Me.ButtonTCoa.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonTCoa.FlatAppearance.BorderSize = 0
        Me.ButtonTCoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonTCoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonTCoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTCoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTCoa.ForeColor = System.Drawing.Color.Black
        Me.ButtonTCoa.Image = CType(resources.GetObject("ButtonTCoa.Image"), System.Drawing.Image)
        Me.ButtonTCoa.Location = New System.Drawing.Point(638, -1)
        Me.ButtonTCoa.Name = "ButtonTCoa"
        Me.ButtonTCoa.Size = New System.Drawing.Size(49, 41)
        Me.ButtonTCoa.TabIndex = 87
        Me.ButtonTCoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonTCoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonTCoa.UseVisualStyleBackColor = False
        Me.ButtonTCoa.Visible = False
        '
        'LblVTCoa
        '
        Me.LblVTCoa.AutoSize = True
        Me.LblVTCoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVTCoa.Location = New System.Drawing.Point(490, 16)
        Me.LblVTCoa.Name = "LblVTCoa"
        Me.LblVTCoa.Size = New System.Drawing.Size(82, 16)
        Me.LblVTCoa.TabIndex = 9
        Me.LblVTCoa.Text = "5-15 Minutos"
        '
        'LblRTCoa
        '
        Me.LblRTCoa.AutoSize = True
        Me.LblRTCoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRTCoa.Location = New System.Drawing.Point(375, 15)
        Me.LblRTCoa.Name = "LblRTCoa"
        Me.LblRTCoa.Size = New System.Drawing.Size(31, 16)
        Me.LblRTCoa.TabIndex = 8
        Me.LblRTCoa.Text = "seg"
        '
        'TxtCoagulacion
        '
        Me.TxtCoagulacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCoagulacion.Location = New System.Drawing.Point(284, 8)
        Me.TxtCoagulacion.Name = "TxtCoagulacion"
        Me.TxtCoagulacion.Size = New System.Drawing.Size(80, 24)
        Me.TxtCoagulacion.TabIndex = 6
        '
        'LabelTCoa
        '
        Me.LabelTCoa.AutoSize = True
        Me.LabelTCoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTCoa.Location = New System.Drawing.Point(74, 15)
        Me.LabelTCoa.Name = "LabelTCoa"
        Me.LabelTCoa.Size = New System.Drawing.Size(146, 13)
        Me.LabelTCoa.TabIndex = 3
        Me.LabelTCoa.Text = "TIEMPO DE COAGULACION"
        '
        'PanelTrombo
        '
        Me.PanelTrombo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelTrombo.Controls.Add(Me.ButtonTrombo)
        Me.PanelTrombo.Controls.Add(Me.LblVTrombo)
        Me.PanelTrombo.Controls.Add(Me.LblRTrombo)
        Me.PanelTrombo.Controls.Add(Me.TxtTrombo)
        Me.PanelTrombo.Controls.Add(Me.LabelTrombo)
        Me.PanelTrombo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTrombo.Location = New System.Drawing.Point(0, 195)
        Me.PanelTrombo.Name = "PanelTrombo"
        Me.PanelTrombo.Size = New System.Drawing.Size(715, 40)
        Me.PanelTrombo.TabIndex = 38
        '
        'ButtonTrombo
        '
        Me.ButtonTrombo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonTrombo.FlatAppearance.BorderSize = 0
        Me.ButtonTrombo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonTrombo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonTrombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTrombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTrombo.ForeColor = System.Drawing.Color.Black
        Me.ButtonTrombo.Image = CType(resources.GetObject("ButtonTrombo.Image"), System.Drawing.Image)
        Me.ButtonTrombo.Location = New System.Drawing.Point(638, -1)
        Me.ButtonTrombo.Name = "ButtonTrombo"
        Me.ButtonTrombo.Size = New System.Drawing.Size(49, 41)
        Me.ButtonTrombo.TabIndex = 86
        Me.ButtonTrombo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonTrombo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonTrombo.UseVisualStyleBackColor = False
        Me.ButtonTrombo.Visible = False
        '
        'LblVTrombo
        '
        Me.LblVTrombo.AutoSize = True
        Me.LblVTrombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVTrombo.Location = New System.Drawing.Point(490, 13)
        Me.LblVTrombo.Name = "LblVTrombo"
        Me.LblVTrombo.Size = New System.Drawing.Size(105, 16)
        Me.LblVTrombo.TabIndex = 10
        Me.LblVTrombo.Text = "34-45 Segundos"
        '
        'LblRTrombo
        '
        Me.LblRTrombo.AutoSize = True
        Me.LblRTrombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRTrombo.Location = New System.Drawing.Point(375, 16)
        Me.LblRTrombo.Name = "LblRTrombo"
        Me.LblRTrombo.Size = New System.Drawing.Size(31, 16)
        Me.LblRTrombo.TabIndex = 9
        Me.LblRTrombo.Text = "seg"
        '
        'TxtTrombo
        '
        Me.TxtTrombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTrombo.Location = New System.Drawing.Point(284, 8)
        Me.TxtTrombo.Name = "TxtTrombo"
        Me.TxtTrombo.Size = New System.Drawing.Size(80, 24)
        Me.TxtTrombo.TabIndex = 6
        '
        'LabelTrombo
        '
        Me.LabelTrombo.AutoSize = True
        Me.LabelTrombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTrombo.Location = New System.Drawing.Point(51, 16)
        Me.LabelTrombo.Name = "LabelTrombo"
        Me.LabelTrombo.Size = New System.Drawing.Size(209, 13)
        Me.LabelTrombo.TabIndex = 3
        Me.LabelTrombo.Text = "TIEMPO PARCIAL DE TROMBOPLATINA"
        '
        'PanelProto
        '
        Me.PanelProto.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelProto.Controls.Add(Me.ButtonProtom)
        Me.PanelProto.Controls.Add(Me.LblVProtom)
        Me.PanelProto.Controls.Add(Me.LblRProtom)
        Me.PanelProto.Controls.Add(Me.TxtProto)
        Me.PanelProto.Controls.Add(Me.LabelProtom)
        Me.PanelProto.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelProto.Location = New System.Drawing.Point(0, 155)
        Me.PanelProto.Name = "PanelProto"
        Me.PanelProto.Size = New System.Drawing.Size(715, 40)
        Me.PanelProto.TabIndex = 37
        '
        'ButtonProtom
        '
        Me.ButtonProtom.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonProtom.FlatAppearance.BorderSize = 0
        Me.ButtonProtom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonProtom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonProtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProtom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProtom.ForeColor = System.Drawing.Color.Black
        Me.ButtonProtom.Image = CType(resources.GetObject("ButtonProtom.Image"), System.Drawing.Image)
        Me.ButtonProtom.Location = New System.Drawing.Point(638, -1)
        Me.ButtonProtom.Name = "ButtonProtom"
        Me.ButtonProtom.Size = New System.Drawing.Size(49, 41)
        Me.ButtonProtom.TabIndex = 85
        Me.ButtonProtom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonProtom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonProtom.UseVisualStyleBackColor = False
        Me.ButtonProtom.Visible = False
        '
        'LblVProtom
        '
        Me.LblVProtom.AutoSize = True
        Me.LblVProtom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVProtom.Location = New System.Drawing.Point(490, 13)
        Me.LblVProtom.Name = "LblVProtom"
        Me.LblVProtom.Size = New System.Drawing.Size(105, 16)
        Me.LblVProtom.TabIndex = 10
        Me.LblVProtom.Text = "11-14 Segundos"
        '
        'LblRProtom
        '
        Me.LblRProtom.AutoSize = True
        Me.LblRProtom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRProtom.Location = New System.Drawing.Point(375, 16)
        Me.LblRProtom.Name = "LblRProtom"
        Me.LblRProtom.Size = New System.Drawing.Size(31, 16)
        Me.LblRProtom.TabIndex = 9
        Me.LblRProtom.Text = "seg"
        '
        'TxtProto
        '
        Me.TxtProto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProto.Location = New System.Drawing.Point(284, 8)
        Me.TxtProto.Name = "TxtProto"
        Me.TxtProto.Size = New System.Drawing.Size(80, 24)
        Me.TxtProto.TabIndex = 6
        '
        'LabelProtom
        '
        Me.LabelProtom.AutoSize = True
        Me.LabelProtom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProtom.Location = New System.Drawing.Point(90, 18)
        Me.LabelProtom.Name = "LabelProtom"
        Me.LabelProtom.Size = New System.Drawing.Size(141, 13)
        Me.LabelProtom.TabIndex = 3
        Me.LabelProtom.Text = "TIEMPO DE PROTOMBINA"
        '
        'PanelHemoglobina
        '
        Me.PanelHemoglobina.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelHemoglobina.Controls.Add(Me.ButtonHemo)
        Me.PanelHemoglobina.Controls.Add(Me.LblVHemo)
        Me.PanelHemoglobina.Controls.Add(Me.LblRHemo)
        Me.PanelHemoglobina.Controls.Add(Me.TxtHemoglobina)
        Me.PanelHemoglobina.Controls.Add(Me.LabelHemo)
        Me.PanelHemoglobina.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHemoglobina.Location = New System.Drawing.Point(0, 115)
        Me.PanelHemoglobina.Name = "PanelHemoglobina"
        Me.PanelHemoglobina.Size = New System.Drawing.Size(715, 40)
        Me.PanelHemoglobina.TabIndex = 36
        '
        'ButtonHemo
        '
        Me.ButtonHemo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonHemo.FlatAppearance.BorderSize = 0
        Me.ButtonHemo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonHemo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonHemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHemo.ForeColor = System.Drawing.Color.Black
        Me.ButtonHemo.Image = CType(resources.GetObject("ButtonHemo.Image"), System.Drawing.Image)
        Me.ButtonHemo.Location = New System.Drawing.Point(638, -1)
        Me.ButtonHemo.Name = "ButtonHemo"
        Me.ButtonHemo.Size = New System.Drawing.Size(49, 41)
        Me.ButtonHemo.TabIndex = 84
        Me.ButtonHemo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonHemo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonHemo.UseVisualStyleBackColor = False
        Me.ButtonHemo.Visible = False
        '
        'LblVHemo
        '
        Me.LblVHemo.AutoSize = True
        Me.LblVHemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVHemo.Location = New System.Drawing.Point(490, 16)
        Me.LblVHemo.Name = "LblVHemo"
        Me.LblVHemo.Size = New System.Drawing.Size(35, 16)
        Me.LblVHemo.TabIndex = 9
        Me.LblVHemo.Text = "g/dL"
        '
        'LblRHemo
        '
        Me.LblRHemo.AutoSize = True
        Me.LblRHemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRHemo.Location = New System.Drawing.Point(375, 15)
        Me.LblRHemo.Name = "LblRHemo"
        Me.LblRHemo.Size = New System.Drawing.Size(35, 16)
        Me.LblRHemo.TabIndex = 8
        Me.LblRHemo.Text = "g/dL"
        '
        'TxtHemoglobina
        '
        Me.TxtHemoglobina.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHemoglobina.Location = New System.Drawing.Point(284, 8)
        Me.TxtHemoglobina.Name = "TxtHemoglobina"
        Me.TxtHemoglobina.Size = New System.Drawing.Size(80, 24)
        Me.TxtHemoglobina.TabIndex = 6
        '
        'LabelHemo
        '
        Me.LabelHemo.AutoSize = True
        Me.LabelHemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHemo.Location = New System.Drawing.Point(109, 16)
        Me.LabelHemo.Name = "LabelHemo"
        Me.LabelHemo.Size = New System.Drawing.Size(86, 13)
        Me.LabelHemo.TabIndex = 3
        Me.LabelHemo.Text = "HEMOGLOBINA"
        '
        'PanelHematocrito
        '
        Me.PanelHematocrito.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelHematocrito.Controls.Add(Me.ButtonHema)
        Me.PanelHematocrito.Controls.Add(Me.LblVHema)
        Me.PanelHematocrito.Controls.Add(Me.LblRHema)
        Me.PanelHematocrito.Controls.Add(Me.TxtHematocrito)
        Me.PanelHematocrito.Controls.Add(Me.LabelHema)
        Me.PanelHematocrito.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHematocrito.Location = New System.Drawing.Point(0, 75)
        Me.PanelHematocrito.Name = "PanelHematocrito"
        Me.PanelHematocrito.Size = New System.Drawing.Size(715, 40)
        Me.PanelHematocrito.TabIndex = 35
        '
        'ButtonHema
        '
        Me.ButtonHema.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonHema.FlatAppearance.BorderSize = 0
        Me.ButtonHema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonHema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonHema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHema.ForeColor = System.Drawing.Color.Black
        Me.ButtonHema.Image = CType(resources.GetObject("ButtonHema.Image"), System.Drawing.Image)
        Me.ButtonHema.Location = New System.Drawing.Point(638, 0)
        Me.ButtonHema.Name = "ButtonHema"
        Me.ButtonHema.Size = New System.Drawing.Size(49, 41)
        Me.ButtonHema.TabIndex = 83
        Me.ButtonHema.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonHema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonHema.UseVisualStyleBackColor = False
        Me.ButtonHema.Visible = False
        '
        'LblVHema
        '
        Me.LblVHema.AutoSize = True
        Me.LblVHema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVHema.Location = New System.Drawing.Point(490, 14)
        Me.LblVHema.Name = "LblVHema"
        Me.LblVHema.Size = New System.Drawing.Size(52, 16)
        Me.LblVHema.TabIndex = 8
        Me.LblVHema.Text = "37-47%"
        '
        'LblRHema
        '
        Me.LblRHema.AutoSize = True
        Me.LblRHema.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRHema.Location = New System.Drawing.Point(375, 14)
        Me.LblRHema.Name = "LblRHema"
        Me.LblRHema.Size = New System.Drawing.Size(20, 16)
        Me.LblRHema.TabIndex = 7
        Me.LblRHema.Text = "%"
        '
        'TxtHematocrito
        '
        Me.TxtHematocrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHematocrito.Location = New System.Drawing.Point(284, 8)
        Me.TxtHematocrito.Name = "TxtHematocrito"
        Me.TxtHematocrito.Size = New System.Drawing.Size(80, 24)
        Me.TxtHematocrito.TabIndex = 5
        '
        'LabelHema
        '
        Me.LabelHema.AutoSize = True
        Me.LabelHema.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHema.Location = New System.Drawing.Point(109, 16)
        Me.LabelHema.Name = "LabelHema"
        Me.LabelHema.Size = New System.Drawing.Size(86, 13)
        Me.LabelHema.TabIndex = 3
        Me.LabelHema.Text = "HEMATOCRITO"
        '
        'PanelVes
        '
        Me.PanelVes.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelVes.Controls.Add(Me.ButtonVes)
        Me.PanelVes.Controls.Add(Me.LblVVes)
        Me.PanelVes.Controls.Add(Me.LblRVes)
        Me.PanelVes.Controls.Add(Me.TxtVes)
        Me.PanelVes.Controls.Add(Me.LabelVes)
        Me.PanelVes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelVes.Location = New System.Drawing.Point(0, 35)
        Me.PanelVes.Name = "PanelVes"
        Me.PanelVes.Size = New System.Drawing.Size(715, 40)
        Me.PanelVes.TabIndex = 34
        '
        'ButtonVes
        '
        Me.ButtonVes.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonVes.FlatAppearance.BorderSize = 0
        Me.ButtonVes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonVes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonVes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVes.ForeColor = System.Drawing.Color.Black
        Me.ButtonVes.Image = CType(resources.GetObject("ButtonVes.Image"), System.Drawing.Image)
        Me.ButtonVes.Location = New System.Drawing.Point(638, -1)
        Me.ButtonVes.Name = "ButtonVes"
        Me.ButtonVes.Size = New System.Drawing.Size(49, 41)
        Me.ButtonVes.TabIndex = 82
        Me.ButtonVes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonVes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonVes.UseVisualStyleBackColor = False
        Me.ButtonVes.Visible = False
        '
        'LblVVes
        '
        Me.LblVVes.AutoSize = True
        Me.LblVVes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVVes.Location = New System.Drawing.Point(490, 14)
        Me.LblVVes.Name = "LblVVes"
        Me.LblVVes.Size = New System.Drawing.Size(119, 16)
        Me.LblVVes.TabIndex = 7
        Me.LblVVes.Text = "HASTA 10 mm/hra"
        '
        'LblRVes
        '
        Me.LblRVes.AutoSize = True
        Me.LblRVes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRVes.Location = New System.Drawing.Point(375, 14)
        Me.LblRVes.Name = "LblRVes"
        Me.LblRVes.Size = New System.Drawing.Size(64, 16)
        Me.LblRVes.TabIndex = 6
        Me.LblRVes.Text = "mm/Hora"
        '
        'TxtVes
        '
        Me.TxtVes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVes.Location = New System.Drawing.Point(284, 8)
        Me.TxtVes.Name = "TxtVes"
        Me.TxtVes.Size = New System.Drawing.Size(80, 24)
        Me.TxtVes.TabIndex = 4
        '
        'LabelVes
        '
        Me.LabelVes.AutoSize = True
        Me.LabelVes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVes.Location = New System.Drawing.Point(135, 14)
        Me.LabelVes.Name = "LabelVes"
        Me.LabelVes.Size = New System.Drawing.Size(28, 13)
        Me.LabelVes.TabIndex = 3
        Me.LabelVes.Text = "VES"
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
        Me.Label4.Location = New System.Drawing.Point(474, 12)
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
        'F_Hematologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(732, 483)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTitulo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Hematologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HEMATOLOGIA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.SystemLetonaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HematologiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.PanelTipo.ResumeLayout(False)
        Me.PanelTipo.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelINR.ResumeLayout(False)
        Me.PanelINR.PerformLayout()
        Me.PanelRA.ResumeLayout(False)
        Me.PanelRA.PerformLayout()
        Me.PanelRRN.ResumeLayout(False)
        Me.PanelRRN.PerformLayout()
        Me.PanelSangradoI.ResumeLayout(False)
        Me.PanelSangradoI.PerformLayout()
        Me.PanelSangradoD.ResumeLayout(False)
        Me.PanelSangradoD.PerformLayout()
        Me.PanelRetraccion.ResumeLayout(False)
        Me.PanelRetraccion.PerformLayout()
        Me.PanelCoagulacion.ResumeLayout(False)
        Me.PanelCoagulacion.PerformLayout()
        Me.PanelTrombo.ResumeLayout(False)
        Me.PanelTrombo.PerformLayout()
        Me.PanelProto.ResumeLayout(False)
        Me.PanelProto.PerformLayout()
        Me.PanelHemoglobina.ResumeLayout(False)
        Me.PanelHemoglobina.PerformLayout()
        Me.PanelHematocrito.ResumeLayout(False)
        Me.PanelHematocrito.PerformLayout()
        Me.PanelVes.ResumeLayout(False)
        Me.PanelVes.PerformLayout()
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
    Friend WithEvents TxtReferencia As ComboBox
    Friend WithEvents Label45 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SystemLetonaDataSet As SystemLetonaDataSet
    Friend WithEvents HematologiaBindingSource As BindingSource
    Friend WithEvents HematologiaTableAdapter As SystemLetonaDataSetTableAdapters.HematologiaTableAdapter
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PanelTipo As Panel
    Friend WithEvents ButtonTipo As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Muestra As DataGridViewTextBoxColumn
    Friend WithEvents Examen As DataGridViewTextBoxColumn
    Friend WithEvents Resultado As DataGridViewTextBoxColumn
    Friend WithEvents Observacion As DataGridViewTextBoxColumn
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents LabelTipo As Label
    Friend WithEvents PanelINR As Panel
    Friend WithEvents ButtonINR As Button
    Friend WithEvents LblVINR As Label
    Friend WithEvents TxtINR As TextBox
    Friend WithEvents LabelINR As Label
    Friend WithEvents PanelRA As Panel
    Friend WithEvents ButtonA As Button
    Friend WithEvents LblVRA As Label
    Friend WithEvents LblRRA As Label
    Friend WithEvents TxtRA As TextBox
    Friend WithEvents LabelRA As Label
    Friend WithEvents PanelRRN As Panel
    Friend WithEvents ButtonRN As Button
    Friend WithEvents LblVRRN As Label
    Friend WithEvents LblRRR As Label
    Friend WithEvents TxtRRN As TextBox
    Friend WithEvents LabelRRN As Label
    Friend WithEvents PanelSangradoI As Panel
    Friend WithEvents ButtonSIvi As Button
    Friend WithEvents LblVSIvi As Label
    Friend WithEvents LblRSIvi As Label
    Friend WithEvents TxtSangradoI As TextBox
    Friend WithEvents LabelSIvi As Label
    Friend WithEvents PanelSangradoD As Panel
    Friend WithEvents ButtonSDuke As Button
    Friend WithEvents LblVSDuke As Label
    Friend WithEvents LblRSDuke As Label
    Friend WithEvents TxtSangradoD As TextBox
    Friend WithEvents LabelSDuke As Label
    Friend WithEvents PanelRetraccion As Panel
    Friend WithEvents ButtonRCoa As Button
    Friend WithEvents LblVRCoa As Label
    Friend WithEvents LblRRCoa As Label
    Friend WithEvents TxtRetraccion As TextBox
    Friend WithEvents LabelRCoa As Label
    Friend WithEvents PanelCoagulacion As Panel
    Friend WithEvents ButtonTCoa As Button
    Friend WithEvents LblVTCoa As Label
    Friend WithEvents LblRTCoa As Label
    Friend WithEvents TxtCoagulacion As TextBox
    Friend WithEvents LabelTCoa As Label
    Friend WithEvents PanelTrombo As Panel
    Friend WithEvents ButtonTrombo As Button
    Friend WithEvents LblVTrombo As Label
    Friend WithEvents LblRTrombo As Label
    Friend WithEvents TxtTrombo As TextBox
    Friend WithEvents LabelTrombo As Label
    Friend WithEvents PanelProto As Panel
    Friend WithEvents ButtonProtom As Button
    Friend WithEvents LblVProtom As Label
    Friend WithEvents LblRProtom As Label
    Friend WithEvents TxtProto As TextBox
    Friend WithEvents LabelProtom As Label
    Friend WithEvents PanelHemoglobina As Panel
    Friend WithEvents ButtonHemo As Button
    Friend WithEvents LblVHemo As Label
    Friend WithEvents LblRHemo As Label
    Friend WithEvents TxtHemoglobina As TextBox
    Friend WithEvents LabelHemo As Label
    Friend WithEvents PanelHematocrito As Panel
    Friend WithEvents ButtonHema As Button
    Friend WithEvents LblVHema As Label
    Friend WithEvents LblRHema As Label
    Friend WithEvents TxtHematocrito As TextBox
    Friend WithEvents LabelHema As Label
    Friend WithEvents PanelVes As Panel
    Friend WithEvents ButtonVes As Button
    Friend WithEvents LblVVes As Label
    Friend WithEvents LblRVes As Label
    Friend WithEvents TxtVes As TextBox
    Friend WithEvents LabelVes As Label
    Friend WithEvents PaneltTabla As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
End Class
