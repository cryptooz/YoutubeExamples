Public Class Form1

    Dim minNumber As Integer = 1
    Dim maxNumber As Integer = 75
    Dim index As Integer = minNumber
    Dim randomarray(maxNumber) As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For i = minNumber To maxNumber
            randomarray(i) = i
        Next

        Randomize()
        Dim j As Integer
        Dim tmp As Integer

        For i = minNumber To maxNumber - 1
            j = Int((maxNumber - i + 1) * Rnd() + i)
            tmp = randomarray(i)
            randomarray(i) = randomarray(j)
            randomarray(j) = tmp
        Next

        Button2.Enabled = True
        index = minNumber
        TextBox1.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = randomarray(index)
        index = index + 1
        If index = randomarray.Count Then
            Button2.Enabled = False
        End If

    End Sub

End Class
