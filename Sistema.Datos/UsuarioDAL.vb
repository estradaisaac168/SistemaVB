﻿Imports Sistema.Entidades
Imports Sistema.Exceptions
Imports System.Data.SqlClient

Public Class UsuarioDAL
    Inherits Conexion


    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader 'Declarando un objeto
            Dim Tabla As New DataTable 'Declarando un objeto e instanciandolo
            Dim Comando As New SqlCommand("usuario_listar", MyBase.conn)
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
        'Return Nothing
    End Function


    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("usuario_buscar", MyBase.conn)
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
        'Return Nothing
    End Function



    Public Function Login(Email As String, Clave As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("usuario_login", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Email
            Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Clave
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
        'Return Nothing
    End Function



    Public Sub Insertar(Obj As Usuario)
        Try
            Dim Comando As New SqlCommand("usuario_insertar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = Obj.IdRol
            Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
            Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = Obj.TipoDocumento
            Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = Obj.NumDocumento
            Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Obj.Direccion
            Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.Telefono
            Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Obj.Email
            Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Obj.Clave
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As SqlException
            Throw New DataAccessException("Error al acceder a la base de datos al intentar insertar.")
        Catch ex As Exception
            Throw New DataAccessException("Error desconocido al intentar insertar.")
        Finally
            MyBase.conn.Close()
        End Try
    End Sub



    Public Sub Actualizar(Obj As Usuario)
        Try
            Dim Comando As New SqlCommand("usuario_actualizar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Obj.IdUsuario
            Comando.Parameters.Add("@idrol", SqlDbType.Int).Value = Obj.IdRol
            Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
            Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = Obj.TipoDocumento
            Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = Obj.NumDocumento
            Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Obj.Direccion
            Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.Telefono
            Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Obj.Email
            Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Obj.Clave
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As SqlException
            Throw New DataAccessException("Error al acceder a la base de datos al intentar insertar.")
        Catch ex As Exception
            Throw New DataAccessException("Error desconocido al intentar insertar.")
        Finally
            MyBase.conn.Close()
        End Try
    End Sub

    Public Sub Eliminar(Id As Integer)
        Try
            Dim Comando As New SqlCommand("usuario_eliminar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As SqlException
            Throw New DataAccessException("Error al acceder a la base de datos al intentar eliminar.")
        Catch ex As Exception
            Throw New DataAccessException("Error desconocido al intentar eliminar.")
        Finally
            MyBase.conn.Close()
        End Try
    End Sub

    Public Sub Desactivar(Id As Integer)
        Try
            Dim Comando As New SqlCommand("usuario_desactivar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As SqlException
            Throw New DataAccessException("Error al acceder a la base de datos al intentar desactivar.")
        Catch ex As Exception
            Throw New DataAccessException("Error desconocido al intentar desactivar.")
        Finally
            MyBase.conn.Close()
        End Try
    End Sub

    Public Sub Activar(Id As Integer)
        Try
            Dim Comando As New SqlCommand("usuario_activar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As SqlException
            Throw New DataAccessException("Error al acceder a la base de datos al intentar activar.")
        Catch ex As Exception
            Throw New DataAccessException("Error desconocido al intentar activar.")
        Finally
            MyBase.conn.Close()
        End Try
    End Sub

End Class
