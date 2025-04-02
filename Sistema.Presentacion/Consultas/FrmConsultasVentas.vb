Imports Sistema.Exceptions

Public Class FrmConsultasVentas




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

    End Sub


    Private Sub Filtrar()
        Try
            Dim Neg As New Negocio.VentaBLL
            Dim FechaInicio As Date
            Dim FechaFin As Date
            FechaInicio = DtpFechaInicio.Value
            FechaFin = DtpFechaFin.Value
            DgvListado.DataSource = Neg.ConsultaFecha(FechaInicio, FechaFin)
            LblTotal.Text = "Total Registros: " & DgvListado.DataSource.Rows.Count
            Me.Formato()
        Catch ex As BusinessLogicException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub FrmConsultasVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelMostrarDetalle.Visible = False
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        Me.Filtrar()
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

    Private Sub BtnCerrarDetalle_Click(sender As Object, e As EventArgs) Handles BtnCerrarDetalle.Click
        PanelMostrarDetalle.Visible = False
    End Sub


    'Pendinete la parte de la Comprobante
End Class