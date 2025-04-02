Imports Sistema.Exceptions
Imports Sistema.Negocio

Public Class FrmVentas


    Private DtDetalle As New DataTable

    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 60
        DgvListado.Columns(3).Width = 150
        DgvListado.Columns(4).Width = 150
        DgvListado.Columns(5).Width = 100
        DgvListado.Columns(6).Width = 70
        DgvListado.Columns(7).Width = 70
        DgvListado.Columns(8).Width = 60
        DgvListado.Columns(9).Width = 100
        DgvListado.Columns(10).Width = 100
        DgvListado.Columns(11).Width = 100

        Me.OcultarComponentes()
        ChkSeleccionar.CheckState = False
    End Sub





    Private Sub OcultarComponentes()
        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnAnular.Visible = False
    End Sub





    Private Sub MostrarComponentes()
        DgvListado.Columns.Item("Seleccionar").Visible = True
        BtnAnular.Visible = True
    End Sub






    Private Sub Listar()
        Try
            Dim Neg As New Negocio.VentaBLL
            DgvListado.DataSource = Neg.Listar()
            LblTotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
            Me.Limpiar()
        Catch ex As BusinessLogicException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.VentaBLL
            Dim Valor As String
            Valor = TxtValor.Text
            DgvListado.DataSource = Neg.Buscar(Valor)
            LblTotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
        Catch ex As BusinessLogicException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub Limpiar()
        BtnGuardar.Visible = True
        'BtnActualizar.Visible = False
        TxtValor.Text = ""
        TxtID.Text = ""
        TxtCodigo.Text = ""
        TxtIdCliente.Text = ""
        TxtNombreCliente.Text = ""
        TxtSerieDocumento.Text = ""
        TxtNumeroComprobante.Text = ""
        DtDetalle.Clear()
        TxtSubTotal.Text = 0
        TxtTotalInpuesto.Text = 0
        TxtTotal.Text = 0
    End Sub


    Private Sub CrearTablaDetalle()
        Me.DtDetalle = New DataTable("Detalle")
        'Espera dos detalles , el idingreso y tipo de dato que le estoy pasando
        Me.DtDetalle.Columns.Add("idarticulo", Type.GetType("System.Int32"))
        Me.DtDetalle.Columns.Add("codigo", Type.GetType("System.String"))
        Me.DtDetalle.Columns.Add("articulo", Type.GetType("System.String"))
        Me.DtDetalle.Columns.Add("stock", Type.GetType("System.Int32"))
        Me.DtDetalle.Columns.Add("cantidad", Type.GetType("System.Int32"))
        Me.DtDetalle.Columns.Add("precio", Type.GetType("System.Decimal"))
        Me.DtDetalle.Columns.Add("descuento", Type.GetType("System.Decimal"))
        Me.DtDetalle.Columns.Add("importe", Type.GetType("System.Decimal"))

        DgvDetalle.DataSource = Me.DtDetalle
        DgvDetalle.Columns(0).Visible = False
        DgvDetalle.Columns(1).HeaderText = "CODIGO"
        DgvDetalle.Columns(1).Width = 100
        DgvDetalle.Columns(2).HeaderText = "ARTICULO"
        DgvDetalle.Columns(2).Width = 200
        DgvDetalle.Columns(3).HeaderText = "STOCK"
        DgvDetalle.Columns(3).Width = 200
        DgvDetalle.Columns(4).HeaderText = "CANTIDAD"
        DgvDetalle.Columns(4).Width = 100
        DgvDetalle.Columns(5).HeaderText = "PRECIO"
        DgvDetalle.Columns(5).Width = 100
        DgvDetalle.Columns(6).HeaderText = "DESCUENTO"
        DgvDetalle.Columns(6).Width = 100
        DgvDetalle.Columns(7).HeaderText = "IMPORTE"
        DgvDetalle.Columns(7).Width = 100

        'Establecer de solo lectura ciertas columnas
        DgvDetalle.Columns(1).ReadOnly = True
        DgvDetalle.Columns(2).ReadOnly = True
        DgvDetalle.Columns(3).ReadOnly = True
        DgvDetalle.Columns(7).ReadOnly = True

    End Sub


    Private Sub FormatoArticulo()
        DgvArticulos.Columns(0).Visible = False
        DgvArticulos.Columns(1).Visible = False
        DgvArticulos.Columns(2).Width = 100
        DgvArticulos.Columns(3).Width = 100
        DgvArticulos.Columns(4).Width = 150
        DgvArticulos.Columns(5).Width = 100
        DgvArticulos.Columns(6).Width = 100
        DgvArticulos.Columns(7).Width = 200
        DgvArticulos.Columns(8).Width = 100
        DgvArticulos.Columns(9).Width = 100
    End Sub


    'Este metodo se encarga de agregar un detalle al datagridview detalle
    Private Sub AgregarDetalle(Fila As Entidades.Articulo)

        Dim Agregar As Boolean = True

        'Recorrer el datagridview detalle para verificar si el articulo ya se encuentra en el detalle
        For Each FilaTemp As DataGridViewRow In DgvDetalle.Rows
            If (Convert.ToInt32(FilaTemp.Cells("idarticulo").Value) = Convert.ToInt32(Fila.IdArticulo)) Then
                Agregar = False
                MsgBox("El articulo ya se encuentra en el detalle", vbOKOnly + vbCritical, "Error al agregar articulo")
            End If

        Next


        If (Agregar) Then
            Dim Row As DataRow
            Row = Me.DtDetalle.NewRow() 'Con esta instruccion creo una nueva fila para agregarlo al detalle
            Row("idarticulo") = Convert.ToString(Fila.IdArticulo)
            Row("codigo") = Convert.ToString(Fila.Codigo)
            Row("articulo") = Convert.ToString(Fila.Nombre)
            Row("stock") = Convert.ToString(Fila.Stock)
            Row("cantidad") = Convert.ToString(1)
            Row("precio") = Convert.ToString(Fila.PrecioVenta)
            Row("descuento") = Convert.ToString(0)
            Row("importe") = Convert.ToString(Fila.PrecioVenta)

            'agregar el objeto fila al DataTable DtDetalle
            Me.DtDetalle.Rows.Add(Row)
            Me.CalcularTotal()
        End If

    End Sub



    Private Sub CalcularTotal()

        Dim Total As Decimal = 0
        Dim SubTotal As Decimal = 0
        Dim TotalImpuesto As Decimal = 0

        For Each FilaTemp As DataGridViewRow In DgvDetalle.Rows
            Total += CDec(FilaTemp.Cells("importe").Value)
        Next

        SubTotal = Math.Round((Total / (1 + CDec(TxtInpuesto.Text))), 2)

        TxtSubTotal.Text = SubTotal

        TxtTotal.Text = Total

        TxtTotalInpuesto.Text = CStr(Total - SubTotal)

    End Sub


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub


    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        'Abre el formulario de buscar clientes 
        FrmClientesVentas.ShowDialog()
        TxtIdCliente.Text = Variables.IdCliente
        TxtNombreCliente.Text = Variables.NombreCliente
    End Sub



    Private Sub TxtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCodigo.KeyDown
        'Evaluar si se presiono la tecla enter
        If e.KeyCode = Keys.Enter Then
            Try
                Dim Neg As New Negocio.ArticuloBLL
                Dim Obj As New Entidades.Articulo

                'A mi variable de tipo articulo le asigno lo que me devuelva el metodo buscarCodigo
                Obj = Neg.BuscarCodigoVenta(TxtCodigo.Text)

                If Obj Is Nothing Then
                    MsgBox("No existe artiulo con ese codigo de barras", vbOKOnly + vbCritical, "No existe articulo")
                Else
                    AgregarDetalle(Obj)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub



    'Mostrar el panel de articulos
    Private Sub BtnBuscarArticulo_Click(sender As Object, e As EventArgs) Handles BtnBuscarArticulo.Click
        PanelArticulo.Visible = True
    End Sub


    'Ocultar el panel de articulos
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        PanelArticulo.Visible = False

    End Sub


    'Busca un articulo con su detalle
    Private Sub BtnBuscarArticuloDetalle_Click(sender As Object, e As EventArgs) Handles BtnBuscarArticuloDetalle.Click
        Try
            Dim Neg As New Negocio.ArticuloBLL
            Dim Valor As String
            Valor = TxtBuscarArticulo.Text

            'Llamo al metodo buscar de la capa de negocio
            DgvArticulos.DataSource = Neg.BuscarVenta(Valor)
            LblTotalArticulos.Text = $"Total de articulo: {DgvArticulos.DataSource.Rows.Count}"
            Me.FormatoArticulo()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvArticulos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvArticulos.CellDoubleClick
        Try
            Dim Obj As New Entidades.Articulo
            'Seleccion del Id en la columna 0
            'Seleccion del Codigo en la columan 3
            'Seleccion del Nombre en la columna 4
            Obj.IdArticulo = DgvArticulos.SelectedCells.Item(0).Value
            Obj.Codigo = DgvArticulos.SelectedCells.Item(3).Value
            Obj.Nombre = DgvArticulos.SelectedCells.Item(4).Value
            Obj.PrecioVenta = DgvArticulos.SelectedCells.Item(5).Value
            Obj.Stock = DgvArticulos.SelectedCells.Item(6).Value

            'Mando como parametro al metodo AgregarDetlle mi objeto articulo
            Me.AgregarDetalle(Obj)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Cuando finalizo de editar una celda del DataGridViiew
    Private Sub DgvDetalle_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetalle.CellEndEdit
        Dim Fila As DataGridViewRow = CType(DgvDetalle.Rows(e.RowIndex), DataGridViewRow)
        Dim Precio As Decimal = Fila.Cells("precio").Value
        Dim Cantidad As Integer = Fila.Cells("cantidad").Value
        Dim Descuento As Decimal = Fila.Cells("descuento").Value
        Dim Stock As Integer = Fila.Cells("stock").Value
        Dim Articulo As String = Fila.Cells("articulo").Value


        If Cantidad > Stock Then
            Cantidad = Stock
            MsgBox("La cantidad de venta del articulo " & Articulo & " no puede ser mayor al stock", vbOKOnly + vbCritical, "Error al ingresar cantidad")
        End If


        Fila.Cells("cantidad").Value = Cantidad
        Fila.Cells("importe").Value = (Precio * Cantidad) - Descuento
        Me.CalcularTotal()
    End Sub


    'Evento que se llama cada vez que se elimina una fila del data GridView
    Private Sub DgvDetalle_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DgvDetalle.RowsRemoved
        Me.CalcularTotal()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            'Valida que no esten los campos vacio y que el detalle tenga al menos un registro en el
            If (TxtIdCliente.Text <> " " And CboTipoComprobante.Text <> " " And TxtNumeroComprobante.Text <> " " And DtDetalle.Rows.Count > 0) Then
                Dim Obj As New Entidades.Venta
                Dim Neg As New Negocio.VentaBLL
                Dim _Articulo As New ArticuloBLL

                Obj.IdUsuario = Variables.IdUsuario
                Obj.IdCliente = TxtIdCliente.Text
                Obj.TipoComprobante = CboTipoComprobante.Text
                Obj.SerieComprobante = TxtSerieDocumento.Text
                Obj.NumeroComprobante = TxtNumeroComprobante.Text
                Obj.Impuesto = TxtInpuesto.Text
                Obj.Total = TxtTotal.Text

                If (Neg.Insertar(Obj, DtDetalle)) Then
                    MsgBox("Se inserto correctamente", vbOKOnly + vbInformation, "Guardando")
                    Me.Listar()

                    'Llamo al metodo buscar de la capa de negocio para refrescar la informacion
                    DgvArticulos.DataSource = _Articulo.BuscarVenta("")
                Else
                    MsgBox("No se pudo insertar", vbOKOnly + vbCritical, "Error al guardar")
                End If

            Else
                MsgBox("Faltan datos por ingresar", vbOKOnly + vbCritical, "Error al guardar")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCerrarDetalle_Click(sender As Object, e As EventArgs) Handles BtnCerrarDetalle.Click
        PanelMostrarDetalle.Visible = False
    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Try
            Dim Neg As New Negocio.VentaBLL

            'Obtengo la fila seleccionada con la columan uno que es el idingreso
            DgvMostrarDetalle.DataSource = Neg.ListarDetalle(DgvListado.SelectedCells.Item(1).Value)

            Dim Total As Decimal = 0
            Dim SubTotal As Decimal = 0
            Dim TotalImpuesto As Decimal = 0

            Total = DgvListado.SelectedCells.Item(10).Value
            SubTotal = Math.Round(Total / (1 + DgvListado.SelectedCells.Item(9).Value), 2)
            TotalImpuesto = Total - SubTotal

            LblTotalDetalle.Text = Total
            LblSubTotal.Text = SubTotal
            LblTotalImpuesto.Text = TotalImpuesto

            PanelMostrarDetalle.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Limpiar()
        TabArticulo.SelectedIndex = 0
    End Sub


    'Evento Check()
    Private Sub ChkSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSeleccionar.CheckedChanged

        If ChkSeleccionar.CheckState = CheckState.Checked Then
            Me.MostrarComponentes()
        Else
            Me.OcultarComponentes()
        End If
    End Sub


    'Cuando se hace click en una celda de contenido
    Private Sub DgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentClick
        If e.ColumnIndex = DgvListado.Columns.Item("Seleccionar").Index Then
            Dim chkCell As DataGridViewCheckBoxCell = DgvListado.Rows(e.RowIndex).Cells("Seleccionar")
            chkCell.Value = Not chkCell.Value
        End If
    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click
        If (MsgBox("Deseas de anular las ventas seleccionadas?", vbYesNo + vbQuestion, "Anular venta") = vbYes) Then
            Try

                Dim Neg As New Negocio.VentaBLL

                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim oneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Anular(oneKey)
                    End If
                Next
                Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub



    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.CrearTablaDetalle()
    End Sub

End Class