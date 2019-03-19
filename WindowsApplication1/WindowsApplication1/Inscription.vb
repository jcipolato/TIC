Imports System.Globalization
Imports Microsoft.Win32

Public Class Inscription
    Private Sub Inscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CountryList()
        SwitchButtonState()
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Close()
    End Sub

    Private Sub txtNumbersOnly_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCP.KeyPress, txtTelPerso.KeyPress, txtTelPro.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
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

    Public Sub CountryList()
        For Each info In CultureInfo.GetCultures(CultureTypes.SpecificCultures)
            Dim ri As RegionInfo = New RegionInfo(info.LCID)
            If Not (cbPays.Items.Contains(ri.DisplayName)) Then
                cbPays.Items.Add(ri.DisplayName)
            End If
        Next

        cbPays.Items.RemoveAt(0)
    End Sub

    Private Sub SwitchButtonState()
        Dim controls As Control() = {txtNom, txtPrenom, txtAdresse, txtCP, txtProfession,
            txtAutre, txtCheque, txtComplement, cbCivilite, cbEmploi, cbEtudes, cbFidelite,
            cbFinancement, cbPays, cbStatut, rbOuiCV, rbNonCV, rbOuiMotiv, rbNonMotiv, rbNonAcompte, rbOuiAcompte}
        For Each item In controls
            AddHandler item.TextChanged, Sub(s, ee)
                                             btnSauvegarder.Enabled = Not controls.Any(Function(box) box.Text = String.Empty)
                                         End Sub

        Next
    End Sub

    Private Sub btnSauvegarder_Click(sender As Object, e As EventArgs) Handles btnSauvegarder.Click
        If Not IsValidEmail(txtMailPerso.Text) And Not IsValidEmail(txtMailPro.Text) Then
            labErreurMail.Visible = True
        ElseIf txtTelPerso.Text.Length < 10 And txtTelPro.Text.Length < 10 Then
            labErreurTel.Visible = True
        End If
    End Sub

    Private Sub cbEtudes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEtudes.SelectedIndexChanged
        If cbEtudes.SelectedItem.ToString = "Autre" Then
            labAutre.Visible = True
            txtAutre.Visible = True
        Else
            labAutre.Visible = False
            txtAutre.Visible = False
        End If
    End Sub
End Class