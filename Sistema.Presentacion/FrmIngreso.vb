﻿Imports Sistema.Exceptions

Public Class FrmIngreso

    Private DtDetalle As DataTable

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
            Dim Neg As New Negocio.IngresoBLL
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
            Dim Neg As New Negocio.IngresoBLL
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
        'BtnGuardar.Visible = True
        'BtnActualizar.Visible = False
        'TxtValor.Text = ""
        'TxtID.Text = ""
        'TxtCodigo.Text = ""
        'TxtNombre.Text = ""
        'TxtPrecioVenta.Text = ""
        'TxtStock.Text = ""
        'TxtImagen.Text = ""
        'PicImage.Image = Nothing
        'TxtDescripcion.Text = ""
        'RutaOrigen = ""
    End Sub


    Private Sub CrearTablaDetalle()
        Me.DtDetalle = New DataTable("Detalle")
        'Espera dos detalles , el idingreso y tipo de dato que le estoy pasando
        Me.DtDetalle.Columns.Add("idarticulo", Type.GetType("System.Int32"))
        Me.DtDetalle.Columns.Add("codigo", Type.GetType("System.String"))
        Me.DtDetalle.Columns.Add("articulo", Type.GetType("System.String"))
        Me.DtDetalle.Columns.Add("cantidad", Type.GetType("System.Int32"))
        Me.DtDetalle.Columns.Add("precio", Type.GetType("System.Decimal"))
        Me.DtDetalle.Columns.Add("importe", Type.GetType("System.Decimal"))

        DgvDetalle.DataSource = Me.DtDetalle
        DgvDetalle.Columns(0).Visible = False
        DgvDetalle.Columns(1).HeaderText = "CODIGO"
        DgvDetalle.Columns(1).Width = 100
        DgvDetalle.Columns(2).HeaderText = "ARTICULO"
        DgvDetalle.Columns(2).Width = 200
        DgvDetalle.Columns(3).HeaderText = "CANTIDAD"
        DgvDetalle.Columns(3).Width = 100
        DgvDetalle.Columns(4).HeaderText = "PRECIO"
        DgvDetalle.Columns(4).Width = 100
        DgvDetalle.Columns(5).HeaderText = "IMPORTE"
        DgvDetalle.Columns(5).Width = 100

        'Establecer de solo lectura ciertas columnas
        DgvDetalle.Columns(1).ReadOnly = True
        DgvDetalle.Columns(2).ReadOnly = True
        DgvDetalle.Columns(5).ReadOnly = True

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
            Row("cantidad") = Convert.ToString(1)
            Row("precio") = Convert.ToString(Fila.PrecioVenta)
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

    Private Sub FrmIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.CrearTablaDetalle()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles BtnBuscarProveedor.Click
        FrmProveedorIngreso.ShowDialog()
        TxtIdProveedor.Text = Variables.IdProveedor
        TxtNombreProveedor.Text = Variables.NombreProveedor
    End Sub

    Private Sub TxtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCodigo.KeyDown
        'Evaluar si se presiono la tecla enter
        If e.KeyCode = Keys.Enter Then
            Try
                Dim Neg As New Negocio.ArticuloBLL
                Dim Obj As New Entidades.Articulo

                'A mi variable de tipo articulo le asigno lo que me devuelva el metodo buscarCodigo
                Obj = Neg.BuscarCodigo(TxtCodigo.Text)

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
            DgvArticulos.DataSource = Neg.Buscar(Valor)
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

        Fila.Cells("importe").Value = Precio * Cantidad
        Me.CalcularTotal()
    End Sub


    'Evento que se llama cada vez que se elimina una fila del data GridView
    Private Sub DgvDetalle_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DgvDetalle.RowsRemoved
        Me.CalcularTotal()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If () Then
            Else

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
