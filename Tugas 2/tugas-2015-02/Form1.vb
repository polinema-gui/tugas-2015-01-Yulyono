Public Class Form1
    Dim op, Txtnum1, Txtnum2 As String
    Dim num1, num2 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If op = "" Then
            Txtnum1 &= "1"
            TxtIsi.Text = Txtnum1
        Else : Txtnum2 &= "1"
            TxtIsi.Text = Txtnum2
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If op = "" Then
            Txtnum1 &= "0"
            TxtIsi.Text = Txtnum1
        Else : Txtnum2 &= "0"
            TxtIsi.Text = Txtnum2
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If op = "" Then
            Txtnum1 &= "2"
            TxtIsi.Text = Txtnum1
        Else : Txtnum2 &= "2"
            TxtIsi.Text = Txtnum1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If op = "" Then
            Txtnum1 &= "3"
            TxtIsi.Text = Txtnum1
        Else : Txtnum2 &= "3"
            TxtIsi.Text = Txtnum2
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If op = "" Then
            Txtnum1 &= "4"
            TxtIsi.Text = Txtnum1
        Else : Txtnum2 &= "4"
            TxtIsi.Text = Txtnum2
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If op = "" Then
            Txtnum1 &= "5"
            TxtIsi.Text = Txtnum1
        Else : Txtnum2 &= "5"
            TxtIsi.Text = Txtnum2
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If op = "" Then
            Txtnum1 &= "6"
            TxtIsi.Text = Txtnum1
        Else : Txtnum2 &= "6"
            TxtIsi.Text = Txtnum2
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If op = "" Then
            Txtnum1 &= "7"
            TxtIsi.Text = Txtnum1
        Else : Txtnum2 &= "7"
            TxtIsi.Text = Txtnum2
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If op = "" Then
            Txtnum1 &= "8"
            TxtIsi.Text = Txtnum1
        Else : Txtnum2 &= "8"
            TxtIsi.Text = Txtnum2
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If op = "" Then
            Txtnum1 &= "9"
            TxtIsi.Text = Txtnum1
        Else : Txtnum2 &= "9"
            TxtIsi.Text = Txtnum2
        End If
    End Sub

    Private Sub PenjumlahanButton_Click(sender As Object, e As EventArgs) Handles PenjumlahanButton.Click
        op = "+"
    End Sub

    Private Sub PenguranganButton_Click(sender As Object, e As EventArgs) Handles PenguranganButton.Click
        op = "-"
    End Sub

    Private Sub HasilButton_Click(sender As Object, e As EventArgs) Handles HasilButton.Click
        num1 = Txtnum1
        num2 = Txtnum2
        If op = "+" Then
            TxtIsi.Text = num1 + num2
        ElseIf op = "-" Then
            TxtIsi.Text = num1 - num2
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        op = ""
        Txtnum1 = ""
        Txtnum2 = ""
        TxtIsi.Text = ""
    End Sub
End Class
