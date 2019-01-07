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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.ButtonGenerer = New System.Windows.Forms.Button()
        Me.ButtonExporterCSV = New System.Windows.Forms.Button()
        Me.ButtonSupprimer = New System.Windows.Forms.Button()
        Me.ButtonModifier = New System.Windows.Forms.Button()
        Me.ButtonRecherche = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ComboBoxTrier = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnSelect, Me.ColumnNumero, Me.ColumnCivilite, Me.ColumnNom, Me.ColumnPrenom, Me.ColumnDateNaissance, Me.ColumnAdresse, Me.ColumnPays, Me.ColumnRegion, Me.ColumnDiplome, Me.ColumnProfession, Me.ColumnMailPerso, Me.ColumnMailPro, Me.ColumnTelPerso, Me.ColumnTelPro, Me.ColumnDateDebutContrat, Me.ColumnDateFinContrat, Me.ColumnStatus, Me.ColumnCurri, Me.ColumnLettreMotive, Me.ColumnAccompte, Me.ColumnNumeroCheque, Me.ColumnCommentaire})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(810, 351)
        Me.DataGridView1.TabIndex = 0
        '
        'ColumnSelect
        '
        Me.ColumnSelect.HeaderText = "Select"
        Me.ColumnSelect.Name = "ColumnSelect"
        '
        'ColumnNumero
        '
        Me.ColumnNumero.HeaderText = "Numéro"
        Me.ColumnNumero.Name = "ColumnNumero"
        '
        'ColumnCivilite
        '
        Me.ColumnCivilite.HeaderText = "Civilité"
        Me.ColumnCivilite.Name = "ColumnCivilite"
        '
        'ColumnNom
        '
        Me.ColumnNom.HeaderText = "Nom"
        Me.ColumnNom.Name = "ColumnNom"
        '
        'ColumnPrenom
        '
        Me.ColumnPrenom.HeaderText = "Prénom"
        Me.ColumnPrenom.Name = "ColumnPrenom"
        '
        'ColumnDateNaissance
        '
        Me.ColumnDateNaissance.HeaderText = "Date de naissance"
        Me.ColumnDateNaissance.Name = "ColumnDateNaissance"
        '
        'ColumnAdresse
        '
        Me.ColumnAdresse.HeaderText = "Adresse"
        Me.ColumnAdresse.Name = "ColumnAdresse"
        '
        'ColumnPays
        '
        Me.ColumnPays.HeaderText = "Pays"
        Me.ColumnPays.Name = "ColumnPays"
        '
        'ColumnRegion
        '
        Me.ColumnRegion.HeaderText = "Région"
        Me.ColumnRegion.Name = "ColumnRegion"
        '
        'ColumnDiplome
        '
        Me.ColumnDiplome.HeaderText = "Diplôme"
        Me.ColumnDiplome.Name = "ColumnDiplome"
        '
        'ColumnProfession
        '
        Me.ColumnProfession.HeaderText = "Profession"
        Me.ColumnProfession.Name = "ColumnProfession"
        '
        'ColumnMailPerso
        '
        Me.ColumnMailPerso.HeaderText = "Mail Perso"
        Me.ColumnMailPerso.Name = "ColumnMailPerso"
        '
        'ColumnMailPro
        '
        Me.ColumnMailPro.HeaderText = "Mail Pro"
        Me.ColumnMailPro.Name = "ColumnMailPro"
        '
        'ColumnTelPerso
        '
        Me.ColumnTelPerso.HeaderText = "Tel Perso"
        Me.ColumnTelPerso.Name = "ColumnTelPerso"
        '
        'ColumnTelPro
        '
        Me.ColumnTelPro.HeaderText = "Tel Pro"
        Me.ColumnTelPro.Name = "ColumnTelPro"
        '
        'ColumnDateDebutContrat
        '
        Me.ColumnDateDebutContrat.HeaderText = "Date de début de contrat"
        Me.ColumnDateDebutContrat.Name = "ColumnDateDebutContrat"
        '
        'ColumnDateFinContrat
        '
        Me.ColumnDateFinContrat.HeaderText = "Date de fin de Contrat"
        Me.ColumnDateFinContrat.Name = "ColumnDateFinContrat"
        '
        'ColumnStatus
        '
        Me.ColumnStatus.HeaderText = "Status"
        Me.ColumnStatus.Name = "ColumnStatus"
        '
        'ColumnCurri
        '
        Me.ColumnCurri.HeaderText = "Curriculum Vitae"
        Me.ColumnCurri.Name = "ColumnCurri"
        '
        'ColumnLettreMotive
        '
        Me.ColumnLettreMotive.HeaderText = "Lettre de motivation"
        Me.ColumnLettreMotive.Name = "ColumnLettreMotive"
        '
        'ColumnAccompte
        '
        Me.ColumnAccompte.HeaderText = "Accompte"
        Me.ColumnAccompte.Name = "ColumnAccompte"
        '
        'ColumnNumeroCheque
        '
        Me.ColumnNumeroCheque.HeaderText = "Numéro de cheque"
        Me.ColumnNumeroCheque.Name = "ColumnNumeroCheque"
        '
        'ColumnCommentaire
        '
        Me.ColumnCommentaire.HeaderText = "Commentaire"
        Me.ColumnCommentaire.Name = "ColumnCommentaire"
        '
        'ButtonRetour
        '
        Me.ButtonRetour.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ButtonRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRetour.Location = New System.Drawing.Point(646, 25)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(136, 43)
        Me.ButtonRetour.TabIndex = 1
        Me.ButtonRetour.Text = "Retour Menu"
        Me.ButtonRetour.UseVisualStyleBackColor = False
        '
        'ButtonGenerer
        '
        Me.ButtonGenerer.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ButtonGenerer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGenerer.Location = New System.Drawing.Point(705, 462)
        Me.ButtonGenerer.Name = "ButtonGenerer"
        Me.ButtonGenerer.Size = New System.Drawing.Size(117, 43)
        Me.ButtonGenerer.TabIndex = 2
        Me.ButtonGenerer.Text = "Générer PDF"
        Me.ButtonGenerer.UseVisualStyleBackColor = False
        '
        'ButtonExporterCSV
        '
        Me.ButtonExporterCSV.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ButtonExporterCSV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExporterCSV.Location = New System.Drawing.Point(569, 462)
        Me.ButtonExporterCSV.Name = "ButtonExporterCSV"
        Me.ButtonExporterCSV.Size = New System.Drawing.Size(115, 43)
        Me.ButtonExporterCSV.TabIndex = 3
        Me.ButtonExporterCSV.Text = "Exporter CSV"
        Me.ButtonExporterCSV.UseVisualStyleBackColor = False
        '
        'ButtonSupprimer
        '
        Me.ButtonSupprimer.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ButtonSupprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSupprimer.Location = New System.Drawing.Point(284, 462)
        Me.ButtonSupprimer.Name = "ButtonSupprimer"
        Me.ButtonSupprimer.Size = New System.Drawing.Size(116, 43)
        Me.ButtonSupprimer.TabIndex = 4
        Me.ButtonSupprimer.Text = "Supprimer"
        Me.ButtonSupprimer.UseVisualStyleBackColor = False
        '
        'ButtonModifier
        '
        Me.ButtonModifier.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ButtonModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModifier.Location = New System.Drawing.Point(141, 462)
        Me.ButtonModifier.Name = "ButtonModifier"
        Me.ButtonModifier.Size = New System.Drawing.Size(119, 43)
        Me.ButtonModifier.TabIndex = 5
        Me.ButtonModifier.Text = "Modifier"
        Me.ButtonModifier.UseVisualStyleBackColor = False
        '
        'ButtonRecherche
        '
        Me.ButtonRecherche.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ButtonRecherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRecherche.Location = New System.Drawing.Point(12, 462)
        Me.ButtonRecherche.Name = "ButtonRecherche"
        Me.ButtonRecherche.Size = New System.Drawing.Size(107, 43)
        Me.ButtonRecherche.TabIndex = 6
        Me.ButtonRecherche.Text = "Rechercher"
        Me.ButtonRecherche.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(425, 462)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(123, 43)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Exporter Gmail"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'ComboBoxTrier
        '
        Me.ComboBoxTrier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxTrier.FormattingEnabled = True
        Me.ComboBoxTrier.Location = New System.Drawing.Point(12, 38)
        Me.ComboBoxTrier.Name = "ComboBoxTrier"
        Me.ComboBoxTrier.Size = New System.Drawing.Size(152, 28)
        Me.ComboBoxTrier.TabIndex = 8
        Me.ComboBoxTrier.Text = "Trier par :"
        '
        'Consultation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 527)
        Me.Controls.Add(Me.ComboBoxTrier)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ButtonRecherche)
        Me.Controls.Add(Me.ButtonModifier)
        Me.Controls.Add(Me.ButtonSupprimer)
        Me.Controls.Add(Me.ButtonExporterCSV)
        Me.Controls.Add(Me.ButtonGenerer)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Consultation"
        Me.Text = "Consultation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents ButtonRetour As Button
    Friend WithEvents ButtonGenerer As Button
    Friend WithEvents ButtonExporterCSV As Button
    Friend WithEvents ButtonSupprimer As Button
    Friend WithEvents ButtonModifier As Button
    Friend WithEvents ButtonRecherche As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ComboBoxTrier As ComboBox
End Class
