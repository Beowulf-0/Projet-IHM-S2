Public Class Plateau
    'Initialisation des variables avec les données d'autres forms
    Dim joueurQuiJoue
    Dim theme As Integer = 1
    Const TPS As Integer = 60
    Dim temps = TPS

    'Variable pour la fin de partie
    Dim ptScore As Integer = 0
    Dim tpsScore As Integer = 0
    Dim fin As Boolean = False

    'Variable essentiel pour la pause
    Dim estEnPause As Boolean = False
    Dim etaitRetourner As Boolean = False

    'Variable principales pour l'algorithme du jeu
    Dim choix As Integer = 0
    Dim oldCard As Object
    Dim oldValue As Integer
    Dim numCardSaved As Integer
    Dim cardClickedSaved As Object
    Dim peutRetourner As Boolean = True
    Dim card = {}
    Dim valeur = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
    Dim pbValue = {-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1}

    'Fonction qui permet de retouner les cartes et de prendre en compte s'il sont les même ou non
    Private Sub retourneCarte(numCard As Integer, cardClicked As Object)
        Dim click = 0
        'Verifie si la carte est déja retourner
        If pbValue(numCard) = -1 And peutRetourner = True Then
            'Retourne la carte
            cardClicked.Image = card(valeur(numCard) + 1)
            'Pour la première carte retourné
            If choix = 0 And click = 0 Then
                'Enrigistre la carte cliqué
                oldCard = cardClicked
                pbValue(numCard) = valeur(numCard)
                oldValue = numCard
                choix = 1
                click = 1
            End If

            'Pour la deuxième carte retourné
            If choix = 1 And click = 0 Then
                pbValue(numCard) = valeur(numCard)

                'Verifie si les deux cartes ont les même symboles
                If pbValue(numCard) <> pbValue(oldValue) Then
                    numCardSaved = numCard
                    cardClickedSaved = cardClicked
                    ShowCard.Start()
                    peutRetourner = False
                Else
                    'Actualise le score
                    ptScore += 1
                    tpsScore = TPS - temps
                    ScoreLabel.Text = "Score : " + Str(ptScore) + " en " + Str(tpsScore) + "sc"
                    If ptScore = 10 Then
                        fin = True
                    End If
                End If
                choix = 0
                click = 1
            End If
        End If
    End Sub

    'Fonction qui retourne les cartes qui n'ont pas les mêmes symboles
    Private Sub retourneCarte2(numCard As Integer, cardClicked As Object)
        cardClicked.Image = card(0)
        oldCard.Image = card(0)
        pbValue(numCard) = -1
        pbValue(oldValue) = -1
        peutRetourner = True
    End Sub

    'Fonction pour mélanger une liste
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
        'nomJoueur.Text = joueurQuiJoue.nom

        'Choix du thème
        If theme = 0 Then
            card = {My.Resources.carteBV__1_, My.Resources.carteBV__2_,
            My.Resources.carteBV__3_, My.Resources.carteBV__4_,
            My.Resources.carteBV__5_, My.Resources.carteBV__6_,
            My.Resources.carteBV__7_, My.Resources.carteBV__8_,
            My.Resources.carteBV__9_, My.Resources.carteBV__10_,
            My.Resources.carteBV__11_}
        ElseIf theme = 1 Then
            card = {My.Resources.carteGN__1_, My.Resources.carteGN__2_,
                My.Resources.carteGN__3_, My.Resources.carteGN__4_,
            My.Resources.carteGN__5_, My.Resources.carteGN__6_,
            My.Resources.carteGN__7_, My.Resources.carteGN__8_,
            My.Resources.carteGN__9_, My.Resources.carteGN__10_,
            My.Resources.carteGN__11_}

        ElseIf theme = 2 Then
            card = {My.Resources.carteRO__1_, My.Resources.carteRO__2_,
                My.Resources.carteRO__3_, My.Resources.carteRO__4_,
            My.Resources.carteRO__5_, My.Resources.carteRO__6_,
            My.Resources.carteRO__7_, My.Resources.carteRO__8_,
            My.Resources.carteRO__9_, My.Resources.carteRO__10_,
            My.Resources.carteRO__11_}
        End If

        'Initialisation de la liste des PictureBox
        Dim pb = {PictureBox1, PictureBox2, PictureBox3, PictureBox4,
            PictureBox5, PictureBox6, PictureBox7, PictureBox8,
            PictureBox9, PictureBox10, PictureBox11, PictureBox12,
            PictureBox13, PictureBox14, PictureBox15, PictureBox16,
            PictureBox17, PictureBox18, PictureBox19, PictureBox20}
        TempsLabel.Text = temps \ 60 & ":" & temps Mod 60

        'Melange la liste des "valeurs" des cartes
        RandomizeArray(valeur)

        TempsJeu.Start()

        'Initialisation des images des cartes
        For i = 0 To pb.Length - 1 Step +1
            pb(i).Image = card(0)
        Next
    End Sub

    'Timer pour le temps de jeu
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TempsJeu.Tick
        If fin = False Then
            temps -= 1
            TempsLabel.Text = temps \ 60 & ":" & temps Mod 60
        End If
        If temps = 0 Or fin = True Then
            TempsJeu.Stop()
            If peutRetourner = False Then
                pbValue(numCardSaved) = -1
                pbValue(oldValue) = -1
                ShowCard.Stop()
            End If
            peutRetourner = False
            TempsLabel.Text = "Fin"
            'If ptScore > joueurQuiJoue.nombreMaxCarré Then
            '	joueurQuiJoue.nombreMaxCarré = ptScore
            '	joueurQuiJoue.tempsMinCarré = tpsScore
            'Else if ptScore == joueurQuiJoue.nombreMaxCarré And tpsScore < joueurQuiJoue.tempsMinCarré
            '	joueurQuiJoue.tempsMinCarré = tpsScore
            'End if
        End If
    End Sub

    'Timer du temps des deux cartes retourné s'ils n'ont pas les mêmes symboles
    Private Sub ShowCard_Tick(sender As Object, e As EventArgs) Handles ShowCard.Tick
        retourneCarte2(numCardSaved, cardClickedSaved)
        ShowCard.Stop()
    End Sub

    'Bouton pause
    Private Sub Pause_Click(sender As Object, e As EventArgs) Handles Pause.Click

        If estEnPause = False Then
            Pause.Text = "Pause : On"
            'peutRetourner retient si la pause intervient lorsqu'on affiche les deux cartes retourné qui n'ont pas le même symbole
            If peutRetourner = False Then
                etaitRetourner = True
            End If
            estEnPause = True
            peutRetourner = False
            TempsJeu.Stop()
            ShowCard.Stop()
        Else
            Pause.Text = "Pause : Off"
            estEnPause = False
            TempsJeu.Start()
            If etaitRetourner = True Then
                ShowCard.Start()
                etaitRetourner = False
            Else
                peutRetourner = True
            End If
        End If
    End Sub

    'Bouton abandonner quitte le formulaire et revient au menu
    Private Sub Abandonner_Click(sender As Object, e As EventArgs) Handles Abandonner.Click
        Dim choixQuitter As Integer = MsgBox("Voulez vous continuer ?",
                                             MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Critical,
                                             "Confirmation")
        If choixQuitter = vbYes Then
            Me.Close()
        End If
    End Sub

    'Appel de la fonction des PictureBox
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
