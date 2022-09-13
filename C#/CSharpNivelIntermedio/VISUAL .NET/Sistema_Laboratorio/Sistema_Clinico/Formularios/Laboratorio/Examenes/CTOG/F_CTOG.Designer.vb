<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_CTOG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_CTOG))
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
        Me.PaneltTabla = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.PanelBenzo = New System.Windows.Forms.Panel()
        Me.TxtReferencia = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtNota = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3Horas = New System.Windows.Forms.Panel()
        Me.Button3H = New System.Windows.Forms.Button()
        Me.LblV3 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Txt3Horas = New System.Windows.Forms.TextBox()
        Me.Label3H = New System.Windows.Forms.Label()
        Me.Panel2Horas = New System.Windows.Forms.Panel()
        Me.Button2H = New System.Windows.Forms.Button()
        Me.LblV2 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Txt2Horas = New System.Windows.Forms.TextBox()
        Me.Label2H = New System.Windows.Forms.Label()
        Me.Panel1Hora = New System.Windows.Forms.Panel()
        Me.Button1H = New System.Windows.Forms.Button()
        Me.LblV1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Txt1Hora = New System.Windows.Forms.TextBox()
        Me.Label1H = New System.Windows.Forms.Label()
        Me.PanelAyunas = New System.Windows.Forms.Panel()
        Me.ButtonA = New System.Windows.Forms.Button()
        Me.LblVA = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtAyunas = New System.Windows.Forms.TextBox()
        Me.LabelA = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Muestra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Examen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Resultado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Referencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTOGTableAdapter = New Sistema_Clinico.SystemLetonaDataSetTableAdapters.CTOGTableAdapter()
        Me.PanelTitulo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PaneltTabla.SuspendLayout()
        Me.PanelBenzo.SuspendLayout()
        Me.Panel3Horas.SuspendLayout()
        Me.Panel2Horas.SuspendLayout()
        Me.Panel1Hora.SuspendLayout()
        Me.PanelAyunas.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TxtIdentidad.Location = New System.Drawing.Point(78, 9)
        Me.TxtIdentidad.MaxLength = 13
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(232, 22)
        Me.TxtIdentidad.TabIndex = 5
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
        Me.TxtPaciente.Location = New System.Drawing.Point(78, 42)
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
        Me.Label1.Size = New System.Drawing.Size(245, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUIMICA SANGUINEA"
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
        'PaneltTabla
        '
        Me.PaneltTabla.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PaneltTabla.Controls.Add(Me.Label4)
        Me.PaneltTabla.Controls.Add(Me.Label3)
        Me.PaneltTabla.Controls.Add(Me.Label2)
        Me.PaneltTabla.Controls.Add(Me.BunifuSeparator1)
        Me.PaneltTabla.Dock = System.Windows.Forms.DockStyle.Top
        Me.PaneltTabla.Location = New System.Drawing.Point(0, 129)
        Me.PaneltTabla.Name = "PaneltTabla"
        Me.PaneltTabla.Size = New System.Drawing.Size(732, 35)
        Me.PaneltTabla.TabIndex = 5
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
        'PanelBenzo
        '
        Me.PanelBenzo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelBenzo.Controls.Add(Me.TxtReferencia)
        Me.PanelBenzo.Controls.Add(Me.Label24)
        Me.PanelBenzo.Controls.Add(Me.TxtNota)
        Me.PanelBenzo.Controls.Add(Me.Label9)
        Me.PanelBenzo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBenzo.Location = New System.Drawing.Point(0, 324)
        Me.PanelBenzo.Name = "PanelBenzo"
        Me.PanelBenzo.Size = New System.Drawing.Size(732, 40)
        Me.PanelBenzo.TabIndex = 14
        '
        'TxtReferencia
        '
        Me.TxtReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferencia.FormattingEnabled = True
        Me.TxtReferencia.Items.AddRange(New Object() {"DR. OSWALDO LETONA"})
        Me.TxtReferencia.Location = New System.Drawing.Point(124, 6)
        Me.TxtReferencia.Name = "TxtReferencia"
        Me.TxtReferencia.Size = New System.Drawing.Size(251, 24)
        Me.TxtReferencia.TabIndex = 68
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(27, 11)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(91, 13)
        Me.Label24.TabIndex = 67
        Me.Label24.Text = "REFERIDO POR:"
        '
        'TxtNota
        '
        Me.TxtNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNota.Location = New System.Drawing.Point(427, 7)
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.Size = New System.Drawing.Size(267, 24)
        Me.TxtNota.TabIndex = 66
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(381, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "NOTA:"
        '
        'Panel3Horas
        '
        Me.Panel3Horas.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel3Horas.Controls.Add(Me.Button3H)
        Me.Panel3Horas.Controls.Add(Me.LblV3)
        Me.Panel3Horas.Controls.Add(Me.Label19)
        Me.Panel3Horas.Controls.Add(Me.Txt3Horas)
        Me.Panel3Horas.Controls.Add(Me.Label3H)
        Me.Panel3Horas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3Horas.Location = New System.Drawing.Point(0, 284)
        Me.Panel3Horas.Name = "Panel3Horas"
        Me.Panel3Horas.Size = New System.Drawing.Size(732, 40)
        Me.Panel3Horas.TabIndex = 13
        '
        'Button3H
        '
        Me.Button3H.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button3H.FlatAppearance.BorderSize = 0
        Me.Button3H.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.Button3H.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.Button3H.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3H.ForeColor = System.Drawing.Color.Black
        Me.Button3H.Image = CType(resources.GetObject("Button3H.Image"), System.Drawing.Image)
        Me.Button3H.Location = New System.Drawing.Point(631, 1)
        Me.Button3H.Name = "Button3H"
        Me.Button3H.Size = New System.Drawing.Size(49, 41)
        Me.Button3H.TabIndex = 65
        Me.Button3H.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3H.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3H.UseVisualStyleBackColor = False
        Me.Button3H.Visible = False
        '
        'LblV3
        '
        Me.LblV3.AutoSize = True
        Me.LblV3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblV3.Location = New System.Drawing.Point(490, 13)
        Me.LblV3.Name = "LblV3"
        Me.LblV3.Size = New System.Drawing.Size(124, 16)
        Me.LblV3.TabIndex = 10
        Me.LblV3.Text = "Inferior a 115 mg/dL"
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
        'Txt3Horas
        '
        Me.Txt3Horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt3Horas.Location = New System.Drawing.Point(284, 8)
        Me.Txt3Horas.Name = "Txt3Horas"
        Me.Txt3Horas.Size = New System.Drawing.Size(80, 24)
        Me.Txt3Horas.TabIndex = 6
        '
        'Label3H
        '
        Me.Label3H.AutoSize = True
        Me.Label3H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3H.Location = New System.Drawing.Point(109, 16)
        Me.Label3H.Name = "Label3H"
        Me.Label3H.Size = New System.Drawing.Size(54, 13)
        Me.Label3H.TabIndex = 3
        Me.Label3H.Text = "3 HORAS"
        '
        'Panel2Horas
        '
        Me.Panel2Horas.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel2Horas.Controls.Add(Me.Button2H)
        Me.Panel2Horas.Controls.Add(Me.LblV2)
        Me.Panel2Horas.Controls.Add(Me.Label18)
        Me.Panel2Horas.Controls.Add(Me.Txt2Horas)
        Me.Panel2Horas.Controls.Add(Me.Label2H)
        Me.Panel2Horas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2Horas.Location = New System.Drawing.Point(0, 244)
        Me.Panel2Horas.Name = "Panel2Horas"
        Me.Panel2Horas.Size = New System.Drawing.Size(732, 40)
        Me.Panel2Horas.TabIndex = 12
        '
        'Button2H
        '
        Me.Button2H.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2H.FlatAppearance.BorderSize = 0
        Me.Button2H.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.Button2H.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.Button2H.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2H.ForeColor = System.Drawing.Color.Black
        Me.Button2H.Image = CType(resources.GetObject("Button2H.Image"), System.Drawing.Image)
        Me.Button2H.Location = New System.Drawing.Point(631, 1)
        Me.Button2H.Name = "Button2H"
        Me.Button2H.Size = New System.Drawing.Size(49, 41)
        Me.Button2H.TabIndex = 64
        Me.Button2H.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2H.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2H.UseVisualStyleBackColor = False
        Me.Button2H.Visible = False
        '
        'LblV2
        '
        Me.LblV2.AutoSize = True
        Me.LblV2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblV2.Location = New System.Drawing.Point(490, 16)
        Me.LblV2.Name = "LblV2"
        Me.LblV2.Size = New System.Drawing.Size(124, 16)
        Me.LblV2.TabIndex = 9
        Me.LblV2.Text = "Inferior a 150 mg/dL"
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
        'Txt2Horas
        '
        Me.Txt2Horas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt2Horas.Location = New System.Drawing.Point(284, 8)
        Me.Txt2Horas.Name = "Txt2Horas"
        Me.Txt2Horas.Size = New System.Drawing.Size(80, 24)
        Me.Txt2Horas.TabIndex = 6
        '
        'Label2H
        '
        Me.Label2H.AutoSize = True
        Me.Label2H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2H.Location = New System.Drawing.Point(109, 16)
        Me.Label2H.Name = "Label2H"
        Me.Label2H.Size = New System.Drawing.Size(54, 13)
        Me.Label2H.TabIndex = 3
        Me.Label2H.Text = "2 HORAS"
        '
        'Panel1Hora
        '
        Me.Panel1Hora.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1Hora.Controls.Add(Me.Button1H)
        Me.Panel1Hora.Controls.Add(Me.LblV1)
        Me.Panel1Hora.Controls.Add(Me.Label17)
        Me.Panel1Hora.Controls.Add(Me.Txt1Hora)
        Me.Panel1Hora.Controls.Add(Me.Label1H)
        Me.Panel1Hora.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1Hora.Location = New System.Drawing.Point(0, 204)
        Me.Panel1Hora.Name = "Panel1Hora"
        Me.Panel1Hora.Size = New System.Drawing.Size(732, 40)
        Me.Panel1Hora.TabIndex = 11
        '
        'Button1H
        '
        Me.Button1H.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1H.FlatAppearance.BorderSize = 0
        Me.Button1H.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.Button1H.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.Button1H.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1H.ForeColor = System.Drawing.Color.Black
        Me.Button1H.Image = CType(resources.GetObject("Button1H.Image"), System.Drawing.Image)
        Me.Button1H.Location = New System.Drawing.Point(631, -1)
        Me.Button1H.Name = "Button1H"
        Me.Button1H.Size = New System.Drawing.Size(49, 41)
        Me.Button1H.TabIndex = 63
        Me.Button1H.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1H.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1H.UseVisualStyleBackColor = False
        Me.Button1H.Visible = False
        '
        'LblV1
        '
        Me.LblV1.AutoSize = True
        Me.LblV1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblV1.Location = New System.Drawing.Point(490, 14)
        Me.LblV1.Name = "LblV1"
        Me.LblV1.Size = New System.Drawing.Size(124, 16)
        Me.LblV1.TabIndex = 8
        Me.LblV1.Text = "Inferior a 200 mg/dL"
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
        'Txt1Hora
        '
        Me.Txt1Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt1Hora.Location = New System.Drawing.Point(284, 8)
        Me.Txt1Hora.Name = "Txt1Hora"
        Me.Txt1Hora.Size = New System.Drawing.Size(80, 24)
        Me.Txt1Hora.TabIndex = 5
        '
        'Label1H
        '
        Me.Label1H.AutoSize = True
        Me.Label1H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1H.Location = New System.Drawing.Point(109, 16)
        Me.Label1H.Name = "Label1H"
        Me.Label1H.Size = New System.Drawing.Size(47, 13)
        Me.Label1H.TabIndex = 3
        Me.Label1H.Text = "1 HORA"
        '
        'PanelAyunas
        '
        Me.PanelAyunas.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PanelAyunas.Controls.Add(Me.ButtonA)
        Me.PanelAyunas.Controls.Add(Me.LblVA)
        Me.PanelAyunas.Controls.Add(Me.Label16)
        Me.PanelAyunas.Controls.Add(Me.TxtAyunas)
        Me.PanelAyunas.Controls.Add(Me.LabelA)
        Me.PanelAyunas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAyunas.Location = New System.Drawing.Point(0, 164)
        Me.PanelAyunas.Name = "PanelAyunas"
        Me.PanelAyunas.Size = New System.Drawing.Size(732, 40)
        Me.PanelAyunas.TabIndex = 10
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
        Me.ButtonA.Location = New System.Drawing.Point(631, 1)
        Me.ButtonA.Name = "ButtonA"
        Me.ButtonA.Size = New System.Drawing.Size(49, 41)
        Me.ButtonA.TabIndex = 62
        Me.ButtonA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonA.UseVisualStyleBackColor = False
        Me.ButtonA.Visible = False
        '
        'LblVA
        '
        Me.LblVA.AutoSize = True
        Me.LblVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVA.Location = New System.Drawing.Point(490, 14)
        Me.LblVA.Name = "LblVA"
        Me.LblVA.Size = New System.Drawing.Size(124, 16)
        Me.LblVA.TabIndex = 7
        Me.LblVA.Text = "Inferior a 115 mg/dL"
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
        'TxtAyunas
        '
        Me.TxtAyunas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAyunas.Location = New System.Drawing.Point(284, 8)
        Me.TxtAyunas.Name = "TxtAyunas"
        Me.TxtAyunas.Size = New System.Drawing.Size(80, 24)
        Me.TxtAyunas.TabIndex = 4
        '
        'LabelA
        '
        Me.LabelA.AutoSize = True
        Me.LabelA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelA.Location = New System.Drawing.Point(109, 16)
        Me.LabelA.Name = "LabelA"
        Me.LabelA.Size = New System.Drawing.Size(51, 13)
        Me.LabelA.TabIndex = 3
        Me.LabelA.Text = "AYUNAS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.BtnEnviar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 450)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(732, 74)
        Me.Panel1.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(195, 58)
        Me.GroupBox1.TabIndex = 62
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Muestra, Me.Examen, Me.Resultado, Me.Referencia})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 370)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(732, 74)
        Me.DataGridView1.TabIndex = 19
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
        'Referencia
        '
        Me.Referencia.HeaderText = "Referencia"
        Me.Referencia.Name = "Referencia"
        '
        'CTOGTableAdapter
        '
        Me.CTOGTableAdapter.ClearBeforeFill = True
        '
        'F_CTOG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(732, 524)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelBenzo)
        Me.Controls.Add(Me.Panel3Horas)
        Me.Controls.Add(Me.Panel2Horas)
        Me.Controls.Add(Me.Panel1Hora)
        Me.Controls.Add(Me.PanelAyunas)
        Me.Controls.Add(Me.PaneltTabla)
        Me.Controls.Add(Me.PanelTitulo)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_CTOG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CTOG"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PaneltTabla.ResumeLayout(False)
        Me.PaneltTabla.PerformLayout()
        Me.PanelBenzo.ResumeLayout(False)
        Me.PanelBenzo.PerformLayout()
        Me.Panel3Horas.ResumeLayout(False)
        Me.Panel3Horas.PerformLayout()
        Me.Panel2Horas.ResumeLayout(False)
        Me.Panel2Horas.PerformLayout()
        Me.Panel1Hora.ResumeLayout(False)
        Me.Panel1Hora.PerformLayout()
        Me.PanelAyunas.ResumeLayout(False)
        Me.PanelAyunas.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents PaneltTabla As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents PanelBenzo As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3Horas As Panel
    Friend WithEvents Txt3Horas As TextBox
    Friend WithEvents Label3H As Label
    Friend WithEvents Panel2Horas As Panel
    Friend WithEvents Txt2Horas As TextBox
    Friend WithEvents Label2H As Label
    Friend WithEvents Panel1Hora As Panel
    Friend WithEvents Txt1Hora As TextBox
    Friend WithEvents Label1H As Label
    Friend WithEvents PanelAyunas As Panel
    Friend WithEvents TxtAyunas As TextBox
    Friend WithEvents LabelA As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LblV3 As Label
    Friend WithEvents LblV2 As Label
    Friend WithEvents LblV1 As Label
    Friend WithEvents LblVA As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3H As Button
    Friend WithEvents Button2H As Button
    Friend WithEvents Button1H As Button
    Friend WithEvents ButtonA As Button
    Friend WithEvents Muestra As DataGridViewTextBoxColumn
    Friend WithEvents Examen As DataGridViewTextBoxColumn
    Friend WithEvents Resultado As DataGridViewTextBoxColumn
    Friend WithEvents Referencia As DataGridViewTextBoxColumn
    Friend WithEvents CTOGTableAdapter As SystemLetonaDataSetTableAdapters.CTOGTableAdapter
    Friend WithEvents TxtNota As TextBox
    Friend WithEvents TxtReferencia As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
