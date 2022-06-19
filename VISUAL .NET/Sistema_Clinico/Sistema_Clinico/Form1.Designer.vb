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
        Dim Animation9 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Animation10 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.PanelMenuLateral = New System.Windows.Forms.Panel()
        Me.PanelAjustes = New System.Windows.Forms.Panel()
        Me.PanelRH = New System.Windows.Forms.Panel()
        Me.PanelPLab = New System.Windows.Forms.Panel()
        Me.PanelSubCitas = New System.Windows.Forms.Panel()
        Me.PanelSubPacientes = New System.Windows.Forms.Panel()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PanelBarra = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkSesion = New System.Windows.Forms.LinkLabel()
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
        Me.BtnRecepcionista = New System.Windows.Forms.Button()
        Me.BtnEnfermera = New System.Windows.Forms.Button()
        Me.BtnLaboratorista = New System.Windows.Forms.Button()
        Me.BtnMedicos = New System.Windows.Forms.Button()
        Me.BtnRH = New System.Windows.Forms.Button()
        Me.BtnVerInformes = New System.Windows.Forms.Button()
        Me.BtnInforme = New System.Windows.Forms.Button()
        Me.BtnPLab = New System.Windows.Forms.Button()
        Me.BtnPrescripcion = New System.Windows.Forms.Button()
        Me.BtnTodas = New System.Windows.Forms.Button()
        Me.BtnCalendario = New System.Windows.Forms.Button()
        Me.BtnCitas = New System.Windows.Forms.Button()
        Me.BtnDocumentos = New System.Windows.Forms.Button()
        Me.BtnHCasos = New System.Windows.Forms.Button()
        Me.BtnLPacientes = New System.Windows.Forms.Button()
        Me.BtnPacientes = New System.Windows.Forms.Button()
        Me.PicUsuario = New System.Windows.Forms.PictureBox()
        Me.LblUsuario = New System.Windows.Forms.TextBox()
        Me.PanelMenuLateral.SuspendLayout()
        Me.PanelAjustes.SuspendLayout()
        Me.PanelRH.SuspendLayout()
        Me.PanelPLab.SuspendLayout()
        Me.PanelSubCitas.SuspendLayout()
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
        Me.PanelMenuLateral.Controls.Add(Me.PanelRH)
        Me.PanelMenuLateral.Controls.Add(Me.BtnRH)
        Me.PanelMenuLateral.Controls.Add(Me.PanelPLab)
        Me.PanelMenuLateral.Controls.Add(Me.BtnPLab)
        Me.PanelMenuLateral.Controls.Add(Me.BtnPrescripcion)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubCitas)
        Me.PanelMenuLateral.Controls.Add(Me.BtnCitas)
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
        Me.PanelAjustes.Location = New System.Drawing.Point(0, 860)
        Me.PanelAjustes.Name = "PanelAjustes"
        Me.PanelAjustes.Size = New System.Drawing.Size(233, 88)
        Me.PanelAjustes.TabIndex = 11
        '
        'PanelRH
        '
        Me.PanelRH.BackColor = System.Drawing.Color.DarkCyan
        Me.PanelRH.Controls.Add(Me.BtnRecepcionista)
        Me.PanelRH.Controls.Add(Me.BtnEnfermera)
        Me.PanelRH.Controls.Add(Me.BtnLaboratorista)
        Me.PanelRH.Controls.Add(Me.BtnMedicos)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.PanelRH, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.PanelRH, BunifuAnimatorNS.DecorationType.None)
        Me.PanelRH.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelRH.Location = New System.Drawing.Point(0, 675)
        Me.PanelRH.Name = "PanelRH"
        Me.PanelRH.Size = New System.Drawing.Size(233, 135)
        Me.PanelRH.TabIndex = 9
        '
        'PanelPLab
        '
        Me.PanelPLab.BackColor = System.Drawing.Color.DarkCyan
        Me.PanelPLab.Controls.Add(Me.BtnVerInformes)
        Me.PanelPLab.Controls.Add(Me.BtnInforme)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.PanelPLab, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.PanelPLab, BunifuAnimatorNS.DecorationType.None)
        Me.PanelPLab.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelPLab.Location = New System.Drawing.Point(0, 548)
        Me.PanelPLab.Name = "PanelPLab"
        Me.PanelPLab.Size = New System.Drawing.Size(233, 77)
        Me.PanelPLab.TabIndex = 7
        '
        'PanelSubCitas
        '
        Me.PanelSubCitas.BackColor = System.Drawing.Color.DarkCyan
        Me.PanelSubCitas.Controls.Add(Me.BtnTodas)
        Me.PanelSubCitas.Controls.Add(Me.BtnCalendario)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.PanelSubCitas, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.PanelSubCitas, BunifuAnimatorNS.DecorationType.None)
        Me.PanelSubCitas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubCitas.Location = New System.Drawing.Point(0, 364)
        Me.PanelSubCitas.Name = "PanelSubCitas"
        Me.PanelSubCitas.Size = New System.Drawing.Size(233, 84)
        Me.PanelSubCitas.TabIndex = 4
        '
        'PanelSubPacientes
        '
        Me.PanelSubPacientes.BackColor = System.Drawing.Color.DarkCyan
        Me.PanelSubPacientes.Controls.Add(Me.BtnDocumentos)
        Me.PanelSubPacientes.Controls.Add(Me.BtnHCasos)
        Me.PanelSubPacientes.Controls.Add(Me.BtnLPacientes)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.PanelSubPacientes, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.PanelSubPacientes, BunifuAnimatorNS.DecorationType.None)
        Me.PanelSubPacientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubPacientes.Location = New System.Drawing.Point(0, 200)
        Me.PanelSubPacientes.Name = "PanelSubPacientes"
        Me.PanelSubPacientes.Size = New System.Drawing.Size(233, 114)
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
        'PanelBarra
        '
        Me.PanelBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelBarra.Controls.Add(Me.Label1)
        Me.PanelBarra.Controls.Add(Me.LinkSesion)
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
        'LinkSesion
        '
        Me.LinkSesion.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.LinkSesion.AutoSize = True
        Me.LinkSesion.BackColor = System.Drawing.Color.Transparent
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.LinkSesion, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.LinkSesion, BunifuAnimatorNS.DecorationType.None)
        Me.LinkSesion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkSesion.LinkColor = System.Drawing.Color.MediumSpringGreen
        Me.LinkSesion.Location = New System.Drawing.Point(18, 9)
        Me.LinkSesion.Name = "LinkSesion"
        Me.LinkSesion.Size = New System.Drawing.Size(89, 17)
        Me.LinkSesion.TabIndex = 6
        Me.LinkSesion.TabStop = True
        Me.LinkSesion.Text = "Iniciar Sesión"
        Me.LinkSesion.Visible = False
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
        Animation9.AnimateOnlyDifferences = True
        Animation9.BlindCoeff = CType(resources.GetObject("Animation9.BlindCoeff"), System.Drawing.PointF)
        Animation9.LeafCoeff = 0!
        Animation9.MaxTime = 1.0!
        Animation9.MinTime = 0!
        Animation9.MosaicCoeff = CType(resources.GetObject("Animation9.MosaicCoeff"), System.Drawing.PointF)
        Animation9.MosaicShift = CType(resources.GetObject("Animation9.MosaicShift"), System.Drawing.PointF)
        Animation9.MosaicSize = 1
        Animation9.Padding = New System.Windows.Forms.Padding(100, 50, 100, 150)
        Animation9.RotateCoeff = 0!
        Animation9.RotateLimit = 0!
        Animation9.ScaleCoeff = CType(resources.GetObject("Animation9.ScaleCoeff"), System.Drawing.PointF)
        Animation9.SlideCoeff = CType(resources.GetObject("Animation9.SlideCoeff"), System.Drawing.PointF)
        Animation9.TimeCoeff = 2.0!
        Animation9.TransparencyCoeff = 0!
        Me.AnimacionPanelMenuLateral.DefaultAnimation = Animation9
        '
        'AnimacionPanelMenuLateralBack
        '
        Me.AnimacionPanelMenuLateralBack.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic
        Me.AnimacionPanelMenuLateralBack.Cursor = Nothing
        Animation10.AnimateOnlyDifferences = True
        Animation10.BlindCoeff = CType(resources.GetObject("Animation10.BlindCoeff"), System.Drawing.PointF)
        Animation10.LeafCoeff = 0!
        Animation10.MaxTime = 1.0!
        Animation10.MinTime = 0!
        Animation10.MosaicCoeff = CType(resources.GetObject("Animation10.MosaicCoeff"), System.Drawing.PointF)
        Animation10.MosaicShift = CType(resources.GetObject("Animation10.MosaicShift"), System.Drawing.PointF)
        Animation10.MosaicSize = 20
        Animation10.Padding = New System.Windows.Forms.Padding(30)
        Animation10.RotateCoeff = 0!
        Animation10.RotateLimit = 0!
        Animation10.ScaleCoeff = CType(resources.GetObject("Animation10.ScaleCoeff"), System.Drawing.PointF)
        Animation10.SlideCoeff = CType(resources.GetObject("Animation10.SlideCoeff"), System.Drawing.PointF)
        Animation10.TimeCoeff = 0!
        Animation10.TransparencyCoeff = 0!
        Me.AnimacionPanelMenuLateralBack.DefaultAnimation = Animation10
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
        Me.pictureBox3.Location = New System.Drawing.Point(154, 124)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(424, 354)
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
        Me.BtnAjustes.Location = New System.Drawing.Point(0, 810)
        Me.BtnAjustes.Name = "BtnAjustes"
        Me.BtnAjustes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnAjustes.Size = New System.Drawing.Size(233, 50)
        Me.BtnAjustes.TabIndex = 10
        Me.BtnAjustes.Text = "AJUSTES"
        Me.BtnAjustes.UseVisualStyleBackColor = False
        '
        'BtnRecepcionista
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnRecepcionista, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnRecepcionista, BunifuAnimatorNS.DecorationType.None)
        Me.BtnRecepcionista.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRecepcionista.FlatAppearance.BorderSize = 0
        Me.BtnRecepcionista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRecepcionista.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnRecepcionista.Image = CType(resources.GetObject("BtnRecepcionista.Image"), System.Drawing.Image)
        Me.BtnRecepcionista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRecepcionista.Location = New System.Drawing.Point(0, 105)
        Me.BtnRecepcionista.Name = "BtnRecepcionista"
        Me.BtnRecepcionista.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnRecepcionista.Size = New System.Drawing.Size(233, 30)
        Me.BtnRecepcionista.TabIndex = 6
        Me.BtnRecepcionista.Text = "Recepcionista"
        Me.BtnRecepcionista.UseVisualStyleBackColor = True
        '
        'BtnEnfermera
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnEnfermera, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnEnfermera, BunifuAnimatorNS.DecorationType.None)
        Me.BtnEnfermera.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEnfermera.FlatAppearance.BorderSize = 0
        Me.BtnEnfermera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnfermera.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnEnfermera.Image = CType(resources.GetObject("BtnEnfermera.Image"), System.Drawing.Image)
        Me.BtnEnfermera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEnfermera.Location = New System.Drawing.Point(0, 70)
        Me.BtnEnfermera.Name = "BtnEnfermera"
        Me.BtnEnfermera.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnEnfermera.Size = New System.Drawing.Size(233, 35)
        Me.BtnEnfermera.TabIndex = 5
        Me.BtnEnfermera.Text = "Enfermera"
        Me.BtnEnfermera.UseVisualStyleBackColor = True
        '
        'BtnLaboratorista
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnLaboratorista, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnLaboratorista, BunifuAnimatorNS.DecorationType.None)
        Me.BtnLaboratorista.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLaboratorista.FlatAppearance.BorderSize = 0
        Me.BtnLaboratorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLaboratorista.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnLaboratorista.Image = CType(resources.GetObject("BtnLaboratorista.Image"), System.Drawing.Image)
        Me.BtnLaboratorista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLaboratorista.Location = New System.Drawing.Point(0, 35)
        Me.BtnLaboratorista.Name = "BtnLaboratorista"
        Me.BtnLaboratorista.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnLaboratorista.Size = New System.Drawing.Size(233, 35)
        Me.BtnLaboratorista.TabIndex = 4
        Me.BtnLaboratorista.Text = "Laboratorista"
        Me.BtnLaboratorista.UseVisualStyleBackColor = True
        '
        'BtnMedicos
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnMedicos, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnMedicos, BunifuAnimatorNS.DecorationType.None)
        Me.BtnMedicos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnMedicos.FlatAppearance.BorderSize = 0
        Me.BtnMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMedicos.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnMedicos.Image = CType(resources.GetObject("BtnMedicos.Image"), System.Drawing.Image)
        Me.BtnMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnMedicos.Location = New System.Drawing.Point(0, 0)
        Me.BtnMedicos.Name = "BtnMedicos"
        Me.BtnMedicos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnMedicos.Size = New System.Drawing.Size(233, 35)
        Me.BtnMedicos.TabIndex = 3
        Me.BtnMedicos.Text = "Medicos"
        Me.BtnMedicos.UseVisualStyleBackColor = True
        '
        'BtnRH
        '
        Me.BtnRH.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnRH, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnRH, BunifuAnimatorNS.DecorationType.None)
        Me.BtnRH.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnRH.FlatAppearance.BorderSize = 0
        Me.BtnRH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRH.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnRH.Image = CType(resources.GetObject("BtnRH.Image"), System.Drawing.Image)
        Me.BtnRH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRH.Location = New System.Drawing.Point(0, 625)
        Me.BtnRH.Name = "BtnRH"
        Me.BtnRH.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnRH.Size = New System.Drawing.Size(233, 50)
        Me.BtnRH.TabIndex = 8
        Me.BtnRH.Text = "RECURSOS HUMANOS"
        Me.BtnRH.UseVisualStyleBackColor = False
        '
        'BtnVerInformes
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnVerInformes, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnVerInformes, BunifuAnimatorNS.DecorationType.None)
        Me.BtnVerInformes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVerInformes.FlatAppearance.BorderSize = 0
        Me.BtnVerInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerInformes.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnVerInformes.Image = CType(resources.GetObject("BtnVerInformes.Image"), System.Drawing.Image)
        Me.BtnVerInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVerInformes.Location = New System.Drawing.Point(0, 35)
        Me.BtnVerInformes.Name = "BtnVerInformes"
        Me.BtnVerInformes.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnVerInformes.Size = New System.Drawing.Size(233, 35)
        Me.BtnVerInformes.TabIndex = 10
        Me.BtnVerInformes.Text = "Ver Informes"
        Me.BtnVerInformes.UseVisualStyleBackColor = True
        '
        'BtnInforme
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnInforme, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnInforme, BunifuAnimatorNS.DecorationType.None)
        Me.BtnInforme.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnInforme.FlatAppearance.BorderSize = 0
        Me.BtnInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInforme.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnInforme.Image = CType(resources.GetObject("BtnInforme.Image"), System.Drawing.Image)
        Me.BtnInforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInforme.Location = New System.Drawing.Point(0, 0)
        Me.BtnInforme.Name = "BtnInforme"
        Me.BtnInforme.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnInforme.Size = New System.Drawing.Size(233, 35)
        Me.BtnInforme.TabIndex = 1
        Me.BtnInforme.Text = "Añadir Informe"
        Me.BtnInforme.UseVisualStyleBackColor = True
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
        Me.BtnPLab.Location = New System.Drawing.Point(0, 498)
        Me.BtnPLab.Name = "BtnPLab"
        Me.BtnPLab.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnPLab.Size = New System.Drawing.Size(233, 50)
        Me.BtnPLab.TabIndex = 6
        Me.BtnPLab.Text = "P. LABORATORIO"
        Me.BtnPLab.UseVisualStyleBackColor = False
        '
        'BtnPrescripcion
        '
        Me.BtnPrescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnPrescripcion, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnPrescripcion, BunifuAnimatorNS.DecorationType.None)
        Me.BtnPrescripcion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPrescripcion.FlatAppearance.BorderSize = 0
        Me.BtnPrescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrescripcion.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnPrescripcion.Image = CType(resources.GetObject("BtnPrescripcion.Image"), System.Drawing.Image)
        Me.BtnPrescripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrescripcion.Location = New System.Drawing.Point(0, 448)
        Me.BtnPrescripcion.Name = "BtnPrescripcion"
        Me.BtnPrescripcion.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnPrescripcion.Size = New System.Drawing.Size(233, 50)
        Me.BtnPrescripcion.TabIndex = 5
        Me.BtnPrescripcion.Text = "PRESCRIPCION"
        Me.BtnPrescripcion.UseVisualStyleBackColor = False
        '
        'BtnTodas
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnTodas, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnTodas, BunifuAnimatorNS.DecorationType.None)
        Me.BtnTodas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTodas.FlatAppearance.BorderSize = 0
        Me.BtnTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTodas.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnTodas.Image = CType(resources.GetObject("BtnTodas.Image"), System.Drawing.Image)
        Me.BtnTodas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTodas.Location = New System.Drawing.Point(0, 35)
        Me.BtnTodas.Name = "BtnTodas"
        Me.BtnTodas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnTodas.Size = New System.Drawing.Size(233, 35)
        Me.BtnTodas.TabIndex = 9
        Me.BtnTodas.Text = "Ver Todas"
        Me.BtnTodas.UseVisualStyleBackColor = True
        '
        'BtnCalendario
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnCalendario, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnCalendario, BunifuAnimatorNS.DecorationType.None)
        Me.BtnCalendario.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCalendario.FlatAppearance.BorderSize = 0
        Me.BtnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalendario.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnCalendario.Image = CType(resources.GetObject("BtnCalendario.Image"), System.Drawing.Image)
        Me.BtnCalendario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCalendario.Location = New System.Drawing.Point(0, 0)
        Me.BtnCalendario.Name = "BtnCalendario"
        Me.BtnCalendario.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnCalendario.Size = New System.Drawing.Size(233, 35)
        Me.BtnCalendario.TabIndex = 6
        Me.BtnCalendario.Text = "Añadir Cita"
        Me.BtnCalendario.UseVisualStyleBackColor = True
        '
        'BtnCitas
        '
        Me.BtnCitas.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnCitas, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnCitas, BunifuAnimatorNS.DecorationType.None)
        Me.BtnCitas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCitas.FlatAppearance.BorderSize = 0
        Me.BtnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCitas.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnCitas.Image = CType(resources.GetObject("BtnCitas.Image"), System.Drawing.Image)
        Me.BtnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCitas.Location = New System.Drawing.Point(0, 314)
        Me.BtnCitas.Name = "BtnCitas"
        Me.BtnCitas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnCitas.Size = New System.Drawing.Size(233, 50)
        Me.BtnCitas.TabIndex = 3
        Me.BtnCitas.Text = "CITAS"
        Me.BtnCitas.UseVisualStyleBackColor = False
        '
        'BtnDocumentos
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnDocumentos, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnDocumentos, BunifuAnimatorNS.DecorationType.None)
        Me.BtnDocumentos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDocumentos.FlatAppearance.BorderSize = 0
        Me.BtnDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDocumentos.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnDocumentos.Image = CType(resources.GetObject("BtnDocumentos.Image"), System.Drawing.Image)
        Me.BtnDocumentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDocumentos.Location = New System.Drawing.Point(0, 70)
        Me.BtnDocumentos.Name = "BtnDocumentos"
        Me.BtnDocumentos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnDocumentos.Size = New System.Drawing.Size(233, 35)
        Me.BtnDocumentos.TabIndex = 2
        Me.BtnDocumentos.Text = "Documentos"
        Me.BtnDocumentos.UseVisualStyleBackColor = True
        '
        'BtnHCasos
        '
        Me.AnimacionPanelMenuLateral.SetDecoration(Me.BtnHCasos, BunifuAnimatorNS.DecorationType.None)
        Me.AnimacionPanelMenuLateralBack.SetDecoration(Me.BtnHCasos, BunifuAnimatorNS.DecorationType.None)
        Me.BtnHCasos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHCasos.FlatAppearance.BorderSize = 0
        Me.BtnHCasos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHCasos.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.BtnHCasos.Image = CType(resources.GetObject("BtnHCasos.Image"), System.Drawing.Image)
        Me.BtnHCasos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHCasos.Location = New System.Drawing.Point(0, 35)
        Me.BtnHCasos.Name = "BtnHCasos"
        Me.BtnHCasos.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BtnHCasos.Size = New System.Drawing.Size(233, 35)
        Me.BtnHCasos.TabIndex = 1
        Me.BtnHCasos.Text = "Historial de Casos"
        Me.BtnHCasos.UseVisualStyleBackColor = True
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
        Me.PicUsuario.Location = New System.Drawing.Point(39, 12)
        Me.PicUsuario.Name = "PicUsuario"
        Me.PicUsuario.Size = New System.Drawing.Size(152, 108)
        Me.PicUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicUsuario.TabIndex = 1
        Me.PicUsuario.TabStop = False
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
        Me.PanelRH.ResumeLayout(False)
        Me.PanelPLab.ResumeLayout(False)
        Me.PanelSubCitas.ResumeLayout(False)
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
    Friend WithEvents PanelSubCitas As Panel
    Friend WithEvents BtnCitas As Button
    Friend WithEvents PanelSubPacientes As Panel
    Friend WithEvents BtnDocumentos As Button
    Friend WithEvents BtnHCasos As Button
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
    Friend WithEvents PanelRH As Panel
    Friend WithEvents BtnRecepcionista As Button
    Friend WithEvents BtnEnfermera As Button
    Friend WithEvents BtnLaboratorista As Button
    Friend WithEvents BtnMedicos As Button
    Friend WithEvents BtnRH As Button
    Friend WithEvents PanelPLab As Panel
    Friend WithEvents BtnInforme As Button
    Friend WithEvents BtnPLab As Button
    Friend WithEvents BtnPrescripcion As Button
    Friend WithEvents BtnCalendario As Button
    Friend WithEvents BtnTodas As Button
    Friend WithEvents BtnVerInformes As Button
    Friend WithEvents MostrarMenu As Timer
    Friend WithEvents OcultarMenu As Timer
    Private WithEvents CurvaSidebar As Bunifu.Framework.UI.BunifuElipse
    Private WithEvents AnimacionPanelMenuLateral As BunifuAnimatorNS.BunifuTransition
    Private WithEvents AnimacionPanelMenuLateralBack As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Public WithEvents LinkSesion As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblUsuario As TextBox
End Class
