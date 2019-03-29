Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports WindowsApplication1

<TestClass()> Public Class Tests

    'MENU

    <TestMethod()> Public Sub Menu_Load_Test()
    End Sub

    <TestMethod()> Public Sub GenerateBackup_Test()
    End Sub

    'DOSSIER

    <TestMethod()> Public Sub Dossier_Properties_Test()
        Dim dossierTest As New Dossier()

        'Setters
        dossierTest.p_civilite = "Madame"
        dossierTest.p_nom = "Molia"
        dossierTest.p_prenom = "Clara"
        dossierTest.p_dateNaissance = Date.FromOADate(21 / 7 / 1996)
        dossierTest.p_adresse = "9 rue Félix Leclerc"
        dossierTest.p_complementAdresse = " "
        dossierTest.p_codePostal = 40220
        dossierTest.p_ville = "Tarnos"
        dossierTest.p_pays = "France"
        dossierTest.p_statut = "Salarié"
        dossierTest.p_niveauEtudes = "Master"
        dossierTest.p_profession = "OnVerra"
        dossierTest.p_domaineEmploi = "Informatique-Multimédia"
        dossierTest.p_mailPerso = "clara.molia@free.fr"
        dossierTest.p_mailPro = ""
        dossierTest.p_telPerso = 619982620
        dossierTest.p_telPro = 619982620
        dossierTest.p_cvOuiNon = False
        dossierTest.p_lettreMotivationOuiNon = False
        dossierTest.p_dateDebutContrat = Date.FromOADate(1 / 10 / 2018)
        dossierTest.p_dateFinContrat = Date.FromOADate(1 / 9 / 2020)
        dossierTest.p_acompteOuiNon = True
        dossierTest.p_numeroCheque = 12457845
        dossierTest.p_financement = "Entreprise"
        dossierTest.p_fidelite = "Autre"

        'EN COURS

        'Getters
        MsgBox(dossierTest.p_civilite + dossierTest.p_nom + dossierTest.p_prenom + Format(dossierTest.p_dateNaissance, "dd/mm/yyyy") +
               dossierTest.p_adresse + dossierTest.p_complementAdresse + CStr(dossierTest.p_codePostal) + dossierTest.p_ville +
               dossierTest.p_pays + dossierTest.p_statut + dossierTest.p_niveauEtudes + dossierTest.p_profession +
               dossierTest.p_domaineEmploi + dossierTest.p_mailPerso + dossierTest.p_mailPro)

        ' + dossierTest.p_telPerso +
        ' dossierTest.p_telPro + dossierTest.p_cvOuiNon + dossierTest.p_lettreMotivationOuiNon + dossierTest.p_dateDebutContrat +
        'dossierTest.p_dateFinContrat + dossierTest.p_acompteOuiNon + dossierTest.p_numeroCheque + dossierTest.p_financement + dossierTest.p_fidelite)



    End Sub


    'INSCRIPTION

    <TestMethod()> Public Sub Inscription_Load_Test()
        CountryList_Test()
        SwitchButtonState_Test()
    End Sub

    <TestMethod()> Public Sub txtNumbersOnly_KeyPress_Test()
    End Sub

    <TestMethod()> Public Sub IsValidEmail_Test()
    End Sub

    <TestMethod()> Public Sub CountryList_Test()
    End Sub

    <TestMethod()> Public Sub SwitchButtonState_Test()
    End Sub

    <TestMethod()> Public Sub btnSauvegarder_Click_Test()
    End Sub

    <TestMethod()> Public Sub cbEtudes_SelectedIndexChanged_Test()
    End Sub

    <TestMethod()> Public Sub FillDossier_Test()
    End Sub

    <TestMethod()> Public Sub addDossier_Test()
    End Sub

    'CONSULTATION

    <TestMethod()> Public Sub Consultattion_Load_Test()
    End Sub

    <TestMethod()> Public Sub btnSupprimer_Click_Test()
    End Sub

    <TestMethod()> Public Sub dtgDossiers_SelectionChanged_Test()
    End Sub

    <TestMethod()> Public Sub ReadBackup_Test()
    End Sub

    <TestMethod()> Public Sub DeleteDossier_Test()
    End Sub

    <TestMethod()> Public Sub dtgDossiers_CellDoubleClick_Test()
    End Sub

    <TestMethod()> Public Sub dtgDossiers_CellEndEdit_Test()
    End Sub

    <TestMethod()> Public Sub findIndex_Test()
    End Sub

End Class