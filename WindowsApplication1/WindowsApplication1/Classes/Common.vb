Imports System.IO
Imports Microsoft.Office.Interop
Imports WindowsApplication1.My.Resources

Public Class Common
    Public Shared Sub GenerateBackup(path As String)
        Dim xls As Excel.Application = New Excel.Application()

        If xls Is Nothing Then
            MessageBox.Show(Messages.Excel_BadVersion)
            Return
        End If
        Dim workbook As Excel.Workbook = xls.Workbooks.Add(Reflection.Missing.Value)
        Dim worksheet As Excel.Worksheet = CType(workbook.Sheets(1), Excel.Worksheet)

        If (Not Directory.Exists(path)) Then
            Directory.CreateDirectory(path)
        End If
        workbook.SaveAs(path + "\UBDXFORM-backup.xlsx")
        xls.Quit()

        releaseObject(worksheet)
        releaseObject(workbook)
        releaseObject(xls)
        File.SetAttributes(path + "\UBDXFORM-backup.xlsx", FileAttributes.Hidden)

        MessageBox.Show(Messages.Backup_success)
    End Sub

    Public Shared Sub releaseObject(ByVal obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Shared Sub CheckBackup()
        Dim Path As String = "C:\UBDXFORM"
        Dim foundFile As String = String.Empty
        For Each currentFile As String In My.Computer.FileSystem.GetFiles(Path, FileIO.SearchOption.SearchAllSubDirectories, "*.xlsx")
            foundFile = currentFile
        Next

        If String.IsNullOrEmpty(foundFile) Then
            Dim BackupNotFound As DialogResult = MessageBox.Show(Messages.Backup_errorMessage, Messages.Backup_errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)

            If BackupNotFound = DialogResult.OK Then
                GenerateBackup(Path)
            End If
        End If
    End Sub
End Class
