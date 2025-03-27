Imports Sistema.Datos
Imports Sistema.Entidades
Imports Sistema.Exceptions

Public Class PersonaBLL




    Public Function Listar() As DataTable
        Try
            Dim Datos As New PersonaDAL
            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al listar los personas. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al intentar listar los personas.")
        End Try
        Return Nothing
    End Function


    Public Function ListarProveedores() As DataTable
        Try
            Dim Datos As New PersonaDAL
            Dim Tabla As New DataTable
            Tabla = Datos.ListarProveedores()
            Return Tabla
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al listar los proveedores. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al intentar listar los proveedores.")
        End Try
        Return Nothing
    End Function



    Public Function ListarClientes() As DataTable
        Try
            Dim Datos As New PersonaDAL
            Dim Tabla As New DataTable
            Tabla = Datos.ListarClientes()
            Return Tabla
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al listar los Clientes. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al intentar listar los Clientes.")
        End Try
        Return Nothing
    End Function

    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Datos As New PersonaDAL
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al listar los personas. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al intentar listar los personas.")
        End Try
        Return Nothing
    End Function


    Public Function BuscarProveedores(Valor As String) As DataTable
        Try
            Dim Datos As New PersonaDAL
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarProveedores(Valor)
            Return Tabla
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al listar los personas. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al intentar listar los proveedores.")
        End Try
        Return Nothing
    End Function



    Public Function BuscarClientes(Valor As String) As DataTable
        Try
            Dim Datos As New PersonaDAL
            Dim Tabla As New DataTable
            Tabla = Datos.BuscarClientes(Valor)
            Return Tabla
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al listar los personas. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al intentar listar los clientes.")
        End Try
        Return Nothing
    End Function


    Public Function Insertar(Obj As Persona) As Boolean
        Dim Inserted = False

        Try
            Dim Datos As New PersonaDAL
            Datos.Insertar(Obj)
            Inserted = True
            Return Inserted
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al guardar el Persona. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al guardar al guardar el Persona." & ex.Message)
        End Try

        Return Inserted
    End Function

    Public Function Actualizar(Obj As Persona) As Boolean
        Dim Upadated = False

        Try
            Dim Datos As New PersonaDAL
            Datos.Actualizar(Obj)
            Upadated = True
            Return Upadated
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al actualizar el Persona. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al actualizar el Persona." & ex.Message)
        End Try

        Return Upadated
    End Function

    Public Function Eliminar(Id As Integer) As Boolean
        Dim Deleted = False
        Try
            Dim Datos As New PersonaDAL
            Datos.Eliminar(Id)
            Deleted = True
            Return Deleted
        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al eliminar el Persona. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al eliminar el Persona." & ex.Message)
        End Try

        Return Deleted
    End Function

End Class
