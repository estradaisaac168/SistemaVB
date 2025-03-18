Imports System.Data.SqlClient

Public Class Conexion

#Region "Variables conexion"
    Private _DataBase As String
    Private _Servidor As String
    Private _Usuario As String
    Private _clave As String
    Private _Seguridad As Boolean = True
    Public conn As SqlConnection
#End Region


#Region "Propiedades de la clase"
    Public Property DataBase As String
        Get
            Return _DataBase
        End Get
        Set(value As String)
            _DataBase = value
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
            Return _clave
        End Get
        Set(value As String)
            _clave = value
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

#End Region


#Region "Constructor de la clase"

    'Declaracion de un constructor con la palabra reservada New()
    'Asignacon a las variables locales con la Me. --> equivalente a this.
    Public Sub New()
        Me.DataBase = "nombre de la base de datos"
        Me.Servidor = "Mi instancia de sql server"
        Me.Usuario = "sa"
        Me.Clave = "Password"
        Me.conn = New SqlConnection(CrearCadena())

    End Sub

#End Region


#Region "Cadena de coneccion que retorna un string CrearCadena()"

    Public Function CrearCadena()
        Dim cadena As String

        cadena = "Server=" & Me.Servidor & ";Database=" & Me.DataBase & ";"

        If Me.Seguridad Then
            cadena = cadena & "Integrated Security = SSPI;"
        Else
            cadena = cadena & "User Id=" & Me.Usuario & ";Password=" & Me.Clave & ";"
        End If

        Return cadena
    End Function
#End Region

End Class

