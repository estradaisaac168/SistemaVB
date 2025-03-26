Imports System.IO
Imports Sistema.Exceptions

Public Class FrmArticulo

    Dim RutaOrigen As String
    Dim RutaDestino As String
    Dim Directorio As String = "D:\Sistema\Imagenes\Articulos\"

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
        File.Filter = "Imagenes (*.jpg;*.png;*.jpeg;*.jpe)|*.jpg;*.png;*.jpeg;*.jpe"
        If File.ShowDialog() = DialogResult.OK Then
            PicImage.Image = Image.FromFile(File.FileName)
            RutaOrigen = File.FileName
            TxtImagen.Text = File.FileName.Substring(File.FileName.LastIndexOf("\") + 1)
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
End Class