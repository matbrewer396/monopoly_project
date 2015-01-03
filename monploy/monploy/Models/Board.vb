Public Class Board

#Region "Property"



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
            Dim i As Integer = value.Count
            _players = value
            Do While i < 6
                _players.Add(Player.NoPlayer)
                i += 1
            Loop
        End Set
    End Property

    Private _GameStatus As GameStatuses
    Public Property GameStatus() As GameStatuses
        Get
            Return _GameStatus
        End Get
        Set(ByVal value As GameStatuses)
            _GameStatus = value

            'Update Time Stamps
            Select Case value
                Case GameStatuses.NotStarted
                    _CreateDatetime = Now()
                Case GameStatuses.Started
                    _StartDatetime = Now()
            End Select
        End Set
    End Property

    Private _CreateDatetime As DateTime
    Public ReadOnly Property CreateDatetime() As DateTime
        Get
            Return _StartDatetime
        End Get
    End Property

    Private _StartDatetime As DateTime
    Public ReadOnly Property StartDate() As DateTime
        Get
            Return _StartDatetime
        End Get
    End Property

#End Region

    Sub New(name As String, players As List(Of Player))
        Me.GameStatus = GameStatuses.NotStarted
        Me.Players = players
    End Sub

    Sub StartGame()
        Me.GameStatus = GameStatuses.Started
        Me.loadBoardPlaces()

    End Sub



    Sub loadBoardPlaces()

        Dim sr As New IO.StreamReader("C:\Users\matt\git\monopoly_project\monploy\monploy\resources\BoardPlaces.txt")
        Do While sr.ReadToEnd
            Dim l As String = sr.ReadLine
            Dim bp As New BoardPlace(l.Split(","))
            BoardPlaces.Add(bp)
        Loop

    End Sub


    Enum GameStatuses
        NotStarted
        Started
        AwaitngPlayer
        Process
    End Enum

End Class


