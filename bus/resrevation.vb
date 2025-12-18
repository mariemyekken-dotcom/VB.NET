Module resrevation
    Dim nbPlacesDispo As Integer = 50
    Public Structure reservation
        Dim ligne As String
        Dim villeDepart As String
        Dim villeArrivee As String
        Dim h_debut As String
        Dim h_fin As String
        Dim places As Integer
        Dim options As List(Of String)
        Dim type As String
        Public Sub initReservation()
            options = New List(Of String)()

        End Sub
    End Structure
    Public listReservations As New List(Of reservation)()
    Public Function AjouterReservation(res As reservation) As Boolean
        If res.places <= nbPlacesDispo Then
            listReservations.Add(res)
            nbPlacesDispo -= res.places
            Return True
        Else
            Return False
        End If
    End Function
End Module
