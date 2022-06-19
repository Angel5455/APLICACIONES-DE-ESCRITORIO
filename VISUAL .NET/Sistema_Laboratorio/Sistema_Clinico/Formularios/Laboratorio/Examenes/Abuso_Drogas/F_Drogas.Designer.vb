<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Drogas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Drogas))
        Me.PanelTitulo = New System.Windows.Forms.Panel()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PanelBenzo = New System.Windows.Forms.Panel()
        Me.ButtonB = New System.Windows.Forms.Button()
        Me.TxtObB = New System.Windows.Forms.TextBox()
        Me.TxtBenzo = New System.Windows.Forms.TextBox()
        Me.LblB = New System.Windows.Forms.Label()
        Me.PanelOpiaseos = New System.Windows.Forms.Panel()
        Me.ButtonO = New System.Windows.Forms.Button()
        Me.TxtObO = New System.Windows.Forms.TextBox()
        Me.TxtOpiaseos = New System.Windows.Forms.TextBox()
        Me.LblO = New System.Windows.Forms.Label()
        Me.PanelAnfetaminas = New System.Windows.Forms.Panel()
        Me.ButtonA = New System.Windows.Forms.Button()
        Me.TxtObA = New System.Windows.Forms.TextBox()
        Me.TxtAnfetamina = New System.Windows.Forms.TextBox()
        Me.LblA = New System.Windows.Forms.Label()
        Me.PanelMarihuana = New System.Windows.Forms.Panel()
        Me.ButtonM = New System.Windows.Forms.Button()
        Me.TxtObM = New System.Windows.Forms.TextBox()
        Me.TxtMarihuana = New System.Windows.Forms.TextBox()
        Me.LblM = New System.Windows.Forms.Label()
        Me.PanelCocaina = New System.Windows.Forms.Panel()
        Me.ButtonC = New System.Windows.Forms.Button()
        Me.TxtObC = New System.Windows.Forms.TextBox()
        Me.TxtCocaina = New System.Windows.Forms.TextBox()
        Me.LblC = New System.Windows.Forms.Label()
        Me.PaneltTabla = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Muestra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Examen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Resultado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SystemLetonaDataSet = New Sistema_Clinico.SystemLetonaDataSet()
        Me.AbusoDrogasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Abuso_DrogasTableAdapter = New Sistema_Clinico.SystemLetonaDataSetTableAdapters.Abuso_DrogasTableAdapter()
        Me.TxtReferencia = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.PanelTitulo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelBenzo.SuspendLayout()
        Me.PanelOpiaseos.SuspendLayout()
        Me.PanelAnfetaminas.SuspendLayout()
        Me.PanelMarihuana.SuspendLayout()
        Me.PanelCocaina.SuspendLayout()
        Me.PaneltTabla.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemLetonaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbusoDrogasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.Panel2)
        Me.PanelTitulo.Controls.Add(Me.Label1)
        Me.PanelTitulo.Controls.Add(Me.BunifuSeparator2)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(732, 129)
        Me.PanelTitulo.TabIndex = 4
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
        Me.TxtIdentidad.Location = New System.Drawing.Point(84, 9)
        Me.TxtIdentidad.MaxLength = 13
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(232, 22)
        Me.TxtIdentidad.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 14)
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
        Me.TxtPaciente.Location = New System.Drawing.Point(84, 42)
        Me.TxtPaciente.Name = "TxtPaciente"
        Me.TxtPaciente.Size = New System.Drawing.Size(232, 22)
        Me.TxtPaciente.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "PACIENTE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DROGAS DE ABUSO"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BtnEnviar)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 466)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(732, 74)
        Me.Panel1.TabIndex = 11
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 58)
        Me.GroupBox1.TabIndex = 60
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
        'PanelBenzo
        '
        Me.PanelBenzo.Controls.Add(Me.ButtonB)
        Me.PanelBenzo.Controls.Add(Me.TxtObB)
        Me.PanelBenzo.Controls.Add(Me.TxtBenzo)
        Me.PanelBenzo.Controls.Add(Me.LblB)
        Me.PanelBenzo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBenzo.Location = New System.Drawing.Point(0, 324)
        Me.PanelBenzo.Name = "PanelBenzo"
        Me.PanelBenzo.Size = New System.Drawing.Size(732, 40)
        Me.PanelBenzo.TabIndex = 17
        '
        'ButtonB
        '
        Me.ButtonB.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonB.FlatAppearance.BorderSize = 0
        Me.ButtonB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonB.ForeColor = System.Drawing.Color.Black
        Me.ButtonB.Image = CType(resources.GetObject("ButtonB.Image"), System.Drawing.Image)
        Me.ButtonB.Location = New System.Drawing.Point(653, 3)
        Me.ButtonB.Name = "ButtonB"
        Me.ButtonB.Size = New System.Drawing.Size(49, 41)
        Me.ButtonB.TabIndex = 65
        Me.ButtonB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonB.UseVisualStyleBackColor = False
        Me.ButtonB.Visible = False
        '
        'TxtObB
        '
        Me.TxtObB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObB.Location = New System.Drawing.Point(447, 8)
        Me.TxtObB.Name = "TxtObB"
        Me.TxtObB.Size = New System.Drawing.Size(200, 24)
        Me.TxtObB.TabIndex = 9
        '
        'TxtBenzo
        '
        Me.TxtBenzo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBenzo.Location = New System.Drawing.Point(284, 8)
        Me.TxtBenzo.Name = "TxtBenzo"
        Me.TxtBenzo.Size = New System.Drawing.Size(100, 24)
        Me.TxtBenzo.TabIndex = 6
        '
        'LblB
        '
        Me.LblB.AutoSize = True
        Me.LblB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblB.Location = New System.Drawing.Point(109, 16)
        Me.LblB.Name = "LblB"
        Me.LblB.Size = New System.Drawing.Size(101, 13)
        Me.LblB.TabIndex = 3
        Me.LblB.Text = "BENZODIAZEPINA"
        '
        'PanelOpiaseos
        '
        Me.PanelOpiaseos.Controls.Add(Me.ButtonO)
        Me.PanelOpiaseos.Controls.Add(Me.TxtObO)
        Me.PanelOpiaseos.Controls.Add(Me.TxtOpiaseos)
        Me.PanelOpiaseos.Controls.Add(Me.LblO)
        Me.PanelOpiaseos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelOpiaseos.Location = New System.Drawing.Point(0, 284)
        Me.PanelOpiaseos.Name = "PanelOpiaseos"
        Me.PanelOpiaseos.Size = New System.Drawing.Size(732, 40)
        Me.PanelOpiaseos.TabIndex = 16
        '
        'ButtonO
        '
        Me.ButtonO.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonO.FlatAppearance.BorderSize = 0
        Me.ButtonO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonO.ForeColor = System.Drawing.Color.Black
        Me.ButtonO.Image = CType(resources.GetObject("ButtonO.Image"), System.Drawing.Image)
        Me.ButtonO.Location = New System.Drawing.Point(653, 3)
        Me.ButtonO.Name = "ButtonO"
        Me.ButtonO.Size = New System.Drawing.Size(49, 41)
        Me.ButtonO.TabIndex = 64
        Me.ButtonO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonO.UseVisualStyleBackColor = False
        Me.ButtonO.Visible = False
        '
        'TxtObO
        '
        Me.TxtObO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObO.Location = New System.Drawing.Point(447, 9)
        Me.TxtObO.Name = "TxtObO"
        Me.TxtObO.Size = New System.Drawing.Size(200, 24)
        Me.TxtObO.TabIndex = 8
        '
        'TxtOpiaseos
        '
        Me.TxtOpiaseos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOpiaseos.Location = New System.Drawing.Point(284, 8)
        Me.TxtOpiaseos.Name = "TxtOpiaseos"
        Me.TxtOpiaseos.Size = New System.Drawing.Size(100, 24)
        Me.TxtOpiaseos.TabIndex = 6
        '
        'LblO
        '
        Me.LblO.AutoSize = True
        Me.LblO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblO.Location = New System.Drawing.Point(109, 16)
        Me.LblO.Name = "LblO"
        Me.LblO.Size = New System.Drawing.Size(61, 13)
        Me.LblO.TabIndex = 3
        Me.LblO.Text = "OPIASEOS"
        '
        'PanelAnfetaminas
        '
        Me.PanelAnfetaminas.Controls.Add(Me.ButtonA)
        Me.PanelAnfetaminas.Controls.Add(Me.TxtObA)
        Me.PanelAnfetaminas.Controls.Add(Me.TxtAnfetamina)
        Me.PanelAnfetaminas.Controls.Add(Me.LblA)
        Me.PanelAnfetaminas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAnfetaminas.Location = New System.Drawing.Point(0, 244)
        Me.PanelAnfetaminas.Name = "PanelAnfetaminas"
        Me.PanelAnfetaminas.Size = New System.Drawing.Size(732, 40)
        Me.PanelAnfetaminas.TabIndex = 15
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
        Me.ButtonA.Location = New System.Drawing.Point(653, 1)
        Me.ButtonA.Name = "ButtonA"
        Me.ButtonA.Size = New System.Drawing.Size(49, 41)
        Me.ButtonA.TabIndex = 63
        Me.ButtonA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonA.UseVisualStyleBackColor = False
        Me.ButtonA.Visible = False
        '
        'TxtObA
        '
        Me.TxtObA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObA.Location = New System.Drawing.Point(447, 7)
        Me.TxtObA.Name = "TxtObA"
        Me.TxtObA.Size = New System.Drawing.Size(200, 24)
        Me.TxtObA.TabIndex = 7
        '
        'TxtAnfetamina
        '
        Me.TxtAnfetamina.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAnfetamina.Location = New System.Drawing.Point(284, 8)
        Me.TxtAnfetamina.Name = "TxtAnfetamina"
        Me.TxtAnfetamina.Size = New System.Drawing.Size(100, 24)
        Me.TxtAnfetamina.TabIndex = 6
        '
        'LblA
        '
        Me.LblA.AutoSize = True
        Me.LblA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblA.Location = New System.Drawing.Point(109, 16)
        Me.LblA.Name = "LblA"
        Me.LblA.Size = New System.Drawing.Size(83, 13)
        Me.LblA.TabIndex = 3
        Me.LblA.Text = "ANFETAMINAS"
        '
        'PanelMarihuana
        '
        Me.PanelMarihuana.Controls.Add(Me.ButtonM)
        Me.PanelMarihuana.Controls.Add(Me.TxtObM)
        Me.PanelMarihuana.Controls.Add(Me.TxtMarihuana)
        Me.PanelMarihuana.Controls.Add(Me.LblM)
        Me.PanelMarihuana.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMarihuana.Location = New System.Drawing.Point(0, 204)
        Me.PanelMarihuana.Name = "PanelMarihuana"
        Me.PanelMarihuana.Size = New System.Drawing.Size(732, 40)
        Me.PanelMarihuana.TabIndex = 14
        '
        'ButtonM
        '
        Me.ButtonM.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonM.FlatAppearance.BorderSize = 0
        Me.ButtonM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonM.ForeColor = System.Drawing.Color.Black
        Me.ButtonM.Image = CType(resources.GetObject("ButtonM.Image"), System.Drawing.Image)
        Me.ButtonM.Location = New System.Drawing.Point(653, 1)
        Me.ButtonM.Name = "ButtonM"
        Me.ButtonM.Size = New System.Drawing.Size(49, 41)
        Me.ButtonM.TabIndex = 62
        Me.ButtonM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonM.UseVisualStyleBackColor = False
        Me.ButtonM.Visible = False
        '
        'TxtObM
        '
        Me.TxtObM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObM.Location = New System.Drawing.Point(447, 7)
        Me.TxtObM.Name = "TxtObM"
        Me.TxtObM.Size = New System.Drawing.Size(200, 24)
        Me.TxtObM.TabIndex = 6
        '
        'TxtMarihuana
        '
        Me.TxtMarihuana.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMarihuana.Location = New System.Drawing.Point(284, 8)
        Me.TxtMarihuana.Name = "TxtMarihuana"
        Me.TxtMarihuana.Size = New System.Drawing.Size(100, 24)
        Me.TxtMarihuana.TabIndex = 5
        '
        'LblM
        '
        Me.LblM.AutoSize = True
        Me.LblM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblM.Location = New System.Drawing.Point(109, 16)
        Me.LblM.Name = "LblM"
        Me.LblM.Size = New System.Drawing.Size(72, 13)
        Me.LblM.TabIndex = 3
        Me.LblM.Text = "MARIHUANA"
        '
        'PanelCocaina
        '
        Me.PanelCocaina.Controls.Add(Me.ButtonC)
        Me.PanelCocaina.Controls.Add(Me.TxtObC)
        Me.PanelCocaina.Controls.Add(Me.TxtCocaina)
        Me.PanelCocaina.Controls.Add(Me.LblC)
        Me.PanelCocaina.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCocaina.Location = New System.Drawing.Point(0, 164)
        Me.PanelCocaina.Name = "PanelCocaina"
        Me.PanelCocaina.Size = New System.Drawing.Size(732, 40)
        Me.PanelCocaina.TabIndex = 13
        '
        'ButtonC
        '
        Me.ButtonC.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButtonC.FlatAppearance.BorderSize = 0
        Me.ButtonC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.ButtonC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.ButtonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonC.ForeColor = System.Drawing.Color.Black
        Me.ButtonC.Image = CType(resources.GetObject("ButtonC.Image"), System.Drawing.Image)
        Me.ButtonC.Location = New System.Drawing.Point(653, 0)
        Me.ButtonC.Name = "ButtonC"
        Me.ButtonC.Size = New System.Drawing.Size(49, 41)
        Me.ButtonC.TabIndex = 61
        Me.ButtonC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonC.UseVisualStyleBackColor = False
        Me.ButtonC.Visible = False
        '
        'TxtObC
        '
        Me.TxtObC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObC.Location = New System.Drawing.Point(447, 7)
        Me.TxtObC.Name = "TxtObC"
        Me.TxtObC.Size = New System.Drawing.Size(200, 24)
        Me.TxtObC.TabIndex = 5
        '
        'TxtCocaina
        '
        Me.TxtCocaina.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCocaina.Location = New System.Drawing.Point(284, 8)
        Me.TxtCocaina.Name = "TxtCocaina"
        Me.TxtCocaina.Size = New System.Drawing.Size(100, 24)
        Me.TxtCocaina.TabIndex = 4
        '
        'LblC
        '
        Me.LblC.AutoSize = True
        Me.LblC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblC.Location = New System.Drawing.Point(109, 16)
        Me.LblC.Name = "LblC"
        Me.LblC.Size = New System.Drawing.Size(54, 13)
        Me.LblC.TabIndex = 3
        Me.LblC.Text = "COCAINA"
        '
        'PaneltTabla
        '
        Me.PaneltTabla.Controls.Add(Me.Label4)
        Me.PaneltTabla.Controls.Add(Me.Label3)
        Me.PaneltTabla.Controls.Add(Me.Label2)
        Me.PaneltTabla.Controls.Add(Me.BunifuSeparator1)
        Me.PaneltTabla.Dock = System.Windows.Forms.DockStyle.Top
        Me.PaneltTabla.Location = New System.Drawing.Point(0, 129)
        Me.PaneltTabla.Name = "PaneltTabla"
        Me.PaneltTabla.Size = New System.Drawing.Size(732, 35)
        Me.PaneltTabla.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(496, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "OBSERVACION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(289, 12)
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
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Muestra, Me.Examen, Me.Resultado, Me.Observacion})
        Me.DataGridView1.Location = New System.Drawing.Point(9, -22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(729, 96)
        Me.DataGridView1.TabIndex = 18
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
        'AbusoDrogasBindingSource
        '
        Me.AbusoDrogasBindingSource.DataMember = "Abuso_Drogas"
        Me.AbusoDrogasBindingSource.DataSource = Me.SystemLetonaDataSet
        '
        'Abuso_DrogasTableAdapter
        '
        Me.Abuso_DrogasTableAdapter.ClearBeforeFill = True
        '
        'TxtReferencia
        '
        Me.TxtReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferencia.FormattingEnabled = True
        Me.TxtReferencia.Items.AddRange(New Object() {"DR. OSWALDO LETONA"})
        Me.TxtReferencia.Location = New System.Drawing.Point(396, 394)
        Me.TxtReferencia.Name = "TxtReferencia"
        Me.TxtReferencia.Size = New System.Drawing.Size(251, 24)
        Me.TxtReferencia.TabIndex = 83
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(299, 399)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(91, 13)
        Me.Label41.TabIndex = 82
        Me.Label41.Text = "REFERIDO POR:"
        '
        'F_Drogas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(732, 540)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.TxtReferencia)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.PanelBenzo)
        Me.Controls.Add(Me.PanelOpiaseos)
        Me.Controls.Add(Me.PanelAnfetaminas)
        Me.Controls.Add(Me.PanelMarihuana)
        Me.Controls.Add(Me.PanelCocaina)
        Me.Controls.Add(Me.PaneltTabla)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTitulo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Drogas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EXAMEN CLINICO"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelBenzo.ResumeLayout(False)
        Me.PanelBenzo.PerformLayout()
        Me.PanelOpiaseos.ResumeLayout(False)
        Me.PanelOpiaseos.PerformLayout()
        Me.PanelAnfetaminas.ResumeLayout(False)
        Me.PanelAnfetaminas.PerformLayout()
        Me.PanelMarihuana.ResumeLayout(False)
        Me.PanelMarihuana.PerformLayout()
        Me.PanelCocaina.ResumeLayout(False)
        Me.PanelCocaina.PerformLayout()
        Me.PaneltTabla.ResumeLayout(False)
        Me.PaneltTabla.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemLetonaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbusoDrogasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitulo As Panel
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents PanelBenzo As Panel
    Friend WithEvents ButtonB As Button
    Friend WithEvents TxtObB As TextBox
    Friend WithEvents TxtBenzo As TextBox
    Friend WithEvents LblB As Label
    Friend WithEvents PanelOpiaseos As Panel
    Friend WithEvents ButtonO As Button
    Friend WithEvents TxtObO As TextBox
    Friend WithEvents TxtOpiaseos As TextBox
    Friend WithEvents LblO As Label
    Friend WithEvents PanelAnfetaminas As Panel
    Friend WithEvents ButtonA As Button
    Friend WithEvents TxtObA As TextBox
    Friend WithEvents TxtAnfetamina As TextBox
    Friend WithEvents LblA As Label
    Friend WithEvents PanelMarihuana As Panel
    Friend WithEvents ButtonM As Button
    Friend WithEvents TxtObM As TextBox
    Friend WithEvents TxtMarihuana As TextBox
    Friend WithEvents LblM As Label
    Friend WithEvents PanelCocaina As Panel
    Friend WithEvents ButtonC As Button
    Friend WithEvents TxtObC As TextBox
    Friend WithEvents TxtCocaina As TextBox
    Friend WithEvents LblC As Label
    Friend WithEvents PaneltTabla As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Muestra As DataGridViewTextBoxColumn
    Friend WithEvents Examen As DataGridViewTextBoxColumn
    Friend WithEvents Resultado As DataGridViewTextBoxColumn
    Friend WithEvents Observacion As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SystemLetonaDataSet As SystemLetonaDataSet
    Friend WithEvents AbusoDrogasBindingSource As BindingSource
    Friend WithEvents Abuso_DrogasTableAdapter As SystemLetonaDataSetTableAdapters.Abuso_DrogasTableAdapter
    Friend WithEvents TxtReferencia As ComboBox
    Friend WithEvents Label41 As Label
End Class
