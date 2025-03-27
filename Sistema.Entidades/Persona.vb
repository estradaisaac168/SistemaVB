Public Class Persona

#Region "Atributos"
    Private _IdPersona As Integer
    Private _TipoPersona As String
    Private _Nombre As String
    Private _TipoDocumento As String
    Private _NumeroDocumento As String
    Private _Direccion As String
    Private _Telefono As String
    Private _Email As String


#End Region

#Region "Propiedades"

    Public Property IdPersona As Integer
        Get
            Return _IdPersona
        End Get
        Set(value As Integer)
            _IdPersona = value
        End Set
    End Property

    Public Property TipoPersona As String
        Get
            Return _TipoPersona
        End Get
        Set(value As String)
            _TipoPersona = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property TipoDocumento As String
        Get
            Return _TipoDocumento
        End Get
        Set(value As String)
            _TipoDocumento = value
        End Set
    End Property

    Public Property NumeroDocumento As String
        Get
            Return _NumeroDocumento
        End Get
        Set(value As String)
            _NumeroDocumento = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

#End Region
End Class
