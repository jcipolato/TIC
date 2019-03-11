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
        Me.btnInscription = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.btnConsultation = New System.Windows.Forms.Button()
        Me.ptUBDX = New System.Windows.Forms.PictureBox()
        Me.labTitreApplication = New System.Windows.Forms.Label()
        CType(Me.ptUBDX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInscription
        '
        Me.btnInscription.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnInscription.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnInscription.Location = New System.Drawing.Point(74, 195)
        Me.btnInscription.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInscription.Name = "btnInscription"
        Me.btnInscription.Size = New System.Drawing.Size(230, 105)
        Me.btnInscription.TabIndex = 0
        Me.btnInscription.Text = "Inscription"
        Me.btnInscription.UseVisualStyleBackColor = False
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ButtonQuitter.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ButtonQuitter.Location = New System.Drawing.Point(570, 343)
        Me.ButtonQuitter.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(93, 38)
        Me.ButtonQuitter.TabIndex = 2
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = False
        '
        'btnConsultation
        '
        Me.btnConsultation.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnConsultation.Font = New System.Drawing.Font("Verdana", 12.0!)
        Me.btnConsultation.Location = New System.Drawing.Point(385, 195)
        Me.btnConsultation.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultation.Name = "btnConsultation"
        Me.btnConsultation.Size = New System.Drawing.Size(230, 105)
        Me.btnConsultation.TabIndex = 1
        Me.btnConsultation.Text = "Consultation"
        Me.btnConsultation.UseVisualStyleBackColor = False
        '
        'ptUBDX
        '
        Me.ptUBDX.Image = Global.WindowsApplication1.My.Resources.Resources.ubdx_logo
        Me.ptUBDX.Location = New System.Drawing.Point(12, 12)
        Me.ptUBDX.Name = "ptUBDX"
        Me.ptUBDX.Size = New System.Drawing.Size(292, 107)
        Me.ptUBDX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptUBDX.TabIndex = 0
        Me.ptUBDX.TabStop = False
        '
        'labTitreApplication
        '
        Me.labTitreApplication.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTitreApplication.Location = New System.Drawing.Point(342, 49)
        Me.labTitreApplication.Name = "labTitreApplication"
        Me.labTitreApplication.Size = New System.Drawing.Size(321, 70)
        Me.labTitreApplication.TabIndex = 4
        Me.labTitreApplication.Text = "UBDXFORM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Centre de formation"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 409)
        Me.Controls.Add(Me.labTitreApplication)
        Me.Controls.Add(Me.ptUBDX)
        Me.Controls.Add(Me.btnConsultation)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.btnInscription)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Menu"
        Me.Text = "Menu"
        CType(Me.ptUBDX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnInscription As Button
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents btnConsultation As Button
    Friend WithEvents ptUBDX As PictureBox
    Friend WithEvents labTitreApplication As Label
End Class
