Public Class Form1


    Private Sub QuitterLeJeu_Click(sender As Object, e As EventArgs) Handles QuitterLeJeu.Click
        Dim rep As Integer = MsgBox("Êtes-vous sûr de vouloir quitter le jeu ?", MsgBoxStyle.YesNo)
        If rep = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub VoirLesRésultats_Click(sender As Object, e As EventArgs) Handles VoirLesRésultats.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub NouvellePartie_Click(sender As Object, e As EventArgs) Handles NouvellePartie.Click
        If NomJoueur.Text.Length <= 3 Then
            NomJoueur.ForeColor = Color.Red
            MsgBox("Veuillez écrire un nom ayant plus de trois caractères SVP", MsgBoxStyle.Critical)
        Else
            If NomJoueur.SelectedIndex > -1 Then
                Dim sindex As Integer = NomJoueur.SelectedIndex
                Dim sitem As Object = NomJoueur.SelectedItem
                NomJoueur.Items.Add(sitem)
                Me.Hide()
                Form2.Hide()
            End If
        End If
    End Sub

    Private Sub Paramètres_Click(sender As Object, e As EventArgs) Handles Paramètres.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub NomJoueur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NomJoueur.SelectedIndexChanged, NomJoueur.TextUpdate

    End Sub


End Class
