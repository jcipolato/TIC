Imports System.Globalization
Imports Microsoft.Win32

Public Class Inscription
    Private Sub Inscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCountriesList()
        SwitchButtonState()
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Close()
    End Sub

    Private Sub txtNumbersOnly_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCP.KeyPress, txtTelPerso.KeyPress, txtTelPro.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
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

    Private Sub SetCountriesList()
        Dim list = CountryList().Values
        For Each country In list
            cbPays.Items.Add(country)
        Next
    End Sub

    Public Function CountryList() As SortedList
        Dim slCountry As SortedList = New SortedList()
        Dim Key As String
        Dim Value As String

        For Each info In CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            Dim ri As RegionInfo = New RegionInfo(info.LCID)
            If Not (slCountry.Contains(ri.TwoLetterISORegionName)) Then
                Value = ri.DisplayName
                Key = ri.TwoLetterISORegionName
                slCountry.Add(Key, Value)
            End If
        Next
        slCountry.RemoveAt(0)
        Return slCountry
    End Function

    Private Sub SwitchButtonState()
        Dim controls As Control() = {txtNom, txtPrenom, txtAdresse, txtCP, txtProfession,
            txtAutre, txtCheque, txtComplement, cbCivilite, cbEmploi, cbEtudes, cbFidelite,
            cbFinancement, cbPays, cbStatut, rbOuiCV, rbNonCV, rbOuiMotiv, rbNonMotiv, rbNonAcompte, rbOuiAcompte}
        For Each item In controls
            AddHandler item.TextChanged, Sub(s, ee)
                                             btnSauvegarder.Enabled = Not controls.Any(Function(box) box.Text = String.Empty)
                                         End Sub

        Next
    End Sub

    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs) Handles btnSauvegarder.Click
        If Not IsValidEmail(txtMailPerso.Text) And Not IsValidEmail(txtMailPro.Text) Then
            labErreurMail.Visible = True
        ElseIf txtTelPerso.Text.Length < 10 And txtTelPro.Text.Length < 10 Then
            labErreurTel.Visible = True
        End If
    End Sub

    Private Sub cbEtudes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEtudes.SelectedIndexChanged
        If cbEtudes.SelectedItem.ToString = "Autre" Then
            labAutre.Visible = True
            txtAutre.Visible = True
        Else
            labAutre.Visible = False
            txtAutre.Visible = False
        End If
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