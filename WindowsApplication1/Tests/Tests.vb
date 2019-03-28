Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class Tests

    'MENU

    <TestMethod()> Public Sub Menu_Load_Test()
    End Sub

    <TestMethod()> Public Sub GenerateBackup_Test()
    End Sub

    'DOSSIER

    <TestMethod()> Public Sub Dossier_Properties_Test()
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