Public Class Move
    Sub New(r As Roll, p As Player)

    End Sub


    Sub procesMove()

    End Sub

    Private _boardPlace_OLD As BoardPlace
    Public Property boardPlace_OLD() As BoardPlace
        Get
            Return _boardPlace_OLD
        End Get
        Set(ByVal value As BoardPlace)
            _boardPlace_OLD = value
        End Set
    End Property

    Private _boardPlace_NEW As BoardPlace
    Public Property boardPlace_NEW() As BoardPlace
        Get
            Return _boardPlace_NEW
        End Get
        Set(ByVal value As BoardPlace)
            _boardPlace_NEW = value
        End Set
    End Property

End Class
