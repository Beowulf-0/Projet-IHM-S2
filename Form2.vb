Public Class Form2
    Dim j As Joueur
    Dim tempsRestant As Integer
    Dim nom As String
    Dim nbCarre As Integer
    Dim tempsCumule As Integer

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = Form1.NomJoueur.Text
        tempsRestant = 180 + Val(Form4.ReglerTemps.Text)
        TempsImparti.Interval = 1000
        TempsImparti.Enabled = True
        TempsImparti.Start()
    End Sub

    Private Sub Pause_Click(sender As Object, e As EventArgs) Handles Pause.Click
        If Pause.Visible = True Then

        End If
    End Sub



    Private Sub TempsImparti_Tick(sender As Object, e As EventArgs) Handles TempsImparti.Tick
        tempsRestant -= 1
        Label2.Text = tempsRestant \ 60 & ": " & tempsRestant Mod 60
    End Sub

    'Methode qui va transformer tout en chaine de caractère, 
    'M2 qui va récupérer les infos du fichier de sauvegarde

    Private Function transformeDonnees()
        Dim texte As String
        nom = Label3.Text

        'texte = CStr(nom & " " &)

    End Function
End Class
