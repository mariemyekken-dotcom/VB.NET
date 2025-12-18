Public Class Form1

    Dim prix As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listboisson.Items.Add("cafe")
        listboisson.Items.Add("the")

    End Sub
    Private Sub ajouter_Click(sender As Object, e As EventArgs) Handles ajouter.Click
        Dim commande As String
        If pizza.Checked Then
            commande = "pizza"
            prix = 10
        ElseIf burger.Checked Then
            commande = "burger"
            prix = 15
        Else
            commande = "pates"
            prix = 20
        End If
        For Each ctrl In grp2.Controls
            If ctrl.checked Then
                commande = commande + ctrl.text
                If ctrl.text = "fromage" Then
                    prix = prix + 2
                ElseIf ctrl.text = "frites" Then
                    prix = prix + 3
                ElseIf ctrl.text = "dessert" Then
                    prix = prix + 4
                End If

            End If
        Next
        resultat.Text = commande & "_" & prix



    End Sub
End Class
