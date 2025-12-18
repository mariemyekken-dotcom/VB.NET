Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim etudiant(2) As etudiant
        Dim meilleur As etudiant
        Dim i As Integer
        For i = 0 To 2
            etudiant(i).nom = InputBox("entrez le nom de l'etudiant")
            etudiant(i).prenom = InputBox("entrez le prenom de l'etudiant")
            etudiant(i).note = Val(InputBox("entrez le age de l'etudiant"))
            meilleur = etudiant(0)
        Next
        For i = 1 To 2
            If etudiant(i).note > meilleur.note Then
                meilleur = etudiant(i)
            End If
        Next
    End Sub
End Class
