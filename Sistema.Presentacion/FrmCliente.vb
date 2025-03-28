Imports Sistema.Exceptions

Public Class FrmCliente


    Private Sub Formato()
        DgvListado.Columns(0).Visible = False
        DgvListado.Columns(0).Width = 100
        DgvListado.Columns(1).Width = 80
        DgvListado.Columns(2).Width = 120
        DgvListado.Columns(3).Width = 100
        DgvListado.Columns(4).Width = 150
        DgvListado.Columns(5).Width = 100
        DgvListado.Columns(6).Width = 120
        DgvListado.Columns(7).Width = 100
        DgvListado.Columns(8).Width = 120

        Me.OcultarComponentes()
        ChkSeleccionar.CheckState = False
    End Sub





    Private Sub OcultarComponentes()
        DgvListado.Columns.Item("Seleccionar").Visible = False
        BtnEliminar.Visible = False
    End Sub





    Private Sub MostrarComponentes()
        DgvListado.Columns.Item("Seleccionar").Visible = True
        BtnEliminar.Visible = True
    End Sub






    Private Sub Listar()
        Try
            Dim Neg As New Negocio.PersonaBLL
            DgvListado.DataSource = Neg.ListarClientes()
            LblTotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
            Me.Limpiar()
        Catch ex As BusinessLogicException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub Buscar()
        Try
            Dim Neg As New Negocio.PersonaBLL
            Dim Valor As String
            Valor = TxtValor.Text
            DgvListado.DataSource = Neg.BuscarClientes(Valor)
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
        TxtDireccion.Text = ""
        TxtNumeroDocumento.Text = ""
    End Sub


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Me.ValidateChildren = True And TxtNombre.Text <> "" Then
                Dim Obj As New Entidades.Persona
                Dim Neg As New Negocio.PersonaBLL

                Obj.TipoPersona = "Cliente"
                Obj.Nombre = TxtNombre.Text
                Obj.TipoDocumento = CboTipoDocumento.Text 'Se coloca text y no selectedvalue porque no se ha llenado el combo desde la base de datos
                Obj.NumeroDocumento = TxtNumeroDocumento.Text
                Obj.Direccion = TxtDireccion.Text
                Obj.Telefono = TxtTelefono.Text
                Obj.Email = TxtEmail.Text

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

        'Regresar al tab numero uno
        TabCliente.SelectedIndex = 0
    End Sub

    Private Sub DgvListado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListado.CellContentDoubleClick
        Try
            Dim Fila As Integer
            Fila = DgvListado.CurrentCell.RowIndex
            TxtID.Text = DgvListado.Rows(Fila).Cells(1).Value
            TxtNombre.Text = DgvListado.Rows(Fila).Cells(3).Value
            CboTipoDocumento.Text = DgvListado.Rows(Fila).Cells(4).Value
            TxtNumeroDocumento.Text = DgvListado.Rows(Fila).Cells(5).Value
            TxtDireccion.Text = DgvListado.Rows(Fila).Cells(6).Value
            TxtTelefono.Text = DgvListado.Rows(Fila).Cells(7).Value
            TxtEmail.Text = DgvListado.Rows(Fila).Cells(8).Value

            TabCliente.SelectedIndex = 1
            BtnActualizar.Visible = True
            BtnGuardar.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Try
            If Me.ValidateChildren = True And TxtNombre.Text <> "" And TxtID.Text <> "" Then
                Dim Obj As New Entidades.Persona
                Dim Neg As New Negocio.PersonaBLL

                Obj.IdPersona = TxtID.Text
                Obj.TipoPersona = "Cliente"
                Obj.Nombre = TxtNombre.Text
                Obj.TipoDocumento = CboTipoDocumento.Text 'Se coloca text y no selectedvalue porque no se ha llenado el combo desde la base de datos
                Obj.NumeroDocumento = TxtNumeroDocumento.Text
                Obj.Direccion = TxtDireccion.Text
                Obj.Telefono = TxtTelefono.Text
                Obj.Email = TxtEmail.Text

                If (Neg.Actualizar(Obj)) Then
                    MsgBox("Se ha Actualizado correctamente", vbOKOnly + vbInformation, "Actualizacion correcta")

                    Me.Listar()
                Else
                    MsgBox("No se ha podido registrar", vbOKOnly + vbCritical, "Actualizado incorrecto")
                End If
            Else
                MsgBox("Rellene todos los campos obligatorios (*)", vbOKOnly + vbCritical, "Falta Ingresar datos")
            End If
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
                Dim Neg As New Negocio.PersonaBLL

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

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Limpiar()
    End Sub
End Class