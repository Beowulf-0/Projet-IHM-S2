Public Class Plateau
    Dim choice As Integer = 0
    Dim oldCard
    Dim oldValue As IntPtr
    Dim card = {My.Resources.carte0, My.Resources.carte1,
            My.Resources.carte2, My.Resources.Carte3,
            My.Resources.carte4, My.Resources.carte5,
            My.Resources.carte6, My.Resources.carte7,
            My.Resources.carte8, My.Resources.carte9}

    Dim nb = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9}

    Dim pbValue1 As Integer = -1
    Dim pbValue2 = -1
    Dim pbValue3 = -1
    Dim pbValue4 = -1
    Dim pbValue5 = -1
    Dim pbValue6 = -1
    Dim pbValue7 = -1
    Dim pbValue8 = -1
    Dim pbValue9 = -1
    Dim pbValue10 = -1
    Dim pbValue11 = -1
    Dim pbValue12 = -1
    Dim pbValue13 = -1
    Dim pbValue14 = -1
    Dim pbValue15 = -1
    Dim pbValue16 = -1
    Dim pbValue17 = -1
    Dim pbValue18 = -1
    Dim pbValue19 = -1
    Dim pbValue20 = -1



    Function retourneCarte(numCard As Integer, cardClicked As Object, pbValue As Integer) As Integer
        Dim click = 0
        If pbValue = -1 Then
            cardClicked.Image = card(nb(numCard))
            If choice = 0 And click = 0 Then
                oldCard = cardClicked
                oldValue = pbValue
                pbValue = nb(numCard)
                choice = 1
                click = 1
            End If

            If choice = 1 And click = 0 Then
                pbValue = nb(numCard)
                If pbValue <> oldValue Then
                    cardClicked.Image = My.Resources.carte
                    oldCard.Image = My.Resources.carte
                    pbValue = -1
                    oldValue = -1
                End If
                choice = 0
                click = 1
            End If
        End If
        Return pbValue
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        pbValue1 = retourneCarte(0, PictureBox1, pbValue1)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        pbValue2 = retourneCarte(1, PictureBox2, pbValue2)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        pbValue3 = retourneCarte(2, PictureBox3, pbValue3)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        pbValue4 = retourneCarte(3, PictureBox4, pbValue4)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        pbValue5 = retourneCarte(4, PictureBox5, pbValue5)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        pbValue6 = retourneCarte(5, PictureBox6, pbValue6)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        pbValue7 = retourneCarte(6, PictureBox7, pbValue7)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        pbValue8 = retourneCarte(7, PictureBox8, pbValue8)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        pbValue9 = retourneCarte(8, PictureBox9, pbValue9)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        pbValue10 = retourneCarte(9, PictureBox10, pbValue10)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        pbValue11 = retourneCarte(10, PictureBox11, pbValue11)
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        pbValue12 = retourneCarte(11, PictureBox12, pbValue12)
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        pbValue13 = retourneCarte(12, PictureBox13, pbValue13)
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        pbValue14 = retourneCarte(13, PictureBox14, pbValue14)
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        pbValue15 = retourneCarte(14, PictureBox15, pbValue15)
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        pbValue16 = retourneCarte(15, PictureBox16, pbValue16)
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        pbValue17 = retourneCarte(16, PictureBox17, pbValue17)
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        pbValue18 = retourneCarte(17, PictureBox18, pbValue18)
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        pbValue19 = retourneCarte(18, PictureBox19, pbValue19)
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        pbValue20 = retourneCarte(19, PictureBox20, pbValue20)
    End Sub
End Class
