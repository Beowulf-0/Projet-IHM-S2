Public Class Form4
    Dim t_OptionsTemps() As String = {"Aucun", "Désactiver le temps", "Régler le temps à :"}
    Dim t_imagesCartes() As String = {"Rouge-Orange", "Bleu-Vert", "Gris-Noir"}
    Private indexTheme As Integer
    Dim time As Integer

    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ThemeCartes.Items.Clear()
        Dim rb As RadioButton
        For i As Integer = 0 To Panel1.Controls.Count - 1
            rb = Panel1.Controls(i)
            rb.Text = t_OptionsTemps(i)
            Array.Sort(t_OptionsTemps)
        Next
        For i As Integer = 0 To t_imagesCartes.Count - 1
            ThemeCartes.Items.Add(t_imagesCartes(i))
        Next

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChangerTheme.CheckedChanged
        If ChangerTheme.Checked = True Then
            ThemeCartes.Visible = True
        Else
            ThemeCartes.Visible = False
        End If
    End Sub


    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles PauseJeu.CheckedChanged
        If PauseJeu.Checked = True Then
            Form2.Pause.Visible = True
            Form2.Pause.Enabled = True
        Else
            Form2.Pause.Visible = False
            Form2.Pause.Enabled = False
        End If
    End Sub

    Private Sub AccederFichierSauv_Click(sender As Object, e As EventArgs) Handles AccederFichierSauv.Click
        Dim nom_fichier As String = "C:\Users\Wahad\source\repos\ProjetIHM-Mehdi\ProjetIHM-Mehdi\Sauvegarde\sauvegarde.txt"
        If System.IO.File.Exists(nom_fichier) Then
            Process.Start(nom_fichier)
        Else
            MessageBox.Show("Le fichier n'existe pas")
        End If
    End Sub

    Private Sub ReglerTemps_LostFocus(sender As Object, e As EventArgs) Handles ReglerTemps.LostFocus
        If ReglerTemps.Visible = True Then
            If ReglerTemps.Text = vbNullString Then
                Exit Sub
            End If
            If IsNumeric(ReglerTemps.Text) Then
                time = CInt(ReglerTemps.Text)
            End If
        End If
    End Sub

    Private Sub ReglerTemps_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ReglerTemps.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If ReglerTemps.Visible = False Then
            ReglerTemps.Visible = True
        Else
            ReglerTemps.Visible = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Form2.TempsImparti.Enabled = False
        Else
            Form2.TempsImparti.Enabled = True
        End If
    End Sub

    Private Sub ThemeCartes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ThemeCartes.SelectedIndexChanged
        indexTheme = ThemeCartes.SelectedIndex
    End Sub

    Public Function getIndexTheme() As Integer
        Return indexTheme
    End Function
End Class
