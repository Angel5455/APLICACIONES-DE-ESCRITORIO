<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Recibo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_Recibo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblLetras = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblConcepto = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblAnterior = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblAbono = New System.Windows.Forms.Label()
        Me.lblActual = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarCantidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarConceptoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarSaldoAnteriorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarAbonoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarSaldoActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblReciboAnt = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Museo 700", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(80, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 35)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "CREATIVOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 24)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "B° Arriba RTN 1601-1975-002586"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 24)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Tel. 2643-3228 / 2643-0271"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(931, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 29)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "N°"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(980, 32)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(19, 29)
        Me.lblId.TabIndex = 34
        Me.lblId.Text = "."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(876, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 20)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Comprobante de Ingreso"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 24)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Fecha:"
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.lblFecha.Location = New System.Drawing.Point(104, 169)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(213, 29)
        Me.lblFecha.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(819, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 24)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Por Lps."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCantidad)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(904, 139)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 47)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.BackColor = System.Drawing.Color.Transparent
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(15, 19)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(98, 24)
        Me.lblCantidad.TabIndex = 41
        Me.lblCantidad.Text = "________"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 255)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 24)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Recibi de:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.BackColor = System.Drawing.Color.Transparent
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(140, 255)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(912, 24)
        Me.lblCliente.TabIndex = 42
        Me.lblCliente.Text = "_________________________________________________________________________________" & _
            "_"
        '
        'lblLetras
        '
        Me.lblLetras.AutoSize = True
        Me.lblLetras.BackColor = System.Drawing.Color.Transparent
        Me.lblLetras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetras.Location = New System.Drawing.Point(134, 291)
        Me.lblLetras.Name = "lblLetras"
        Me.lblLetras.Size = New System.Drawing.Size(912, 24)
        Me.lblLetras.TabIndex = 44
        Me.lblLetras.Text = "_________________________________________________________________________________" & _
            "_"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(29, 291)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 24)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Suma de:"
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.BackColor = System.Drawing.Color.Transparent
        Me.lblConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConcepto.Location = New System.Drawing.Point(193, 332)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(857, 24)
        Me.lblConcepto.TabIndex = 46
        Me.lblConcepto.Text = "_____________________________________________________________________________"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(29, 332)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(158, 24)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Por Concepto de:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(123, 531)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 24)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Usuario:"
        Me.Label8.Visible = False
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(208, 531)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(90, 24)
        Me.lblUsuario.TabIndex = 42
        Me.lblUsuario.Text = "________"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblUsuario.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(904, 158)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(119, 32)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 437)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 24)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Saldo Anterior"
        '
        'lblAnterior
        '
        Me.lblAnterior.AutoSize = True
        Me.lblAnterior.BackColor = System.Drawing.Color.Transparent
        Me.lblAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnterior.Location = New System.Drawing.Point(164, 437)
        Me.lblAnterior.Name = "lblAnterior"
        Me.lblAnterior.Size = New System.Drawing.Size(110, 24)
        Me.lblAnterior.TabIndex = 52
        Me.lblAnterior.Text = "__________"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 463)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 24)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Abono"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 490)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 24)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Saldo Actual"
        '
        'lblAbono
        '
        Me.lblAbono.AutoSize = True
        Me.lblAbono.BackColor = System.Drawing.Color.Transparent
        Me.lblAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbono.Location = New System.Drawing.Point(165, 463)
        Me.lblAbono.Name = "lblAbono"
        Me.lblAbono.Size = New System.Drawing.Size(110, 24)
        Me.lblAbono.TabIndex = 57
        Me.lblAbono.Text = "__________"
        '
        'lblActual
        '
        Me.lblActual.AutoSize = True
        Me.lblActual.BackColor = System.Drawing.Color.Transparent
        Me.lblActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActual.Location = New System.Drawing.Point(165, 490)
        Me.lblActual.Name = "lblActual"
        Me.lblActual.Size = New System.Drawing.Size(110, 24)
        Me.lblActual.TabIndex = 58
        Me.lblActual.Text = "__________"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarCantidadToolStripMenuItem, Me.EditarClienteToolStripMenuItem, Me.EditarConceptoToolStripMenuItem, Me.EditarSaldoAnteriorToolStripMenuItem, Me.EditarAbonoToolStripMenuItem, Me.EditarSaldoActualToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(222, 160)
        '
        'EditarCantidadToolStripMenuItem
        '
        Me.EditarCantidadToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarCantidadToolStripMenuItem.Image = Global.CREATIVOS.My.Resources.Resources.edit_icon
        Me.EditarCantidadToolStripMenuItem.Name = "EditarCantidadToolStripMenuItem"
        Me.EditarCantidadToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.EditarCantidadToolStripMenuItem.Text = "Editar Cantidad"
        '
        'EditarClienteToolStripMenuItem
        '
        Me.EditarClienteToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarClienteToolStripMenuItem.Image = CType(resources.GetObject("EditarClienteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarClienteToolStripMenuItem.Name = "EditarClienteToolStripMenuItem"
        Me.EditarClienteToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.EditarClienteToolStripMenuItem.Text = "Editar Cliente"
        '
        'EditarConceptoToolStripMenuItem
        '
        Me.EditarConceptoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarConceptoToolStripMenuItem.Image = CType(resources.GetObject("EditarConceptoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarConceptoToolStripMenuItem.Name = "EditarConceptoToolStripMenuItem"
        Me.EditarConceptoToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.EditarConceptoToolStripMenuItem.Text = "Editar Concepto"
        '
        'EditarSaldoAnteriorToolStripMenuItem
        '
        Me.EditarSaldoAnteriorToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarSaldoAnteriorToolStripMenuItem.Image = CType(resources.GetObject("EditarSaldoAnteriorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarSaldoAnteriorToolStripMenuItem.Name = "EditarSaldoAnteriorToolStripMenuItem"
        Me.EditarSaldoAnteriorToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.EditarSaldoAnteriorToolStripMenuItem.Text = "Editar Saldo Anterior"
        '
        'EditarAbonoToolStripMenuItem
        '
        Me.EditarAbonoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarAbonoToolStripMenuItem.Image = CType(resources.GetObject("EditarAbonoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarAbonoToolStripMenuItem.Name = "EditarAbonoToolStripMenuItem"
        Me.EditarAbonoToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.EditarAbonoToolStripMenuItem.Text = "Editar Abono"
        '
        'EditarSaldoActualToolStripMenuItem
        '
        Me.EditarSaldoActualToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditarSaldoActualToolStripMenuItem.Image = CType(resources.GetObject("EditarSaldoActualToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditarSaldoActualToolStripMenuItem.Name = "EditarSaldoActualToolStripMenuItem"
        Me.EditarSaldoActualToolStripMenuItem.Size = New System.Drawing.Size(221, 26)
        Me.EditarSaldoActualToolStripMenuItem.Text = "Editar Saldo Actual"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.BackColor = System.Drawing.Color.Transparent
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(508, 531)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(90, 24)
        Me.lblEstado.TabIndex = 153
        Me.lblEstado.Text = "________"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(423, 531)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 24)
        Me.Label16.TabIndex = 154
        Me.Label16.Text = "Estado:"
        '
        'lblReciboAnt
        '
        Me.lblReciboAnt.AutoSize = True
        Me.lblReciboAnt.BackColor = System.Drawing.Color.Transparent
        Me.lblReciboAnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReciboAnt.Location = New System.Drawing.Point(497, 437)
        Me.lblReciboAnt.Name = "lblReciboAnt"
        Me.lblReciboAnt.Size = New System.Drawing.Size(90, 24)
        Me.lblReciboAnt.TabIndex = 155
        Me.lblReciboAnt.Text = "________"
        Me.lblReciboAnt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblReciboAnt.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(412, 437)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 24)
        Me.Label17.TabIndex = 156
        Me.Label17.Text = "Recibo"
        Me.Label17.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CREATIVOS.My.Resources.Resources.logo_la
        Me.PictureBox1.Location = New System.Drawing.Point(19, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.CREATIVOS.My.Resources.Resources.Actions_application_exit_icon
        Me.btnSalir.Location = New System.Drawing.Point(924, 405)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(135, 126)
        Me.btnSalir.TabIndex = 152
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.CREATIVOS.My.Resources.Resources.Floppy_Small_icon3
        Me.btnGuardar.Location = New System.Drawing.Point(759, 405)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(139, 126)
        Me.btnGuardar.TabIndex = 151
        Me.btnGuardar.Text = "AGREGAR"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'F_Recibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1124, 579)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.lblReciboAnt)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblActual)
        Me.Controls.Add(Me.lblAbono)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblAnterior)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblConcepto)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblLetras)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "F_Recibo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RECIBO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents lblLetras As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblConcepto As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblAnterior As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblAbono As System.Windows.Forms.Label
    Friend WithEvents lblActual As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditarCantidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents EditarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarConceptoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarSaldoAnteriorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarAbonoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarSaldoActualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblReciboAnt As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
