Imports Sistema.Entidades
Imports Sistema.Exceptions
Imports System.Data.SqlClient

Public Class PersonaDAL
    Inherits Conexion


    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader 'Declarando un objeto
            Dim Tabla As New DataTable 'Declarando un objeto e instanciandolo
            Dim Comando As New SqlCommand("persona_listar", MyBase.conn)
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


    Public Function ListarProveedores() As DataTable
        Try
            Dim Resultado As SqlDataReader 'Declarando un objeto
            Dim Tabla As New DataTable 'Declarando un objeto e instanciandolo
            Dim Comando As New SqlCommand("persona_listar_proveedores", MyBase.conn)
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


    Public Function ListarClientes() As DataTable
        Try
            Dim Resultado As SqlDataReader 'Declarando un objeto
            Dim Tabla As New DataTable 'Declarando un objeto e instanciandolo
            Dim Comando As New SqlCommand("persona_listar_clientes", MyBase.conn)
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
            Dim Comando As New SqlCommand("persona_buscar", MyBase.conn)
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


    Public Function BuscarProveedores(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("persona_buscar_proveedores", MyBase.conn)
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



    Public Function BuscarClientes(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("persona_buscar_clientes", MyBase.conn)
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


    Public Sub Insertar(Obj As Persona)
        Try
            Dim Comando As New SqlCommand("persona_insertar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = Obj.TipoPersona
            Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
            Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = Obj.TipoDocumento
            Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = Obj.NumeroDocumento
            Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Obj.Direccion
            Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.Telefono
            Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Obj.Email
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



    Public Sub Actualizar(Obj As Persona)
        Try
            Dim Comando As New SqlCommand("persona_actualizar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idpersona", SqlDbType.Int).Value = Obj.IdPersona
            Comando.Parameters.Add("@tipo_persona", SqlDbType.VarChar).Value = Obj.TipoPersona
            Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.Nombre
            Comando.Parameters.Add("@tipo_documento", SqlDbType.VarChar).Value = Obj.TipoDocumento
            Comando.Parameters.Add("@num_documento", SqlDbType.VarChar).Value = Obj.NumeroDocumento
            Comando.Parameters.Add("@direccion", SqlDbType.VarChar).Value = Obj.Direccion
            Comando.Parameters.Add("@telefono", SqlDbType.VarChar).Value = Obj.Telefono
            Comando.Parameters.Add("@email", SqlDbType.VarChar).Value = Obj.Email
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As SqlException
            Throw New DataAccessException("Error al acceder a la base de datos al intentar actualizar.")
        Catch ex As Exception
            Throw New DataAccessException("Error desconocido al intentar actualizar.")
        Finally
            MyBase.conn.Close()
        End Try
    End Sub

    Public Sub Eliminar(Id As Integer)
        Try
            Dim Comando As New SqlCommand("persona_eliminar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idpersona", SqlDbType.Int).Value = Id
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

End Class
