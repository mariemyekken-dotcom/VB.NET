Module articles
    Structure article
        Dim code As Integer
        Dim designation As String
        Dim prix As Double
        Dim quantite As Integer
    End Structure
    Public listearticle As New List(Of article)
    Public Sub ajouterarticle(a As article)
        Dim x As Integer = existe(a)
        If x >= 0 Then
            Dim temp As article = listearticle(x)
            temp.quantite = temp.quantite + a.quantite
            temp.prix = a.prix
            listearticle(x) = temp
        Else
            listearticle.Add(a)


        End If
    End Sub
    Function existe(A As article) As Integer
        Dim p As Integer = -1
        For i As Integer = 0 To listearticle.Count - 1
            If listearticle(i).code = A.code Then
                p = i
            End If
        Next
        Return p
    End Function
End Module
