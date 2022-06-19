<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Busqueda_Agencias
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Busqueda_Agencias))
        Me.lblP_Desembolsado = New System.Windows.Forms.Label()
        Me.lblT_Desembolsado = New System.Windows.Forms.Label()
        Me.lblT_Aprobado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnNoSave = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAgencia = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFase = New System.Windows.Forms.ComboBox()
        Me.ConfiguracionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FasesDataSet = New IHCAFE.FasesDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ConfiguracionTableAdapter = New IHCAFE.FasesDataSetTableAdapters.ConfiguracionTableAdapter()
        CType(Me.btnNoSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConfiguracionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FasesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblP_Desembolsado
        '
        Me.lblP_Desembolsado.AutoSize = True
        Me.lblP_Desembolsado.BackColor = System.Drawing.Color.Transparent
        Me.lblP_Desembolsado.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP_Desembolsado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblP_Desembolsado.Location = New System.Drawing.Point(336, 524)
        Me.lblP_Desembolsado.Name = "lblP_Desembolsado"
        Me.lblP_Desembolsado.Size = New System.Drawing.Size(256, 22)
        Me.lblP_Desembolsado.TabIndex = 117
        Me.lblP_Desembolsado.Text = "PENDIENTE DESEMBOLSADO"
        '
        'lblT_Desembolsado
        '
        Me.lblT_Desembolsado.AutoSize = True
        Me.lblT_Desembolsado.BackColor = System.Drawing.Color.Transparent
        Me.lblT_Desembolsado.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT_Desembolsado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblT_Desembolsado.Location = New System.Drawing.Point(336, 480)
        Me.lblT_Desembolsado.Name = "lblT_Desembolsado"
        Me.lblT_Desembolsado.Size = New System.Drawing.Size(208, 22)
        Me.lblT_Desembolsado.TabIndex = 116
        Me.lblT_Desembolsado.Text = "TOTAL DESEMBOLSADO"
        '
        'lblT_Aprobado
        '
        Me.lblT_Aprobado.AutoSize = True
        Me.lblT_Aprobado.BackColor = System.Drawing.Color.Transparent
        Me.lblT_Aprobado.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT_Aprobado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblT_Aprobado.Location = New System.Drawing.Point(336, 430)
        Me.lblT_Aprobado.Name = "lblT_Aprobado"
        Me.lblT_Aprobado.Size = New System.Drawing.Size(159, 22)
        Me.lblT_Aprobado.TabIndex = 115
        Me.lblT_Aprobado.Text = "TOTAL APROBADO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(39, 524)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(256, 22)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "PENDIENTE DESEMBOLSADO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(39, 480)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 22)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "TOTAL DESEMBOLSADO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(39, 430)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 22)
        Me.Label8.TabIndex = 112
        Me.Label8.Text = "TOTAL APROBADO"
        '
        'btnNoSave
        '
        Me.btnNoSave.BackColor = System.Drawing.Color.Transparent
        Me.btnNoSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNoSave.Image = Global.IHCAFE.My.Resources.Resources.Printer
        Me.btnNoSave.Location = New System.Drawing.Point(737, 468)
        Me.btnNoSave.Name = "btnNoSave"
        Me.btnNoSave.Size = New System.Drawing.Size(81, 78)
        Me.btnNoSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnNoSave.TabIndex = 109
        Me.btnNoSave.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(75, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 26)
        Me.Label14.TabIndex = 106
        Me.Label14.Text = "P.A.P.P System"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.Font = New System.Drawing.Font("Mistral", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(237, 31)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(334, 44)
        Me.Label30.TabIndex = 105
        Me.Label30.Text = "BUSQUEDA DE AGENCIAS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(38, 168)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(780, 234)
        Me.DataGridView1.TabIndex = 102
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.IHCAFE.My.Resources.Resources._1__89_
        Me.PictureBox2.Location = New System.Drawing.Point(12, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(57, 59)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 118
        Me.PictureBox2.TabStop = False
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblUsuario.Location = New System.Drawing.Point(707, 10)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(66, 22)
        Me.lblUsuario.TabIndex = 122
        Me.lblUsuario.Text = "Usuario"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label32.Location = New System.Drawing.Point(595, 10)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(87, 22)
        Me.Label32.TabIndex = 121
        Me.Label32.Text = "Bienvenido"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.BackColor = System.Drawing.Color.Transparent
        Me.lblfecha.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblfecha.Location = New System.Drawing.Point(707, 46)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(106, 22)
        Me.lblfecha.TabIndex = 120
        Me.lblfecha.Text = "Fecha Ingreso"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(626, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 22)
        Me.Label12.TabIndex = 119
        Me.Label12.Text = "Fecha"
        '
        'txtAgencia
        '
        Me.txtAgencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtAgencia.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAgencia.FormattingEnabled = True
        Me.txtAgencia.Items.AddRange(New Object() {"1 - A, S.B.", "2 - B, S.B.", "Colinas", "Trinidad", "San Nicolas", "San Luis", "La Union Lempira"})
        Me.txtAgencia.Location = New System.Drawing.Point(409, 120)
        Me.txtAgencia.Name = "txtAgencia"
        Me.txtAgencia.Size = New System.Drawing.Size(121, 26)
        Me.txtAgencia.TabIndex = 126
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(337, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 22)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "Agencia"
        '
        'txtFase
        '
        Me.txtFase.DataSource = Me.ConfiguracionBindingSource
        Me.txtFase.DisplayMember = "Fase"
        Me.txtFase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFase.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFase.FormattingEnabled = True
        Me.txtFase.Location = New System.Drawing.Point(170, 120)
        Me.txtFase.Name = "txtFase"
        Me.txtFase.Size = New System.Drawing.Size(96, 26)
        Me.txtFase.TabIndex = 124
        Me.txtFase.ValueMember = "Fase"
        '
        'ConfiguracionBindingSource
        '
        Me.ConfiguracionBindingSource.DataMember = "Configuracion"
        Me.ConfiguracionBindingSource.DataSource = Me.FasesDataSet
        '
        'FasesDataSet
        '
        Me.FasesDataSet.DataSetName = "FasesDataSet"
        Me.FasesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(41, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 22)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Listado de Fases"
        '
        'ConfiguracionTableAdapter
        '
        Me.ConfiguracionTableAdapter.ClearBeforeFill = True
        '
        'F_Busqueda_Agencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IHCAFE.My.Resources.Resources.orange51280nq71
        Me.ClientSize = New System.Drawing.Size(852, 603)
        Me.Controls.Add(Me.txtAgencia)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblP_Desembolsado)
        Me.Controls.Add(Me.lblT_Desembolsado)
        Me.Controls.Add(Me.lblT_Aprobado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnNoSave)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "F_Busqueda_Agencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTE POR AGENCIAS"
        CType(Me.btnNoSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConfiguracionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FasesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblP_Desembolsado As System.Windows.Forms.Label
    Friend WithEvents lblT_Desembolsado As System.Windows.Forms.Label
    Friend WithEvents lblT_Aprobado As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnNoSave As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAgencia As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFase As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FasesDataSet As IHCAFE.FasesDataSet
    Friend WithEvents ConfiguracionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConfiguracionTableAdapter As IHCAFE.FasesDataSetTableAdapters.ConfiguracionTableAdapter
End Class
