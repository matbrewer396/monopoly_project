Public Class Roll
    Private _Dice1 As String
    Public Property Dice1() As String
        Get
            Return _Dice1
        End Get
        Set(ByVal value As String)
            _Dice1 = value
        End Set
    End Property

    Private _Dice2 As String
    Public Property Dice2() As String
        Get
            Return _Dice2
        End Get
        Set(ByVal value As String)
            _Dice2 = value
        End Set
    End Property

    Function rollTotal() As Integer

    End Function


End Class
