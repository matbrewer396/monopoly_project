Public Class FrmFirstRoll
    Public players As List(Of Player)
    Public i As Integer = 0


    Public Sub New(p As List(Of Player))
        players = p
        InitializeComponent()
        updateButton(players(i).Name)
    End Sub


    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        players(i).FirstRoll = New Roll
        DicePic1.Dice = players(i).FirstRoll.Dice1
        DicePic1.DiceType = players(i).FirstRoll.DiceType
        DicePic1.Update()
        DicePic2.Dice = players(i).FirstRoll.Dice2
        DicePic2.DiceType = players(i).FirstRoll.DiceType
        DicePic2.Update()
        i += 1
        updateButton(players(i).Name)

    End Sub

    Sub updateButton(Playername As String)
        btnRoll.Text = "Player: " & Playername & " Roll"
    End Sub
End Class