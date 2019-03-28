Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Office.Interop
Imports WindowsApplication1.Common
Imports WindowsApplication1.My.Resources

Public Class Consultation
    Private data As List(Of Dossier) = New List(Of Dossier)()
    Private old_value

    Private Sub Consultation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each column In dtgDossiers.Columns
            column.ReadOnly = True
        Next
        ReadBackup()
    End Sub

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Close()
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If dtgDossiers.SelectedRows.Count > 0 Then
            MessageBox.Show(Messages.DeleteDossier_Message, Messages.DeleteDossier_Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If DialogResult.Yes Then
                DeleteDossier()
            End If
        End If
    End Sub

    Private Sub dtgDossiers_SelectionChanged(sender As Object, e As EventArgs) Handles dtgDossiers.SelectionChanged
        If dtgDossiers.SelectedRows.Count > 1 Then
            btnSupprimer.Enabled = False
            btnGenerer.Enabled = True
        ElseIf dtgDossiers.SelectedRows.Count > 0 Then
            btnGenerer.Enabled = True
            btnSupprimer.Enabled = True
        Else
            btnSupprimer.Enabled = False
            btnGenerer.Enabled = False
        End If
    End Sub

    Private Sub ReadBackup()

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
                dossier.p_statut = DirectCast(worksheet.Cells(i, 10), Excel.Range).Value
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
                dossier.p_numeroCheque = DirectCast(worksheet.Cells(i, 23), Excel.Range).Value
                dossier.p_financement = DirectCast(worksheet.Cells(i, 24), Excel.Range).Value
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

    Private Sub DeleteDossier()
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

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged
        dtgDossiers.Rows(findIndex()).Selected = True
    End Sub

    Private Sub dtgDossiers_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgDossiers.CellDoubleClick
        If (e.RowIndex > -1) Then
            dtgDossiers(e.ColumnIndex, e.RowIndex).ReadOnly = False
            old_value = dtgDossiers(e.ColumnIndex, e.RowIndex).Value
            dtgDossiers.BeginEdit(True)
        End If
    End Sub

    Private Sub dtgDossiers_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dtgDossiers.CellEndEdit
        Dim currentcell = dtgDossiers(e.ColumnIndex, e.RowIndex)
        If currentcell.Value <> old_value Then
            Dim confirmation = MessageBox.Show(Messages.EditDossier_Message, Messages.EditDossier_Title, MessageBoxButtons.YesNo)
            If confirmation = DialogResult.Yes Then
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

                    Dim cell = worksheet.UsedRange.Find(old_value)
                    worksheet.UsedRange.Cells(cell.Row, cell.Column) = currentcell.Value

                    workbook.Save()
                    workbook.Close()
                    xls.Quit()

                    releaseObject(worksheet)
                    releaseObject(workbook)
                    releaseObject(xls)

                    MessageBox.Show(Messages.EditDossier_Success)
                End If
            Else
                Dim dossier As Dossier = dtgDossiers.CurrentRow.DataBoundItem
                For Each prop In dossier.GetType.GetProperties
                    If dtgDossiers.Columns(dtgDossiers.CurrentCell.ColumnIndex).DataPropertyName = prop.Name Then
                        prop.SetValue(dossier, old_value)
                    End If
                Next
            End If
            currentcell.ReadOnly = True
        End If
    End Sub

    Private Function findIndex() As Integer
        For Each dossier In DossierBindingSource.DataSource
            For Each prop In dossier.GetType.GetProperties
                Dim search As String = prop.GetValue(dossier)
                If search.Contains(txtRechercher.Text) Then
                    Return DossierBindingSource.IndexOf(dossier)
                End If
            Next
        Next
        Return 0
    End Function

    Private Sub cbTrier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTrier.SelectedIndexChanged
        For Each column In dtgDossiers.Columns
            If cbTrier.SelectedItem = column.HeaderText Then
                TrieDataGridView(dtgDossiers, column.Index)
            End If
        Next
    End Sub

    Private Sub TrieDataGridView(ByRef DGV As DataGridView, ByVal IndiceColonneATrier As Integer)
        If DGV.Rows.Count < 2 Then
            Exit Sub
        End If
        Dim TemoinDePermutation As Boolean = True
        Dim Tmp(DGV.Columns.Count - 1) As String
        While TemoinDePermutation
            TemoinDePermutation = False
            For R As Integer = 0 To DGV.Rows.Count - 2
                If DGV.Item(IndiceColonneATrier, R).Value > DGV.Item(IndiceColonneATrier, R + 1).Value Then
                    For C As Integer = 0 To DGV.Columns.Count - 1
                        Tmp(C) = DGV.Item(C, R).Value
                    Next
                    For C As Integer = 0 To DGV.Columns.Count - 1
                        DGV.Item(C, R).Value = DGV.Item(C, R + 1).Value
                    Next
                    For C As Integer = 0 To DGV.Columns.Count - 1
                        DGV.Item(C, R + 1).Value = Tmp(C)
                    Next
                    TemoinDePermutation = True
                End If
            Next
        End While
    End Sub

    Private Sub btnGenerer_Click(sender As Object, e As EventArgs) Handles btnGenerer.Click
        RemplirWord(dtgDossiers.CurrentRow.DataBoundItem)
    End Sub

    Private Sub RemplirWord(dossier As Dossier)
        Dim word As Word.Application = CreateObject("Word.Application")
        Try
            Dim path = "C:\Users\" + Environment.UserName + "\Downloads\Dossier-" + dossier.p_nom + "-" + dossier.p_prenom + ".docx"
            If Not File.Exists(path) Then
                My.Computer.FileSystem.CopyFile("C:\UBDXFORM\Dossier.docx", path)
                File.SetAttributes(path, FileAttributes.Normal)
            End If

            Dim doc As Word.Document = word.Documents.Open(path)

            For Each table In doc.Tables
                table.Cell(2, 2).Range.Text = dossier.p_nom
                table.Cell(3, 2).Range.Text = dossier.p_prenom
                table.Cell(4, 2).Range.Text = dossier.p_dateNaissance
                If Not String.IsNullOrEmpty(dossier.p_complementAdresse) Then
                    table.Cell(5, 2).Range.Text = dossier.p_adresse + " - " + dossier.p_complementAdresse
                Else
                    table.Cell(5, 2).Range.Text = dossier.p_adresse
                End If
                table.Cell(6, 2).Range.Text = dossier.p_codePostal
                table.Cell(7, 2).Range.Text = dossier.p_ville
                table.Cell(8, 2).Range.Text = dossier.p_telPro
                table.Cell(9, 2).Range.Text = dossier.p_telPerso
                table.Cell(10, 2).Range.Text = dossier.p_mailPerso
                table.Cell(11, 2).Range.Text = dossier.p_mailPro
                Select Case dossier.p_niveauEtudes
                    Case "Licence"
                        doc.ContentControls(1).Checked = True
                    Case "Master"
                        doc.ContentControls(2).Checked = True
                    Case "BTS"
                        doc.ContentControls(3).Checked = True
                    Case "DEUG"
                        doc.ContentControls(4).Checked = True
                    Case "Baccalauréat"
                        doc.ContentControls(5).Checked = True
                    Case Else
                        doc.ContentControls(6).Checked = True
                        doc.Content.Find.Execute(FindText:="(préciser) : ", ReplaceWith:="(préciser) : " + dossier.p_niveauEtudes)
                End Select
                table.Cell(13, 2).Range.Text = dossier.p_profession
                doc.ContentControls(7).Checked = dossier.p_domaineEmploi = "Art"
                doc.ContentControls(8).Checked = dossier.p_domaineEmploi = "Droit"
                doc.ContentControls(9).Checked = dossier.p_domaineEmploi = "Environnement"
                doc.ContentControls(10).Checked = dossier.p_domaineEmploi = "Médecine-Santé"
                doc.ContentControls(11).Checked = dossier.p_domaineEmploi = "Sport"
                doc.ContentControls(12).Checked = dossier.p_domaineEmploi = "Autre"
                doc.ContentControls(13).Checked = dossier.p_domaineEmploi = "Biologie-Chimie-Physique"
                doc.ContentControls(14).Checked = dossier.p_domaineEmploi = "Economie-Administrations"
                doc.ContentControls(15).Checked = dossier.p_domaineEmploi = "Hôtellerie-Tourisme"
                doc.ContentControls(16).Checked = dossier.p_domaineEmploi = "Média-Communication"
                doc.ContentControls(17).Checked = dossier.p_domaineEmploi = "Transports"
                doc.ContentControls(18).Checked = dossier.p_domaineEmploi = "Commerce-Services"
                doc.ContentControls(19).Checked = dossier.p_domaineEmploi = "Enseignement"
                doc.ContentControls(20).Checked = dossier.p_domaineEmploi = "Informatique-Multimédia"
                doc.ContentControls(21).Checked = dossier.p_domaineEmploi = "Social-Sciences Humaines"
                doc.ContentControls(22).Checked = dossier.p_domaineEmploi = "Technique"

                doc.ContentControls(23).Checked = dossier.p_financement = "Financement propre"
                doc.ContentControls(24).Checked = dossier.p_financement = "Entreprise"
                doc.ContentControls(25).Checked = dossier.p_financement = "OPCA"

                doc.ContentControls(26).Checked = dossier.p_fidelite = "Relation personnelle"
                doc.ContentControls(27).Checked = dossier.p_fidelite = "Presse audiovisuelle"
                doc.ContentControls(28).Checked = dossier.p_fidelite = "Site École"
                doc.ContentControls(29).Checked = dossier.p_fidelite = "Réseaux sociaux"
                doc.ContentControls(30).Checked = dossier.p_fidelite = "Presse écrite"
                doc.ContentControls(31).Checked = dossier.p_fidelite = "Site Institutionnelle"
                doc.ContentControls(32).Checked = dossier.p_fidelite = "Réseaux sociaux Institutionnel"
                doc.ContentControls(33).Checked = dossier.p_fidelite = "Autre"

                doc.ContentControls(34).Checked = Not String.IsNullOrEmpty(dossier.p_numeroCheque)
                doc.ContentControls(35).Checked = String.IsNullOrEmpty(dossier.p_numeroCheque)
                doc.ContentControls(36).Checked = dossier.p_cvOuiNon
                doc.ContentControls(37).Checked = dossier.p_cvOuiNon = False
                doc.ContentControls(38).Checked = dossier.p_lettreMotivationOuiNon
                doc.ContentControls(39).Checked = dossier.p_lettreMotivationOuiNon = False
                doc.ContentControls(40).Checked = dossier.p_acompteOuiNon
                doc.ContentControls(41).Checked = dossier.p_acompteOuiNon = False
            Next

            doc.Save()
            doc.Close()
            word.Quit()

            releaseObject(doc)
            releaseObject(word)

            MessageBox.Show(Messages.GenerateDossier_Success)
        Catch ex As Exception
            word.Quit()
        End Try
    End Sub
End Class