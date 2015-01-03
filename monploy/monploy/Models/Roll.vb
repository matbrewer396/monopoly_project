Public Class Roll
    Private _Dice1 As Dices
    Public Property Dice1() As Dices
        Get
            Return _Dice1
        End Get
        Set(ByVal value As Dices)
            _Dice1 = value
        End Set
    End Property

    Private _Dice2 As Dices
    Public Property Dice2() As Dices
        Get
            Return _Dice2
        End Get
        Set(ByVal value As Dices)
            _Dice2 = value
        End Set
    End Property

    Public ReadOnly Property DiceType() As DiceTypes
        Get
            If (_Dice1 = _Dice2) Then
                Return DiceTypes.DOUBL
            Else
                Return DiceTypes.NORMAL
            End If
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

    Shared Function GetImgPath(dice As Dices, diceType As DiceTypes) As String
        Select Case dice
            Case Roll.Dices.ONE
                Return app.GetReourcesFolder() & "DiceOne.png"
            Case Roll.Dices.TWO
                Return app.GetReourcesFolder() & "DiceTwo.png"
            Case Roll.Dices.THREE
                Return app.GetReourcesFolder() & "DiceThree.png"
            Case Roll.Dices.FOUR
                Return app.GetReourcesFolder() & "DiceFour.png"
            Case Roll.Dices.FIVE
                Return app.GetReourcesFolder() & "DiceFive.png"
            Case Roll.Dices.SIX
                Return app.GetReourcesFolder() & "DiceSix.png"

        End Select
    End Function

    Enum Dices
        ONE = 1
        TWO = 2
        THREE = 3
        FOUR = 4
        FIVE = 5
        SIX = 6
    End Enum
    Enum DiceTypes
        NORMAL
        DOUBL
    End Enum


End Class


