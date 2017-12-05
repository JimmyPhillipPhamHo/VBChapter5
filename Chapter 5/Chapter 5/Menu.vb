Public Class Menu
    ' Game Application Button Clome
    Private Sub btnCoinToss_Click(sender As Object, e As EventArgs) Handles btnCoinToss.Click
        Dim Box = New CoinToss()
        Box.Show()
    End Sub

    Private Sub btnRockPaperScissors_Click(sender As Object, e As EventArgs) Handles btnRockPaperScissors.Click
        Dim Box = New RockPaperScissors()
        Box.Show()
    End Sub

    Private Sub btnRaceCarGame_Click(sender As Object, e As EventArgs) Handles btnRaceCarGame.Click
        Dim Box = New RaceCarGame()
        Box.Show()
    End Sub

    Private Sub btnRandomNumberGuessingGameEnhancement_Click(sender As Object, e As EventArgs) Handles btnRandomNumberGuessingGameEnhancement.Click
        Dim Box = New RandomNumberGuessingGameEnhancement
    End Sub

    ' Math Application

End Class