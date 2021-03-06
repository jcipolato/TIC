﻿Imports System.Globalization
Imports Microsoft.Office.Interop
Imports Microsoft.Win32
Imports WindowsApplication1.Common
Imports WindowsApplication1.My.Resources

Public Class Inscription
    Private Sub Inscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountryList()
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

    Public Sub CountryList()
        For Each info In CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            Dim ri As RegionInfo = New RegionInfo(info.LCID)
            If Not (cbPays.Items.Contains(ri.DisplayName)) Then
                cbPays.Items.Add(ri.DisplayName)
            End If
        Next

        cbPays.Items.RemoveAt(0)
    End Sub

    Private Sub SwitchButtonState()
        Dim controls As Control() = {txtNom, txtPrenom, txtAdresse, txtCP,
            cbCivilite, cbEtudes, cbPays, cbStatut, rbOuiCV, rbNonCV,
            rbOuiMotiv, rbNonMotiv, rbNonAcompte, rbOuiAcompte}
        For Each item In controls
            AddHandler item.TextChanged, Sub(s, ee)
                                             btnSauvegarder.Enabled = Not controls.Any(Function(box) box.Text = String.Empty)
                                         End Sub
        Next
    End Sub

    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs) Handles btnSauvegarder.Click
        labErreurMail.Visible = txtMailPerso.Text <> "" And Not IsValidEmail(txtMailPerso.Text) Or
            txtMailPro.Text <> "" And Not IsValidEmail(txtMailPro.Text)
        labErreurTel.Visible = txtTelPerso.Text <> "" And txtTelPerso.Text.Length <> 10 Or
            txtTelPerso.Text <> "" And txtTelPro.Text.Length <> 10
        labErreurCP.Visible = txtCP.Text.Length <> 5
        labErreurDateNaissance.Visible = dtNaissance.Value.Year >= Date.Now.Year - 18
        labErreurDatesContrat.Visible = dtDebutContrat.Value.Date >= dtFinContrat.Value.Date

        If dtNaissance.Value.Year <Date.Now.Year - 18 And dtDebutContrat.Value.Date <dtFinContrat.Value.Date Then
            FillDossier()
        End If
    End Sub

    Private Sub cbEtudes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEtudes.SelectedIndexChanged
        If cbEtudes.SelectedItem = "Autre" Then
            labAutre.Visible = True
            txtAutre.Visible = True
        Else
            labAutre.Visible = False
            txtAutre.Visible = False
        End If
    End Sub

    Private Sub FillDossier()
        Dim dossier As New Dossier()
        dossier.p_civilite = cbCivilite.Text
        dossier.p_nom = txtNom.Text
        dossier.p_prenom = txtPrenom.Text
        dossier.p_dateNaissance = dtNaissance.Text
        dossier.p_adresse = txtAdresse.Text
        dossier.p_complementAdresse = txtComplement.Text
        dossier.p_codePostal = txtCP.Text
        dossier.p_ville = txtVille.Text
        dossier.p_pays = cbPays.Text
        dossier.p_statut = cbStatut.Text
        If cbEtudes.SelectedItem = "Autre" Then
            dossier.p_niveauEtudes = txtAutre.Text
        Else
            dossier.p_niveauEtudes = cbEtudes.Text
        End If
        dossier.p_profession = txtProfession.Text
        dossier.p_domaineEmploi = cbEmploi.Text
        dossier.p_mailPerso = txtMailPerso.Text
        dossier.p_mailPro = txtMailPro.Text
        If txtTelPerso.Text = "" Then
            dossier.p_telPerso = Nothing
        Else
            dossier.p_telPerso = txtTelPerso.Text
        End If
        If txtTelPro.Text = "" Then
            dossier.p_telPro = Nothing
        Else
            dossier.p_telPro = txtTelPro.Text
        End If

        If rbOuiCV.Checked Then
            dossier.p_cvOuiNon = True
        Else dossier.p_cvOuiNon = False
        End If

        If rbOuiMotiv.Checked Then
            dossier.p_lettreMotivationOuiNon = True
        Else dossier.p_lettreMotivationOuiNon = False
        End If

        dossier.p_dateDebutContrat = dtDebutContrat.Value
        dossier.p_dateFinContrat = dtFinContrat.Value

        If rbOuiAcompte.Checked Then
            dossier.p_acompteOuiNon = True
        Else dossier.p_acompteOuiNon = False
        End If

        dossier.p_numeroCheque = txtCheque.Text
        dossier.p_financement = cbFinancement.Text
        dossier.p_fidelite = cbFidelite.Text

        AddDossier(dossier)
    End Sub

    Private Sub AddDossier(dossier As Dossier)
        CheckBackup()
        Dim xls As Excel.Application = New Excel.Application()

        If xls Is Nothing Then
            MessageBox.Show(Messages.Excel_BadVersion)
            Return
        End If
        Dim workbook As Excel.Workbook = xls.Workbooks.Open("C:\UBDXFORM\UBDXFORM-backup.xlsx")
        Dim worksheet As Excel.Worksheet = CType(workbook.Sheets(1), Excel.Worksheet)

        If worksheet.UsedRange.Cells(worksheet.UsedRange.Rows.Count, 1).Value IsNot Nothing Then
            dossier.p_numero = worksheet.UsedRange.Cells(worksheet.UsedRange.Rows.Count, 1).Value + 1
        Else
            dossier.p_numero = 1
        End If

        If worksheet.Rows(1).Insert() Then
            For Each prop In dossier.GetType().GetProperties()
                DirectCast(worksheet.Cells(1, Array.IndexOf(dossier.GetType().GetProperties(), prop) + 1), Excel.Range).Value = prop.GetValue(dossier)
            Next
            MessageBox.Show(Messages.Inscription_Success)
        End If

        workbook.Save()
        workbook.Close()
        xls.Quit()

        releaseObject(worksheet)
        releaseObject(workbook)
        releaseObject(xls)
        Me.Close()
    End Sub

End Class