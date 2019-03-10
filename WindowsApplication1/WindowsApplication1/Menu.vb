Imports System.Resources
Imports Microsoft.Win32
Imports WindowsApplication1.My.Resources

Public Class Menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonInscription.Click
        Inscription.Show()

    End Sub

    Private Sub ButtonConsultaion_Click(sender As Object, e As EventArgs) Handles ButtonConsultaion.Click
        Consultation.Show()

    End Sub

    Private Sub ButtonConfiguration_Click(sender As Object, e As EventArgs) Handles ButtonConfiguration.Click
        Configuration.Show()

    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim AppRegistryKey As RegistryKey

        AppRegistryKey = Registry.CurrentUser.OpenSubKey("Software\UBDXFORM")

        If IsNothing(AppRegistryKey) Then
            AppRegistryKey = Registry.CurrentUser.CreateSubKey("Software\UBDXFORM", RegistryKeyPermissionCheck.ReadWriteSubTree)
            Dim FirstOpeningMessage = MessageBox.Show(Messages.FirstOpening_Message, Messages.FirstOpening_Title, MessageBoxButtons.OKCancel)

            If FirstOpeningMessage = DialogResult.Cancel Then
                Me.Close()
            End If
        End If
    End Sub
End Class
