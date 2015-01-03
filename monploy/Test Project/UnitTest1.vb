Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports monploy
Imports monploy.Board

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub DicesAreNotNull()

        Dim r As New Roll

        Assert.IsNotNull(r.Dice1)
        Assert.IsNotNull(r.Dice2)

    End Sub


    <TestMethod()> Public Sub BoardSetupProcess()

        Dim p As New Player("Matt", New PlayerIcon("car", "car.png"))
        Dim p1 As New Player("Bob", New PlayerIcon("Boat", "boat.png"))

        Dim players As New List(Of Player)

        players.Add(p)
        players.Add(p1)

        Dim b As New Board("My Game Name", players)


        Assert.AreEqual("My Game Name", b.Name)
        Assert.AreEqual(GameStatuses.NotStarted, b.GameStatus)
        Assert.IsNotNull(b.CreateDatetime)
        'Check Players are their
        Assert.AreEqual("Matt", b.Players(0).Name)
        Assert.AreEqual("Bob", b.Players(1).Name)
        Assert.AreEqual("No Player", b.Players(2).Name)
        Assert.AreEqual("No Player", b.Players(3).Name)
        Assert.AreEqual("No Player", b.Players(4).Name)
        Assert.AreEqual("No Player", b.Players(5).Name)

        b.StartGame()
        Assert.IsNotNull(b.StartDate)
        Assert.AreEqual(GameStatuses.Started, b.GameStatus)

        Assert.IsNotNull(b.BoardPlaces)


    End Sub

    <TestMethod()> Public Sub PhaseBoardPlace()
        Dim inp As String = "0,Go,NILL,GO,NILL,NILL,-200,NILL,NILL,NILL,NILL,NILL"
        Dim i() As String = Split(inp, ",")
        Dim bp As New BoardPlace(i)

    End Sub



End Class