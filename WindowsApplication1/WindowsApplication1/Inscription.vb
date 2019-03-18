Public Class Inscription
    Private Sub txtCP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCP.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelPerso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelPerso.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelPro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelPro.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub SauvegarderEnabled(cb As ComboBox)
        If cb.SelectedIndex > -1 Then
            btnSauvegarder.Enabled = True
        Else
            btnSauvegarder.Enabled = False
        End If
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr = New Net.Mail.MailAddress(email)
            Return True
        Catch
            Return False
        End Try
    End Function

    Private Sub Inscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim textboxes As TextBox() = {txtNom, txtPrenom, txtAdresse, txtDateNaissance, txtCP, txtProfession, txtAutre, txtCheque, txtComplement}
        Dim comboboxes As ComboBox() = {cbCivilite, cbEmploi, cbEtudes, cbFidelite, cbFinancement, cbPays, cbStatut}
        For Each tb In textboxes
            AddHandler tb.TextChanged, Sub(s, ee)
                                           btnSauvegarder.Enabled = Not textboxes.Any(Function(box) box.Text = String.Empty)
                                       End Sub
        Next
        For Each cb In comboboxes
            AddHandler cb.SelectedIndexChanged, Sub(s, ee)
                                                    btnSauvegarder.Enabled = Not comboboxes.Any(Function(box) box.SelectedIndex > -1)
                                                End Sub
        Next
    End Sub
End Class