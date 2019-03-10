<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.ButtonInscription = New System.Windows.Forms.Button()
        Me.ButtonConfiguration = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.ButtonConsultaion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonInscription
        '
        Me.ButtonInscription.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ButtonInscription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInscription.Location = New System.Drawing.Point(36, 31)
        Me.ButtonInscription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonInscription.Name = "ButtonInscription"
        Me.ButtonInscription.Size = New System.Drawing.Size(300, 166)
        Me.ButtonInscription.TabIndex = 0
        Me.ButtonInscription.Text = "Inscription"
        Me.ButtonInscription.UseVisualStyleBackColor = False
        '
        'ButtonConfiguration
        '
        Me.ButtonConfiguration.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ButtonConfiguration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConfiguration.Location = New System.Drawing.Point(36, 215)
        Me.ButtonConfiguration.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonConfiguration.Name = "ButtonConfiguration"
        Me.ButtonConfiguration.Size = New System.Drawing.Size(300, 166)
        Me.ButtonConfiguration.TabIndex = 1
        Me.ButtonConfiguration.Text = "Configuration"
        Me.ButtonConfiguration.UseVisualStyleBackColor = False
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ButtonQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitter.Location = New System.Drawing.Point(363, 215)
        Me.ButtonQuitter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(300, 166)
        Me.ButtonQuitter.TabIndex = 2
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = False
        '
        'ButtonConsultaion
        '
        Me.ButtonConsultaion.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ButtonConsultaion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConsultaion.Location = New System.Drawing.Point(363, 31)
        Me.ButtonConsultaion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonConsultaion.Name = "ButtonConsultaion"
        Me.ButtonConsultaion.Size = New System.Drawing.Size(300, 166)
        Me.ButtonConsultaion.TabIndex = 3
        Me.ButtonConsultaion.Text = "Consultation / Modification"
        Me.ButtonConsultaion.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 409)
        Me.Controls.Add(Me.ButtonConsultaion)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonConfiguration)
        Me.Controls.Add(Me.ButtonInscription)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonInscription As Button
    Friend WithEvents ButtonConfiguration As Button
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents ButtonConsultaion As Button
End Class
