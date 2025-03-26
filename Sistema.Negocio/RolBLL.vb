Imports Sistema.Datos
Imports Sistema.Exceptions

Public Class RolBLL

    Public Function Listar() As DataTable
        Try
            Dim Datos As New RolDAL
            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As DataAccessException
            Throw New BusinessLogicException(ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error en la capa negocio, metodo listar().")
        End Try
        Return Nothing
    End Function

End Class
