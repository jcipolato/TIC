Imports System.Data
Imports System.Data.OleDb

Public Class Configuration
    Dim conn As OleDbConnection
    Dim dta As OleDbDataAdapter
    Dim dts As DataSet
    Dim excel As String
    Dim OpenFileDialog As New OpenFileDialog
    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click

        Me.Hide()

    End Sub

    Private Sub LabelFichierExcel_Click(sender As Object, e As EventArgs) Handles LabelFichierExcel.Click

    End Sub

    Private Sub TextBoxFichierExcel_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFichierExcel.TextChanged

    End Sub

    Private Sub ButtonParcourir_Click(sender As Object, e As EventArgs) Handles ButtonParcourir.Click
        Try
            OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog.Filter = "All Files (*.*)|*.*|Exel Files(*.xls)|*.xlsx|Xls Files (*.xls)|*.xls"
            If OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                Dim fi As New IO.FileInfo(OpenFileDialog.FileName)
                Dim fileName As String = OpenFileDialog.FileName
                excel = fi.FullName
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 16.0;")
                dta = New OleDbDataAdapter("select * from [Feuil1$]", conn)
                dts = New DataSet
                dta.Fill(dts, "[Feuil1$]")
                Consultation.DataGridView1.DataSource = dts
                Consultation.DataGridView1.DataMember = "[Feuil1$]"
                conn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
            Exit Sub


        End Try
    End Sub
End Class
