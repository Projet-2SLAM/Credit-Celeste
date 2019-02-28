<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboCidt = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodePostal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.txtNumTel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNomJeuneFille = New System.Windows.Forms.TextBox()
        Me.txtRevenuAnnuel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProfession = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDateNaissance = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmdCredit = New System.Windows.Forms.Button()
        Me.cmdBien = New System.Windows.Forms.Button()
        Me.cmdIntro = New System.Windows.Forms.Button()
        Me.cmdEnregistre = New System.Windows.Forms.Button()
        Me.gpbSituation = New System.Windows.Forms.GroupBox()
        Me.rdbOccGratuit = New System.Windows.Forms.RadioButton()
        Me.rdbLocat = New System.Windows.Forms.RadioButton()
        Me.rdbProprio = New System.Windows.Forms.RadioButton()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.gpbAutorisations = New System.Windows.Forms.GroupBox()
        Me.chkboxPrestat = New System.Windows.Forms.CheckBox()
        Me.chkboxCommerc = New System.Windows.Forms.CheckBox()
        Me.chkboxCorresp = New System.Windows.Forms.CheckBox()
        Me.gpbSituation.SuspendLayout()
        Me.gpbAutorisations.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(499, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Prénom"
        '
        'txtPrenom
        '
        Me.txtPrenom.Location = New System.Drawing.Point(470, 29)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(100, 20)
        Me.txtPrenom.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(370, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nom"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(337, 30)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Je m'appelle"
        '
        'cboCidt
        '
        Me.cboCidt.FormattingEnabled = True
        Me.cboCidt.Items.AddRange(New Object() {"Madame", "Mademoiselle", "Monsieur"})
        Me.cboCidt.Location = New System.Drawing.Point(180, 29)
        Me.cboCidt.Name = "cboCidt"
        Me.cboCidt.Size = New System.Drawing.Size(121, 21)
        Me.cboCidt.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(419, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Code Postal"
        '
        'txtCodePostal
        '
        Me.txtCodePostal.Location = New System.Drawing.Point(408, 98)
        Me.txtCodePostal.Name = "txtCodePostal"
        Me.txtCodePostal.Size = New System.Drawing.Size(100, 20)
        Me.txtCodePostal.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Ville"
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(128, 98)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(100, 20)
        Me.txtAdresse.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(151, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "J'habite"
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(265, 98)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(100, 20)
        Me.txtVille.TabIndex = 18
        '
        'txtNumTel
        '
        Me.txtNumTel.Location = New System.Drawing.Point(534, 98)
        Me.txtNumTel.Name = "txtNumTel"
        Me.txtNumTel.Size = New System.Drawing.Size(100, 20)
        Me.txtNumTel.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(538, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 15)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Num téléphone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(531, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 15)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Nom de jeune fille"
        '
        'txtNomJeuneFille
        '
        Me.txtNomJeuneFille.Location = New System.Drawing.Point(534, 162)
        Me.txtNomJeuneFille.Name = "txtNomJeuneFille"
        Me.txtNomJeuneFille.Size = New System.Drawing.Size(100, 20)
        Me.txtNomJeuneFille.TabIndex = 27
        '
        'txtRevenuAnnuel
        '
        Me.txtRevenuAnnuel.Location = New System.Drawing.Point(265, 162)
        Me.txtRevenuAnnuel.Name = "txtRevenuAnnuel"
        Me.txtRevenuAnnuel.Size = New System.Drawing.Size(100, 20)
        Me.txtRevenuAnnuel.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(426, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 15)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Profession"
        '
        'txtProfession
        '
        Me.txtProfession.Location = New System.Drawing.Point(408, 162)
        Me.txtProfession.Name = "txtProfession"
        Me.txtProfession.Size = New System.Drawing.Size(100, 20)
        Me.txtProfession.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(269, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 15)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Revenus annuel"
        '
        'txtDateNaissance
        '
        Me.txtDateNaissance.Location = New System.Drawing.Point(128, 162)
        Me.txtDateNaissance.Name = "txtDateNaissance"
        Me.txtDateNaissance.Size = New System.Drawing.Size(100, 20)
        Me.txtDateNaissance.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(132, 185)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 15)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Date Naissance"
        '
        'cmdCredit
        '
        Me.cmdCredit.Location = New System.Drawing.Point(534, 380)
        Me.cmdCredit.Name = "cmdCredit"
        Me.cmdCredit.Size = New System.Drawing.Size(75, 23)
        Me.cmdCredit.TabIndex = 30
        Me.cmdCredit.Text = "Crédit"
        Me.cmdCredit.UseVisualStyleBackColor = True
        '
        'cmdBien
        '
        Me.cmdBien.Location = New System.Drawing.Point(417, 380)
        Me.cmdBien.Name = "cmdBien"
        Me.cmdBien.Size = New System.Drawing.Size(75, 23)
        Me.cmdBien.TabIndex = 29
        Me.cmdBien.Text = "Voiture"
        Me.cmdBien.UseVisualStyleBackColor = True
        '
        'cmdIntro
        '
        Me.cmdIntro.Location = New System.Drawing.Point(290, 380)
        Me.cmdIntro.Name = "cmdIntro"
        Me.cmdIntro.Size = New System.Drawing.Size(81, 23)
        Me.cmdIntro.TabIndex = 31
        Me.cmdIntro.Text = "Introduction"
        Me.cmdIntro.UseVisualStyleBackColor = True
        '
        'cmdEnregistre
        '
        Me.cmdEnregistre.Location = New System.Drawing.Point(659, 380)
        Me.cmdEnregistre.Name = "cmdEnregistre"
        Me.cmdEnregistre.Size = New System.Drawing.Size(83, 23)
        Me.cmdEnregistre.TabIndex = 32
        Me.cmdEnregistre.Text = "J'enregistre"
        Me.cmdEnregistre.UseVisualStyleBackColor = True
        '
        'gpbSituation
        '
        Me.gpbSituation.Controls.Add(Me.rdbOccGratuit)
        Me.gpbSituation.Controls.Add(Me.rdbLocat)
        Me.gpbSituation.Controls.Add(Me.rdbProprio)
        Me.gpbSituation.Location = New System.Drawing.Point(588, 239)
        Me.gpbSituation.Name = "gpbSituation"
        Me.gpbSituation.Size = New System.Drawing.Size(200, 84)
        Me.gpbSituation.TabIndex = 33
        Me.gpbSituation.TabStop = False
        Me.gpbSituation.Text = "Situation patrimoniale"
        '
        'rdbOccGratuit
        '
        Me.rdbOccGratuit.AutoSize = True
        Me.rdbOccGratuit.Location = New System.Drawing.Point(7, 62)
        Me.rdbOccGratuit.Name = "rdbOccGratuit"
        Me.rdbOccGratuit.Size = New System.Drawing.Size(147, 19)
        Me.rdbOccGratuit.TabIndex = 2
        Me.rdbOccGratuit.Text = "Occupant à titre gratuit"
        Me.rdbOccGratuit.UseVisualStyleBackColor = True
        '
        'rdbLocat
        '
        Me.rdbLocat.AutoSize = True
        Me.rdbLocat.Location = New System.Drawing.Point(7, 43)
        Me.rdbLocat.Name = "rdbLocat"
        Me.rdbLocat.Size = New System.Drawing.Size(76, 19)
        Me.rdbLocat.TabIndex = 1
        Me.rdbLocat.Text = "Locataire"
        Me.rdbLocat.UseVisualStyleBackColor = True
        '
        'rdbProprio
        '
        Me.rdbProprio.AutoSize = True
        Me.rdbProprio.Location = New System.Drawing.Point(7, 24)
        Me.rdbProprio.Name = "rdbProprio"
        Me.rdbProprio.Size = New System.Drawing.Size(89, 19)
        Me.rdbProprio.TabIndex = 0
        Me.rdbProprio.Text = "Propriétaire"
        Me.rdbProprio.UseVisualStyleBackColor = True
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(90, 268)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(145, 20)
        Me.txtMail.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 269)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 15)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Adresse mail"
        '
        'gpbAutorisations
        '
        Me.gpbAutorisations.Controls.Add(Me.chkboxPrestat)
        Me.gpbAutorisations.Controls.Add(Me.chkboxCommerc)
        Me.gpbAutorisations.Controls.Add(Me.chkboxCorresp)
        Me.gpbAutorisations.Location = New System.Drawing.Point(263, 239)
        Me.gpbAutorisations.Name = "gpbAutorisations"
        Me.gpbAutorisations.Size = New System.Drawing.Size(255, 81)
        Me.gpbAutorisations.TabIndex = 36
        Me.gpbAutorisations.TabStop = False
        Me.gpbAutorisations.Text = "Autorisations"
        '
        'chkboxPrestat
        '
        Me.chkboxPrestat.AutoSize = True
        Me.chkboxPrestat.Location = New System.Drawing.Point(7, 58)
        Me.chkboxPrestat.Name = "chkboxPrestat"
        Me.chkboxPrestat.Size = New System.Drawing.Size(247, 19)
        Me.chkboxPrestat.TabIndex = 2
        Me.chkboxPrestat.Text = "J'accepte utilisation par prestat. externes"
        Me.chkboxPrestat.UseVisualStyleBackColor = True
        '
        'chkboxCommerc
        '
        Me.chkboxCommerc.AutoSize = True
        Me.chkboxCommerc.Location = New System.Drawing.Point(7, 39)
        Me.chkboxCommerc.Name = "chkboxCommerc"
        Me.chkboxCommerc.Size = New System.Drawing.Size(208, 19)
        Me.chkboxCommerc.TabIndex = 1
        Me.chkboxCommerc.Text = "J'accepte utilisation commerciale"
        Me.chkboxCommerc.UseVisualStyleBackColor = True
        '
        'chkboxCorresp
        '
        Me.chkboxCorresp.AutoSize = True
        Me.chkboxCorresp.Location = New System.Drawing.Point(7, 20)
        Me.chkboxCorresp.Name = "chkboxCorresp"
        Me.chkboxCorresp.Size = New System.Drawing.Size(225, 19)
        Me.chkboxCorresp.TabIndex = 0
        Me.chkboxCorresp.Text = "J'accepte utilisation correspondance"
        Me.chkboxCorresp.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkboxCorresp.UseVisualStyleBackColor = True
        '
        'Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gpbAutorisations)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.gpbSituation)
        Me.Controls.Add(Me.cmdEnregistre)
        Me.Controls.Add(Me.cmdIntro)
        Me.Controls.Add(Me.cmdCredit)
        Me.Controls.Add(Me.cmdBien)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtNomJeuneFille)
        Me.Controls.Add(Me.txtRevenuAnnuel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtProfession)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDateNaissance)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNumTel)
        Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodePostal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboCidt)
        Me.Name = "Client"
        Me.Text = "Client"
        Me.gpbSituation.ResumeLayout(False)
        Me.gpbSituation.PerformLayout()
        Me.gpbAutorisations.ResumeLayout(False)
        Me.gpbAutorisations.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboCidt As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodePostal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtVille As TextBox
    Friend WithEvents txtNumTel As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNomJeuneFille As TextBox
    Friend WithEvents txtRevenuAnnuel As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProfession As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDateNaissance As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmdCredit As Button
    Friend WithEvents cmdBien As Button
    Friend WithEvents cmdIntro As Button
    Friend WithEvents cmdEnregistre As Button
    Friend WithEvents gpbSituation As GroupBox
    Friend WithEvents rdbOccGratuit As RadioButton
    Friend WithEvents rdbLocat As RadioButton
    Friend WithEvents rdbProprio As RadioButton
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents gpbAutorisations As GroupBox
    Friend WithEvents chkboxPrestat As CheckBox
    Friend WithEvents chkboxCommerc As CheckBox
    Friend WithEvents chkboxCorresp As CheckBox
End Class
