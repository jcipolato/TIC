<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.PciviliteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PnomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PprenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PdateNaissanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PadresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcomplementAdresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PcodePostalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PvilleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PpaysDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PniveauEtudesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.PacompteOuiNonDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PnumeroChequeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PfinancementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PfideliteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DossierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnGenerer = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.cbTrier = New System.Windows.Forms.ComboBox()
        Me.labRechercher = New System.Windows.Forms.Label()
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.labTrier = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.dtgDossiers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PciviliteDataGridViewTextBoxColumn, Me.PnomDataGridViewTextBoxColumn, Me.PprenomDataGridViewTextBoxColumn, Me.PdateNaissanceDataGridViewTextBoxColumn, Me.PadresseDataGridViewTextBoxColumn, Me.PcomplementAdresseDataGridViewTextBoxColumn, Me.PcodePostalDataGridViewTextBoxColumn, Me.PvilleDataGridViewTextBoxColumn, Me.PpaysDataGridViewTextBoxColumn, Me.PniveauEtudesDataGridViewTextBoxColumn, Me.PprofessionDataGridViewTextBoxColumn, Me.PdomaineEmploiDataGridViewTextBoxColumn, Me.PmailPersoDataGridViewTextBoxColumn, Me.PmailProDataGridViewTextBoxColumn, Me.PtelProDataGridViewTextBoxColumn, Me.PtelPersoDataGridViewTextBoxColumn, Me.PcvOuiNonDataGridViewCheckBoxColumn, Me.PlettreMotivationOuiNonDataGridViewCheckBoxColumn, Me.PdateDebutContratDataGridViewTextBoxColumn, Me.PdateFinContratDataGridViewTextBoxColumn, Me.PacompteOuiNonDataGridViewCheckBoxColumn, Me.PnumeroChequeDataGridViewTextBoxColumn, Me.PfinancementDataGridViewTextBoxColumn, Me.PfideliteDataGridViewTextBoxColumn})
        Me.dtgDossiers.DataSource = Me.DossierBindingSource
        Me.dtgDossiers.Location = New System.Drawing.Point(16, 124)
        Me.dtgDossiers.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgDossiers.MultiSelect = False
        Me.dtgDossiers.Name = "dtgDossiers"
        Me.dtgDossiers.Size = New System.Drawing.Size(1080, 458)
        Me.dtgDossiers.TabIndex = 0
        '
        'PciviliteDataGridViewTextBoxColumn
        '
        Me.PciviliteDataGridViewTextBoxColumn.DataPropertyName = "p_civilite"
        Me.PciviliteDataGridViewTextBoxColumn.HeaderText = "Civilité"
        Me.PciviliteDataGridViewTextBoxColumn.Name = "PciviliteDataGridViewTextBoxColumn"
        Me.PciviliteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PnomDataGridViewTextBoxColumn
        '
        Me.PnomDataGridViewTextBoxColumn.DataPropertyName = "p_nom"
        Me.PnomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.PnomDataGridViewTextBoxColumn.Name = "PnomDataGridViewTextBoxColumn"
        Me.PnomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PprenomDataGridViewTextBoxColumn
        '
        Me.PprenomDataGridViewTextBoxColumn.DataPropertyName = "p_prenom"
        Me.PprenomDataGridViewTextBoxColumn.HeaderText = "Prénom"
        Me.PprenomDataGridViewTextBoxColumn.Name = "PprenomDataGridViewTextBoxColumn"
        Me.PprenomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PdateNaissanceDataGridViewTextBoxColumn
        '
        Me.PdateNaissanceDataGridViewTextBoxColumn.DataPropertyName = "p_dateNaissance"
        Me.PdateNaissanceDataGridViewTextBoxColumn.HeaderText = "Date de naissance"
        Me.PdateNaissanceDataGridViewTextBoxColumn.Name = "PdateNaissanceDataGridViewTextBoxColumn"
        Me.PdateNaissanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PadresseDataGridViewTextBoxColumn
        '
        Me.PadresseDataGridViewTextBoxColumn.DataPropertyName = "p_adresse"
        Me.PadresseDataGridViewTextBoxColumn.HeaderText = "Adresse"
        Me.PadresseDataGridViewTextBoxColumn.Name = "PadresseDataGridViewTextBoxColumn"
        Me.PadresseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PcomplementAdresseDataGridViewTextBoxColumn
        '
        Me.PcomplementAdresseDataGridViewTextBoxColumn.DataPropertyName = "p_complementAdresse"
        Me.PcomplementAdresseDataGridViewTextBoxColumn.HeaderText = "Complément d'adresse"
        Me.PcomplementAdresseDataGridViewTextBoxColumn.Name = "PcomplementAdresseDataGridViewTextBoxColumn"
        Me.PcomplementAdresseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PcodePostalDataGridViewTextBoxColumn
        '
        Me.PcodePostalDataGridViewTextBoxColumn.DataPropertyName = "p_codePostal"
        Me.PcodePostalDataGridViewTextBoxColumn.HeaderText = "Code postal"
        Me.PcodePostalDataGridViewTextBoxColumn.Name = "PcodePostalDataGridViewTextBoxColumn"
        Me.PcodePostalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PvilleDataGridViewTextBoxColumn
        '
        Me.PvilleDataGridViewTextBoxColumn.DataPropertyName = "p_ville"
        Me.PvilleDataGridViewTextBoxColumn.HeaderText = "Ville"
        Me.PvilleDataGridViewTextBoxColumn.Name = "PvilleDataGridViewTextBoxColumn"
        Me.PvilleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PpaysDataGridViewTextBoxColumn
        '
        Me.PpaysDataGridViewTextBoxColumn.DataPropertyName = "p_pays"
        Me.PpaysDataGridViewTextBoxColumn.HeaderText = "Pays"
        Me.PpaysDataGridViewTextBoxColumn.Name = "PpaysDataGridViewTextBoxColumn"
        Me.PpaysDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PniveauEtudesDataGridViewTextBoxColumn
        '
        Me.PniveauEtudesDataGridViewTextBoxColumn.DataPropertyName = "p_niveauEtudes"
        Me.PniveauEtudesDataGridViewTextBoxColumn.HeaderText = "Diplôme"
        Me.PniveauEtudesDataGridViewTextBoxColumn.Name = "PniveauEtudesDataGridViewTextBoxColumn"
        Me.PniveauEtudesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PprofessionDataGridViewTextBoxColumn
        '
        Me.PprofessionDataGridViewTextBoxColumn.DataPropertyName = "p_profession"
        Me.PprofessionDataGridViewTextBoxColumn.HeaderText = "Profession"
        Me.PprofessionDataGridViewTextBoxColumn.Name = "PprofessionDataGridViewTextBoxColumn"
        Me.PprofessionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PdomaineEmploiDataGridViewTextBoxColumn
        '
        Me.PdomaineEmploiDataGridViewTextBoxColumn.DataPropertyName = "p_domaineEmploi"
        Me.PdomaineEmploiDataGridViewTextBoxColumn.HeaderText = "Domaine d'emploi"
        Me.PdomaineEmploiDataGridViewTextBoxColumn.Name = "PdomaineEmploiDataGridViewTextBoxColumn"
        Me.PdomaineEmploiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmailPersoDataGridViewTextBoxColumn
        '
        Me.PmailPersoDataGridViewTextBoxColumn.DataPropertyName = "p_mailPerso"
        Me.PmailPersoDataGridViewTextBoxColumn.HeaderText = "Mail perso."
        Me.PmailPersoDataGridViewTextBoxColumn.Name = "PmailPersoDataGridViewTextBoxColumn"
        Me.PmailPersoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PmailProDataGridViewTextBoxColumn
        '
        Me.PmailProDataGridViewTextBoxColumn.DataPropertyName = "p_mailPro"
        Me.PmailProDataGridViewTextBoxColumn.HeaderText = "Mail pro."
        Me.PmailProDataGridViewTextBoxColumn.Name = "PmailProDataGridViewTextBoxColumn"
        Me.PmailProDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PtelProDataGridViewTextBoxColumn
        '
        Me.PtelProDataGridViewTextBoxColumn.DataPropertyName = "p_telPro"
        Me.PtelProDataGridViewTextBoxColumn.HeaderText = "Tél. pro."
        Me.PtelProDataGridViewTextBoxColumn.Name = "PtelProDataGridViewTextBoxColumn"
        Me.PtelProDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PtelPersoDataGridViewTextBoxColumn
        '
        Me.PtelPersoDataGridViewTextBoxColumn.DataPropertyName = "p_telPerso"
        Me.PtelPersoDataGridViewTextBoxColumn.HeaderText = "Tél. perso."
        Me.PtelPersoDataGridViewTextBoxColumn.Name = "PtelPersoDataGridViewTextBoxColumn"
        Me.PtelPersoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PcvOuiNonDataGridViewCheckBoxColumn
        '
        Me.PcvOuiNonDataGridViewCheckBoxColumn.DataPropertyName = "p_cvOuiNon"
        Me.PcvOuiNonDataGridViewCheckBoxColumn.HeaderText = "CV"
        Me.PcvOuiNonDataGridViewCheckBoxColumn.Name = "PcvOuiNonDataGridViewCheckBoxColumn"
        Me.PcvOuiNonDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PlettreMotivationOuiNonDataGridViewCheckBoxColumn
        '
        Me.PlettreMotivationOuiNonDataGridViewCheckBoxColumn.DataPropertyName = "p_lettreMotivationOuiNon"
        Me.PlettreMotivationOuiNonDataGridViewCheckBoxColumn.HeaderText = "Lettre de motivation"
        Me.PlettreMotivationOuiNonDataGridViewCheckBoxColumn.Name = "PlettreMotivationOuiNonDataGridViewCheckBoxColumn"
        Me.PlettreMotivationOuiNonDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PdateDebutContratDataGridViewTextBoxColumn
        '
        Me.PdateDebutContratDataGridViewTextBoxColumn.DataPropertyName = "p_dateDebutContrat"
        Me.PdateDebutContratDataGridViewTextBoxColumn.HeaderText = "Début de contrat"
        Me.PdateDebutContratDataGridViewTextBoxColumn.Name = "PdateDebutContratDataGridViewTextBoxColumn"
        Me.PdateDebutContratDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PdateFinContratDataGridViewTextBoxColumn
        '
        Me.PdateFinContratDataGridViewTextBoxColumn.DataPropertyName = "p_dateFinContrat"
        Me.PdateFinContratDataGridViewTextBoxColumn.HeaderText = "Fin de contrat"
        Me.PdateFinContratDataGridViewTextBoxColumn.Name = "PdateFinContratDataGridViewTextBoxColumn"
        Me.PdateFinContratDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PacompteOuiNonDataGridViewCheckBoxColumn
        '
        Me.PacompteOuiNonDataGridViewCheckBoxColumn.DataPropertyName = "p_acompteOuiNon"
        Me.PacompteOuiNonDataGridViewCheckBoxColumn.HeaderText = "Acompte"
        Me.PacompteOuiNonDataGridViewCheckBoxColumn.Name = "PacompteOuiNonDataGridViewCheckBoxColumn"
        Me.PacompteOuiNonDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'PnumeroChequeDataGridViewTextBoxColumn
        '
        Me.PnumeroChequeDataGridViewTextBoxColumn.DataPropertyName = "p_numeroCheque"
        Me.PnumeroChequeDataGridViewTextBoxColumn.HeaderText = "Numéro de chèque"
        Me.PnumeroChequeDataGridViewTextBoxColumn.Name = "PnumeroChequeDataGridViewTextBoxColumn"
        Me.PnumeroChequeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PfinancementDataGridViewTextBoxColumn
        '
        Me.PfinancementDataGridViewTextBoxColumn.DataPropertyName = "p_financement"
        Me.PfinancementDataGridViewTextBoxColumn.HeaderText = "Financement"
        Me.PfinancementDataGridViewTextBoxColumn.Name = "PfinancementDataGridViewTextBoxColumn"
        Me.PfinancementDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PfideliteDataGridViewTextBoxColumn
        '
        Me.PfideliteDataGridViewTextBoxColumn.DataPropertyName = "p_fidelite"
        Me.PfideliteDataGridViewTextBoxColumn.HeaderText = "Commentaire"
        Me.PfideliteDataGridViewTextBoxColumn.Name = "PfideliteDataGridViewTextBoxColumn"
        Me.PfideliteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DossierBindingSource
        '
        Me.DossierBindingSource.DataSource = GetType(WindowsApplication1.Dossier)
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
        Me.btnRetour.Text = "Retour"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'btnGenerer
        '
        Me.btnGenerer.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnGenerer.Enabled = False
        Me.btnGenerer.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.btnGenerer.Location = New System.Drawing.Point(791, 72)
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
        Me.btnSupprimer.Location = New System.Drawing.Point(943, 72)
        Me.btnSupprimer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(122, 33)
        Me.btnSupprimer.TabIndex = 4
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = False
        '
        'cbTrier
        '
        Me.cbTrier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTrier.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cbTrier.FormattingEnabled = True
        Me.cbTrier.Items.AddRange(New Object() {"Nom", "Prénom", "Date de naissance", "Adresse", "Code postal", "Ville", "Pays", "Diplôme", "Profession", "Domaine d'emploi", "Mail perso", "Mail pro", "Tél perso", "Tél pro"})
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 599)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(624, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Pour modifier un dossier, double-cliquez sur la cellule que vous souhaitez modifi" &
    "er."
        '
        'Consultation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 649)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labTrier)
        Me.Controls.Add(Me.txtRechercher)
        Me.Controls.Add(Me.labRechercher)
        Me.Controls.Add(Me.cbTrier)
        Me.Controls.Add(Me.btnSupprimer)
        Me.Controls.Add(Me.btnGenerer)
        Me.Controls.Add(Me.btnRetour)
        Me.Controls.Add(Me.dtgDossiers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
    Friend WithEvents cbTrier As ComboBox
    Friend WithEvents labRechercher As Label
    Friend WithEvents txtRechercher As TextBox
    Friend WithEvents labTrier As Label
    Friend WithEvents DossierBindingSource As BindingSource
    Friend WithEvents PStatutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaccompteOuiNonDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PciviliteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PnomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PprenomDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PdateNaissanceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PadresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PcomplementAdresseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PcodePostalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PvilleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PpaysDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PniveauEtudesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents PacompteOuiNonDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PnumeroChequeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PfinancementDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PfideliteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
