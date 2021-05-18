Public Class Form4
    Dim t_OptionsTemps() As String = {"Aucun", "Désactiver le temps", "Régler le temps à :"}
    Dim t_OptionsAutre() As String = {"Changez le thème des cartes : ", "Accéder / créer au chemin de sauvegarde", "Activer la pause dans le jeu"}
    Dim t_imagesCartes() As String = {"Test", "Test1", "Test2"}


    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rb As RadioButton
        Dim cb As CheckBox
        For i As Integer = 0 To Panel1.Controls.Count - 1
            rb = Panel1.Controls(i)
            rb.Text = t_OptionsTemps(i)
            Array.Sort(t_OptionsTemps)
        Next
        For i As Integer = 0 To Panel2.Controls.Count - 1
            cb = Panel2.Controls(i)
            cb.Text = t_OptionsAutre(i)
            Array.Sort(t_OptionsAutre)
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChangerTheme.CheckedChanged
        If ChangerTheme.Checked = True Then
            ThemeCartes.Visible = True
        Else
            ThemeCartes.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles AccederFichier.CheckedChanged
        If AccederFichier.Checked = True Then
            AccederFichierSauv.Visible = True
        Else
            AccederFichierSauv.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles PauseJeu.CheckedChanged
        If PauseJeu.Checked = True Then
            Form2.Pause.Visible = True
        Else
            Form2.Pause.Visible = False
        End If
    End Sub

    Private Sub AccederFichierSauv_Click(sender As Object, e As EventArgs) Handles AccederFichierSauv.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("./Sauvegarde/sauvegarde.txt", True)
        If Form1.NomJoueur.Text <= 3 Then
            file.WriteLine("Nom : Gerard")
            file.Close()
        Else
            file.WriteLine("Nom :" + Form1.NomJoueur.Text)
        End If
    End Sub
End Class
