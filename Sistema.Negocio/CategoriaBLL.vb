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
            Dim Tabla As DataTable = Repositorio.Listar()

            If Tabla Is Nothing OrElse Tabla.Rows.Count = 0 Then
                Return New DataTable() ' DataTable vacío
            End If

            Return Tabla

        Catch ex As DataAccessException
            LogError("Error en la capa de lógica de negocio en Listar(). " & ex.Message)
            Throw New BusinessLogicException("Hubo un problema al listar las categorías. Intente nuevamente.")

        Catch ex As Exception
            LogError("Error inesperado en la capa de lógica de negocio en Listar(). " & ex.Message)
            Throw New BusinessLogicException("Error desconocido al intentar listar las categorías.")

        End Try
    End Function






    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Repositorio As New CategoriaDAL()
            Dim Tabla As DataTable = Repositorio.Buscar(Valor)
            If Tabla Is Nothing OrElse Tabla.Rows.Count = 0 Then
                Return New DataTable() ' DataTable vacío
            End If

            Return Tabla

        Catch ex As DataAccessException
            LogError("Error en la capa de lógica de negocio en Buscar(). " & ex.Message)
            Throw New BusinessLogicException("Hubo un problema al realizar la búsqueda. Intente nuevamente.")

        Catch ex As Exception
            LogError("Error inesperado en la capa de lógica de negocio en Buscar(). " & ex.Message)
            Throw New BusinessLogicException("Error desconocido al intentar realizar la búsqueda.")
        End Try
    End Function



    'Public Function Insertar(Obj As Categoria) As Boolean
    '    Try
    '        ' Crear una instancia del repositorio para manejar la inserción
    '        Dim Repositorio As New CategoriaDAL()

    '        ' Llamar al método de inserción del repositorio
    '        Repositorio.Insertar(Obj)

    '        ' Retornar True si la inserción fue exitosa
    '        Return True

    '    Catch ex As DataAccessException
    '        ' Registrar error específico de acceso a la base de datos
    '        LogError("Error en la capa de negocio en Insertar(): " & ex.Message)

    '        ' Devolver False si hubo un error en la base de datos
    '        Return False

    '    Catch ex As Exception
    '        ' Registrar cualquier otro error inesperado
    '        LogError("Error inesperado en la capa de negocio en Insertar(): " & ex.Message)

    '        ' Devolver False en caso de error inesperado
    '        Return False
    '    End Try
    'End Function



    'Public Function Actualizar(Obj As Categoria) As Boolean
    '    Try
    '        ' Crear una instancia del repositorio para manejar la actualización
    '        Dim Repositorio As New CategoriaDAL()

    '        ' Llamar al método de actualización del repositorio
    '        Repositorio.Actualizar(Obj)

    '        ' Retornar True si la actualización fue exitosa
    '        Return True

    '    Catch ex As DataAccessException
    '        ' Registrar error de acceso a la base de datos
    '        LogError("Error en la capa de negocio en Actualizar(): " & ex.Message)

    '        ' Devolver False en caso de error relacionado con la base de datos
    '        Return False

    '    Catch ex As Exception
    '        ' Registrar cualquier otro error inesperado
    '        LogError("Error inesperado en la capa de negocio en Actualizar(): " & ex.Message)

    '        ' Devolver False en caso de error inesperado
    '        Return False
    '    End Try
    'End Function




    '' Método para Eliminar
    'Public Function Eliminar(Id As Integer) As Boolean
    '    Try
    '        ' Crear una instancia del repositorio
    '        Dim Repositorio As New CategoriaDAL()

    '        ' Llamar al método Eliminar del repositorio
    '        Repositorio.Eliminar(Id)
    '        Return True

    '    Catch ex As DataAccessException
    '        ' Log del error en caso de un problema con la base de datos
    '        LogError("Error al eliminar la categoría con ID " & Id & ". " & ex.Message)

    '        ' Retornar False si ocurre un error de base de datos
    '        Return False

    '    Catch ex As Exception
    '        ' Log para otros errores inesperados
    '        LogError("Error inesperado al eliminar la categoría con ID " & Id & ". " & ex.Message)

    '        ' Retornar False si ocurre cualquier otro error inesperado
    '        Return False
    '    End Try
    'End Function





    '' Método para Desactivar
    'Public Function Desactivar(Id As Integer) As Boolean
    '    Try
    '        ' Crear una instancia del repositorio
    '        Dim Repositorio As New CategoriaDAL()

    '        ' Llamar al método Desactivar del repositorio
    '        Repositorio.Desactivar(Id)
    '        Return True

    '    Catch ex As DataAccessException
    '        ' Log del error en caso de un problema con la base de datos
    '        LogError("Error al desactivar la categoría con ID " & Id & ". " & ex.Message)

    '        ' Retornar False si ocurre un error de base de datos
    '        Return False

    '    Catch ex As Exception
    '        ' Log para otros errores inesperados
    '        LogError("Error inesperado al desactivar la categoría con ID " & Id & ". " & ex.Message)

    '        ' Retornar False si ocurre cualquier otro error inesperado
    '        Return False
    '    End Try
    'End Function




    '' Método para Activar
    'Public Function Activar(Id As Integer) As Boolean
    '    Try
    '        ' Crear una instancia del repositorio
    '        Dim Repositorio As New CategoriaDAL()

    '        ' Llamar al método Activar del repositorio
    '        Repositorio.Activar(Id)
    '        Return True

    '    Catch ex As DataAccessException
    '        ' Log del error en caso de un problema con la base de datos
    '        LogError("Error al activar la categoría con ID " & Id & ". " & ex.Message)

    '        ' Retornar False si ocurre un error de base de datos
    '        Return False

    '    Catch ex As Exception
    '        ' Log para otros errores inesperados
    '        LogError("Error inesperado al activar la categoría con ID " & Id & ". " & ex.Message)

    '        ' Retornar False si ocurre cualquier otro error inesperado
    '        Return False
    '    End Try
    'End Function





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
