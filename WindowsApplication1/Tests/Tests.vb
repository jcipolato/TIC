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

        dossierTest.p_civilite = "Madame"
        Assert.Equals(dossierTest.p_civilite, "Madame")

        dossierTest.p_nom = "Molia"
        Assert.Equals(dossierTest.p_nom, "Molia")

        dossierTest.p_prenom = "Clara"
        Assert.Equals(dossierTest.p_prenom, "Clara")

        dossierTest.p_dateNaissance = Date.FromOADate(21 / 7 / 1996)
        Assert.Equals(dossierTest.p_dateNaissance, Date.FromOADate(21 / 7 / 1996))

        dossierTest.p_adresse = "9 rue Félix Leclerc"
        Assert.Equals(dossierTest.p_adresse, "9 rue Félix Leclerc")

        dossierTest.p_complementAdresse = " "
        Assert.Equals(dossierTest.p_complementAdresse, " ")

        dossierTest.p_codePostal = 40220
        Assert.Equals(dossierTest.p_codePostal, 40220)

        dossierTest.p_ville = "Tarnos"
        Assert.Equals(dossierTest.p_ville, "Tarnos")

        dossierTest.p_pays = "France"
        Assert.Equals(dossierTest.p_pays, "France")

        dossierTest.p_statut = "Salarié"
        Assert.Equals(dossierTest.p_statut, "Salarié")

        dossierTest.p_niveauEtudes = "Master"
        Assert.Equals(dossierTest.p_niveauEtudes, "Master")

        dossierTest.p_profession = "OnVerra"
        Assert.Equals(dossierTest.p_profession, "OnVerra")

        dossierTest.p_domaineEmploi = "Informatique-Multimédia"
        Assert.Equals(dossierTest.p_domaineEmploi, "Informatique-Multimédia")

        dossierTest.p_mailPerso = "clara.molia@free.fr"
        Assert.Equals(dossierTest.p_mailPerso, "clara.molia@free.fr")

        dossierTest.p_mailPro = ""
        Assert.Equals(dossierTest.p_mailPro, "")

        dossierTest.p_telPerso = 619982620
        Assert.Equals(dossierTest.p_telPerso, 619982620)

        dossierTest.p_telPro = 619982620
        Assert.Equals(dossierTest.p_telPro, 619982620)

        dossierTest.p_cvOuiNon = False
        Assert.Equals(dossierTest.p_cvOuiNon, False)

        dossierTest.p_lettreMotivationOuiNon = False
        Assert.Equals(dossierTest.p_lettreMotivationOuiNon, False)

        dossierTest.p_dateDebutContrat = Date.FromOADate(1 / 10 / 2018)
        Assert.Equals(dossierTest.p_dateDebutContrat, Date.FromOADate(1 / 10 / 2018))

        dossierTest.p_dateFinContrat = Date.FromOADate(1 / 9 / 2020)
        Assert.Equals(dossierTest.p_dateFinContrat, Date.FromOADate(1 / 9 / 2020))

        dossierTest.p_acompteOuiNon = True
        Assert.Equals(dossierTest.p_acompteOuiNon, True)

        dossierTest.p_numeroCheque = 12457845
        Assert.Equals(dossierTest.p_numeroCheque, 12457845)

        dossierTest.p_financement = "Entreprise"
        Assert.Equals(dossierTest.p_financement, "Entreprise")

        dossierTest.p_fidelite = "Autre"
        Assert.Equals(dossierTest.p_fidelite, "Autre")

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