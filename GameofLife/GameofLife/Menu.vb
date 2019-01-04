Public Class Menu
    Private Sub btnGameofLife1_Click(sender As Object, e As EventArgs) Handles btnGameofLife1.Click
        Dim G1 As New GameLife1
        G1.Show()
    End Sub

    Private Sub btnGameofLife2_Click(sender As Object, e As EventArgs) Handles btnGameofLife2.Click
        'Dim G2 As New Game2
        'Dim CG2 As New ConfGame2
        G2 = New Game2
        CG2 = New ConfGame2
        G2.Show()
        CG2.Show()
    End Sub

End Class