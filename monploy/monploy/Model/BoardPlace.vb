Public Class BoardPlace
    Private _PlaceNumber As Integer
    Public Property PlaceNumber() As Integer
        Get
            Return _PlaceNumber
        End Get
        Set(ByVal value As Integer)
            _PlaceNumber = value
        End Set
    End Property

    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property




End Class
