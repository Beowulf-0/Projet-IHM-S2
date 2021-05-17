Public Class Form4
    Dim t_Options() As String = {"Désactiver le temps", "Régler le temps à :", "Chercher le fichier de sauvegarde", "Activer le bouton de pause dans le formulaire de jeu", "Changer le thème :"}
    Dim t_imagesCartes() As String = {"Test", "Test1", "Test2"}
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cb As CheckBox
        For i As Integer = 0 To GroupBox1.Controls.Count - 1
            cb = GroupBox1.Controls(i)
            cb.Text = t_Options(i)
            Array.Sort(t_Options)
        Next
    End Sub


End Class