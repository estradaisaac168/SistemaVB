Imports Sistema.Entidades
Imports Sistema.Exceptions
Imports System.Data.SqlClient

Public Class IngresoDAL
    Inherits Conexion


    Public Function Listar() As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("ingreso_listar", MyBase.conn)
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
        Return Nothing
    End Function




    Public Function Buscar(Valor As String) As DataTable
        Try
            Dim Resultado As SqlDataReader
            Dim Tabla As New DataTable
            Dim Comando As New SqlCommand("ingreso_buscar", MyBase.conn)
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
        Return Nothing
    End Function



    Public Sub Insertar(Obj As Ingreso, Detalle As DataTable)

        Try

            Dim Comando As New SqlCommand("ingreso_insertar", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idingreso", SqlDbType.VarChar).Value = Obj.IdIngreso
            Comando.Parameters("@idingreso").Direction = ParameterDirection.Output
            Comando.Parameters.Add("@idproveedor", SqlDbType.Int).Value = Obj.IdProveedor
            Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Obj.IdUsuario
            Comando.Parameters.Add("@tipo_comprobante", SqlDbType.VarChar).Value = Obj.TipoComprobante
            Comando.Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = Obj.SerieComprobante
            Comando.Parameters.Add("@num_comprobante", SqlDbType.VarChar).Value = Obj.NumeroComprobante
            Comando.Parameters.Add("@inpuesto", SqlDbType.Decimal).Value = Obj.Impuesto
            Comando.Parameters.Add("@total", SqlDbType.Decimal).Value = Obj.Total
            Comando.Parameters.Add("@detalle", SqlDbType.Structured).Value = Detalle


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


    Public Sub Anular(Id As Integer)

        Try

            Dim Comando As New SqlCommand("ingreso_anular", MyBase.conn)
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.Add("@idingreso", SqlDbType.Int).Value = Id
            MyBase.conn.Open()
            Comando.ExecuteNonQuery()
            MyBase.conn.Close()
        Catch ex As Exception
            Throw New DataAccessException("Error al acceder a la base de datos: ")
        Finally
            MyBase.conn.Close()
        End Try

    End Sub
End Class
