'Alex Wheelock
'RCET 3317
'Fall 2024
'

Option Strict On
Option Explicit On
Public Class WarGame


    Sub NewGame(ByRef tracker(,) As Boolean)
        ReDim tracker(13, 4)
    End Sub

    Sub Play()
        Static tracker(13, 4) As Boolean
        Dim suit As Integer
        Dim card As Integer
        Dim playerCard As Integer
        Dim playerSuit As Integer
        Dim opponentCard As Integer
        Dim opponentSuit As Integer
        Static cardsDrawn As Integer
        Static yourScore As Integer
        Static opponentScore As Integer
        Dim temp As String
        Dim suits() = {$"Spades", $"Clubs", $"Hearts", $"Diamonds"}



        If cardsDrawn = 52 Then
            NewGame(tracker)
        End If

        Do
            card = DrawCards(13)
            suit = DrawCards(4)
        Loop While tracker(card, suit)

        tracker(card, suit) = True
        cardsDrawn += 1
        playerCard = card
        playersuit = suit

        Do
            card = DrawCards(13)
            suit = DrawCards(4)
        Loop While tracker(card, suit)

        tracker(card, suit) = True
        cardsDrawn += 1
        opponentCard = card
        opponentSuit = suit

        If opponentCard > playerCard Then
            opponentScore += 1
        ElseIf opponentCard = playerCard Then
        Else
            yourScore += 1
        End If

        OpponentScoreLabel.Text = CStr(opponentScore)
        PlayerScoreLabel.Text = CStr(yourScore)

        UpdateDisplay(tracker)



        DisplayListBox.Items.Add(StrDup(100, "="))
        DisplayListBox.Items.Add("")
        Select Case opponentCard
            Case 0
                temp = "A"
            Case 1
                temp = "2"
            Case 2
                temp = "3"
            Case 3
                temp = "4"
            Case 4
                temp = "5"
            Case 5
                temp = "6"
            Case 6
                temp = "7"
            Case 7
                temp = "8"
            Case 8
                temp = "9"
            Case 9
                temp = "10"
            Case 10
                temp = "J"
            Case 11
                temp = "Q"
            Case 12
                temp = "K"
        End Select
        DisplayListBox.Items.Add($"Opponent card: {temp} of {suits(opponentSuit)}")
        DisplayListBox.Items.Add("")
        DisplayListBox.Items.Add(StrDup(100, "-"))
        DisplayListBox.Items.Add("")
        Select Case playerCard
            Case 0
                temp = "A"
            Case 1
                temp = "2"
            Case 2
                temp = "3"
            Case 3
                temp = "4"
            Case 4
                temp = "5"
            Case 5
                temp = "6"
            Case 6
                temp = "7"
            Case 7
                temp = "8"
            Case 8
                temp = "9"
            Case 9
                temp = "10"
            Case 10
                temp = "J"
            Case 11
                temp = "Q"
            Case 12
                temp = "K"
        End Select
        DisplayListBox.Items.Add($"Your card: {temp} of {suits(playerSuit)}")
        DisplayListBox.Items.Add("")
        DisplayListBox.Items.Add(StrDup(100, "="))

        If cardsDrawn = 52 Then
            If opponentScore > yourScore Then
                MsgBox("All cards have been drawn, opponent wins." & vbCrLf _
                       & vbCrLf _
                       & "To continue playing, start a New game.")
            ElseIf opponentScore = yourScore Then
                MsgBox("All cards have been drawn, the game resulted in a tie." & vbCrLf _
       & vbCrLf _
       & "To continue playing, start a New game.")
            Else
                MsgBox("All cards have been drawn, you win!" & vbCrLf _
       & vbCrLf _
       & "To continue playing, start a New game.")
            End If
        End If
    End Sub


    Function DrawCards(max As Integer) As Integer
        Dim value As Integer

        Randomize()

        value = CInt(Math.Floor(Rnd() * max))

        Return value
    End Function


    Sub UpdateDisplay(ByRef tracker(,) As Boolean)
        Dim suits() = {$"S", $"C", $"H", $"D"}
        Dim card As String
        Dim temp As String
        DisplayListBox.Items.Clear()

        temp = (suits(0).PadLeft(2).PadRight(4) & suits(1).PadLeft(2).PadRight(4) & suits(2).PadLeft(2).PadRight(4) & suits(3).PadLeft(2).PadRight(4))
        DisplayListBox.Items.Add(temp.PadLeft(48))
        temp = ""

        For row = 0 To 12
            For column = 0 To 3
                If tracker(row, column) Then
                    Select Case row
                        Case 0
                            card = "A"
                        Case 1
                            card = "2"
                        Case 2
                            card = "3"
                        Case 3
                            card = "4"
                        Case 4
                            card = "5"
                        Case 5
                            card = "6"
                        Case 6
                            card = "7"
                        Case 7
                            card = "8"
                        Case 8
                            card = "9"
                        Case 9
                            card = "10"
                        Case 10
                            card = "J"
                        Case 11
                            card = "Q"
                        Case 12
                            card = "K"
                    End Select
                    If card = "10" Then
                        temp += (($" {card}|").PadLeft(3).PadRight(4))
                    Else
                        temp += (($" {card} |").PadLeft(3).PadRight(4))
                    End If
                Else
                    temp += (("   |").PadLeft(3).PadRight(4))
                End If
            Next
            DisplayListBox.Items.Add(temp.PadLeft(48))
            temp = ""
        Next
        DisplayListBox.Items.Add("")

    End Sub

    '========================================================================
    'EVENT HANDLERS BELOW THIS POINT
    '========================================================================


    Private Sub WarGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Play()
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

End Class
