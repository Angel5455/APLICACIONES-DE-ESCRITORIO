<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFactura = New System.Windows.Forms.RadioButton()
        Me.radBoleta = New System.Windows.Forms.RadioButton()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.txtCodCli = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNomCli = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodEmpl = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNomEmp = New System.Windows.Forms.TextBox()
        Me.DatosGrid = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodigoDocu = New System.Windows.Forms.TextBox()
        Me.cbTipoDocu = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIgv = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnBusEmpleado = New System.Windows.Forms.Button()
        Me.btnBusCliente = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DatosGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NUMERO DOCUMENTO"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(148, 18)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radFactura)
        Me.GroupBox1.Controls.Add(Me.radBoleta)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 56)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Documento"
        '
        'radFactura
        '
        Me.radFactura.AutoSize = True
        Me.radFactura.Location = New System.Drawing.Point(214, 24)
        Me.radFactura.Name = "radFactura"
        Me.radFactura.Size = New System.Drawing.Size(92, 17)
        Me.radFactura.TabIndex = 1
        Me.radFactura.TabStop = True
        Me.radFactura.Text = "PRESTAMOS"
        Me.radFactura.UseVisualStyleBackColor = True
        '
        'radBoleta
        '
        Me.radBoleta.AutoSize = True
        Me.radBoleta.Location = New System.Drawing.Point(43, 25)
        Me.radBoleta.Name = "radBoleta"
        Me.radBoleta.Size = New System.Drawing.Size(63, 17)
        Me.radBoleta.TabIndex = 0
        Me.radBoleta.TabStop = True
        Me.radBoleta.Text = "TICKET"
        Me.radBoleta.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(394, 23)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(378, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FECHA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(418, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ESTADO"
        '
        'cbEstado
        '
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(381, 70)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(121, 21)
        Me.cbEstado.TabIndex = 6
        '
        'txtCodCli
        '
        Me.txtCodCli.Location = New System.Drawing.Point(153, 114)
        Me.txtCodCli.Name = "txtCodCli"
        Me.txtCodCli.Size = New System.Drawing.Size(100, 20)
        Me.txtCodCli.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CODIGO CLIENTE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "NOMBRE"
        '
        'txtNomCli
        '
        Me.txtNomCli.Location = New System.Drawing.Point(153, 139)
        Me.txtNomCli.Name = "txtNomCli"
        Me.txtNomCli.Size = New System.Drawing.Size(211, 20)
        Me.txtNomCli.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "CODIGO EMPLEADO"
        '
        'txtCodEmpl
        '
        Me.txtCodEmpl.Location = New System.Drawing.Point(153, 167)
        Me.txtCodEmpl.Name = "txtCodEmpl"
        Me.txtCodEmpl.Size = New System.Drawing.Size(100, 20)
        Me.txtCodEmpl.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "NOMBRE"
        '
        'txtNomEmp
        '
        Me.txtNomEmp.Location = New System.Drawing.Point(154, 196)
        Me.txtNomEmp.Name = "txtNomEmp"
        Me.txtNomEmp.Size = New System.Drawing.Size(210, 20)
        Me.txtNomEmp.TabIndex = 15
        '
        'DatosGrid
        '
        Me.DatosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Precio, Me.Cantidad, Me.Importe})
        Me.DatosGrid.Location = New System.Drawing.Point(30, 248)
        Me.DatosGrid.Name = "DatosGrid"
        Me.DatosGrid.Size = New System.Drawing.Size(464, 124)
        Me.DatosGrid.TabIndex = 17
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(29, 219)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 18
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(119, 219)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitar.TabIndex = 19
        Me.btnQuitar.Text = "QUITAR"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(29, 373)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 20
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(119, 373)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 21
        Me.btnGrabar.Text = "GRABAR"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnImprimir)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtCodigoDocu)
        Me.GroupBox2.Controls.Add(Me.cbTipoDocu)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 446)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(465, 66)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reporte"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(352, 30)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 23
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(169, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Codigo"
        '
        'txtCodigoDocu
        '
        Me.txtCodigoDocu.Location = New System.Drawing.Point(172, 33)
        Me.txtCodigoDocu.Name = "txtCodigoDocu"
        Me.txtCodigoDocu.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoDocu.TabIndex = 23
        '
        'cbTipoDocu
        '
        Me.cbTipoDocu.FormattingEnabled = True
        Me.cbTipoDocu.Location = New System.Drawing.Point(15, 33)
        Me.cbTipoDocu.Name = "cbTipoDocu"
        Me.cbTipoDocu.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoDocu.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Seleccione Tipo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(316, 380)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "SUBTOTAL"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Location = New System.Drawing.Point(394, 375)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(316, 406)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "ISV"
        '
        'txtIgv
        '
        Me.txtIgv.Location = New System.Drawing.Point(394, 401)
        Me.txtIgv.Name = "txtIgv"
        Me.txtIgv.Size = New System.Drawing.Size(100, 20)
        Me.txtIgv.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(316, 432)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "TOTAL"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(394, 427)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 27
        '
        'btnBusEmpleado
        '
        Me.btnBusEmpleado.Location = New System.Drawing.Point(381, 166)
        Me.btnBusEmpleado.Name = "btnBusEmpleado"
        Me.btnBusEmpleado.Size = New System.Drawing.Size(75, 23)
        Me.btnBusEmpleado.TabIndex = 8
        Me.btnBusEmpleado.Text = "BUSCAR"
        Me.btnBusEmpleado.UseVisualStyleBackColor = True
        '
        'btnBusCliente
        '
        Me.btnBusCliente.Location = New System.Drawing.Point(381, 116)
        Me.btnBusCliente.Name = "btnBusCliente"
        Me.btnBusCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnBusCliente.TabIndex = 7
        Me.btnBusCliente.Text = "BUSCAR"
        Me.btnBusCliente.UseVisualStyleBackColor = True
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 528)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtIgv)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.DatosGrid)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNomEmp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCodEmpl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNomCli)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodCli)
        Me.Controls.Add(Me.btnBusEmpleado)
        Me.Controls.Add(Me.btnBusCliente)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Factura"
        Me.Text = "Factura"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DatosGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radFactura As System.Windows.Forms.RadioButton
    Friend WithEvents radBoleta As System.Windows.Forms.RadioButton
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodCli As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNomCli As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCodEmpl As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNomEmp As System.Windows.Forms.TextBox
    Friend WithEvents DatosGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoDocu As System.Windows.Forms.TextBox
    Friend WithEvents cbTipoDocu As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIgv As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBusEmpleado As System.Windows.Forms.Button
    Friend WithEvents btnBusCliente As System.Windows.Forms.Button
End Class
