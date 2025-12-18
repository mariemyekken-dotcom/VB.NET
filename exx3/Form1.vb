
Public Class Form1
        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim a As Integer
            a = InputBox("donnez votre moyenne")
            If a >= 10 Then
                MessageBox.Show("admis")
            ElseIf 8 <= a <= 10 Then
                MessageBox.Show("rattrapage")
            Else
                MessageBox.Show("ajourné")

            End If
        End Sub
    End Class


