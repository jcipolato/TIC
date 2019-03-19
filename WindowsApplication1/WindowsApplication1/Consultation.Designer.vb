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
        Me.dtgDossiers = New System.Windows.Forms.DataGridView()
        Me.ColumnSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColumnNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCivilite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPrenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDateNaissance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAdresse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnRegion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDiplome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnProfession = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnMailPerso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnMailPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTelPerso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTelPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDateDebutContrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDateFinContrat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCurri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnLettreMotive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnAccompte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNumeroCheque = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCommentaire = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.btnGenerer = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.cbTrier = New System.Windows.Forms.ComboBox()
        Me.labRechercher = New System.Windows.Forms.Label()
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.labTrier = New System.Windows.Forms.Label()
        CType(Me.dtgDossiers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgDossiers
        '
        Me.dtgDossiers.AllowUserToAddRows = False
        Me.dtgDossiers.AllowUserToDeleteRows = False
        Me.dtgDossiers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDossiers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnSelect, Me.ColumnNumero, Me.ColumnCivilite, Me.ColumnNom, Me.ColumnPrenom, Me.ColumnDateNaissance, Me.ColumnAdresse, Me.ColumnPays, Me.ColumnRegion, Me.ColumnDiplome, Me.ColumnProfession, Me.ColumnMailPerso, Me.ColumnMailPro, Me.ColumnTelPerso, Me.ColumnTelPro, Me.ColumnDateDebutContrat, Me.ColumnDateFinContrat, Me.ColumnStatus, Me.ColumnCurri, Me.ColumnLettreMotive, Me.ColumnAccompte, Me.ColumnNumeroCheque, Me.ColumnCommentaire})
        Me.dtgDossiers.Location = New System.Drawing.Point(16, 124)
        Me.dtgDossiers.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgDossiers.Name = "dtgDossiers"
        Me.dtgDossiers.ReadOnly = True
        Me.dtgDossiers.Size = New System.Drawing.Size(1080, 458)
        Me.dtgDossiers.TabIndex = 0
        '
        'ColumnSelect
        '
        Me.ColumnSelect.HeaderText = "Select"
        Me.ColumnSelect.Name = "ColumnSelect"
        Me.ColumnSelect.ReadOnly = True
        '
        'ColumnNumero
        '
        Me.ColumnNumero.HeaderText = "Numéro"
        Me.ColumnNumero.Name = "ColumnNumero"
        Me.ColumnNumero.ReadOnly = True
        '
        'ColumnCivilite
        '
        Me.ColumnCivilite.HeaderText = "Civilité"
        Me.ColumnCivilite.Name = "ColumnCivilite"
        Me.ColumnCivilite.ReadOnly = True
        '
        'ColumnNom
        '
        Me.ColumnNom.HeaderText = "Nom"
        Me.ColumnNom.Name = "ColumnNom"
        Me.ColumnNom.ReadOnly = True
        '
        'ColumnPrenom
        '
        Me.ColumnPrenom.HeaderText = "Prénom"
        Me.ColumnPrenom.Name = "ColumnPrenom"
        Me.ColumnPrenom.ReadOnly = True
        '
        'ColumnDateNaissance
        '
        Me.ColumnDateNaissance.HeaderText = "Date de naissance"
        Me.ColumnDateNaissance.Name = "ColumnDateNaissance"
        Me.ColumnDateNaissance.ReadOnly = True
        '
        'ColumnAdresse
        '
        Me.ColumnAdresse.HeaderText = "Adresse"
        Me.ColumnAdresse.Name = "ColumnAdresse"
        Me.ColumnAdresse.ReadOnly = True
        '
        'ColumnPays
        '
        Me.ColumnPays.HeaderText = "Pays"
        Me.ColumnPays.Name = "ColumnPays"
        Me.ColumnPays.ReadOnly = True
        '
        'ColumnRegion
        '
        Me.ColumnRegion.HeaderText = "Code postal"
        Me.ColumnRegion.Name = "ColumnRegion"
        Me.ColumnRegion.ReadOnly = True
        '
        'ColumnDiplome
        '
        Me.ColumnDiplome.HeaderText = "Diplôme"
        Me.ColumnDiplome.Name = "ColumnDiplome"
        Me.ColumnDiplome.ReadOnly = True
        '
        'ColumnProfession
        '
        Me.ColumnProfession.HeaderText = "Profession"
        Me.ColumnProfession.Name = "ColumnProfession"
        Me.ColumnProfession.ReadOnly = True
        '
        'ColumnMailPerso
        '
        Me.ColumnMailPerso.HeaderText = "Mail Perso"
        Me.ColumnMailPerso.Name = "ColumnMailPerso"
        Me.ColumnMailPerso.ReadOnly = True
        '
        'ColumnMailPro
        '
        Me.ColumnMailPro.HeaderText = "Mail Pro"
        Me.ColumnMailPro.Name = "ColumnMailPro"
        Me.ColumnMailPro.ReadOnly = True
        '
        'ColumnTelPerso
        '
        Me.ColumnTelPerso.HeaderText = "Tel Perso"
        Me.ColumnTelPerso.Name = "ColumnTelPerso"
        Me.ColumnTelPerso.ReadOnly = True
        '
        'ColumnTelPro
        '
        Me.ColumnTelPro.HeaderText = "Tel Pro"
        Me.ColumnTelPro.Name = "ColumnTelPro"
        Me.ColumnTelPro.ReadOnly = True
        '
        'ColumnDateDebutContrat
        '
        Me.ColumnDateDebutContrat.HeaderText = "Date de début de contrat"
        Me.ColumnDateDebutContrat.Name = "ColumnDateDebutContrat"
        Me.ColumnDateDebutContrat.ReadOnly = True
        '
        'ColumnDateFinContrat
        '
        Me.ColumnDateFinContrat.HeaderText = "Date de fin de contrat"
        Me.ColumnDateFinContrat.Name = "ColumnDateFinContrat"
        Me.ColumnDateFinContrat.ReadOnly = True
        '
        'ColumnStatus
        '
        Me.ColumnStatus.HeaderText = "Statut"
        Me.ColumnStatus.Name = "ColumnStatus"
        Me.ColumnStatus.ReadOnly = True
        '
        'ColumnCurri
        '
        Me.ColumnCurri.HeaderText = "Curriculum Vitae"
        Me.ColumnCurri.Name = "ColumnCurri"
        Me.ColumnCurri.ReadOnly = True
        '
        'ColumnLettreMotive
        '
        Me.ColumnLettreMotive.HeaderText = "Lettre de motivation"
        Me.ColumnLettreMotive.Name = "ColumnLettreMotive"
        Me.ColumnLettreMotive.ReadOnly = True
        '
        'ColumnAccompte
        '
        Me.ColumnAccompte.HeaderText = "Acompte"
        Me.ColumnAccompte.Name = "ColumnAccompte"
        Me.ColumnAccompte.ReadOnly = True
        '
        'ColumnNumeroCheque
        '
        Me.ColumnNumeroCheque.HeaderText = "Numéro de cheque"
        Me.ColumnNumeroCheque.Name = "ColumnNumeroCheque"
        Me.ColumnNumeroCheque.ReadOnly = True
        '
        'ColumnCommentaire
        '
        Me.ColumnCommentaire.HeaderText = "Commentaire"
        Me.ColumnCommentaire.Name = "ColumnCommentaire"
        Me.ColumnCommentaire.ReadOnly = True
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgDossiers As DataGridView
    Friend WithEvents btnRetour As Button
    Friend WithEvents btnGenerer As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents cbTrier As ComboBox
    Friend WithEvents ColumnSelect As DataGridViewCheckBoxColumn
    Friend WithEvents ColumnNumero As DataGridViewTextBoxColumn
    Friend WithEvents ColumnCivilite As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNom As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPrenom As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDateNaissance As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAdresse As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPays As DataGridViewTextBoxColumn
    Friend WithEvents ColumnRegion As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDiplome As DataGridViewTextBoxColumn
    Friend WithEvents ColumnProfession As DataGridViewTextBoxColumn
    Friend WithEvents ColumnMailPerso As DataGridViewTextBoxColumn
    Friend WithEvents ColumnMailPro As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTelPerso As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTelPro As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDateDebutContrat As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDateFinContrat As DataGridViewTextBoxColumn
    Friend WithEvents ColumnStatus As DataGridViewTextBoxColumn
    Friend WithEvents ColumnCurri As DataGridViewTextBoxColumn
    Friend WithEvents ColumnLettreMotive As DataGridViewTextBoxColumn
    Friend WithEvents ColumnAccompte As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNumeroCheque As DataGridViewTextBoxColumn
    Friend WithEvents ColumnCommentaire As DataGridViewTextBoxColumn
    Friend WithEvents labRechercher As Label
    Friend WithEvents txtRechercher As TextBox
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
    Friend WithEvents labTrier As Label
End Class
