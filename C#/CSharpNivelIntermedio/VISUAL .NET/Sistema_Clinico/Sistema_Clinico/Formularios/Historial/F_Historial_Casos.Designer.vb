<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_Historial_Casos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Historial_Casos))
        Me.DataGridView1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoHistorialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PacienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotivoConsultaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AntecedentesPersonalesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AntecedentesFamiliaresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HEADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExamenFisicoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExamenesComplementariosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PesoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiagnosticoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TratamientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HistorialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SystemLetonaDataSet = New Sistema_Clinico.SystemLetonaDataSet()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.TxtBuscarPacientes = New Bunifu.Framework.UI.BunifuTextbox()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IconCerrar = New System.Windows.Forms.PictureBox()
        Me.HistorialTableAdapter = New Sistema_Clinico.SystemLetonaDataSetTableAdapters.HistorialTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelBotones = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistorialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemLetonaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        CType(Me.IconCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CodigoHistorialDataGridViewTextBoxColumn, Me.IdentidadDataGridViewTextBoxColumn, Me.PacienteDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.MotivoConsultaDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.AntecedentesPersonalesDataGridViewTextBoxColumn, Me.AntecedentesFamiliaresDataGridViewTextBoxColumn, Me.HEADataGridViewTextBoxColumn, Me.ExamenFisicoDataGridViewTextBoxColumn, Me.ExamenesComplementariosDataGridViewTextBoxColumn, Me.PADataGridViewTextBoxColumn, Me.FCDataGridViewTextBoxColumn, Me.FRDataGridViewTextBoxColumn, Me.TDataGridViewTextBoxColumn, Me.PesoDataGridViewTextBoxColumn, Me.DiagnosticoDataGridViewTextBoxColumn, Me.TratamientoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.HistorialBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.DoubleBuffered = True
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.HeaderBgColor = System.Drawing.Color.Teal
        Me.DataGridView1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(49, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(572, 305)
        Me.DataGridView1.TabIndex = 10
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 49
        '
        'CodigoHistorialDataGridViewTextBoxColumn
        '
        Me.CodigoHistorialDataGridViewTextBoxColumn.DataPropertyName = "Codigo_Historial"
        Me.CodigoHistorialDataGridViewTextBoxColumn.HeaderText = "Codigo_Historial"
        Me.CodigoHistorialDataGridViewTextBoxColumn.Name = "CodigoHistorialDataGridViewTextBoxColumn"
        Me.CodigoHistorialDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodigoHistorialDataGridViewTextBoxColumn.Width = 158
        '
        'IdentidadDataGridViewTextBoxColumn
        '
        Me.IdentidadDataGridViewTextBoxColumn.DataPropertyName = "Identidad"
        Me.IdentidadDataGridViewTextBoxColumn.HeaderText = "Identidad"
        Me.IdentidadDataGridViewTextBoxColumn.Name = "IdentidadDataGridViewTextBoxColumn"
        Me.IdentidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdentidadDataGridViewTextBoxColumn.Width = 112
        '
        'PacienteDataGridViewTextBoxColumn
        '
        Me.PacienteDataGridViewTextBoxColumn.DataPropertyName = "Paciente"
        Me.PacienteDataGridViewTextBoxColumn.HeaderText = "Paciente"
        Me.PacienteDataGridViewTextBoxColumn.Name = "PacienteDataGridViewTextBoxColumn"
        Me.PacienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.PacienteDataGridViewTextBoxColumn.Width = 103
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        Me.SexoDataGridViewTextBoxColumn.ReadOnly = True
        Me.SexoDataGridViewTextBoxColumn.Width = 69
        '
        'EdadDataGridViewTextBoxColumn
        '
        Me.EdadDataGridViewTextBoxColumn.DataPropertyName = "Edad"
        Me.EdadDataGridViewTextBoxColumn.HeaderText = "Edad"
        Me.EdadDataGridViewTextBoxColumn.Name = "EdadDataGridViewTextBoxColumn"
        Me.EdadDataGridViewTextBoxColumn.ReadOnly = True
        Me.EdadDataGridViewTextBoxColumn.Width = 75
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Width = 99
        '
        'MotivoConsultaDataGridViewTextBoxColumn
        '
        Me.MotivoConsultaDataGridViewTextBoxColumn.DataPropertyName = "Motivo_Consulta"
        Me.MotivoConsultaDataGridViewTextBoxColumn.HeaderText = "Motivo_Consulta"
        Me.MotivoConsultaDataGridViewTextBoxColumn.Name = "MotivoConsultaDataGridViewTextBoxColumn"
        Me.MotivoConsultaDataGridViewTextBoxColumn.ReadOnly = True
        Me.MotivoConsultaDataGridViewTextBoxColumn.Width = 166
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 82
        '
        'AntecedentesPersonalesDataGridViewTextBoxColumn
        '
        Me.AntecedentesPersonalesDataGridViewTextBoxColumn.DataPropertyName = "Antecedentes_Personales"
        Me.AntecedentesPersonalesDataGridViewTextBoxColumn.HeaderText = "Antecedentes_Personales"
        Me.AntecedentesPersonalesDataGridViewTextBoxColumn.Name = "AntecedentesPersonalesDataGridViewTextBoxColumn"
        Me.AntecedentesPersonalesDataGridViewTextBoxColumn.ReadOnly = True
        Me.AntecedentesPersonalesDataGridViewTextBoxColumn.Width = 235
        '
        'AntecedentesFamiliaresDataGridViewTextBoxColumn
        '
        Me.AntecedentesFamiliaresDataGridViewTextBoxColumn.DataPropertyName = "Antecedentes_Familiares"
        Me.AntecedentesFamiliaresDataGridViewTextBoxColumn.HeaderText = "Antecedentes_Familiares"
        Me.AntecedentesFamiliaresDataGridViewTextBoxColumn.Name = "AntecedentesFamiliaresDataGridViewTextBoxColumn"
        Me.AntecedentesFamiliaresDataGridViewTextBoxColumn.ReadOnly = True
        Me.AntecedentesFamiliaresDataGridViewTextBoxColumn.Width = 230
        '
        'HEADataGridViewTextBoxColumn
        '
        Me.HEADataGridViewTextBoxColumn.DataPropertyName = "HEA"
        Me.HEADataGridViewTextBoxColumn.HeaderText = "HEA"
        Me.HEADataGridViewTextBoxColumn.Name = "HEADataGridViewTextBoxColumn"
        Me.HEADataGridViewTextBoxColumn.ReadOnly = True
        Me.HEADataGridViewTextBoxColumn.Width = 66
        '
        'ExamenFisicoDataGridViewTextBoxColumn
        '
        Me.ExamenFisicoDataGridViewTextBoxColumn.DataPropertyName = "Examen_Fisico"
        Me.ExamenFisicoDataGridViewTextBoxColumn.HeaderText = "Examen_Fisico"
        Me.ExamenFisicoDataGridViewTextBoxColumn.Name = "ExamenFisicoDataGridViewTextBoxColumn"
        Me.ExamenFisicoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExamenFisicoDataGridViewTextBoxColumn.Width = 144
        '
        'ExamenesComplementariosDataGridViewTextBoxColumn
        '
        Me.ExamenesComplementariosDataGridViewTextBoxColumn.DataPropertyName = "Examenes_Complementarios"
        Me.ExamenesComplementariosDataGridViewTextBoxColumn.HeaderText = "Examenes_Complementarios"
        Me.ExamenesComplementariosDataGridViewTextBoxColumn.Name = "ExamenesComplementariosDataGridViewTextBoxColumn"
        Me.ExamenesComplementariosDataGridViewTextBoxColumn.ReadOnly = True
        Me.ExamenesComplementariosDataGridViewTextBoxColumn.Width = 259
        '
        'PADataGridViewTextBoxColumn
        '
        Me.PADataGridViewTextBoxColumn.DataPropertyName = "PA"
        Me.PADataGridViewTextBoxColumn.HeaderText = "PA"
        Me.PADataGridViewTextBoxColumn.Name = "PADataGridViewTextBoxColumn"
        Me.PADataGridViewTextBoxColumn.ReadOnly = True
        Me.PADataGridViewTextBoxColumn.Width = 55
        '
        'FCDataGridViewTextBoxColumn
        '
        Me.FCDataGridViewTextBoxColumn.DataPropertyName = "FC"
        Me.FCDataGridViewTextBoxColumn.HeaderText = "FC"
        Me.FCDataGridViewTextBoxColumn.Name = "FCDataGridViewTextBoxColumn"
        Me.FCDataGridViewTextBoxColumn.ReadOnly = True
        Me.FCDataGridViewTextBoxColumn.Width = 54
        '
        'FRDataGridViewTextBoxColumn
        '
        Me.FRDataGridViewTextBoxColumn.DataPropertyName = "FR"
        Me.FRDataGridViewTextBoxColumn.HeaderText = "FR"
        Me.FRDataGridViewTextBoxColumn.Name = "FRDataGridViewTextBoxColumn"
        Me.FRDataGridViewTextBoxColumn.ReadOnly = True
        Me.FRDataGridViewTextBoxColumn.Width = 51
        '
        'TDataGridViewTextBoxColumn
        '
        Me.TDataGridViewTextBoxColumn.DataPropertyName = "T"
        Me.TDataGridViewTextBoxColumn.HeaderText = "T"
        Me.TDataGridViewTextBoxColumn.Name = "TDataGridViewTextBoxColumn"
        Me.TDataGridViewTextBoxColumn.ReadOnly = True
        Me.TDataGridViewTextBoxColumn.Width = 41
        '
        'PesoDataGridViewTextBoxColumn
        '
        Me.PesoDataGridViewTextBoxColumn.DataPropertyName = "Peso"
        Me.PesoDataGridViewTextBoxColumn.HeaderText = "Peso"
        Me.PesoDataGridViewTextBoxColumn.Name = "PesoDataGridViewTextBoxColumn"
        Me.PesoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PesoDataGridViewTextBoxColumn.Width = 68
        '
        'DiagnosticoDataGridViewTextBoxColumn
        '
        Me.DiagnosticoDataGridViewTextBoxColumn.DataPropertyName = "Diagnostico"
        Me.DiagnosticoDataGridViewTextBoxColumn.HeaderText = "Diagnostico"
        Me.DiagnosticoDataGridViewTextBoxColumn.Name = "DiagnosticoDataGridViewTextBoxColumn"
        Me.DiagnosticoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiagnosticoDataGridViewTextBoxColumn.Width = 126
        '
        'TratamientoDataGridViewTextBoxColumn
        '
        Me.TratamientoDataGridViewTextBoxColumn.DataPropertyName = "Tratamiento"
        Me.TratamientoDataGridViewTextBoxColumn.HeaderText = "Tratamiento"
        Me.TratamientoDataGridViewTextBoxColumn.Name = "TratamientoDataGridViewTextBoxColumn"
        Me.TratamientoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TratamientoDataGridViewTextBoxColumn.Width = 130
        '
        'HistorialBindingSource
        '
        Me.HistorialBindingSource.DataMember = "Historial"
        Me.HistorialBindingSource.DataSource = Me.SystemLetonaDataSet
        '
        'SystemLetonaDataSet
        '
        Me.SystemLetonaDataSet.DataSetName = "SystemLetonaDataSet"
        Me.SystemLetonaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Teal
        Me.BunifuCards1.Controls.Add(Me.BtnEditar)
        Me.BunifuCards1.Controls.Add(Me.BtnImprimir)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(5, 70)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(148, 356)
        Me.BunifuCards1.TabIndex = 58
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.White
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.Color.Black
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.Location = New System.Drawing.Point(-2, 32)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(143, 62)
        Me.BtnEditar.TabIndex = 56
        Me.BtnEditar.Text = "  Editar"
        Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackColor = System.Drawing.Color.White
        Me.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImprimir.FlatAppearance.BorderSize = 0
        Me.BtnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.BtnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimir.ForeColor = System.Drawing.Color.Black
        Me.BtnImprimir.Image = CType(resources.GetObject("BtnImprimir.Image"), System.Drawing.Image)
        Me.BtnImprimir.Location = New System.Drawing.Point(-2, 132)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(143, 62)
        Me.BtnImprimir.TabIndex = 55
        Me.BtnImprimir.Text = " Imprimir"
        Me.BtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnImprimir.UseVisualStyleBackColor = False
        '
        'TxtBuscarPacientes
        '
        Me.TxtBuscarPacientes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBuscarPacientes.BackColor = System.Drawing.Color.Silver
        Me.TxtBuscarPacientes.BackgroundImage = CType(resources.GetObject("TxtBuscarPacientes.BackgroundImage"), System.Drawing.Image)
        Me.TxtBuscarPacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TxtBuscarPacientes.ForeColor = System.Drawing.Color.Teal
        Me.TxtBuscarPacientes.Icon = CType(resources.GetObject("TxtBuscarPacientes.Icon"), System.Drawing.Image)
        Me.TxtBuscarPacientes.Location = New System.Drawing.Point(49, 70)
        Me.TxtBuscarPacientes.Name = "TxtBuscarPacientes"
        Me.TxtBuscarPacientes.Size = New System.Drawing.Size(572, 39)
        Me.TxtBuscarPacientes.TabIndex = 55
        Me.TxtBuscarPacientes.text = "Buscar Pacientes"
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.DarkCyan
        Me.PanelHeader.Controls.Add(Me.Label2)
        Me.PanelHeader.Controls.Add(Me.IconCerrar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(800, 40)
        Me.PanelHeader.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Historial Medico"
        '
        'IconCerrar
        '
        Me.IconCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconCerrar.Image = CType(resources.GetObject("IconCerrar.Image"), System.Drawing.Image)
        Me.IconCerrar.Location = New System.Drawing.Point(773, 12)
        Me.IconCerrar.Name = "IconCerrar"
        Me.IconCerrar.Size = New System.Drawing.Size(15, 15)
        Me.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconCerrar.TabIndex = 0
        Me.IconCerrar.TabStop = False
        '
        'HistorialTableAdapter
        '
        Me.HistorialTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PanelBotones)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 60
        '
        'PanelBotones
        '
        Me.PanelBotones.BackColor = System.Drawing.Color.White
        Me.PanelBotones.Controls.Add(Me.BunifuCards1)
        Me.PanelBotones.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelBotones.Location = New System.Drawing.Point(644, 0)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(156, 450)
        Me.PanelBotones.TabIndex = 52
        '
        'F_Historial_Casos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.TxtBuscarPacientes)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Historial_Casos"
        Me.Text = "F_Historial_Casos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistorialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemLetonaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelHeader.PerformLayout()
        CType(Me.IconCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.PanelBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents TxtBuscarPacientes As Bunifu.Framework.UI.BunifuTextbox
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Private WithEvents BtnImprimir As Button
    Private WithEvents PanelHeader As Panel
    Friend WithEvents Label2 As Label
    Private WithEvents IconCerrar As PictureBox
    Friend WithEvents SystemLetonaDataSet As SystemLetonaDataSet
    Friend WithEvents HistorialBindingSource As BindingSource
    Friend WithEvents HistorialTableAdapter As SystemLetonaDataSetTableAdapters.HistorialTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoHistorialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdentidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PacienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EdadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MotivoConsultaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AntecedentesPersonalesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AntecedentesFamiliaresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HEADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExamenFisicoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExamenesComplementariosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FRDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PesoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiagnosticoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TratamientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelBotones As Panel
    Private WithEvents BtnEditar As Button
End Class
