<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_AgregarHistorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_AgregarHistorial))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TxtIdentidad = New System.Windows.Forms.MaskedTextBox()
        Me.lblIdentidad = New System.Windows.Forms.Label()
        Me.TxtMotivo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckF = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckM = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.TxtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPaciente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtHEA = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtAFamiliares = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtAPersonales = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.TxtPeso = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtT = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtFR = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtFC = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtPA = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtExamenC = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtExamenFisico = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.TxtTratamiento = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtDiagnostico = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LblId = New System.Windows.Forms.Label()
        Me.LblOpcion = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(684, 426)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TxtIdentidad)
        Me.TabPage1.Controls.Add(Me.lblIdentidad)
        Me.TabPage1.Controls.Add(Me.TxtMotivo)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.TxtTelefono)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.TxtEdad)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.CheckF)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.CheckM)
        Me.TabPage1.Controls.Add(Me.TxtFecha)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TxtPaciente)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(676, 393)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos Personales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdentidad.Location = New System.Drawing.Point(16, 131)
        Me.TxtIdentidad.Mask = "0000000000000"
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(112, 22)
        Me.TxtIdentidad.TabIndex = 3
        '
        'lblIdentidad
        '
        Me.lblIdentidad.AutoSize = True
        Me.lblIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentidad.Location = New System.Drawing.Point(13, 109)
        Me.lblIdentidad.Name = "lblIdentidad"
        Me.lblIdentidad.Size = New System.Drawing.Size(64, 16)
        Me.lblIdentidad.TabIndex = 29
        Me.lblIdentidad.Text = "Identidad"
        '
        'TxtMotivo
        '
        Me.TxtMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMotivo.Location = New System.Drawing.Point(16, 232)
        Me.TxtMotivo.Multiline = True
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtMotivo.Size = New System.Drawing.Size(642, 98)
        Me.TxtMotivo.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 16)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Motivo de la Consulta"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(356, 131)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(155, 22)
        Me.TxtTelefono.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(353, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Telefono"
        '
        'TxtEdad
        '
        Me.TxtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEdad.Location = New System.Drawing.Point(198, 131)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(124, 22)
        Me.TxtEdad.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(195, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Edad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(601, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "F"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(537, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "M"
        '
        'CheckF
        '
        Me.CheckF.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CheckF.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CheckF.Checked = False
        Me.CheckF.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.CheckF.ForeColor = System.Drawing.Color.White
        Me.CheckF.Location = New System.Drawing.Point(627, 135)
        Me.CheckF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckF.Name = "CheckF"
        Me.CheckF.Size = New System.Drawing.Size(20, 20)
        Me.CheckF.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(579, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Sexo"
        '
        'CheckM
        '
        Me.CheckM.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CheckM.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.CheckM.Checked = False
        Me.CheckM.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.CheckM.ForeColor = System.Drawing.Color.White
        Me.CheckM.Location = New System.Drawing.Point(563, 135)
        Me.CheckM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckM.Name = "CheckM"
        Me.CheckM.Size = New System.Drawing.Size(20, 20)
        Me.CheckM.TabIndex = 6
        '
        'TxtFecha
        '
        Me.TxtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFecha.Location = New System.Drawing.Point(381, 56)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(266, 22)
        Me.TxtFecha.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(378, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Fecha"
        '
        'TxtPaciente
        '
        Me.TxtPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPaciente.Location = New System.Drawing.Point(16, 56)
        Me.TxtPaciente.Name = "TxtPaciente"
        Me.TxtPaciente.Size = New System.Drawing.Size(316, 22)
        Me.TxtPaciente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Paciente"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TxtHEA)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.TxtAFamiliares)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.TxtAPersonales)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(676, 393)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Antecedentes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TxtHEA
        '
        Me.TxtHEA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHEA.Location = New System.Drawing.Point(18, 284)
        Me.TxtHEA.Multiline = True
        Me.TxtHEA.Name = "TxtHEA"
        Me.TxtHEA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtHEA.Size = New System.Drawing.Size(642, 84)
        Me.TxtHEA.TabIndex = 105
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 265)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(174, 16)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Historial Enfermedad Actual"
        '
        'TxtAFamiliares
        '
        Me.TxtAFamiliares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAFamiliares.Location = New System.Drawing.Point(18, 159)
        Me.TxtAFamiliares.Multiline = True
        Me.TxtAFamiliares.Name = "TxtAFamiliares"
        Me.TxtAFamiliares.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtAFamiliares.Size = New System.Drawing.Size(642, 84)
        Me.TxtAFamiliares.TabIndex = 103
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 16)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Antecedentes Familiares"
        '
        'TxtAPersonales
        '
        Me.TxtAPersonales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAPersonales.Location = New System.Drawing.Point(18, 38)
        Me.TxtAPersonales.Multiline = True
        Me.TxtAPersonales.Name = "TxtAPersonales"
        Me.TxtAPersonales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtAPersonales.Size = New System.Drawing.Size(642, 84)
        Me.TxtAPersonales.TabIndex = 100
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(163, 16)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Antecedentes Personales"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.BunifuCards1)
        Me.TabPage3.Controls.Add(Me.TxtExamenC)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.TxtExamenFisico)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(676, 393)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Examenes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuCards1.BottomSahddow = False
        Me.BunifuCards1.color = System.Drawing.Color.Teal
        Me.BunifuCards1.Controls.Add(Me.TxtPeso)
        Me.BunifuCards1.Controls.Add(Me.Label18)
        Me.BunifuCards1.Controls.Add(Me.TxtT)
        Me.BunifuCards1.Controls.Add(Me.Label17)
        Me.BunifuCards1.Controls.Add(Me.TxtFR)
        Me.BunifuCards1.Controls.Add(Me.Label16)
        Me.BunifuCards1.Controls.Add(Me.TxtFC)
        Me.BunifuCards1.Controls.Add(Me.Label15)
        Me.BunifuCards1.Controls.Add(Me.TxtPA)
        Me.BunifuCards1.Controls.Add(Me.Label14)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(465, 20)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = False
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(196, 347)
        Me.BunifuCards1.TabIndex = 36
        '
        'TxtPeso
        '
        Me.TxtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPeso.Location = New System.Drawing.Point(60, 292)
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.Size = New System.Drawing.Size(101, 22)
        Me.TxtPeso.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(25, 295)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(17, 16)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "P"
        '
        'TxtT
        '
        Me.TxtT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT.Location = New System.Drawing.Point(60, 227)
        Me.TxtT.Name = "TxtT"
        Me.TxtT.Size = New System.Drawing.Size(101, 22)
        Me.TxtT.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(25, 230)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 16)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "T°"
        '
        'TxtFR
        '
        Me.TxtFR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFR.Location = New System.Drawing.Point(60, 166)
        Me.TxtFR.Name = "TxtFR"
        Me.TxtFR.Size = New System.Drawing.Size(101, 22)
        Me.TxtFR.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(25, 169)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 16)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "F.R"
        '
        'TxtFC
        '
        Me.TxtFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFC.Location = New System.Drawing.Point(60, 111)
        Me.TxtFC.Name = "TxtFC"
        Me.TxtFC.Size = New System.Drawing.Size(101, 22)
        Me.TxtFC.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(25, 114)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 16)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "F.C"
        '
        'TxtPA
        '
        Me.TxtPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPA.Location = New System.Drawing.Point(60, 44)
        Me.TxtPA.Name = "TxtPA"
        Me.TxtPA.Size = New System.Drawing.Size(101, 22)
        Me.TxtPA.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(25, 47)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 16)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "P.A"
        '
        'TxtExamenC
        '
        Me.TxtExamenC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExamenC.Location = New System.Drawing.Point(19, 225)
        Me.TxtExamenC.Multiline = True
        Me.TxtExamenC.Name = "TxtExamenC"
        Me.TxtExamenC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtExamenC.Size = New System.Drawing.Size(428, 123)
        Me.TxtExamenC.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 206)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(181, 16)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "Examenes Complementarios"
        '
        'TxtExamenFisico
        '
        Me.TxtExamenFisico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExamenFisico.Location = New System.Drawing.Point(19, 51)
        Me.TxtExamenFisico.Multiline = True
        Me.TxtExamenFisico.Name = "TxtExamenFisico"
        Me.TxtExamenFisico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtExamenFisico.Size = New System.Drawing.Size(428, 123)
        Me.TxtExamenFisico.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 16)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Examen Fisico"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.BtnEnviar)
        Me.TabPage4.Controls.Add(Me.TxtTratamiento)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.TxtDiagnostico)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(676, 393)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Diagnostico & Tratamiento"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'BtnEnviar
        '
        Me.BtnEnviar.BackColor = System.Drawing.Color.Teal
        Me.BtnEnviar.FlatAppearance.BorderSize = 0
        Me.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnviar.ForeColor = System.Drawing.Color.White
        Me.BtnEnviar.Image = CType(resources.GetObject("BtnEnviar.Image"), System.Drawing.Image)
        Me.BtnEnviar.Location = New System.Drawing.Point(521, 313)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(138, 49)
        Me.BtnEnviar.TabIndex = 51
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEnviar.UseVisualStyleBackColor = False
        '
        'TxtTratamiento
        '
        Me.TxtTratamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTratamiento.Location = New System.Drawing.Point(17, 182)
        Me.TxtTratamiento.Multiline = True
        Me.TxtTratamiento.Name = "TxtTratamiento"
        Me.TxtTratamiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtTratamiento.Size = New System.Drawing.Size(642, 84)
        Me.TxtTratamiento.TabIndex = 33
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(14, 163)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 16)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Tratamiento"
        '
        'TxtDiagnostico
        '
        Me.TxtDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDiagnostico.Location = New System.Drawing.Point(17, 59)
        Me.TxtDiagnostico.Multiline = True
        Me.TxtDiagnostico.Name = "TxtDiagnostico"
        Me.TxtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDiagnostico.Size = New System.Drawing.Size(642, 84)
        Me.TxtDiagnostico.TabIndex = 31
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(14, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 16)
        Me.Label19.TabIndex = 32
        Me.Label19.Text = "Diagnostico"
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCodigo.ForeColor = System.Drawing.Color.White
        Me.LblCodigo.Location = New System.Drawing.Point(572, 12)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(58, 16)
        Me.LblCodigo.TabIndex = 30
        Me.LblCodigo.Text = "Codigo"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 465)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(519, 150)
        Me.DataGridView1.TabIndex = 30
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblId.Location = New System.Drawing.Point(553, 522)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(19, 18)
        Me.LblId.TabIndex = 50
        Me.LblId.Text = "Id"
        '
        'LblOpcion
        '
        Me.LblOpcion.AutoSize = True
        Me.LblOpcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOpcion.Location = New System.Drawing.Point(553, 494)
        Me.LblOpcion.Name = "LblOpcion"
        Me.LblOpcion.Size = New System.Drawing.Size(56, 18)
        Me.LblOpcion.TabIndex = 49
        Me.LblOpcion.Text = "Opcion"
        '
        'F_AgregarHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(708, 455)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.LblOpcion)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LblCodigo)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_AgregarHistorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HISTORIAL MÉDICO"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckF As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Label3 As Label
    Friend WithEvents CheckM As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents TxtFecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPaciente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TxtHEA As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtAFamiliares As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtAPersonales As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents TxtPeso As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtT As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtFR As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtFC As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtPA As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtExamenC As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtExamenFisico As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TxtTratamiento As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtDiagnostico As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents lblIdentidad As Label
    Friend WithEvents TxtMotivo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LblCodigo As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents TxtIdentidad As MaskedTextBox
    Friend WithEvents LblId As Label
    Friend WithEvents LblOpcion As Label
End Class
