<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class R_Impresion
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(R_Impresion))
        Me.Label6 = New System.Windows.Forms.Label
        Me.label21 = New System.Windows.Forms.Label
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.lblMonto_Aprobado = New System.Windows.Forms.Label
        Me.lblSaldo_Anterior = New System.Windows.Forms.Label
        Me.lblMonto_Desembolsado = New System.Windows.Forms.Label
        Me.lblCantidad_Disponible = New System.Windows.Forms.Label
        Me.lblRegional = New System.Windows.Forms.Label
        Me.lblAgencia = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblIdentidad = New System.Windows.Forms.Label
        Me.lblClave = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.lblFase = New System.Windows.Forms.Label
        Me.lblr = New System.Windows.Forms.Label
        Me.lbla = New System.Windows.Forms.Label
        Me.lblpres = New System.Windows.Forms.Label
        Me.lblaño = New System.Windows.Forms.Label
        Me.lbld = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblFactura = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Picturebox6 = New System.Windows.Forms.PictureBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picturebox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(212, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 25)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "ORDEN DE ENTREGA"
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label21.ForeColor = System.Drawing.Color.Black
        Me.label21.Location = New System.Drawing.Point(134, 177)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(197, 16)
        Me.label21.TabIndex = 32
        Me.label21.Text = "___________________________"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToFile
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(91, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 16)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "DESEMBOLSO Nº:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(48, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "REGIONAL:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(340, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "AGENCIA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(407, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 16)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "___________________________"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(48, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(198, 16)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "NOMBRE DEL PRESTATARIO:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(372, 239)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 16)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "CLAVE:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(49, 239)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 16)
        Me.Label17.TabIndex = 71
        Me.Label17.Text = "IDENTIDAD:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(134, 239)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(232, 16)
        Me.Label18.TabIndex = 70
        Me.Label18.Text = "________________________________"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(138, 424)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(375, 16)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "ORDEN DE ENTREGA DE INSUMOS Y MATERIALES"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(51, 443)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(570, 195)
        Me.DataGridView1.TabIndex = 81
        '
        'lblMonto_Aprobado
        '
        Me.lblMonto_Aprobado.AutoSize = True
        Me.lblMonto_Aprobado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto_Aprobado.ForeColor = System.Drawing.Color.Black
        Me.lblMonto_Aprobado.Location = New System.Drawing.Point(403, 286)
        Me.lblMonto_Aprobado.Name = "lblMonto_Aprobado"
        Me.lblMonto_Aprobado.Size = New System.Drawing.Size(127, 16)
        Me.lblMonto_Aprobado.TabIndex = 82
        Me.lblMonto_Aprobado.Text = "lblMonto_Aprobado"
        Me.lblMonto_Aprobado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSaldo_Anterior
        '
        Me.lblSaldo_Anterior.AutoSize = True
        Me.lblSaldo_Anterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaldo_Anterior.ForeColor = System.Drawing.Color.Black
        Me.lblSaldo_Anterior.Location = New System.Drawing.Point(411, 317)
        Me.lblSaldo_Anterior.Name = "lblSaldo_Anterior"
        Me.lblSaldo_Anterior.Size = New System.Drawing.Size(111, 16)
        Me.lblSaldo_Anterior.TabIndex = 83
        Me.lblSaldo_Anterior.Text = "lblSaldo_Anterior"
        Me.lblSaldo_Anterior.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonto_Desembolsado
        '
        Me.lblMonto_Desembolsado.AutoSize = True
        Me.lblMonto_Desembolsado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto_Desembolsado.ForeColor = System.Drawing.Color.Black
        Me.lblMonto_Desembolsado.Location = New System.Drawing.Point(402, 345)
        Me.lblMonto_Desembolsado.Name = "lblMonto_Desembolsado"
        Me.lblMonto_Desembolsado.Size = New System.Drawing.Size(153, 16)
        Me.lblMonto_Desembolsado.TabIndex = 84
        Me.lblMonto_Desembolsado.Text = "lblMontoDesembolsado"
        Me.lblMonto_Desembolsado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCantidad_Disponible
        '
        Me.lblCantidad_Disponible.AutoSize = True
        Me.lblCantidad_Disponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad_Disponible.ForeColor = System.Drawing.Color.Black
        Me.lblCantidad_Disponible.Location = New System.Drawing.Point(397, 377)
        Me.lblCantidad_Disponible.Name = "lblCantidad_Disponible"
        Me.lblCantidad_Disponible.Size = New System.Drawing.Size(148, 16)
        Me.lblCantidad_Disponible.TabIndex = 85
        Me.lblCantidad_Disponible.Text = "lblCantidad_Disponible"
        Me.lblCantidad_Disponible.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRegional
        '
        Me.lblRegional.AutoSize = True
        Me.lblRegional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegional.ForeColor = System.Drawing.Color.Black
        Me.lblRegional.Location = New System.Drawing.Point(150, 173)
        Me.lblRegional.Name = "lblRegional"
        Me.lblRegional.Size = New System.Drawing.Size(77, 16)
        Me.lblRegional.TabIndex = 86
        Me.lblRegional.Text = "lblRegional"
        '
        'lblAgencia
        '
        Me.lblAgencia.AutoSize = True
        Me.lblAgencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgencia.ForeColor = System.Drawing.Color.Black
        Me.lblAgencia.Location = New System.Drawing.Point(421, 173)
        Me.lblAgencia.Name = "lblAgencia"
        Me.lblAgencia.Size = New System.Drawing.Size(72, 16)
        Me.lblAgencia.TabIndex = 87
        Me.lblAgencia.Text = "lblAgencia"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(268, 206)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(71, 16)
        Me.lblNombre.TabIndex = 88
        Me.lblNombre.Text = "lblNombre"
        '
        'lblIdentidad
        '
        Me.lblIdentidad.AutoSize = True
        Me.lblIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdentidad.ForeColor = System.Drawing.Color.Black
        Me.lblIdentidad.Location = New System.Drawing.Point(150, 233)
        Me.lblIdentidad.Name = "lblIdentidad"
        Me.lblIdentidad.Size = New System.Drawing.Size(78, 16)
        Me.lblIdentidad.TabIndex = 89
        Me.lblIdentidad.Text = "lblIdentidad"
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClave.ForeColor = System.Drawing.Color.Black
        Me.lblClave.Location = New System.Drawing.Point(461, 235)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(57, 16)
        Me.lblClave.TabIndex = 90
        Me.lblClave.Text = "lblClave"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(280, 641)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(145, 28)
        Me.Label20.TabIndex = 91
        Me.Label20.Text = "GRAN TOTAL"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(479, 641)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(82, 25)
        Me.lblTotal.TabIndex = 92
        Me.lblTotal.Text = "lblTotal"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(165, 61)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 16)
        Me.Label22.TabIndex = 93
        Me.Label22.Text = "FASE"
        '
        'lblFase
        '
        Me.lblFase.AutoSize = True
        Me.lblFase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFase.ForeColor = System.Drawing.Color.Black
        Me.lblFase.Location = New System.Drawing.Point(218, 61)
        Me.lblFase.Name = "lblFase"
        Me.lblFase.Size = New System.Drawing.Size(60, 16)
        Me.lblFase.TabIndex = 94
        Me.lblFase.Text = "lblFase"
        '
        'lblr
        '
        Me.lblr.AutoSize = True
        Me.lblr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblr.ForeColor = System.Drawing.Color.Black
        Me.lblr.Location = New System.Drawing.Point(252, 132)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(26, 16)
        Me.lblr.TabIndex = 96
        Me.lblr.Text = "lblr"
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbla.ForeColor = System.Drawing.Color.Black
        Me.lbla.Location = New System.Drawing.Point(309, 132)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(30, 16)
        Me.lbla.TabIndex = 97
        Me.lbla.Text = "lbla"
        '
        'lblpres
        '
        Me.lblpres.AutoSize = True
        Me.lblpres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpres.ForeColor = System.Drawing.Color.Black
        Me.lblpres.Location = New System.Drawing.Point(361, 132)
        Me.lblpres.Name = "lblpres"
        Me.lblpres.Size = New System.Drawing.Size(49, 16)
        Me.lblpres.TabIndex = 98
        Me.lblpres.Text = "lblpres"
        '
        'lblaño
        '
        Me.lblaño.AutoSize = True
        Me.lblaño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaño.ForeColor = System.Drawing.Color.Black
        Me.lblaño.Location = New System.Drawing.Point(436, 132)
        Me.lblaño.Name = "lblaño"
        Me.lblaño.Size = New System.Drawing.Size(45, 16)
        Me.lblaño.TabIndex = 99
        Me.lblaño.Text = "lblaño"
        '
        'lbld
        '
        Me.lbld.AutoSize = True
        Me.lbld.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbld.ForeColor = System.Drawing.Color.Black
        Me.lbld.Location = New System.Drawing.Point(524, 132)
        Me.lbld.Name = "lbld"
        Me.lbld.Size = New System.Drawing.Size(30, 16)
        Me.lbld.TabIndex = 100
        Me.lbld.Text = "lbld"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(248, 210)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(358, 16)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "__________________________________________________"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(421, 239)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(183, 16)
        Me.Label16.TabIndex = 101
        Me.Label16.Text = "_________________________"
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFactura.ForeColor = System.Drawing.Color.Black
        Me.lblFactura.Location = New System.Drawing.Point(476, 61)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(77, 16)
        Me.lblFactura.TabIndex = 104
        Me.lblFactura.Text = "lblFactura"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(366, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "FACTURA Nº:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IHCAFE.My.Resources.Resources.Remove_Mark
        Me.PictureBox1.Location = New System.Drawing.Point(123, 667)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 105
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Salir")
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.IHCAFE.My.Resources.Resources.Printer
        Me.PictureBox5.Location = New System.Drawing.Point(51, 667)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 102
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Imprimir")
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.IHCAFE.My.Resources.Resources.Tabla3
        Me.PictureBox4.Location = New System.Drawing.Point(233, 113)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(336, 45)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 95
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.IHCAFE.My.Resources.Resources.TABLA1
        Me.PictureBox3.Location = New System.Drawing.Point(94, 270)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(477, 130)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 74
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.IHCAFE.My.Resources.Resources.Logo_del_IHCAFE_en_3d12
        Me.PictureBox2.Location = New System.Drawing.Point(16, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(85, 85)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'Picturebox6
        '
        Me.Picturebox6.Image = Global.IHCAFE.My.Resources.Resources._1__89_
        Me.Picturebox6.Location = New System.Drawing.Point(578, 12)
        Me.Picturebox6.Name = "Picturebox6"
        Me.Picturebox6.Size = New System.Drawing.Size(85, 85)
        Me.Picturebox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picturebox6.TabIndex = 52
        Me.Picturebox6.TabStop = False
        '
        'R_Impresion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(675, 742)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblFactura)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.lbld)
        Me.Controls.Add(Me.lblaño)
        Me.Controls.Add(Me.lblpres)
        Me.Controls.Add(Me.lbla)
        Me.Controls.Add(Me.lblr)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblFase)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblClave)
        Me.Controls.Add(Me.lblIdentidad)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblAgencia)
        Me.Controls.Add(Me.lblRegional)
        Me.Controls.Add(Me.lblCantidad_Disponible)
        Me.Controls.Add(Me.lblMonto_Desembolsado)
        Me.Controls.Add(Me.lblSaldo_Anterior)
        Me.Controls.Add(Me.lblMonto_Aprobado)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Picturebox6)
        Me.Controls.Add(Me.label21)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label16)
        Me.MaximizeBox = False
        Me.Name = "R_Impresion"
        Me.Text = "AREA DE IMPRESIONES"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picturebox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents label21 As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Picturebox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblMonto_Desembolsado As System.Windows.Forms.Label
    Friend WithEvents lblSaldo_Anterior As System.Windows.Forms.Label
    Friend WithEvents lblMonto_Aprobado As System.Windows.Forms.Label
    Friend WithEvents lblCantidad_Disponible As System.Windows.Forms.Label
    Friend WithEvents lblAgencia As System.Windows.Forms.Label
    Friend WithEvents lblRegional As System.Windows.Forms.Label
    Friend WithEvents lblIdentidad As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblClave As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblFase As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lbld As System.Windows.Forms.Label
    Friend WithEvents lblaño As System.Windows.Forms.Label
    Friend WithEvents lblpres As System.Windows.Forms.Label
    Friend WithEvents lbla As System.Windows.Forms.Label
    Friend WithEvents lblr As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents lblFactura As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
