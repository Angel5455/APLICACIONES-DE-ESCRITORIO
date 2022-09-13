<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_BD
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OFICIALIADataSet = New Oficialia.OFICIALIADataSet()
        Me.SolicitudesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SolicitudesTableAdapter = New Oficialia.OFICIALIADataSetTableAdapters.SolicitudesTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpedienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TGRDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SolicitanteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonaInscritaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaResolucionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEnvioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRemisionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OFICIALIADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolicitudesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdentidadDataGridViewTextBoxColumn, Me.ExpedienteDataGridViewTextBoxColumn, Me.TGRDataGridViewTextBoxColumn, Me.SolicitanteDataGridViewTextBoxColumn, Me.PersonaInscritaDataGridViewTextBoxColumn, Me.TipoSolicitudDataGridViewTextBoxColumn, Me.FechaSolicitudDataGridViewTextBoxColumn, Me.FechaResolucionDataGridViewTextBoxColumn, Me.FechaEnvioDataGridViewTextBoxColumn, Me.FechaRemisionDataGridViewTextBoxColumn, Me.AutoDataGridViewTextBoxColumn, Me.CajaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SolicitudesBindingSource
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(14, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(722, 449)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(599, 479)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 39)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OFICIALIADataSet
        '
        Me.OFICIALIADataSet.DataSetName = "OFICIALIADataSet"
        Me.OFICIALIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SolicitudesBindingSource
        '
        Me.SolicitudesBindingSource.DataMember = "Solicitudes"
        Me.SolicitudesBindingSource.DataSource = Me.OFICIALIADataSet
        '
        'SolicitudesTableAdapter
        '
        Me.SolicitudesTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'IdentidadDataGridViewTextBoxColumn
        '
        Me.IdentidadDataGridViewTextBoxColumn.DataPropertyName = "Identidad"
        Me.IdentidadDataGridViewTextBoxColumn.HeaderText = "Identidad"
        Me.IdentidadDataGridViewTextBoxColumn.Name = "IdentidadDataGridViewTextBoxColumn"
        '
        'ExpedienteDataGridViewTextBoxColumn
        '
        Me.ExpedienteDataGridViewTextBoxColumn.DataPropertyName = "Expediente"
        Me.ExpedienteDataGridViewTextBoxColumn.HeaderText = "Expediente"
        Me.ExpedienteDataGridViewTextBoxColumn.Name = "ExpedienteDataGridViewTextBoxColumn"
        '
        'TGRDataGridViewTextBoxColumn
        '
        Me.TGRDataGridViewTextBoxColumn.DataPropertyName = "TGR"
        Me.TGRDataGridViewTextBoxColumn.HeaderText = "TGR"
        Me.TGRDataGridViewTextBoxColumn.Name = "TGRDataGridViewTextBoxColumn"
        '
        'SolicitanteDataGridViewTextBoxColumn
        '
        Me.SolicitanteDataGridViewTextBoxColumn.DataPropertyName = "Solicitante"
        Me.SolicitanteDataGridViewTextBoxColumn.HeaderText = "Solicitante"
        Me.SolicitanteDataGridViewTextBoxColumn.Name = "SolicitanteDataGridViewTextBoxColumn"
        '
        'PersonaInscritaDataGridViewTextBoxColumn
        '
        Me.PersonaInscritaDataGridViewTextBoxColumn.DataPropertyName = "Persona_Inscrita"
        Me.PersonaInscritaDataGridViewTextBoxColumn.HeaderText = "Persona_Inscrita"
        Me.PersonaInscritaDataGridViewTextBoxColumn.Name = "PersonaInscritaDataGridViewTextBoxColumn"
        '
        'TipoSolicitudDataGridViewTextBoxColumn
        '
        Me.TipoSolicitudDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Solicitud"
        Me.TipoSolicitudDataGridViewTextBoxColumn.HeaderText = "Tipo_Solicitud"
        Me.TipoSolicitudDataGridViewTextBoxColumn.Name = "TipoSolicitudDataGridViewTextBoxColumn"
        '
        'FechaSolicitudDataGridViewTextBoxColumn
        '
        Me.FechaSolicitudDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Solicitud"
        Me.FechaSolicitudDataGridViewTextBoxColumn.HeaderText = "Fecha_Solicitud"
        Me.FechaSolicitudDataGridViewTextBoxColumn.Name = "FechaSolicitudDataGridViewTextBoxColumn"
        '
        'FechaResolucionDataGridViewTextBoxColumn
        '
        Me.FechaResolucionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Resolucion"
        Me.FechaResolucionDataGridViewTextBoxColumn.HeaderText = "Fecha_Resolucion"
        Me.FechaResolucionDataGridViewTextBoxColumn.Name = "FechaResolucionDataGridViewTextBoxColumn"
        '
        'FechaEnvioDataGridViewTextBoxColumn
        '
        Me.FechaEnvioDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Envio"
        Me.FechaEnvioDataGridViewTextBoxColumn.HeaderText = "Fecha_Envio"
        Me.FechaEnvioDataGridViewTextBoxColumn.Name = "FechaEnvioDataGridViewTextBoxColumn"
        '
        'FechaRemisionDataGridViewTextBoxColumn
        '
        Me.FechaRemisionDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Remision"
        Me.FechaRemisionDataGridViewTextBoxColumn.HeaderText = "Fecha_Remision"
        Me.FechaRemisionDataGridViewTextBoxColumn.Name = "FechaRemisionDataGridViewTextBoxColumn"
        '
        'AutoDataGridViewTextBoxColumn
        '
        Me.AutoDataGridViewTextBoxColumn.DataPropertyName = "Auto"
        Me.AutoDataGridViewTextBoxColumn.HeaderText = "Auto"
        Me.AutoDataGridViewTextBoxColumn.Name = "AutoDataGridViewTextBoxColumn"
        '
        'CajaDataGridViewTextBoxColumn
        '
        Me.CajaDataGridViewTextBoxColumn.DataPropertyName = "Caja"
        Me.CajaDataGridViewTextBoxColumn.HeaderText = "Caja"
        Me.CajaDataGridViewTextBoxColumn.Name = "CajaDataGridViewTextBoxColumn"
        '
        'F_BD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(763, 544)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_BD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_BD"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OFICIALIADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolicitudesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OFICIALIADataSet As Oficialia.OFICIALIADataSet
    Friend WithEvents SolicitudesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SolicitudesTableAdapter As Oficialia.OFICIALIADataSetTableAdapters.SolicitudesTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdentidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpedienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TGRDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SolicitanteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PersonaInscritaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoSolicitudDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaSolicitudDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaResolucionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaEnvioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaRemisionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AutoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
