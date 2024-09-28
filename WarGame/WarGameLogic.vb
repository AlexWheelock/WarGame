Public Class WarGameLogic

    'Start a new game and clear the drawn cards
    Public Shared Sub NewGame(ByRef tracker(,) As Boolean)
        ReDim tracker(13, 4)
    End Sub

    'Draw a random card card
    Public Shared Function DrawCards(max As Integer) As Integer
        Dim value As Integer

        Randomize()

        value = CInt(Math.Floor(Rnd() * max))

        Return value
    End Function

End Class
