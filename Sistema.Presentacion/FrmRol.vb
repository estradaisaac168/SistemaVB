Imports Sistema.Exceptions

Public Class FrmRol


    Private Sub Formato()

        DgvListadoRol.Columns(0).Width = 100
        DgvListadoRol.Columns(1).Width = 150
        DgvListadoRol.Columns(0).HeaderText = "ID"
        DgvListadoRol.Columns(1).HeaderText = "Nombre"
    End Sub



    Private Sub Listar()
        Try
            Dim Neg As New Negocio.RolBLL
            DgvListadoRol.DataSource = Neg.Listar()
            LblTotal.Text = "Total Registros: " & DgvListadoRol.DataSource.Rows.Count
            Me.Formato()
        Catch ex As BusinessLogicException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub DgvListadoRol_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvListadoRol.CellContentClick

    End Sub

    Private Sub FrmRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Listar()
    End Sub
End Class