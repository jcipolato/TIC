<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inscription
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LabelTel = New System.Windows.Forms.Label()
        Me.LabelMail = New System.Windows.Forms.Label()
        Me.TextBoxTelPro = New System.Windows.Forms.TextBox()
        Me.TextBoxTelPerso = New System.Windows.Forms.TextBox()
        Me.TextBoxMailPro = New System.Windows.Forms.TextBox()
        Me.TextBoxMailPerso = New System.Windows.Forms.TextBox()
        Me.LabelProtel = New System.Windows.Forms.Label()
        Me.LabelPersoTel = New System.Windows.Forms.Label()
        Me.LabelProMail = New System.Windows.Forms.Label()
        Me.LabelPerso = New System.Windows.Forms.Label()
        Me.PanelProfession = New System.Windows.Forms.Panel()
        Me.TextBoxProfession = New System.Windows.Forms.TextBox()
        Me.TextBoxDiplome = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelDiplome = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBoxRegion = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPays = New System.Windows.Forms.ComboBox()
        Me.TextBoxAdresse = New System.Windows.Forms.TextBox()
        Me.LabelRegion = New System.Windows.Forms.Label()
        Me.LabelPays = New System.Windows.Forms.Label()
        Me.LabelAdresse = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBoxCivilite = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerDateNaissance = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.LabelPrenom = New System.Windows.Forms.Label()
        Me.LabelDateNaissance = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.LabelCivilite = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RichTextBoxCommentaire = New System.Windows.Forms.RichTextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.ComboBoxSatus = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerDateFin = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerDateDebut = New System.Windows.Forms.DateTimePicker()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.LabelDateFinDeContrat = New System.Windows.Forms.Label()
        Me.LabelDateDebutContrat = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.RadioButtonNonMotiv = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOuiMotiv = New System.Windows.Forms.RadioButton()
        Me.RadioButtonNonCurry = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOuiCurry = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOuiCurri = New System.Windows.Forms.RadioButton()
        Me.LabelLettreMotiv = New System.Windows.Forms.Label()
        Me.LabelCurri = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TextBoxNumeroCheque = New System.Windows.Forms.TextBox()
        Me.TextBoxAccompte = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelAccompte = New System.Windows.Forms.Label()
        Me.Sauvegarder = New System.Windows.Forms.Button()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelProfession.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.PanelProfession)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(390, 442)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.LabelTel)
        Me.Panel5.Controls.Add(Me.LabelMail)
        Me.Panel5.Controls.Add(Me.TextBoxTelPro)
        Me.Panel5.Controls.Add(Me.TextBoxTelPerso)
        Me.Panel5.Controls.Add(Me.TextBoxMailPro)
        Me.Panel5.Controls.Add(Me.TextBoxMailPerso)
        Me.Panel5.Controls.Add(Me.LabelProtel)
        Me.Panel5.Controls.Add(Me.LabelPersoTel)
        Me.Panel5.Controls.Add(Me.LabelProMail)
        Me.Panel5.Controls.Add(Me.LabelPerso)
        Me.Panel5.Location = New System.Drawing.Point(13, 303)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(363, 126)
        Me.Panel5.TabIndex = 4
        '
        'LabelTel
        '
        Me.LabelTel.AutoSize = True
        Me.LabelTel.Location = New System.Drawing.Point(2, 64)
        Me.LabelTel.Name = "LabelTel"
        Me.LabelTel.Size = New System.Drawing.Size(22, 13)
        Me.LabelTel.TabIndex = 10
        Me.LabelTel.Text = "Tel"
        '
        'LabelMail
        '
        Me.LabelMail.AutoSize = True
        Me.LabelMail.Location = New System.Drawing.Point(2, 10)
        Me.LabelMail.Name = "LabelMail"
        Me.LabelMail.Size = New System.Drawing.Size(26, 13)
        Me.LabelMail.TabIndex = 9
        Me.LabelMail.Text = "Mail"
        '
        'TextBoxTelPro
        '
        Me.TextBoxTelPro.Location = New System.Drawing.Point(245, 85)
        Me.TextBoxTelPro.Name = "TextBoxTelPro"
        Me.TextBoxTelPro.Size = New System.Drawing.Size(110, 20)
        Me.TextBoxTelPro.TabIndex = 8
        '
        'TextBoxTelPerso
        '
        Me.TextBoxTelPerso.Location = New System.Drawing.Point(57, 85)
        Me.TextBoxTelPerso.Name = "TextBoxTelPerso"
        Me.TextBoxTelPerso.Size = New System.Drawing.Size(110, 20)
        Me.TextBoxTelPerso.TabIndex = 7
        '
        'TextBoxMailPro
        '
        Me.TextBoxMailPro.Location = New System.Drawing.Point(245, 33)
        Me.TextBoxMailPro.Name = "TextBoxMailPro"
        Me.TextBoxMailPro.Size = New System.Drawing.Size(110, 20)
        Me.TextBoxMailPro.TabIndex = 6
        '
        'TextBoxMailPerso
        '
        Me.TextBoxMailPerso.Location = New System.Drawing.Point(57, 33)
        Me.TextBoxMailPerso.Name = "TextBoxMailPerso"
        Me.TextBoxMailPerso.Size = New System.Drawing.Size(110, 20)
        Me.TextBoxMailPerso.TabIndex = 5
        '
        'LabelProtel
        '
        Me.LabelProtel.AutoSize = True
        Me.LabelProtel.Location = New System.Drawing.Point(216, 88)
        Me.LabelProtel.Name = "LabelProtel"
        Me.LabelProtel.Size = New System.Drawing.Size(23, 13)
        Me.LabelProtel.TabIndex = 4
        Me.LabelProtel.Text = "Pro"
        '
        'LabelPersoTel
        '
        Me.LabelPersoTel.AutoSize = True
        Me.LabelPersoTel.Location = New System.Drawing.Point(15, 88)
        Me.LabelPersoTel.Name = "LabelPersoTel"
        Me.LabelPersoTel.Size = New System.Drawing.Size(34, 13)
        Me.LabelPersoTel.TabIndex = 3
        Me.LabelPersoTel.Text = "Perso"
        '
        'LabelProMail
        '
        Me.LabelProMail.AutoSize = True
        Me.LabelProMail.Location = New System.Drawing.Point(216, 36)
        Me.LabelProMail.Name = "LabelProMail"
        Me.LabelProMail.Size = New System.Drawing.Size(23, 13)
        Me.LabelProMail.TabIndex = 2
        Me.LabelProMail.Text = "Pro"
        '
        'LabelPerso
        '
        Me.LabelPerso.AutoSize = True
        Me.LabelPerso.Location = New System.Drawing.Point(15, 36)
        Me.LabelPerso.Name = "LabelPerso"
        Me.LabelPerso.Size = New System.Drawing.Size(34, 13)
        Me.LabelPerso.TabIndex = 1
        Me.LabelPerso.Text = "Perso"
        '
        'PanelProfession
        '
        Me.PanelProfession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelProfession.Controls.Add(Me.TextBoxProfession)
        Me.PanelProfession.Controls.Add(Me.TextBoxDiplome)
        Me.PanelProfession.Controls.Add(Me.Label9)
        Me.PanelProfession.Controls.Add(Me.LabelDiplome)
        Me.PanelProfession.Location = New System.Drawing.Point(13, 228)
        Me.PanelProfession.Name = "PanelProfession"
        Me.PanelProfession.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PanelProfession.Size = New System.Drawing.Size(363, 59)
        Me.PanelProfession.TabIndex = 3
        '
        'TextBoxProfession
        '
        Me.TextBoxProfession.Location = New System.Drawing.Point(245, 15)
        Me.TextBoxProfession.Name = "TextBoxProfession"
        Me.TextBoxProfession.Size = New System.Drawing.Size(110, 20)
        Me.TextBoxProfession.TabIndex = 7
        '
        'TextBoxDiplome
        '
        Me.TextBoxDiplome.Location = New System.Drawing.Point(57, 15)
        Me.TextBoxDiplome.Name = "TextBoxDiplome"
        Me.TextBoxDiplome.Size = New System.Drawing.Size(110, 20)
        Me.TextBoxDiplome.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(183, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Profession"
        '
        'LabelDiplome
        '
        Me.LabelDiplome.AutoSize = True
        Me.LabelDiplome.Location = New System.Drawing.Point(12, 18)
        Me.LabelDiplome.Name = "LabelDiplome"
        Me.LabelDiplome.Size = New System.Drawing.Size(45, 13)
        Me.LabelDiplome.TabIndex = 4
        Me.LabelDiplome.Text = "Diplôme"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ComboBoxRegion)
        Me.Panel2.Controls.Add(Me.ComboBoxPays)
        Me.Panel2.Controls.Add(Me.TextBoxAdresse)
        Me.Panel2.Controls.Add(Me.LabelRegion)
        Me.Panel2.Controls.Add(Me.LabelPays)
        Me.Panel2.Controls.Add(Me.LabelAdresse)
        Me.Panel2.Location = New System.Drawing.Point(13, 126)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(363, 85)
        Me.Panel2.TabIndex = 2
        '
        'ComboBoxRegion
        '
        Me.ComboBoxRegion.FormattingEnabled = True
        Me.ComboBoxRegion.Location = New System.Drawing.Point(245, 46)
        Me.ComboBoxRegion.Name = "ComboBoxRegion"
        Me.ComboBoxRegion.Size = New System.Drawing.Size(110, 21)
        Me.ComboBoxRegion.TabIndex = 8
        '
        'ComboBoxPays
        '
        Me.ComboBoxPays.FormattingEnabled = True
        Me.ComboBoxPays.Location = New System.Drawing.Point(57, 46)
        Me.ComboBoxPays.Name = "ComboBoxPays"
        Me.ComboBoxPays.Size = New System.Drawing.Size(110, 21)
        Me.ComboBoxPays.TabIndex = 7
        '
        'TextBoxAdresse
        '
        Me.TextBoxAdresse.Location = New System.Drawing.Point(57, 9)
        Me.TextBoxAdresse.Name = "TextBoxAdresse"
        Me.TextBoxAdresse.Size = New System.Drawing.Size(298, 20)
        Me.TextBoxAdresse.TabIndex = 6
        '
        'LabelRegion
        '
        Me.LabelRegion.AutoSize = True
        Me.LabelRegion.Location = New System.Drawing.Point(194, 49)
        Me.LabelRegion.Name = "LabelRegion"
        Me.LabelRegion.Size = New System.Drawing.Size(41, 13)
        Me.LabelRegion.TabIndex = 3
        Me.LabelRegion.Text = "Région"
        '
        'LabelPays
        '
        Me.LabelPays.AutoSize = True
        Me.LabelPays.Location = New System.Drawing.Point(10, 49)
        Me.LabelPays.Name = "LabelPays"
        Me.LabelPays.Size = New System.Drawing.Size(30, 13)
        Me.LabelPays.TabIndex = 2
        Me.LabelPays.Text = "Pays"
        '
        'LabelAdresse
        '
        Me.LabelAdresse.AutoSize = True
        Me.LabelAdresse.Location = New System.Drawing.Point(6, 12)
        Me.LabelAdresse.Name = "LabelAdresse"
        Me.LabelAdresse.Size = New System.Drawing.Size(45, 13)
        Me.LabelAdresse.TabIndex = 1
        Me.LabelAdresse.Text = "Adresse"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ComboBoxCivilite)
        Me.Panel3.Controls.Add(Me.DateTimePickerDateNaissance)
        Me.Panel3.Controls.Add(Me.TextBoxNom)
        Me.Panel3.Controls.Add(Me.TextBoxPrenom)
        Me.Panel3.Controls.Add(Me.LabelPrenom)
        Me.Panel3.Controls.Add(Me.LabelDateNaissance)
        Me.Panel3.Controls.Add(Me.LabelNom)
        Me.Panel3.Controls.Add(Me.LabelCivilite)
        Me.Panel3.Location = New System.Drawing.Point(13, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(363, 95)
        Me.Panel3.TabIndex = 1
        '
        'ComboBoxCivilite
        '
        Me.ComboBoxCivilite.FormattingEnabled = True
        Me.ComboBoxCivilite.Location = New System.Drawing.Point(57, 7)
        Me.ComboBoxCivilite.Name = "ComboBoxCivilite"
        Me.ComboBoxCivilite.Size = New System.Drawing.Size(85, 21)
        Me.ComboBoxCivilite.TabIndex = 12
        '
        'DateTimePickerDateNaissance
        '
        Me.DateTimePickerDateNaissance.Location = New System.Drawing.Point(120, 64)
        Me.DateTimePickerDateNaissance.Name = "DateTimePickerDateNaissance"
        Me.DateTimePickerDateNaissance.Size = New System.Drawing.Size(177, 20)
        Me.DateTimePickerDateNaissance.TabIndex = 11
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(57, 34)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(110, 20)
        Me.TextBoxNom.TabIndex = 5
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Location = New System.Drawing.Point(245, 34)
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(110, 20)
        Me.TextBoxPrenom.TabIndex = 4
        '
        'LabelPrenom
        '
        Me.LabelPrenom.AutoSize = True
        Me.LabelPrenom.Location = New System.Drawing.Point(194, 37)
        Me.LabelPrenom.Name = "LabelPrenom"
        Me.LabelPrenom.Size = New System.Drawing.Size(43, 13)
        Me.LabelPrenom.TabIndex = 3
        Me.LabelPrenom.Text = "Prenom"
        '
        'LabelDateNaissance
        '
        Me.LabelDateNaissance.AutoSize = True
        Me.LabelDateNaissance.Location = New System.Drawing.Point(12, 70)
        Me.LabelDateNaissance.Name = "LabelDateNaissance"
        Me.LabelDateNaissance.Size = New System.Drawing.Size(102, 13)
        Me.LabelDateNaissance.TabIndex = 2
        Me.LabelDateNaissance.Text = "Date de naissance :"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Location = New System.Drawing.Point(12, 37)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(29, 13)
        Me.LabelNom.TabIndex = 1
        Me.LabelNom.Text = "Nom"
        '
        'LabelCivilite
        '
        Me.LabelCivilite.AutoSize = True
        Me.LabelCivilite.Location = New System.Drawing.Point(12, 10)
        Me.LabelCivilite.Name = "LabelCivilite"
        Me.LabelCivilite.Size = New System.Drawing.Size(37, 13)
        Me.LabelCivilite.TabIndex = 0
        Me.LabelCivilite.Text = "Civilité"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.RichTextBoxCommentaire)
        Me.Panel4.Controls.Add(Me.Panel8)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Location = New System.Drawing.Point(426, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(396, 503)
        Me.Panel4.TabIndex = 1
        '
        'RichTextBoxCommentaire
        '
        Me.RichTextBoxCommentaire.Location = New System.Drawing.Point(14, 368)
        Me.RichTextBoxCommentaire.Name = "RichTextBoxCommentaire"
        Me.RichTextBoxCommentaire.Size = New System.Drawing.Size(363, 117)
        Me.RichTextBoxCommentaire.TabIndex = 9
        Me.RichTextBoxCommentaire.Text = "Commentaire"
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.ComboBoxSatus)
        Me.Panel8.Controls.Add(Me.DateTimePickerDateFin)
        Me.Panel8.Controls.Add(Me.DateTimePickerDateDebut)
        Me.Panel8.Controls.Add(Me.LabelStatus)
        Me.Panel8.Controls.Add(Me.LabelDateFinDeContrat)
        Me.Panel8.Controls.Add(Me.LabelDateDebutContrat)
        Me.Panel8.Location = New System.Drawing.Point(14, 16)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel8.Size = New System.Drawing.Size(363, 115)
        Me.Panel8.TabIndex = 8
        '
        'ComboBoxSatus
        '
        Me.ComboBoxSatus.FormattingEnabled = True
        Me.ComboBoxSatus.Location = New System.Drawing.Point(131, 77)
        Me.ComboBoxSatus.Name = "ComboBoxSatus"
        Me.ComboBoxSatus.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxSatus.TabIndex = 15
        '
        'DateTimePickerDateFin
        '
        Me.DateTimePickerDateFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerDateFin.Location = New System.Drawing.Point(206, 30)
        Me.DateTimePickerDateFin.Name = "DateTimePickerDateFin"
        Me.DateTimePickerDateFin.Size = New System.Drawing.Size(135, 20)
        Me.DateTimePickerDateFin.TabIndex = 14
        '
        'DateTimePickerDateDebut
        '
        Me.DateTimePickerDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerDateDebut.Location = New System.Drawing.Point(26, 30)
        Me.DateTimePickerDateDebut.Name = "DateTimePickerDateDebut"
        Me.DateTimePickerDateDebut.Size = New System.Drawing.Size(143, 20)
        Me.DateTimePickerDateDebut.TabIndex = 13
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(87, 80)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(38, 13)
        Me.LabelStatus.TabIndex = 6
        Me.LabelStatus.Text = "Statue"
        '
        'LabelDateFinDeContrat
        '
        Me.LabelDateFinDeContrat.AutoSize = True
        Me.LabelDateFinDeContrat.Location = New System.Drawing.Point(221, 9)
        Me.LabelDateFinDeContrat.Name = "LabelDateFinDeContrat"
        Me.LabelDateFinDeContrat.Size = New System.Drawing.Size(110, 13)
        Me.LabelDateFinDeContrat.TabIndex = 5
        Me.LabelDateFinDeContrat.Text = "Date de fin de contrat"
        '
        'LabelDateDebutContrat
        '
        Me.LabelDateDebutContrat.AutoSize = True
        Me.LabelDateDebutContrat.Location = New System.Drawing.Point(35, 9)
        Me.LabelDateDebutContrat.Name = "LabelDateDebutContrat"
        Me.LabelDateDebutContrat.Size = New System.Drawing.Size(126, 13)
        Me.LabelDateDebutContrat.TabIndex = 4
        Me.LabelDateDebutContrat.Text = "Date de début de contrat"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.RadioButtonNonMotiv)
        Me.Panel7.Controls.Add(Me.RadioButtonOuiMotiv)
        Me.Panel7.Controls.Add(Me.RadioButtonNonCurry)
        Me.Panel7.Controls.Add(Me.RadioButtonOuiCurry)
        Me.Panel7.Controls.Add(Me.RadioButtonOuiCurri)
        Me.Panel7.Controls.Add(Me.LabelLettreMotiv)
        Me.Panel7.Controls.Add(Me.LabelCurri)
        Me.Panel7.Location = New System.Drawing.Point(14, 148)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel7.Size = New System.Drawing.Size(363, 83)
        Me.Panel7.TabIndex = 5
        '
        'RadioButtonNonMotiv
        '
        Me.RadioButtonNonMotiv.AutoSize = True
        Me.RadioButtonNonMotiv.Location = New System.Drawing.Point(286, 44)
        Me.RadioButtonNonMotiv.Name = "RadioButtonNonMotiv"
        Me.RadioButtonNonMotiv.Size = New System.Drawing.Size(45, 17)
        Me.RadioButtonNonMotiv.TabIndex = 11
        Me.RadioButtonNonMotiv.TabStop = True
        Me.RadioButtonNonMotiv.Text = "Non"
        Me.RadioButtonNonMotiv.UseVisualStyleBackColor = True
        '
        'RadioButtonOuiMotiv
        '
        Me.RadioButtonOuiMotiv.AutoSize = True
        Me.RadioButtonOuiMotiv.Location = New System.Drawing.Point(234, 45)
        Me.RadioButtonOuiMotiv.Name = "RadioButtonOuiMotiv"
        Me.RadioButtonOuiMotiv.Size = New System.Drawing.Size(41, 17)
        Me.RadioButtonOuiMotiv.TabIndex = 10
        Me.RadioButtonOuiMotiv.TabStop = True
        Me.RadioButtonOuiMotiv.Text = "Oui"
        Me.RadioButtonOuiMotiv.UseVisualStyleBackColor = True
        '
        'RadioButtonNonCurry
        '
        Me.RadioButtonNonCurry.AutoSize = True
        Me.RadioButtonNonCurry.Location = New System.Drawing.Point(85, 45)
        Me.RadioButtonNonCurry.Name = "RadioButtonNonCurry"
        Me.RadioButtonNonCurry.Size = New System.Drawing.Size(45, 17)
        Me.RadioButtonNonCurry.TabIndex = 8
        Me.RadioButtonNonCurry.TabStop = True
        Me.RadioButtonNonCurry.Text = "Non"
        Me.RadioButtonNonCurry.UseVisualStyleBackColor = True
        '
        'RadioButtonOuiCurry
        '
        Me.RadioButtonOuiCurry.AutoSize = True
        Me.RadioButtonOuiCurry.Location = New System.Drawing.Point(38, 45)
        Me.RadioButtonOuiCurry.Name = "RadioButtonOuiCurry"
        Me.RadioButtonOuiCurry.Size = New System.Drawing.Size(41, 17)
        Me.RadioButtonOuiCurry.TabIndex = 7
        Me.RadioButtonOuiCurry.TabStop = True
        Me.RadioButtonOuiCurry.Text = "Oui"
        Me.RadioButtonOuiCurry.UseVisualStyleBackColor = True
        '
        'RadioButtonOuiCurri
        '
        Me.RadioButtonOuiCurri.AutoSize = True
        Me.RadioButtonOuiCurri.Location = New System.Drawing.Point(-34, 44)
        Me.RadioButtonOuiCurri.Name = "RadioButtonOuiCurri"
        Me.RadioButtonOuiCurri.Size = New System.Drawing.Size(41, 17)
        Me.RadioButtonOuiCurri.TabIndex = 6
        Me.RadioButtonOuiCurri.TabStop = True
        Me.RadioButtonOuiCurri.Text = "Oui"
        Me.RadioButtonOuiCurri.UseVisualStyleBackColor = True
        '
        'LabelLettreMotiv
        '
        Me.LabelLettreMotiv.AutoSize = True
        Me.LabelLettreMotiv.Location = New System.Drawing.Point(231, 18)
        Me.LabelLettreMotiv.Name = "LabelLettreMotiv"
        Me.LabelLettreMotiv.Size = New System.Drawing.Size(100, 13)
        Me.LabelLettreMotiv.TabIndex = 5
        Me.LabelLettreMotiv.Text = "Lettre de motivation"
        '
        'LabelCurri
        '
        Me.LabelCurri.AutoSize = True
        Me.LabelCurri.Location = New System.Drawing.Point(35, 18)
        Me.LabelCurri.Name = "LabelCurri"
        Me.LabelCurri.Size = New System.Drawing.Size(82, 13)
        Me.LabelCurri.TabIndex = 4
        Me.LabelCurri.Text = "Curriculum vitae"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.TextBoxNumeroCheque)
        Me.Panel6.Controls.Add(Me.TextBoxAccompte)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.LabelAccompte)
        Me.Panel6.Location = New System.Drawing.Point(14, 247)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel6.Size = New System.Drawing.Size(363, 106)
        Me.Panel6.TabIndex = 4
        '
        'TextBoxNumeroCheque
        '
        Me.TextBoxNumeroCheque.Location = New System.Drawing.Point(175, 45)
        Me.TextBoxNumeroCheque.Name = "TextBoxNumeroCheque"
        Me.TextBoxNumeroCheque.Size = New System.Drawing.Size(166, 20)
        Me.TextBoxNumeroCheque.TabIndex = 7
        '
        'TextBoxAccompte
        '
        Me.TextBoxAccompte.Location = New System.Drawing.Point(15, 45)
        Me.TextBoxAccompte.Name = "TextBoxAccompte"
        Me.TextBoxAccompte.Size = New System.Drawing.Size(127, 20)
        Me.TextBoxAccompte.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Numéro de chèque"
        '
        'LabelAccompte
        '
        Me.LabelAccompte.AutoSize = True
        Me.LabelAccompte.Location = New System.Drawing.Point(52, 22)
        Me.LabelAccompte.Name = "LabelAccompte"
        Me.LabelAccompte.Size = New System.Drawing.Size(55, 13)
        Me.LabelAccompte.TabIndex = 4
        Me.LabelAccompte.Text = "Accompte"
        '
        'Sauvegarder
        '
        Me.Sauvegarder.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Sauvegarder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sauvegarder.Location = New System.Drawing.Point(55, 476)
        Me.Sauvegarder.Name = "Sauvegarder"
        Me.Sauvegarder.Size = New System.Drawing.Size(130, 39)
        Me.Sauvegarder.TabIndex = 2
        Me.Sauvegarder.Text = "Sauvegarder"
        Me.Sauvegarder.UseVisualStyleBackColor = False
        '
        'ButtonRetour
        '
        Me.ButtonRetour.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ButtonRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRetour.Location = New System.Drawing.Point(224, 476)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(130, 39)
        Me.ButtonRetour.TabIndex = 3
        Me.ButtonRetour.Text = "Retour Menu"
        Me.ButtonRetour.UseVisualStyleBackColor = False
        '
        'Inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 527)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.Sauvegarder)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Inscription"
        Me.Text = "Inscription"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.PanelProfession.ResumeLayout(False)
        Me.PanelProfession.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBoxTelPro As TextBox
    Friend WithEvents TextBoxTelPerso As TextBox
    Friend WithEvents TextBoxMailPro As TextBox
    Friend WithEvents TextBoxMailPerso As TextBox
    Friend WithEvents LabelProtel As Label
    Friend WithEvents LabelPersoTel As Label
    Friend WithEvents LabelProMail As Label
    Friend WithEvents LabelPerso As Label
    Friend WithEvents PanelProfession As Panel
    Friend WithEvents TextBoxProfession As TextBox
    Friend WithEvents TextBoxDiplome As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LabelDiplome As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelRegion As Label
    Friend WithEvents LabelPays As Label
    Friend WithEvents LabelAdresse As Label
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents TextBoxPrenom As TextBox
    Friend WithEvents LabelPrenom As Label
    Friend WithEvents LabelDateNaissance As Label
    Friend WithEvents LabelNom As Label
    Friend WithEvents LabelCivilite As Label
    Friend WithEvents TextBoxAdresse As TextBox
    Friend WithEvents LabelTel As Label
    Friend WithEvents LabelMail As Label
    Friend WithEvents ComboBoxRegion As ComboBox
    Friend WithEvents ComboBoxPays As ComboBox
    Friend WithEvents ComboBoxCivilite As ComboBox
    Friend WithEvents DateTimePickerDateNaissance As DateTimePicker
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents DateTimePickerDateDebut As DateTimePicker
    Friend WithEvents LabelStatus As Label
    Friend WithEvents LabelDateFinDeContrat As Label
    Friend WithEvents LabelDateDebutContrat As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LabelLettreMotiv As Label
    Friend WithEvents LabelCurri As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextBoxNumeroCheque As TextBox
    Friend WithEvents TextBoxAccompte As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelAccompte As Label
    Friend WithEvents ComboBoxSatus As ComboBox
    Friend WithEvents DateTimePickerDateFin As DateTimePicker
    Friend WithEvents RadioButtonOuiCurry As RadioButton
    Friend WithEvents RadioButtonOuiCurri As RadioButton
    Friend WithEvents RadioButtonOuiMotiv As RadioButton
    Friend WithEvents RadioButtonNonCurry As RadioButton
    Friend WithEvents RadioButtonNonMotiv As RadioButton
    Friend WithEvents RichTextBoxCommentaire As RichTextBox
    Friend WithEvents Sauvegarder As Button
    Friend WithEvents ButtonRetour As Button
End Class
