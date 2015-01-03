Public Class Player

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _Icon As PlayerIcon
    Public Property Icon() As PlayerIcon
        Get
            Return _Icon
        End Get
        Set(ByVal value As PlayerIcon)
            _Icon = value
        End Set
    End Property

    Private _Cash As Integer
    Public Property Cash() As Integer
        Get
            Return _Cash
        End Get
        Set(ByVal value As Integer)
            _Cash = value
        End Set
    End Property

    Private _FirstRoll As Roll
    Public Property FirstRoll() As Roll
        Get
            Return _FirstRoll
        End Get
        Set(ByVal value As Roll)
            _FirstRoll = value
        End Set
    End Property

    Private _backColour As Color
    Public Property BackColour() As Color
        Get
            Return _backColour
        End Get
        Set(ByVal value As Color)
            _backColour = value
        End Set
    End Property







    Sub New(name As String, icon As PlayerIcon)
        Me._name = name
        Me._Icon = icon
    End Sub

    Shared Function NoPlayer() As Player
        Dim p As New Player("No Player", New PlayerIcon("NoEntry", "NoEntry.jpeg"))
        p.Cash = 0
        p._backColour = Color.LightCoral
        Return p
    End Function



End Class
