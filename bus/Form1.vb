Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As reservation
        If listligne.SelectedIndex = -1 Then
            ErrorProvider1.SetError(listligne, "Veuillez sélectionner une ligne.")
        End If
        r.ligne = listligne.Text
        If listdep.SelectedIndex = -1 Then
            ErrorProvider1.SetError(listdep, "Veuillez sélectionner une ville de départ.")
        End If
        r.villeDepart = listdep.Text
        If listarr.SelectedIndex = -1 Then
            ErrorProvider1.SetError(listarr, "Veuillez sélectionner une ville d'arrivée.")
        End If
        r.villeArrivee = listarr.Text
    End Sub
End Class
