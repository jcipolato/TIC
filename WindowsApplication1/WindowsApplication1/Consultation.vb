Public Class Consultation
    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
    End Sub

    Private Sub ButtonModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        Inscription.Show()
        Me.Hide()
    End Sub

    Private Sub dtgDossiers_SelectionChanged(sender As Object, e As EventArgs) Handles dtgDossiers.SelectionChanged
        If dtgDossiers.SelectedRows.Count > 1 Then
            btnModifier.Enabled = False
            btnSupprimer.Enabled = True
            btnGenerer.Enabled = True
        ElseIf dtgDossiers.SelectedRows.Count > 0 Then
            btnGenerer.Enabled = True
            btnModifier.Enabled = True
            btnSupprimer.Enabled = True
        Else
            btnModifier.Enabled = False
            btnSupprimer.Enabled = False
            btnGenerer.Enabled = False
        End If
    End Sub
End Class