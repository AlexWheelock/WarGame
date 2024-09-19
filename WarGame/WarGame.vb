'Alex Wheelock
'RCET 3317
'Fall 2024
'

Option Strict On
Option Explicit On
Public Class WarGame

    Dim display As New List(Of String)

    Sub NewGame(ByRef tracker() As Integer)
        tracker(0) = 13
        tracker(1) = 4
    End Sub


    Sub Play()
        Static tracker(13, 4) As Boolean
        Dim suit As Integer
        Dim card As Integer
        Dim playerCard() As Integer
        Dim opponentCard() As Integer
        Static cardsDrawn As Integer

        Do
            card = DrawCards(13)
            suit = DrawCards(4)
        Loop While tracker(card, suit)

        tracker(suit, card) = True
        cardsDrawn += 1

        UpdateDisplay(tracker())


    End Sub


    Function DrawCards(max As Integer) As Integer
        Dim value As Integer

        Randomize()

        value = CInt(Math.Floor(Rnd())) * max

        Return value
    End Function


    Sub UpdateDisplay(tracker() As Boolean)
        Dim temp(4, 13) As Boolean
        Dim suits() = {$"{Chr(6)}", $"{Chr(5)}", $"{Chr(3)}", $"{Chr(4)}"}
        Dim card As String

        temp() = tracker()


    End Sub

    '========================================================================
    'EVENT HANDLERS BELOW THIS POINT
    '========================================================================


    Private Sub WarGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click

    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub
End Class
