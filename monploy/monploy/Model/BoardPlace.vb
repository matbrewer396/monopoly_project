Public Class BoardPlace

#Region "Imported Property"
    'Phase array
    Sub New(i As String())

    End Sub

    Private _Position As Integer
    Public Property Position() As Integer
        Get
            Return _Position
        End Get
        Set(ByVal value As Integer)
            _Position = value
        End Set
    End Property

    Private _SlotName As String
    Public Property SlotName() As String
        Get
            Return _SlotName
        End Get
        Set(ByVal value As String)
            _SlotName = value
        End Set
    End Property

    Private _Grouping As Groups
    Public Property Grouping() As Groups
        Get
            Return _Grouping
        End Get
        Set(ByVal value As Groups)
            _Grouping = value
        End Set
    End Property

    Private _PlaceType As PlaceTypes
    Public Property PlaceType() As PlaceTypes
        Get
            Return _PlaceType
        End Get
        Set(ByVal value As PlaceTypes)
            _PlaceType = value
        End Set
    End Property

    Private _Cost As Integer
    Public Property Cost() As Integer
        Get
            Return _Cost
        End Get
        Set(ByVal value As Integer)
            _Cost = value
        End Set
    End Property

    Private _CostHouse As Integer
    Public Property CostHouse() As Integer
        Get
            Return _CostHouse
        End Get
        Set(ByVal value As Integer)
            _CostHouse = value
        End Set
    End Property

    Private _CostHotel As Integer
    Public Property CostHotel() As Integer
        Get
            Return _CostHouse
        End Get
        Set(ByVal value As Integer)
            _CostHouse = value
        End Set
    End Property

    Private _RentWithNoHouse As Integer
    Public Property RentWithNoHouse() As Integer
        Get
            Return _RentWithNoHouse
        End Get
        Set(ByVal value As Integer)
            _RentWithNoHouse = value
        End Set
    End Property

    Private _RentWith1House As Integer
    Public Property RentWith1House() As Integer
        Get
            Return _RentWith1House
        End Get
        Set(ByVal value As Integer)
            _RentWith1House = value
        End Set
    End Property

    Private _RentWith2House As Integer
    Public Property RentWith2House() As Integer
        Get
            Return _RentWith2House
        End Get
        Set(ByVal value As Integer)
            _RentWith2House = value
        End Set
    End Property

    Private _RentWith3House As Integer
    Public Property RentWith3House() As Integer
        Get
            Return _RentWith3House
        End Get
        Set(ByVal value As Integer)
            _RentWith3House = value
        End Set
    End Property

    Private _RentWith4House As Integer
    Public Property RentWith4House() As Integer
        Get
            Return _RentWith4House
        End Get
        Set(ByVal value As Integer)
            _RentWith4House = value
        End Set
    End Property

    Private _RentWithHotel As Integer
    Public Property RentWithHotel() As Integer
        Get
            Return _RentWithHotel
        End Get
        Set(ByVal value As Integer)
            _RentWithHotel = value
        End Set
    End Property



#End Region

#Region "Property"

    Private _BuildLevel As PlaceBuildLevels = PlaceBuildLevels.WithNoHouse
    Public Property BuildLevel() As PlaceBuildLevels
        Get
            Return _BuildLevel
        End Get
        Set(ByVal value As PlaceBuildLevels)
            _BuildLevel = value
        End Set
    End Property


    Public ReadOnly Property CostToUpgrade() As Integer
        Get
            Select Case _BuildLevel
                Case PlaceBuildLevels.WithHotel
                    Return 0
                Case PlaceBuildLevels.Whit4House
                    Return CostHotel
                Case Else
                    Return CostHouse
            End Select
        End Get
    End Property

    Public ReadOnly Property RefundOnDegrade() As Integer
        Get
            Select Case _BuildLevel
                Case PlaceBuildLevels.WithHotel
                    Return CostHotel
                Case PlaceBuildLevels.Whit4House
                    Return CostHouse
                Case Else
                    Return 0
            End Select
        End Get
    End Property

#End Region




    Enum PlaceBuildLevels
        WithNoHouse
        With1House
        With2House
        With3House
        Whit4House
        WithHotel
    End Enum


    Enum Groups
        NILL
        GREEN
        BLUE
        BROWN
        STATION
    End Enum

    Enum PlaceTypes
        STANDARD
        GO
        STATION
        UTITLES
    End Enum



End Class
