Public Class MainPage
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        storiaPage.Show()
        Me.Hide()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sportPage.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ScienzePage.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        geoPage.Show()
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ingPage.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        artePage.Show()
        Me.Hide()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        spettacoloPage.Show()
        Me.Hide()
    End Sub
    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class