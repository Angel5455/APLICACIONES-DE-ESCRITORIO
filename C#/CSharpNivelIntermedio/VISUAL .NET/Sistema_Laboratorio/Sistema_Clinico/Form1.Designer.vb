<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.PanelMenuLateral = New System.Windows.Forms.Panel()
        Me.PanelAjustes = New System.Windows.Forms.Panel()
        Me.PanelPLab = New System.Windows.Forms.Panel()
        Me.PanelSubPacientes = New System.Windows.Forms.Panel()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.LblUsuario = New System.Windows.Forms.TextBox()
        Me.PanelBarra = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PanelFormularioHijo = New System.Windows.Forms.Panel()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.MostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.OcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.CurvaSidebar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.AnimacionPanelMenuLateral = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.AnimacionPanelMenuLateralBack = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Btnmenu = New System.Windows.Forms.PictureBox()
        Me.IconMinimizar = New System.Windows.Forms.PictureBox()
        Me.IconCerrar = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtnBackup = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.BtnAjustes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnQuimicaS = New System.Windows.Forms.Button()
        Me.BtnPEspeciales = New System.Windows.Forms.Button()
        Me.BtnOrina = New System.Windows.Forms.Button()
        Me.BtnPiloryS = New System.Windows.Forms.Button()
        Me.BtnPiloryH = New System.Windows.Forms.Button()
        Me.BtnHematologia = New System.Windows.Forms.Button()
        Me.BtnHeces = New System.Windows.Forms.Button()
        Me.BtnFSP = New System.Windows.Forms.Button()
        Me.BtnEmbarazoS = New System.Windows.Forms.Button()
        Me.BtnEmbarazoO = New System.Windows.Forms.Button()
        Me.BtnCTOG = New System.Windows.Forms.Button()
        Me.BtnCitologia = New System.Windows.Forms.Button()
        Me.BtnADrogas = New System.Windows.Forms.Button()
        Me.BtnPLab = New System.Windows.Forms.Button()
        Me.BtnLPacientes = New System.Windows.Forms.Button()
        Me.BtnPacientes = New System.Windows.Forms.Button()
        Me.PicUsuario = New System.Windows.Forms.PictureBox()
        Me.PanelMenuLateral.SuspendLayout()
        Me.PanelAjustes.SuspendLayout()
        Me.PanelPLab.SuspendLayout()
        Me.PanelSubPacientes.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.PanelBarra.SuspendLayout()
        Me.PanelFormularioHijo.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        CType(Me.Btnmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenuLateral
        '
        Me.PanelMenuLateral.AutoScroll = True
        Me.PanelMenuLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.PanelMenuLateral.Controls.Add(Me.PanelAjustes)
        Me.PanelMenuLateral.Controls.Add(Me.BtnAjustes)
        Me.PanelMenuLateral.Controls.Add(Me.Button1)
        Me.PanelMenuLateral.Controls.Add(Me.PanelPLab)
        Me.PanelMenuLateral.Controls.Add(Me.BtnPLab)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubPacientes)
        Me.PanelMenuLateral.Controls.Add(Me.BtnPacientes)
        Me.PanelMenuLateral.Controls.Add(Me.PanelLogo)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.PanelMenuLateral, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.PanelMenuLateral, BunifuAnimatorNS.DecorationType.None)
        Me.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuLateral.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuLateral.Name = "PanelMenuLateral"
        Me.PanelMenuLateral.Size = New System.Drawing.Size(250, 665)
        Me.PanelMenuLateral.TabIndex = 0
        '
        'PanelAjustes
        '
        Me.PanelAjustes.BackColor = System.Drawing.Color.DarkCyan
        Me.PanelAjustes.Controls.Add(Me.BtnBackup)
        Me.PanelAjustes.Controls.Add(Me.Button22)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.PanelAjustes, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.PanelAjustes, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAjustes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAjustes.Location = New System.Drawing.Point(0, 881)
        Me.PanelAjustes.Name = "PanelAjustes"
        Me.PanelAjustes.Size = New System.Drawing.Size(233, 88)
        Me.PanelAjustes.TabIndex = 11
        '
        'PanelPLab
        '
        Me.PanelPLab.BackColor = System.Drawing.Color.DarkCyan
        Me.PanelPLab.Controls.Add(Me.BtnQuimicaS)
        Me.PanelPLab.Controls.Add(Me.BtnPEspeciales)
        Me.PanelPLab.Controls.Add(Me.BtnOrina)
        Me.PanelPLab.Controls.Add(Me.BtnPiloryS)
        Me.PanelPLab.Controls.Add(Me.BtnPiloryH)
        Me.PanelPLab.Controls.Add(Me.BtnHematologia)
        Me.PanelPLab.Controls.Add(Me.BtnHeces)
        Me.PanelPLab.Controls.Add(Me.BtnFSP)
        Me.PanelPLab.Controls.Add(Me.BtnEmbarazoS)
        Me.PanelPLab.Controls.Add(Me.BtnEmbarazoO)
        Me.PanelPLab.Controls.Add(Me.BtnCTOG)
        Me.PanelPLab.Controls.Add(Me.BtnCitologia)
        Me.PanelPLab.Controls.Add(Me.BtnADrogas)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.PanelPLab, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.PanelPLab, BunifuAnimatorNS.DecorationType.None)
        Me.PanelPLab.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPLab.Location = New System.Drawing.Point(0, 297)
        Me.PanelPLab.Name = "PanelPLab"
        Me.PanelPLab.Size = New System.Drawing.Size(233, 484)
        Me.PanelPLab.TabIndex = 7
        '
        'PanelSubPacientes
        '
        Me.PanelSubPacientes.BackColor = System.Drawing.Color.DarkCyan
        Me.PanelSubPacientes.Controls.Add(Me.BtnLPacientes)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.PanelSubPacientes, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.PanelSubPacientes, BunifuAnimatorNS.DecorationType.None)
        Me.PanelSubPacientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubPacientes.Location = New System.Drawing.Point(0, 200)
        Me.PanelSubPacientes.Name = "PanelSubPacientes"
        Me.PanelSubPacientes.Size = New System.Drawing.Size(233, 47)
        Me.PanelSubPacientes.TabIndex = 2
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.LblUsuario)
        Me.PanelLogo.Controls.Add(Me.PicUsuario)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.PanelLogo, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.PanelLogo, BunifuAnimatorNS.DecorationType.None)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(233, 150)
        Me.PanelLogo.TabIndex = 0
        '
        'LblUsuario
        '
        Me.LblUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.LblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.LblUsuario, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.LblUsuario, BunifuAnimatorNS.DecorationType.None)
        Me.LblUsuario.Enabled = False
        Me.LblUsuario.ForeColor = System.Drawing.Color.Yellow
        Me.LblUsuario.Location = New System.Drawing.Point(0, 124)
        Me.LblUsuario.Multiline = True
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(250, 26)
        Me.LblUsuario.TabIndex = 2
        Me.LblUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelBarra
        '
        Me.PanelBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelBarra.Controls.Add(Me.Label1)
        Me.PanelBarra.Controls.Add(Me.Label3)
        Me.PanelBarra.Controls.Add(Me.Label2)
        Me.PanelBarra.Controls.Add(Me.LinkLabel1)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.PanelBarra, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.PanelBarra, BunifuAnimatorNS.DecorationType.None)
        Me.PanelBarra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBarra.Location = New System.Drawing.Point(250, 625)
        Me.PanelBarra.Name = "PanelBarra"
        Me.PanelBarra.Size = New System.Drawing.Size(757, 40)
        Me.PanelBarra.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(667, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Version 1.0.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(131, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CARGO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(131, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "USUARIO"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel1.AutoSize = True
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.LinkLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.LinkLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(35, 101)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(90, 16)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Cerrar Sesión"
        '
        'PanelFormularioHijo
        '
        Me.PanelFormularioHijo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelFormularioHijo.Controls.Add(Me.PanelHeader)
        Me.PanelFormularioHijo.Controls.Add(Me.pictureBox3)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.PanelFormularioHijo, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.PanelFormularioHijo, BunifuAnimatorNS.DecorationType.None)
        Me.PanelFormularioHijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularioHijo.Location = New System.Drawing.Point(250, 0)
        Me.PanelFormularioHijo.Name = "PanelFormularioHijo"
        Me.PanelFormularioHijo.Size = New System.Drawing.Size(757, 625)
        Me.PanelFormularioHijo.TabIndex = 2
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.Btnmenu)
        Me.PanelHeader.Controls.Add(Me.IconMinimizar)
        Me.PanelHeader.Controls.Add(Me.IconCerrar)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.PanelHeader, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.PanelHeader, BunifuAnimatorNS.DecorationType.None)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(757, 40)
        Me.PanelHeader.TabIndex = 6
        '
        'MostrarMenu
        '
        '
        'OcultarMenu
        '
        '
        'CurvaSidebar
        '
        Me.CurvaSidebar.ElipseRadius = 20
        Me.CurvaSidebar.TargetControl = Me
        '
        'AnimacionPanelMenuLateral
        '
        Me.AnimacionPanelMenuLateral.AnimationType = BunifuAnimatorNS.AnimationType.Particles
        Me.AnimacionPanelMenuLateral.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 1
        Animation1.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 2.0!
        Animation1.TransparencyCoeff = 0!
        Me.AnimacionPanelMenuLateral.DefaultAnimation = Animation1
        '
        'AnimacionPanelMenuLateralBack
        '
        Me.AnimacionPanelMenuLateralBack.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic
        Me.AnimacionPanelMenuLateralBack.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 20
        Animation2.Padding = New System.Windows.Forms.Padding(30)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.AnimacionPanelMenuLateralBack.DefaultAnimation = Animation2
        Me.AnimacionPanelMenuLateralBack.MaxAnimationTime = 3000
        '
        'Btnmenu
        '
        Me.Btnmenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.Btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.Btnmenu, BunifuAnimatorNS.DecorationType.None)
        Me.Btnmenu.Image = CType(resources.GetObject("Btnmenu.Image"), System.Drawing.Image)
        Me.Btnmenu.Location = New System.Drawing.Point(5, 4)
        Me.Btnmenu.Name = "Btnmenu"
        Me.Btnmenu.Size = New System.Drawing.Size(30, 30)
        Me.Btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btnmenu.TabIndex = 4
        Me.Btnmenu.TabStop = False
        '
        'IconMinimizar
        '
        Me.IconMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.IconMinimizar, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.IconMinimizar, BunifuAnimatorNS.DecorationType.None)
        Me.IconMinimizar.Image = CType(resources.GetObject("IconMinimizar.Image"), System.Drawing.Image)
        Me.IconMinimizar.Location = New System.Drawing.Point(701, 5)
        Me.IconMinimizar.Name = "IconMinimizar"
        Me.IconMinimizar.Size = New System.Drawing.Size(15, 15)
        Me.IconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconMinimizar.TabIndex = 3
        Me.IconMinimizar.TabStop = False
        '
        'IconCerrar
        '
        Me.IconCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.IconCerrar, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.IconCerrar, BunifuAnimatorNS.DecorationType.None)
        Me.IconCerrar.Image = CType(resources.GetObject("IconCerrar.Image"), System.Drawing.Image)
        Me.IconCerrar.Location = New System.Drawing.Point(731, 5)
        Me.IconCerrar.Name = "IconCerrar"
        Me.IconCerrar.Size = New System.Drawing.Size(15, 15)
        Me.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconCerrar.TabIndex = 0
        Me.IconCerrar.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.pictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.pictureBox3, BunifuAnimatorNS.DecorationType.None)
        Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
        Me.pictureBox3.Location = New System.Drawing.Point(228, 124)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(350, 396)
        Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox3.TabIndex = 1
        Me.pictureBox3.TabStop = False
        '
        'BtnBackup
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnBackup, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnBackup, BunifuAnimatorNS.DecorationType.None)
        Me.BtnBackup.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBackup.FlatAppearance.BorderSize = 0
        Me.BtnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBackup.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnBackup.Image = CType(resources.GetObject("BtnBackup.Image"), System.Drawing.Image)
        Me.BtnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBackup.Location = New System.Drawing.Point(0, 35)
        Me.BtnBackup.Name = "BtnBackup"
        Me.BtnBackup.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnBackup.Size = New System.Drawing.Size(233, 35)
        Me.BtnBackup.TabIndex = 4
        Me.BtnBackup.Text = "Base de Datos"
        Me.BtnBackup.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.Button22, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.Button22, BunifuAnimatorNS.DecorationType.None)
        Me.Button22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button22.FlatAppearance.BorderSize = 0
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button22.Image = CType(resources.GetObject("Button22.Image"), System.Drawing.Image)
        Me.Button22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button22.Location = New System.Drawing.Point(0, 0)
        Me.Button22.Name = "Button22"
        Me.Button22.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button22.Size = New System.Drawing.Size(233, 35)
        Me.Button22.TabIndex = 3
        Me.Button22.Text = "Ajustes del Sistema"
        Me.Button22.UseVisualStyleBackColor = True
        Me.Button22.Visible = False
        '
        'BtnAjustes
        '
        Me.BtnAjustes.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnAjustes, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnAjustes, BunifuAnimatorNS.DecorationType.None)
        Me.BtnAjustes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAjustes.FlatAppearance.BorderSize = 0
        Me.BtnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAjustes.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnAjustes.Image = CType(resources.GetObject("BtnAjustes.Image"), System.Drawing.Image)
        Me.BtnAjustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAjustes.Location = New System.Drawing.Point(0, 831)
        Me.BtnAjustes.Name = "BtnAjustes"
        Me.BtnAjustes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnAjustes.Size = New System.Drawing.Size(233, 50)
        Me.BtnAjustes.TabIndex = 10
        Me.BtnAjustes.Text = "AJUSTES"
        Me.BtnAjustes.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 781)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(233, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "BUSCAR EXAMEN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnQuimicaS
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnQuimicaS, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnQuimicaS, BunifuAnimatorNS.DecorationType.None)
        Me.BtnQuimicaS.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnQuimicaS.FlatAppearance.BorderSize = 0
        Me.BtnQuimicaS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnQuimicaS.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnQuimicaS.Image = CType(resources.GetObject("BtnQuimicaS.Image"), System.Drawing.Image)
        Me.BtnQuimicaS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnQuimicaS.Location = New System.Drawing.Point(0, 420)
        Me.BtnQuimicaS.Name = "BtnQuimicaS"
        Me.BtnQuimicaS.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnQuimicaS.Size = New System.Drawing.Size(233, 35)
        Me.BtnQuimicaS.TabIndex = 22
        Me.BtnQuimicaS.Text = "Quimica Sanguinea"
        Me.BtnQuimicaS.UseVisualStyleBackColor = True
        '
        'BtnPEspeciales
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnPEspeciales, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnPEspeciales, BunifuAnimatorNS.DecorationType.None)
        Me.BtnPEspeciales.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPEspeciales.FlatAppearance.BorderSize = 0
        Me.BtnPEspeciales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPEspeciales.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnPEspeciales.Image = CType(resources.GetObject("BtnPEspeciales.Image"), System.Drawing.Image)
        Me.BtnPEspeciales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPEspeciales.Location = New System.Drawing.Point(0, 385)
        Me.BtnPEspeciales.Name = "BtnPEspeciales"
        Me.BtnPEspeciales.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnPEspeciales.Size = New System.Drawing.Size(233, 35)
        Me.BtnPEspeciales.TabIndex = 21
        Me.BtnPEspeciales.Text = "Pruebas Especiales"
        Me.BtnPEspeciales.UseVisualStyleBackColor = True
        '
        'BtnOrina
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnOrina, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnOrina, BunifuAnimatorNS.DecorationType.None)
        Me.BtnOrina.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnOrina.FlatAppearance.BorderSize = 0
        Me.BtnOrina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOrina.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnOrina.Image = CType(resources.GetObject("BtnOrina.Image"), System.Drawing.Image)
        Me.BtnOrina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOrina.Location = New System.Drawing.Point(0, 350)
        Me.BtnOrina.Name = "BtnOrina"
        Me.BtnOrina.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnOrina.Size = New System.Drawing.Size(233, 35)
        Me.BtnOrina.TabIndex = 20
        Me.BtnOrina.Text = "Orina"
        Me.BtnOrina.UseVisualStyleBackColor = True
        '
        'BtnPiloryS
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnPiloryS, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnPiloryS, BunifuAnimatorNS.DecorationType.None)
        Me.BtnPiloryS.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPiloryS.FlatAppearance.BorderSize = 0
        Me.BtnPiloryS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPiloryS.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnPiloryS.Image = CType(resources.GetObject("BtnPiloryS.Image"), System.Drawing.Image)
        Me.BtnPiloryS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPiloryS.Location = New System.Drawing.Point(0, 315)
        Me.BtnPiloryS.Name = "BtnPiloryS"
        Me.BtnPiloryS.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnPiloryS.Size = New System.Drawing.Size(233, 35)
        Me.BtnPiloryS.TabIndex = 19
        Me.BtnPiloryS.Text = "H.Pilory / Sangre"
        Me.BtnPiloryS.UseVisualStyleBackColor = True
        '
        'BtnPiloryH
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnPiloryH, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnPiloryH, BunifuAnimatorNS.DecorationType.None)
        Me.BtnPiloryH.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPiloryH.FlatAppearance.BorderSize = 0
        Me.BtnPiloryH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPiloryH.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnPiloryH.Image = CType(resources.GetObject("BtnPiloryH.Image"), System.Drawing.Image)
        Me.BtnPiloryH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPiloryH.Location = New System.Drawing.Point(0, 280)
        Me.BtnPiloryH.Name = "BtnPiloryH"
        Me.BtnPiloryH.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnPiloryH.Size = New System.Drawing.Size(233, 35)
        Me.BtnPiloryH.TabIndex = 18
        Me.BtnPiloryH.Text = "H.Pilory / Heces"
        Me.BtnPiloryH.UseVisualStyleBackColor = True
        '
        'BtnHematologia
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnHematologia, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnHematologia, BunifuAnimatorNS.DecorationType.None)
        Me.BtnHematologia.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHematologia.FlatAppearance.BorderSize = 0
        Me.BtnHematologia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHematologia.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnHematologia.Image = CType(resources.GetObject("BtnHematologia.Image"), System.Drawing.Image)
        Me.BtnHematologia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHematologia.Location = New System.Drawing.Point(0, 245)
        Me.BtnHematologia.Name = "BtnHematologia"
        Me.BtnHematologia.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnHematologia.Size = New System.Drawing.Size(233, 35)
        Me.BtnHematologia.TabIndex = 17
        Me.BtnHematologia.Text = "Hematologia"
        Me.BtnHematologia.UseVisualStyleBackColor = True
        '
        'BtnHeces
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnHeces, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnHeces, BunifuAnimatorNS.DecorationType.None)
        Me.BtnHeces.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHeces.FlatAppearance.BorderSize = 0
        Me.BtnHeces.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHeces.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnHeces.Image = CType(resources.GetObject("BtnHeces.Image"), System.Drawing.Image)
        Me.BtnHeces.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHeces.Location = New System.Drawing.Point(0, 210)
        Me.BtnHeces.Name = "BtnHeces"
        Me.BtnHeces.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnHeces.Size = New System.Drawing.Size(233, 35)
        Me.BtnHeces.TabIndex = 16
        Me.BtnHeces.Text = "Heces"
        Me.BtnHeces.UseVisualStyleBackColor = True
        '
        'BtnFSP
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnFSP, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnFSP, BunifuAnimatorNS.DecorationType.None)
        Me.BtnFSP.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnFSP.FlatAppearance.BorderSize = 0
        Me.BtnFSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFSP.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnFSP.Image = CType(resources.GetObject("BtnFSP.Image"), System.Drawing.Image)
        Me.BtnFSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFSP.Location = New System.Drawing.Point(0, 175)
        Me.BtnFSP.Name = "BtnFSP"
        Me.BtnFSP.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnFSP.Size = New System.Drawing.Size(233, 35)
        Me.BtnFSP.TabIndex = 15
        Me.BtnFSP.Text = "FSP"
        Me.BtnFSP.UseVisualStyleBackColor = True
        '
        'BtnEmbarazoS
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnEmbarazoS, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnEmbarazoS, BunifuAnimatorNS.DecorationType.None)
        Me.BtnEmbarazoS.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEmbarazoS.FlatAppearance.BorderSize = 0
        Me.BtnEmbarazoS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmbarazoS.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnEmbarazoS.Image = CType(resources.GetObject("BtnEmbarazoS.Image"), System.Drawing.Image)
        Me.BtnEmbarazoS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmbarazoS.Location = New System.Drawing.Point(0, 140)
        Me.BtnEmbarazoS.Name = "BtnEmbarazoS"
        Me.BtnEmbarazoS.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnEmbarazoS.Size = New System.Drawing.Size(233, 35)
        Me.BtnEmbarazoS.TabIndex = 14
        Me.BtnEmbarazoS.Text = "Embarazo / Sangre"
        Me.BtnEmbarazoS.UseVisualStyleBackColor = True
        '
        'BtnEmbarazoO
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnEmbarazoO, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnEmbarazoO, BunifuAnimatorNS.DecorationType.None)
        Me.BtnEmbarazoO.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEmbarazoO.FlatAppearance.BorderSize = 0
        Me.BtnEmbarazoO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmbarazoO.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnEmbarazoO.Image = CType(resources.GetObject("BtnEmbarazoO.Image"), System.Drawing.Image)
        Me.BtnEmbarazoO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmbarazoO.Location = New System.Drawing.Point(0, 105)
        Me.BtnEmbarazoO.Name = "BtnEmbarazoO"
        Me.BtnEmbarazoO.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnEmbarazoO.Size = New System.Drawing.Size(233, 35)
        Me.BtnEmbarazoO.TabIndex = 13
        Me.BtnEmbarazoO.Text = "Embarazo / Orina"
        Me.BtnEmbarazoO.UseVisualStyleBackColor = True
        '
        'BtnCTOG
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnCTOG, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnCTOG, BunifuAnimatorNS.DecorationType.None)
        Me.BtnCTOG.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCTOG.FlatAppearance.BorderSize = 0
        Me.BtnCTOG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCTOG.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnCTOG.Image = CType(resources.GetObject("BtnCTOG.Image"), System.Drawing.Image)
        Me.BtnCTOG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCTOG.Location = New System.Drawing.Point(0, 70)
        Me.BtnCTOG.Name = "BtnCTOG"
        Me.BtnCTOG.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnCTOG.Size = New System.Drawing.Size(233, 35)
        Me.BtnCTOG.TabIndex = 12
        Me.BtnCTOG.Text = "CTOG"
        Me.BtnCTOG.UseVisualStyleBackColor = True
        '
        'BtnCitologia
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnCitologia, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnCitologia, BunifuAnimatorNS.DecorationType.None)
        Me.BtnCitologia.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCitologia.FlatAppearance.BorderSize = 0
        Me.BtnCitologia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCitologia.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnCitologia.Image = CType(resources.GetObject("BtnCitologia.Image"), System.Drawing.Image)
        Me.BtnCitologia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCitologia.Location = New System.Drawing.Point(0, 35)
        Me.BtnCitologia.Name = "BtnCitologia"
        Me.BtnCitologia.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnCitologia.Size = New System.Drawing.Size(233, 35)
        Me.BtnCitologia.TabIndex = 11
        Me.BtnCitologia.Text = "Citologia M. Fecal"
        Me.BtnCitologia.UseVisualStyleBackColor = True
        '
        'BtnADrogas
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnADrogas, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnADrogas, BunifuAnimatorNS.DecorationType.None)
        Me.BtnADrogas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnADrogas.FlatAppearance.BorderSize = 0
        Me.BtnADrogas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnADrogas.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnADrogas.Image = CType(resources.GetObject("BtnADrogas.Image"), System.Drawing.Image)
        Me.BtnADrogas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnADrogas.Location = New System.Drawing.Point(0, 0)
        Me.BtnADrogas.Name = "BtnADrogas"
        Me.BtnADrogas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnADrogas.Size = New System.Drawing.Size(233, 35)
        Me.BtnADrogas.TabIndex = 10
        Me.BtnADrogas.Text = "Abuso de Drogas"
        Me.BtnADrogas.UseVisualStyleBackColor = True
        '
        'BtnPLab
        '
        Me.BtnPLab.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnPLab, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnPLab, BunifuAnimatorNS.DecorationType.None)
        Me.BtnPLab.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPLab.FlatAppearance.BorderSize = 0
        Me.BtnPLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPLab.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnPLab.Image = CType(resources.GetObject("BtnPLab.Image"), System.Drawing.Image)
        Me.BtnPLab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPLab.Location = New System.Drawing.Point(0, 247)
        Me.BtnPLab.Name = "BtnPLab"
        Me.BtnPLab.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnPLab.Size = New System.Drawing.Size(233, 50)
        Me.BtnPLab.TabIndex = 6
        Me.BtnPLab.Text = "P. LABORATORIO"
        Me.BtnPLab.UseVisualStyleBackColor = False
        '
        'BtnLPacientes
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnLPacientes, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnLPacientes, BunifuAnimatorNS.DecorationType.None)
        Me.BtnLPacientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLPacientes.FlatAppearance.BorderSize = 0
        Me.BtnLPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLPacientes.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnLPacientes.Image = CType(resources.GetObject("BtnLPacientes.Image"), System.Drawing.Image)
        Me.BtnLPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLPacientes.Location = New System.Drawing.Point(0, 0)
        Me.BtnLPacientes.Name = "BtnLPacientes"
        Me.BtnLPacientes.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnLPacientes.Size = New System.Drawing.Size(233, 35)
        Me.BtnLPacientes.TabIndex = 0
        Me.BtnLPacientes.Text = "Lista Pacientes"
        Me.BtnLPacientes.UseVisualStyleBackColor = True
        '
        'BtnPacientes
        '
        Me.BtnPacientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnPacientes, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnPacientes, BunifuAnimatorNS.DecorationType.None)
        Me.BtnPacientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPacientes.FlatAppearance.BorderSize = 0
        Me.BtnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPacientes.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnPacientes.Image = CType(resources.GetObject("BtnPacientes.Image"), System.Drawing.Image)
        Me.BtnPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPacientes.Location = New System.Drawing.Point(0, 150)
        Me.BtnPacientes.Name = "BtnPacientes"
        Me.BtnPacientes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnPacientes.Size = New System.Drawing.Size(233, 50)
        Me.BtnPacientes.TabIndex = 1
        Me.BtnPacientes.Text = "PACIENTES"
        Me.BtnPacientes.UseVisualStyleBackColor = False
        '
        'PicUsuario
        '
        Me.PicUsuario.BackColor = System.Drawing.Color.Transparent
        Me.PicUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.PicUsuario, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.PicUsuario, BunifuAnimatorNS.DecorationType.None)
        Me.PicUsuario.Image = CType(resources.GetObject("PicUsuario.Image"), System.Drawing.Image)
        Me.PicUsuario.Location = New System.Drawing.Point(47, 12)
        Me.PicUsuario.Name = "PicUsuario"
        Me.PicUsuario.Size = New System.Drawing.Size(123, 132)
        Me.PicUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicUsuario.TabIndex = 1
        Me.PicUsuario.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1007, 665)
        Me.Controls.Add(Me.PanelFormularioHijo)
        Me.Controls.Add(Me.PanelBarra)
        Me.Controls.Add(Me.PanelMenuLateral)
        Me.AnimacionPanelMenuLateral.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(950, 665)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelMenuLateral.ResumeLayout(False)
        Me.PanelAjustes.ResumeLayout(False)
        Me.PanelPLab.ResumeLayout(False)
        Me.PanelSubPacientes.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        Me.PanelBarra.ResumeLayout(False)
        Me.PanelBarra.PerformLayout()
        Me.PanelFormularioHijo.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        CType(Me.Btnmenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents BtnPacientes As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelSubPacientes As Panel
    Friend WithEvents BtnLPacientes As Button
    Private WithEvents PicUsuario As PictureBox
    Friend WithEvents PanelBarra As Panel
    Friend WithEvents PanelFormularioHijo As Panel
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents PanelHeader As Panel
    Private WithEvents Btnmenu As PictureBox
    Private WithEvents IconMinimizar As PictureBox
    Private WithEvents IconCerrar As PictureBox
    Friend WithEvents PanelAjustes As Panel
    Friend WithEvents BtnBackup As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents BtnAjustes As Button
    Friend WithEvents PanelPLab As Panel
    Friend WithEvents BtnPLab As Button
    Friend WithEvents BtnADrogas As Button
    Friend WithEvents MostrarMenu As Timer
    Friend WithEvents OcultarMenu As Timer
    Private WithEvents CurvaSidebar As Bunifu.Framework.UI.BunifuElipse
    Private WithEvents AnimacionPanelMenuLateral As BunifuAnimatorNS.BunifuTransition
    Private WithEvents AnimacionPanelMenuLateralBack As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblUsuario As TextBox
    Friend WithEvents BtnQuimicaS As Button
    Friend WithEvents BtnPEspeciales As Button
    Friend WithEvents BtnOrina As Button
    Friend WithEvents BtnPiloryS As Button
    Friend WithEvents BtnPiloryH As Button
    Friend WithEvents BtnHematologia As Button
    Friend WithEvents BtnHeces As Button
    Friend WithEvents BtnFSP As Button
    Friend WithEvents BtnEmbarazoS As Button
    Friend WithEvents BtnEmbarazoO As Button
    Friend WithEvents BtnCTOG As Button
    Friend WithEvents BtnCitologia As Button
    Friend WithEvents Button1 As Button
End Class
