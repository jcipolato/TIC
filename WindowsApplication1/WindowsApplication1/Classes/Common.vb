Public Class Common
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

    Public Shared Function FileNotFound(Path As String) As Boolean
        Dim foundFile As String = String.Empty
        For Each currentFile As String In My.Computer.FileSystem.GetFiles(Path, FileIO.SearchOption.SearchAllSubDirectories, "*.xlsx")
            foundFile = currentFile
        Next

        Return String.IsNullOrEmpty(foundFile)
    End Function
End Class
