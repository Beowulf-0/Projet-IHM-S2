<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NouvellePartie = New System.Windows.Forms.Button()
        Me.NomJoueur = New System.Windows.Forms.ComboBox()
        Me.VoirLesRésultats = New System.Windows.Forms.Button()
        Me.QuitterLeJeu = New System.Windows.Forms.Button()
        Me.Paramètres = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'NouvellePartie
        '
        Me.NouvellePartie.Location = New System.Drawing.Point(92, 143)
        Me.NouvellePartie.Name = "NouvellePartie"
        Me.NouvellePartie.Size = New System.Drawing.Size(100, 23)
        Me.NouvellePartie.TabIndex = 0
        Me.NouvellePartie.Text = "Nouvelle Partie"
        Me.NouvellePartie.UseVisualStyleBackColor = True
        '
        'NomJoueur
        '
        Me.NomJoueur.FormattingEnabled = True
        Me.NomJoueur.Location = New System.Drawing.Point(81, 101)
        Me.NomJoueur.Name = "NomJoueur"
        Me.NomJoueur.Size = New System.Drawing.Size(121, 21)
        Me.NomJoueur.TabIndex = 1
        '
        'VoirLesRésultats
        '
        Me.VoirLesRésultats.Location = New System.Drawing.Point(92, 186)
        Me.VoirLesRésultats.Name = "VoirLesRésultats"
        Me.VoirLesRésultats.Size = New System.Drawing.Size(100, 23)
        Me.VoirLesRésultats.TabIndex = 2
        Me.VoirLesRésultats.Text = "Voir les résultats"
        Me.VoirLesRésultats.UseVisualStyleBackColor = True
        '
        'QuitterLeJeu
        '
        Me.QuitterLeJeu.Location = New System.Drawing.Point(92, 277)
        Me.QuitterLeJeu.Name = "QuitterLeJeu"
        Me.QuitterLeJeu.Size = New System.Drawing.Size(100, 23)
        Me.QuitterLeJeu.TabIndex = 3
        Me.QuitterLeJeu.Text = "Quitter le jeu"
        Me.QuitterLeJeu.UseVisualStyleBackColor = True
        '
        'Paramètres
        '
        Me.Paramètres.Location = New System.Drawing.Point(92, 229)
        Me.Paramètres.Name = "Paramètres"
        Me.Paramètres.Size = New System.Drawing.Size(100, 23)
        Me.Paramètres.TabIndex = 4
        Me.Paramètres.Text = "Paramètres"
        Me.Paramètres.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 49)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Memory"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 312)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Paramètres)
        Me.Controls.Add(Me.QuitterLeJeu)
        Me.Controls.Add(Me.VoirLesRésultats)
        Me.Controls.Add(Me.NomJoueur)
        Me.Controls.Add(Me.NouvellePartie)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NouvellePartie As Button
    Friend WithEvents NomJoueur As ComboBox
    Friend WithEvents VoirLesRésultats As Button
    Friend WithEvents QuitterLeJeu As Button
    Friend WithEvents Paramètres As Button
    Friend WithEvents Label1 As Label
End Class
