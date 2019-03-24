Imports System.IO
Imports Microsoft.Office.Interop
Imports WindowsApplication1.Common
Imports WindowsApplication1.My.Resources

Public Class Consultation
    Private Sub Consultation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadBackup()
    End Sub

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Hide()
    End Sub

    Private Sub ButtonModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        Inscription.Show()
        Me.Hide()
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If dtgDossiers.SelectedRows.Count > 0 Then
            MessageBox.Show(Messages.DeleteDossier_Message, Messages.DeleteDossier_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DialogResult.Yes Then
                DeleteDossier(dtgDossiers.SelectedRows)
            End If
        End If
    End Sub

    Private Sub dtgDossiers_SelectionChanged(sender As Object, e As EventArgs) Handles dtgDossiers.SelectionChanged
        If dtgDossiers.SelectedRows.Count > 1 Then
            btnModifier.Enabled = False
            btnSupprimer.Enabled = False
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

    Private Sub ReadBackup()
        Dim data As List(Of Dossier) = New List(Of Dossier)()

        If FileNotFound("C:\UBDXFORM\") = True Then
            MessageBox.Show(Messages.Backup_errorMessage, Messages.Backup_errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim xls As Excel.Application = New Excel.Application()

            If xls Is Nothing Then
                MessageBox.Show(Messages.Excel_BadVersion)
                Return
            End If
            Dim workbook As Excel.Workbook = xls.Workbooks.Open("C:\UBDXFORM\UBDXFORM-backup.xlsx")
            Dim worksheet As Excel.Worksheet = CType(workbook.Sheets(1), Excel.Worksheet)

            For i = 1 To worksheet.UsedRange.Rows.Count
                Dim dossier As Dossier = New Dossier()

                dossier.p_civilite = DirectCast(worksheet.Cells(i, 1), Excel.Range).Value
                dossier.p_nom = DirectCast(worksheet.Cells(i, 2), Excel.Range).Value
                dossier.p_prenom = DirectCast(worksheet.Cells(i, 3), Excel.Range).Value
                dossier.p_dateNaissance = DirectCast(worksheet.Cells(i, 4), Excel.Range).Value
                dossier.p_adresse = DirectCast(worksheet.Cells(i, 5), Excel.Range).Value
                dossier.p_complementAdresse = DirectCast(worksheet.Cells(i, 6), Excel.Range).Value
                dossier.p_codePostal = DirectCast(worksheet.Cells(i, 7), Excel.Range).Value
                dossier.p_ville = DirectCast(worksheet.Cells(i, 8), Excel.Range).Value
                dossier.p_pays = DirectCast(worksheet.Cells(i, 9), Excel.Range).Value
                dossier.p_Statut = DirectCast(worksheet.Cells(i, 10), Excel.Range).Value
                dossier.p_niveauEtudes = DirectCast(worksheet.Cells(i, 11), Excel.Range).Value
                dossier.p_profession = DirectCast(worksheet.Cells(i, 12), Excel.Range).Value
                dossier.p_domaineEmploi = DirectCast(worksheet.Cells(i, 13), Excel.Range).Value
                dossier.p_mailPerso = DirectCast(worksheet.Cells(i, 14), Excel.Range).Value
                dossier.p_mailPro = DirectCast(worksheet.Cells(i, 15), Excel.Range).Value
                dossier.p_telPerso = DirectCast(worksheet.Cells(i, 16), Excel.Range).Value
                dossier.p_telPro = DirectCast(worksheet.Cells(i, 17), Excel.Range).Value
                dossier.p_cvOuiNon = DirectCast(worksheet.Cells(i, 18), Excel.Range).Value
                dossier.p_lettreMotivationOuiNon = DirectCast(worksheet.Cells(i, 19), Excel.Range).Value
                dossier.p_dateDebutContrat = DirectCast(worksheet.Cells(i, 20), Excel.Range).Value
                dossier.p_dateFinContrat = DirectCast(worksheet.Cells(i, 21), Excel.Range).Value
                dossier.p_acompteOuiNon = DirectCast(worksheet.Cells(i, 22), Excel.Range).Value
                dossier.p_financement = DirectCast(worksheet.Cells(i, 23), Excel.Range).Value
                dossier.p_numeroCheque = DirectCast(worksheet.Cells(i, 24), Excel.Range).Value
                dossier.p_fidelite = DirectCast(worksheet.Cells(i, 25), Excel.Range).Value
                data.Add(dossier)
            Next

            workbook.Close()
            xls.Quit()

            DossierBindingSource.DataSource = data
            releaseObject(worksheet)
            releaseObject(workbook)
            releaseObject(xls)
        End If
    End Sub

    Private Sub DeleteDossier(row As DataGridViewSelectedRowCollection)
        If FileNotFound("C:\UBDXFORM\") = True Then
            MessageBox.Show(Messages.Backup_errorMessage, Messages.Backup_errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim xls As Excel.Application = New Excel.Application()

            If xls Is Nothing Then
                MessageBox.Show(Messages.Excel_BadVersion)
                Return
            End If
            Dim workbook As Excel.Workbook = xls.Workbooks.Open("C:\UBDXFORM\UBDXFORM-backup.xlsx")
            Dim worksheet As Excel.Worksheet = CType(workbook.Sheets(1), Excel.Worksheet)

            worksheet.UsedRange.Rows(dtgDossiers.CurrentCell.RowIndex + 1).Delete()

            workbook.Save()
            workbook.Close()
            xls.Quit()

            releaseObject(worksheet)
            releaseObject(workbook)
            releaseObject(xls)

            For Each item In dtgDossiers.SelectedRows
                dtgDossiers.Rows.RemoveAt(item.Index)
            Next
        End If
    End Sub
End Class