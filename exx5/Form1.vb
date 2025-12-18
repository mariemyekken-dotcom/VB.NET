Public Class Form1
    Function carre(x As Integer) As Integer
        Return x * x
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As Integer
        a = InputBox("entrez un entier")
        MessageBox.Show("le racine carre est " & carre(a))
    End Sub
End Class
