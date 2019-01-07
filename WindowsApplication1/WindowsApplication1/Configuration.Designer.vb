<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuration
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
        Me.LabelFichierExcel = New System.Windows.Forms.Label()
        Me.ButtonParcourir = New System.Windows.Forms.Button()
        Me.TextBoxFichierExcel = New System.Windows.Forms.TextBox()
        Me.LabelExporter = New System.Windows.Forms.Label()
        Me.ButtonBackup = New System.Windows.Forms.Button()
        Me.ButtonAppliquer = New System.Windows.Forms.Button()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelFichierExcel
        '
        Me.LabelFichierExcel.AutoSize = True
        Me.LabelFichierExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFichierExcel.Location = New System.Drawing.Point(58, 75)
        Me.LabelFichierExcel.Name = "LabelFichierExcel"
        Me.LabelFichierExcel.Size = New System.Drawing.Size(180, 20)
        Me.LabelFichierExcel.TabIndex = 0
        Me.LabelFichierExcel.Text = "Changer de fichier Excel"
        '
        'ButtonParcourir
        '
        Me.ButtonParcourir.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ButtonParcourir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonParcourir.Location = New System.Drawing.Point(490, 67)
        Me.ButtonParcourir.Name = "ButtonParcourir"
        Me.ButtonParcourir.Size = New System.Drawing.Size(102, 37)
        Me.ButtonParcourir.TabIndex = 2
        Me.ButtonParcourir.Text = "Parcourir..."
        Me.ButtonParcourir.UseVisualStyleBackColor = False
        '
        'TextBoxFichierExcel
        '
        Me.TextBoxFichierExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TextBoxFichierExcel.Location = New System.Drawing.Point(248, 69)
        Me.TextBoxFichierExcel.Name = "TextBoxFichierExcel"
        Me.TextBoxFichierExcel.Size = New System.Drawing.Size(207, 29)
        Me.TextBoxFichierExcel.TabIndex = 6
        Me.TextBoxFichierExcel.Text = "Fichier.XLS"
        '
        'LabelExporter
        '
        Me.LabelExporter.AutoSize = True
        Me.LabelExporter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelExporter.Location = New System.Drawing.Point(58, 145)
        Me.LabelExporter.Name = "LabelExporter"
        Me.LabelExporter.Size = New System.Drawing.Size(305, 20)
        Me.LabelExporter.TabIndex = 7
        Me.LabelExporter.Text = "Exporter la base de données entierement "
        '
        'ButtonBackup
        '
        Me.ButtonBackup.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ButtonBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBackup.Location = New System.Drawing.Point(490, 138)
        Me.ButtonBackup.Name = "ButtonBackup"
        Me.ButtonBackup.Size = New System.Drawing.Size(102, 35)
        Me.ButtonBackup.TabIndex = 8
        Me.ButtonBackup.Text = "Backup"
        Me.ButtonBackup.UseVisualStyleBackColor = False
        '
        'ButtonAppliquer
        '
        Me.ButtonAppliquer.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ButtonAppliquer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAppliquer.Location = New System.Drawing.Point(286, 360)
        Me.ButtonAppliquer.Name = "ButtonAppliquer"
        Me.ButtonAppliquer.Size = New System.Drawing.Size(136, 50)
        Me.ButtonAppliquer.TabIndex = 9
        Me.ButtonAppliquer.Text = "Appliquer"
        Me.ButtonAppliquer.UseVisualStyleBackColor = False
        '
        'ButtonRetour
        '
        Me.ButtonRetour.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ButtonRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRetour.Location = New System.Drawing.Point(460, 360)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(132, 50)
        Me.ButtonRetour.TabIndex = 10
        Me.ButtonRetour.Text = "Retour Menu"
        Me.ButtonRetour.UseVisualStyleBackColor = False
        '
        'Configuration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 451)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.ButtonAppliquer)
        Me.Controls.Add(Me.ButtonBackup)
        Me.Controls.Add(Me.LabelExporter)
        Me.Controls.Add(Me.TextBoxFichierExcel)
        Me.Controls.Add(Me.ButtonParcourir)
        Me.Controls.Add(Me.LabelFichierExcel)
        Me.Name = "Configuration"
        Me.Text = "Configuration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelFichierExcel As Label
    Friend WithEvents ButtonParcourir As Button
    Friend WithEvents TextBoxFichierExcel As TextBox
    Friend WithEvents LabelExporter As Label
    Friend WithEvents ButtonBackup As Button
    Friend WithEvents ButtonAppliquer As Button
    Friend WithEvents ButtonRetour As Button
End Class
