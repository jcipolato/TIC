Imports System.IO
Imports System.Resources
Imports System.Security.AccessControl
Imports Microsoft.Office.Interop
Imports Microsoft.Win32
Imports WindowsApplication1.My.Resources

Public Class Menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInscription.Click
        Inscription.Show()

    End Sub

    Private Sub ButtonConsultation_Click(sender As Object, e As EventArgs) Handles btnConsultation.Click
        Consultation.Show()

    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim AppRegistryKey As RegistryKey

        AppRegistryKey = Registry.CurrentUser.OpenSubKey("Software\UBDXFORM")

        If IsNothing(AppRegistryKey) Then
            AppRegistryKey = Registry.CurrentUser.CreateSubKey("Software\UBDXFORM", RegistryKeyPermissionCheck.ReadWriteSubTree)
            Dim FirstOpeningMessage As DialogResult = MessageBox.Show(Messages.FirstOpening_Message, Messages.FirstOpening_Title, MessageBoxButtons.OKCancel)

            If FirstOpeningMessage = DialogResult.Cancel Then
                Me.Close()
            ElseIf FirstOpeningMessage = DialogResult.OK Then
                Common.GenerateBackup("C:\UBDXFORM")
            End If
        Else
            Common.CheckBackup()
        End If
    End Sub

End Class
