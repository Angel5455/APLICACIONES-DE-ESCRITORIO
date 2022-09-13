<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class E_Drogas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_Drogas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.LblId = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtSexo = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxtMuestra = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtReferencia = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPaciente = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.PaneltTabla = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.PanelCocaina = New System.Windows.Forms.Panel()
        Me.TxtObC = New System.Windows.Forms.TextBox()
        Me.TxtCocaina = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelMarihuana = New System.Windows.Forms.Panel()
        Me.TxtObM = New System.Windows.Forms.TextBox()
        Me.TxtMarihuana = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelAnfetaminas = New System.Windows.Forms.Panel()
        Me.TxtObA = New System.Windows.Forms.TextBox()
        Me.TxtAnfetamina = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PanelOpiaseos = New System.Windows.Forms.Panel()
        Me.TxtObO = New System.Windows.Forms.TextBox()
        Me.TxtOpiaseos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanelBenzo = New System.Windows.Forms.Panel()
        Me.TxtObB = New System.Windows.Forms.TextBox()
        Me.TxtBenzo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CachedCrysEmbarazoO1 = New Sistema_Clinico.CachedCrysEmbarazoO()
        Me.PanelTitulo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PaneltTabla.SuspendLayout()
        Me.PanelCocaina.SuspendLayout()
        Me.PanelMarihuana.SuspendLayout()
        Me.PanelAnfetaminas.SuspendLayout()
        Me.PanelOpiaseos.SuspendLayout()
        Me.PanelBenzo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
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
        Me.PanelTitulo.Size = New System.Drawing.Size(728, 129)
        Me.PanelTitulo.TabIndex = 3
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
        Me.Panel2.Controls.Add(Me.TxtReferencia)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.TxtEdad)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TxtPaciente)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(728, 83)
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
        'TxtReferencia
        '
        Me.TxtReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtReferencia.Location = New System.Drawing.Point(87, 42)
        Me.TxtReferencia.Name = "TxtReferencia"
        Me.TxtReferencia.Size = New System.Drawing.Size(232, 22)
        Me.TxtReferencia.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "REFERENCIA"
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
        Me.TxtPaciente.Location = New System.Drawing.Point(87, 9)
        Me.TxtPaciente.Name = "TxtPaciente"
        Me.TxtPaciente.Size = New System.Drawing.Size(232, 22)
        Me.TxtPaciente.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "PACIENTE"
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
        Me.PaneltTabla.Controls.Add(Me.Label4)
        Me.PaneltTabla.Controls.Add(Me.Label3)
        Me.PaneltTabla.Controls.Add(Me.Label2)
        Me.PaneltTabla.Controls.Add(Me.BunifuSeparator1)
        Me.PaneltTabla.Dock = System.Windows.Forms.DockStyle.Top
        Me.PaneltTabla.Location = New System.Drawing.Point(0, 129)
        Me.PaneltTabla.Name = "PaneltTabla"
        Me.PaneltTabla.Size = New System.Drawing.Size(728, 35)
        Me.PaneltTabla.TabIndex = 4
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
        'PanelCocaina
        '
        Me.PanelCocaina.Controls.Add(Me.TxtObC)
        Me.PanelCocaina.Controls.Add(Me.TxtCocaina)
        Me.PanelCocaina.Controls.Add(Me.Label5)
        Me.PanelCocaina.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCocaina.Location = New System.Drawing.Point(0, 164)
        Me.PanelCocaina.Name = "PanelCocaina"
        Me.PanelCocaina.Size = New System.Drawing.Size(728, 40)
        Me.PanelCocaina.TabIndex = 5
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(109, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "COCAINA"
        '
        'PanelMarihuana
        '
        Me.PanelMarihuana.Controls.Add(Me.TxtObM)
        Me.PanelMarihuana.Controls.Add(Me.TxtMarihuana)
        Me.PanelMarihuana.Controls.Add(Me.Label6)
        Me.PanelMarihuana.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelMarihuana.Location = New System.Drawing.Point(0, 204)
        Me.PanelMarihuana.Name = "PanelMarihuana"
        Me.PanelMarihuana.Size = New System.Drawing.Size(728, 40)
        Me.PanelMarihuana.TabIndex = 6
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(109, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "MARIHUANA"
        '
        'PanelAnfetaminas
        '
        Me.PanelAnfetaminas.Controls.Add(Me.TxtObA)
        Me.PanelAnfetaminas.Controls.Add(Me.TxtAnfetamina)
        Me.PanelAnfetaminas.Controls.Add(Me.Label7)
        Me.PanelAnfetaminas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAnfetaminas.Location = New System.Drawing.Point(0, 244)
        Me.PanelAnfetaminas.Name = "PanelAnfetaminas"
        Me.PanelAnfetaminas.Size = New System.Drawing.Size(728, 40)
        Me.PanelAnfetaminas.TabIndex = 7
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(109, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "ANFETAMINAS"
        '
        'PanelOpiaseos
        '
        Me.PanelOpiaseos.Controls.Add(Me.TxtObO)
        Me.PanelOpiaseos.Controls.Add(Me.TxtOpiaseos)
        Me.PanelOpiaseos.Controls.Add(Me.Label8)
        Me.PanelOpiaseos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelOpiaseos.Location = New System.Drawing.Point(0, 284)
        Me.PanelOpiaseos.Name = "PanelOpiaseos"
        Me.PanelOpiaseos.Size = New System.Drawing.Size(728, 40)
        Me.PanelOpiaseos.TabIndex = 8
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(109, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "OPIASEOS"
        '
        'PanelBenzo
        '
        Me.PanelBenzo.Controls.Add(Me.TxtObB)
        Me.PanelBenzo.Controls.Add(Me.TxtBenzo)
        Me.PanelBenzo.Controls.Add(Me.Label9)
        Me.PanelBenzo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBenzo.Location = New System.Drawing.Point(0, 324)
        Me.PanelBenzo.Name = "PanelBenzo"
        Me.PanelBenzo.Size = New System.Drawing.Size(728, 40)
        Me.PanelBenzo.TabIndex = 9
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(109, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "BENZODIAZEPINA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BtnEnviar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 384)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 74)
        Me.Panel1.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(22, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 59
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(327, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'E_Drogas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(728, 458)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelBenzo)
        Me.Controls.Add(Me.PanelOpiaseos)
        Me.Controls.Add(Me.PanelAnfetaminas)
        Me.Controls.Add(Me.PanelMarihuana)
        Me.Controls.Add(Me.PanelCocaina)
        Me.Controls.Add(Me.PaneltTabla)
        Me.Controls.Add(Me.PanelTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "E_Drogas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EXAMEN CLINICO"
        Me.PanelTitulo.ResumeLayout(False)
        Me.PanelTitulo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PaneltTabla.ResumeLayout(False)
        Me.PaneltTabla.PerformLayout()
        Me.PanelCocaina.ResumeLayout(False)
        Me.PanelCocaina.PerformLayout()
        Me.PanelMarihuana.ResumeLayout(False)
        Me.PanelMarihuana.PerformLayout()
        Me.PanelAnfetaminas.ResumeLayout(False)
        Me.PanelAnfetaminas.PerformLayout()
        Me.PanelOpiaseos.ResumeLayout(False)
        Me.PanelOpiaseos.PerformLayout()
        Me.PanelBenzo.ResumeLayout(False)
        Me.PanelBenzo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents PaneltTabla As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelCocaina As Panel
    Friend WithEvents TxtCocaina As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PanelMarihuana As Panel
    Friend WithEvents TxtMarihuana As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PanelAnfetaminas As Panel
    Friend WithEvents TxtAnfetamina As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PanelOpiaseos As Panel
    Friend WithEvents TxtOpiaseos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PanelBenzo As Panel
    Friend WithEvents TxtBenzo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtObC As TextBox
    Friend WithEvents TxtObM As TextBox
    Friend WithEvents TxtObA As TextBox
    Friend WithEvents TxtObO As TextBox
    Friend WithEvents TxtObB As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtFecha As DateTimePicker
    Friend WithEvents TxtMuestra As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtReferencia As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtPaciente As TextBox
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents TxtSexo As ComboBox
    Friend WithEvents LblId As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CachedCrysEmbarazoO1 As CachedCrysEmbarazoO
End Class
