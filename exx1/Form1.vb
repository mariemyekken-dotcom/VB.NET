Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nom As String
        Dim age As Integer
        nom = InputBox("Entrez votre nom")
        age = InputBox("Entrez votre age")
        MessageBox.Show("Bonjoour " & nom & " vous avez " & age & " ans")
    End Sub
End Class
