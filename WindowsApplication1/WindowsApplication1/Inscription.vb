Imports System.Globalization
Imports Microsoft.Office.Interop
Imports Microsoft.Win32

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
        Else
            FillDossier()
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

    Private Sub FillDossier()
        Dim dossier As New Dossier()
        dossier.p_civilite = cbCivilite.SelectedValue
        dossier.p_nom = txtNom.Text
        dossier.p_prenom = txtPrenom.Text
        dossier.p_dateNaissance = dtNaissance.Text
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
        dossier.p_telPerso = txtTelPerso.Text
        dossier.p_telPro = txtTelPro.Text

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
            dossier.p_accompteOuiNon = True
        Else dossier.p_accompteOuiNon = False
        End If

        dossier.p_numeroCheque = txtCheque.Text
        dossier.p_financement = cbFinancement.SelectedValue
        dossier.p_fidelite = cbFidelite.SelectedValue


        'Appeler fonction Private qui exporte dans fichier Excel
        addExcel()

    End Sub

    Private Sub addExcel()

        'OUVERTURE EXCEL
        Dim xls As Excel.Application = New Excel.Application()

        If xls Is Nothing Then
            MessageBox.Show(My.Resources.Messages.Excel_BadVersion)
            Return
        End If
        Dim workbook As Excel.Workbook = xls.Workbooks.Open("C:\UBDXFORM\UBDXFORM-backup.xlsx")
        Dim worksheet As Excel.Worksheet = CType(workbook.Sheets(1), Excel.Worksheet)

        For i = 1 To worksheet.UsedRange.Rows.Count
            worksheet.Cells(i, 1) = cbCivilite.SelectedValue
            worksheet.Cells(i, 2) = txtNom.Text
            worksheet.Cells(i, 3) = txtPrenom.Text
            worksheet.Cells(i, 4) = dtNaissance.Text
            worksheet.Cells(i, 5) = txtAdresse.Text
            worksheet.Cells(i, 6) = txtComplement.Text
            worksheet.Cells(i, 7) = txtCP.Text
            worksheet.Cells(i, 8) = txtVille.Text
            worksheet.Cells(i, 9) = cbPays.SelectedValue
            worksheet.Cells(i, 10) = cbStatut.SelectedValue
            worksheet.Cells(i, 11) = cbEtudes.SelectedValue
            worksheet.Cells(i, 12) = txtAutre.Text
            worksheet.Cells(i, 13) = txtProfession.Text
            worksheet.Cells(i, 14) = cbEmploi.SelectedValue
            worksheet.Cells(i, 15) = txtMailPerso.Text
            worksheet.Cells(i, 16) = txtMailPro.Text
            worksheet.Cells(i, 17) = txtTelPerso.Text
            worksheet.Cells(i, 18) = txtTelPro.Text

            If rbOuiCV.Checked Then
                worksheet.Cells(i, 19) = True
            Else worksheet.Cells(i, 19) = False
            End If

            If rbOuiMotiv.Checked Then
                worksheet.Cells(i, 20) = True
            Else worksheet.Cells(i, 20) = False
            End If

            worksheet.Cells(i, 21) = dtDebutContrat.Value
            worksheet.Cells(i, 22) = dtFinContrat.Value

            If rbOuiAcompte.Checked Then
                worksheet.Cells(i, 23) = True
            Else worksheet.Cells(i, 23) = False
            End If

            worksheet.Cells(i, 24) = txtCheque.Text
            worksheet.Cells(i, 25) = cbFinancement.SelectedValue
            worksheet.Cells(i, 26) = cbFidelite.SelectedValue
        Next


        'FERMETURE EXCEL




    End Sub


End Class