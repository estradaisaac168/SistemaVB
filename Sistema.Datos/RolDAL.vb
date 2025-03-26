Imports Sistema.Exceptions
Imports System.Data.SqlClient

Public Class RolDAL
    Inherits Conexion


    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader 'Declarando un objeto
            Dim Tabla As New DataTable 'Declarando un objeto e instanciandolo
            Dim Comando As New SqlCommand("rol_listar", MyBase.conn)
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

End Class
