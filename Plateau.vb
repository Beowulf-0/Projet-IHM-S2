Public Class Plateau
    Dim choice As Integer = 0
    Dim oldCard As Object
    Dim oldValue As Integer
    Dim numCardSaved As Integer
    Dim cardClickedSaved As Object
    Dim check As Integer = 1
    Dim card = {My.Resources.carte0, My.Resources.carte1,
            My.Resources.carte2, My.Resources.Carte3,
            My.Resources.carte4, My.Resources.carte5,
            My.Resources.carte6, My.Resources.carte7,
            My.Resources.carte8, My.Resources.carte9}

    Dim nb = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9}

    Dim pbValue = {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1}

    Private Sub retourneCarte(numCard As Integer, cardClicked As Object)
        Dim click = 0
        If pbValue(numCard) = -1 And check = 1 Then
            cardClicked.Image = card(nb(numCard))
            If choice = 0 And click = 0 Then
                oldCard = cardClicked
                pbValue(numCard) = nb(numCard)
                oldValue = numCard
                choice = 1
                click = 1
            End If

            If choice = 1 And click = 0 Then
                pbValue(numCard) = nb(numCard)
                If pbValue(numCard) <> pbValue(oldValue) Then
                    numCardSaved = numCard
                    cardClickedSaved = cardClicked
                    ShowCard.Start()
                    check = 0

                End If
                choice = 0
                click = 1
            End If
        End If
    End Sub

    Private Sub retourneCarte2(numCard As Integer, cardClicked As Object)
        cardClicked.Image = My.Resources.carte
        oldCard.Image = My.Resources.carte
        pbValue(numCard) = -1
        pbValue(oldValue) = -1
        check = 1
    End Sub

    Private Sub RandomizeArray(ByVal items() As Integer)
        Dim max_index As Integer = items.Length - 1
        Dim rnd As New Random
        For i As Integer = 0 To max_index - 1
            Dim j As Integer = rnd.Next(i, max_index + 1)

            Dim temp As Integer = items(i)
            items(i) = items(j)
            items(j) = temp
        Next i
    End Sub

    Private Sub Plateau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RandomizeArray(nb)
    End Sub

    Private Sub ShowCard_Tick(sender As Object, e As EventArgs) Handles ShowCard.Tick
        retourneCarte2(numCardSaved, cardClickedSaved)
        ShowCard.Stop()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        retourneCarte(0, PictureBox1)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        retourneCarte(1, PictureBox2)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        retourneCarte(2, PictureBox3)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        retourneCarte(3, PictureBox4)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        retourneCarte(4, PictureBox5)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        retourneCarte(5, PictureBox6)
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        retourneCarte(6, PictureBox7)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        retourneCarte(7, PictureBox8)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        retourneCarte(8, PictureBox9)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        retourneCarte(9, PictureBox10)
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        retourneCarte(10, PictureBox11)
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        retourneCarte(11, PictureBox12)
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        retourneCarte(12, PictureBox13)
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        retourneCarte(13, PictureBox14)
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        retourneCarte(14, PictureBox15)
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        retourneCarte(15, PictureBox16)
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        retourneCarte(16, PictureBox17)
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        retourneCarte(17, PictureBox18)
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        retourneCarte(18, PictureBox19)
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        retourneCarte(19, PictureBox20)
    End Sub
End Class
