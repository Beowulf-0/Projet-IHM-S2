Module Enregistrement
    Public Structure Joueur
        Dim nom As String
        Dim nombreMaxCarré As Integer
        Dim tempsMinCarré As Integer
        Dim nbPartieJouées As Integer
        Dim tempsCumuléJeu As Integer
    End Structure

    Dim tab_joueur As New List(Of Joueur)

    Public Function getNbJoueur() As Integer
        Return tab_joueur.Count
    End Function

    Public Function ajouterJoueur(j As Joueur)
        tab_joueur.Add(j)
        Return getNbJoueur() - 1
    End Function

    Public Function getTemps()
        Return Val(Form4.ReglerTemps.Text) * 60
    End Function
End Module

