Imports Sistema.Datos
Imports Sistema.Entidades
Imports System.IO
Imports Sistema.Exceptions
Imports System.Runtime.InteropServices

'Capa de aplicacion --> Servicios o logica de negocio

Public Class CategoriaBLL



    Public Function Listar() As DataTable
        Try

            Dim Repositorio As New CategoriaDAL()
            Dim Tabla As New DataTable
            Tabla = Repositorio.Listar()
            Return Tabla

        Catch ex As DataAccessException
            LogError("Error en la capa de lógica de negocio en Listar(). " & ex.Message)
            Throw New BusinessLogicException("Hubo un problema al listar las categorías. Intente nuevamente." & ex.Message)

        Catch ex As Exception
            LogError("Error inesperado en la capa de lógica de negocio en Listar(). " & ex.Message)
            Throw New BusinessLogicException("Error desconocido al intentar listar las categorías.")

        End Try
        Return Nothing
    End Function



    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Repositorio As New CategoriaDAL()
            Dim Tabla As New DataTable
            Tabla = Repositorio.Buscar(Valor)
            Return Tabla

        Catch ex As DataAccessException
            LogError("Error en la capa de lógica de negocio en Buscar(). " & ex.Message)
            Throw New BusinessLogicException("Hubo un problema al realizar la búsqueda. Intente nuevamente.")

        Catch ex As Exception
            LogError("Error inesperado en la capa de lógica de negocio en Buscar(). " & ex.Message)
            Throw New BusinessLogicException("Error desconocido al intentar realizar la búsqueda.")
        End Try
        Return Nothing
    End Function


    Public Function Seleccionar() As DataTable
        Try

            Dim Repositorio As New CategoriaDAL()
            Dim Tabla As New DataTable
            Tabla = Repositorio.Seleccionar()
            Return Tabla

        Catch ex As DataAccessException
            LogError("Error en la capa de lógica de negocio en Listar(). " & ex.Message)
            Throw New BusinessLogicException("Hubo un problema al listar las categorías. Intente nuevamente." & ex.Message)

        Catch ex As Exception
            LogError("Error inesperado en la capa de lógica de negocio en Listar(). " & ex.Message)
            Throw New BusinessLogicException("Error desconocido al intentar listar las categorías.")

        End Try
        Return Nothing
    End Function

    Public Function Insertar(Obj As Categoria) As Boolean

        Dim Inserted = False

        Try
            ' Crear una instancia del repositorio para manejar la inserción
            Dim Repositorio As New CategoriaDAL()

            ' Llamar al método de inserción del repositorio
            Repositorio.Insertar(Obj)
            Inserted = True

            ' Retornar True si la inserción fue exitosa
            Return Inserted

        Catch ex As DataAccessException
            LogError("Error en la capa de negocio en Insertar(): " & ex.Message)
            Throw New BusinessLogicException("Hubo un problema al guardar la categoría. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            LogError("Error inesperado en la capa de negocio en Insertar(): " & ex.Message)
            Throw New BusinessLogicException("Error desconocido al guardar la categoria." & ex.Message)
        End Try

        Return Inserted
    End Function



    Public Function Actualizar(Obj As Categoria) As Boolean
        Dim Updated = False

        Try
            ' Crear una instancia del repositorio para manejar la actualización
            Dim Repositorio As New CategoriaDAL()

            ' Llamar al método de actualización del repositorio
            Repositorio.Actualizar(Obj)
            Updated = True

            ' Retornar True si la actualización fue exitosa
            Return Updated

        Catch ex As DataAccessException
            LogError("Error en la capa de negocio en Insertar(): " & ex.Message)
            Throw New BusinessLogicException("Hubo un problema al actualizar la categoría. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            LogError("Error inesperado en la capa de negocio en actualizar : " & ex.Message)
            Throw New BusinessLogicException("Error desconocido al actualizar  la categoria." & ex.Message)
        End Try
        Return Updated
    End Function




    ' Método para Eliminar
    Public Function Eliminar(Id As Integer) As Boolean

        Dim Deleted = False


        Try
            ' Crear una instancia del repositorio
            Dim Repositorio As New CategoriaDAL()

            ' Llamar al método Eliminar del repositorio
            Repositorio.Eliminar(Id)
            Deleted = True
            Return Deleted

        Catch ex As DataAccessException
            ' Log del error en caso de un problema con la base de datos
            LogError("Error al eliminar la categoría con ID " & Id & ". " & ex.Message)
            Throw New BusinessLogicException("Hubo un problema al eliminar la categoría. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            ' Log para otros errores inesperados
            Throw New BusinessLogicException("Hubo un problema al eliminar la categoría. Intente nuevamente." & ex.Message)
        End Try
        Return Deleted
    End Function





    ' Método para Desactivar
    Public Function Desactivar(Id As Integer) As Boolean

        Dim Activated = False
        Try
            ' Crear una instancia del repositorio
            Dim Repositorio As New CategoriaDAL()

            ' Llamar al método Desactivar del repositorio
            Repositorio.Desactivar(Id)
            Activated = True
            Return Activated

        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al desactivar la categoría. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Hubo un problema al desactivar la categoría. Intente nuevamente." & ex.Message)
        End Try
        Return Activated

    End Function




    ' Método para Activar
    Public Function Activar(Id As Integer) As Boolean
        Dim Activated = False

        Try
            ' Crear una instancia del repositorio
            Dim Repositorio As New CategoriaDAL()

            ' Llamar al método Activar del repositorio
            Repositorio.Activar(Id)
            Activated = True
            Return Activated

        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al activar la categoría. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Hubo un problema al activar la categoría. Intente nuevamente." & ex.Message)
        End Try
        Return Activated
    End Function





    'Public Function Buscar(Valor As String) As DataTable

    '    Try
    '        Dim Repositorio As New RepositorioCategoria
    '        Dim Tabla As New DataTable
    '        Tabla = Repositorio.Buscar(Valor)
    '        Return Tabla

    '    Catch ex As Exception
    '        ' Registrar el error
    '        LogError("Error en Buscar(): " & ex.Message)

    '        ' Devolver Nothing en caso de error
    '        Return Nothing
    '    End Try
    'End Function



    'Public Function Listar() As DataTable

    '    Try
    '        Dim Repositorio As New RepositorioCategoria
    '        Dim Tabla As New DataTable
    '        Tabla = Repositorio.Listar()
    '        Return Tabla

    '    Catch ex As Exception
    '        ' Registrar el error
    '        LogError("Error en Listar(): " & ex.Message)

    '        ' Devolver Nothing en caso de error
    '        Return Nothing
    '    End Try
    'End Function




    'Public Function Insertar(Obj As Categoria) As Boolean

    '    Try
    '        Dim Repositorio As New RepositorioCategoria
    '        Repositorio.Insertar(Obj)
    '        Return True
    '    Catch ex As DataAccessException
    '        ' Registrar error de base de datos
    '        LogError("Error en Insertar(): " & ex.Message)

    '        ' Retornar False en lugar de lanzar excepción
    '        Return False
    '    Catch ex As Exception
    '        ' Registrar cualquier otro error inesperado
    '        LogError("Error inesperado en Insertar(): " & ex.Message)

    '        ' Retornar False en caso de error inesperado
    '        Return False
    '    End Try

    'End Function





    'Public Function Actualizar(Obj As Categoria) As Boolean

    '    Try
    '        Dim Repositorio As New RepositorioCategoria
    '        Repositorio.Actualizar(Obj)
    '        Return True
    '    Catch ex As DataAccessException
    '        ' Registrar error de base de datos
    '        LogError("Error en Actualizar(): " & ex.Message)

    '        ' Retornar False en lugar de lanzar excepción
    '        Return False
    '    Catch ex As Exception
    '        ' Registrar cualquier otro error inesperado
    '        LogError("Error inesperado en Actualizar(): " & ex.Message)

    '        ' Retornar False en caso de error inesperado
    '        Return False
    '    End Try

    'End Function





    'Public Function Eliminar(Id As Integer) As Boolean

    '    Try

    '        Dim Repositorio As New RepositorioCategoria
    '        Repositorio.Eliminar(Id)
    '        Return True
    '    Catch ex As DataAccessException
    '        ' Registrar error de base de datos
    '        LogError("Error en Eliminar(): " & ex.Message)

    '        ' Retornar False en lugar de lanzar excepción
    '        Return False
    '    Catch ex As Exception
    '        ' Registrar cualquier otro error inesperado
    '        LogError("Error inesperado en Eliminar(): " & ex.Message)

    '        ' Retornar False en caso de error inesperado
    '        Return False
    '    End Try

    'End Function






    'Public Function Desactivar(Id As Integer) As Boolean

    '    Try
    '        Dim Repositorio As New RepositorioCategoria
    '        Repositorio.Desactivar(Id)
    '        Return True
    '    Catch ex As DataAccessException
    '        ' Registrar error de base de datos
    '        LogError("Error en Desactivar(): " & ex.Message)

    '        ' Retornar False en lugar de lanzar excepción
    '        Return False
    '    Catch ex As Exception
    '        ' Registrar cualquier otro error inesperado
    '        LogError("Error inesperado en Desactivar(): " & ex.Message)

    '        ' Retornar False en caso de error inesperado
    '        Return False
    '    End Try

    'End Function





    'Public Function Activar(Id As Integer) As Boolean

    '    Try
    '        Dim Repositorio As New RepositorioCategoria
    '        Repositorio.Activar(Id)
    '        Return True
    '    Catch ex As DataAccessException
    '        ' Registrar error de base de datos
    '        LogError("Error en Activar(): " & ex.Message)

    '        ' Retornar False en lugar de lanzar excepción
    '        Return False
    '    Catch ex As Exception
    '        ' Registrar cualquier otro error inesperado
    '        LogError("Error inesperado en Activar(): " & ex.Message)

    '        ' Retornar False en caso de error inesperado
    '        Return False
    '    End Try

    'End Function


    Private Sub LogError(message As String)
        File.AppendAllText("errores.log", DateTime.Now.ToString() & " - " & message & Environment.NewLine)
    End Sub

End Class
