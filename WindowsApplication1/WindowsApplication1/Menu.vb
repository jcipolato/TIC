Public Class Menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonInscription.Click
        Inscription.Show()

    End Sub

    Private Sub ButtonConsultaion_Click(sender As Object, e As EventArgs) Handles ButtonConsultaion.Click
        Consultation.Show()

    End Sub

    Private Sub ButtonConfiguration_Click(sender As Object, e As EventArgs) Handles ButtonConfiguration.Click
        Configuration.Show()

    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
    End Sub
End Class
