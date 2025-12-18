Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labdate.Text = "date du jour" & Date.Today.ToLongDateString()
    End Sub

    Private Sub btnajouter_Click(sender As Object, e As EventArgs) Handles btnajouter.Click
        Dim a As patient
        Dim nom As String
        Dim prenom As String
        Dim age As Integer
        If String.IsNullOrWhiteSpace(txtnom.Text) Then
            ErrorProvider1.SetError(txtnom, "nom invalide")
        End If
        If String.IsNullOrWhiteSpace(txtprenom.Text) Then
            ErrorProvider1.SetError(txtprenom, "prenom invalide")
        End If
        age = CInt(txtage.Text)
        a.nom = nom
        a.prenom = prenom
        a.age = age
        ajouterpatient(a)
        init()
        maj_dgv()
    End Sub
    Private Sub init()
        txtage.ResetText()
        txtnom.Clear()
        txtprenom.Clear()
    End Sub
    Private Sub maj_dgv()
        graffichage.Rows.Clear()
        For Each a As patient In listpatients
            graffichage.Rows.Add(a.code, a.nom, a.prenom, a.age)
        Next
    End Sub
End Class
