<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_BuscarTicket
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTicket = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TicketsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketsTableAdapter = New CREATIVOS.dRptCREATIVOSTableAdapters.TicketsTableAdapter()
        Me.TicketsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DRptCREATIVOS = New CREATIVOS.dRptCREATIVOS()
        Me.TicketDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New CREATIVOS.dRptCREATIVOSTableAdapters.EmpleadosTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DRptCREATIVOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TicketDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.MesDataGridViewTextBoxColumn, Me.HoraDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TicketsBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(26, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(462, 149)
        Me.DataGridView1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(210, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Ticket"
        '
        'txtTicket
        '
        Me.txtTicket.Location = New System.Drawing.Point(213, 45)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.Size = New System.Drawing.Size(75, 20)
        Me.txtTicket.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(374, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 53)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "VISTA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PRELIMINAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TicketsBindingSource
        '
        Me.TicketsBindingSource.DataMember = "Tickets"
        Me.TicketsBindingSource.DataSource = Me.DRptCREATIVOS
        '
        'TicketsTableAdapter
        '
        Me.TicketsTableAdapter.ClearBeforeFill = True
        '
        'TicketsBindingSource1
        '
        Me.TicketsBindingSource1.DataMember = "Tickets"
        Me.TicketsBindingSource1.DataSource = Me.DRptCREATIVOS
        '
        'EmpleadosBindingSource1
        '
        Me.EmpleadosBindingSource1.DataMember = "Empleados"
        Me.EmpleadosBindingSource1.DataSource = Me.DRptCREATIVOS
        '
        'DRptCREATIVOS
        '
        Me.DRptCREATIVOS.DataSetName = "dRptCREATIVOS"
        Me.DRptCREATIVOS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TicketDataGridViewTextBoxColumn
        '
        Me.TicketDataGridViewTextBoxColumn.DataPropertyName = "Ticket"
        Me.TicketDataGridViewTextBoxColumn.HeaderText = "Ticket"
        Me.TicketDataGridViewTextBoxColumn.Name = "TicketDataGridViewTextBoxColumn"
        Me.TicketDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MesDataGridViewTextBoxColumn
        '
        Me.MesDataGridViewTextBoxColumn.DataPropertyName = "Mes"
        Me.MesDataGridViewTextBoxColumn.HeaderText = "Mes"
        Me.MesDataGridViewTextBoxColumn.Name = "MesDataGridViewTextBoxColumn"
        Me.MesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HoraDataGridViewTextBoxColumn
        '
        Me.HoraDataGridViewTextBoxColumn.DataPropertyName = "Hora"
        Me.HoraDataGridViewTextBoxColumn.HeaderText = "Hora"
        Me.HoraDataGridViewTextBoxColumn.Name = "HoraDataGridViewTextBoxColumn"
        Me.HoraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.EmpleadosBindingSource1
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(26, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(143, 21)
        Me.ComboBox1.TabIndex = 17
        Me.ComboBox1.ValueMember = "Nombre"
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.DRptCREATIVOS
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'F_BuscarTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 312)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTicket)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "F_BuscarTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BUSCAR TICKET"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DRptCREATIVOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTicket As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TicketsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TicketsTableAdapter As CREATIVOS.dRptCREATIVOSTableAdapters.TicketsTableAdapter
    Friend WithEvents TicketsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TicketDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HoraDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DRptCREATIVOS As CREATIVOS.dRptCREATIVOS
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As CREATIVOS.dRptCREATIVOSTableAdapters.EmpleadosTableAdapter
End Class
