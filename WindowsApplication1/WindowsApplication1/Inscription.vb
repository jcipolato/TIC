Public Class Inscription
    Private Sub txtCP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCP.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelPerso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelPerso.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelPro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelPro.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub SauvegarderEnabled(cb As ComboBox)
        If cb.SelectedIndex > -1 Then
            btnSauvegarder.Enabled = True
        Else
            btnSauvegarder.Enabled = False
        End If
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr = New Net.Mail.MailAddress(email)
            Return True
        Catch
            Return False
        End Try
    End Function

    Private Sub Inscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim textboxes As TextBox() = {txtNom, txtPrenom, txtAdresse, txtDateNaissance, txtCP, txtProfession, txtAutre, txtCheque, txtComplement}
        Dim comboboxes As ComboBox() = {cbCivilite, cbEmploi, cbEtudes, cbFidelite, cbFinancement, cbPays, cbStatut}
        For Each tb In textboxes
            AddHandler tb.TextChanged, Sub(s, ee)
                                           btnSauvegarder.Enabled = Not textboxes.Any(Function(box) box.Text = String.Empty)
                                       End Sub
        Next
        For Each cb In comboboxes
            AddHandler cb.SelectedIndexChanged, Sub(s, ee)
                                                    btnSauvegarder.Enabled = Not comboboxes.Any(Function(box) box.SelectedIndex > -1)
                                                End Sub
        Next
    End Sub

    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs) Handles btnSauvegarder.Click
        Dim dossier As New Dossier()
        dossier.p_civilite = cbCivilite.SelectedValue
        dossier.p_nom = txtNom.Text
        dossier.p_prenom = txtPrenom.Text
        dossier.p_dateNaissance = txtDateNaissance.Text
        dossier.p_adresse = txtAdresse.Text
        dossier.p_complementAdresse = txtComplement.Text
        dossier.p_codePostal = txtCP.Text
        dossier.p_ville = txtVille.Text
        dossier.p_pays = cbPays.SelectedValue
        dossier.p_Statut = cbStatut.SelectedValue
        dossier.p_niveauEtudes = cbEtudes.SelectedValue
        dossier.p_autre = txtAutre.Text
        dossier.p_profession = txtProfession.Text
        dossier.p_domaineEmploi = cbEmploi.SelectedValue
        dossier.p_mailPerso = txtMailPerso.Text
        dossier.p_mailPro = txtMailPro.Text
        dossier.p_telPerso = txtTelPerso.Text 'pas de conversion à faire ?
        dossier.p_telPro = txtTelPro.Text

        If rbOuiCV.Checked Then
            dossier.p_cvOuiNon = True
        Else dossier.p_cvOuiNon = False
        End If

        'dossier.p_cvOuiNon = rbOuiCV.Checked Or rbNonCV.Checked à tester

        If rbOuiMotiv.Checked Then
            dossier.p_lettreMotivationOuiNon = True
        Else dossier.p_lettreMotivationOuiNon = False
        End If

        dossier.p_dateDebutContrat = dtDebutContrat.Value
        dossier.p_dateFinContrat = dtFinContrat.Value

        If rbAcompteOui.Checked Then
            dossier.p_accompteOuiNon = True
        Else dossier.p_accompteOuiNon = False
        End If

        dossier.p_numeroCheque = txtCheque.Text
        dossier.p_financement = cbFinancement.SelectedValue
        dossier.p_fidelite = cbFidelite.SelectedValue











    End Sub

    Private Sub rbOuiCV_CheckedChanged(sender As Object, e As EventArgs) Handles rbOuiCV.CheckedChanged
        ' MessageBox pour afficher p_CVOuiNon


    End Sub
End Class