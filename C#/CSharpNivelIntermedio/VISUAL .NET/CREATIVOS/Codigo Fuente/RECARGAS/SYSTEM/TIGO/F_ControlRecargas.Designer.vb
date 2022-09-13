<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_ControlRecargas
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
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.MaskedTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.ComprarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReiniciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CierreToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldoAnteriorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaldoActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErroresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSaldoAnterior = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSaldoActual = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblVendido = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCierre = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblEfectivo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel11 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCreditos = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel13 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblErrores = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel10 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblHora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblCompra = New System.Windows.Forms.Label()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.lblObservacion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblDinero = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblCel = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCelular
        '
        Me.txtCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(22, 138)
        Me.txtCelular.Mask = "99-99-99-99"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(467, 98)
        Me.txtCelular.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(17, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 39)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Celular"
        '
        'txtId
        '
        Me.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(1018, 70)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(65, 35)
        Me.txtId.TabIndex = 78
        '
        'txtnombre
        '
        Me.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(228, 331)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(560, 62)
        Me.txtnombre.TabIndex = 74
        Me.txtnombre.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(407, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 39)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Nombre"
        Me.Label5.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(1031, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 29)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Id"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox1.Location = New System.Drawing.Point(803, 304)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(252, 43)
        Me.CheckBox1.TabIndex = 103
        Me.CheckBox1.Text = "AL CREDITO"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(478, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 98)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(670, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 39)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(677, 138)
        Me.txtCantidad.Mask = "999"
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(172, 98)
        Me.txtCantidad.TabIndex = 3
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel6, Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1, Me.lblSaldoAnterior, Me.ToolStripStatusLabel2, Me.lblSaldoActual, Me.ToolStripStatusLabel4, Me.lblVendido, Me.ToolStripStatusLabel7, Me.lblCierre})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(1124, 42)
        Me.StatusStrip1.TabIndex = 85
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(135, 37)
        Me.ToolStripStatusLabel6.Text = "Opciones"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprarToolStripMenuItem, Me.CierreToolStripMenuItem, Me.ReiniciarToolStripMenuItem})
        Me.ToolStripSplitButton1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripSplitButton1.Image = Global.CREATIVOS.My.Resources.Resources.tigo_1
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 40)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'ComprarToolStripMenuItem
        '
        Me.ComprarToolStripMenuItem.Name = "ComprarToolStripMenuItem"
        Me.ComprarToolStripMenuItem.Size = New System.Drawing.Size(211, 34)
        Me.ComprarToolStripMenuItem.Text = "Comprar"
        '
        'CierreToolStripMenuItem
        '
        Me.CierreToolStripMenuItem.Name = "CierreToolStripMenuItem"
        Me.CierreToolStripMenuItem.Size = New System.Drawing.Size(211, 34)
        Me.CierreToolStripMenuItem.Text = "Cierre del Dia"
        '
        'ReiniciarToolStripMenuItem
        '
        Me.ReiniciarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CierreToolStripMenuItem1, Me.CreditosToolStripMenuItem, Me.SaldoAnteriorToolStripMenuItem, Me.SaldoActualToolStripMenuItem, Me.ErroresToolStripMenuItem, Me.VendidoToolStripMenuItem, Me.ComprasMToolStripMenuItem, Me.TodoToolStripMenuItem})
        Me.ReiniciarToolStripMenuItem.Name = "ReiniciarToolStripMenuItem"
        Me.ReiniciarToolStripMenuItem.Size = New System.Drawing.Size(211, 34)
        Me.ReiniciarToolStripMenuItem.Text = "Reiniciar"
        '
        'CierreToolStripMenuItem1
        '
        Me.CierreToolStripMenuItem1.Name = "CierreToolStripMenuItem1"
        Me.CierreToolStripMenuItem1.Size = New System.Drawing.Size(205, 34)
        Me.CierreToolStripMenuItem1.Text = "Cierre"
        '
        'CreditosToolStripMenuItem
        '
        Me.CreditosToolStripMenuItem.Name = "CreditosToolStripMenuItem"
        Me.CreditosToolStripMenuItem.Size = New System.Drawing.Size(205, 34)
        Me.CreditosToolStripMenuItem.Text = "Creditos"
        '
        'SaldoAnteriorToolStripMenuItem
        '
        Me.SaldoAnteriorToolStripMenuItem.Name = "SaldoAnteriorToolStripMenuItem"
        Me.SaldoAnteriorToolStripMenuItem.Size = New System.Drawing.Size(205, 34)
        Me.SaldoAnteriorToolStripMenuItem.Text = "Saldos"
        '
        'SaldoActualToolStripMenuItem
        '
        Me.SaldoActualToolStripMenuItem.Name = "SaldoActualToolStripMenuItem"
        Me.SaldoActualToolStripMenuItem.Size = New System.Drawing.Size(205, 34)
        Me.SaldoActualToolStripMenuItem.Text = "Efectivo"
        '
        'ErroresToolStripMenuItem
        '
        Me.ErroresToolStripMenuItem.Name = "ErroresToolStripMenuItem"
        Me.ErroresToolStripMenuItem.Size = New System.Drawing.Size(205, 34)
        Me.ErroresToolStripMenuItem.Text = "Errores"
        '
        'VendidoToolStripMenuItem
        '
        Me.VendidoToolStripMenuItem.Name = "VendidoToolStripMenuItem"
        Me.VendidoToolStripMenuItem.Size = New System.Drawing.Size(205, 34)
        Me.VendidoToolStripMenuItem.Text = "Vendido"
        '
        'ComprasMToolStripMenuItem
        '
        Me.ComprasMToolStripMenuItem.Name = "ComprasMToolStripMenuItem"
        Me.ComprasMToolStripMenuItem.Size = New System.Drawing.Size(205, 34)
        Me.ComprasMToolStripMenuItem.Text = "Editar Saldos"
        '
        'TodoToolStripMenuItem
        '
        Me.TodoToolStripMenuItem.Name = "TodoToolStripMenuItem"
        Me.TodoToolStripMenuItem.Size = New System.Drawing.Size(205, 34)
        Me.TodoToolStripMenuItem.Text = "Todo"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(204, 37)
        Me.ToolStripStatusLabel1.Text = "Saldo Anterior"
        '
        'lblSaldoAnterior
        '
        Me.lblSaldoAnterior.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoAnterior.ForeColor = System.Drawing.Color.Blue
        Me.lblSaldoAnterior.Name = "lblSaldoAnterior"
        Me.lblSaldoAnterior.Size = New System.Drawing.Size(31, 37)
        Me.lblSaldoAnterior.Text = "S"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(178, 37)
        Me.ToolStripStatusLabel2.Text = "Saldo Actual"
        '
        'lblSaldoActual
        '
        Me.lblSaldoActual.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldoActual.ForeColor = System.Drawing.Color.Blue
        Me.lblSaldoActual.Name = "lblSaldoActual"
        Me.lblSaldoActual.Size = New System.Drawing.Size(48, 37)
        Me.lblSaldoActual.Text = "SA"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(123, 37)
        Me.ToolStripStatusLabel4.Text = "Vendido"
        '
        'lblVendido
        '
        Me.lblVendido.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendido.ForeColor = System.Drawing.Color.Blue
        Me.lblVendido.Name = "lblVendido"
        Me.lblVendido.Size = New System.Drawing.Size(34, 37)
        Me.lblVendido.Text = "V"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(94, 37)
        Me.ToolStripStatusLabel7.Text = "Cierre"
        '
        'lblCierre
        '
        Me.lblCierre.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCierre.ForeColor = System.Drawing.Color.Blue
        Me.lblCierre.Name = "lblCierre"
        Me.lblCierre.Size = New System.Drawing.Size(34, 37)
        Me.lblCierre.Text = "C"
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel5, Me.lblEfectivo, Me.ToolStripStatusLabel11, Me.lblCreditos, Me.ToolStripStatusLabel13, Me.lblErrores, Me.ToolStripStatusLabel9, Me.lblFecha, Me.ToolStripStatusLabel10, Me.lblHora, Me.lblUsuario})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 537)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.StatusStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip2.Size = New System.Drawing.Size(1124, 42)
        Me.StatusStrip2.TabIndex = 86
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(120, 37)
        Me.ToolStripStatusLabel5.Text = "Efectivo"
        '
        'lblEfectivo
        '
        Me.lblEfectivo.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEfectivo.ForeColor = System.Drawing.Color.Blue
        Me.lblEfectivo.Name = "lblEfectivo"
        Me.lblEfectivo.Size = New System.Drawing.Size(31, 37)
        Me.lblEfectivo.Text = "E"
        '
        'ToolStripStatusLabel11
        '
        Me.ToolStripStatusLabel11.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel11.Name = "ToolStripStatusLabel11"
        Me.ToolStripStatusLabel11.Size = New System.Drawing.Size(125, 37)
        Me.ToolStripStatusLabel11.Text = "Creditos"
        '
        'lblCreditos
        '
        Me.lblCreditos.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditos.ForeColor = System.Drawing.Color.Blue
        Me.lblCreditos.Name = "lblCreditos"
        Me.lblCreditos.Size = New System.Drawing.Size(50, 37)
        Me.lblCreditos.Text = "CR"
        '
        'ToolStripStatusLabel13
        '
        Me.ToolStripStatusLabel13.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel13.Name = "ToolStripStatusLabel13"
        Me.ToolStripStatusLabel13.Size = New System.Drawing.Size(108, 37)
        Me.ToolStripStatusLabel13.Text = "Errores"
        '
        'lblErrores
        '
        Me.lblErrores.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrores.ForeColor = System.Drawing.Color.Blue
        Me.lblErrores.Name = "lblErrores"
        Me.lblErrores.Size = New System.Drawing.Size(47, 37)
        Me.lblErrores.Text = "ER"
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(90, 37)
        Me.ToolStripStatusLabel9.Text = "Fecha"
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Blue
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(30, 37)
        Me.lblFecha.Text = "F"
        '
        'ToolStripStatusLabel10
        '
        Me.ToolStripStatusLabel10.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel10.Name = "ToolStripStatusLabel10"
        Me.ToolStripStatusLabel10.Size = New System.Drawing.Size(81, 37)
        Me.ToolStripStatusLabel10.Text = "Hora"
        '
        'lblHora
        '
        Me.lblHora.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.Blue
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(36, 37)
        Me.lblHora.Text = "H"
        '
        'lblUsuario
        '
        Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(36, 37)
        Me.lblUsuario.Text = "U"
        '
        'lblCompra
        '
        Me.lblCompra.AutoSize = True
        Me.lblCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompra.Location = New System.Drawing.Point(386, 475)
        Me.lblCompra.Name = "lblCompra"
        Me.lblCompra.Size = New System.Drawing.Size(18, 20)
        Me.lblCompra.TabIndex = 88
        Me.lblCompra.Text = "0"
        Me.lblCompra.Visible = False
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(249, 486)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(40, 23)
        Me.Calcular.TabIndex = 89
        Me.Calcular.Text = "..."
        Me.Calcular.UseVisualStyleBackColor = True
        Me.Calcular.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox2.Location = New System.Drawing.Point(803, 353)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(214, 43)
        Me.CheckBox2.TabIndex = 104
        Me.CheckBox2.Text = "ERRORES"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'lblObservacion
        '
        Me.lblObservacion.AutoSize = True
        Me.lblObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservacion.Location = New System.Drawing.Point(410, 424)
        Me.lblObservacion.Name = "lblObservacion"
        Me.lblObservacion.Size = New System.Drawing.Size(103, 24)
        Me.lblObservacion.TabIndex = 91
        Me.lblObservacion.Text = "NINGUNA"
        Me.lblObservacion.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(225, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 24)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "MONTO:"
        Me.Label4.Visible = False
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMonto.Location = New System.Drawing.Point(342, 428)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(18, 20)
        Me.lblMonto.TabIndex = 93
        Me.lblMonto.Text = "0"
        Me.lblMonto.Visible = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblError.Location = New System.Drawing.Point(400, 508)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(18, 20)
        Me.lblError.TabIndex = 94
        Me.lblError.Text = "0"
        Me.lblError.Visible = False
        '
        'lblDinero
        '
        Me.lblDinero.AutoSize = True
        Me.lblDinero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinero.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDinero.Location = New System.Drawing.Point(326, 508)
        Me.lblDinero.Name = "lblDinero"
        Me.lblDinero.Size = New System.Drawing.Size(18, 20)
        Me.lblDinero.TabIndex = 95
        Me.lblDinero.Text = "0"
        Me.lblDinero.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.CREATIVOS.My.Resources.Resources.money_icon
        Me.Button2.Location = New System.Drawing.Point(634, 402)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 126)
        Me.Button2.TabIndex = 96
        Me.Button2.Text = "CREDITOS"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CREATIVOS.My.Resources.Resources.tigo_1
        Me.PictureBox1.Location = New System.Drawing.Point(22, 332)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 196)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.CREATIVOS.My.Resources.Resources.Actions_application_exit_icon
        Me.btnSalir.Location = New System.Drawing.Point(948, 402)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(135, 126)
        Me.btnSalir.TabIndex = 150
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.CREATIVOS.My.Resources.Resources.Floppy_Small_icon3
        Me.btnGuardar.Location = New System.Drawing.Point(787, 402)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(139, 126)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "AGREGAR"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblCel
        '
        Me.lblCel.AutoSize = True
        Me.lblCel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCel.Location = New System.Drawing.Point(71, 305)
        Me.lblCel.Name = "lblCel"
        Me.lblCel.Size = New System.Drawing.Size(59, 24)
        Me.lblCel.TabIndex = 97
        Me.lblCel.Text = "TIGO"
        Me.lblCel.Visible = False
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.CREATIVOS.My.Resources.Resources.money_icon
        Me.Button3.Location = New System.Drawing.Point(855, 138)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 98)
        Me.Button3.TabIndex = 98
        Me.Button3.Text = "Abonar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.Blue
        Me.CheckBox3.Location = New System.Drawing.Point(803, 255)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(250, 43)
        Me.CheckBox3.TabIndex = 151
        Me.CheckBox3.Text = "PAQUETIGO"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'F_ControlRecargas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1124, 579)
        Me.ControlBox = False
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lblCel)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblDinero)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblObservacion)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.lblCompra)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtCelular)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_ControlRecargas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTROL DE RECARGAS - TIGO"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSaldoAnterior As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSaldoActual As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblVendido As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ComprarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCierre As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel10 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblHora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CierreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCompra As System.Windows.Forms.Label
    Friend WithEvents Calcular As System.Windows.Forms.Button
    Friend WithEvents ReiniciarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaldoAnteriorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaldoActualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CierreToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblEfectivo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel11 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblCreditos As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel13 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblErrores As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents lblObservacion As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblDinero As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CreditosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ErroresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCel As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
