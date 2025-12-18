Imports System.Net.NetworkInformation

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ajouter_Click(sender As Object, e As EventArgs) Handles ajouter.Click
        Dim article As article = New article
        Dim test As Boolean = False
        For Each ctrl In grpvetement.Controls
            If ctrl.checked Then
                article.vetement = ctrl.vetement
                test = True

            End If
        Next
        If test = False Then
            ErrorProvider1.SetError(grpvetement, "invalide le vetement ")

        End If
        For Each ctrl In grpnett.Controls
            If ctrl.checked Then
                article.typenett = ctrl.typenett
                test = True

            End If
        Next
        If test = False Then
            ErrorProvider1.SetError(grpnett, "invalide le type ")

        End If
        Dim nb As Integer
        nb = CInt(txtnum.Text)
        If nb < 0 Then
            ErrorProvider1.SetError(txtnum, "invalide le type ")
        End If
        article.nombre = nb
        If defoissage.Checked Then
            article.suppement(0) = True
        End If
        If antitache.Checked Then
            article.suppement(1) = True
        End If
        ajouterarticle(article)
    End Sub
End Class
