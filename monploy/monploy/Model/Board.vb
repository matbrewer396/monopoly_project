Public Class Board

    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    Private _BoardPlaces As List(Of BoardPlace)
    Public Property BoardPlaces() As List(Of BoardPlace)
        Get
            Return _BoardPlaces
        End Get
        Set(ByVal value As List(Of BoardPlace))
            _BoardPlaces = value
        End Set
    End Property

    Private _players As List(Of Player)
    Public Property Players() As List(Of Player)
        Get
            Return _players
        End Get
        Set(ByVal value As List(Of Player))
            _players = value
        End Set
    End Property


    Sub New(name As String)


    End Sub




End Class
