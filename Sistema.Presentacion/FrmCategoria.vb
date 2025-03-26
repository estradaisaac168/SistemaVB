Imports Sistema.Exceptions

Public Class FrmCategoria

    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 100
        DgvListado.Columns(2).Width = 150
        DgvListado.Columns(3).Width = 400
        DgvListado.Columns(4).Width = 100
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
            Dim Neg As New Negocio.CategoriaBLL
            DgvListado.DataSource = Neg.Listar()
            LblTotal.Text = "Total de registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
            Me.Limpiar()
        Catch ex As BusinessLogicException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.CategoriaBLL
            Dim Valor As String
            Valor = TxtValor.Text
            DgvListado.DataSource = Neg.Buscar(Valor)
            LblTotal.Text = "Total de registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
        Catch ex As BusinessLogicException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Limpiar()
        BtnGuardar.Visible = True
        BtnActualizar.Visible = False
        TxtValor.Text = ""
        TxtID.Text = ""
        TxtNombre.Text = ""
        TxtDescripcion.Text = ""
    End Sub

    Private Sub FrmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
    End Sub


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Limpiar()
        TabCategoria.SelectedIndex = 0
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Me.ValidateChildren = True And TxtNombre.Text <> "" Then
            Dim Obj As New Entidades.Categoria
            Dim Neg As New Negocio.CategoriaBLL

            Obj.Nombre = TxtNombre.Text
            Obj.Descripcion = TxtDescripcion.Text

            If (Neg.Insertar(Obj)) Then
                MsgBox("Registro guardado correctamente", vbOKOnly + vbInformation, "Registro correcto")
                Me.Listar()
            Else
                MsgBox("No se pudo guardar el registro", vbOKOnly + vbCritical, "Registro incorrecto")
            End If
        Else
            MsgBox("Rellene todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta ingresar datos")
        End If
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub


    'Con este metodo se agrega validacion al campo nombre en el formulario
    Private Sub TxtNombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TxtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorIcono.SetError(sender, "")
        Else
            Me.ErrorIcono.SetError(sender, "Ingrese el nombre de la categoria")
        End If
    End Sub

    Private Sub DgvListado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellDoubleClick

        'Obtengo los valores de la fila seleccionada
        'Lleno los campos con esos valores
        TxtID.Text = DgvListado.SelectedCells.Item(1).Value
        TxtNombre.Text = DgvListado.SelectedCells.Item(2).Value
        TxtDescripcion.Text = DgvListado.SelectedCells.Item(3).Value

        'Cuando hace doble click es porque se va a actualizar un registro
        'En este caso se debe de ocutar el boton guardar y habilitar el boton actualizar
        BtnGuardar.Visible = False
        BtnActualizar.Visible = True

        TabCategoria.SelectedIndex = 1 'Redirijo al tab de mantenimiento
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Me.ValidateChildren = True And TxtNombre.Text <> "" And TxtID.Text <> "" Then


            Dim Obj As New Entidades.Categoria
            Dim Neg As New Negocio.CategoriaBLL

            Obj.IdCategoria = TxtID.Text
            Obj.Nombre = TxtNombre.Text
            Obj.Descripcion = TxtDescripcion.Text

            If (Neg.Actualizar(Obj)) Then
                MsgBox("Registro actualizado correctamente", vbOKOnly + vbInformation, "Actualizacion correcta")
                Me.Listar()
                'Redireccionar al listado
                TabCategoria.SelectedIndex = 0
            Else
                MsgBox("No se pudo actualizado el registro", vbOKOnly + vbCritical, "Registro incorrecto")
            End If
        Else
            MsgBox("Rellene todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta ingresar datos")
        End If
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


    'Boton para Eliminar
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If (MsgBox("Deseas eliminar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar registro") = vbYes) Then
            Try

                Dim Neg As New Negocio.CategoriaBLL

                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then
                        Dim oneKey As Integer = Convert.ToInt32(row.Cells("ID").Value)
                        Neg.Eliminar(oneKey)
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

                Dim Neg As New Negocio.CategoriaBLL

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

                Dim Neg As New Negocio.CategoriaBLL

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