Imports Sistema.Exceptions

Public Class FrmProveedor


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
            DgvListado.DataSource = Neg.ListarProveedores()
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
            DgvListado.DataSource = Neg.BuscarProveedores(Valor)
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



    Private Sub FrmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Me.ValidateChildren = True And TxtNombre.Text <> "" Then
                Dim Obj As New Entidades.Persona
                Dim Neg As New Negocio.PersonaBLL

                Obj.TipoPersona = "Proveedor"
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
End Class