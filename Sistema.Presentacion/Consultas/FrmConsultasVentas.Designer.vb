<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultasVentas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PanelMostrarDetalle = New System.Windows.Forms.Panel()
        Me.BtnCerrarDetalle = New System.Windows.Forms.Button()
        Me.LblTotalDetalle = New System.Windows.Forms.Label()
        Me.LblTotalImpuesto = New System.Windows.Forms.Label()
        Me.LblSubTotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DgvMostrarDetalle = New System.Windows.Forms.DataGridView()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TabArticulo = New System.Windows.Forms.TabControl()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.TabPage1.SuspendLayout()
        Me.PanelMostrarDetalle.SuspendLayout()
        CType(Me.DgvMostrarDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabArticulo.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DtpFechaFin)
        Me.TabPage1.Controls.Add(Me.DtpFechaInicio)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.PanelMostrarDetalle)
        Me.TabPage1.Controls.Add(Me.BtnFiltrar)
        Me.TabPage1.Controls.Add(Me.LblTotal)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1035, 592)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PanelMostrarDetalle
        '
        Me.PanelMostrarDetalle.BackColor = System.Drawing.Color.DimGray
        Me.PanelMostrarDetalle.Controls.Add(Me.BtnCerrarDetalle)
        Me.PanelMostrarDetalle.Controls.Add(Me.LblTotalDetalle)
        Me.PanelMostrarDetalle.Controls.Add(Me.LblTotalImpuesto)
        Me.PanelMostrarDetalle.Controls.Add(Me.LblSubTotal)
        Me.PanelMostrarDetalle.Controls.Add(Me.Label11)
        Me.PanelMostrarDetalle.Controls.Add(Me.Label10)
        Me.PanelMostrarDetalle.Controls.Add(Me.Label9)
        Me.PanelMostrarDetalle.Controls.Add(Me.DgvMostrarDetalle)
        Me.PanelMostrarDetalle.Location = New System.Drawing.Point(70, 90)
        Me.PanelMostrarDetalle.Name = "PanelMostrarDetalle"
        Me.PanelMostrarDetalle.Size = New System.Drawing.Size(940, 397)
        Me.PanelMostrarDetalle.TabIndex = 7
        Me.PanelMostrarDetalle.Visible = False
        '
        'BtnCerrarDetalle
        '
        Me.BtnCerrarDetalle.BackColor = System.Drawing.Color.Transparent
        Me.BtnCerrarDetalle.Location = New System.Drawing.Point(837, 25)
        Me.BtnCerrarDetalle.Name = "BtnCerrarDetalle"
        Me.BtnCerrarDetalle.Size = New System.Drawing.Size(67, 23)
        Me.BtnCerrarDetalle.TabIndex = 7
        Me.BtnCerrarDetalle.Text = "Cerrar"
        Me.BtnCerrarDetalle.UseVisualStyleBackColor = False
        '
        'LblTotalDetalle
        '
        Me.LblTotalDetalle.AutoSize = True
        Me.LblTotalDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalDetalle.ForeColor = System.Drawing.Color.White
        Me.LblTotalDetalle.Location = New System.Drawing.Point(887, 357)
        Me.LblTotalDetalle.Name = "LblTotalDetalle"
        Me.LblTotalDetalle.Size = New System.Drawing.Size(17, 17)
        Me.LblTotalDetalle.TabIndex = 6
        Me.LblTotalDetalle.Text = "0"
        '
        'LblTotalImpuesto
        '
        Me.LblTotalImpuesto.AutoSize = True
        Me.LblTotalImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalImpuesto.ForeColor = System.Drawing.Color.White
        Me.LblTotalImpuesto.Location = New System.Drawing.Point(887, 321)
        Me.LblTotalImpuesto.Name = "LblTotalImpuesto"
        Me.LblTotalImpuesto.Size = New System.Drawing.Size(17, 17)
        Me.LblTotalImpuesto.TabIndex = 5
        Me.LblTotalImpuesto.Text = "0"
        '
        'LblSubTotal
        '
        Me.LblSubTotal.AutoSize = True
        Me.LblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTotal.ForeColor = System.Drawing.Color.White
        Me.LblSubTotal.Location = New System.Drawing.Point(887, 284)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(17, 17)
        Me.LblSubTotal.TabIndex = 4
        Me.LblSubTotal.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(777, 361)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(777, 325)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Total Impuesto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(777, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Sub Total"
        '
        'DgvMostrarDetalle
        '
        Me.DgvMostrarDetalle.AllowUserToAddRows = False
        Me.DgvMostrarDetalle.AllowUserToDeleteRows = False
        Me.DgvMostrarDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMostrarDetalle.Location = New System.Drawing.Point(20, 68)
        Me.DgvMostrarDetalle.Name = "DgvMostrarDetalle"
        Me.DgvMostrarDetalle.ReadOnly = True
        Me.DgvMostrarDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMostrarDetalle.Size = New System.Drawing.Size(917, 191)
        Me.DgvMostrarDetalle.TabIndex = 0
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Location = New System.Drawing.Point(902, 36)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(122, 23)
        Me.BtnFiltrar.TabIndex = 3
        Me.BtnFiltrar.Text = "Filtrar"
        Me.BtnFiltrar.UseVisualStyleBackColor = True
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(847, 538)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(37, 13)
        Me.LblTotal.TabIndex = 1
        Me.LblTotal.Text = "Total: "
        '
        'DgvListado
        '
        Me.DgvListado.AllowUserToAddRows = False
        Me.DgvListado.AllowUserToDeleteRows = False
        Me.DgvListado.AllowUserToOrderColumns = True
        Me.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.DgvListado.Location = New System.Drawing.Point(7, 73)
        Me.DgvListado.Name = "DgvListado"
        Me.DgvListado.ReadOnly = True
        Me.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListado.Size = New System.Drawing.Size(1017, 418)
        Me.DgvListado.TabIndex = 0
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        '
        'TabArticulo
        '
        Me.TabArticulo.Controls.Add(Me.TabPage1)
        Me.TabArticulo.Location = New System.Drawing.Point(12, 12)
        Me.TabArticulo.Name = "TabArticulo"
        Me.TabArticulo.SelectedIndex = 0
        Me.TabArticulo.Size = New System.Drawing.Size(1043, 618)
        Me.TabArticulo.TabIndex = 4
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(355, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Hasta:"
        '
        'DtpFechaInicio
        '
        Me.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaInicio.Location = New System.Drawing.Point(76, 34)
        Me.DtpFechaInicio.Name = "DtpFechaInicio"
        Me.DtpFechaInicio.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaInicio.TabIndex = 10
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaFin.Location = New System.Drawing.Point(412, 34)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Size = New System.Drawing.Size(200, 20)
        Me.DtpFechaFin.TabIndex = 11
        '
        'FrmConsultasVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1062, 653)
        Me.Controls.Add(Me.TabArticulo)
        Me.Name = "FrmConsultasVentas"
        Me.Text = "Consultas de ventas entre fechas"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.PanelMostrarDetalle.ResumeLayout(False)
        Me.PanelMostrarDetalle.PerformLayout()
        CType(Me.DgvMostrarDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabArticulo.ResumeLayout(False)
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DtpFechaFin As DateTimePicker
    Friend WithEvents DtpFechaInicio As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelMostrarDetalle As Panel
    Friend WithEvents BtnCerrarDetalle As Button
    Friend WithEvents LblTotalDetalle As Label
    Friend WithEvents LblTotalImpuesto As Label
    Friend WithEvents LblSubTotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DgvMostrarDetalle As DataGridView
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents LblTotal As Label
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents TabArticulo As TabControl
    Friend WithEvents ErrorIcono As ErrorProvider
End Class
