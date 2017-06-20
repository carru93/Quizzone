Public Class Punteggio
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Punteggio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ProgressBar1.Maximum = Val(TextBox1.Text)
        ProgressBar2.Maximum = Val(TextBox1.Text)
        ProgressBar3.Maximum = Val(TextBox1.Text)
        ProgressBar4.Maximum = Val(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Blocca" Then
            TextBox1.Enabled = False
            Button2.Text = "Sblocca"
        Else
            TextBox1.Enabled = True
            Button2.Text = "Blocca"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Value = 0
        ProgressBar2.Value = 0
        ProgressBar3.Value = 0
        ProgressBar4.Value = 0
        Label6.Text = "0p."
        Label7.Text = "0p."
        Label8.Text = "0p."
        Label9.Text = "0p."
        NumericUpDown1.Value = 10
        NumericUpDown2.Value = 10
        NumericUpDown3.Value = 10
        NumericUpDown4.Value = 10
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ProgressBar1.Value + NumericUpDown1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value = ProgressBar1.Value + NumericUpDown1.Value
            Label6.Text = Str(ProgressBar1.Value) + "p."
        Else
            ProgressBar1.Value = ProgressBar1.Maximum
            MessageBox.Show("Hanno vinto i ROSSI!", "VITTORIA!")
            Label6.Text = Str(ProgressBar1.Maximum) + "p."
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ProgressBar2.Value + NumericUpDown2.Value < ProgressBar2.Maximum Then
            ProgressBar2.Value = ProgressBar2.Value + NumericUpDown2.Value
            Label7.Text = Str(ProgressBar2.Value) + "p."
        Else
            ProgressBar2.Value = ProgressBar2.Maximum
            MessageBox.Show("Hanno vinto i VERDI!", "VITTORIA!")
            Label7.Text = Str(ProgressBar2.Maximum) + "p."
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ProgressBar3.Value + NumericUpDown3.Value < ProgressBar3.Maximum Then
            ProgressBar3.Value = ProgressBar3.Value + NumericUpDown3.Value
            Label8.Text = Str(ProgressBar3.Value) + "p."
        Else
            ProgressBar3.Value = ProgressBar3.Maximum
            MessageBox.Show("Hanno vinto i GIALLI!", "VITTORIA!")
            Label8.Text = Str(ProgressBar3.Maximum) + "p."
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ProgressBar4.Value + NumericUpDown4.Value < ProgressBar4.Maximum Then
            ProgressBar4.Value = ProgressBar4.Value + NumericUpDown4.Value
            Label9.Text = Str(ProgressBar4.Value) + "p."
        Else
            ProgressBar4.Value = ProgressBar4.Maximum
            MessageBox.Show("Hanno vinto gli AZZURRI!", "VITTORIA!")
            Label9.Text = Str(ProgressBar4.Maximum) + "p."
        End If
    End Sub

    Private Sub ProgressBar4_Click(sender As Object, e As EventArgs) Handles ProgressBar4.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If ProgressBar1.Value - NumericUpDown1.Value > 0 Then
            ProgressBar1.Value = ProgressBar1.Value - NumericUpDown1.Value
            Label6.Text = Str(ProgressBar1.Value) + "p."
        Else
            ProgressBar1.Value = ProgressBar1.Minimum
            Label6.Text = Str(ProgressBar1.Value) + "p."
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If ProgressBar2.Value - NumericUpDown2.Value > 0 Then
            ProgressBar2.Value = ProgressBar2.Value - NumericUpDown2.Value
            Label7.Text = Str(ProgressBar2.Value) + "p."
        Else
            ProgressBar2.Value = ProgressBar2.Minimum
            Label7.Text = Str(ProgressBar2.Value) + "p."
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ProgressBar3.Value - NumericUpDown3.Value > 0 Then
            ProgressBar3.Value = ProgressBar3.Value - NumericUpDown3.Value
            Label8.Text = Str(ProgressBar3.Value) + "p."
        Else
            ProgressBar3.Value = ProgressBar3.Minimum
            Label8.Text = Str(ProgressBar3.Value) + "p."
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If ProgressBar4.Value - NumericUpDown4.Value > 0 Then
            ProgressBar4.Value = ProgressBar4.Value - NumericUpDown4.Value
            Label9.Text = Str(ProgressBar4.Value) + "p."
        Else
            ProgressBar4.Value = ProgressBar4.Minimum
            Label9.Text = Str(ProgressBar4.Value) + "p."
        End If

    End Sub
End Class