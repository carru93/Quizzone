Public Class artePage
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        arte10.Show()
        Button2.BackColor = Color.LightPink
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainPage.Show()
        Me.Hide()
    End Sub
End Class