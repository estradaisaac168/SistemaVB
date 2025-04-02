Imports Sistema.Entidades
Imports Sistema.Datos.ArticuloDAL
Imports Sistema.Datos
Imports Sistema.Exceptions

Public Class ArticuloBLL

    Public Function Listar() As DataTable
        Try
            Dim Datos As New ArticuloDAL
            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al listar los articulos. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al intentar listar los articulos.")
        End Try
        Return Nothing
    End Function

    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Datos As New ArticuloDAL
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al listar los articulos. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al intentar listar los articulos.")
        End Try
        Return Nothing
    End Function


    Public Function BuscarVenta(Valor As String) As DataTable
        Try
            Dim Datos As New ArticuloDAL
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarVenta(Valor)
            Return Tabla
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al listar los articulos. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al intentar listar los articulos.")
        End Try
        Return Nothing
    End Function


    Public Function BuscarCodigo(Valor As String) As Articulo
        Try
            Dim Datos As New ArticuloDAL
            Dim Tabla As New DataTable
            Dim Art As New Articulo
            Tabla = Datos.BuscarCodigo(Valor)

            'Valido que la tabla tenga al menos una fila
            If (Tabla.Rows.Count > 0) Then

                'Cargo los datos del articulo con los valores que necesito
                Art.IdArticulo = Tabla.Rows(0).Item(0).ToString
                Art.Codigo = Tabla.Rows(0).Item(1).ToString
                Art.Nombre = Tabla.Rows(0).Item(2).ToString
                Art.PrecioVenta = Tabla.Rows(0).Item(3).ToString
                Art.Stock = Tabla.Rows(0).Item(4).ToString
                Return Art
            Else
                Return Nothing
            End If
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al listar los articulos. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al intentar listar los articulos.")
        End Try
        Return Nothing
    End Function


    Public Function BuscarCodigoVenta(Valor As String) As Articulo
        Try
            Dim Datos As New ArticuloDAL
            Dim Tabla As New DataTable
            Dim Art As New Articulo
            Tabla = Datos.BuscarCodigoVenta(Valor)

            'Valido que la tabla tenga al menos una fila
            If (Tabla.Rows.Count > 0) Then

                'Cargo los datos del articulo con los valores que necesito
                Art.IdArticulo = Tabla.Rows(0).Item(0).ToString
                Art.Codigo = Tabla.Rows(0).Item(1).ToString
                Art.Nombre = Tabla.Rows(0).Item(2).ToString
                Art.PrecioVenta = Tabla.Rows(0).Item(3).ToString
                Art.Stock = Tabla.Rows(0).Item(4).ToString
                Return Art
            Else
                Return Nothing
            End If
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al listar los articulos. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al intentar listar los articulos.")
        End Try
        Return Nothing
    End Function



    Public Function Insertar(Obj As Articulo) As Boolean
        Dim Inserted = False

        Try
            Dim RepositorioArticulo As New ArticuloDAL
            RepositorioArticulo.Insertar(Obj)
            Inserted = True
            Return Inserted
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al guardar el articulo. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al guardar al guardar el articulo." & ex.Message)
        End Try

        Return Inserted
    End Function

    Public Function Actualizar(Obj As Articulo) As Boolean
        Dim Upadated = False

        Try
            Dim Datos As New ArticuloDAL
            Datos.Actualizar(Obj)
            Upadated = True
            Return Upadated
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al actualizar el articulo. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al actualizar el articulo." & ex.Message)
        End Try

        Return Upadated
    End Function

    Public Function Eliminar(Id As Integer) As Boolean
        Dim Deleted = False
        Try
            Dim Datos As New ArticuloDAL
            Datos.Eliminar(Id)
            Deleted = True
            Return Deleted
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al eliminar el articulo. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al eliminar el articulo." & ex.Message)
        End Try

        Return Deleted
    End Function

    Public Function Desactivar(Id As Integer) As Boolean
        Dim Activated = False
        Try
            Dim Datos As New ArticuloDAL
            Datos.Desactivar(Id)
            Activated = True
            Return Activated
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al desactivar  el articulo. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Hubo un problema al desactivar  el articulo. Intente nuevamente." & ex.Message)
        End Try
        Return Activated
    End Function

    Public Function Activar(Id As Integer) As Boolean
        Dim Activated = False
        Try
            Dim Datos As New ArticuloDAL
            Datos.Activar(Id)
            Activated = True
            Return Activated
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al activar  el articulo. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Hubo un problema al activar  el articulo. Intente nuevamente." & ex.Message)
        End Try
        Return Activated
    End Function

End Class
