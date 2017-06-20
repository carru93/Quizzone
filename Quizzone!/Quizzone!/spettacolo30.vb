Public Class spettacolo30
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Cominciamo!", "Bonus sette nani")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        spettacoloPage.Show()
        Me.Hide()
    End Sub
End Class