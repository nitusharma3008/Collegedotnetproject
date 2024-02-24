Public Class EvenOdd
    Private Sub btnclick_Click(sender As Object, e As EventArgs) Handles btnclick.Click
        Dim n As Integer = TextBox1.Text
        If n Mod 2 = 0 Then
            lblans.Text = n & "  is even"
        Else
            lblans.Text = n & "  is odd"
        End If

    End Sub
End Class