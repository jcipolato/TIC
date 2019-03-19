<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inscription
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panParcours = New System.Windows.Forms.Panel()
        Me.txtAutre = New System.Windows.Forms.TextBox()
        Me.labAutre = New System.Windows.Forms.Label()
        Me.txtProfession = New System.Windows.Forms.TextBox()
        Me.labProfession = New System.Windows.Forms.Label()
        Me.cbEmploi = New System.Windows.Forms.ComboBox()
        Me.labEmploi = New System.Windows.Forms.Label()
        Me.cbEtudes = New System.Windows.Forms.ComboBox()
        Me.labDiplome = New System.Windows.Forms.Label()
        Me.labStatut = New System.Windows.Forms.Label()
        Me.cbStatut = New System.Windows.Forms.ComboBox()
        Me.panCoordonnees = New System.Windows.Forms.Panel()
        Me.txtComplement = New System.Windows.Forms.TextBox()
        Me.labComplement = New System.Windows.Forms.Label()
        Me.labVille = New System.Windows.Forms.Label()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.cbPays = New System.Windows.Forms.ComboBox()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.labCP = New System.Windows.Forms.Label()
        Me.labPays = New System.Windows.Forms.Label()
        Me.labAdresse = New System.Windows.Forms.Label()
        Me.panIdentite = New System.Windows.Forms.Panel()
        Me.dtNaissance = New System.Windows.Forms.DateTimePicker()
        Me.cbCivilite = New System.Windows.Forms.ComboBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.labPrenom = New System.Windows.Forms.Label()
        Me.labDateNaissance = New System.Windows.Forms.Label()
        Me.labNom = New System.Windows.Forms.Label()
        Me.labCivilite = New System.Windows.Forms.Label()
        Me.panContact = New System.Windows.Forms.Panel()
        Me.labErreurTel = New System.Windows.Forms.Label()
        Me.labErreurMail = New System.Windows.Forms.Label()
        Me.LabelTel = New System.Windows.Forms.Label()
        Me.LabelMail = New System.Windows.Forms.Label()
        Me.txtTelPro = New System.Windows.Forms.TextBox()
        Me.txtTelPerso = New System.Windows.Forms.TextBox()
        Me.txtMailPro = New System.Windows.Forms.TextBox()
        Me.txtMailPerso = New System.Windows.Forms.TextBox()
        Me.labProTel = New System.Windows.Forms.Label()
        Me.labPersoTel = New System.Windows.Forms.Label()
        Me.labProMail = New System.Windows.Forms.Label()
        Me.labPerso = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panRenseign = New System.Windows.Forms.Panel()
        Me.cbFidelite = New System.Windows.Forms.ComboBox()
        Me.cbFinancement = New System.Windows.Forms.ComboBox()
        Me.labFidelite = New System.Windows.Forms.Label()
        Me.labFinancement = New System.Windows.Forms.Label()
        Me.panPieces = New System.Windows.Forms.Panel()
        Me.grpMotiv = New System.Windows.Forms.GroupBox()
        Me.labMotiv = New System.Windows.Forms.Label()
        Me.rbOuiMotiv = New System.Windows.Forms.RadioButton()
        Me.rbNonMotiv = New System.Windows.Forms.RadioButton()
        Me.grpCV = New System.Windows.Forms.GroupBox()
        Me.labCV = New System.Windows.Forms.Label()
        Me.rbOuiCV = New System.Windows.Forms.RadioButton()
        Me.rbNonCV = New System.Windows.Forms.RadioButton()
        Me.panReglement = New System.Windows.Forms.Panel()
        Me.rbNonAcompte = New System.Windows.Forms.RadioButton()
        Me.rbOuiAcompte = New System.Windows.Forms.RadioButton()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.dtFinContrat = New System.Windows.Forms.DateTimePicker()
        Me.labFinContrat = New System.Windows.Forms.Label()
        Me.labDebutContrat = New System.Windows.Forms.Label()
        Me.dtDebutContrat = New System.Windows.Forms.DateTimePicker()
        Me.labCheque = New System.Windows.Forms.Label()
        Me.labAcompte = New System.Windows.Forms.Label()
        Me.btnSauvegarder = New System.Windows.Forms.Button()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.panParcours.SuspendLayout()
        Me.panCoordonnees.SuspendLayout()
        Me.panIdentite.SuspendLayout()
        Me.panContact.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panRenseign.SuspendLayout()
        Me.panPieces.SuspendLayout()
        Me.grpMotiv.SuspendLayout()
        Me.grpCV.SuspendLayout()
        Me.panReglement.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.panParcours)
        Me.Panel1.Controls.Add(Me.panCoordonnees)
        Me.Panel1.Controls.Add(Me.panIdentite)
        Me.Panel1.Location = New System.Drawing.Point(16, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 563)
        Me.Panel1.TabIndex = 0
        '
        'panParcours
        '
        Me.panParcours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panParcours.Controls.Add(Me.txtAutre)
        Me.panParcours.Controls.Add(Me.labAutre)
        Me.panParcours.Controls.Add(Me.txtProfession)
        Me.panParcours.Controls.Add(Me.labProfession)
        Me.panParcours.Controls.Add(Me.cbEmploi)
        Me.panParcours.Controls.Add(Me.labEmploi)
        Me.panParcours.Controls.Add(Me.cbEtudes)
        Me.panParcours.Controls.Add(Me.labDiplome)
        Me.panParcours.Controls.Add(Me.labStatut)
        Me.panParcours.Controls.Add(Me.cbStatut)
        Me.panParcours.Location = New System.Drawing.Point(17, 353)
        Me.panParcours.Margin = New System.Windows.Forms.Padding(4)
        Me.panParcours.Name = "panParcours"
        Me.panParcours.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.panParcours.Size = New System.Drawing.Size(483, 185)
        Me.panParcours.TabIndex = 3
        '
        'txtAutre
        '
        Me.txtAutre.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtAutre.Location = New System.Drawing.Point(342, 55)
        Me.txtAutre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAutre.Name = "txtAutre"
        Me.txtAutre.Size = New System.Drawing.Size(130, 26)
        Me.txtAutre.TabIndex = 11
        Me.txtAutre.Visible = False
        '
        'labAutre
        '
        Me.labAutre.AutoSize = True
        Me.labAutre.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labAutre.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.labAutre.Location = New System.Drawing.Point(274, 58)
        Me.labAutre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labAutre.Name = "labAutre"
        Me.labAutre.Size = New System.Drawing.Size(60, 18)
        Me.labAutre.TabIndex = 19
        Me.labAutre.Text = "Autre :"
        Me.labAutre.Visible = False
        '
        'txtProfession
        '
        Me.txtProfession.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtProfession.Location = New System.Drawing.Point(104, 92)
        Me.txtProfession.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.Size = New System.Drawing.Size(363, 26)
        Me.txtProfession.TabIndex = 12
        '
        'labProfession
        '
        Me.labProfession.AutoSize = True
        Me.labProfession.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labProfession.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.labProfession.Location = New System.Drawing.Point(-1, 95)
        Me.labProfession.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labProfession.Name = "labProfession"
        Me.labProfession.Size = New System.Drawing.Size(97, 18)
        Me.labProfession.TabIndex = 18
        Me.labProfession.Text = "Profession :"
        '
        'cbEmploi
        '
        Me.cbEmploi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmploi.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cbEmploi.FormattingEnabled = True
        Me.cbEmploi.Items.AddRange(New Object() {"Art", "Autre", "Administration", "Biologie-Chimiste-Physique", "Commerce", "Droit", "Enseignement", "Environnement", "Hôtellerie-Restauration-Tourisme", "Informatique-Multimédia", "Médecine-Santé", "Social", "Sport", "Technique", "Transports"})
        Me.cbEmploi.Location = New System.Drawing.Point(7, 153)
        Me.cbEmploi.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEmploi.Name = "cbEmploi"
        Me.cbEmploi.Size = New System.Drawing.Size(363, 26)
        Me.cbEmploi.TabIndex = 13
        '
        'labEmploi
        '
        Me.labEmploi.AutoSize = True
        Me.labEmploi.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labEmploi.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.labEmploi.Location = New System.Drawing.Point(4, 131)
        Me.labEmploi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labEmploi.Name = "labEmploi"
        Me.labEmploi.Size = New System.Drawing.Size(153, 18)
        Me.labEmploi.TabIndex = 16
        Me.labEmploi.Text = "Domaine d'emploi :"
        '
        'cbEtudes
        '
        Me.cbEtudes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEtudes.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cbEtudes.FormattingEnabled = True
        Me.cbEtudes.Items.AddRange(New Object() {"Baccalauréat", "BTS", "DUT", "Licence", "Master", "Autre"})
        Me.cbEtudes.Location = New System.Drawing.Point(104, 54)
        Me.cbEtudes.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEtudes.Name = "cbEtudes"
        Me.cbEtudes.Size = New System.Drawing.Size(162, 26)
        Me.cbEtudes.TabIndex = 10
        '
        'labDiplome
        '
        Me.labDiplome.AutoSize = True
        Me.labDiplome.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labDiplome.Location = New System.Drawing.Point(4, 45)
        Me.labDiplome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labDiplome.Name = "labDiplome"
        Me.labDiplome.Size = New System.Drawing.Size(83, 36)
        Me.labDiplome.TabIndex = 4
        Me.labDiplome.Text = "Niveau " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "d'études :"
        '
        'labStatut
        '
        Me.labStatut.AutoSize = True
        Me.labStatut.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labStatut.Location = New System.Drawing.Point(8, 13)
        Me.labStatut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labStatut.Name = "labStatut"
        Me.labStatut.Size = New System.Drawing.Size(66, 18)
        Me.labStatut.TabIndex = 6
        Me.labStatut.Text = "Statut :"
        '
        'cbStatut
        '
        Me.cbStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatut.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cbStatut.FormattingEnabled = True
        Me.cbStatut.Items.AddRange(New Object() {"Salarié", "Fonctionnaire", "Auto-entrepreneur", "Sans emploi", "Etudiant(e)"})
        Me.cbStatut.Location = New System.Drawing.Point(104, 12)
        Me.cbStatut.Margin = New System.Windows.Forms.Padding(4)
        Me.cbStatut.Name = "cbStatut"
        Me.cbStatut.Size = New System.Drawing.Size(225, 26)
        Me.cbStatut.TabIndex = 9
        '
        'panCoordonnees
        '
        Me.panCoordonnees.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panCoordonnees.Controls.Add(Me.txtComplement)
        Me.panCoordonnees.Controls.Add(Me.labComplement)
        Me.panCoordonnees.Controls.Add(Me.labVille)
        Me.panCoordonnees.Controls.Add(Me.txtVille)
        Me.panCoordonnees.Controls.Add(Me.txtCP)
        Me.panCoordonnees.Controls.Add(Me.cbPays)
        Me.panCoordonnees.Controls.Add(Me.txtAdresse)
        Me.panCoordonnees.Controls.Add(Me.labCP)
        Me.panCoordonnees.Controls.Add(Me.labPays)
        Me.panCoordonnees.Controls.Add(Me.labAdresse)
        Me.panCoordonnees.Location = New System.Drawing.Point(17, 193)
        Me.panCoordonnees.Margin = New System.Windows.Forms.Padding(4)
        Me.panCoordonnees.Name = "panCoordonnees"
        Me.panCoordonnees.Size = New System.Drawing.Size(483, 141)
        Me.panCoordonnees.TabIndex = 2
        '
        'txtComplement
        '
        Me.txtComplement.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtComplement.Location = New System.Drawing.Point(128, 42)
        Me.txtComplement.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComplement.Name = "txtComplement"
        Me.txtComplement.Size = New System.Drawing.Size(344, 26)
        Me.txtComplement.TabIndex = 5
        '
        'labComplement
        '
        Me.labComplement.AutoSize = True
        Me.labComplement.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labComplement.Location = New System.Drawing.Point(4, 45)
        Me.labComplement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labComplement.Name = "labComplement"
        Me.labComplement.Size = New System.Drawing.Size(116, 18)
        Me.labComplement.TabIndex = 11
        Me.labComplement.Text = "Complément :"
        '
        'labVille
        '
        Me.labVille.AutoSize = True
        Me.labVille.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labVille.Location = New System.Drawing.Point(4, 112)
        Me.labVille.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labVille.Name = "labVille"
        Me.labVille.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.labVille.Size = New System.Drawing.Size(48, 18)
        Me.labVille.TabIndex = 10
        Me.labVille.Text = "Ville :"
        Me.labVille.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVille
        '
        Me.txtVille.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtVille.Location = New System.Drawing.Point(60, 109)
        Me.txtVille.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVille.MaxLength = 50
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(148, 26)
        Me.txtVille.TabIndex = 7
        '
        'txtCP
        '
        Me.txtCP.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtCP.Location = New System.Drawing.Point(128, 76)
        Me.txtCP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCP.MaxLength = 5
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(143, 26)
        Me.txtCP.TabIndex = 6
        '
        'cbPays
        '
        Me.cbPays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPays.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cbPays.FormattingEnabled = True
        Me.cbPays.Location = New System.Drawing.Point(277, 109)
        Me.cbPays.Margin = New System.Windows.Forms.Padding(4)
        Me.cbPays.Name = "cbPays"
        Me.cbPays.Size = New System.Drawing.Size(200, 26)
        Me.cbPays.TabIndex = 8
        '
        'txtAdresse
        '
        Me.txtAdresse.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtAdresse.Location = New System.Drawing.Point(128, 11)
        Me.txtAdresse.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(344, 26)
        Me.txtAdresse.TabIndex = 4
        '
        'labCP
        '
        Me.labCP.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labCP.Location = New System.Drawing.Point(-4, 75)
        Me.labCP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labCP.Name = "labCP"
        Me.labCP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.labCP.Size = New System.Drawing.Size(141, 27)
        Me.labCP.TabIndex = 3
        Me.labCP.Text = "Code postal :"
        Me.labCP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labPays
        '
        Me.labPays.AutoSize = True
        Me.labPays.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labPays.Location = New System.Drawing.Point(216, 113)
        Me.labPays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labPays.Name = "labPays"
        Me.labPays.Size = New System.Drawing.Size(55, 18)
        Me.labPays.TabIndex = 2
        Me.labPays.Text = "Pays :"
        '
        'labAdresse
        '
        Me.labAdresse.AutoSize = True
        Me.labAdresse.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labAdresse.Location = New System.Drawing.Point(41, 14)
        Me.labAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labAdresse.Name = "labAdresse"
        Me.labAdresse.Size = New System.Drawing.Size(79, 18)
        Me.labAdresse.TabIndex = 1
        Me.labAdresse.Text = "Adresse :"
        '
        'panIdentite
        '
        Me.panIdentite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panIdentite.Controls.Add(Me.dtNaissance)
        Me.panIdentite.Controls.Add(Me.cbCivilite)
        Me.panIdentite.Controls.Add(Me.txtNom)
        Me.panIdentite.Controls.Add(Me.txtPrenom)
        Me.panIdentite.Controls.Add(Me.labPrenom)
        Me.panIdentite.Controls.Add(Me.labDateNaissance)
        Me.panIdentite.Controls.Add(Me.labNom)
        Me.panIdentite.Controls.Add(Me.labCivilite)
        Me.panIdentite.Location = New System.Drawing.Point(17, 20)
        Me.panIdentite.Margin = New System.Windows.Forms.Padding(4)
        Me.panIdentite.Name = "panIdentite"
        Me.panIdentite.Size = New System.Drawing.Size(483, 150)
        Me.panIdentite.TabIndex = 0
        '
        'dtNaissance
        '
        Me.dtNaissance.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.dtNaissance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtNaissance.Location = New System.Drawing.Point(182, 112)
        Me.dtNaissance.Margin = New System.Windows.Forms.Padding(4)
        Me.dtNaissance.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtNaissance.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtNaissance.Name = "dtNaissance"
        Me.dtNaissance.Size = New System.Drawing.Size(163, 26)
        Me.dtNaissance.TabIndex = 22
        '
        'cbCivilite
        '
        Me.cbCivilite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCivilite.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cbCivilite.FormattingEnabled = True
        Me.cbCivilite.Items.AddRange(New Object() {"Madame", "Monsieur"})
        Me.cbCivilite.Location = New System.Drawing.Point(182, 9)
        Me.cbCivilite.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCivilite.Name = "cbCivilite"
        Me.cbCivilite.Size = New System.Drawing.Size(112, 26)
        Me.cbCivilite.TabIndex = 0
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtNom.Location = New System.Drawing.Point(182, 43)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(163, 26)
        Me.txtNom.TabIndex = 1
        '
        'txtPrenom
        '
        Me.txtPrenom.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtPrenom.Location = New System.Drawing.Point(182, 78)
        Me.txtPrenom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(163, 26)
        Me.txtPrenom.TabIndex = 2
        '
        'labPrenom
        '
        Me.labPrenom.AutoSize = True
        Me.labPrenom.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labPrenom.Location = New System.Drawing.Point(18, 81)
        Me.labPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labPrenom.Name = "labPrenom"
        Me.labPrenom.Size = New System.Drawing.Size(78, 18)
        Me.labPrenom.TabIndex = 3
        Me.labPrenom.Text = "Prénom :"
        '
        'labDateNaissance
        '
        Me.labDateNaissance.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labDateNaissance.Location = New System.Drawing.Point(18, 116)
        Me.labDateNaissance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labDateNaissance.Name = "labDateNaissance"
        Me.labDateNaissance.Size = New System.Drawing.Size(156, 26)
        Me.labDateNaissance.TabIndex = 2
        Me.labDateNaissance.Text = "Date de naissance :"
        '
        'labNom
        '
        Me.labNom.AutoSize = True
        Me.labNom.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labNom.Location = New System.Drawing.Point(18, 46)
        Me.labNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labNom.Name = "labNom"
        Me.labNom.Size = New System.Drawing.Size(56, 18)
        Me.labNom.TabIndex = 1
        Me.labNom.Text = "Nom :"
        '
        'labCivilite
        '
        Me.labCivilite.AutoSize = True
        Me.labCivilite.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labCivilite.Location = New System.Drawing.Point(18, 12)
        Me.labCivilite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labCivilite.Name = "labCivilite"
        Me.labCivilite.Size = New System.Drawing.Size(67, 18)
        Me.labCivilite.TabIndex = 0
        Me.labCivilite.Text = "Civilité :"
        '
        'panContact
        '
        Me.panContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panContact.Controls.Add(Me.labErreurTel)
        Me.panContact.Controls.Add(Me.labErreurMail)
        Me.panContact.Controls.Add(Me.LabelTel)
        Me.panContact.Controls.Add(Me.LabelMail)
        Me.panContact.Controls.Add(Me.txtTelPro)
        Me.panContact.Controls.Add(Me.txtTelPerso)
        Me.panContact.Controls.Add(Me.txtMailPro)
        Me.panContact.Controls.Add(Me.txtMailPerso)
        Me.panContact.Controls.Add(Me.labProTel)
        Me.panContact.Controls.Add(Me.labPersoTel)
        Me.panContact.Controls.Add(Me.labProMail)
        Me.panContact.Controls.Add(Me.labPerso)
        Me.panContact.Location = New System.Drawing.Point(19, 5)
        Me.panContact.Margin = New System.Windows.Forms.Padding(4)
        Me.panContact.Name = "panContact"
        Me.panContact.Size = New System.Drawing.Size(483, 169)
        Me.panContact.TabIndex = 4
        '
        'labErreurTel
        '
        Me.labErreurTel.AutoSize = True
        Me.labErreurTel.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labErreurTel.ForeColor = System.Drawing.Color.Red
        Me.labErreurTel.Location = New System.Drawing.Point(135, 114)
        Me.labErreurTel.Name = "labErreurTel"
        Me.labErreurTel.Size = New System.Drawing.Size(305, 18)
        Me.labErreurTel.TabIndex = 19
        Me.labErreurTel.Text = "Le numéro de téléphone est invalide"
        Me.labErreurTel.Visible = False
        '
        'labErreurMail
        '
        Me.labErreurMail.AutoSize = True
        Me.labErreurMail.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labErreurMail.ForeColor = System.Drawing.Color.Red
        Me.labErreurMail.Location = New System.Drawing.Point(100, 7)
        Me.labErreurMail.Name = "labErreurMail"
        Me.labErreurMail.Size = New System.Drawing.Size(311, 18)
        Me.labErreurMail.TabIndex = 18
        Me.labErreurMail.Text = "Le format d'adresse mail est invalide"
        Me.labErreurMail.Visible = False
        '
        'LabelTel
        '
        Me.LabelTel.AutoSize = True
        Me.LabelTel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelTel.Location = New System.Drawing.Point(4, 114)
        Me.LabelTel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTel.Name = "LabelTel"
        Me.LabelTel.Size = New System.Drawing.Size(92, 18)
        Me.LabelTel.TabIndex = 10
        Me.LabelTel.Text = "Téléphone"
        '
        'LabelMail
        '
        Me.LabelMail.AutoSize = True
        Me.LabelMail.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMail.Location = New System.Drawing.Point(4, 7)
        Me.LabelMail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMail.Name = "LabelMail"
        Me.LabelMail.Size = New System.Drawing.Size(40, 18)
        Me.LabelMail.TabIndex = 9
        Me.LabelMail.Text = "Mail"
        '
        'txtTelPro
        '
        Me.txtTelPro.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtTelPro.Location = New System.Drawing.Point(300, 135)
        Me.txtTelPro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelPro.MaxLength = 10
        Me.txtTelPro.Name = "txtTelPro"
        Me.txtTelPro.Size = New System.Drawing.Size(164, 26)
        Me.txtTelPro.TabIndex = 17
        '
        'txtTelPerso
        '
        Me.txtTelPerso.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtTelPerso.Location = New System.Drawing.Point(86, 136)
        Me.txtTelPerso.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelPerso.MaxLength = 10
        Me.txtTelPerso.Name = "txtTelPerso"
        Me.txtTelPerso.Size = New System.Drawing.Size(157, 26)
        Me.txtTelPerso.TabIndex = 16
        '
        'txtMailPro
        '
        Me.txtMailPro.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtMailPro.Location = New System.Drawing.Point(86, 75)
        Me.txtMailPro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMailPro.Name = "txtMailPro"
        Me.txtMailPro.Size = New System.Drawing.Size(379, 26)
        Me.txtMailPro.TabIndex = 15
        '
        'txtMailPerso
        '
        Me.txtMailPerso.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtMailPerso.Location = New System.Drawing.Point(86, 34)
        Me.txtMailPerso.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMailPerso.Name = "txtMailPerso"
        Me.txtMailPerso.Size = New System.Drawing.Size(379, 26)
        Me.txtMailPerso.TabIndex = 14
        '
        'labProTel
        '
        Me.labProTel.AutoSize = True
        Me.labProTel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labProTel.Location = New System.Drawing.Point(248, 143)
        Me.labProTel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labProTel.Name = "labProTel"
        Me.labProTel.Size = New System.Drawing.Size(45, 18)
        Me.labProTel.TabIndex = 4
        Me.labProTel.Text = "Pro :"
        '
        'labPersoTel
        '
        Me.labPersoTel.AutoSize = True
        Me.labPersoTel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labPersoTel.Location = New System.Drawing.Point(16, 143)
        Me.labPersoTel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labPersoTel.Name = "labPersoTel"
        Me.labPersoTel.Size = New System.Drawing.Size(62, 18)
        Me.labPersoTel.TabIndex = 3
        Me.labPersoTel.Text = "Perso :"
        '
        'labProMail
        '
        Me.labProMail.AutoSize = True
        Me.labProMail.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labProMail.Location = New System.Drawing.Point(33, 78)
        Me.labProMail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labProMail.Name = "labProMail"
        Me.labProMail.Size = New System.Drawing.Size(45, 18)
        Me.labProMail.TabIndex = 2
        Me.labProMail.Text = "Pro :"
        '
        'labPerso
        '
        Me.labPerso.AutoSize = True
        Me.labPerso.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labPerso.Location = New System.Drawing.Point(16, 37)
        Me.labPerso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labPerso.Name = "labPerso"
        Me.labPerso.Size = New System.Drawing.Size(62, 18)
        Me.labPerso.TabIndex = 1
        Me.labPerso.Text = "Perso :"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.panRenseign)
        Me.Panel2.Controls.Add(Me.panContact)
        Me.Panel2.Controls.Add(Me.panPieces)
        Me.Panel2.Controls.Add(Me.panReglement)
        Me.Panel2.Location = New System.Drawing.Point(568, 15)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(527, 619)
        Me.Panel2.TabIndex = 1
        '
        'panRenseign
        '
        Me.panRenseign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panRenseign.Controls.Add(Me.cbFidelite)
        Me.panRenseign.Controls.Add(Me.cbFinancement)
        Me.panRenseign.Controls.Add(Me.labFidelite)
        Me.panRenseign.Controls.Add(Me.labFinancement)
        Me.panRenseign.Location = New System.Drawing.Point(19, 460)
        Me.panRenseign.Margin = New System.Windows.Forms.Padding(4)
        Me.panRenseign.Name = "panRenseign"
        Me.panRenseign.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.panRenseign.Size = New System.Drawing.Size(483, 115)
        Me.panRenseign.TabIndex = 12
        '
        'cbFidelite
        '
        Me.cbFidelite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFidelite.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cbFidelite.FormattingEnabled = True
        Me.cbFidelite.Items.AddRange(New Object() {"Relation professionnelle", "Presse audovisuelle", "Site école", "Réseaux sociaux", "Presse écrite", "Site institutionnel", "Réseaux sociaux institutionnel", "Autre"})
        Me.cbFidelite.Location = New System.Drawing.Point(8, 81)
        Me.cbFidelite.Margin = New System.Windows.Forms.Padding(4)
        Me.cbFidelite.Name = "cbFidelite"
        Me.cbFidelite.Size = New System.Drawing.Size(403, 26)
        Me.cbFidelite.TabIndex = 27
        '
        'cbFinancement
        '
        Me.cbFinancement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFinancement.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cbFinancement.FormattingEnabled = True
        Me.cbFinancement.Items.AddRange(New Object() {"Financement propre ", "Entreprise", "OPCA"})
        Me.cbFinancement.Location = New System.Drawing.Point(187, 18)
        Me.cbFinancement.Margin = New System.Windows.Forms.Padding(4)
        Me.cbFinancement.Name = "cbFinancement"
        Me.cbFinancement.Size = New System.Drawing.Size(290, 26)
        Me.cbFinancement.TabIndex = 26
        '
        'labFidelite
        '
        Me.labFidelite.AutoSize = True
        Me.labFidelite.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labFidelite.Location = New System.Drawing.Point(5, 59)
        Me.labFidelite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labFidelite.Name = "labFidelite"
        Me.labFidelite.Size = New System.Drawing.Size(283, 18)
        Me.labFidelite.TabIndex = 5
        Me.labFidelite.Text = "Comment nous avez-vous connu ? :"
        '
        'labFinancement
        '
        Me.labFinancement.AutoSize = True
        Me.labFinancement.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labFinancement.Location = New System.Drawing.Point(4, 21)
        Me.labFinancement.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labFinancement.Name = "labFinancement"
        Me.labFinancement.Size = New System.Drawing.Size(174, 18)
        Me.labFinancement.TabIndex = 4
        Me.labFinancement.Text = "Type de financement :"
        '
        'panPieces
        '
        Me.panPieces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panPieces.Controls.Add(Me.grpMotiv)
        Me.panPieces.Controls.Add(Me.grpCV)
        Me.panPieces.Location = New System.Drawing.Point(19, 182)
        Me.panPieces.Margin = New System.Windows.Forms.Padding(4)
        Me.panPieces.Name = "panPieces"
        Me.panPieces.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.panPieces.Size = New System.Drawing.Size(483, 102)
        Me.panPieces.TabIndex = 5
        '
        'grpMotiv
        '
        Me.grpMotiv.Controls.Add(Me.labMotiv)
        Me.grpMotiv.Controls.Add(Me.rbOuiMotiv)
        Me.grpMotiv.Controls.Add(Me.rbNonMotiv)
        Me.grpMotiv.Location = New System.Drawing.Point(265, 3)
        Me.grpMotiv.Name = "grpMotiv"
        Me.grpMotiv.Size = New System.Drawing.Size(200, 89)
        Me.grpMotiv.TabIndex = 22
        Me.grpMotiv.TabStop = False
        '
        'labMotiv
        '
        Me.labMotiv.AutoSize = True
        Me.labMotiv.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labMotiv.Location = New System.Drawing.Point(7, 18)
        Me.labMotiv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labMotiv.Name = "labMotiv"
        Me.labMotiv.Size = New System.Drawing.Size(160, 18)
        Me.labMotiv.TabIndex = 5
        Me.labMotiv.Text = "Lettre de motivation"
        '
        'rbOuiMotiv
        '
        Me.rbOuiMotiv.AutoSize = True
        Me.rbOuiMotiv.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.rbOuiMotiv.Location = New System.Drawing.Point(35, 51)
        Me.rbOuiMotiv.Margin = New System.Windows.Forms.Padding(4)
        Me.rbOuiMotiv.Name = "rbOuiMotiv"
        Me.rbOuiMotiv.Size = New System.Drawing.Size(53, 22)
        Me.rbOuiMotiv.TabIndex = 19
        Me.rbOuiMotiv.TabStop = True
        Me.rbOuiMotiv.Text = "Oui"
        Me.rbOuiMotiv.UseVisualStyleBackColor = True
        '
        'rbNonMotiv
        '
        Me.rbNonMotiv.AutoSize = True
        Me.rbNonMotiv.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.rbNonMotiv.Location = New System.Drawing.Point(111, 51)
        Me.rbNonMotiv.Margin = New System.Windows.Forms.Padding(4)
        Me.rbNonMotiv.Name = "rbNonMotiv"
        Me.rbNonMotiv.Size = New System.Drawing.Size(59, 22)
        Me.rbNonMotiv.TabIndex = 20
        Me.rbNonMotiv.TabStop = True
        Me.rbNonMotiv.Text = "Non"
        Me.rbNonMotiv.UseVisualStyleBackColor = True
        '
        'grpCV
        '
        Me.grpCV.Controls.Add(Me.labCV)
        Me.grpCV.Controls.Add(Me.rbOuiCV)
        Me.grpCV.Controls.Add(Me.rbNonCV)
        Me.grpCV.Location = New System.Drawing.Point(19, 3)
        Me.grpCV.Name = "grpCV"
        Me.grpCV.Size = New System.Drawing.Size(200, 89)
        Me.grpCV.TabIndex = 21
        Me.grpCV.TabStop = False
        '
        'labCV
        '
        Me.labCV.AutoSize = True
        Me.labCV.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labCV.Location = New System.Drawing.Point(29, 18)
        Me.labCV.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labCV.Name = "labCV"
        Me.labCV.Size = New System.Drawing.Size(128, 18)
        Me.labCV.TabIndex = 4
        Me.labCV.Text = "Curriculum vitae"
        '
        'rbOuiCV
        '
        Me.rbOuiCV.AutoSize = True
        Me.rbOuiCV.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.rbOuiCV.Location = New System.Drawing.Point(32, 50)
        Me.rbOuiCV.Margin = New System.Windows.Forms.Padding(4)
        Me.rbOuiCV.Name = "rbOuiCV"
        Me.rbOuiCV.Size = New System.Drawing.Size(53, 22)
        Me.rbOuiCV.TabIndex = 17
        Me.rbOuiCV.TabStop = True
        Me.rbOuiCV.Text = "Oui"
        Me.rbOuiCV.UseVisualStyleBackColor = True
        '
        'rbNonCV
        '
        Me.rbNonCV.AutoSize = True
        Me.rbNonCV.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.rbNonCV.Location = New System.Drawing.Point(111, 50)
        Me.rbNonCV.Margin = New System.Windows.Forms.Padding(4)
        Me.rbNonCV.Name = "rbNonCV"
        Me.rbNonCV.Size = New System.Drawing.Size(59, 22)
        Me.rbNonCV.TabIndex = 18
        Me.rbNonCV.TabStop = True
        Me.rbNonCV.Text = "Non"
        Me.rbNonCV.UseVisualStyleBackColor = True
        '
        'panReglement
        '
        Me.panReglement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panReglement.Controls.Add(Me.rbNonAcompte)
        Me.panReglement.Controls.Add(Me.rbOuiAcompte)
        Me.panReglement.Controls.Add(Me.txtCheque)
        Me.panReglement.Controls.Add(Me.dtFinContrat)
        Me.panReglement.Controls.Add(Me.labFinContrat)
        Me.panReglement.Controls.Add(Me.labDebutContrat)
        Me.panReglement.Controls.Add(Me.dtDebutContrat)
        Me.panReglement.Controls.Add(Me.labCheque)
        Me.panReglement.Controls.Add(Me.labAcompte)
        Me.panReglement.Location = New System.Drawing.Point(19, 304)
        Me.panReglement.Margin = New System.Windows.Forms.Padding(4)
        Me.panReglement.Name = "panReglement"
        Me.panReglement.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.panReglement.Size = New System.Drawing.Size(483, 130)
        Me.panReglement.TabIndex = 4
        '
        'rbNonAcompte
        '
        Me.rbNonAcompte.AutoSize = True
        Me.rbNonAcompte.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.rbNonAcompte.Location = New System.Drawing.Point(265, 64)
        Me.rbNonAcompte.Margin = New System.Windows.Forms.Padding(4)
        Me.rbNonAcompte.Name = "rbNonAcompte"
        Me.rbNonAcompte.Size = New System.Drawing.Size(59, 22)
        Me.rbNonAcompte.TabIndex = 24
        Me.rbNonAcompte.TabStop = True
        Me.rbNonAcompte.Text = "Non"
        Me.rbNonAcompte.UseVisualStyleBackColor = True
        '
        'rbOuiAcompte
        '
        Me.rbOuiAcompte.AutoSize = True
        Me.rbOuiAcompte.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.rbOuiAcompte.Location = New System.Drawing.Point(187, 64)
        Me.rbOuiAcompte.Margin = New System.Windows.Forms.Padding(4)
        Me.rbOuiAcompte.Name = "rbOuiAcompte"
        Me.rbOuiAcompte.Size = New System.Drawing.Size(53, 22)
        Me.rbOuiAcompte.TabIndex = 23
        Me.rbOuiAcompte.TabStop = True
        Me.rbOuiAcompte.Text = "Oui"
        Me.rbOuiAcompte.UseVisualStyleBackColor = True
        '
        'txtCheque
        '
        Me.txtCheque.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtCheque.Location = New System.Drawing.Point(187, 94)
        Me.txtCheque.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(152, 26)
        Me.txtCheque.TabIndex = 25
        '
        'dtFinContrat
        '
        Me.dtFinContrat.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.dtFinContrat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinContrat.Location = New System.Drawing.Point(261, 24)
        Me.dtFinContrat.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFinContrat.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtFinContrat.MinDate = New Date(2019, 3, 13, 0, 0, 0, 0)
        Me.dtFinContrat.Name = "dtFinContrat"
        Me.dtFinContrat.Size = New System.Drawing.Size(187, 26)
        Me.dtFinContrat.TabIndex = 22
        '
        'labFinContrat
        '
        Me.labFinContrat.AutoSize = True
        Me.labFinContrat.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labFinContrat.Location = New System.Drawing.Point(253, 2)
        Me.labFinContrat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labFinContrat.Name = "labFinContrat"
        Me.labFinContrat.Size = New System.Drawing.Size(182, 18)
        Me.labFinContrat.TabIndex = 5
        Me.labFinContrat.Text = "Date de fin de contrat :"
        '
        'labDebutContrat
        '
        Me.labDebutContrat.AutoSize = True
        Me.labDebutContrat.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labDebutContrat.Location = New System.Drawing.Point(16, 2)
        Me.labDebutContrat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labDebutContrat.Name = "labDebutContrat"
        Me.labDebutContrat.Size = New System.Drawing.Size(207, 18)
        Me.labDebutContrat.TabIndex = 4
        Me.labDebutContrat.Text = "Date de début de contrat :"
        '
        'dtDebutContrat
        '
        Me.dtDebutContrat.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.dtDebutContrat.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDebutContrat.Location = New System.Drawing.Point(36, 24)
        Me.dtDebutContrat.Margin = New System.Windows.Forms.Padding(4)
        Me.dtDebutContrat.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtDebutContrat.MinDate = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.dtDebutContrat.Name = "dtDebutContrat"
        Me.dtDebutContrat.Size = New System.Drawing.Size(187, 26)
        Me.dtDebutContrat.TabIndex = 21
        '
        'labCheque
        '
        Me.labCheque.AutoSize = True
        Me.labCheque.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labCheque.Location = New System.Drawing.Point(4, 99)
        Me.labCheque.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labCheque.Name = "labCheque"
        Me.labCheque.Size = New System.Drawing.Size(161, 18)
        Me.labCheque.TabIndex = 5
        Me.labCheque.Text = "Numéro de chèque :"
        '
        'labAcompte
        '
        Me.labAcompte.AutoSize = True
        Me.labAcompte.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labAcompte.Location = New System.Drawing.Point(4, 62)
        Me.labAcompte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labAcompte.Name = "labAcompte"
        Me.labAcompte.Size = New System.Drawing.Size(133, 18)
        Me.labAcompte.TabIndex = 4
        Me.labAcompte.Text = "Acompte versé :"
        '
        'btnSauvegarder
        '
        Me.btnSauvegarder.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnSauvegarder.Enabled = False
        Me.btnSauvegarder.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnSauvegarder.Location = New System.Drawing.Point(83, 586)
        Me.btnSauvegarder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSauvegarder.Name = "btnSauvegarder"
        Me.btnSauvegarder.Size = New System.Drawing.Size(173, 48)
        Me.btnSauvegarder.TabIndex = 2
        Me.btnSauvegarder.Text = "Sauvegarder"
        Me.btnSauvegarder.UseVisualStyleBackColor = False
        '
        'btnRetour
        '
        Me.btnRetour.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnRetour.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnRetour.Location = New System.Drawing.Point(312, 586)
        Me.btnRetour.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(173, 48)
        Me.btnRetour.TabIndex = 3
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'Inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1111, 649)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.btnSauvegarder)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Inscription"
        Me.Text = "Inscription"
        Me.Panel1.ResumeLayout(False)
        Me.panParcours.ResumeLayout(False)
        Me.panParcours.PerformLayout()
        Me.panCoordonnees.ResumeLayout(False)
        Me.panCoordonnees.PerformLayout()
        Me.panIdentite.ResumeLayout(False)
        Me.panIdentite.PerformLayout()
        Me.panContact.ResumeLayout(False)
        Me.panContact.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.panRenseign.ResumeLayout(False)
        Me.panRenseign.PerformLayout()
        Me.panPieces.ResumeLayout(False)
        Me.grpMotiv.ResumeLayout(False)
        Me.grpMotiv.PerformLayout()
        Me.grpCV.ResumeLayout(False)
        Me.grpCV.PerformLayout()
        Me.panReglement.ResumeLayout(False)
        Me.panReglement.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents panIdentite As Panel
    Friend WithEvents panContact As Panel
    Friend WithEvents txtTelPro As TextBox
    Friend WithEvents txtTelPerso As TextBox
    Friend WithEvents txtMailPro As TextBox
    Friend WithEvents txtMailPerso As TextBox
    Friend WithEvents labProTel As Label
    Friend WithEvents labPersoTel As Label
    Friend WithEvents labProMail As Label
    Friend WithEvents labPerso As Label
    Friend WithEvents panParcours As Panel
    Friend WithEvents labDiplome As Label
    Friend WithEvents panCoordonnees As Panel
    Friend WithEvents labCP As Label
    Friend WithEvents labPays As Label
    Friend WithEvents labAdresse As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents labPrenom As Label
    Friend WithEvents labDateNaissance As Label
    Friend WithEvents labNom As Label
    Friend WithEvents labCivilite As Label
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents LabelTel As Label
    Friend WithEvents LabelMail As Label
    Friend WithEvents cbPays As ComboBox
    Friend WithEvents cbCivilite As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtDebutContrat As DateTimePicker
    Friend WithEvents labStatut As Label
    Friend WithEvents labFinContrat As Label
    Friend WithEvents labDebutContrat As Label
    Friend WithEvents panPieces As Panel
    Friend WithEvents labMotiv As Label
    Friend WithEvents labCV As Label
    Friend WithEvents panReglement As Panel
    Friend WithEvents txtCheque As TextBox
    Friend WithEvents labCheque As Label
    Friend WithEvents labAcompte As Label
    Friend WithEvents cbStatut As ComboBox
    Friend WithEvents dtFinContrat As DateTimePicker
    Friend WithEvents rbOuiCV As RadioButton
    Friend WithEvents rbOuiMotiv As RadioButton
    Friend WithEvents rbNonCV As RadioButton
    Friend WithEvents rbNonMotiv As RadioButton
    Friend WithEvents btnSauvegarder As Button
    Friend WithEvents btnRetour As Button
    Friend WithEvents labVille As Label
    Friend WithEvents txtVille As TextBox
    Friend WithEvents txtCP As TextBox
    Friend WithEvents labEmploi As Label
    Friend WithEvents cbEtudes As ComboBox
    Friend WithEvents txtComplement As TextBox
    Friend WithEvents labComplement As Label
    Friend WithEvents cbEmploi As ComboBox
    Friend WithEvents txtAutre As TextBox
    Friend WithEvents labAutre As Label
    Friend WithEvents txtProfession As TextBox
    Friend WithEvents labProfession As Label
    Friend WithEvents panRenseign As Panel
    Friend WithEvents cbFidelite As ComboBox
    Friend WithEvents cbFinancement As ComboBox
    Friend WithEvents labFidelite As Label
    Friend WithEvents labFinancement As Label
    Friend WithEvents rbNonAcompte As RadioButton
    Friend WithEvents rbOuiAcompte As RadioButton
    Friend WithEvents labErreurMail As Label
    Friend WithEvents labErreurTel As Label
    Friend WithEvents grpMotiv As GroupBox
    Friend WithEvents grpCV As GroupBox
    Friend WithEvents dtNaissance As DateTimePicker
End Class
