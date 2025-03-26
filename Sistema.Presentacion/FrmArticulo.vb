Imports System.IO
Imports Sistema.Exceptions

Public Class FrmArticulo

    Dim RutaOrigen As String
    Dim RutaDestino As String
    Dim Directorio As String = "C:\Users\Isaac_Estrada\Documents\Imagenes\Articulos\"

    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 100
        DgvListado.Columns(3).Width = 100
        DgvListado.Columns(4).Width = 100
        DgvListado.Columns(5).Width = 150
        DgvListado.Columns(6).Width = 100
        DgvListado.Columns(7).Width = 100
        DgvListado.Columns(8).Width = 200
        DgvListado.Columns(9).Width = 100
        DgvListado.Columns(10).Width = 100

        Me.OcultarComponentes()
        ChkSeleccionar.CheckState = False
    End Sub





    Private Sub OcultarComponentes()
        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False
        BtnActivar.Visible = False
        BtnDesactivar.Visible = False
    End Sub





    Private Sub MostrarComponentes()
        DgvListado.Columns.Item("Seleccionar").Visible = True
        BtnEliminar.Visible = True
        BtnActivar.Visible = True
        BtnDesactivar.Visible = True
    End Sub






    Private Sub Listar()
        Try
            Dim Neg As New Negocio.ArticuloBLL
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
            Dim Neg As New Negocio.ArticuloBLL
            Dim Valor As String
            Valor = TxtValor.Text
            DgvListado.DataSource = Neg.Buscar(Valor)
            LblTotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
        Catch ex As BusinessLogicException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub






    Private Sub CargarCategoria()

        Try
            Dim Neg As New Negocio.CategoriaBLL
            'Llenar un combobox
            CboCategoria.DataSource = Neg.Seleccionar
            CboCategoria.ValueMember = "idcategoria" 'Valor
            CboCategoria.DisplayMember = "nombre" ' Texto
        Catch ex As BusinessLogicException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub







    Private Sub Limpiar()
        BtnGuardar.Visible = True
        BtnActualizar.Visible = False
        TxtValor.Text = ""
        TxtID.Text = ""
        TxtCodigo.Text = ""
        TxtNombre.Text = ""
        TxtPrecioVenta.Text = ""
        TxtStock.Text = ""
        TxtImagen.Text = ""
        PicImage.Image = Nothing
        TxtDescripcion.Text = ""
        RutaOrigen = ""
    End Sub







    Private Sub FrmArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.CargarCategoria()
    End Sub







    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub






    Private Sub CboCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboCategoria.SelectedIndexChanged

    End Sub






    Private Sub BtnCargarImagen_Click(sender As Object, e As EventArgs) Handles BtnCargarImagen.Click
        Dim File As New OpenFileDialog()

        'Asignar nombre unico a la imagen antes de guardarla con ramdom
        Dim Random As New Random
        Dim RandomNumber As Integer = Random.Next(1, 100000)

        'En el cuadro de dialogo aparece esta opcion de filtrar
        File.Filter = "Imagenes (*.jpg;*.png;*.jpeg;*.jpe)|*.jpg;*.png;*.jpeg;*.jpe"

        'Muestra el dialogo de confirmacion
        If File.ShowDialog() = DialogResult.OK Then
            PicImage.Image = Image.FromFile(File.FileName)
            RutaOrigen = File.FileName
            TxtImagen.Text = RandomNumber & File.FileName.Substring(File.FileName.LastIndexOf("\") + 1)
        End If
    End Sub






    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Me.ValidateChildren = True And CboCategoria.Text <> "" And TxtNombre.Text <> "" And TxtPrecioVenta.Text <> "" And TxtStock.Text <> "" Then
                Dim Obj As New Entidades.Articulo
                Dim Neg As New Negocio.ArticuloBLL

                Obj.IdCategoria = CboCategoria.SelectedValue
                Obj.Codigo = TxtCodigo.Text
                Obj.Nombre = TxtNombre.Text
                Obj.PrecioVenta = TxtPrecioVenta.Text
                Obj.Stock = TxtStock.Text
                Obj.Imagen = TxtImagen.Text
                Obj.Descripcion = TxtDescripcion.Text

                If (Neg.Insertar(Obj)) Then
                    MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro correcto")
                    If (TxtImagen.Text <> "") Then
                        'Si no existe el directorio lo crea
                        If Not Directory.Exists(Directorio) Then
                            Directory.CreateDirectory(Directorio)
                        End If
                        RutaDestino = Directorio & TxtImagen.Text
                        File.Copy(RutaOrigen, RutaDestino)
                    End If
                    Me.Listar()
                Else
                    MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Registro incorrecto")
                End If
            Else
                MsgBox("Rellene todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta Ingresar datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub






    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Limpiar()
        TabArticulo.SelectedIndex = 0
    End Sub




    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick
        Try
            'Seleccionar el registro al hacer doble click y asignar los valores a las variables
            TxtID.Text = DgvListado.SelectedCells.Item(1).Value
            CboCategoria.SelectedValue = DgvListado.SelectedCells.Item(2).Value
            TxtCodigo.Text = DgvListado.SelectedCells.Item(4).Value
            TxtNombre.Text = DgvListado.SelectedCells.Item(5).Value
            TxtStock.Text = DgvListado.SelectedCells.Item(6).Value
            TxtPrecioVenta.Text = DgvListado.SelectedCells.Item(7).Value
            TxtDescripcion.Text = DgvListado.SelectedCells.Item(8).Value

            Console.WriteLine(DgvListado.SelectedCells.Item(5).Value)

            Dim Imagen As String
            Imagen = DgvListado.SelectedCells.Item(9).Value

            'Asignar a la variable RutaImagen la ruta de la imagen para verificar que exista
            Dim RutaImagen As String = Directorio & Imagen

            'Si la imagen no existe entonces se asigna un valor vacio a la imagen
            If Imagen <> "" And File.Exists(RutaImagen) Then
                PicImage.Image = Image.FromFile(Directorio & Imagen)
                TxtImagen.Text = Imagen
            Else
                PicImage.Image = Nothing
                TxtImagen.Text = ""
            End If

            BtnGuardar.Visible = False
            BtnActualizar.Visible = True
            TabArticulo.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub





    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            'Validar que los campos no esten vacios
            If Me.ValidateChildren = True And CboCategoria.Text <> "" And TxtNombre.Text <> "" And TxtPrecioVenta.Text <> "" And TxtStock.Text <> "" And TxtID.Text <> "" Then

                'Creo un objeto de instancia de la clase Articulo
                Dim Obj As New Entidades.Articulo

                'Creo un objeto de instancia de la clase ArticuloBLL
                Dim Neg As New Negocio.ArticuloBLL

                Obj.IdArticulo = TxtID.Text
                Obj.IdCategoria = CboCategoria.SelectedValue
                Obj.Codigo = TxtCodigo.Text
                Obj.Nombre = TxtNombre.Text
                Obj.PrecioVenta = TxtPrecioVenta.Text
                Obj.Stock = TxtStock.Text
                Obj.Imagen = TxtImagen.Text
                Obj.Descripcion = TxtDescripcion.Text

                If (Neg.Actualizar(Obj)) Then
                    MsgBox("Se ha actuailzado correctamente", vbOKOnly + vbInformation, "Actualizacion correcta")

                    'Si existe en el directorio no es necesario copiar la imagen
                    If (TxtImagen.Text <> "" And RutaOrigen <> "") Then
                        'Si no existe el directorio lo crea
                        If Not Directory.Exists(Directorio) Then
                            Directory.CreateDirectory(Directorio)
                        End If
                        RutaDestino = Directorio & TxtImagen.Text
                        File.Copy(RutaOrigen, RutaDestino)
                    End If
                    Me.Listar()
                Else
                    MsgBox("No se ha podido Actualizar", vbOKOnly + vbCritical, "Actualizacion correcta")
                End If
            Else
                MsgBox("Rellene todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta Ingresar datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    'Activar o deactivar el checkbox
    Private Sub DgvListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentClick
        'Verificar si la celda clickeada esta en la columna "Seleccionar"
        If e.ColumnIndex = DgvListado.Columns.Item("Seleccionar").Index AndAlso e.RowIndex >= 0 Then

            'Obtener la celda Checkbox
            Dim chkCell As DataGridViewCheckBoxCell = DgvListado.Rows(e.RowIndex).Cells("Seleccionar")

            'Evaluar que el valor de la celda no sea Nothing y convertirlo a Booleano antes de invertirlo
            chkCell.Value = Not CBool(If(chkCell.Value, False))

            'Actualizar visualmente el DataGridView
            DgvListado.RefreshEdit()
        End If
    End Sub





    Private Sub ChkSeleccionar_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSeleccionar.CheckedChanged

        'Verificar si el checkbox esta seleccionado
        If ChkSeleccionar.CheckState = CheckState.Checked Then
            Me.MostrarComponentes()
        Else
            Me.OcultarComponentes()
        End If
    End Sub






    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click

        'Verificar si el usuario desea eliminar los registros seleccionados
        If (MsgBox("Deseas eliminar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar registro") = vbYes) Then
            Try

                'Crear una instancia de la clase ArticuloBLL
                Dim Neg As New Negocio.ArticuloBLL

                'Recorrer el DataGridView
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then

                        'Obtener el valor de la celda ID del datagridview
                        Dim oneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)

                        'Obtener el nombre de la imagen del datagridview
                        Dim Imagen As String = Convert.ToString(row.Cells("Imagen").Value)
                        Neg.Eliminar(oneKey)

                        'Si la imagen existe en el directorio entonces eliminarla
                        If Imagen <> "" Then
                            Dim RutaImagen As String = Directorio & Imagen
                            If File.Exists(RutaImagen) Then
                                File.Delete(RutaImagen)
                            End If
                        End If
                    End If
                Next
                Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub




    Private Sub BtnActivar_Click(sender As Object, e As EventArgs) Handles BtnActivar.Click
        If (MsgBox("Deseas activar los registros seleccionados?", vbYesNo + vbQuestion, "Activar registro") = vbYes) Then
            Try

                Dim Neg As New Negocio.ArticuloBLL

                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim oneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Activar(oneKey)
                    End If
                Next
                Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub




    Private Sub BtnDesactivar_Click(sender As Object, e As EventArgs) Handles BtnDesactivar.Click
        If (MsgBox("Deseas desactivar los registros seleccionados?", vbYesNo + vbQuestion, "Desactivar registro") = vbYes) Then
            Try

                Dim Neg As New Negocio.ArticuloBLL

                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim oneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Desactivar(oneKey)
                    End If
                Next
                Listar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class