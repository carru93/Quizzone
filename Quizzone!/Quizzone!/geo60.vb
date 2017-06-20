Public Class geo60
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.BackColor = Color.Lime
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = Color.Red
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.BackColor = Color.Red
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.BackColor = Color.Red
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        geoPage.Show()
        Me.Hide()
    End Sub
End Class