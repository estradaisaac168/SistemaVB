Imports Sistema.Datos
Imports Sistema.Entidades
Imports Sistema.Exceptions

Public Class UsuarioBLL


    Public Function Listar() As DataTable
        Try
            Dim Datos As New UsuarioDAL
            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al listar los usuarios. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al intentar listar los usuarios.")
        End Try
        Return Nothing
    End Function

    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Datos As New UsuarioDAL
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al listar los usuarios. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al intentar listar los usuarios.")
        End Try
        Return Nothing
    End Function



    Public Function Login(Email As String, Clave As String) As Usuario
        Try
            Dim UsuarioActual As New Usuario
            Dim Datos As New UsuarioDAL
            Dim Tabla As New DataTable
            Tabla = Datos.Login(Email, Clave)
            If (Tabla.Rows.Count > 0) Then
                UsuarioActual.IdUsuario = Tabla.Rows(0).Item(0).ToString
                UsuarioActual.IdRol = Tabla.Rows(0).Item(1).ToString
                UsuarioActual.Rol = Tabla.Rows(0).Item(2).ToString
                UsuarioActual.Nombre = Tabla.Rows(0).Item(3).ToString
                UsuarioActual.Estado = Tabla.Rows(0).Item(4)

                Return UsuarioActual
            Else
                Return Nothing
            End If
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema con el login usuarios. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al intentar iniciar session.")
        End Try
        Return Nothing
    End Function



    Public Function Insertar(Obj As Usuario) As Boolean
        Dim Inserted = False

        Try
            Dim Datos As New UsuarioDAL
            Datos.Insertar(Obj)
            Inserted = True
            Return Inserted
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al guardar el usuario. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al guardar al guardar el usuario." & ex.Message)
        End Try

        Return Inserted
    End Function

    Public Function Actualizar(Obj As Usuario) As Boolean
        Dim Upadated = False

        Try
            Dim Datos As New UsuarioDAL
            Datos.Actualizar(Obj)
            Upadated = True
            Return Upadated
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al actualizar el usuario. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al actualizar el usuario." & ex.Message)
        End Try

        Return Upadated
    End Function

    Public Function Eliminar(Id As Integer) As Boolean
        Dim Deleted = False
        Try
            Dim Datos As New UsuarioDAL
            Datos.Eliminar(Id)
            Deleted = True
            Return Deleted
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al eliminar el usuario. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al eliminar el usuario." & ex.Message)
        End Try

        Return Deleted
    End Function

    Public Function Desactivar(Id As Integer) As Boolean
        Dim Activated = False
        Try
            Dim Datos As New UsuarioDAL
            Datos.Desactivar(Id)
            Activated = True
            Return Activated
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al desactivar  el usuario. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Hubo un problema al desactivar  el usuario. Intente nuevamente." & ex.Message)
        End Try
        Return Activated
    End Function

    Public Function Activar(Id As Integer) As Boolean
        Dim Activated = False
        Try
            Dim Datos As New UsuarioDAL
            Datos.Activar(Id)
            Activated = True
            Return Activated
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al activar  el usuario. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Hubo un problema al activar  el usuario. Intente nuevamente." & ex.Message)
        End Try
        Return Activated
    End Function


End Class
