Public Class Form3
    Dim score As String()
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox1.SelectedIndex = ListBox2.SelectedIndex
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        ListBox2.SelectedIndex = ListBox3.SelectedIndex
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        ListBox3.SelectedIndex = ListBox4.SelectedIndex
    End Sub

    Private Sub ListBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox4.SelectedIndexChanged
        ListBox4.SelectedIndex = ListBox5.SelectedIndex
    End Sub

    Private Sub ListBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox5.SelectedIndexChanged
        ListBox5.SelectedIndex = ListBox1.SelectedIndex
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ChercherJoueur_TextChanged(sender As Object, e As EventArgs) Handles ChercherJoueur.TextChanged
        If ChercherJoueur.Text = ListBox1.SelectedIndex Then

        End If
    End Sub
End Class
