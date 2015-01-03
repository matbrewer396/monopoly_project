Imports monploy

Module Module1

    Sub Main()

        Dim p As New Player("Matt", New PlayerIcon("car", "car.png"))
        Dim p1 As New Player("Bob", New PlayerIcon("Boat", "boat.png"))

        Dim players As New List(Of Player)

        players.Add(p)
        players.Add(p1)

        Dim b As New Board("My Game Name", players)
        b.StartGame()
    End Sub

End Module
