Public Class Roll
    Private _Dice1 As String
    Public Property Dice1() As Integer
        Get
            Return _Dice1
        End Get
        Set(ByVal value As Integer)
            _Dice1 = value
        End Set
    End Property

    Private _Dice2 As Integer
    Public Property Dice2() As Integer
        Get
            Return _Dice2
        End Get
        Set(ByVal value As Integer)
            _Dice2 = value
        End Set
    End Property

    Public ReadOnly Property isDouble() As Boolean
        Get
            Return (_Dice1 = _Dice2)
        End Get
    End Property

    Private Function DiceRoll() As Integer
        Randomize()
        Dim SngChoice As Single
        SngChoice = Rnd()
        SngChoice = SngChoice * 6
        Return Math.Round(SngChoice)
    End Function
    Function rollTotal() As Integer
        Dim Dicetotal As Integer
        Dicetotal = _Dice1 + _Dice2
        Return Dicetotal
    End Function

    Sub New()
        _Dice1 = DiceRoll()
        _Dice2 = DiceRoll()
    End Sub


End Class
