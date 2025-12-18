Module aricles
    Public Structure article
        Dim code As String
        Dim vetement As String
        Dim typenett As String
        Dim nombre As Integer
        Dim suppement As List(Of article)
    End Structure
    Public Sub initarticle()
        suppement = New List(Of Boolean)({False, False})
    End Sub
    Public listearticle As New List(Of article)
    Public Sub ajouterarticle(a As article)
        a.code = a.vetement.Substring(1, 2) & "_" & listearticle.Count
        listearticle.Add(a)
    End Sub
End Module
