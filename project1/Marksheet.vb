Public Class Marksheet

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Dim n, s1, s2, s3, s4, s5, total As Integer
        n = txtno.Text
        Dim name As String = txtname.Text
        s1 = txtsub1.Text
        s2 = txtsub2.Text
        s3 = txtsub3.Text
        s4 = txtsub4.Text
        s5 = txtsub5.Text
        Dim per As Double
        total = 0


        If txtno.Text = "" Then

            MsgBox("Please enter Roll no")
        Else
            Try

                total = s1 + s2 + s3 + s4 + s5
                per = total / 5
                lblno.Text = "Roll No: " & n
                lblname.Text = "Name : " + name
                lbltotal.Text = "Total Marks :" & total
                lblper.Text = "Percentage :" & per & "%"

                If per >= 70 Then
                    lblresult.Text = "Result : Distinction "
                ElseIf per >= 60 Then
                    lblresult.Text = "Result : First Class "
                ElseIf per >= 50 Then
                    lblresult.Text = "Result : Second Class "
                ElseIf per >= 40 Then
                    lblresult.Text = "Result : Pass Class "
                Else
                    lblresult.Text = "Result : Fail "
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub
End Class