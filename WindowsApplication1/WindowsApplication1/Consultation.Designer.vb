﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultation
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
        Me.components = New System.ComponentModel.Container()
        Me.dtgDossiers = New System.Windows.Forms.DataGridView()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnGenerer = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.cbTrier = New System.Windows.Forms.ComboBox()
        Me.labRechercher = New System.Windows.Forms.Label()
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.labTrier = New System.Windows.Forms.Label()
        Me.colCivilite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNaissance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAdresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComplement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVille = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiplome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colProfession = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDomaine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMailPerso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMailPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelPerso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCV = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colMotiv = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colDebutContrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFinContrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAcompte = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colCheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFinancement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCommentaire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PciviliteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PprenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PdateNaissanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PadresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcomplementAdresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcodePostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PvilleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PpaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PStatutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PniveauEtudesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PautreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PprofessionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PdomaineEmploiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PmailPersoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PmailProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PtelProDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PtelPersoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcvOuiNonDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PlettreMotivationOuiNonDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PdateDebutContratDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PdateFinContratDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaccompteOuiNonDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PnumeroChequeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PfinancementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PfideliteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DossierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dtgDossiers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DossierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgDossiers
        '
        Me.dtgDossiers.AllowUserToAddRows = False
        Me.dtgDossiers.AllowUserToDeleteRows = False
        Me.dtgDossiers.AutoGenerateColumns = False
        Me.dtgDossiers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDossiers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCivilite, Me.colNom, Me.colPrenom, Me.colNaissance, Me.colAdresse, Me.colComplement, Me.colCP, Me.colVille, Me.colPays, Me.colStatut, Me.colDiplome, Me.colProfession, Me.colDomaine, Me.colMailPerso, Me.colMailPro, Me.colTelPro, Me.colTelPerso, Me.colCV, Me.colMotiv, Me.colDebutContrat, Me.colFinContrat, Me.colAcompte, Me.colCheque, Me.colFinancement, Me.colCommentaire, Me.PciviliteDataGridViewTextBoxColumn, Me.PnomDataGridViewTextBoxColumn, Me.PprenomDataGridViewTextBoxColumn, Me.PdateNaissanceDataGridViewTextBoxColumn, Me.PadresseDataGridViewTextBoxColumn, Me.PcomplementAdresseDataGridViewTextBoxColumn, Me.PcodePostalDataGridViewTextBoxColumn, Me.PvilleDataGridViewTextBoxColumn, Me.PpaysDataGridViewTextBoxColumn, Me.PStatutDataGridViewTextBoxColumn, Me.PniveauEtudesDataGridViewTextBoxColumn, Me.PautreDataGridViewTextBoxColumn, Me.PprofessionDataGridViewTextBoxColumn, Me.PdomaineEmploiDataGridViewTextBoxColumn, Me.PmailPersoDataGridViewTextBoxColumn, Me.PmailProDataGridViewTextBoxColumn, Me.PtelProDataGridViewTextBoxColumn, Me.PtelPersoDataGridViewTextBoxColumn, Me.PcvOuiNonDataGridViewCheckBoxColumn, Me.PlettreMotivationOuiNonDataGridViewCheckBoxColumn, Me.PdateDebutContratDataGridViewTextBoxColumn, Me.PdateFinContratDataGridViewTextBoxColumn, Me.PaccompteOuiNonDataGridViewCheckBoxColumn, Me.PnumeroChequeDataGridViewTextBoxColumn, Me.PfinancementDataGridViewTextBoxColumn, Me.PfideliteDataGridViewTextBoxColumn})
        Me.dtgDossiers.DataSource = Me.DossierBindingSource
        Me.dtgDossiers.Location = New System.Drawing.Point(16, 124)
        Me.dtgDossiers.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgDossiers.Name = "dtgDossiers"
        Me.dtgDossiers.ReadOnly = True
        Me.dtgDossiers.Size = New System.Drawing.Size(1080, 458)
        Me.dtgDossiers.TabIndex = 0
        '
        'btnRetour
        '
        Me.btnRetour.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnRetour.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnRetour.Location = New System.Drawing.Point(943, 599)
        Me.btnRetour.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(153, 38)
        Me.btnRetour.TabIndex = 1
        Me.btnRetour.Text = "Retour Menu"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'btnGenerer
        '
        Me.btnGenerer.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnGenerer.Enabled = False
        Me.btnGenerer.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnGenerer.Location = New System.Drawing.Point(943, 68)
        Me.btnGenerer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGenerer.Name = "btnGenerer"
        Me.btnGenerer.Size = New System.Drawing.Size(122, 33)
        Me.btnGenerer.TabIndex = 2
        Me.btnGenerer.Text = "Générer"
        Me.btnGenerer.UseVisualStyleBackColor = False
        '
        'btnSupprimer
        '
        Me.btnSupprimer.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnSupprimer.Enabled = False
        Me.btnSupprimer.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnSupprimer.Location = New System.Drawing.Point(790, 68)
        Me.btnSupprimer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(122, 33)
        Me.btnSupprimer.TabIndex = 4
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = False
        '
        'btnModifier
        '
        Me.btnModifier.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnModifier.Enabled = False
        Me.btnModifier.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnModifier.Location = New System.Drawing.Point(637, 68)
        Me.btnModifier.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(122, 33)
        Me.btnModifier.TabIndex = 5
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = False
        '
        'cbTrier
        '
        Me.cbTrier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTrier.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cbTrier.FormattingEnabled = True
        Me.cbTrier.Location = New System.Drawing.Point(19, 40)
        Me.cbTrier.Margin = New System.Windows.Forms.Padding(4)
        Me.cbTrier.Name = "cbTrier"
        Me.cbTrier.Size = New System.Drawing.Size(201, 26)
        Me.cbTrier.TabIndex = 8
        '
        'labRechercher
        '
        Me.labRechercher.AutoSize = True
        Me.labRechercher.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labRechercher.Location = New System.Drawing.Point(16, 83)
        Me.labRechercher.Name = "labRechercher"
        Me.labRechercher.Size = New System.Drawing.Size(103, 18)
        Me.labRechercher.TabIndex = 9
        Me.labRechercher.Text = "Rechercher :"
        '
        'txtRechercher
        '
        Me.txtRechercher.Location = New System.Drawing.Point(135, 83)
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.Size = New System.Drawing.Size(319, 22)
        Me.txtRechercher.TabIndex = 10
        '
        'labTrier
        '
        Me.labTrier.AutoSize = True
        Me.labTrier.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.labTrier.Location = New System.Drawing.Point(16, 11)
        Me.labTrier.Name = "labTrier"
        Me.labTrier.Size = New System.Drawing.Size(81, 18)
        Me.labTrier.TabIndex = 11
        Me.labTrier.Text = "Trier par :"
        '
        'colCivilite
        '
        Me.colCivilite.DataPropertyName = "p_civilite"
        Me.colCivilite.HeaderText = "Civilité"
        Me.colCivilite.Name = "colCivilite"
        Me.colCivilite.ReadOnly = True
        '
        'colNom
        '
        Me.colNom.DataPropertyName = "p_nom"
        Me.colNom.HeaderText = "Nom"
        Me.colNom.Name = "colNom"
        Me.colNom.ReadOnly = True
        '
        'colPrenom
        '
        Me.colPrenom.DataPropertyName = "p_prenom"
        Me.colPrenom.HeaderText = "Prénom"
        Me.colPrenom.Name = "colPrenom"
        Me.colPrenom.ReadOnly = True
        '
        'colNaissance
        '
        Me.colNaissance.DataPropertyName = "p_dateNaissance"
        Me.colNaissance.HeaderText = "Date de naissance"
        Me.colNaissance.Name = "colNaissance"
        Me.colNaissance.ReadOnly = True
        '
        'colAdresse
        '
        Me.colAdresse.DataPropertyName = "p_adresse"
        Me.colAdresse.HeaderText = "Adresse"
        Me.colAdresse.Name = "colAdresse"
        Me.colAdresse.ReadOnly = True
        '
        'colComplement
        '
        Me.colComplement.DataPropertyName = "p_complementAdresse"
        Me.colComplement.HeaderText = "Complément adresse"
        Me.colComplement.Name = "colComplement"
        Me.colComplement.ReadOnly = True
        '
        'colCP
        '
        Me.colCP.DataPropertyName = "p_codePostal"
        Me.colCP.HeaderText = "Code postal"
        Me.colCP.Name = "colCP"
        Me.colCP.ReadOnly = True
        '
        'colVille
        '
        Me.colVille.DataPropertyName = "p_ville"
        Me.colVille.HeaderText = "Ville"
        Me.colVille.Name = "colVille"
        Me.colVille.ReadOnly = True
        '
        'colPays
        '
        Me.colPays.DataPropertyName = "p_pays"
        Me.colPays.HeaderText = "Pays"
        Me.colPays.Name = "colPays"
        Me.colPays.ReadOnly = True
        '
        'colStatut
        '
        Me.colStatut.DataPropertyName = "p_Statut"
        Me.colStatut.HeaderText = "Statut"
        Me.colStatut.Name = "colStatut"
        Me.colStatut.ReadOnly = True
        '
        'colDiplome
        '
        Me.colDiplome.DataPropertyName = "p_niveauEtudes"
        Me.colDiplome.HeaderText = "Diplome"
        Me.colDiplome.Name = "colDiplome"
        Me.colDiplome.ReadOnly = True
        '
        'colProfession
        '
        Me.colProfession.DataPropertyName = "p_profession"
        Me.colProfession.HeaderText = "Profession"
        Me.colProfession.Name = "colProfession"
        Me.colProfession.ReadOnly = True
        '
        'colDomaine
        '
        Me.colDomaine.DataPropertyName = "p_domaineEmploi"
        Me.colDomaine.HeaderText = "Domaine d'emploi"
        Me.colDomaine.Name = "colDomaine"
        Me.colDomaine.ReadOnly = True
        '
        'colMailPerso
        '
        Me.colMailPerso.DataPropertyName = "p_mailPerso"
        Me.colMailPerso.HeaderText = "Mail Perso"
        Me.colMailPerso.Name = "colMailPerso"
        Me.colMailPerso.ReadOnly = True
        '
        'colMailPro
        '
        Me.colMailPro.DataPropertyName = "p_mailPro"
        Me.colMailPro.HeaderText = "Mail Pro"
        Me.colMailPro.Name = "colMailPro"
        Me.colMailPro.ReadOnly = True
        '
        'colTelPro
        '
        Me.colTelPro.DataPropertyName = "p_telPro"
        Me.colTelPro.HeaderText = "Tel Pro"
        Me.colTelPro.Name = "colTelPro"
        Me.colTelPro.ReadOnly = True
        '
        'colTelPerso
        '
        Me.colTelPerso.DataPropertyName = "p_telPerso"
        Me.colTelPerso.HeaderText = "Tel Perso"
        Me.colTelPerso.Name = "colTelPerso"
        Me.colTelPerso.ReadOnly = True
        '
        'colCV
        '
        Me.colCV.DataPropertyName = "p_cvOuiNon"
        Me.colCV.HeaderText = "Curriculum Vitae"
        Me.colCV.Name = "colCV"
        Me.colCV.ReadOnly = True
        '
        'colMotiv
        '
        Me.colMotiv.DataPropertyName = "p_lettreMotivationOuiNon"
        Me.colMotiv.HeaderText = "Lettre de motivation"
        Me.colMotiv.Name = "colMotiv"
        Me.colMotiv.ReadOnly = True
        '
        'colDebutContrat
        '
        Me.colDebutContrat.DataPropertyName = "p_dateDebutContrat"
        Me.colDebutContrat.HeaderText = "Début du contrat"
        Me.colDebutContrat.Name = "colDebutContrat"
        Me.colDebutContrat.ReadOnly = True
        '
        'colFinContrat
        '
        Me.colFinContrat.DataPropertyName = "p_dateFinContrat"
        Me.colFinContrat.HeaderText = "Fin du contrat"
        Me.colFinContrat.Name = "colFinContrat"
        Me.colFinContrat.ReadOnly = True
        '
        'colAcompte
        '
        Me.colAcompte.DataPropertyName = "p_accompteOuiNon"
        Me.colAcompte.HeaderText = "Acompte"
        Me.colAcompte.Name = "colAcompte"
        Me.colAcompte.ReadOnly = True
        '
        'colCheque
        '
        Me.colCheque.DataPropertyName = "p_numeroCheque"
        Me.colCheque.HeaderText = "Chèque"
        Me.colCheque.Name = "colCheque"
        Me.colCheque.ReadOnly = True
        '
        'colFinancement
        '
        Me.colFinancement.DataPropertyName = "p_financement"
        Me.colFinancement.HeaderText = "Financement"
        Me.colFinancement.Name = "colFinancement"
        Me.colFinancement.ReadOnly = True
        '
        'colCommentaire
        '
        Me.colCommentaire.DataPropertyName = "p_fidelite"
        Me.colCommentaire.HeaderText = "Commentaire"
        Me.colCommentaire.Name = "colCommentaire"
        Me.colCommentaire.ReadOnly = True
        '
        'PciviliteDataGridViewTextBoxColumn
        '
        Me.PciviliteDataGridViewTextBoxColumn.DataPropertyName = "p_civilite"
        Me.PciviliteDataGridViewTextBoxColumn.HeaderText = "p_civilite"
        Me.PciviliteDataGridViewTextBoxColumn.Name = "PciviliteDataGridViewTextBoxColumn"
        Me.PciviliteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PnomDataGridViewTextBoxColumn
        '
        Me.PnomDataGridViewTextBoxColumn.DataPropertyName = "p_nom"
        Me.PnomDataGridViewTextBoxColumn.HeaderText = "p_nom"
        Me.PnomDataGridViewTextBoxColumn.Name = "PnomDataGridViewTextBoxColumn"
        Me.PnomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PprenomDataGridViewTextBoxColumn
        '
        Me.PprenomDataGridViewTextBoxColumn.DataPropertyName = "p_prenom"
        Me.PprenomDataGridViewTextBoxColumn.HeaderText = "p_prenom"
        Me.PprenomDataGridViewTextBoxColumn.Name = "PprenomDataGridViewTextBoxColumn"
        Me.PprenomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PdateNaissanceDataGridViewTextBoxColumn
        '
        Me.PdateNaissanceDataGridViewTextBoxColumn.DataPropertyName = "p_dateNaissance"
        Me.PdateNaissanceDataGridViewTextBoxColumn.HeaderText = "p_dateNaissance"
        Me.PdateNaissanceDataGridViewTextBoxColumn.Name = "PdateNaissanceDataGridViewTextBoxColumn"
        Me.PdateNaissanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PadresseDataGridViewTextBoxColumn
        '
        Me.PadresseDataGridViewTextBoxColumn.DataPropertyName = "p_adresse"
        Me.PadresseDataGridViewTextBoxColumn.HeaderText = "p_adresse"
        Me.PadresseDataGridViewTextBoxColumn.Name = "PadresseDataGridViewTextBoxColumn"
        Me.PadresseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PcomplementAdresseDataGridViewTextBoxColumn
        '
        Me.PcomplementAdresseDataGridViewTextBoxColumn.DataPropertyName = "p_complementAdresse"
        Me.PcomplementAdresseDataGridViewTextBoxColumn.HeaderText = "p_complementAdresse"
        Me.PcomplementAdresseDataGridViewTextBoxColumn.Name = "PcomplementAdresseDataGridViewTextBoxColumn"
        Me.PcomplementAdresseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PcodePostalDataGridViewTextBoxColumn
        '
        Me.PcodePostalDataGridViewTextBoxColumn.DataPropertyName = "p_codePostal"
        Me.PcodePostalDataGridViewTextBoxColumn.HeaderText = "p_codePostal"
        Me.PcodePostalDataGridViewTextBoxColumn.Name = "PcodePostalDataGridViewTextBoxColumn"
        Me.PcodePostalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PvilleDataGridViewTextBoxColumn
        '
        Me.PvilleDataGridViewTextBoxColumn.DataPropertyName = "p_ville"
        Me.PvilleDataGridViewTextBoxColumn.HeaderText = "p_ville"
        Me.PvilleDataGridViewTextBoxColumn.Name = "PvilleDataGridViewTextBoxColumn"
        Me.PvilleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PpaysDataGridViewTextBoxColumn
        '
        Me.PpaysDataGridViewTextBoxColumn.DataPropertyName = "p_pays"
        Me.PpaysDataGridViewTextBoxColumn.HeaderText = "p_pays"
        Me.PpaysDataGridViewTextBoxColumn.Name = "PpaysDataGridViewTextBoxColumn"
        Me.PpaysDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PStatutDataGridViewTextBoxColumn
        '
        Me.PStatutDataGridViewTextBoxColumn.DataPropertyName = "p_Statut"
        Me.PStatutDataGridViewTextBoxColumn.HeaderText = "p_Statut"
        Me.PStatutDataGridViewTextBoxColumn.Name = "PStatutDataGridViewTextBoxColumn"
        Me.PStatutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PniveauEtudesDataGridViewTextBoxColumn
        '
        Me.PniveauEtudesDataGridViewTextBoxColumn.DataPropertyName = "p_niveauEtudes"
        Me.PniveauEtudesDataGridViewTextBoxColumn.HeaderText = "p_niveauEtudes"
        Me.PniveauEtudesDataGridViewTextBoxColumn.Name = "PniveauEtudesDataGridViewTextBoxColumn"
        Me.PniveauEtudesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PautreDataGridViewTextBoxColumn
        '
        Me.PautreDataGridViewTextBoxColumn.DataPropertyName = "p_autre"
        Me.PautreDataGridViewTextBoxColumn.HeaderText = "p_autre"
        Me.PautreDataGridViewTextBoxColumn.Name = "PautreDataGridViewTextBoxColumn"
        Me.PautreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PprofessionDataGridViewTextBoxColumn
        '
        Me.PprofessionDataGridViewTextBoxColumn.DataPropertyName = "p_profession"
        Me.PprofessionDataGridViewTextBoxColumn.HeaderText = "p_profession"
        Me.PprofessionDataGridViewTextBoxColumn.Name = "PprofessionDataGridViewTextBoxColumn"
        Me.PprofessionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PdomaineEmploiDataGridViewTextBoxColumn
        '
        Me.PdomaineEmploiDataGridViewTextBoxColumn.DataPropertyName = "p_domaineEmploi"
        Me.PdomaineEmploiDataGridViewTextBoxColumn.HeaderText = "p_domaineEmploi"
        Me.PdomaineEmploiDataGridViewTextBoxColumn.Name = "PdomaineEmploiDataGridViewTextBoxColumn"
        Me.PdomaineEmploiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmailPersoDataGridViewTextBoxColumn
        '
        Me.PmailPersoDataGridViewTextBoxColumn.DataPropertyName = "p_mailPerso"
        Me.PmailPersoDataGridViewTextBoxColumn.HeaderText = "p_mailPerso"
        Me.PmailPersoDataGridViewTextBoxColumn.Name = "PmailPersoDataGridViewTextBoxColumn"
        Me.PmailPersoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmailProDataGridViewTextBoxColumn
        '
        Me.PmailProDataGridViewTextBoxColumn.DataPropertyName = "p_mailPro"
        Me.PmailProDataGridViewTextBoxColumn.HeaderText = "p_mailPro"
        Me.PmailProDataGridViewTextBoxColumn.Name = "PmailProDataGridViewTextBoxColumn"
        Me.PmailProDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PtelProDataGridViewTextBoxColumn
        '
        Me.PtelProDataGridViewTextBoxColumn.DataPropertyName = "p_telPro"
        Me.PtelProDataGridViewTextBoxColumn.HeaderText = "p_telPro"
        Me.PtelProDataGridViewTextBoxColumn.Name = "PtelProDataGridViewTextBoxColumn"
        Me.PtelProDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PtelPersoDataGridViewTextBoxColumn
        '
        Me.PtelPersoDataGridViewTextBoxColumn.DataPropertyName = "p_telPerso"
        Me.PtelPersoDataGridViewTextBoxColumn.HeaderText = "p_telPerso"
        Me.PtelPersoDataGridViewTextBoxColumn.Name = "PtelPersoDataGridViewTextBoxColumn"
        Me.PtelPersoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PcvOuiNonDataGridViewCheckBoxColumn
        '
        Me.PcvOuiNonDataGridViewCheckBoxColumn.DataPropertyName = "p_cvOuiNon"
        Me.PcvOuiNonDataGridViewCheckBoxColumn.HeaderText = "p_cvOuiNon"
        Me.PcvOuiNonDataGridViewCheckBoxColumn.Name = "PcvOuiNonDataGridViewCheckBoxColumn"
        Me.PcvOuiNonDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PlettreMotivationOuiNonDataGridViewCheckBoxColumn
        '
        Me.PlettreMotivationOuiNonDataGridViewCheckBoxColumn.DataPropertyName = "p_lettreMotivationOuiNon"
        Me.PlettreMotivationOuiNonDataGridViewCheckBoxColumn.HeaderText = "p_lettreMotivationOuiNon"
        Me.PlettreMotivationOuiNonDataGridViewCheckBoxColumn.Name = "PlettreMotivationOuiNonDataGridViewCheckBoxColumn"
        Me.PlettreMotivationOuiNonDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PdateDebutContratDataGridViewTextBoxColumn
        '
        Me.PdateDebutContratDataGridViewTextBoxColumn.DataPropertyName = "p_dateDebutContrat"
        Me.PdateDebutContratDataGridViewTextBoxColumn.HeaderText = "p_dateDebutContrat"
        Me.PdateDebutContratDataGridViewTextBoxColumn.Name = "PdateDebutContratDataGridViewTextBoxColumn"
        Me.PdateDebutContratDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PdateFinContratDataGridViewTextBoxColumn
        '
        Me.PdateFinContratDataGridViewTextBoxColumn.DataPropertyName = "p_dateFinContrat"
        Me.PdateFinContratDataGridViewTextBoxColumn.HeaderText = "p_dateFinContrat"
        Me.PdateFinContratDataGridViewTextBoxColumn.Name = "PdateFinContratDataGridViewTextBoxColumn"
        Me.PdateFinContratDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaccompteOuiNonDataGridViewCheckBoxColumn
        '
        Me.PaccompteOuiNonDataGridViewCheckBoxColumn.DataPropertyName = "p_accompteOuiNon"
        Me.PaccompteOuiNonDataGridViewCheckBoxColumn.HeaderText = "p_accompteOuiNon"
        Me.PaccompteOuiNonDataGridViewCheckBoxColumn.Name = "PaccompteOuiNonDataGridViewCheckBoxColumn"
        Me.PaccompteOuiNonDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PnumeroChequeDataGridViewTextBoxColumn
        '
        Me.PnumeroChequeDataGridViewTextBoxColumn.DataPropertyName = "p_numeroCheque"
        Me.PnumeroChequeDataGridViewTextBoxColumn.HeaderText = "p_numeroCheque"
        Me.PnumeroChequeDataGridViewTextBoxColumn.Name = "PnumeroChequeDataGridViewTextBoxColumn"
        Me.PnumeroChequeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PfinancementDataGridViewTextBoxColumn
        '
        Me.PfinancementDataGridViewTextBoxColumn.DataPropertyName = "p_financement"
        Me.PfinancementDataGridViewTextBoxColumn.HeaderText = "p_financement"
        Me.PfinancementDataGridViewTextBoxColumn.Name = "PfinancementDataGridViewTextBoxColumn"
        Me.PfinancementDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PfideliteDataGridViewTextBoxColumn
        '
        Me.PfideliteDataGridViewTextBoxColumn.DataPropertyName = "p_fidelite"
        Me.PfideliteDataGridViewTextBoxColumn.HeaderText = "p_fidelite"
        Me.PfideliteDataGridViewTextBoxColumn.Name = "PfideliteDataGridViewTextBoxColumn"
        Me.PfideliteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DossierBindingSource
        '
        Me.DossierBindingSource.DataSource = GetType(WindowsApplication1.Dossier)
        '
        'Consultation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 649)
        Me.Controls.Add(Me.labTrier)
        Me.Controls.Add(Me.txtRechercher)
        Me.Controls.Add(Me.labRechercher)
        Me.Controls.Add(Me.cbTrier)
        Me.Controls.Add(Me.btnModifier)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.btnGenerer)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.dtgDossiers)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Consultation"
        Me.Text = "Consultation"
        CType(Me.dtgDossiers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DossierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgDossiers As DataGridView
    Friend WithEvents btnRetour As Button
    Friend WithEvents btnGenerer As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents cbTrier As ComboBox
    Friend WithEvents labRechercher As Label
    Friend WithEvents txtRechercher As TextBox
    Friend WithEvents labTrier As Label
    Friend WithEvents DossierBindingSource As BindingSource
    Friend WithEvents colCivilite As DataGridViewTextBoxColumn
    Friend WithEvents colNom As DataGridViewTextBoxColumn
    Friend WithEvents colPrenom As DataGridViewTextBoxColumn
    Friend WithEvents colNaissance As DataGridViewTextBoxColumn
    Friend WithEvents colAdresse As DataGridViewTextBoxColumn
    Friend WithEvents colComplement As DataGridViewTextBoxColumn
    Friend WithEvents colCP As DataGridViewTextBoxColumn
    Friend WithEvents colVille As DataGridViewTextBoxColumn
    Friend WithEvents colPays As DataGridViewTextBoxColumn
    Friend WithEvents colStatut As DataGridViewTextBoxColumn
    Friend WithEvents colDiplome As DataGridViewTextBoxColumn
    Friend WithEvents colProfession As DataGridViewTextBoxColumn
    Friend WithEvents colDomaine As DataGridViewTextBoxColumn
    Friend WithEvents colMailPerso As DataGridViewTextBoxColumn
    Friend WithEvents colMailPro As DataGridViewTextBoxColumn
    Friend WithEvents colTelPro As DataGridViewTextBoxColumn
    Friend WithEvents colTelPerso As DataGridViewTextBoxColumn
    Friend WithEvents colCV As DataGridViewCheckBoxColumn
    Friend WithEvents colMotiv As DataGridViewCheckBoxColumn
    Friend WithEvents colDebutContrat As DataGridViewTextBoxColumn
    Friend WithEvents colFinContrat As DataGridViewTextBoxColumn
    Friend WithEvents colAcompte As DataGridViewCheckBoxColumn
    Friend WithEvents colCheque As DataGridViewTextBoxColumn
    Friend WithEvents colFinancement As DataGridViewTextBoxColumn
    Friend WithEvents colCommentaire As DataGridViewTextBoxColumn
    Friend WithEvents PciviliteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PnomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PprenomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PdateNaissanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PadresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PcomplementAdresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PcodePostalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PvilleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PpaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PStatutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PniveauEtudesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PautreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PprofessionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PdomaineEmploiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PmailPersoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PmailProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PtelProDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PtelPersoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PcvOuiNonDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PlettreMotivationOuiNonDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PdateDebutContratDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PdateFinContratDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaccompteOuiNonDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PnumeroChequeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PfinancementDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PfideliteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
