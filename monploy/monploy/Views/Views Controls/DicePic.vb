﻿Public Class DicePic

    Private _dice As Roll.Dices
    Public Property Dice() As Roll.Dices
        Get
            Return _dice
        End Get
        Set(ByVal value As Roll.Dices)
            _dice = value
        End Set
    End Property

    Private _DiceType As Roll.DiceTypes
    Public Property DiceType() As Roll.DiceTypes
        Get
            Return _DiceType
        End Get
        Set(ByVal value As Roll.DiceTypes)
            _DiceType = value
        End Set
    End Property
    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updatePic()
    End Sub

    Sub updatePic()
        picDiceImage.ImageLocation = Roll.GetImgPath(_dice, _DiceType)
        picDiceImage.Load()
    End Sub


End Class
