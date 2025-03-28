Imports Sistema.Datos
Imports Sistema.Entidades
Imports Sistema.Exceptions

Public Class IngresoBLL


    Public Function Listar() As DataTable
        Try

            Dim Datos As New IngresoDAL()
            Dim Tabla As New DataTable
            Tabla = Datos.Listar()
            Return Tabla

        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al listar las categorías. Intente nuevamente." & ex.Message)

        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al intentar listar las categorías.")

        End Try
        Return Nothing
    End Function



    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Datos As New IngresoDAL()
            Dim Tabla As New DataTable
            Tabla = Datos.Buscar(Valor)
            Return Tabla

        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al realizar la búsqueda. Intente nuevamente.")

        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al intentar realizar la búsqueda.")
        End Try
        Return Nothing
    End Function


    Public Function Insertar(Obj As Ingreso, Detalle As DataTable) As Boolean

        Dim Inserted = False

        Try
            ' Crear una instancia del repositorio para manejar la inserción
            Dim Datos As New IngresoDAL()

            ' Llamar al método de inserción del repositorio
            Datos.Insertar(Obj, Detalle)
            Inserted = True

            ' Retornar True si la inserción fue exitosa
            Return Inserted

        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al guardar el ingreso. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Error desconocido al guardar el ingreso." & ex.Message)
        End Try

        Return Inserted
    End Function


    Public Function Anular(Id As Integer) As Boolean

        Dim Activated = False
        Try
            ' Crear una instancia del repositorio
            Dim Datos As New IngresoDAL()

            ' Llamar al método Desactivar del repositorio
            Datos.Anular(Id)
            Activated = True
            Return Activated

        Catch ex As DataAccessException
            Throw New BusinessLogicException("Hubo un problema al anular el ingreso. Intente nuevamente." & ex.Message)
        Catch ex As Exception
            Throw New BusinessLogicException("Hubo un problema al anular el ingreso. Intente nuevamente." & ex.Message)
        End Try
        Return Activated

    End Function
End Class
