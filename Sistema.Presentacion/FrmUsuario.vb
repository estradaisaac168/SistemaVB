Imports System.IO
Imports Sistema.Exceptions

Public Class FrmUsuario


    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(2).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 80
        DgvListado.Columns(3).Width = 120
        DgvListado.Columns(4).Width = 100
        DgvListado.Columns(5).Width = 150
        DgvListado.Columns(6).Width = 100
        DgvListado.Columns(7).Width = 120
        DgvListado.Columns(8).Width = 100
        DgvListado.Columns(9).Width = 120
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
            Dim Neg As New Negocio.UsuarioBLL
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
            Dim Neg As New Negocio.UsuarioBLL
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
        BtnActualizar.Visible = False
        TxtID.Text = ""
        TxtNombre.Text = ""
        TxtTelefono.Text = ""
        TxtEmail.Text = ""
        TxtClave.Text = ""
        TxtDireccion.Text = ""
        TxtNumeroDocumento.Text = ""
    End Sub


    Private Sub CargarRol()
        Try
            Dim Neg As New Negocio.RolBLL
            CboRol.DataSource = Neg.Listar()
            CboRol.ValueMember = "idrol"
            CboRol.DisplayMember = "nombre"
        Catch ex As BusinessLogicException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
        Me.CargarRol()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Me.ValidateChildren = True And CboRol.Text <> "" And TxtNombre.Text <> "" And TxtEmail.Text <> "" And TxtClave.Text <> "" Then
                Dim Obj As New Entidades.Usuario
                Dim Neg As New Negocio.UsuarioBLL

                Obj.IdRol = CboRol.SelectedValue
                Obj.Nombre = TxtNombre.Text
                Obj.TipoDocumento = CboTipoDocumento.Text 'Se coloca text y no selectedvalue porque no se ha llenado el combo desde la base de datos
                Obj.NumDocumento = TxtNumeroDocumento.Text
                Obj.Direccion = TxtDireccion.Text
                Obj.Telefono = TxtTelefono.Text
                Obj.Email = TxtEmail.Text
                Obj.Clave = TxtClave.Text

                If (Neg.Insertar(Obj)) Then
                    MsgBox("Se ha registrado correctamente", vbOKOnly + vbInformation, "Registro correcto")

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
        TabUsuario.SelectedIndex = 0
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If Me.ValidateChildren = True And TxtID.Text <> "" And CboRol.Text <> "" And TxtNombre.Text <> "" And TxtEmail.Text <> "" Then
                Dim Obj As New Entidades.Usuario
                Dim Neg As New Negocio.UsuarioBLL

                Obj.IdUsuario = TxtID.Text
                Obj.IdRol = CboRol.SelectedValue
                Obj.Nombre = TxtNombre.Text
                Obj.TipoDocumento = CboTipoDocumento.Text 'Se coloca text y no selectedvalue porque no se ha llenado el combo desde la base de datos
                Obj.NumDocumento = TxtNumeroDocumento.Text
                Obj.Direccion = TxtDireccion.Text
                Obj.Telefono = TxtTelefono.Text
                Obj.Email = TxtEmail.Text
                Obj.Clave = TxtClave.Text

                If (Neg.Actualizar(Obj)) Then
                    MsgBox("Se ha actualizado correctamente", vbOKOnly + vbInformation, "Actualizado correcto")

                    Me.Listar()
                Else
                    MsgBox("No se ha podido actualizado", vbOKOnly + vbCritical, "Actualizado incorrecto")
                End If
            Else
                MsgBox("Rellene todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta Ingresar datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvListado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentDoubleClick
        Try
            TxtID.Text = DgvListado.SelectedCells.Item(1).Value
            CboRol.SelectedValue = DgvListado.SelectedCells.Item(2).Value
            TxtNombre.Text = DgvListado.SelectedCells.Item(4).Value
            CboTipoDocumento.Text = DgvListado.SelectedCells.Item(5).Value
            TxtNumeroDocumento.Text = DgvListado.SelectedCells.Item(6).Value
            TxtDireccion.Text = DgvListado.SelectedCells.Item(7).Value
            TxtTelefono.Text = DgvListado.SelectedCells.Item(8).Value
            TxtEmail.Text = DgvListado.SelectedCells.Item(9).Value
            BtnGuardar.Visible = False
            BtnActualizar.Visible = True
            TabUsuario.SelectedIndex = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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
                Dim Neg As New Negocio.UsuarioBLL

                'Recorrer el DataGridView
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then

                        'Obtener el valor de la celda ID del datagridview
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
        If (MsgBox("Deseas activar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar registro") = vbYes) Then
            Try

                'Crear una instancia de la clase ArticuloBLL
                Dim Neg As New Negocio.UsuarioBLL

                'Recorrer el DataGridView
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then

                        'Obtener el valor de la celda ID del datagridview
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
        If (MsgBox("Deseas desactivar los registros seleccionados?", vbYesNo + vbQuestion, "Eliminar registro") = vbYes) Then
            Try

                'Crear una instancia de la clase ArticuloBLL
                Dim Neg As New Negocio.UsuarioBLL

                'Recorrer el DataGridView
                For Each row As DataGridViewRow In DgvListado.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Seleccionar").Value)
                    If marcado Then

                        'Obtener el valor de la celda ID del datagridview
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