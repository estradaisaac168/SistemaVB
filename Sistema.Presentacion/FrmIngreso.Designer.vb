<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngreso
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
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ChkSeleccionar = New System.Windows.Forms.CheckBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.LblTotal = New System.Windows.Forms.Label()
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
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.TabArticulo = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PanelArticulo = New System.Windows.Forms.Panel()
        Me.LblTotalArticulos = New System.Windows.Forms.Label()
        Me.DgvArticulos = New System.Windows.Forms.DataGridView()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnBuscarArticuloDetalle = New System.Windows.Forms.Button()
        Me.TxtBuscarArticulo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnBuscarArticulo = New System.Windows.Forms.Button()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTotalInpuesto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvDetalle = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtInpuesto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumeroComprobante = New System.Windows.Forms.TextBox()
        Me.TxtSerieDocumento = New System.Windows.Forms.TextBox()
        Me.CboTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.BtnBuscarProveedor = New System.Windows.Forms.Button()
        Me.TxtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.TxtIdProveedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabPage1.SuspendLayout()
        Me.PanelMostrarDetalle.SuspendLayout()
        CType(Me.DgvMostrarDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabArticulo.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanelArticulo.SuspendLayout()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Comprobante (*)"
        '
        'ChkSeleccionar
        '
        Me.ChkSeleccionar.AutoSize = True
        Me.ChkSeleccionar.Location = New System.Drawing.Point(7, 537)
        Me.ChkSeleccionar.Name = "ChkSeleccionar"
        Me.ChkSeleccionar.Size = New System.Drawing.Size(82, 17)
        Me.ChkSeleccionar.TabIndex = 4
        Me.ChkSeleccionar.Text = "Seleccionar"
        Me.ChkSeleccionar.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(796, 31)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(122, 23)
        Me.BtnBuscar.TabIndex = 3
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(286, 31)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(471, 20)
        Me.TxtValor.TabIndex = 2
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(765, 541)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(37, 13)
        Me.LblTotal.TabIndex = 1
        Me.LblTotal.Text = "Total: "
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PanelMostrarDetalle)
        Me.TabPage1.Controls.Add(Me.BtnAnular)
        Me.TabPage1.Controls.Add(Me.ChkSeleccionar)
        Me.TabPage1.Controls.Add(Me.BtnBuscar)
        Me.TabPage1.Controls.Add(Me.TxtValor)
        Me.TabPage1.Controls.Add(Me.LblTotal)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(931, 666)
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
        Me.PanelMostrarDetalle.Size = New System.Drawing.Size(784, 397)
        Me.PanelMostrarDetalle.TabIndex = 7
        Me.PanelMostrarDetalle.Visible = False
        '
        'BtnCerrarDetalle
        '
        Me.BtnCerrarDetalle.BackColor = System.Drawing.Color.Transparent
        Me.BtnCerrarDetalle.Location = New System.Drawing.Point(699, 23)
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
        Me.LblTotalDetalle.Location = New System.Drawing.Point(741, 351)
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
        Me.LblTotalImpuesto.Location = New System.Drawing.Point(741, 315)
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
        Me.LblSubTotal.Location = New System.Drawing.Point(741, 278)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(17, 17)
        Me.LblSubTotal.TabIndex = 4
        Me.LblSubTotal.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(631, 355)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(631, 319)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Total Impuesto"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(631, 282)
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
        Me.DgvMostrarDetalle.Size = New System.Drawing.Size(746, 191)
        Me.DgvMostrarDetalle.TabIndex = 0
        '
        'BtnAnular
        '
        Me.BtnAnular.Location = New System.Drawing.Point(171, 533)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(75, 23)
        Me.BtnAnular.TabIndex = 6
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'DgvListado
        '
        Me.DgvListado.AllowUserToAddRows = False
        Me.DgvListado.AllowUserToDeleteRows = False
        Me.DgvListado.AllowUserToOrderColumns = True
        Me.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.DgvListado.Location = New System.Drawing.Point(7, 80)
        Me.DgvListado.Name = "DgvListado"
        Me.DgvListado.ReadOnly = True
        Me.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListado.Size = New System.Drawing.Size(911, 418)
        Me.DgvListado.TabIndex = 0
        '
        'TabArticulo
        '
        Me.TabArticulo.Controls.Add(Me.TabPage1)
        Me.TabArticulo.Controls.Add(Me.TabPage2)
        Me.TabArticulo.Location = New System.Drawing.Point(12, 12)
        Me.TabArticulo.Name = "TabArticulo"
        Me.TabArticulo.SelectedIndex = 0
        Me.TabArticulo.Size = New System.Drawing.Size(939, 692)
        Me.TabArticulo.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.TxtID)
        Me.TabPage2.Controls.Add(Me.BtnCancelar)
        Me.TabPage2.Controls.Add(Me.BtnGuardar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(931, 666)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PanelArticulo)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.BtnBuscarArticulo)
        Me.GroupBox2.Controls.Add(Me.TxtCodigo)
        Me.GroupBox2.Controls.Add(Me.TxtTotal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtTotalInpuesto)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DgvDetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(902, 421)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'PanelArticulo
        '
        Me.PanelArticulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelArticulo.Controls.Add(Me.LblTotalArticulos)
        Me.PanelArticulo.Controls.Add(Me.DgvArticulos)
        Me.PanelArticulo.Controls.Add(Me.BtnCerrar)
        Me.PanelArticulo.Controls.Add(Me.BtnBuscarArticuloDetalle)
        Me.PanelArticulo.Controls.Add(Me.TxtBuscarArticulo)
        Me.PanelArticulo.Location = New System.Drawing.Point(57, 78)
        Me.PanelArticulo.Name = "PanelArticulo"
        Me.PanelArticulo.Size = New System.Drawing.Size(817, 337)
        Me.PanelArticulo.TabIndex = 11
        Me.PanelArticulo.Visible = False
        '
        'LblTotalArticulos
        '
        Me.LblTotalArticulos.AutoSize = True
        Me.LblTotalArticulos.Location = New System.Drawing.Point(649, 301)
        Me.LblTotalArticulos.Name = "LblTotalArticulos"
        Me.LblTotalArticulos.Size = New System.Drawing.Size(31, 13)
        Me.LblTotalArticulos.TabIndex = 12
        Me.LblTotalArticulos.Text = "Total"
        '
        'DgvArticulos
        '
        Me.DgvArticulos.AllowUserToAddRows = False
        Me.DgvArticulos.AllowUserToDeleteRows = False
        Me.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArticulos.Location = New System.Drawing.Point(13, 58)
        Me.DgvArticulos.Name = "DgvArticulos"
        Me.DgvArticulos.ReadOnly = True
        Me.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvArticulos.Size = New System.Drawing.Size(788, 222)
        Me.DgvArticulos.TabIndex = 14
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(726, 21)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 13
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnBuscarArticuloDetalle
        '
        Me.BtnBuscarArticuloDetalle.Location = New System.Drawing.Point(580, 21)
        Me.BtnBuscarArticuloDetalle.Name = "BtnBuscarArticuloDetalle"
        Me.BtnBuscarArticuloDetalle.Size = New System.Drawing.Size(111, 23)
        Me.BtnBuscarArticuloDetalle.TabIndex = 12
        Me.BtnBuscarArticuloDetalle.Text = "Buscar Articulo"
        Me.BtnBuscarArticuloDetalle.UseVisualStyleBackColor = True
        '
        'TxtBuscarArticulo
        '
        Me.TxtBuscarArticulo.Location = New System.Drawing.Point(13, 23)
        Me.TxtBuscarArticulo.Name = "TxtBuscarArticulo"
        Me.TxtBuscarArticulo.Size = New System.Drawing.Size(517, 20)
        Me.TxtBuscarArticulo.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(324, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(367, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Escriba el codigo de barra en campo luego presione enter o presione Buscar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(324, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Codigo Articulo"
        '
        'BtnBuscarArticulo
        '
        Me.BtnBuscarArticulo.Location = New System.Drawing.Point(799, 40)
        Me.BtnBuscarArticulo.Name = "BtnBuscarArticulo"
        Me.BtnBuscarArticulo.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarArticulo.TabIndex = 8
        Me.BtnBuscarArticulo.Text = "Buscar"
        Me.BtnBuscarArticulo.UseVisualStyleBackColor = True
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(423, 43)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(361, 20)
        Me.TxtCodigo.TabIndex = 7
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(762, 379)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(112, 20)
        Me.TxtTotal.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(675, 382)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total"
        '
        'TxtTotalInpuesto
        '
        Me.TxtTotalInpuesto.Location = New System.Drawing.Point(762, 342)
        Me.TxtTotalInpuesto.Name = "TxtTotalInpuesto"
        Me.TxtTotalInpuesto.ReadOnly = True
        Me.TxtTotalInpuesto.Size = New System.Drawing.Size(112, 20)
        Me.TxtTotalInpuesto.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(673, 345)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total Inpuesto"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Location = New System.Drawing.Point(762, 301)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.ReadOnly = True
        Me.TxtSubTotal.Size = New System.Drawing.Size(112, 20)
        Me.TxtSubTotal.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(675, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SubTotal"
        '
        'DgvDetalle
        '
        Me.DgvDetalle.AllowUserToAddRows = False
        Me.DgvDetalle.AllowUserToOrderColumns = True
        Me.DgvDetalle.BackgroundColor = System.Drawing.Color.White
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Location = New System.Drawing.Point(21, 78)
        Me.DgvDetalle.Name = "DgvDetalle"
        Me.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalle.Size = New System.Drawing.Size(853, 205)
        Me.DgvDetalle.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtInpuesto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNumeroComprobante)
        Me.GroupBox1.Controls.Add(Me.TxtSerieDocumento)
        Me.GroupBox1.Controls.Add(Me.CboTipoComprobante)
        Me.GroupBox1.Controls.Add(Me.BtnBuscarProveedor)
        Me.GroupBox1.Controls.Add(Me.TxtNombreProveedor)
        Me.GroupBox1.Controls.Add(Me.TxtIdProveedor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(902, 135)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cabecera"
        '
        'TxtInpuesto
        '
        Me.TxtInpuesto.Location = New System.Drawing.Point(786, 76)
        Me.TxtInpuesto.Name = "TxtInpuesto"
        Me.TxtInpuesto.ReadOnly = True
        Me.TxtInpuesto.Size = New System.Drawing.Size(88, 20)
        Me.TxtInpuesto.TabIndex = 23
        Me.TxtInpuesto.Text = "0.10"
        Me.TxtInpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(717, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Inpuesto"
        '
        'TxtNumeroComprobante
        '
        Me.TxtNumeroComprobante.Location = New System.Drawing.Point(448, 79)
        Me.TxtNumeroComprobante.Name = "TxtNumeroComprobante"
        Me.TxtNumeroComprobante.Size = New System.Drawing.Size(207, 20)
        Me.TxtNumeroComprobante.TabIndex = 21
        '
        'TxtSerieDocumento
        '
        Me.TxtSerieDocumento.Location = New System.Drawing.Point(280, 79)
        Me.TxtSerieDocumento.Name = "TxtSerieDocumento"
        Me.TxtSerieDocumento.Size = New System.Drawing.Size(151, 20)
        Me.TxtSerieDocumento.TabIndex = 20
        '
        'CboTipoComprobante
        '
        Me.CboTipoComprobante.FormattingEnabled = True
        Me.CboTipoComprobante.Items.AddRange(New Object() {"Factura", "Boleta", "Ticket"})
        Me.CboTipoComprobante.Location = New System.Drawing.Point(104, 79)
        Me.CboTipoComprobante.Name = "CboTipoComprobante"
        Me.CboTipoComprobante.Size = New System.Drawing.Size(159, 21)
        Me.CboTipoComprobante.TabIndex = 19
        Me.CboTipoComprobante.Text = "Factura"
        '
        'BtnBuscarProveedor
        '
        Me.BtnBuscarProveedor.Location = New System.Drawing.Point(513, 27)
        Me.BtnBuscarProveedor.Name = "BtnBuscarProveedor"
        Me.BtnBuscarProveedor.Size = New System.Drawing.Size(142, 23)
        Me.BtnBuscarProveedor.TabIndex = 18
        Me.BtnBuscarProveedor.Text = "Proveedor"
        Me.BtnBuscarProveedor.UseVisualStyleBackColor = False
        '
        'TxtNombreProveedor
        '
        Me.TxtNombreProveedor.Location = New System.Drawing.Point(209, 29)
        Me.TxtNombreProveedor.Name = "TxtNombreProveedor"
        Me.TxtNombreProveedor.ReadOnly = True
        Me.TxtNombreProveedor.Size = New System.Drawing.Size(284, 20)
        Me.TxtNombreProveedor.TabIndex = 17
        '
        'TxtIdProveedor
        '
        Me.TxtIdProveedor.Location = New System.Drawing.Point(104, 29)
        Me.TxtIdProveedor.Name = "TxtIdProveedor"
        Me.TxtIdProveedor.ReadOnly = True
        Me.TxtIdProveedor.Size = New System.Drawing.Size(87, 20)
        Me.TxtIdProveedor.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Proveedor (*)"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(780, 6)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(100, 20)
        Me.TxtID.TabIndex = 6
        Me.TxtID.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(176, 624)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(142, 23)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(6, 624)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(142, 23)
        Me.BtnGuardar.TabIndex = 4
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'FrmIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(962, 716)
        Me.Controls.Add(Me.TabArticulo)
        Me.Name = "FrmIngreso"
        Me.Text = "Ingresos"
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.PanelMostrarDetalle.ResumeLayout(False)
        Me.PanelMostrarDetalle.PerformLayout()
        CType(Me.DgvMostrarDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabArticulo.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelArticulo.ResumeLayout(False)
        Me.PanelArticulo.PerformLayout()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents ChkSeleccionar As CheckBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents LblTotal As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnAnular As Button
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents TabArticulo As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtNombreProveedor As TextBox
    Friend WithEvents TxtIdProveedor As TextBox
    Friend WithEvents BtnBuscarProveedor As Button
    Friend WithEvents CboTipoComprobante As ComboBox
    Friend WithEvents TxtInpuesto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNumeroComprobante As TextBox
    Friend WithEvents TxtSerieDocumento As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTotalInpuesto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DgvDetalle As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnBuscarArticulo As Button
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PanelArticulo As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnBuscarArticuloDetalle As Button
    Friend WithEvents TxtBuscarArticulo As TextBox
    Friend WithEvents DgvArticulos As DataGridView
    Friend WithEvents LblTotalArticulos As Label
    Friend WithEvents PanelMostrarDetalle As Panel
    Friend WithEvents LblTotalDetalle As Label
    Friend WithEvents LblTotalImpuesto As Label
    Friend WithEvents LblSubTotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DgvMostrarDetalle As DataGridView
    Friend WithEvents BtnCerrarDetalle As Button
End Class
