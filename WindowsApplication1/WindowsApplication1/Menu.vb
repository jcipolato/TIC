Imports System.Resources
Imports Microsoft.Office.Interop
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

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim AppRegistryKey As RegistryKey

        AppRegistryKey = Registry.CurrentUser.OpenSubKey("Software\UBDXFORM")

        If IsNothing(AppRegistryKey) Then
            AppRegistryKey = Registry.CurrentUser.CreateSubKey("Software\UBDXFORM", RegistryKeyPermissionCheck.ReadWriteSubTree)
            Dim FirstOpeningMessage As DialogResult = MessageBox.Show(Messages.FirstOpening_Message, Messages.FirstOpening_Title, MessageBoxButtons.OKCancel)

            If FirstOpeningMessage = DialogResult.Cancel Then
                Me.Close()
            ElseIf FirstOpeningMessage = DialogResult.OK Then
                GenerateBackup()
            End If

        End If
    End Sub

    Private Sub GenerateBackup()
        Dim browse As New FolderBrowserDialog()

        If (browse.ShowDialog() = DialogResult.OK) Then
            Dim directory As String = browse.SelectedPath
            Dim xls As Excel.Application = New Excel.Application()
            If xls Is Nothing Then
                MessageBox.Show(Messages.Excel_BadVersion)
                Return
            End If
            Dim workbook As Excel.Workbook = xls.Workbooks.Add(Reflection.Missing.Value)
            Dim worksheet As Excel.Worksheet = CType(workbook.Sheets(1), Excel.Worksheet)
            workbook.SaveAs(directory + "\UBDXFORM-backup.xlsx")
            xls.Quit()

            releaseObject(worksheet)
            releaseObject(workbook)
            releaseObject(xls)

            MessageBox.Show(Messages.Backup_success)
        End If
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class
