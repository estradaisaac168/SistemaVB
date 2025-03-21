Imports Sistema.Exceptions
Imports Sistema.Entidades
Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.InteropServices


'Clase de acceso a Datos --> Capa de acceso a Datos
Public Class CategoriaDAL
    Inherits Conexion


    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("categoria_listar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw New DataAccessException("Error al acceder a la base de datos: ")

        Finally
            MyBase.conn.Close()
        End Try
    End Function




    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("categoria_buscar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor
            MyBase.conn.Open()
            Resultado = Comando.ExecuteReader()
            Tabla.Load(Resultado)
            MyBase.conn.Close()
            Return Tabla
        Catch ex As Exception
            Throw New DataAccessException("Error al acceder a la base de datos: ")
        Finally
            MyBase.conn.Close()
        End Try
    End Function


    'Public Function Buscar(Valor As String) As DataTable
    '    Dim Tabla As New DataTable

    '    Try
    '        OpenConnection() ' Abre la conexión
    '        Using comando As New SqlCommand("categoria_buscar", conn)
    '            comando.CommandType = CommandType.StoredProcedure
    '            comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor
    '            Using reader As SqlDataReader = comando.ExecuteReader()
    '                Tabla.Load(reader)
    '            End Using
    '        End Using
    '        Return Tabla
    '    Catch ex As Exception
    '        LogError("Error en Listar(): " & ex.Message)
    '        Throw New DataAccessException("Error al acceder a la base de datos: ")
    '    Finally
    '        CloseConnection() ' Cierra la conexión
    '    End Try
    'End Function




    'Public Sub Insertar(Obj As Categoria)
    '    Try
    '        ' Abrir la conexión usando la función OpenConnection() de la clase base
    '        OpenConnection()

    '        ' Usar Using para asegurar que el SqlCommand se disponga correctamente
    '        Using Comando As New SqlCommand("categoria_insertar", conn)
    '            Comando.CommandType = CommandType.StoredProcedure

    '            ' Agregar los parámetros al comando
    '            Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
    '            Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion

    '            ' Ejecutar el comando
    '            Comando.ExecuteNonQuery()
    '        End Using ' El comando se dispone automáticamente aquí

    '    Catch ex As SqlException
    '        ' Log del error SQL con información relevante
    '        LogError("Error al insertar en la base de datos. Procedimiento: categoria_insertar. " & ex.Message)

    '        ' Relanzar el error para que la capa superior lo maneje
    '        Throw New DataAccessException("Error al acceder a la base de datos al intentar insertar.")
    '    Catch ex As Exception
    '        ' Log para cualquier otro error inesperado
    '        LogError("Error inesperado al insertar en la base de datos: " & ex.Message)

    '        ' Relanzar la excepción
    '        Throw New DataAccessException("Error desconocido al intentar insertar.")
    '    Finally
    '        ' Asegurarse de que la conexión se cierre, en caso de que no se haya cerrado antes
    '        CloseConnection()
    '    End Try
    'End Sub





    'Public Sub Actualizar(Obj As Categoria)
    '    Try
    '        OpenConnection()

    '        ' Usar Using para el SqlCommand
    '        Using Comando As New SqlCommand("categoria_actualizar", conn)
    '            Comando.CommandType = CommandType.StoredProcedure

    '            ' Agregar los parámetros al comando
    '            Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.IdCategoria
    '            Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
    '            Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion

    '            ' Ejecutar el comando
    '            Comando.ExecuteNonQuery()
    '        End Using ' El comando se dispone automáticamente aquí

    '    Catch ex As SqlException
    '        ' Log del error SQL con información relevante
    '        LogError("Error al actualizar en la base de datos. Procedimiento: categoria_actualizar. " & ex.Message)

    '        ' Relanzar el error para que lo maneje la capa superior
    '        Throw New DataAccessException("Error al acceder a la base de datos al intentar actualizar.")
    '    Catch ex As Exception
    '        ' Log para cualquier otro error inesperado
    '        LogError("Error inesperado al actualizar en la base de datos: " & ex.Message)

    '        ' Relanzar la excepción
    '        Throw New DataAccessException("Error desconocido al intentar actualizar.")
    '    Finally
    '        ' Asegurarse de que la conexión se cierre si fue abierta
    '        CloseConnection()
    '    End Try
    'End Sub


    'Public Sub Eliminar(Id As Integer)
    '    Try
    '        ' Usar la conexión heredada desde la clase base
    '        OpenConnection()

    '        ' Usar Using para el SqlCommand
    '        Using Comando As New SqlCommand("categoria_eliminar", conn)
    '            Comando.CommandType = CommandType.StoredProcedure
    '            Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id

    '            ' Ejecutar el comando
    '            Comando.ExecuteNonQuery()
    '        End Using ' El comando se dispone automáticamente aquí

    '    Catch ex As SqlException
    '        ' Log del error SQL con información relevante
    '        LogError("Error al eliminar en la base de datos. Procedimiento: categoria_eliminar. " & ex.Message)

    '        ' Relanzar el error para que lo maneje la capa superior
    '        Throw New DataAccessException("Error al acceder a la base de datos al intentar eliminar.")
    '    Catch ex As Exception
    '        ' Log para cualquier otro error inesperado
    '        LogError("Error inesperado al eliminar en la base de datos: " & ex.Message)

    '        ' Relanzar la excepción
    '        Throw New DataAccessException("Error desconocido al intentar eliminar.")
    '    Finally
    '        ' Asegurarse de que la conexión se cierre si fue abierta
    '        CloseConnection()
    '    End Try
    'End Sub

    'Public Sub Desactivar(Id As Integer)
    '    Try
    '        ' Usar la conexión heredada desde la clase base
    '        OpenConnection()

    '        ' Usar Using para el SqlCommand
    '        Using Comando As New SqlCommand("categoria_desactivar", conn)
    '            Comando.CommandType = CommandType.StoredProcedure
    '            Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id

    '            ' Ejecutar el comando
    '            Comando.ExecuteNonQuery()
    '        End Using ' El comando se dispone automáticamente aquí

    '    Catch ex As SqlException
    '        ' Log del error SQL con información relevante
    '        LogError("Error al desactivar en la base de datos. Procedimiento: categoria_desactivar. " & ex.Message)

    '        ' Relanzar el error para que lo maneje la capa superior
    '        Throw New DataAccessException("Error al acceder a la base de datos al intentar desactivar.")
    '    Catch ex As Exception
    '        ' Log para cualquier otro error inesperado
    '        LogError("Error inesperado al desactivar en la base de datos: " & ex.Message)

    '        ' Relanzar la excepción
    '        Throw New DataAccessException("Error desconocido al intentar desactivar.")
    '    Finally
    '        ' Asegurarse de que la conexión se cierre si fue abierta
    '        CloseConnection()
    '    End Try
    'End Sub

    'Public Sub Activar(Id As Integer)
    '    Try
    '        ' Usar la conexión heredada desde la clase base
    '        OpenConnection()

    '        ' Usar Using para el SqlCommand
    '        Using Comando As New SqlCommand("categoria_activar", conn)
    '            Comando.CommandType = CommandType.StoredProcedure
    '            Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id

    '            ' Ejecutar el comando
    '            Comando.ExecuteNonQuery()
    '        End Using ' El comando se dispone automáticamente aquí

    '    Catch ex As SqlException
    '        ' Log del error SQL con información relevante
    '        LogError("Error al activar en la base de datos. Procedimiento: categoria_activar. " & ex.Message)

    '        ' Relanzar el error para que lo maneje la capa superior
    '        Throw New DataAccessException("Error al acceder a la base de datos al intentar activar.")
    '    Catch ex As Exception
    '        ' Log para cualquier otro error inesperado
    '        LogError("Error inesperado al activar en la base de datos: " & ex.Message)

    '        ' Relanzar la excepción
    '        Throw New DataAccessException("Error desconocido al intentar activar.")
    '    Finally
    '        ' Asegurarse de que la conexión se cierre si fue abierta
    '        CloseConnection()
    '    End Try
    'End Sub



    '' Método para registrar errores en un archivo
    'Private Sub LogError(message As String)
    '    File.AppendAllText("errores.log", DateTime.Now.ToString() & " - " & message & Environment.NewLine)
    'End Sub





    'Public Function Buscar(Valor As String) As DataTable

    '    Try
    '        Dim Resultado As SqlDataReader
    '        Dim Tabla As New DataTable
    '        Dim Comando As New SqlCommand("categoria_buscar", MyBase.conn)
    '        Comando.CommandType = CommandType.StoredProcedure
    '        Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor
    '        MyBase.conn.Open()
    '        Resultado = Comando.ExecuteReader()
    '        Tabla.Load(Resultado)
    '        MyBase.conn.Close()
    '        Return Tabla
    '    Catch ex As Exception
    '        ' Log del error
    '        LogError("Error en Listar(): " & ex.Message)

    '        ' Relanzar el error para que lo maneje la capa superior
    '        Throw New DataAccessException("Error al acceder a la base de datos: ")
    '    End Try

    'End Function

    'Public Function Listar() As DataTable

    '    Try
    '        Dim Resultado As SqlDataReader
    '        Dim Tabla As New DataTable
    '        Dim Comando As New SqlCommand("categoria_listar", MyBase.conn)
    '        Comando.CommandType = CommandType.StoredProcedure
    '        MyBase.conn.Open()
    '        Resultado = Comando.ExecuteReader()
    '        Tabla.Load(Resultado)
    '        MyBase.conn.Close()
    '        Return Tabla

    '    Catch ex As Exception
    '        ' Log del error
    '        LogError("Error en Listar(): " & ex.Message)

    '        ' Relanzar el error para que lo maneje la capa superior
    '        Throw New DataAccessException("Error al acceder a la base de datos: ")
    '    End Try

    'End Function

    ' Método para listar las categorías

    'Public Sub Insertar(Obj As Categoria)

    '    Try

    '        Dim Comando As New SqlCommand("categoria_insertar", MyBase.conn)
    '        Comando.CommandType = CommandType.StoredProcedure
    '        Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
    '        Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion
    '        MyBase.conn.Open()
    '        Comando.ExecuteNonQuery()
    '        MyBase.conn.Close()
    '    Catch ex As Exception
    '        ' Log del error
    '        LogError("Error en Listar(): " & ex.Message)

    '        ' Relanzar el error para que lo maneje la capa superior
    '        Throw New DataAccessException("Error al acceder a la base de datos: ")
    '    End Try

    'End Sub



    'Public Sub Actualizar(Obj As Categoria)

    '    Try

    '        Dim Comando As New SqlCommand("categoria_actualizar", MyBase.conn)
    '        Comando.CommandType = CommandType.StoredProcedure
    '        Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Obj.IdCategoria
    '        Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
    '        Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion
    '        MyBase.conn.Open()
    '        Comando.ExecuteNonQuery()
    '        MyBase.conn.Close()
    '    Catch ex As Exception
    '        ' Log del error
    '        LogError("Error en Listar(): " & ex.Message)

    '        ' Relanzar el error para que lo maneje la capa superior
    '        Throw New DataAccessException("Error al acceder a la base de datos: ")
    '    End Try

    'End Sub


    'Public Sub Eliminar(Id As Integer)

    '    Try

    '        Dim Comando As New SqlCommand("categoria_eliminar", MyBase.conn)
    '        Comando.CommandType = CommandType.StoredProcedure
    '        Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id
    '        MyBase.conn.Open()
    '        Comando.ExecuteNonQuery()
    '        MyBase.conn.Close()
    '    Catch ex As Exception
    '        ' Log del error
    '        LogError("Error en Listar(): " & ex.Message)

    '        ' Relanzar el error para que lo maneje la capa superior
    '        Throw New DataAccessException("Error al acceder a la base de datos: ")
    '    End Try

    'End Sub





    'Public Sub Desactivar(Id As Integer)

    '    Try

    '        Dim Comando As New SqlCommand("categoria_desactivar", MyBase.conn)
    '        Comando.CommandType = CommandType.StoredProcedure
    '        Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id
    '        MyBase.conn.Open()
    '        Comando.ExecuteNonQuery()
    '        MyBase.conn.Close()
    '    Catch ex As Exception
    '        ' Log del error
    '        LogError("Error en Listar(): " & ex.Message)

    '        ' Relanzar el error para que lo maneje la capa superior
    '        Throw New DataAccessException("Error al acceder a la base de datos: ")
    '    End Try

    'End Sub





    'Public Sub Activar(Id As Integer)

    '    Try

    '        Dim Comando As New SqlCommand("categoria_activar", MyBase.conn)
    '        Comando.CommandType = CommandType.StoredProcedure
    '        Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = Id
    '        MyBase.conn.Open()
    '        Comando.ExecuteNonQuery()
    '        MyBase.conn.Close()
    '    Catch ex As Exception
    '        ' Log del error
    '        LogError("Error en Listar(): " & ex.Message)

    '        ' Relanzar el error para que lo maneje la capa superior
    '        Throw New DataAccessException("Error al acceder a la base de datos: ")
    '    End Try

    'End Sub


End Class
