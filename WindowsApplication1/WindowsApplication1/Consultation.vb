Public Class Consultation
    Private Sub ButtonRecherche_Click(sender As Object, e As EventArgs) Handles ButtonRecherche.Click
        Rechercher.Show()
        Me.Hide()

    End Sub

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Me.Hide()
    End Sub

    Private Sub ButtonModifier_Click(sender As Object, e As EventArgs) Handles ButtonModifier.Click
        Inscription.Show()
        Me.Hide()


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class