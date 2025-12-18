Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As Integer
        Dim b As Integer
        Dim somme As Double
        Dim difference As Double
        Dim quotient As Double
        Dim produit As Double
        a = InputBox("entrez un entier1")
        b = InputBox("entrez un entier1")
        If b = 0 Then
            MessageBox.Show("erreur")

        End If
        somme = a + b
        produit = a * b
        difference = a - b
        quotient = a / b
        MessageBox.Show("la somme est = " & somme)
        MessageBox.Show("le produit est = " & produit)
        MessageBox.Show("la quotion est = " & quotient)
        MessageBox.Show("la difference est = " & difference)

    End Sub
End Class
