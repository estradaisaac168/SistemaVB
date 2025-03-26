Imports System.Data.SqlClient


Public Class Conexion
    Private _Base As String
    Private _Servidor As String
    Private _Usuario As String
    Private _Clave As String
    Private _Seguridad As Boolean = False
    Public conn As SqlConnection
    Public Property Base As String
        Get
            Return _Base
        End Get
        Set(value As String)
            _Base = value
        End Set
    End Property

    Public Property Servidor As String
        Get
            Return _Servidor
        End Get
        Set(value As String)
            _Servidor = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(value As String)
            _Usuario = value
        End Set
    End Property

    Public Property Clave As String
        Get
            Return _Clave
        End Get
        Set(value As String)
            _Clave = value
        End Set
    End Property

    Public Property Seguridad As Boolean
        Get
            Return _Seguridad
        End Get
        Set(value As Boolean)
            _Seguridad = value
        End Set
    End Property

    Public Sub New()
        Me.Base = "db_sistemas"
        'Me.Servidor = "DESKTOP-JSC6DST\SQLEXPRESS"
        Me.Servidor = "PC01548"
        Me.Usuario = "sa"
        Me.Clave = "Coco14.negrita90"
        Me.conn = New SqlConnection(CrearCadena)
    End Sub

    Public Function CrearCadena() As String
        Dim cadena As String
        cadena = "Server=" & Me.Servidor & "; Database=" & Me.Base & ";"
        If Me.Seguridad Then
            cadena = cadena & "Integrated Security= SSPI"
        Else
            cadena = cadena & "User Id=" & Me.Usuario & ";Password=" & Me.Clave
        End If
        Return cadena
    End Function
End Class


'Public Class Conexion
'    Implements IDisposable ' Implementamos IDisposable para cerrar la conexión automáticamente

'#Region "Variables de conexión"
'    Private _DataBase As String
'    Private _Servidor As String
'    Private _Usuario As String
'    Private _Clave As String
'    Private _Seguridad As Boolean = False
'    Public conn As SqlConnection
'#End Region

'#Region "Propiedades de la clase"
'    Public Property DataBase As String
'        Get
'            Return _DataBase
'        End Get
'        Set(value As String)
'            _DataBase = value
'        End Set
'    End Property

'    Public Property Servidor As String
'        Get
'            Return _Servidor
'        End Get
'        Set(value As String)
'            _Servidor = value
'        End Set
'    End Property

'    Public Property Usuario As String
'        Get
'            Return _Usuario
'        End Get
'        Set(value As String)
'            _Usuario = value
'        End Set
'    End Property

'    Public Property Clave As String
'        Get
'            Return _Clave
'        End Get
'        Set(value As String)
'            _Clave = value
'        End Set
'    End Property

'    Public Property Seguridad As Boolean
'        Get
'            Return _Seguridad
'        End Get
'        Set(value As Boolean)
'            _Seguridad = value
'        End Set
'    End Property
'#End Region

'#Region "Constructor de la clase"
'    Public Sub New()
'        Me.DataBase = "db_sistemas"
'        Me.Servidor = "DESKTOP-JSC6DST\SQLEXPRESS"
'        Me.Usuario = "sa"
'        Me.Clave = "Coco14.negrita90"
'        Me.conn = New SqlConnection(CrearCadena()) ' Creamos la conexión utilizando la cadena generada
'    End Sub
'#End Region

'#Region "Cadena de conexión que retorna un string"
'    Public Function CrearCadena() As String
'        Dim cadena As String = "Server=" & Me.Servidor & ";Database=" & Me.DataBase & ";"

'        If Me.Seguridad Then
'            cadena &= "Integrated Security=SSPI;" ' Autenticación de Windows
'        Else
'            cadena &= "User Id=" & Me.Usuario & ";Password=" & Me.Clave & ";" ' Autenticación de SQL Server
'        End If

'        Return cadena
'    End Function
'#End Region

'#Region "Métodos de conexión"
'    ' Método para abrir la conexión
'    Public Sub OpenConnection()
'        If conn.State = ConnectionState.Closed Then
'            Try
'                conn.Open()
'            Catch ex As Exception
'                ' Registrar el error de conexión
'                LogError("Error al abrir la conexión: " & ex.Message)
'                Throw New Exception("No se pudo establecer la conexión a la base de datos.")
'            End Try
'        End If
'    End Sub

'    ' Método para cerrar la conexión
'    Public Sub CloseConnection()
'        If conn.State = ConnectionState.Open Then
'            conn.Close()
'        End If
'    End Sub
'#End Region

'#Region "Método para registrar errores"
'    ' Método para registrar errores en un archivo de log
'    Private Sub LogError(message As String)
'        ' Puedes cambiar esto para registrar en una base de datos o en algún servicio de logging
'        System.IO.File.AppendAllText("errores.log", DateTime.Now.ToString() & " - " & message & Environment.NewLine)
'    End Sub
'#End Region

'#Region "Implementación de IDisposable"
'    ' Implementamos IDisposable para liberar recursos
'    Public Sub Dispose() Implements IDisposable.Dispose
'        If conn IsNot Nothing Then
'            conn.Dispose()
'        End If
'    End Sub
'#End Region
'End Class



'Public Class Conexion

'#Region "Variables conexion"
'    Private _DataBase As String
'    Private _Servidor As String
'    Private _Usuario As String
'    Private _clave As String
'    Private _Seguridad As Boolean = True
'    Public conn As SqlConnection
'#End Region


'#Region "Propiedades de la clase"
'    Public Property DataBase As String
'        Get
'            Return _DataBase
'        End Get
'        Set(value As String)
'            _DataBase = value
'        End Set
'    End Property

'    Public Property Servidor As String
'        Get
'            Return _Servidor
'        End Get
'        Set(value As String)
'            _Servidor = value
'        End Set
'    End Property

'    Public Property Usuario As String
'        Get
'            Return _Usuario
'        End Get
'        Set(value As String)
'            _Usuario = value
'        End Set
'    End Property

'    Public Property Clave As String
'        Get
'            Return _clave
'        End Get
'        Set(value As String)
'            _clave = value
'        End Set
'    End Property

'    Public Property Seguridad As Boolean
'        Get
'            Return _Seguridad
'        End Get
'        Set(value As Boolean)
'            _Seguridad = value
'        End Set
'    End Property

'#End Region


'#Region "Constructor de la clase"

'    'Declaracion de un constructor con la palabra reservada New()
'    'Asignacon a las variables locales con la Me. --> equivalente a this.
'    Public Sub New()
'        Me.DataBase = "nombre de la base de datos"
'        Me.Servidor = "Mi instancia de sql server"
'        Me.Usuario = "sa"
'        Me.Clave = "Password"
'        Me.conn = New SqlConnection(CrearCadena())

'    End Sub

'#End Region


'#Region "Cadena de coneccion que retorna un string CrearCadena()"

'    Public Function CrearCadena()
'        Dim cadena As String

'        cadena = "Server=" & Me.Servidor & ";Database=" & Me.DataBase & ";"

'        If Me.Seguridad Then
'            cadena = cadena & "Integrated Security = SSPI;"
'        Else
'            cadena = cadena & "User Id=" & Me.Usuario & ";Password=" & Me.Clave & ";"
'        End If

'        Return cadena
'    End Function
'#End Region

'End Class

